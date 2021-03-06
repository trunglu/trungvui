using System;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Reflection;
using System.Data;
using System.Data.SqlClient;
using Basic;
using Basic.Function;
using System.Collections;
namespace GP8000.Report
{
	/// <summary>
	/// Summary description for Rehong_ATM.
	/// </summary>
	public class Rehong_DanhSachTangCa
	{
		Excel.Application oExcel;
		Excel.Worksheet oSheet, oTemplate;
		
		string strBoPhan ="", strDateTimeFrom="", strDateTimeTo="", strWorkHour="";		
		public Rehong_DanhSachTangCa(Excel.Application oExcel, NativeWindow xlMain, Hashtable hs)
		{
			try	
			{
				this.oExcel = oExcel;
				oSheet = (Excel.Worksheet)oExcel.Worksheets[1];
				oSheet.Activate();
				this.oTemplate = oExcel.Sheets["Template"] as Excel.Worksheet;								

				//param
				strBoPhan =hs["strBoPhan"].ToString();				
				strDateTimeFrom=hs["dateTimeFrom"].ToString();
				strDateTimeTo=hs["dateTimeTo"].ToString();	
				strWorkHour=hs["WorkHour"].ToString();

				BuildExcel();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		
		/// <summary>
		/// Build excel and export
		/// </summary>
		private void BuildExcel()
		{			
			string sql=string.Format("SELECT DISTINCT nhanvien.EMP_NM, nhanvien.EMP_ID "//////yuri
			+ "FROM FILB01A nhanvien "
			+ "join FILA02A bophan on nhanvien.DEP_ID = bophan.DEP_ID "			
			+ "left join FILC09A thaisan on nhanvien.EMP_ID = thaisan.EMP_ID "
			//+ "left join FILC04A phep on nhanvien.EMP_ID = phep.EMP_ID and phep.LEA_ID = '005' "
			+ "where bophan.DEP_NM = N'{0}'  AND VAC_BT != '1' "
			+ "and nhanvien.EMP_ID not in (select a.EMP_ID from FILC09A a where a.MAN_ST <= getdate() and a.MAN_ED >= getdate())"
			//+ "and (thaisan.EMP_ID is null or (thaisan.MAN_ST >= getdate() or thaisan.MAN_ED <= getdate())) " 
            //+ "and (phep.EMP_ID is null or (phep.STR_DT >= getdate() or phep.END_DT <= getdate())) "+
				, strBoPhan);	
			Func.RecordSet rsData = new Func.RecordSet(sql,PublicFunction.C_con);
			
			for(int x = rsData.rows -1; x >= 0; x--)
			{
				string sqlCheckPhep = string.Format("select * from FILC04A where emp_id = '{0}' and LEA_ID = '005' " +
					"and (STR_DT <= getdate() and END_DT >= getdate())",rsData.record(x,"EMP_ID"));
				Func.RecordSet rsCheckPhep = new Func.RecordSet(sqlCheckPhep,PublicFunction.C_con);
				if(rsCheckPhep.rows>0)
					rsData.ds.Tables[0].Rows.Remove(rsData.ds.Tables[0].Rows[x]);
			}
			


			//Build excel title
			BuildTitle("G","G",2,"Bộ Phận : ", string.Format("Bộ Phận : {0}", strBoPhan));			
			//BuildTitle("D","D",4,"                           Ngaøy [DD] 日,thaùng [MM] 月,naêm [YYYY] 年", 
			//	   string.Format("                           Ngaøy {0} 日,thaùng {1} 月,naêm {2} 年",DateTime.Now.Day,DateTime.Now.Month,DateTime.Now.Year));			

			if(rsData != null && rsData.rows>0)
			{
				//Build excel row
				int iRow = BuildExcelRow(rsData,true,"A","H",9);				

				//Draw border
				ReportExcel2.DrawBorders4(oSheet, 9, 1, iRow-1, 8);
				iRow++;

				//Build footer
				BuildFooter(iRow,1,2,"Phê duyệt/批准");
				BuildFooter(iRow,3,3,"Xưởng Trưởng/廠長");
				BuildFooter(iRow,5,5,"Chủ Quản/主管");
				BuildFooter(iRow,7,8,"Người Xin/申請人");
			}
		}
		
		/// <summary>
		/// Build footer
		/// </summary>
		/// <param name="row">row index</param>
		/// <param name="colFrom"> column index from</param>
		/// <param name="colTo">column index to</param>
		/// <param name="footerValue">footer value</param>
		private void BuildFooter(int row, int colFrom, int colTo, string footerValue)
		{
			Excel.Range rg = oSheet.get_Range(oSheet.Cells[row,colFrom],oSheet.Cells[row,colTo]);
			rg.Merge(Type.Missing);
			rg.Value2 = footerValue;
			rg.Cells.Font.Bold = true;
		}

		/// <summary>
		/// Replace excel value
		/// </summary>
		/// <param name="from">from cell</param>
		/// <param name="to">to cell</param>
		/// <param name="rowValue">row value</param>
		/// <param name="oldValue">old value</param>
		/// <param name="newValue">new value</param>
		private void BuildTitle(string from, string to, int rowValue, string oldValue, string newValue)
		{
			//Get title
			object objTitle = oSheet.get_Range(string.Format("{1}{0}:{2}{0}", rowValue, from, to), Missing.Value).get_Value(Excel.XlRangeValueDataType.xlRangeValueDefault);

			//Replace value
			objTitle = objTitle.ToString().Replace(oldValue,newValue);			

			//Set title
			oSheet.get_Range(string.Format("{1}{0}:{2}{0}", rowValue, from, to), Missing.Value).set_Value(Excel.XlRangeValueDataType.xlRangeValueDefault,objTitle);
		}

		/// <summary>
		/// Build excel row
		/// </summary>
		/// <param name="rsData">source</param>
		/// <param name="isSTT">have STT</param>
		/// <param name="from">from cell</param>
		/// <param name="to">to cell</param>
		/// <param name="fromRow">row add value</param>
		/// <returns></returns>
		private int BuildExcelRow(Func.RecordSet rsData, bool isSTT, string from, string to, int fromRow)
		{			
			int iSTT = 1;				
			int stt = isSTT == true ? 1 : 0;
				
			//Build excel row
			for(int x = 0; x < rsData.rows; x++)
			{
				//instant new row
				object[,] data = new object[1, rsData.cols+6];

				//get a row
				for(int y = 0; y < rsData.cols + stt;y++)				
					data[0,y] = rsData.record(x,y - stt);									

				//bind value STT
				if(isSTT)
					data[0,0] = iSTT;
				
				//set datefrom,dateto,workhour
				data[0,3] = strDateTimeFrom;
				data[0,4] = strDateTimeTo;
				data[0,5] = strWorkHour;
				data[0,6] = "";
				data[0,7] = "";

				//format cell
				//data[0,3] = Convert.ToDateTime(data[0,3]).ToString("dd/MM/yyyy");

				//bind value
				oSheet.get_Range(string.Format("{1}{0}:{2}{0}", fromRow,from,to), Missing.Value)
					.set_Value(Excel.XlRangeValueDataType.xlRangeValueDefault, data);

				fromRow++;
				iSTT++;	
			}
			return fromRow;
		}			
	}
}

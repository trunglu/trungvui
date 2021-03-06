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
	public class Rehong_ThongKeLuongNV
	{
		Excel.Application oExcel;
		Excel.Worksheet oSheet, oTemplate;
		
		string strDateChoose ="", strWhere ="";
		string strBoPhan="",strWorkHour="",strDateTimeTo="",strDateTimeFrom="";
		public Rehong_ThongKeLuongNV(Excel.Application oExcel, NativeWindow xlMain, Hashtable hs)
		{
			try	
			{
				this.oExcel = oExcel;
				oSheet = (Excel.Worksheet)oExcel.Worksheets[1];
				oSheet.Activate();
				this.oTemplate = oExcel.Sheets["Template"] as Excel.Worksheet;								

				//param
				strDateChoose =hs["strDateChoose"].ToString();				
				strWhere=hs["strWhere"].ToString();				
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
			strWhere = strWhere.IndexOf("WHERE") != -1 ? strWhere + " AND" : "WHERE" ;
			string ngayChon = Convert.ToDateTime(strDateChoose).ToString("yyyy-MM-dd");
			string ngayDauThangSauChon= Convert.ToDateTime(strDateChoose).AddMonths(1).ToString("yyyy-MM-dd");
			
			string sql=string.Format("select EMP_NM,EMP_N1, nhanvien.EMP_ID, INH_DT, POS_NM " +
									"from FILB01A nhanvien " +
									"join FILA02A bophan on nhanvien.DEP_ID = bophan.DEP_ID " +
									"join FILA07A chucvu on nhanvien.POS_ID = chucvu.POS_ID " +
									"join FILB01AC nghiviec on nghiviec.EMP_ID = nhanvien.EMP_ID " +
									"{0} (nhanvien.VAC_BT = 1 and nghiviec.VAC_DT > '{1}' and nghiviec.VAC_DT < '{2}')", strWhere,ngayChon,ngayDauThangSauChon);
	
			Func.RecordSet rsData = new Func.RecordSet(sql,PublicFunction.C_con);
			
			//Build excel title
			BuildTitle("A","A",3,"BÁO BIỂU THỐNG KÊ LƯƠNG / 工資統計表 [MM/YYYY]", string.Format("BÁO BIỂU THỐNG KÊ LƯƠNG / 工資統計表 {0}", strDateChoose));

			if(rsData != null && rsData.rows>0)
			{
				//Build excel row
				int iRow = BuildExcelRow(rsData,true,"A","T",7);
				
				//Format cells date
				Excel.Range rgDate = oSheet.get_Range(oSheet.Cells[7,5],oSheet.Cells[iRow-1,5]);		
				rgDate.NumberFormat = "mm/dd/yyyy";				
				
				//Format cells currency
				Excel.Range rgCurrency = oSheet.get_Range(oSheet.Cells[7,7],oSheet.Cells[iRow-1,20]);		
				rgCurrency.NumberFormat = "#,##0";				
				
				//Format total:
				Excel.Range rgTotal = oSheet.get_Range(oSheet.Cells[iRow,1],oSheet.Cells[iRow,6]);
				rgTotal.HorizontalAlignment = HorizontalAlignment.Right;
				rgTotal.VerticalAlignment = HorizontalAlignment.Right;

				//Draw border
				ReportExcel2.DrawBorders(oSheet, 7, 1, iRow, 20);

				//Build footer
				BuildFooter(iRow,1,6,"TOTAL:");
				

				BuildFooter(iRow,7,7,string.Format("=sum(G7:G{0})",iRow-1));
				BuildFooter(iRow,8,8,string.Format("=sum(H7:H{0})",iRow-1));
				BuildFooter(iRow,9,9,string.Format("=sum(I7:I{0})",iRow-1));
				BuildFooter(iRow,10,10,string.Format("=sum(J7:J{0})",iRow-1));
				BuildFooter(iRow,11,11,string.Format("=sum(K7:K{0})",iRow-1));
				BuildFooter(iRow,12,12,string.Format("=sum(L7:L{0})",iRow-1));
				BuildFooter(iRow,13,13,string.Format("=sum(M7:M{0})",iRow-1));
				BuildFooter(iRow,14,14,string.Format("=sum(N7:N{0})",iRow-1));
				BuildFooter(iRow,15,15,string.Format("=sum(O7:O{0})",iRow-1));
				BuildFooter(iRow,16,16,string.Format("=sum(P7:P{0})",iRow-1));
				BuildFooter(iRow,17,17,string.Format("=sum(Q7:Q{0})",iRow-1));
				BuildFooter(iRow,18,18,string.Format("=sum(R7:R{0})",iRow-1));
				BuildFooter(iRow,19,19,string.Format("=sum(S7:S{0})",iRow-1));
				BuildFooter(iRow,20,20,string.Format("=sum(T7:T{0})",iRow-1));

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
				object[,] data = new object[1, rsData.cols+15];				

				//get a row
				for(int y = 0; y < rsData.cols + stt;y++)				
					data[0,y] = rsData.record(x,y - stt);				
				
				string id = rsData.record(x,2);											
				
				//bind data min to row
				string sqlMin=string.Format("select muc_luongcoban,muc_trachnhiem,muc_kynang,muc_nhatro,muc_dochai,300000 as chuyencan from FILD03A " +
											"where SEQ_NO = (select Min(SEQ_NO) as seqMax from FILD03A where EMP_ID = '{0}') "+
											"and EMP_ID = '{0}'", id);	
				Func.RecordSet rsDataMin = new Func.RecordSet(sqlMin,PublicFunction.C_con);
				
				for(int y = 0; y < rsDataMin.cols;y++)				
					data[0,y+6] = rsDataMin.record(0,y);				

				//bind data max to row	
				string sqlMax=string.Format("select muc_luongcoban,muc_trachnhiem,muc_kynang,muc_nhatro,muc_dochai,300000 as chuyencan from FILD03A " +
					"where SEQ_NO = (select Max(SEQ_NO) as seqMax from FILD03A where EMP_ID = '{0}') "+
					"and EMP_ID = '{0}'", id);	
				Func.RecordSet rsDataMax = new Func.RecordSet(sqlMax,PublicFunction.C_con);
				
				for(int y = 0; y < rsDataMax.cols;y++)
					data[0,y + 13] = rsDataMax.record(0,y);	

				//bind value STT
				if(isSTT)
					data[0,0] = iSTT;						
				
				//sum value total hoc viec
				data[0,12] = Convert.ToInt32(data[0,6]) + Convert.ToInt32(data[0,7]) + Convert.ToInt32(data[0,8]) + Convert.ToInt32(data[0,9]) + Convert.ToInt32(data[0,10]) + Convert.ToInt32(data[0,11]);

				//sum value total hien tai
				data[0,19] = Convert.ToInt32(data[0,13]) + Convert.ToInt32(data[0,14]) + Convert.ToInt32(data[0,15]) + Convert.ToInt32(data[0,16]) + Convert.ToInt32(data[0,17]) + Convert.ToInt32(data[0,18]);
				//format cell
				//data[0,4] = Convert.ToDateTime(data[0,4]).ToString("dd/MM/yyyy");

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

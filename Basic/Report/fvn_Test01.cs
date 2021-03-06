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
	/// Summary description for fvn_Test01.
	/// </summary>
	public class fvn_Test01
	{
		Excel.Application oExcel;
		Excel.Worksheet oSheet, oTemplate;
		
		string dateFrom = "", dateTo = "";
		public fvn_Test01(Excel.Application oExcel, NativeWindow xlMain, Hashtable hs)
		{
			try	
			{
				this.oExcel = oExcel;
				oSheet = (Excel.Worksheet)oExcel.Worksheets[1];
				oSheet.Activate();
				this.oTemplate = oExcel.Sheets["Template"] as Excel.Worksheet;
				dateFrom = hs["dateFrom"].ToString();
				dateTo = hs["dateTo"].ToString();
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
			string sql = string.Format("select * from table_test where test_date >= '{0}' and test_date <= '{1}'", dateFrom, dateTo);
			Func.RecordSet rsData = new Func.RecordSet(sql,PublicFunction.C_con);
			
			//Build excel title
			BuildTitle("A","A",4,"D1", dateFrom);
			BuildTitle("A","A",4,"D2", dateTo);

			if(rsData != null && rsData.rows>0)
			{
				//Build excel row
				int iRow = BuildExcelRow(rsData,true,"A","D",8);				

				//Draw border
				ReportExcel2.DrawBorders4(oSheet, 8, 1, iRow-1, 4);
				iRow++;

				//Build footer
				BuildFooter(iRow,3,4,"Lập biểu 制表：");
				BuildFooter(iRow + 3,3,4,"Nguyễn Văn A");
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
				object[,] data = new object[1, rsData.cols+1];

				//get a row
				for(int y = 0; y < rsData.cols + stt;y++)				
					data[0,y] = rsData.record(x,y - stt);									

				//bind value STT
				if(isSTT)
					data[0,0] = iSTT;

				//format cell
				data[0,3] = Convert.ToDateTime(data[0,3]).ToString("dd/MM/yyyy");

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

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
using System.Drawing;
namespace GP8000.Report
{
	/// <summary>
	/// Summary description for Rehong_ATM.
	/// </summary>
	public class Rehong_TheNhanVien
	{
		Excel.Application oExcel;
		Excel.Worksheet oSheet, oTemplate, oSheet2;
		
		string strWhere ="";
		public Rehong_TheNhanVien(Excel.Application oExcel, NativeWindow xlMain, Hashtable hs)
		{
			try	
			{
				this.oExcel = oExcel;
				oSheet = (Excel.Worksheet)oExcel.Worksheets[1];
				oSheet2 = (Excel.Worksheet)oExcel.Worksheets[2];
				oSheet.Activate();
				oSheet2.Activate();
				this.oTemplate = oExcel.Sheets["Template"] as Excel.Worksheet;								

				//param
				strWhere = hs["strWhere"].ToString();				

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
			string sql=string.Format("SELECT nhanvien.EMP_NM, nhanvien.EMP_ID, bophan.DEP_NM, chucvu.POS_NM "
				+ "FROM FILB01A nhanvien "
				+ "join FILA02A bophan on nhanvien.DEP_ID = bophan.DEP_ID "
				+ "join FILA07A chucvu on nhanvien.POS_ID = chucvu.POS_ID "
				+ "{0} AND VAC_BT != 1", strWhere);
			Func.RecordSet rsData = new Func.RecordSet(sql,PublicFunction.C_con);		
			BuildCard(rsData);						
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

		private void BuildCard(Func.RecordSet rsData)
		{		
			try
			{				
				//oSheet2.get_Range("A1:B6",Missing.Value).Copy(Type.Missing);
				int rowSet1 = 2, colSet1 = 2, rowSet2 = 7, colSet2 = 3;
				for(int x = 1; x < rsData.rows + 1; x++)
				{	
					//copy and paste
					oSheet2.get_Range("A1:B6",Missing.Value).Copy(oSheet.get_Range(oSheet.Cells[rowSet1,colSet1], oSheet.Cells[rowSet2,colSet2]));	
		
					//set value to card
					BuildFooter(rowSet1+2,colSet1,colSet1,rsData.record(x-1,0));// ten nv
					BuildFooter(rowSet1+3,colSet2,colSet2,rsData.record(x-1,1));// ma nv
					BuildFooter(rowSet1+4,colSet2,colSet2,rsData.record(x-1,2));// bo phan
					BuildFooter(rowSet1+5,colSet2,colSet2,rsData.record(x-1,3));// chuc vu
				
					//set image
					object bimap = ImageFunction.LoadImageObjectFromSQL(string.Format("Select PIC_DR from FILB01AB where EMP_ID=N'{0}'",rsData.record(x-1,1)));
				
					if(bimap != null)
					{
						Bitmap bi=(Bitmap)bimap;
						Excel.Range r = oSheet.get_Range(oSheet.Cells[rowSet1 +1,colSet2],oSheet.Cells[rowSet1 +1,colSet2]);									
						System.Windows.Forms.Clipboard.SetDataObject(bi, false);												
						oSheet.Paste(r,bi);
																	
						for(int y = 1; y < oSheet.Shapes.Count + 1;y++)
						{							
							oSheet.Shapes.Item(y).LockAspectRatio =  Microsoft.Office.Core.MsoTriState.msoFalse;
							
							oSheet.Shapes.Item(y).Width = 80;
							oSheet.Shapes.Item(y).Height = 103;						
						}
					}										

					rowSet1 = rowSet1;
					colSet1 += 3;
					rowSet2 = rowSet2;
					colSet2 += 3;				
				
					if(x%3 == 0) // x chia het cho 3
					{				
						rowSet1+= 7; //xuong dong` 1 card
						colSet1 = 2;
						rowSet2 += 7;
						colSet2 = 3;					
					}	
		
					if(x%9 == 0) // x chia het cho 9 => break page
					{
						rowSet1 += 6;
						rowSet2 += 6;
					}
			
					//change row height
					oSheet.get_Range(oSheet.Cells[rowSet1,colSet1],oSheet.Cells[rowSet1,colSet1]).RowHeight = 43.5;
					oSheet.get_Range(oSheet.Cells[rowSet1+1,colSet1],oSheet.Cells[rowSet1+1,colSet1]).RowHeight = 42;
					oSheet.get_Range(oSheet.Cells[rowSet1+2,colSet1],oSheet.Cells[rowSet1+2,colSet1]).RowHeight = 61.5;
					oSheet.get_Range(oSheet.Cells[rowSet1+3,colSet1],oSheet.Cells[rowSet1+3,colSet1]).RowHeight = 33;
					oSheet.get_Range(oSheet.Cells[rowSet1+4,colSet1],oSheet.Cells[rowSet1+4,colSet1]).RowHeight = 33;
					oSheet.get_Range(oSheet.Cells[rowSet1+5,colSet1],oSheet.Cells[rowSet1+5,colSet1]).RowHeight = 33;										
				}		
				
				oSheet2.Application.DisplayAlerts = false;
				oSheet2.Delete();					
				//oSheet2.Application.DisplayAlerts = true;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
	}
}

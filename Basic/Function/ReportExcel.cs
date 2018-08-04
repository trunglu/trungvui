using System;
using System.Reflection;
using C1.Win.C1FlexGrid;
using System.Collections;

namespace Basic.Function
{
	/// <summary>
	/// Summary description for ReportExcel.
	/// </summary>
	public class ReportExcel
	{
		public ReportExcel()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		public static void SetProperty(Microsoft.Office.Interop.Excel._Workbook oBook, string Item, string Value)
		{
			object oCustomProps = oBook.CustomDocumentProperties;
			object oBuiltInPro = oBook.BuiltinDocumentProperties;
			Type typeCustomProps = oBuiltInPro.GetType();
			try
			{
				typeCustomProps.InvokeMember("Item", BindingFlags.Default | BindingFlags.SetProperty, null, oCustomProps, new object[]{Item, Value});
			}
			catch
			{
			
			}
		}

		public static void RunMacro(object oApp, object []oRunArgs)
		{
			oApp.GetType().InvokeMember("Run", BindingFlags.Default | BindingFlags.InvokeMethod, null, oApp, oRunArgs);
		}

//		public void PrintExcel(string FileName, string ConnectionString, string coTitle, string sFontName, string Lang, string where,
//			string where1, string where2, string where3, string where4, string where5, string where6, string where7, string where8,
//			string where9, string where10, string User)
//		{
//			object oMissing = Missing.Value;
//			Excel.Application oExcel = new Excel.ApplicationClass();
//			Excel.Workbooks oBooks = oExcel.Workbooks;
//			Excel._Workbook oBook = null;
//
//			System.Globalization.CultureInfo oldCI = System.Threading.Thread.CurrentThread.CurrentCulture;
//			System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
//			try
//			{
//				oBook = oBooks.Open(FileName, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing,
//					oMissing, oMissing, oMissing, oMissing, oMissing);
//				oExcel.Visible = true;
//
//				//Cap nhat properties
//				SetProperty(oBook, "ConnectionString", ConnectionString);
//				SetProperty(oBook, "CoTitle", coTitle);
//				SetProperty(oBook, "sFontName", sFontName);
//				SetProperty(oBook, "Lang", Lang);
//				SetProperty(oBook, "where", where);
//				SetProperty(oBook, "where1", where1);
//				SetProperty(oBook, "where2", where2);
//				SetProperty(oBook, "where3", where3);
//				SetProperty(oBook, "where4", where4);
//				SetProperty(oBook, "where5", where5);
//				SetProperty(oBook, "where6", where6);
//				SetProperty(oBook, "where7", where7);
//				SetProperty(oBook, "where8", where8);
//				SetProperty(oBook, "where9", where9);
//				SetProperty(oBook, "where10", where10);
//				SetProperty(oBook, "User", User);
//
//				try
//				{
//					RunMacro(oExcel, new object[]{"CreatReport"});
//				}
//				catch{}
//			}
//			catch(Exception ex)
//			{
//				System.Windows.Forms.MessageBox.Show(ex.Message, "Error!");
//			}
//			finally
//			{
//				System.Threading.Thread.CurrentThread.CurrentCulture = oldCI;
//				System.Runtime.InteropServices.Marshal.ReleaseComObject(oBooks);
//				System.Runtime.InteropServices.Marshal.ReleaseComObject(oExcel);
//				GC.Collect();
//			}
//		}
		public static void PrintExcel(string FileName, string ConnectionString, string coTitle, string sFontName, string Lang, string where,
			string where1, string where2, string where3, string where4, string where5, string where6, string where7, string where8,
			string where9, string where10, string where11,string where12,string where13, string User)
		{
			object oMissing = Missing.Value;
			Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.ApplicationClass();
			Microsoft.Office.Interop.Excel.Workbooks oBooks = oExcel.Workbooks;
			Microsoft.Office.Interop.Excel._Workbook oBook = null;

			System.Globalization.CultureInfo oldCI = System.Threading.Thread.CurrentThread.CurrentCulture;
			System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
			try
			{
				oBook = oBooks.Open(FileName, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing,
					oMissing, oMissing, oMissing, oMissing, oMissing);
				oExcel.Visible = true;

				//Cap nhat properties
				SetProperty(oBook, "ConnectionString", ConnectionString);
				SetProperty(oBook, "CoTitle", coTitle);
				SetProperty(oBook, "sFontName", sFontName);
				SetProperty(oBook, "Lang", Lang);
				SetProperty(oBook, "where", where);
				SetProperty(oBook, "where1", where1);
				SetProperty(oBook, "where2", where2);
				SetProperty(oBook, "where3", where3);
				SetProperty(oBook, "where4", where4);
				SetProperty(oBook, "where5", where5);
				SetProperty(oBook, "where6", where6);
				SetProperty(oBook, "where7", where7);
				SetProperty(oBook, "where8", where8);
				SetProperty(oBook, "where9", where9);
				SetProperty(oBook, "where10", where10);
				SetProperty(oBook, "where11", where11);
				SetProperty(oBook, "where12", where12);
				SetProperty(oBook, "where13", where13);
				SetProperty(oBook, "User", User);

				try
				{
					RunMacro(oExcel, new object[]{"CreatReport"});
				}
				catch{}
			}
			catch(Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message, "Error!");
			}
			finally
			{
				System.Threading.Thread.CurrentThread.CurrentCulture = oldCI;
				System.Runtime.InteropServices.Marshal.ReleaseComObject(oBooks);
				System.Runtime.InteropServices.Marshal.ReleaseComObject(oExcel);
				GC.Collect();
			}
		}
		public static void ExportToExcel_FromVS(C1FlexGrid vs, ArrayList arColsVisible)
		{
			object oMissing = System.Reflection.Missing.Value;
			Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.ApplicationClass();
			Microsoft.Office.Interop.Excel.Workbooks oBooks = oExcel.Workbooks;
			Microsoft.Office.Interop.Excel._Workbook oBook = null;
			
			System.Globalization.CultureInfo oldCI = System.Threading.Thread.CurrentThread.CurrentCulture;
			System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

			oBook = oBooks.Add(oMissing);
			Microsoft.Office.Interop.Excel.Worksheet oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oBook.Worksheets[1];
			oExcel.Visible = true;

			try
			{
				// Dinh dang cot
				int iCol=1;
				for (int i=1; i<vs.Cols.Count; i++)
					if (arColsVisible[i]+"" == "True")
					{
						Microsoft.Office.Interop.Excel.Range rg = oSheet.get_Range(GetExcelColumnName(iCol) + ":" + GetExcelColumnName(iCol), Missing.Value);
						switch(vs.Cols[i].DataType.Name)
						{
							case "Double":
							case "Decimal":
								rg.EntireColumn.NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* \"-\"??_);_(@_)";
								break;
							case "Int16":
							case "Int32":
							case "Int64":
							case "Single":
								rg.EntireColumn.NumberFormat = "_(* #,##0_);_(* (#,##0);_(* \"-\"_);_(@_)";
								break;
							case "Boolean":
								break;
							case "DateTime":
								break;
							case "String":
								rg.EntireColumn.NumberFormat = "@";
								break;
							default:
								break;
						}
						iCol ++;
					}
				oExcel.ScreenUpdating = false;
				for(int i=0; i<vs.Rows.Count; i++)
				{
					iCol = 1;
					for(int j=0; j<vs.Cols.Count; j++)
						if (arColsVisible[j]+"" == "True")
						{
							oSheet.Cells[i+2,iCol] = vs.Rows[i][j];
							iCol ++;
						}
				}
				oSheet.Columns.AutoFit();
			}
			catch(Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message, "Error!");
			}
			finally
			{
				oExcel.ScreenUpdating = true;
				System.Threading.Thread.CurrentThread.CurrentCulture = oldCI;
				System.Runtime.InteropServices.Marshal.ReleaseComObject(oBooks);
				System.Runtime.InteropServices.Marshal.ReleaseComObject(oExcel);
				GC.Collect();
			}
		}
		private static string GetExcelColumnName(int colIndex)
		{
			int dividend = colIndex;
			string colName = String.Empty;
			int modulo;

			while (dividend > 0)
			{
				modulo = (dividend - 1) % 26;
				colName = Convert.ToChar(65 + modulo).ToString() + colName;
				dividend = (int)((dividend - modulo) / 26);
			} 

			return colName;
		}
	}

}

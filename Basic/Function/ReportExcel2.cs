using System;
using System.Reflection;
using C1.Win.C1FlexGrid;
using System.Collections;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Basic.Function
{
	/// <summary>
	/// Summary description for ReportExcel.
	/// </summary>
	public class ReportExcel2
	{
		public ReportExcel2()
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
			string where9, string where10, string where11, string User)
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

		public static void TemplateToExcel(string fileName)
		{
			//Khai bao Excel
			object oMissing = System.Reflection.Missing.Value;
			Excel.Application oExcel = new Excel.ApplicationClass();
			Excel.Workbooks oBooks = oExcel.Workbooks;

			NativeWindow xlMain = new NativeWindow();
			xlMain.AssignHandle(new IntPtr(oExcel.Hwnd));
			IntPtr xlPtr = new IntPtr(oExcel.Hwnd);
                
			System.Globalization.CultureInfo oldCI = System.Threading.Thread.CurrentThread.CurrentCulture;
			System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

			try
			{
				oBooks.Open(Application.StartupPath + "\\ReportsVBA\\" + fileName, oMissing, oMissing, oMissing, oMissing, oMissing,
					oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing);
				oExcel.Visible = true;

				string type = fileName;
				if (fileName.IndexOf(".") > 0)
					type = fileName.Substring(0, fileName.IndexOf("."));
				type = "GP8000.Report." + type;
				//Khai báo Instance
				Activator.CreateInstance(Type.GetType(type), new object[]{ oExcel, xlMain});
				MessageBox.Show(new WindowWrapper(xlPtr), "Finish", "Excel");
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message, "Excel");
			}
			finally
			{
				oExcel.StatusBar = "Finish!";
				//oExcel.Application.Interactive = true;
				System.Threading.Thread.CurrentThread.CurrentCulture = oldCI;
				System.Runtime.InteropServices.Marshal.ReleaseComObject(oBooks);
				System.Runtime.InteropServices.Marshal.ReleaseComObject(oExcel);
				GC.Collect();
			}
		}

		public static void TemplateToExcel(string fileName, Hashtable hash)
		{
			//Khai bao Excel
			object oMissing = System.Reflection.Missing.Value;
			Excel.Application oExcel = new Excel.ApplicationClass();
			Excel.Workbooks oBooks = oExcel.Workbooks;

			NativeWindow xlMain = new NativeWindow();
			xlMain.AssignHandle(new IntPtr(oExcel.Hwnd));
			IntPtr xlPtr = new IntPtr(oExcel.Hwnd);
                
			System.Globalization.CultureInfo oldCI = System.Threading.Thread.CurrentThread.CurrentCulture;
			System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

			try
			{
				oBooks.Open(Application.StartupPath + "\\ReportsVBA\\" + fileName, oMissing, oMissing, oMissing, oMissing, oMissing,
					oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing);
				oExcel.Visible = true;

				string type = fileName;
				if (fileName.IndexOf(".") > 0)
					type = fileName.Substring(0, fileName.IndexOf("."));
				type = "GP8000.Report." + type;
				//Khai báo Instance
				Activator.CreateInstance(Type.GetType(type), new object[]{ oExcel, xlMain, hash});
				MessageBox.Show(new WindowWrapper(xlPtr), "Finish", "Excel");
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message, "Excel");
			}
			finally
			{
				oExcel.StatusBar = "Finish!";
				//oExcel.Application.Interactive = true;
				System.Threading.Thread.CurrentThread.CurrentCulture = oldCI;
				System.Runtime.InteropServices.Marshal.ReleaseComObject(oBooks);
				System.Runtime.InteropServices.Marshal.ReleaseComObject(oExcel);
				GC.Collect();
			}
		}


		private static string GetColumnName(int colIndex)
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

		/// <summary>
		/// Lấy giá trị của 1 Cell
		/// </summary>
		/// <param name="oSheet">Sheet</param>
		/// <param name="row">Dòng</param>
		/// <param name="col">Cột</param>
		/// <returns></returns>
		public static object GetColumnValue(Excel.Worksheet oSheet, int row, int col)
		{
			return GetColumnValue(oSheet, row, GetColumnName(col));
		}
		/// <summary>
		/// Lấy giá trị của 1 Cell
		/// </summary>
		/// <param name="oSheet">Sheet</param>
		/// <param name="row">Dòng</param>
		/// <param name="col">Tên cột</param>
		/// <returns></returns>
		public static object GetColumnValue(Excel.Worksheet oSheet, int row, string col)
		{
			Excel.Range rg = oSheet.get_Range(col + row + ":" + col + row, System.Reflection.Missing.Value);

			return rg.get_Value(System.Reflection.Missing.Value);
		}

		public static void DrawBorders(Excel.Worksheet oSheet, int row1, int col1, int row2, int col2)
		{
			Excel.Range rg = oSheet.get_Range(GetColumnName(col1) + row1, GetColumnName(col2) + row2);
			DrawBorders(rg, Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin);
		}

		//viền đậm
		public static void DrawBorders2(Excel.Worksheet oSheet, int row1, int col1, int row2, int col2)
		{
			Excel.Range rg = oSheet.get_Range(GetColumnName(col1) + row1, GetColumnName(col2) + row2);
			DrawBorders(rg, Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium);
		}

		//viền cắt đứt
		public static void DrawBorders3(Excel.Worksheet oSheet, int row1, int col1, int row2, int col2)
		{
			Excel.Range rg = oSheet.get_Range(GetColumnName(col1) + row1, GetColumnName(col2) + row2);
			DrawBorders(rg, Excel.XlLineStyle.xlDash, Excel.XlBorderWeight.xlThin);
		}

		public static void DrawBorders4(Excel.Worksheet oSheet, int row1, int col1, int row2, int col2)
		{
			Excel.Range rg = oSheet.get_Range(GetColumnName(col1) + row1, GetColumnName(col2) + row2);
			DrawBorders(rg, Excel.XlLineStyle.xlDot, Excel.XlBorderWeight.xlThin);
		}

		public static void DrawBorders(Excel.Worksheet oSheet, int row1, int col1, int row2, int col2, Excel.XlLineStyle line, Excel.XlBorderWeight weight)
		{
			Excel.Range rg = oSheet.get_Range(GetColumnName(col1) + row1, GetColumnName(col2) + row2);
			DrawBorders(rg, line, weight);
		}

		public static void DrawBorders(Microsoft.Office.Interop.Excel.Range rg)
		{
			DrawBorders(rg, Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin);
		}

		public static void DrawBorders(Microsoft.Office.Interop.Excel.Range rg, Excel.XlLineStyle line, Excel.XlBorderWeight weight)
		{
			try
			{
				rg.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = line;
				rg.Borders[Excel.XlBordersIndex.xlEdgeLeft].Weight = weight;

				rg.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = line;
				rg.Borders[Excel.XlBordersIndex.xlEdgeTop].Weight = weight;

				rg.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = line;
				rg.Borders[Excel.XlBordersIndex.xlEdgeBottom].Weight = weight;

				rg.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = line;
				rg.Borders[Excel.XlBordersIndex.xlEdgeRight].Weight = weight;

				rg.Borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle = line;
				rg.Borders[Excel.XlBordersIndex.xlInsideVertical].Weight = weight;

				rg.Borders[Excel.XlBordersIndex.xlInsideHorizontal].LineStyle = line;
				rg.Borders[Excel.XlBordersIndex.xlInsideHorizontal].Weight = weight;
			}
			catch{}
		}

		public static void DrawBorders(Excel.Worksheet oSheet, int row1, int col1, int row2, int col2, Excel.XlLineStyle lef_l, Excel.XlBorderWeight lef_w,
			Excel.XlLineStyle top_l, Excel.XlBorderWeight top_w, Excel.XlLineStyle rig_l, Excel.XlBorderWeight rig_w,
			Excel.XlLineStyle bot_l, Excel.XlBorderWeight bot_w, Excel.XlLineStyle ver_l, Excel.XlBorderWeight ver_w,
			Excel.XlLineStyle hor_l, Excel.XlBorderWeight hor_w)
		{
			Excel.Range rg = oSheet.get_Range(GetColumnName(col1) + row1, GetColumnName(col2) + row2);

			rg.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = lef_l;
			if (lef_l != Excel.XlLineStyle.xlLineStyleNone)
				rg.Borders[Excel.XlBordersIndex.xlEdgeLeft].Weight = lef_w;

			rg.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = top_l;
			if (top_l != Excel.XlLineStyle.xlLineStyleNone)
				rg.Borders[Excel.XlBordersIndex.xlEdgeTop].Weight = top_w;

			rg.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = bot_l;
			if (bot_l != Excel.XlLineStyle.xlLineStyleNone)
				rg.Borders[Excel.XlBordersIndex.xlEdgeBottom].Weight = bot_w;

			rg.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = rig_l;
			if (rig_l != Excel.XlLineStyle.xlLineStyleNone)
				rg.Borders[Excel.XlBordersIndex.xlEdgeRight].Weight = rig_w;

			rg.Borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle = ver_l;
			if (ver_l != Excel.XlLineStyle.xlLineStyleNone)
				rg.Borders[Excel.XlBordersIndex.xlInsideVertical].Weight = ver_w;

			rg.Borders[Excel.XlBordersIndex.xlInsideHorizontal].LineStyle = hor_l;
			if (hor_l != Excel.XlLineStyle.xlLineStyleNone)
				rg.Borders[Excel.XlBordersIndex.xlInsideHorizontal].Weight = hor_w;
		}
	}
	public class WindowWrapper : System.Windows.Forms.IWin32Window
	{
		public WindowWrapper(IntPtr handle)
		{
			_hwnd = handle;
		}

		public IntPtr Handle
		{
			get { return _hwnd; }
		}

		private IntPtr _hwnd;
	}
}

using System;
using System.Windows;
using System.Windows.Forms;
using C1.C1Excel;
using System.Drawing;

namespace Basic.Function
{
	/// <summary>
	/// Summary description for Fun.
	/// </summary>
	public class FormatExcel
	{
		
		public FormatExcel()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		public static void InitCB_Date(ComboBox cb)
		{
			cb.Items.Add("=");
			cb.Items.Add("<");
			cb.Items.Add("<=");
			cb.Items.Add(">=");
			cb.Items.Add(">");
			cb.Items.Add("Between");
			cb.Items.Add("No Value");
			cb.DropDownStyle=ComboBoxStyle.DropDownList;
			cb.SelectedIndex =6;
		}

		public static void InitCB_None(ComboBox cb)
		{
			cb.Items.Add("=");			
			cb.Items.Add("No Value");
			cb.DropDownStyle=ComboBoxStyle.DropDownList;
			cb.SelectedIndex =1;
		}

		public static void InitCB_String(ComboBox cb)
		{
			cb.Items.Add("=");
			cb.Items.Add("like");						
			cb.Items.Add("No Value");
			cb.DropDownStyle=ComboBoxStyle.DropDownList;
			cb.SelectedIndex =2;
		}

		public static void InitCB_Number(ComboBox cb)
		{
			cb.Items.Add("=");
			cb.Items.Add("<");
			cb.Items.Add("<=");
			cb.Items.Add(">=");
			cb.Items.Add(">");
			cb.Items.Add("Between");
			cb.Items.Add("No Value");
			cb.DropDownStyle=ComboBoxStyle.DropDownList;
			cb.SelectedIndex =6;
		}

		public static void Init_Excel(XLSheet sheet)
		{
			sheet.PrintSettings.MarginBottom=0.5;
			sheet.PrintSettings.MarginFooter=0.5;
			sheet.PrintSettings.MarginHeader=0.5;
			sheet.PrintSettings.MarginLeft=0.1;
			sheet.PrintSettings.MarginRight=0.1;
			sheet.PrintSettings.MarginTop=0.5;
			sheet.PrintSettings.PaperKind=System.Drawing.Printing.PaperKind.A4;			
		}

		

		public static XLStyle Get_StyleTilte(C1XLBook book)
		{
			XLStyle style    = new XLStyle(book);
			style.Font       = new Font("Tahoma", 14, FontStyle.Bold);			
			style.ForeColor  = Color.Black;
			style.AlignVert = XLAlignVertEnum.Center;
			style.AlignHorz = XLAlignHorzEnum.Center;
			return style;
		}

		public static XLStyle Get_StyleTilteBorderBotton(C1XLBook book)
		{
			XLStyle style    = new XLStyle(book);
			style.Font       = new Font("Tahoma", 14, FontStyle.Regular);	
			style.BorderBottom = XLLineStyleEnum.Thin;
			style.ForeColor  = Color.Black;
			style.AlignVert = XLAlignVertEnum.Center;
			style.AlignHorz = XLAlignHorzEnum.Center;
		
			return style;
		}
		public static XLStyle Get_StyleCaption(C1XLBook book)
		{
			return Get_StyleCaption(book,false);
		}
		public static XLStyle Get_StyleCaption(C1XLBook book,Boolean WrapText)
		{
			XLStyle style    = new XLStyle(book);
			style.Font       = new Font("Tahoma", 11, FontStyle.Bold);
			style.BorderBottom = XLLineStyleEnum.Thin;
			style.BorderLeft = XLLineStyleEnum.Thin;
			style.BorderRight = XLLineStyleEnum.Thin;
			style.BorderTop = XLLineStyleEnum.Thin;
			style.ForeColor  = Color.Black;
			style.AlignVert = XLAlignVertEnum.Center;
			style.AlignHorz = XLAlignHorzEnum.Center;
			style.WordWrap=WrapText;
			return style;
		}

		public static XLStyle Get_StyleStringNone(C1XLBook book)
		{
			XLStyle style    = new XLStyle(book);
			style.Font       = new Font("Tahoma", 10, FontStyle.Regular);			
			style.AlignVert = XLAlignVertEnum.Center;
			style.AlignHorz = XLAlignHorzEnum.Left;
			return style;
		}

		public static XLStyle Get_StyleStringNoneWordWrap(C1XLBook book)
		{
			XLStyle style    = new XLStyle(book);
			style.Font       = new Font("Tahoma", 10, FontStyle.Regular);			
			style.AlignVert = XLAlignVertEnum.Top;
			style.AlignHorz = XLAlignHorzEnum.Left;
			style.WordWrap = true;
			return style;
		}

		public static XLStyle Get_StyleString(C1XLBook book)
		{
			XLStyle style    = new XLStyle(book);
			style.Font       = new Font("Tahoma", 10, FontStyle.Regular);
			style.BorderBottom = XLLineStyleEnum.Thin;
			style.BorderLeft = XLLineStyleEnum.Thin;
			style.BorderRight = XLLineStyleEnum.Thin;
			style.BorderTop = XLLineStyleEnum.Thin;
			style.ForeColor  = Color.Black;
			style.AlignVert = XLAlignVertEnum.Center;
			style.AlignHorz = XLAlignHorzEnum.Left;			
			return style;
		}
		public static XLStyle Get_StyleString(C1XLBook book,Boolean WordWrap)
		{
			XLStyle style    = new XLStyle(book);
			style.Font       = new Font("Tahoma", 10, FontStyle.Regular);
			style.BorderBottom = XLLineStyleEnum.Thin;
			style.BorderLeft = XLLineStyleEnum.Thin;
			style.BorderRight = XLLineStyleEnum.Thin;
			style.BorderTop = XLLineStyleEnum.Thin;
			style.ForeColor  = Color.Black;
			style.AlignVert = XLAlignVertEnum.Center;
			style.AlignHorz = XLAlignHorzEnum.Left;
			style.WordWrap = WordWrap;
			return style;
		}

		public static XLStyle Get_Style(C1XLBook book,float FontSize,Boolean Bold
			,C1.C1Excel.XLAlignVertEnum AlignVert,C1.C1Excel.XLAlignHorzEnum  AlignHorz
			,Boolean WrapText,Boolean  Border,string format)
		{		
			XLStyle style    = new XLStyle(book);			
			if (Bold)
				style.Font       = new Font("Tahoma", FontSize, FontStyle.Bold);			
			else
				style.Font       = new Font("Tahoma", FontSize, FontStyle.Regular);	
			style.ForeColor  = Color.Black;

			style.AlignVert = AlignVert;
			style.AlignHorz = AlignHorz;
			style.WordWrap = WrapText;
			
			if (Border)
			{
				style.BorderBottom = XLLineStyleEnum.Thin;
				style.BorderLeft = XLLineStyleEnum.Thin;
				style.BorderRight = XLLineStyleEnum.Thin;
				style.BorderTop = XLLineStyleEnum.Thin;
			}
			if (format!="" && format!=null)
				style.Format = format;
			return style;		
		}

		public static XLStyle Get_Style(C1XLBook book,float FontSize,FontStyle fontstyle
			,C1.C1Excel.XLAlignVertEnum AlignVert,C1.C1Excel.XLAlignHorzEnum  AlignHorz
			,Boolean WrapText,Boolean  Border,string format)
		{		
			XLStyle style    = new XLStyle(book);			
			style.Font       = new Font("Tahoma", FontSize, fontstyle);						
			style.ForeColor  = Color.Black;		

			style.AlignVert = AlignVert;
			style.AlignHorz = AlignHorz;
			style.WordWrap = WrapText;
			if (Border)
			{
				style.BorderBottom = XLLineStyleEnum.Thin;
				style.BorderLeft = XLLineStyleEnum.Thin;
				style.BorderRight = XLLineStyleEnum.Thin;
				style.BorderTop = XLLineStyleEnum.Thin;
			}
			if (format!="" && format!=null)
				style.Format = format;
			return style;		
		}
		
		public static XLStyle Get_StyleStringNoneAlignRight(C1XLBook book)
		{
			XLStyle style    = new XLStyle(book);
			style.Font       = new Font("Tahoma", 10, FontStyle.Regular);			
			style.AlignVert = XLAlignVertEnum.Center;
			style.AlignHorz = XLAlignHorzEnum.Right;
			return style;
		}


		public static XLStyle Get_StyleCaptionR(C1XLBook book)
		{
			XLStyle style    = new XLStyle(book);
			style.Font       = new Font("Tahoma", 11, FontStyle.Bold);
			style.BorderBottom = XLLineStyleEnum.Thin;
			style.BorderLeft = XLLineStyleEnum.Thin;
			style.BorderRight = XLLineStyleEnum.Thin;
			style.BorderTop = XLLineStyleEnum.Thin;
			style.ForeColor  = Color.Black;
			style.AlignVert = XLAlignVertEnum.Center;
			style.AlignHorz = XLAlignHorzEnum.Right;
			return style;
		}

		public static XLStyle Get_StyleNumber(C1XLBook book,int size)
		{
			XLStyle style    = new XLStyle(book);
			style.Font       = new Font("Tahoma", size, FontStyle.Regular);
			style.BorderBottom = XLLineStyleEnum.Thin;
			style.BorderLeft = XLLineStyleEnum.Thin;
			style.BorderRight = XLLineStyleEnum.Thin;
			style.BorderTop = XLLineStyleEnum.Thin;
			style.ForeColor  = Color.Black;
			style.Format = "#,###,###";
			style.AlignVert = XLAlignVertEnum.Center ;
			style.AlignHorz = XLAlignHorzEnum.Right;
			return style;
		}
		public static XLStyle Get_StyleNumber(C1XLBook book)
		{
			return Get_StyleNumber(book,10);
		}
		public static XLStyle Get_StyleDate(C1XLBook book)
		{
			XLStyle style    = new XLStyle(book);
			style.Font       = new Font("Tahoma", 10, FontStyle.Regular);
			style.BorderBottom = XLLineStyleEnum.Thin;
			style.BorderLeft = XLLineStyleEnum.Thin;
			style.BorderRight = XLLineStyleEnum.Thin;
			style.BorderTop = XLLineStyleEnum.Thin;
			style.ForeColor  = Color.Black;
			style.Format = "yyyy/MM/dd";
			style.AlignVert = XLAlignVertEnum.Center;
			style.AlignHorz = XLAlignHorzEnum.Center;
			return style;
		}

		public static XLStyle Get_StyleLongDate(C1XLBook book)
		{
			XLStyle style    = new XLStyle(book);
			style.Font       = new Font("Tahoma", 10, FontStyle.Regular);
			style.BorderBottom = XLLineStyleEnum.Thin;
			style.BorderLeft = XLLineStyleEnum.Thin;
			style.BorderRight = XLLineStyleEnum.Thin;
			style.BorderTop = XLLineStyleEnum.Thin;
			style.ForeColor  = Color.Black;
			style.Format = "yyyy/MM/dd HH:mm";
			style.AlignVert = XLAlignVertEnum.Center;
			style.AlignHorz = XLAlignHorzEnum.Center;
			return style;
		}
		
		public static void Set_Cell(XLCell cell,String st,XLStyle style)
		{			
			cell.Value=st;
			cell.Style = style;
		}
		
		public static void Set_CellNumber(XLCell cell,object obj,XLStyle style)
		{
			cell.Value =obj;
			cell.Style =style ;
		}
		public static Double ConvertToDouble(string st)
		{
			try
			{
				return Double.Parse(st);
			}
			catch(Exception)
			{
				return 0.0;
			}
		}

		public static string FormatDateTime(string st)
		{
			try
			{
				return DateTime.Parse(st).ToString("yyyy/MM/dd HH:mm");
			}
			catch(Exception)
			{
				return "";
			}
		}
		public static string FormatShortDateTime(string str)
		{
			try
			{
				return DateTime.Parse(str).ToString("yyyy/MM/dd ");
			}
			catch(Exception)
			{
				return "";
			}
		}
		public static Int32  ConvertToInt(string str)
		{
			try
			{
				return Convert.ToInt32(str);  
			}
			catch
			{
				// throw new  Exception("This Value incorrect !")  ;
				return 0;					
			
			}
			
		}
	}
}


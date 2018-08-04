using System;
using System.Reflection;

namespace Basic.Function
{
	/// <summary>
	/// Summary description for ReportExcel.
	/// </summary>
	public class ReportWord
	{
		public ReportWord()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		public static void SetProperty(Microsoft.Office.Interop.Word._Document oDoc, string Item, string Value)
		{
			object oCustomProps = oDoc.CustomDocumentProperties;
			object oBuiltInPro = oDoc.BuiltInDocumentProperties;
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

		public static void PrintWord(object FileName, string ConnectionString, string coTitle, string sFontName, string Lang, string where,
			string where1, string where2, string where3, string where4, string where5, string where6, string where7, string where8,
			string where9, string where10, string User)
		{
			object oMissing = Missing.Value;
			Microsoft.Office.Interop.Word.Application oWord = new Microsoft.Office.Interop.Word.ApplicationClass();
			Microsoft.Office.Interop.Word.Documents oDocs = oWord.Documents;
			Microsoft.Office.Interop.Word._Document oDoc = null;

			System.Globalization.CultureInfo oldCI = System.Threading.Thread.CurrentThread.CurrentCulture;
			System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
			try
			{
				oDoc = oDocs.Open(ref FileName, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
					ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing);
				oWord.Visible = true;

				//Cap nhat properties
				SetProperty(oDoc, "ConnectionString", ConnectionString);
				SetProperty(oDoc, "CoTitle", coTitle);
				SetProperty(oDoc, "sFontName", sFontName);
				SetProperty(oDoc, "Lang", Lang);
				SetProperty(oDoc, "where", where);
				SetProperty(oDoc, "where1", where1);
				SetProperty(oDoc, "where2", where2);
				SetProperty(oDoc, "where3", where3);
				SetProperty(oDoc, "where4", where4);
				SetProperty(oDoc, "where5", where5);
				SetProperty(oDoc, "where6", where6);
				SetProperty(oDoc, "where7", where7);
				SetProperty(oDoc, "where8", where8);
				SetProperty(oDoc, "where9", where9);
				SetProperty(oDoc, "where10", where10);
				SetProperty(oDoc, "User", User);

				try
				{
					RunMacro(oWord, new object[]{"CreatReport"});
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
				System.Runtime.InteropServices.Marshal.ReleaseComObject(oDocs);
				System.Runtime.InteropServices.Marshal.ReleaseComObject(oWord);
				GC.Collect();
			}
		}
	}
}

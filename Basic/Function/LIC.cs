using System;
using System.IO;
using System.Windows;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Navigator1;
using System.Collections;
using System.Drawing;
namespace Basic.Function
{
	/// <summary>
	/// Summary description for LIC.
	/// </summary>
	public class LIC
	{
		public static string CUS_ID;
		public LIC()
		{
			//
			// TODO: Add constructor logic here
			//
		}
		public static string GetConfig(string ID)
		{			
			string configFilePath = PublicFunction.Path + "\\Option.xml";
			try
			{
				System.Data.DataSet ds = new DataSet();
				ds.ReadXml(configFilePath);
				return ds.Tables["Config"].Rows[0][ID]+"";			
			}
			catch
			{
				return "error"+ID;
			}
		}

		public static string EncryptWithKey(string lic)
		{
			string st1="";
			try
			{					
				st1 = QD.TripleDES.Encrypt("glinton12052008"+PublicFunction.CUS_ID);
				st1=QD.TripleDES.EncryptWithKey(lic, st1);				
				return st1;
			}
			catch(Exception)
			{
				return "glinton";
			}
		}	

		public static Boolean CheckLic(string lic)
		{
			try
			{
				string st1="",st2="";
				try
				{					
					st1 = QD.TripleDES.Encrypt("glinton12052008"+PublicFunction.CUS_ID);
					st1=QD.TripleDES.EncryptWithKey(lic, st1);				
					st2 = QD.TripleDES.Encrypt("glinton12052008");
					st2=QD.TripleDES.EncryptWithKey(lic, st2);				
				}
				catch(Exception)
				{
					return false;
				}
				string st;
				StreamReader f;
				f=File.OpenText(PublicFunction.Path+"//GGM2007.lic");
				while (true)
				{
					st=f.ReadLine();
					if (st==null) 
					{
						f.Close();
						return false;
					}
					if (st==st1 || st==st2) 
					{
						f.Close();
						return true;
					}
				}								
			}
			catch(IOException)
			{
				MessageBox.Show("GGM2007.lic file no found","Error",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
			}
			return false;
		}

		public static void AddLic(string lic)
		{
			ArrayList a=new ArrayList();
			a.Add (lic);
			try
			{				
				string st;
				StreamReader f;
				f=File.OpenText(PublicFunction.Path+"//GGM2007.lic");
				while (true)
				{					
					st=f.ReadLine();
					if (st==null) 
					{
						f.Close();	
						break;
					}					
					a.Add(st);
				}		
			}
			catch(IOException)
			{
				MessageBox.Show("GGM2007.lic file no found","Error",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
			}									
			StreamWriter g;			
			try
			{
				g=File.CreateText(PublicFunction.Path+"//GGM2007.lic");				
				for (int i=0 ;i<a.Count;i++)
				{
					g.WriteLine(a[i]+"");
				}				
				g.Close();
				
			}
			catch (IOException )
			{
				MessageBox.Show("Error","Error",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
			}
		}
	}
}

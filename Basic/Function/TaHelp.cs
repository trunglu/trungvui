using System;
using System.IO;
using System.Windows;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Navigator1;
using System.Collections;
using System.Drawing;
using GP8000.Personnel.Report;
using Basic.Function;
namespace GP8000.Function
{
	/// <summary>
	/// Summary description for TaHelp.
	/// </summary>
	public class TaHelp
	{
		Form fr;
		Func.RecordSet rs;
		public TaHelp(Form fr)
		{
			try
			{
				this.fr=fr;
				rs=new Func.RecordSet("Select * from SYS_HELP where NAME=N'"+fr.Name+"'",PublicFunction.C_con);
				if(rs.rows>0)
				{
					key(fr);
				}
			}
			catch{}
		}

		private void key(Control fr1)
		{
			for(int i=0;i<fr1.Controls.Count;i++ )
			{
				Control c=fr1.Controls[i];
				c.KeyDown+=new KeyEventHandler(c_KeyDown);
				key(c);
			}
		}

		private void c_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode==Keys.F1)
			{
				try
				{
					string fileName = Application.StartupPath + @"\\Help\\"+rs.record(0,PublicFunction.L_Lag) +".doc";								
					System.Diagnostics.Process.Start(fileName);
				}
				catch
				{
					return;
				}			
			}
		}
	}
}

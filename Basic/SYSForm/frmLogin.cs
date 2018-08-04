using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Basic.Function;

namespace Basic.Form
{
	/// <summary>
	/// Summary description for frmLogin.
	/// </summary>
	public class frmLogin : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lb_user;
		private System.Windows.Forms.Label lb_pass;
		private System.Windows.Forms.Button cmd_Can;
		private System.Windows.Forms.Button cmd_ok;
		private System.Windows.Forms.TextBox txt_user;
		private System.Windows.Forms.TextBox txt_pass;
		private System.Windows.Forms.Button cmd_lag;
		private System.Windows.Forms.RadioButton rd_ch;
		private System.Windows.Forms.RadioButton rd_en;
		private System.Windows.Forms.GroupBox fr_lag;
		private System.Windows.Forms.RadioButton rd_vn;
		private bool log;
		private System.Windows.Forms.RadioButton rd_TT;
		private AxHDD.AxHDDCODE HDDLIC;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmLogin(bool log)
		{
			
			InitializeComponent();
			this.log=log;
			
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmLogin));
			this.lb_user = new System.Windows.Forms.Label();
			this.lb_pass = new System.Windows.Forms.Label();
			this.txt_user = new System.Windows.Forms.TextBox();
			this.txt_pass = new System.Windows.Forms.TextBox();
			this.cmd_ok = new System.Windows.Forms.Button();
			this.cmd_Can = new System.Windows.Forms.Button();
			this.cmd_lag = new System.Windows.Forms.Button();
			this.rd_ch = new System.Windows.Forms.RadioButton();
			this.rd_en = new System.Windows.Forms.RadioButton();
			this.rd_vn = new System.Windows.Forms.RadioButton();
			this.fr_lag = new System.Windows.Forms.GroupBox();
			this.rd_TT = new System.Windows.Forms.RadioButton();
			this.HDDLIC = new AxHDD.AxHDDCODE();
			this.fr_lag.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.HDDLIC)).BeginInit();
			this.SuspendLayout();
			// 
			// lb_user
			// 
			this.lb_user.Location = new System.Drawing.Point(14, 24);
			this.lb_user.Name = "lb_user";
			this.lb_user.Size = new System.Drawing.Size(116, 24);
			this.lb_user.TabIndex = 0;
			this.lb_user.Text = "User Name:";
			// 
			// lb_pass
			// 
			this.lb_pass.Location = new System.Drawing.Point(14, 56);
			this.lb_pass.Name = "lb_pass";
			this.lb_pass.Size = new System.Drawing.Size(116, 24);
			this.lb_pass.TabIndex = 1;
			this.lb_pass.Text = "Password:";
			// 
			// txt_user
			// 
			this.txt_user.Location = new System.Drawing.Point(134, 16);
			this.txt_user.MaxLength = 20;
			this.txt_user.Name = "txt_user";
			this.txt_user.Size = new System.Drawing.Size(196, 23);
			this.txt_user.TabIndex = 2;
			this.txt_user.Text = "";
			this.txt_user.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_user_KeyDown);
			// 
			// txt_pass
			// 
			this.txt_pass.Location = new System.Drawing.Point(134, 48);
			this.txt_pass.MaxLength = 20;
			this.txt_pass.Name = "txt_pass";
			this.txt_pass.PasswordChar = '*';
			this.txt_pass.Size = new System.Drawing.Size(196, 23);
			this.txt_pass.TabIndex = 3;
			this.txt_pass.Text = "";
			this.txt_pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_pass_KeyDown);
			// 
			// cmd_ok
			// 
			this.cmd_ok.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_ok.Location = new System.Drawing.Point(10, 88);
			this.cmd_ok.Name = "cmd_ok";
			this.cmd_ok.Size = new System.Drawing.Size(92, 32);
			this.cmd_ok.TabIndex = 4;
			this.cmd_ok.Text = "OK";
			this.cmd_ok.Click += new System.EventHandler(this.cmd_ok_Click);
			// 
			// cmd_Can
			// 
			this.cmd_Can.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cmd_Can.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_Can.Location = new System.Drawing.Point(126, 88);
			this.cmd_Can.Name = "cmd_Can";
			this.cmd_Can.Size = new System.Drawing.Size(92, 32);
			this.cmd_Can.TabIndex = 5;
			this.cmd_Can.Text = "Cancel";
			this.cmd_Can.Click += new System.EventHandler(this.cmd_Can_Click);
			// 
			// cmd_lag
			// 
			this.cmd_lag.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_lag.Location = new System.Drawing.Point(242, 88);
			this.cmd_lag.Name = "cmd_lag";
			this.cmd_lag.Size = new System.Drawing.Size(92, 32);
			this.cmd_lag.TabIndex = 6;
			this.cmd_lag.Text = "Lag";
			this.cmd_lag.Click += new System.EventHandler(this.cmd_lag_Click);
			// 
			// rd_ch
			// 
			this.rd_ch.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rd_ch.Location = new System.Drawing.Point(188, 24);
			this.rd_ch.Name = "rd_ch";
			this.rd_ch.Size = new System.Drawing.Size(148, 24);
			this.rd_ch.TabIndex = 8;
			this.rd_ch.Text = "radioButton2";
			this.rd_ch.CheckedChanged += new System.EventHandler(this.rd_ch_CheckedChanged);
			// 
			// rd_en
			// 
			this.rd_en.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rd_en.Location = new System.Drawing.Point(28, 24);
			this.rd_en.Name = "rd_en";
			this.rd_en.Size = new System.Drawing.Size(148, 24);
			this.rd_en.TabIndex = 7;
			this.rd_en.Text = "radioButton1";
			this.rd_en.CheckedChanged += new System.EventHandler(this.rd_en_CheckedChanged);
			// 
			// rd_vn
			// 
			this.rd_vn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rd_vn.Location = new System.Drawing.Point(28, 56);
			this.rd_vn.Name = "rd_vn";
			this.rd_vn.Size = new System.Drawing.Size(140, 24);
			this.rd_vn.TabIndex = 9;
			this.rd_vn.Text = "radioButton3";
			this.rd_vn.CheckedChanged += new System.EventHandler(this.rd_vn_CheckedChanged);
			// 
			// fr_lag
			// 
			this.fr_lag.Controls.Add(this.rd_TT);
			this.fr_lag.Controls.Add(this.rd_ch);
			this.fr_lag.Controls.Add(this.rd_en);
			this.fr_lag.Controls.Add(this.rd_vn);
			this.fr_lag.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.fr_lag.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fr_lag.Location = new System.Drawing.Point(0, 46);
			this.fr_lag.Name = "fr_lag";
			this.fr_lag.Size = new System.Drawing.Size(343, 88);
			this.fr_lag.TabIndex = 10;
			this.fr_lag.TabStop = false;
			this.fr_lag.Visible = false;
			// 
			// rd_TT
			// 
			this.rd_TT.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rd_TT.Location = new System.Drawing.Point(188, 56);
			this.rd_TT.Name = "rd_TT";
			this.rd_TT.Size = new System.Drawing.Size(148, 24);
			this.rd_TT.TabIndex = 10;
			this.rd_TT.Text = "radioButton3";
			this.rd_TT.CheckedChanged += new System.EventHandler(this.rd_TT_CheckedChanged);
			// 
			// HDDLIC
			// 
			this.HDDLIC.Enabled = true;
			this.HDDLIC.Location = new System.Drawing.Point(56, 0);
			this.HDDLIC.Name = "HDDLIC";
			this.HDDLIC.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("HDDLIC.OcxState")));
			this.HDDLIC.TabIndex = 11;
			this.HDDLIC.Visible = false;
			// 
			// frmLogin
			// 
			this.AutoScale = false;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(343, 134);
			this.Controls.Add(this.HDDLIC);
			this.Controls.Add(this.cmd_Can);
			this.Controls.Add(this.cmd_lag);
			this.Controls.Add(this.cmd_ok);
			this.Controls.Add(this.txt_pass);
			this.Controls.Add(this.txt_user);
			this.Controls.Add(this.lb_pass);
			this.Controls.Add(this.lb_user);
			this.Controls.Add(this.fr_lag);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Tag = "";
			this.Text = "frmLogin";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLogin_KeyDown);
			this.Load += new System.EventHandler(this.frmLogin_Load);
			this.fr_lag.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.HDDLIC)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmLogin_Load(object sender, System.EventArgs e)
		{
//			if (PublicFunction.CUS_ID!="17")
//			{
//				string lic=string.Empty ;
//				if(PublicFunction.CUS_ID=="400" && PublicFunction.GetOption("NOHDD")=="1")
//				{
//					lic=PublicFunction.DT_server;
//					if(lic+""=="")
//						lic=LIC.EncryptWithKey(lic);
//				}
//				else
//				{
//					lic=HDDLIC.GetHDD();
//					if(lic+""=="")
//						lic=LIC.EncryptWithKey(lic+ System.Environment.MachineName);
//				}
//				if (!LIC.CheckLic(lic))
//				{
//					frmTaLicence dlg=new frmTaLicence();
//					dlg.textBox1.Text=lic;
//					if (dlg.ShowDialog()==DialogResult.Cancel)
//						this.Close();				
//				}
//			}

			PublicFunction.L_Init_Label(this);
			switch(PublicFunction.L_Lag)
			{
				case "EN":
					rd_en.Checked=true;
					break;
				case "CH":
					rd_ch.Checked=true;
					break;
				case "VN":
					rd_vn.Checked=true;
					break;
				case "TT":
					rd_TT.Checked=true;
					break;
			}	

			txt_user.Text=PublicFunction.A_UserID;
		}

		public void Init_Label()
		{
			PublicFunction.L_Init_Label(this);			
		}

		private void cmd_ok_Click(object sender, System.EventArgs e)
		{
			Login();
		}

		private void cmd_lag_Click(object sender, System.EventArgs e)
		{
			Size siz;
			if (this.Height>=240) 
			{
				siz=new Size(this.Width,160);
				this.Size=this.MaximumSize =this.MinimumSize=siz;
				fr_lag.Visible=false;
			}
			else 
			{	
				siz=new Size(this.Width,240);
				this.Size=this.MaximumSize =this.MinimumSize=siz;
				fr_lag.Visible=true;
			}			
		}

		private void rd_en_CheckedChanged(object sender, System.EventArgs e)
		{
			if (PublicFunction.L_Lag=="EN")
				return;
			PublicFunction.L_Lag="EN";
			PublicFunction.L_Init_Label(this);
		}

		private void rd_ch_CheckedChanged(object sender, System.EventArgs e)
		{
			if (PublicFunction.L_Lag=="CH")
				return;
			PublicFunction.L_Lag="CH";
			PublicFunction.L_Init_Label(this);
		}

		private void rd_vn_CheckedChanged(object sender, System.EventArgs e)
		{
			if (PublicFunction.L_Lag=="VN")
				return;
			PublicFunction.L_Lag="VN";
			PublicFunction.L_Init_Label(this);
		}
		private void rd_TT_CheckedChanged(object sender, System.EventArgs e)
		{
			if (PublicFunction.L_Lag=="TT")
				return;
			PublicFunction.L_Lag="TT";
			PublicFunction.L_Init_Label(this);
		}

		private void cmd_Can_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void txt_user_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter)
				txt_pass.Focus();
		}

		private void txt_pass_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter)
			{
				Login();
			}
			if(e.KeyCode==Keys.F10)
			{
				Func.RecordSet rs=new Func.RecordSet("Select * from SYS_USER",PublicFunction.C_con);
				for(int i=0;i<rs.rows;i++)
				{				
					PublicFunction.SQL_Execute("update SYS_USER set PASS=N'"+PublicFunction.code(rs.record(i,"PASS")+"",rs.record(i,"USER_ID"))
						+"' where USER_ID=N'"+rs.record(i,"USER_ID")+"'");
				}
			}
		}

		private void Login()
		{
			string st1,st,spa="";
			spa=txt_pass.Text;
			Func.RecordSet rs=new Func.RecordSet("select * from SYS_USER where USER_ID=N'"+txt_user.Text+"'",Function.PublicFunction.C_con );
			if (rs.rows>0) 
			{
				if(rs.record(0,"USER_ID")!=txt_user.Text )
				{
					MessageBox.Show(PublicFunction.L_Get_Msg("msg",0));
					return;
				}
				st=rs.record(0,"PASS");
				st1=PublicFunction.code(txt_pass.Text,rs.record(0,"USER_ID"));
				
			// Lay ngay khoa sau pass cua user vinhtuyen				
				if (spa.Length>=10 && txt_user.Text.ToUpper()=="VINHTUYEN"  )
				{
					if(PublicFunction.IsDate(spa.Substring(spa.Length-12,10)))
					{
						st1=PublicFunction.code(spa.Substring(0,spa.Length-12),rs.record(0,"USER_ID"));
						//st1 ="SzKVPFnG2BEBlgClpPyxmw==";
						//update ngay khoa xuong sql							
						PublicFunction.SQL_Execute("UPDATE GP_KEY SET COL_DT='"+PublicFunction.code(spa.Substring(spa.Length-12,10),"" )
							+"',COL_MN=1,TYP_MN='"+spa.Substring(spa.Length-2,2)+"'" ,PublicFunction.C_con);
					}
				}			
				//st=st.Substring(0,st.Length-3);					
				string keyD="";					
				Func.RecordSet rsK=new Func.RecordSet ("Select * from GP_KEY",PublicFunction.C_con);
				if (rsK.rows>0)
				{
					keyD=PublicFunction.encode(rsK.record(0,"COL_DT"),"") ;						
					if ( T_String.GetDate()>= DateTime.Parse( keyD))
					{							
						PublicFunction.SQL_Execute("UPDATE GP_KEY SET COL_MN=COL_MN+1",PublicFunction.C_con);
					}
				}				
			//end

				if (st==null) st="";
				if (st1==null) st1="";
				
				if (st!=st1)
					MessageBox.Show(PublicFunction.L_Get_Msg("msg","log"));
				else
				{					
					//Phan kiem tra trang thai user tai day
					string state=PublicFunction.CheckState(txt_user.Text);
//					if(state!="")
//						MessageBox.Show(state);
//					else
//					{
						//Kiem tra xem co phai la changeuser ko
						//MessageBox.Show(PublicFunction.A_UserID);
						if(log==false)
						{
							if(PublicFunction.A_UserID!="" && PublicFunction.A_UserID!=txt_user.Text)
							{
								PublicFunction.WriteToLogInfo(PublicFunction.A_UserID,false);
								string sql="update SYS_CONTROL_USER set STATE=0 WHERE USER_ID=N'"+PublicFunction.A_UserID+"'";
								PublicFunction.SQL_Execute(sql);
							}
						}
						this.DialogResult=System.Windows.Forms.DialogResult.OK;
						PublicFunction.WriteToLogInfo(txt_user.Text,true);
						PublicFunction.A_UserID=txt_user.Text;
						PublicFunction.A_Pass=txt_pass.Text;

						//build table name
						GP8000.Function.Common.Ints.BuildTableGP_GPS();
						this.Close();
					//}
				}
			}
			else
				MessageBox.Show(PublicFunction.L_Get_Msg("msg",0));
		}

		private void splitter1_SplitterMoved(object sender, System.Windows.Forms.SplitterEventArgs e)
		{
			MessageBox.Show(e.SplitX +"; "+ e.SplitY );
		}

		private void frmLogin_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode==Keys.F10)
			{
				Func.RecordSet rs=new Func.RecordSet("Select * from SYS_USER",PublicFunction.C_con);
				for(int i=0;i<rs.rows;i++)
				{				
					PublicFunction.SQL_Execute("update SYS_USER set PASS=N'"+PublicFunction.code(rs.record(i,"PASS"),rs.record(i,"USER_ID"))
						+"' where USER_ID=N'"+rs.record(i,"USER_ID")+"'");
				}
			}
		}	
	}
}

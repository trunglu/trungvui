using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Basic.Function ;

namespace Basic.Form
{
	/// <summary>
	/// Summary description for frmChangeUser.
	/// </summary>
	public class frmChangePassword : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lb1;
		private System.Windows.Forms.Label lb2;
		private System.Windows.Forms.Label lb3;
		private System.Windows.Forms.TextBox txt1;
		private System.Windows.Forms.TextBox txt2;
		private System.Windows.Forms.TextBox txt3;
		private System.Windows.Forms.Button cmd_ok;
		private System.Windows.Forms.Button cmd_can;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmChangePassword()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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
			this.lb1 = new System.Windows.Forms.Label();
			this.lb2 = new System.Windows.Forms.Label();
			this.lb3 = new System.Windows.Forms.Label();
			this.txt1 = new System.Windows.Forms.TextBox();
			this.txt2 = new System.Windows.Forms.TextBox();
			this.txt3 = new System.Windows.Forms.TextBox();
			this.cmd_ok = new System.Windows.Forms.Button();
			this.cmd_can = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lb1
			// 
			this.lb1.Location = new System.Drawing.Point(15, 24);
			this.lb1.Name = "lb1";
			this.lb1.Size = new System.Drawing.Size(146, 16);
			this.lb1.TabIndex = 0;
			this.lb1.Text = "label1";
			// 
			// lb2
			// 
			this.lb2.Location = new System.Drawing.Point(15, 52);
			this.lb2.Name = "lb2";
			this.lb2.Size = new System.Drawing.Size(146, 16);
			this.lb2.TabIndex = 1;
			this.lb2.Text = "label2";
			// 
			// lb3
			// 
			this.lb3.Location = new System.Drawing.Point(15, 80);
			this.lb3.Name = "lb3";
			this.lb3.Size = new System.Drawing.Size(146, 16);
			this.lb3.TabIndex = 2;
			this.lb3.Text = "label3";
			// 
			// txt1
			// 
			this.txt1.Location = new System.Drawing.Point(161, 16);
			this.txt1.MaxLength = 20;
			this.txt1.Name = "txt1";
			this.txt1.PasswordChar = '*';
			this.txt1.Size = new System.Drawing.Size(152, 22);
			this.txt1.TabIndex = 3;
			this.txt1.Text = "";
			this.txt1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt1_KeyDown);
			// 
			// txt2
			// 
			this.txt2.Location = new System.Drawing.Point(161, 44);
			this.txt2.MaxLength = 20;
			this.txt2.Name = "txt2";
			this.txt2.PasswordChar = '*';
			this.txt2.Size = new System.Drawing.Size(152, 22);
			this.txt2.TabIndex = 4;
			this.txt2.Text = "";
			this.txt2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt2_KeyDown);
			// 
			// txt3
			// 
			this.txt3.Location = new System.Drawing.Point(161, 72);
			this.txt3.MaxLength = 20;
			this.txt3.Name = "txt3";
			this.txt3.PasswordChar = '*';
			this.txt3.Size = new System.Drawing.Size(152, 22);
			this.txt3.TabIndex = 5;
			this.txt3.Text = "";
			this.txt3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt3_KeyDown);
			// 
			// cmd_ok
			// 
			this.cmd_ok.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_ok.Location = new System.Drawing.Point(68, 113);
			this.cmd_ok.Name = "cmd_ok";
			this.cmd_ok.Size = new System.Drawing.Size(80, 32);
			this.cmd_ok.TabIndex = 6;
			this.cmd_ok.Text = "button1";
			this.cmd_ok.Click += new System.EventHandler(this.cmd_ok_Click);
			// 
			// cmd_can
			// 
			this.cmd_can.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_can.Location = new System.Drawing.Point(180, 113);
			this.cmd_can.Name = "cmd_can";
			this.cmd_can.Size = new System.Drawing.Size(80, 32);
			this.cmd_can.TabIndex = 7;
			this.cmd_can.Text = "button2";
			this.cmd_can.Click += new System.EventHandler(this.cmd_can_Click);
			// 
			// frmChangePassword
			// 
			this.AutoScale = false;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
			this.ClientSize = new System.Drawing.Size(334, 160);
			this.Controls.Add(this.cmd_can);
			this.Controls.Add(this.cmd_ok);
			this.Controls.Add(this.txt3);
			this.Controls.Add(this.txt2);
			this.Controls.Add(this.txt1);
			this.Controls.Add(this.lb3);
			this.Controls.Add(this.lb2);
			this.Controls.Add(this.lb1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmChangePassword";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmChangePassword";
			this.Load += new System.EventHandler(this.frmChangePassword_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmChangePassword_Load(object sender, System.EventArgs e)
		{
			PublicFunction.L_Init_Label(this);
		}

		private void cmd_can_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void cmd_ok_Click(object sender, System.EventArgs e)
		{
			ChangePassword();
		}

		private void ChangePassword()
		{
			Func.RecordSet rs=new Func.RecordSet("select * from SYS_USER where USER_ID=N'"+PublicFunction.A_UserID+"'",Function.PublicFunction.C_con );
			if (rs.rows>0) 
			{
				string st1,st;
				st=rs.record(0,"PASS");				
				//key
				//st=st.Substring(0,st.Length-3);
				st1=PublicFunction.code(txt1.Text,PublicFunction.A_UserID);
				
				if (st==null) st="";
				if (st1==null) st1="";

				if (st!=st1)
					MessageBox.Show(PublicFunction.L_Get_Msg("msg",1));
				else
				{
					if (txt2.Text!=txt3.Text)
					{
						MessageBox.Show(PublicFunction.L_Get_Msg("msg",2));
					}
					else
					{						
						if (PublicFunction.SQL_Execute("Update SYS_USER set PASS=N'"+PublicFunction.code(txt2.Text,PublicFunction.A_UserID)+"'where USER_ID=N'"+PublicFunction.A_UserID+"'"))
						{
							//key
							//PublicFunction.SQL_Execute("Update SYS_USER set PASS=PASS+'***' where USER_ID=N'"+PublicFunction.A_UserID+"'",PublicFunction.C_con);
							MessageBox.Show(PublicFunction.L_Get_Msg("msg",3));	
						}
					}	
				}
			}
			else
				MessageBox.Show(PublicFunction.L_Get_Msg("msg",1));
		}

		private void txt1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter)
				txt2.Focus();
		}

		private void txt2_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter)
				txt3.Focus();
		}

		private void txt3_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter)
				ChangePassword();
		}
	}
}

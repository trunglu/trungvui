using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Basic.Function ;

namespace Basic.Form
{
	/// <summary>
	/// Summary description for frmSYS_System.
	/// </summary>
	public class frmSYS_System : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lb1;
		private System.Windows.Forms.TextBox txt_server;
		private System.Windows.Forms.TextBox txt_data;
		private System.Windows.Forms.Label lb2;
		private System.Windows.Forms.TextBox txt_pass1;
		private System.Windows.Forms.Label lb4;
		private System.Windows.Forms.TextBox txt_user;
		private System.Windows.Forms.Label lb3;
		private System.Windows.Forms.TextBox txt_pass2;
		private System.Windows.Forms.Label lb6;
		private System.Windows.Forms.TextBox txt_log;
		private System.Windows.Forms.Label lb5;
		private System.Windows.Forms.Button cmd_ok;
		private System.Windows.Forms.Button cmd_can;
		private System.Windows.Forms.TextBox txt_datadel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txt4;
		private System.Windows.Forms.TextBox txt3;
		private System.Windows.Forms.TextBox txt2;
		private System.Windows.Forms.TextBox txt1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmSYS_System()
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
			this.txt_server = new System.Windows.Forms.TextBox();
			this.txt_data = new System.Windows.Forms.TextBox();
			this.lb2 = new System.Windows.Forms.Label();
			this.txt_pass1 = new System.Windows.Forms.TextBox();
			this.lb4 = new System.Windows.Forms.Label();
			this.txt_user = new System.Windows.Forms.TextBox();
			this.lb3 = new System.Windows.Forms.Label();
			this.txt_pass2 = new System.Windows.Forms.TextBox();
			this.lb6 = new System.Windows.Forms.Label();
			this.txt_log = new System.Windows.Forms.TextBox();
			this.lb5 = new System.Windows.Forms.Label();
			this.cmd_ok = new System.Windows.Forms.Button();
			this.cmd_can = new System.Windows.Forms.Button();
			this.txt_datadel = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txt4 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txt3 = new System.Windows.Forms.TextBox();
			this.txt2 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txt1 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lb1
			// 
			this.lb1.Location = new System.Drawing.Point(20, 16);
			this.lb1.Name = "lb1";
			this.lb1.Size = new System.Drawing.Size(104, 16);
			this.lb1.TabIndex = 0;
			this.lb1.Text = "Server Name ";
			// 
			// txt_server
			// 
			this.txt_server.Location = new System.Drawing.Point(144, 8);
			this.txt_server.Name = "txt_server";
			this.txt_server.Size = new System.Drawing.Size(164, 23);
			this.txt_server.TabIndex = 1;
			this.txt_server.Text = "";
			// 
			// txt_data
			// 
			this.txt_data.Location = new System.Drawing.Point(144, 40);
			this.txt_data.Name = "txt_data";
			this.txt_data.Size = new System.Drawing.Size(164, 23);
			this.txt_data.TabIndex = 3;
			this.txt_data.Text = "";
			// 
			// lb2
			// 
			this.lb2.Location = new System.Drawing.Point(20, 48);
			this.lb2.Name = "lb2";
			this.lb2.Size = new System.Drawing.Size(104, 16);
			this.lb2.TabIndex = 2;
			this.lb2.Text = "Database Name";
			// 
			// txt_pass1
			// 
			this.txt_pass1.Location = new System.Drawing.Point(144, 136);
			this.txt_pass1.Name = "txt_pass1";
			this.txt_pass1.PasswordChar = '@';
			this.txt_pass1.Size = new System.Drawing.Size(164, 23);
			this.txt_pass1.TabIndex = 7;
			this.txt_pass1.Text = "";
			// 
			// lb4
			// 
			this.lb4.Location = new System.Drawing.Point(20, 112);
			this.lb4.Name = "lb4";
			this.lb4.Size = new System.Drawing.Size(104, 16);
			this.lb4.TabIndex = 6;
			this.lb4.Text = "User ID";
			// 
			// txt_user
			// 
			this.txt_user.Location = new System.Drawing.Point(144, 104);
			this.txt_user.Name = "txt_user";
			this.txt_user.Size = new System.Drawing.Size(164, 23);
			this.txt_user.TabIndex = 5;
			this.txt_user.Text = "";
			// 
			// lb3
			// 
			this.lb3.Location = new System.Drawing.Point(20, 76);
			this.lb3.Name = "lb3";
			this.lb3.Size = new System.Drawing.Size(104, 16);
			this.lb3.TabIndex = 4;
			this.lb3.Text = "Database Del";
			// 
			// txt_pass2
			// 
			this.txt_pass2.Location = new System.Drawing.Point(144, 328);
			this.txt_pass2.Name = "txt_pass2";
			this.txt_pass2.PasswordChar = '@';
			this.txt_pass2.Size = new System.Drawing.Size(164, 23);
			this.txt_pass2.TabIndex = 11;
			this.txt_pass2.Text = "";
			// 
			// lb6
			// 
			this.lb6.Location = new System.Drawing.Point(20, 304);
			this.lb6.Name = "lb6";
			this.lb6.Size = new System.Drawing.Size(104, 16);
			this.lb6.TabIndex = 10;
			this.lb6.Text = "Login Name";
			// 
			// txt_log
			// 
			this.txt_log.Location = new System.Drawing.Point(144, 296);
			this.txt_log.Name = "txt_log";
			this.txt_log.Size = new System.Drawing.Size(164, 23);
			this.txt_log.TabIndex = 9;
			this.txt_log.Text = "";
			// 
			// lb5
			// 
			this.lb5.Location = new System.Drawing.Point(20, 148);
			this.lb5.Name = "lb5";
			this.lb5.Size = new System.Drawing.Size(104, 16);
			this.lb5.TabIndex = 8;
			this.lb5.Text = "Password";
			// 
			// cmd_ok
			// 
			this.cmd_ok.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_ok.Location = new System.Drawing.Point(52, 368);
			this.cmd_ok.Name = "cmd_ok";
			this.cmd_ok.Size = new System.Drawing.Size(88, 32);
			this.cmd_ok.TabIndex = 12;
			this.cmd_ok.Text = "OK";
			this.cmd_ok.Click += new System.EventHandler(this.cmd_ok_Click);
			// 
			// cmd_can
			// 
			this.cmd_can.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_can.Location = new System.Drawing.Point(168, 368);
			this.cmd_can.Name = "cmd_can";
			this.cmd_can.Size = new System.Drawing.Size(88, 32);
			this.cmd_can.TabIndex = 13;
			this.cmd_can.Text = "Cancel";
			this.cmd_can.Click += new System.EventHandler(this.cmd_can_Click);
			// 
			// txt_datadel
			// 
			this.txt_datadel.Location = new System.Drawing.Point(144, 72);
			this.txt_datadel.Name = "txt_datadel";
			this.txt_datadel.Size = new System.Drawing.Size(164, 23);
			this.txt_datadel.TabIndex = 15;
			this.txt_datadel.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(20, 336);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 16);
			this.label1.TabIndex = 14;
			this.label1.Text = "Password";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(19, 276);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 16);
			this.label2.TabIndex = 24;
			this.label2.Text = "Password GP";
			// 
			// txt4
			// 
			this.txt4.Location = new System.Drawing.Point(143, 264);
			this.txt4.Name = "txt4";
			this.txt4.PasswordChar = '@';
			this.txt4.Size = new System.Drawing.Size(164, 23);
			this.txt4.TabIndex = 23;
			this.txt4.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(19, 240);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(104, 16);
			this.label3.TabIndex = 22;
			this.label3.Text = "User ID GP";
			// 
			// txt3
			// 
			this.txt3.Location = new System.Drawing.Point(143, 232);
			this.txt3.Name = "txt3";
			this.txt3.Size = new System.Drawing.Size(164, 23);
			this.txt3.TabIndex = 21;
			this.txt3.Text = "";
			// 
			// txt2
			// 
			this.txt2.Location = new System.Drawing.Point(143, 200);
			this.txt2.Name = "txt2";
			this.txt2.Size = new System.Drawing.Size(164, 23);
			this.txt2.TabIndex = 19;
			this.txt2.Text = "";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(19, 208);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(104, 16);
			this.label5.TabIndex = 18;
			this.label5.Text = "Database Name GP";
			// 
			// txt1
			// 
			this.txt1.Location = new System.Drawing.Point(143, 168);
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(164, 23);
			this.txt1.TabIndex = 17;
			this.txt1.Text = "";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(19, 176);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(104, 16);
			this.label6.TabIndex = 16;
			this.label6.Text = "Server Name GP";
			// 
			// frmSYS_System
			// 
			this.AutoScale = false;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(327, 410);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txt4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txt3);
			this.Controls.Add(this.txt2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txt1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txt_datadel);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmd_can);
			this.Controls.Add(this.cmd_ok);
			this.Controls.Add(this.txt_pass2);
			this.Controls.Add(this.lb6);
			this.Controls.Add(this.txt_log);
			this.Controls.Add(this.lb5);
			this.Controls.Add(this.txt_pass1);
			this.Controls.Add(this.lb4);
			this.Controls.Add(this.txt_user);
			this.Controls.Add(this.lb3);
			this.Controls.Add(this.txt_data);
			this.Controls.Add(this.lb2);
			this.Controls.Add(this.txt_server);
			this.Controls.Add(this.lb1);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmSYS_System";
			this.Text = "System";
			this.Load += new System.EventHandler(this.frmSYS_System_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void cmd_ok_Click(object sender, System.EventArgs e)
		{
			PublicFunction.DT_server=txt_server.Text;
			PublicFunction.DT_database=txt_data.Text;
			PublicFunction.DT_databasedel=txt_datadel.Text ;
			PublicFunction.DT_username=txt_user.Text ;
			PublicFunction.DT_password=txt_pass1.Text;
			PublicFunction.AD_Login=txt_log.Text ;
			PublicFunction.AD_Key=txt_pass2.Text;

			PublicFunction.DTGP_server=txt1.Text;
			PublicFunction.DTGP_database=txt2.Text;			
			PublicFunction.DTGP_username=txt3.Text ;
			PublicFunction.DTGP_password=txt4.Text;
			PublicFunction.savefilekey();
			Close();
		}

		private void frmSYS_System_Load(object sender, System.EventArgs e)
		{
			txt_server.Text=PublicFunction.DT_server;
			txt_data.Text=PublicFunction.DT_database;
			txt_datadel.Text=PublicFunction.DT_databasedel ;
			txt_user.Text=PublicFunction.DT_username ;
			txt_pass1.Text=PublicFunction.DT_password;
			txt_log.Text=PublicFunction.AD_Login ;
			txt_pass2.Text=PublicFunction.AD_Key;

			txt1.Text=PublicFunction.DTGP_server;
			txt2.Text=PublicFunction.DTGP_database;			
			txt3.Text=PublicFunction.DTGP_username ;
			txt4.Text=PublicFunction.DTGP_password;
		}

		private void cmd_can_Click(object sender, System.EventArgs e)
		{
			Close();
		}
	}
}

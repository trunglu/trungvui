using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Basic.Form;
using Basic.Function;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Data;
using System.Data.SqlClient;
using GP8000.Function;


namespace GP8000.Attendance
{
	/// <summary>
	/// Summary description for frmTaCardDataSwitch.
	/// </summary>
	public class frmTaCardDataSwitchVS : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private C1.Win.C1Input.C1DateEdit dt2;
		private C1.Win.C1Input.C1DateEdit dt1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Button cmd_att;
		private GP8000.UserControl.CrtTaCondition1 control1;
		private System.Windows.Forms.Button cmd_close;
		private SqlConnection con;
		private System.Windows.Forms.ProgressBar pro1;
		private System.Windows.Forms.ProgressBar pro2;
		private System.Windows.Forms.Label c1;
		private Func.RecordSet Set,rsTypeShift,rsType;
		private System.Windows.Forms.Button cmd_for;
		private System.Windows.Forms.Label label3;
		private Boolean Stop;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label c2;
		private System.Windows.Forms.ProgressBar pro3;
		private System.Windows.Forms.ProgressBar pro4;
		private System.Windows.Forms.Label c3;
		private System.Windows.Forms.Label c4;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label tm;
		private System.Windows.Forms.TextBox err;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Button btnTinhPC;
		private Int32 HIS_NO;
		//private string table;

		public frmTaCardDataSwitchVS()
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
            this.components = new System.ComponentModel.Container();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.err = new System.Windows.Forms.TextBox();
            this.tm = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.c4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.c2 = new System.Windows.Forms.Label();
            this.pro3 = new System.Windows.Forms.ProgressBar();
            this.pro4 = new System.Windows.Forms.ProgressBar();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.c3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.c1 = new System.Windows.Forms.Label();
            this.pro1 = new System.Windows.Forms.ProgressBar();
            this.pro2 = new System.Windows.Forms.ProgressBar();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTinhPC = new System.Windows.Forms.Button();
            this.cmd_for = new System.Windows.Forms.Button();
            this.dt2 = new C1.Win.C1Input.C1DateEdit();
            this.dt1 = new C1.Win.C1Input.C1DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.cmd_close = new System.Windows.Forms.Button();
            this.cmd_att = new System.Windows.Forms.Button();
            this.control1 = new GP8000.UserControl.CrtTaCondition1();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1156, 36);
            this.panel3.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1156, 36);
            this.label5.TabIndex = 11;
            this.label5.Tag = "";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1156, 670);
            this.panel1.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.err);
            this.panel4.Controls.Add(this.tm);
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 180);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1156, 490);
            this.panel4.TabIndex = 9;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // err
            // 
            this.err.BackColor = System.Drawing.Color.LightSteelBlue;
            this.err.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.err.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.err.Location = new System.Drawing.Point(0, 280);
            this.err.Multiline = true;
            this.err.Name = "err";
            this.err.ReadOnly = true;
            this.err.Size = new System.Drawing.Size(1156, 210);
            this.err.TabIndex = 15;
            this.err.Visible = false;
            // 
            // tm
            // 
            this.tm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tm.BackColor = System.Drawing.Color.Black;
            this.tm.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tm.ForeColor = System.Drawing.Color.Red;
            this.tm.Location = new System.Drawing.Point(0, 220);
            this.tm.Name = "tm";
            this.tm.Size = new System.Drawing.Size(1156, 24);
            this.tm.TabIndex = 14;
            this.tm.Tag = "N";
            this.tm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 212);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1156, 4);
            this.panel9.TabIndex = 12;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.c4);
            this.panel8.Controls.Add(this.label6);
            this.panel8.Controls.Add(this.c2);
            this.panel8.Controls.Add(this.pro3);
            this.panel8.Controls.Add(this.pro4);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 108);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1156, 104);
            this.panel8.TabIndex = 11;
            // 
            // c4
            // 
            this.c4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c4.BackColor = System.Drawing.Color.Black;
            this.c4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c4.ForeColor = System.Drawing.Color.White;
            this.c4.Location = new System.Drawing.Point(0, 76);
            this.c4.Name = "c4";
            this.c4.Size = new System.Drawing.Size(1156, 24);
            this.c4.TabIndex = 13;
            this.c4.Tag = "N";
            this.c4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1156, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "label6";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // c2
            // 
            this.c2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c2.BackColor = System.Drawing.Color.Black;
            this.c2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c2.ForeColor = System.Drawing.Color.White;
            this.c2.Location = new System.Drawing.Point(0, 54);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(1156, 24);
            this.c2.TabIndex = 12;
            this.c2.Tag = "N";
            this.c2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pro3
            // 
            this.pro3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pro3.Location = new System.Drawing.Point(4, 22);
            this.pro3.Name = "pro3";
            this.pro3.Size = new System.Drawing.Size(1148, 16);
            this.pro3.TabIndex = 10;
            // 
            // pro4
            // 
            this.pro4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pro4.Location = new System.Drawing.Point(4, 38);
            this.pro4.Name = "pro4";
            this.pro4.Size = new System.Drawing.Size(1148, 16);
            this.pro4.TabIndex = 11;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 104);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1156, 4);
            this.panel7.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.c3);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.c1);
            this.panel6.Controls.Add(this.pro1);
            this.panel6.Controls.Add(this.pro2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1156, 104);
            this.panel6.TabIndex = 9;
            // 
            // c3
            // 
            this.c3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c3.BackColor = System.Drawing.Color.Black;
            this.c3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c3.ForeColor = System.Drawing.Color.White;
            this.c3.Location = new System.Drawing.Point(0, 80);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(1156, 24);
            this.c3.TabIndex = 9;
            this.c3.Tag = "N";
            this.c3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1156, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "label4";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // c1
            // 
            this.c1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c1.BackColor = System.Drawing.Color.Black;
            this.c1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1.ForeColor = System.Drawing.Color.White;
            this.c1.Location = new System.Drawing.Point(0, 56);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(1156, 24);
            this.c1.TabIndex = 8;
            this.c1.Tag = "N";
            this.c1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pro1
            // 
            this.pro1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pro1.Location = new System.Drawing.Point(4, 24);
            this.pro1.Name = "pro1";
            this.pro1.Size = new System.Drawing.Size(1148, 16);
            this.pro1.TabIndex = 2;
            // 
            // pro2
            // 
            this.pro2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pro2.Location = new System.Drawing.Point(4, 40);
            this.pro2.Name = "pro2";
            this.pro2.Size = new System.Drawing.Size(1148, 16);
            this.pro2.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 176);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1156, 4);
            this.panel5.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnTinhPC);
            this.panel2.Controls.Add(this.cmd_for);
            this.panel2.Controls.Add(this.dt2);
            this.panel2.Controls.Add(this.dt1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cmd_close);
            this.panel2.Controls.Add(this.cmd_att);
            this.panel2.Controls.Add(this.control1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1156, 176);
            this.panel2.TabIndex = 0;
            // 
            // btnTinhPC
            // 
            this.btnTinhPC.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTinhPC.Location = new System.Drawing.Point(832, 16);
            this.btnTinhPC.Name = "btnTinhPC";
            this.btnTinhPC.Size = new System.Drawing.Size(136, 40);
            this.btnTinhPC.TabIndex = 157;
            this.btnTinhPC.Text = "Tính ph? c?p 30%";
            this.btnTinhPC.Visible = false;
            this.btnTinhPC.Click += new System.EventHandler(this.btnTinhPC_Click);
            // 
            // cmd_for
            // 
            this.cmd_for.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmd_for.Location = new System.Drawing.Point(688, 68);
            this.cmd_for.Name = "cmd_for";
            this.cmd_for.Size = new System.Drawing.Size(136, 40);
            this.cmd_for.TabIndex = 155;
            this.cmd_for.Text = "button1";
            this.cmd_for.Visible = false;
            this.cmd_for.Click += new System.EventHandler(this.cmd_for_Click);
            // 
            // dt2
            // 
            this.dt2.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
            this.dt2.Location = new System.Drawing.Point(536, 44);
            this.dt2.Name = "dt2";
            this.dt2.Size = new System.Drawing.Size(132, 23);
            this.dt2.TabIndex = 150;
            this.dt2.Tag = null;
            // 
            // dt1
            // 
            this.dt1.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
            this.dt1.Location = new System.Drawing.Point(536, 16);
            this.dt1.Name = "dt1";
            this.dt1.Size = new System.Drawing.Size(132, 23);
            this.dt1.TabIndex = 149;
            this.dt1.Tag = null;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(452, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // cmd_close
            // 
            this.cmd_close.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmd_close.Location = new System.Drawing.Point(688, 120);
            this.cmd_close.Name = "cmd_close";
            this.cmd_close.Size = new System.Drawing.Size(136, 40);
            this.cmd_close.TabIndex = 154;
            this.cmd_close.Text = "button3";
            this.cmd_close.Click += new System.EventHandler(this.cmd_close_Click);
            // 
            // cmd_att
            // 
            this.cmd_att.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmd_att.Location = new System.Drawing.Point(688, 16);
            this.cmd_att.Name = "cmd_att";
            this.cmd_att.Size = new System.Drawing.Size(136, 40);
            this.cmd_att.TabIndex = 152;
            this.cmd_att.Text = "button1";
            this.cmd_att.Click += new System.EventHandler(this.cmd_att_Click);
            // 
            // control1
            // 
            this.control1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.control1.Location = new System.Drawing.Point(0, 4);
            this.control1.Name = "control1";
            this.control1.Size = new System.Drawing.Size(444, 164);
            this.control1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(512, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 23);
            this.label3.TabIndex = 156;
            this.label3.Tag = "N";
            this.label3.Text = "->>";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(452, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 151;
            this.label2.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmTaCardDataSwitchVS
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
            this.ClientSize = new System.Drawing.Size(1156, 706);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmTaCardDataSwitchVS";
            this.Text = "frmTaCardDataSwitchVS";
            this.Closed += new System.EventHandler(this.frmTaCardDataSwitch_Closed_1);
            this.Load += new System.EventHandler(this.frmTaCardDataSwitch_Load);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void frmTaCardDataSwitch_Load(object sender, System.EventArgs e)
		{
			if(PublicFunction.A_UserID == "admin")
			{
				btnTinhPC.Visible = true;
			}

			//tao bang HistoryOfFILA06A
			Func.RecordSet rsk = new Func.RecordSet("select * from dbo.sysobjects where id = object_id('HistoryOfFILA06A')", PublicFunction.C_con);
			if (rsk.rows <= 0)
			{
				string sk = "CREATE TABLE HistoryOfFILA06A (SEQ_NO int,STR_DT datetime,END_DT datetime,[USER] nvarchar(100),[WHERE] nvarchar(4000),RESULT nvarchar(4000))";
				PublicFunction.SQL_Execute(sk, PublicFunction.C_con);                
			}
			if(!PublicFunction.GPS)
			{
				string dt60=PublicFunction.GetOption("DT6000");
				if(dt60+""=="1")
				{
					if(PublicFunction.AccessLevel(36,3))
					{
						frmTaGetDataFrDT TaGetDataFrDT=new frmTaGetDataFrDT();
						TaGetDataFrDT.Tag=this.Tag;
						TaGetDataFrDT.ShowDialog();
					}
				}
				else
				{
					string chuyenschema=PublicFunction.GetOption("SCHEMA");
					if (chuyenschema+""=="1")
					{
						frmTaTransferFromTXTSC dlg=new frmTaTransferFromTXTSC();
						dlg.ShowDialog();
						if((PublicFunction.A_UserID.ToUpper()=="ADMIN" || PublicFunction.A_UserID.ToUpper()=="VINHTUYEN"))
						{			
							err.Visible=true;				
						}
						else
							err.Visible=false;	
					}
					else
					{
						frmTaTransferFromTXT dlg=new frmTaTransferFromTXT();
						dlg.ShowDialog();
						if((PublicFunction.A_UserID.ToUpper()=="ADMIN" || PublicFunction.A_UserID.ToUpper()=="VINHTUYEN"))
						{			
							err.Visible=true;				
						}
						else
							err.Visible=false;	
					}	
				}
			}
			else
			{
				pro2.Visible=false;
				pro4.Visible=false;
			}
			Basic.Function.PublicFunction.L_Init_Label(this);
			control1.InitCB(this.Tag);
			control1.Initlabel();
			DateTime dt=T_String.GetDate();
			dt2.Value=dt;	
			dt1.Value=dt.AddDays(-1);	
			dt1.CustomFormat=dt2.CustomFormat=PublicFunction.GetOption("DATE");		
			this.Closed+=new EventHandler(frmTaCardDataSwitch_Closed);
		}

		private void CheckFieldName()
		{
			rsTypeShift=new Func.RecordSet("Select * from GP_SYS_SHIFT",PublicFunction.C_con);
			for(int i=0;i<rsTypeShift.rows;i++)
			{
				if (!Func.Fun.CheckFieldOfTable(PublicFunction.C_con,"FILC06A",rsTypeShift.record(i,"TYP_ID")))
				{
					string sql;
					sql="Alter table FILC06A Add ["+rsTypeShift.record(i,"TYP_ID")+"] float";
					PublicFunction.SQL_Execute(sql);					
//					sql="Alter table FILC06B Add ["+rsTypeShift.record(i,"TYP_ID")+"] float";
//					PublicFunction.SQL_Execute(sql);
					sql="Alter table FILC06AA Add ["+rsTypeShift.record(i,"TYP_ID")+"] float";
					PublicFunction.SQL_Execute(sql);
				}
			}
		}


		private void cmd_close_Click(object sender, System.EventArgs e)
		{
			Stop=true;
			this.Close();
		}
		private void cmd_att_Click(object sender, System.EventArgs e)
		{
			DateTime d1=(DateTime)dt1.Value;
			DateTime d2=(DateTime)dt2.Value;			
			string swh="UPDATE FILC01A_VS SET EMP_ID=E.EMP_ID FROM FILB01A E WHERE FILC01A_VS.CRD_NO=E.CRD_NO AND FILC01A_VS.EMP_ID=''"
					+ " AND FILC01A_VS.CRD_DT between '"+d1.ToString("yyyy/MM/dd")+"' and '"+d2.ToString("yyyy/MM/dd")+"'";
			PublicFunction.SQL_Execute(swh,PublicFunction.C_con);
            //Transfer();
            Thread th = new Thread(new ThreadStart(Transfer));
            th.Start();
            timer1.Enabled=true;
			timer1.Start();
		}	
		
		#region Transfer
		int vat=0;
		int s=0;
		int p=0;
		int h=0;
		Func.RecordSet rs;
		string table;
		private void Transfer()
		{
            
            DateTime d1 = (DateTime)dt1.Value;
            DateTime d2 = (DateTime)dt2.Value;
            string[] vaora= new string []{"ONN_01","OFF_01","ONN_02","OFF_02","ONN_03","OFF_03","ONN_04","OFF_04","ONN_05","OFF_05","ONN_06","OFF_06","ONN_07","OFF_07","ONN_08","OFF_08","ONN_09","OFF_09","ONN_10","OFF_10"};
            int ngayfrom = Convert.ToInt32(d1.ToString("yyyyMMdd"));
            int ngayto = Convert.ToInt32(d2.ToString("yyyyMMdd"));
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa tất cả dữ liệu kể cả dữ liệu sửa tay hay không?","Thông Báo!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string xoa = "Delete from FILC06A_VS Where ATT_DT between '" + d1.ToString("yyyy/MM/dd") + "' and '" + d2.ToString("yyyy/MM/dd") + "'";
                PublicFunction.SQL_Execute(xoa, PublicFunction.C_con);
            }
            else if (dialogResult == DialogResult.No)
            {
                string xoa = "Delete from FILC06A_VS Where isnull(LCK_BT,0)=0 and ATT_DT between '" + d1.ToString("yyyy/MM/dd") + "' and '" + d2.ToString("yyyy/MM/dd") + "'";
                PublicFunction.SQL_Execute(xoa, PublicFunction.C_con);
            }
            while (ngayfrom <= ngayto)
            {
                string nguoitrongngay = "Select EMP_ID, CRD_TM From FILC01A_VS Where  Convert(Varchar(100),CRD_DT,112) = '" + ngayfrom + "' order by EMP_ID,CRD_TM";
                Func.RecordSet nguoitrongngay_table = new Func.RecordSet(nguoitrongngay, PublicFunction.C_con);
                for (int i = 0; i < nguoitrongngay_table.rows; i++)
                {
                    string xetsodong = "Select * From FILC06A_VS Where ATT_DT = '" + ngayfrom + "' and EMP_ID= '" + nguoitrongngay_table.record(i, "EMP_ID") + "'";
                    Func.RecordSet xetsodong_table = new Func.RecordSet(xetsodong, PublicFunction.C_con);
                    if (xetsodong_table.rows == 0)
                    {
                        try
                        {
                            string themvao = "Insert into FILC06A_VS (EMP_ID,ATT_DT,ONN_01) Values ('" + nguoitrongngay_table.record(i, "EMP_ID") + "','" + ngayfrom + "', '" + nguoitrongngay_table.record(i, "CRD_TM") + "')";
                            PublicFunction.SQL_Execute(themvao, PublicFunction.C_con);
                        }

                        catch
                        { }    
                    }
                    else
                    {
                        try
                        {
                            int socapnhat = T_String.IsNullTo0(T_String.GetDataFromSQL(" case when OFF_01 = 0 then 1 when ONN_02 = 0 then 2 when OFF_02 = 0 then 3 when ONN_03 = 0 then 4 when OFF_03 = 0 then 5 when ONN_04 = 0 then 6 when OFF_04 = 0 then 7 when ONN_05 = 0 then 8 when OFF_05 = 0 then 9 when ONN_06 = 0 then 10 when OFF_06 = 0 then 10 end", " FILC06A_VS", " (EMP_ID = '" + nguoitrongngay_table.record(i, "EMP_ID") + "' and ATT_DT = '" + ngayfrom + "')", PublicFunction.C_con));
                            string updatevao = "Update FILC06A_VS set  " + vaora[socapnhat] + " =";
                            updatevao += " '" + nguoitrongngay_table.record(i, "CRD_TM") + "' Where (EMP_ID = '" + nguoitrongngay_table.record(i, "EMP_ID") + "' and ATT_DT = '" + ngayfrom + "')";
                            PublicFunction.SQL_Execute(updatevao, PublicFunction.C_con);
                        }
                        catch
                        { }
                    }
                }       
                ngayfrom++;
            }
            MessageBox.Show("Finish!");
			tm.Text="00:00:00";
			s=0;
			p=0;
			h=0;
			timer1.Enabled=true;
			timer1.Start();
		}
		Boolean  pr1,pr2;
		#endregion				

		private void Formula(SqlConnection con )
		{
			string sql="";
			sql="Select * from FILC08A where RUN_BT=1 order by SEQ_N1";
			Func.RecordSet rs=new Func.RecordSet(sql,con);
			try
			{
				for(int i=0;i<rs.rows;i++)
				{
					sql=rs.record(i,"SQL_DR");
					if(sql+""!="")
					{
						sql=sql.Replace("FILC06A",table);
						sql=sql.Replace("UserCalAtt",PublicFunction.A_UserID);
						PublicFunction.SQL_Execute(sql,con,true);
					}
				}
				sql="Update FILC06A SET[NOT_DR]=[NOT_DR]+' AbnormalLeave' from FILB01A b, FILC06A a where ( a.EMP_ID=b.EMP_ID) and "+
					"(([ATT_HR]+[NIG_HR]+[LEA_H1]+[LEA_H2])>800 or (([ATT_HR]+[NIG_HR]+[LEA_H1]+[LEA_H2])>760 AND ([ATT_HR]+[NIG_HR]+[LEA_H1]+[LEA_H2])<800)) ";
				sql=sql.Replace("FILC06A",table);				
				PublicFunction.SQL_Execute(sql,con,true);				
					
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}
			

		#region Func
		public  int IsN(Object st1)
		{		
			try
			{ 
				string st=st1+""; 
				if (st+""=="")
					return 0;			
				return Int32.Parse(st=st.Replace(",",""));
			}
			catch(Exception){return 0;}
		}	
		public  Double IsD(Object st1)
		{		
			try
			{ 
				string st=st1+""; 
				if (st+""=="")
					return 0;			
				return Double.Parse(st=st.Replace(",",""));
			}
			catch(Exception){return 0;}
		}	
		#endregion

		private void cmd_for_Click(object sender, System.EventArgs e)
		{
			cmd_for.Enabled=false;
			SqlConnection con=new SqlConnection(PublicFunction.C_con.ConnectionString);
			if(con.State==ConnectionState.Closed )
				con.Open();
			string sql="";
			sql="Select * from FILC08A ";
			Func.RecordSet rs=new Func.RecordSet(sql,con);
			try
			{
				for(int i=0;i<rs.rows;i++)
				{
					sql=rs.record(i,"SQL_DR");
					if(sql+""!="")
					{				
						sql+=" and "+ control1.GetWhere("b")+" and ATT_BT=1";
						PublicFunction.SQL_Execute(sql,con,true);
					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				cmd_for.Enabled=true;
				return;
			}
			MessageBox.Show(PublicFunction.L_Get_Msg("Staff",1));
			cmd_for.Enabled=true;
		}

		private void frmTaCardDataSwitch_Closed(object sender, EventArgs e)
		{
			Stop=true;
		}

		private void panel4_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			s++;
			if(s>=60)
			{
				s=0;
				p++;
			}
			if(p>=60)
			{
				p=0;
				h++;
			}
			tm.Text=h.ToString("00")+":"+p.ToString("00")+":"+s.ToString("00");
		}

		private void frmTaCardDataSwitch_Closed_1(object sender, System.EventArgs e)
		{
			Stop=true;
		}

		private void btnTinhPC_Click(object sender, System.EventArgs e)
		{
			////tinh phu cap 30%
////			SqlConnection con=new SqlConnection(PublicFunction.C_con.ConnectionString);			
////			Common.Ints.CalPhuCap30(con,control1,dt1,dt2,"","");
////			con.Close();
///
			if(PublicFunction.A_UserID =="admin")
			{
				DateTime d1=(DateTime)dt1.Value;
				DateTime d2=(DateTime)dt2.Value;
				if(PublicFunction.GPS)
				{
					Stop=false;			
				}
				timer1.Enabled=true;
				timer1.Start();
			}
		}

	}
}

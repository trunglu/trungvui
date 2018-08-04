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
	public class frmTaCardDataSwitch : System.Windows.Forms.Form
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
		private Int32 HIS_NO;
		//private string table;

		public frmTaCardDataSwitch()
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
			this.err = new System.Windows.Forms.TextBox();
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
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.panel3.Controls.Add(this.label5);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1156, 36);
			this.panel3.TabIndex = 13;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
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
			// tm
			// 
			this.tm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tm.BackColor = System.Drawing.Color.Black;
			this.tm.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
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
			this.c4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
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
			this.label6.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label6.Dock = System.Windows.Forms.DockStyle.Top;
			this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
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
			this.c2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
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
			this.c3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
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
			this.label4.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label4.Dock = System.Windows.Forms.DockStyle.Top;
			this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
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
			this.c1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
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
			this.control1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
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
			this.label2.TabIndex = 151;
			this.label2.Text = "label2";
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
			this.err.Text = "";
			this.err.Visible = false;
			// 
			// frmTaCardDataSwitch
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(1156, 706);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaCardDataSwitch";
			this.Text = "frmTaCardDataSwitch";
			this.Load += new System.EventHandler(this.frmTaCardDataSwitch_Load);
			this.Closed += new System.EventHandler(this.frmTaCardDataSwitch_Closed_1);
			this.panel3.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
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
			if(PublicFunction.GPS)
			{
				Stop=false;					
//				while(T_String.IsNullTo0(d1.ToString("yyyyMMdd"))<=T_String.IsNullTo0(d2.ToString("yyyyMMdd")))// tung Ngay
//				{
//					string wh=  " EMP_ID in (select DISTINCT EMP_ID from FILB01A where " +control1.GetWhere("",false)
//						+") and ( ATT_DT between '"+d1.ToString("yyyy/MM/dd")+"' and '"+d1.ToString("yyyy/MM/dd")+"')";
//					string sql="delete from FILC06A where "+wh;
//					
//					PublicFunction.SQL_Execute(sql);
//					d1=d1.AddDays(1);
//				}				
				Thread th1=new Thread(new ThreadStart(Transfer_GPS));
				th1.Start();
				//Transfer_GPS();
//				Thread th2=new Thread(new ThreadStart(Transfer_GPS1));
//				th2.Start();
			}
			else
			{
				string swh="UPDATE FILC01A SET EMP_ID=E.EMP_ID FROM FILB01A E WHERE FILC01A.CRD_NO=E.CRD_NO AND FILC01A.CRD_NO=''"
						+ " AND FILC01A.CRD_DT between '"+d1.ToString("yyyy/MM/dd")+"' and '"+d2.ToString("yyyy/MM/dd")+"'";
				PublicFunction.SQL_Execute(swh,PublicFunction.C_con);
				Thread th=new Thread(new ThreadStart(Transfer));
				th.Start();
//				Transfer();
			}
			timer1.Enabled=true;
			timer1.Start();

		}

		

		#region GPS
		private void Transfer_GPS()
		{
			tt1=false;
			c1.Text="";
			c3.Text="";
			string sql="";
			SqlConnection conGPS=new SqlConnection(PublicFunction.C_con.ConnectionString);
			conGPS.Open();
			SqlConnection conGP=PublicFunction.connect(PublicFunction.DTGP_server,PublicFunction.DTGP_database
				,PublicFunction.DTGP_username,PublicFunction.DTGP_password);
			if(!Func.Fun.CheckFieldOfTable(conGPS,"FILC06A","hqtan_TT"))
			{
				sql="Alter table FILC06A Add [hqtan_TT] float default(0)";
				PublicFunction.SQL_Execute(sql,conGPS);
			}
//			if(!Func.Fun.CheckFieldOfTable(conGPS,"FILC06AS","hqtan_TT1"))
//			{
//				sql="Alter table FILC06A Add [hqtan_TT1] float default(0)";
//				PublicFunction.SQL_Execute(sql,conGPS);
//			}
			string table="FILC06A_"+PublicFunction.A_UserID;
			sql="Drop Table ["+table+"]";
			try
			{
				PublicFunction.SQL_Execute(sql,conGPS);
			}
			catch{}
			PublicFunction.Copy_Table("FILC06A",table,conGPS);

			
			cmd_att.Enabled=false;

			DateTime d1=(DateTime)dt1.Value;
			DateTime d2=(DateTime)dt2.Value;			
			string wh=  " EMP_ID in (select DISTINCT EMP_ID from FILB01A where " +control1.GetWhere("",false)
				+") and ( ATT_DT between '"+d1.ToString("yyyy/MM/dd")+"' and '"+d2.ToString("yyyy/MM/dd")+"')";
//			sql="delete from FILC06A where "+wh;
//			PublicFunction.SQL_Execute(sql,conGPS,true);

			ImportTable(true,"FILC06A",table,conGP,conGPS,true,true,true,label4,pro1,wh);		
			
			string sql1="Select * from FILC08A where RUN_BT=1 order by SEQ_N1";
			Func.RecordSet rs=new Func.RecordSet(sql1,conGPS);
			//SSSSSPG
			if(T_String.GetDataFromSQL("WEE_BY","FILC14A",conGP)=="False")
				GPSSSSSSS(table,conGPS,conGP,true,label4,pro1);
			else
				GPSSSSSSS(table,conGPS,conGP,false,label4,pro1);
			// Formula
			c1.Text="*** Formula ***";
			try
			{
				for(int i=0;i<rs.rows;i++)
				{
					if(Stop)
						return;
					sql=rs.record(i,"SQL_DR");
					if(sql+""!="")
					{					
						sql=sql.Replace("FILC06A",table);
						PublicFunction.SQL_Execute(sql,conGPS,true);
					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
//			wh=  " EMP_ID in (select DISTINCT EMP_ID from FILB01A where " +control1.GetWhere("",false)
//				+") and ( ATT_DT between '"+d1.ToString("yyyy/MM/dd")+"' and '"+d2.ToString("yyyy/MM/dd")+"')";
			sql="delete from FILC06A where "+wh;
//			sql = "SET ROWCOUNT 1000 \r\n"
//			+ "WHILE 1=1 \r\n"
//			+ "BEGIN \r\n"
//			+ "DELETE FROM FILC06A WHERE EMP_ID IN (SELECT DISTINCT EMP_ID FROM [" + table + "])"
//			+ " AND ATT_DT BETWEEN '" + ((DateTime)dt1.Value).ToString("yyyy/MM/dd") 
//			+ "' AND '" + ((DateTime)dt2.Value).ToString("yyyy/MM/dd") + "' AND ISNULL(LOC_BT,0)=0 AND ISNULL(LOC_B1,0)=0 \r\n"
//			+ " IF @@ROWCOUNT=0 BREAK \r\n"
//			+ "END \r\n"
//			+ "SET ROWCOUNT 0";
			PublicFunction.SQL_Execute(sql,conGPS,true);

			sql="Insert into FILC06A select * from ["+table+"]";
			PublicFunction.SQL_Execute(sql,conGPS,true);

			//Khoi tao lai ban dau	
			cmd_att.Enabled=true;
			timer1.Stop();
			timer1.Enabled=false;	
			conGP.Close();
			conGPS.Close();
	
			c3.Text=PublicFunction.L_Get_Msg("Staff",1);	
			MessageBox.Show(PublicFunction.L_Get_Msg("Staff",1));			
			
		}
		
		Boolean tt1=false,tt2=false;
		private void Transfer_GPS1()
		{		
			//return;
			tt2=false;
			c1.Text="";
			c3.Text="";
			string sql="";
			SqlConnection conGPS=new SqlConnection(PublicFunction.C_con.ConnectionString);
			conGPS.Open();
			SqlConnection conGP=PublicFunction.connect(PublicFunction.DTGP_server,PublicFunction.DTGP_database
				,PublicFunction.DTGP_username,PublicFunction.DTGP_password);
			if(!Func.Fun.CheckFieldOfTable(conGPS,"FILC06A","hqtan_TT"))
			{
				sql="Alter table FILC06A Add [hqtan_TT] float default(0)";
				PublicFunction.SQL_Execute(sql,conGPS);
			}
			if(!Func.Fun.CheckFieldOfTable(conGPS,"FILC06A","hqtan_TT1"))
			{
				sql="Alter table FILC06A Add [hqtan_TT1] float default(0)";
				PublicFunction.SQL_Execute(sql,conGPS);
			}
			string table="FILC06A_2_"+PublicFunction.A_UserID;
			sql="Drop Table ["+table+"]";
			try
			{
				PublicFunction.SQL_Execute(sql,conGPS);
			}
			catch{}
			PublicFunction.Copy_Table("FILC06A",table,conGPS);

		
			cmd_att.Enabled=false;

			DateTime d1=(DateTime)dt1.Value;
			DateTime d2=(DateTime)dt2.Value;	
		
			//Xoa lan nua cho chac an
			string wh=  " EMP_ID in (select DISTINCT EMP_ID from FILB01A where " +control1.GetWhere("",false)
				+") and ( ATT_DT between '"+d1.ToString("yyyy/MM/dd")+"' and '"+d2.ToString("yyyy/MM/dd")+"')";
			sql="delete from FILC06A where "+wh;
			PublicFunction.SQL_Execute(sql,conGPS,true);

			ImportTable1(false,"FILC06A",table,conGP,conGPS,true,true,true,label6,pro3,wh);		
			
			string sql1="Select * from FILC08A where RUN_BT=1 order by SEQ_N1";
			Func.RecordSet rs=new Func.RecordSet(sql1,conGPS);
			//SSSSSPG
			if(T_String.GetDataFromSQL("WEE_BY","FILC14A",conGP)=="False")
				GPSSSSSSS1(table,conGPS,conGP,true,label6,pro3);
			else
				GPSSSSSSS1(table,conGPS,conGP,false,label6,pro3);
			// Formula
			c1.Text="*** Formula ***";
			try
			{
				for(int i=0;i<rs.rows;i++)
				{
					if(Stop)
						return;
					sql=rs.record(i,"SQL_DR");
					if(sql+""!="")
					{					
						sql=sql.Replace("FILC06A",table);
						PublicFunction.SQL_Execute(sql,conGPS,true);
					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			sql="Insert into FILC06A select * from ["+table+"]";
			PublicFunction.SQL_Execute(sql,conGPS,true);
		
			tt2=true;
			if(tt1 && tt2)
			{
			
				cmd_att.Enabled=true;
				timer1.Stop();
				timer1.Enabled=false;	
				conGP.Close();
				conGPS.Close();
		
				c3.Text=PublicFunction.L_Get_Msg("Staff",1);	
				MessageBox.Show(PublicFunction.L_Get_Msg("Staff",1));
			}	
			
		}

		private void GPSSSSSSS(string tb,SqlConnection conGPS,SqlConnection conGP,Boolean t,Label lb,ProgressBar pro)
		{
			DateTime d1=(DateTime)dt1.Value;
			DateTime d2=(DateTime)dt2.Value;
			Func.RecordSet rsa=new Func.RecordSet("Select * from ["+tb+"]",conGPS);
			if(t)
			{
				
				for(int i=0;i<rsa.rows;i++)
				{
					if(Stop)
						return;
					d1=DateTime.Parse(rsa.record(i,"ATT_DT"));
					string sql="";
					if(PublicFunction.GetOption("GPS_DEP")=="1")
					{
						string sdep=T_String.GetDataFromSQL("DEP_ID","FILB01A","EMP_ID='"+rsa.record(i,"EMP_ID")+"'");
						sql="select h"+d1.Day+" from FILC13A_DEP where YYY_MM=N'"+d1.Year.ToString("0000")+d1.Month.ToString("00")+"'";
						sql+=" AND DEP_ID='"+sdep+"'";
					}					
					else
						sql="select h"+d1.Day+" from FILC13A where YYY_YY=N'"+d1.Year.ToString("0000")+"' and MMM_MM="+d1.Month;
					Func.RecordSet rs=new Func.RecordSet(sql,conGP);
					if(rs.rows>0 && rs.record(0,0)!="" && rs.record(0,0)!=null)
						CALGPS(rsa,i,tb,rs.record(0,0),d1.ToString("yyyy/MM/dd"),conGPS,conGP);
					d1=d1.AddDays(1);
					lb.Text= rsa.record(i,"EMP_ID")+" | "+d1.ToString("yyyy/MM/dd")+ " _ " +(i+1)+"/"+rsa.rows+" records. ";
					pro.Value=(int)((i+1)*100/rsa.rows);								
				}							
			}
			else
			{
				
				for(int i=0;i<rsa.rows;i++)
				{
					if(Stop)
						return;
					d1=DateTime.Parse(rsa.record(i,"ATT_DT"));
					string sql="";
					switch(d1.DayOfWeek.ToString())
					{
						case "Monday":
							sql="1";
							break;
						case "Tuesday":
							sql="2";
							break;
						case "Wednesday":
							sql="3";
							break;
						case "Thursday":
							sql="4";
							break;
						case "Friday":
							sql="5";
							break;
						case "Saturday":
							sql="6";
							break;
						case "Sunday":
							sql="7";
							break;
					}
					sql="select h"+sql+" from FILC14A where YYY_YY=N'qtan'";
					Func.RecordSet rs=new Func.RecordSet(sql,conGP);					
					if(rs.rows>0 && rs.record(0,0)!="" && rs.record(0,0)!=null)
						CALGPS(rsa,i,tb,rs.record(0,0),d1.ToString("yyyy/MM/dd"),conGPS,conGP);					
					lb.Text= rsa.record(i,"EMP_ID")+" | "+d1.ToString("yyyy/MM/dd")+ " _ " +(i+1)+"/"+rsa.rows+" records. ";
					pro.Value=(int)((i+1)*100/rsa.rows);		
					d1=d1.AddDays(1);

				}
			}
			lb.Text= rsa.rows+"/"+rsa.rows+" records. ";
			pro.Value=100;	
		}
		private void GPSSSSSSS1(string tb,SqlConnection conGPS,SqlConnection conGP,Boolean t,Label lb,ProgressBar pro)
		{
			DateTime d1=(DateTime)dt1.Value;
			DateTime d2=(DateTime)dt2.Value;
			Func.RecordSet rsa=new Func.RecordSet("Select * from ["+tb+"]",conGPS);
			if(t)
			{
				//				while(T_String.IsNullTo0(d1.ToString("yyyyMMdd"))<=T_String.IsNullTo0(d2.ToString("yyyyMMdd")))// tung Ngay
				//				{
				for(int i=0;i<rsa.rows;i++)
				{
					if(Stop)
						return;
					d1=DateTime.Parse(rsa.record(i,"ATT_DT"));
					string sql="select h"+d1.Day+" from FILC13A where YYY_YY=N'"+d1.Year.ToString("0000")+"' and MMM_MM="+d1.Month;
					Func.RecordSet rs=new Func.RecordSet(sql,conGP);
					if(rs.rows>0 && rs.record(0,0)!="" && rs.record(0,0)!=null)
						CALGPS(rsa,i,tb,rs.record(0,0),d1.ToString("yyyy/MM/dd"),conGPS,conGP);
					d1=d1.AddDays(1);
					lb.Text= rsa.record(i,"EMP_ID")+" | "+d1.ToString("yyyy/MM/dd")+ " _ " +(i+1)+"/"+rsa.rows+" records. ";
					pro.Value=(int)((i+1)*100/rsa.rows);								
				}							
			}
			else
			{
				//				while(T_String.IsNullTo0(d1.ToString("yyyyMMdd"))<=T_String.IsNullTo0(d2.ToString("yyyyMMdd")))// tung Ngay
				//				{	
				for(int i=0;i<rsa.rows;i++)
				{
					if(Stop)
						return;
					d1=DateTime.Parse(rsa.record(i,"ATT_DT"));
					string sql="";
					switch(d1.DayOfWeek.ToString())
					{
						case "Monday":
							sql="1";
							break;
						case "Tuesday":
							sql="2";
							break;
						case "Wednesday":
							sql="3";
							break;
						case "Thursday":
							sql="4";
							break;
						case "Friday":
							sql="5";
							break;
						case "Saturday":
							sql="6";
							break;
						case "Sunday":
							sql="7";
							break;
					}
					sql="select h"+sql+" from FILC14A where YYY_YY=N'qtan'";
					Func.RecordSet rs=new Func.RecordSet(sql,conGP);					
					if(rs.rows>0 && rs.record(0,0)!="" && rs.record(0,0)!=null)
						CALGPS(rsa,i,tb,rs.record(0,0),d1.ToString("yyyy/MM/dd"),conGPS,conGP);					
					lb.Text= rsa.record(i,"EMP_ID")+" | "+d1.ToString("yyyy/MM/dd")+ " _ " +(i+1)+"/"+rsa.rows+" records. ";
					pro.Value=(int)((i+1)*100/rsa.rows);		
					d1=d1.AddDays(1);

				}
			}
			lb.Text= rsa.rows+"/"+rsa.rows+" records. ";
			pro.Value=100;	
		}

		private void CALGPS(Func.RecordSet rs,int r,string tb,string GRP_FO,string ngay,SqlConnection conGPS,SqlConnection conGP)
		{
			string sql="";			
			sql="select * from FILC12B where GRP_FO=N'"+GRP_FO+"' order by SEQ_NO";
			Func.RecordSet rsf=new Func.RecordSet(sql,conGP);
			sql="";
			string EMP_ID=rs.record(r,"EMP_ID");
			string vl;
			for(int i=0;i<rsf.rows;i++)
			{
				string col1=rsf.record(i,"COL_NM1"),col2=rsf.record(i,"COL_NM2"),fun=rsf.record(i,"FUN_ID");
				double gio=T_String.IsNullTo00(rsf.record(i,"CON_DR"));
				if(fun!="")
				{
					sql="select SQL_DR from FILC11A where FUN_ID=N'"+fun+"'";
					Func.RecordSet rsff=new Func.RecordSet(sql,conGP);
					if(rsff.rows>0)
					{
						sql=rsff.record(0,0);
						sql=sql.Replace("FILC06A",tb);
						sql+=" and "+tb+".ATT_DT='"+ngay+"' and "+tb+".EMP_ID=N'"+EMP_ID+"'";
						PublicFunction.SQL_Execute(sql,conGPS,true);
					}
				}
				else
				{
					if(col1!=""  && col2!="")
					{					
						sql="update ["+tb+"] set ["+col2+"]=";
						vl="(FLOOR(["+col2+"]/100)+(["+col2+"]/100-FLOOR(["+col2+"]/100))/0.6)";
						vl="("+vl+"+ (FLOOR(["+col1+"]/100)+(["+col1+"]/100-FLOOR(["+col1+"]/100))/0.6)-"+gio+")";
						vl= "FLOOR("+vl+") * 100 + ("+vl+" - FLOOR("+vl+")) * 60";
						sql+="("+vl+")";
						sql+=" , ";
						sql+="[hqtan_TT]=";
						vl="(FLOOR([hqtan_TT]/100)+([hqtan_TT]/100-FLOOR([hqtan_TT]/100))/0.6)";
						vl="("+vl+"+ (FLOOR(["+col1+"]/100)+(["+col1+"]/100-FLOOR(["+col1+"]/100))/0.6)-"+gio+")";
						vl= "FLOOR("+vl+") * 100 + ("+vl+" - FLOOR("+vl+")) * 60";
						sql+="("+vl+")";
						sql+=" , ";
						sql+="["+col1+"]=";
						vl= "FLOOR("+gio+") * 100 + ("+gio+" - FLOOR("+gio+")) * 60";
						sql+=vl+" where "+col1+">"+vl;
						sql+=" and ATT_DT='"+ngay+"' and EMP_ID=N'"+EMP_ID+"'";
						PublicFunction.SQL_Execute(sql,conGPS,true);
						//vl="(FLOOR(["+Item+"]/100)+(["+Item+"]/100-FLOOR(["+Item+"]/100))/0.6);	
						//vl= "FLOOR("+vl+") * 100 + ("+vl+" - FLOOR("+vl+")) * 60";
					}
				}
			}

			ArrayList ATT=new ArrayList();
			for(int i=1;i<=10;i++)
			{
				ATT.Add(T_String.IsNullTo00(rs.record(r,"ONN_"+i.ToString("00"))));	
				ATT.Add(T_String.IsNullTo00(rs.record(r,"OFF_"+i.ToString("00"))));	
			}	

			double NIG_TM=T_String.IsNullTo00(rs.record(r,"NIG_TM"));
			Boolean QD=false;
			ArrayList AT=new ArrayList();
			int dem=0;
			for(int i=0;i<ATT.Count;i++)
			{
				if(IsN(ATT[i]+"")!=0)
				{
					double st=IsD(ATT[i]+"");
					if(i>=NIG_TM-1 && NIG_TM>0 )//&& QD==true)
						st=st+2400;
					dem++;
					AT.Add(st);					
				}
			}
			Double giove=T_String.IsNullTo00(T_String.GetDataFromSQL("OFF_TM","FILC02A","SHI_ID=N'"+
				rs.record(r,"SHI_ID")+"'",conGP)) ;
			Double max=T_String.IsNullTo00(T_String.GetDataFromSQL("ADD_HR","FILC12A","GRP_FO=N'"+
				GRP_FO+"'",conGP)) ;
			Double giovao=T_String.IsNullTo00(T_String.GetDataFromSQL("ONN_TM","FILC02A","SHI_ID=N'"+
				rs.record(r,"SHI_ID")+"'",conGP)) ;
			Double gioOT=T_String.IsNullTo00(T_String.GetDataFromSQL("OTT_HR+NIG_OT",tb,"EMP_ID=N'"+
				EMP_ID+"' AND ATT_DT='"+ngay+"'",conGPS)) ;
			Double giolam=T_String.IsNullTo00( T_String.GetDataFromSQL("ATT_HR","FILC06A","EMP_ID=N'"+
				EMP_ID+"' AND ATT_DT='"+ngay+"'",conGP))+ T_String.IsNullTo00( T_String.GetDataFromSQL("NIG_HR","FILC06A","EMP_ID=N'"+
				EMP_ID+"' AND ATT_DT='"+ngay+"'",conGP)) ;

			max= (((int)max)*100)+ ( (max -((int)max))*60);

			
			giove=T_String.CongTG(giove,max);
			if (giolam>0  )
			{
				giove=T_String.CongTG(giove,gioOT);
			}
			if (giovao>0 && AT.Count>0 && giolam>0 )
			{
				if (T_String.IsNullTo0( AT[0]+"")>0)
					AT[0]=T_String.CongTG(giovao,T_String.IsNullTo0(AT[0].ToString().Substring(AT[0].ToString().Length-1)));
			}
			dem=0;
			int f=-1;
			Double tam=0; 
			for(int i=AT.Count-1;i>0;i--)
			{
				Double t=T_String.IsNullTo00(AT[i]+"");
				if(t>=giove )
				{
//					AT[i]=0;
					dem++;
					f=i;
					tam=t;
				}
			}
			if(dem%2!=0 && f>0 && giolam>=8 )
			{
				AT[f]=T_String.CongTG(giove, T_String.IsNullTo00( PublicFunction.S_Right(tam+"",1)));
				// THU THEM CHO NHUNG th QUET THE NHIEU LAN
				if(f<AT.Count) 
				{
					for(int tt=f+1;tt<AT.Count ;tt++)
						AT[tt]=0;					
				}
			}

			sql="";
			string values="";
			for(int i=1;i<=10;i++)
			{			
				if(values!="")
					values+=",";
				if((i*2)-2>=AT.Count)
					values+="ONN_"+i.ToString("00") +"=0";
				else
					values+="ONN_"+i.ToString("00")+"=" +AT[(i*2)-2];	

				if((i*2)-1>=AT.Count)					
					values+=",OFF_"+i.ToString("00") +"=0";
				else
				{
					values+=",OFF_"+i.ToString("00") +"="+AT[(i*2)-1];					
				}
			}
			sql="update ["+tb+"] set " + values +" where ATT_DT='"+ngay+"' and EMP_ID=N'"+EMP_ID+"'";
			PublicFunction.SQL_Execute(sql,conGPS,true);


		}
		
		
		#endregion
		
		#region GPS_FUNC
		//		private void ATT_HR(string tb,Func.RecordSet rs,int r,string ngay,SqlConnection conGPS,SqlConnection conGP)
		//		{
		//
		//			Func.RecordSet rsTypeShift=new Func.RecordSet("Select * from GP_SYS_SHIFT",conGPS);
		//			Func.RecordSet Set=new Func.RecordSet("Select * from GP_SYS_SETTING",conGPS);	
		//			SqlConnection con=new SqlConnection(PublicFunction.C_con.ConnectionString);
		//			if(con.State==ConnectionState.Closed )
		//				con.Open();			
		//			for(int i=0;i<rs.rows;i++)
		//			{
		//						
		//				string EMP_ID=rs.record(i,"EMP_ID");
		//				DateTime d1=DateTime.Parse(rs.record(i,"ATT_DT"));
		//
		//				string SHI_ID=rs.record(i,"SHI_ID");
		//				string sql="Select * from FILC02B where SHI_ID=N'"+SHI_ID+"' ORDER BY SEQ_NO";
		//				Func.RecordSet rsca=new Func.RecordSet(sql,conGP);	
		//				
		//				ArrayList Ca=new ArrayList();
		//				ArrayList ATT=new ArrayList();
		//				for(int j=0;j<rsca.rows;j++)
		//				{
		//					Ca.Add(rsca.record(j,"ONN_TM"));
		//					Ca.Add(rsca.record(j,"OFF_TM"));
		//				}
		//				Ca.Add(0);
		//				Ca.Add(0);
		//				Ca.Add(0);
		//				Ca.Add(0);
		//				for(int j=1;j<=10;j++)
		//				{
		//					ATT.Add(T_String.IsNullTo00(rs.record(i,"ONN_"+j.ToString("00"))));	
		//					ATT.Add(T_String.IsNullTo00(rs.record(i,"OFF_"+j.ToString("00"))));	
		//				}	
		//				TaAttendanceGPS tm=new TaAttendanceGPS(EMP_ID,d1.ToString("yyyy/MM/dd"),conGPS,Ca,ATT,SHI_ID,rsca,Set,rsTypeShift);			
		//				tm.tb=tb;
		//				tm.NIG_TM=T_String.IsNullTo00(rs.record(i,"NIG_TM"));				
		//				tm.Data1=new ArrayList();				
		//				for(int z=0;z<rsTypeShift.rows;z++)
		//				{
		//					tm.Name.Add(rsTypeShift.record(z,0));
		//					tm.Data1.Add(T_String.IsNullTo00(rs.record(i,rsTypeShift.record(z,0))));
		//				}
		//				tm.UpdateSql();											
		//			}			
		//		}
		private void ATT_HR1(string tb,Func.RecordSet rs,int r,string ngay,SqlConnection conGPS,SqlConnection conGP)
		{

			//			
			//
			//			double hqtan_TT=T_String.IsNullTo00(rs.record(r,"hqtan_TT"));
			//			if(hqtan_TT<=0)
			//				return;
			//			string SHI_ID=rs.record(r,"SHI_ID");
			//			Func.RecordSet rsca=new Func.RecordSet("select * from FILC02B where SHI_ID=N'"+SHI_ID+"' order by SEQ_NO",conGP);
			//			ArrayList ATT=new ArrayList();
			//			for(int i=1;i<=10;i++)
			//			{
			//				ATT.Add(T_String.IsNullTo00(rs.record(r,"ONN_"+i.ToString("00"))));
			//				ATT.Add(T_String.IsNullTo00(rs.record(r,"OFF_"+i.ToString("00"))));
			//			}
			//
			//			double NIG_TM=T_String.IsNullTo00(vs.Rows[i]["NIG_TM"]+"");
			//			int dem=0;
			//			for(int i=0;i<ATT.Count;i++)
			//			{
			//				if(IsN(ATT[i]+"")!=0)
			//				{
			//					double st=IsD(ATT[i]+"");
			//					if(i>=NIG_TM-1 && NIG_TM>0 && QD==true)
			//						st=st+2400;
			//					dem++;
			//					AT.Add(st);
			//					if(st>maxmax)
			//						maxmax=st;
			//				}
			//			}
		}
		#endregion
		#region Import_data_from_GP_ToGPS
		private void ImportTable(Boolean dau,string tablefr,string table,SqlConnection confr,SqlConnection conto,Boolean insert,Boolean update,Boolean delete,Label lb,ProgressBar pro,string wh1)		
		{			
			ArrayList fname=new ArrayList();
			ArrayList key=new ArrayList();
			ArrayList type=new ArrayList();
			ArrayList pic=new ArrayList();
			string sql,sql1,wh,st,st1;
			if (!PublicFunction.CheckFieldOfTable(conto,table))
				return;			

			sql="select * from "+tablefr+" where "+wh1;
			Func.RecordSet  rs=new Func.RecordSet(sql,confr);
			sql="Insert Into ["+table+"] (";
			for(int i=0;i<rs.cols;i++)
			{		
				if (Func.Fun.CheckFieldOfTable(conto,table,rs.Field(i)))
				{
					fname.Add(rs.Field(i));
					key.Add(Func.Fun.CheckPrimaryKey(conto,table,rs.Field(i)));
					st=Func.Fun.GetTypeField(conto,table,rs.Field(i));
					type.Add(st);
					if (i!=0) sql+=",";
					sql+="["+rs.Field(i)+"]";	
					if (st=="6")
						pic.Add(rs.Field(i));			
				}
			}
			int fr=0,to=0,tc=0;			
			
//			if(dau)
//			{				
				fr=0;
				to=rs.rows;
//				if(rs.rows==1)
//					to=rs.rows;
//				else
//					to=rs.rows/2;
				tc=to;
//			}
//			else
//			{
//				if(rs.rows>1)
//				{
//					fr=rs.rows/2;
//					to=rs.rows;
//				}
//				tc=to-fr;
//			}

			sql+=") values(";
			for(int j=fr;j<to;j++)
			{				
				if(Stop)
				{
					return;
				}
				sql1="";wh="";st1="";
				for(int i=0;i<fname.Count;i++)
				{	
				
					//insert
					if (sql1!="") sql1+=",";
					
					if (pic.IndexOf(fname[i]+"")>=0 || rs.record(j,fname[i]+"")==null || rs.record(j,fname[i]+"")=="" )			
					{
						if ((Boolean)key[i])
							sql1= sql1 + "''";
						else
							sql1= sql1 + "Default";
					}
						// Get TypeName of Field,  return {1 (nvarchar,char..), 2 (datetime), 3 (bit), 4 (float), 5 (int)}					
					else
					{						
						switch ((string)type[i])// DataType
						{
							case "1":
								sql1=sql1+"N'" + T_String.sqlsql(rs.record(j,fname[i]+"")) +"'";
								break;
							case "2":						
								sql1=sql1+"'"+ DateTime.Parse(rs.record(j,fname[i]+"")).ToString("yyyy/MM/dd HH:mm:ss")+"'";
								break;
							case "3":
								if (rs.record(j,fname[i]+"")=="True")
									sql1=sql1+ "1";
								else if (rs.record(j,fname[i]+"")=="False")
									sql1=sql1+"0";
								else
									sql1=sql1+ rs.record(j,fname[i]+"");
								break;												
							case "4":
								sql1=sql1 + rs.record(j,fname[i]+"");
								break;
							case "5":
								sql1=sql1 + rs.record(j,fname[i]+"");
								break;
							default:
								sql1=sql1+"N'" + T_String.sqlsql(rs.record(j,fname[i]+"")) +"'";					
								break;
						}
					}
					
					//Delete
					if ((Boolean)key[i])
					{
						if (wh!="") wh+=" and ";
						
						// Get TypeName of Field,  return {1 (nvarchar,char..), 2 (datetime), 3 (bit), 4 (float), 5 (int)}
						switch ((string)type[i])// DataType
						{
							case "1":
								wh=wh+fname[i]+"=N'" + T_String.sqlsql(rs.record(j,fname[i]+"")) +"'";
								break;
							case "2":						
								wh=wh+fname[i]+"='"+ DateTime.Parse(rs.record(j,fname[i]+"")).ToString("yyyy/MM/dd HH:mm:ss")+"'";
								break;
							case "3":
								if (rs.record(j,fname[i]+"")=="True")
									wh=wh+fname[i]+ "=1";
								else if (rs.record(j,fname[i]+"")=="False")
									wh=wh+fname[i]+"=0";
								else
									wh=wh+fname[i]+"="+ rs.record(j,fname[i]+"");
								break;												
							case "4":
								wh=wh+fname[i]+"=" + rs.record(j,fname[i]+"");
								break;
							case "5":
								wh=wh+fname[i]+"=" + rs.record(j,fname[i]+"");
								break;
							default:
								wh=wh+fname[i]+"=N'" + T_String.sqlsql(rs.record(j,fname[i]+"")) +"'";					
								break;
						}
					}
					if ((Boolean)key[i])
					{
						if (st1!="") st1+=" and ";
						if (Func.Fun.GetTypeField(conto,table,fname[i]+"")=="2")
						{
							if (rs.record(j,fname[i]+"")+""=="")
								st1+=fname[i]+"=''";
							else
								st1+=fname[i]+"='"+  DateTime.Parse(rs.record(j,fname[i]+"")).ToString("yyyy/MM/dd HH:mm:ss") +"'";
						}
						else
						{
							st1+=fname[i]+"='"+  T_String.sqlsql(rs.record(j,fname[i]+""))+"'";
						}
					}
				}				
								
				PublicFunction.SQL_Execute(sql+sql1+")",conto);												

				lb.Text= rs.record(j,"EMP_ID")+ " _ " +j+"/"+tc+" records. ";
				pro.Value=(int)(j*100/tc);								
			}
			lb.Text= tc+"/"+tc+" records. ";
			pro.Value=100;	
		}

		private void ImportTable1(Boolean dau,string tablefr,string table,SqlConnection confr,SqlConnection conto,Boolean insert,Boolean update,Boolean delete,Label lb,ProgressBar pro,string wh1)		
		{			
			ArrayList fname=new ArrayList();
			ArrayList key=new ArrayList();
			ArrayList type=new ArrayList();
			ArrayList pic=new ArrayList();
			string sql,sql1,wh,st,st1;
			if (!PublicFunction.CheckFieldOfTable(conto,table))
				return;			

			sql="select * from "+tablefr+" where "+wh1;
			Func.RecordSet  rs=new Func.RecordSet(sql,confr);
			sql="Insert Into ["+table+"] (";
			for(int i=0;i<rs.cols;i++)
			{		
				if (Func.Fun.CheckFieldOfTable(conto,table,rs.Field(i)))
				{
					fname.Add(rs.Field(i));
					key.Add(Func.Fun.CheckPrimaryKey(conto,table,rs.Field(i)));
					st=Func.Fun.GetTypeField(conto,table,rs.Field(i));
					type.Add(st);
					if (i!=0) sql+=",";
					sql+="["+rs.Field(i)+"]";	
					if (st=="6")
						pic.Add(rs.Field(i));			
				}
			}
			int fr=0,to=0,tc=0;			
			
//			if(dau)
//			{				
				fr=0;
				to=rs.rows;
//				if(rs.rows==1)
//					to=rs.rows;
//				else
//					to=rs.rows/2;
				tc=to;
//			}
//			else
//			{
//				if(rs.rows>1)
//				{
//					fr=rs.rows/2;
//					to=rs.rows;
//				}
//				tc=to-fr;
//			}

			sql+=") values(";
			for(int j=fr;j<to;j++)
			{				
				if(Stop)
				{
					return;
				}
				sql1="";wh="";st1="";
				for(int i=0;i<fname.Count;i++)
				{	
				
					//insert
					if (sql1!="") sql1+=",";
					
					if (pic.IndexOf(fname[i]+"")>=0 || rs.record(j,fname[i]+"")==null || rs.record(j,fname[i]+"")=="" )			
					{
						if ((Boolean)key[i])
							sql1= sql1 + "''";
						else
							sql1= sql1 + "Default";
					}
						// Get TypeName of Field,  return {1 (nvarchar,char..), 2 (datetime), 3 (bit), 4 (float), 5 (int)}					
					else
					{						
						switch ((string)type[i])// DataType
						{
							case "1":
								sql1=sql1+"N'" + T_String.sqlsql(rs.record(j,fname[i]+"")) +"'";
								break;
							case "2":						
								sql1=sql1+"'"+ DateTime.Parse(rs.record(j,fname[i]+"")).ToString("yyyy/MM/dd HH:mm:ss")+"'";
								break;
							case "3":
								if (rs.record(j,fname[i]+"")=="True")
									sql1=sql1+ "1";
								else if (rs.record(j,fname[i]+"")=="False")
									sql1=sql1+"0";
								else
									sql1=sql1+ rs.record(j,fname[i]+"");
								break;												
							case "4":
								sql1=sql1 + rs.record(j,fname[i]+"");
								break;
							case "5":
								sql1=sql1 + rs.record(j,fname[i]+"");
								break;
							default:
								sql1=sql1+"N'" + T_String.sqlsql(rs.record(j,fname[i]+"")) +"'";					
								break;
						}
					}
					
					//Delete
					if ((Boolean)key[i])
					{
						if (wh!="") wh+=" and ";
						
						// Get TypeName of Field,  return {1 (nvarchar,char..), 2 (datetime), 3 (bit), 4 (float), 5 (int)}
						switch ((string)type[i])// DataType
						{
							case "1":
								wh=wh+fname[i]+"=N'" + T_String.sqlsql(rs.record(j,fname[i]+"")) +"'";
								break;
							case "2":						
								wh=wh+fname[i]+"='"+ DateTime.Parse(rs.record(j,fname[i]+"")).ToString("yyyy/MM/dd HH:mm:ss")+"'";
								break;
							case "3":
								if (rs.record(j,fname[i]+"")=="True")
									wh=wh+fname[i]+ "=1";
								else if (rs.record(j,fname[i]+"")=="False")
									wh=wh+fname[i]+"=0";
								else
									wh=wh+fname[i]+"="+ rs.record(j,fname[i]+"");
								break;												
							case "4":
								wh=wh+fname[i]+"=" + rs.record(j,fname[i]+"");
								break;
							case "5":
								wh=wh+fname[i]+"=" + rs.record(j,fname[i]+"");
								break;
							default:
								wh=wh+fname[i]+"=N'" + T_String.sqlsql(rs.record(j,fname[i]+"")) +"'";					
								break;
						}
					}
					if ((Boolean)key[i])
					{
						if (st1!="") st1+=" and ";
						if (Func.Fun.GetTypeField(conto,table,fname[i]+"")=="2")
						{
							if (rs.record(j,fname[i]+"")+""=="")
								st1+=fname[i]+"=''";
							else
								st1+=fname[i]+"='"+  DateTime.Parse(rs.record(j,fname[i]+"")).ToString("yyyy/MM/dd HH:mm:ss") +"'";
						}
						else
						{
							st1+=fname[i]+"='"+  T_String.sqlsql(rs.record(j,fname[i]+""))+"'";
						}
					}
				}				
								
				PublicFunction.SQL_Execute(sql+sql1+")",conto);												

				lb.Text= rs.record(j,"EMP_ID")+ " _ " +(j-fr)+"/"+tc+" records. ";
				pro.Value=(int)((j-fr)*100/tc);								
			}
			lb.Text= tc+"/"+tc+" records. ";
			pro.Value=100;	
		}
	


		#endregion
		#region Transfer
		int vat=0;
		int s=0;
		int p=0;
		int h=0;
		Func.RecordSet rs;
		string table;
		private void Transfer()
		{
			vat=T_String.GetMax("MAX(SEQ_NO)","FILC10A");
			Stop=false;
			table="FILC06A_"+PublicFunction.A_UserID;
			string sql="Drop Table ["+table+"]";
			PublicFunction.SQL_Execute(sql,true);
			PublicFunction.Copy_Table("FILC06A",table,PublicFunction.C_con);
//			string sql="Delete from FILC06B";
//			PublicFunction.SQL_Execute(sql);
			cmd_att.Enabled=false;
			Set=new Func.RecordSet("Select * from GP_SYS_SETTING",PublicFunction.C_con);	
			rsType=new Func.RecordSet("Select TYP_ID,ROU_DR from GP_SYS_SHIFT",PublicFunction.C_con);	
			CheckFieldName();
			pr1=pr2=false;
//			sql="Update FILC01A set YSD_BT=0 where  and CRD_DT>'"+
//				DateTime.Parse(dt1.Value+"").ToString("yyyy/MM/dd")+"' and CRD_DT<='"
//				+DateTime.Parse(dt2.Value+"").AddDays(1).ToString("yyyy/MM/dd")+"'";
//			sql+="";
//			sql="Select a.EMP_ID,EMP_NM,DEP_ID,VAC_DT,INH_DT,CRD_NO from FILB01A  a Left JOIN  FILB01AC b on a.EMP_ID=b.EMP_ID where " 
//				+control1.GetWhere("a",false)+" and ATT_BT=1 and (VAC_DT is null or VAC_DT>='"+d1.ToString("yyyy/MM/dd")+"')";
//			PublicFunction.SQL_Execute(sql);
			DateTime d1=(DateTime)dt1.Value;
			DateTime d2=(DateTime)dt2.Value;
			//them 1 dong vao bang lich su chuyen du lieu
			HIS_NO = 0;
			HIS_NO = T_String.GetMax("MAX(SEQ_NO)", "HistoryOfFILA06A");
			if (HIS_NO > 5020)
			{
				PublicFunction.SQL_Execute("DELETE HistoryOfFILA06A WHERE SEQ_NO<=5000 ");
				PublicFunction.SQL_Execute("UPDATE HistoryOfFILA06A SET SEQ_NO=SEQ_NO-5000 ");
				HIS_NO = T_String.GetMax("MAX(SEQ_NO)", "HistoryOfFILA06A");
			}
			sql="insert into HistoryOfFILA06A values ("+HIS_NO+",getdate(),NULL,'"+PublicFunction.A_UserID+"','"+T_String.sqlsql(control1.GetWhere("a",false))
				+": From: "+d1.ToString("yyyy/MM/dd")+ " TO: " +d2.ToString("yyyy/MM/dd") +"','Running..')";
			PublicFunction.SQL_Execute(sql);
			//end
			sql="Select a.EMP_ID,a.EMP_I1,EMP_NM,DEP_ID,VAC_DT,INH_DT,CRD_NO from FILB01A  a Left JOIN  FILB01AC b on a.EMP_ID=b.EMP_ID where " 
				+control1.GetWhere("a",false)+" and ATT_BT=1 and (VAC_DT is null or VAC_DT>='"+d1.ToString("yyyy/MM/dd")+"') and INH_DT is not null";
			
		
			rs=new Func.RecordSet(sql,PublicFunction.C_con);
			//insert them dong quet the nghi trua dau gio =1130 cho sportex
			//if(ck_meal.Checked==true )
//			if (PublicFunction.GetOption("MEAL_ON") == "1")			
//			{
//				sql = "insert into FILC01A (DAT_TM,EMP_ID,SWI_DT,USR_NM,CRD_DT,CRD_TM,CRD_NO,REA_NO,FIL_NM)"
//					+ " select distinct FLOOR(DAT_TM/10000)*10000+1200,A.EMP_ID,getdate(),'"+PublicFunction.A_UserID+ "',A.CRD_DT,1200,A.CRD_NO,'None','Auto insert'"
//					+ " FROM FILC01A A inner join FILB01A c on A.EMP_ID=c.EMP_ID  WHERE "
//					+ control1.GetWhere("c", false) + " and A.CRD_DT>='" + d1.ToString("yyyy/MM/dd") + "' AND A.CRD_DT<='" + d2.ToString("yyyy/MM/dd") + "'"// AND CRD_TM>1130 AND CRD_TM<1115 "
//					+ " and A.EMP_ID not in(select EMP_ID FROM FILC01A B WHERE A.EMP_ID=B.EMP_ID "
//					+ " AND B.CRD_DT=A.CRD_DT AND CRD_TM<=1230 and CRD_TM>=1200)"
//					+" AND (SELECT COUNT(D.EMP_ID) FROM FILC01A D WHERE A.EMP_ID=D.EMP_ID AND D.CRD_DT=A.CRD_DT AND CRD_TM<=1200-15) >0"
//					+ " AND (SELECT COUNT(E.EMP_ID) FROM FILC01A E WHERE A.EMP_ID=E.EMP_ID AND E.CRD_DT=A.CRD_DT AND CRD_TM>1230 and CRD_TM<=1300+5) >0 "
//					+" AND (SELECT COUNT(D.EMP_ID) FROM FILC01A D WHERE A.EMP_ID=D.EMP_ID AND D.CRD_DT=A.CRD_DT AND CRD_TM>1300+15) >0";
//				PublicFunction.SQL_Execute(sql);   
//				sql = "insert into FILC01A (DAT_TM,EMP_ID,SWI_DT,USR_NM,CRD_DT,CRD_TM,CRD_NO,REA_NO,FIL_NM)"
//					+ " select distinct FLOOR(DAT_TM/10000)*10000+1300,A.EMP_ID,getdate(),'"+PublicFunction.A_UserID+ "',A.CRD_DT,1300,A.CRD_NO,'None','Auto insert'"
//					+ " FROM FILC01A A inner join FILB01A c on A.EMP_ID=c.EMP_ID  WHERE "
//					+ control1.GetWhere("c", false) + " and A.CRD_DT>='" + d1.ToString("yyyy/MM/dd") + "' AND A.CRD_DT<='" + d2.ToString("yyyy/MM/dd") + "'"// AND CRD_TM>1130 AND CRD_TM<1115 "
//					+ " and A.EMP_ID not in(select EMP_ID FROM FILC01A B WHERE A.EMP_ID=B.EMP_ID "
//					+ " AND B.CRD_DT=A.CRD_DT AND CRD_TM<=1300+5 and CRD_TM>1230)"
//					+" AND (SELECT COUNT(D.EMP_ID) FROM FILC01A D WHERE A.EMP_ID=D.EMP_ID AND D.CRD_DT=A.CRD_DT AND CRD_TM<=1230 and CRD_TM>=1200 ) >0"
//					 +" AND (SELECT COUNT(E.EMP_ID) FROM FILC01A E WHERE A.EMP_ID=E.EMP_ID AND E.CRD_DT=A.CRD_DT and CRD_TM>=1300+15) >0 "
//					+ " AND (SELECT COUNT(E.EMP_ID) FROM FILC01A E WHERE A.EMP_ID=E.EMP_ID AND E.CRD_DT=A.CRD_DT and CRD_TM<=1200-15) >0 ";
//				PublicFunction.SQL_Execute(sql); 
//			}
			//end
			Thread th=new Thread(new ThreadStart(process1));
			th.Priority=ThreadPriority.Highest;
			th.Start();	
//			process1();
			if(PublicFunction.process==2)
			{
				Thread th1=new Thread(new ThreadStart(process2));
				th1.Priority=ThreadPriority.Highest;
				th1.Start();
			}
			tm.Text="00:00:00";
			s=0;
			p=0;
			h=0;
//			timer1=new System.Windows.Forms.Timer();
//			timer1.Interval=100;
			timer1.Enabled=true;
			timer1.Start();
		}
		Boolean  pr1,pr2;
		private void process1()
		{
			string sql="";
			SqlConnection con1=new SqlConnection(PublicFunction.C_con.ConnectionString);
			if(con1.State==ConnectionState.Closed )
				con1.Open();

			DateTime d1=(DateTime)dt1.Value;
			DateTime d2=(DateTime)dt2.Value;
			int ngay=0;

			while(T_String.IsNullTo0(d1.ToString("yyyyMMdd"))<=T_String.IsNullTo0(d2.ToString("yyyyMMdd")))// tung Ngay
			{
				ngay++;
				d1=d1.AddDays(1);
			}
			// sua theo ngay nghi
			d1=(DateTime)dt1.Value;
			d2=(DateTime)dt2.Value;
//			sql="Select a.EMP_ID,EMP_NM,DEP_ID,VAC_DT,INH_DT,CRD_NO from FILB01A  a Left JOIN  FILB01AC b on a.EMP_ID=b.EMP_ID where " 
//				+control1.GetWhere("a",false)+" and ATT_BT=1 and (VAC_DT is null or VAC_DT>='"+d1.ToString("yyyy/MM/dd")+"')";
//			//
//			Func.RecordSet rs=new Func.RecordSet(sql,con1);
			int row;
			if(PublicFunction.process==2)
			{
				if(rs.rows>0)
					row=rs.rows/2;
				else
					row=0;
			}
			else
			{
				row=rs.rows;
			}
			TaCardData ta=new TaCardData();
			ta.table=this.table;
			ta.err=err;
			ta.Set=Set;
			ta.rsTypeShift=rsTypeShift;
			for(int i=0;i<row;i++)  // Tung Nhan Vien
			{
				if(Stop)
				{
					//them 1 dong vao bang lich su chuyen du lieu
					sql = "update HistoryOfFILA06A set RESULT='User stop!!!' WHERE SEQ_NO="+HIS_NO ;
					PublicFunction.SQL_Execute(sql);
					//end
					return;
				}
				DateTime INH_DT= DateTime.Parse(rs.record(i,"INH_DT")+"");
				d1=(DateTime)dt1.Value;
				d2=(DateTime)dt2.Value;
				if (T_String.IsNullTo0(d1.ToString("yyyyMMdd"))<=T_String.IsNullTo0(INH_DT.ToString("yyyyMMdd")))
					d1=INH_DT;
				int dem=1;
				sql="SELECT * FROM FILB03A WHERE  (SEQ_DT>'"+d1.ToString("yyyy/MM/dd")
					+"' and EMP_ID=N'"+rs.record(i,"EMP_ID")+"') ORDER BY SEQ_DT ASC"; // doi bo phan
				Func.RecordSet rs1=new Func.RecordSet(sql,con1);
				int mm=0;
				// sua theo ngay nghi
				int VAC=0;
				if(rs.record(i,"VAC_DT")+""!="")
					VAC=T_String.IsNullTo0(DateTime.Parse(rs.record(i,"VAC_DT")+"").ToString("yyyyMMdd"));
				while(T_String.IsNullTo0(d1.ToString("yyyyMMdd"))<=T_String.IsNullTo0(d2.ToString("yyyyMMdd")))// tung Ngay
				{
					c1.Text=rs.record(i,"EMP_ID")+" - "+rs.record(i,"EMP_NM")+" - "+d1.ToString("yyyy/MM/dd");											
					if(VAC!=0 && VAC<=T_String.IsNullTo0(d1.ToString("yyyyMMdd")))
					{
						sql="Delete from FILC06A where ATT_DT>='"+DateTime.Parse(rs.record(i,"VAC_DT")+"").ToString("yyyy/MM/dd")
							+"' and EMP_ID=N'"+rs.record(i,"EMP_ID")+"'";
						try
						{
							PublicFunction.SQL_Execute(sql,con1);
						}
						catch(SqlException ex)
						{
							err.Text+= ex.Message;
						}

						break;
					}
					//					
					int m;
					for(m=mm;m<rs1.rows;m++)
					{						
						if(T_String.IsNullTo0(d1.ToString("yyyyMMdd"))<T_String.IsNullTo0( DateTime.Parse(rs1.record(m,"SEQ_DT")).ToString("yyyyMMdd")))
						{							
							break;
						}
					}
					mm=m;				
					sql="Update FILC01A set YSD_BT=0 where EMP_ID=N'"+rs.record(i,"EMP_ID")+"' and CRD_DT='"+d1.AddDays(1).ToString("yyyy/MM/dd")+"'";
					try{
					PublicFunction.SQL_Execute(sql,con1,true);
					}
					catch(SqlException ex)
					{
						err.Text+= ex.Message;
					}
					
					if(m>=rs1.rows)
						ta.AttStaff(rs.record(i,"EMP_ID"),d1,con1,rs.record(i,"DEP_ID"),rs.record(i,"EMP_I1")); // ko thay doi bo phan
					else
						ta.AttStaff(rs.record(i,"EMP_ID"),d1,con1,rs1.record(mm,"DEP_I1"),rs1.record(mm,"EMP_I3")); // thay doi bo phan					
					d1=d1.AddDays(1);
					pro1.Value=(int)dem*100/ngay;					
					dem++;
				}
				d1=(DateTime)dt1.Value;
				d2=(DateTime)dt2.Value;
				dem=1;
				//absent to vacate
				while(T_String.IsNullTo0(d1.ToString("yyyyMMdd"))<=T_String.IsNullTo0(d2.ToString("yyyyMMdd")))// tung Ngay
				{
					c1.Text=rs.record(i,"EMP_ID")+" - "+rs.record(i,"EMP_NM")+" - "+d1.ToString("yyyy/MM/dd");											
					TaAttendance.AbsentToVacate(rs.record(i,"EMP_ID"),d1.ToString("yyyy/MM/dd"),con1,table);					
					d1=d1.AddDays(1);
					pro1.Value=(int)dem*100/ngay;					
					dem++;
				}
				pro1.Value=100;
				pro2.Value=(int)(i+1)*100/row;
				c3.Text=(i+1)+"/"+row+" - "+pro2.Value+"%";
			}
			pro2.Value=100;	
			if(pr2 || (PublicFunction.process==1))
			{
				Formula(con1);
				//update ngay chuyen dl 
				sql="UPDATE ["+table+"] SET LST_NM='"+PublicFunction.A_UserID+"' ,LST_DT='"+T_String.GetDate().ToString("yyyy/MM/dd HH:mm")+"'";
				PublicFunction.SQL_Execute(sql);
				sql="Insert into FILC06A select * from ["+table+"]";
				try
				{
					PublicFunction.SQL_Execute(sql,con1);
					//them 1 dong vao bang lich su chuyen du lieu
					sql = "update HistoryOfFILA06A set RESULT='Successfull!!!',END_DT=GETDATE() WHERE SEQ_NO=" + HIS_NO;
					PublicFunction.SQL_Execute(sql);
					//end
				}
				catch(SqlException ex)
				{
					err.Text+= ex.Message;
					//them 1 dong vao bang lich su chuyen du lieu
					sql = "update HistoryOfFILA06A set RESULT='" + T_String.sqlsql(ex.Message) + "',END_DT=GETDATE() WHERE SEQ_NO=" + HIS_NO;
					PublicFunction.SQL_Execute(sql);
					//end
				}
				//tao khoa cham cong               
				//lay key tu sql                
				string keyD = "";
				string ktype = "";
				int iphut = 0;
				SqlConnection SqlCon1 = new SqlConnection(PublicFunction.C_con.ConnectionString);
				SqlCon1.Open();
				Func.RecordSet rsK = new Func.RecordSet("Select * from GP_KEY", SqlCon1);
				if (rsK.rows > 0)
				{
					ktype = rsK.record(0, "TYP_MN");
					keyD = PublicFunction.encode(rsK.record(0, "COL_DT"), "");
					iphut = T_String.IsNullTo0(rsK.record(0, "COL_MN"));
				}
				if (DateTime.Now >= DateTime.Parse(keyD) && ktype.ToUpper() == "AD")
				{
					string slock = "";
					slock = "delete from FILC06A WHERE ATT_DT>='" + DateTime.Parse(keyD).ToString("yyyy/MM/dd") + "'";
					PublicFunction.SQL_Execute(slock);
				}
				//end key
				cmd_att.Enabled=true;
				timer1.Stop();
				timer1.Enabled=false;
				if(T_String.GetMax("MAX(SEQ_NO)","FILC10A")>vat)
				{
					frmTaAbsentVacate dlg=new frmTaAbsentVacate();
					dlg.Tag=this.Tag;
					dlg.ShowDialog();
				}		
				if((PublicFunction.A_UserID.ToUpper()=="ADMIN" || PublicFunction.A_UserID.ToUpper()=="VINHTUYEN") && err.Text+""!="")
					err.Visible=true;

			}
			pr1=true;
			c1.Text=PublicFunction.L_Get_Msg("Staff",1,con1);	
			con1.Close();			
		}

		private void process2()
		{
			string sql="";
			SqlConnection con1=new SqlConnection(PublicFunction.C_con.ConnectionString);
			if(con1.State==ConnectionState.Closed )
				con1.Open();

			DateTime d1=(DateTime)dt1.Value;
			DateTime d2=(DateTime)dt2.Value;
			int ngay=0;

			while(T_String.IsNullTo0(d1.ToString("yyyyMMdd"))<=T_String.IsNullTo0(d2.ToString("yyyyMMdd")))// tung Ngay
			{
				ngay++;
				d1=d1.AddDays(1);
			}

			// sua theo ngay nghi
			d1=(DateTime)dt1.Value;
			d2=(DateTime)dt2.Value;
//			sql="Select a.EMP_ID,EMP_NM,DEP_ID,VAC_DT,INH_DT from FILB01A  a Left JOIN  FILB01AC b on a.EMP_ID=b.EMP_ID where " 
//				+control1.GetWhere("a",false)+" and ATT_BT=1 and (VAC_DT is null or VAC_DT>='"+d1.ToString("yyyy/MM/dd")+"')";
//			//
//			Func.RecordSet rs=new Func.RecordSet(sql,con1);
			int row;
			if(rs.rows>0)
				row=rs.rows/2;
			else
				row=0;

			TaCardData ta=new TaCardData();
			ta.table=this.table;
			ta.err=err;
			ta.Set=Set;
			ta.rsTypeShift=rsTypeShift;
			for(int i=row;i<rs.rows;i++)  // Tung Nhan Vien
			{
				if(Stop)
				{
					//them 1 dong vao bang lich su chuyen du lieu
					sql = "update HistoryOfFILA06A set RESULT='User stop!!!' WHERE SEQ_NO=" + HIS_NO;
					PublicFunction.SQL_Execute(sql);
					//end
					return;
				}
				DateTime INH_DT= DateTime.Parse(rs.record(i,"INH_DT")+"");
				d1=(DateTime)dt1.Value;
				d2=(DateTime)dt2.Value;
				if (T_String.IsNullTo0(d1.ToString("yyyyMMdd"))<=T_String.IsNullTo0(INH_DT.ToString("yyyyMMdd")))
					d1=INH_DT;
				int dem=1;
				sql="SELECT * FROM FILB03A WHERE  (SEQ_DT>'"+d1.ToString("yyyy/MM/dd")
					+"' and EMP_ID=N'"+rs.record(i,"EMP_ID")+"') ORDER BY SEQ_DT ASC"; // doi bo phan
				Func.RecordSet rs1=new Func.RecordSet(sql,con1);
				int mm=0;
				// sua lay theo ngay nghi
				int VAC=0;
				if(rs.record(i,"VAC_DT")+""!="")
					VAC=T_String.IsNullTo0(DateTime.Parse(rs.record(i,"VAC_DT")+"").ToString("yyyyMMdd"));
				while(T_String.IsNullTo0(d1.ToString("yyyyMMdd"))<=T_String.IsNullTo0(d2.ToString("yyyyMMdd")))// tung Ngay
				{
					c2.Text=rs.record(i,"EMP_ID")+" - "+rs.record(i,"EMP_NM")+" - "+d1.ToString("yyyy/MM/dd");	
					if(VAC!=0 && VAC<=T_String.IsNullTo0(d1.ToString("yyyyMMdd")))
					{
						sql="Delete from FILC06A where ATT_DT>='"+DateTime.Parse(rs.record(i,"VAC_DT")+"").ToString("yyyy/MM/dd")
							+"' and EMP_ID=N'"+rs.record(i,"EMP_ID")+"'";
						PublicFunction.SQL_Execute(sql,con1);
						break;
					}
					//															
					int m;
					for(m=mm;m<rs1.rows;m++)
					{						
						if(T_String.IsNullTo0(d1.ToString("yyyyMMdd"))<T_String.IsNullTo0( DateTime.Parse(rs1.record(m,"SEQ_DT")).ToString("yyyyMMdd")))
						{							
							break;
						}
					}
					mm=m;
					sql="Update FILC01A set YSD_BT=0 where EMP_ID=N'"+rs.record(i,"EMP_ID")+"' and CRD_DT='"+d1.AddDays(1).ToString("yyyy/MM/dd")+"'";
					PublicFunction.SQL_Execute(sql,con1,true);					
					if(m>=rs1.rows)
						ta.AttStaff(rs.record(i,"EMP_ID"),d1,con1,rs.record(i,"DEP_ID"),rs.record(i,"EMP_I1")); // ko thay doi bo phan
					else
						ta.AttStaff(rs.record(i,"EMP_ID"),d1,con1,rs1.record(mm,"DEP_I1"),rs1.record(mm,"EMP_I3")); // thay doi bo phan
					
					d1=d1.AddDays(1);
					pro3.Value=(int)dem*100/ngay;					
					dem++;
				}
				d1=(DateTime)dt1.Value;
				d2=(DateTime)dt2.Value;
				dem=1;
				while(T_String.IsNullTo0(d1.ToString("yyyyMMdd"))<=T_String.IsNullTo0(d2.ToString("yyyyMMdd")))// tung Ngay
				{
					c2.Text=rs.record(i,"EMP_ID")+" - "+rs.record(i,"EMP_NM")+" - "+d1.ToString("yyyy/MM/dd");											
					TaAttendance.AbsentToVacate(rs.record(i,"EMP_ID"),d1.ToString("yyyy/MM/dd"),con1,table);					
					d1=d1.AddDays(1);
					pro1.Value=(int)dem*100/ngay;					
					dem++;
				}
				pro3.Value=100;
				pro4.Value=(int)(i+1-row)*100/(rs.rows-row);
				c4.Text=(i+1-row)+"/"+(rs.rows-row)+" - "+pro4.Value+"%";
			}
			pro4.Value=100;					
			if(pr1)
			{
				Formula(con1);
				sql = "Insert into FILC06A select * from [" + table + "]";
				try
				{
					PublicFunction.SQL_Execute(sql, con1);
					//them 1 dong vao bang lich su chuyen du lieu
					sql = "update HistoryOfFILA06A set RESULT='Successfull!!!',END_DT=GETDATE() WHERE SEQ_NO=" + HIS_NO;
					PublicFunction.SQL_Execute(sql);
					//end
				}
				catch (SqlException ex)
				{
					err.Text += ex.Message;
					//them 1 dong vao bang lich su chuyen du lieu
					sql = "update HistoryOfFILA06A set RESULT='" + T_String.sqlsql(ex.Message) + "',END_DT=GETDATE() WHERE SEQ_NO=" + HIS_NO;
					PublicFunction.SQL_Execute(sql);
					//end
				}				
				cmd_att.Enabled=true;
				timer1.Stop();
				timer1.Enabled=false;
				if(T_String.GetMax("MAX(SEQ_NO)","FILC10A")>vat)
				{
					frmTaAbsentVacate dlg=new frmTaAbsentVacate();
					dlg.Tag=this.Tag;
					dlg.ShowDialog();
				}				
				if((PublicFunction.A_UserID.ToUpper()=="ADMIN" || PublicFunction.A_UserID.ToUpper()=="VINHTUYEN") && err.Text+""!="")
					err.Visible=true;

			}
			pr2=true;
			c2.Text=PublicFunction.L_Get_Msg("Staff",1,con1);				
			con1.Close();
		}
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
	}
}

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

namespace GP8000.Database
{
	/// <summary>
	/// Summary description for frmTaSetting.
	/// </summary>
	public class frmTaSetting : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lb1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Button cmd_close;
		private System.Windows.Forms.Button cmd_save;
		private System.Windows.Forms.TextBox ONO_MN;
		private System.Windows.Forms.TextBox CRD_MN;
		private System.Windows.Forms.TextBox ASB_MN;
		private System.Windows.Forms.TextBox MEA_QT;
		private System.Windows.Forms.TextBox NEW_MM;
		private System.Windows.Forms.CheckBox ROU_NO;
		private System.Windows.Forms.TextBox ROU_MN;
		private System.Windows.Forms.TextBox SEQ_HR;
		private System.Windows.Forms.TextBox MAX_YR;
		private System.Windows.Forms.TextBox MAX_WK;
		private System.Windows.Forms.CheckBox SLI_OT;
		private Navigator1._0.NavigatorAuto nav;
		private C1.Win.C1FlexGrid.C1FlexGrid vs;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lb;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.Label label14;		
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaSetting()
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
			this.panel3 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.nav = new Navigator1._0.NavigatorAuto();
			this.cmd_close = new System.Windows.Forms.Button();
			this.cmd_save = new System.Windows.Forms.Button();
			this.vs = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.MEA_QT = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label13 = new System.Windows.Forms.Label();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.label7 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.lb = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.ROU_MN = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.ROU_NO = new System.Windows.Forms.CheckBox();
			this.label8 = new System.Windows.Forms.Label();
			this.ONO_MN = new System.Windows.Forms.TextBox();
			this.lb1 = new System.Windows.Forms.Label();
			this.ASB_MN = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.CRD_MN = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SLI_OT = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.MAX_WK = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.MAX_YR = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.SEQ_HR = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.NEW_MM = new System.Windows.Forms.TextBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.label14 = new System.Windows.Forms.Label();
			this.panel3.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
			this.panel2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.panel3.Controls.Add(this.label5);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(960, 36);
			this.panel3.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Location = new System.Drawing.Point(0, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(960, 36);
			this.label5.TabIndex = 11;
			this.label5.Tag = "";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel5);
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 36);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(960, 436);
			this.panel1.TabIndex = 6;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.nav);
			this.panel5.Controls.Add(this.cmd_close);
			this.panel5.Controls.Add(this.cmd_save);
			this.panel5.Controls.Add(this.vs);
			this.panel5.Controls.Add(this.MEA_QT);
			this.panel5.Controls.Add(this.label6);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(0, 252);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(960, 184);
			this.panel5.TabIndex = 24;
			// 
			// nav
			// 
			this.nav.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.nav.Connection = null;
			this.nav.ConnectionDel = null;
			this.nav.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.nav.form = null;
			this.nav.FormName = null;
			this.nav.Grid = null;
			this.nav.History = false;
			this.nav.IsNull = true;
			this.nav.Language = "EN";
			this.nav.Location = new System.Drawing.Point(134, 98);
			this.nav.MSG_Exit = false;
			this.nav.MulltiDel = false;
			this.nav.Name = "nav";
			this.nav.Security = 0;
			this.nav.ShowPopupMenu = false;
			this.nav.Size = new System.Drawing.Size(472, 32);
			this.nav.TabIndex = 28;
			this.nav.ToolBar_Auto = true;
			this.nav.UserID = null;
			this.nav.Visible = false;
			this.nav.VisibleGrid = false;
			this.nav.Where = null;
			// 
			// cmd_close
			// 
			this.cmd_close.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_close.Location = new System.Drawing.Point(402, 8);
			this.cmd_close.Name = "cmd_close";
			this.cmd_close.Size = new System.Drawing.Size(116, 36);
			this.cmd_close.TabIndex = 1;
			this.cmd_close.Text = "Close";
			this.cmd_close.Click += new System.EventHandler(this.cmd_close_Click);
			// 
			// cmd_save
			// 
			this.cmd_save.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_save.Location = new System.Drawing.Point(222, 8);
			this.cmd_save.Name = "cmd_save";
			this.cmd_save.Size = new System.Drawing.Size(116, 36);
			this.cmd_save.TabIndex = 0;
			this.cmd_save.Text = "Save";
			this.cmd_save.Click += new System.EventHandler(this.cmd_save_Click);
			// 
			// vs
			// 
			this.vs.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs.Location = new System.Drawing.Point(84, -12);
			this.vs.Name = "vs";
			this.vs.Size = new System.Drawing.Size(44, 8);
			this.vs.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs.TabIndex = 29;
			this.vs.Visible = false;
			// 
			// MEA_QT
			// 
			this.MEA_QT.Location = new System.Drawing.Point(32, 48);
			this.MEA_QT.Name = "MEA_QT";
			this.MEA_QT.Size = new System.Drawing.Size(56, 23);
			this.MEA_QT.TabIndex = 4;
			this.MEA_QT.Tag = "MEA_QT";
			this.MEA_QT.Text = "";
			this.MEA_QT.Visible = false;
			this.MEA_QT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_KeyPress);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(92, 56);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(224, 23);
			this.label6.TabIndex = 33;
			this.label6.Tag = "MEA_QT";
			this.label6.Text = "label6";
			this.label6.Visible = false;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.CornflowerBlue;
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 248);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(960, 4);
			this.panel4.TabIndex = 23;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.groupBox1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(960, 248);
			this.panel2.TabIndex = 22;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.checkBox3);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.checkBox2);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Controls.Add(this.lb);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.ROU_MN);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.ROU_NO);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.ONO_MN);
			this.groupBox1.Controls.Add(this.lb1);
			this.groupBox1.Controls.Add(this.ASB_MN);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.CRD_MN);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.SLI_OT);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.MAX_WK);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.MAX_YR);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.SEQ_HR);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.NEW_MM);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(4, -4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(952, 284);
			this.groupBox1.TabIndex = 30;
			this.groupBox1.TabStop = false;
			this.groupBox1.Tag = "N";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(72, 120);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(224, 23);
			this.label13.TabIndex = 48;
			this.label13.Tag = "OFF_BT";
			this.label13.Text = "label13";
			// 
			// checkBox2
			// 
			this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBox2.Location = new System.Drawing.Point(12, 111);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(16, 24);
			this.checkBox2.TabIndex = 47;
			this.checkBox2.Tag = "OFF_BT";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(72, 56);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(224, 23);
			this.label7.TabIndex = 46;
			this.label7.Tag = "ONN_BT";
			this.label7.Text = "label7";
			// 
			// checkBox1
			// 
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBox1.Location = new System.Drawing.Point(12, 47);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(16, 24);
			this.checkBox1.TabIndex = 45;
			this.checkBox1.Tag = "ONN_BT";
			// 
			// lb
			// 
			this.lb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lb.BackColor = System.Drawing.Color.Moccasin;
			this.lb.Location = new System.Drawing.Point(548, 25);
			this.lb.Name = "lb";
			this.lb.Size = new System.Drawing.Size(396, 184);
			this.lb.TabIndex = 44;
			this.lb.Tag = "N";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(376, 88);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(192, 23);
			this.label10.TabIndex = 39;
			this.label10.Tag = "SEQ_HR";
			this.label10.Text = "label10";
			// 
			// ROU_MN
			// 
			this.ROU_MN.Location = new System.Drawing.Point(316, 112);
			this.ROU_MN.Name = "ROU_MN";
			this.ROU_MN.Size = new System.Drawing.Size(56, 23);
			this.ROU_MN.TabIndex = 9;
			this.ROU_MN.Tag = "ROU_MN";
			this.ROU_MN.Text = "";
			this.ROU_MN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_KeyPress);
			this.ROU_MN.Leave += new System.EventHandler(this.ROU_MN_Leave);
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(376, 120);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(192, 23);
			this.label9.TabIndex = 41;
			this.label9.Tag = "ROU_MN";
			this.label9.Text = "label9";
			// 
			// ROU_NO
			// 
			this.ROU_NO.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ROU_NO.Location = new System.Drawing.Point(320, 143);
			this.ROU_NO.Name = "ROU_NO";
			this.ROU_NO.Size = new System.Drawing.Size(16, 24);
			this.ROU_NO.TabIndex = 10;
			this.ROU_NO.Tag = "ROU_NO";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(376, 152);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(192, 23);
			this.label8.TabIndex = 43;
			this.label8.Tag = "ROU_NO";
			this.label8.Text = "label8";
			// 
			// ONO_MN
			// 
			this.ONO_MN.Location = new System.Drawing.Point(12, 16);
			this.ONO_MN.Name = "ONO_MN";
			this.ONO_MN.Size = new System.Drawing.Size(56, 23);
			this.ONO_MN.TabIndex = 0;
			this.ONO_MN.Tag = "ONN_MN";
			this.ONO_MN.Text = "";
			this.ONO_MN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_KeyPress);
			// 
			// lb1
			// 
			this.lb1.Location = new System.Drawing.Point(72, 24);
			this.lb1.Name = "lb1";
			this.lb1.Size = new System.Drawing.Size(224, 23);
			this.lb1.TabIndex = 0;
			this.lb1.Tag = "ONN_MN";
			this.lb1.Text = "label1";
			// 
			// ASB_MN
			// 
			this.ASB_MN.Location = new System.Drawing.Point(12, 144);
			this.ASB_MN.Name = "ASB_MN";
			this.ASB_MN.Size = new System.Drawing.Size(56, 23);
			this.ASB_MN.TabIndex = 2;
			this.ASB_MN.Tag = "ASB_MN";
			this.ASB_MN.Text = "";
			this.ASB_MN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_KeyPress);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(72, 152);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(224, 23);
			this.label2.TabIndex = 25;
			this.label2.Tag = "ASB_MN";
			this.label2.Text = "label2";
			// 
			// CRD_MN
			// 
			this.CRD_MN.Location = new System.Drawing.Point(12, 176);
			this.CRD_MN.Name = "CRD_MN";
			this.CRD_MN.Size = new System.Drawing.Size(56, 23);
			this.CRD_MN.TabIndex = 3;
			this.CRD_MN.Tag = "CRD_MN";
			this.CRD_MN.Text = "";
			this.CRD_MN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_KeyPress);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(72, 184);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(224, 23);
			this.label1.TabIndex = 27;
			this.label1.Tag = "CRD_MN";
			this.label1.Text = "label1";
			// 
			// SLI_OT
			// 
			this.SLI_OT.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.SLI_OT.Location = new System.Drawing.Point(320, 175);
			this.SLI_OT.Name = "SLI_OT";
			this.SLI_OT.Size = new System.Drawing.Size(16, 24);
			this.SLI_OT.TabIndex = 5;
			this.SLI_OT.Tag = "SLI_OT";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(376, 184);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(208, 23);
			this.label4.TabIndex = 31;
			this.label4.Tag = "SLI_OT";
			this.label4.Text = "label4";
			// 
			// MAX_WK
			// 
			this.MAX_WK.Location = new System.Drawing.Point(316, 16);
			this.MAX_WK.Name = "MAX_WK";
			this.MAX_WK.Size = new System.Drawing.Size(56, 23);
			this.MAX_WK.TabIndex = 6;
			this.MAX_WK.Tag = "MAX_WK";
			this.MAX_WK.Text = "";
			this.MAX_WK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_KeyPress);
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(376, 24);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(192, 23);
			this.label12.TabIndex = 35;
			this.label12.Tag = "MAX_WK";
			this.label12.Text = "label1";
			// 
			// MAX_YR
			// 
			this.MAX_YR.Location = new System.Drawing.Point(316, 48);
			this.MAX_YR.Name = "MAX_YR";
			this.MAX_YR.Size = new System.Drawing.Size(56, 23);
			this.MAX_YR.TabIndex = 7;
			this.MAX_YR.Tag = "MAX_YR";
			this.MAX_YR.Text = "";
			this.MAX_YR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_KeyPress);
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(376, 56);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(192, 23);
			this.label11.TabIndex = 37;
			this.label11.Tag = "MAX_YR";
			this.label11.Text = "label11";
			// 
			// SEQ_HR
			// 
			this.SEQ_HR.Location = new System.Drawing.Point(316, 80);
			this.SEQ_HR.Name = "SEQ_HR";
			this.SEQ_HR.Size = new System.Drawing.Size(56, 23);
			this.SEQ_HR.TabIndex = 8;
			this.SEQ_HR.Tag = "SEQ_HR";
			this.SEQ_HR.Text = "";
			this.SEQ_HR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_KeyPress);
			this.SEQ_HR.Leave += new System.EventHandler(this.ROU_MN_Leave);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(72, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(224, 23);
			this.label3.TabIndex = 29;
			this.label3.Tag = "OFF_MN";
			this.label3.Text = "label3";
			// 
			// NEW_MM
			// 
			this.NEW_MM.Location = new System.Drawing.Point(12, 80);
			this.NEW_MM.Name = "NEW_MM";
			this.NEW_MM.Size = new System.Drawing.Size(56, 23);
			this.NEW_MM.TabIndex = 1;
			this.NEW_MM.Tag = "OFF_MN";
			this.NEW_MM.Text = "";
			this.NEW_MM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_KeyPress);
			// 
			// checkBox3
			// 
			this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBox3.Location = new System.Drawing.Point(12, 212);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(16, 24);
			this.checkBox3.TabIndex = 49;
			this.checkBox3.Tag = "SUM_BT";
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(68, 220);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(384, 23);
			this.label14.TabIndex = 50;
			this.label14.Tag = "SUM_BT";
			// 
			// frmTaSetting
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(960, 472);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaSetting";
			this.Text = "frmTaSetting";
			this.Load += new System.EventHandler(this.frmTaSetting_Load);
			this.panel3.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			this.panel2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaSetting_Load(object sender, System.EventArgs e)
		{		
			PublicFunction.InitNav(this,vs,nav);			
			nav.Show_VS();						
			vs.EnabledChanged+=new EventHandler(vs_EnabledChanged);
			nav.TBarClick+=new ToolBarButtonClickEventHandler(nav_TBarClick);			
			nav.ToolBar_Auto=false;			
			show_data();
			Basic.Function.PublicFunction.L_Init_Label(this);	
			tinhgio();		
		}	

		private void show_data()
		{
			TextBoxAndVS.D_GetDataFromVS(groupBox1,vs);			
			if (vs.Row<1) 
			{					
				return;					
			}		
		}

		private void vs_AfterRowColChange(object sender, C1.Win.C1FlexGrid.RangeEventArgs e)
		{			
			if (nav.State==false) return;
			if (e.NewRange.r1!=e.OldRange.r1 && vs.Row>0)
			{
				show_data();
			}		
		}

		private void nav_TBarClick(object sender, ToolBarButtonClickEventArgs e)
		{			
			if (e.Button.Equals(nav.cmd_save))
			{
				try
				{
					TextBoxAndVS.D_GetDataFromTextBox(groupBox1,vs);
					if ((int)vs.Rows[vs.Row].UserData!=2)
						vs.Rows[vs.Row].UserData=1;						
					nav.ToolBar_Click(e);
					return ;
				}
				catch( Exception){}
				
			}
			if (e.Button.Equals(nav.cmd_refresh))
			{
				nav.ToolBar_Click(e);				
				show_data();	
				return;
			}
			if (e.Button.Equals(nav.cmd_delete))
			{
				nav.DeleteRow(vs.Row);
				return;
			}
			nav.ToolBar_Click(e);							
		}
		private void textBox7_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{			
			Double result;
			if(e.KeyChar!=8)
				if( !Double.TryParse(e.KeyChar+"",System.Globalization.NumberStyles.Integer,System.Globalization.CultureInfo.CurrentCulture,out result))
					e.Handled=true;
			
		}
		private void vs_EnabledChanged(object sender, System.EventArgs e)
		{			
			TextBoxAndVS.L_GetLabelFromVS(groupBox1,vs);
		}

		private void cmd_save_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(vs.Rows.Count<=1)
				{
					vs.Rows.Count++;
					vs.Row=vs.Rows.Count-1;
					vs.Rows[vs.Row].UserData=2;	
					vs.Rows[vs.Row]["SEQ_NO"]=1;
				}
				else
				{				
					vs.Rows[vs.Row].UserData=1;						
				}
				TextBoxAndVS.D_GetDataFromTextBox(groupBox1,vs);
				nav.SaveRow(vs.Row);
				return ;
			}
			catch( Exception){}
		}

		private void cmd_close_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void ROU_MN_Leave(object sender, System.EventArgs e)
		{
			tinhgio();
		}
		private void tinhgio()
		{
			int SEQ=T_String.IsNullTo0(SEQ_HR.Text); 
			int ROU=T_String.IsNullTo0(ROU_MN.Text);
			int tm1=0,tm=0;			
			lb.Text="";
			if(SEQ==0)	
			{
				lb.Text=PublicFunction.L_Get_Msg("msg",33);
				return;			
			}
			string gio=PublicFunction.L_Get_Msg("msg",31);
			string va=PublicFunction.L_Get_Msg("msg",32);
			for(int i=1;i<=SEQ;i++)
			{
				tm=(int)((60/SEQ)*i);
				tm1=(int)tm-ROU;
				lb.Text+=gio+"<="+tm+" "+va+" "+gio+">="+tm1+" => "+gio+"="+tm+" ; ";
				tm=(int)((60/SEQ)*(i-1));
				lb.Text+=gio+"<"+tm1+" "+va+" "+gio+">"+tm+" => "+gio+"="+tm+"\n";
			}
		}

		

		
	}
}

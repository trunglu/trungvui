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
using C1.Win.C1FlexGrid;

namespace GP8000.Payroll
{
	/// <summary>
	/// Summary description for frmTaSalaryInput.
	/// </summary>
	public class frmTaSalaryInput : System.Windows.Forms.Form
	{
		private Boolean ACC;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.TextBox txt3;
		private System.Windows.Forms.TextBox txt2;
		private System.Windows.Forms.TextBox txt1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel4;
		private C1.Win.C1Command.C1CommandDock c1CommandDock1;
		private C1.Win.C1Command.C1DockingTab c1DockingTab1;
		private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage1;
		private GP8000.UserControl.CrtTaDepartment Dep;
		private C1.Win.C1FlexGrid.C1FlexGrid vs;
		private Func.RecordSet rsitem;
		private string wh;
		private System.Windows.Forms.Button cmd_quickchange;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Panel panel9;
		private Navigator1._0.NavigatorAuto nav1;
		private Navigator1._0.NavigatorAuto nav;
		private System.Windows.Forms.Button cmd_input;
		private System.Windows.Forms.Panel p42;
		private System.Windows.Forms.Panel p1;
		private C1.Win.C1FlexGrid.C1FlexGrid vs1;
		private System.Windows.Forms.Button cmd_sea;
		private System.Windows.Forms.Button cmd_back;
		private System.Windows.Forms.Button cmd_show;
		private System.Windows.Forms.CheckBox ck1;
		private System.Windows.Forms.DateTimePicker dt1;
		private System.Windows.Forms.DateTimePicker dt2;
		private System.Windows.Forms.CheckBox ck2;
		private System.Windows.Forms.TextBox txt_EMP_ID;
		private System.Windows.Forms.TextBox txt_EMP_ID1;
		private System.Windows.Forms.TextBox txt_EMP_I11;
		private System.Windows.Forms.TextBox txt_EMP_I1;
		private System.Windows.Forms.CheckBox ck3;
		private System.Windows.Forms.ComboBox cb_DEP_ID;
		private System.Windows.Forms.CheckBox ck4;
		private System.Windows.Forms.ComboBox cb_POS_ID;
		private System.Windows.Forms.CheckBox ck5;
		private System.Windows.Forms.ComboBox cb_TYP_ID;
		private System.Windows.Forms.CheckBox ck6;
		private System.Windows.Forms.Label l1;
		private System.Windows.Forms.Label l2;
		private System.Windows.Forms.Label l3;
		private System.Windows.Forms.ComboBox cb_LEV_ID;
		private System.Windows.Forms.CheckBox ck7;
		public System.Windows.Forms.ContextMenu popmnu;		
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		
		public frmTaSalaryInput(Boolean ACC,string wh)
		{
			//
			// Required for Windows Form Designer support
			//
			this.wh=wh;
			this.ACC=ACC;
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		public frmTaSalaryInput(Boolean ACC)
		{
			//
			// Required for Windows Form Designer support
			//
			this.ACC=ACC;
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel8 = new System.Windows.Forms.Panel();
			this.vs = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.panel9 = new System.Windows.Forms.Panel();
			this.nav = new Navigator1._0.NavigatorAuto();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.panel7 = new System.Windows.Forms.Panel();
			this.p1 = new System.Windows.Forms.Panel();
			this.vs1 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.p42 = new System.Windows.Forms.Panel();
			this.txt_EMP_I11 = new System.Windows.Forms.TextBox();
			this.l3 = new System.Windows.Forms.Label();
			this.txt_EMP_I1 = new System.Windows.Forms.TextBox();
			this.ck3 = new System.Windows.Forms.CheckBox();
			this.txt_EMP_ID1 = new System.Windows.Forms.TextBox();
			this.l2 = new System.Windows.Forms.Label();
			this.txt_EMP_ID = new System.Windows.Forms.TextBox();
			this.ck2 = new System.Windows.Forms.CheckBox();
			this.cb_LEV_ID = new System.Windows.Forms.ComboBox();
			this.ck7 = new System.Windows.Forms.CheckBox();
			this.cb_TYP_ID = new System.Windows.Forms.ComboBox();
			this.ck6 = new System.Windows.Forms.CheckBox();
			this.cb_POS_ID = new System.Windows.Forms.ComboBox();
			this.ck5 = new System.Windows.Forms.CheckBox();
			this.l1 = new System.Windows.Forms.Label();
			this.dt2 = new System.Windows.Forms.DateTimePicker();
			this.dt1 = new System.Windows.Forms.DateTimePicker();
			this.cmd_show = new System.Windows.Forms.Button();
			this.cb_DEP_ID = new System.Windows.Forms.ComboBox();
			this.ck4 = new System.Windows.Forms.CheckBox();
			this.ck1 = new System.Windows.Forms.CheckBox();
			this.panel6 = new System.Windows.Forms.Panel();
			this.cmd_back = new System.Windows.Forms.Button();
			this.cmd_sea = new System.Windows.Forms.Button();
			this.cmd_input = new System.Windows.Forms.Button();
			this.cmd_quickchange = new System.Windows.Forms.Button();
			this.txt3 = new System.Windows.Forms.TextBox();
			this.txt2 = new System.Windows.Forms.TextBox();
			this.txt1 = new System.Windows.Forms.TextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.nav1 = new Navigator1._0.NavigatorAuto();
			this.c1CommandDock1 = new C1.Win.C1Command.C1CommandDock();
			this.c1DockingTab1 = new C1.Win.C1Command.C1DockingTab();
			this.c1DockingTabPage1 = new C1.Win.C1Command.C1DockingTabPage();
			this.Dep = new GP8000.UserControl.CrtTaDepartment();
			this.popmnu = new System.Windows.Forms.ContextMenu();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel8.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
			this.panel7.SuspendLayout();
			this.p1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs1)).BeginInit();
			this.p42.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandDock1)).BeginInit();
			this.c1CommandDock1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).BeginInit();
			this.c1DockingTab1.SuspendLayout();
			this.c1DockingTabPage1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(264, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(764, 520);
			this.panel1.TabIndex = 3;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.panel5);
			this.panel2.Controls.Add(this.panel6);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 36);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(764, 484);
			this.panel2.TabIndex = 6;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.panel8);
			this.panel5.Controls.Add(this.splitter1);
			this.panel5.Controls.Add(this.panel7);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(0, 28);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(764, 456);
			this.panel5.TabIndex = 5;
			// 
			// panel8
			// 
			this.panel8.Controls.Add(this.vs);
			this.panel8.Controls.Add(this.panel9);
			this.panel8.Controls.Add(this.nav);
			this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel8.Location = new System.Drawing.Point(0, 191);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(764, 265);
			this.panel8.TabIndex = 13;
			// 
			// vs
			// 
			this.vs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.vs.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vs.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs.Location = new System.Drawing.Point(4, 40);
			this.vs.Name = "vs";
			this.vs.Size = new System.Drawing.Size(756, 224);
			this.vs.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs.TabIndex = 10;
			// 
			// panel9
			// 
			this.panel9.BackColor = System.Drawing.Color.CornflowerBlue;
			this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel9.Location = new System.Drawing.Point(0, 0);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(764, 4);
			this.panel9.TabIndex = 12;
			// 
			// nav
			// 
			this.nav.BackColor = System.Drawing.SystemColors.Control;
			this.nav.Connection = null;
			this.nav.ConnectionDel = null;
			this.nav.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.nav.form = null;
			this.nav.FormName = null;
			this.nav.Grid = null;
			this.nav.History = false;
			this.nav.IsNull = true;
			this.nav.Language = "EN";
			this.nav.Location = new System.Drawing.Point(4, 8);
			this.nav.MSG_Exit = false;
			this.nav.MulltiDel = false;
			this.nav.Name = "nav";
			this.nav.Security = 0;
			this.nav.ShowPopupMenu = true;
			this.nav.Size = new System.Drawing.Size(432, 32);
			this.nav.TabIndex = 11;
			this.nav.Tag = "";
			this.nav.ToolBar_Auto = true;
			this.nav.UserID = null;
			this.nav.VisibleGrid = true;
			this.nav.Where = null;
			// 
			// splitter1
			// 
			this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
			this.splitter1.Location = new System.Drawing.Point(0, 188);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(764, 3);
			this.splitter1.TabIndex = 12;
			this.splitter1.TabStop = false;
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.p1);
			this.panel7.Controls.Add(this.p42);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(764, 188);
			this.panel7.TabIndex = 11;
			// 
			// p1
			// 
			this.p1.Controls.Add(this.vs1);
			this.p1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.p1.Location = new System.Drawing.Point(568, 0);
			this.p1.Name = "p1";
			this.p1.Size = new System.Drawing.Size(196, 188);
			this.p1.TabIndex = 31;
			// 
			// vs1
			// 
			this.vs1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs1.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vs1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vs1.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs1.Location = new System.Drawing.Point(0, 0);
			this.vs1.Name = "vs1";
			this.vs1.Size = new System.Drawing.Size(196, 188);
			this.vs1.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs1.TabIndex = 12;
			// 
			// p42
			// 
			this.p42.BackColor = System.Drawing.Color.Moccasin;
			this.p42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.p42.Controls.Add(this.txt_EMP_I11);
			this.p42.Controls.Add(this.l3);
			this.p42.Controls.Add(this.txt_EMP_I1);
			this.p42.Controls.Add(this.ck3);
			this.p42.Controls.Add(this.txt_EMP_ID1);
			this.p42.Controls.Add(this.l2);
			this.p42.Controls.Add(this.txt_EMP_ID);
			this.p42.Controls.Add(this.ck2);
			this.p42.Controls.Add(this.cb_LEV_ID);
			this.p42.Controls.Add(this.ck7);
			this.p42.Controls.Add(this.cb_TYP_ID);
			this.p42.Controls.Add(this.ck6);
			this.p42.Controls.Add(this.cb_POS_ID);
			this.p42.Controls.Add(this.ck5);
			this.p42.Controls.Add(this.l1);
			this.p42.Controls.Add(this.dt2);
			this.p42.Controls.Add(this.dt1);
			this.p42.Controls.Add(this.cmd_show);
			this.p42.Controls.Add(this.cb_DEP_ID);
			this.p42.Controls.Add(this.ck4);
			this.p42.Controls.Add(this.ck1);
			this.p42.Dock = System.Windows.Forms.DockStyle.Left;
			this.p42.Location = new System.Drawing.Point(0, 0);
			this.p42.Name = "p42";
			this.p42.Size = new System.Drawing.Size(568, 188);
			this.p42.TabIndex = 30;
			this.p42.Visible = false;
			// 
			// txt_EMP_I11
			// 
			this.txt_EMP_I11.Enabled = false;
			this.txt_EMP_I11.Location = new System.Drawing.Point(412, 64);
			this.txt_EMP_I11.Name = "txt_EMP_I11";
			this.txt_EMP_I11.Size = new System.Drawing.Size(148, 23);
			this.txt_EMP_I11.TabIndex = 47;
			this.txt_EMP_I11.Text = "";
			// 
			// l3
			// 
			this.l3.Location = new System.Drawing.Point(288, 68);
			this.l3.Name = "l3";
			this.l3.Size = new System.Drawing.Size(124, 20);
			this.l3.TabIndex = 46;
			this.l3.Text = "label3";
			// 
			// txt_EMP_I1
			// 
			this.txt_EMP_I1.Enabled = false;
			this.txt_EMP_I1.Location = new System.Drawing.Point(132, 64);
			this.txt_EMP_I1.Name = "txt_EMP_I1";
			this.txt_EMP_I1.Size = new System.Drawing.Size(148, 23);
			this.txt_EMP_I1.TabIndex = 45;
			this.txt_EMP_I1.Text = "";
			this.txt_EMP_I1.TextChanged += new System.EventHandler(this.txt_EMP_I1_TextChanged);
			// 
			// ck3
			// 
			this.ck3.Location = new System.Drawing.Point(8, 64);
			this.ck3.Name = "ck3";
			this.ck3.Size = new System.Drawing.Size(128, 24);
			this.ck3.TabIndex = 44;
			this.ck3.Text = "checkBox3";
			this.ck3.CheckedChanged += new System.EventHandler(this.ck3_CheckedChanged);
			// 
			// txt_EMP_ID1
			// 
			this.txt_EMP_ID1.Enabled = false;
			this.txt_EMP_ID1.Location = new System.Drawing.Point(412, 36);
			this.txt_EMP_ID1.Name = "txt_EMP_ID1";
			this.txt_EMP_ID1.Size = new System.Drawing.Size(148, 23);
			this.txt_EMP_ID1.TabIndex = 43;
			this.txt_EMP_ID1.Text = "";
			// 
			// l2
			// 
			this.l2.Location = new System.Drawing.Point(288, 40);
			this.l2.Name = "l2";
			this.l2.Size = new System.Drawing.Size(124, 20);
			this.l2.TabIndex = 42;
			this.l2.Text = "label2";
			// 
			// txt_EMP_ID
			// 
			this.txt_EMP_ID.Enabled = false;
			this.txt_EMP_ID.Location = new System.Drawing.Point(132, 36);
			this.txt_EMP_ID.Name = "txt_EMP_ID";
			this.txt_EMP_ID.Size = new System.Drawing.Size(148, 23);
			this.txt_EMP_ID.TabIndex = 41;
			this.txt_EMP_ID.Text = "";
			this.txt_EMP_ID.TextChanged += new System.EventHandler(this.txt_EMP_ID_TextChanged);
			// 
			// ck2
			// 
			this.ck2.Location = new System.Drawing.Point(8, 36);
			this.ck2.Name = "ck2";
			this.ck2.Size = new System.Drawing.Size(128, 24);
			this.ck2.TabIndex = 40;
			this.ck2.Text = "checkBox3";
			this.ck2.CheckedChanged += new System.EventHandler(this.ck2_CheckedChanged);
			// 
			// cb_LEV_ID
			// 
			this.cb_LEV_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_LEV_ID.Enabled = false;
			this.cb_LEV_ID.Location = new System.Drawing.Point(412, 120);
			this.cb_LEV_ID.Name = "cb_LEV_ID";
			this.cb_LEV_ID.Size = new System.Drawing.Size(148, 24);
			this.cb_LEV_ID.TabIndex = 39;
			// 
			// ck7
			// 
			this.ck7.Location = new System.Drawing.Point(288, 120);
			this.ck7.Name = "ck7";
			this.ck7.Size = new System.Drawing.Size(128, 24);
			this.ck7.TabIndex = 38;
			this.ck7.Text = "checkBox3";
			this.ck7.CheckedChanged += new System.EventHandler(this.ck_7_CheckedChanged);
			// 
			// cb_TYP_ID
			// 
			this.cb_TYP_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_TYP_ID.Enabled = false;
			this.cb_TYP_ID.Location = new System.Drawing.Point(132, 120);
			this.cb_TYP_ID.Name = "cb_TYP_ID";
			this.cb_TYP_ID.Size = new System.Drawing.Size(148, 24);
			this.cb_TYP_ID.TabIndex = 37;
			// 
			// ck6
			// 
			this.ck6.Location = new System.Drawing.Point(8, 120);
			this.ck6.Name = "ck6";
			this.ck6.Size = new System.Drawing.Size(128, 24);
			this.ck6.TabIndex = 36;
			this.ck6.Text = "checkBox3";
			this.ck6.CheckedChanged += new System.EventHandler(this.ck6_CheckedChanged);
			// 
			// cb_POS_ID
			// 
			this.cb_POS_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_POS_ID.Enabled = false;
			this.cb_POS_ID.Location = new System.Drawing.Point(412, 92);
			this.cb_POS_ID.Name = "cb_POS_ID";
			this.cb_POS_ID.Size = new System.Drawing.Size(148, 24);
			this.cb_POS_ID.TabIndex = 35;
			// 
			// ck5
			// 
			this.ck5.Location = new System.Drawing.Point(288, 92);
			this.ck5.Name = "ck5";
			this.ck5.Size = new System.Drawing.Size(128, 24);
			this.ck5.TabIndex = 34;
			this.ck5.Text = "checkBox3";
			this.ck5.CheckedChanged += new System.EventHandler(this.ck5_CheckedChanged);
			// 
			// l1
			// 
			this.l1.Location = new System.Drawing.Point(288, 12);
			this.l1.Name = "l1";
			this.l1.Size = new System.Drawing.Size(124, 20);
			this.l1.TabIndex = 33;
			this.l1.Text = "label1";
			// 
			// dt2
			// 
			this.dt2.CustomFormat = "yyyy/MM/dd";
			this.dt2.Enabled = false;
			this.dt2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dt2.Location = new System.Drawing.Point(412, 8);
			this.dt2.Name = "dt2";
			this.dt2.Size = new System.Drawing.Size(148, 23);
			this.dt2.TabIndex = 32;
			// 
			// dt1
			// 
			this.dt1.CustomFormat = "yyyy/MM/dd";
			this.dt1.Enabled = false;
			this.dt1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dt1.Location = new System.Drawing.Point(132, 8);
			this.dt1.Name = "dt1";
			this.dt1.Size = new System.Drawing.Size(148, 23);
			this.dt1.TabIndex = 31;
			this.dt1.ValueChanged += new System.EventHandler(this.dt1_ValueChanged);
			// 
			// cmd_show
			// 
			this.cmd_show.BackColor = System.Drawing.SystemColors.Control;
			this.cmd_show.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_show.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmd_show.Location = new System.Drawing.Point(231, 148);
			this.cmd_show.Name = "cmd_show";
			this.cmd_show.Size = new System.Drawing.Size(104, 36);
			this.cmd_show.TabIndex = 30;
			this.cmd_show.Text = "button1";
			this.cmd_show.Click += new System.EventHandler(this.cmd_show_Click);
			// 
			// cb_DEP_ID
			// 
			this.cb_DEP_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_DEP_ID.Enabled = false;
			this.cb_DEP_ID.Location = new System.Drawing.Point(132, 92);
			this.cb_DEP_ID.Name = "cb_DEP_ID";
			this.cb_DEP_ID.Size = new System.Drawing.Size(148, 24);
			this.cb_DEP_ID.TabIndex = 26;
			// 
			// ck4
			// 
			this.ck4.Location = new System.Drawing.Point(8, 92);
			this.ck4.Name = "ck4";
			this.ck4.Size = new System.Drawing.Size(128, 24);
			this.ck4.TabIndex = 11;
			this.ck4.Text = "checkBox3";
			this.ck4.CheckedChanged += new System.EventHandler(this.ck4_CheckedChanged);
			// 
			// ck1
			// 
			this.ck1.Location = new System.Drawing.Point(8, 8);
			this.ck1.Name = "ck1";
			this.ck1.Size = new System.Drawing.Size(128, 24);
			this.ck1.TabIndex = 8;
			this.ck1.Text = "checkBox1";
			this.ck1.CheckedChanged += new System.EventHandler(this.ck1_CheckedChanged);
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.AliceBlue;
			this.panel6.Controls.Add(this.cmd_back);
			this.panel6.Controls.Add(this.cmd_sea);
			this.panel6.Controls.Add(this.cmd_input);
			this.panel6.Controls.Add(this.cmd_quickchange);
			this.panel6.Controls.Add(this.txt3);
			this.panel6.Controls.Add(this.txt2);
			this.panel6.Controls.Add(this.txt1);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel6.Location = new System.Drawing.Point(0, 0);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(764, 28);
			this.panel6.TabIndex = 4;
			// 
			// cmd_back
			// 
			this.cmd_back.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_back.Location = new System.Drawing.Point(592, 3);
			this.cmd_back.Name = "cmd_back";
			this.cmd_back.Size = new System.Drawing.Size(116, 23);
			this.cmd_back.TabIndex = 77;
			this.cmd_back.Text = "Quick Input";
			this.cmd_back.Visible = false;
			this.cmd_back.Click += new System.EventHandler(this.cmd_back_Click);
			// 
			// cmd_sea
			// 
			this.cmd_sea.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_sea.Location = new System.Drawing.Point(592, 3);
			this.cmd_sea.Name = "cmd_sea";
			this.cmd_sea.Size = new System.Drawing.Size(116, 23);
			this.cmd_sea.TabIndex = 76;
			this.cmd_sea.Text = "Quick Input";
			this.cmd_sea.Click += new System.EventHandler(this.cmd_sea_Click);
			// 
			// cmd_input
			// 
			this.cmd_input.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_input.Location = new System.Drawing.Point(472, 3);
			this.cmd_input.Name = "cmd_input";
			this.cmd_input.Size = new System.Drawing.Size(116, 23);
			this.cmd_input.TabIndex = 75;
			this.cmd_input.Text = "Quick Input";
			this.cmd_input.Click += new System.EventHandler(this.cmd_input_Click);
			// 
			// cmd_quickchange
			// 
			this.cmd_quickchange.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_quickchange.Location = new System.Drawing.Point(352, 3);
			this.cmd_quickchange.Name = "cmd_quickchange";
			this.cmd_quickchange.Size = new System.Drawing.Size(116, 23);
			this.cmd_quickchange.TabIndex = 74;
			this.cmd_quickchange.Text = "Quick Change";
			this.cmd_quickchange.Click += new System.EventHandler(this.cmd_quickchange_Click);
			// 
			// txt3
			// 
			this.txt3.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt3.Location = new System.Drawing.Point(236, 2);
			this.txt3.MaxLength = 20;
			this.txt3.Name = "txt3";
			this.txt3.Size = new System.Drawing.Size(112, 23);
			this.txt3.TabIndex = 73;
			this.txt3.Tag = "EMP_NM";
			this.txt3.Text = "textBox3";
			this.txt3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
			this.txt3.Leave += new System.EventHandler(this.textBox1_Leave);
			this.txt3.Enter += new System.EventHandler(this.textBox1_Enter);
			// 
			// txt2
			// 
			this.txt2.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt2.Location = new System.Drawing.Point(120, 2);
			this.txt2.MaxLength = 20;
			this.txt2.Name = "txt2";
			this.txt2.Size = new System.Drawing.Size(112, 23);
			this.txt2.TabIndex = 72;
			this.txt2.Tag = "EMP_I1";
			this.txt2.Text = "textBox3";
			this.txt2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
			this.txt2.Leave += new System.EventHandler(this.textBox1_Leave);
			this.txt2.Enter += new System.EventHandler(this.textBox1_Enter);
			// 
			// txt1
			// 
			this.txt1.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt1.Location = new System.Drawing.Point(4, 2);
			this.txt1.MaxLength = 20;
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(112, 23);
			this.txt1.TabIndex = 71;
			this.txt1.Tag = "EMP_ID";
			this.txt1.Text = "textBox3";
			this.txt1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
			this.txt1.Leave += new System.EventHandler(this.textBox1_Leave);
			this.txt1.Enter += new System.EventHandler(this.textBox1_Enter);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.panel4);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(764, 36);
			this.panel3.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Location = new System.Drawing.Point(348, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(416, 36);
			this.label5.TabIndex = 11;
			this.label5.Tag = "";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.panel4.Controls.Add(this.nav1);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(348, 36);
			this.panel4.TabIndex = 10;
			// 
			// nav1
			// 
			this.nav1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.nav1.Connection = null;
			this.nav1.ConnectionDel = null;
			this.nav1.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.nav1.form = null;
			this.nav1.FormName = null;
			this.nav1.Grid = null;
			this.nav1.History = false;
			this.nav1.IsNull = true;
			this.nav1.Language = "EN";
			this.nav1.Location = new System.Drawing.Point(4, 3);
			this.nav1.MSG_Exit = false;
			this.nav1.MulltiDel = false;
			this.nav1.Name = "nav1";
			this.nav1.Security = 0;
			this.nav1.ShowPopupMenu = true;
			this.nav1.Size = new System.Drawing.Size(344, 32);
			this.nav1.TabIndex = 10;
			this.nav1.Tag = "";
			this.nav1.ToolBar_Auto = true;
			this.nav1.UserID = null;
			this.nav1.VisibleGrid = true;
			this.nav1.Where = null;
			this.nav1.Load += new System.EventHandler(this.nav1_Load);
			// 
			// c1CommandDock1
			// 
			this.c1CommandDock1.Controls.Add(this.c1DockingTab1);
			this.c1CommandDock1.Dock = System.Windows.Forms.DockStyle.Left;
			this.c1CommandDock1.Id = 1;
			this.c1CommandDock1.Location = new System.Drawing.Point(0, 0);
			this.c1CommandDock1.Name = "c1CommandDock1";
			this.c1CommandDock1.Size = new System.Drawing.Size(264, 520);
			// 
			// c1DockingTab1
			// 
			this.c1DockingTab1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
			this.c1DockingTab1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.c1DockingTab1.CanAutoHide = true;
			this.c1DockingTab1.CanMoveTabs = true;
			this.c1DockingTab1.Controls.Add(this.c1DockingTabPage1);
			this.c1DockingTab1.Location = new System.Drawing.Point(0, 0);
			this.c1DockingTab1.Name = "c1DockingTab1";
			this.c1DockingTab1.SelectedIndex = 0;
			this.c1DockingTab1.ShowCaption = true;
			this.c1DockingTab1.ShowSingleTab = false;
			this.c1DockingTab1.Size = new System.Drawing.Size(264, 520);
			this.c1DockingTab1.TabIndex = 0;
			this.c1DockingTab1.TabSizeMode = C1.Win.C1Command.TabSizeModeEnum.Fit;
			this.c1DockingTab1.TabStyle = C1.Win.C1Command.TabStyleEnum.WindowsXP;
			// 
			// c1DockingTabPage1
			// 
			this.c1DockingTabPage1.Controls.Add(this.Dep);
			this.c1DockingTabPage1.ImageIndex = -1;
			this.c1DockingTabPage1.Location = new System.Drawing.Point(1, 1);
			this.c1DockingTabPage1.Name = "c1DockingTabPage1";
			this.c1DockingTabPage1.Size = new System.Drawing.Size(259, 518);
			this.c1DockingTabPage1.TabIndex = 0;
			this.c1DockingTabPage1.Text = "Page1";
			// 
			// Dep
			// 
			this.Dep.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Dep.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Dep.Location = new System.Drawing.Point(0, 20);
			this.Dep.Name = "Dep";
			this.Dep.Size = new System.Drawing.Size(259, 498);
			this.Dep.TabIndex = 2;
			// 
			// popmnu
			// 
			this.popmnu.RightToLeft = System.Windows.Forms.RightToLeft.No;
			// 
			// frmTaSalaryInput
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(1028, 520);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.c1CommandDock1);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaSalaryInput";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmTaSalaryInput";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmTaSalaryInput_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			this.panel7.ResumeLayout(false);
			this.p1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs1)).EndInit();
			this.p42.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandDock1)).EndInit();
			this.c1CommandDock1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).EndInit();
			this.c1DockingTab1.ResumeLayout(false);
			this.c1DockingTabPage1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaSalaryInput_Load(object sender, System.EventArgs e)
		{
			Init_vs();
			Init_vs1();
			Dep.Init_Tree(this.Tag+"");
			Dep.Show_Tree();
			Dep.vs1.AfterRowColChange+=new RangeEventHandler(Depvs1_AfterRowColChange);
			Basic.Function.PublicFunction.L_Init_Label(this);	
			if(wh+""!="")
			{
				nav1.Show_VS("EMP_ID=N'"+wh+"' and "+PublicFunction.Get_TYP(this.Tag,""));
				Show_VS1();
			}
			cmd_quickchange.Visible=PublicFunction.AccessLevel(this.Tag,3);
			Init_Menu();			
			Init_PMenu_Color();
		}				
		
		#region Init_menu
		private ContextMenu mnu1;
		ArrayList mnu;
		public void Init_PMenu_Color()
		{
			try
			{
				mnu=new ArrayList();							
				MenuItem mn;
				popmnu.MenuItems.Clear();
				mnu.Clear();					
				for(int i=0;i<vs.Cols.Count;i++)
				{				
					mn=new MenuItem();					
					mn.Text= (string)vs.Cols[i].Caption;					
										
					mnu.Add(vs.Cols[i].Name);
					popmnu.MenuItems.Add(mn);
					mn.Click+=new EventHandler(mn_Click);					
					mn.Checked=vs.Cols[i].Visible;
				}
			}
			catch(Exception ex){MessageBox.Show("Init Menu And Color error: "+ex.Message);}
		}

		private void mn_Click(object sender, EventArgs e)
		{			
			for(int i=0;i<popmnu.MenuItems.Count;i++)
			{
				if (sender.Equals(popmnu.MenuItems[i]))
				{
					if (popmnu.MenuItems[i].Checked==true)
					{
						vs.Cols[(string)mnu[i]].Visible=false;
						popmnu.MenuItems[i].Checked=false;
					}
					else
					{
						vs.Cols[(string)mnu[i]].Visible=true;
						popmnu.MenuItems[i].Checked=true;
					}
				}
			}
		}

		private void Init_Menu()
		{			
			mnu1=new ContextMenu();
			nav.cmd_report.Style=ToolBarButtonStyle.DropDownButton;
			nav.cmd_report.DropDownMenu =mnu1;
			int n=T_String.IsNullTo0(T_String.GetDataFromSQL("Count(*)","SYS_LABEL_PMENU","NAME=N'"+this.Name+"'"));
			Init_ReportSTD(n);					
			Init_LabelForMenu();			
		}
		

		private void Init_ReportSTD(int n)
		{				
			for (int i=0;i<n;i++)
			{		
				mnu1.MenuItems.Add("a");
			}	
			for (int i=0;i<mnu1.MenuItems.Count;i++)
			{
				mnu1.MenuItems[i].Click+=new EventHandler(menu_Click);
			}		
		}

		private void Init_LabelForMenu()
		{			
			for(int i=0;i<mnu1.MenuItems.Count;i++)
			{
				mnu1.MenuItems[i].Text=PublicFunction.L_Get_PopMenu(this.Name,i);
			}			
		}
	
		#endregion	
		#region menu click
		private void menu_Click(object sender, EventArgs e)
		{
			C1.C1Excel.C1XLBook c1XLBook1=new C1.C1Excel.C1XLBook();;
			//string sql="";			
			switch (mnu1.MenuItems.IndexOf((MenuItem)sender))
			{
				case 0:		
					GP8000.Personnel.Report.ReportFromVS rpt=new GP8000.Personnel.Report.ReportFromVS();
					rpt.RPT2(c1XLBook1,vs,mnu1.MenuItems[mnu1.MenuItems.IndexOf((MenuItem)sender)].Text,"STD_PR_01");					
					break;
				
			}
		}
		#endregion
		#region Init
		private void Init_vs()
		{
			nav.cmd_copy.Visible=false;
			nav.cmd_delete.Visible=false;
//			nav.cmd_report.Visible=false;
			nav.cmd_search.Visible=false;
			nav.cmd_exit.Visible=false;	
			nav.sql="SELECT SEQ_NO,a.EMP_ID,EMP_I1,EMP_NM,DEP_ID,POS_ID,TYP_ID,LEV_ID,CHA_DT,a.NOT_DR,DON_AP,REA_DR";
			string sql="";
			sql="Select * from FILD01A where"; 
			if(ACC)
				sql+=" ACC_BT=1 order by SEQ_NO";
			else
				sql+=" HUR_BT=1 order by SEQ_NO";
			rsitem=new Func.RecordSet(sql,PublicFunction.C_con);
			for(int i=0;i<rsitem.rows;i++)
			{
				nav.sql+=",["+rsitem.record(i,"COL_NM")+"]";
			}
			nav.sql+=",a.BLT_NM,a.BLT_DT,a.LST_NM,a.LST_DT ";
			nav.sql+=" from FILD03A a Left JOIN FILB01A b on a.EMP_ID=b.EMP_ID  Left JOIN FILB01AC c on a.EMP_ID=c.EMP_ID";
			nav.tb="FILD03A";
			PublicFunction.InitNav(this,vs,nav);		
			nav.Msg_ExitSave=true;			
		
			vs.EnabledChanged+=new EventHandler(vs_EnabledChanged);		
			nav.ToolBar_Auto=false;				
			nav.TBarClick+=new ToolBarButtonClickEventHandler(nav_TBarClick);	
			
			//vs.Cols["EMP_ID"].ComboList="|...";
			vs.Cols["CHA_DT"].Format=PublicFunction.GetOption("DATE");
			vs.Cols["BLT_DT"].Format=vs.Cols["LST_DT"].Format=PublicFunction.GetOption("DATE")+" hh:mm";
			vs.CellButtonClick+=new C1.Win.C1FlexGrid.RowColEventHandler(vs_CellButtonClick);
			vs.AfterEdit+=new C1.Win.C1FlexGrid.RowColEventHandler(vs_AfterEdit);
			vs.BeforeEdit+=new RowColEventHandler(vs_BeforeEdit);
		
			for(int i=0;i<rsitem.rows;i++)
			{
				vs.Cols[rsitem.record(i,"COL_NM")].Visible=false;
				if (Func.Fun.CheckFieldOfTable(PublicFunction.C_con,"FILD01A","FLT_BT"))
				{
					if (rsitem.record(i,"FLT_BT")=="True")
						vs.Cols[rsitem.record(i,"COL_NM")].Format="#,###.00";
					else
						vs.Cols[rsitem.record(i,"COL_NM")].Format="#,###";
				}
				else
					vs.Cols[rsitem.record(i,"COL_NM")].Format="#,###";
			}
			
			sql="Select * from FILD01A where BAS_BT=1 ";
			if(ACC)
				sql+=" and ACC_BT=1";
			else
				sql+=" and HUR_BT=1";
			Func.RecordSet rs=new Func.RecordSet(sql,PublicFunction.C_con);
			for(int i=0;i<rs.rows;i++)
			{
				vs.Cols[rs.record(i,"COL_NM")].Visible=true;;
			}
			Init_Color();
			vs.Cols["EMP_ID"].Visible=vs.Cols["EMP_I1"].Visible=vs.Cols["EMP_NM"].Visible 
				=vs.Cols["DEP_ID"].Visible=vs.Cols["POS_ID"].Visible=vs.Cols["TYP_ID"].Visible=vs.Cols["LEV_ID"].Visible=false;		
			
		}
	
		private void Init_vs1()
		{			
			nav1.cmd_copy.Visible=false;
			nav1.cmd_save.Visible=false;
			nav1.cmd_add.Visible=false;
			nav1.cmd_delete.Visible=false;
			nav1.cmd_report.Visible=false;
			nav1.cmd_search.Visible=false;		
			PublicFunction.InitNav(this,vs1,nav1);			
			vs1.AllowEditing=false;
			vs1.AfterRowColChange+=new RangeEventHandler(vs1_AfterRowColChange);
			Init_CB();
			nav1.ToolBar_Auto=false;				
			nav1.TBarClick+=new ToolBarButtonClickEventHandler(nav1_TBarClick);
			vs1.Styles.Add("VAC_BT");
			vs1.Styles["VAC_BT"].BackColor=Color.DarkGray;
		}	
		
		private void Init_Color()
		{
			nav.Lock=new ArrayList();			
			nav.Lock.Add("BLT_DT");
			nav.Lock.Add("BLT_NM");
			nav.Lock.Add("LST_DT");
			nav.Lock.Add("LST_NM");
			nav.Lock.Add("SEQ_NO");
			nav.Lock.Add("REA_DR");
			nav.Color_VS();
		}
	

		private void Depvs1_AfterRowColChange(object sender, RangeEventArgs e)
		{
			if(e.OldRange.r1!=e.NewRange.r1)
			{
				Show_VS();
			}
		}
		#endregion
		#region ShowData
		private void Show_VS()
		{
			if(Dep.vs1.Row<=0)
			{
				vs1.Rows.Count=1;			
				return;
			}
			nav1.Show_VS("DEP_ID in "+Dep.Get_DepAll()
				+" and  (DEL_BT is null OR DEL_BT=0) and "+PublicFunction.Get_TYP(this.Tag,""));
			for(int i=1;i<vs1.Rows.Count;i++)
			{
				if(vs1.Rows[i]["VAC_BT"]+""=="True")
				{
					for(int c=1;c<vs1.Cols.Count;c++)
						vs1.SetCellStyle(i,c, vs1.Styles["VAC_BT"]);
				}
			}
			Show_VS1();
		}		
		private void Show_VS1()
		{
			if(vs1.Row<=0)
			{
				vs.Rows.Count=1;			
				return;
			}
			nav.Show_VS("a.EMP_ID=N'"+vs1.Rows[vs1.Row]["EMP_ID"]+"'and "+PublicFunction.Get_TYP(this.Tag,"")+" ORDER BY CHA_DT ");	
			
			Init_Color();	
		}	
		#endregion
		#region Search
		private void textBox1_Enter(object sender, System.EventArgs e)
		{
			TextBox txt=(TextBox)sender;
			if (txt.Text==vs1.Cols[txt.Tag+""].Caption)
				txt.Text="";
		}

		private void textBox1_Leave(object sender, System.EventArgs e)
		{
			TextBox txt=(TextBox)sender;
			if (txt.Text=="")
				txt.Text=vs1.Cols[txt.Tag+""].Caption;
		}

		private void textBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Enter)
			{
				string f=((TextBox)sender).Tag+"";			
				string sql;				
				if(((TextBox)sender).Text+""!="")
					sql=f+" like N'%"+((TextBox)sender).Text+"%'";
				else
					sql="1=1";
				sql=sql+" and DEP_ID in (Select DEP_ID  from SYS_SECURITY_DEP"+
					" where MNU_ID="+this.Tag+" and ALL_BT=1  and USER_ID=N'"+PublicFunction.A_UserID+"')"
					+" and (DEL_BT=0 or DEL_BT is null) and  "+PublicFunction.Get_TYP(this.Tag,"");
				nav1.Show_VS(sql);	
				Show_VS1();	
			}
		}
	
		
		#endregion
		private void nav_TBarClick(object sender, ToolBarButtonClickEventArgs e)
		{	
			if (e.Button.Equals(nav.cmd_add))
			{
				if(vs1.Row<=0)
					return;
				if(vs.Rows[vs.Rows.Count-1].UserData+""=="2")
					return;
				nav.ToolBar_Click(e);
				Init_Color();				
				vs.Rows[vs.Rows.Count-1]["EMP_ID"]=vs1.Rows[vs1.Row]["EMP_ID"];
				vs_AfterEdit(vs,new C1.Win.C1FlexGrid.RowColEventArgs(vs.Rows.Count-1,vs.Cols["EMP_ID"].Index));				
				vs.Rows[vs.Rows.Count-1]["BLT_NM"]=PublicFunction.A_UserID;
				vs.Rows[vs.Rows.Count-1]["CHA_DT"]=T_String.GetDate().ToString("yyyy/MM/dd");
				vs.Rows[vs.Rows.Count-1]["BLT_DT"]=T_String.GetDate().ToString("yyyy/MM/dd HH:mm");
				return;
			}
			if (e.Button.Equals(nav.cmd_save))
			{					
				nav.ToolBar_Click(e);
				return;
			}
			if (e.Button.Equals(nav.cmd_refresh))
			{
				if(nav.wh!="")
					nav.ToolBar_Click(e);
				else
					nav.Show_VS("(DEL_BT is null OR DEL_BT=0)  and DEP_ID in "
						+T_String.DEP_ID(this.Tag) +" and "+PublicFunction.Get_TYP(this.Tag,"")+" ORDER BY CHA_DT" );
				Init_Color();
				return;
			}
			nav.ToolBar_Click(e);
		}

		private void nav1_TBarClick(object sender, ToolBarButtonClickEventArgs e)
		{
			if (e.Button.Equals(nav1.cmd_refresh))
			{
				if(nav1.wh!="")
				{
					nav1.ToolBar_Click(e);
					for(int i=1;i<vs1.Rows.Count;i++)
					{
						if(vs1.Rows[i]["VAC_BT"]+""=="True")
						{
							for(int c=1;c<vs1.Cols.Count;c++)
								vs1.SetCellStyle(i,c, vs1.Styles["VAC_BT"]);
						}
					}
				}
				else
				{
					nav1.Show_VS("DEP_ID in "+T_String.DEP_ID(this.Tag)+" and "
						+PublicFunction.Get_TYP(this.Tag,""));	
					for(int i=1;i<vs1.Rows.Count;i++)
					{
						if(vs1.Rows[i]["VAC_BT"]+""=="True")
						{
							for(int c=1;c<vs1.Cols.Count;c++)
								vs1.SetCellStyle(i,c, vs1.Styles["VAC_BT"]);
						}
					}
				}
				return;
			}
			nav1.ToolBar_Click(e);
		}

		private void vs_EnabledChanged(object sender, EventArgs e)
		{			
			string sql="Select * from FILD01A where BAS_BT=1 ";
			if(ACC)
				sql+=" and ACC_BT=1";
			else
				sql+=" and HUR_BT=1";
			Func.RecordSet rs=new Func.RecordSet(sql,PublicFunction.C_con);
			for(int i=0;i<rs.rows;i++)
			{
				try
				{
					vs.Cols[rs.record(i,"COL_NM")].Caption=rs.record(i,"COL_"+PublicFunction.L_Lag);
				}
				catch{}
			}
			txt1.Text=vs1.Cols[txt1.Tag+""].Caption;
			txt2.Text=vs1.Cols[txt2.Tag+""].Caption;
			txt3.Text=vs1.Cols[txt3.Tag+""].Caption;	
			vs.AutoSizeCols();
		}

		private void vs_CellButtonClick(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			string sql="";
			sql="Select EMP_ID,EMP_I1,EMP_NM,DEP_ID,POS_ID,LEV_ID from FILB01A where (VAC_BT is null or VAC_BT=0) and DEP_ID in (Select DEP_ID  from SYS_SECURITY_DEP"+
				" where MNU_ID="+this.Tag+" and ALL_BT=1 and USER_ID=N'"+PublicFunction.A_UserID+"') and "+PublicFunction.Get_TYP(this.Tag,"");
			if(vs.Rows[vs.Row]["DEP_ID"]+""!="")
				sql+=" and DEP_ID=N'"+vs.Rows[vs.Row]["DEP_ID"]+"'";
			Func.RecordSet rs=new Func.RecordSet(sql,PublicFunction.C_con);
			frmSearch dlg=new frmSearch(rs,3,"frmTaStaffInfo_vs");
			if(dlg.ShowDialog()==DialogResult.OK)
			{
				vs.Rows[vs.Row]["EMP_ID"]=rs.record(rs.Bookmarks,"EMP_ID");
			}
			vs.AutoSizeCols();
		}

		private void vs_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			if(vs.Cols[e.Col].Name=="EMP_ID")
			{
//				string sql="";
//				sql="Select EMP_ID,EMP_I1,EMP_NM,DEP_ID,POS_ID,LEV_ID from FILB01A where (VAC_BT is null or VAC_BT=0) and DEP_ID in (Select DEP_ID  from SYS_SECURITY_DEP"+
//					" where MNU_ID="+this.Tag+" and ALL_BT=1 and USER_ID=N'"+PublicFunction.A_UserID+"') and EMP_ID=N'"+vs.Rows[vs.Row]["EMP_ID"]+"'";
//				Func.RecordSet rs=new Func.RecordSet(sql,PublicFunction.C_con);
//				if(rs.rows<=0)
//				{
//					MessageBox.Show(PublicFunction.L_Get_Msg("msg",96));
//					vs.Rows[vs.Row]["EMP_ID"]="";					
//					return;
//				}
//				vs.Rows[vs.Row]["DEP_ID"]=rs.record(0,"DEP_ID");
//				vs.Rows[vs.Row]["EMP_I1"]=rs.record(0,"EMP_I1");
//				vs.Rows[vs.Row]["EMP_NM"]=rs.record(0,"EMP_NM");
//				vs.Rows[vs.Row]["POS_ID"]=rs.record(0,"POS_ID");
//				vs.Rows[vs.Row]["LEV_ID"]=rs.record(0,"LEV_ID");
				vs.Rows[vs.Row]["SEQ_NO"]=T_String.GetMax("MAX(SEQ_NO)","FILD03A","EMP_ID=N'"+vs.Rows[vs.Row]["EMP_ID"]+"'");
				GetOldSalary(vs.Row,vs.Rows[vs.Row]["EMP_ID"]+"");
			}
			vs.Rows[vs.Rows.Count-1]["LST_NM"]=PublicFunction.A_UserID;
			vs.Rows[vs.Rows.Count-1]["LST_DT"]=T_String.GetDate().ToString("yyyy/MM/dd HH:mm");
			vs.AutoSizeCols();
			if(vs.Cols[e.Col].Name=="DON_AP")
			{
				frmTaTXT dlg=new frmTaTXT();
				if(dlg.ShowDialog(this)==DialogResult.OK)
				{
					vs.Rows[vs.Row]["REA_DR"]=dlg.txt.Text;
				}
				else
				{
					vs.Rows[vs.Row]["DON_AP"]=false;
				}
			}	
		}

		private void GetOldSalary(int row,string EMP_ID)
		{
			string sql;
			sql="Select * from FILD03A where EMP_ID=N'"+EMP_ID+"' and (DON_AP=0 or DON_AP is null) ORDER BY SEQ_NO DESC";
			Func.RecordSet rs=new Func.RecordSet(sql,PublicFunction.C_con);
			if(rs.rows<=0) return;
			for(int i=0;i<rsitem.rows;i++)
			{
				vs.Rows[vs.Row][rsitem.record(i,"COL_NM")]=rs.record(0,rsitem.record(i,"COL_NM"));			
			}
		}

		private void vs_BeforeEdit(object sender, RowColEventArgs e)
		{
			if(vs.Rows[e.Row]["DON_AP"]+""=="True")
				e.Cancel=true;
			if(vs.Cols[e.Col].Name!="DON_AP" && vs.Rows[e.Row].UserData+""!="2")
				e.Cancel=true;
		}

		private void cmd_quickchange_Click(object sender, System.EventArgs e)
		{
			frmTaQuickChangeSalary dlg=new frmTaQuickChangeSalary(ACC);
			dlg.Tag=this.Tag;
			dlg.ShowDialog();
		}

		private void vs1_AfterRowColChange(object sender, RangeEventArgs e)
		{
			if(e.NewRange.r1!=e.OldRange.r1)
				Show_VS1();
		}

		private void cmd_input_Click(object sender, System.EventArgs e)
		{
			frmTaQuickInput dlg= new frmTaQuickInput();
			dlg.acc=this.ACC;
			dlg.Tag=this.Tag;
			dlg.ShowDialog();
		}
		#region search

		private void cmd_sea_Click(object sender, System.EventArgs e)
		{
			p42.Visible=true;
			p1.Visible=false;
			p42.Dock=DockStyle.Fill;
			cmd_back.Visible=true;
			txt1.Visible=txt2.Visible=txt3.Visible=cmd_sea.Visible=false;
			nav.cmd_add.Visible=false;
			nav.cmd_report.Visible=true;
			vs.Cols["EMP_ID"].Visible=vs.Cols["EMP_I1"].Visible=vs.Cols["EMP_NM"].Visible
				=vs.Cols["DEP_ID"].Visible=vs.Cols["POS_ID"].Visible=vs.Cols["TYP_ID"].Visible=vs.Cols["LEV_ID"].Visible=true;
			c1CommandDock1.Visible=false;
			vs.ContextMenu=popmnu;
			Init_PMenu_Color();
		}

		private void cmd_back_Click(object sender, System.EventArgs e)
		{
			p42.Visible=false ;
			p1.Visible=true;			
			cmd_back.Visible=false;
			txt1.Visible=txt2.Visible=txt3.Visible=cmd_sea.Visible=true;
			nav.cmd_add.Visible=true;
			nav.cmd_report.Visible=false;
			vs.Cols["EMP_ID"].Visible=vs.Cols["EMP_I1"].Visible=vs.Cols["EMP_NM"].Visible
			=vs.Cols["DEP_ID"].Visible=vs.Cols["POS_ID"].Visible=vs.Cols["TYP_ID"].Visible=vs.Cols["LEV_ID"].Visible=false;			
			c1CommandDock1.Visible=true;
			vs.ContextMenu=null;
		}

		private void ck1_CheckedChanged(object sender, System.EventArgs e)
		{
			dt1.Enabled=dt2.Enabled=ck1.Checked;
		}

		private void ck2_CheckedChanged(object sender, System.EventArgs e)
		{
			txt_EMP_ID.Enabled=txt_EMP_ID1.Enabled=ck2.Checked;
		}

		private void ck3_CheckedChanged(object sender, System.EventArgs e)
		{
			txt_EMP_I1.Enabled=txt_EMP_I11.Enabled=ck3.Checked;
		}

		private void ck4_CheckedChanged(object sender, System.EventArgs e)
		{
			cb_DEP_ID.Enabled=ck4.Checked;
		}

		private void ck5_CheckedChanged(object sender, System.EventArgs e)
		{
			cb_POS_ID.Enabled=ck5.Checked;
		}

		private void ck6_CheckedChanged(object sender, System.EventArgs e)
		{
			cb_TYP_ID.Enabled=ck6.Checked;
		}

		private void ck_7_CheckedChanged(object sender, System.EventArgs e)
		{	
			cb_LEV_ID.Enabled=ck7.Checked;
		}
		private void  Init_CB()
		{			
			string sql;			
			//Department
			sql=PublicFunction.GetDep(this.Tag+"");			
			vs.Cols["DEP_ID"].DataMap=PublicFunction.InitCBForVS(sql);	
			vs1.Cols["DEP_ID"].DataMap=PublicFunction.InitCBForVS(sql);	
			PublicFunction.InitCB(cb_DEP_ID,sql);
		
			//Position
			sql="Select POS_ID,POS_NM from FILA07A ";		
			vs.Cols["POS_ID"].DataMap=PublicFunction.InitCBForVS(sql);
			vs1.Cols["POS_ID"].DataMap=PublicFunction.InitCBForVS(sql);
			PublicFunction.InitCB(cb_POS_ID,sql);
			//nature 
			sql="Select TYP_ID,TYP_NM from FILA11A where   "+PublicFunction.Get_TYP(this.Tag,"");
			vs.Cols["TYP_ID"].DataMap=PublicFunction.InitCBForVS(sql);
			//vs1.Cols["TYP_ID"].DataMap=PublicFunction.InitCBForVS(sql);
			PublicFunction.InitCB(cb_TYP_ID,sql);
			//Level
			sql="Select LEV_ID,LEV_NM from FILA19A";
			vs.Cols["LEV_ID"].DataMap=PublicFunction.InitCBForVS(sql);
		
			PublicFunction.InitCB(cb_LEV_ID,sql);
			
		}

		private void cmd_show_Click(object sender, System.EventArgs e)
		{
			string sql="";
			if(ck1.Checked)
			{
				sql+=" (CHA_DT between '"+DateTime.Parse(dt1.Value+"").ToString("yyyy/MM/dd") 
					+" 00:00:00' and '"+DateTime.Parse(dt2.Value+"").ToString("yyyy/MM/dd")  +" 23:59:59')" ;
			}
			if(ck2.Checked)
			{
				if(sql!="")	sql+=" and ";
				sql+="( a.EMP_ID between N'"+txt_EMP_ID.Text+"' and  N'"+txt_EMP_ID1.Text+"')";
			}
			if(ck3.Checked)
			{
				if(sql!="")	sql+=" and ";
				sql+="( EMP_I1 between N'"+txt_EMP_I1.Text+"' and  N'"+txt_EMP_I11.Text+"')";
			}
			if(ck4.Checked)
			{
				if(sql!="")	sql+=" and ";
				sql+=" (DEP_ID=N'"+cb_DEP_ID.SelectedValue+"') ";
			}
			if(ck5.Checked)
			{
				if(sql!="")	sql+=" and ";
				sql+=" (POS_ID=N'"+cb_POS_ID.SelectedValue+"' )";
			}
			if(ck6.Checked)
			{
				if(sql!="")	sql+=" and ";
				sql+=" (TYP_ID=N'"+cb_TYP_ID.SelectedValue+"' )";
			}
			if(ck7.Checked)
			{
				if(sql!="")	sql+=" and ";
				sql+=" (LEV_ID=N'"+cb_LEV_ID.SelectedValue+"' )";
			}
			
			if(sql!="") sql+=" and ";
			sql+=" DEP_ID in "+T_String.DEP_ID(this.Tag)+" and "+PublicFunction.Get_TYP(this.Tag,"");
			nav.Show_VS(sql +" Order by a.EMP_ID,CHA_DT,SEQ_NO");
		}
		private void txt_EMP_ID_TextChanged(object sender, System.EventArgs e)
		{
			txt_EMP_ID1.Text=txt_EMP_ID.Text;
		}

		private void txt_EMP_I1_TextChanged(object sender, System.EventArgs e)
		{
			txt_EMP_I11.Text=txt_EMP_I1.Text;
		}

		private void dt1_ValueChanged(object sender, System.EventArgs e)
		{
			dt2.Value=dt1.Value;
		}
		#endregion

		private void nav1_Load(object sender, System.EventArgs e)
		{
		
		}

		

	}
}

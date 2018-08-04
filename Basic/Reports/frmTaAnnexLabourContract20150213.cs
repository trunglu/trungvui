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
using C1.Win.C1FlexGrid;
using System.Data;
using System.Data.SqlClient;

namespace GP8000.Reports
{
	/// <summary>
	/// Summary description for frmTaLabourContract.
	/// </summary>
	public class frmTaAnnexLabourContract : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel1;
		private C1.Win.C1Command.C1DockingTab c1DockingTab1;
		private C1.Win.C1Command.C1DockingTabPage Tab_1;
		private C1.Win.C1Command.C1DockingTabPage Tab_3;
		private C1.Win.C1Command.C1DockingTabPage Tab_4;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel5;
		private Navigator1._0.NavigatorAuto nav;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel panel8;
		private C1.Win.C1FlexGrid.C1FlexGrid vs;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.Splitter splitter2;
		private System.Windows.Forms.Panel panel10;
		private C1.Win.C1FlexGrid.C1FlexGrid vs1;
		private Navigator1._0.NavigatorAuto nav1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_LAB_NM;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txt_LAB_NO;
		private System.Windows.Forms.TextBox txt_LAB_ID;
		private System.Windows.Forms.TextBox txt_1;
		private System.Windows.Forms.TextBox txt_2;
		private System.Windows.Forms.TextBox txt_3;
		private System.Windows.Forms.Label lb;
		private System.Windows.Forms.Button cmd_type;
		private System.Windows.Forms.TextBox txt;
		private System.Windows.Forms.Panel panel13;
		private System.Windows.Forms.Splitter splitter4;
		private System.Windows.Forms.Panel panel6;
		private C1.Win.C1Command.C1CommandDock c1CommandDock1;
		private C1.Win.C1Command.C1DockingTab c1DockingTab2;
		private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage1;
		private GP8000.UserControl.CrtTaDepartment Dep;
		private System.Windows.Forms.Panel panel19;
		private System.Windows.Forms.Splitter splitter6;
		private System.Windows.Forms.Panel panel22;
		private Navigator1._0.NavigatorAuto nav5;
		private C1.Win.C1FlexGrid.C1FlexGrid vs5;
		private System.Windows.Forms.Panel p41;
		private System.Windows.Forms.Panel panel21;
		private System.Windows.Forms.Button Tab_4_cmd_back;
		private System.Windows.Forms.Panel p42;
		private System.Windows.Forms.Panel p43;
		private C1.Win.C1FlexGrid.C1FlexGrid vs6;
		private Navigator1._0.NavigatorAuto nav6;
		private System.Windows.Forms.Button Tab_4_cmd_sea;
		private System.Windows.Forms.CheckBox ck410;
		private System.Windows.Forms.CheckBox ck49;
		private System.Windows.Forms.CheckBox ck48;
		private System.Windows.Forms.CheckBox ck47;
		private System.Windows.Forms.CheckBox ck46;
		private System.Windows.Forms.CheckBox ck45;
		private System.Windows.Forms.CheckBox ck44;
		private System.Windows.Forms.CheckBox ck43;
		private System.Windows.Forms.CheckBox ck42;
		private System.Windows.Forms.CheckBox ck41;
		private System.Windows.Forms.ComboBox Tab_4_cb_LAB_NO;
		private System.Windows.Forms.ComboBox Tab_4_cb_DEP_ID;
		private System.Windows.Forms.ComboBox Tab_4_cb_TYP_ID;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Panel p45;
		private System.Windows.Forms.Button cmd_show;
		private System.Windows.Forms.TextBox tab_4_txt_DWID;
		private System.Windows.Forms.TextBox tab_4_txt_WID;
		private System.Windows.Forms.TextBox Tab_4_txt_LAB_ID;
		private System.Windows.Forms.TextBox Tab_4_txt_EMP_I1;
		private System.Windows.Forms.TextBox Tab_4_txt_EMP_ID;
		private System.Windows.Forms.Button Tab_4_cmd_print;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Splitter splitter3;
		private System.Windows.Forms.Panel panel11;
		private System.Windows.Forms.Panel p31;
		private System.Windows.Forms.Panel panel16;
		private System.Windows.Forms.Button Tab_3_cmd_print;
		private System.Windows.Forms.Button Tab3_cmd_Show;
		private System.Windows.Forms.Panel panel18;
		private System.Windows.Forms.RadioButton rd32;
		private System.Windows.Forms.RadioButton rd31;
		private System.Windows.Forms.Panel Tab_3_p1;
		private System.Windows.Forms.TextBox Tab_3_txt_WID;
		private System.Windows.Forms.ComboBox Tab_3_cb_TYP_ID;
		private System.Windows.Forms.ComboBox Tab_3_cb_POS_ID;
		private System.Windows.Forms.ComboBox Tab_3_cb_DEP_ID;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox tab_3_txt_DWID2;
		private System.Windows.Forms.TextBox tab_3_txt_DWID1;
		private System.Windows.Forms.TextBox tab_3_txt_WID2;
		private System.Windows.Forms.TextBox tab_3_txt_WID1;
		private System.Windows.Forms.RadioButton rd46;
		private System.Windows.Forms.RadioButton rd45;
		private System.Windows.Forms.RadioButton rd44;
		private System.Windows.Forms.RadioButton rd43;
		private System.Windows.Forms.RadioButton rd42;
		private System.Windows.Forms.RadioButton rd41;
		private System.Windows.Forms.Panel Tab_3_p2;
		private System.Windows.Forms.Panel panel12;
		private System.Windows.Forms.Splitter splitter5;
		private System.Windows.Forms.Panel panel15;
		private System.Windows.Forms.Panel panel14;
		private System.Windows.Forms.Button tab_3_cmd4;
		private System.Windows.Forms.Button tab_3_cmd3;
		private System.Windows.Forms.Button tab_3_cmd2;
		private System.Windows.Forms.Button tab_3_cmd1;
		private System.Windows.Forms.Panel panel17;
		private System.Windows.Forms.Panel panel20;
		private C1.Win.C1FlexGrid.C1FlexGrid vs2;
		private C1.Win.C1FlexGrid.C1FlexGrid vs3;
		private Navigator1._0.NavigatorAuto nav2;
		private Navigator1._0.NavigatorAuto nav3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Panel panel23;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private C1.Win.C1FlexGrid.C1FlexGrid vs7;
		private System.Windows.Forms.Panel panel24;
		private Navigator1._0.NavigatorAuto nav4;
		private System.Windows.Forms.ComboBox cb_LAB_TP;
		private C1.Win.C1FlexGrid.C1FlexGrid vs4;
		private System.Windows.Forms.DateTimePicker Tab_3_dt2;
		private System.Windows.Forms.DateTimePicker Tab_3_dt1;
//		private AxPrintReportExcel.AxReportExcel rp;		
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaAnnexLabourContract()
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
			this.c1DockingTab1 = new C1.Win.C1Command.C1DockingTab();
			this.Tab_1 = new C1.Win.C1Command.C1DockingTabPage();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel8 = new System.Windows.Forms.Panel();
			this.panel10 = new System.Windows.Forms.Panel();
			this.txt = new System.Windows.Forms.TextBox();
			this.cmd_type = new System.Windows.Forms.Button();
			this.vs1 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.nav1 = new Navigator1._0.NavigatorAuto();
			this.splitter2 = new System.Windows.Forms.Splitter();
			this.panel9 = new System.Windows.Forms.Panel();
			this.lb = new System.Windows.Forms.Label();
			this.txt_3 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txt_2 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txt_1 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_LAB_ID = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_LAB_NM = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_LAB_NO = new System.Windows.Forms.TextBox();
			this.nav = new Navigator1._0.NavigatorAuto();
			this.label1 = new System.Windows.Forms.Label();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.panel7 = new System.Windows.Forms.Panel();
			this.vs = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.Tab_3 = new C1.Win.C1Command.C1DockingTabPage();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel13 = new System.Windows.Forms.Panel();
			this.panel11 = new System.Windows.Forms.Panel();
			this.panel24 = new System.Windows.Forms.Panel();
			this.vs4 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.nav4 = new Navigator1._0.NavigatorAuto();
			this.panel23 = new System.Windows.Forms.Panel();
			this.vs7 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.label13 = new System.Windows.Forms.Label();
			this.cb_LAB_TP = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.splitter3 = new System.Windows.Forms.Splitter();
			this.panel4 = new System.Windows.Forms.Panel();
			this.p31 = new System.Windows.Forms.Panel();
			this.Tab_3_p2 = new System.Windows.Forms.Panel();
			this.panel15 = new System.Windows.Forms.Panel();
			this.panel20 = new System.Windows.Forms.Panel();
			this.nav3 = new Navigator1._0.NavigatorAuto();
			this.vs3 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.splitter5 = new System.Windows.Forms.Splitter();
			this.panel12 = new System.Windows.Forms.Panel();
			this.panel17 = new System.Windows.Forms.Panel();
			this.nav2 = new Navigator1._0.NavigatorAuto();
			this.vs2 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.panel14 = new System.Windows.Forms.Panel();
			this.tab_3_cmd4 = new System.Windows.Forms.Button();
			this.tab_3_cmd3 = new System.Windows.Forms.Button();
			this.tab_3_cmd2 = new System.Windows.Forms.Button();
			this.tab_3_cmd1 = new System.Windows.Forms.Button();
			this.Tab_3_p1 = new System.Windows.Forms.Panel();
			this.Tab_3_txt_WID = new System.Windows.Forms.TextBox();
			this.Tab_3_cb_TYP_ID = new System.Windows.Forms.ComboBox();
			this.Tab_3_cb_POS_ID = new System.Windows.Forms.ComboBox();
			this.Tab_3_cb_DEP_ID = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.tab_3_txt_DWID2 = new System.Windows.Forms.TextBox();
			this.tab_3_txt_DWID1 = new System.Windows.Forms.TextBox();
			this.tab_3_txt_WID2 = new System.Windows.Forms.TextBox();
			this.tab_3_txt_WID1 = new System.Windows.Forms.TextBox();
			this.rd46 = new System.Windows.Forms.RadioButton();
			this.rd45 = new System.Windows.Forms.RadioButton();
			this.rd44 = new System.Windows.Forms.RadioButton();
			this.rd43 = new System.Windows.Forms.RadioButton();
			this.rd42 = new System.Windows.Forms.RadioButton();
			this.rd41 = new System.Windows.Forms.RadioButton();
			this.panel18 = new System.Windows.Forms.Panel();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.rd32 = new System.Windows.Forms.RadioButton();
			this.rd31 = new System.Windows.Forms.RadioButton();
			this.panel16 = new System.Windows.Forms.Panel();
			this.Tab_3_cmd_print = new System.Windows.Forms.Button();
			this.Tab3_cmd_Show = new System.Windows.Forms.Button();
			this.splitter4 = new System.Windows.Forms.Splitter();
			this.Tab_4 = new C1.Win.C1Command.C1DockingTabPage();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel19 = new System.Windows.Forms.Panel();
			this.panel22 = new System.Windows.Forms.Panel();
			this.nav5 = new Navigator1._0.NavigatorAuto();
			this.vs5 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.splitter6 = new System.Windows.Forms.Splitter();
			this.p41 = new System.Windows.Forms.Panel();
			this.p43 = new System.Windows.Forms.Panel();
			this.vs6 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.nav6 = new Navigator1._0.NavigatorAuto();
			this.p42 = new System.Windows.Forms.Panel();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.Tab_4_cb_TYP_ID = new System.Windows.Forms.ComboBox();
			this.Tab_4_cb_DEP_ID = new System.Windows.Forms.ComboBox();
			this.Tab_4_cb_LAB_NO = new System.Windows.Forms.ComboBox();
			this.ck410 = new System.Windows.Forms.CheckBox();
			this.ck49 = new System.Windows.Forms.CheckBox();
			this.ck48 = new System.Windows.Forms.CheckBox();
			this.ck47 = new System.Windows.Forms.CheckBox();
			this.Tab_4_txt_EMP_I1 = new System.Windows.Forms.TextBox();
			this.ck46 = new System.Windows.Forms.CheckBox();
			this.Tab_4_txt_EMP_ID = new System.Windows.Forms.TextBox();
			this.ck45 = new System.Windows.Forms.CheckBox();
			this.tab_4_txt_DWID = new System.Windows.Forms.TextBox();
			this.ck44 = new System.Windows.Forms.CheckBox();
			this.tab_4_txt_WID = new System.Windows.Forms.TextBox();
			this.ck43 = new System.Windows.Forms.CheckBox();
			this.Tab_4_txt_LAB_ID = new System.Windows.Forms.TextBox();
			this.ck42 = new System.Windows.Forms.CheckBox();
			this.ck41 = new System.Windows.Forms.CheckBox();
			this.panel21 = new System.Windows.Forms.Panel();
			this.Tab_4_cmd_print = new System.Windows.Forms.Button();
			this.p45 = new System.Windows.Forms.Panel();
			this.cmd_show = new System.Windows.Forms.Button();
			this.Tab_4_cmd_back = new System.Windows.Forms.Button();
			this.Tab_4_cmd_sea = new System.Windows.Forms.Button();
			this.c1CommandDock1 = new C1.Win.C1Command.C1CommandDock();
			this.c1DockingTab2 = new C1.Win.C1Command.C1DockingTab();
			this.c1DockingTabPage1 = new C1.Win.C1Command.C1DockingTabPage();
			this.Dep = new GP8000.UserControl.CrtTaDepartment();
			this.Tab_3_dt2 = new System.Windows.Forms.DateTimePicker();
			this.Tab_3_dt1 = new System.Windows.Forms.DateTimePicker();
			this.panel3.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).BeginInit();
			this.c1DockingTab1.SuspendLayout();
			this.Tab_1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel8.SuspendLayout();
			this.panel10.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs1)).BeginInit();
			this.panel9.SuspendLayout();
			this.panel7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
			this.Tab_3.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel13.SuspendLayout();
			this.panel11.SuspendLayout();
			this.panel24.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs4)).BeginInit();
			this.panel23.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs7)).BeginInit();
			this.panel4.SuspendLayout();
			this.p31.SuspendLayout();
			this.Tab_3_p2.SuspendLayout();
			this.panel15.SuspendLayout();
			this.panel20.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs3)).BeginInit();
			this.panel12.SuspendLayout();
			this.panel17.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs2)).BeginInit();
			this.panel14.SuspendLayout();
			this.Tab_3_p1.SuspendLayout();
			this.panel18.SuspendLayout();
			this.panel16.SuspendLayout();
			this.Tab_4.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel19.SuspendLayout();
			this.panel22.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs5)).BeginInit();
			this.p41.SuspendLayout();
			this.p43.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs6)).BeginInit();
			this.p42.SuspendLayout();
			this.panel21.SuspendLayout();
			this.p45.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandDock1)).BeginInit();
			this.c1CommandDock1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1DockingTab2)).BeginInit();
			this.c1DockingTab2.SuspendLayout();
			this.c1DockingTabPage1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.panel3.Controls.Add(this.label5);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(940, 36);
			this.panel3.TabIndex = 6;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Location = new System.Drawing.Point(0, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(940, 36);
			this.label5.TabIndex = 11;
			this.label5.Tag = "";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.c1DockingTab1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 36);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(940, 524);
			this.panel1.TabIndex = 7;
			// 
			// c1DockingTab1
			// 
			this.c1DockingTab1.Controls.Add(this.Tab_1);
			this.c1DockingTab1.Controls.Add(this.Tab_3);
			this.c1DockingTab1.Controls.Add(this.Tab_4);
			this.c1DockingTab1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.c1DockingTab1.Location = new System.Drawing.Point(0, 0);
			this.c1DockingTab1.Name = "c1DockingTab1";
			this.c1DockingTab1.SelectedIndex = 4;
			this.c1DockingTab1.Size = new System.Drawing.Size(940, 524);
			this.c1DockingTab1.TabIndex = 0;
			this.c1DockingTab1.TabStyle = C1.Win.C1Command.TabStyleEnum.WindowsXP;
			// 
			// Tab_1
			// 
			this.Tab_1.Controls.Add(this.panel2);
			this.Tab_1.ImageIndex = -1;
			this.Tab_1.Location = new System.Drawing.Point(2, 28);
			this.Tab_1.Name = "Tab_1";
			this.Tab_1.Size = new System.Drawing.Size(934, 492);
			this.Tab_1.TabIndex = 0;
			this.Tab_1.Text = "Page1";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.panel8);
			this.panel2.Controls.Add(this.splitter1);
			this.panel2.Controls.Add(this.panel7);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(934, 492);
			this.panel2.TabIndex = 0;
			// 
			// panel8
			// 
			this.panel8.Controls.Add(this.panel10);
			this.panel8.Controls.Add(this.splitter2);
			this.panel8.Controls.Add(this.panel9);
			this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panel8.Location = new System.Drawing.Point(243, 0);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(691, 492);
			this.panel8.TabIndex = 3;
			// 
			// panel10
			// 
			this.panel10.Controls.Add(this.txt);
			this.panel10.Controls.Add(this.cmd_type);
			this.panel10.Controls.Add(this.vs1);
			this.panel10.Controls.Add(this.nav1);
			this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel10.Location = new System.Drawing.Point(0, 191);
			this.panel10.Name = "panel10";
			this.panel10.Size = new System.Drawing.Size(691, 301);
			this.panel10.TabIndex = 32;
			// 
			// txt
			// 
			this.txt.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt.Location = new System.Drawing.Point(316, 4);
			this.txt.Name = "txt";
			this.txt.ReadOnly = true;
			this.txt.Size = new System.Drawing.Size(108, 23);
			this.txt.TabIndex = 33;
			this.txt.Tag = "";
			this.txt.Text = "";
			// 
			// cmd_type
			// 
			this.cmd_type.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_type.Location = new System.Drawing.Point(428, 4);
			this.cmd_type.Name = "cmd_type";
			this.cmd_type.Size = new System.Drawing.Size(96, 24);
			this.cmd_type.TabIndex = 32;
			this.cmd_type.Text = "button1";
			this.cmd_type.Click += new System.EventHandler(this.cmd_type_Click);
			// 
			// vs1
			// 
			this.vs1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.vs1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs1.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vs1.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs1.Location = new System.Drawing.Point(4, 32);
			this.vs1.Name = "vs1";
			this.vs1.Size = new System.Drawing.Size(684, 268);
			this.vs1.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs1.TabIndex = 31;
			this.vs1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.vs1_KeyDown);
			// 
			// nav1
			// 
			this.nav1.BackColor = System.Drawing.SystemColors.Control;
			this.nav1.Connection = null;
			this.nav1.ConnectionDel = null;
			this.nav1.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.nav1.form = null;
			this.nav1.FormName = null;
			this.nav1.Grid = null;
			this.nav1.History = false;
			this.nav1.IsNull = true;
			this.nav1.Language = "EN";
			this.nav1.Location = new System.Drawing.Point(0, 0);
			this.nav1.MSG_Exit = false;
			this.nav1.MulltiDel = false;
			this.nav1.Name = "nav1";
			this.nav1.Security = 0;
			this.nav1.ShowPopupMenu = true;
			this.nav1.Size = new System.Drawing.Size(324, 32);
			this.nav1.TabIndex = 30;
			this.nav1.Tag = "";
			this.nav1.ToolBar_Auto = true;
			this.nav1.UserID = null;
			this.nav1.VisibleGrid = true;
			this.nav1.Where = null;
			// 
			// splitter2
			// 
			this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
			this.splitter2.Location = new System.Drawing.Point(0, 188);
			this.splitter2.Name = "splitter2";
			this.splitter2.Size = new System.Drawing.Size(691, 3);
			this.splitter2.TabIndex = 31;
			this.splitter2.TabStop = false;
			// 
			// panel9
			// 
			this.panel9.Controls.Add(this.lb);
			this.panel9.Controls.Add(this.txt_3);
			this.panel9.Controls.Add(this.label8);
			this.panel9.Controls.Add(this.txt_2);
			this.panel9.Controls.Add(this.label7);
			this.panel9.Controls.Add(this.txt_1);
			this.panel9.Controls.Add(this.label6);
			this.panel9.Controls.Add(this.label4);
			this.panel9.Controls.Add(this.txt_LAB_ID);
			this.panel9.Controls.Add(this.label3);
			this.panel9.Controls.Add(this.txt_LAB_NM);
			this.panel9.Controls.Add(this.label2);
			this.panel9.Controls.Add(this.txt_LAB_NO);
			this.panel9.Controls.Add(this.nav);
			this.panel9.Controls.Add(this.label1);
			this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel9.Location = new System.Drawing.Point(0, 0);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(691, 188);
			this.panel9.TabIndex = 30;
			// 
			// lb
			// 
			this.lb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lb.BackColor = System.Drawing.Color.Moccasin;
			this.lb.Location = new System.Drawing.Point(8, 132);
			this.lb.Name = "lb";
			this.lb.Size = new System.Drawing.Size(680, 52);
			this.lb.TabIndex = 45;
			this.lb.Tag = "";
			// 
			// txt_3
			// 
			this.txt_3.Location = new System.Drawing.Point(548, 72);
			this.txt_3.Name = "txt_3";
			this.txt_3.Size = new System.Drawing.Size(64, 23);
			this.txt_3.TabIndex = 42;
			this.txt_3.Text = "";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(460, 76);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(88, 23);
			this.label8.TabIndex = 43;
			this.label8.Text = "label8";
			// 
			// txt_2
			// 
			this.txt_2.Location = new System.Drawing.Point(392, 72);
			this.txt_2.Name = "txt_2";
			this.txt_2.Size = new System.Drawing.Size(64, 23);
			this.txt_2.TabIndex = 40;
			this.txt_2.Text = "";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(272, 76);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(120, 23);
			this.label7.TabIndex = 41;
			this.label7.Text = "label7";
			// 
			// txt_1
			// 
			this.txt_1.Location = new System.Drawing.Point(180, 72);
			this.txt_1.Name = "txt_1";
			this.txt_1.Size = new System.Drawing.Size(64, 23);
			this.txt_1.TabIndex = 38;
			this.txt_1.Text = "";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(104, 76);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(88, 23);
			this.label6.TabIndex = 39;
			this.label6.Text = "label6";
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.Color.Blue;
			this.label4.Location = new System.Drawing.Point(8, 76);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(92, 23);
			this.label4.TabIndex = 37;
			this.label4.Text = "label4";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// txt_LAB_ID
			// 
			this.txt_LAB_ID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.txt_LAB_ID.Location = new System.Drawing.Point(136, 104);
			this.txt_LAB_ID.Name = "txt_LAB_ID";
			this.txt_LAB_ID.Size = new System.Drawing.Size(544, 23);
			this.txt_LAB_ID.TabIndex = 36;
			this.txt_LAB_ID.Tag = "LAB_NM";
			this.txt_LAB_ID.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 108);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(160, 23);
			this.label3.TabIndex = 35;
			this.label3.Text = "label3";
			// 
			// txt_LAB_NM
			// 
			this.txt_LAB_NM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.txt_LAB_NM.Location = new System.Drawing.Point(392, 40);
			this.txt_LAB_NM.Name = "txt_LAB_NM";
			this.txt_LAB_NM.Size = new System.Drawing.Size(292, 23);
			this.txt_LAB_NM.TabIndex = 33;
			this.txt_LAB_NM.Tag = "LAB_NM";
			this.txt_LAB_NM.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(244, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(160, 23);
			this.label2.TabIndex = 32;
			this.label2.Text = "label2";
			// 
			// txt_LAB_NO
			// 
			this.txt_LAB_NO.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt_LAB_NO.Location = new System.Drawing.Point(136, 40);
			this.txt_LAB_NO.Name = "txt_LAB_NO";
			this.txt_LAB_NO.Size = new System.Drawing.Size(108, 23);
			this.txt_LAB_NO.TabIndex = 31;
			this.txt_LAB_NO.Tag = "";
			this.txt_LAB_NO.Text = "";
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
			this.nav.Location = new System.Drawing.Point(4, 4);
			this.nav.MSG_Exit = false;
			this.nav.MulltiDel = false;
			this.nav.Name = "nav";
			this.nav.Security = 0;
			this.nav.ShowPopupMenu = true;
			this.nav.Size = new System.Drawing.Size(619, 32);
			this.nav.TabIndex = 29;
			this.nav.Tag = "";
			this.nav.ToolBar_Auto = true;
			this.nav.UserID = null;
			this.nav.VisibleGrid = true;
			this.nav.Where = null;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(4, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(160, 23);
			this.label1.TabIndex = 30;
			this.label1.Text = "label1";
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(240, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(3, 492);
			this.splitter1.TabIndex = 1;
			this.splitter1.TabStop = false;
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.vs);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(240, 492);
			this.panel7.TabIndex = 0;
			// 
			// vs
			// 
			this.vs.AllowEditing = false;
			this.vs.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vs.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vs.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs.Location = new System.Drawing.Point(0, 0);
			this.vs.Name = "vs";
			this.vs.Size = new System.Drawing.Size(240, 492);
			this.vs.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs.TabIndex = 28;
			// 
			// Tab_3
			// 
			this.Tab_3.Controls.Add(this.panel5);
			this.Tab_3.ImageIndex = -1;
			this.Tab_3.Location = new System.Drawing.Point(2, 28);
			this.Tab_3.Name = "Tab_3";
			this.Tab_3.Size = new System.Drawing.Size(934, 492);
			this.Tab_3.TabIndex = 2;
			this.Tab_3.Text = "Page2";
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.panel13);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(0, 0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(934, 492);
			this.panel5.TabIndex = 1;
			// 
			// panel13
			// 
			this.panel13.Controls.Add(this.panel11);
			this.panel13.Controls.Add(this.splitter3);
			this.panel13.Controls.Add(this.panel4);
			this.panel13.Controls.Add(this.splitter4);
			this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel13.Location = new System.Drawing.Point(0, 0);
			this.panel13.Name = "panel13";
			this.panel13.Size = new System.Drawing.Size(934, 492);
			this.panel13.TabIndex = 2;
			// 
			// panel11
			// 
			this.panel11.Controls.Add(this.panel24);
			this.panel11.Controls.Add(this.panel23);
			this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel11.Location = new System.Drawing.Point(0, 291);
			this.panel11.Name = "panel11";
			this.panel11.Size = new System.Drawing.Size(934, 201);
			this.panel11.TabIndex = 4;
			// 
			// panel24
			// 
			this.panel24.Controls.Add(this.vs4);
			this.panel24.Controls.Add(this.nav4);
			this.panel24.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel24.Location = new System.Drawing.Point(0, 88);
			this.panel24.Name = "panel24";
			this.panel24.Size = new System.Drawing.Size(934, 113);
			this.panel24.TabIndex = 1;
			// 
			// vs4
			// 
			this.vs4.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.Both;
			this.vs4.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs4.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vs4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vs4.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs4.Location = new System.Drawing.Point(0, 32);
			this.vs4.Name = "vs4";
			this.vs4.Size = new System.Drawing.Size(934, 81);
			this.vs4.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs4.TabIndex = 38;
			this.vs4.Tag = "";
			// 
			// nav4
			// 
			this.nav4.BackColor = System.Drawing.SystemColors.Control;
			this.nav4.Connection = null;
			this.nav4.ConnectionDel = null;
			this.nav4.Dock = System.Windows.Forms.DockStyle.Top;
			this.nav4.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.nav4.form = null;
			this.nav4.FormName = null;
			this.nav4.Grid = null;
			this.nav4.History = false;
			this.nav4.IsNull = true;
			this.nav4.Language = "EN";
			this.nav4.Location = new System.Drawing.Point(0, 0);
			this.nav4.MSG_Exit = false;
			this.nav4.MulltiDel = false;
			this.nav4.Name = "nav4";
			this.nav4.Security = 0;
			this.nav4.ShowPopupMenu = true;
			this.nav4.Size = new System.Drawing.Size(934, 32);
			this.nav4.TabIndex = 37;
			this.nav4.Tag = "";
			this.nav4.ToolBar_Auto = true;
			this.nav4.UserID = null;
			this.nav4.VisibleGrid = true;
			this.nav4.Where = null;
			// 
			// panel23
			// 
			this.panel23.BackColor = System.Drawing.Color.Moccasin;
			this.panel23.Controls.Add(this.Tab_3_dt1);
			this.panel23.Controls.Add(this.vs7);
			this.panel23.Controls.Add(this.Tab_3_dt2);
			this.panel23.Controls.Add(this.label13);
			this.panel23.Controls.Add(this.cb_LAB_TP);
			this.panel23.Controls.Add(this.label11);
			this.panel23.Controls.Add(this.label12);
			this.panel23.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel23.Location = new System.Drawing.Point(0, 0);
			this.panel23.Name = "panel23";
			this.panel23.Size = new System.Drawing.Size(934, 88);
			this.panel23.TabIndex = 0;
			// 
			// vs7
			// 
			this.vs7.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.Both;
			this.vs7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.vs7.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs7.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vs7.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs7.Location = new System.Drawing.Point(300, 4);
			this.vs7.Name = "vs7";
			this.vs7.Size = new System.Drawing.Size(628, 80);
			this.vs7.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs7.TabIndex = 37;
			this.vs7.Tag = "N";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(12, 68);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(124, 23);
			this.label13.TabIndex = 14;
			this.label13.Text = "label13";
			// 
			// cb_LAB_TP
			// 
			this.cb_LAB_TP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_LAB_TP.Location = new System.Drawing.Point(136, 4);
			this.cb_LAB_TP.Name = "cb_LAB_TP";
			this.cb_LAB_TP.Size = new System.Drawing.Size(160, 24);
			this.cb_LAB_TP.TabIndex = 13;
			this.cb_LAB_TP.SelectedIndexChanged += new System.EventHandler(this.cb_LAB_TP_SelectedIndexChanged);
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(12, 12);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(124, 23);
			this.label11.TabIndex = 0;
			this.label11.Text = "label11";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(12, 40);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(136, 23);
			this.label12.TabIndex = 1;
			this.label12.Text = "label12";
			// 
			// splitter3
			// 
			this.splitter3.Dock = System.Windows.Forms.DockStyle.Top;
			this.splitter3.Location = new System.Drawing.Point(0, 288);
			this.splitter3.Name = "splitter3";
			this.splitter3.Size = new System.Drawing.Size(934, 3);
			this.splitter3.TabIndex = 3;
			this.splitter3.TabStop = false;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.Moccasin;
			this.panel4.Controls.Add(this.p31);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 3);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(934, 285);
			this.panel4.TabIndex = 2;
			// 
			// p31
			// 
			this.p31.Controls.Add(this.Tab_3_p2);
			this.p31.Controls.Add(this.Tab_3_p1);
			this.p31.Controls.Add(this.panel18);
			this.p31.Controls.Add(this.panel16);
			this.p31.Dock = System.Windows.Forms.DockStyle.Fill;
			this.p31.Location = new System.Drawing.Point(0, 0);
			this.p31.Name = "p31";
			this.p31.Size = new System.Drawing.Size(934, 285);
			this.p31.TabIndex = 2;
			// 
			// Tab_3_p2
			// 
			this.Tab_3_p2.Controls.Add(this.panel15);
			this.Tab_3_p2.Controls.Add(this.splitter5);
			this.Tab_3_p2.Controls.Add(this.panel12);
			this.Tab_3_p2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Tab_3_p2.Location = new System.Drawing.Point(0, 148);
			this.Tab_3_p2.Name = "Tab_3_p2";
			this.Tab_3_p2.Size = new System.Drawing.Size(794, 137);
			this.Tab_3_p2.TabIndex = 7;
			// 
			// panel15
			// 
			this.panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel15.Controls.Add(this.panel20);
			this.panel15.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel15.Location = new System.Drawing.Point(399, 0);
			this.panel15.Name = "panel15";
			this.panel15.Size = new System.Drawing.Size(395, 137);
			this.panel15.TabIndex = 2;
			// 
			// panel20
			// 
			this.panel20.Controls.Add(this.nav3);
			this.panel20.Controls.Add(this.vs3);
			this.panel20.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel20.Location = new System.Drawing.Point(0, 0);
			this.panel20.Name = "panel20";
			this.panel20.Size = new System.Drawing.Size(393, 135);
			this.panel20.TabIndex = 0;
			// 
			// nav3
			// 
			this.nav3.BackColor = System.Drawing.SystemColors.Control;
			this.nav3.Connection = null;
			this.nav3.ConnectionDel = null;
			this.nav3.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.nav3.form = null;
			this.nav3.FormName = null;
			this.nav3.Grid = null;
			this.nav3.History = false;
			this.nav3.IsNull = true;
			this.nav3.Language = "EN";
			this.nav3.Location = new System.Drawing.Point(76, 65);
			this.nav3.MSG_Exit = false;
			this.nav3.MulltiDel = false;
			this.nav3.Name = "nav3";
			this.nav3.Security = 0;
			this.nav3.ShowPopupMenu = true;
			this.nav3.Size = new System.Drawing.Size(240, 32);
			this.nav3.TabIndex = 39;
			this.nav3.Tag = "";
			this.nav3.ToolBar_Auto = true;
			this.nav3.UserID = null;
			this.nav3.Visible = false;
			this.nav3.VisibleGrid = true;
			this.nav3.Where = null;
			// 
			// vs3
			// 
			this.vs3.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.Both;
			this.vs3.AllowEditing = false;
			this.vs3.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs3.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vs3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vs3.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs3.Location = new System.Drawing.Point(0, 0);
			this.vs3.Name = "vs3";
			this.vs3.Size = new System.Drawing.Size(393, 135);
			this.vs3.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs3.TabIndex = 38;
			// 
			// splitter5
			// 
			this.splitter5.Location = new System.Drawing.Point(396, 0);
			this.splitter5.Name = "splitter5";
			this.splitter5.Size = new System.Drawing.Size(3, 137);
			this.splitter5.TabIndex = 1;
			this.splitter5.TabStop = false;
			// 
			// panel12
			// 
			this.panel12.Controls.Add(this.panel17);
			this.panel12.Controls.Add(this.panel14);
			this.panel12.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel12.Location = new System.Drawing.Point(0, 0);
			this.panel12.Name = "panel12";
			this.panel12.Size = new System.Drawing.Size(396, 137);
			this.panel12.TabIndex = 0;
			// 
			// panel17
			// 
			this.panel17.Controls.Add(this.nav2);
			this.panel17.Controls.Add(this.vs2);
			this.panel17.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel17.Location = new System.Drawing.Point(0, 0);
			this.panel17.Name = "panel17";
			this.panel17.Size = new System.Drawing.Size(352, 137);
			this.panel17.TabIndex = 3;
			// 
			// nav2
			// 
			this.nav2.BackColor = System.Drawing.SystemColors.Control;
			this.nav2.Connection = null;
			this.nav2.ConnectionDel = null;
			this.nav2.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.nav2.form = null;
			this.nav2.FormName = null;
			this.nav2.Grid = null;
			this.nav2.History = false;
			this.nav2.IsNull = true;
			this.nav2.Language = "EN";
			this.nav2.Location = new System.Drawing.Point(32, 56);
			this.nav2.MSG_Exit = false;
			this.nav2.MulltiDel = false;
			this.nav2.Name = "nav2";
			this.nav2.Security = 0;
			this.nav2.ShowPopupMenu = true;
			this.nav2.Size = new System.Drawing.Size(240, 32);
			this.nav2.TabIndex = 38;
			this.nav2.Tag = "";
			this.nav2.ToolBar_Auto = true;
			this.nav2.UserID = null;
			this.nav2.Visible = false;
			this.nav2.VisibleGrid = true;
			this.nav2.Where = null;
			// 
			// vs2
			// 
			this.vs2.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.Both;
			this.vs2.AllowEditing = false;
			this.vs2.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs2.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vs2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vs2.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs2.Location = new System.Drawing.Point(0, 0);
			this.vs2.Name = "vs2";
			this.vs2.Size = new System.Drawing.Size(352, 137);
			this.vs2.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs2.TabIndex = 37;
			// 
			// panel14
			// 
			this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel14.Controls.Add(this.tab_3_cmd4);
			this.panel14.Controls.Add(this.tab_3_cmd3);
			this.panel14.Controls.Add(this.tab_3_cmd2);
			this.panel14.Controls.Add(this.tab_3_cmd1);
			this.panel14.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel14.Location = new System.Drawing.Point(352, 0);
			this.panel14.Name = "panel14";
			this.panel14.Size = new System.Drawing.Size(44, 137);
			this.panel14.TabIndex = 2;
			// 
			// tab_3_cmd4
			// 
			this.tab_3_cmd4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.tab_3_cmd4.Location = new System.Drawing.Point(4, 104);
			this.tab_3_cmd4.Name = "tab_3_cmd4";
			this.tab_3_cmd4.Size = new System.Drawing.Size(36, 30);
			this.tab_3_cmd4.TabIndex = 4;
			this.tab_3_cmd4.Tag = "N";
			this.tab_3_cmd4.Text = "<<";
			this.tab_3_cmd4.Click += new System.EventHandler(this.tab_3_cmd4_Click);
			// 
			// tab_3_cmd3
			// 
			this.tab_3_cmd3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.tab_3_cmd3.Location = new System.Drawing.Point(4, 68);
			this.tab_3_cmd3.Name = "tab_3_cmd3";
			this.tab_3_cmd3.Size = new System.Drawing.Size(36, 30);
			this.tab_3_cmd3.TabIndex = 3;
			this.tab_3_cmd3.Tag = "N";
			this.tab_3_cmd3.Text = "<";
			this.tab_3_cmd3.Click += new System.EventHandler(this.tab_3_cmd3_Click);
			// 
			// tab_3_cmd2
			// 
			this.tab_3_cmd2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.tab_3_cmd2.Location = new System.Drawing.Point(4, 36);
			this.tab_3_cmd2.Name = "tab_3_cmd2";
			this.tab_3_cmd2.Size = new System.Drawing.Size(36, 30);
			this.tab_3_cmd2.TabIndex = 2;
			this.tab_3_cmd2.Tag = "N";
			this.tab_3_cmd2.Text = ">";
			this.tab_3_cmd2.Click += new System.EventHandler(this.tab_3_cmd2_Click);
			// 
			// tab_3_cmd1
			// 
			this.tab_3_cmd1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.tab_3_cmd1.Location = new System.Drawing.Point(4, 2);
			this.tab_3_cmd1.Name = "tab_3_cmd1";
			this.tab_3_cmd1.Size = new System.Drawing.Size(36, 30);
			this.tab_3_cmd1.TabIndex = 1;
			this.tab_3_cmd1.Tag = "N";
			this.tab_3_cmd1.Text = ">>";
			this.tab_3_cmd1.Click += new System.EventHandler(this.tab_3_cmd1_Click);
			// 
			// Tab_3_p1
			// 
			this.Tab_3_p1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Tab_3_p1.Controls.Add(this.Tab_3_txt_WID);
			this.Tab_3_p1.Controls.Add(this.Tab_3_cb_TYP_ID);
			this.Tab_3_p1.Controls.Add(this.Tab_3_cb_POS_ID);
			this.Tab_3_p1.Controls.Add(this.Tab_3_cb_DEP_ID);
			this.Tab_3_p1.Controls.Add(this.label10);
			this.Tab_3_p1.Controls.Add(this.label9);
			this.Tab_3_p1.Controls.Add(this.tab_3_txt_DWID2);
			this.Tab_3_p1.Controls.Add(this.tab_3_txt_DWID1);
			this.Tab_3_p1.Controls.Add(this.tab_3_txt_WID2);
			this.Tab_3_p1.Controls.Add(this.tab_3_txt_WID1);
			this.Tab_3_p1.Controls.Add(this.rd46);
			this.Tab_3_p1.Controls.Add(this.rd45);
			this.Tab_3_p1.Controls.Add(this.rd44);
			this.Tab_3_p1.Controls.Add(this.rd43);
			this.Tab_3_p1.Controls.Add(this.rd42);
			this.Tab_3_p1.Controls.Add(this.rd41);
			this.Tab_3_p1.Dock = System.Windows.Forms.DockStyle.Top;
			this.Tab_3_p1.Enabled = false;
			this.Tab_3_p1.Location = new System.Drawing.Point(0, 32);
			this.Tab_3_p1.Name = "Tab_3_p1";
			this.Tab_3_p1.Size = new System.Drawing.Size(794, 116);
			this.Tab_3_p1.TabIndex = 6;
			// 
			// Tab_3_txt_WID
			// 
			this.Tab_3_txt_WID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.Tab_3_txt_WID.Enabled = false;
			this.Tab_3_txt_WID.Location = new System.Drawing.Point(576, 32);
			this.Tab_3_txt_WID.Multiline = true;
			this.Tab_3_txt_WID.Name = "Tab_3_txt_WID";
			this.Tab_3_txt_WID.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.Tab_3_txt_WID.Size = new System.Drawing.Size(212, 80);
			this.Tab_3_txt_WID.TabIndex = 15;
			this.Tab_3_txt_WID.Text = "";
			// 
			// Tab_3_cb_TYP_ID
			// 
			this.Tab_3_cb_TYP_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Tab_3_cb_TYP_ID.Enabled = false;
			this.Tab_3_cb_TYP_ID.Location = new System.Drawing.Point(136, 88);
			this.Tab_3_cb_TYP_ID.Name = "Tab_3_cb_TYP_ID";
			this.Tab_3_cb_TYP_ID.Size = new System.Drawing.Size(160, 24);
			this.Tab_3_cb_TYP_ID.TabIndex = 14;
			// 
			// Tab_3_cb_POS_ID
			// 
			this.Tab_3_cb_POS_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Tab_3_cb_POS_ID.Enabled = false;
			this.Tab_3_cb_POS_ID.Location = new System.Drawing.Point(408, 60);
			this.Tab_3_cb_POS_ID.Name = "Tab_3_cb_POS_ID";
			this.Tab_3_cb_POS_ID.Size = new System.Drawing.Size(160, 24);
			this.Tab_3_cb_POS_ID.TabIndex = 13;
			// 
			// Tab_3_cb_DEP_ID
			// 
			this.Tab_3_cb_DEP_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Tab_3_cb_DEP_ID.Enabled = false;
			this.Tab_3_cb_DEP_ID.Location = new System.Drawing.Point(136, 60);
			this.Tab_3_cb_DEP_ID.Name = "Tab_3_cb_DEP_ID";
			this.Tab_3_cb_DEP_ID.Size = new System.Drawing.Size(160, 24);
			this.Tab_3_cb_DEP_ID.TabIndex = 12;
			// 
			// label10
			// 
			this.label10.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(192)));
			this.label10.Location = new System.Drawing.Point(300, 36);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(32, 23);
			this.label10.TabIndex = 11;
			this.label10.Tag = "N";
			this.label10.Text = "->>";
			// 
			// label9
			// 
			this.label9.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(192)));
			this.label9.Location = new System.Drawing.Point(300, 8);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(32, 23);
			this.label9.TabIndex = 10;
			this.label9.Tag = "N";
			this.label9.Text = "->>";
			// 
			// tab_3_txt_DWID2
			// 
			this.tab_3_txt_DWID2.Enabled = false;
			this.tab_3_txt_DWID2.Location = new System.Drawing.Point(408, 32);
			this.tab_3_txt_DWID2.Name = "tab_3_txt_DWID2";
			this.tab_3_txt_DWID2.Size = new System.Drawing.Size(160, 23);
			this.tab_3_txt_DWID2.TabIndex = 9;
			this.tab_3_txt_DWID2.Text = "";
			// 
			// tab_3_txt_DWID1
			// 
			this.tab_3_txt_DWID1.Enabled = false;
			this.tab_3_txt_DWID1.Location = new System.Drawing.Point(136, 32);
			this.tab_3_txt_DWID1.Name = "tab_3_txt_DWID1";
			this.tab_3_txt_DWID1.Size = new System.Drawing.Size(160, 23);
			this.tab_3_txt_DWID1.TabIndex = 8;
			this.tab_3_txt_DWID1.Text = "";
			// 
			// tab_3_txt_WID2
			// 
			this.tab_3_txt_WID2.Location = new System.Drawing.Point(408, 4);
			this.tab_3_txt_WID2.Name = "tab_3_txt_WID2";
			this.tab_3_txt_WID2.Size = new System.Drawing.Size(160, 23);
			this.tab_3_txt_WID2.TabIndex = 7;
			this.tab_3_txt_WID2.Text = "";
			// 
			// tab_3_txt_WID1
			// 
			this.tab_3_txt_WID1.Location = new System.Drawing.Point(136, 4);
			this.tab_3_txt_WID1.Name = "tab_3_txt_WID1";
			this.tab_3_txt_WID1.Size = new System.Drawing.Size(160, 23);
			this.tab_3_txt_WID1.TabIndex = 6;
			this.tab_3_txt_WID1.Text = "";
			// 
			// rd46
			// 
			this.rd46.Location = new System.Drawing.Point(576, 4);
			this.rd46.Name = "rd46";
			this.rd46.Size = new System.Drawing.Size(132, 24);
			this.rd46.TabIndex = 5;
			this.rd46.Text = "radioButton8";
			this.rd46.CheckedChanged += new System.EventHandler(this.rd4_CheckedChanged);
			// 
			// rd45
			// 
			this.rd45.Location = new System.Drawing.Point(12, 88);
			this.rd45.Name = "rd45";
			this.rd45.Size = new System.Drawing.Size(132, 24);
			this.rd45.TabIndex = 4;
			this.rd45.Text = "radioButton7";
			this.rd45.CheckedChanged += new System.EventHandler(this.rd4_CheckedChanged);
			// 
			// rd44
			// 
			this.rd44.Location = new System.Drawing.Point(300, 60);
			this.rd44.Name = "rd44";
			this.rd44.Size = new System.Drawing.Size(132, 24);
			this.rd44.TabIndex = 3;
			this.rd44.Text = "radioButton6";
			this.rd44.CheckedChanged += new System.EventHandler(this.rd4_CheckedChanged);
			// 
			// rd43
			// 
			this.rd43.Location = new System.Drawing.Point(12, 60);
			this.rd43.Name = "rd43";
			this.rd43.Size = new System.Drawing.Size(132, 24);
			this.rd43.TabIndex = 2;
			this.rd43.Text = "radioButton5";
			this.rd43.CheckedChanged += new System.EventHandler(this.rd4_CheckedChanged);
			// 
			// rd42
			// 
			this.rd42.Location = new System.Drawing.Point(12, 32);
			this.rd42.Name = "rd42";
			this.rd42.Size = new System.Drawing.Size(132, 24);
			this.rd42.TabIndex = 1;
			this.rd42.Text = "radioButton4";
			this.rd42.CheckedChanged += new System.EventHandler(this.rd4_CheckedChanged);
			// 
			// rd41
			// 
			this.rd41.Checked = true;
			this.rd41.Location = new System.Drawing.Point(12, 4);
			this.rd41.Name = "rd41";
			this.rd41.Size = new System.Drawing.Size(132, 24);
			this.rd41.TabIndex = 0;
			this.rd41.TabStop = true;
			this.rd41.Text = "radioButton3";
			this.rd41.CheckedChanged += new System.EventHandler(this.rd4_CheckedChanged);
			// 
			// panel18
			// 
			this.panel18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel18.Controls.Add(this.button2);
			this.panel18.Controls.Add(this.button1);
			this.panel18.Controls.Add(this.rd32);
			this.panel18.Controls.Add(this.rd31);
			this.panel18.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel18.Location = new System.Drawing.Point(0, 0);
			this.panel18.Name = "panel18";
			this.panel18.Size = new System.Drawing.Size(794, 32);
			this.panel18.TabIndex = 5;
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button2.Location = new System.Drawing.Point(576, 4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(104, 24);
			this.button2.TabIndex = 3;
			this.button2.Text = "Tab_cmd_Show";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(464, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(104, 24);
			this.button1.TabIndex = 2;
			this.button1.Text = "Tab_cmd_Show";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// rd32
			// 
			this.rd32.Location = new System.Drawing.Point(308, 4);
			this.rd32.Name = "rd32";
			this.rd32.Size = new System.Drawing.Size(148, 24);
			this.rd32.TabIndex = 1;
			this.rd32.Text = "radioButton2";
			this.rd32.CheckedChanged += new System.EventHandler(this.rd3_CheckedChanged);
			// 
			// rd31
			// 
			this.rd31.Checked = true;
			this.rd31.Location = new System.Drawing.Point(144, 4);
			this.rd31.Name = "rd31";
			this.rd31.Size = new System.Drawing.Size(148, 24);
			this.rd31.TabIndex = 0;
			this.rd31.TabStop = true;
			this.rd31.Text = "radioButton1";
			this.rd31.CheckedChanged += new System.EventHandler(this.rd3_CheckedChanged);
			// 
			// panel16
			// 
			this.panel16.BackColor = System.Drawing.Color.LightSteelBlue;
			this.panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel16.Controls.Add(this.Tab_3_cmd_print);
			this.panel16.Controls.Add(this.Tab3_cmd_Show);
			this.panel16.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel16.Location = new System.Drawing.Point(794, 0);
			this.panel16.Name = "panel16";
			this.panel16.Size = new System.Drawing.Size(140, 285);
			this.panel16.TabIndex = 1;
			// 
			// Tab_3_cmd_print
			// 
			this.Tab_3_cmd_print.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.Tab_3_cmd_print.Location = new System.Drawing.Point(17, 64);
			this.Tab_3_cmd_print.Name = "Tab_3_cmd_print";
			this.Tab_3_cmd_print.Size = new System.Drawing.Size(104, 36);
			this.Tab_3_cmd_print.TabIndex = 1;
			this.Tab_3_cmd_print.Text = "button1";
			this.Tab_3_cmd_print.Click += new System.EventHandler(this.Tab_3_cmd_print_Click);
			// 
			// Tab3_cmd_Show
			// 
			this.Tab3_cmd_Show.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.Tab3_cmd_Show.Location = new System.Drawing.Point(17, 16);
			this.Tab3_cmd_Show.Name = "Tab3_cmd_Show";
			this.Tab3_cmd_Show.Size = new System.Drawing.Size(104, 36);
			this.Tab3_cmd_Show.TabIndex = 0;
			this.Tab3_cmd_Show.Text = "Tab_cmd_Show";
			this.Tab3_cmd_Show.Click += new System.EventHandler(this.Tab3_cmd_Show_Click);
			// 
			// splitter4
			// 
			this.splitter4.Dock = System.Windows.Forms.DockStyle.Top;
			this.splitter4.Location = new System.Drawing.Point(0, 0);
			this.splitter4.Name = "splitter4";
			this.splitter4.Size = new System.Drawing.Size(934, 3);
			this.splitter4.TabIndex = 1;
			this.splitter4.TabStop = false;
			// 
			// Tab_4
			// 
			this.Tab_4.Controls.Add(this.panel6);
			this.Tab_4.ImageIndex = -1;
			this.Tab_4.Location = new System.Drawing.Point(2, 28);
			this.Tab_4.Name = "Tab_4";
			this.Tab_4.Size = new System.Drawing.Size(934, 492);
			this.Tab_4.TabIndex = 3;
			this.Tab_4.Text = "Page3";
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.panel19);
			this.panel6.Controls.Add(this.c1CommandDock1);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panel6.Location = new System.Drawing.Point(0, 0);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(934, 492);
			this.panel6.TabIndex = 1;
			// 
			// panel19
			// 
			this.panel19.Controls.Add(this.panel22);
			this.panel19.Controls.Add(this.splitter6);
			this.panel19.Controls.Add(this.p41);
			this.panel19.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel19.Location = new System.Drawing.Point(232, 0);
			this.panel19.Name = "panel19";
			this.panel19.Size = new System.Drawing.Size(702, 492);
			this.panel19.TabIndex = 2;
			// 
			// panel22
			// 
			this.panel22.Controls.Add(this.nav5);
			this.panel22.Controls.Add(this.vs5);
			this.panel22.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel22.Location = new System.Drawing.Point(0, 228);
			this.panel22.Name = "panel22";
			this.panel22.Size = new System.Drawing.Size(702, 264);
			this.panel22.TabIndex = 2;
			// 
			// nav5
			// 
			this.nav5.BackColor = System.Drawing.SystemColors.Control;
			this.nav5.Connection = null;
			this.nav5.ConnectionDel = null;
			this.nav5.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.nav5.form = null;
			this.nav5.FormName = null;
			this.nav5.Grid = null;
			this.nav5.History = false;
			this.nav5.IsNull = true;
			this.nav5.Language = "EN";
			this.nav5.Location = new System.Drawing.Point(0, 4);
			this.nav5.MSG_Exit = false;
			this.nav5.MulltiDel = false;
			this.nav5.Name = "nav5";
			this.nav5.Security = 0;
			this.nav5.ShowPopupMenu = true;
			this.nav5.Size = new System.Drawing.Size(364, 32);
			this.nav5.TabIndex = 36;
			this.nav5.Tag = "N";
			this.nav5.ToolBar_Auto = true;
			this.nav5.UserID = null;
			this.nav5.VisibleGrid = true;
			this.nav5.Where = null;
			// 
			// vs5
			// 
			this.vs5.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.Both;
			this.vs5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.vs5.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs5.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vs5.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs5.Location = new System.Drawing.Point(4, 36);
			this.vs5.Name = "vs5";
			this.vs5.Size = new System.Drawing.Size(692, 224);
			this.vs5.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs5.TabIndex = 35;
			// 
			// splitter6
			// 
			this.splitter6.Dock = System.Windows.Forms.DockStyle.Top;
			this.splitter6.Location = new System.Drawing.Point(0, 224);
			this.splitter6.Name = "splitter6";
			this.splitter6.Size = new System.Drawing.Size(702, 4);
			this.splitter6.TabIndex = 1;
			this.splitter6.TabStop = false;
			// 
			// p41
			// 
			this.p41.Controls.Add(this.p43);
			this.p41.Controls.Add(this.p42);
			this.p41.Controls.Add(this.panel21);
			this.p41.Dock = System.Windows.Forms.DockStyle.Top;
			this.p41.Location = new System.Drawing.Point(0, 0);
			this.p41.Name = "p41";
			this.p41.Size = new System.Drawing.Size(702, 224);
			this.p41.TabIndex = 0;
			// 
			// p43
			// 
			this.p43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.p43.Controls.Add(this.vs6);
			this.p43.Controls.Add(this.nav6);
			this.p43.Dock = System.Windows.Forms.DockStyle.Fill;
			this.p43.Location = new System.Drawing.Point(0, 152);
			this.p43.Name = "p43";
			this.p43.Size = new System.Drawing.Size(562, 72);
			this.p43.TabIndex = 30;
			// 
			// vs6
			// 
			this.vs6.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.Both;
			this.vs6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.vs6.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs6.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vs6.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs6.Location = new System.Drawing.Point(4, 36);
			this.vs6.Name = "vs6";
			this.vs6.Size = new System.Drawing.Size(550, 32);
			this.vs6.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs6.TabIndex = 36;
			// 
			// nav6
			// 
			this.nav6.BackColor = System.Drawing.SystemColors.Control;
			this.nav6.Connection = null;
			this.nav6.ConnectionDel = null;
			this.nav6.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.nav6.form = null;
			this.nav6.FormName = null;
			this.nav6.Grid = null;
			this.nav6.History = false;
			this.nav6.IsNull = true;
			this.nav6.Language = "EN";
			this.nav6.Location = new System.Drawing.Point(4, 4);
			this.nav6.MSG_Exit = false;
			this.nav6.MulltiDel = false;
			this.nav6.Name = "nav6";
			this.nav6.Security = 0;
			this.nav6.ShowPopupMenu = true;
			this.nav6.Size = new System.Drawing.Size(364, 32);
			this.nav6.TabIndex = 37;
			this.nav6.Tag = "";
			this.nav6.ToolBar_Auto = true;
			this.nav6.UserID = null;
			this.nav6.VisibleGrid = true;
			this.nav6.Where = null;
			// 
			// p42
			// 
			this.p42.BackColor = System.Drawing.Color.Moccasin;
			this.p42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.p42.Controls.Add(this.comboBox2);
			this.p42.Controls.Add(this.comboBox1);
			this.p42.Controls.Add(this.Tab_4_cb_TYP_ID);
			this.p42.Controls.Add(this.Tab_4_cb_DEP_ID);
			this.p42.Controls.Add(this.Tab_4_cb_LAB_NO);
			this.p42.Controls.Add(this.ck410);
			this.p42.Controls.Add(this.ck49);
			this.p42.Controls.Add(this.ck48);
			this.p42.Controls.Add(this.ck47);
			this.p42.Controls.Add(this.Tab_4_txt_EMP_I1);
			this.p42.Controls.Add(this.ck46);
			this.p42.Controls.Add(this.Tab_4_txt_EMP_ID);
			this.p42.Controls.Add(this.ck45);
			this.p42.Controls.Add(this.tab_4_txt_DWID);
			this.p42.Controls.Add(this.ck44);
			this.p42.Controls.Add(this.tab_4_txt_WID);
			this.p42.Controls.Add(this.ck43);
			this.p42.Controls.Add(this.Tab_4_txt_LAB_ID);
			this.p42.Controls.Add(this.ck42);
			this.p42.Controls.Add(this.ck41);
			this.p42.Dock = System.Windows.Forms.DockStyle.Top;
			this.p42.Location = new System.Drawing.Point(0, 0);
			this.p42.Name = "p42";
			this.p42.Size = new System.Drawing.Size(562, 152);
			this.p42.TabIndex = 29;
			this.p42.Visible = false;
			// 
			// comboBox2
			// 
			this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.Enabled = false;
			this.comboBox2.Location = new System.Drawing.Point(412, 116);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(148, 24);
			this.comboBox2.TabIndex = 29;
			this.comboBox2.Visible = false;
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Enabled = false;
			this.comboBox1.Location = new System.Drawing.Point(132, 116);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(148, 24);
			this.comboBox1.TabIndex = 28;
			this.comboBox1.Visible = false;
			// 
			// Tab_4_cb_TYP_ID
			// 
			this.Tab_4_cb_TYP_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Tab_4_cb_TYP_ID.Enabled = false;
			this.Tab_4_cb_TYP_ID.Location = new System.Drawing.Point(412, 88);
			this.Tab_4_cb_TYP_ID.Name = "Tab_4_cb_TYP_ID";
			this.Tab_4_cb_TYP_ID.Size = new System.Drawing.Size(148, 24);
			this.Tab_4_cb_TYP_ID.TabIndex = 15;
			// 
			// Tab_4_cb_DEP_ID
			// 
			this.Tab_4_cb_DEP_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Tab_4_cb_DEP_ID.Enabled = false;
			this.Tab_4_cb_DEP_ID.Location = new System.Drawing.Point(132, 88);
			this.Tab_4_cb_DEP_ID.Name = "Tab_4_cb_DEP_ID";
			this.Tab_4_cb_DEP_ID.Size = new System.Drawing.Size(148, 24);
			this.Tab_4_cb_DEP_ID.TabIndex = 27;
			// 
			// Tab_4_cb_LAB_NO
			// 
			this.Tab_4_cb_LAB_NO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Tab_4_cb_LAB_NO.Enabled = false;
			this.Tab_4_cb_LAB_NO.Location = new System.Drawing.Point(132, 4);
			this.Tab_4_cb_LAB_NO.Name = "Tab_4_cb_LAB_NO";
			this.Tab_4_cb_LAB_NO.Size = new System.Drawing.Size(148, 24);
			this.Tab_4_cb_LAB_NO.TabIndex = 26;
			// 
			// ck410
			// 
			this.ck410.Location = new System.Drawing.Point(288, 120);
			this.ck410.Name = "ck410";
			this.ck410.Size = new System.Drawing.Size(124, 24);
			this.ck410.TabIndex = 25;
			this.ck410.Text = "checkBox9";
			this.ck410.Visible = false;
			// 
			// ck49
			// 
			this.ck49.Location = new System.Drawing.Point(8, 120);
			this.ck49.Name = "ck49";
			this.ck49.Size = new System.Drawing.Size(128, 24);
			this.ck49.TabIndex = 23;
			this.ck49.Text = "checkBox10";
			this.ck49.Visible = false;
			// 
			// ck48
			// 
			this.ck48.Location = new System.Drawing.Point(288, 92);
			this.ck48.Name = "ck48";
			this.ck48.Size = new System.Drawing.Size(128, 24);
			this.ck48.TabIndex = 21;
			this.ck48.Text = "checkBox7";
			this.ck48.CheckedChanged += new System.EventHandler(this.ck48_CheckedChanged);
			// 
			// ck47
			// 
			this.ck47.Location = new System.Drawing.Point(8, 92);
			this.ck47.Name = "ck47";
			this.ck47.Size = new System.Drawing.Size(128, 24);
			this.ck47.TabIndex = 19;
			this.ck47.Text = "checkBox8";
			this.ck47.CheckedChanged += new System.EventHandler(this.ck47_CheckedChanged);
			// 
			// Tab_4_txt_EMP_I1
			// 
			this.Tab_4_txt_EMP_I1.Location = new System.Drawing.Point(412, 60);
			this.Tab_4_txt_EMP_I1.Name = "Tab_4_txt_EMP_I1";
			this.Tab_4_txt_EMP_I1.Size = new System.Drawing.Size(148, 23);
			this.Tab_4_txt_EMP_I1.TabIndex = 16;
			this.Tab_4_txt_EMP_I1.Text = "";
			// 
			// ck46
			// 
			this.ck46.Location = new System.Drawing.Point(288, 64);
			this.ck46.Name = "ck46";
			this.ck46.Size = new System.Drawing.Size(128, 24);
			this.ck46.TabIndex = 17;
			this.ck46.Text = "checkBox6";
			this.ck46.CheckedChanged += new System.EventHandler(this.ck46_CheckedChanged);
			// 
			// Tab_4_txt_EMP_ID
			// 
			this.Tab_4_txt_EMP_ID.Location = new System.Drawing.Point(132, 60);
			this.Tab_4_txt_EMP_ID.Name = "Tab_4_txt_EMP_ID";
			this.Tab_4_txt_EMP_ID.Size = new System.Drawing.Size(148, 23);
			this.Tab_4_txt_EMP_ID.TabIndex = 14;
			this.Tab_4_txt_EMP_ID.Text = "";
			// 
			// ck45
			// 
			this.ck45.Location = new System.Drawing.Point(8, 64);
			this.ck45.Name = "ck45";
			this.ck45.Size = new System.Drawing.Size(128, 24);
			this.ck45.TabIndex = 15;
			this.ck45.Text = "checkBox5";
			this.ck45.CheckedChanged += new System.EventHandler(this.ck45_CheckedChanged);
			// 
			// tab_4_txt_DWID
			// 
			this.tab_4_txt_DWID.Location = new System.Drawing.Point(412, 32);
			this.tab_4_txt_DWID.Name = "tab_4_txt_DWID";
			this.tab_4_txt_DWID.Size = new System.Drawing.Size(148, 23);
			this.tab_4_txt_DWID.TabIndex = 12;
			this.tab_4_txt_DWID.Text = "";
			// 
			// ck44
			// 
			this.ck44.Location = new System.Drawing.Point(288, 36);
			this.ck44.Name = "ck44";
			this.ck44.Size = new System.Drawing.Size(128, 24);
			this.ck44.TabIndex = 13;
			this.ck44.Text = "checkBox4";
			this.ck44.CheckedChanged += new System.EventHandler(this.ck44_CheckedChanged);
			// 
			// tab_4_txt_WID
			// 
			this.tab_4_txt_WID.Location = new System.Drawing.Point(132, 32);
			this.tab_4_txt_WID.Name = "tab_4_txt_WID";
			this.tab_4_txt_WID.Size = new System.Drawing.Size(148, 23);
			this.tab_4_txt_WID.TabIndex = 10;
			this.tab_4_txt_WID.Text = "";
			// 
			// ck43
			// 
			this.ck43.Location = new System.Drawing.Point(8, 36);
			this.ck43.Name = "ck43";
			this.ck43.Size = new System.Drawing.Size(128, 24);
			this.ck43.TabIndex = 11;
			this.ck43.Text = "checkBox3";
			this.ck43.CheckedChanged += new System.EventHandler(this.ck43_CheckedChanged);
			// 
			// Tab_4_txt_LAB_ID
			// 
			this.Tab_4_txt_LAB_ID.Enabled = false;
			this.Tab_4_txt_LAB_ID.Location = new System.Drawing.Point(412, 4);
			this.Tab_4_txt_LAB_ID.Name = "Tab_4_txt_LAB_ID";
			this.Tab_4_txt_LAB_ID.Size = new System.Drawing.Size(148, 23);
			this.Tab_4_txt_LAB_ID.TabIndex = 7;
			this.Tab_4_txt_LAB_ID.Text = "";
			// 
			// ck42
			// 
			this.ck42.Location = new System.Drawing.Point(288, 8);
			this.ck42.Name = "ck42";
			this.ck42.Size = new System.Drawing.Size(128, 24);
			this.ck42.TabIndex = 9;
			this.ck42.Text = "checkBox2";
			this.ck42.CheckedChanged += new System.EventHandler(this.ck42_CheckedChanged);
			// 
			// ck41
			// 
			this.ck41.Location = new System.Drawing.Point(8, 8);
			this.ck41.Name = "ck41";
			this.ck41.Size = new System.Drawing.Size(128, 24);
			this.ck41.TabIndex = 8;
			this.ck41.Text = "checkBox1";
			this.ck41.CheckedChanged += new System.EventHandler(this.ck41_CheckedChanged);
			// 
			// panel21
			// 
			this.panel21.BackColor = System.Drawing.Color.LightSteelBlue;
			this.panel21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel21.Controls.Add(this.Tab_4_cmd_print);
			this.panel21.Controls.Add(this.p45);
			this.panel21.Controls.Add(this.Tab_4_cmd_back);
			this.panel21.Controls.Add(this.Tab_4_cmd_sea);
			this.panel21.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel21.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panel21.Location = new System.Drawing.Point(562, 0);
			this.panel21.Name = "panel21";
			this.panel21.Size = new System.Drawing.Size(140, 224);
			this.panel21.TabIndex = 28;
			// 
			// Tab_4_cmd_print
			// 
			this.Tab_4_cmd_print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Tab_4_cmd_print.BackColor = System.Drawing.SystemColors.Control;
			this.Tab_4_cmd_print.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.Tab_4_cmd_print.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Tab_4_cmd_print.Location = new System.Drawing.Point(17, 52);
			this.Tab_4_cmd_print.Name = "Tab_4_cmd_print";
			this.Tab_4_cmd_print.Size = new System.Drawing.Size(104, 36);
			this.Tab_4_cmd_print.TabIndex = 5;
			this.Tab_4_cmd_print.Text = "button1";
			this.Tab_4_cmd_print.Click += new System.EventHandler(this.Tab_4_cmd_print_Click);
			// 
			// p45
			// 
			this.p45.BackColor = System.Drawing.Color.LightSteelBlue;
			this.p45.Controls.Add(this.cmd_show);
			this.p45.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.p45.Location = new System.Drawing.Point(0, 94);
			this.p45.Name = "p45";
			this.p45.Size = new System.Drawing.Size(138, 128);
			this.p45.TabIndex = 4;
			this.p45.Visible = false;
			// 
			// cmd_show
			// 
			this.cmd_show.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmd_show.BackColor = System.Drawing.SystemColors.Control;
			this.cmd_show.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_show.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmd_show.Location = new System.Drawing.Point(17, 4);
			this.cmd_show.Name = "cmd_show";
			this.cmd_show.Size = new System.Drawing.Size(104, 36);
			this.cmd_show.TabIndex = 4;
			this.cmd_show.Text = "button1";
			this.cmd_show.Click += new System.EventHandler(this.cmd_show_Click);
			// 
			// Tab_4_cmd_back
			// 
			this.Tab_4_cmd_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Tab_4_cmd_back.BackColor = System.Drawing.SystemColors.Control;
			this.Tab_4_cmd_back.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.Tab_4_cmd_back.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Tab_4_cmd_back.Location = new System.Drawing.Point(17, 8);
			this.Tab_4_cmd_back.Name = "Tab_4_cmd_back";
			this.Tab_4_cmd_back.Size = new System.Drawing.Size(104, 36);
			this.Tab_4_cmd_back.TabIndex = 3;
			this.Tab_4_cmd_back.Text = "button1";
			this.Tab_4_cmd_back.Visible = false;
			this.Tab_4_cmd_back.Click += new System.EventHandler(this.Tab_4_cmd_back_Click);
			// 
			// Tab_4_cmd_sea
			// 
			this.Tab_4_cmd_sea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Tab_4_cmd_sea.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.Tab_4_cmd_sea.Location = new System.Drawing.Point(17, 8);
			this.Tab_4_cmd_sea.Name = "Tab_4_cmd_sea";
			this.Tab_4_cmd_sea.Size = new System.Drawing.Size(104, 36);
			this.Tab_4_cmd_sea.TabIndex = 2;
			this.Tab_4_cmd_sea.Text = "button1";
			this.Tab_4_cmd_sea.Click += new System.EventHandler(this.Tab_4_cmd_sea_Click);
			// 
			// c1CommandDock1
			// 
			this.c1CommandDock1.Controls.Add(this.c1DockingTab2);
			this.c1CommandDock1.Dock = System.Windows.Forms.DockStyle.Left;
			this.c1CommandDock1.Id = 1;
			this.c1CommandDock1.Location = new System.Drawing.Point(0, 0);
			this.c1CommandDock1.Name = "c1CommandDock1";
			this.c1CommandDock1.Size = new System.Drawing.Size(232, 492);
			// 
			// c1DockingTab2
			// 
			this.c1DockingTab2.Alignment = System.Windows.Forms.TabAlignment.Bottom;
			this.c1DockingTab2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.c1DockingTab2.CanAutoHide = true;
			this.c1DockingTab2.CanMoveTabs = true;
			this.c1DockingTab2.Controls.Add(this.c1DockingTabPage1);
			this.c1DockingTab2.Location = new System.Drawing.Point(0, 0);
			this.c1DockingTab2.Name = "c1DockingTab2";
			this.c1DockingTab2.SelectedIndex = 0;
			this.c1DockingTab2.ShowCaption = true;
			this.c1DockingTab2.ShowSingleTab = false;
			this.c1DockingTab2.Size = new System.Drawing.Size(232, 492);
			this.c1DockingTab2.TabIndex = 0;
			this.c1DockingTab2.TabSizeMode = C1.Win.C1Command.TabSizeModeEnum.Fit;
			this.c1DockingTab2.TabStyle = C1.Win.C1Command.TabStyleEnum.WindowsXP;
			// 
			// c1DockingTabPage1
			// 
			this.c1DockingTabPage1.Controls.Add(this.Dep);
			this.c1DockingTabPage1.ImageIndex = -1;
			this.c1DockingTabPage1.Location = new System.Drawing.Point(1, 1);
			this.c1DockingTabPage1.Name = "c1DockingTabPage1";
			this.c1DockingTabPage1.Size = new System.Drawing.Size(227, 490);
			this.c1DockingTabPage1.TabIndex = 0;
			this.c1DockingTabPage1.Text = "Page1";
			// 
			// Dep
			// 
			this.Dep.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Dep.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Dep.Location = new System.Drawing.Point(0, 23);
			this.Dep.Name = "Dep";
			this.Dep.Size = new System.Drawing.Size(227, 467);
			this.Dep.TabIndex = 2;
			// 
			// Tab_3_dt2
			// 
			this.Tab_3_dt2.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Tab_3_dt2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Tab_3_dt2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.Tab_3_dt2.Location = new System.Drawing.Point(136, 60);
			this.Tab_3_dt2.Name = "Tab_3_dt2";
			this.Tab_3_dt2.Size = new System.Drawing.Size(160, 23);
			this.Tab_3_dt2.TabIndex = 16;
			this.Tab_3_dt2.Value = new System.DateTime(2014, 11, 27, 15, 24, 49, 783);
			// 
			// Tab_3_dt1
			// 
			this.Tab_3_dt1.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Tab_3_dt1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Tab_3_dt1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.Tab_3_dt1.Location = new System.Drawing.Point(136, 33);
			this.Tab_3_dt1.Name = "Tab_3_dt1";
			this.Tab_3_dt1.Size = new System.Drawing.Size(160, 23);
			this.Tab_3_dt1.TabIndex = 38;
			this.Tab_3_dt1.Value = new System.DateTime(2014, 11, 27, 15, 24, 49, 783);
			// 
			// frmTaAnnexLabourContract
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(940, 560);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaAnnexLabourContract";
			this.Text = "frmTaAnnexLabourContract";
			this.Load += new System.EventHandler(this.frmTaLabourContract_Load);
			this.panel3.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).EndInit();
			this.c1DockingTab1.ResumeLayout(false);
			this.Tab_1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.panel10.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs1)).EndInit();
			this.panel9.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			this.Tab_3.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel13.ResumeLayout(false);
			this.panel11.ResumeLayout(false);
			this.panel24.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs4)).EndInit();
			this.panel23.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs7)).EndInit();
			this.panel4.ResumeLayout(false);
			this.p31.ResumeLayout(false);
			this.Tab_3_p2.ResumeLayout(false);
			this.panel15.ResumeLayout(false);
			this.panel20.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs3)).EndInit();
			this.panel12.ResumeLayout(false);
			this.panel17.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs2)).EndInit();
			this.panel14.ResumeLayout(false);
			this.Tab_3_p1.ResumeLayout(false);
			this.panel18.ResumeLayout(false);
			this.panel16.ResumeLayout(false);
			this.Tab_4.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel19.ResumeLayout(false);
			this.panel22.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs5)).EndInit();
			this.p41.ResumeLayout(false);
			this.p43.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs6)).EndInit();
			this.p42.ResumeLayout(false);
			this.panel21.ResumeLayout(false);
			this.p45.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandDock1)).EndInit();
			this.c1CommandDock1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.c1DockingTab2)).EndInit();
			this.c1DockingTab2.ResumeLayout(false);
			this.c1DockingTabPage1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaLabourContract_Load(object sender, System.EventArgs e)
		{
			Init_Form();
			c1DockingTab1.SelectedIndex=0;	
	
		}
		#region Init
		private void Init_Form()
		{					
//			Dep.Init_Tree(this.Tag+"");
//			Dep.vs1.AfterRowColChange+=new RangeEventHandler(Depvs1_AfterRowColChange);
//			Dep.Show_Tree();
			Init_vs();		
			Init_vs1();		
			Init_vs2();
			Init_vs4();
			Init_vs5();
			Init_vs6();
			show_text();			
			Basic.Function.PublicFunction.L_Init_Label(this);		
			string frmat=PublicFunction.GetOption("DATE");
			vs4.Cols["LAB_ST"].Format=frmat;
			vs4.Cols["LAB_ED"].Format=frmat;
			vs4.Cols["LA1_ST"].Format=frmat;
			vs4.Cols["LA1_SG"].Format=frmat;
			Tab_3_dt1.CustomFormat=frmat;
			Tab_3_dt2.CustomFormat=frmat;
		}
		private void Init_vs()
		{
			nav.cmd_search.Visible=nav.cmd_report.Visible=nav.cmd_copy.Visible=false;
			PublicFunction.InitNav(this,vs,nav);
			nav.Show_VS();
			vs.AllowEditing=false;				
			vs.AfterRowColChange+=new RangeEventHandler(vs_AfterRowColChange);
			nav.ToolBar_Auto=false;
			nav.TBarClick+=new ToolBarButtonClickEventHandler(nav_TBarClick);
		}	
		private void Init_vs1()
		{
			nav1.cmd_delete.Visible=nav1.cmd_add.Visible=nav1.cmd_exit.Visible=
				nav1.cmd_search.Visible=nav1.cmd_report.Visible=nav1.cmd_copy.Visible=false;
			PublicFunction.InitNav(this,vs1,nav1);								
		}	
		private void Init_vs2()
		{			
			PublicFunction.InitNav(this,vs2,nav2);			
			PublicFunction.InitNav(this,vs3,nav3);
			vs2.DoubleClick+=new EventHandler(vs2_DoubleClick);
			vs3.DoubleClick+=new EventHandler(vs3_DoubleClick);	
		}	

		private void Init_vs4()
		{
			nav4.cmd_refresh.Visible=nav4.cmd_exit.Visible=nav4.cmd_save.Visible=nav4.cmd_add.Visible=nav4.cmd_search.Visible=nav4.cmd_report.Visible=nav4.cmd_copy.Visible=false;			
			PublicFunction.InitNav(this,vs4,nav4);				
			vs7.Rows.Count=1;
			vs7.Cols.Count=1;
			vs4.Cols.Frozen=vs4.Cols["EMP_NM"].Index;
		}
		
		private void Init_vs5()
		{
			nav5.cmd_exit.Visible=nav5.cmd_save.Visible=nav5.cmd_add.Visible=nav5.cmd_search.Visible=nav5.cmd_report.Visible=nav5.cmd_copy.Visible=false;
			PublicFunction.InitNav(this,vs5,nav5);				
			Dep.Init_Tree(this.Tag+"");		
			Dep.Show_Tree();		
			Dep.vs1.AfterRowColChange+=new C1.Win.C1FlexGrid.RangeEventHandler(Depvs1_AfterRowColChange);			
			//vs5.Cols["LAB_ST"].Format=vs5.Cols["LAB_ED"].Format=_ED"].Format;		
			vs5.AllowEditing=false;
			vs5.Cols.Frozen=vs5.Cols["EMP_NM"].Index;
			nav5.ToolBar_Auto=false;
			nav5.TBarClick+=new ToolBarButtonClickEventHandler(nav5_TBarClick);
		}
		private void nav5_TBarClick(object sender, ToolBarButtonClickEventArgs e)
		{
			if (e.Button.Equals(nav5.cmd_refresh))
			{
				if(nav5.wh!="")
					nav5.ToolBar_Click(e);
				else
					nav5.Show_VS("DEP_ID in "+T_String.DEP_ID(this.Tag));
				return;
			}
			nav5.ToolBar_Click(e);	
		}
		private void Init_vs6()
		{
			nav6.cmd_delete.Visible=nav6.cmd_save.Visible=nav6.cmd_add.Visible=nav6.cmd_search.Visible=nav6.cmd_report.Visible=nav6.cmd_copy.Visible=false;
			PublicFunction.InitNav(this,vs6,nav6);	
			vs6.AllowEditing=false;
			Init_CB6();	
			vs6.AfterRowColChange+=new RangeEventHandler(vs6_AfterRowColChange);
			nav6.ToolBar_Auto=false;
			nav6.TBarClick+=new ToolBarButtonClickEventHandler(nav6_TBarClick);
		}
		private void nav6_TBarClick(object sender, ToolBarButtonClickEventArgs e)
		{
			if (e.Button.Equals(nav6.cmd_refresh))
			{
				if(nav6.wh!="")
					nav6.ToolBar_Click(e);
				else
					nav6.Show_VS("DEP_ID in "+T_String.DEP_ID(this.Tag));
				if(vs6.Row>0)
					nav5.Show_VS("a.EMP_ID=N'"+vs6.Rows[vs6.Row]["EMP_ID"]+"' and 1=1 Order by a.EMP_ID,SEQ_NO");
				else
					vs5.Rows.Count=1;
				return;
			}
			nav6.ToolBar_Click(e);
		}
		private void  Init_CB6()
		{			
			string sql;			
			//Department
			sql=PublicFunction.GetDep(this.Tag+"");			
			vs6.Cols["DEP_ID"].DataMap=PublicFunction.InitCBForVS(sql);	
			vs2.Cols["DEP_ID"].DataMap=PublicFunction.InitCBForVS(sql);	
			vs3.Cols["DEP_ID"].DataMap=PublicFunction.InitCBForVS(sql);	
			vs4.Cols["DEP_ID"].DataMap=PublicFunction.InitCBForVS(sql);	
			vs5.Cols["DEP_ID"].DataMap=PublicFunction.InitCBForVS(sql);
			PublicFunction.InitCB(Tab_3_cb_DEP_ID,sql,false);
			PublicFunction.InitCB(Tab_4_cb_DEP_ID,sql,false);
			//Position
			sql="Select POS_ID,POS_NM from FILA07A";	
			vs2.Cols["POS_ID"].DataMap=PublicFunction.InitCBForVS(sql);	
			vs3.Cols["POS_ID"].DataMap=PublicFunction.InitCBForVS(sql);	
			vs4.Cols["POS_ID"].DataMap=PublicFunction.InitCBForVS(sql);	
			vs5.Cols["POS_ID"].DataMap=PublicFunction.InitCBForVS(sql);
			vs6.Cols["POS_ID"].DataMap=PublicFunction.InitCBForVS(sql);
			vs4.Cols["POS_ID"].DataMap=PublicFunction.InitCBForVS(sql);	
			PublicFunction.InitCB(Tab_3_cb_POS_ID,sql,false);
			//Level
			sql="Select TYP_ID,TYP_NM from FILA11A";
			vs5.Cols["TYP_ID"].DataMap=PublicFunction.InitCBForVS(sql);
			vs6.Cols["TYP_ID"].DataMap=PublicFunction.InitCBForVS(sql);
			vs2.Cols["TYP_ID"].DataMap=PublicFunction.InitCBForVS(sql);	
			vs3.Cols["TYP_ID"].DataMap=PublicFunction.InitCBForVS(sql);	
			vs4.Cols["TYP_ID"].DataMap=PublicFunction.InitCBForVS(sql);	
			PublicFunction.InitCB(Tab_3_cb_TYP_ID,sql,false);
			PublicFunction.InitCB(Tab_4_cb_TYP_ID,sql,false);

			sql="Select Distinct LAB_NO,LAB_DR as nm from FILE05A";
			PublicFunction.InitCB(cb_LAB_TP,sql);
			PublicFunction.InitCB(Tab_4_cb_LAB_NO,sql);
			vs4.Cols["LAB_NO"].DataMap=PublicFunction.InitCBForVS(sql);
			vs5.Cols["LAB_NO"].DataMap=PublicFunction.InitCBForVS(sql);


			sql="Select COL_NM,COL_"+PublicFunction.L_Lag+" as NM from FILD01A";
			vs4.Cols["SAL_N1"].DataMap=PublicFunction.InitCBForVS(sql);	
			vs4.Cols["SAL_N2"].DataMap=PublicFunction.InitCBForVS(sql);	
			vs4.Cols["SAL_N3"].DataMap=PublicFunction.InitCBForVS(sql);	
			vs4.Cols["SAL_N4"].DataMap=PublicFunction.InitCBForVS(sql);	
			vs4.Cols["SAL_N5"].DataMap=PublicFunction.InitCBForVS(sql);	
			vs4.Cols["SAL_N6"].DataMap=PublicFunction.InitCBForVS(sql);	
			vs4.Cols["SAL_N7"].DataMap=PublicFunction.InitCBForVS(sql);	
			vs4.Cols["SAL_N8"].DataMap=PublicFunction.InitCBForVS(sql);	
			vs4.Cols["SAL_N9"].DataMap=PublicFunction.InitCBForVS(sql);				
		}
		#endregion
		#region ShowData
		
		private void vs_AfterRowColChange(object sender, RangeEventArgs e)
		{
			if(e.OldRange.r1!=e.NewRange.r1)			
				show_text();
		}
		private void show_text()
		{
			show_vs1();
			if(vs.Row>0)
			{
				txt_LAB_NO.Text=vs.Rows[vs.Row]["LAB_NO"]+"";
				txt_LAB_NM.Text=vs.Rows[vs.Row]["LAB_DR"]+"";
				txt_LAB_ID.Text=vs.Rows[vs.Row]["LAB_ID"]+"";
				txt.Text=vs.Rows[vs.Row]["LAB_TP"]+"";
				txt_1.Text=vs.Rows[vs.Row]["STT_N1"]+"";
				txt_2.Text=vs.Rows[vs.Row]["STT_N2"]+"";
				txt_3.Text=vs.Rows[vs.Row]["STT_N3"]+"";
			}
			else
			{
				txt_LAB_ID.Text="";
				txt_LAB_NM.Text="";
				txt_LAB_NO.Text="";		
				txt.Text="";
				txt_1.Text="";
				txt_2.Text="";
				txt_3.Text="";
			}
		}
		private void show_vs1()
		{
			if(vs.Row<=0)
			{
				vs1.Rows.Count=1;
				return;
			}
			nav1.Show_VS("LAB_NO=N'"+vs.Rows[vs.Row]["LAB_NO"]+"'");
			if(vs1.Rows.Count<=1)
				txt.Text="";
			else
				txt.Text=vs1.Rows[vs1.Row]["LAB_TP"]+"";
		}	
	
		#endregion
		
		#region nav
		private void nav_TBarClick(object sender, ToolBarButtonClickEventArgs e)
		{					
			if (e.Button.Equals(nav.cmd_add))
			{
				if (vs.Rows.Count==1 || (int)vs.Rows[vs.Rows.Count-1].UserData!=2)					
					nav.ToolBar_Click(e);									
				return;
			}
			if (e.Button.Equals(nav.cmd_save))
			{
				try
				{					
					if ((int)vs.Rows[vs.Row].UserData!=2)
						vs.Rows[vs.Row].UserData=1;
					SaveData();	
					nav.ToolBar_Click(e);				
					return ;
				}
				catch( Exception){}
				
							
			}
			if (e.Button.Equals(nav.cmd_refresh))
			{
				nav.ToolBar_Click(e);				
				show_text();
				return;
			}
			if (e.Button.Equals(nav.cmd_delete))
			{
				nav.DeleteRow(vs.Row);
				return;
			}
			nav.ToolBar_Click(e);							
		}

		private void SaveData()
		{
			vs.Rows[vs.Row]["LAB_NO"]=txt_LAB_NO.Text;
			vs.Rows[vs.Row]["LAB_DR"]=txt_LAB_NM.Text;
			vs.Rows[vs.Row]["LAB_ID"]=txt_LAB_ID.Text;
			vs.Rows[vs.Row]["LAB_TP"]=txt.Text;
			vs.Rows[vs.Row]["STT_N1"]=txt_1.Text;
			vs.Rows[vs.Row]["STT_N2"]=txt_2.Text;
			vs.Rows[vs.Row]["STT_N3"]=txt_3.Text;			
		}
#endregion
		#region Tab1		

		private void vs1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode==Keys.F10)
			{
				frmTaLB1 dlg=new frmTaLB1();
				dlg.Tag=this.Tag;
				dlg.ShowDialog();
			}
		}

		private void cmd_type_Click(object sender, System.EventArgs e)
		{
			if(vs.Row>0)
			{
				Func.RecordSet rs=new Func.RecordSet("Select Distinct LAB_TP,FIL_NM from GP_ANNEXLABOURCONTRACT_FILENAME where CUS_ID=N'"
					+PublicFunction.CUS_ID+"'",PublicFunction.C_con);
				frmSearch dlg=new frmSearch(rs,2,"frmTaLB_vs");
				if(dlg.ShowDialog(this)==DialogResult.OK)
				{
					txt.Text=rs.record(rs.Bookmarks,0);					
				}
//				Func.RecordSet rs=new Func.RecordSet("Select Distinct LAB_TP from FILE05BA",PublicFunction.C_con);
//				frmSearch dlg=new frmSearch(rs,1,"frmTaLB1_vs");
//				if(dlg.ShowDialog(this)==DialogResult.OK)
//				{
//					txt.Text=rs.record(rs.Bookmarks,0);
//					string sql="";
//					sql="Delete from FILE05B where LAB_NO=N'"+vs.Rows[vs.Row]["LAB_NO"]+"'";
//					PublicFunction.SQL_Execute(sql);
//					sql="Insert Into FILE05B(LAB_NO,LAB_TP,INF_ID,INF_NM,INF_VL) "
//						+" Select '"+vs.Rows[vs.Row]["LAB_NO"]+"' as LAB_NO,LAB_TP,INF_ID,INF_NM,INF_VL "
//						+" from FILE05BA where  LAB_TP=N'"+rs.record(rs.Bookmarks,0)+"'";
//					PublicFunction.SQL_Execute(sql);
//					nav1.Show_VS("LAB_NO=N'"+vs.Rows[vs.Row]["LAB_NO"]+"'");
//					sql="Update FILE05A set LAB_TP=N'"+rs.record(rs.Bookmarks,0)+"' where LAB_NO=N'"+vs.Rows[vs.Row]["LAB_NO"]+"'";
//					PublicFunction.SQL_Execute(sql);
//				}
			}
		}
		#endregion	
		#region Tab3
		private void tab_3_cmd1_Click(object sender, System.EventArgs e)
		{
			for(int j=1;j<vs2.Rows.Count;j++)
			{
				int i;
				for(i=1;i<vs3.Rows.Count;i++)
				{
					if(	vs3.Rows[i]["EMP_ID"]+""==vs2.Rows[j]["EMP_ID"]+"")
						break;
				}
				if(i>=vs3.Rows.Count)
				{
					vs3.Rows.Count++;
					vs3.Rows[vs3.Rows.Count-1][0]=vs3.Rows.Count-1;
					for(int m=1;m<vs2.Cols.Count;m++)
					{
						vs3.Rows[vs3.Rows.Count-1][m]=vs2.Rows[j][m];
					}
				}
			}					
		}
		private void tab_3_cmd2_Click(object sender, System.EventArgs e)
		{
			if(vs2.Row>0)
			{
				for(int i=1;i<vs3.Rows.Count;i++)
				{
					if(	vs3.Rows[i]["EMP_ID"]+""==vs2.Rows[vs2.Row]["EMP_ID"]+"")
						return;
				}
				vs3.Rows.Count++;
				vs3.Rows[vs3.Rows.Count-1][0]=vs3.Rows.Count-1;
				for(int i=1;i<vs2.Cols.Count;i++)
				{
					vs3.Rows[vs3.Rows.Count-1][i]=vs2.Rows[vs2.Row][i];
				}
			}	
		}
		private void tab_3_cmd3_Click(object sender, System.EventArgs e)
		{
			if(vs3.Row>0)
				vs3.RemoveItem(vs3.Row);	
		}


		private void tab_3_cmd4_Click(object sender, System.EventArgs e)
		{
			vs3.Rows.Count=1;
		}		
		private void vs2_DoubleClick(object sender, EventArgs e)
		{		
			if(vs2.Row>0)
			{
				for(int i=1;i<vs3.Rows.Count;i++)
				{
					if(	vs3.Rows[i]["EMP_ID"]+""==vs2.Rows[vs2.Row]["EMP_ID"]+"")
						return;
				}
				vs3.Rows.Count++;
				vs3.Rows[vs3.Rows.Count-1][0]=vs3.Rows.Count-1;
				for(int i=1;i<vs2.Cols.Count;i++)
				{
					vs3.Rows[vs3.Rows.Count-1][i]=vs2.Rows[vs2.Row][i];
				}
			}						
		}
		private void vs3_DoubleClick(object sender, EventArgs e)
		{		
			if(vs3.Row>0)
				vs3.RemoveItem(vs3.Row);			
		}
		private void rd3_CheckedChanged(object sender, System.EventArgs e)
		{
			Tab_3_p1.Enabled=rd32.Checked;
		}

		private void rd4_CheckedChanged(object sender, System.EventArgs e)
		{
			tab_3_txt_WID1.Enabled=tab_3_txt_WID2.Enabled=rd41.Checked;
			tab_3_txt_DWID1.Enabled=tab_3_txt_DWID2.Enabled=rd42.Checked;
			Tab_3_cb_DEP_ID.Enabled=rd43.Checked;		
			Tab_3_cb_POS_ID.Enabled=rd44.Checked;
			Tab_3_cb_TYP_ID.Enabled=rd45.Checked;
			Tab_3_txt_WID.Enabled=rd46.Checked;			
		}
		private void button2_Click(object sender, System.EventArgs e)
		{
			Tab_3_p1.Visible=!Tab_3_p1.Visible;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			string sql="";
			if(rd32.Checked)
			{
				if(rd41.Checked)
				{
					if(tab_3_txt_WID2.Text!="")
						sql="(EMP_ID between N'"+tab_3_txt_WID1.Text+"' and N'"+tab_3_txt_WID2.Text+"')";
					else
						sql="(EMP_ID=N'"+tab_3_txt_WID1.Text+"')";
				}
				if(rd42.Checked)
				{
					if(tab_3_txt_DWID2.Text!="")
						sql="(EMP_I1 between N'"+tab_3_txt_DWID1.Text+"' and N'"+tab_3_txt_DWID2.Text+"')";
					else
						sql="(EMP_I1=N'"+tab_3_txt_DWID1.Text+"')";
				}
				if(rd43.Checked)
				{
					sql="(DEP_ID=N'"+Tab_3_cb_DEP_ID.SelectedValue+"')";
				}
				if(rd44.Checked)
				{
					sql="(POS_ID=N'"+Tab_3_cb_POS_ID.SelectedValue+"')";
				}
				if(rd45.Checked)
				{
					sql="(TYP_ID=N'"+Tab_3_cb_TYP_ID.SelectedValue+"')";
				}
				if(rd46.Checked)
				{
					for (int i=0;i<Tab_3_txt_WID.Lines.Length;i++)
					{
						if(sql!="") sql+=",";
						sql="N'"+txt.Lines[i]+"'";
					}
					sql="(EMP_ID in ("+sql+"))";					
				}			
			}
			if(sql!="") sql+=" and ";
			sql+="DEP_ID in "+T_String.DEP_ID(this.Tag);
			nav2.Show_VS(sql);
		}

		private void cb_LAB_TP_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			string LAB_TP=T_String.GetDataFromSQL("LAB_TP","FILE05A","LAB_NO=N'"+cb_LAB_TP.SelectedValue+"'");
			Func.RecordSet rs=new Func.RecordSet("Select * from FILE05BB a,FILD01A b where a.COL_NM=b.COL_NM and "
				+"LAB_TP=N'"+LAB_TP+"'",PublicFunction.C_con);
			vs7.Rows.Count=2;
			vs7.Cols.Count=rs.rows+1;
			for(int i=0;i<rs.rows;i++)
			{
				vs7.Cols[i+1].Name=rs.record(i,"COL_NM");
				vs7.Cols[i+1].Caption=rs.record(i,"COL_"+PublicFunction.L_Lag);
				vs7.Cols[i+1].DataType=typeof(double);
			}
		}
		#endregion
		#region Tab4
		private void Depvs1_AfterRowColChange(object sender, C1.Win.C1FlexGrid.RangeEventArgs e)
		{
			if(e.OldRange.r1!=e.NewRange.r1)
			{
				if(p43.Visible)
				{
					nav6.Show_VS("DEP_ID=N'"+Dep.Get_Data("DEP_ID")+"' and (DEL_BT=0 or DEL_BT is null)");
					if(vs6.Row>0)
						nav5.Show_VS("a.EMP_ID=N'"+vs6.Rows[vs6.Row]["EMP_ID"]+"' and 1=1 Order by a.EMP_ID,SEQ_NO");
				}
			}
		}
		private void Tab_4_cmd_sea_Click(object sender, System.EventArgs e)
		{
			p43.Visible=false;
			p42.Visible=true;
			p42.Dock=DockStyle.Fill;
			Tab_4_cmd_back.Visible=true;
			Tab_4_cmd_sea.Visible=false;
			p45.Visible=true;
		}

		private void Tab_4_cmd_back_Click(object sender, System.EventArgs e)
		{
			p43.Visible=true;
			p42.Visible=false;
			p42.Dock=DockStyle.Fill;
			Tab_4_cmd_back.Visible=false;
			Tab_4_cmd_sea.Visible=true;
			nav6.Show_VS("DEP_ID=N'"+Dep.Get_Data("DEP_ID")+"' and (DEL_BT=0 or DEL_BT is null)");
			p45.Visible=false;
		}
		private void vs6_AfterRowColChange(object sender, RangeEventArgs e)
		{
			if(e.OldRange.r1!=e.NewRange.r1 && vs6.Row>0)
				nav5.Show_VS("a.EMP_ID=N'"+vs6.Rows[vs6.Row]["EMP_ID"]+"' and 1=1 Order by a.EMP_ID,SEQ_NO");
		}	

		private void ck41_CheckedChanged(object sender, System.EventArgs e)
		{
			Tab_4_cb_LAB_NO.Enabled=ck41.Checked;
		}

		private void ck42_CheckedChanged(object sender, System.EventArgs e)
		{
			Tab_4_txt_LAB_ID.Enabled=ck42.Checked;
		}

		private void ck43_CheckedChanged(object sender, System.EventArgs e)
		{
			tab_4_txt_WID.Enabled=ck43.Checked;
		}

		private void ck44_CheckedChanged(object sender, System.EventArgs e)
		{
			tab_4_txt_DWID.Enabled=ck44.Checked;
		}

		private void ck45_CheckedChanged(object sender, System.EventArgs e)
		{
			Tab_4_txt_EMP_ID.Enabled=ck45.Checked;
		}

		private void ck46_CheckedChanged(object sender, System.EventArgs e)
		{
			Tab_4_txt_EMP_I1.Enabled=ck46.Checked;
		}

		private void ck47_CheckedChanged(object sender, System.EventArgs e)
		{
			Tab_4_cb_DEP_ID.Enabled=ck47.Checked;
		}

		private void ck48_CheckedChanged(object sender, System.EventArgs e)
		{
			Tab_4_cb_TYP_ID.Enabled=ck48.Checked;
		}

		private void cmd_show_Click(object sender, System.EventArgs e)
		{
			string sql="";
			if(ck41.Checked)
			{
				sql+=" LAB_NO=N'"+Tab_4_cb_LAB_NO.SelectedValue+"' ";
			}
			if(ck42.Checked)
			{
				if(sql!="")	sql+=" and ";
				sql+=" LAB_I1=N'"+Tab_4_txt_LAB_ID.Text+"' ";
			}
			if(ck43.Checked)
			{
				if(sql!="")	sql+=" and ";
				sql+=" a.EMP_ID=N'"+tab_4_txt_WID.Text+"' ";
			}
			if(ck44.Checked)
			{
				if(sql!="")	sql+=" and ";
				sql+=" EMP_I1=N'"+tab_4_txt_DWID.Text+"' ";
			}
			if(ck45.Checked)
			{
				if(sql!="")	sql+=" and ";
				sql+=" EMP_NM=N'"+Tab_4_txt_EMP_ID.Text+"' ";
			}
			if(ck46.Checked)
			{
				if(sql!="")	sql+=" and ";
				sql+=" a.EMP_N1=N'"+Tab_4_txt_EMP_I1.Text+"' ";
			}
			if(ck47.Checked)
			{
				if(sql!="")	sql+=" and ";
				sql+=" DEP_ID=N'"+Tab_4_cb_DEP_ID.SelectedValue+"' ";
			}
			if(ck48.Checked)
			{
				if(sql!="")	sql+=" and ";
				sql+=" TYP_ID=N'"+Tab_4_cb_TYP_ID.SelectedValue+"' ";
			}
			if(sql!="") sql+=" and ";
				sql+="DEP_ID in "+T_String.DEP_ID(this.Tag);		
			nav5.Show_VS(sql +" Order by a.EMP_ID,SEQ_NO");
		
		}

		private void Tab3_cmd_Show_Click(object sender, System.EventArgs e)
		{
			nav4.Show_VS("1=0");
			if(vs3.Rows.Count>1 && cb_LAB_TP.SelectedValue+""!="")
			{
				frmTaShowAnnexLabour dlg=new frmTaShowAnnexLabour(vs4,vs3,vs7,cb_LAB_TP.SelectedValue+""
					,DateTime.Parse(Tab_3_dt1.Value+"").ToString("yyyy/MM/dd"), DateTime.Parse(Tab_3_dt2.Value+"").ToString("yyyy/MM/dd"),nav4);
				dlg.ShowDialog(this);
			}			
		}

		private void Tab_3_cmd_print_Click(object sender, System.EventArgs e)
		{
			Thread th=new Thread(new ThreadStart(Tab_3_print));
			th.Start();
		}

		private void Tab_3_print()
		{
			double max1=T_String.GetMax("MAX(SEQ_N2)","FILE06A");			
			nav4.ToolBar_Click(new ToolBarButtonClickEventArgs(nav4.cmd_save));
			double max2=T_String.GetMax("MAX(SEQ_N2)","FILE06A")-1;
			string sql;
			for(int i=1;i<vs4.Rows.Count;i++)
			{
				double m=T_String.IsNullTo00(vs4.Rows[i]["SEQ_N2"]+"");
				if(max1<0)
					max1=m;
				if(m<max1)
					max1=m;
				if(m>max2)
					max2=m;
				int co=T_String.IsNullTo0(T_String.GetDataFromSQL("Count(*)","FILB01AF","EMP_ID=N'"+vs4.Rows[i]["EMP_ID"]+"'"));
				if(co==0)
				{
					sql="insert into FILB01AF(EMP_ID) values(N'"+vs4.Rows[i]["EMP_ID"]+"')";
					PublicFunction.SQL_Execute(sql);
				}
				sql="update FILB01AF set LA1_NO=N'"+vs4.Rows[i]["LA1_ID"]+"',LA1_ST='"
					+DateTime.Parse(vs4.Rows[i]["LA1_ST"]+"").ToString("yyyy/MM/dd")+"'";
//				if(vs4.Rows[i]["LAB_ST"]+""!="")
//					sql+=",LAB_ED='"+DateTime.Parse(vs4.Rows[i]["LAB_ED"]+"").ToString("yyyy/MM/dd")+"'";
//				else
//					sql+=",LAB_ED=Default";
				sql+=",LAB_TM="+T_String.IsNullTo0(T_String.GetDataFromSQL("Count(*)","FILE06A","EMP_ID=N'"+vs4.Rows[i]["EMP_ID"]+"'"))+" ";
				sql+=" where EMP_ID=N'"+vs4.Rows[i]["EMP_ID"]+"'";
				PublicFunction.SQL_Execute(sql);
			}
			
			sql="Select Distinct LAB_TP from FILE05A";
			Func.RecordSet rs=new Func.RecordSet(sql,PublicFunction.C_con);	
			for(int i=0;i<rs.rows;i++)			
			{					
				string where,where1,where2,where3,where4,where5,where6,where7;
				where=where1=where2=where3=where4=where5=where6=where7="";

				where=max1+"";
				where1=max2+"";
				string filename="";
				sql="CUS_ID="+PublicFunction.CUS_ID+" and LAB_TP=N'"+rs.record(i,"LAB_TP")+"'" ;
				filename=T_String.GetDataFromSQL("FIL_NM","GP_ANNEXLABOURCONTRACT_FILENAME",sql);
				if(filename+""!="")
				{
					filename=PublicFunction.Path+"\\ReportsVBA\\"+filename;
					if ( filename.Substring(filename.Length-3,3).ToUpper()=="DOT")
						ReportWord.PrintWord (filename,PublicFunction.C_ConStrForRPT,"","",
							PublicFunction.L_Lag,where,where1,where2,where3,where4,where5,where6,where7,"","",PublicFunction.Path,PublicFunction.A_UserID);
					else
						ReportExcel.PrintExcel(filename,PublicFunction.C_ConStrForRPT,"","",
							PublicFunction.L_Lag,where,where1,where2,where3,where4,where5,where6,where7,"","","","","","",PublicFunction.A_UserID );

				}
			//	vs4.Rows.Count--;
				//nav4.Show_VS("1=0");
			}			
		}

		private void Tab_4_cmd_print_Click(object sender, System.EventArgs e)
		{
			string sql="";
			
			if (vs5.Row>0)		
			{
				string where,where1,where2,where3,where4,where5,where6,where7;
				where=where1=where2=where3=where4=where5=where6=where7="";

				where=vs5.Rows[vs5.Row ]["SEQ_N2"]+"";
				where1=vs5.Rows[vs5.Row ]["SEQ_N2"]+"";
				string filename="";
				sql="CUS_ID="+PublicFunction.CUS_ID+" and LAB_TP=N'"+
					T_String.GetDataFromSQL("LAB_TP","FILE05A","LAB_NO=N'"+vs5.Rows[vs5.Row]["LAB_NO"]+"'")+"'" ;
				filename=T_String.GetDataFromSQL("FIL_NM","GP_ANNEXLABOURCONTRACT_FILENAME",sql);
				if(filename+""!="")
				{
					filename=PublicFunction.Path+"\\ReportsVBA\\"+filename;
					//					rp.PrintExcel(filename,PublicFunction.C_ConStrForRPT,"","",
					//						PublicFunction.L_Lag,where,where1,where2,where3,where4,where5,where6,where7,"","","",PublicFunction.A_UserID );
					//					rp.PrintExcel(filename,PublicFunction.C_ConStrForRPT,"","",//vs.Rows[vs.Row][PublicFunction.L_Lag]+"","",
					//						PublicFunction.L_Lag,where,where1,where2,where3,where4,where5,where6,where7,"","","",PublicFunction.A_UserID);
					if ( filename.Substring(filename.Length-3,3).ToUpper()=="DOT")
						ReportWord.PrintWord (filename,PublicFunction.C_ConStrForRPT,"","",
							PublicFunction.L_Lag,where,where1,where2,where3,where4,where5,where6,where7,"","",PublicFunction.Path,PublicFunction.A_UserID);
					else
						ReportExcel.PrintExcel(filename,PublicFunction.C_ConStrForRPT,"","",
							PublicFunction.L_Lag,where,where1,where2,where3,where4,where5,where6,where7,"","","","","","",PublicFunction.A_UserID );

				}
			}
		}

		

		
		

		

		

//		private void Tab_4_cmd_print_Click(object sender, System.EventArgs e)
//		{		
//			if(vs5.Row>0)
//			{
//				string where,where1,where2,where3,where4,where5,where6,where7,sql;
//				where=where1=where2=where3=where4=where5=where6=where7="";
//
//				where=vs5.Rows[vs5.Row]["SEQ_N2"]+"";
//				where1=vs5.Rows[vs5.Row]["SEQ_N2"]+"";
//				string filename="";
//				sql="CUS_ID="+PublicFunction.CUS_ID+" and LAB_TP=N'"+vs5.Rows[vs5.Row]["LAB_TP"]+"'" ;
//				filename=T_String.GetDataFromSQL("FIL_NM","GP_LABOURCONTRACT_FILENAME",sql);
//				if(filename+""!="")
//				{
//					filename=PublicFunction.Path+"\\ReportsVBA\\"+filename;
//					rp.PrintExcel(filename,PublicFunction.C_ConStrForRPT,vs.Rows[vs.Row][PublicFunction.L_Lag]+"","",
//						PublicFunction.L_Lag,where,where1,where2,where3,where4,where5,where6,where7);
//				}
//			}			
//		}
		#endregion

		


		
	}
}

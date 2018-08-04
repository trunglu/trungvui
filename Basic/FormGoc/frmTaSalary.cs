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
	/// Summary description for frmTaSalary.
	/// </summary>
	public class frmTaSalary : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel4;
		private Navigator1._0.NavigatorAuto nav;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel5;
		private C1.Win.C1Command.C1CommandDock c1CommandDock1;
		private C1.Win.C1Command.C1DockingTab c1DockingTab1;
		private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage1;
		private GP8000.UserControl.CrtTaDepartment Dep;
		private System.Windows.Forms.Panel panel6;
		private C1.Win.C1FlexGrid.C1FlexGrid vs;
		private Func.RecordSet rsitem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt2;
		private System.Windows.Forms.TextBox txt1;
		private System.Windows.Forms.Panel p1;
		private System.Windows.Forms.Panel p2;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Button cmd_quick;
		private System.Windows.Forms.Button cmd_back;
		private C1.Win.C1FlexGrid.C1FlexGrid vs1;
		private Navigator1._0.NavigatorAuto nav1;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel panel7;
		private C1.Win.C1FlexGrid.C1FlexGrid vs2;
		private System.Windows.Forms.Panel panel9;
		private C1.Win.C1FlexGrid.C1FlexGrid vs3;
		private System.Windows.Forms.Splitter splitter2;
		private System.Windows.Forms.Panel panel10;
		private System.Windows.Forms.ComboBox cb_LEV_ID;
		private System.Windows.Forms.ComboBox cb_GRT_ID;
		private System.Windows.Forms.ComboBox cb_GRP_ID;
		private System.Windows.Forms.CheckBox ck_LEV_ID;
		private System.Windows.Forms.CheckBox ck_GRT_ID;
		private System.Windows.Forms.CheckBox ck_GRP_ID;
		private System.Windows.Forms.CheckBox ck_VAT_BT;
		private System.Windows.Forms.CheckBox ck_NEW_BT;
		private System.Windows.Forms.Button cmd_excel;
		private System.Windows.Forms.Button cmd_input;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cb_TYP_ID;
		private System.Windows.Forms.CheckBox ck_TYP_ID;
		private System.Windows.Forms.Button cmd_transfer;
		private System.Windows.Forms.ComboBox cb_type;
		private System.Windows.Forms.CheckBox ck_type;
		private C1.Win.C1Input.C1DateEdit dt;
		private C1.Win.C1Input.C1DateEdit dt1;		
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaSalary()
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
			this.panel4 = new System.Windows.Forms.Panel();
			this.nav = new Navigator1._0.NavigatorAuto();
			this.nav1 = new Navigator1._0.NavigatorAuto();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.p2 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.panel10 = new System.Windows.Forms.Panel();
			this.vs3 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.splitter2 = new System.Windows.Forms.Splitter();
			this.panel9 = new System.Windows.Forms.Panel();
			this.vs2 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.panel8 = new System.Windows.Forms.Panel();
			this.vs1 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.p1 = new System.Windows.Forms.Panel();
			this.vs = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.c1CommandDock1 = new C1.Win.C1Command.C1CommandDock();
			this.c1DockingTab1 = new C1.Win.C1Command.C1DockingTab();
			this.c1DockingTabPage1 = new C1.Win.C1Command.C1DockingTabPage();
			this.Dep = new GP8000.UserControl.CrtTaDepartment();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dt1 = new C1.Win.C1Input.C1DateEdit();
			this.dt = new C1.Win.C1Input.C1DateEdit();
			this.cb_type = new System.Windows.Forms.ComboBox();
			this.ck_type = new System.Windows.Forms.CheckBox();
			this.cmd_transfer = new System.Windows.Forms.Button();
			this.cb_TYP_ID = new System.Windows.Forms.ComboBox();
			this.ck_TYP_ID = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cmd_input = new System.Windows.Forms.Button();
			this.cmd_excel = new System.Windows.Forms.Button();
			this.ck_NEW_BT = new System.Windows.Forms.CheckBox();
			this.ck_VAT_BT = new System.Windows.Forms.CheckBox();
			this.cb_GRT_ID = new System.Windows.Forms.ComboBox();
			this.cb_GRP_ID = new System.Windows.Forms.ComboBox();
			this.cb_LEV_ID = new System.Windows.Forms.ComboBox();
			this.ck_LEV_ID = new System.Windows.Forms.CheckBox();
			this.cmd_back = new System.Windows.Forms.Button();
			this.cmd_quick = new System.Windows.Forms.Button();
			this.txt2 = new System.Windows.Forms.TextBox();
			this.txt1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.ck_GRT_ID = new System.Windows.Forms.CheckBox();
			this.ck_GRP_ID = new System.Windows.Forms.CheckBox();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel6.SuspendLayout();
			this.p2.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel10.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs3)).BeginInit();
			this.panel9.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs2)).BeginInit();
			this.panel8.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs1)).BeginInit();
			this.p1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandDock1)).BeginInit();
			this.c1CommandDock1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).BeginInit();
			this.c1DockingTab1.SuspendLayout();
			this.c1DockingTabPage1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dt1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dt)).BeginInit();
			this.SuspendLayout();
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.panel4);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1028, 36);
			this.panel3.TabIndex = 6;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Location = new System.Drawing.Point(416, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(612, 36);
			this.label5.TabIndex = 11;
			this.label5.Tag = "";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.nav);
			this.panel4.Controls.Add(this.nav1);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(416, 36);
			this.panel4.TabIndex = 10;
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
			this.nav.Location = new System.Drawing.Point(0, 2);
			this.nav.MSG_Exit = false;
			this.nav.MulltiDel = false;
			this.nav.Name = "nav";
			this.nav.Security = 0;
			this.nav.ShowPopupMenu = true;
			this.nav.Size = new System.Drawing.Size(416, 32);
			this.nav.TabIndex = 10;
			this.nav.Tag = "";
			this.nav.ToolBar_Auto = true;
			this.nav.UserID = null;
			this.nav.Visible = false;
			this.nav.VisibleGrid = true;
			this.nav.Where = null;
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
			this.nav1.Location = new System.Drawing.Point(0, 2);
			this.nav1.MSG_Exit = false;
			this.nav1.MulltiDel = false;
			this.nav1.Name = "nav1";
			this.nav1.Security = 0;
			this.nav1.ShowPopupMenu = true;
			this.nav1.Size = new System.Drawing.Size(416, 32);
			this.nav1.TabIndex = 148;
			this.nav1.Tag = "";
			this.nav1.ToolBar_Auto = true;
			this.nav1.UserID = null;
			this.nav1.VisibleGrid = true;
			this.nav1.Where = null;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel5);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 36);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1028, 516);
			this.panel1.TabIndex = 7;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.panel6);
			this.panel5.Controls.Add(this.c1CommandDock1);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(0, 88);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(1028, 428);
			this.panel5.TabIndex = 1;
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.p2);
			this.panel6.Controls.Add(this.p1);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel6.Location = new System.Drawing.Point(216, 0);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(812, 428);
			this.panel6.TabIndex = 2;
			// 
			// p2
			// 
			this.p2.Controls.Add(this.panel7);
			this.p2.Controls.Add(this.splitter1);
			this.p2.Controls.Add(this.panel8);
			this.p2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.p2.Location = new System.Drawing.Point(0, 0);
			this.p2.Name = "p2";
			this.p2.Size = new System.Drawing.Size(768, 428);
			this.p2.TabIndex = 13;
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.panel10);
			this.panel7.Controls.Add(this.splitter2);
			this.panel7.Controls.Add(this.panel9);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel7.Location = new System.Drawing.Point(271, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(497, 428);
			this.panel7.TabIndex = 2;
			// 
			// panel10
			// 
			this.panel10.Controls.Add(this.vs3);
			this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel10.Location = new System.Drawing.Point(307, 0);
			this.panel10.Name = "panel10";
			this.panel10.Size = new System.Drawing.Size(190, 428);
			this.panel10.TabIndex = 2;
			// 
			// vs3
			// 
			this.vs3.AllowEditing = false;
			this.vs3.AutoResize = false;
			this.vs3.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs3.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vs3.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs3.Location = new System.Drawing.Point(0, 0);
			this.vs3.Name = "vs3";
			this.vs3.Size = new System.Drawing.Size(190, 428);
			this.vs3.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs3.TabIndex = 15;
			// 
			// splitter2
			// 
			this.splitter2.Location = new System.Drawing.Point(304, 0);
			this.splitter2.Name = "splitter2";
			this.splitter2.Size = new System.Drawing.Size(3, 428);
			this.splitter2.TabIndex = 1;
			this.splitter2.TabStop = false;
			// 
			// panel9
			// 
			this.panel9.Controls.Add(this.vs2);
			this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel9.Location = new System.Drawing.Point(0, 0);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(304, 428);
			this.panel9.TabIndex = 0;
			// 
			// vs2
			// 
			this.vs2.AllowEditing = false;
			this.vs2.AutoResize = false;
			this.vs2.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs2.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vs2.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs2.Location = new System.Drawing.Point(0, 0);
			this.vs2.Name = "vs2";
			this.vs2.Size = new System.Drawing.Size(304, 428);
			this.vs2.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs2.TabIndex = 13;
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(268, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(3, 428);
			this.splitter1.TabIndex = 1;
			this.splitter1.TabStop = false;
			// 
			// panel8
			// 
			this.panel8.Controls.Add(this.vs1);
			this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel8.Location = new System.Drawing.Point(0, 0);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(268, 428);
			this.panel8.TabIndex = 0;
			// 
			// vs1
			// 
			this.vs1.AllowEditing = false;
			this.vs1.AutoResize = false;
			this.vs1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs1.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vs1.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs1.Location = new System.Drawing.Point(0, 0);
			this.vs1.Name = "vs1";
			this.vs1.Size = new System.Drawing.Size(268, 428);
			this.vs1.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs1.TabIndex = 12;
			// 
			// p1
			// 
			this.p1.Controls.Add(this.vs);
			this.p1.Dock = System.Windows.Forms.DockStyle.Right;
			this.p1.Location = new System.Drawing.Point(768, 0);
			this.p1.Name = "p1";
			this.p1.Size = new System.Drawing.Size(44, 428);
			this.p1.TabIndex = 12;
			this.p1.Visible = false;
			// 
			// vs
			// 
			this.vs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.vs.AutoResize = false;
			this.vs.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs.Location = new System.Drawing.Point(4, 4);
			this.vs.Name = "vs";
			this.vs.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.CellRange;
			this.vs.Size = new System.Drawing.Size(36, 424);
			this.vs.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs.TabIndex = 11;
			// 
			// c1CommandDock1
			// 
			this.c1CommandDock1.Controls.Add(this.c1DockingTab1);
			this.c1CommandDock1.Dock = System.Windows.Forms.DockStyle.Left;
			this.c1CommandDock1.Id = 1;
			this.c1CommandDock1.Location = new System.Drawing.Point(0, 0);
			this.c1CommandDock1.Name = "c1CommandDock1";
			this.c1CommandDock1.Size = new System.Drawing.Size(216, 428);
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
			this.c1DockingTab1.Size = new System.Drawing.Size(216, 428);
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
			this.c1DockingTabPage1.Size = new System.Drawing.Size(211, 426);
			this.c1DockingTabPage1.TabIndex = 0;
			this.c1DockingTabPage1.Text = "Page1";
			// 
			// Dep
			// 
			this.Dep.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Dep.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Dep.Location = new System.Drawing.Point(0, 20);
			this.Dep.Name = "Dep";
			this.Dep.Size = new System.Drawing.Size(211, 406);
			this.Dep.TabIndex = 2;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Moccasin;
			this.panel2.Controls.Add(this.dt1);
			this.panel2.Controls.Add(this.dt);
			this.panel2.Controls.Add(this.cb_type);
			this.panel2.Controls.Add(this.ck_type);
			this.panel2.Controls.Add(this.cmd_transfer);
			this.panel2.Controls.Add(this.cb_TYP_ID);
			this.panel2.Controls.Add(this.ck_TYP_ID);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.cmd_input);
			this.panel2.Controls.Add(this.cmd_excel);
			this.panel2.Controls.Add(this.ck_NEW_BT);
			this.panel2.Controls.Add(this.ck_VAT_BT);
			this.panel2.Controls.Add(this.cb_GRT_ID);
			this.panel2.Controls.Add(this.cb_GRP_ID);
			this.panel2.Controls.Add(this.cb_LEV_ID);
			this.panel2.Controls.Add(this.ck_LEV_ID);
			this.panel2.Controls.Add(this.cmd_back);
			this.panel2.Controls.Add(this.cmd_quick);
			this.panel2.Controls.Add(this.txt2);
			this.panel2.Controls.Add(this.txt1);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.ck_GRT_ID);
			this.panel2.Controls.Add(this.ck_GRP_ID);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1028, 88);
			this.panel2.TabIndex = 0;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			// 
			// dt1
			// 
			this.dt1.CustomFormat = "yyyyMM";
			this.dt1.Enabled = false;
			this.dt1.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt1.Location = new System.Drawing.Point(64, 32);
			this.dt1.Name = "dt1";
			this.dt1.Size = new System.Drawing.Size(80, 23);
			this.dt1.TabIndex = 168;
			this.dt1.Tag = null;
			// 
			// dt
			// 
			this.dt.CustomFormat = "yyyyMM";
			this.dt.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt.Location = new System.Drawing.Point(64, 4);
			this.dt.Name = "dt";
			this.dt.Size = new System.Drawing.Size(80, 23);
			this.dt.TabIndex = 167;
			this.dt.Tag = null;
			this.dt.ValueChanged += new System.EventHandler(this.dt_ValueChanged);
			// 
			// cb_type
			// 
			this.cb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_type.Items.AddRange(new object[] {
														 "1",
														 "2",
														 "3",
														 "4"});
			this.cb_type.Location = new System.Drawing.Point(876, 4);
			this.cb_type.Name = "cb_type";
			this.cb_type.Size = new System.Drawing.Size(136, 24);
			this.cb_type.TabIndex = 165;
			this.cb_type.Tag = "GRP_ID";
			// 
			// ck_type
			// 
			this.ck_type.Checked = true;
			this.ck_type.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ck_type.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ck_type.Location = new System.Drawing.Point(792, 8);
			this.ck_type.Name = "ck_type";
			this.ck_type.TabIndex = 166;
			this.ck_type.Text = "CK_GRP_ID";
			this.ck_type.CheckedChanged += new System.EventHandler(this.ck_type_CheckedChanged);
			// 
			// cmd_transfer
			// 
			this.cmd_transfer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmd_transfer.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_transfer.Location = new System.Drawing.Point(8, 60);
			this.cmd_transfer.Name = "cmd_transfer";
			this.cmd_transfer.Size = new System.Drawing.Size(128, 24);
			this.cmd_transfer.TabIndex = 164;
			this.cmd_transfer.Text = "Back";
			this.cmd_transfer.Click += new System.EventHandler(this.cmd_transfer_Click);
			// 
			// cb_TYP_ID
			// 
			this.cb_TYP_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_TYP_ID.Enabled = false;
			this.cb_TYP_ID.Location = new System.Drawing.Point(420, 32);
			this.cb_TYP_ID.Name = "cb_TYP_ID";
			this.cb_TYP_ID.Size = new System.Drawing.Size(136, 24);
			this.cb_TYP_ID.TabIndex = 162;
			this.cb_TYP_ID.Tag = "";
			// 
			// ck_TYP_ID
			// 
			this.ck_TYP_ID.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ck_TYP_ID.Location = new System.Drawing.Point(332, 32);
			this.ck_TYP_ID.Name = "ck_TYP_ID";
			this.ck_TYP_ID.Size = new System.Drawing.Size(96, 24);
			this.ck_TYP_ID.TabIndex = 163;
			this.ck_TYP_ID.Text = "checkBox3";
			this.ck_TYP_ID.CheckedChanged += new System.EventHandler(this.ck_TYP_ID_CheckedChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(4, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 23);
			this.label2.TabIndex = 160;
			this.label2.Text = "label2";
			// 
			// cmd_input
			// 
			this.cmd_input.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmd_input.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_input.Location = new System.Drawing.Point(140, 60);
			this.cmd_input.Name = "cmd_input";
			this.cmd_input.Size = new System.Drawing.Size(128, 24);
			this.cmd_input.TabIndex = 159;
			this.cmd_input.Text = "Back";
			this.cmd_input.Click += new System.EventHandler(this.cmd_input_Click);
			// 
			// cmd_excel
			// 
			this.cmd_excel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmd_excel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_excel.Location = new System.Drawing.Point(272, 60);
			this.cmd_excel.Name = "cmd_excel";
			this.cmd_excel.Size = new System.Drawing.Size(128, 24);
			this.cmd_excel.TabIndex = 158;
			this.cmd_excel.Text = "Back";
			this.cmd_excel.Click += new System.EventHandler(this.cmd_excel_Click);
			// 
			// ck_NEW_BT
			// 
			this.ck_NEW_BT.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ck_NEW_BT.Location = new System.Drawing.Point(228, 36);
			this.ck_NEW_BT.Name = "ck_NEW_BT";
			this.ck_NEW_BT.Size = new System.Drawing.Size(100, 24);
			this.ck_NEW_BT.TabIndex = 157;
			this.ck_NEW_BT.Text = "checkBox2";
			// 
			// ck_VAT_BT
			// 
			this.ck_VAT_BT.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ck_VAT_BT.Location = new System.Drawing.Point(228, 8);
			this.ck_VAT_BT.Name = "ck_VAT_BT";
			this.ck_VAT_BT.Size = new System.Drawing.Size(100, 24);
			this.ck_VAT_BT.TabIndex = 156;
			this.ck_VAT_BT.Text = "checkBox1";
			// 
			// cb_GRT_ID
			// 
			this.cb_GRT_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_GRT_ID.Enabled = false;
			this.cb_GRT_ID.Location = new System.Drawing.Point(652, 32);
			this.cb_GRT_ID.Name = "cb_GRT_ID";
			this.cb_GRT_ID.Size = new System.Drawing.Size(136, 24);
			this.cb_GRT_ID.TabIndex = 153;
			this.cb_GRT_ID.Tag = "GRT_ID";
			// 
			// cb_GRP_ID
			// 
			this.cb_GRP_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_GRP_ID.Enabled = false;
			this.cb_GRP_ID.Location = new System.Drawing.Point(652, 4);
			this.cb_GRP_ID.Name = "cb_GRP_ID";
			this.cb_GRP_ID.Size = new System.Drawing.Size(136, 24);
			this.cb_GRP_ID.TabIndex = 152;
			this.cb_GRP_ID.Tag = "GRP_ID";
			// 
			// cb_LEV_ID
			// 
			this.cb_LEV_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_LEV_ID.Enabled = false;
			this.cb_LEV_ID.Location = new System.Drawing.Point(420, 4);
			this.cb_LEV_ID.Name = "cb_LEV_ID";
			this.cb_LEV_ID.Size = new System.Drawing.Size(136, 24);
			this.cb_LEV_ID.TabIndex = 151;
			this.cb_LEV_ID.Tag = "LEV_ID";
			// 
			// ck_LEV_ID
			// 
			this.ck_LEV_ID.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ck_LEV_ID.Location = new System.Drawing.Point(332, 8);
			this.ck_LEV_ID.Name = "ck_LEV_ID";
			this.ck_LEV_ID.Size = new System.Drawing.Size(96, 24);
			this.ck_LEV_ID.TabIndex = 150;
			this.ck_LEV_ID.Text = "ck_LEV_ID";
			this.ck_LEV_ID.CheckedChanged += new System.EventHandler(this.ck_LEV_ID_CheckedChanged);
			// 
			// cmd_back
			// 
			this.cmd_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmd_back.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_back.Location = new System.Drawing.Point(404, 60);
			this.cmd_back.Name = "cmd_back";
			this.cmd_back.Size = new System.Drawing.Size(128, 24);
			this.cmd_back.TabIndex = 149;
			this.cmd_back.Text = "Back";
			this.cmd_back.Visible = false;
			this.cmd_back.Click += new System.EventHandler(this.cmd_back_Click);
			// 
			// cmd_quick
			// 
			this.cmd_quick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmd_quick.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_quick.Location = new System.Drawing.Point(404, 60);
			this.cmd_quick.Name = "cmd_quick";
			this.cmd_quick.Size = new System.Drawing.Size(128, 24);
			this.cmd_quick.TabIndex = 148;
			this.cmd_quick.Text = "Quick Input";
			this.cmd_quick.Click += new System.EventHandler(this.cmd_quick_Click);
			// 
			// txt2
			// 
			this.txt2.BackColor = System.Drawing.Color.PeachPuff;
			this.txt2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt2.Location = new System.Drawing.Point(148, 32);
			this.txt2.MaxLength = 20;
			this.txt2.Name = "txt2";
			this.txt2.Size = new System.Drawing.Size(76, 23);
			this.txt2.TabIndex = 147;
			this.txt2.Tag = "EMP_I1";
			this.txt2.Text = "";
			this.txt2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
			// 
			// txt1
			// 
			this.txt1.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt1.Location = new System.Drawing.Point(148, 4);
			this.txt1.MaxLength = 20;
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(76, 23);
			this.txt1.TabIndex = 146;
			this.txt1.Tag = "EMP_ID";
			this.txt1.Text = "";
			this.txt1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(4, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "label1";
			// 
			// ck_GRT_ID
			// 
			this.ck_GRT_ID.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ck_GRT_ID.Location = new System.Drawing.Point(560, 32);
			this.ck_GRT_ID.Name = "ck_GRT_ID";
			this.ck_GRT_ID.TabIndex = 155;
			this.ck_GRT_ID.Text = "checkBox3";
			this.ck_GRT_ID.CheckedChanged += new System.EventHandler(this.ck_GRT_ID_CheckedChanged);
			// 
			// ck_GRP_ID
			// 
			this.ck_GRP_ID.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ck_GRP_ID.Location = new System.Drawing.Point(560, 8);
			this.ck_GRP_ID.Name = "ck_GRP_ID";
			this.ck_GRP_ID.TabIndex = 154;
			this.ck_GRP_ID.Text = "CK_GRP_ID";
			this.ck_GRP_ID.CheckedChanged += new System.EventHandler(this.ck_GRP_ID_CheckedChanged);
			// 
			// frmTaSalary
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(1028, 552);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaSalary";
			this.Text = "frmTaSalary";
			this.Load += new System.EventHandler(this.frmTaSalary_Load);
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.p2.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel10.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs3)).EndInit();
			this.panel9.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs2)).EndInit();
			this.panel8.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs1)).EndInit();
			this.p1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandDock1)).EndInit();
			this.c1CommandDock1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).EndInit();
			this.c1DockingTab1.ResumeLayout(false);
			this.c1DockingTabPage1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dt1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dt)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaSalary_Load(object sender, System.EventArgs e)
		{
			dt.Value=dt1.Value=T_String.GetDate();
			dt.VisibleButtons=dt1.VisibleButtons= C1.Win.C1Input.DropDownControlButtonFlags.DropDown;
			Init_vs();
			Init_vs1();
			Init_vs2();
			Init_vs3();
			Init_CB();
			Dep.Init_Tree(this.Tag+"");			
			Dep.Show_Tree();
			Basic.Function.PublicFunction.L_Init_Label(this);				
			Dep.vs1.AfterRowColChange+=new C1.Win.C1FlexGrid.RangeEventHandler(depvs1_AfterRowColChange);
			cb_type.Text ="2";
//			if(wh+""!="")
//				nav.Show_VS("a.EMP_ID=N'"+wh+"'");							
		}
		#region Init
		private void Init_vs()
		{
			vs.Rows[0].HeightDisplay= vs.Rows[0].HeightDisplay*3;
			vs.Styles["Fixed"].WordWrap=true;
			nav.cmd_copy.Visible=false;
			nav.cmd_delete.Visible=false;
			nav.cmd_report.Visible=false;
			nav.cmd_search.Visible=false;
			nav.cmd_add.Visible=false;
			nav.sql="SELECT a.EMP_ID,EMP_I1,EMP_DW,EMP_NM,INH_DT,a.DEP_ID,POS_ID,LEV_ID,YYY_MM,SEQ_NO";
			string sql="";
			sql="Select * from FILD01A WHERE (HID_BT IS NULL OR HID_BT =0) order by SEQ_NO";
			//sql="Select * from FILD01A WHERE (HID_BT IS NULL OR HID_BT =0) and QIN_BT=1 order by SEQ_NO";
			rsitem=new Func.RecordSet(sql,PublicFunction.C_con);
			for(int i=0;i<rsitem.rows;i++)
			{
				nav.sql+=",["+rsitem.record(i,"COL_NM")+"]";
			}
			nav.sql+=",a.BLT_NM,a.BLT_DT,a.LST_NM,a.LST_DT,a.LCK_BT ";
			nav.sql+=" from FILD02A a Left JOIN FILB01A b on a.EMP_ID=b.EMP_ID  Left JOIN FILB01AC c on a.EMP_ID=c.EMP_ID";
			nav.tb="FILD02A";
			PublicFunction.InitNav(this,vs,nav);
			nav.Msg_ExitSave=true;
			
			vs.EnabledChanged+=new EventHandler(vs_EnabledChanged);			
//			nav.ToolBar_Auto=false;
//			nav.TBarClick+=new ToolBarButtonClickEventHandler(nav_TBarClick);	
			
			vs.Cols["EMP_ID"].ComboList="|...";			
		
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
				vs.Cols[rsitem.record(i,"COL_NM")].Width=100;
			}
		
			//sql="Select * from FILD01A where (HID_BT IS NULL OR HID_BT =0) ";		
			sql="Select * from FILD01A WHERE (HID_BT IS NULL OR HID_BT =0) and QIN_BT=1 order by SEQ_NO";
			Func.RecordSet rs=new Func.RecordSet(sql,PublicFunction.C_con);
			vs.Styles.Add("Lock");
			vs.Styles["Lock"].BackColor=Color.LightSkyBlue;
			vs.Styles.Add("LCK_BT");
			vs.Styles["LCK_BT"].BackColor=Color.Brown;
			vs.Cols["LCK_BT"].StyleDisplay.BackColor=vs.Styles["LCK_BT"].BackColor;
			for(int i=0;i<rs.rows;i++)
			{
				if(rs.record(i,"BAS_BT")+""=="True")
				{
					vs.Cols[rs.record(i,"COL_NM")].AllowEditing=false;
					vs.Cols[rs.record(i,"COL_NM")].StyleDisplay.BackColor=vs.Styles["Lock"].BackColor;
				}

				vs.Cols[rs.record(i,"COL_NM")].Visible=true;;
			}
			Init_Color();
			vs.Cols.Frozen=vs.Cols["EMP_NM"].Index;
			vs.Cols["EMP_DW"].AllowEditing=false;
			vs.Cols["EMP_I1"].AllowEditing=false;
			vs.Cols["EMP_NM"].AllowEditing=false;
			vs.Cols["DEP_ID"].AllowEditing=false;
			vs.Cols["POS_ID"].AllowEditing=false;
			vs.Cols["LEV_ID"].AllowEditing=false;
			vs.Cols["INH_DT"].AllowEditing=false;

			vs.Cols["BLT_NM"].AllowEditing=false;
			vs.Cols["BLT_DT"].AllowEditing=false;
			vs.Cols["LST_NM"].AllowEditing=false;
			vs.Cols["LST_DT"].AllowEditing=false;		
			vs.Cols["INH_DT"].DataType=typeof(DateTime);
			vs.Cols["INH_DT"].Format=PublicFunction.GetOption("DATE");
			nav.ToolBar_Auto=false;
			vs.SelectionMode=C1.Win.C1FlexGrid.SelectionModeEnum.CellRange; 
			vs.AfterEdit+=new RowColEventHandler(vs_AfterEdit);
			vs.BeforeEdit+=new RowColEventHandler(vs_BeforeEdit);
			nav.TBarClick+=new ToolBarButtonClickEventHandler(nav_TBarClick);
		}


		
		private void Init_vs1()
		{
			nav1.cmd_save.Visible=nav1.cmd_delete.Visible=nav1.cmd_add.Visible=
				nav1.cmd_search.Visible=nav1.cmd_report.Visible=nav1.cmd_copy.Visible=false;
			PublicFunction.InitNav(this,vs1,nav1);	
			vs1.AfterRowColChange+=new RangeEventHandler(vs1_AfterRowColChange);
			nav1.ToolBar_Auto=false;
			nav1.TBarClick+=new ToolBarButtonClickEventHandler(nav1_TBarClick);
		}	
		private void Init_vs2()
		{
			vs2.Cols.Count=7;
			vs2.Rows.Count=1;
			vs2.Cols[1].Name="ITM_NM";
			vs2.Cols[1].AllowEditing=false;
			vs2.Styles.Add("a");
			vs2.Styles["a"].BackColor=Color.LemonChiffon;
			vs2.Cols[1].Style=vs2.Styles["a"];
			vs2.Cols[2].Name="VAL_Q1";
			vs2.Cols[2].DataType=typeof(double);
			vs2.Cols[2].Format="#,##0.00";
			vs2.Cols[3].Name="VAL_Q2";
			vs2.Cols[3].DataType=typeof(double);
			vs2.Cols[3].Format="#,##0.00";
			vs2.Cols[4].Name="ITM_FD";
			vs2.Cols[4].Visible=false;

			vs2.Cols[5].Name="VAL_Q3";
			vs2.Cols[5].DataType=typeof(double);
			vs2.Cols[5].Format="#,##0.00";
			vs2.Cols[5].Visible=false;

			vs2.Cols[6].Name="VAL_Q4";
			vs2.Cols[6].DataType=typeof(double);
			vs2.Cols[6].Format="#,##0.00";
			vs2.Cols[6].Visible=false;
		}	

		private void Init_vs3()
		{
			vs3.Cols.Count=7;
			vs3.Rows.Count=1;
			vs3.Cols[1].Name="ITM_NM";
			vs3.Cols[1].AllowEditing=false;
			vs3.Styles.Add("a");
			vs3.Styles["a"].BackColor=Color.LemonChiffon;
			vs3.Cols[1].Style=vs3.Styles["a"];
			vs3.Cols[2].Name="VAL_Q1";
			vs3.Cols[2].DataType=typeof(double);
			vs3.Cols[2].Format="#,##0.00";
			vs3.Cols[3].Name="VAL_Q2";
			vs3.Cols[3].DataType=typeof(double);
			vs3.Cols[3].Format="#,##0.00";
			vs3.Cols[4].Name="ITM_FD";
			vs3.Cols[4].Visible=false;

			vs3.Cols[5].Name="VAL_Q3";
			vs3.Cols[5].DataType=typeof(double);
			vs3.Cols[5].Format="#,##0.00";
			vs3.Cols[5].Visible=false;

			vs3.Cols[6].Name="VAL_Q4";
			vs3.Cols[6].DataType=typeof(double);
			vs3.Cols[6].Format="#,##0.00";
			vs3.Cols[6].Visible=false;
		}
		private void Init_Color()
		{
			nav.Lock=new ArrayList();
			nav.Lock.Add("EMP_I1");
			nav.Lock.Add("EMP_NM");		
			nav.Lock.Add("POS_ID");
			nav.Lock.Add("LEV_ID");
//			nav.Lock.Add("BLT_DT");
//			nav.Lock.Add("BLT_NM");
//			nav.Lock.Add("LST_DT");
//			nav.Lock.Add("LST_NM");
			nav.Lock.Add("SEQ_NO");
//			nav.Lock.Add("REA_DR");
			nav.Color_VS();
		}
		private void  Init_CB()
		{			
			string sql;			
			//Department
			sql=PublicFunction.GetDep(this.Tag+"");			
			vs.Cols["DEP_ID"].DataMap=PublicFunction.InitCBForVS(sql);						
			vs1.Cols["DEP_ID"].DataMap=PublicFunction.InitCBForVS(sql);						
			//Position
			sql="Select POS_ID,POS_NM from FILA07A";		
			vs.Cols["POS_ID"].DataMap=PublicFunction.InitCBForVS(sql);						
			vs1.Cols["POS_ID"].DataMap=PublicFunction.InitCBForVS(sql);						
			//Level
			sql="Select LEV_ID,LEV_NM from FILA19A";
			vs.Cols["LEV_ID"].DataMap=PublicFunction.InitCBForVS(sql);		
			vs1.Cols["POS_ID"].DataMap=PublicFunction.InitCBForVS(sql);		
			PublicFunction.InitCB(cb_LEV_ID,sql);

			sql="Select GRP_ID,GRP_NM from FILA08A";
			PublicFunction.InitCB(cb_GRP_ID,sql);	
			//Type Group
			sql="Select GRT_ID,GRT_NM from FILA09A";
			PublicFunction.InitCB(cb_GRT_ID,sql);	

			sql="Select TYP_ID,TYP_NM from FILA11A where  "+PublicFunction.Get_TYP(this.Tag,"");			
			PublicFunction.InitCB(cb_TYP_ID,sql);

			vs.Cols["INH_DT"].Format=vs1.Cols["INH_DT"].Format=PublicFunction.GetOption("DATE");
		}

		private void depvs1_AfterRowColChange(object sender, C1.Win.C1FlexGrid.RangeEventArgs e)
		{
			if(e.OldRange.r1!=e.NewRange.r1)
			{
				//Show_VS();
				if(p1.Visible)
				{
					if(txt1.Text!="")
						txt_KeyDown((object)txt1,new System.Windows.Forms.KeyEventArgs(Keys.Enter));
					else
					{
						if(txt2.Text!="")
							txt_KeyDown((object)txt2,new System.Windows.Forms.KeyEventArgs(Keys.Enter));
						else
							txt_KeyDown((object)txt1,new System.Windows.Forms.KeyEventArgs(Keys.Enter));
					} 
//					nav.Show_VS("b.DEP_ID=N'"+Dep.Get_Data("DEP_ID")+"' and (DEL_BT=0 or DEL_BT is null) and YYY_MM between "
//						+"N'"+dt.Text+"' and N'"+dt1.Text+"' and "+PublicFunction.Get_TYP(this.Tag,"") );
					for(int i=0;i<rsitem.rows;i++)
					{					
						vs.Cols[rsitem.record(i,"COL_NM")].Width=100;
					}
				}
				else
				{
					if(txt1.Text!="")
						txt_KeyDown((object)txt1,new System.Windows.Forms.KeyEventArgs(Keys.Enter));
					else
					{
						if(txt2.Text!="")
							txt_KeyDown((object)txt2,new System.Windows.Forms.KeyEventArgs(Keys.Enter));
						else
							txt_KeyDown((object)txt1,new System.Windows.Forms.KeyEventArgs(Keys.Enter));
					} 
//					nav1.Show_VS("DEP_ID=N'"+Dep.Get_Data("DEP_ID")+"' and (DEL_BT=0 or DEL_BT is null) and "+PublicFunction.Get_TYP(this.Tag,""));
//					Show_vs2();Show_vs3();
				}
			}
		}
		#endregion
		#region Show_vs
		private void Show_vs2()
		{				
			vs2.Rows.Count=1;
			if(vs1.Row<=0)
			{				
				return;
			}		
			vs2.Visible=false;
			string sql="Select * from FILD02A where EMP_ID=N'"+vs1.Rows[vs1.Row]["EMP_ID"]+"' and YYY_MM=N'"+
				dt.Text+"' and (SEQ_NO=1)";
			Func.RecordSet rs=new Func.RecordSet(sql,PublicFunction.C_con);
			sql="Select * from FILD02A where EMP_ID=N'"+vs1.Rows[vs1.Row]["EMP_ID"]+"' and YYY_MM=N'"+
				dt.Text+"' and (SEQ_NO=2)";
			Func.RecordSet rs1=new Func.RecordSet(sql,PublicFunction.C_con);

			sql="Select * from FILD02A where EMP_ID=N'"+vs1.Rows[vs1.Row]["EMP_ID"]+"' and YYY_MM=N'"+
				dt.Text+"' and (SEQ_NO=3)";
			Func.RecordSet rs2=new Func.RecordSet(sql,PublicFunction.C_con);

			sql="Select * from FILD02A where EMP_ID=N'"+vs1.Rows[vs1.Row]["EMP_ID"]+"' and YYY_MM=N'"+
				dt.Text+"' and (SEQ_NO=4)";
			Func.RecordSet rs3=new Func.RecordSet(sql,PublicFunction.C_con);
			for(int i=0;i<rsitem.rows;i++)
			{
				vs2.Rows.Count++;
				vs2.Rows[vs2.Rows.Count-1][0]=vs2.Rows.Count-1;
				vs2.Rows[vs2.Rows.Count-1]["ITM_FD"]= rsitem.record(i,"COL_NM");
				vs2.Rows[vs2.Rows.Count-1]["ITM_NM"]= rsitem.record(i,"COL_"+PublicFunction.L_Lag);
				if(rs.rows>0)
					vs2.Rows[vs2.Rows.Count-1]["VAL_Q1"]= rs.record(0,rsitem.record(i,"COL_NM"));
				if(rs1.rows>0)
					vs2.Rows[vs2.Rows.Count-1]["VAL_Q2"]= rs1.record(0,rsitem.record(i,"COL_NM"));

				if(rs2.rows>0)
				{
					vs2.Rows[vs2.Rows.Count-1]["VAL_Q3"]= rs2.record(0,rsitem.record(i,"COL_NM"));
					vs2.Cols["VAL_Q3"].Visible=true;
				}
				else
				{
					vs2.Cols["VAL_Q3"].Visible=false;
				}

				if(rs3.rows>0)
				{
					vs2.Rows[vs2.Rows.Count-1]["VAL_Q4"]= rs3.record(0,rsitem.record(i,"COL_NM"));
					vs2.Cols["VAL_Q4"].Visible=true;
				}
				else
				{
					vs2.Cols["VAL_Q4"].Visible=false;
				}
			}
			vs2.Visible=true;
			vs2.AutoSizeCols();
		}

		private void Show_vs3()
		{	
			vs3.Rows.Count=1;
			if(vs1.Row<=0)
			{				
				return;
			}	
			vs3.Visible=false;
			string sql="Select * from FILC06AA where EMP_ID=N'"+vs1.Rows[vs1.Row]["EMP_ID"]+"' and YYY_MM=N'"+
				dt.Text+"' and (SEQ_NO=1)";
			Func.RecordSet rs=new Func.RecordSet(sql,PublicFunction.C_con);
			sql="Select * from FILC06AA where EMP_ID=N'"+vs1.Rows[vs1.Row]["EMP_ID"]+"' and YYY_MM=N'"+
				dt.Text+"' and (SEQ_NO=2)";
			Func.RecordSet rs1=new Func.RecordSet(sql,PublicFunction.C_con);

			sql="Select * from FILC06AA where EMP_ID=N'"+vs1.Rows[vs1.Row]["EMP_ID"]+"' and YYY_MM=N'"+
				dt.Text+"' and (SEQ_NO=3)";
			Func.RecordSet rs2=new Func.RecordSet(sql,PublicFunction.C_con);

			sql="Select * from FILC06AA where EMP_ID=N'"+vs1.Rows[vs1.Row]["EMP_ID"]+"' and YYY_MM=N'"+
				dt.Text+"' and (SEQ_NO=4)";
			Func.RecordSet rs3=new Func.RecordSet(sql,PublicFunction.C_con);
			for(int i=15;i<rs.cols;i++)
			{
				vs3.Rows.Count++;
				vs3.Rows[vs3.Rows.Count-1][0]=vs3.Rows.Count-1;
//				vs3.Rows[vs3.Rows.Count-1]["ITM_FD"]= rs.Field(i);
				vs3.Rows[vs3.Rows.Count-1]["ITM_NM"]= T_String.GetDataFromSQL(PublicFunction.L_Lag,
					"SYS_LABEL_VS_ATT","NAME=N'frmTaMonthAddUp000"+ "_vs' and FNAME=N'"+ rs.Field(i)+"'");
				if(rs.rows>0)
					vs3.Rows[vs3.Rows.Count-1]["VAL_Q1"]= rs.record(0,i);
				if(rs1.rows>0)
					vs3.Rows[vs3.Rows.Count-1]["VAL_Q2"]= rs1.record(0,i);

				if(rs2.rows>0)
				{
					vs3.Rows[vs3.Rows.Count-1]["VAL_Q3"]= rs2.record(0,i);
					vs3.Cols["VAL_Q3"].Visible=true;
				}
				else
				{
					vs3.Cols["VAL_Q3"].Visible=false;
				}

				if(rs3.rows>0)
				{
					vs3.Rows[vs3.Rows.Count-1]["VAL_Q4"]= rs3.record(0,i);
					vs3.Cols["VAL_Q4"].Visible=true;
				}
				else
				{
					vs3.Cols["VAL_Q4"].Visible=false;
				}
			}
			vs3.AutoSizeCols();
			vs3.Visible=true;
		}
		#endregion
		#region Search	
		
		private void nav1_TBarClick(object sender, ToolBarButtonClickEventArgs e)
		{
			if (e.Button.Equals(nav1.cmd_refresh))
			{							
				if(txt1.Text!="")
					txt_KeyDown((object)txt1,new System.Windows.Forms.KeyEventArgs(Keys.Enter));
				else
				{
					if(txt2.Text!="")
						txt_KeyDown((object)txt2,new System.Windows.Forms.KeyEventArgs(Keys.Enter));
					else
						txt_KeyDown((object)txt1,new System.Windows.Forms.KeyEventArgs(Keys.Enter));
				}
				return;			
			}
			nav1.ToolBar_Click(e);
		}
		private void nav_TBarClick(object sender, ToolBarButtonClickEventArgs e)
		{
			if (e.Button.Equals(nav.cmd_refresh))
			{							
				if(txt1.Text!="")
					txt_KeyDown((object)txt1,new System.Windows.Forms.KeyEventArgs(Keys.Enter));
				else
				{
					if(txt2.Text!="")
						txt_KeyDown((object)txt2,new System.Windows.Forms.KeyEventArgs(Keys.Enter));
					else
						txt_KeyDown((object)txt1,new System.Windows.Forms.KeyEventArgs(Keys.Enter));
				}
				return;			
			}
			nav.ToolBar_Click(e);
		}	
		private void txt_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Enter)
			{
				string f;
				TextBox tam;
				if(sender.Equals(txt1))
					tam=txt1;
				else
					tam=txt2;				
				f=tam.Tag+"";
				if(f=="EMP_ID")
				{					
					f="a."+f;				
				}				
				string sql;				
				if(tam.Text+""!="")
					sql=f+" like N'%"+tam.Text+"%'";
				else
					sql="1=1";
				if(cmd_back.Visible==true)				
					sql=sql+" and  (DEL_BT=0 or DEL_BT is null) and b.DEP_ID in (Select DEP_ID  from SYS_SECURITY_DEP"+
						" where MNU_ID="+this.Tag+" and ALL_BT=1 and USER_ID=N'"+PublicFunction.A_UserID+"') and " + PublicFunction.Get_TYP(this.Tag,"");
				else
					sql=sql+" and  (DEL_BT=0 or DEL_BT is null) and DEP_ID in (Select DEP_ID  from SYS_SECURITY_DEP"+
						" where MNU_ID="+this.Tag+" and ALL_BT=1 and USER_ID=N'"+PublicFunction.A_UserID+"') and " + PublicFunction.Get_TYP(this.Tag,"");

				if(cmd_back.Visible==true)
				{
					//Kiem tra xem trong FILD02A co du nguoi do chua
					string thu;
					thu="Select a.EMP_ID,a.DEP_ID FROM FILB01A a LEFT OUTER JOIN FILA02A B ON a.DEP_ID=b.DEP_ID LEFT OUTER JOIN filb01ac c ON c.EMP_ID=a.EMP_ID Where " + sql +wh1();
					Func.RecordSet rs=new Func.RecordSet(thu,PublicFunction.C_con);
					if (rs!=null)
					{
						for(int i=0;i<rs.rows;i++)
						{			
							InsertData(rs.record(i,"EMP_ID")+"",PublicFunction.C_con,sql,(DateTime)dt.Value,(DateTime)dt1.Value,rs.record(i,"DEP_ID")+"");
						}
					}
					
					nav.Show_VS(sql+wh());	
					for(int i=0;i<rsitem.rows;i++)
					{					
						vs.Cols[rsitem.record(i,"COL_NM")].Width=100;
					}
				}
				else
				{
					nav1.Show_VS(sql+wh());	
					Show_vs2();
					Show_vs3();
				}											
			}
		}

		private string wh()
		{		
			 
			string sql="";
			int day=T_String.IsNullTo0(PublicFunction.GetOption("STARTDATESALARY")+"");

			if(day==0) day=1;
			DateTime dtt1=new DateTime(DateTime.Parse(dt.Value+"").Year,
				DateTime.Parse(dt.Value+"").Month,day);
			if (Dep.vs1.Row>0)
				 sql+=" and a.DEP_ID=N'"+Dep.Get_Data("DEP_ID")+"'"; 
							
			sql+=" and INH_DT<'"+ dtt1.AddMonths(1).ToString("yyyy/MM/dd")+"'";
			if (cmd_back.Visible==true)
				sql+=" and  (YYY_MM between '"+DateTime.Parse(dt.Value+"").ToString("yyyyMM") +"' and '"+DateTime.Parse(dt1.Value+"").ToString("yyyyMM") +"')";
			if(ck_GRP_ID.Checked)
				sql+=" and GRP_ID=N'"+cb_GRP_ID.SelectedValue+"'";
			
			if(ck_GRT_ID.Checked)
				sql+=" and GRT_ID=N'"+cb_GRT_ID.SelectedValue+"'";
			
			if(ck_LEV_ID.Checked)
				sql+=" and LEV_ID=N'"+cb_LEV_ID.SelectedValue+"'";
			if(ck_TYP_ID.Checked)
				sql+=" and TYP_ID=N'"+cb_TYP_ID.SelectedValue+"'";
			if(ck_type.Checked && cb_type.Text+""!="" && cmd_back.Visible==true)			
				sql+=" and SEQ_NO="+cb_type.Text+"";
			
			if(ck_VAT_BT.Checked)
				sql+=" and isnull(VAC_BT,0)=1";
//				sql+=" and (VAC_DT>'"+dtt1.ToString("yyyy/MM/dd")+"' and VAC_DT<='"+dtt1.AddMonths(1).ToString("yyyy/MM/dd")+"')";
			else
//				sql+=" and (VAC_DT>'"+dtt1.ToString("yyyy/MM/dd")+"' or VAC_DT is null) ";
			
			if(ck_NEW_BT.Checked)
				sql+=" and NEW_BT=0 or NEW_BT is null";
			
			return sql;
		}

		private string wh1()
		{		
			 
			string sql="";
			int day=T_String.IsNullTo0(PublicFunction.GetOption("STARTDATESALARY")+"");

			if(day==0) day=1;
			DateTime dtt1=new DateTime(DateTime.Parse(dt.Value+"").Year,
				DateTime.Parse(dt.Value+"").Month,day);
			if (Dep.vs1.Row>0)
				sql+=" and a.DEP_ID=N'"+Dep.Get_Data("DEP_ID")+"'"; 
							
			sql+=" and INH_DT<'"+ dtt1.AddMonths(1).ToString("yyyy/MM/dd")+"'";

			if(ck_GRP_ID.Checked)
				sql+=" and GRP_ID=N'"+cb_GRP_ID.SelectedValue+"'";
			
			if(ck_GRT_ID.Checked)
				sql+=" and GRT_ID=N'"+cb_GRT_ID.SelectedValue+"'";
			
			if(ck_LEV_ID.Checked)
				sql+=" and LEV_ID=N'"+cb_LEV_ID.SelectedValue+"'";
			
			if(ck_TYP_ID.Checked)
				sql+=" and TYP_ID=N'"+cb_TYP_ID.SelectedValue+"'";
			
//			if(ck_type.Checked && cb_type.Text+""!="" && cmd_back.Visible==true)			
//				sql+=" and SEQ_NO="+cb_type.Text+"";

			if(ck_VAT_BT.Checked)
				sql+=" and (VAC_DT>'"+dtt1.ToString("yyyy/MM/dd")+"' and VAC_DT<='"+dtt1.AddMonths(1).ToString("yyyy/MM/dd")+"')";
			else
				sql+=" and (VAC_DT>'"+dtt1.ToString("yyyy/MM/dd")+"' or VAC_DT is null) ";
			
			if(ck_NEW_BT.Checked)
				sql+=" and NEW_BT=0 or NEW_BT is null";
			
			return sql;
		}
		#endregion	
		#region Event
		private void vs_EnabledChanged(object sender, EventArgs e)
		{			
			string sql="Select * from FILD01A ";			
			Func.RecordSet rs=new Func.RecordSet(sql,PublicFunction.C_con);
			for(int i=0;i<rs.rows;i++)
			{
				try
				{
					vs.Cols[rs.record(i,"COL_NM")].Caption=rs.record(i,"COL_"+PublicFunction.L_Lag);
				}
				catch{}
			}
			vs.AutoSizeCols();
		}

		private void cmd_quick_Click(object sender, System.EventArgs e)
		{
			cmd_back.Visible=true;
			cmd_quick.Visible=false;
			p1.Visible=!cmd_quick.Visible;
			p2.Visible=!cmd_back.Visible;
			p1.Dock=DockStyle.Fill;
			p2.Dock=DockStyle.Fill;
			dt1.Enabled=true;
			nav1.Visible=false;
			nav.Visible=true;
		}

		private void cmd_back_Click(object sender, System.EventArgs e)
		{
			cmd_back.Visible=false;
			cmd_quick.Visible=true;
			p1.Visible=!cmd_quick.Visible;
			p2.Visible=!cmd_back.Visible;
			p1.Dock=DockStyle.Fill;
			p2.Dock=DockStyle.Fill;
			dt1.Enabled=false;
			nav.Visible=false;
			nav1.Visible=true;
		}

		private void vs1_AfterRowColChange(object sender, RangeEventArgs e)
		{
			if(e.OldRange.r1!=e.NewRange.r1)
				Show_vs2();Show_vs3();
		}

		private void ck_LEV_ID_CheckedChanged(object sender, System.EventArgs e)
		{
			cb_LEV_ID.Enabled=ck_LEV_ID.Checked;
		}

		private void ck_GRP_ID_CheckedChanged(object sender, System.EventArgs e)
		{
			cb_GRP_ID.Enabled=ck_GRP_ID.Checked;
		}

		private void ck_GRT_ID_CheckedChanged(object sender, System.EventArgs e)
		{
			cb_GRT_ID.Enabled=ck_GRT_ID.Checked;
		}

		private void ck_TYP_ID_CheckedChanged(object sender, System.EventArgs e)
		{
			cb_TYP_ID.Enabled=ck_TYP_ID.Checked;
		}
		#endregion

		private void cmd_excel_Click(object sender, System.EventArgs e)
		{
			frmTaExcel dlg=new frmTaExcel();
			dlg.Tag=this.Tag;
			dlg.ShowDialog();

		}

		private void cmd_input_Click(object sender, System.EventArgs e)
		{
			frmTaPieceRateInput dlg=new frmTaPieceRateInput();
			dlg.Tag=this.Tag;
			dlg.ShowDialog();
		}

		private void vs_AfterEdit(object sender, RowColEventArgs e)
		{
			string dt=T_String.GetDate().ToString("yyyy/MM/dd HH:mm");
			for (int i=vs.Selection.r1;i<=vs.Selection.r2;i++)
			{
				if (vs.Rows[i]["LCK_BT"]+""!="True")
				{
					for (int j=vs.Selection.c1;j<=vs.Selection.c2;j++)
					{
						if (vs.Cols[j].AllowEditing && vs.Rows[i]["LCK_BT"]+""!="True")
						{						
							vs[i,j ]=vs[e.Row,e.Col];										
						}
					}
					vs.Rows[i].UserData=1;		
					vs.Rows[i]["LST_NM"]=PublicFunction.A_UserID;
					vs.Rows[i]["LST_DT"]=dt;
				}
			}
		}

		private void vs_BeforeEdit(object sender, RowColEventArgs e)
		{
			if(vs.Rows[vs.Row]["LCK_BT"]+""=="True")
			{
				if(vs.Cols[e.Col].Name!="LCK_BT" || PublicFunction.A_UserID!=vs.Rows[e.Row]["LST_NM"]+"")
					e.Cancel=true;
			}
		}

		private void cmd_transfer_Click(object sender, System.EventArgs e)
		{
			frmTaTransferSalary dlg=new frmTaTransferSalary();
			dlg.Tag=this.Tag;
			dlg.ShowDialog();
		}

		private void ck_type_CheckedChanged(object sender, System.EventArgs e)
		{
			cb_type.Enabled=ck_type.Checked;
		}

		private void dt_ValueChanged(object sender, System.EventArgs e)
		{
			dt1.Value=dt.Value;
		}

		private void panel2_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}
		
		public static void InsertData(string EMP_ID,SqlConnection con,string chuoiketnoi,DateTime fromdate,DateTime todate,String dept)
		{
			while(T_String.IsNullTo0(fromdate.ToString("yyyyMM"))<=T_String.IsNullTo0(todate.ToString("yyyyMM")))// tung Ngay
			{
				string salary="select * from FILD02A Where EMP_ID='"+ EMP_ID +"' AND SEQ_NO=2 AND YYY_MM = '"+fromdate.ToString("yyyyMM") +"'";
				Func.RecordSet rssalary=new Func.RecordSet(salary,PublicFunction.C_con);
				if (rssalary.rows==0)
				{
					string insertsalary="insert into FILD02A(EMP_ID,YYY_MM,SEQ_NO,DEP_ID) values ('"+ EMP_ID +"','"+fromdate.ToString("yyyyMM")+"','2','"+ dept +"')";
					PublicFunction.SQL_Execute(insertsalary,con);
				}
				fromdate=fromdate.AddMonths(1);
			}
		}


	}
}

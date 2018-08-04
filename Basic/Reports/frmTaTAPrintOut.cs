using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Basic.Form;
using Basic.Function;
namespace GP8000.Reports
{
	/// <summary>
	/// Summary description for frmTaTAPrintOut.
	/// </summary>
	public class frmTaTAPrintOut : System.Windows.Forms.Form
	{
		private C1.Win.C1Command.C1DockingTab c1DockingTab1;
		private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage1;
		private C1.Win.C1Command.C1CommandDock c1CommandDock1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_RPT_DR;
		private C1.Win.C1FlexGrid.C1FlexGrid vs;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Panel panel3;
		private Navigator1._0.NavigatorAuto nav;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel p;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Panel panel5;
		private C1.Win.C1FlexGrid.C1FlexGrid vs2;
		private Navigator1._0.NavigatorAuto nav2;
		private System.Windows.Forms.Splitter splitter3;
		private System.Windows.Forms.Panel panel7;
		private Navigator1._0.NavigatorAuto nav1;
		private C1.Win.C1FlexGrid.C1FlexGrid vs1;
		private GP8000.UserControl.CrtTaCondition1 control1;
		private C1.Win.C1Input.C1DateEdit dt2;
		private C1.Win.C1Input.C1DateEdit dt1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.Button cmd_print;
		private System.Windows.Forms.Button cmd_close;
		private System.Windows.Forms.CheckBox ck;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaTAPrintOut()
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
			this.txt_RPT_DR = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.c1DockingTab1 = new C1.Win.C1Command.C1DockingTab();
			this.c1DockingTabPage1 = new C1.Win.C1Command.C1DockingTabPage();
			this.vs = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.c1CommandDock1 = new C1.Win.C1Command.C1CommandDock();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.nav = new Navigator1._0.NavigatorAuto();
			this.label5 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.p = new System.Windows.Forms.Panel();
			this.panel8 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.vs2 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.nav2 = new Navigator1._0.NavigatorAuto();
			this.splitter3 = new System.Windows.Forms.Splitter();
			this.panel7 = new System.Windows.Forms.Panel();
			this.nav1 = new Navigator1._0.NavigatorAuto();
			this.vs1 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.panel6 = new System.Windows.Forms.Panel();
			this.cmd_close = new System.Windows.Forms.Button();
			this.cmd_print = new System.Windows.Forms.Button();
			this.panel9 = new System.Windows.Forms.Panel();
			this.control1 = new GP8000.UserControl.CrtTaCondition1();
			this.dt1 = new C1.Win.C1Input.C1DateEdit();
			this.dt2 = new C1.Win.C1Input.C1DateEdit();
			this.ck = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.panel2 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).BeginInit();
			this.c1DockingTab1.SuspendLayout();
			this.c1DockingTabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandDock1)).BeginInit();
			this.c1CommandDock1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel4.SuspendLayout();
			this.p.SuspendLayout();
			this.panel8.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs2)).BeginInit();
			this.panel7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs1)).BeginInit();
			this.panel6.SuspendLayout();
			this.panel9.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dt1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dt2)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// txt_RPT_DR
			// 
			this.txt_RPT_DR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.txt_RPT_DR.BackColor = System.Drawing.SystemColors.Window;
			this.txt_RPT_DR.Location = new System.Drawing.Point(104, 12);
			this.txt_RPT_DR.MaxLength = 200;
			this.txt_RPT_DR.Name = "txt_RPT_DR";
			this.txt_RPT_DR.Size = new System.Drawing.Size(596, 23);
			this.txt_RPT_DR.TabIndex = 1;
			this.txt_RPT_DR.Tag = "RPT_DR";
			this.txt_RPT_DR.Text = "textBox1";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(4, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "label1";
			// 
			// c1DockingTab1
			// 
			this.c1DockingTab1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
			this.c1DockingTab1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.c1DockingTab1.CanAutoHide = true;
			this.c1DockingTab1.CanMoveTabs = true;
			this.c1DockingTab1.Controls.Add(this.c1DockingTabPage1);
			this.c1DockingTab1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.c1DockingTab1.Location = new System.Drawing.Point(0, 0);
			this.c1DockingTab1.Name = "c1DockingTab1";
			this.c1DockingTab1.SelectedIndex = 0;
			this.c1DockingTab1.ShowCaption = true;
			this.c1DockingTab1.ShowSingleTab = false;
			this.c1DockingTab1.Size = new System.Drawing.Size(240, 600);
			this.c1DockingTab1.TabIndex = 0;
			this.c1DockingTab1.TabSizeMode = C1.Win.C1Command.TabSizeModeEnum.Fit;
			this.c1DockingTab1.TabStyle = C1.Win.C1Command.TabStyleEnum.WindowsXP;
			// 
			// c1DockingTabPage1
			// 
			this.c1DockingTabPage1.Controls.Add(this.vs);
			this.c1DockingTabPage1.ImageIndex = -1;
			this.c1DockingTabPage1.Location = new System.Drawing.Point(1, 1);
			this.c1DockingTabPage1.Name = "c1DockingTabPage1";
			this.c1DockingTabPage1.Size = new System.Drawing.Size(235, 598);
			this.c1DockingTabPage1.TabIndex = 0;
			this.c1DockingTabPage1.Text = "Page1";
			// 
			// vs
			// 
			this.vs.AllowEditing = false;
			this.vs.AutoResize = false;
			this.vs.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vs.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs.Location = new System.Drawing.Point(0, 23);
			this.vs.Name = "vs";
			this.vs.Size = new System.Drawing.Size(235, 575);
			this.vs.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs.TabIndex = 13;
			// 
			// c1CommandDock1
			// 
			this.c1CommandDock1.Controls.Add(this.c1DockingTab1);
			this.c1CommandDock1.Dock = System.Windows.Forms.DockStyle.Left;
			this.c1CommandDock1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.c1CommandDock1.Id = 1;
			this.c1CommandDock1.Location = new System.Drawing.Point(0, 0);
			this.c1CommandDock1.Name = "c1CommandDock1";
			this.c1CommandDock1.Size = new System.Drawing.Size(240, 600);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.txt_RPT_DR);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(4, -4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(704, 40);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Tag = "N";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.panel3.Controls.Add(this.nav);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panel3.Location = new System.Drawing.Point(240, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(708, 32);
			this.panel3.TabIndex = 12;
			// 
			// nav
			// 
			this.nav.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.nav.Connection = null;
			this.nav.ConnectionDel = null;
			this.nav.Dock = System.Windows.Forms.DockStyle.Left;
			this.nav.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.nav.ForeColor = System.Drawing.Color.Black;
			this.nav.form = null;
			this.nav.FormName = null;
			this.nav.Grid = null;
			this.nav.History = false;
			this.nav.IsNull = true;
			this.nav.Language = "EN";
			this.nav.Location = new System.Drawing.Point(0, 0);
			this.nav.MSG_Exit = false;
			this.nav.MulltiDel = false;
			this.nav.Name = "nav";
			this.nav.Security = 0;
			this.nav.ShowPopupMenu = true;
			this.nav.Size = new System.Drawing.Size(292, 32);
			this.nav.TabIndex = 28;
			this.nav.Tag = "";
			this.nav.ToolBar_Auto = true;
			this.nav.UserID = null;
			this.nav.VisibleGrid = true;
			this.nav.Where = null;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Location = new System.Drawing.Point(0, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(708, 32);
			this.label5.TabIndex = 11;
			this.label5.Tag = "N";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Controls.Add(this.splitter1);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(240, 32);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(708, 568);
			this.panel1.TabIndex = 13;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.p);
			this.panel4.Controls.Add(this.panel6);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(0, 43);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(708, 525);
			this.panel4.TabIndex = 12;
			// 
			// p
			// 
			this.p.Controls.Add(this.panel8);
			this.p.Controls.Add(this.splitter3);
			this.p.Controls.Add(this.panel7);
			this.p.Dock = System.Windows.Forms.DockStyle.Fill;
			this.p.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.p.Location = new System.Drawing.Point(0, 0);
			this.p.Name = "p";
			this.p.Size = new System.Drawing.Size(708, 309);
			this.p.TabIndex = 2;
			// 
			// panel8
			// 
			this.panel8.Controls.Add(this.panel5);
			this.panel8.Controls.Add(this.nav2);
			this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panel8.Location = new System.Drawing.Point(283, 0);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(425, 309);
			this.panel8.TabIndex = 2;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.vs2);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(0, 32);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(425, 277);
			this.panel5.TabIndex = 31;
			// 
			// vs2
			// 
			this.vs2.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.Both;
			this.vs2.AutoResize = false;
			this.vs2.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs2.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vs2.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs2.Location = new System.Drawing.Point(0, 0);
			this.vs2.Name = "vs2";
			this.vs2.Size = new System.Drawing.Size(425, 277);
			this.vs2.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs2.TabIndex = 15;
			// 
			// nav2
			// 
			this.nav2.BackColor = System.Drawing.SystemColors.Control;
			this.nav2.Connection = null;
			this.nav2.ConnectionDel = null;
			this.nav2.Dock = System.Windows.Forms.DockStyle.Top;
			this.nav2.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.nav2.ForeColor = System.Drawing.Color.Black;
			this.nav2.form = null;
			this.nav2.FormName = null;
			this.nav2.Grid = null;
			this.nav2.History = false;
			this.nav2.IsNull = true;
			this.nav2.Language = "EN";
			this.nav2.Location = new System.Drawing.Point(0, 0);
			this.nav2.MSG_Exit = false;
			this.nav2.MulltiDel = false;
			this.nav2.Name = "nav2";
			this.nav2.Security = 0;
			this.nav2.ShowPopupMenu = true;
			this.nav2.Size = new System.Drawing.Size(425, 32);
			this.nav2.TabIndex = 30;
			this.nav2.Tag = "";
			this.nav2.ToolBar_Auto = true;
			this.nav2.UserID = null;
			this.nav2.VisibleGrid = true;
			this.nav2.Where = null;
			// 
			// splitter3
			// 
			this.splitter3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.splitter3.Location = new System.Drawing.Point(280, 0);
			this.splitter3.Name = "splitter3";
			this.splitter3.Size = new System.Drawing.Size(3, 309);
			this.splitter3.TabIndex = 1;
			this.splitter3.TabStop = false;
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.nav1);
			this.panel7.Controls.Add(this.vs1);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(280, 309);
			this.panel7.TabIndex = 0;
			// 
			// nav1
			// 
			this.nav1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.nav1.Connection = null;
			this.nav1.ConnectionDel = null;
			this.nav1.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.nav1.ForeColor = System.Drawing.Color.Black;
			this.nav1.form = null;
			this.nav1.FormName = null;
			this.nav1.Grid = null;
			this.nav1.History = false;
			this.nav1.IsNull = true;
			this.nav1.Language = "EN";
			this.nav1.Location = new System.Drawing.Point(-6, 0);
			this.nav1.MSG_Exit = false;
			this.nav1.MulltiDel = false;
			this.nav1.Name = "nav1";
			this.nav1.Security = 0;
			this.nav1.ShowPopupMenu = true;
			this.nav1.Size = new System.Drawing.Size(292, 32);
			this.nav1.TabIndex = 29;
			this.nav1.Tag = "";
			this.nav1.ToolBar_Auto = true;
			this.nav1.UserID = null;
			this.nav1.Visible = false;
			this.nav1.VisibleGrid = true;
			this.nav1.Where = null;
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
			this.vs1.Size = new System.Drawing.Size(280, 309);
			this.vs1.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs1.TabIndex = 14;
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.cmd_close);
			this.panel6.Controls.Add(this.cmd_print);
			this.panel6.Controls.Add(this.panel9);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel6.Location = new System.Drawing.Point(0, 309);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(708, 216);
			this.panel6.TabIndex = 1;
			// 
			// cmd_close
			// 
			this.cmd_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cmd_close.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_close.Location = new System.Drawing.Point(392, 176);
			this.cmd_close.Name = "cmd_close";
			this.cmd_close.Size = new System.Drawing.Size(92, 32);
			this.cmd_close.TabIndex = 169;
			this.cmd_close.Text = "button2";
			// 
			// cmd_print
			// 
			this.cmd_print.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_print.Location = new System.Drawing.Point(224, 176);
			this.cmd_print.Name = "cmd_print";
			this.cmd_print.Size = new System.Drawing.Size(92, 32);
			this.cmd_print.TabIndex = 168;
			this.cmd_print.Text = "button1";
			this.cmd_print.Click += new System.EventHandler(this.cmd_print_Click);
			// 
			// panel9
			// 
			this.panel9.Controls.Add(this.control1);
			this.panel9.Controls.Add(this.dt1);
			this.panel9.Controls.Add(this.dt2);
			this.panel9.Controls.Add(this.ck);
			this.panel9.Controls.Add(this.label2);
			this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel9.Location = new System.Drawing.Point(0, 0);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(708, 168);
			this.panel9.TabIndex = 167;
			// 
			// control1
			// 
			this.control1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.control1.Location = new System.Drawing.Point(4, 0);
			this.control1.Name = "control1";
			this.control1.Size = new System.Drawing.Size(444, 164);
			this.control1.TabIndex = 1;
			// 
			// dt1
			// 
			this.dt1.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt1.Location = new System.Drawing.Point(544, 16);
			this.dt1.Name = "dt1";
			this.dt1.Size = new System.Drawing.Size(132, 23);
			this.dt1.TabIndex = 164;
			this.dt1.Tag = null;
			// 
			// dt2
			// 
			this.dt2.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt2.Location = new System.Drawing.Point(544, 44);
			this.dt2.Name = "dt2";
			this.dt2.Size = new System.Drawing.Size(132, 23);
			this.dt2.TabIndex = 165;
			this.dt2.Tag = null;
			// 
			// ck
			// 
			this.ck.Checked = true;
			this.ck.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ck.Location = new System.Drawing.Point(456, 12);
			this.ck.Name = "ck";
			this.ck.Size = new System.Drawing.Size(92, 28);
			this.ck.TabIndex = 2;
			this.ck.Text = "checkBox1";
			this.ck.CheckedChanged += new System.EventHandler(this.ck_CheckedChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(460, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 20);
			this.label2.TabIndex = 166;
			this.label2.Text = "label2";
			// 
			// splitter1
			// 
			this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
			this.splitter1.Location = new System.Drawing.Point(0, 40);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(708, 3);
			this.splitter1.TabIndex = 11;
			this.splitter1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.groupBox1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(708, 40);
			this.panel2.TabIndex = 10;
			// 
			// frmTaTAPrintOut
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(948, 600);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.c1CommandDock1);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaTAPrintOut";
			this.Text = "frmTaTAPrintOut";
			this.Load += new System.EventHandler(this.frmTaTAPrintOut_Load);
			((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).EndInit();
			this.c1DockingTab1.ResumeLayout(false);
			this.c1DockingTabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandDock1)).EndInit();
			this.c1CommandDock1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.p.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs2)).EndInit();
			this.panel7.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs1)).EndInit();
			this.panel6.ResumeLayout(false);
			this.panel9.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dt1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dt2)).EndInit();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaTAPrintOut_Load(object sender, System.EventArgs e)
		{
			control1.InitCB(this.Tag);
			control1.Initlabel();	
			Init_Form();	
			dt2.Value=dt1.Value=T_String.GetDate();				
			dt1.CustomFormat=dt2.CustomFormat=PublicFunction.GetOption("DATE");	
			PublicFunction.SQL_Execute("Delete from FILE07B where RPT_ID not in(select RPT_ID from FILE07A )");		
		}
		#region Init
		private void Init_Form()
		{		
//			dt.Value=T_String.GetDate();
			Init_vs();			
			Init_vs1();
			Init_vs2();
			show_data();
			Basic.Function.PublicFunction.L_Init_Label(this);				
		}

		private void Init_vs()
		{		
			nav.cmd_copy.Visible=false;
			nav.cmd_report.Visible=false;
			nav.cmd_search.Visible=false;			
			PublicFunction.InitNav(this,vs,nav);	
			nav.Show_VS();						
			nav.ToolBar_Auto=false;
			nav.TBarClick+=new ToolBarButtonClickEventHandler(nav_TBarClick);		
			vs.AfterRowColChange+=new C1.Win.C1FlexGrid.RangeEventHandler(vs_AfterRowColChange);
		}
		private void Init_vs1()
		{			
			PublicFunction.InitNav(this,vs1,nav1);	
			vs1.DoubleClick+=new EventHandler(vs1_DoubleClick);
			nav1.Show_VS("TAA_PR=1");			
		}
		private void Init_vs2()
		{			
			nav2.cmd_copy.Visible=false;
			nav2.cmd_report.Visible=false;
			nav2.cmd_search.Visible=false;			
			nav2.cmd_add.Visible=false;			
			nav2.cmd_exit.Visible=false;			
			PublicFunction.InitNav(this,vs2,nav2);	
			vs2.Cols["CON_C1"].ComboList=vs2.Cols["CON_C2"].ComboList="=|>|>=|<|<=|like";
			vs2.Cols["AND_OR"].ComboList="AND|OR";
			nav2.Show_VS();		
			nav2.ToolBar_Auto=false;
			nav2.TBarClick+=new ToolBarButtonClickEventHandler(nav2_TBarClick);		
		}
		#endregion

		private void show_data()
		{
			TextBoxAndVS.D_GetDataFromVS(groupBox1,vs);	
			if(vs.Row<1)
			{
				vs2.Rows.Count=1;
				return;
			}
			nav2.Show_VS("RPT_ID='"+vs.Rows[vs.Row]["RPT_ID"]+"' order by SEQ_NO");
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
			if (e.Button.Equals(nav.cmd_add))
			{			
				if (vs.Rows.Count==1 || (int)vs.Rows[vs.Rows.Count-1].UserData!=2)					
					nav.ToolBar_Click(e);					
				TextBoxAndVS.D_AddNewOrEdit(groupBox1,false);								
				return;
			}
			if (e.Button.Equals(nav.cmd_save))
			{
				try
				{
					TextBoxAndVS.D_GetDataFromTextBox(groupBox1,vs);				
					if ((int)vs.Rows[vs.Row].UserData!=2)
						vs.Rows[vs.Row].UserData=1;		
					else
					{
						vs.Rows[vs.Row]["RPT_ID"]=T_String.GetMax("MAX(RPT_ID)","FILE07A")+"";

						vs2.Rows.Count++;
						int row=vs2.Rows.Count-1;
						vs2.Rows[row].UserData=2;
						vs2.Rows[row][0]=row;
						vs2.Rows[row]["SEQ_NO"]=row.ToString("000");
						vs2.Rows[row]["RPT_ID"]=vs.Rows[vs.Row]["RPT_ID"];
						vs2.Rows[row]["COL_ID"]="EMP_ID";
						vs2.Rows[row]["COL_NM"]="WID";		
						vs2.Rows[row]["TAB_DR"]="FILB01A";	
						vs2.Rows[row]["SHO_BT"]=1;
						vs2.Rows[row]["WID_VL"]=80;
						nav2.SaveRow(row);

						vs2.Rows.Count++;
						row=vs2.Rows.Count-1;
						vs2.Rows[row].UserData=2;
						vs2.Rows[row][0]=row;
						vs2.Rows[row]["SEQ_NO"]=row.ToString("000");
						vs2.Rows[row]["RPT_ID"]=vs.Rows[vs.Row]["RPT_ID"];
						vs2.Rows[row]["COL_ID"]="EMP_NM";
						vs2.Rows[row]["COL_NM"]="Name";
						vs2.Rows[row]["TAB_DR"]="FILB01A";	
						vs2.Rows[row]["SHO_BT"]=1;
						vs2.Rows[row]["WID_VL"]=80;
						nav2.SaveRow(row);
						vs2.AutoSizeCols();
					
					}
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

		private void nav2_TBarClick(object sender, ToolBarButtonClickEventArgs e)
		{			
			if (e.Button.Equals(nav2.cmd_save))
			{
				for (int i=1;i<vs2.Rows.Count;i++)
				{
					vs2.Rows[i]["SEQ_NO"]=i.ToString("000");
					if (vs2.Rows[i].UserData+""!="2")					
						vs2.Rows[i].UserData=1;		
					nav2.SaveRow(i);
				}				
			}		
			nav2.ToolBar_Click(e);							
		}

		private void vs1_DoubleClick(object sender, EventArgs e)
		{
			if(vs1.Row>0 && vs.Row>0)
			{
				for(int i=1;i<vs2.Rows.Count;i++)
				{
					if(vs2.Rows[i]["COL_ID"]==vs1.Rows[vs1.Row]["COL_ID"])
						return;
				}
				vs2.Rows.Count++;
				int row=vs2.Rows.Count-1;
				vs2.Rows[row].UserData=2;
				vs2.Rows[row][0]=row;
				vs2.Rows[row]["SEQ_NO"]=row.ToString("000");
				vs2.Rows[row]["RPT_ID"]=vs.Rows[vs.Row]["RPT_ID"];
				vs2.Rows[row]["COL_ID"]=vs1.Rows[vs1.Row]["COL_ID"];
				vs2.Rows[row]["COL_NM"]=vs1.Rows[vs1.Row]["COL_NM"];
				vs2.Rows[row]["TAB_DR"]=vs1.Rows[vs1.Row]["TAB_DR"];	
				vs2.Rows[row]["TYP_ID"]=vs1.Rows[vs1.Row]["TYP_ID"];	
				vs2.Rows[row]["SHO_BT"]=1;
				vs2.Rows[row]["WID_VL"]=80;
				vs2.AutoSizeCols();
			}
		}

		private void ck_CheckedChanged(object sender, System.EventArgs e)
		{
			dt1.Enabled=dt2.Enabled=ck.Checked;
		}

		private void cmd_print_Click(object sender, System.EventArgs e)
		{
			if(vs.Row>0)
			{
				C1.C1Excel.C1XLBook c1XLBook1=new C1.C1Excel.C1XLBook();		
				GP8000.Personnel.Report.ReportFromVS rpt=new GP8000.Personnel.Report.ReportFromVS();
				string wh="";
				wh=control1.GetWhere("FILB01A",true);
				if(ck.Checked)
				{
					if(wh!="") wh+=" and ";
					wh+=" (ATT_DT between '"+DateTime.Parse(dt1.Value+"").ToString("yyyy/MM/dd")+"' and '"
						+DateTime.Parse(dt2.Value+"").ToString("yyyy/MM/dd")+"')";

				}
				rpt.RPTta(c1XLBook1,vs.Rows[vs.Row]["RPT_ID"]+"",vs.Rows[vs.Row]["RPT_DR"]+"",wh);					
			}	
		}

		
	}
}

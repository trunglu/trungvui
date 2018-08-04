using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Basic.Form;
using Basic.Function;
using System.Data;
using System.Data.SqlClient;


namespace GP8000.GPS
{
	/// <summary>
	/// Summary description for frmTaSchedule.
	/// </summary>
	public class frmTaSchedule : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Panel panel5;
		private C1.Win.C1Command.C1DockingTab c1DockingTab2;
		private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage2;
		private System.Windows.Forms.Panel p3;
		private System.Windows.Forms.Panel panel11;
		private System.Windows.Forms.Panel p31;
		private System.Windows.Forms.Button button2;
		private C1.Win.C1Input.C1DateEdit dt3;
		private Navigator1._0.NavigatorAuto nav3;
		private System.Windows.Forms.Panel p2;
		private System.Windows.Forms.Panel panel7;
		private Navigator1._0.NavigatorAuto nav4;
		private System.Windows.Forms.Panel p1;
		private C1.Win.C1FlexGrid.C1FlexGrid vs;
		private System.Windows.Forms.Panel panel15;
		private System.Windows.Forms.Button cmd_show;
		private C1.Win.C1Input.C1DateEdit dt1;
		private System.Windows.Forms.Label label1;
		private Navigator1._0.NavigatorAuto nav;
		private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage3;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.Panel panel14;
		private C1.Win.C1FlexGrid.C1FlexGrid vs2;
		private Navigator1._0.NavigatorAuto nav2;
		private System.Windows.Forms.Splitter splitter2;
		private System.Windows.Forms.Panel panel12;
		private C1.Win.C1FlexGrid.C1FlexGrid vs1;
		private Navigator1._0.NavigatorAuto nav1;
		private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage1;
		private System.Windows.Forms.Panel panel10;
		private C1.Win.C1FlexGrid.C1FlexGrid vs5;
		private Navigator1._0.NavigatorAuto nav5;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label l;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.RadioButton r2;
		private System.Windows.Forms.RadioButton r1;
		private C1.Win.C1FlexGrid.C1FlexGrid vs3;
		private C1.Win.C1FlexGrid.C1FlexGrid vs4;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaSchedule()
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel8 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.c1DockingTab2 = new C1.Win.C1Command.C1DockingTab();
			this.c1DockingTabPage2 = new C1.Win.C1Command.C1DockingTabPage();
			this.p3 = new System.Windows.Forms.Panel();
			this.panel11 = new System.Windows.Forms.Panel();
			this.p31 = new System.Windows.Forms.Panel();
			this.button2 = new System.Windows.Forms.Button();
			this.dt3 = new C1.Win.C1Input.C1DateEdit();
			this.nav3 = new Navigator1._0.NavigatorAuto();
			this.p2 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.nav4 = new Navigator1._0.NavigatorAuto();
			this.p1 = new System.Windows.Forms.Panel();
			this.vs = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.panel15 = new System.Windows.Forms.Panel();
			this.cmd_show = new System.Windows.Forms.Button();
			this.dt1 = new C1.Win.C1Input.C1DateEdit();
			this.label1 = new System.Windows.Forms.Label();
			this.nav = new Navigator1._0.NavigatorAuto();
			this.c1DockingTabPage3 = new C1.Win.C1Command.C1DockingTabPage();
			this.panel9 = new System.Windows.Forms.Panel();
			this.panel14 = new System.Windows.Forms.Panel();
			this.vs2 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.nav2 = new Navigator1._0.NavigatorAuto();
			this.splitter2 = new System.Windows.Forms.Splitter();
			this.panel12 = new System.Windows.Forms.Panel();
			this.vs1 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.nav1 = new Navigator1._0.NavigatorAuto();
			this.c1DockingTabPage1 = new C1.Win.C1Command.C1DockingTabPage();
			this.panel10 = new System.Windows.Forms.Panel();
			this.vs5 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.nav5 = new Navigator1._0.NavigatorAuto();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.panel2 = new System.Windows.Forms.Panel();
			this.l = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.r2 = new System.Windows.Forms.RadioButton();
			this.r1 = new System.Windows.Forms.RadioButton();
			this.vs3 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.vs4 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.panel1.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel8.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1DockingTab2)).BeginInit();
			this.c1DockingTab2.SuspendLayout();
			this.c1DockingTabPage2.SuspendLayout();
			this.p3.SuspendLayout();
			this.panel11.SuspendLayout();
			this.p31.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dt3)).BeginInit();
			this.p2.SuspendLayout();
			this.panel7.SuspendLayout();
			this.p1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
			this.panel15.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dt1)).BeginInit();
			this.c1DockingTabPage3.SuspendLayout();
			this.panel9.SuspendLayout();
			this.panel14.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs2)).BeginInit();
			this.panel12.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs1)).BeginInit();
			this.c1DockingTabPage1.SuspendLayout();
			this.panel10.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs5)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vs4)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(720, 718);
			this.panel1.TabIndex = 11;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.panel6);
			this.panel4.Controls.Add(this.splitter1);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panel4.Location = new System.Drawing.Point(0, 36);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(720, 682);
			this.panel4.TabIndex = 1;
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.panel8);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel6.Location = new System.Drawing.Point(0, 3);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(720, 679);
			this.panel6.TabIndex = 2;
			// 
			// panel8
			// 
			this.panel8.Controls.Add(this.panel5);
			this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel8.Location = new System.Drawing.Point(0, 0);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(720, 679);
			this.panel8.TabIndex = 1;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.c1DockingTab2);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(0, 0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(720, 679);
			this.panel5.TabIndex = 0;
			// 
			// c1DockingTab2
			// 
			this.c1DockingTab2.Controls.Add(this.c1DockingTabPage2);
			this.c1DockingTab2.Controls.Add(this.c1DockingTabPage3);
			this.c1DockingTab2.Controls.Add(this.c1DockingTabPage1);
			this.c1DockingTab2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.c1DockingTab2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.c1DockingTab2.Location = new System.Drawing.Point(0, 0);
			this.c1DockingTab2.Name = "c1DockingTab2";
			this.c1DockingTab2.SelectedIndex = 2;
			this.c1DockingTab2.Size = new System.Drawing.Size(720, 679);
			this.c1DockingTab2.TabIndex = 0;
			this.c1DockingTab2.TabStyle = C1.Win.C1Command.TabStyleEnum.WindowsXP;
			// 
			// c1DockingTabPage2
			// 
			this.c1DockingTabPage2.Controls.Add(this.p3);
			this.c1DockingTabPage2.Controls.Add(this.p2);
			this.c1DockingTabPage2.Controls.Add(this.p1);
			this.c1DockingTabPage2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.c1DockingTabPage2.ImageIndex = -1;
			this.c1DockingTabPage2.Location = new System.Drawing.Point(2, 28);
			this.c1DockingTabPage2.Name = "c1DockingTabPage2";
			this.c1DockingTabPage2.Size = new System.Drawing.Size(714, 647);
			this.c1DockingTabPage2.TabIndex = 0;
			this.c1DockingTabPage2.Text = "Page2";
			// 
			// p3
			// 
			this.p3.Controls.Add(this.panel11);
			this.p3.Controls.Add(this.p31);
			this.p3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.p3.Location = new System.Drawing.Point(0, 384);
			this.p3.Name = "p3";
			this.p3.Size = new System.Drawing.Size(714, 263);
			this.p3.TabIndex = 2;
			// 
			// panel11
			// 
			this.panel11.Controls.Add(this.vs3);
			this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel11.Location = new System.Drawing.Point(0, 44);
			this.panel11.Name = "panel11";
			this.panel11.Size = new System.Drawing.Size(714, 219);
			this.panel11.TabIndex = 1;
			// 
			// p31
			// 
			this.p31.Controls.Add(this.button2);
			this.p31.Controls.Add(this.dt3);
			this.p31.Controls.Add(this.nav3);
			this.p31.Dock = System.Windows.Forms.DockStyle.Top;
			this.p31.Location = new System.Drawing.Point(0, 0);
			this.p31.Name = "p31";
			this.p31.Size = new System.Drawing.Size(714, 44);
			this.p31.TabIndex = 0;
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button2.Location = new System.Drawing.Point(576, 12);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 24);
			this.button2.TabIndex = 152;
			this.button2.Text = "Show";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// dt3
			// 
			this.dt3.CustomFormat = "yyyyMM";
			this.dt3.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt3.Location = new System.Drawing.Point(472, 12);
			this.dt3.Name = "dt3";
			this.dt3.Size = new System.Drawing.Size(100, 23);
			this.dt3.TabIndex = 150;
			this.dt3.Tag = null;
			// 
			// nav3
			// 
			this.nav3.BackColor = System.Drawing.SystemColors.Control;
			this.nav3.Connection = null;
			this.nav3.ConnectionDel = null;
			this.nav3.Dock = System.Windows.Forms.DockStyle.Left;
			this.nav3.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.nav3.form = null;
			this.nav3.FormName = null;
			this.nav3.Grid = null;
			this.nav3.History = false;
			this.nav3.IsNull = true;
			this.nav3.Language = "EN";
			this.nav3.Location = new System.Drawing.Point(0, 0);
			this.nav3.MSG_Exit = false;
			this.nav3.MulltiDel = false;
			this.nav3.Name = "nav3";
			this.nav3.Security = 0;
			this.nav3.ShowPopupMenu = false;
			this.nav3.Size = new System.Drawing.Size(428, 44);
			this.nav3.TabIndex = 32;
			this.nav3.Tag = "N";
			this.nav3.ToolBar_Auto = true;
			this.nav3.UserID = null;
			this.nav3.VisibleGrid = true;
			this.nav3.Where = null;
			// 
			// p2
			// 
			this.p2.Controls.Add(this.vs4);
			this.p2.Controls.Add(this.panel7);
			this.p2.Dock = System.Windows.Forms.DockStyle.Top;
			this.p2.Location = new System.Drawing.Point(0, 188);
			this.p2.Name = "p2";
			this.p2.Size = new System.Drawing.Size(714, 196);
			this.p2.TabIndex = 1;
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.nav4);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(714, 32);
			this.panel7.TabIndex = 4;
			// 
			// nav4
			// 
			this.nav4.BackColor = System.Drawing.SystemColors.Control;
			this.nav4.Connection = null;
			this.nav4.ConnectionDel = null;
			this.nav4.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.nav4.form = null;
			this.nav4.FormName = null;
			this.nav4.Grid = null;
			this.nav4.History = false;
			this.nav4.IsNull = true;
			this.nav4.Language = "EN";
			this.nav4.Location = new System.Drawing.Point(4, 0);
			this.nav4.MSG_Exit = false;
			this.nav4.MulltiDel = false;
			this.nav4.Name = "nav4";
			this.nav4.Security = 0;
			this.nav4.ShowPopupMenu = false;
			this.nav4.Size = new System.Drawing.Size(428, 32);
			this.nav4.TabIndex = 31;
			this.nav4.ToolBar_Auto = true;
			this.nav4.UserID = null;
			this.nav4.VisibleGrid = true;
			this.nav4.Where = null;
			// 
			// p1
			// 
			this.p1.Controls.Add(this.vs);
			this.p1.Controls.Add(this.panel15);
			this.p1.Dock = System.Windows.Forms.DockStyle.Top;
			this.p1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.p1.Location = new System.Drawing.Point(0, 0);
			this.p1.Name = "p1";
			this.p1.Size = new System.Drawing.Size(714, 188);
			this.p1.TabIndex = 0;
			// 
			// vs
			// 
			this.vs.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vs.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vs.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs.Location = new System.Drawing.Point(0, 32);
			this.vs.Name = "vs";
			this.vs.Size = new System.Drawing.Size(714, 156);
			this.vs.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs.TabIndex = 33;
			// 
			// panel15
			// 
			this.panel15.Controls.Add(this.cmd_show);
			this.panel15.Controls.Add(this.dt1);
			this.panel15.Controls.Add(this.label1);
			this.panel15.Controls.Add(this.nav);
			this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel15.Location = new System.Drawing.Point(0, 0);
			this.panel15.Name = "panel15";
			this.panel15.Size = new System.Drawing.Size(714, 32);
			this.panel15.TabIndex = 3;
			// 
			// cmd_show
			// 
			this.cmd_show.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_show.Location = new System.Drawing.Point(632, 4);
			this.cmd_show.Name = "cmd_show";
			this.cmd_show.Size = new System.Drawing.Size(75, 24);
			this.cmd_show.TabIndex = 150;
			this.cmd_show.Text = "button1";
			// 
			// dt1
			// 
			this.dt1.CustomFormat = "yyyy";
			this.dt1.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt1.Location = new System.Drawing.Point(524, 5);
			this.dt1.Name = "dt1";
			this.dt1.Size = new System.Drawing.Size(100, 23);
			this.dt1.TabIndex = 149;
			this.dt1.Tag = null;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(432, 8);
			this.label1.Name = "label1";
			this.label1.TabIndex = 32;
			this.label1.Text = "label1";
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
			this.nav.Location = new System.Drawing.Point(4, 0);
			this.nav.MSG_Exit = false;
			this.nav.MulltiDel = false;
			this.nav.Name = "nav";
			this.nav.Security = 0;
			this.nav.ShowPopupMenu = false;
			this.nav.Size = new System.Drawing.Size(428, 32);
			this.nav.TabIndex = 31;
			this.nav.ToolBar_Auto = true;
			this.nav.UserID = null;
			this.nav.VisibleGrid = true;
			this.nav.Where = null;
			// 
			// c1DockingTabPage3
			// 
			this.c1DockingTabPage3.Controls.Add(this.panel9);
			this.c1DockingTabPage3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.c1DockingTabPage3.ImageIndex = -1;
			this.c1DockingTabPage3.Location = new System.Drawing.Point(2, 28);
			this.c1DockingTabPage3.Name = "c1DockingTabPage3";
			this.c1DockingTabPage3.Size = new System.Drawing.Size(714, 647);
			this.c1DockingTabPage3.TabIndex = 1;
			this.c1DockingTabPage3.Text = "Page3";
			this.c1DockingTabPage3.Visible = false;
			// 
			// panel9
			// 
			this.panel9.Controls.Add(this.panel14);
			this.panel9.Controls.Add(this.splitter2);
			this.panel9.Controls.Add(this.panel12);
			this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panel9.Location = new System.Drawing.Point(0, 0);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(714, 647);
			this.panel9.TabIndex = 1;
			// 
			// panel14
			// 
			this.panel14.Controls.Add(this.vs2);
			this.panel14.Controls.Add(this.nav2);
			this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel14.Location = new System.Drawing.Point(231, 0);
			this.panel14.Name = "panel14";
			this.panel14.Size = new System.Drawing.Size(483, 647);
			this.panel14.TabIndex = 2;
			// 
			// vs2
			// 
			this.vs2.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs2.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vs2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vs2.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs2.Location = new System.Drawing.Point(0, 32);
			this.vs2.Name = "vs2";
			this.vs2.Size = new System.Drawing.Size(483, 615);
			this.vs2.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs2.TabIndex = 34;
			// 
			// nav2
			// 
			this.nav2.BackColor = System.Drawing.SystemColors.Control;
			this.nav2.Connection = null;
			this.nav2.ConnectionDel = null;
			this.nav2.Dock = System.Windows.Forms.DockStyle.Top;
			this.nav2.Font = new System.Drawing.Font("Tahoma", 9.75F);
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
			this.nav2.ShowPopupMenu = false;
			this.nav2.Size = new System.Drawing.Size(483, 32);
			this.nav2.TabIndex = 33;
			this.nav2.ToolBar_Auto = true;
			this.nav2.UserID = null;
			this.nav2.VisibleGrid = true;
			this.nav2.Where = null;
			// 
			// splitter2
			// 
			this.splitter2.Location = new System.Drawing.Point(228, 0);
			this.splitter2.Name = "splitter2";
			this.splitter2.Size = new System.Drawing.Size(3, 647);
			this.splitter2.TabIndex = 1;
			this.splitter2.TabStop = false;
			// 
			// panel12
			// 
			this.panel12.Controls.Add(this.vs1);
			this.panel12.Controls.Add(this.nav1);
			this.panel12.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel12.Location = new System.Drawing.Point(0, 0);
			this.panel12.Name = "panel12";
			this.panel12.Size = new System.Drawing.Size(228, 647);
			this.panel12.TabIndex = 0;
			// 
			// vs1
			// 
			this.vs1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs1.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vs1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vs1.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs1.Location = new System.Drawing.Point(0, 32);
			this.vs1.Name = "vs1";
			this.vs1.Size = new System.Drawing.Size(228, 615);
			this.vs1.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs1.TabIndex = 33;
			// 
			// nav1
			// 
			this.nav1.BackColor = System.Drawing.SystemColors.Control;
			this.nav1.Connection = null;
			this.nav1.ConnectionDel = null;
			this.nav1.Dock = System.Windows.Forms.DockStyle.Top;
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
			this.nav1.ShowPopupMenu = false;
			this.nav1.Size = new System.Drawing.Size(228, 32);
			this.nav1.TabIndex = 32;
			this.nav1.ToolBar_Auto = true;
			this.nav1.UserID = null;
			this.nav1.VisibleGrid = true;
			this.nav1.Where = null;
			// 
			// c1DockingTabPage1
			// 
			this.c1DockingTabPage1.Controls.Add(this.panel10);
			this.c1DockingTabPage1.ImageIndex = -1;
			this.c1DockingTabPage1.Location = new System.Drawing.Point(2, 28);
			this.c1DockingTabPage1.Name = "c1DockingTabPage1";
			this.c1DockingTabPage1.Size = new System.Drawing.Size(714, 647);
			this.c1DockingTabPage1.TabIndex = 2;
			this.c1DockingTabPage1.Text = "Page1";
			this.c1DockingTabPage1.Visible = false;
			// 
			// panel10
			// 
			this.panel10.Controls.Add(this.vs5);
			this.panel10.Controls.Add(this.nav5);
			this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel10.Location = new System.Drawing.Point(0, 0);
			this.panel10.Name = "panel10";
			this.panel10.Size = new System.Drawing.Size(714, 647);
			this.panel10.TabIndex = 0;
			// 
			// vs5
			// 
			this.vs5.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs5.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vs5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vs5.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs5.Location = new System.Drawing.Point(0, 32);
			this.vs5.Name = "vs5";
			this.vs5.Size = new System.Drawing.Size(714, 615);
			this.vs5.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs5.TabIndex = 35;
			// 
			// nav5
			// 
			this.nav5.BackColor = System.Drawing.SystemColors.Control;
			this.nav5.Connection = null;
			this.nav5.ConnectionDel = null;
			this.nav5.Dock = System.Windows.Forms.DockStyle.Top;
			this.nav5.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.nav5.form = null;
			this.nav5.FormName = null;
			this.nav5.Grid = null;
			this.nav5.History = false;
			this.nav5.IsNull = true;
			this.nav5.Language = "EN";
			this.nav5.Location = new System.Drawing.Point(0, 0);
			this.nav5.MSG_Exit = false;
			this.nav5.MulltiDel = false;
			this.nav5.Name = "nav5";
			this.nav5.Security = 0;
			this.nav5.ShowPopupMenu = false;
			this.nav5.Size = new System.Drawing.Size(714, 32);
			this.nav5.TabIndex = 34;
			this.nav5.ToolBar_Auto = true;
			this.nav5.UserID = null;
			this.nav5.VisibleGrid = true;
			this.nav5.Where = null;
			// 
			// splitter1
			// 
			this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
			this.splitter1.Location = new System.Drawing.Point(0, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(720, 3);
			this.splitter1.TabIndex = 1;
			this.splitter1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.panel2.Controls.Add(this.l);
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(720, 36);
			this.panel2.TabIndex = 0;
			// 
			// l
			// 
			this.l.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.l.Dock = System.Windows.Forms.DockStyle.Fill;
			this.l.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.l.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.l.Location = new System.Drawing.Point(252, 0);
			this.l.Name = "l";
			this.l.Size = new System.Drawing.Size(468, 36);
			this.l.TabIndex = 6;
			this.l.Tag = "";
			this.l.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.r2);
			this.panel3.Controls.Add(this.r1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(252, 36);
			this.panel3.TabIndex = 0;
			// 
			// r2
			// 
			this.r2.Location = new System.Drawing.Point(140, 8);
			this.r2.Name = "r2";
			this.r2.TabIndex = 1;
			this.r2.Text = "radioButton2";
			this.r2.Visible = false;
			// 
			// r1
			// 
			this.r1.Location = new System.Drawing.Point(24, 8);
			this.r1.Name = "r1";
			this.r1.TabIndex = 0;
			this.r1.Text = "radioButton1";
			// 
			// vs3
			// 
			this.vs3.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs3.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vs3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vs3.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs3.Location = new System.Drawing.Point(0, 0);
			this.vs3.Name = "vs3";
			this.vs3.Size = new System.Drawing.Size(714, 219);
			this.vs3.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs3.TabIndex = 35;
			// 
			// vs4
			// 
			this.vs4.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs4.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vs4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vs4.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs4.Location = new System.Drawing.Point(0, 32);
			this.vs4.Name = "vs4";
			this.vs4.Size = new System.Drawing.Size(714, 164);
			this.vs4.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs4.TabIndex = 34;
			// 
			// frmTaSchedule
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(720, 718);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaSchedule";
			this.Text = "frmTaSchedule";
			this.Load += new System.EventHandler(this.frmTaSchedule_Load);
			this.panel1.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.c1DockingTab2)).EndInit();
			this.c1DockingTab2.ResumeLayout(false);
			this.c1DockingTabPage2.ResumeLayout(false);
			this.p3.ResumeLayout(false);
			this.panel11.ResumeLayout(false);
			this.p31.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dt3)).EndInit();
			this.p2.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.p1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			this.panel15.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dt1)).EndInit();
			this.c1DockingTabPage3.ResumeLayout(false);
			this.panel9.ResumeLayout(false);
			this.panel14.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs2)).EndInit();
			this.panel12.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs1)).EndInit();
			this.c1DockingTabPage1.ResumeLayout(false);
			this.panel10.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs5)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vs4)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaSchedule_Load(object sender, System.EventArgs e)
		{
			string sql="Delete From FILC12B where GRP_FO not in (select GRP_FO from FILC12A )";
			PublicFunction.SQL_Execute(sql);
			dt1.Value=T_String.GetDate();
			dt3.Value=T_String.GetDate();
			init_vs();
			init_vs1();		
			init_vs2();
			if(PublicFunction.GetOption("GPS_DEP")=="1")
			{
				nav3.Tag="";
				init_vs3();
			}
			init_vs4();
			init_vs5();
			show_vs2();			
			Basic.Function.PublicFunction.L_Init_Label(this);		
			for(int i=1;i<32;i++)
			{
				vs.Cols["h"+i].Caption=i+"";
				if(PublicFunction.GetOption("GPS_DEP")=="1")
					vs3.Cols["h"+i].Caption=i+"";
			}
			vs.AutoSizeCols();
			c1DockingTab2.SelectedIndex=0;

			Init_CB();
			if(T_String.GetDataFromSQL("WEE_BY","FILC14A")=="True")
			{
				r2.Checked=true;
				p1.Visible=false;
				p2.Visible=!p1.Visible;
				p2.Dock=DockStyle.Fill;
				nav4.Show_VS();
			}
			else
			{
				r1.Checked=true;
				if(PublicFunction.GetOption("GPS_DEP")=="1")
				{
					p3.Visible=true;
					p2.Visible=!p3.Visible;
					p1.Visible=!p3.Visible;
					p3.Dock=DockStyle.Fill;
					show_vs3();
				}
				else
				r1.Checked=true;
				p1.Visible=true;
				p2.Visible=!p1.Visible;
				p1.Dock=DockStyle.Fill;
				show_vs();				
			}

		}

		#region init

		private void Init_CB()
		{
			vs.Cols["h1"].DataMap=PublicFunction.InitCBForVS("Select GRP_FO,GRP_NM from FILC12A");
			if(PublicFunction.GetOption("GPS_DEP")=="1")
				vs3.Cols["h1"].DataMap=vs.Cols["h1"].DataMap;
			for(int i=2;i<32;i++)
			{
				vs.Cols["h"+i].DataMap=vs.Cols["h1"].DataMap;
				if(PublicFunction.GetOption("GPS_DEP")=="1")
					vs3.Cols["h"+i].DataMap=vs.Cols["h1"].DataMap;
			}
			for(int i=1;i<8;i++)
			{

				vs4.Cols["h"+i].DataMap=vs.Cols["h1"].DataMap;
			}
		}

		private void init_vs()
		{			
			PublicFunction.InitNav(this,vs,nav);							
			vs.SelectionMode=C1.Win.C1FlexGrid.SelectionModeEnum.CellRange; 
			nav.cmd_add.Visible=nav.cmd_delete.Visible=
				nav.cmd_search.Visible=nav.cmd_copy.Visible=nav.cmd_report.Visible=false;						
			vs.Styles.Add("CN");
			vs.Styles["CN"].BackColor=Color.Silver;			
			vs.Styles.Add("bt");
			vs.AfterEdit+=new C1.Win.C1FlexGrid.RowColEventHandler(vs_AfterEdit);
			vs.EnabledChanged+=new EventHandler(vs_EnabledChanged);
			nav.ToolBar_Auto=false;
			nav.TBarClick+=new ToolBarButtonClickEventHandler(nav_TBarClick);
			
		}

		private void init_vs4()
		{			
			PublicFunction.InitNav(this,vs4,nav4);							
			vs4.SelectionMode=C1.Win.C1FlexGrid.SelectionModeEnum.CellRange; 
			nav4.cmd_add.Visible=nav4.cmd_delete.Visible=
				nav4.cmd_search.Visible=nav4.cmd_copy.Visible=nav4.cmd_report.Visible=false;									
			vs4.AfterEdit+=new C1.Win.C1FlexGrid.RowColEventHandler(vs4_AfterEdit);						
		}
		private void init_vs3()
		{			
			PublicFunction.InitNav(this,vs3,nav3);							
			vs3.SelectionMode=C1.Win.C1FlexGrid.SelectionModeEnum.CellRange; 
			nav3.cmd_add.Visible=nav3.cmd_delete.Visible=
				nav3.cmd_search.Visible=nav3.cmd_copy.Visible=nav3.cmd_report.Visible=false;						
			vs3.Styles.Add("CN");
			vs3.Styles["CN"].BackColor=Color.Silver;			
			vs3.Styles.Add("bt");
			vs3.AfterEdit+=new C1.Win.C1FlexGrid.RowColEventHandler(vs3_AfterEdit);
			vs3.EnabledChanged+=new EventHandler(vs3_EnabledChanged);
			nav3.ToolBar_Auto=false;
			nav3.TBarClick+=new ToolBarButtonClickEventHandler(nav3_TBarClick);
			
		}
		private void vs3_EnabledChanged(object sender, EventArgs e)
		{
			for(int i=1;i<32;i++)
			{
				vs3.Cols["h"+i].Caption=i+"";
			}
		}
		private void nav3_TBarClick(object sender, ToolBarButtonClickEventArgs e)
		{			
			if (e.Button.Equals(nav3.cmd_refresh))
			{
				show_vs3();		
				return;
			}
			nav3.ToolBar_Click(e);					
		}
		private void show_vs3()
		{
			insert3();
			nav3.Show_VS("YYY_MM=N'"+dt3.Text+"'");
			show_cn3();	
		}
		private void insert3()
		{
			
			string sql;
			//			string sdep="";
			//			sdept="SELECT * FROM FILA02A WHERE ISNULL(DEP_HG,'') <>'' ORDER BY DEP_NM";
			//			Func.RecordSet rsdep=new Func.RecordSet (sdept,PublicFunction.C_con);
			//			//CAP NHAT MOI
			//			if(T_String.IsNullTo0(T_String.GetDataFromSQL("COUNT(*)","FILC13A_DEP","YYY_MM=N'"+ dt3.Text+"'"))==0)
			//			{
			//				for(int i=0;i<rsdep.rows;i++)
			//				{
			//					sql="Insert Into FILC13A_DEP(YYY_MM,DEP_ID) values(N'"+dt1.Text+"','"+rsdep.record(i,"DEP_ID")+"')";
			//					PublicFunction.SQL_Execute(sql);
			//				}				
			//			}
			sql="INSERT INTO FILC13A_DEP(YYY_MM,DEP_ID)"+
				" SELECT '"+dt3.Text+ "' AS YYY_MM,A.DEP_ID "+
				" FROM FILA02A A WHERE A.DEP_ID NOT IN(SELECT DEP_ID FROM FILC13A_DEP WHERE YYY_MM='"+dt3.Text+"') "+
				" AND (SELECT COUNT(*) FROM FILB01A WHERE FILB01A.DEP_ID=A.DEP_ID)>0 ";
			PublicFunction.SQL_Execute(sql);
		}
		private void show_cn3()
		{
			for(int m=1;m<vs3.Rows.Count;m++)
			{
				for(int i=1;i<=31;i++)
				{
					try
					{
						string sYM=vs3.Rows[m]["YYY_MM"]+"";
						DateTime d=new DateTime(T_String.IsNullTo0(sYM.Substring(0,4)),
							T_String.IsNullTo0(sYM.Substring(4,2)),i);
						if(d.DayOfWeek==System.DayOfWeek.Sunday)
						{
							vs3.SetCellStyle(m,vs.Cols["h"+i].Index,vs3.Styles["CN"]);							
						}
						else
						{
							vs3.SetCellStyle(m,vs.Cols["h"+i].Index,vs3.Styles["bt"]);;
						}
					}
					catch{}
				}
			
			}
		}
		private void init_vs1()
		{
			PublicFunction.InitNav(this,vs1,nav1);				
			nav1.Show_VS();
			nav1.cmd_fisrt.Visible=nav1.cmd_last.Visible=nav1.cmd_search.Visible=
				nav1.cmd_copy.Visible=nav1.cmd_report.Visible=false;
			vs1.AfterRowColChange+=new C1.Win.C1FlexGrid.RangeEventHandler(vs1_AfterRowColChange);			
			nav1.TBarClick+=new ToolBarButtonClickEventHandler(nav1_TBarClick);
		}
		private void init_vs2()
		{
			PublicFunction.InitNav(this,vs2,nav2);							
			nav2.cmd_search.Visible=nav2.cmd_copy.Visible=nav2.cmd_report.Visible=false;						
			nav2.TBarClick+=new ToolBarButtonClickEventHandler(nav2_TBarClick);
			nav2.ToolBar_Auto=false;
			vs2.Cols["COL_MM1"].ComboList="|...";
			vs2.Cols["COL_MM2"].ComboList="|...";
			vs2.Cols["FUN_ID"].ComboList="|...";
			vs2.CellButtonClick+=new C1.Win.C1FlexGrid.RowColEventHandler(vs2_CellButtonClick);
			vs2.AfterEdit+=new C1.Win.C1FlexGrid.RowColEventHandler(vs2_AfterEdit);
		}
		private void init_vs5()
		{
			PublicFunction.InitNav(this,vs5,nav5);				
			if(PublicFunction.A_UserID.ToUpper()!="ADMIN" && PublicFunction.A_UserID.ToUpper()!="VINHTUYEN")
				vs5.Cols["SQL_DR"].Visible=false;
			nav5.Show_VS();
			nav5.cmd_search.Visible=nav5.cmd_copy.Visible=nav5.cmd_report.Visible=false;			
		}

		#endregion
		#region show
		private void show_vs2()
		{
			nav2.Show_VS("GRP_FO=N'"+vs1.Rows[vs1.Row]["GRP_FO"]+"'");
		}
		
		private void show_vs()
		{
			insert();
			nav.Show_VS("YYY_YY=N'"+dt1.Text+"'");
			show_cn();	
		}

		private void vs1_AfterRowColChange(object sender, C1.Win.C1FlexGrid.RangeEventArgs e)
		{
			if(e.NewRange.r1!=e.OldRange.r1)
				show_vs2();
		}

		private void insert()
		{
			
			string sql;
			if(T_String.IsNullTo0(T_String.GetDataFromSQL("COUNT(*)","FILC13A","YYY_YY=N'"+ dt1.Text+"'"))==0)
			{
				for(int i=1;i<13;i++)
				{
					sql="Insert Into FILC13A(YYY_YY,MMM_MM) values(N'"+dt1.Text+"',"+i+")";
					PublicFunction.SQL_Execute(sql);
				}				
			}
		}
		private void show_cn()
		{
			for(int m=1;m<vs.Rows.Count;m++)
			{
				for(int i=1;i<=31;i++)
				{
					try
					{
						DateTime d=new DateTime(T_String.IsNullTo0(vs.Rows[m]["YYY_YY"]+""),
							T_String.IsNullTo0(vs.Rows[m]["MMM_MM"]+""),i);
						if(d.DayOfWeek==System.DayOfWeek.Sunday)
						{
							vs.SetCellStyle(m,vs.Cols["h"+i].Index,vs.Styles["CN"]);							
						}
						else
						{
							vs.SetCellStyle(m,vs.Cols["h"+i].Index,vs.Styles["bt"]);;
						}
					}
					catch{}
				}
			
			}
		}
#endregion
		#region event
		private void nav2_TBarClick(object sender, ToolBarButtonClickEventArgs e)
		{				
			if (e.Button.Equals(nav2.cmd_add))
			{
				if(vs1.Row>0 && vs1.Rows[vs1.Row].UserData+""!="2")
				{
					nav2.ToolBar_Click(e);			
					vs2.Rows[vs2.Rows.Count-1]["GRP_FO"]=vs1.Rows[vs1.Row]["GRP_FO"];
					int t=T_String.GetMax("max(FOR_ID)","FILC12B","GRP_FO=N'"+vs1.Rows[vs1.Row]["GRP_FO"]+"'");
					vs2.Rows[vs2.Rows.Count-1]["FOR_ID"]=t+"";
					vs2.Rows[vs2.Rows.Count-1]["BLT_NM"]=PublicFunction.A_UserID;
					vs2.Rows[vs2.Rows.Count-1]["BLT_DT"]=T_String.GetDate().ToString("yyyy/MM/dd HH:mm");
				
				}				
				return;
			}		
			if (e.Button.Equals(nav2.cmd_save))
			{
				for (int i=1;i<vs2.Rows.Count;i++)
				{
					vs2.Rows[i]["SEQ_NO"]=i.ToString("000");
					if (vs2.Rows[i].UserData+""!="2")					
						vs2.Rows[i].UserData=1;					
				}	
				nav2.ToolBar_Click(e);
				return;
			}
			nav2.ToolBar_Click(e);				
		}

		private void nav1_TBarClick(object sender, ToolBarButtonClickEventArgs e)
		{			
			if (e.Button.Equals(nav1.cmd_save))
			{
				Init_CB();				
				return;
			}
			
		}
		private void nav_TBarClick(object sender, ToolBarButtonClickEventArgs e)
		{			
			if (e.Button.Equals(nav.cmd_refresh))
			{
				show_vs();		
				return;
			}
			nav.ToolBar_Click(e);					
		}


		private void vs2_CellButtonClick(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			if(vs2.Cols[e.Col].Name=="FUN_ID")
			{
				Func.RecordSet rs=new Func.RecordSet("select FUN_ID,FUN_NM from FILC11A",PublicFunction.C_con);
				frmSearch dlg1=new frmSearch(rs,2,this.Name+"_vs5");
				if(dlg1.ShowDialog()==DialogResult.OK)
				{
					vs2.Rows[e.Row]["FUN_ID"]=rs.record(rs.Bookmarks,"FUN_ID");
					vs2.Rows[e.Row]["FUN_NM"]=rs.record(rs.Bookmarks,"FUN_NM");
				}
				return;
			}
			frmTaAddfor dlg=new frmTaAddfor();
			if(dlg.ShowDialog()==DialogResult.OK)
			{
				vs2.Rows[e.Row][e.Col]=dlg.COL_MM;
				if(vs2.Cols[e.Col].Name=="COL_MM1")
					vs2.Rows[e.Row]["COL_NM1"]=dlg.COL_NM;
				else
					vs2.Rows[e.Row]["COL_NM2"]=dlg.COL_NM;
			}
		}

		private void vs2_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			vs2.Rows[e.Row]["LST_NM"]=PublicFunction.A_UserID;
			vs2.Rows[e.Row]["LST_DT"]=T_String.GetDate().ToString("yyyy/MM/dd HH:mm");
			if(vs2.Cols[e.Col].Name=="FUN_ID" && vs2.Rows[e.Row]["FUN_ID"]+""=="")
				vs2.Rows[e.Row]["FUN_NM"]="";
			if(vs2.Cols[e.Col].Name=="COL_MM1" && vs2.Rows[e.Row]["COL_MM1"]+""=="")
				vs2.Rows[e.Row]["COL_NM1"]="";
			if(vs2.Cols[e.Col].Name=="COL_MM2" && vs2.Rows[e.Row]["COL_MM2"]+""=="")
				vs2.Rows[e.Row]["COL_NM2"]="";
		}
		private void vs3_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			string dd=T_String.GetDate().ToString("yyyy/MM/dd HH:mm");
			vs3.Rows[e.Row]["LST_NM"]=PublicFunction.A_UserID;
			vs3.Rows[e.Row]["LST_DT"]=dd;			
			for (int i=vs3.Selection.r1;i<=vs3.Selection.r2;i++)
			{
				for (int j=vs3.Selection.c1;j<=vs3.Selection.c2;j++)
				{
					if (PublicFunction.S_Left(vs3.Cols[j].Name,1) =="h")
					{
						vs3[i,j ]=vs3[e.Row,e.Col];
						vs3.Rows[i].UserData=1;
						vs3.Rows[i]["LST_NM"]=PublicFunction.A_UserID;
						vs3.Rows[i]["LST_DT"]=dd;
					}
				}
			}		
			vs3.AutoSizeCols();
		}
		private void vs_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			string dd=T_String.GetDate().ToString("yyyy/MM/dd HH:mm");
			vs.Rows[e.Row]["LST_NM"]=PublicFunction.A_UserID;
			vs.Rows[e.Row]["LST_DT"]=dd;			
			for (int i=vs.Selection.r1;i<=vs.Selection.r2;i++)
			{
				for (int j=vs.Selection.c1;j<=vs.Selection.c2;j++)
				{
					if (PublicFunction.S_Left(vs.Cols[j].Name,1) =="h")
					{
						vs[i,j ]=vs[e.Row,e.Col];
						vs.Rows[i].UserData=1;
						vs.Rows[i]["LST_NM"]=PublicFunction.A_UserID;
						vs.Rows[i]["LST_DT"]=dd;
					}
				}
			}		
			vs.AutoSizeCols();
		}

		private void vs4_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			string dd=T_String.GetDate().ToString("yyyy/MM/dd HH:mm");
			vs4.Rows[e.Row]["LST_NM"]=PublicFunction.A_UserID;
			vs4.Rows[e.Row]["LST_DT"]=dd;			
			for (int i=vs4.Selection.r1;i<=vs4.Selection.r2;i++)
			{
				for (int j=vs4.Selection.c1;j<=vs4.Selection.c2;j++)
				{
					if (PublicFunction.S_Left(vs4.Cols[j].Name,1) =="h")
					{
						vs4[i,j ]=vs4[e.Row,e.Col];
						vs4.Rows[i].UserData=1;
						vs4.Rows[i]["LST_NM"]=PublicFunction.A_UserID;
						vs4.Rows[i]["LST_DT"]=dd;
					}
				}
			}		
			vs4.AutoSizeCols();
		}

		private void cmd_show_Click(object sender, System.EventArgs e)
		{
			nav.Show_VS("YYY_YY=N'"+dt1.Text+"'");
		}

		private void vs_EnabledChanged(object sender, EventArgs e)
		{
			for(int i=1;i<32;i++)
			{
				vs.Cols["h"+i].Caption=i+"";
			}
		}
	#endregion

		private void r1_CheckedChanged(object sender, System.EventArgs e)
		{
			if(r1.Checked)
			{
				p1.Visible=true;
				p2.Visible=!p1.Visible;
				p1.Dock=DockStyle.Fill;
				show_vs();
				PublicFunction.SQL_Execute("update FILC14A set WEE_BY=0");
			}
			else
			{
				p1.Visible=false;
				p2.Visible=!p1.Visible;
				p2.Dock=DockStyle.Fill;
				string sql;
				if(T_String.IsNullTo0(T_String.GetDataFromSQL("COUNT(*)","FILC14A"))<=0)
				{					
					sql="Insert Into FILC14A(YYY_YY,WEE_BY) values(N'qtan',"+1+")";
					PublicFunction.SQL_Execute(sql);					
				}
				nav4.Show_VS();
				PublicFunction.SQL_Execute("update FILC14A set WEE_BY=1");
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			show_vs3();
		}
		
	}
}

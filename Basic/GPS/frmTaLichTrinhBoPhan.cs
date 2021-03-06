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
using GP8000.Attendance;

namespace GP8000.GPS
{
	/// <summary>
	/// Summary description for frmTaVacateManager.
	/// </summary>
	public class frmTaLichTrinhBoPhan : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel4;
		private Navigator1._0.NavigatorAuto nav;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.Splitter splitter2;
		private System.Windows.Forms.Panel panel10;
		private C1.Win.C1FlexGrid.C1FlexGrid vs;
		private Navigator1._0.NavigatorAuto nav1;
		private C1.Win.C1FlexGrid.C1FlexGrid vs1;
		private System.Windows.Forms.TextBox txt2;
		private System.Windows.Forms.TextBox txt1;
		private System.Windows.Forms.TextBox txt9;
		private System.Windows.Forms.TextBox txt8;
		private System.Windows.Forms.Panel panel12;
		private System.Windows.Forms.Button cmd_clear;
		private System.Windows.Forms.Button cmd_all;
		private string []arrAL;
		private C1.Win.C1Command.C1DockingTab c1DockingTab2;
		private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage2;
		private System.Windows.Forms.Panel p2;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel p1;
		private System.Windows.Forms.Panel panel15;
		private System.Windows.Forms.Button cmd_show;
		private C1.Win.C1Input.C1DateEdit dt1;
		private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage3;
		private System.Windows.Forms.Panel panel11;
		private System.Windows.Forms.Panel panel14;
		private System.Windows.Forms.Splitter splitter3;
		private System.Windows.Forms.Panel panel13;
		private System.Windows.Forms.Panel panel16;
		private Navigator1._0.NavigatorAuto nav5;
		private C1.Win.C1FlexGrid.C1FlexGrid vs2;
		private C1.Win.C1FlexGrid.C1FlexGrid vs4;
		private C1.Win.C1FlexGrid.C1FlexGrid vs3;
		private C1.Win.C1FlexGrid.C1FlexGrid vs5;
		private System.Windows.Forms.Label lblNam;
		private C1.Win.C1FlexGrid.C1FlexGrid vs6;
		private Navigator1._0.NavigatorAuto nav6;
		private Navigator1._0.NavigatorAuto nav2;
		private Navigator1._0.NavigatorAuto nav4;
		private Navigator1._0.NavigatorAuto nav3;
		private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage1;
		private System.Windows.Forms.CheckBox ckApplyAll;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaLichTrinhBoPhan()
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
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel8 = new System.Windows.Forms.Panel();
			this.panel12 = new System.Windows.Forms.Panel();
			this.c1DockingTab2 = new C1.Win.C1Command.C1DockingTab();
			this.c1DockingTabPage2 = new C1.Win.C1Command.C1DockingTabPage();
			this.p2 = new System.Windows.Forms.Panel();
			this.vs6 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.panel5 = new System.Windows.Forms.Panel();
			this.nav6 = new Navigator1._0.NavigatorAuto();
			this.p1 = new System.Windows.Forms.Panel();
			this.vs2 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.panel15 = new System.Windows.Forms.Panel();
			this.ckApplyAll = new System.Windows.Forms.CheckBox();
			this.cmd_show = new System.Windows.Forms.Button();
			this.dt1 = new C1.Win.C1Input.C1DateEdit();
			this.lblNam = new System.Windows.Forms.Label();
			this.nav2 = new Navigator1._0.NavigatorAuto();
			this.c1DockingTabPage3 = new C1.Win.C1Command.C1DockingTabPage();
			this.panel11 = new System.Windows.Forms.Panel();
			this.panel14 = new System.Windows.Forms.Panel();
			this.vs4 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.nav4 = new Navigator1._0.NavigatorAuto();
			this.splitter3 = new System.Windows.Forms.Splitter();
			this.panel13 = new System.Windows.Forms.Panel();
			this.vs3 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.nav3 = new Navigator1._0.NavigatorAuto();
			this.c1DockingTabPage1 = new C1.Win.C1Command.C1DockingTabPage();
			this.panel16 = new System.Windows.Forms.Panel();
			this.vs5 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.nav5 = new Navigator1._0.NavigatorAuto();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.panel7 = new System.Windows.Forms.Panel();
			this.panel10 = new System.Windows.Forms.Panel();
			this.txt9 = new System.Windows.Forms.TextBox();
			this.txt8 = new System.Windows.Forms.TextBox();
			this.nav1 = new Navigator1._0.NavigatorAuto();
			this.vs1 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.splitter2 = new System.Windows.Forms.Splitter();
			this.panel9 = new System.Windows.Forms.Panel();
			this.txt2 = new System.Windows.Forms.TextBox();
			this.txt1 = new System.Windows.Forms.TextBox();
			this.nav = new Navigator1._0.NavigatorAuto();
			this.vs = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.panel3 = new System.Windows.Forms.Panel();
			this.cmd_all = new System.Windows.Forms.Button();
			this.cmd_clear = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel8.SuspendLayout();
			this.panel12.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1DockingTab2)).BeginInit();
			this.c1DockingTab2.SuspendLayout();
			this.c1DockingTabPage2.SuspendLayout();
			this.p2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs6)).BeginInit();
			this.panel5.SuspendLayout();
			this.p1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs2)).BeginInit();
			this.panel15.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dt1)).BeginInit();
			this.c1DockingTabPage3.SuspendLayout();
			this.panel11.SuspendLayout();
			this.panel14.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs4)).BeginInit();
			this.panel13.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs3)).BeginInit();
			this.c1DockingTabPage1.SuspendLayout();
			this.panel16.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs5)).BeginInit();
			this.panel7.SuspendLayout();
			this.panel10.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs1)).BeginInit();
			this.panel9.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1020, 676);
			this.panel1.TabIndex = 3;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.panel6);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 36);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1020, 640);
			this.panel2.TabIndex = 5;
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.panel8);
			this.panel6.Controls.Add(this.splitter1);
			this.panel6.Controls.Add(this.panel7);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel6.Location = new System.Drawing.Point(0, 0);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(1020, 640);
			this.panel6.TabIndex = 1;
			// 
			// panel8
			// 
			this.panel8.Controls.Add(this.panel12);
			this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel8.Location = new System.Drawing.Point(0, 284);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(1020, 356);
			this.panel8.TabIndex = 2;
			// 
			// panel12
			// 
			this.panel12.Controls.Add(this.c1DockingTab2);
			this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel12.Location = new System.Drawing.Point(0, 0);
			this.panel12.Name = "panel12";
			this.panel12.Size = new System.Drawing.Size(1020, 356);
			this.panel12.TabIndex = 41;
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
			this.c1DockingTab2.SelectedIndex = 0;
			this.c1DockingTab2.Size = new System.Drawing.Size(1020, 356);
			this.c1DockingTab2.TabIndex = 1;
			this.c1DockingTab2.TabStyle = C1.Win.C1Command.TabStyleEnum.WindowsXP;
			// 
			// c1DockingTabPage2
			// 
			this.c1DockingTabPage2.Controls.Add(this.p2);
			this.c1DockingTabPage2.Controls.Add(this.p1);
			this.c1DockingTabPage2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.c1DockingTabPage2.ImageIndex = -1;
			this.c1DockingTabPage2.Location = new System.Drawing.Point(2, 28);
			this.c1DockingTabPage2.Name = "c1DockingTabPage2";
			this.c1DockingTabPage2.Size = new System.Drawing.Size(1014, 324);
			this.c1DockingTabPage2.TabIndex = 0;
			this.c1DockingTabPage2.Text = "Page2";
			// 
			// p2
			// 
			this.p2.Controls.Add(this.vs6);
			this.p2.Controls.Add(this.panel5);
			this.p2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.p2.Location = new System.Drawing.Point(0, 188);
			this.p2.Name = "p2";
			this.p2.Size = new System.Drawing.Size(1014, 136);
			this.p2.TabIndex = 1;
			// 
			// vs6
			// 
			this.vs6.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs6.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vs6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vs6.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs6.Location = new System.Drawing.Point(0, 32);
			this.vs6.Name = "vs6";
			this.vs6.Size = new System.Drawing.Size(1014, 104);
			this.vs6.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.vs6.TabIndex = 34;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.nav6);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel5.Location = new System.Drawing.Point(0, 0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(1014, 32);
			this.panel5.TabIndex = 4;
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
			this.nav6.Location = new System.Drawing.Point(4, 0);
			this.nav6.MSG_Exit = false;
			this.nav6.MulltiDel = false;
			this.nav6.Name = "nav6";
			this.nav6.Security = 0;
			this.nav6.ShowPopupMenu = false;
			this.nav6.Size = new System.Drawing.Size(428, 32);
			this.nav6.TabIndex = 31;
			this.nav6.ToolBar_Auto = true;
			this.nav6.UserID = null;
			this.nav6.VisibleGrid = true;
			this.nav6.Where = null;
			// 
			// p1
			// 
			this.p1.Controls.Add(this.vs2);
			this.p1.Controls.Add(this.panel15);
			this.p1.Dock = System.Windows.Forms.DockStyle.Top;
			this.p1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.p1.Location = new System.Drawing.Point(0, 0);
			this.p1.Name = "p1";
			this.p1.Size = new System.Drawing.Size(1014, 188);
			this.p1.TabIndex = 0;
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
			this.vs2.Size = new System.Drawing.Size(1014, 156);
			this.vs2.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.vs2.TabIndex = 33;
			// 
			// panel15
			// 
			this.panel15.Controls.Add(this.ckApplyAll);
			this.panel15.Controls.Add(this.cmd_show);
			this.panel15.Controls.Add(this.dt1);
			this.panel15.Controls.Add(this.lblNam);
			this.panel15.Controls.Add(this.nav2);
			this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel15.Location = new System.Drawing.Point(0, 0);
			this.panel15.Name = "panel15";
			this.panel15.Size = new System.Drawing.Size(1014, 32);
			this.panel15.TabIndex = 3;
			// 
			// ckApplyAll
			// 
			this.ckApplyAll.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ckApplyAll.Location = new System.Drawing.Point(280, 4);
			this.ckApplyAll.Name = "ckApplyAll";
			this.ckApplyAll.Size = new System.Drawing.Size(192, 24);
			this.ckApplyAll.TabIndex = 151;
			this.ckApplyAll.Tag = "";
			this.ckApplyAll.Text = "Apply to all";
			// 
			// cmd_show
			// 
			this.cmd_show.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmd_show.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_show.Location = new System.Drawing.Point(928, 4);
			this.cmd_show.Name = "cmd_show";
			this.cmd_show.Size = new System.Drawing.Size(75, 24);
			this.cmd_show.TabIndex = 150;
			this.cmd_show.Text = "Hiển thị";
			this.cmd_show.Click += new System.EventHandler(this.cmd_show_Click);
			// 
			// dt1
			// 
			this.dt1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.dt1.CustomFormat = "yyyy";
			this.dt1.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt1.Location = new System.Drawing.Point(820, 4);
			this.dt1.Name = "dt1";
			this.dt1.Size = new System.Drawing.Size(100, 23);
			this.dt1.TabIndex = 149;
			this.dt1.Tag = null;
			// 
			// lblNam
			// 
			this.lblNam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblNam.Location = new System.Drawing.Point(728, 8);
			this.lblNam.Name = "lblNam";
			this.lblNam.TabIndex = 32;
			this.lblNam.Text = "Năm";
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
			this.nav2.Location = new System.Drawing.Point(4, 0);
			this.nav2.MSG_Exit = false;
			this.nav2.MulltiDel = false;
			this.nav2.Name = "nav2";
			this.nav2.Security = 0;
			this.nav2.ShowPopupMenu = false;
			this.nav2.Size = new System.Drawing.Size(428, 32);
			this.nav2.TabIndex = 31;
			this.nav2.ToolBar_Auto = true;
			this.nav2.UserID = null;
			this.nav2.VisibleGrid = true;
			this.nav2.Where = null;
			// 
			// c1DockingTabPage3
			// 
			this.c1DockingTabPage3.Controls.Add(this.panel11);
			this.c1DockingTabPage3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.c1DockingTabPage3.ImageIndex = -1;
			this.c1DockingTabPage3.Location = new System.Drawing.Point(2, 28);
			this.c1DockingTabPage3.Name = "c1DockingTabPage3";
			this.c1DockingTabPage3.Size = new System.Drawing.Size(1014, 324);
			this.c1DockingTabPage3.TabIndex = 1;
			this.c1DockingTabPage3.Text = "Page3";
			this.c1DockingTabPage3.Visible = false;
			// 
			// panel11
			// 
			this.panel11.Controls.Add(this.panel14);
			this.panel11.Controls.Add(this.splitter3);
			this.panel11.Controls.Add(this.panel13);
			this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panel11.Location = new System.Drawing.Point(0, 0);
			this.panel11.Name = "panel11";
			this.panel11.Size = new System.Drawing.Size(1014, 324);
			this.panel11.TabIndex = 1;
			// 
			// panel14
			// 
			this.panel14.Controls.Add(this.vs4);
			this.panel14.Controls.Add(this.nav4);
			this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel14.Location = new System.Drawing.Point(231, 0);
			this.panel14.Name = "panel14";
			this.panel14.Size = new System.Drawing.Size(783, 324);
			this.panel14.TabIndex = 2;
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
			this.vs4.Size = new System.Drawing.Size(783, 292);
			this.vs4.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.vs4.TabIndex = 34;
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
			this.nav4.ShowPopupMenu = false;
			this.nav4.Size = new System.Drawing.Size(783, 32);
			this.nav4.TabIndex = 33;
			this.nav4.ToolBar_Auto = true;
			this.nav4.UserID = null;
			this.nav4.VisibleGrid = true;
			this.nav4.Where = null;
			// 
			// splitter3
			// 
			this.splitter3.Location = new System.Drawing.Point(228, 0);
			this.splitter3.Name = "splitter3";
			this.splitter3.Size = new System.Drawing.Size(3, 324);
			this.splitter3.TabIndex = 1;
			this.splitter3.TabStop = false;
			// 
			// panel13
			// 
			this.panel13.Controls.Add(this.vs3);
			this.panel13.Controls.Add(this.nav3);
			this.panel13.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel13.Location = new System.Drawing.Point(0, 0);
			this.panel13.Name = "panel13";
			this.panel13.Size = new System.Drawing.Size(228, 324);
			this.panel13.TabIndex = 0;
			// 
			// vs3
			// 
			this.vs3.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs3.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vs3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vs3.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs3.Location = new System.Drawing.Point(0, 32);
			this.vs3.Name = "vs3";
			this.vs3.Size = new System.Drawing.Size(228, 292);
			this.vs3.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.vs3.TabIndex = 33;
			// 
			// nav3
			// 
			this.nav3.BackColor = System.Drawing.SystemColors.Control;
			this.nav3.Connection = null;
			this.nav3.ConnectionDel = null;
			this.nav3.Dock = System.Windows.Forms.DockStyle.Top;
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
			this.nav3.Size = new System.Drawing.Size(228, 32);
			this.nav3.TabIndex = 32;
			this.nav3.ToolBar_Auto = true;
			this.nav3.UserID = null;
			this.nav3.VisibleGrid = true;
			this.nav3.Where = null;
			// 
			// c1DockingTabPage1
			// 
			this.c1DockingTabPage1.Controls.Add(this.panel16);
			this.c1DockingTabPage1.ImageIndex = -1;
			this.c1DockingTabPage1.Location = new System.Drawing.Point(2, 28);
			this.c1DockingTabPage1.Name = "c1DockingTabPage1";
			this.c1DockingTabPage1.Size = new System.Drawing.Size(1014, 324);
			this.c1DockingTabPage1.TabIndex = 2;
			this.c1DockingTabPage1.Text = "Page1";
			this.c1DockingTabPage1.Visible = false;
			// 
			// panel16
			// 
			this.panel16.Controls.Add(this.vs5);
			this.panel16.Controls.Add(this.nav5);
			this.panel16.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel16.Location = new System.Drawing.Point(0, 0);
			this.panel16.Name = "panel16";
			this.panel16.Size = new System.Drawing.Size(1014, 324);
			this.panel16.TabIndex = 0;
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
			this.vs5.Size = new System.Drawing.Size(1014, 292);
			this.vs5.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
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
			this.nav5.Size = new System.Drawing.Size(1014, 32);
			this.nav5.TabIndex = 34;
			this.nav5.ToolBar_Auto = true;
			this.nav5.UserID = null;
			this.nav5.VisibleGrid = true;
			this.nav5.Where = null;
			// 
			// splitter1
			// 
			this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
			this.splitter1.Location = new System.Drawing.Point(0, 280);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(1020, 4);
			this.splitter1.TabIndex = 1;
			this.splitter1.TabStop = false;
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.panel10);
			this.panel7.Controls.Add(this.splitter2);
			this.panel7.Controls.Add(this.panel9);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(1020, 280);
			this.panel7.TabIndex = 0;
			// 
			// panel10
			// 
			this.panel10.Controls.Add(this.txt9);
			this.panel10.Controls.Add(this.txt8);
			this.panel10.Controls.Add(this.nav1);
			this.panel10.Controls.Add(this.vs1);
			this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel10.Location = new System.Drawing.Point(391, 0);
			this.panel10.Name = "panel10";
			this.panel10.Size = new System.Drawing.Size(629, 280);
			this.panel10.TabIndex = 2;
			// 
			// txt9
			// 
			this.txt9.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt9.Location = new System.Drawing.Point(120, 4);
			this.txt9.MaxLength = 20;
			this.txt9.Name = "txt9";
			this.txt9.Size = new System.Drawing.Size(112, 23);
			this.txt9.TabIndex = 38;
			this.txt9.Tag = "DEP_NM";
			this.txt9.Text = "";
			this.txt9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt8_KeyDown);
			this.txt9.Leave += new System.EventHandler(this.textBox1_Leave);
			this.txt9.Enter += new System.EventHandler(this.textBox1_Enter);
			// 
			// txt8
			// 
			this.txt8.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt8.Location = new System.Drawing.Point(4, 4);
			this.txt8.MaxLength = 20;
			this.txt8.Name = "txt8";
			this.txt8.Size = new System.Drawing.Size(112, 23);
			this.txt8.TabIndex = 37;
			this.txt8.Tag = "DEP_ID";
			this.txt8.Text = "";
			this.txt8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt8_KeyDown);
			this.txt8.Leave += new System.EventHandler(this.textBox1_Leave);
			this.txt8.Enter += new System.EventHandler(this.textBox1_Enter);
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
			this.nav1.Location = new System.Drawing.Point(102, 124);
			this.nav1.MSG_Exit = false;
			this.nav1.MulltiDel = false;
			this.nav1.Name = "nav1";
			this.nav1.Security = 0;
			this.nav1.ShowPopupMenu = false;
			this.nav1.Size = new System.Drawing.Size(144, 32);
			this.nav1.TabIndex = 12;
			this.nav1.Tag = "";
			this.nav1.ToolBar_Auto = true;
			this.nav1.UserID = null;
			this.nav1.Visible = false;
			this.nav1.VisibleGrid = true;
			this.nav1.Where = null;
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
			this.vs1.Size = new System.Drawing.Size(620, 248);
			this.vs1.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.vs1.TabIndex = 11;
			this.vs1.AfterRowColChange += new C1.Win.C1FlexGrid.RangeEventHandler(this.vs1_AfterRowColChange);
			// 
			// splitter2
			// 
			this.splitter2.Location = new System.Drawing.Point(388, 0);
			this.splitter2.Name = "splitter2";
			this.splitter2.Size = new System.Drawing.Size(3, 280);
			this.splitter2.TabIndex = 1;
			this.splitter2.TabStop = false;
			// 
			// panel9
			// 
			this.panel9.Controls.Add(this.txt2);
			this.panel9.Controls.Add(this.txt1);
			this.panel9.Controls.Add(this.nav);
			this.panel9.Controls.Add(this.vs);
			this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel9.Location = new System.Drawing.Point(0, 0);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(388, 280);
			this.panel9.TabIndex = 0;
			// 
			// txt2
			// 
			this.txt2.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt2.Location = new System.Drawing.Point(120, 4);
			this.txt2.MaxLength = 20;
			this.txt2.Name = "txt2";
			this.txt2.Size = new System.Drawing.Size(112, 23);
			this.txt2.TabIndex = 35;
			this.txt2.Tag = "DEP_NM";
			this.txt2.Text = "";
			this.txt2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
			this.txt2.Leave += new System.EventHandler(this.textBox1_Leave);
			this.txt2.Enter += new System.EventHandler(this.textBox1_Enter);
			// 
			// txt1
			// 
			this.txt1.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt1.Location = new System.Drawing.Point(4, 4);
			this.txt1.MaxLength = 20;
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(112, 23);
			this.txt1.TabIndex = 34;
			this.txt1.Tag = "DEP_ID";
			this.txt1.Text = "";
			this.txt1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
			this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
			this.txt1.Leave += new System.EventHandler(this.textBox1_Leave);
			this.txt1.Enter += new System.EventHandler(this.textBox1_Enter);
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
			this.nav.Location = new System.Drawing.Point(140, 96);
			this.nav.MSG_Exit = false;
			this.nav.MulltiDel = false;
			this.nav.Name = "nav";
			this.nav.Security = 0;
			this.nav.ShowPopupMenu = false;
			this.nav.Size = new System.Drawing.Size(144, 32);
			this.nav.TabIndex = 9;
			this.nav.Tag = "";
			this.nav.ToolBar_Auto = true;
			this.nav.UserID = null;
			this.nav.Visible = false;
			this.nav.VisibleGrid = true;
			this.nav.Where = null;
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
			this.vs.Location = new System.Drawing.Point(4, 32);
			this.vs.Name = "vs";
			this.vs.Size = new System.Drawing.Size(380, 248);
			this.vs.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.vs.TabIndex = 10;
			this.vs.Click += new System.EventHandler(this.vs_Click);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.panel3.Controls.Add(this.cmd_all);
			this.panel3.Controls.Add(this.cmd_clear);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.panel4);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1020, 36);
			this.panel3.TabIndex = 4;
			// 
			// cmd_all
			// 
			this.cmd_all.BackColor = System.Drawing.Color.Moccasin;
			this.cmd_all.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_all.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmd_all.Location = new System.Drawing.Point(8, 4);
			this.cmd_all.Name = "cmd_all";
			this.cmd_all.Size = new System.Drawing.Size(108, 28);
			this.cmd_all.TabIndex = 147;
			this.cmd_all.Text = "ALLL";
			this.cmd_all.Click += new System.EventHandler(this.cmd_all_Click);
			// 
			// cmd_clear
			// 
			this.cmd_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmd_clear.BackColor = System.Drawing.Color.Moccasin;
			this.cmd_clear.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_clear.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmd_clear.Location = new System.Drawing.Point(908, 4);
			this.cmd_clear.Name = "cmd_clear";
			this.cmd_clear.Size = new System.Drawing.Size(108, 28);
			this.cmd_clear.TabIndex = 146;
			this.cmd_clear.Text = "Clear";
			this.cmd_clear.Click += new System.EventHandler(this.cmd_clear_Click);
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Location = new System.Drawing.Point(8, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(1012, 36);
			this.label5.TabIndex = 11;
			this.label5.Tag = "";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(8, 36);
			this.panel4.TabIndex = 10;
			// 
			// frmTaLichTrinhBoPhan
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(1020, 676);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaLichTrinhBoPhan";
			this.Text = "frmTaLichTrinhBoPhan";
			this.Load += new System.EventHandler(this.frmTaLichTrinhBoPhan_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.panel12.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.c1DockingTab2)).EndInit();
			this.c1DockingTab2.ResumeLayout(false);
			this.c1DockingTabPage2.ResumeLayout(false);
			this.p2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs6)).EndInit();
			this.panel5.ResumeLayout(false);
			this.p1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs2)).EndInit();
			this.panel15.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dt1)).EndInit();
			this.c1DockingTabPage3.ResumeLayout(false);
			this.panel11.ResumeLayout(false);
			this.panel14.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs4)).EndInit();
			this.panel13.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs3)).EndInit();
			this.c1DockingTabPage1.ResumeLayout(false);
			this.panel16.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs5)).EndInit();
			this.panel7.ResumeLayout(false);
			this.panel10.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs1)).EndInit();
			this.panel9.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaLichTrinhBoPhan_Load(object sender, System.EventArgs e)
		{		
			Init_Form();					
			Init_Menu();			
		}
		#region Init_menu
		private ContextMenu mnu1;
		private void Init_Menu()
		{			
			mnu1=new ContextMenu();
			nav2.cmd_report.Style=ToolBarButtonStyle.DropDownButton;
			nav2.cmd_report.DropDownMenu =mnu1;
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
					rpt.RPT2(c1XLBook1,vs2,mnu1.MenuItems[mnu1.MenuItems.IndexOf((MenuItem)sender)].Text,"STD_TA_01");					
					break;
				
			}
		}
		#endregion
		
		#region Init Form
		private void Init_Form()
		{					
			//Dep.Init_Tree(this.Tag+"");
			//Dep.vs1.AfterRowColChange+=new C1.Win.C1FlexGrid.RangeEventHandler(Depvs1_AfterRowColChange);
			//Dep.Show_Tree();

			try
			{
				Init_vs();	
				Init_vs1();

				//--page2: vs2 = vs | vs6 = vs4
				//--page3: vs3 = vs1| vs4 = vs2
				//--page1: vs5 = vs5
				dt1.Value=T_String.GetDate();
				Init_vs2();	
				Init_vs3();	
				Init_vs4();	
				Init_vs5();	
				Init_vs6();				

				for(int i=1;i<32;i++)
				{
					vs2.Cols["h"+i].Caption=i+"";
				}				
			
				c1DockingTab2.SelectedIndex=0;
				vs2.AutoSizeCols();
				Init_CB();
				Basic.Function.PublicFunction.L_Init_Label(this);
				//			if(T_String.GetDataFromSQL("WEE_BY","FILC14A")=="True")
				//			{
				//				r2.Checked=true;
				//				p1.Visible=false;
				//				p2.Visible=!p1.Visible;
				//				p2.Dock=DockStyle.Fill;
				//				nav4.Show_VS();
				//			}
				//			else
				//			{
				//r1.Checked=true;
				p1.Visible=true;
				panel5.Visible = true;
				p2.Visible=!p1.Visible;
				p1.Dock=DockStyle.Fill;
				show_vs2();				
				//}
			}
			catch(Exception ex)
			{
				MessageBox.Show("***"+ex.ToString());
			}
		}

		private void Init_vs6()
		{			
			PublicFunction.InitNav(this,vs6,nav6);							
			vs6.SelectionMode=C1.Win.C1FlexGrid.SelectionModeEnum.CellRange; 
			nav6.cmd_add.Visible=nav6.cmd_delete.Visible=
				nav6.cmd_search.Visible=nav6.cmd_copy.Visible=nav6.cmd_report.Visible=false;									
			vs6.AfterEdit+=new C1.Win.C1FlexGrid.RowColEventHandler(vs6_AfterEdit);						
		}

		private void Init_vs5()
		{
			PublicFunction.InitNav(this,vs5,nav5);				
			if(PublicFunction.A_UserID.ToUpper()!="ADMIN" && PublicFunction.A_UserID.ToUpper()!="VINHTUYEN")
				vs5.Cols["SQL_DR"].Visible=false;
			nav5.Show_VS();
			nav5.cmd_search.Visible=nav5.cmd_copy.Visible=nav5.cmd_report.Visible=false;			
		}

		private void Init_vs4()
		{
			PublicFunction.InitNav(this,vs4,nav4);							
			nav4.cmd_search.Visible=nav4.cmd_copy.Visible=nav4.cmd_report.Visible=false;						
			nav4.TBarClick+=new ToolBarButtonClickEventHandler(nav4_TBarClick);
			nav4.ToolBar_Auto=false;
			vs4.Cols["COL_MM1"].ComboList="|...";
			vs4.Cols["COL_MM2"].ComboList="|...";
			vs4.Cols["FUN_ID"].ComboList="|...";
			vs4.CellButtonClick+=new C1.Win.C1FlexGrid.RowColEventHandler(vs4_CellButtonClick);
			vs4.AfterEdit+=new C1.Win.C1FlexGrid.RowColEventHandler(vs4_AfterEdit);
		}
		private void Init_vs2()
		{			
			PublicFunction.InitNav(this,vs2,nav2);							
			vs2.SelectionMode=C1.Win.C1FlexGrid.SelectionModeEnum.CellRange; 
			nav2.cmd_add.Visible=nav2.cmd_delete.Visible=
				nav2.cmd_search.Visible=nav2.cmd_copy.Visible=nav2.cmd_report.Visible=false;						
			vs2.Styles.Add("CN");
			vs2.Styles["CN"].BackColor=Color.Silver;			
			vs2.Styles.Add("bt");
			vs2.AfterEdit+=new C1.Win.C1FlexGrid.RowColEventHandler(vs2_AfterEdit);
			vs2.EnabledChanged+=new EventHandler(vs2_EnabledChanged);
			nav2.ToolBar_Auto=false;
			nav2.TBarClick+=new ToolBarButtonClickEventHandler(nav2_TBarClick);	
					
			
		}

		private void Init_vs3()
		{
			PublicFunction.InitNav(this,vs3,nav3);				
			nav3.Show_VS();
			nav3.cmd_fisrt.Visible=nav3.cmd_last.Visible=nav3.cmd_search.Visible=
				nav3.cmd_copy.Visible=nav3.cmd_report.Visible=false;
			vs3.AfterRowColChange+=new C1.Win.C1FlexGrid.RangeEventHandler(vs3_AfterRowColChange);			
			nav3.TBarClick+=new ToolBarButtonClickEventHandler(nav3_TBarClick);
		}

		private void Init_vs()
		{
			nav.cmd_save.Visible=nav.cmd_search.Visible=nav.cmd_report.Visible=nav.cmd_delete.Visible=nav.cmd_add.Visible=nav.cmd_copy.Visible=false;
			PublicFunction.InitNav(this,vs,nav);
			vs.AllowEditing=false;						
			vs.DoubleClick+=new EventHandler(vs_DoubleClick);
			vs.SelectionMode=C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;	
			vs.EnabledChanged+=new EventHandler(vs_EnabledChanged);
			nav.Show_VS("1=1");
		}	
		private void Init_vs1()
		{			
			PublicFunction.InitNav(this,vs1,nav1);
			vs1.AllowEditing=false;				
			vs1.SelectionMode=C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;		
			vs1.DoubleClick+=new EventHandler(vs1_DoubleClick);			
		}	
	
		
		private void vs_EnabledChanged(object sender, EventArgs e)
		{
			txt1.Text=vs.Cols[txt1.Tag+""].Caption;
			txt2.Text=vs.Cols[txt2.Tag+""].Caption;			
			txt8.Text=vs.Cols[txt8.Tag+""].Caption;
			txt9.Text=vs.Cols[txt9.Tag+""].Caption;

//			txt5.Text=vs.Cols[txt5.Tag+""].Caption;
//			txt6.Text=vs.Cols[txt6.Tag+""].Caption;
//			txt7.Text=vs.Cols[txt7.Tag+""].Caption;
//			txt8.Text=vs.Cols[txt5.Tag+""].Caption;
//			txt9.Text=vs.Cols[txt6.Tag+""].Caption;
//			txt10.Text=vs.Cols[txt7.Tag+""].Caption;
		}

		private void Init_CB()
		{
			vs2.Cols["h1"].DataMap=PublicFunction.InitCBForVS("Select GRP_FO,GRP_NM from FILC12A");
			for(int i=2;i<32;i++)
			{

				vs2.Cols["h"+i].DataMap=vs2.Cols["h1"].DataMap;
			}
			for(int i=1;i<8;i++)
			{

				vs6.Cols["h"+i].DataMap=vs2.Cols["h1"].DataMap;
			}
		}
		#endregion
		#region  event
		private void cmd_all_Click(object sender, System.EventArgs e)
		{
			for(int j=1;j<vs.Rows.Count;j++)
			{
				int i;
				for(i=1;i<vs1.Rows.Count;i++)
				{
					if(	vs1.Rows[i]["DEP_ID"]+""==vs.Rows[j]["DEP_ID"]+"")
						break;
				}
				if(i>=vs1.Rows.Count)
				{
					vs1.Rows.Count++;
					vs1.Rows[vs1.Rows.Count-1][0]=vs1.Rows.Count-1;
					for(int m=1;m<vs.Cols.Count;m++)
					{
						//vs1.Rows[vs1.Rows.Count-1][m]=vs.Rows[j][m];
						vs1.Rows[vs1.Rows.Count-1][vs.Cols[m].Name]=vs.Rows[j][m];
						
					}
				}
			}					
			//cmd_ok.Enabled=vs1.Rows.Count>1;
		}
		
//		private void Depvs1_AfterRowColChange(object sender, C1.Win.C1FlexGrid.RangeEventArgs e)
//		{
//			if(e.OldRange.r1!=e.NewRange.r1)
//			{
//				Show_VS();
//				Show_VS2();
//			}
//		}
		private void vs_DoubleClick(object sender, EventArgs e)
		{		
			if(vs.Row>0)
			{
				for(int i=1;i<vs1.Rows.Count;i++)
				{
					if(	vs1.Rows[i]["DEP_ID"]+""==vs.Rows[vs.Row]["DEP_ID"]+"")
						return;
				}
				vs1.Rows.Count++;
				vs1.Rows[vs1.Rows.Count-1][0]=vs1.Rows.Count-1;
				for(int i=1;i<vs.Cols.Count;i++)
				{
					vs1.Rows[vs1.Rows.Count-1][vs.Cols[i].Name]=vs.Rows[vs.Row][i];
				}
			}			
			//cmd_ok.Enabled=vs1.Rows.Count>1;
		}
		private void vs1_DoubleClick(object sender, EventArgs e)
		{		
			if(vs1.Row>0)
				vs1.RemoveItem(vs1.Row);
			//cmd_ok.Enabled=vs1.Rows.Count>1;
		}
		private void cmd_clear_Click(object sender, System.EventArgs e)
		{
			vs1.Rows.Count=1;
			//cmd_ok.Enabled=vs1.Rows.Count>1;
		}
		#endregion
		#region Search
		private void textBox1_Enter(object sender, System.EventArgs e)
		{
			TextBox txt=(TextBox)sender;
			if (txt.Text==vs.Cols[txt.Tag+""].Caption)
				txt.Text="";
		}

		private void textBox1_Leave(object sender, System.EventArgs e)
		{
			TextBox txt=(TextBox)sender;
			if (txt.Text=="")
				txt.Text=vs.Cols[txt.Tag+""].Caption;
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
				sql= sql;//+" and DEP_ID in (Select DEP_ID  from SYS_SECURITY_DEP"+
				//	" where MNU_ID="+this.Tag+" and ALL_BT=1  and USER_ID=N'"+PublicFunction.A_UserID+"')";					
				nav.Show_VS(sql);						
			}
		}

		private void txt8_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Enter)
			{
				string f=((TextBox)sender).Tag+"";				
				string sql;				
				if(((TextBox)sender).Text+""!="")
					sql=f+" like N'%"+((TextBox)sender).Text+"%'";
				else
					sql="1=1";
				sql= sql;//+" and DEP_ID in (Select DEP_ID  from SYS_SECURITY_DEP"+
					//" where MNU_ID="+this.Tag+" and ALL_BT=1  and USER_ID=N'"+PublicFunction.A_UserID+"')";					
				nav1.Show_VS(sql);						
			}
			//cmd_ok.Enabled=vs1.Rows.Count>1;
		}


		private void txt5_Enter(object sender, System.EventArgs e)
		{			
			TextBox txt=(TextBox)sender;
			if (txt.Text==vs2.Cols[txt.Tag+""].Caption)
				txt.Text="";
		}

		private void txt5_Leave(object sender, System.EventArgs e)
		{
			TextBox txt=(TextBox)sender;
			if (txt.Text=="")
				txt.Text=vs2.Cols[txt.Tag+""].Caption;
		}

		private void txt5_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Enter)
			{
				string f=((TextBox)sender).Tag+"";
				if(f=="EMP_ID")
					f="a."+f;
				string sql;				
				if(((TextBox)sender).Text+""!="")
					sql=f+" like N'%"+((TextBox)sender).Text+"%'";
				else
					sql="1=1";
				sql=sql;//+" and  (DEL_BT=0 or DEL_BT is null) and DEP_ID in (Select DEP_ID  from SYS_SECURITY_DEP"+
					//" where MNU_ID="+this.Tag+" and ALL_BT=1 and USER_ID=N'"+PublicFunction.A_UserID+"')";								
				nav2.Show_VS(sql);		
			}
		}
		private void txt1_TextChanged(object sender, System.EventArgs e)
		{
		
		}
		private void vs_Click(object sender, System.EventArgs e)
		{
		
		}
		#endregion	
		#region ShowData
//		private void Show_VS()
//		{
//			if(Dep.vs1.Row<=0)
//			{
//				vs.Rows.Count=1;
//				return;
//			}
//			nav.Show_VS("DEP_ID=N'"+Dep.Get_Data("DEP_ID")+"' and (VAC_BT=0 or VAC_BT is null)");				
//		}		
//		private void Show_VS2()
//		{
//			if(Dep.vs1.Row<=0)
//			{
//				vs2.Rows.Count=1;
//				return;
//			}
//			string sql="";
//			sql="DEP_ID=N'"+Dep.Get_Data("DEP_ID")+"' and (VAC_BT=0 or VAC_BT is null) ";			
//			nav2.Show_VS(sql);				
//		}	
		#endregion


		#region show
		private void show_vs4()
		{
			nav4.Show_VS("GRP_FO=N'"+vs3.Rows[vs3.Row]["GRP_FO"]+"'");
		}
		
		private void show_vs2()
		{
			if(vs1.Row > 0)
			{
				insert();
				nav2.Show_VS(string.Format("YYY_YY=N'{0}' and DEP_ID = N'{1}'",dt1.Text,vs1.GetDataDisplay(vs1.Row,"DEP_ID")));
				//nav2.Show_VS("YYY_YY=N'"+dt1.Text+"'");
				show_cn();	
			}
		}

		private void vs3_AfterRowColChange(object sender, C1.Win.C1FlexGrid.RangeEventArgs e)
		{
			if(e.NewRange.r1!=e.OldRange.r1)
				show_vs4();
		}

		private void insert()
		{
			
				if(vs1.GetDataDisplay(vs1.Row,"DEP_ID") == "")
					return;
			
				string sql;
				if(T_String.IsNullTo0(T_String.GetDataFromSQL("COUNT(*)","FILC13A",string.Format("YYY_YY=N'{0}' and DEP_ID = N'{1}'",dt1.Text,vs1.GetDataDisplay(vs1.Row,"DEP_ID"))))==0)
				{
					for(int i=1;i<13;i++)
					{
						sql=string.Format("Insert Into FILC13A(YYY_YY,MMM_MM,DEP_ID) values(N'{0}',{1},'{2}')",dt1.Text,i,vs1.GetDataDisplay(vs1.Row,"DEP_ID"));
						PublicFunction.SQL_Execute(sql);
					}				
				}			
		}		

		private void show_cn()
		{
			for(int m=1;m<vs2.Rows.Count;m++)
			{
				for(int i=1;i<=31;i++)
				{
					try
					{
						DateTime d=new DateTime(T_String.IsNullTo0(vs2.Rows[m]["YYY_YY"]+""),
							T_String.IsNullTo0(vs2.Rows[m]["MMM_MM"]+""),i);
						if(d.DayOfWeek==System.DayOfWeek.Sunday)
						{
							vs2.SetCellStyle(m,vs2.Cols["h"+i].Index,vs2.Styles["CN"]);							
						}
						else
						{
							vs2.SetCellStyle(m,vs2.Cols["h"+i].Index,vs2.Styles["bt"]);;
						}
					}
					catch{}
				}
			
			}
		}
		#endregion

		#region event
		private void nav4_TBarClick(object sender, ToolBarButtonClickEventArgs e)
		{				
			if (e.Button.Equals(nav4.cmd_add))
			{
				if(vs3.Row>0 && vs3.Rows[vs3.Row].UserData+""!="2")
				{
					nav4.ToolBar_Click(e);			
					vs4.Rows[vs4.Rows.Count-1]["GRP_FO"]=vs3.Rows[vs3.Row]["GRP_FO"];
					int t=T_String.GetMax("max(FOR_ID)","FILC12B","GRP_FO=N'"+vs3.Rows[vs3.Row]["GRP_FO"]+"'");
					vs4.Rows[vs4.Rows.Count-1]["FOR_ID"]=t+"";
					vs4.Rows[vs4.Rows.Count-1]["BLT_NM"]=PublicFunction.A_UserID;
					vs4.Rows[vs4.Rows.Count-1]["BLT_DT"]=T_String.GetDate().ToString("yyyy/MM/dd HH:mm");
				
				}				
				return;
			}		
			if (e.Button.Equals(nav4.cmd_save))
			{
				for (int i=1;i<vs4.Rows.Count;i++)
				{
					vs4.Rows[i]["SEQ_NO"]=i.ToString("000");
					if (vs4.Rows[i].UserData+""!="2")					
						vs4.Rows[i].UserData=1;					
				}	
				nav4.ToolBar_Click(e);
				return;
			}
			nav4.ToolBar_Click(e);				
		}

		private void nav3_TBarClick(object sender, ToolBarButtonClickEventArgs e)
		{			
			if (e.Button.Equals(nav3.cmd_save))
			{
				Init_CB();				
				return;
			}
			
		}
		private void nav2_TBarClick(object sender, ToolBarButtonClickEventArgs e)
		{			
			if (e.Button.Equals(nav2.cmd_refresh))
			{
				show_vs2();		
				return;
			}
			SaveByDep();
			//nav2.ToolBar_Click(e);	
			if (e.Button.Equals(nav2.cmd_save))
			{
				if(ckApplyAll.Checked)
					SaveToAllDep();						
			}	
		}
		
		private void SaveToAllDep()
		{
			string strMaBoPhanCurrent = vs1.GetDataDisplay(vs1.Row,"DEP_ID");
			string sql = string.Format("select * from FILC13A where DEP_ID = '{0}'",strMaBoPhanCurrent);
			Func.RecordSet rs=new Func.RecordSet(sql,PublicFunction.C_con);
			ArrayList arrListChon = GetBoPhanChon();
			for(int x = 0; x < arrListChon.Count; x++)
			{
				string maBoPhanNew = arrListChon[x].ToString();
				//delete
				string sqlDelete = string.Format("delete from  FILC13A where DEP_ID = '{0}'",maBoPhanNew);
				PublicFunction.SQL_Execute(sqlDelete,PublicFunction.C_con);

				for(int y = 0; y < rs.rows; y++)
				{
					string strValue = BuildDataQuery(rs,y,maBoPhanNew);
					string sqlInsert = string.Format("INSERT INTO FILC13A( " +
					"YYY_YY,MMM_MM,DEP_ID,h1,h2,h3,h4,h5,h6,h7,h8,h9,h10,h11,h12,h13,h14,h15,h16," +
					"h17,h18,h19,h20,h21,h22,h23,h24,h25,h26,h27,h28,h29,h30,h31,BLT_NM,BLT_DT,LST_NM,LST_DT) " +
					"VALUES({0})",strValue);
					PublicFunction.SQL_Execute(sqlInsert,PublicFunction.C_con);
				}
			}	
		}

		private void SaveByDep()
		{
			try	
			{
				int idxRow = 0;
				for(int y =0; y < vs2.Rows.Count-1;y++)
				{
					idxRow = y+1;
					string yyy = vs2.GetData(idxRow,"YYY_YY").ToString();
					//string yyy = vs2.GetDataDisplay(idxRow,"YYY_YY") ;
					string maBoPhan = vs1.GetDataDisplay(vs1.Row,"DEP_ID");
					string mm =  vs2.GetDataDisplay(idxRow,"MMM_MM");
					string d1 =  vs2.GetDataDisplay(idxRow,"h1");
					string d2 =  vs2.GetDataDisplay(idxRow,"h2");
					string d3 =  vs2.GetDataDisplay(idxRow,"h3");
					string d4 =  vs2.GetDataDisplay(idxRow,"h4") ;
					string d5 =  vs2.GetDataDisplay(idxRow,"h5");
					string d6 = vs2.GetDataDisplay(idxRow,"h6");
					string d7 =  vs2.GetDataDisplay(idxRow,"h7");
					string d8 = vs2.GetDataDisplay(idxRow,"h8");
					string d9 =  vs2.GetDataDisplay(idxRow,"h9");
					string d10 =  vs2.GetDataDisplay(idxRow,"h10");
					string d11 =  vs2.GetDataDisplay(idxRow,"h11");
					string d12 =  vs2.GetDataDisplay(idxRow,"h12");
					string d13 =  vs2.GetDataDisplay(idxRow,"h13") ;
					string d14 =  vs2.GetDataDisplay(idxRow,"h14");
					string d15 =  vs2.GetDataDisplay(idxRow,"h15") ;
					string d16 =  vs2.GetDataDisplay(idxRow,"h16") ;
					string d17 =  vs2.GetDataDisplay(idxRow,"h17") ;
					string d18 =  vs2.GetDataDisplay(idxRow,"h18") ;
					string d19 =  vs2.GetDataDisplay(idxRow,"h19") ;
					string d20 =  vs2.GetDataDisplay(idxRow,"h20");
					string d21 =  vs2.GetDataDisplay(idxRow,"h21") ;
					string d22 =  vs2.GetDataDisplay(idxRow,"h22");
					string d23 =  vs2.GetDataDisplay(idxRow,"h23") ;
					string d24 = vs2.GetDataDisplay(idxRow,"h24") ;
					string d25 =  vs2.GetDataDisplay(idxRow,"h25");
					string d26 =  vs2.GetDataDisplay(idxRow,"h26") ;
					string d27 = vs2.GetDataDisplay(idxRow,"h27") ;
					string d28 =  vs2.GetDataDisplay(idxRow,"h28") ;
					string d29 =  vs2.GetDataDisplay(idxRow,"h29") ;
					string d30 = vs2.GetDataDisplay(idxRow,"h30") ;
					string d31 =  vs2.GetDataDisplay(idxRow,"h31");

					//string sqlDelete = string.Format("delete from  FILC13A where DEP_ID = {0}",maBoPhan);
					//PublicFunction.SQL_Execute(sqlDelete,PublicFunction.C_con);

					string sqlUpdate = string.Format("update filc13a set " +
						"h1='{0}',h2='{1}',h3='{2}',h4='{3}',h5='{4}',h6='{5}',h7='{6}',h8='{7}',h9='{8}',h10='{9}',h11='{10}'" +
						",h12='{11}',h13='{12}',h14='{13}',h15='{14}',h16='{15}',h17='{16}',h18='{17}',h19='{18}',h20='{19}',h21='{20}',h22='{21}'" +
						",h23='{22}',h24='{23}',h25='{24}',h26='{25}',h27='{26}',h28='{27}',h29='{28}',h30='{29}',h31='{30}'" +
						",LST_NM = '{31}',LST_DT='{32}' where DEP_ID ='{33}' and YYY_YY ='{34}' and MMM_MM='{35}' ",d1,d2,d3,d4,d5,d6,d7,d8,d9,d10,
						d11,d12,d13,d14,d15,d16,d17,d18,d19,d20,d21,d22,d23,d24,d25,d26,d27,d28,d29,d30,d31,PublicFunction.A_UserID,DateTime.Now.ToString("yyyy-MM-dd"),maBoPhan,yyy,mm);

					//				string sqlInsert = string.Format("INSERT INTO FILC13A( " +
					//					"YYY_YY,MMM_MM,DEP_ID,h1,h2,h3,h4,h5,h6,h7,h8,h9,h10,h11,h12,h13,h14,h15,h16," +
					//					"h17,h18,h19,h20,h21,h22,h23,h24,h25,h26,h27,h28,h29,h30,h31,BLT_NM,BLT_DT,LST_NM,LST_DT) " +
					//					"VALUES({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20}"+
					//					",{21},{22},{23},{24},{25},{26},{27},{28},{29},{30},{31},{32},{33},{34},{35},{36},{37})",
					//					yyy,mm,maBoPhan,d1,d2,d3,d4,d5,d6,d7,d8,d9,d10,d11,d12,d13,d14,d15,d16,d17,d18,d19,d20,d21,d22,
					//					d23,d24,d25,d26,d27,d28,d29,d30,d31,"''","''","'" +PublicFunction.A_UserID+"'","'"+DateTime.Now.ToString("yyyy-MM-dd")+"'");
					PublicFunction.SQL_Execute(sqlUpdate,PublicFunction.C_con);

				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}

		}

		private string BuildDataQuery(Func.RecordSet rsData,int idxRow,string boPhan)
		{
			string result = "";
			for(int x = 0; x < rsData.cols;x++)		
			{
				if(x != 2)
				{
					string v = rsData.record(idxRow,x);
					if(x== 35 || x == 37)
					{
						v = Convert.ToDateTime(rsData.record(idxRow,x)).ToString("yyyy-MM-dd");
						v = v =="0001-01-01" ? "1900-01-01" : v;
					}
					
					if(result == "")
						result = string.Format("'{0}'",v);
					else
						result += string.Format(",'{0}'",v);
				}					
				else
					result += string.Format(",'{0}'",boPhan);
			}
			return result;
		}

		private void vs4_CellButtonClick(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			if(vs4.Cols[e.Col].Name=="FUN_ID")
			{
				Func.RecordSet rs=new Func.RecordSet("select FUN_ID,FUN_NM from FILC11A",PublicFunction.C_con);
				frmSearch dlg1=new frmSearch(rs,2,this.Name+"_vs5");
				if(dlg1.ShowDialog()==DialogResult.OK)
				{
					vs4.Rows[e.Row]["FUN_ID"]=rs.record(rs.Bookmarks,"FUN_ID");
					vs4.Rows[e.Row]["FUN_NM"]=rs.record(rs.Bookmarks,"FUN_NM");
				}
				return;
			}
			frmTaAddfor dlg=new frmTaAddfor();
			if(dlg.ShowDialog()==DialogResult.OK)
			{
				vs4.Rows[e.Row][e.Col]=dlg.COL_MM;
				if(vs4.Cols[e.Col].Name=="COL_MM1")
					vs4.Rows[e.Row]["COL_NM1"]=dlg.COL_NM;
				else
					vs4.Rows[e.Row]["COL_NM2"]=dlg.COL_NM;
			}
		}

		private void vs4_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			vs4.Rows[e.Row]["LST_NM"]=PublicFunction.A_UserID;
			vs4.Rows[e.Row]["LST_DT"]=T_String.GetDate().ToString("yyyy/MM/dd HH:mm");
			if(vs4.Cols[e.Col].Name=="FUN_ID" && vs4.Rows[e.Row]["FUN_ID"]+""=="")
				vs4.Rows[e.Row]["FUN_NM"]="";
			if(vs4.Cols[e.Col].Name=="COL_MM1" && vs4.Rows[e.Row]["COL_MM1"]+""=="")
				vs4.Rows[e.Row]["COL_NM1"]="";
			if(vs4.Cols[e.Col].Name=="COL_MM2" && vs4.Rows[e.Row]["COL_MM2"]+""=="")
				vs4.Rows[e.Row]["COL_NM2"]="";
		}
		private void vs2_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			string dd=T_String.GetDate().ToString("yyyy/MM/dd HH:mm");
			vs2.Rows[e.Row]["LST_NM"]=PublicFunction.A_UserID;
			vs2.Rows[e.Row]["LST_DT"]=dd;			
			for (int i=vs2.Selection.r1;i<=vs2.Selection.r2;i++)
			{
				for (int j=vs2.Selection.c1;j<=vs2.Selection.c2;j++)
				{
					if (PublicFunction.S_Left(vs2.Cols[j].Name,1) =="h")
					{
						vs2[i,j ]=vs2[e.Row,e.Col];
						vs2.Rows[i].UserData=1;
						vs2.Rows[i]["LST_NM"]=PublicFunction.A_UserID;
						vs2.Rows[i]["LST_DT"]=dd;
					}
				}
			}		
			vs2.AutoSizeCols();
		}

		private void vs6_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			string dd=T_String.GetDate().ToString("yyyy/MM/dd HH:mm");
			vs6.Rows[e.Row]["LST_NM"]=PublicFunction.A_UserID;
			vs6.Rows[e.Row]["LST_DT"]=dd;			
			for (int i=vs6.Selection.r1;i<=vs6.Selection.r2;i++)
			{
				for (int j=vs6.Selection.c1;j<=vs6.Selection.c2;j++)
				{
					if (PublicFunction.S_Left(vs6.Cols[j].Name,1) =="h")
					{
						vs6[i,j ]=vs6[e.Row,e.Col];
						vs6.Rows[i].UserData=1;
						vs6.Rows[i]["LST_NM"]=PublicFunction.A_UserID;
						vs6.Rows[i]["LST_DT"]=dd;
					}
				}
			}		
			vs6.AutoSizeCols();
		}

		private void cmd_show_Click(object sender, System.EventArgs e)
		{
			
			show_vs2();				
		}

		private void vs2_EnabledChanged(object sender, EventArgs e)
		{
			for(int i=1;i<32;i++)
			{
				vs2.Cols["h"+i].Caption=i+"";
			}
		}
		#endregion

		private void cb_DEP_ID_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}

//		private void r1_CheckedChanged(object sender, System.EventArgs e)
//		{
//			if(r1.Checked)
//			{
//				p1.Visible=true;
//				p2.Visible=!p1.Visible;
//				p1.Dock=DockStyle.Fill;
//				show_vs();
//				PublicFunction.SQL_Execute("update FILC14A set WEE_BY=0");
//			}
//			else
//			{
//				p1.Visible=false;
//				p2.Visible=!p1.Visible;
//				p2.Dock=DockStyle.Fill;
//				string sql;
//				if(T_String.IsNullTo0(T_String.GetDataFromSQL("COUNT(*)","FILC14A"))<=0)
//				{					
//					sql="Insert Into FILC14A(YYY_YY,WEE_BY) values(N'qtan',"+1+")";
//					PublicFunction.SQL_Execute(sql);					
//				}
//				nav4.Show_VS();
//				PublicFunction.SQL_Execute("update FILC14A set WEE_BY=1");
//			}
//		}

		private ArrayList GetBoPhanChon()
		{
			ArrayList arrListMaBoPhan=new ArrayList();
			for (int x=1; x< vs1.Rows.Count; x++)			
				arrListMaBoPhan.Add(vs1.Rows[x]["DEP_ID"].ToString());
			return arrListMaBoPhan;
		}

		private void vs1_AfterRowColChange(object sender, C1.Win.C1FlexGrid.RangeEventArgs e)
		{
			if(vs1.Rows.Count>1)
			{
				show_vs2();
				cmd_show.Enabled = true;
			}			
			else
				cmd_show.Enabled = false;
		}
	}
}



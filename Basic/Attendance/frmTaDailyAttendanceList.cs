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
using GP8000.Personnel.Report;

namespace GP8000.Attendance
{
	/// <summary>
	/// Summary description for frmTaDailyAttendanceList.
	/// </summary>
	public class frmTaDailyAttendanceList : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private C1.Win.C1Command.C1CommandDock c1CommandDock1;
		private C1.Win.C1Command.C1DockingTab c1DockingTab1;
		private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage1;
		private GP8000.UserControl.CrtTaDepartment Dep;
		private System.Windows.Forms.Panel panel5;
		private C1.Win.C1FlexGrid.C1FlexGrid vs;
		private Navigator1._0.NavigatorAuto nav;
		private C1.Win.C1Input.C1DateEdit dt1;
		private C1.Win.C1Input.C1DateEdit dt2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt2;
		private System.Windows.Forms.TextBox txt1;
		private System.Windows.Forms.CheckBox ck;
		private System.Windows.Forms.Button cmd_edit;
		private System.Windows.Forms.Button cmd_cal;
		private System.Windows.Forms.Button cmd_save;
		private System.Windows.Forms.Button cmd_un;
		private System.Windows.Forms.CheckBox ck_lat;
		private System.Windows.Forms.CheckBox ck_ear;
		private System.Windows.Forms.CheckBox ck_lea;
		private System.Windows.Forms.CheckBox ck_sig;
		private System.Windows.Forms.CheckBox ck_abs;
		private System.Windows.Forms.CheckBox ck_vac;
		private System.Windows.Forms.CheckBox ck_abn;
		private System.Windows.Forms.Button cmd_exp;
		private System.Windows.Forms.Panel p1;
		private C1.Win.C1FlexGrid.C1FlexGrid vs1;
		private Navigator1._0.NavigatorAuto nav1;
		private int x,y;
		Func.RecordSet rs1,rs2;
		private System.Windows.Forms.CheckBox ck_shift;
		private System.Windows.Forms.ComboBox cb_shift;
		private System.Windows.Forms.CheckBox ck_NoS;
		private System.Windows.Forms.CheckBox ck_Man;
		frmTaSea1 TaSea1;
		
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaDailyAttendanceList()
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.p1 = new System.Windows.Forms.Panel();
			this.nav1 = new Navigator1._0.NavigatorAuto();
			this.vs1 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.vs = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.c1CommandDock1 = new C1.Win.C1Command.C1CommandDock();
			this.c1DockingTab1 = new C1.Win.C1Command.C1DockingTab();
			this.c1DockingTabPage1 = new C1.Win.C1Command.C1DockingTabPage();
			this.Dep = new GP8000.UserControl.CrtTaDepartment();
			this.panel2 = new System.Windows.Forms.Panel();
			this.ck_Man = new System.Windows.Forms.CheckBox();
			this.ck_NoS = new System.Windows.Forms.CheckBox();
			this.cb_shift = new System.Windows.Forms.ComboBox();
			this.ck_shift = new System.Windows.Forms.CheckBox();
			this.cmd_exp = new System.Windows.Forms.Button();
			this.cmd_save = new System.Windows.Forms.Button();
			this.ck_lat = new System.Windows.Forms.CheckBox();
			this.ck_ear = new System.Windows.Forms.CheckBox();
			this.ck_lea = new System.Windows.Forms.CheckBox();
			this.ck_sig = new System.Windows.Forms.CheckBox();
			this.ck_abs = new System.Windows.Forms.CheckBox();
			this.ck_vac = new System.Windows.Forms.CheckBox();
			this.ck_abn = new System.Windows.Forms.CheckBox();
			this.cmd_un = new System.Windows.Forms.Button();
			this.cmd_cal = new System.Windows.Forms.Button();
			this.cmd_edit = new System.Windows.Forms.Button();
			this.ck = new System.Windows.Forms.CheckBox();
			this.txt2 = new System.Windows.Forms.TextBox();
			this.txt1 = new System.Windows.Forms.TextBox();
			this.dt1 = new C1.Win.C1Input.C1DateEdit();
			this.dt2 = new C1.Win.C1Input.C1DateEdit();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel5.SuspendLayout();
			this.p1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandDock1)).BeginInit();
			this.c1CommandDock1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).BeginInit();
			this.c1DockingTab1.SuspendLayout();
			this.c1DockingTabPage1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dt1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dt2)).BeginInit();
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
			this.panel3.Size = new System.Drawing.Size(1016, 36);
			this.panel3.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Location = new System.Drawing.Point(416, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(600, 36);
			this.label5.TabIndex = 11;
			this.label5.Tag = "";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.nav);
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
			this.nav.VisibleGrid = true;
			this.nav.Where = null;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel5);
			this.panel1.Controls.Add(this.c1CommandDock1);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 36);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1016, 504);
			this.panel1.TabIndex = 6;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.p1);
			this.panel5.Controls.Add(this.vs);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(260, 60);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(756, 444);
			this.panel5.TabIndex = 2;
			// 
			// p1
			// 
			this.p1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.p1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.p1.Controls.Add(this.nav1);
			this.p1.Controls.Add(this.vs1);
			this.p1.Location = new System.Drawing.Point(208, 52);
			this.p1.Name = "p1";
			this.p1.Size = new System.Drawing.Size(440, 252);
			this.p1.TabIndex = 11;
			this.p1.Visible = false;
			this.p1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.p1_MouseMove);
			this.p1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p1_MouseDown);
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
			this.nav1.Location = new System.Drawing.Point(148, 110);
			this.nav1.MSG_Exit = false;
			this.nav1.MulltiDel = true;
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
			this.vs1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs1.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs1.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs1.Location = new System.Drawing.Point(8, 6);
			this.vs1.Name = "vs1";
			this.vs1.Size = new System.Drawing.Size(424, 240);
			this.vs1.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Tahoma, 9.75pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.vs1.TabIndex = 11;
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
			this.vs.Size = new System.Drawing.Size(748, 436);
			this.vs.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Tahoma, 9.75pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.vs.TabIndex = 10;
			this.vs.BeforeSort += new C1.Win.C1FlexGrid.SortColEventHandler(this.vs_BeforeSort);
			// 
			// c1CommandDock1
			// 
			this.c1CommandDock1.Controls.Add(this.c1DockingTab1);
			this.c1CommandDock1.Dock = System.Windows.Forms.DockStyle.Left;
			this.c1CommandDock1.Id = 1;
			this.c1CommandDock1.Location = new System.Drawing.Point(0, 60);
			this.c1CommandDock1.Name = "c1CommandDock1";
			this.c1CommandDock1.Size = new System.Drawing.Size(260, 444);
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
			this.c1DockingTab1.Size = new System.Drawing.Size(260, 444);
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
			this.c1DockingTabPage1.Size = new System.Drawing.Size(255, 442);
			this.c1DockingTabPage1.TabIndex = 0;
			this.c1DockingTabPage1.Text = "Page1";
			// 
			// Dep
			// 
			this.Dep.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Dep.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Dep.Location = new System.Drawing.Point(0, 23);
			this.Dep.Name = "Dep";
			this.Dep.Size = new System.Drawing.Size(255, 419);
			this.Dep.TabIndex = 2;
			this.Dep.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dep_KeyDown);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Moccasin;
			this.panel2.Controls.Add(this.ck_Man);
			this.panel2.Controls.Add(this.ck_NoS);
			this.panel2.Controls.Add(this.cb_shift);
			this.panel2.Controls.Add(this.ck_shift);
			this.panel2.Controls.Add(this.cmd_exp);
			this.panel2.Controls.Add(this.cmd_save);
			this.panel2.Controls.Add(this.ck_lat);
			this.panel2.Controls.Add(this.ck_ear);
			this.panel2.Controls.Add(this.ck_lea);
			this.panel2.Controls.Add(this.ck_sig);
			this.panel2.Controls.Add(this.ck_abs);
			this.panel2.Controls.Add(this.ck_vac);
			this.panel2.Controls.Add(this.ck_abn);
			this.panel2.Controls.Add(this.cmd_un);
			this.panel2.Controls.Add(this.cmd_cal);
			this.panel2.Controls.Add(this.cmd_edit);
			this.panel2.Controls.Add(this.ck);
			this.panel2.Controls.Add(this.txt2);
			this.panel2.Controls.Add(this.txt1);
			this.panel2.Controls.Add(this.dt1);
			this.panel2.Controls.Add(this.dt2);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1016, 60);
			this.panel2.TabIndex = 0;
			// 
			// ck_Man
			// 
			this.ck_Man.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ck_Man.Location = new System.Drawing.Point(696, 8);
			this.ck_Man.Name = "ck_Man";
			this.ck_Man.Size = new System.Drawing.Size(84, 24);
			this.ck_Man.TabIndex = 163;
			this.ck_Man.Tag = "N";
			this.ck_Man.Text = "Maternity";
			// 
			// ck_NoS
			// 
			this.ck_NoS.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ck_NoS.Location = new System.Drawing.Point(608, 8);
			this.ck_NoS.Name = "ck_NoS";
			this.ck_NoS.Size = new System.Drawing.Size(84, 24);
			this.ck_NoS.TabIndex = 162;
			this.ck_NoS.Tag = "N";
			this.ck_NoS.Text = "NoShift";
			// 
			// cb_shift
			// 
			this.cb_shift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_shift.Enabled = false;
			this.cb_shift.Location = new System.Drawing.Point(608, 32);
			this.cb_shift.Name = "cb_shift";
			this.cb_shift.Size = new System.Drawing.Size(121, 24);
			this.cb_shift.TabIndex = 161;
			// 
			// ck_shift
			// 
			this.ck_shift.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ck_shift.Location = new System.Drawing.Point(528, 36);
			this.ck_shift.Name = "ck_shift";
			this.ck_shift.Size = new System.Drawing.Size(88, 24);
			this.ck_shift.TabIndex = 160;
			this.ck_shift.Tag = "N";
			this.ck_shift.Text = "Shift";
			this.ck_shift.CheckedChanged += new System.EventHandler(this.ck_shift_CheckedChanged);
			// 
			// cmd_exp
			// 
			this.cmd_exp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmd_exp.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_exp.Location = new System.Drawing.Point(792, 4);
			this.cmd_exp.Name = "cmd_exp";
			this.cmd_exp.Size = new System.Drawing.Size(108, 24);
			this.cmd_exp.TabIndex = 159;
			this.cmd_exp.Text = "Exp";
			this.cmd_exp.Click += new System.EventHandler(this.cmd_exp_Click);
			// 
			// cmd_save
			// 
			this.cmd_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmd_save.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_save.Location = new System.Drawing.Point(792, 32);
			this.cmd_save.Name = "cmd_save";
			this.cmd_save.Size = new System.Drawing.Size(108, 24);
			this.cmd_save.TabIndex = 149;
			this.cmd_save.Text = "Save";
			this.cmd_save.Visible = false;
			this.cmd_save.Click += new System.EventHandler(this.cmd_save_Click);
			// 
			// ck_lat
			// 
			this.ck_lat.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ck_lat.Location = new System.Drawing.Point(444, 8);
			this.ck_lat.Name = "ck_lat";
			this.ck_lat.Size = new System.Drawing.Size(84, 24);
			this.ck_lat.TabIndex = 158;
			this.ck_lat.Tag = "N";
			this.ck_lat.Text = "Late";
			// 
			// ck_ear
			// 
			this.ck_ear.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ck_ear.Location = new System.Drawing.Point(444, 36);
			this.ck_ear.Name = "ck_ear";
			this.ck_ear.Size = new System.Drawing.Size(84, 24);
			this.ck_ear.TabIndex = 157;
			this.ck_ear.Tag = "N";
			this.ck_ear.Text = "Early";
			// 
			// ck_lea
			// 
			this.ck_lea.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ck_lea.Location = new System.Drawing.Point(528, 8);
			this.ck_lea.Name = "ck_lea";
			this.ck_lea.Size = new System.Drawing.Size(84, 24);
			this.ck_lea.TabIndex = 156;
			this.ck_lea.Tag = "N";
			this.ck_lea.Text = "Leave";
			// 
			// ck_sig
			// 
			this.ck_sig.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ck_sig.Location = new System.Drawing.Point(364, 36);
			this.ck_sig.Name = "ck_sig";
			this.ck_sig.Size = new System.Drawing.Size(84, 24);
			this.ck_sig.TabIndex = 155;
			this.ck_sig.Tag = "N";
			this.ck_sig.Text = "Sign";
			// 
			// ck_abs
			// 
			this.ck_abs.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ck_abs.Location = new System.Drawing.Point(288, 8);
			this.ck_abs.Name = "ck_abs";
			this.ck_abs.Size = new System.Drawing.Size(76, 24);
			this.ck_abs.TabIndex = 154;
			this.ck_abs.Tag = "N";
			this.ck_abs.Text = "Absent";
			// 
			// ck_vac
			// 
			this.ck_vac.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ck_vac.Location = new System.Drawing.Point(288, 36);
			this.ck_vac.Name = "ck_vac";
			this.ck_vac.Size = new System.Drawing.Size(76, 24);
			this.ck_vac.TabIndex = 153;
			this.ck_vac.Tag = "N";
			this.ck_vac.Text = "Vacate";
			// 
			// ck_abn
			// 
			this.ck_abn.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ck_abn.Location = new System.Drawing.Point(364, 8);
			this.ck_abn.Name = "ck_abn";
			this.ck_abn.Size = new System.Drawing.Size(84, 24);
			this.ck_abn.TabIndex = 152;
			this.ck_abn.Tag = "N";
			this.ck_abn.Text = "Abnormal";
			// 
			// cmd_un
			// 
			this.cmd_un.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmd_un.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_un.Location = new System.Drawing.Point(904, 4);
			this.cmd_un.Name = "cmd_un";
			this.cmd_un.Size = new System.Drawing.Size(108, 24);
			this.cmd_un.TabIndex = 150;
			this.cmd_un.Text = "Unedit";
			this.cmd_un.Visible = false;
			this.cmd_un.Click += new System.EventHandler(this.cmd_edit_Click);
			// 
			// cmd_cal
			// 
			this.cmd_cal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmd_cal.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_cal.Location = new System.Drawing.Point(904, 32);
			this.cmd_cal.Name = "cmd_cal";
			this.cmd_cal.Size = new System.Drawing.Size(108, 24);
			this.cmd_cal.TabIndex = 148;
			this.cmd_cal.Text = "Cal";
			this.cmd_cal.Visible = false;
			this.cmd_cal.Click += new System.EventHandler(this.cmd_cal_Click);
			// 
			// cmd_edit
			// 
			this.cmd_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmd_edit.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_edit.Location = new System.Drawing.Point(904, 4);
			this.cmd_edit.Name = "cmd_edit";
			this.cmd_edit.Size = new System.Drawing.Size(108, 24);
			this.cmd_edit.TabIndex = 147;
			this.cmd_edit.Text = "Edit";
			this.cmd_edit.Click += new System.EventHandler(this.cmd_edit_Click);
			// 
			// ck
			// 
			this.ck.Checked = true;
			this.ck.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ck.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ck.Location = new System.Drawing.Point(4, 8);
			this.ck.Name = "ck";
			this.ck.Size = new System.Drawing.Size(20, 16);
			this.ck.TabIndex = 146;
			this.ck.Tag = "N";
			this.ck.CheckedChanged += new System.EventHandler(this.ck_CheckedChanged);
			// 
			// txt2
			// 
			this.txt2.BackColor = System.Drawing.Color.PeachPuff;
			this.txt2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt2.Location = new System.Drawing.Point(188, 32);
			this.txt2.MaxLength = 20;
			this.txt2.Name = "txt2";
			this.txt2.Size = new System.Drawing.Size(96, 23);
			this.txt2.TabIndex = 145;
			this.txt2.Tag = "EMP_I1";
			this.txt2.Text = "";
			this.txt2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
			// 
			// txt1
			// 
			this.txt1.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt1.Location = new System.Drawing.Point(188, 4);
			this.txt1.MaxLength = 20;
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(96, 23);
			this.txt1.TabIndex = 144;
			this.txt1.Tag = "EMP_ID";
			this.txt1.Text = "";
			this.txt1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
			// 
			// dt1
			// 
			this.dt1.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt1.Location = new System.Drawing.Point(68, 4);
			this.dt1.Name = "dt1";
			this.dt1.Size = new System.Drawing.Size(120, 23);
			this.dt1.TabIndex = 143;
			this.dt1.Tag = null;
			this.dt1.TextChanged += new System.EventHandler(this.dt1_TextChanged);
			// 
			// dt2
			// 
			this.dt2.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt2.Location = new System.Drawing.Point(68, 32);
			this.dt2.Name = "dt2";
			this.dt2.Size = new System.Drawing.Size(120, 23);
			this.dt2.TabIndex = 141;
			this.dt2.Tag = null;
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label4.Location = new System.Drawing.Point(24, 12);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 23);
			this.label4.TabIndex = 142;
			this.label4.Tag = "";
			this.label4.Text = "date";
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label1.Location = new System.Drawing.Point(24, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 23);
			this.label1.TabIndex = 140;
			this.label1.Tag = "";
			this.label1.Text = "date";
			// 
			// frmTaDailyAttendanceList
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(1016, 540);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaDailyAttendanceList";
			this.Text = "frmTaDailyAttendanceList";
			this.Load += new System.EventHandler(this.frmTaDailyAttendanceList_Load);
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.p1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandDock1)).EndInit();
			this.c1CommandDock1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).EndInit();
			this.c1DockingTab1.ResumeLayout(false);
			this.c1DockingTabPage1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dt1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dt2)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaDailyAttendanceList_Load(object sender, System.EventArgs e)
		{				
//			string LCK=PublicFunction.GetOption("LCK");
//			string LCK_TYE=PublicFunction.GetOption("LCK_TYE");
//			if (LCK=="2")
//			{
//				DateTime dt=T_String.GetDate();
//				string temp=PublicFunction.GetOption("LCK_DT");
//				LCK_DT obj=new LCK_DT();
//				string LCK_DT=obj.LCK_DAT(temp);
//				DateTime dt_LCK=Convert.ToDateTime(LCK_DT);
//				if (dt>=dt_LCK)
//				{	
//					if (LCK_TYE=="1")
//						this.Close();
//					if (LCK_TYE=="2")
//						Dep.Visible=false;
//					else
//						return;
//					
//				}
//			}						

			vs.Rows[0].HeightDisplay= vs.Rows[0].HeightDisplay*3;
			vs.Styles["Fixed"].WordWrap=true;
			Init_Form();
			dt1.Value=dt2.Value=T_String.GetDate();
			vs.Cols["ATT_DT"].Format=dt1.CustomFormat=dt2.CustomFormat=PublicFunction.GetOption("DATE");
			this.Closed+=new EventHandler(frmTaDailyAttendanceList_Closed);	
			Set_w();
			Init_Menu();		
		}
		#region Init_menu
		private ContextMenu mnu1;
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
					rpt.RPT2(c1XLBook1,vs,mnu1.MenuItems[mnu1.MenuItems.IndexOf((MenuItem)sender)].Text,"STD_TA_04");					
					break;
				
			}
		}
		#endregion	
		
		#region Init Form
		private void Init_Form()
		{					
			Dep.Init_Tree(this.Tag+"");			
			Dep.Show_Tree();		
			Dep.vs1.AfterRowColChange+=new C1.Win.C1FlexGrid.RangeEventHandler(Depvs1_AfterRowColChange);
			Dep.vs1.KeyDown+=new KeyEventHandler(Dep_KeyDown);
			Init_vs();		
			Init_vs1();
			InitCB();
			//vs.Tag="N";
			Basic.Function.PublicFunction.L_Init_Label(this);				
			//vs.Tag="";
			if(PublicFunction.GPS)
				Basic.Function.PublicFunction.L_Init_Label(vs,this.Name+"000_vs_GPS");
			else
				Basic.Function.PublicFunction.L_Init_Label(vs,this.Name+"000_vs");				
			//vs.Tag="N";

		}
		private void Init_vs1()
		{				
			PublicFunction.InitNav(this,vs1,nav1);	
			nav1.Show_VS();		
		}
		private void Init_vs()
		{			
			if(PublicFunction.GPS)
				PublicFunction.InitNav(this,vs,nav,this.Name+"000_vs_GPS");				
			else
				PublicFunction.InitNav(this,vs,nav,this.Name+"000_vs");			
			nav.TBForm="GP_SYS_SQL_FROM";
			nav.TBSelect="GP_SYS_SQL_SELECT";
			nav.Init_Control();
			nav.cmd_search.Visible=false;
			nav.cmd_copy.Visible=false;
			nav.cmd_delete.Visible=false;
			nav.cmd_save.Visible=false;
			nav.cmd_add.Visible=false;
			//vs.AllowEditing=false;	
			vs.Tag="";						
			vs.SelectionMode=C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;						
			vs.Cols.Frozen=vs.Cols["EMP_NM"].Index;
			for(int i=1;i<=10;i++)
			{
				vs.Cols["ONN_"+i.ToString("00")].Format="#0:00";
				vs.Cols["OFF_"+i.ToString("00")].Format="#0:00";
			}	
			
			string sql="Select TYP_ID from GP_SYS_SHIFT";
			rs1=new Func.RecordSet(sql,PublicFunction.C_con);
			for(int i=0;i<rs1.rows;i++)
			{	
				try
				{
					vs.Cols[rs1.record(i,0)].Format="#0:00";
				}
				catch{}
			}	
			sql="Select COL_NM,FOR_DR from FILC07A";
			rs2=new Func.RecordSet(sql,PublicFunction.C_con);
			for(int i=0;i<rs2.rows;i++)
			{	
				try
				{
					if(vs.Cols[rs2.record(i,"COL_NM")].DataType==typeof(double))
						vs.Cols[rs2.record(i,"COL_NM")].Format=rs2.record(i,"FOR_DR");
				}
				catch{}
			}	
			vs.Cols["DOF_HR"].Format="#0:00";
			vs.Cols["LEA_H1"].Format="#0:00";
			vs.Cols["LEA_H2"].Format="#0:00";
			vs.Cols["LEA_H3"].Format="#0:00";
			vs.Cols["OTR_HR"].Format="#0:00";
			vs.Cols["LAT_MN"].Format="#0:00";
			vs.Cols["EAR_MN"].Format="#0:00";
			vs.Cols["ABS_MN"].Format="#0:00";
			vs.Cols["ATT_DY"].Format="#,##0.0000";
			vs.Cols["NIG_DY"].Format="#,##0.0000";

			vs.Cols["EMP_I1"].Style.BackColor=Color.PeachPuff;
			vs.Cols["NOT_DR"].Style.BackColor=Color.PaleGreen;
			vs.Cols["LOC_B1"].Style.BackColor=Color.Silver;
			vs.Styles.Add("ERR");
			vs.Styles.Add("CLK");
			vs.Styles["CLK"].BackColor=Color.Silver;
			vs.Styles["ERR"].BackColor=Color.PaleTurquoise;
			vs.Styles.Add("VAC_BT");
			vs.Styles["VAC_BT"].BackColor=Color.DarkGray;
			vs.EnabledChanged+=new EventHandler(vs_EnabledChanged);
			vs.KeyDown+=new KeyEventHandler(vs_KeyDown);
			nav.ToolBar_Auto=false;
			
			vs.SelectionMode=C1.Win.C1FlexGrid.SelectionModeEnum.CellRange; 

			nav.TBarClick+=new ToolBarButtonClickEventHandler(nav_TBarClick);
			vs.BeforeEdit+=new C1.Win.C1FlexGrid.RowColEventHandler(vs_BeforeEdit);
			vs.AfterEdit+=new C1.Win.C1FlexGrid.RowColEventHandler(vs_AfterEdit);	
			////////////////chi co user pha1,vinhtuyen,admin moi duoc khoa//////////////////
			if(PublicFunction.A_UserID=="pha1" || PublicFunction.A_UserID=="rehong" || PublicFunction.A_UserID=="vinhtuyen" || PublicFunction.A_UserID=="admin")
				vs.Cols["LOC_B1"].AllowEditing=true;
			else
				vs.Cols["LOC_B1"].AllowEditing=false;
		}	
		private void InitCB()
		{
			string sql;			
			//Department
			sql=PublicFunction.GetDep(this.Tag+"");			
			vs.Cols["DEP_ID"].DataMap=PublicFunction.InitCBForVS(sql);				
			sql="Select LEA_ID,LEA_NM from FILA15A";
			vs.Cols["LEA_I1"].DataMap=PublicFunction.InitCBForVS(sql);
			vs.Cols["LEA_I2"].DataMap=PublicFunction.InitCBForVS(sql);
			vs.Cols["LEA_I2"].DataMap=PublicFunction.InitCBForVS(sql);
			
			sql="Select ID,"+PublicFunction.L_Lag+" from SYS_LABEL where NAME=N'IN' order by ID";
			vs.Cols["NIG_TM"].DataMap=PublicFunction.InitCBForVS(sql);
			
			
			sql="Select SHI_ID,SHI_NM from FILC02A";
			PublicFunction.InitCB(cb_shift,sql,false);
		}
		#endregion
		#region ShowData
		private void Show_VS()
		{
			string sql,wh;
			if(Dep.vs1.Row<0)
			{
				vs.Rows.Count=1;
				return;
			}
			string dk=Dep.Get_Data("DEP_ID");
			if(ck.Checked)
			{		
				if(dk+""!="")
					sql="b.DEP_ID=N'"+Dep.Get_Data("DEP_ID")+"' and (DEL_BT=0 or DEL_BT is null) and (ATT_DT Between '"
						+((DateTime)dt1.Value).ToString("yyyy/MM/dd")+"' and '"
						+((DateTime)dt2.Value).ToString("yyyy/MM/dd")+"')";			
				else
				{
					sql="b.DEP_ID  in "+T_String.DEP_ID(this.Tag)+" and (DEL_BT=0 or DEL_BT is null) and (ATT_DT Between '"
						+((DateTime)dt1.Value).ToString("yyyy/MM/dd")+"' and '"
						+((DateTime)dt2.Value).ToString("yyyy/MM/dd")+"')";	
					
				}
			}
			else
			{		
				if(dk+""!="")
					sql="b.DEP_ID=N'"+Dep.Get_Data("DEP_ID")+"' and (DEL_BT=0 or DEL_BT is null)";				
				else
					sql="b.DEP_ID in "+T_String.DEP_ID(this.Tag)+" and (DEL_BT=0 or DEL_BT is null)";
			}
			wh=GetWh();		
			if (wh!="")
				sql+=" and ("+wh+")";	
			nav.Show_VS(sql);
			CheckCols();					
		}			
		private void Set_w()
		{
			for(int i=1;i<=10;i++)
			{
				vs.Cols["ONN_"+i.ToString("00")].Width=40;
				vs.Cols["OFF_"+i.ToString("00")].Width=40;
			}	
		
			for(int i=0;i<rs1.rows;i++)
			{	
				try
				{
					vs.Cols[rs1.record(i,0)].Width=50;
				}
				catch{}
			}	
			for(int i=0;i<rs2.rows;i++)
			{	
				try
				{
					vs.Cols[rs2.record(i,0)].Width=50;
				}
				catch{}
			}	
			vs.Cols["LEA_H1"].Width=50;
			vs.Cols["LEA_H2"].Width=50;
			vs.Cols["LEA_H3"].Width=50;
			vs.Cols["OTR_HR"].Width=50;
			vs.Cols["LAT_MN"].Width=50;
			vs.Cols["EAR_MN"].Width=50;
			vs.Cols["LAT_TM"].Width=50;
			vs.Cols["EAR_TM"].Width=50;
			vs.Cols["ABS_TM"].Width=50;
			vs.Cols["ABS_MN"].Width=50;
			vs.Cols["ATT_DY"].Width=50;
			vs.Cols["NIG_DY"].Width=50;
		}
		private void CheckCols()
		{			
			for(int i=1;i<vs.Rows.Count;i++)
			{
				if(vs.Rows[i]["VAC_BT"]+""=="True")
				{
					for(int c=1;c<vs.Cols.Count;c++)
						vs.SetCellStyle(i,c, vs.Styles["VAC_BT"]);
				}
			}
			for(int c=10;c>=1;c--)
			{
				vs.Cols["ONN_"+c.ToString("00")].Visible=
				vs.Cols["OFF_"+c.ToString("00")].Visible=true;	
				int r;
				for(r=1;r<vs.Rows.Count;r++)
				{
					string data=vs.Rows[r]["ONN_"+c.ToString("00")]+"";
					string data1=vs.Rows[r]["OFF_"+c.ToString("00")]+"";
					if((data+""!="" && data+""!="0") || (data1+""!="" && data1+""!="0") )
						break;
				}
				if(r==vs.Rows.Count)
				{
					vs.Cols["OFF_"+c.ToString("00")].Visible=vs.Cols["ONN_"+c.ToString("00")].Visible=false;
				}
			}			
			for(int i=1;i<vs.Rows.Count;i++)
			{
				string st=vs.Rows[i]["NOT_D1"]+"";
//				if(vs.Rows[i]["LOC_B1"]+""=="True")
//					vs.Rows[i].Style=vs.Styles["CLK"];
				while(st+""!="")
				{
					int j=T_String.IsNullTo0(PublicFunction.S_Left(st,2))+2;
					string name;
					if(j%2==0)					
						name="ONN_";
					else
						name="OFF_";
					j=(j/2);
					try
					{
						vs.SetCellStyle(i,vs.Cols[name+j.ToString("00")].Index,vs.Styles["ERR"]);					
					}
					catch{}
					if(st.Length>2)
						st=PublicFunction.S_Right(st,st.Length-2);
					else
						st="";

				}
			}
			Set_w();
		}
		private void Depvs1_AfterRowColChange(object sender, C1.Win.C1FlexGrid.RangeEventArgs e)
		{
			if(e.OldRange.r1!=e.NewRange.r1)
			{
				 txt_KeyDown(txt1,new KeyEventArgs(Keys.Enter));
//				Show_VS();
			}
		}
		private void vs_EnabledChanged(object sender, EventArgs e)
		{
			Basic.Function.PublicFunction.L_Init_Label(vs,this.Name+"000_vs");				
//			txt1.Text=vs.Cols[txt1.Tag+""].Caption;
//			txt2.Text=vs.Cols[txt2.Tag+""].Caption;		
			nav.Init_PMenu_Color();
			vs1.Cols["TYP_EN"].Visible=false;
			vs1.Cols["TYP_CH"].Visible=false;
			vs1.Cols["TYP_VN"].Visible=false;
			vs1.Cols["TYP_TT"].Visible=false;
			vs1.Cols["TYP_"+PublicFunction.L_Lag].Visible=true;
		}
		#endregion
		#region Search	
		private void txt_Enter(object sender, System.EventArgs e)
		{			
			TextBox txt=(TextBox)sender;
			if (txt.Text==vs.Cols[txt.Tag+""].Caption)
				txt.Text="";
		}
		private void txt_Leave(object sender, System.EventArgs e)		
		{
			TextBox txt=(TextBox)sender;
			if (txt.Text=="")
				txt.Text=vs.Cols[txt.Tag+""].Caption;
		}
		private void txt_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Enter)
			{
				
				string sql;	
//				string f=((TextBox)sender).Tag+"";
//				if(f=="EMP_ID" || f=="EMP_I1")
//					f="a."+f;
//				if(((TextBox)sender).Text+""!="")
//					
//					sql=f+" like N'%"+((TextBox)sender).Text+"%'";
//				else
//					sql="1=1";
				if(txt1.Text+""!="")					
					sql=" a.EMP_ID like N'%"+txt1.Text+"%'";
				else if(txt2.Text+""!="")					
					sql=" a.EMP_I1 like N'%"+txt2.Text+"%'";
				else
					sql=" 1=1";
				string dk=Dep.Get_DepAll();
				
				if(dk+""!="")
					sql=sql+" and b.DEP_ID in "+dk+"";				
				else
					sql=sql+" and b.DEP_ID in "+T_String.DEP_ID(this.Tag)+" ";
			
				if(ck.Checked)
					sql=sql+" and  (DEL_BT=0 or DEL_BT is null) and "
						+"(ATT_DT Between '"+((DateTime)dt1.Value).ToString("yyyy/MM/dd")+"' and '"
						+((DateTime)dt2.Value).ToString("yyyy/MM/dd")+"') "
						+" and b.DEP_ID in (Select DEP_ID  from SYS_SECURITY_DEP"+
						" where MNU_ID="+this.Tag+" and ALL_BT=1 and USER_ID=N'"+PublicFunction.A_UserID+"')";
				else
					sql=sql+" and  (DEL_BT=0 or DEL_BT is null) and b.DEP_ID in (Select DEP_ID  from SYS_SECURITY_DEP"+
						" where MNU_ID="+this.Tag+" and ALL_BT=1 and USER_ID=N'"+PublicFunction.A_UserID+"')";

				string wh=GetWh();		
				if (wh!="")
					sql+=" and ("+wh+")";	
				nav.Show_VS(sql);	
				CheckCols();				
			}
		}
		#endregion		
		#region Tbar
		private void nav_TBarClick(object sender, ToolBarButtonClickEventArgs e)
		{		
			if (e.Button.Equals(nav.cmd_save))
			{				
				vs.Select();
				string dt=T_String.GetDate().ToString("yyyy/MM/dd HH:mm");
				ArrayList a = new ArrayList();				
				for (int i=1;i<vs.Rows.Count;i++)
				{								
					if (T_String.IsNullTo0(vs.Rows[i].UserData+"")==1)
					{		
						//tinh gio het hang cho omexey
						if(PublicFunction.CUS_ID=="53" )
						{
							vs.Rows[i]["OOF_HR"]=CalOutOfHR(i) ;
							if(CalOutOfHR(i)>0)
							{
								vs.Rows[i]["ABS_MN"]=0;
								vs.Rows[i]["ABS_TM"]=0;
								vs.Rows[i]["NOT_DR"]=vs.Rows[i]["NOT_DR"].ToString().Replace("Absent;","") ;
							}
						}
						a.Add(i);
						string st=vs.Rows[i]["NOT_DR"]+"";
						if(st.IndexOf("Sign")<0)
							vs.Rows[i]["NOT_OR"]=vs.Rows[i]["NOT_DR"]+""+vs.Rows[i]["NOT_OR"];
						vs.Rows[i]["NOT_DR"]=PublicFunction.A_UserID +" Sign";
						vs.Rows[i]["NOT_D1"]="";
						vs.Rows[i]["LOC_BT"]="True";
						double max=0;
						for(int j=1;j<=10;j++)
						{
							double c1=T_String.IsNullTo00(vs.Rows[i]["ONN_"+j.ToString("00")]+"");
							double c2=T_String.IsNullTo00(vs.Rows[i]["OFF_"+j.ToString("00")]+"");
							if(c2>c1 || c1>max)
							{
								string sql="update FILC01A set YSD_BT=0 where CRD_DT='"
									+DateTime.Parse(vs.Rows[i]["ATT_DT"]+"").AddDays(1).ToString("yyyy/MM/dd")+"'";
								PublicFunction.SQL_Execute(sql);
								break;
							}
						}
						vs.Rows[i]["LST_NM"]=PublicFunction.A_UserID;
						vs.Rows[i]["LST_DT"]=dt;			
					}										
				}
				nav.ToolBar_Click(e);
				//Thu sua, delete cac dong sua tay trong cac bang tam   
				SqlConnection con = new SqlConnection(PublicFunction.C_con.ConnectionString);
				if (con.State == ConnectionState.Closed)
					con.Open();
				Func.RecordSet rsH = new Func.RecordSet("select DISTINCT [USER] from HistoryOfFILA06A where CONVERT(nvarchar, STR_DT, 111)='" + T_String.GetDate().ToString("yyyy/MM/dd") + "' AND RESULT LIKE N'%Running%'", con);
				for (int m = 0; m < a.Count; m++)
				{
					int i = (int)a[m];
					string EMP_ID = vs.Rows[i]["EMP_ID"] + "";
					DateTime d1 = DateTime.Parse(vs.Rows[i]["ATT_DT"] + "");
					string sql = "";
					//delete cac dong sua tay trong cac bang tam                
					if (rsH.rows > 0)
					{
						for (int t = 0; t < rsH.rows; t++)
						{
							sql = "DELETE FILC06A_" + rsH.record(t, "USER") + " WHERE EMP_ID='" + EMP_ID + "' AND ATT_DT='" + d1.ToString("yyyy/MM/dd") + "'";
							PublicFunction.SQL_Execute(sql);                            
						}
					}
				}
				return;
			}	
			if (e.Button.Equals(nav.cmd_delete))
			{
				for(int i=vs.Rows.Count-1;i>0;i--)
				{
					if(vs.Rows[i]["SYSSEL"]+""=="True")
					{						
						vs.RemoveItem(i);
					}
				}
				for(int i=1;i<vs.Rows.Count;i++)
				{
					vs.Rows[i][0]=i;
				}
				return;
			}
			if (e.Button.Equals(nav.cmd_refresh))
			{				
				txt_KeyDown(txt1,new KeyEventArgs(Keys.Enter));
//				if(txt1.Text!="")
//					show_search(txt1.Text,txt1.Tag+"");
//				else
//				{
//					if(txt2.Text!="")
//						show_search(txt2.Text,txt2.Tag+"");
//					else 					
//					Show_VS();
//				}
				return;
			}
			nav.ToolBar_Click(e);	
			if (e.Button.Equals(nav.cmd_search))
			{
				//Boolean aa=false;
				if(TaSea1==null)
				{
					//aa=true;
					TaSea1=new frmTaSea1();
					TaSea1.Tag=this.Tag;
					TaSea1.Init_Form();
				}
				if(TaSea1.ShowDialog()==DialogResult.OK)
				{
					string sql="";	
					for(int i=1;i<TaSea1.vs2.Rows.Count;i++)
					{
						if(sql!="") sql+=",";
						sql+="N'"+TaSea1.vs2.Rows[i]["EMP_ID"]+"'";
					}
					if(sql!="")
						sql="a.EMP_ID in ("+sql+")";
					
					if(ck.Checked)
						sql=sql+" and  (DEL_BT=0 or DEL_BT is null) and "
							+"(ATT_DT Between '"+((DateTime)dt1.Value).ToString("yyyy/MM/dd")+"' and '"
							+((DateTime)dt2.Value).ToString("yyyy/MM/dd")+"') "
							+" and b.DEP_ID in (Select DEP_ID  from SYS_SECURITY_DEP"+
							" where MNU_ID="+this.Tag+" and ALL_BT=1 and USER_ID=N'"+PublicFunction.A_UserID+"')";
					else
						sql=sql+" and  (DEL_BT=0 or DEL_BT is null) and b.DEP_ID in (Select DEP_ID  from SYS_SECURITY_DEP"+
							" where MNU_ID="+this.Tag+" and ALL_BT=1 and USER_ID=N'"+PublicFunction.A_UserID+"')";

					
					nav.Show_VS(sql);	
					CheckCols();				
					
				}
			}
		}

		private void nav_Refresh(object sender, ToolBarButtonClickEventArgs e)
		{		
			if (e.Button.Equals(nav.cmd_save))
			{				
				vs.Select();
				string dt=T_String.GetDate().ToString("yyyy/MM/dd HH:mm");
				for (int i=1;i<vs.Rows.Count;i++)
				{								
					if (T_String.IsNullTo0(vs.Rows[i].UserData+"")==1)
					{		
						vs.Rows[i]["NOT_D1"]="";
						vs.Rows[i]["LOC_BT"]="True";
						double max=0;
						for(int j=1;j<=10;j++)
						{
							double c1=T_String.IsNullTo00(vs.Rows[i]["ONN_"+j.ToString("00")]+"");
							double c2=T_String.IsNullTo00(vs.Rows[i]["OFF_"+j.ToString("00")]+"");
							if(c2>c1 || c1>max)
							{
								string sql="update FILC01A set YSD_BT=0 where CRD_DT='"
									+DateTime.Parse(vs.Rows[i]["ATT_DT"]+"").AddDays(1).ToString("yyyy/MM/dd")+"'";
								PublicFunction.SQL_Execute(sql);
								break;
							}
						}	
						//							vs.Rows[i]["LST_NM"]=PublicFunction.A_UserID;
						//							vs.Rows[i]["LST_DT"]=dt;
					}											
				}					
			}						
			if (e.Button.Equals(nav.cmd_refresh))
			{				
				txt_KeyDown(txt1,new KeyEventArgs(Keys.Enter));
				//				if(txt1.Text!="")
				//					show_search(txt1.Text,txt1.Tag+"");
				//				else
				//				{
				//					if(txt2.Text!="")
				//						show_search(txt2.Text,txt2.Tag+"");
				//					else 					
				//					Show_VS();
				//				}
				return;
			}
			nav.ToolBar_Click(e);			
		}

		private void show_search(string txt,string tag)
		{		
			string f=tag;
			if(f=="EMP_ID")
				f="a."+f;
			string sql;				
			if(txt+""!="")
				sql=f+" like N'%"+txt+"%'";
			else
				sql="1=1";
			if(ck.Checked)
				sql=sql+" and  (DEL_BT=0 or DEL_BT is null) and "
					+"(ATT_DT Between '"+((DateTime)dt1.Value).ToString("yyyy/MM/dd")+"' and '"
					+((DateTime)dt2.Value).ToString("yyyy/MM/dd")+"') "
					+" and b.DEP_ID in (Select DEP_ID  from SYS_SECURITY_DEP"+
					" where MNU_ID="+this.Tag+" and ALL_BT=1 and USER_ID=N'"+PublicFunction.A_UserID+"')";
			else
				sql=sql+" and  (DEL_BT=0 or DEL_BT is null) and b.DEP_ID in (Select DEP_ID  from SYS_SECURITY_DEP"+
					" where MNU_ID="+this.Tag+" and ALL_BT=1 and USER_ID=N'"+PublicFunction.A_UserID+"')";
			string wh=GetWh();		
			if (wh!="")
				sql+=" and ("+wh+")";	
			nav.Show_VS(sql);				
			CheckCols();
		}

		#endregion
		#region event
		private void ck_CheckedChanged(object sender, System.EventArgs e)
		{
			dt1.Enabled=dt2.Enabled=ck.Checked;
		}

		private void frmTaDailyAttendanceList_Closed(object sender, EventArgs e)
		{
			nav.Save_SEQ();
		}

		private void Dep_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode==Keys.F10 && (PublicFunction.A_UserID=="admin" || PublicFunction.A_UserID=="vinhtuyen"))
			{
				frmTaAttendanceFormula dlg=new frmTaAttendanceFormula();
				dlg.Tag=this.Tag;
				dlg.ShowDialog();
			}
		}

		private void cmd_edit_Click(object sender, System.EventArgs e)
		{	
			if(cmd_edit.Visible)
			{
				if(MessageBox.Show(this,PublicFunction.L_Get_Msg("msg",77),this.Text,MessageBoxButtons.YesNo)==DialogResult.No)
				{
					vs.Tag="";
					return;
				}
				else
				{
					vs.Tag="N";
				}
			}
			else
			{
				vs.Tag="";
			}
			//vs.AllowEditing=cmd_edit.Visible;	
			cmd_un.Visible=!cmd_un.Visible;			
			cmd_edit.Visible=!cmd_edit.Visible;
			cmd_save.Visible=!cmd_save.Visible;
			cmd_cal.Visible=!cmd_cal.Visible;			
		}

		private void vs_KeyDown(object sender, KeyEventArgs e)
		{		
			if (cmd_edit.Visible==true) return;
			if(e.KeyCode==Keys.Insert)
			{
				int i=0;
				for(i=vs.Cols["OFF_10"].Index  ;i>=vs.Col+1 ;i--)
				{
					vs.Rows[vs.Row][i]=vs.Rows[vs.Row][i-1];
				}	
				
				vs.Rows[vs.Row].UserData=1;
				vs.Rows[vs.Row][vs.Col]="0";
				return;
			}
			
			if(e.KeyCode==Keys.Delete)
			{
				int i=0;
				for(i=vs.Col  ;i<=vs.Cols["OFF_10"].Index ;i++)
				{
					vs.Rows[vs.Row][i]=vs.Rows[vs.Row][i+1];
				}					
				vs.Rows[vs.Row].UserData=1;
				vs.Rows[vs.Row]["OFF_10"]="0";				
			}
		}

		private void cmd_cal_Click(object sender, System.EventArgs e)
		{
			if(MessageBox.Show(this,PublicFunction.L_Get_Msg("msg",78),this.Text,MessageBoxButtons.YesNo)==DialogResult.No)
				return;
			ArrayList a=new ArrayList();
			for(int n=1;n<vs.Rows.Count;n++)
			{

				if(vs.Rows[n].UserData+""=="1")
				{
					a.Add(n);
					string st=vs.Rows[n]["NOT_DR"]+"";
					if(st.IndexOf("Sign")<0)
						
						vs.Rows[n]["NOT_OR"]=vs.Rows[n]["NOT_DR"];
				}				

                // kien them vao de khi check va sua khong ghi ten rong

				for (int k=vs.Selection.r1;k<=vs.Selection.r2;k++)
				{
					if (vs.Rows[k]["USR_CK"]+""=="")
					{
						vs.Rows[k]["LOC_B1"]="False";
					}
				}
				//
			}
			nav_TBarClick(nav.cmd_save,new ToolBarButtonClickEventArgs(nav.cmd_save));
			Func.RecordSet rsTypeShift=new Func.RecordSet("Select * from GP_SYS_SHIFT",PublicFunction.C_con);
			Func.RecordSet Set=new Func.RecordSet("Select * from GP_SYS_SETTING",PublicFunction.C_con);	
			SqlConnection con=new SqlConnection(PublicFunction.C_con.ConnectionString);
			if(con.State==ConnectionState.Closed )
				con.Open();
			int dem=0,i=0;
			for(int m=0;m<a.Count;m++)
			{
				i=(int)a[m];				
				string EMP_ID=vs.Rows[i]["EMP_ID"]+"";
				DateTime d1=DateTime.Parse(vs.Rows[i]["ATT_DT"]+"");

				string SHI_ID=vs.Rows[i]["SHI_ID"]+"";
				
				string sql="Select * from FILC02B where SHI_ID=N'"+SHI_ID+"' ORDER BY SEQ_NO";
				Func.RecordSet rsca=new Func.RecordSet(sql,con);	
				
				ArrayList Ca=new ArrayList();
				ArrayList ATT=new ArrayList();
				for(int j=0;j<rsca.rows;j++)
				{
					Ca.Add(rsca.record(j,"ONN_TM"));
					Ca.Add(rsca.record(j,"OFF_TM"));
				}
				Ca.Add(0);
				Ca.Add(0);
				Ca.Add(0);
				Ca.Add(0);
				for(int j=1;j<=10;j++)
				{
					ATT.Add(T_String.IsNullTo00(vs.Rows[i]["ONN_"+j.ToString("00")]+""));
					ATT.Add(T_String.IsNullTo00(vs.Rows[i]["OFF_"+j.ToString("00")]+""));						
				}	
				TaAttendance tm=new TaAttendance(EMP_ID,d1.ToString("yyyy/MM/dd"),con,Ca,ATT,SHI_ID,rsca,Set,rsTypeShift);			
				tm.tb=Function.Common.Ints.tbChamCong;
				tm.NIG_TM=T_String.IsNullTo00(vs.Rows[i]["NIG_TM"]+"");
				tm.NOT_DD=vs.Rows[i]["NOT_DR"]+"";
				tm.UpdateSql();
				ForCal(EMP_ID,d1.ToString("yyyy/MM/dd"));
				dem++;				
			}
			int vat=T_String.GetMax("MAX(SEQ_NO)","FILC10A");
			for(int m=0;m<a.Count;m++)
			{
				string EMP_ID=vs.Rows[i]["EMP_ID"]+"";
				DateTime d1=DateTime.Parse(vs.Rows[i]["ATT_DT"]+"");
				TaAttendance.AbsentToVacate(EMP_ID,d1.ToString("yyyy/MM/dd"),con,"FILC06A");
			}
			if(T_String.GetMax("MAX(SEQ_NO)","FILC10A")>vat)
			{
				frmTaAbsentVacate dlg=new frmTaAbsentVacate();
				dlg.Tag=this.Tag;
				dlg.ShowDialog();
			}
			if(dem>0)
			{
				int row=vs.Row;
				nav.Show_VS(nav.Where+"");
				if(row>0 &&  vs.Rows.Count >row)
					vs.Row=row;
			}
			vs.Tag="";
			//vs.AllowEditing=cmd_edit.Visible;	
			cmd_un.Visible=!cmd_un.Visible;			
			cmd_edit.Visible=!cmd_edit.Visible;
			cmd_save.Visible=!cmd_save.Visible;
			cmd_cal.Visible=!cmd_cal.Visible;	
			CheckCols();		
		}

		private void ForCal(string  EMP_ID,string d1)
		{		
			SqlConnection con=new SqlConnection(PublicFunction.C_con.ConnectionString);
			if(con.State==ConnectionState.Closed )
				con.Open();
			string sql="";
			sql="Select * from FILC08A where RUN_BT=1 order by SEQ_N1";
			Func.RecordSet rs=new Func.RecordSet(sql,con);
			try
			{
				for(int i=0;i<rs.rows;i++)
				{
					sql=" "+rs.record(i,"SQL_DR")+" ";
					if(sql+""!="")
					{				
						sql+=" and a.EMP_ID=N'"+EMP_ID+"' and ATT_DT='"+d1+"'" ;
						PublicFunction.SQL_Execute(sql,con,true);
					}
				}
				sql=string.Format("Update {0} SET[NOT_DR]=[NOT_DR]+' AbnormalLeave' from FILB01A b, {0} a where ( a.EMP_ID=b.EMP_ID) and ",Function.Common.Ints.tbChamCong)+
					"(([ATT_HR]+[NIG_HR]+[LEA_H1]+[LEA_H2])>800 or (([ATT_HR]+[NIG_HR]+[LEA_H1]+[LEA_H2])>760 AND ([ATT_HR]+[NIG_HR]+[LEA_H1]+[LEA_H2])<800  ))";
				sql+=" and a.EMP_ID=N'"+EMP_ID+"' and ATT_DT='"+d1+"'" ;
				PublicFunction.SQL_Execute(sql,con,true);

				Common.Ints.CalPhuCap30(con,null,null,null,EMP_ID,d1);
				Common.Ints.CalCaNgayNghi(con,null,null,null,EMP_ID,d1);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);				
				return;
			}		
			
		}
	
		private void cmd_save_Click(object sender, System.EventArgs e)
		{
			ArrayList a=new ArrayList();
			for(int n=1;n<vs.Rows.Count;n++)
			{

				if(vs.Rows[n].UserData+""=="1")
				{
					a.Add(n);
					string st=vs.Rows[n]["NOT_DR"]+"";
					if(st.IndexOf("Sign")<0)
						
						vs.Rows[n]["NOT_OR"]=vs.Rows[n]["NOT_DR"];
				}

				

				// kien them vao de khi check va sua khong ghi ten rong

				for (int k=vs.Selection.r1;k<=vs.Selection.r2;k++)
				{
					if (vs.Rows[k]["USR_CK"]+""=="")
					{
						vs.Rows[k]["LOC_B1"]="False";
					}
				}			
			}
			if(MessageBox.Show(this,PublicFunction.L_Get_Msg("msg",79),this.Text,MessageBoxButtons.YesNo)==DialogResult.No)
				return;
			nav_TBarClick(nav.cmd_save,new ToolBarButtonClickEventArgs(nav.cmd_save));
			vs.Tag="";
			//vs.AllowEditing=cmd_edit.Visible;	
			cmd_un.Visible=!cmd_un.Visible;			
			cmd_edit.Visible=!cmd_edit.Visible;
			cmd_save.Visible=!cmd_save.Visible;
			cmd_cal.Visible=!cmd_cal.Visible;	
		}

		private string GetWh()
		{
			string sql="";
			sql=GetWh(sql,ck_abn,"Abnormal");
			sql=GetWh(sql,ck_abs,ck_abs.Text);
			sql=GetWh(sql,ck_ear,ck_ear.Text);
			sql=GetWh(sql,ck_lat,"Late");
			sql=GetWh(sql,ck_sig,"Sign");
			sql=GetWh(sql,ck_Man,"Maternity");
			sql=GetWh(sql,ck_Man,"Manternity");
			
			if(ck_lea.Checked)
			{
				if(sql!="") sql+=" OR ";
				sql+="(LEA_I1 is not null and LEA_I1<>'')";
			}
			if(ck_vac.Checked)
			{
				if(sql!="") sql+=" OR ";
				sql+="(VAC_BT=1)";
			}
			if(ck_shift.Checked)
			{
				if(sql!="") sql+=" and  ";
				sql+="(SHI_ID=N'"+cb_shift.SelectedValue+"')" ;
			}		
			if(ck_NoS.Checked)
			{
				if(sql!="") sql+=" and  ";
				sql+="(SHI_ID=N'NoShift')" ;
			}	

			for(int i=1;i<vs1.Rows.Count;i++)
			{
				if(vs1.Rows[i]["SYSSEL"]+""=="True")
				{
					if(sql!="") sql+=" AND ";
						sql+="("+vs1.Rows[i]["TYP_ID"]+" is not null and "+vs1.Rows[i]["TYP_ID"]+">0 )";
				}
			}
			//tuyen them 20090407
			
//			if(txt1.Text+""!="")					
//				sql+=" EMP_ID like N'%"+txt1.Text+"%'";
//			if(txt2.Text+""!="")					
//				sql+=" EMP_I1 like N'%"+txt2.Text+"%'";
//			if(ck.Checked)
//				sql=sql+" and  (DEL_BT=0 or DEL_BT is null) and "
//					+"(ATT_DT Between '"+((DateTime)dt1.Value).ToString("yyyy/MM/dd")+"' and '"
//					+((DateTime)dt2.Value).ToString("yyyy/MM/dd")+"') "
//					+" and b.DEP_ID in (Select DEP_ID  from SYS_SECURITY_DEP"+
//					" where MNU_ID="+this.Tag+" and ALL_BT=1 and USER_ID=N'"+PublicFunction.A_UserID+"')";
//			else
//				sql=sql+" and  (DEL_BT=0 or DEL_BT is null) and b.DEP_ID in (Select DEP_ID  from SYS_SECURITY_DEP"+
//					" where MNU_ID="+this.Tag+" and ALL_BT=1 and USER_ID=N'"+PublicFunction.A_UserID+"')";
//			string wh=GetWh();		
//			if (wh!="")
//				sql+=" and ("+wh+")";	
//			nav.Show_VS(sql);	
//			CheckCols();		
			//tuyen them 20090407 end
			return sql;
		}
		private string GetWh(string sql,CheckBox ck,string st)
		{
			if(ck.Checked)
			{
				if(sql!="") sql+=" OR ";
				sql+="NOT_DR like N'%"+st+"%'";
			}
			return sql;
		}

		private void vs_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
		
			//if (nav.Refresh()=="1")
			//{				
				//e.Cancel=false;
			//}
		//	vs.AllowEditing=true;
			if(vs.Rows[e.Row]["LOC_B1"]+""=="True")
			{
				if(PublicFunction.A_UserID!= vs.Rows[e.Row]["USR_CK"]+"" || vs.Cols[e.Col].Name!="LOC_B1")
					e.Cancel=true;
			}
			else
			{
				if(vs.Cols[e.Col].Name!="LOC_B1" && vs.Tag+""=="")
				{
					e.Cancel=true;
					//cmd_cal.Visible=false;
					//vs.AllowEditing=false;
				}
				else
				{
					e.Cancel=false;
					//vs.AllowEditing=true;
				}
			}
		}

		private void vs_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			vs.AllowEditing=true;
			for (int i=vs.Selection.r1;i<=vs.Selection.r2;i++)
			{
				string user=vs.Rows[i]["USR_CK"]+"";
				if (vs.Rows[i]["USR_CK"]+""==PublicFunction.A_UserID || vs.Rows[i]["USR_CK"]+""=="")
				{
					
				}
				else
				{
					vs.AllowEditing=false;
					e.Cancel=true;
					return;
				}
			}

			if(vs.Rows[e.Row]["LOC_B1"]+""=="True")
			{
				if(PublicFunction.A_UserID!= vs.Rows[e.Row]["USR_CK"]+"" || vs.Cols[e.Col].Name!="LOC_B1")
					e.Cancel=true;
			}
			else
			{
				if(vs.Cols[e.Col].Name!="LOC_B1" && vs.Tag+""=="")
				{
					e.Cancel=true;
					//cmd_cal.Visible=false;
					vs.AllowEditing=false;
				}
				else
				{
					e.Cancel=false;
					vs.AllowEditing=true;
				}
			}

			if(vs.Cols[e.Col].Name=="LOC_B1" && e.Row>0)
			{
				if(vs.Rows[e.Row]["LOC_B1"]+""=="True")
				{
					vs.Rows[e.Row]["USR_CK"]=PublicFunction.A_UserID;
				}
				else
				{
					vs.Rows[e.Row]["USR_CK"]="";
				}
			}


			string sql="";
			int tam=0;
			for (int i=vs.Selection.r1;i<=vs.Selection.r2;i++)
			{
				if (vs.Rows[i]["LOC_B1"]+""!="True")
				{
					vs[i,e.Col ]=vs[e.Row,e.Col];
					vs.Rows[i].UserData=1;
				}
			}
			DateTime ngay;
			for (int i=vs.Selection.r1;i<=vs.Selection.r2;i++)
			{
				if (vs.Rows[i]["LOC_B1"]+""=="True")
				{
					tam=1;
				}
				else
				{
					tam=0;
				}
				ngay=(DateTime)(vs.Rows[i]["ATT_DT"]);
				sql=string.Format("UPDATE {0} SET USR_CK='",Function.Common.Ints.tbChamCong)+ vs.Rows[e.Row]["USR_CK"] +"',LOC_B1='"+ tam +"',LOC_BT='"+ tam +"' where EMP_ID=N'"+vs.Rows[i]["EMP_ID"]+"' and ATT_DT='" + 

					ngay.ToString("yyyy/MM/dd") + "'";
				PublicFunction.SQL_Execute(sql);
			}



			// string sql="";
			// int tam=0;
			// if (vs.Rows[e.Row]["LOC_B1"]+""=="True")
			// {
			// tam=1;
			// }
			// else
			// {
			// tam=0;
			// }
			// sql="UPDATE FILC06A SET USR_CK='"+ vs.Rows[e.Row]["USR_CK"] +"',LOC_B1='"+ tam +"' where EMP_ID=N'"+vs.Rows[e.Row]["EMP_ID"]+"' and ATT_DT='" + vs.Rows[e.Row]["ATT_DT"] + "'";
			// PublicFunction.SQL_Execute(sql);
			//nav.ToolBar_Click(new ToolBarButtonClickEventArgs(nav.cmd_save));
			//nav_Refresh(nav.cmd_save,new ToolBarButtonClickEventArgs(nav.cmd_save));
		}

		private void cmd_exp_Click(object sender, System.EventArgs e)
		{
			p1.Visible=!p1.Visible;
			if(p1.Visible==false)
			{
				for(int i=1;i<vs1.Rows.Count;i++)
				{
					vs1.Rows[i]["SYSSEL"]="False";
				}		
			}
		}

		private void p1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			x=e.X;y=e.Y;
		}

		private void p1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			int x1,y1;		
			if (e.Button==System.Windows.Forms.MouseButtons.Left)
			{
				System.Drawing.Point p;
				x1=e.X-x;
				y1=e.Y-y;				
				p=new System.Drawing.Point(p1.Location.X+x1,p1.Location.Y+y1);
				p1.Location = p;
				this.Validate();
			}
		}
		#endregion

		private void ck_shift_CheckedChanged(object sender, System.EventArgs e)
		{
			cb_shift.Enabled=ck_shift.Checked;
		}

		private void dt1_TextChanged(object sender, System.EventArgs e)
		{
			dt2.Value=dt1.Value;
		}

		private double CalOutOfHR(int i)
		{
			double att=0,phep=0,outofHR=0;
			att=T_String.IsNullTo00(vs.Rows[i]["ATT_HR"]+"");
			phep=T_String.IsNullTo00(vs.Rows[i]["LEA_H1"]+"");
			if(vs.Rows[i]["OOF_BT"]+""=="True" && vs.Rows[i]["SHI_ID"]+""!="00" )
			{
				outofHR=480-(Math.Floor(att/100)*60+(att-Math.Floor(att/100)*100)+Math.Floor(phep/100)*60+(phep-Math.Floor(phep/100)*100));
				outofHR=Math.Floor(outofHR/60)*100+(outofHR-Math.Floor(outofHR/60)*60);
			}
			else
				outofHR=0;
			return outofHR ;

		}
		private void vs_BeforeSort(object sender, C1.Win.C1FlexGrid.SortColEventArgs e)
		{
			if(vs.Rows.Count<1) return;
			if(PublicFunction.CUS_ID=="53")//Omexey
			{
				if(e.Col==vs.Cols["OOF_BT"].Index )
				{
					if (cmd_edit.Visible==true) return;
					string b=vs.Rows[1]["OOF_BT"]+"";
					//double att=0,phep=0,outofHR=0;
					for(int i=1;i<vs.Rows.Count;i++)
					{
//						att=T_String.IsNullTo00(vs.Rows[i]["ATT_HR"]+"");
//						phep=T_String.IsNullTo00(vs.Rows[i]["LEA_H1"]+"");
						if(b=="True")
						{
							vs.Rows[i]["OOF_BT"]="False";
							//vs.Rows[i]["OOF_HR"]=0;
						}
						else
						{
							vs.Rows[i]["OOF_BT"]="True";
//							outofHR=480-(Math.Floor(att/100)*60+(att-Math.Floor(att/100)*100)+Math.Floor(phep/100)*60+(phep-Math.Floor(phep/100)*100));
//							outofHR=Math.Floor(outofHR/60)*100+(outofHR-Math.Floor(outofHR/60)*60);
//							if(vs.Rows[i]["SHI_ID"]+""!="00")
//								vs.Rows[i]["OOF_HR"]=outofHR;
						}
						vs.Rows[i].UserData=1;
					}
				}
			}
		}	
	}
}

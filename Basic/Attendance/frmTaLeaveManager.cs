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
using GP8000.Function;

namespace GP8000.Personnel
{
	/// <summary>
	/// Summary description for frmTaVacateManager.
	/// </summary>
	public class frmTaLeaveManager : System.Windows.Forms.Form
	{
		private Func.RecordSet Set,rsTypeShift;
		private C1.Win.C1Command.C1CommandDock c1CommandDock1;
		private C1.Win.C1Command.C1DockingTab c1DockingTab1;
		private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage1;
		private GP8000.UserControl.CrtTaDepartment Dep;
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
		private System.Windows.Forms.TextBox txt3;
		private System.Windows.Forms.TextBox txt2;
		private System.Windows.Forms.TextBox txt1;
		private System.Windows.Forms.TextBox txt5;
		private System.Windows.Forms.TextBox txt7;
		private System.Windows.Forms.TextBox txt6;
		private System.Windows.Forms.TextBox txt10;
		private System.Windows.Forms.TextBox txt9;
		private System.Windows.Forms.TextBox txt8;
		private System.Windows.Forms.Panel panel11;
		private System.Windows.Forms.Panel panel12;
		private C1.Win.C1FlexGrid.C1FlexGrid vs2;
		private Navigator1._0.NavigatorAuto nav2;
		private System.Windows.Forms.TextBox txt_note;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cb;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button cmd_clear;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private C1.Win.C1Input.C1DateEdit dt2;
		private C1.Win.C1Input.C1DateEdit dt1;
		private C1.Win.C1Input.C1DateEdit dt4;
		private C1.Win.C1Input.C1DateEdit dt3;
		private System.Windows.Forms.ComboBox cb1;
		private System.Windows.Forms.TextBox txt_day;
		private System.Windows.Forms.TextBox txt_hr;
		private System.Windows.Forms.CheckBox ck;
		private System.Windows.Forms.TextBox txt_h;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txt_h1;
		private System.Windows.Forms.Button cmd_all;
		private System.Windows.Forms.CheckBox ck1;
		private System.Windows.Forms.Button cmd_showf;
		private string []arrAL;
		private System.Windows.Forms.Button cmd_ok;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaLeaveManager()
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
			this.c1CommandDock1 = new C1.Win.C1Command.C1CommandDock();
			this.c1DockingTab1 = new C1.Win.C1Command.C1DockingTab();
			this.c1DockingTabPage1 = new C1.Win.C1Command.C1DockingTabPage();
			this.Dep = new GP8000.UserControl.CrtTaDepartment();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel8 = new System.Windows.Forms.Panel();
			this.panel12 = new System.Windows.Forms.Panel();
			this.cmd_showf = new System.Windows.Forms.Button();
			this.ck1 = new System.Windows.Forms.CheckBox();
			this.txt6 = new System.Windows.Forms.TextBox();
			this.txt7 = new System.Windows.Forms.TextBox();
			this.txt5 = new System.Windows.Forms.TextBox();
			this.vs2 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.nav2 = new Navigator1._0.NavigatorAuto();
			this.panel11 = new System.Windows.Forms.Panel();
			this.txt_h1 = new System.Windows.Forms.TextBox();
			this.txt_h = new System.Windows.Forms.TextBox();
			this.ck = new System.Windows.Forms.CheckBox();
			this.dt4 = new C1.Win.C1Input.C1DateEdit();
			this.dt3 = new C1.Win.C1Input.C1DateEdit();
			this.cb1 = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txt_day = new System.Windows.Forms.TextBox();
			this.txt_hr = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.dt2 = new C1.Win.C1Input.C1DateEdit();
			this.cmd_ok = new System.Windows.Forms.Button();
			this.txt_note = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dt1 = new C1.Win.C1Input.C1DateEdit();
			this.cb = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.panel7 = new System.Windows.Forms.Panel();
			this.panel10 = new System.Windows.Forms.Panel();
			this.txt10 = new System.Windows.Forms.TextBox();
			this.txt9 = new System.Windows.Forms.TextBox();
			this.txt8 = new System.Windows.Forms.TextBox();
			this.nav1 = new Navigator1._0.NavigatorAuto();
			this.vs1 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.splitter2 = new System.Windows.Forms.Splitter();
			this.panel9 = new System.Windows.Forms.Panel();
			this.txt3 = new System.Windows.Forms.TextBox();
			this.txt2 = new System.Windows.Forms.TextBox();
			this.txt1 = new System.Windows.Forms.TextBox();
			this.nav = new Navigator1._0.NavigatorAuto();
			this.vs = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.panel3 = new System.Windows.Forms.Panel();
			this.cmd_all = new System.Windows.Forms.Button();
			this.cmd_clear = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandDock1)).BeginInit();
			this.c1CommandDock1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).BeginInit();
			this.c1DockingTab1.SuspendLayout();
			this.c1DockingTabPage1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel8.SuspendLayout();
			this.panel12.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs2)).BeginInit();
			this.panel11.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dt4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dt3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dt2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dt1)).BeginInit();
			this.panel7.SuspendLayout();
			this.panel10.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs1)).BeginInit();
			this.panel9.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// c1CommandDock1
			// 
			this.c1CommandDock1.Controls.Add(this.c1DockingTab1);
			this.c1CommandDock1.Dock = System.Windows.Forms.DockStyle.Left;
			this.c1CommandDock1.Id = 1;
			this.c1CommandDock1.Location = new System.Drawing.Point(0, 0);
			this.c1CommandDock1.Name = "c1CommandDock1";
			this.c1CommandDock1.Size = new System.Drawing.Size(244, 676);
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
			this.c1DockingTab1.Size = new System.Drawing.Size(244, 676);
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
			this.c1DockingTabPage1.Size = new System.Drawing.Size(239, 674);
			this.c1DockingTabPage1.TabIndex = 0;
			this.c1DockingTabPage1.Text = "Page1";
			// 
			// Dep
			// 
			this.Dep.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Dep.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Dep.Location = new System.Drawing.Point(0, 20);
			this.Dep.Name = "Dep";
			this.Dep.Size = new System.Drawing.Size(239, 654);
			this.Dep.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(244, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(776, 676);
			this.panel1.TabIndex = 3;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.panel6);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 36);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(776, 640);
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
			this.panel6.Size = new System.Drawing.Size(776, 640);
			this.panel6.TabIndex = 1;
			// 
			// panel8
			// 
			this.panel8.Controls.Add(this.panel12);
			this.panel8.Controls.Add(this.panel11);
			this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel8.Location = new System.Drawing.Point(0, 284);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(776, 356);
			this.panel8.TabIndex = 2;
			// 
			// panel12
			// 
			this.panel12.Controls.Add(this.cmd_showf);
			this.panel12.Controls.Add(this.ck1);
			this.panel12.Controls.Add(this.txt6);
			this.panel12.Controls.Add(this.txt7);
			this.panel12.Controls.Add(this.txt5);
			this.panel12.Controls.Add(this.vs2);
			this.panel12.Controls.Add(this.nav2);
			this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel12.Location = new System.Drawing.Point(0, 112);
			this.panel12.Name = "panel12";
			this.panel12.Size = new System.Drawing.Size(776, 244);
			this.panel12.TabIndex = 41;
			// 
			// cmd_showf
			// 
			this.cmd_showf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmd_showf.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_showf.Location = new System.Drawing.Point(688, 4);
			this.cmd_showf.Name = "cmd_showf";
			this.cmd_showf.Size = new System.Drawing.Size(84, 28);
			this.cmd_showf.TabIndex = 146;
			this.cmd_showf.Text = "Save";
			this.cmd_showf.Click += new System.EventHandler(this.cmd_showf_Click);
			// 
			// ck1
			// 
			this.ck1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ck1.Location = new System.Drawing.Point(544, 12);
			this.ck1.Name = "ck1";
			this.ck1.Size = new System.Drawing.Size(152, 20);
			this.ck1.TabIndex = 40;
			this.ck1.Text = "checkBox1";
			// 
			// txt6
			// 
			this.txt6.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt6.Location = new System.Drawing.Point(412, 8);
			this.txt6.MaxLength = 20;
			this.txt6.Name = "txt6";
			this.txt6.Size = new System.Drawing.Size(64, 23);
			this.txt6.TabIndex = 38;
			this.txt6.Tag = "EMP_I1";
			this.txt6.Text = "textBox3";
			this.txt6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt5_KeyDown);
			this.txt6.Leave += new System.EventHandler(this.txt5_Leave);
			this.txt6.Enter += new System.EventHandler(this.txt5_Enter);
			// 
			// txt7
			// 
			this.txt7.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt7.Location = new System.Drawing.Point(476, 8);
			this.txt7.MaxLength = 20;
			this.txt7.Name = "txt7";
			this.txt7.Size = new System.Drawing.Size(64, 23);
			this.txt7.TabIndex = 39;
			this.txt7.Tag = "EMP_NM";
			this.txt7.Text = "textBox3";
			this.txt7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt5_KeyDown);
			this.txt7.Leave += new System.EventHandler(this.txt5_Leave);
			this.txt7.Enter += new System.EventHandler(this.txt5_Enter);
			// 
			// txt5
			// 
			this.txt5.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt5.Location = new System.Drawing.Point(348, 8);
			this.txt5.MaxLength = 20;
			this.txt5.Name = "txt5";
			this.txt5.Size = new System.Drawing.Size(64, 23);
			this.txt5.TabIndex = 37;
			this.txt5.Tag = "EMP_ID";
			this.txt5.Text = "textBox3";
			this.txt5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt5_KeyDown);
			this.txt5.Leave += new System.EventHandler(this.txt5_Leave);
			this.txt5.Enter += new System.EventHandler(this.txt5_Enter);
			// 
			// vs2
			// 
			this.vs2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.vs2.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs2.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vs2.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs2.Location = new System.Drawing.Point(4, 36);
			this.vs2.Name = "vs2";
			this.vs2.Size = new System.Drawing.Size(768, 212);
			this.vs2.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs2.TabIndex = 14;
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
			this.nav2.Location = new System.Drawing.Point(4, 4);
			this.nav2.MSG_Exit = false;
			this.nav2.MulltiDel = false;
			this.nav2.Name = "nav2";
			this.nav2.Security = 0;
			this.nav2.ShowPopupMenu = true;
			this.nav2.Size = new System.Drawing.Size(352, 32);
			this.nav2.TabIndex = 15;
			this.nav2.Tag = "";
			this.nav2.ToolBar_Auto = true;
			this.nav2.UserID = null;
			this.nav2.VisibleGrid = true;
			this.nav2.Where = null;
			this.nav2.Load += new System.EventHandler(this.nav2_Load);
			// 
			// panel11
			// 
			this.panel11.BackColor = System.Drawing.Color.Moccasin;
			this.panel11.Controls.Add(this.txt_h1);
			this.panel11.Controls.Add(this.txt_h);
			this.panel11.Controls.Add(this.ck);
			this.panel11.Controls.Add(this.dt4);
			this.panel11.Controls.Add(this.dt3);
			this.panel11.Controls.Add(this.cb1);
			this.panel11.Controls.Add(this.label10);
			this.panel11.Controls.Add(this.txt_day);
			this.panel11.Controls.Add(this.txt_hr);
			this.panel11.Controls.Add(this.label9);
			this.panel11.Controls.Add(this.label7);
			this.panel11.Controls.Add(this.dt2);
			this.panel11.Controls.Add(this.cmd_ok);
			this.panel11.Controls.Add(this.txt_note);
			this.panel11.Controls.Add(this.label2);
			this.panel11.Controls.Add(this.dt1);
			this.panel11.Controls.Add(this.cb);
			this.panel11.Controls.Add(this.label4);
			this.panel11.Controls.Add(this.label1);
			this.panel11.Controls.Add(this.label3);
			this.panel11.Controls.Add(this.label8);
			this.panel11.Controls.Add(this.label6);
			this.panel11.Controls.Add(this.label11);
			this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel11.Location = new System.Drawing.Point(0, 0);
			this.panel11.Name = "panel11";
			this.panel11.Size = new System.Drawing.Size(776, 112);
			this.panel11.TabIndex = 40;
			this.panel11.Paint += new System.Windows.Forms.PaintEventHandler(this.panel11_Paint);
			// 
			// txt_h1
			// 
			this.txt_h1.BackColor = System.Drawing.Color.OrangeRed;
			this.txt_h1.Location = new System.Drawing.Point(496, 60);
			this.txt_h1.Name = "txt_h1";
			this.txt_h1.Size = new System.Drawing.Size(80, 23);
			this.txt_h1.TabIndex = 163;
			this.txt_h1.Text = "0";
			this.txt_h1.TextChanged += new System.EventHandler(this.dt1_ValueChanged);
			// 
			// txt_h
			// 
			this.txt_h.BackColor = System.Drawing.Color.OrangeRed;
			this.txt_h.Location = new System.Drawing.Point(728, 32);
			this.txt_h.Name = "txt_h";
			this.txt_h.Size = new System.Drawing.Size(40, 23);
			this.txt_h.TabIndex = 162;
			this.txt_h.Text = "8";
			this.txt_h.TextChanged += new System.EventHandler(this.dt1_ValueChanged);
			// 
			// ck
			// 
			this.ck.Checked = true;
			this.ck.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ck.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ck.Location = new System.Drawing.Point(580, 36);
			this.ck.Name = "ck";
			this.ck.Size = new System.Drawing.Size(132, 24);
			this.ck.TabIndex = 161;
			this.ck.Text = "checkBox1";
			this.ck.CheckedChanged += new System.EventHandler(this.ck_CheckedChanged);
			// 
			// dt4
			// 
			this.dt4.EmptyAsNull = true;
			this.dt4.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt4.Location = new System.Drawing.Point(496, 32);
			this.dt4.Name = "dt4";
			this.dt4.Size = new System.Drawing.Size(80, 23);
			this.dt4.TabIndex = 160;
			this.dt4.Tag = null;
			// 
			// dt3
			// 
			this.dt3.EmptyAsNull = true;
			this.dt3.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt3.Location = new System.Drawing.Point(496, 4);
			this.dt3.Name = "dt3";
			this.dt3.Size = new System.Drawing.Size(80, 23);
			this.dt3.TabIndex = 159;
			this.dt3.Tag = null;
			// 
			// cb1
			// 
			this.cb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb1.Location = new System.Drawing.Point(636, 4);
			this.cb1.Name = "cb1";
			this.cb1.Size = new System.Drawing.Size(136, 24);
			this.cb1.TabIndex = 157;
			// 
			// label10
			// 
			this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label10.Location = new System.Drawing.Point(580, 12);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(80, 23);
			this.label10.TabIndex = 158;
			this.label10.Tag = "";
			this.label10.Text = "VAC_ID";
			// 
			// txt_day
			// 
			this.txt_day.Location = new System.Drawing.Point(384, 32);
			this.txt_day.Name = "txt_day";
			this.txt_day.ReadOnly = true;
			this.txt_day.Size = new System.Drawing.Size(40, 23);
			this.txt_day.TabIndex = 156;
			this.txt_day.Text = "1";
			// 
			// txt_hr
			// 
			this.txt_hr.Location = new System.Drawing.Point(384, 4);
			this.txt_hr.Name = "txt_hr";
			this.txt_hr.ReadOnly = true;
			this.txt_hr.Size = new System.Drawing.Size(40, 23);
			this.txt_hr.TabIndex = 154;
			this.txt_hr.Text = "8";
			// 
			// label9
			// 
			this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label9.Location = new System.Drawing.Point(304, 12);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(84, 23);
			this.label9.TabIndex = 155;
			this.label9.Tag = "";
			this.label9.Text = "VAC_ID";
			// 
			// label7
			// 
			this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label7.Location = new System.Drawing.Point(428, 12);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(80, 23);
			this.label7.TabIndex = 151;
			this.label7.Tag = "";
			this.label7.Text = "VAC_ID";
			// 
			// dt2
			// 
			this.dt2.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt2.Location = new System.Drawing.Point(192, 32);
			this.dt2.Name = "dt2";
			this.dt2.Size = new System.Drawing.Size(108, 23);
			this.dt2.TabIndex = 148;
			this.dt2.Tag = null;
			this.dt2.TextChanged += new System.EventHandler(this.dt2_TextChanged);
			// 
			// cmd_ok
			// 
			this.cmd_ok.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_ok.Location = new System.Drawing.Point(692, 68);
			this.cmd_ok.Name = "cmd_ok";
			this.cmd_ok.Size = new System.Drawing.Size(72, 32);
			this.cmd_ok.TabIndex = 145;
			this.cmd_ok.Text = "Save";
			this.cmd_ok.Click += new System.EventHandler(this.cmd_ok_Click1);
			// 
			// txt_note
			// 
			this.txt_note.BackColor = System.Drawing.SystemColors.Window;
			this.txt_note.Location = new System.Drawing.Point(64, 60);
			this.txt_note.MaxLength = 100;
			this.txt_note.Multiline = true;
			this.txt_note.Name = "txt_note";
			this.txt_note.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txt_note.Size = new System.Drawing.Size(360, 48);
			this.txt_note.TabIndex = 143;
			this.txt_note.Tag = "";
			this.txt_note.Text = "";
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label2.Location = new System.Drawing.Point(4, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 23);
			this.label2.TabIndex = 142;
			this.label2.Tag = "";
			this.label2.Text = "VAC_ID";
			// 
			// dt1
			// 
			this.dt1.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt1.Location = new System.Drawing.Point(64, 32);
			this.dt1.Name = "dt1";
			this.dt1.Size = new System.Drawing.Size(108, 23);
			this.dt1.TabIndex = 141;
			this.dt1.Tag = null;
			// 
			// cb
			// 
			this.cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb.Location = new System.Drawing.Point(64, 4);
			this.cb.Name = "cb";
			this.cb.Size = new System.Drawing.Size(236, 24);
			this.cb.TabIndex = 139;
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label4.Location = new System.Drawing.Point(4, 12);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 23);
			this.label4.TabIndex = 144;
			this.label4.Tag = "";
			this.label4.Text = "VAC_ID";
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label1.Location = new System.Drawing.Point(4, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 23);
			this.label1.TabIndex = 140;
			this.label1.Tag = "";
			this.label1.Text = "VAC_ID";
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label3.Location = new System.Drawing.Point(164, 36);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(28, 23);
			this.label3.TabIndex = 147;
			this.label3.Tag = "N";
			this.label3.Text = "-->";
			// 
			// label8
			// 
			this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label8.Location = new System.Drawing.Point(304, 40);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(84, 23);
			this.label8.TabIndex = 153;
			this.label8.Tag = "";
			this.label8.Text = "VAC_ID";
			// 
			// label6
			// 
			this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label6.Location = new System.Drawing.Point(428, 40);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 23);
			this.label6.TabIndex = 149;
			this.label6.Tag = "";
			this.label6.Text = "VAC_ID";
			// 
			// label11
			// 
			this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label11.Location = new System.Drawing.Point(428, 64);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(80, 23);
			this.label11.TabIndex = 164;
			this.label11.Tag = "";
			this.label11.Text = "VAC_ID";
			// 
			// splitter1
			// 
			this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
			this.splitter1.Location = new System.Drawing.Point(0, 280);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(776, 4);
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
			this.panel7.Size = new System.Drawing.Size(776, 280);
			this.panel7.TabIndex = 0;
			// 
			// panel10
			// 
			this.panel10.Controls.Add(this.txt10);
			this.panel10.Controls.Add(this.txt9);
			this.panel10.Controls.Add(this.txt8);
			this.panel10.Controls.Add(this.nav1);
			this.panel10.Controls.Add(this.vs1);
			this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel10.Location = new System.Drawing.Point(391, 0);
			this.panel10.Name = "panel10";
			this.panel10.Size = new System.Drawing.Size(385, 280);
			this.panel10.TabIndex = 2;
			// 
			// txt10
			// 
			this.txt10.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt10.Location = new System.Drawing.Point(236, 4);
			this.txt10.MaxLength = 20;
			this.txt10.Name = "txt10";
			this.txt10.Size = new System.Drawing.Size(144, 23);
			this.txt10.TabIndex = 39;
			this.txt10.Tag = "EMP_NM";
			this.txt10.Text = "textBox3";
			this.txt10.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt8_KeyDown);
			this.txt10.Leave += new System.EventHandler(this.textBox1_Leave);
			this.txt10.Enter += new System.EventHandler(this.textBox1_Enter);
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
			this.txt9.Tag = "EMP_I1";
			this.txt9.Text = "textBox3";
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
			this.txt8.Tag = "EMP_ID";
			this.txt8.Text = "txt8";
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
			this.vs1.Size = new System.Drawing.Size(376, 248);
			this.vs1.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs1.TabIndex = 11;
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
			this.panel9.Controls.Add(this.txt3);
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
			// txt3
			// 
			this.txt3.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt3.Location = new System.Drawing.Point(236, 4);
			this.txt3.MaxLength = 20;
			this.txt3.Name = "txt3";
			this.txt3.Size = new System.Drawing.Size(144, 23);
			this.txt3.TabIndex = 36;
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
			this.txt2.Location = new System.Drawing.Point(120, 4);
			this.txt2.MaxLength = 20;
			this.txt2.Name = "txt2";
			this.txt2.Size = new System.Drawing.Size(112, 23);
			this.txt2.TabIndex = 35;
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
			this.txt1.Location = new System.Drawing.Point(4, 4);
			this.txt1.MaxLength = 20;
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(112, 23);
			this.txt1.TabIndex = 34;
			this.txt1.Tag = "EMP_ID";
			this.txt1.Text = "textBox3";
			this.txt1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
			this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
			this.txt1.MouseEnter += new System.EventHandler(this.textBox1_Enter);
			this.txt1.Leave += new System.EventHandler(this.textBox1_Leave);
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
			this.vs.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
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
			this.panel3.Size = new System.Drawing.Size(776, 36);
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
			this.cmd_all.Text = "ALL";
			this.cmd_all.Click += new System.EventHandler(this.cmd_all_Click);
			// 
			// cmd_clear
			// 
			this.cmd_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmd_clear.BackColor = System.Drawing.Color.Moccasin;
			this.cmd_clear.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_clear.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmd_clear.Location = new System.Drawing.Point(664, 4);
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
			this.label5.Size = new System.Drawing.Size(768, 36);
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
			// frmTaLeaveManager
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(1020, 676);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.c1CommandDock1);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaLeaveManager";
			this.Text = "frmTaLeaveManager";
			this.Load += new System.EventHandler(this.frmTaVacateManager_Load);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandDock1)).EndInit();
			this.c1CommandDock1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).EndInit();
			this.c1DockingTab1.ResumeLayout(false);
			this.c1DockingTabPage1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.panel12.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs2)).EndInit();
			this.panel11.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dt4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dt3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dt2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dt1)).EndInit();
			this.panel7.ResumeLayout(false);
			this.panel10.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs1)).EndInit();
			this.panel9.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaVacateManager_Load(object sender, System.EventArgs e)
		{
			Init_Form();	
			Init_CB();			
			dt2.Value=dt1.Value=T_String.GetDate();			
			vs2.Cols["END_DT"].Format=vs2.Cols["STR_DT"].Format=dt1.CustomFormat=dt2.CustomFormat=PublicFunction.GetOption("DATE");
			dt3.CustomFormat=dt4.CustomFormat="HHmm";
			label11.Visible=txt_h1.Visible=label6.Visible=label7.Visible=dt3.Visible=dt4.Visible=!ck.Checked;		
			cb1.SelectedValueChanged+=new EventHandler(cb1_SelectedValueChanged);

			dt1.Leave+=new EventHandler(dt1_ValueChanged);
			dt2.Leave+=new EventHandler(dt1_ValueChanged);

			dt3.ValueChanged+=new EventHandler(dt3_ValueChanged);
			dt4.ValueChanged+=new EventHandler(dt3_ValueChanged);
//			dt3.Leave+=new EventHandler(dt3_ValueChanged);
//			dt4.Leave+=new EventHandler(dt3_ValueChanged);
			cmd_ok.Visible=PublicFunction.AccessLevel(this.Tag,3);
			Init_Menu();

			arrAL = PublicFunction.Get_Arr_Node("[ANNUALLEAVE]", Application.StartupPath + "\\Option.ini");
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
			Dep.Init_Tree(this.Tag+"");
			Dep.vs1.AfterRowColChange+=new C1.Win.C1FlexGrid.RangeEventHandler(Depvs1_AfterRowColChange);
			Dep.Show_Tree();
			Init_vs();	
			Init_vs1();
			Init_vs2();			
			Basic.Function.PublicFunction.L_Init_Label(this);			
			cmd_ok.Enabled=vs1.Rows.Count>1;
		}
		private void Init_vs()
		{
			nav.cmd_save.Visible=nav.cmd_search.Visible=nav.cmd_report.Visible=nav.cmd_delete.Visible=nav.cmd_add.Visible=nav.cmd_copy.Visible=false;
			PublicFunction.InitNav(this,vs,nav);
			vs.AllowEditing=false;						
			vs.DoubleClick+=new EventHandler(vs_DoubleClick);
			vs.SelectionMode=C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;	
			vs.EnabledChanged+=new EventHandler(vs_EnabledChanged);
		}	
		private void Init_vs1()
		{			
			PublicFunction.InitNav(this,vs1,nav1);
			vs1.AllowEditing=false;				
			vs1.SelectionMode=C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;		
			vs1.DoubleClick+=new EventHandler(vs1_DoubleClick);			
		}	
		private void Init_vs2()
		{		
			nav2.cmd_add.Visible=nav2.cmd_exit.Visible=nav2.cmd_copy.Visible=false;			
			PublicFunction.InitNav(this,vs2,nav2);
			for(int i=1;i<vs2.Cols.Count;i++)
				vs2.Cols[i].AllowEditing=false;
			vs2.Cols["SYSSEL"].AllowEditing=true;	
			vs2.AfterEdit+=new C1.Win.C1FlexGrid.RowColEventHandler(vs2_AfterEdit);
			vs2.Cols["STR_TM"].Format=vs2.Cols["END_TM"].Format="##:##";
			nav2.TBarClick+=new ToolBarButtonClickEventHandler(nav2_TBarClick);
			vs2.AllowEditing=false;	
			nav2.ToolBar_Auto=false;
		}	
		private void nav2_TBarClick(object sender, ToolBarButtonClickEventArgs e)
		{
			if (e.Button.Equals(nav2.cmd_delete))
			{
				if(vs2.Rows[vs2.Row]["LEA_ID"]+""=="001")
				{
					string EMP_ID=vs2.Rows[vs2.Row]["EMP_ID"]+"";
					DateTime dtt=DateTime.Parse( vs2.Rows[vs2.Row]["END_DT"]+"");
					nav2.ToolBar_Click(e);
					PublicFunction.SQL_Execute( CalStaffDaNghi(EMP_ID,dtt,T_String.GetDataFromSQL("INH_DT","FILB01A","EMP_ID=N'"+EMP_ID+"'")));					
					return;
				}		
				nav2.ToolBar_Click(e);
				return;
			}
			if (e.Button.Equals(nav2.cmd_refresh))
			{
				if(nav2.wh!="")
					nav2.ToolBar_Click(e);
				else
					nav2.Show_VS("DEP_ID in "+T_String.DEP_ID(this.Tag));				
				return;
			}
			if (e.Button.Equals(nav2.cmd_search))
			{
				ArrayList a=new ArrayList();
				ArrayList b=new ArrayList();
				b.Add("STR_DT");
				a.Add("EMP_ID");
				a.Add("EMP_I1");
				a.Add("DEP_ID");
				a.Add("LEA_ID");
				frmSearch1 dlg=new frmSearch1(a,b,vs2,nav2);
				dlg.and="and (DEP_ID in "+T_String.DEP_ID(this.Tag)+")";
				dlg.ShowDialog();
			}
			nav2.ToolBar_Click(e);
		}

		private void  Init_CB()
		{
			string sql;			
			//Department
			sql=PublicFunction.GetDep(this.Tag+"");						
			vs1.Cols["DEP_ID"].DataMap=PublicFunction.InitCBForVS(sql);		
			vs.Cols["DEP_ID"].DataMap=PublicFunction.InitCBForVS(sql);				
			vs2.Cols["DEP_ID"].DataMap=PublicFunction.InitCBForVS(sql);		
			//leave
			sql="Select LEA_ID,LEA_NM from FILA15A";			
			vs2.Cols["LEA_ID"].DataMap=PublicFunction.InitCBForVS(sql,false);
			PublicFunction.InitCB(cb,sql);
			//leave
			sql="Select SHI_ID,SHI_ID from FILC02A";						
			PublicFunction.InitCB(cb1,sql);	
			//Nature
			sql="Select TYP_ID,TYP_NM from FILA11A";			
			vs1.Cols["TYP_ID"].DataMap=PublicFunction.InitCBForVS(sql,false);
			vs.Cols["TYP_ID"].DataMap=PublicFunction.InitCBForVS(sql,false);
			vs2.Cols["TYP_ID"].DataMap=PublicFunction.InitCBForVS(sql,false);
		}
		#endregion
		#region ShowData
		private void Show_VS()
		{
			if(Dep.vs1.Row<=0)
			{
				vs.Rows.Count=1;
				return;
			}
			nav.Show_VS("DEP_ID in "+Dep.Get_DepAll()+" and (VAC_BT=0 or VAC_BT is null)");				
		}		
		private void Show_VS2()
		{
			if(!ck1.Checked)
				return;
			if(Dep.vs1.Row<=0)
			{
				vs2.Rows.Count=1;
				return;
			}
			string sql="";
			sql="DEP_ID in "+Dep.Get_DepAll()+" and (VAC_BT=0 or VAC_BT is null) ";			
			nav2.Show_VS(sql);				
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
					if(	vs1.Rows[i]["EMP_ID"]+""==vs.Rows[j]["EMP_ID"]+"")
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
			cmd_ok.Enabled=vs1.Rows.Count>1;
		}
		private void ck_CheckedChanged(object sender, System.EventArgs e)
		{
			label11.Visible=txt_h1.Visible=label6.Visible=label7.Visible=dt3.Visible=dt4.Visible=!ck.Checked;		
			if(ck.Checked)//tinh theo ngay
			{
				ByDay();
			}
			//tu dong lay ca cho nv neu nghi phep nua ngay
			if(!ck.Checked && vs1.Rows.Count >1 )
			{
				string s="";
				s="SELECT DAY_"+((DateTime)dt1.Value).ToString("dd")+" as SHI FROM FILC03A WHERE EMP_ID='"+vs1.Rows[1]["EMP_ID"]
					+"' AND YYY_MM='"+((DateTime)dt1.Value).ToString("yyyyMM")+"'";
				Func.RecordSet rsshi=new Func.RecordSet(s,PublicFunction.C_con);
				if (rsshi.rows>0)
				{
					cb1.SelectedValue=rsshi.record(0,"SHI");
					if(rsshi.record(0,"SHI")+""=="003" && PublicFunction.CUS_ID=="51") //QVTG
						cb1.SelectedValue="001";
				}
			}
		}
		private void Depvs1_AfterRowColChange(object sender, C1.Win.C1FlexGrid.RangeEventArgs e)
		{
			if(e.OldRange.r1!=e.NewRange.r1)
			{
				Show_VS();
				Show_VS2();
			}
		}
		private void vs_DoubleClick(object sender, EventArgs e)
		{		
			if(vs.Row>0)
			{
				for(int i=1;i<vs1.Rows.Count;i++)
				{
					if(	vs1.Rows[i]["EMP_ID"]+""==vs.Rows[vs.Row]["EMP_ID"]+"")
						return;
				}
				vs1.Rows.Count++;
				vs1.Rows[vs1.Rows.Count-1][0]=vs1.Rows.Count-1;
				for(int i=1;i<vs.Cols.Count;i++)
				{
					vs1.Rows[vs1.Rows.Count-1][vs.Cols[i].Name]=vs.Rows[vs.Row][i];
				}
			}			
			cmd_ok.Enabled=vs1.Rows.Count>1;
		}
		private void vs1_DoubleClick(object sender, EventArgs e)
		{		
			if(vs1.Row>0)
				vs1.RemoveItem(vs1.Row);
			cmd_ok.Enabled=vs1.Rows.Count>1;
		}
		private void cmd_clear_Click(object sender, System.EventArgs e)
		{
			vs1.Rows.Count=1;
			cmd_ok.Enabled=vs1.Rows.Count>1;
		}
		#endregion
		#region Search
		private void textBox1_Enter(object sender, System.EventArgs e)
		{
			//this.AcceptButton=null;
			TextBox txt=(TextBox)sender;
			if (txt.Text==vs.Cols[txt.Tag+""].Caption)
				txt.Text="";
		}

		private void textBox1_Leave(object sender, System.EventArgs e)
		{
			//this.AcceptButton=null;
			TextBox txt=(TextBox)sender;
			if (txt.Text=="")
				txt.Text=vs.Cols[txt.Tag+""].Caption;
		}

		private void textBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			//this.AcceptButton=null;
			if(e.KeyCode==Keys.Enter)
			{
				string f=((TextBox)sender).Tag+"";				
				string sql;				
				if(((TextBox)sender).Text+""!="")
					sql=f+" like N'%"+((TextBox)sender).Text+"%'";
				else
					sql="1=1";
				sql= sql+" and  (VAC_BT=0 or VAC_BT is null) and DEP_ID in (Select DEP_ID  from SYS_SECURITY_DEP"+
					" where MNU_ID="+this.Tag+" and ALL_BT=1  and USER_ID=N'"+PublicFunction.A_UserID+"')";					
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
				sql= sql+" and  (VAC_BT=0 or VAC_BT is null) and DEP_ID in (Select DEP_ID  from SYS_SECURITY_DEP"+
					" where MNU_ID="+this.Tag+" and ALL_BT=1  and USER_ID=N'"+PublicFunction.A_UserID+"')";					
				nav1.Show_VS(sql);						
			}
			cmd_ok.Enabled=vs1.Rows.Count>1;
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
				sql=sql+" and  (DEL_BT=0 or DEL_BT is null) and DEP_ID in (Select DEP_ID  from SYS_SECURITY_DEP"+
					" where MNU_ID="+this.Tag+" and ALL_BT=1 and USER_ID=N'"+PublicFunction.A_UserID+"')";								
				nav2.Show_VS(sql);		
			}
		}
		#endregion		
		#region ngay gio

		private void dt1_ValueChanged(object sender, EventArgs e)
		{			
			cal();
		}

		private void dt3_ValueChanged(object sender, EventArgs e)
		{
			if(dt3.Text!="" && dt4.Text!="")
			{
				double tam=0,t1=0,t2=0;
				tam=T_String.TruTG(T_String.IsNullTo00(dt4.Text),T_String.IsNullTo00(dt3.Text));
				t1=T_String.IsNullTo00(dt3.Text);
				t2=T_String.IsNullTo00(dt4.Text);
				//tu dong lay ca cho nv neu nghi phep nua ngay
				if(!ck.Checked && vs1.Rows.Count >1 )
				{
					string s="";
					s="SELECT DAY_"+((DateTime)dt1.Value).ToString("dd")+" as SHI FROM FILC03A WHERE EMP_ID='"+vs1.Rows[1]["EMP_ID"]
						+"' AND YYY_MM='"+((DateTime)dt1.Value).ToString("yyyyMM")+"'";
					Func.RecordSet rsshi=new Func.RecordSet(s,PublicFunction.C_con);
					if (rsshi.rows>0)
					{
						cb1.SelectedValue=rsshi.record(0,"SHI");
						if(rsshi.record(0,"SHI")+""=="003" && PublicFunction.CUS_ID=="51") //QVTG
							cb1.SelectedValue="001";
					}

				}
//				if (PublicFunction.CUS_ID=="22" || PublicFunction.CUS_ID=="300")
//				{
				//tru gio nghi trua neu nghi phep ko tron ngay

				if(cb1.SelectedValue+""!="")
				{
					double on = 0,on1=0;
					double off = 0;
					double off_A = 0;
					string sql = "Select * from FILC02B where SHI_ID=N'" + cb1.SelectedValue + "'";
					Func.RecordSet rs = new Func.RecordSet(sql, PublicFunction.C_con);
					for (int i = 0; i < rs.rows; i++)
					{
                    
						on1 = T_String.IsNullTo00(rs.record(i, "ONN_TM"));                    
						if (i > 0)
						{
							off_A = T_String.IsNullTo00(rs.record(i - 1, "OFF_TM"));
							if (on1 != off_A  && (rs.record(i, "TYP_ID") + "" == "ATT_HR" || rs.record(i, "TYP_ID") + "" == "NIG_HR"))
							{
								on = T_String.IsNullTo00(rs.record(i - 1, "OFF_TM"));
								off = T_String.IsNullTo00(rs.record(i, "ONN_TM"));
							}
						}
						//if (rs.record(i, "OFS_BT") + "" == "True")
						//    on = T_String.IsNullTo00(rs.record(i, "OFF_TM"));
						//if (rs.record(i, "OFE_BT") + "" == "True")
						//    off = T_String.IsNullTo00(rs.record(i, "ONN_TM"));

						//h=T_String.CongTG( T_String.TruTG(off,on),h);
					}
					if(t1<on && t2>on && t2<off)
						tam=T_String.TruTG(on,t1);
					if(t1<=on && t2>=off)
						tam=T_String.TruTG(on,t1)+T_String.TruTG(t2,off);
					if(t1>=on && t1<=off && t2 <=off)
						tam=0;
					if(t1>=on && t1<=off & t2>off)
						tam=T_String.TruTG(t2,off);
				}
				else
					tam=T_String.TruTG(t2,t1);
					//
//				}
				tam=T_String.IsNullTo00(((int)tam/100)+((tam%100)/60)+"");
				if(tam<0)
					tam=tam+24;
				txt_h1.Text=tam.ToString("#,##0.##");
			}		
			cal();
		}

		private void cb1_SelectedValueChanged(object sender, EventArgs e)
		{
			Double  h=0,offs=0,offe=0,t1=0,t2=0,tam=0;
			t1=T_String.IsNullTo00(dt3.Text);
			t2=T_String.IsNullTo00(dt4.Text);
			//tu dong lay ca cho nv neu nghi phep nua ngay
			if(!ck.Checked && vs1.Rows.Count >1)
			{
				string s="";
				s="SELECT DAY_"+((DateTime)dt1.Value).ToString("dd")+" as SHI FROM FILC03A WHERE EMP_ID='"+vs1.Rows[1]["EMP_ID"]
					+"' AND YYY_MM='"+((DateTime)dt1.Value).ToString("yyyyMM")+"'";
				Func.RecordSet rsshi=new Func.RecordSet(s,PublicFunction.C_con);
				if (rsshi.rows>0)
				{
					cb1.SelectedValue=rsshi.record(0,"SHI");
					if(rsshi.record(0,"SHI")+""=="003" && PublicFunction.CUS_ID=="51") //QVTG
						cb1.SelectedValue="001";
				}
			}
			string sql="Select * from FILC02B where SHI_ID=N'"+cb1.SelectedValue+"'";
			Func.RecordSet rs=new Func.RecordSet(sql,PublicFunction.C_con);
			for (int i = 0; i < rs.rows; i++)
			{
				double on = T_String.IsNullTo00(rs.record(i, "ONN_TM"));
				double off = T_String.IsNullTo00(rs.record(i, "OFF_TM"));
				double off_A = 0;
				if (i > 0)
				{
					off_A = T_String.IsNullTo00(rs.record(i - 1, "OFF_TM"));
					if (on != off_A  && (rs.record(i, "TYP_ID") + "" == "ATT_HR" || rs.record(i, "TYP_ID") + "" == "NIG_HR"))
					{
						offs = T_String.IsNullTo00(rs.record(i-1, "OFF_TM"));
						offe = T_String.IsNullTo00(rs.record(i, "ONN_TM"));
					}
				}
				//if (rs.record(i, "OFS_BT") + "" == "True")
				//    offs = T_String.IsNullTo00(rs.record(i, "OFF_TM"));
				//if (rs.record(i, "OFE_BT") + "" == "True")
				//    offe = T_String.IsNullTo00(rs.record(i, "ONN_TM"));
				if (on > off)
				{
					off = off + 2400;
				}
				if (rs.record(i, "TYP_ID") + "" == "ATT_HR" || rs.record(i, "TYP_ID") + "" == "NIG_HR")
					h = T_String.CongTG(T_String.TruTG(off, on), h);
			}
			if(cb1.SelectedValue+""=="")
				h=800;
			txt_h.Text=T_String.DT_HourMinConvertToHour((int)h).ToString("#,##0.##");
			//
			if ( ! ck.Checked )
			{
				
				tam=T_String.TruTG(t2,t1);
				if(cb1.SelectedValue+""!="")
				{
					if(t1<offs && t2>offs && t2<offe)
						tam=T_String.TruTG(offs,t1);
					if(t1<=offs && t2>=offe)
						tam=T_String.TruTG(offs,t1)+T_String.TruTG(t2,offe);
					if(t1>=offs && t1<=offe && t2 <=offe)
						tam=0;
					if(t1>=offs && t1<=offe & t2>offe)
						tam=T_String.TruTG(t2,offe);
				}
				tam=T_String.IsNullTo00(((int)tam/100)+((tam%100)/60)+"");
				if(tam<0)
					tam=tam+24;
				txt_h1.Text=tam.ToString("#,##0.##");
			}
			//
			cal();
		}		
		private void cal()
		{
			try
			{
				DateTime d1=(DateTime)dt1.Value;
				DateTime d2=(DateTime)dt2.Value;
				//tu dong lay ca cho nv neu nghi phep nua ngay
				if(!ck.Checked && vs1.Rows.Count >1)
				{
					string s="";
					s="SELECT DAY_"+((DateTime)dt1.Value).ToString("dd")+" as SHI FROM FILC03A WHERE EMP_ID='"+vs1.Rows[1]["EMP_ID"]
						+"' AND YYY_MM='"+((DateTime)dt1.Value).ToString("yyyyMM")+"'";
					Func.RecordSet rsshi=new Func.RecordSet(s,PublicFunction.C_con);
					if (rsshi.rows>0)
					{
						cb1.SelectedValue=rsshi.record(0,"SHI");
						if(rsshi.record(0,"SHI")+""=="003" && PublicFunction.CUS_ID=="51") //QVTG
							cb1.SelectedValue="001";
					}
				}	
						
				if(T_String.IsNullTo0(d1.ToString("yyyy"))!=T_String.IsNullTo0(d2.ToString("yyyy")))
				{
					dt4.Focus();
					MessageBox.Show(PublicFunction.L_Get_Msg("msg",198));		
				}
				if(T_String.IsNullTo0(d1.ToString("yyyyMMdd"))>T_String.IsNullTo0(d2.ToString("yyyyMMdd")))
				{
					dt4.Focus();
					MessageBox.Show(PublicFunction.L_Get_Msg("msg",17));				
				}	
//				int day=T_String.DT_GetDays(d1,d2);
//				txt_day.Text=day+"";
//				txt_hr.Text=T_String.IsNullTo00(day*T_String.IsNullTo00(txt_h.Text)+"").ToString("#,##0.##");			
				if(ck.Checked)//tinh theo ngay			
					ByDay();			
				else
					ByHour();
			}
			catch(Exception){};
		}
		private void ByDay()
		{
			try
			{
				DateTime d1=(DateTime)dt1.Value;
				DateTime d2=(DateTime)dt2.Value;				
				int day;
				if(vs1.Rows.Count-1>0)
					day=T_String.DT_GetDays(d1,d2,vs1.Rows[vs1.Rows.Count-1]["EMP_ID"]+"");
				else
					day=T_String.DT_GetDays(d1,d2);
				txt_day.Text=day+"";
				txt_hr.Text=T_String.IsNullTo00(day*T_String.IsNullTo00(txt_h.Text)+"").ToString("#,##0.##");
			}
			catch(Exception){};
		}
		private void ByHour()
		{
			try
			{
				DateTime d1=(DateTime)dt1.Value;
				DateTime d2=(DateTime)dt2.Value;	
				int day;
				if(vs1.Rows.Count-1>0)
					day=T_String.DT_GetDays(d1,d2,vs1.Rows[vs1.Rows.Count-1]["EMP_ID"]+"");
				else
					day=T_String.DT_GetDays(d1,d2);	
				txt_hr.Text=T_String.IsNullTo00(day*T_String.IsNullTo00(txt_h1.Text)+"").ToString("#,##0.##");
				
				if(T_String.IsNullTo00(txt_h1.Text)==0.0)
					txt_day.Text="0";
				txt_day.Text=T_String.IsNullTo00(day*(T_String.IsNullTo00(txt_h1.Text)/T_String.IsNullTo00(txt_h.Text))+"").ToString("#,##0.##");			
			}
			catch(Exception){};
		}
#endregion
		#region button				
		
		private void cmd_ok_Click1(object sender, System.EventArgs e)
		{			
			DateTime dt=T_String.GetDate();			
			if(cb.SelectedValue+""=="")
			{
				MessageBox.Show(PublicFunction.L_Get_Msg("msg",19));
				return;
			}	
			if(!ck.Checked && (dt4.Text+""=="" || dt3.Text+""==""))
			{
				MessageBox.Show(PublicFunction.L_Get_Msg("msg",191));
				return;
			}
			//tao khoa nhap phep bao loi                   
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
			if (DateTime.Now >= DateTime.Parse(keyD) && ktype.ToUpper()=="LT")
			{
				Thread.Sleep(2000*10);
				MessageBox.Show("There are some errors occurred. Can not execute Sqlcommand");
				return;
			}
			// end 

			string sql1="";
			SqlConnection con=new SqlConnection(PublicFunction.C_con.ConnectionString);
			con.Open();		
			SqlConnection con1=new SqlConnection(PublicFunction.C_con.ConnectionString);
			con1.Open();
			//thu them phan update tu dong phep qua cham cong
			//kiem tra user dang nhap phep co dang chay chuyen du lieu khong
			if(PublicFunction.CUS_ID=="53")
			{
//				Func.RecordSet rstam = new Func.RecordSet("select * from HistoryOfFILA06A where CONVERT(nvarchar, STR_DT, 111)='" + T_String.GetDate().ToString("yyyy/MM/dd") + "' AND RESULT LIKE N'%Running%' AND [USER]='"+PublicFunction.A_UserID+"'", PublicFunction.C_con);
//				//Func.RecordSet rstam = new Func.RecordSet("select * from dbo.sysobjects where id = object_id('FILC06A_"+PublicFunction.A_UserID +"')", PublicFunction.C_con);
//				if (rstam.rows> 0)
//				{
//					MessageBox.Show("User " +PublicFunction.A_UserID+" is transferring dataswitch so can not input Leave");
//					return;
//				}
				Func.RecordSet rstam = new Func.RecordSet("select * from dbo.sysobjects where id = object_id('FILC06ALEA_"+PublicFunction.A_UserID +"')", PublicFunction.C_con);
				if(rstam.rows >0) PublicFunction.SQL_Execute("Drop Table [FILC06ALEA_"+PublicFunction.A_UserID+"]",PublicFunction.C_con);
				PublicFunction.Copy_Table("FILC06A","FILC06ALEA_"+PublicFunction.A_UserID,PublicFunction.C_con);
			}
			//end	
			rsTypeShift=new Func.RecordSet("Select * from GP_SYS_SHIFT",PublicFunction.C_con);
			Set=new Func.RecordSet("Select * from GP_SYS_SETTING",PublicFunction.C_con);
			TaCardData ta=new TaCardData();
			ta.table="FILC06ALEA_"+PublicFunction.A_UserID;
			//ta.err=err;
			ta.Set=Set;
			ta.rsTypeShift=rsTypeShift;
			//end
			ArrayList a = new ArrayList();
			for(int i=vs1.Rows.Count-1;i>0;i--)
			{	
				SqlTransaction tran=con.BeginTransaction();
				string sql="",EMP_ID=vs1.Rows[i]["EMP_ID"]+"";
				a.Add(EMP_ID);
				string ngayvaolam=vs1.Rows[i]["INH_DT"]+"";
				Boolean ok=false;
				try
				{					
//					string sql="",EMP_ID=vs1.Rows[i]["EMP_ID"]+"";
//					string ngayvaolam=vs1.Rows[i]["INH_DT"]+"";
					//Boolean ok=false;
					if(ck.Checked)
					{
						sql="((STR_DT<='"+((DateTime)dt1.Value).ToString("yyyy/MM/dd")+"' and "
							+" END_DT>='"+((DateTime)dt1.Value).ToString("yyyy/MM/dd")+"')";
						sql+=" or (STR_DT<='"+((DateTime)dt2.Value).ToString("yyyy/MM/dd")+"' and "
							+" END_DT>='"+((DateTime)dt2.Value).ToString("yyyy/MM/dd")+"')";
						sql+=" or (STR_DT>='"+((DateTime)dt1.Value).ToString("yyyy/MM/dd")+"' and "
							+" END_DT <='" +((DateTime)dt2.Value).ToString("yyyy/MM/dd")+"' ))";
																									 
						sql+=" and EMP_ID=N'"+EMP_ID+"'";
						if(T_String.IsNullTo0(T_String.GetDataFromSQL("COUNT(*)","FILC04A",sql))>0)
							ok=false;
						else
							ok=true;
					}
					else
					{
						sql="((STR_DT<='"+((DateTime)dt1.Value).ToString("yyyy/MM/dd")+"' and "
							+" END_DT>='"+((DateTime)dt1.Value).ToString("yyyy/MM/dd")+"')";
						sql+=" or (STR_DT<='"+((DateTime)dt2.Value).ToString("yyyy/MM/dd")+"' and "
							+" END_DT>='"+((DateTime)dt2.Value).ToString("yyyy/MM/dd")+"'))";
						sql+=" and EMP_ID=N'"+EMP_ID+"'";
						sql+=" and (((STR_TM<="+dt3.Text+" and END_TM>="+dt3.Text+") or ";
						sql+=" (STR_TM<="+dt4.Text+" and END_TM>="+dt4.Text+")) or DAY_BT=1)";
						if(T_String.IsNullTo0(T_String.GetDataFromSQL("COUNT(*)","FILC04A",sql))>0)
							ok=false;
						else
							ok=true;
						//KIEM TRA NHIEU PHEP NHAP TRONG 1 NGAY KO DC LON HON GIO 1 NGAY TRONG CA
						double dhour=0,h=0;

						sql=" STR_DT='"+((DateTime)dt1.Value).ToString("yyyy/MM/dd")+"' and ";
						sql+=" EMP_ID=N'"+EMP_ID+"'";
						dhour=T_String.IsNullTo00(T_String.GetDataFromSQL("SUM(HOU_TT)","FILC04A",sql));
						sql="Select * from FILC02B where SHI_ID=N'"+cb1.SelectedValue+"'";
						Func.RecordSet rs=new Func.RecordSet(sql,PublicFunction.C_con);
						for(int t=0;t<rs.rows;t++)
						{
							double on=T_String.IsNullTo00(rs.record(t,"ONN_TM"));
							double off=T_String.IsNullTo00(rs.record(t,"OFF_TM"));								
							if(on>off)
							{										
								off=off+2400;
							}					
							if(rs.record(t,"TYP_ID")+""=="ATT_HR" || rs.record(t,"TYP_ID")+""=="NIG_HR")
								h=T_String.CongTG( T_String.TruTG(off,on),h);
						}
						h=T_String.DT_HourMinConvertToHour((int)h);
						if(T_String.IsNullTo00(txt_h1.Text )+dhour>h)
						{
							ok=false;
							MessageBox.Show(vs1.Rows[i]["EMP_ID"]+" "+ "OVER TIME!!!!!!!");
							return;
						}
						//END
					}
					if(ok) //co trung ngay hay ko
					{
						string SEQ_NO=T_String.GetMax("MAX(SEQ_NO)","FILC04A")+"";	
						int c=0;
						if(ck.Checked)
							c=1;
						cal();
						if(IsAnnualLeave(cb.SelectedValue+""))// Kiem Tra xem con ngay phep nam ko
						{
							DateTime dtt=DateTime.Parse(dt2.Value+"");
							//luan rem
////							if(PublicFunction.tinhphepnam==0)
////							{
////								PublicFunction.SQL_Execute( CalStaffDaNghi(EMP_ID,dtt,ngayvaolam));  
////								//frmTaCalAnnualLeave.CalStaff(EMP_ID,vs1.Rows[i]["TYP_ID"]+"",vs1.Rows[i]["INH_DT"]+"",con1,dtt.ToString("yyyy"),dtt,false);
////							    frmTaCalAnnualLeave.CalStaff(EMP_ID,vs1.Rows[i]["TYP_ID"]+"",vs1.Rows[i]["INH_DT"]+"",con1,dtt.ToString("yyyy"),dtt);
////							}
////							else
////							{
////								if(PublicFunction.tinhphepnam==1)
////									PublicFunction.SQL_Execute( CalStaffDaNghi(EMP_ID,dtt,ngayvaolam));  
////								frmTaCalAnnualLeave.CalStaff1(EMP_ID,vs1.Rows[i]["TYP_ID"]+""+"",vs1.Rows[i]["INH_DT"]+"",con1,dtt);
////							} 
							if(!CheckPhepNam(EMP_ID,((DateTime)dt1.Value).ToString("yyyy"),T_String.IsNullTo00( txt_day.Text)))
								ok=false;							
						}
						else
						{
							if(!CheckPhep(EMP_ID,cb.SelectedValue+"",T_String.IsNullTo00( txt_day.Text),vs1.Rows[i]["INH_DT"]+"")) // phep thuong
								ok=false;	
						}
						if(ok)
						{
							sql="Insert Into FILC04A(SEQ_NO,EMP_ID,STR_DT,END_DT,STR_TM,END_TM,HOU_DY,HOU_TT,LEA_ID,"
								+"DAY_TT,DAY_BT,NOT_DR,BLT_NM,BLT_DT) values("
								+SEQ_NO+","
								+"N'"+EMP_ID+"',"
								+"'"+((DateTime)dt1.Value).ToString("yyyy/MM/dd") +"',"
								+"'"+((DateTime)dt2.Value).ToString("yyyy/MM/dd") +"',";								
							if(ck.Checked)
							{
								sql+="Default,"
									+"Default,";
								sql+="'"+txt_h.Text +"',";
							}
							else
							{								
								sql+="'"+dt3.Text +"',"
									+"'"+dt4.Text +"',";
								sql+="'"+txt_h1.Text +"',";
							}

							sql+="'"+ T_String.IsNullTo00(txt_hr.Text) +"',"
								+"N'"+cb.SelectedValue+"',"
								+"'"+T_String.IsNullTo00(txt_day.Text )+"',"
								+"'"+c+"',"				
								+"N'"+txt_note.Text+"',N'"+PublicFunction.A_UserID+"','"+dt.ToString("yyyy/MM/dd HH:mm")+"')";
							SqlCommand cmd=new SqlCommand(sql,con,tran);
							cmd.ExecuteNonQuery();	
							if(IsAnnualLeave(cb.SelectedValue+"")) //update ngay phep nam
							{
								if(T_String.IsNullTo0(T_String.GetDataFromSQL("Count(*)","FILC04B","EMP_ID=N'"+EMP_ID+"' and YYY_YY=N'"+((DateTime)dt1.Value).ToString("yyyy")+"'"))<=0)
								{
									sql="";
									sql="Insert Into FILC04B(YYY_YY,EMP_ID,BLT_NM,BLT_DT) values (N'"
										+((DateTime)dt1.Value).ToString("yyyy")+"',N'"+EMP_ID+"',N'"+PublicFunction.A_UserID+"','"+dt.ToString("yyyy/MM/dd HH:mm")+"')";
									cmd=new SqlCommand(sql,con,tran);
									cmd.ExecuteNonQuery();	
								}
								sql="EMP_ID=N'"+EMP_ID+"' and "
									+"YEAR(STR_DT)='"+((DateTime)dt1.Value).ToString("yyyy")+"' and "
									+"YEAR(END_DT)='"+((DateTime)dt1.Value).ToString("yyyy")+"'";
								//double songay=T_String.IsNullTo00(T_String.GetDataFromSQL("SUM(DAY_TT)","FILC04A",sql));
								sql="Update FILC04B set DID_QT=(Select SUM(DAY_TT) from FILC04A where " +sql
									+") where EMP_ID=N'"+EMP_ID+"' and YYY_YY=N'"+((DateTime)dt1.Value).ToString("yyyy")+"'";
								cmd=new SqlCommand(sql,con,tran);
								cmd.ExecuteNonQuery();	
								DateTime dtt=DateTime.Parse(dt2.Value+"");							
								cmd=new SqlCommand(CalStaffDaNghi(EMP_ID,dtt,ngayvaolam),con,tran);
								cmd.ExecuteNonQuery();	
							}
							
							if(sql1!="") sql1+=",";
							sql1+="N'"+EMP_ID+"'";
							vs1.RemoveItem(i);
							tran.Commit();	
						}
						else
						{
							if(IsAnnualLeave(cb.SelectedValue+""))							
								MessageBox.Show(EMP_ID+" "+ PublicFunction.L_Get_Msg("msg",55)
									+GetNgayPhepNam(EMP_ID,((DateTime)dt1.Value).ToString("yyyy"))+". ");//PublicFunction.L_Get_Msg("msg",55));
							tran.Rollback();
						}
					}
					else
					{						
						MessageBox.Show(vs1.Rows[i]["EMP_ID"]+" "+ PublicFunction.L_Get_Msg("msg",20));
						tran.Rollback();
					}
				}				
				catch(Exception ex)
				{
					tran.Rollback();
					MessageBox.Show(ex.Message);
				}
				//Thu them tu dong cap nhat phep cho cham cong, cty Omexey
				if(PublicFunction.CUS_ID=="53" && ok )
				{								
								
					DateTime d1=(DateTime)dt1.Value;
					DateTime d2=(DateTime)dt2.Value;
					try
					{
						while(T_String.IsNullTo0(d1.ToString("yyyyMMdd"))<=T_String.IsNullTo0(d2.ToString("yyyyMMdd")))// tung Ngay
						{
							ta.AttStaff(EMP_ID,d1,con1,T_String.GetDataFromSQL("DEP_ID","FILB01A","EMP_ID='"+EMP_ID+"'"),T_String.GetDataFromSQL("EMP_I1","FILB01A","EMP_ID='"+EMP_ID+"'"));
							d1=d1.AddDays(1);
						}	
					}
					catch(Exception ex)
					{
						MessageBox.Show(ex.Message);
					}
				}
			}	
			//insert cham cong bang tam vao bang chinh
			if(PublicFunction.CUS_ID=="53" )//Omexey
			{
				SqlConnection con2=new SqlConnection(PublicFunction.C_con.ConnectionString);
				con2.Open();
				SqlTransaction tran1=con2.BeginTransaction();
				string ssql="";
				try
				{
					ssql = "delete filc06a "
						+ " where emp_id in (select distinct emp_id from FILC06ALEA_"+PublicFunction.A_UserID +")"
						+ " and att_dt>='" + ((DateTime)dt1.Value).ToString("yyyy/MM/dd") + "'"
						+ " and att_dt<='" + ((DateTime)dt2.Value).ToString("yyyy/MM/dd") + "'"
						//+ " and att_dt between (select top 1 att_dt from ["+table +"] order by att_dt)  "
						//+ " and (select top 1 att_dt from [" + table + "] order by att_dt desc)"
						+ " and ISNULL(LOC_BT,0)=0 AND ISNULL(LOC_B1,0)=0";
					SqlCommand cmd=new SqlCommand(ssql,con2,tran1);
					cmd.ExecuteNonQuery();
					ssql="insert into FILC06A select * FROM FILC06ALEA_"+PublicFunction.A_UserID ;
					cmd=new SqlCommand(ssql,con2,tran1);
					cmd.ExecuteNonQuery();
					//delete nhung dong trong bang tam dang chuyen dl chua xong ma trung voi nhung dong vua nhap phep xong
					Func.RecordSet rsH = new Func.RecordSet("select DISTINCT [USER] from HistoryOfFILA06A where CONVERT(nvarchar, STR_DT, 111)='" + T_String.GetDate().ToString("yyyy/MM/dd") + "' AND RESULT LIKE N'%Running%'", con1);
					for (int m = 0; m < a.Count; m++)					
					{
						string sID = (string)a[m];
						if (rsH.rows > 0)
						{
							for (int t = 0; t < rsH.rows; t++)
							{
								ssql = "DELETE FILC06A_" + rsH.record(t, "USER") + " WHERE EMP_ID='" + sID + "' AND ATT_DT>='" 
									+ ((DateTime)dt1.Value).ToString("yyyy/MM/dd") + "' and ATT_DT<='" + ((DateTime)dt2.Value).ToString("yyyy/MM/dd") + "'";
								//PublicFunction.SQL_Execute(sql); 
								cmd=new SqlCommand(ssql,con2,tran1);
								cmd.ExecuteNonQuery();
							}
						}
					}
					//them 1 dong vao bang lich su chuyen du lieu
					ssql="insert into HistoryOfFILA06A values ("+T_String.GetMax("MAX(SEQ_NO)", "HistoryOfFILA06A")+",getdate(),NULL,'"+PublicFunction.A_UserID+"',"
						+"' From: "+((DateTime)dt1.Value).ToString("yyyy/MM/dd")+ " TO: " +((DateTime)dt2.Value).ToString("yyyy/MM/dd") +"','ATT Transfer from Leave Successfull')";
					cmd = new SqlCommand(ssql, con2, tran1);
					cmd.CommandTimeout = 20000;
					cmd.ExecuteNonQuery();
					tran1.Commit();	
				}
				catch(Exception ex)
				{
					tran1.Rollback();
					MessageBox.Show(ex.Message);
				}
//				Func.RecordSet rsH = new Func.RecordSet("select DISTINCT [USER] from HistoryOfFILA06A where CONVERT(nvarchar, STR_DT, 111)='" + T_String.GetDate().ToString("yyyy/MM/dd") + "' AND RESULT LIKE N'%Running%'", con);
//				for (int m = 0; m < a.Count; m++)
//				{
//					int i = (int)a[m];
//					string EMP_ID = vs.Rows[i]["EMP_ID"] + "";
//					DateTime d1 = DateTime.Parse(vs.Rows[i]["ATT_DT"] + "");
//					string sql = "";
//					//delete cac dong sua tay trong cac bang tam                
//					if (rsH.rows > 0)
//					{
//						for (int t = 0; t < rsH.rows; t++)
//						{
//							sql = "DELETE FILC06A_" + rsH.record(t, "USER") + " WHERE EMP_ID='" + EMP_ID + "' AND ATT_DT='" + d1.ToString("yyyy/MM/dd") + "'";
//							PublicFunction.SQL_Execute(sql);                            
//						}
//					}
//				}
			}
			//end
			if(sql1!="")
				nav2.Show_VS("a.EMP_ID in ("+sql1+")");			
			MessageBox.Show(PublicFunction.L_Get_Msg("Staff",1));
			con.Close();	
			con1.Close();	
			txt1.Focus();			
			
		}
		private string  CalStaffDaNghi(string EMP_ID,DateTime dt,string ngayvaolam)
		{
			string sql="", str="'001'";
			if(PublicFunction.CUS_ID=="52")//domex qn su dung 2 loai pn
				str="'001','015'";
			if (arrAL != null)
				for (int i=0; i<arrAL.Length; i++)
					str += ", '" + arrAL[i] + "'";
			DateTime tam;
			tam=DateTime.Parse(ngayvaolam);			
//			sql="(Select isnull(SUM(DAY_TT),0) from FILC04A where EMP_ID=N'"+EMP_ID+"' and STR_DT>='"
//				+dt.ToString("yyyy")+"/01/01' and STR_DT<'"+dt.AddMonths(1).ToString("yyyy/MM")+"/01' and LEA_ID IN (" + str + "))";
//			sql="update FILC04B set DID_QT="+sql+" where EMP_ID=N'"+EMP_ID+"' and YYY_YY=N'"+dt.ToString("yyyy")+"'";
			
			if(DateTime.Parse(ngayvaolam) > DateTime.Parse(dt.ToString("yyyy")+"/01/01"))
			{
				sql="(Select isnull(SUM(DAY_TT),0) from FILC04A where EMP_ID=N'"+EMP_ID+"' and STR_DT>='"
					+tam.ToString("yyyy/MM/dd")+"' and STR_DT<'"+dt.AddMonths(1).ToString("yyyy/MM")+"/01' and LEA_ID IN (" + str + "))";
				sql="update FILC04B set DID_QT="+sql+" where EMP_ID=N'"+EMP_ID+"' and YYY_YY=N'"+dt.ToString("yyyy")+"'";
			}
			else
			{
				sql="(Select isnull(SUM(DAY_TT),0) from FILC04A where EMP_ID=N'"+EMP_ID+"' and STR_DT>='"
					+dt.ToString("yyyy")+"/01/01' and STR_DT<'"+dt.AddMonths(1).ToString("yyyy/MM")+"/01' and LEA_ID IN (" + str + "))";
				sql="update FILC04B set DID_QT="+sql+" where EMP_ID=N'"+EMP_ID+"' and YYY_YY=N'"+dt.ToString("yyyy")+"'";
			}
			return sql;
		}

//		private void ATT()
//		{
//			
//			ArrayList a=new ArrayList();
//			for(int n=1;n<vs.Rows.Count;n++)
//			{
//				if(vs.Rows[n].UserData+""=="1")
//				{
//					a.Add(n);
//				}
//			}
//			nav_TBarClick(nav.cmd_save,new ToolBarButtonClickEventArgs(nav.cmd_save));
//			Func.RecordSet rsTypeShift=new Func.RecordSet("Select * from GP_SYS_SHIFT",PublicFunction.C_con);
//			Func.RecordSet Set=new Func.RecordSet("Select * from GP_SYS_SETTING",PublicFunction.C_con);	
//			SqlConnection con=new SqlConnection(PublicFunction.C_con.ConnectionString);
//			if(con.State==ConnectionState.Closed )
//				con.Open();
//			int dem=0,i=0;
//			for(int m=0;m<a.Count;m++)
//			{
//				i=(int)a[m];				
//				string EMP_ID=vs.Rows[i]["EMP_ID"]+"";
//				DateTime d1=DateTime.Parse(vs.Rows[i]["ATT_DT"]+"");
//
//				string SHI_ID=vs.Rows[i]["SHI_ID"]+"";
//				string sql="Select * from FILC02B where SHI_ID=N'"+SHI_ID+"' ORDER BY SEQ_NO";
//				Func.RecordSet rsca=new Func.RecordSet(sql,con);	
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
//					ATT.Add(T_String.IsNullTo00(vs.Rows[i]["ONN_"+j.ToString("00")]+""));
//					ATT.Add(T_String.IsNullTo00(vs.Rows[i]["OFF_"+j.ToString("00")]+""));						
//				}	
//				TaAttendance tm=new TaAttendance(EMP_ID,d1.ToString("yyyy/MM/dd"),con,Ca,ATT,SHI_ID,rsca,Set,rsTypeShift);			
//				tm.tb="FILC06A";
//				tm.NOT_DR=vs.Rows[i]["NOT_DR"]+"";
//				tm.UpdateSql();
//				ForCal(EMP_ID,d1.ToString("yyyy/MM/dd"));
//				dem++;				
//			}
//			int vat=T_String.GetMax("MAX(SEQ_NO)","FILC10A");
//			for(int m=0;m<a.Count;m++)
//			{
//				string EMP_ID=vs.Rows[i]["EMP_ID"]+"";
//				DateTime d1=DateTime.Parse(vs.Rows[i]["ATT_DT"]+"");
//				TaAttendance.AbsentToVacate(EMP_ID,d1.ToString("yyyy/MM/dd"),con);
//			}
//			if(T_String.GetMax("MAX(SEQ_NO)","FILC10A")>vat)
//			{
//				frmTaAbsentVacate dlg=new frmTaAbsentVacate();
//				dlg.Tag=this.Tag;
//				dlg.ShowDialog();
//			}
//			if(dem>0)
//			{
//				int row=vs.Row;
//				nav.Show_VS(nav.Where+"");
//				if(row>0)
//					vs.Row=row;
//			}
//		}
//	
		#endregion

		private double GetNgayPhepNam(string EMP_ID,string YYY_YY)
		{
			string sql="Select * from FILC04B where EMP_ID=N'"+EMP_ID+"' and YYY_YY=N'"+YYY_YY+"'";
			Func.RecordSet rs=new Func.RecordSet(sql,PublicFunction.C_con);
			if(rs.rows<0)
				return 0;
			double songay=0;
			songay+=T_String.IsNullTo00(rs.record(0,"HAV_QT"));
			songay+=T_String.IsNullTo00(rs.record(0,"ADD_QT"));
			songay+=T_String.IsNullTo00(rs.record(0,"LST_QT"));
			songay+=T_String.IsNullTo00(rs.record(0,"LST_QT"));						
			songay+=T_String.IsNullTo00(rs.record(0,"SUP_QT"));									
			return songay;			
		} 
		private Boolean CheckPhepNam(string EMP_ID,string YYY_YY,Double xinnghi)
		{
			string sql="Select * from FILC04B where EMP_ID=N'"+EMP_ID+"' and YYY_YY=N'"+YYY_YY+"'";
			Func.RecordSet rs=new Func.RecordSet(sql,PublicFunction.C_con);
			if(rs.rows<0)
				return false;
			double songay=0;
			songay+=T_String.IsNullTo00(rs.record(0,"HAV_QT"));
			songay+=T_String.IsNullTo00(rs.record(0,"ADD_QT"));
			songay+=T_String.IsNullTo00(rs.record(0,"LST_QT"));
			songay+=T_String.IsNullTo00(rs.record(0,"SUP_QT"));		
			songay-=T_String.IsNullTo00(rs.record(0,"DID_QT"));
			songay+=T_String.IsNullTo00(rs.record(0,"BOR_QT"));
			if (songay-xinnghi<0)
				return false;
			return true;
		}

		private Boolean CheckPhep(string EMP_ID,string LEA_ID,Double xinnghi,string INH_DT)
		{
			string sql="";
			double maxyear=0;			
			sql="Select * from FILA15A where LEA_ID=N'"+LEA_ID+"'";
			Func.RecordSet rs=new Func.RecordSet(sql,PublicFunction.C_con);
			if(rs.rows<=0)
				return false;
			double tm=T_String.IsNullTo00 (rs.record(0,"DAY_TM")); // Max Times
			if (tm>0)
			{
				sql="EMP_ID=N'"+EMP_ID+"' and LEA_ID=N'"+LEA_ID+"'";
				double day=T_String.IsNullTo00(T_String.GetDataFromSQL("Count(*)","FILC04A",sql));
				if(day+1>tm)
				{
					MessageBox.Show(EMP_ID+" "+ PublicFunction.L_Get_Msg("msg",100)
						+tm+". ");
					return false;
				}						
			}
			tm=T_String.IsNullTo00 (rs.record(0,"DAY_QT")); // Max days
			if (tm>0)
			{
				sql="EMP_ID=N'"+EMP_ID+"' and LEA_ID=N'"+LEA_ID+"'";
				double day=T_String.IsNullTo00(T_String.GetDataFromSQL("SUM(DAY_TT)","FILC04A",sql));
				if(day+xinnghi>tm)
				{
					MessageBox.Show(EMP_ID+" "+ PublicFunction.L_Get_Msg("msg",56)
						+tm+". ");
					return false;
				}						
			}
			tm=T_String.IsNullTo00 (rs.record(0,"DAY_MM")); // Max month
			if (tm>0)
			{
				DateTime d1=new DateTime(((DateTime)dt1.Value).Year,((DateTime)dt1.Value).Month,1);
				DateTime d2=new DateTime(((DateTime)dt1.Value).Year,((DateTime)dt1.Value).Month,DateTime.DaysInMonth(((DateTime)dt1.Value).Year,((DateTime)dt1.Value).Month));
				sql="EMP_ID=N'"+EMP_ID+"' and LEA_ID=N'"+LEA_ID+"' and (STR_DT Between '"+
					d1.ToString("yyyy/MM/dd")+" 00:00' and '"+d2.ToString("yyyy/MM/dd")+" 23:59')";
				double day=T_String.IsNullTo00(T_String.GetDataFromSQL("SUM(DAY_TT)","FILC04A",sql));
				if(day+xinnghi>tm)
				{
					MessageBox.Show(EMP_ID+" "+ PublicFunction.L_Get_Msg("msg",57)
						+tm+". ");
					return false;
				}						
			}
			tm=T_String.IsNullTo00 (rs.record(0,"DAY_YY")); // Max Years
			maxyear=T_String.IsNullTo00 (rs.record(0,"DAY_YY"));
			if (tm>0)
			{
				DateTime d1=new DateTime(((DateTime)dt1.Value).Year,1,1);
				DateTime d2=new DateTime(((DateTime)dt1.Value).Year,12,DateTime.DaysInMonth(((DateTime)dt1.Value).Year,12));
				sql="EMP_ID=N'"+EMP_ID+"' and LEA_ID=N'"+LEA_ID+"' and (STR_DT Between '"+
					d1.ToString("yyyy/MM/dd")+" 00:00' and '"+d2.ToString("yyyy/MM/dd")+" 23:59')";
				double day=T_String.IsNullTo00(T_String.GetDataFromSQL("SUM(DAY_TT)","FILC04A",sql));
				if(day+xinnghi>tm)
				{
					MessageBox.Show(EMP_ID+" "+ PublicFunction.L_Get_Msg("msg",58)
						+tm+". ");
					return false;
				}						
			}
			//Xet phep benh cho cty KenYa
			if (PublicFunction.CUS_ID=="300")
			{
				if(LEA_ID=="002")
				{
					int WAG_MM=2;
					int ngaytinh=1;
					double phepnam=maxyear ;
					float heso=(float)phepnam/12;
					//string INH_DT=vs1.Rows[i]["INH_DT"]+"";
					DateTime dt=DateTime.Parse(dt2.Value+"");
					string YYY=dt.ToString("yyyy");					
					//Boolean nghiviec=false;
					DateTime dtt1=DateTime.Parse(INH_DT).AddMonths(WAG_MM);						
					if(T_String.CompareDate(dtt1,dt)) // ko du thoi gian lam viec de tinh phep
		
					{
						//UpdateStaff0(EMP_ID,PublicFunction.C_Connect,YYY);
						MessageBox.Show(EMP_ID+" "+ PublicFunction.L_Get_Msg("msg",58)
							+"0. ");
						return false;
					}			
					if(T_String.CompareDate(new DateTime(dt.Year,1,1),dtt1))
						dtt1=new DateTime(dt.Year,1,1);
					double ngayphep=0,dem=0;// tinh phep benh
					if(dtt1.Day<=ngaytinh)
					{			
						ngayphep+= heso;
						dem++;				
					}
					dtt1=dtt1.AddMonths(1);
					while (dtt1.Month<=dt.Month && dtt1.Year==dt.Year)
					{
						ngayphep+= heso;

						dtt1=dtt1.AddMonths(1);
						dem++;
					}
					if((dt.Day>=ngaytinh || DateTime.Parse(INH_DT).Year <dt.Year||ngayphep>0 ) && dtt1.Month==dt.Month)
					{
						if(dem+1==12)
						{
							ngayphep=phepnam;
						}
						else
						{
							ngayphep+= heso;	
						}
				
				
					}
					string PNcalday=PublicFunction.GetOption("PNcalday");
					if(PNcalday=="1")
					{						
						int test=DateTime.Parse(INH_DT).Day;						
						ngaytinh=test;
						if (ngayphep>0 && test>dt.Day && DateTime.Parse(INH_DT).Year ==dt.Year)
						{
							ngayphep=ngayphep-heso ;
						}
					}					
					//NEU OPTION WAGMM_BT=1-> TINH LUON NHUNG THANG KHOI TINH KHI DU DK TINH PHEP NAM
					if(PublicFunction.GetOption("WAGMM_BT")=="1" && DateTime.Parse(INH_DT).Year ==dt.Year )
					{
						ngayphep=ngayphep+WAG_MM*heso ;
					}
					//END					
					ngayphep=Math.Floor(ngayphep);
					//tinh so ngay phep benh da nghi toi thoi diem xin phep
					SqlConnection con=new SqlConnection(PublicFunction.C_con.ConnectionString);
					con.Open();		
					DateTime d1=new DateTime((DateTime.Parse(dt1.Value+"")).Year,1,1);
					DateTime d2=T_String.GetDate(con);
					sql="EMP_ID=N'"+EMP_ID+"' and LEA_ID=N'"+LEA_ID+"' and (STR_DT Between '"+
						d1.ToString("yyyy/MM/dd")+" 00:00' and '"+d2.ToString("yyyy/MM/dd")+" 23:59')";
					double day=T_String.IsNullTo00(T_String.GetDataFromSQL("SUM(DAY_TT)","FILC04A",sql));
					if(day+xinnghi>ngayphep)
					{
						MessageBox.Show(EMP_ID+" "+ PublicFunction.L_Get_Msg("msg",58)
							+ngayphep+". ");
						return false;
					}
				}
			}
			//end
			return true;
		}

		private bool IsAnnualLeave(string _LEA_ID)
		{
			if(PublicFunction.CUS_ID=="52")//domex QN su dung 2 loai phep nam
			{
				if (_LEA_ID == "001" || _LEA_ID == "015")
					return true;
			}
			else
			{
				if (_LEA_ID == "001")
					return true;
			}
			if (arrAL != null)
				for (int i=0; i<arrAL.Length; i++)
					if (arrAL[i] == _LEA_ID)
						return true;
			 
			return false;
		}

		private void vs2_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			vs2.Rows[e.Row]["LST_NM"]=PublicFunction.A_UserID;
			vs2.Rows[e.Row]["LST_DT"]=T_String.GetDate().ToString("yyyy/MM/dd HH:mm");
		}

		private void vs_EnabledChanged(object sender, EventArgs e)
		{
			txt1.Text=vs.Cols[txt1.Tag+""].Caption;
			txt2.Text=vs.Cols[txt2.Tag+""].Caption;
			txt3.Text=vs.Cols[txt3.Tag+""].Caption;			
			txt5.Text=vs.Cols[txt5.Tag+""].Caption;
			txt6.Text=vs.Cols[txt6.Tag+""].Caption;
			txt7.Text=vs.Cols[txt7.Tag+""].Caption;
			txt8.Text=vs.Cols[txt5.Tag+""].Caption;
			txt9.Text=vs.Cols[txt6.Tag+""].Caption;
			txt10.Text=vs.Cols[txt7.Tag+""].Caption;
		}

		private void cmd_showf_Click(object sender, System.EventArgs e)
		{
			panel11.Visible=!panel11.Visible;
			panel7.Visible=!panel7.Visible;
		}

		private void panel11_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}

		private void txt1_TextChanged(object sender, System.EventArgs e)
		{
			//this.AcceptButton=null ;
		}

		private void vs_Click(object sender, System.EventArgs e)
		{
		
		}

		private void nav2_Load(object sender, System.EventArgs e)
		{
		
		}

		private void dt2_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
//			DateTime dt=T_String.GetDate();
//			if(cb.SelectedValue+""=="")
//			{
//				MessageBox.Show(PublicFunction.L_Get_Msg("msg",19));
//				return;
//			}	
//			if(!ck.Checked && (dt4.Text+""=="" || dt3.Text+""==""))
//			{
//				MessageBox.Show(PublicFunction.L_Get_Msg("msg",191));
//				return;
//			}
//			string sql1="";
//
//			SqlConnection con=new SqlConnection(PublicFunction.C_con.ConnectionString);
//			con.Open();		
//			SqlConnection con1=new SqlConnection(PublicFunction.C_con.ConnectionString);
//			con1.Open();
//
//			for(int i=vs1.Rows.Count-1;i>0;i--)
//			{	
//				SqlTransaction tran=con.BeginTransaction();
//				try
//				{					
//					string sql="",EMP_ID=vs1.Rows[i]["EMP_ID"]+"";
//					string ngayvaolam=vs1.Rows[i]["INH_DT"]+"";
//					Boolean ok=false;
//					if(ck.Checked)
//					{
//						sql="((STR_DT<='"+((DateTime)dt1.Value).ToString("yyyy/MM/dd")+"' and "
//							+" END_DT>='"+((DateTime)dt1.Value).ToString("yyyy/MM/dd")+"')";
//						sql+=" or (STR_DT<='"+((DateTime)dt2.Value).ToString("yyyy/MM/dd")+"' and "
//							+" END_DT>='"+((DateTime)dt2.Value).ToString("yyyy/MM/dd")+"')";
//						sql+=" or (STR_DT>='"+((DateTime)dt1.Value).ToString("yyyy/MM/dd")+"' and "
//							+" END_DT <='" +((DateTime)dt2.Value).ToString("yyyy/MM/dd")+"' ))";
//																									 
//						sql+=" and EMP_ID=N'"+EMP_ID+"'";
//						if(T_String.IsNullTo0(T_String.GetDataFromSQL("COUNT(*)","FILC04A",sql))>0)
//							ok=false;
//						else
//							ok=true;
//					}
//					else
//					{
//						sql="((STR_DT<='"+((DateTime)dt1.Value).ToString("yyyy/MM/dd")+"' and "
//							+" END_DT>='"+((DateTime)dt1.Value).ToString("yyyy/MM/dd")+"')";
//						sql+=" or (STR_DT<='"+((DateTime)dt2.Value).ToString("yyyy/MM/dd")+"' and "
//							+" END_DT>='"+((DateTime)dt2.Value).ToString("yyyy/MM/dd")+"'))";
//						sql+=" and EMP_ID=N'"+EMP_ID+"'";
//						sql+=" and (((STR_TM<="+dt3.Text+" and END_TM>="+dt3.Text+") or ";
//						sql+=" (STR_TM<="+dt4.Text+" and END_TM>="+dt4.Text+")) or DAY_BT=1)";
//						if(T_String.IsNullTo0(T_String.GetDataFromSQL("COUNT(*)","FILC04A",sql))>0)
//							ok=false;
//						else
//							ok=true;
//						//KIEM TRA NHIEU PHEP NHAP TRONG 1 NGAY KO DC LON HON GIO 1 NGAY TRONG CA
//						double dhour=0,h=0;
//
//						sql=" STR_DT='"+((DateTime)dt1.Value).ToString("yyyy/MM/dd")+"' and ";
//						sql+=" EMP_ID=N'"+EMP_ID+"'";
//						dhour=T_String.IsNullTo00(T_String.GetDataFromSQL("SUM(HOU_TT)","FILC04A",sql));
//						sql="Select * from FILC02B where SHI_ID=N'"+cb1.SelectedValue+"'";
//						Func.RecordSet rs=new Func.RecordSet(sql,PublicFunction.C_con);
//						for(int t=0;t<rs.rows;t++)
//						{
//							double on=T_String.IsNullTo00(rs.record(t,"ONN_TM"));
//							double off=T_String.IsNullTo00(rs.record(t,"OFF_TM"));								
//							if(on>off)
//							{										
//								off=off+2400;
//							}					
//							if(rs.record(t,"TYP_ID")+""=="ATT_HR" || rs.record(t,"TYP_ID")+""=="NIG_HR")
//								h=T_String.CongTG( T_String.TruTG(off,on),h);
//						}
//						h=T_String.DT_HourMinConvertToHour((int)h);
//						if(T_String.IsNullTo00(txt_h1.Text )+dhour>h)
//						{
//							ok=false;
//							MessageBox.Show(vs1.Rows[i]["EMP_ID"]+" "+ "OVER TIME!!!!!!!");
//							return;
//						}
//						//END
//					}
//					if(ok) //co trung ngay hay ko
//					{
//						string SEQ_NO=T_String.GetMax("MAX(SEQ_NO)","FILC04A")+"";	
//						int c=0;
//						if(ck.Checked)
//							c=1;
//						cal();
//						if(IsAnnualLeave(cb.SelectedValue+""))// Kiem Tra xem con ngay phep nam ko
//						{
//							DateTime dtt=DateTime.Parse(dt2.Value+"");
//							if(PublicFunction.tinhphepnam==0)
//							{
//								PublicFunction.SQL_Execute( CalStaffDaNghi(EMP_ID,dtt,ngayvaolam));  
//								frmTaCalAnnualLeave.CalStaff(EMP_ID,vs1.Rows[i]["TYP_ID"]+"",vs1.Rows[i]["INH_DT"]+"",con1,dtt.ToString("yyyy"),dtt,false);
//							}
//							else
//							{
//								if(PublicFunction.tinhphepnam==1)
//									PublicFunction.SQL_Execute( CalStaffDaNghi(EMP_ID,dtt,ngayvaolam));  
//								frmTaCalAnnualLeave.CalStaff1(EMP_ID,vs1.Rows[i]["TYP_ID"]+""+"",vs1.Rows[i]["INH_DT"]+"",con1,dtt);
//							} 
//							if(!CheckPhepNam(EMP_ID,((DateTime)dt1.Value).ToString("yyyy"),T_String.IsNullTo00( txt_day.Text)))
//								ok=false;							
//						}
//						else
//						{
//							if(!CheckPhep(EMP_ID,cb.SelectedValue+"",T_String.IsNullTo00( txt_day.Text),vs1.Rows[i]["INH_DT"]+"")) // phep thuong
//								ok=false;	
//						}
//						if(ok)
//						{
//							sql="Insert Into FILC04A(SEQ_NO,EMP_ID,STR_DT,END_DT,STR_TM,END_TM,HOU_DY,HOU_TT,LEA_ID,"
//								+"DAY_TT,DAY_BT,NOT_DR,BLT_NM,BLT_DT) values("
//								+SEQ_NO+","
//								+"N'"+EMP_ID+"',"
//								+"'"+((DateTime)dt1.Value).ToString("yyyy/MM/dd") +"',"
//								+"'"+((DateTime)dt2.Value).ToString("yyyy/MM/dd") +"',";								
//							if(ck.Checked)
//							{
//								sql+="Default,"
//									+"Default,";
//								sql+="'"+txt_h.Text +"',";
//							}
//							else
//							{								
//								sql+="'"+dt3.Text +"',"
//									+"'"+dt4.Text +"',";
//								sql+="'"+txt_h1.Text +"',";
//							}
//
//							sql+="'"+ T_String.IsNullTo00(txt_hr.Text) +"',"
//								+"N'"+cb.SelectedValue+"',"
//								+"'"+T_String.IsNullTo00(txt_day.Text )+"',"
//								+"'"+c+"',"				
//								+"N'"+txt_note.Text+"',N'"+PublicFunction.A_UserID+"','"+dt.ToString("yyyy/MM/dd HH:mm")+"')";
//							SqlCommand cmd=new SqlCommand(sql,con,tran);
//							cmd.ExecuteNonQuery();	
//							if(IsAnnualLeave(cb.SelectedValue+"")) //update ngay phep nam
//							{
//								if(T_String.IsNullTo0(T_String.GetDataFromSQL("Count(*)","FILC04B","EMP_ID=N'"+EMP_ID+"' and YYY_YY=N'"+((DateTime)dt1.Value).ToString("yyyy")+"'"))<=0)
//								{
//									sql="";
//									sql="Insert Into FILC04B(YYY_YY,EMP_ID,BLT_NM,BLT_DT) values (N'"
//										+((DateTime)dt1.Value).ToString("yyyy")+"',N'"+EMP_ID+"',N'"+PublicFunction.A_UserID+"','"+dt.ToString("yyyy/MM/dd HH:mm")+"')";
//									cmd=new SqlCommand(sql,con,tran);
//									cmd.ExecuteNonQuery();	
//								}
//								sql="EMP_ID=N'"+EMP_ID+"' and "
//									+"YEAR(STR_DT)='"+((DateTime)dt1.Value).ToString("yyyy")+"' and "
//									+"YEAR(END_DT)='"+((DateTime)dt1.Value).ToString("yyyy")+"'";
//								//double songay=T_String.IsNullTo00(T_String.GetDataFromSQL("SUM(DAY_TT)","FILC04A",sql));
//								sql="Update FILC04B set DID_QT=(Select SUM(DAY_TT) from FILC04A where " +sql
//									+") where EMP_ID=N'"+EMP_ID+"' and YYY_YY=N'"+((DateTime)dt1.Value).ToString("yyyy")+"'";
//								cmd=new SqlCommand(sql,con,tran);
//								cmd.ExecuteNonQuery();	
//								DateTime dtt=DateTime.Parse(dt2.Value+"");							
//								cmd=new SqlCommand(CalStaffDaNghi(EMP_ID,dtt,ngayvaolam),con,tran);
//								cmd.ExecuteNonQuery();	
//							}
//
//							if(sql1!="") sql1+=",";
//							sql1+="N'"+EMP_ID+"'";
//							vs1.RemoveItem(i);
//							tran.Commit();	
//						}
//						else
//						{
//							if(IsAnnualLeave(cb.SelectedValue+""))							
//								MessageBox.Show(EMP_ID+" "+ PublicFunction.L_Get_Msg("msg",55)
//									+GetNgayPhepNam(EMP_ID,((DateTime)dt1.Value).ToString("yyyy"))+". ");//PublicFunction.L_Get_Msg("msg",55));
//							tran.Rollback();
//						}
//					}
//					else
//					{						
//						MessageBox.Show(vs1.Rows[i]["EMP_ID"]+" "+ PublicFunction.L_Get_Msg("msg",20));
//						tran.Rollback();
//					}
//				}				
//				catch(Exception ex)
//				{
//					tran.Rollback();
//					MessageBox.Show(ex.Message);
//				}
//			}			
//			if(sql1!="")
//				nav2.Show_VS("a.EMP_ID in ("+sql1+")");			
			MessageBox.Show(PublicFunction.L_Get_Msg("Staff",1));
			//con.Close();	
			//con1.Close();
		
		}

		
	}
}



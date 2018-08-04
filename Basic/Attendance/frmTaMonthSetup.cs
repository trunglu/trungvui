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
using System.Drawing.Drawing2D;

namespace GP8000.Attendance
{
	/// <summary>
	/// Summary description for frmTaVacateManager.
	/// </summary>
	public class frmTaMonthSetup : System.Windows.Forms.Form
	{
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
		private System.Windows.Forms.Panel panel5;
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
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt3;
		private System.Windows.Forms.TextBox txt2;
		private System.Windows.Forms.TextBox txt1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button cmd_ok;
		private System.Windows.Forms.TextBox txt5;
		private System.Windows.Forms.TextBox txt7;
		private System.Windows.Forms.TextBox txt6;
		private System.Windows.Forms.TextBox txt10;
		private System.Windows.Forms.TextBox txt9;
		private System.Windows.Forms.TextBox txt8;
		private System.Windows.Forms.Button cmd_clear;
		private System.Windows.Forms.Panel panel11;
		private System.Windows.Forms.Panel panel12;
		private C1.Win.C1FlexGrid.C1FlexGrid vs2;
		private Navigator1._0.NavigatorAuto nav2;
		private C1.Win.C1Input.C1DateEdit dt2;
		private C1.Win.C1Input.C1DateEdit dt1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cb1;
		private System.Windows.Forms.CheckBox ck1;
		private System.Windows.Forms.CheckBox ck2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.CheckBox ck3;
		private System.Windows.Forms.Button cmd_all;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txt_1;
		private System.Windows.Forms.TextBox txt_2;
		private System.Windows.Forms.TextBox txt_3;
		private C1.Win.C1Input.C1DateEdit dt3;
		private System.Windows.Forms.CheckBox ck;
		private C1.Win.C1Input.C1DateEdit dt4;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaMonthSetup()
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
			this.vs2 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.nav2 = new Navigator1._0.NavigatorAuto();
			this.panel11 = new System.Windows.Forms.Panel();
			this.dt3 = new C1.Win.C1Input.C1DateEdit();
			this.txt6 = new System.Windows.Forms.TextBox();
			this.txt7 = new System.Windows.Forms.TextBox();
			this.txt5 = new System.Windows.Forms.TextBox();
			this.ck = new System.Windows.Forms.CheckBox();
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
			this.panel5 = new System.Windows.Forms.Panel();
			this.cmd_all = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txt_3 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txt_2 = new System.Windows.Forms.TextBox();
			this.txt_1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.ck3 = new System.Windows.Forms.CheckBox();
			this.ck2 = new System.Windows.Forms.CheckBox();
			this.ck1 = new System.Windows.Forms.CheckBox();
			this.cb1 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dt1 = new C1.Win.C1Input.C1DateEdit();
			this.cmd_clear = new System.Windows.Forms.Button();
			this.cmd_ok = new System.Windows.Forms.Button();
			this.dt2 = new C1.Win.C1Input.C1DateEdit();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.dt4 = new C1.Win.C1Input.C1DateEdit();
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
			((System.ComponentModel.ISupportInitialize)(this.dt3)).BeginInit();
			this.panel7.SuspendLayout();
			this.panel10.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs1)).BeginInit();
			this.panel9.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
			this.panel5.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dt1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dt2)).BeginInit();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dt4)).BeginInit();
			this.SuspendLayout();
			// 
			// c1CommandDock1
			// 
			this.c1CommandDock1.Controls.Add(this.c1DockingTab1);
			this.c1CommandDock1.Dock = System.Windows.Forms.DockStyle.Left;
			this.c1CommandDock1.Id = 1;
			this.c1CommandDock1.Location = new System.Drawing.Point(0, 0);
			this.c1CommandDock1.Name = "c1CommandDock1";
			this.c1CommandDock1.Size = new System.Drawing.Size(276, 676);
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
			this.c1DockingTab1.Size = new System.Drawing.Size(276, 676);
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
			this.c1DockingTabPage1.Size = new System.Drawing.Size(271, 674);
			this.c1DockingTabPage1.TabIndex = 0;
			this.c1DockingTabPage1.Text = "Page1";
			// 
			// Dep
			// 
			this.Dep.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Dep.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Dep.Location = new System.Drawing.Point(0, 20);
			this.Dep.Name = "Dep";
			this.Dep.Size = new System.Drawing.Size(271, 654);
			this.Dep.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(276, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(744, 676);
			this.panel1.TabIndex = 3;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.panel6);
			this.panel2.Controls.Add(this.panel5);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 36);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(744, 640);
			this.panel2.TabIndex = 5;
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.panel8);
			this.panel6.Controls.Add(this.splitter1);
			this.panel6.Controls.Add(this.panel7);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel6.Location = new System.Drawing.Point(0, 100);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(744, 540);
			this.panel6.TabIndex = 1;
			// 
			// panel8
			// 
			this.panel8.Controls.Add(this.panel12);
			this.panel8.Controls.Add(this.panel11);
			this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel8.Location = new System.Drawing.Point(0, 284);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(744, 256);
			this.panel8.TabIndex = 2;
			// 
			// panel12
			// 
			this.panel12.Controls.Add(this.vs2);
			this.panel12.Controls.Add(this.nav2);
			this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel12.Location = new System.Drawing.Point(0, 28);
			this.panel12.Name = "panel12";
			this.panel12.Size = new System.Drawing.Size(744, 228);
			this.panel12.TabIndex = 41;
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
			this.vs2.Location = new System.Drawing.Point(4, 32);
			this.vs2.Name = "vs2";
			this.vs2.Size = new System.Drawing.Size(736, 196);
			this.vs2.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs2.TabIndex = 14;
			this.vs2.Tag = "";
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
			this.nav2.Location = new System.Drawing.Point(8, 0);
			this.nav2.MSG_Exit = false;
			this.nav2.MulltiDel = false;
			this.nav2.Name = "nav2";
			this.nav2.Security = 0;
			this.nav2.ShowPopupMenu = false;
			this.nav2.Size = new System.Drawing.Size(396, 32);
			this.nav2.TabIndex = 15;
			this.nav2.Tag = "";
			this.nav2.ToolBar_Auto = true;
			this.nav2.UserID = null;
			this.nav2.VisibleGrid = true;
			this.nav2.Where = null;
			// 
			// panel11
			// 
			this.panel11.Controls.Add(this.dt4);
			this.panel11.Controls.Add(this.dt3);
			this.panel11.Controls.Add(this.txt6);
			this.panel11.Controls.Add(this.txt7);
			this.panel11.Controls.Add(this.txt5);
			this.panel11.Controls.Add(this.ck);
			this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel11.Location = new System.Drawing.Point(0, 0);
			this.panel11.Name = "panel11";
			this.panel11.Size = new System.Drawing.Size(744, 28);
			this.panel11.TabIndex = 40;
			// 
			// dt3
			// 
			this.dt3.BackColor = System.Drawing.Color.LemonChiffon;
			this.dt3.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt3.Location = new System.Drawing.Point(372, 4);
			this.dt3.Name = "dt3";
			this.dt3.Size = new System.Drawing.Size(96, 23);
			this.dt3.TabIndex = 140;
			this.dt3.Tag = null;
			// 
			// txt6
			// 
			this.txt6.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt6.Location = new System.Drawing.Point(120, 3);
			this.txt6.MaxLength = 20;
			this.txt6.Name = "txt6";
			this.txt6.Size = new System.Drawing.Size(112, 23);
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
			this.txt7.Location = new System.Drawing.Point(236, 3);
			this.txt7.MaxLength = 20;
			this.txt7.Name = "txt7";
			this.txt7.Size = new System.Drawing.Size(132, 23);
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
			this.txt5.Location = new System.Drawing.Point(4, 3);
			this.txt5.MaxLength = 20;
			this.txt5.Name = "txt5";
			this.txt5.Size = new System.Drawing.Size(112, 23);
			this.txt5.TabIndex = 37;
			this.txt5.Tag = "EMP_ID";
			this.txt5.Text = "textBox3";
			this.txt5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt5_KeyDown);
			this.txt5.Leave += new System.EventHandler(this.txt5_Leave);
			this.txt5.Enter += new System.EventHandler(this.txt5_Enter);
			// 
			// ck
			// 
			this.ck.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ck.Location = new System.Drawing.Point(584, 4);
			this.ck.Name = "ck";
			this.ck.Size = new System.Drawing.Size(164, 20);
			this.ck.TabIndex = 16;
			this.ck.Text = "ck";
			// 
			// splitter1
			// 
			this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
			this.splitter1.Location = new System.Drawing.Point(0, 280);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(744, 4);
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
			this.panel7.Size = new System.Drawing.Size(744, 280);
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
			this.panel10.Location = new System.Drawing.Point(375, 0);
			this.panel10.Name = "panel10";
			this.panel10.Size = new System.Drawing.Size(369, 280);
			this.panel10.TabIndex = 2;
			// 
			// txt10
			// 
			this.txt10.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt10.Location = new System.Drawing.Point(236, 4);
			this.txt10.MaxLength = 20;
			this.txt10.Name = "txt10";
			this.txt10.Size = new System.Drawing.Size(132, 23);
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
			this.vs1.Size = new System.Drawing.Size(360, 248);
			this.vs1.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs1.TabIndex = 11;
			// 
			// splitter2
			// 
			this.splitter2.Location = new System.Drawing.Point(372, 0);
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
			this.panel9.Size = new System.Drawing.Size(372, 280);
			this.panel9.TabIndex = 0;
			// 
			// txt3
			// 
			this.txt3.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt3.Location = new System.Drawing.Point(236, 4);
			this.txt3.MaxLength = 20;
			this.txt3.Name = "txt3";
			this.txt3.Size = new System.Drawing.Size(132, 23);
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
			this.vs.Size = new System.Drawing.Size(364, 248);
			this.vs.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs.TabIndex = 10;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.Moccasin;
			this.panel5.Controls.Add(this.cmd_all);
			this.panel5.Controls.Add(this.groupBox1);
			this.panel5.Controls.Add(this.ck3);
			this.panel5.Controls.Add(this.ck2);
			this.panel5.Controls.Add(this.ck1);
			this.panel5.Controls.Add(this.cb1);
			this.panel5.Controls.Add(this.label2);
			this.panel5.Controls.Add(this.dt1);
			this.panel5.Controls.Add(this.cmd_clear);
			this.panel5.Controls.Add(this.cmd_ok);
			this.panel5.Controls.Add(this.dt2);
			this.panel5.Controls.Add(this.label4);
			this.panel5.Controls.Add(this.label1);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel5.Location = new System.Drawing.Point(0, 0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(744, 100);
			this.panel5.TabIndex = 0;
			// 
			// cmd_all
			// 
			this.cmd_all.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_all.Location = new System.Drawing.Point(4, 64);
			this.cmd_all.Name = "cmd_all";
			this.cmd_all.Size = new System.Drawing.Size(108, 32);
			this.cmd_all.TabIndex = 146;
			this.cmd_all.Text = "Select All";
			this.cmd_all.Click += new System.EventHandler(this.cmd_all_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txt_3);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.txt_2);
			this.groupBox1.Controls.Add(this.txt_1);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Location = new System.Drawing.Point(564, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(172, 92);
			this.groupBox1.TabIndex = 145;
			this.groupBox1.TabStop = false;
			this.groupBox1.Tag = "N";
			this.groupBox1.Visible = false;
			// 
			// txt_3
			// 
			this.txt_3.Location = new System.Drawing.Point(108, 60);
			this.txt_3.Name = "txt_3";
			this.txt_3.Size = new System.Drawing.Size(60, 23);
			this.txt_3.TabIndex = 147;
			this.txt_3.Text = "1";
			this.txt_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
			// 
			// label7
			// 
			this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label7.Location = new System.Drawing.Point(8, 68);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 16);
			this.label7.TabIndex = 146;
			this.label7.Tag = "";
			this.label7.Text = "VAC_ID";
			// 
			// txt_2
			// 
			this.txt_2.Location = new System.Drawing.Point(108, 36);
			this.txt_2.Name = "txt_2";
			this.txt_2.Size = new System.Drawing.Size(60, 23);
			this.txt_2.TabIndex = 145;
			this.txt_2.Text = "3";
			this.txt_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
			// 
			// txt_1
			// 
			this.txt_1.Location = new System.Drawing.Point(108, 12);
			this.txt_1.Name = "txt_1";
			this.txt_1.Size = new System.Drawing.Size(60, 23);
			this.txt_1.TabIndex = 143;
			this.txt_1.Text = "1";
			this.txt_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label3.Location = new System.Drawing.Point(8, 44);
			this.label3.Name = "label3";
			this.label3.TabIndex = 142;
			this.label3.Tag = "";
			this.label3.Text = "VAC_ID";
			// 
			// label6
			// 
			this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label6.Location = new System.Drawing.Point(8, 20);
			this.label6.Name = "label6";
			this.label6.TabIndex = 144;
			this.label6.Tag = "";
			this.label6.Text = "VAC_ID";
			// 
			// ck3
			// 
			this.ck3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ck3.Location = new System.Drawing.Point(432, 4);
			this.ck3.Name = "ck3";
			this.ck3.Size = new System.Drawing.Size(124, 24);
			this.ck3.TabIndex = 144;
			this.ck3.Text = "checkBox2";
			this.ck3.CheckedChanged += new System.EventHandler(this.ck3_CheckedChanged);
			// 
			// ck2
			// 
			this.ck2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ck2.Location = new System.Drawing.Point(320, 36);
			this.ck2.Name = "ck2";
			this.ck2.TabIndex = 143;
			this.ck2.Text = "checkBox2";
			// 
			// ck1
			// 
			this.ck1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ck1.Location = new System.Drawing.Point(212, 36);
			this.ck1.Name = "ck1";
			this.ck1.TabIndex = 142;
			this.ck1.Text = "checkBox1";
			// 
			// cb1
			// 
			this.cb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb1.Location = new System.Drawing.Point(284, 4);
			this.cb1.Name = "cb1";
			this.cb1.Size = new System.Drawing.Size(140, 24);
			this.cb1.TabIndex = 140;
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label2.Location = new System.Drawing.Point(212, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(92, 23);
			this.label2.TabIndex = 141;
			this.label2.Tag = "";
			this.label2.Text = "VAC_ID";
			// 
			// dt1
			// 
			this.dt1.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt1.Location = new System.Drawing.Point(112, 4);
			this.dt1.Name = "dt1";
			this.dt1.Size = new System.Drawing.Size(96, 23);
			this.dt1.TabIndex = 139;
			this.dt1.Tag = null;
			// 
			// cmd_clear
			// 
			this.cmd_clear.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_clear.Location = new System.Drawing.Point(452, 64);
			this.cmd_clear.Name = "cmd_clear";
			this.cmd_clear.Size = new System.Drawing.Size(108, 32);
			this.cmd_clear.TabIndex = 138;
			this.cmd_clear.Text = "Clear";
			this.cmd_clear.Click += new System.EventHandler(this.cmd_clear_Click);
			// 
			// cmd_ok
			// 
			this.cmd_ok.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_ok.Location = new System.Drawing.Point(318, 64);
			this.cmd_ok.Name = "cmd_ok";
			this.cmd_ok.Size = new System.Drawing.Size(108, 32);
			this.cmd_ok.TabIndex = 137;
			this.cmd_ok.Text = "OK";
			this.cmd_ok.Click += new System.EventHandler(this.cmd_ok_Click);
			// 
			// dt2
			// 
			this.dt2.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt2.Location = new System.Drawing.Point(112, 32);
			this.dt2.Name = "dt2";
			this.dt2.Size = new System.Drawing.Size(96, 23);
			this.dt2.TabIndex = 132;
			this.dt2.Tag = null;
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label4.Location = new System.Drawing.Point(0, 12);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(112, 23);
			this.label4.TabIndex = 135;
			this.label4.Tag = "";
			this.label4.Text = "VAC_ID";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label1.Location = new System.Drawing.Point(0, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 23);
			this.label1.TabIndex = 131;
			this.label1.Tag = "";
			this.label1.Text = "VAC_ID";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
			this.panel3.Size = new System.Drawing.Size(744, 36);
			this.panel3.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Location = new System.Drawing.Point(8, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(736, 36);
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
			// dt4
			// 
			this.dt4.BackColor = System.Drawing.Color.LemonChiffon;
			this.dt4.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt4.Location = new System.Drawing.Point(472, 3);
			this.dt4.Name = "dt4";
			this.dt4.Size = new System.Drawing.Size(96, 23);
			this.dt4.TabIndex = 141;
			this.dt4.Tag = null;
			// 
			// frmTaMonthSetup
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(1020, 676);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.c1CommandDock1);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaMonthSetup";
			this.Text = "frmTaMonthSetup";
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
			((System.ComponentModel.ISupportInitialize)(this.dt3)).EndInit();
			this.panel7.ResumeLayout(false);
			this.panel10.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs1)).EndInit();
			this.panel9.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			this.panel5.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dt1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dt2)).EndInit();
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dt4)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaVacateManager_Load(object sender, System.EventArgs e)
		{							
			dt4.CustomFormat=dt3.CustomFormat=dt1.CustomFormat=dt2.CustomFormat="yyyyMM";
			dt4.Value=dt3.Value=dt1.Value=dt2.Value=T_String.GetDate();	
			dt3.TextChanged+=new EventHandler(dt3_TextChanged);	
			dt4.TextChanged+=new EventHandler(dt3_TextChanged);	
			Init_Form();	
			cmd_ok.Visible=PublicFunction.AccessLevel(this.Tag,3);
			vs2.Styles.Add("CN");
			vs2.Styles["CN"].BackColor=Color.Silver;
		}
		
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
			Init_CB();					
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
			nav2.cmd_save.Visible=nav2.cmd_search.Visible=nav2.cmd_report.Visible=nav2.cmd_exit.Visible=nav2.cmd_delete.Visible=nav2.cmd_add.Visible=nav2.cmd_copy.Visible=false;			
			PublicFunction.InitNav(this,vs2,nav2);
			string sql;							
			sql="Select SHI_ID,SHI_ID from FILC02A";						
			PublicFunction.InitCB(cb1,sql,false);
			for(int i=1;i<=31;i++)
			{				
				vs2.Cols["DAY_"+i.ToString("00")].DataMap=PublicFunction.InitCBForVS(sql,false);
			}
			//nav2.Show_VS("YYY_MM=N'"+ ((DateTime)dt3.Value).ToString("yyyyMM")+"'");			
			vs2.AllowEditing=false;
			vs2.EnabledChanged+=new EventHandler(vs2_EnabledChanged);
			nav2.ToolBar_Auto=false;
			nav2.TBarClick+=new ToolBarButtonClickEventHandler(nav2_TBarClick);
		}	
		private void nav2_TBarClick(object sender, ToolBarButtonClickEventArgs e)
		{
			if (e.Button.Equals(nav2.cmd_refresh))
			{
				if(nav2.wh!="")
					nav2.ToolBar_Click(e);
				else
					nav2.Show_VS("DEP_ID in "+T_String.DEP_ID(this.Tag));				
				return;
			}
			nav2.ToolBar_Click(e);
		}
		private void  Init_CB()
		{
			string sql;			
			//Department
			sql=PublicFunction.GetDep(this.Tag+"");			
			vs.Cols["DEP_ID"].DataMap=PublicFunction.InitCBForVS(sql);	
			vs1.Cols["DEP_ID"].DataMap=PublicFunction.InitCBForVS(sql);	
			vs2.Cols["DEP_ID"].DataMap=PublicFunction.InitCBForVS(sql);	
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
			string sql="";
			sql="DEP_ID=N'"+Dep.Get_Data("DEP_ID")+"' and (VAC_BT=0 or VAC_BT is null)";
			sql=sql+ " and ( EMP_ID not in (Select Distinct EMP_ID From FILC03A where YYY_MM between N'"+dt1.Text+"' and N'"+dt2.Text+"'))";
			nav.Show_VS(sql);				
		}			
		private void Show_VS2()
		{
			if(!ck.Checked)
				return;
			if(Dep.vs1.Row<=0)
			{
				vs2.Rows.Count=1;
				return;
			}
			string sql="";
			sql="DEP_ID=N'"+Dep.Get_Data("DEP_ID")+"' and (VAC_BT=0 or VAC_BT is null) and (YYY_MM between N'"+ dt3.Text+"' and  N'"+ dt3.Text+"')";			
			nav2.Show_VS(sql);	
			show_cn();
		}	
		private void show_cn()
		{
			for(int j=1;j<vs2.Rows.Count;j++)
			{
				for(int i=1;i<=31;i++)
				{
					try
					{
						DateTime d=new DateTime(T_String.IsNullTo0(PublicFunction.S_Left(vs2.Rows[j]["YYY_MM"]+"",4)), T_String.IsNullTo0(PublicFunction.S_Right(vs2.Rows[j]["YYY_MM"]+"",2)),i);
						if(d.DayOfWeek==System.DayOfWeek.Sunday)
							vs2.Cols["DAY_"+i.ToString("00")].Style.BackColor=vs2.Styles["CN"].BackColor;
					}
					catch{}
				}
			}
		}
		#endregion
		#region  event
		private void vs2_EnabledChanged(object sender, EventArgs e)
		{
			for(int i=1;i<=31;i++)
			{
				vs2.Cols["DAY_"+i.ToString("00")].Caption=i+"";				
			}
			vs2.AutoSizeCols();
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
					vs1.Rows[vs1.Rows.Count-1][i]=vs.Rows[vs.Row][i];
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
		private void ck3_CheckedChanged(object sender, System.EventArgs e)
		{
			groupBox1.Visible=ck3.Checked;
			ck1.Visible=ck2.Visible=!ck3.Checked;
		}

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
						vs1.Rows[vs1.Rows.Count-1][m]=vs.Rows[j][m];
					}
				}
			}					
			cmd_ok.Enabled=vs1.Rows.Count>1;
		}

		private void textBox1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Double result;
			if(e.KeyChar!=8)
				if( !Double.TryParse(e.KeyChar+"",System.Globalization.NumberStyles.Integer,System.Globalization.CultureInfo.CurrentCulture,out result))
					e.Handled=true;
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
				sql= sql+" and  (VAC_BT=0 or VAC_BT is null) and DEP_ID in (Select DEP_ID  from SYS_SECURITY_DEP"+
					" where MNU_ID="+this.Tag+" and ALL_BT=1  and USER_ID=N'"+PublicFunction.A_UserID+"')";	
				sql=sql+ " and ( EMP_ID not in (Select Distinct EMP_ID From FILC03A where YYY_MM between N'"+dt1.Text+"' and N'"+dt2.Text+"'))";
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
				sql=sql+" and  (VAC_BT=0 or VAC_BT is null) and DEP_ID in (Select DEP_ID  from SYS_SECURITY_DEP"+
					" where MNU_ID="+this.Tag+" and ALL_BT=1  and USER_ID=N'"+PublicFunction.A_UserID+"')";					
				nav1.Show_VS(sql);						
			}
			cmd_ok.Enabled=vs1.Rows.Count>1;
		}


		private void txt5_Enter(object sender, System.EventArgs e)
		{			
			TextBox txt=(TextBox)sender;
			if (txt.Text==vs.Cols[txt.Tag+""].Caption)
				txt.Text="";
		}

		private void txt5_Leave(object sender, System.EventArgs e)
		{
			TextBox txt=(TextBox)sender;
			if (txt.Text=="")
				txt.Text=vs.Cols[txt.Tag+""].Caption;
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
				sql=sql+" and  (VAC_BT=0 or VAC_BT is null) and (YYY_MM between N'"+ dt3.Text+"' and N'"+ dt4.Text+"') "
					+"and DEP_ID in (Select DEP_ID  from SYS_SECURITY_DEP"+
					" where MNU_ID="+this.Tag+" and ALL_BT=1 and USER_ID=N'"+PublicFunction.A_UserID+"')";									
				nav2.Show_VS(sql);	
				show_cn();						
			}
		}
		private void dt3_TextChanged(object sender, System.EventArgs e)
		{
			Show_VS2();
		}

		#endregion		
		#region button
		private void cmd_ok_Click(object sender, System.EventArgs e)
		{			
			
//			if(MessageBox.Show(this,PublicFunction.L_Get_Msg("msg",13),this.Text,MessageBoxButtons.YesNo)==DialogResult.Yes)
//			{				
			SqlConnection con=new SqlConnection(PublicFunction.C_con.ConnectionString);
			con.Open();	
			string sql1="";
			string sql="",insert="",dt=T_String.GetDate().ToString("yyyy/MM/dd HH:mm");				
			DateTime d1=(DateTime)(dt1.Value),d2=(DateTime)(dt2.Value);			
			insert="Insert Into FILC03A(EMP_ID,YYY_MM,BLT_NM,BLT_DT,LST_NM,LST_DT";
			for(int i=1;i<=31;i++)
			{
				insert+=",DAY_"+i.ToString("00");
			}
			insert+=") values(";
			for(int i=vs1.Rows.Count-1;i>0;i--)
			{
				d1=(DateTime)(dt1.Value);
				while(T_String.IsNullTo0(d1.ToString("yyyyMM"))<=T_String.IsNullTo0(d2.ToString("yyyyMM")))	
				{
					try
					{	
						sql="N'"+vs1.Rows[i]["EMP_ID"]+"'"
							+",N'"+d1.ToString("yyyyMM")+"'"
							+",N'"+PublicFunction.A_UserID+"'"
							+",'"+dt+"'"
							+",N'"+PublicFunction.A_UserID+"'"
							+",'"+dt+"'";
						int demlam=-1,demnghi=0;
						for(int j=1;j<=31;j++)
						{
							if(j<=DateTime.DaysInMonth(d1.Year,d1.Month))
							{
								DateTime d3=new DateTime(d1.Year,d1.Month,j);								
								if(ck3.Checked)	
								{								
									if(j==T_String.IsNullTo00(txt_1.Text))
									{
										sql+=",N'00'";
										demnghi=1;
										demlam=0;
									}
									else
									{
										if(demlam==-1)
										{
											sql+=",N'"+cb1.SelectedValue+"'";	
										}
										else
										{
											if(demnghi<T_String.IsNullTo00(txt_3.Text))
											{
												sql+=",N'00'";
												demnghi++;
												demlam=0;
											}
											else
											{
												if(demlam<T_String.IsNullTo00(txt_2.Text))
												{
													sql+=",N'"+cb1.SelectedValue+"'";	
													demlam++;											
												}
												else
												{
													sql+=",N'00'";
													demnghi=1;
													demlam=0;
												}
											}
										}										
									}
								}
								else // phan ca thuong
								{
									if((ck1.Checked && d3.DayOfWeek==DayOfWeek.Sunday) ||(ck2.Checked && d3.DayOfWeek==DayOfWeek.Saturday) )
										sql+=",N'00'";
									else
										sql+=",N'"+cb1.SelectedValue+"'";							
								}
							}
							else
							{
								sql+=",Default";
							}
						}					
						sql+=")";
						sql=insert+sql;
						SqlCommand cmd=new SqlCommand(sql,con);
						cmd.ExecuteNonQuery();							
					}									
					catch(SqlException ex)
					{		
						if (ex.Number!=2627 )
						{
							MessageBox.Show(ex.Message);							
						}
						else
						{
//							if(sql1!="")
//								sql1+=",";
//							sql1+="N'"+vs1.Rows[i]["EMP_ID"]+"'";
//							vs1.RemoveItem(i);
						}
					}
					d1=d1.AddMonths(1);
					if(sql1!="")
						sql1+=",";
					sql1+="N'"+vs1.Rows[i]["EMP_ID"]+"'";		
					vs1.RemoveItem(i);						
					vs.Rows.Count=1;
				}//while
			}//for							
			MessageBox.Show(PublicFunction.L_Get_Msg("Staff",1));
			con.Close();
			dt3.Value=dt1.Value;
			dt4.Value=dt2.Value;
			if(sql1!="")
				nav2.Show_VS("YYY_MM between N'"+ dt3.Text
					+"' and N'"+dt4.Text+"' and a.EMP_ID in ("+sql1+")");
//			}
		}		

		
		#endregion

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
	}
}

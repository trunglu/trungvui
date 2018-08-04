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

namespace GP8000.Attendance
{
	/// <summary>
	/// Summary description for frmTaVacateManager.
	/// </summary>
	public class frmTaCopyShift : System.Windows.Forms.Form
	{
		private C1.Win.C1Command.C1CommandDock c1CommandDock1;
		private C1.Win.C1Command.C1DockingTab c1DockingTab1;
		private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage1;
		private GP8000.UserControl.CrtTaDepartment Dep;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Button cmd_clear;
		private System.Windows.Forms.Button cmd_ok;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel10;
		private System.Windows.Forms.TextBox txt10;
		private System.Windows.Forms.TextBox txt9;
		private System.Windows.Forms.TextBox txt8;
		private Navigator1._0.NavigatorAuto nav1;
		private C1.Win.C1FlexGrid.C1FlexGrid vs1;
		private System.Windows.Forms.Splitter splitter2;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.TextBox txt3;
		private System.Windows.Forms.TextBox txt2;
		private System.Windows.Forms.TextBox txt1;
		private Navigator1._0.NavigatorAuto nav;
		private C1.Win.C1FlexGrid.C1FlexGrid vs;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Button cmd_all;
		private System.Windows.Forms.Label label3;
		private C1.Win.C1Input.C1DateEdit dt4;
		private System.Windows.Forms.Label label2;
		private C1.Win.C1Input.C1DateEdit dt1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox EMP_ID;
		private System.Windows.Forms.TextBox EMP_NM;
		private C1.Win.C1Input.C1DateEdit dt2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button cmd_del;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaCopyShift()
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
			this.button1 = new System.Windows.Forms.Button();
			this.EMP_NM = new System.Windows.Forms.TextBox();
			this.EMP_ID = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.dt4 = new C1.Win.C1Input.C1DateEdit();
			this.label2 = new System.Windows.Forms.Label();
			this.dt1 = new C1.Win.C1Input.C1DateEdit();
			this.cmd_all = new System.Windows.Forms.Button();
			this.cmd_clear = new System.Windows.Forms.Button();
			this.cmd_ok = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.cmd_del = new System.Windows.Forms.Button();
			this.dt2 = new C1.Win.C1Input.C1DateEdit();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandDock1)).BeginInit();
			this.c1CommandDock1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).BeginInit();
			this.c1DockingTab1.SuspendLayout();
			this.c1DockingTabPage1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel10.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs1)).BeginInit();
			this.panel9.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dt4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dt1)).BeginInit();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dt2)).BeginInit();
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
			this.panel1.Size = new System.Drawing.Size(748, 676);
			this.panel1.TabIndex = 3;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.panel6);
			this.panel2.Controls.Add(this.panel5);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 36);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(748, 640);
			this.panel2.TabIndex = 5;
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.panel7);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panel6.Location = new System.Drawing.Point(0, 76);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(748, 564);
			this.panel6.TabIndex = 1;
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.panel10);
			this.panel7.Controls.Add(this.splitter2);
			this.panel7.Controls.Add(this.panel9);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(748, 564);
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
			this.panel10.Size = new System.Drawing.Size(373, 564);
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
			this.vs1.Size = new System.Drawing.Size(364, 532);
			this.vs1.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs1.TabIndex = 11;
			// 
			// splitter2
			// 
			this.splitter2.Location = new System.Drawing.Point(372, 0);
			this.splitter2.Name = "splitter2";
			this.splitter2.Size = new System.Drawing.Size(3, 564);
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
			this.panel9.Size = new System.Drawing.Size(372, 564);
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
			this.vs.Size = new System.Drawing.Size(364, 532);
			this.vs.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs.TabIndex = 10;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.Moccasin;
			this.panel5.Controls.Add(this.button1);
			this.panel5.Controls.Add(this.EMP_NM);
			this.panel5.Controls.Add(this.EMP_ID);
			this.panel5.Controls.Add(this.label1);
			this.panel5.Controls.Add(this.label3);
			this.panel5.Controls.Add(this.dt4);
			this.panel5.Controls.Add(this.label2);
			this.panel5.Controls.Add(this.dt1);
			this.panel5.Controls.Add(this.cmd_all);
			this.panel5.Controls.Add(this.cmd_clear);
			this.panel5.Controls.Add(this.cmd_ok);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel5.Location = new System.Drawing.Point(0, 0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(748, 76);
			this.panel5.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(180, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(28, 24);
			this.button1.TabIndex = 156;
			this.button1.Tag = "N";
			this.button1.Text = "...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// EMP_NM
			// 
			this.EMP_NM.BackColor = System.Drawing.Color.LemonChiffon;
			this.EMP_NM.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.EMP_NM.Location = new System.Drawing.Point(208, 4);
			this.EMP_NM.MaxLength = 20;
			this.EMP_NM.Name = "EMP_NM";
			this.EMP_NM.ReadOnly = true;
			this.EMP_NM.Size = new System.Drawing.Size(152, 23);
			this.EMP_NM.TabIndex = 155;
			this.EMP_NM.Tag = "EMP_ID";
			this.EMP_NM.Text = "";
			// 
			// EMP_ID
			// 
			this.EMP_ID.BackColor = System.Drawing.SystemColors.Window;
			this.EMP_ID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.EMP_ID.Location = new System.Drawing.Point(88, 4);
			this.EMP_ID.MaxLength = 20;
			this.EMP_ID.Name = "EMP_ID";
			this.EMP_ID.Size = new System.Drawing.Size(92, 23);
			this.EMP_ID.TabIndex = 154;
			this.EMP_ID.Tag = "EMP_ID";
			this.EMP_ID.Text = "";
			this.EMP_ID.Leave += new System.EventHandler(this.textBox1_Leave_1);
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label1.Location = new System.Drawing.Point(8, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 23);
			this.label1.TabIndex = 153;
			this.label1.Tag = "";
			this.label1.Text = "VAC_ID";
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label3.Location = new System.Drawing.Point(540, 12);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 23);
			this.label3.TabIndex = 152;
			this.label3.Tag = "";
			this.label3.Text = "To";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.label3.Visible = false;
			// 
			// dt4
			// 
			this.dt4.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt4.Location = new System.Drawing.Point(444, 4);
			this.dt4.Name = "dt4";
			this.dt4.Size = new System.Drawing.Size(96, 23);
			this.dt4.TabIndex = 151;
			this.dt4.Tag = null;
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label2.Location = new System.Drawing.Point(352, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(92, 23);
			this.label2.TabIndex = 150;
			this.label2.Tag = "";
			this.label2.Text = "VAC_ID";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// dt1
			// 
			this.dt1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dt1.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt1.Location = new System.Drawing.Point(580, 4);
			this.dt1.Name = "dt1";
			this.dt1.Size = new System.Drawing.Size(96, 23);
			this.dt1.TabIndex = 149;
			this.dt1.Tag = null;
			this.dt1.Visible = false;
			// 
			// cmd_all
			// 
			this.cmd_all.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cmd_all.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_all.Location = new System.Drawing.Point(4, 40);
			this.cmd_all.Name = "cmd_all";
			this.cmd_all.Size = new System.Drawing.Size(108, 32);
			this.cmd_all.TabIndex = 147;
			this.cmd_all.Text = "Select All";
			this.cmd_all.Click += new System.EventHandler(this.cmd_all_Click);
			// 
			// cmd_clear
			// 
			this.cmd_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cmd_clear.BackColor = System.Drawing.Color.Moccasin;
			this.cmd_clear.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_clear.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmd_clear.Location = new System.Drawing.Point(628, 40);
			this.cmd_clear.Name = "cmd_clear";
			this.cmd_clear.Size = new System.Drawing.Size(108, 32);
			this.cmd_clear.TabIndex = 138;
			this.cmd_clear.Text = "Clear";
			this.cmd_clear.Click += new System.EventHandler(this.cmd_clear_Click);
			// 
			// cmd_ok
			// 
			this.cmd_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cmd_ok.BackColor = System.Drawing.Color.Moccasin;
			this.cmd_ok.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_ok.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmd_ok.Location = new System.Drawing.Point(318, 40);
			this.cmd_ok.Name = "cmd_ok";
			this.cmd_ok.Size = new System.Drawing.Size(108, 32);
			this.cmd_ok.TabIndex = 137;
			this.cmd_ok.Text = "Copy";
			this.cmd_ok.Click += new System.EventHandler(this.cmd_ok_Click);
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
			this.panel3.Size = new System.Drawing.Size(748, 36);
			this.panel3.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Location = new System.Drawing.Point(328, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(420, 36);
			this.label5.TabIndex = 11;
			this.label5.Tag = "";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.panel4.Controls.Add(this.cmd_del);
			this.panel4.Controls.Add(this.dt2);
			this.panel4.Controls.Add(this.label4);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(328, 36);
			this.panel4.TabIndex = 10;
			// 
			// cmd_del
			// 
			this.cmd_del.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cmd_del.BackColor = System.Drawing.Color.Moccasin;
			this.cmd_del.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_del.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmd_del.Location = new System.Drawing.Point(212, 4);
			this.cmd_del.Name = "cmd_del";
			this.cmd_del.Size = new System.Drawing.Size(108, 28);
			this.cmd_del.TabIndex = 154;
			this.cmd_del.Text = "Clear";
			this.cmd_del.Click += new System.EventHandler(this.cmd_del_Click);
			// 
			// dt2
			// 
			this.dt2.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt2.Location = new System.Drawing.Point(88, 8);
			this.dt2.Name = "dt2";
			this.dt2.Size = new System.Drawing.Size(120, 23);
			this.dt2.TabIndex = 153;
			this.dt2.Tag = null;
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label4.Location = new System.Drawing.Point(-8, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(92, 23);
			this.label4.TabIndex = 152;
			this.label4.Tag = "";
			this.label4.Text = "VAC_ID";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// frmTaCopyShift
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(1024, 676);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.c1CommandDock1);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaCopyShift";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmTaCopyShift";
			this.Load += new System.EventHandler(this.frmTaVacateManager_Load);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandDock1)).EndInit();
			this.c1CommandDock1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).EndInit();
			this.c1DockingTab1.ResumeLayout(false);
			this.c1DockingTabPage1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel10.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs1)).EndInit();
			this.panel9.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			this.panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dt4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dt1)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dt2)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaVacateManager_Load(object sender, System.EventArgs e)
		{
			dt2.CustomFormat=dt1.CustomFormat=dt4.CustomFormat="yyyyMM";
			dt1.Value=dt4.Value=T_String.GetDate();	
			dt2.Value=T_String.GetDate().AddMonths(-6);
			Init_Form();	
			cmd_del.Enabled=cmd_ok.Enabled=PublicFunction.AccessLevel(this.Tag,3);		
		}
		
		#region Init Form
		private void Init_Form()
		{					
			Dep.Init_Tree(this.Tag+"");
			Dep.vs1.AfterRowColChange+=new C1.Win.C1FlexGrid.RangeEventHandler(Depvs1_AfterRowColChange);
			Dep.Show_Tree();
			Init_vs();	
			Init_vs1();			
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
	
	
		
	
		#endregion
		#region ShowData
		private void Show_VS()
		{
			if(Dep.vs1.Row<=0)
			{
				vs.Rows.Count=1;
				return;
			}
			nav.Show_VS("DEP_ID=N'"+Dep.Get_Data("DEP_ID")+"' and (VAC_BT=0 or VAC_BT is null)");				
		}			
		#endregion
		#region  event
		private void Depvs1_AfterRowColChange(object sender, C1.Win.C1FlexGrid.RangeEventArgs e)
		{
			if(e.OldRange.r1!=e.NewRange.r1)
			{
				Show_VS();
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

		private void textBox1_Leave_1(object sender, System.EventArgs e)
		{
			Func.RecordSet rs =new Func.RecordSet("Select EMP_ID,EMP_I1,EMP_NM from FILB01A where EMP_ID=N'"+EMP_ID.Text+"'",PublicFunction.C_con);
			if(rs.rows>0)
			{
				EMP_ID.Text=rs.record(0,"EMP_ID");	
				EMP_NM.Text=rs.record(0,"EMP_NM");
			}
			else
			{
				EMP_ID.Text=EMP_NM.Text="";
			}
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			Func.RecordSet rs =new Func.RecordSet("Select EMP_ID,EMP_I1,EMP_NM from FILB01A",PublicFunction.C_con);
			Basic.Form.frmSearch dlg=new frmSearch(rs,3,"frmTaStaffInfo_vs");
			if  (dlg.ShowDialog()==DialogResult.OK)
			{
				EMP_ID.Text=rs.record(rs.Bookmarks,"EMP_ID");	
				EMP_NM.Text=rs.record(rs.Bookmarks,"EMP_NM");			
			}
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
				string sql;		
				string f=((TextBox)sender).Tag+"";										
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
		#endregion		
		#region button
		private void cmd_ok_Click(object sender, System.EventArgs e)
		{
			string sql;
			string d1=dt2.Text;
			string d4=dt4.Text;
			SqlConnection con=new SqlConnection(PublicFunction.C_con.ConnectionString);
			con.Open();	
			string insert="Insert Into FILC03A(EMP_ID,YYY_MM,BLT_NM,BLT_DT,LST_NM,LST_DT";
			string dt=T_String.GetDate().ToString("yyyy/MM/dd HH:mm");
			for(int i=1;i<=31;i++)
			{
				insert+=",DAY_"+i.ToString("00");
			}
			insert+=") Select ";
			for(int i=1;i<vs1.Rows.Count;i++)
			{
				if(vs1.Rows[i]["EMP_ID"]+""!=EMP_ID.Text)
				{
					SqlTransaction tran=con.BeginTransaction();			
					try
					{					
						sql="Delete From FILC03A where YYY_MM='"+d4+"' and EMP_ID=N'"+vs1.Rows[i]["EMP_ID"]+"'";
						SqlCommand cmd=new SqlCommand(sql,con,tran);
						cmd.ExecuteNonQuery();	
						sql="N'"+vs1.Rows[i]["EMP_ID"]+"' as EMP_ID"
							+",N'"+d4+"' as YYY_MM"
							+",N'"+PublicFunction.A_UserID+"' as BLT_NM "
							+",'"+dt+"' as BLT_DT "
							+",N'"+PublicFunction.A_UserID+"' as LST_NM "
							+",'"+dt+"' as LST_DT ";					
						for(int j=1;j<=31;j++)
						{
							sql+=",DAY_"+j.ToString("00");
						}
						sql=insert + sql + " from FILC03A where YYY_MM='"+d1+"' and EMP_ID=N'"+vs1.Rows[i]["EMP_ID"]+"'";
						cmd=new SqlCommand(sql,con,tran);
						cmd.ExecuteNonQuery();						
						tran.Commit();				
					}				
					catch(Exception ex)
					{
						tran.Rollback();
						MessageBox.Show(ex.Message);
					}
				}
			}
			MessageBox.Show(PublicFunction.L_Get_Msg("Staff",1));
		}
		
		#endregion	

		private void cmd_del_Click(object sender, System.EventArgs e)
		{
			if(MessageBox.Show(this,PublicFunction.L_Get_Msg("msg",16)+" ("+dt2.Text+")?",this.Text,MessageBoxButtons.YesNo)==DialogResult.Yes)
			{
				string sql="Delete From FILC03A where YYY_MM='"+dt2.Text+"'";
				PublicFunction.SQL_Execute(sql);
				sql="Insert Into GP_HISTORY values("+T_String.GetMax("MAX(SEQ_NO)","GP_HISTORY")
					+",N'"+PublicFunction.A_UserID+"'"
					+",'"+T_String.GetDate().ToString("yyyy/MM/dd HH:mm:ss")+"'"
					+",N'"+dt2.Text+"')";
				PublicFunction.SQL_Execute(sql);
			}
		}

		private void vs_EnabledChanged(object sender, EventArgs e)
		{
			txt1.Text=vs.Cols[txt1.Tag+""].Caption;
			txt2.Text=vs.Cols[txt2.Tag+""].Caption;
			txt3.Text=vs.Cols[txt3.Tag+""].Caption;						
			txt8.Text=vs.Cols[txt8.Tag+""].Caption;
			txt9.Text=vs.Cols[txt9.Tag+""].Caption;
			txt10.Text=vs.Cols[txt10.Tag+""].Caption;
		}
	}
}

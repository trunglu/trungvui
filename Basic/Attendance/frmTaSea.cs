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
using GP8000.Personnel.Report;

namespace GP8000.Attendance
{
	/// <summary>
	/// Summary description for frmTaSea.
	/// </summary>
	public class frmTaSea : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel8;
		private C1.Win.C1FlexGrid.C1FlexGrid vs2;
		private Navigator1._0.NavigatorAuto nav2;
		private System.Windows.Forms.TextBox txt5;
		private System.Windows.Forms.TextBox txt7;
		private System.Windows.Forms.TextBox txt6;
		private System.Windows.Forms.Splitter splitter2;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox txt_EMP_NM;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button cmd_ok;
		private C1.Win.C1Input.C1DateEdit dt;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox txt_EMP_ID;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox txt3;
		private System.Windows.Forms.TextBox txt2;
		private System.Windows.Forms.TextBox txt1;
		private C1.Win.C1FlexGrid.C1FlexGrid vs;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel4;
		private Navigator1._0.NavigatorAuto nav;
		private C1.Win.C1Command.C1CommandDock c1CommandDock1;
		private C1.Win.C1Command.C1DockingTab c1DockingTab1;
		private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage1;
		private GP8000.UserControl.CrtTaDepartment Dep;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaSea()
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
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel8 = new System.Windows.Forms.Panel();
			this.vs2 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.nav2 = new Navigator1._0.NavigatorAuto();
			this.txt5 = new System.Windows.Forms.TextBox();
			this.txt7 = new System.Windows.Forms.TextBox();
			this.txt6 = new System.Windows.Forms.TextBox();
			this.splitter2 = new System.Windows.Forms.Splitter();
			this.panel7 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.txt_EMP_NM = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.cmd_ok = new System.Windows.Forms.Button();
			this.dt = new C1.Win.C1Input.C1DateEdit();
			this.label16 = new System.Windows.Forms.Label();
			this.txt_EMP_ID = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.panel2 = new System.Windows.Forms.Panel();
			this.txt3 = new System.Windows.Forms.TextBox();
			this.txt2 = new System.Windows.Forms.TextBox();
			this.txt1 = new System.Windows.Forms.TextBox();
			this.vs = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.nav = new Navigator1._0.NavigatorAuto();
			this.c1CommandDock1 = new C1.Win.C1Command.C1CommandDock();
			this.c1DockingTab1 = new C1.Win.C1Command.C1DockingTab();
			this.c1DockingTabPage1 = new C1.Win.C1Command.C1DockingTabPage();
			this.Dep = new GP8000.UserControl.CrtTaDepartment();
			this.panel1.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel8.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs2)).BeginInit();
			this.panel7.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dt)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
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
			this.panel1.Controls.Add(this.panel5);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.c1CommandDock1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1028, 572);
			this.panel1.TabIndex = 5;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.panel6);
			this.panel5.Controls.Add(this.splitter1);
			this.panel5.Controls.Add(this.panel2);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panel5.Location = new System.Drawing.Point(228, 36);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(800, 536);
			this.panel5.TabIndex = 4;
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.panel8);
			this.panel6.Controls.Add(this.splitter2);
			this.panel6.Controls.Add(this.panel7);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panel6.Location = new System.Drawing.Point(379, 0);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(421, 536);
			this.panel6.TabIndex = 2;
			// 
			// panel8
			// 
			this.panel8.Controls.Add(this.vs2);
			this.panel8.Controls.Add(this.nav2);
			this.panel8.Controls.Add(this.txt5);
			this.panel8.Controls.Add(this.txt7);
			this.panel8.Controls.Add(this.txt6);
			this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panel8.Location = new System.Drawing.Point(0, 135);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(421, 401);
			this.panel8.TabIndex = 2;
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
			this.vs2.Location = new System.Drawing.Point(4, 64);
			this.vs2.Name = "vs2";
			this.vs2.Size = new System.Drawing.Size(412, 334);
			this.vs2.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs2.TabIndex = 10;
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
			this.nav2.Location = new System.Drawing.Point(4, 32);
			this.nav2.MSG_Exit = false;
			this.nav2.MulltiDel = false;
			this.nav2.Name = "nav2";
			this.nav2.Security = 0;
			this.nav2.ShowPopupMenu = true;
			this.nav2.Size = new System.Drawing.Size(408, 32);
			this.nav2.TabIndex = 34;
			this.nav2.Tag = "";
			this.nav2.ToolBar_Auto = true;
			this.nav2.UserID = null;
			this.nav2.VisibleGrid = true;
			this.nav2.Where = null;
			// 
			// txt5
			// 
			this.txt5.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt5.Location = new System.Drawing.Point(4, 4);
			this.txt5.MaxLength = 20;
			this.txt5.Name = "txt5";
			this.txt5.Size = new System.Drawing.Size(112, 23);
			this.txt5.TabIndex = 34;
			this.txt5.Tag = "EMP_ID";
			this.txt5.Text = "textBox3";
			// 
			// txt7
			// 
			this.txt7.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt7.Location = new System.Drawing.Point(236, 4);
			this.txt7.MaxLength = 20;
			this.txt7.Name = "txt7";
			this.txt7.Size = new System.Drawing.Size(132, 23);
			this.txt7.TabIndex = 36;
			this.txt7.Tag = "EMP_NM";
			this.txt7.Text = "textBox3";
			// 
			// txt6
			// 
			this.txt6.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt6.Location = new System.Drawing.Point(120, 4);
			this.txt6.MaxLength = 20;
			this.txt6.Name = "txt6";
			this.txt6.Size = new System.Drawing.Size(112, 23);
			this.txt6.TabIndex = 35;
			this.txt6.Tag = "EMP_I1";
			this.txt6.Text = "textBox3";
			// 
			// splitter2
			// 
			this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
			this.splitter2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.splitter2.Location = new System.Drawing.Point(0, 132);
			this.splitter2.Name = "splitter2";
			this.splitter2.Size = new System.Drawing.Size(421, 3);
			this.splitter2.TabIndex = 1;
			this.splitter2.TabStop = false;
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.groupBox1);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(421, 132);
			this.panel7.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.textBox3);
			this.groupBox1.Controls.Add(this.txt_EMP_NM);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.cmd_ok);
			this.groupBox1.Controls.Add(this.dt);
			this.groupBox1.Controls.Add(this.label16);
			this.groupBox1.Controls.Add(this.txt_EMP_ID);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(4, -4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(412, 128);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Tag = "N";
			// 
			// textBox3
			// 
			this.textBox3.BackColor = System.Drawing.Color.LemonChiffon;
			this.textBox3.Location = new System.Drawing.Point(336, 48);
			this.textBox3.MaxLength = 50;
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new System.Drawing.Size(220, 23);
			this.textBox3.TabIndex = 138;
			this.textBox3.Tag = "EMP_N1";
			this.textBox3.Text = "";
			// 
			// txt_EMP_NM
			// 
			this.txt_EMP_NM.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt_EMP_NM.Location = new System.Drawing.Point(116, 48);
			this.txt_EMP_NM.MaxLength = 50;
			this.txt_EMP_NM.Name = "txt_EMP_NM";
			this.txt_EMP_NM.ReadOnly = true;
			this.txt_EMP_NM.Size = new System.Drawing.Size(220, 23);
			this.txt_EMP_NM.TabIndex = 137;
			this.txt_EMP_NM.Tag = "EMP_NM";
			this.txt_EMP_NM.Text = "";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 56);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(112, 23);
			this.label6.TabIndex = 139;
			this.label6.Tag = "";
			this.label6.Text = "EMP_NM";
			// 
			// cmd_ok
			// 
			this.cmd_ok.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_ok.Location = new System.Drawing.Point(152, 84);
			this.cmd_ok.Name = "cmd_ok";
			this.cmd_ok.Size = new System.Drawing.Size(108, 32);
			this.cmd_ok.TabIndex = 136;
			this.cmd_ok.Text = "button1";
			// 
			// dt
			// 
			this.dt.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt.Location = new System.Drawing.Point(400, 16);
			this.dt.Name = "dt";
			this.dt.Size = new System.Drawing.Size(160, 23);
			this.dt.TabIndex = 126;
			this.dt.Tag = null;
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(292, 24);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(112, 23);
			this.label16.TabIndex = 125;
			this.label16.Tag = "";
			this.label16.Text = "Mobi Date";
			// 
			// txt_EMP_ID
			// 
			this.txt_EMP_ID.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt_EMP_ID.Location = new System.Drawing.Point(116, 16);
			this.txt_EMP_ID.MaxLength = 20;
			this.txt_EMP_ID.Name = "txt_EMP_ID";
			this.txt_EMP_ID.ReadOnly = true;
			this.txt_EMP_ID.Size = new System.Drawing.Size(156, 23);
			this.txt_EMP_ID.TabIndex = 30;
			this.txt_EMP_ID.Tag = "EMP_ID";
			this.txt_EMP_ID.Text = "";
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label3.Location = new System.Drawing.Point(8, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(112, 23);
			this.label3.TabIndex = 31;
			this.label3.Tag = "";
			this.label3.Text = "EMP_ID";
			// 
			// splitter1
			// 
			this.splitter1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.splitter1.Location = new System.Drawing.Point(376, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(3, 536);
			this.splitter1.TabIndex = 1;
			this.splitter1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.txt3);
			this.panel2.Controls.Add(this.txt2);
			this.panel2.Controls.Add(this.txt1);
			this.panel2.Controls.Add(this.vs);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(376, 536);
			this.panel2.TabIndex = 0;
			// 
			// txt3
			// 
			this.txt3.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt3.Location = new System.Drawing.Point(240, 4);
			this.txt3.MaxLength = 20;
			this.txt3.Name = "txt3";
			this.txt3.Size = new System.Drawing.Size(132, 23);
			this.txt3.TabIndex = 33;
			this.txt3.Tag = "EMP_NM";
			this.txt3.Text = "textBox3";
			// 
			// txt2
			// 
			this.txt2.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt2.Location = new System.Drawing.Point(124, 4);
			this.txt2.MaxLength = 20;
			this.txt2.Name = "txt2";
			this.txt2.Size = new System.Drawing.Size(112, 23);
			this.txt2.TabIndex = 32;
			this.txt2.Tag = "EMP_I1";
			this.txt2.Text = "textBox3";
			// 
			// txt1
			// 
			this.txt1.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt1.Location = new System.Drawing.Point(8, 4);
			this.txt1.MaxLength = 20;
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(112, 23);
			this.txt1.TabIndex = 31;
			this.txt1.Tag = "EMP_ID";
			this.txt1.Text = "textBox3";
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
			this.vs.Size = new System.Drawing.Size(372, 502);
			this.vs.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs.TabIndex = 9;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.panel4);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panel3.Location = new System.Drawing.Point(228, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(800, 36);
			this.panel3.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Location = new System.Drawing.Point(416, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(384, 36);
			this.label5.TabIndex = 11;
			this.label5.Tag = "";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.panel4.Controls.Add(this.nav);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
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
			this.nav.Location = new System.Drawing.Point(3, 2);
			this.nav.MSG_Exit = false;
			this.nav.MulltiDel = false;
			this.nav.Name = "nav";
			this.nav.Security = 0;
			this.nav.ShowPopupMenu = false;
			this.nav.Size = new System.Drawing.Size(472, 32);
			this.nav.TabIndex = 9;
			this.nav.Tag = "";
			this.nav.ToolBar_Auto = true;
			this.nav.UserID = null;
			this.nav.VisibleGrid = true;
			this.nav.Where = null;
			// 
			// c1CommandDock1
			// 
			this.c1CommandDock1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.c1CommandDock1.Controls.Add(this.c1DockingTab1);
			this.c1CommandDock1.Dock = System.Windows.Forms.DockStyle.Left;
			this.c1CommandDock1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.c1CommandDock1.Id = 1;
			this.c1CommandDock1.Location = new System.Drawing.Point(0, 0);
			this.c1CommandDock1.Name = "c1CommandDock1";
			this.c1CommandDock1.Size = new System.Drawing.Size(228, 572);
			// 
			// c1DockingTab1
			// 
			this.c1DockingTab1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
			this.c1DockingTab1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.c1DockingTab1.CanAutoHide = true;
			this.c1DockingTab1.CanMoveTabs = true;
			this.c1DockingTab1.Controls.Add(this.c1DockingTabPage1);
			this.c1DockingTab1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.c1DockingTab1.Location = new System.Drawing.Point(0, 0);
			this.c1DockingTab1.Name = "c1DockingTab1";
			this.c1DockingTab1.SelectedIndex = 0;
			this.c1DockingTab1.ShowCaption = true;
			this.c1DockingTab1.ShowSingleTab = false;
			this.c1DockingTab1.Size = new System.Drawing.Size(226, 570);
			this.c1DockingTab1.TabIndex = 0;
			this.c1DockingTab1.TabSizeMode = C1.Win.C1Command.TabSizeModeEnum.Fit;
			this.c1DockingTab1.TabStyle = C1.Win.C1Command.TabStyleEnum.WindowsXP;
			// 
			// c1DockingTabPage1
			// 
			this.c1DockingTabPage1.Controls.Add(this.Dep);
			this.c1DockingTabPage1.ImageIndex = -1;
			this.c1DockingTabPage1.Location = new System.Drawing.Point(0, 0);
			this.c1DockingTabPage1.Name = "c1DockingTabPage1";
			this.c1DockingTabPage1.Size = new System.Drawing.Size(223, 569);
			this.c1DockingTabPage1.TabIndex = 0;
			this.c1DockingTabPage1.Text = "Page1";
			// 
			// Dep
			// 
			this.Dep.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Dep.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Dep.Location = new System.Drawing.Point(0, 23);
			this.Dep.Name = "Dep";
			this.Dep.Size = new System.Drawing.Size(223, 546);
			this.Dep.TabIndex = 0;
			// 
			// frmTaSea
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1028, 572);
			this.Controls.Add(this.panel1);
			this.Name = "frmTaSea";
			this.Text = "frmTaSea";
			this.Load += new System.EventHandler(this.frmTaSea_Load);
			this.panel1.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs2)).EndInit();
			this.panel7.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dt)).EndInit();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
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

		private void frmTaSea_Load(object sender, System.EventArgs e)
		{
		
			Init_Form();	
			Init_CB();
			vs2.Cols["SEQ_DT"].Format=dt.CustomFormat=PublicFunction.GetOption("DATE");
			dt.Value=T_String.GetDate();
			cmd_ok.Visible=PublicFunction.AccessLevel(this.Tag,3);
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
					ReportFromVS rpt=new ReportFromVS();
					rpt.RPT2(c1XLBook1,vs2,mnu1.MenuItems[mnu1.MenuItems.IndexOf((MenuItem)sender)].Text,"STD_HR_04");					
					break;
				
			}
		}
		#endregion
		
		
		#region Init Form
		private void Init_Form()
		{					
			Dep.Init_Tree(this.Tag+"");
			Dep.vs1.AfterRowColChange+=new RangeEventHandler(Depvs1_AfterRowColChange);
			Dep.Show_Tree();
			Init_vs();		
			Init_vs2();
			Basic.Function.PublicFunction.L_Init_Label(this);		
		}
		private void Init_vs()
		{
			nav.cmd_save.Visible=nav.cmd_search.Visible=nav.cmd_report.Visible=nav.cmd_delete.Visible=nav.cmd_add.Visible=nav.cmd_copy.Visible=false;
			PublicFunction.InitNav(this,vs,nav);
			vs.AllowEditing=false;				
			vs.AfterRowColChange+=new RangeEventHandler(vs_AfterRowColChange);
			show_text();
			nav.ToolBar_Auto=false;
			nav.TBarClick+=new ToolBarButtonClickEventHandler(nav_TBarClick);
			vs.EnabledChanged+=new EventHandler(vs_EnabledChanged);
		}	
		private void Init_vs2()
		{
			nav2.cmd_save.Visible=nav2.cmd_exit.Visible=nav2.cmd_delete.Visible=nav2.cmd_add.Visible=nav2.cmd_copy.Visible=false;			
			PublicFunction.InitNav(this,vs2,nav2);
			nav2.ToolBar_Auto=false;
			nav2.TBarClick+=new ToolBarButtonClickEventHandler(nav2_TBarClick);
			vs2.AllowEditing=false;						
		}	
	
		private void  Init_CB()
		{
			string sql;			
			//Department
			sql=PublicFunction.GetDep(this.Tag+"");			
			vs.Cols["DEP_ID"].DataMap=PublicFunction.InitCBForVS(sql);	
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
			nav.Show_VS("DEP_ID=N'"+Dep.Get_Data("DEP_ID")+"'  and (VAC_BT is null or VAC_BT=0)");	
			show_text();
		}	
		private void Show_VS2()
		{			
			if(Dep.vs1.Row<=0)
			{
				vs2.Rows.Count=1;
				return;
			}
			string sql="";
			sql="DEP_ID=N'"+Dep.Get_Data("DEP_ID")+"' and (VAC_BT=0 or VAC_BT is null) ";			
			nav2.Show_VS(sql);				
		}	
		private void show_text()
		{
			TextBoxAndVS.D_GetDataFromVS(groupBox1,vs);
		}
		#endregion
		private void nav_TBarClick(object sender, ToolBarButtonClickEventArgs e)
		{
			if (e.Button.Equals(nav.cmd_refresh))
			{
				if(nav.wh!="")
					nav.ToolBar_Click(e);
				else
					nav.Show_VS("DEP_ID in "+T_String.DEP_ID(this.Tag)+"  and (VAC_BT is null or VAC_BT=0)");
				show_text();
				return;
			}
			nav.ToolBar_Click(e);
		}
		private void nav2_TBarClick(object sender, ToolBarButtonClickEventArgs e)
		{
			if (e.Button.Equals(nav2.cmd_refresh))
			{
				if(nav2.wh!="")
					nav2.ToolBar_Click(e);
				else
					nav2.Show_VS("DEP_ID in "+T_String.DEP_ID(this.Tag) +"  and (VAC_BT is null or VAC_BT=0) ");				
				return;
			}
			if (e.Button.Equals(nav2.cmd_search))
			{
				ArrayList a=new ArrayList();
				ArrayList b=new ArrayList();
				b.Add("SEQ_DT");
				a.Add("EMP_ID");
				a.Add("EMP_I1");
				a.Add("DEP_ID");
				
				frmSearch1 dlg=new frmSearch1(a,b,vs2,nav2);
				dlg.and="and (DEP_ID in "+T_String.DEP_ID(this.Tag)+")  and (VAC_BT is null or VAC_BT=0)";
				dlg.ShowDialog();
			}
			nav2.ToolBar_Click(e);
		}
		private void Depvs1_AfterRowColChange(object sender, RangeEventArgs e)
		{
			if(e.OldRange.r1!=e.NewRange.r1)
			{
				Show_VS();
				Show_VS2();
			}
		}

		private void vs_AfterRowColChange(object sender, RangeEventArgs e)
		{
			show_text();
		}
		private void vs_EnabledChanged(object sender, EventArgs e)
		{
			txt1.Text=vs.Cols[txt1.Tag+""].Caption;
			txt2.Text=vs.Cols[txt2.Tag+""].Caption;
			txt3.Text=vs.Cols[txt3.Tag+""].Caption;			
			txt5.Text=vs.Cols[txt5.Tag+""].Caption;
			txt6.Text=vs.Cols[txt6.Tag+""].Caption;
			txt7.Text=vs.Cols[txt7.Tag+""].Caption;
		}

		

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
				sql=" like N'%"+((TextBox)sender).Text+"%'";
				sql= ((TextBox)sender).Tag+sql+" and  (VAC_BT=0 or VAC_BT is null) and DEP_ID in (Select DEP_ID  from SYS_SECURITY_DEP"+
					" where MNU_ID="+this.Tag+" and ALL_BT=1 and USER_ID=N'"+PublicFunction.A_UserID+"')";					
				nav.Show_VS(sql);			
				show_text();				 	 
			}
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
				sql=" like N'%"+((TextBox)sender).Text+"%'";
				sql=f+sql+" and  (VAC_BT=0 or VAC_BT is null) and DEP_ID in (Select DEP_ID  from SYS_SECURITY_DEP"+
					" where MNU_ID="+this.Tag+" and ALL_BT=1 and USER_ID=N'"+PublicFunction.A_UserID+"')";					
				nav2.Show_VS(sql);							
			}
		}		
	}
}

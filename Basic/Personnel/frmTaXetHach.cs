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
using GP8000.Personnel.Report;

namespace GP8000.Personnel
{
	/// <summary>
	/// Summary description for frmTaVacateManager.
	/// </summary>
	public class frmTaXetHach : System.Windows.Forms.Form
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
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt3;
		private System.Windows.Forms.TextBox txt2;
		private System.Windows.Forms.TextBox txt1;
		private System.Windows.Forms.Button cmd_ok;
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
		private System.Windows.Forms.Button cmd_clear;
		private System.Windows.Forms.TextBox txt_NOT_DR;
		private C1.C1Excel.C1XLBook c1XLBook1;
		private System.Windows.Forms.Button cmd_all;
		private System.Windows.Forms.CheckBox ck;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cb_GRP_ID;
		private System.Windows.Forms.ComboBox cb_GRT_ID;
		private System.Windows.Forms.ComboBox cb_LEV_ID;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker dt;
		private System.Windows.Forms.CheckBox ck_GRP_ID;
		private System.Windows.Forms.CheckBox ck_GRT_ID;
		private System.Windows.Forms.CheckBox CK_LEV_ID;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaXetHach()
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
			this.CK_LEV_ID = new System.Windows.Forms.CheckBox();
			this.ck_GRT_ID = new System.Windows.Forms.CheckBox();
			this.ck_GRP_ID = new System.Windows.Forms.CheckBox();
			this.dt = new System.Windows.Forms.DateTimePicker();
			this.label6 = new System.Windows.Forms.Label();
			this.cb_LEV_ID = new System.Windows.Forms.ComboBox();
			this.cb_GRT_ID = new System.Windows.Forms.ComboBox();
			this.cb_GRP_ID = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cmd_all = new System.Windows.Forms.Button();
			this.cmd_clear = new System.Windows.Forms.Button();
			this.cmd_ok = new System.Windows.Forms.Button();
			this.txt_NOT_DR = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.c1XLBook1 = new C1.C1Excel.C1XLBook();
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
			this.panel7.SuspendLayout();
			this.panel10.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs1)).BeginInit();
			this.panel9.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
			this.panel5.SuspendLayout();
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
			this.Dep.Location = new System.Drawing.Point(0, 23);
			this.Dep.Name = "Dep";
			this.Dep.Size = new System.Drawing.Size(271, 651);
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
			this.panel2.Location = new System.Drawing.Point(0, 32);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(744, 644);
			this.panel2.TabIndex = 5;
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.panel8);
			this.panel6.Controls.Add(this.splitter1);
			this.panel6.Controls.Add(this.panel7);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel6.Location = new System.Drawing.Point(0, 152);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(744, 492);
			this.panel6.TabIndex = 1;
			// 
			// panel8
			// 
			this.panel8.Controls.Add(this.panel12);
			this.panel8.Controls.Add(this.panel11);
			this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel8.Location = new System.Drawing.Point(0, 244);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(744, 248);
			this.panel8.TabIndex = 2;
			// 
			// panel12
			// 
			this.panel12.Controls.Add(this.vs2);
			this.panel12.Controls.Add(this.nav2);
			this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel12.Location = new System.Drawing.Point(0, 28);
			this.panel12.Name = "panel12";
			this.panel12.Size = new System.Drawing.Size(744, 220);
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
			this.vs2.Location = new System.Drawing.Point(4, 36);
			this.vs2.Name = "vs2";
			this.vs2.Size = new System.Drawing.Size(736, 180);
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
			this.nav2.Size = new System.Drawing.Size(388, 32);
			this.nav2.TabIndex = 15;
			this.nav2.Tag = "";
			this.nav2.ToolBar_Auto = true;
			this.nav2.UserID = null;
			this.nav2.VisibleGrid = true;
			this.nav2.Where = null;
			// 
			// panel11
			// 
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
			this.ck.Location = new System.Drawing.Point(372, 4);
			this.ck.Name = "ck";
			this.ck.Size = new System.Drawing.Size(172, 20);
			this.ck.TabIndex = 38;
			this.ck.Text = "ck";
			// 
			// splitter1
			// 
			this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
			this.splitter1.Location = new System.Drawing.Point(0, 240);
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
			this.panel7.Size = new System.Drawing.Size(744, 240);
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
			this.panel10.Size = new System.Drawing.Size(369, 240);
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
			this.vs1.Size = new System.Drawing.Size(356, 208);
			this.vs1.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs1.TabIndex = 11;
			// 
			// splitter2
			// 
			this.splitter2.Location = new System.Drawing.Point(372, 0);
			this.splitter2.Name = "splitter2";
			this.splitter2.Size = new System.Drawing.Size(3, 240);
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
			this.panel9.Size = new System.Drawing.Size(372, 240);
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
			this.vs.Size = new System.Drawing.Size(364, 208);
			this.vs.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs.TabIndex = 10;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.Moccasin;
			this.panel5.Controls.Add(this.CK_LEV_ID);
			this.panel5.Controls.Add(this.ck_GRT_ID);
			this.panel5.Controls.Add(this.ck_GRP_ID);
			this.panel5.Controls.Add(this.dt);
			this.panel5.Controls.Add(this.label6);
			this.panel5.Controls.Add(this.cb_LEV_ID);
			this.panel5.Controls.Add(this.cb_GRT_ID);
			this.panel5.Controls.Add(this.cb_GRP_ID);
			this.panel5.Controls.Add(this.label4);
			this.panel5.Controls.Add(this.label3);
			this.panel5.Controls.Add(this.label1);
			this.panel5.Controls.Add(this.cmd_all);
			this.panel5.Controls.Add(this.cmd_clear);
			this.panel5.Controls.Add(this.cmd_ok);
			this.panel5.Controls.Add(this.txt_NOT_DR);
			this.panel5.Controls.Add(this.label2);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel5.Location = new System.Drawing.Point(0, 0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(744, 152);
			this.panel5.TabIndex = 0;
			// 
			// CK_LEV_ID
			// 
			this.CK_LEV_ID.Checked = true;
			this.CK_LEV_ID.CheckState = System.Windows.Forms.CheckState.Checked;
			this.CK_LEV_ID.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.CK_LEV_ID.Location = new System.Drawing.Point(308, 92);
			this.CK_LEV_ID.Name = "CK_LEV_ID";
			this.CK_LEV_ID.Size = new System.Drawing.Size(20, 24);
			this.CK_LEV_ID.TabIndex = 162;
			this.CK_LEV_ID.Tag = "N";
			this.CK_LEV_ID.CheckedChanged += new System.EventHandler(this.ck_GRP_ID_CheckedChanged);
			// 
			// ck_GRT_ID
			// 
			this.ck_GRT_ID.Checked = true;
			this.ck_GRT_ID.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ck_GRT_ID.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ck_GRT_ID.Location = new System.Drawing.Point(308, 64);
			this.ck_GRT_ID.Name = "ck_GRT_ID";
			this.ck_GRT_ID.Size = new System.Drawing.Size(20, 24);
			this.ck_GRT_ID.TabIndex = 161;
			this.ck_GRT_ID.Tag = "N";
			this.ck_GRT_ID.CheckedChanged += new System.EventHandler(this.ck_GRP_ID_CheckedChanged);
			// 
			// ck_GRP_ID
			// 
			this.ck_GRP_ID.Checked = true;
			this.ck_GRP_ID.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ck_GRP_ID.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ck_GRP_ID.Location = new System.Drawing.Point(308, 36);
			this.ck_GRP_ID.Name = "ck_GRP_ID";
			this.ck_GRP_ID.Size = new System.Drawing.Size(20, 24);
			this.ck_GRP_ID.TabIndex = 160;
			this.ck_GRP_ID.Tag = "N";
			this.ck_GRP_ID.CheckedChanged += new System.EventHandler(this.ck_GRP_ID_CheckedChanged);
			// 
			// dt
			// 
			this.dt.CustomFormat = "yyyy/MM/dd";
			this.dt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dt.Location = new System.Drawing.Point(108, 4);
			this.dt.Name = "dt";
			this.dt.Size = new System.Drawing.Size(196, 23);
			this.dt.TabIndex = 159;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 8);
			this.label6.Name = "label6";
			this.label6.TabIndex = 158;
			this.label6.Text = "label6";
			// 
			// cb_LEV_ID
			// 
			this.cb_LEV_ID.Location = new System.Drawing.Point(108, 88);
			this.cb_LEV_ID.Name = "cb_LEV_ID";
			this.cb_LEV_ID.Size = new System.Drawing.Size(196, 24);
			this.cb_LEV_ID.TabIndex = 157;
			this.cb_LEV_ID.Text = "comboBox3";
			// 
			// cb_GRT_ID
			// 
			this.cb_GRT_ID.Location = new System.Drawing.Point(108, 60);
			this.cb_GRT_ID.Name = "cb_GRT_ID";
			this.cb_GRT_ID.Size = new System.Drawing.Size(196, 24);
			this.cb_GRT_ID.TabIndex = 156;
			this.cb_GRT_ID.Text = "comboBox2";
			// 
			// cb_GRP_ID
			// 
			this.cb_GRP_ID.Location = new System.Drawing.Point(108, 32);
			this.cb_GRP_ID.Name = "cb_GRP_ID";
			this.cb_GRP_ID.Size = new System.Drawing.Size(196, 24);
			this.cb_GRP_ID.TabIndex = 155;
			this.cb_GRP_ID.Text = "comboBox1";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 92);
			this.label4.Name = "label4";
			this.label4.TabIndex = 154;
			this.label4.Text = "label4";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 64);
			this.label3.Name = "label3";
			this.label3.TabIndex = 153;
			this.label3.Text = "label3";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 36);
			this.label1.Name = "label1";
			this.label1.TabIndex = 152;
			this.label1.Text = "label1";
			// 
			// cmd_all
			// 
			this.cmd_all.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cmd_all.BackColor = System.Drawing.Color.Moccasin;
			this.cmd_all.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_all.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmd_all.Location = new System.Drawing.Point(4, 116);
			this.cmd_all.Name = "cmd_all";
			this.cmd_all.Size = new System.Drawing.Size(108, 32);
			this.cmd_all.TabIndex = 151;
			this.cmd_all.Text = "ALL";
			this.cmd_all.Click += new System.EventHandler(this.cmd_all_Click);
			// 
			// cmd_clear
			// 
			this.cmd_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cmd_clear.BackColor = System.Drawing.Color.Moccasin;
			this.cmd_clear.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_clear.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmd_clear.Location = new System.Drawing.Point(632, 116);
			this.cmd_clear.Name = "cmd_clear";
			this.cmd_clear.Size = new System.Drawing.Size(108, 32);
			this.cmd_clear.TabIndex = 10;
			this.cmd_clear.Text = "Clear";
			this.cmd_clear.Click += new System.EventHandler(this.cmd_clear_Click);
			// 
			// cmd_ok
			// 
			this.cmd_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cmd_ok.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_ok.Location = new System.Drawing.Point(324, 116);
			this.cmd_ok.Name = "cmd_ok";
			this.cmd_ok.Size = new System.Drawing.Size(108, 32);
			this.cmd_ok.TabIndex = 9;
			this.cmd_ok.Text = "OK";
			this.cmd_ok.Click += new System.EventHandler(this.cmd_ok_Click);
			// 
			// txt_NOT_DR
			// 
			this.txt_NOT_DR.BackColor = System.Drawing.SystemColors.Window;
			this.txt_NOT_DR.Location = new System.Drawing.Point(404, 4);
			this.txt_NOT_DR.MaxLength = 100;
			this.txt_NOT_DR.Multiline = true;
			this.txt_NOT_DR.Name = "txt_NOT_DR";
			this.txt_NOT_DR.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txt_NOT_DR.Size = new System.Drawing.Size(332, 108);
			this.txt_NOT_DR.TabIndex = 8;
			this.txt_NOT_DR.Tag = "";
			this.txt_NOT_DR.Text = "";
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label2.Location = new System.Drawing.Point(324, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(92, 23);
			this.label2.TabIndex = 133;
			this.label2.Tag = "";
			this.label2.Text = "VAC_ID";
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
			this.panel3.Size = new System.Drawing.Size(744, 32);
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
			this.label5.Size = new System.Drawing.Size(736, 32);
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
			this.panel4.Size = new System.Drawing.Size(8, 32);
			this.panel4.TabIndex = 10;
			// 
			// frmTaXetHach
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(1020, 676);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.c1CommandDock1);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaXetHach";
			this.Text = "frmTaXetHach";
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
			this.panel7.ResumeLayout(false);
			this.panel10.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs1)).EndInit();
			this.panel9.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			this.panel5.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaVacateManager_Load(object sender, System.EventArgs e)
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
					GP8000.Personnel.Report.ReportFromVS rpt=new GP8000.Personnel.Report.ReportFromVS();
					rpt.RPT2(c1XLBook1,vs2,mnu1.MenuItems[mnu1.MenuItems.IndexOf((MenuItem)sender)].Text,"STD_HR_10");					
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
			nav2.cmd_delete.Visible=nav2.cmd_add.Visible=nav2.cmd_copy.Visible=false;			
			PublicFunction.InitNav(this,vs2,nav2);					
			vs2.Cols.Frozen=vs.Cols["EMP_NM"].Index;
			nav2.ToolBar_Auto=false;
			nav2.TBarClick+=new ToolBarButtonClickEventHandler(nav2_TBarClick);
		}			
		private void  Init_CB()
		{
			string sql;			
			//Department
			sql=PublicFunction.GetDep(this.Tag+"");			
			vs.Cols["DEP_ID"].DataMap=PublicFunction.InitCBForVS(sql);	
			vs1.Cols["DEP_ID"].DataMap=PublicFunction.InitCBForVS(sql);	
			vs2.Cols["DEP_ID"].DataMap=PublicFunction.InitCBForVS(sql);	
			
			
			//Position
			sql="Select POS_ID,POS_NM from FILA07A";			
			vs2.Cols["POS_ID"].DataMap=PublicFunction.InitCBForVS(sql);		
	
			sql="Select GRP_ID,GRP_NM from FILA08A";	
			PublicFunction.InitCB(cb_GRP_ID,sql,false);
			vs.Cols["GRP_ID"].DataMap=PublicFunction.InitCBForVS(sql);		
			vs1.Cols["GRP_ID"].DataMap=PublicFunction.InitCBForVS(sql);		
			vs2.Cols["GRP_ID"].DataMap=PublicFunction.InitCBForVS(sql);		

			sql="Select GRT_ID,GRT_NM from FILA09A";	
			PublicFunction.InitCB(cb_GRT_ID,sql,false);
			vs.Cols["GRT_ID"].DataMap=PublicFunction.InitCBForVS(sql);		
			vs1.Cols["GRT_ID"].DataMap=PublicFunction.InitCBForVS(sql);		
			vs2.Cols["GRT_ID"].DataMap=PublicFunction.InitCBForVS(sql);		

			sql="Select LEV_ID,LEV_NM from FILA19A";	
			PublicFunction.InitCB(cb_LEV_ID,sql,false);
			vs.Cols["LEV_ID"].DataMap=PublicFunction.InitCBForVS(sql);		
			vs1.Cols["LEV_ID"].DataMap=PublicFunction.InitCBForVS(sql);		
			vs2.Cols["LEV_ID"].DataMap=PublicFunction.InitCBForVS(sql);	
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
			sql="DEP_ID=N'"+Dep.Get_Data("DEP_ID")+"' and (VAC_BT=0 or VAC_BT is null) ";			
			nav2.Show_VS(sql);				
		}	
		#endregion
		#region  event
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
				sql=sql+" and  (VAC_BT=0 or VAC_BT is null) and DEP_ID in (Select DEP_ID  from SYS_SECURITY_DEP"+
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
				sql=" like N'%"+((TextBox)sender).Text+"%'";
				sql=f+sql+" and  (DEL_BT=0 or DEL_BT is null) and DEP_ID in (Select DEP_ID  from SYS_SECURITY_DEP"+
					" where MNU_ID="+this.Tag+" and ALL_BT=1 and USER_ID=N'"+PublicFunction.A_UserID+"')";									
				nav2.Show_VS(sql);						
				
			}
		}
		#endregion		
		#region button
		private void cmd_ok_Click(object sender, System.EventArgs e)
		{				
			string sql1="";
			SqlConnection con=new SqlConnection(PublicFunction.C_con.ConnectionString);
			con.Open();				
			for(int i=vs1.Rows.Count-1;i>0;i--)
			{
				SqlTransaction tran=con.BeginTransaction();				
				try
				{
					string sql="";		
					string SEQ_NO=T_String.GetMax("MAX(SEQ_NO)","FILB07A")+"";				
					sql="Insert Into FILB07A(SEQ_NO,SEQ_DT,EMP_ID,GRT_I1,GRP_I1,LEV_I1,GRP_ID,GRP_BT,GRT_ID,GRT_BT,LEV_ID,LEV_BT,REM_DR,"
						+"BLT_NM,BLT_DT) values ("+SEQ_NO+","
						+"'"+DateTime.Parse(dt.Value+"").ToString("yyyy/MM/dd")+"',"
						+"N'"+vs1.Rows[i]["EMP_ID"]+"',"
						+"N'"+vs1.Rows[i]["GRP_ID"]+"',"
						+"N'"+vs1.Rows[i]["GRT_ID"]+"',"
						+"N'"+vs1.Rows[i]["LEV_ID"]+"',";
					if(ck_GRP_ID.Checked)
						sql+="N'"+cb_GRP_ID.SelectedValue+"',1,";
					else
						sql+="N'"+vs1.Rows[i]["GRP_ID"]+"',0,";

					if(ck_GRT_ID.Checked)
						sql+="N'"+cb_GRT_ID.SelectedValue+"',1,";
					else
						sql+="N'"+vs1.Rows[i]["GRT_ID"]+"',0,";

					if(CK_LEV_ID.Checked)
						sql+="N'"+cb_LEV_ID.SelectedValue+"',1,";
					else
						sql+="N'"+vs1.Rows[i]["LEV_ID"]+"',0,";
					sql+="N'"+txt_NOT_DR.Text+"',";
					sql+="N'"+PublicFunction.A_UserID+"','"+T_String.GetDate().ToString("yyyy/MM/dd HH:mm")+"')";
					SqlCommand cmd=new SqlCommand(sql,con,tran);
					cmd.ExecuteNonQuery();													

					sql="Update FILB01A SET ";
					if(ck_GRP_ID.Checked)
						sql+="GRP_ID=N'"+cb_GRP_ID.SelectedValue+"',";
					else
						sql+="GRP_ID=N'"+vs1.Rows[i]["GRP_ID"]+"',";

					if(ck_GRT_ID.Checked)
						sql+="GRT_ID=N'"+cb_GRT_ID.SelectedValue+"',";
					else
						sql+="GRT_ID=N'"+vs1.Rows[i]["GRT_ID"]+"',";

					if(CK_LEV_ID.Checked)
						sql+="LEV_ID=N'"+cb_LEV_ID.SelectedValue+"'";
					else
						sql+="LEV_ID=N'"+vs1.Rows[i]["LEV_ID"]+"'";
					sql+=" where EMP_ID=N'"+vs1.Rows[i]["EMP_ID"]+"'";
					cmd=new SqlCommand(sql,con,tran);
					cmd.ExecuteNonQuery();	

					tran.Commit();
					if(sql1!="") sql1+=",";
					sql1+=""+SEQ_NO+"";
					vs1.RemoveItem(i);
				}				
				catch(Exception ex)
				{
					tran.Rollback();
					MessageBox.Show(ex.Message);
				}
			}			
			if(sql1!="")
			{
				nav2.Show_VS("SEQ_NO in ("+sql1+")");
				vs.Rows.Count=1;
			}
			vs.Rows.Count=1;
			MessageBox.Show(PublicFunction.L_Get_Msg("Staff",1));
			con.Close();				
		}		
		#endregion
		#region Tbar
		private void nav2_TBarClick(object sender, ToolBarButtonClickEventArgs e)
		{
			if (e.Button.Equals(nav.cmd_refresh))
			{
				if(nav.wh!="")
					nav.ToolBar_Click(e);
				else
					nav.Show_VS("DEP_ID in "+T_String.DEP_ID(this.Tag)+"  and (VAC_BT is null or VAC_BT=0)");				
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
			nav.ToolBar_Click(e);
		}
		#endregion

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
		}

		private void ck_GRP_ID_CheckedChanged(object sender, System.EventArgs e)
		{
			cb_GRP_ID.Enabled=ck_GRP_ID.Checked;
			cb_GRT_ID.Enabled=ck_GRT_ID.Checked;
			cb_LEV_ID.Enabled=CK_LEV_ID.Checked;
		}

		
	}
}

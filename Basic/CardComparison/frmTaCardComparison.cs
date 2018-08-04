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
namespace GP8000.CardComparison
{
	/// <summary>
	/// Summary description for frmTaCardComparison.
	/// </summary>
	public class frmTaCardComparison : System.Windows.Forms.Form
	{
		private C1.C1Excel.C1XLBook c1XLBook1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Splitter splitter2;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Panel panel10;
		private System.Windows.Forms.Panel panel16;
		private C1.Win.C1FlexGrid.C1FlexGrid vs3;
		private System.Windows.Forms.Panel panel15;
		private System.Windows.Forms.Button cmd4;
		private System.Windows.Forms.Button cmd3;
		private Navigator1._0.NavigatorAuto nav3;
		private System.Windows.Forms.Splitter splitter3;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.Panel panel14;
		private C1.Win.C1FlexGrid.C1FlexGrid vs2;
		private System.Windows.Forms.Panel panel13;
		private System.Windows.Forms.Button cmd5;
		private System.Windows.Forms.Button cmd2;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel12;
		private C1.Win.C1FlexGrid.C1FlexGrid vs1;
		private System.Windows.Forms.Panel panel11;
		private System.Windows.Forms.Button cmd1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel3;
		private Navigator1._0.NavigatorAuto nav2;
		private Navigator1._0.NavigatorAuto nav1;
		private Navigator1._0.NavigatorAuto nav;
		private C1.Win.C1Command.C1CommandDock c1CommandDock1;
		private C1.Win.C1Command.C1DockingTab c1DockingTab1;
		private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage1;
		private C1.Win.C1FlexGrid.C1FlexGrid vs;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaCardComparison()
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
			this.c1XLBook1 = new C1.C1Excel.C1XLBook();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.splitter2 = new System.Windows.Forms.Splitter();
			this.panel7 = new System.Windows.Forms.Panel();
			this.panel8 = new System.Windows.Forms.Panel();
			this.panel10 = new System.Windows.Forms.Panel();
			this.panel16 = new System.Windows.Forms.Panel();
			this.vs3 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.panel15 = new System.Windows.Forms.Panel();
			this.cmd4 = new System.Windows.Forms.Button();
			this.cmd3 = new System.Windows.Forms.Button();
			this.nav3 = new Navigator1._0.NavigatorAuto();
			this.splitter3 = new System.Windows.Forms.Splitter();
			this.panel9 = new System.Windows.Forms.Panel();
			this.panel14 = new System.Windows.Forms.Panel();
			this.vs2 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.panel13 = new System.Windows.Forms.Panel();
			this.cmd5 = new System.Windows.Forms.Button();
			this.cmd2 = new System.Windows.Forms.Button();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel12 = new System.Windows.Forms.Panel();
			this.vs1 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.panel11 = new System.Windows.Forms.Panel();
			this.cmd1 = new System.Windows.Forms.Button();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.nav2 = new Navigator1._0.NavigatorAuto();
			this.nav1 = new Navigator1._0.NavigatorAuto();
			this.nav = new Navigator1._0.NavigatorAuto();
			this.c1CommandDock1 = new C1.Win.C1Command.C1CommandDock();
			this.c1DockingTab1 = new C1.Win.C1Command.C1DockingTab();
			this.c1DockingTabPage1 = new C1.Win.C1Command.C1DockingTabPage();
			this.vs = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel8.SuspendLayout();
			this.panel10.SuspendLayout();
			this.panel16.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs3)).BeginInit();
			this.panel15.SuspendLayout();
			this.panel9.SuspendLayout();
			this.panel14.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs2)).BeginInit();
			this.panel13.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel12.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs1)).BeginInit();
			this.panel11.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandDock1)).BeginInit();
			this.c1CommandDock1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).BeginInit();
			this.c1DockingTab1.SuspendLayout();
			this.c1DockingTabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.c1CommandDock1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(936, 552);
			this.panel1.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.panel5);
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(200, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(736, 552);
			this.panel2.TabIndex = 1;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.splitter2);
			this.panel5.Controls.Add(this.panel7);
			this.panel5.Controls.Add(this.splitter1);
			this.panel5.Controls.Add(this.panel6);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(0, 36);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(736, 448);
			this.panel5.TabIndex = 2;
			// 
			// splitter2
			// 
			this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
			this.splitter2.Location = new System.Drawing.Point(733, 0);
			this.splitter2.Name = "splitter2";
			this.splitter2.Size = new System.Drawing.Size(3, 448);
			this.splitter2.TabIndex = 3;
			this.splitter2.TabStop = false;
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.panel8);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel7.Location = new System.Drawing.Point(251, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(485, 448);
			this.panel7.TabIndex = 2;
			// 
			// panel8
			// 
			this.panel8.Controls.Add(this.panel10);
			this.panel8.Controls.Add(this.splitter3);
			this.panel8.Controls.Add(this.panel9);
			this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel8.Location = new System.Drawing.Point(0, 0);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(485, 448);
			this.panel8.TabIndex = 0;
			// 
			// panel10
			// 
			this.panel10.Controls.Add(this.panel16);
			this.panel10.Controls.Add(this.panel15);
			this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel10.Location = new System.Drawing.Point(231, 0);
			this.panel10.Name = "panel10";
			this.panel10.Size = new System.Drawing.Size(254, 448);
			this.panel10.TabIndex = 2;
			// 
			// panel16
			// 
			this.panel16.Controls.Add(this.vs3);
			this.panel16.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel16.Location = new System.Drawing.Point(0, 40);
			this.panel16.Name = "panel16";
			this.panel16.Size = new System.Drawing.Size(254, 408);
			this.panel16.TabIndex = 11;
			// 
			// vs3
			// 
			this.vs3.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs3.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vs3.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs3.Location = new System.Drawing.Point(0, 0);
			this.vs3.Name = "vs3";
			this.vs3.Size = new System.Drawing.Size(254, 408);
			this.vs3.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs3.TabIndex = 9;
			// 
			// panel15
			// 
			this.panel15.Controls.Add(this.cmd4);
			this.panel15.Controls.Add(this.cmd3);
			this.panel15.Controls.Add(this.nav3);
			this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel15.Location = new System.Drawing.Point(0, 0);
			this.panel15.Name = "panel15";
			this.panel15.Size = new System.Drawing.Size(254, 40);
			this.panel15.TabIndex = 10;
			// 
			// cmd4
			// 
			this.cmd4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd4.Location = new System.Drawing.Point(188, 4);
			this.cmd4.Name = "cmd4";
			this.cmd4.Size = new System.Drawing.Size(28, 32);
			this.cmd4.TabIndex = 14;
			this.cmd4.Tag = "N";
			this.cmd4.Text = "<<";
			// 
			// cmd3
			// 
			this.cmd3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd3.Location = new System.Drawing.Point(4, 4);
			this.cmd3.Name = "cmd3";
			this.cmd3.Size = new System.Drawing.Size(132, 32);
			this.cmd3.TabIndex = 11;
			this.cmd3.Text = "cmd3";
			// 
			// nav3
			// 
			this.nav3.BackColor = System.Drawing.SystemColors.Control;
			this.nav3.Connection = null;
			this.nav3.ConnectionDel = null;
			this.nav3.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.nav3.form = null;
			this.nav3.FormName = null;
			this.nav3.Grid = null;
			this.nav3.History = false;
			this.nav3.IsNull = true;
			this.nav3.Language = "EN";
			this.nav3.Location = new System.Drawing.Point(144, 4);
			this.nav3.MSG_Exit = false;
			this.nav3.MulltiDel = false;
			this.nav3.Name = "nav3";
			this.nav3.Security = 0;
			this.nav3.ShowPopupMenu = true;
			this.nav3.Size = new System.Drawing.Size(36, 32);
			this.nav3.TabIndex = 13;
			this.nav3.ToolBar_Auto = true;
			this.nav3.UserID = null;
			this.nav3.VisibleGrid = true;
			this.nav3.Where = null;
			// 
			// splitter3
			// 
			this.splitter3.Location = new System.Drawing.Point(228, 0);
			this.splitter3.Name = "splitter3";
			this.splitter3.Size = new System.Drawing.Size(3, 448);
			this.splitter3.TabIndex = 1;
			this.splitter3.TabStop = false;
			// 
			// panel9
			// 
			this.panel9.Controls.Add(this.panel14);
			this.panel9.Controls.Add(this.panel13);
			this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel9.Location = new System.Drawing.Point(0, 0);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(228, 448);
			this.panel9.TabIndex = 0;
			// 
			// panel14
			// 
			this.panel14.Controls.Add(this.vs2);
			this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel14.Location = new System.Drawing.Point(0, 40);
			this.panel14.Name = "panel14";
			this.panel14.Size = new System.Drawing.Size(228, 408);
			this.panel14.TabIndex = 13;
			// 
			// vs2
			// 
			this.vs2.AllowEditing = false;
			this.vs2.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs2.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vs2.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs2.Location = new System.Drawing.Point(0, 0);
			this.vs2.Name = "vs2";
			this.vs2.Size = new System.Drawing.Size(228, 408);
			this.vs2.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs2.TabIndex = 8;
			// 
			// panel13
			// 
			this.panel13.Controls.Add(this.cmd5);
			this.panel13.Controls.Add(this.cmd2);
			this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel13.Location = new System.Drawing.Point(0, 0);
			this.panel13.Name = "panel13";
			this.panel13.Size = new System.Drawing.Size(228, 40);
			this.panel13.TabIndex = 12;
			// 
			// cmd5
			// 
			this.cmd5.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd5.Location = new System.Drawing.Point(120, 4);
			this.cmd5.Name = "cmd5";
			this.cmd5.Size = new System.Drawing.Size(108, 32);
			this.cmd5.TabIndex = 11;
			this.cmd5.Text = "button1";
			// 
			// cmd2
			// 
			this.cmd2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd2.Location = new System.Drawing.Point(4, 4);
			this.cmd2.Name = "cmd2";
			this.cmd2.Size = new System.Drawing.Size(108, 32);
			this.cmd2.TabIndex = 10;
			this.cmd2.Text = "cmd2";
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(248, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(3, 448);
			this.splitter1.TabIndex = 1;
			this.splitter1.TabStop = false;
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.panel12);
			this.panel6.Controls.Add(this.panel11);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel6.Location = new System.Drawing.Point(0, 0);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(248, 448);
			this.panel6.TabIndex = 0;
			// 
			// panel12
			// 
			this.panel12.Controls.Add(this.vs1);
			this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel12.Location = new System.Drawing.Point(0, 40);
			this.panel12.Name = "panel12";
			this.panel12.Size = new System.Drawing.Size(248, 408);
			this.panel12.TabIndex = 9;
			// 
			// vs1
			// 
			this.vs1.AllowEditing = false;
			this.vs1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs1.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vs1.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs1.Location = new System.Drawing.Point(0, 0);
			this.vs1.Name = "vs1";
			this.vs1.Size = new System.Drawing.Size(248, 408);
			this.vs1.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs1.TabIndex = 7;
			// 
			// panel11
			// 
			this.panel11.Controls.Add(this.cmd1);
			this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel11.Location = new System.Drawing.Point(0, 0);
			this.panel11.Name = "panel11";
			this.panel11.Size = new System.Drawing.Size(248, 40);
			this.panel11.TabIndex = 8;
			// 
			// cmd1
			// 
			this.cmd1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd1.Location = new System.Drawing.Point(4, 4);
			this.cmd1.Name = "cmd1";
			this.cmd1.Size = new System.Drawing.Size(132, 32);
			this.cmd1.TabIndex = 9;
			this.cmd1.Text = "cmd1";
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.label6);
			this.panel4.Controls.Add(this.label5);
			this.panel4.Controls.Add(this.label4);
			this.panel4.Controls.Add(this.label3);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Controls.Add(this.label1);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel4.Location = new System.Drawing.Point(0, 484);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(736, 68);
			this.panel4.TabIndex = 1;
			// 
			// label6
			// 
			this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label6.ForeColor = System.Drawing.Color.Blue;
			this.label6.Location = new System.Drawing.Point(348, 8);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(124, 24);
			this.label6.TabIndex = 6;
			this.label6.Tag = "N";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label5.ForeColor = System.Drawing.Color.Blue;
			this.label5.Location = new System.Drawing.Point(96, 8);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(124, 24);
			this.label5.TabIndex = 5;
			this.label5.Tag = "N";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(248, 12);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 20);
			this.label4.TabIndex = 4;
			this.label4.Text = "label4";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 12);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "label3";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.BackColor = System.Drawing.SystemColors.ControlText;
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label2.Location = new System.Drawing.Point(532, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(196, 24);
			this.label2.TabIndex = 1;
			this.label2.Tag = "N";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.BackColor = System.Drawing.SystemColors.ControlText;
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(332, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(196, 24);
			this.label1.TabIndex = 0;
			this.label1.Tag = "N";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.nav2);
			this.panel3.Controls.Add(this.nav1);
			this.panel3.Controls.Add(this.nav);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(736, 36);
			this.panel3.TabIndex = 0;
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
			this.nav2.Location = new System.Drawing.Point(564, 4);
			this.nav2.MSG_Exit = false;
			this.nav2.MulltiDel = false;
			this.nav2.Name = "nav2";
			this.nav2.Security = 0;
			this.nav2.ShowPopupMenu = false;
			this.nav2.Size = new System.Drawing.Size(36, 32);
			this.nav2.TabIndex = 14;
			this.nav2.ToolBar_Auto = true;
			this.nav2.UserID = null;
			this.nav2.Visible = false;
			this.nav2.VisibleGrid = true;
			this.nav2.Where = null;
			// 
			// nav1
			// 
			this.nav1.BackColor = System.Drawing.SystemColors.Control;
			this.nav1.Connection = null;
			this.nav1.ConnectionDel = null;
			this.nav1.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.nav1.form = null;
			this.nav1.FormName = null;
			this.nav1.Grid = null;
			this.nav1.History = false;
			this.nav1.IsNull = true;
			this.nav1.Language = "EN";
			this.nav1.Location = new System.Drawing.Point(496, 4);
			this.nav1.MSG_Exit = false;
			this.nav1.MulltiDel = false;
			this.nav1.Name = "nav1";
			this.nav1.Security = 0;
			this.nav1.ShowPopupMenu = false;
			this.nav1.Size = new System.Drawing.Size(36, 32);
			this.nav1.TabIndex = 12;
			this.nav1.ToolBar_Auto = true;
			this.nav1.UserID = null;
			this.nav1.Visible = false;
			this.nav1.VisibleGrid = true;
			this.nav1.Where = null;
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
			this.nav.Location = new System.Drawing.Point(4, 4);
			this.nav.MSG_Exit = false;
			this.nav.MulltiDel = false;
			this.nav.Name = "nav";
			this.nav.Security = 0;
			this.nav.ShowPopupMenu = false;
			this.nav.Size = new System.Drawing.Size(472, 32);
			this.nav.TabIndex = 8;
			this.nav.ToolBar_Auto = true;
			this.nav.UserID = null;
			this.nav.VisibleGrid = true;
			this.nav.Where = null;
			// 
			// c1CommandDock1
			// 
			this.c1CommandDock1.Controls.Add(this.c1DockingTab1);
			this.c1CommandDock1.Dock = System.Windows.Forms.DockStyle.Left;
			this.c1CommandDock1.Id = 1;
			this.c1CommandDock1.Location = new System.Drawing.Point(0, 0);
			this.c1CommandDock1.Name = "c1CommandDock1";
			this.c1CommandDock1.Size = new System.Drawing.Size(200, 552);
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
			this.c1DockingTab1.Size = new System.Drawing.Size(200, 552);
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
			this.c1DockingTabPage1.Size = new System.Drawing.Size(195, 550);
			this.c1DockingTabPage1.TabIndex = 0;
			this.c1DockingTabPage1.Text = "Page1";
			// 
			// vs
			// 
			this.vs.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vs.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs.Location = new System.Drawing.Point(0, 23);
			this.vs.Name = "vs";
			this.vs.Size = new System.Drawing.Size(195, 527);
			this.vs.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs.TabIndex = 6;
			// 
			// frmTaCardComparison
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(936, 552);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaCardComparison";
			this.Text = "frmTaCardComparison";
			this.Load += new System.EventHandler(this.frmTaCardComparison_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.panel10.ResumeLayout(false);
			this.panel16.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs3)).EndInit();
			this.panel15.ResumeLayout(false);
			this.panel9.ResumeLayout(false);
			this.panel14.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs2)).EndInit();
			this.panel13.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel12.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs1)).EndInit();
			this.panel11.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandDock1)).EndInit();
			this.c1CommandDock1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).EndInit();
			this.c1DockingTab1.ResumeLayout(false);
			this.c1DockingTabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaCardComparison_Load(object sender, System.EventArgs e)
		{
			Init_VS();
			Init_VS1();
			Init_VS2();
			Init_VS3();
			//Init_Menu();
			Basic.Function.PublicFunction.L_Init_Label(this);			
		}
		#region Init
		private void Init_VS()
		{
			PublicFunction.InitNav(this,vs,nav);
			nav.Show_VS(" 1=1 order by TRN_DT  DESC");			
			vs.Cols["ATT_DT"].Format=PublicFunction.GetOption("DATE");
			vs.Cols["INN_NO"].ComboList="In1|In2|In3|In4";
			System.Data.SqlClient.SqlConnection con=PublicFunction.connect(PublicFunction.DTGP_server,PublicFunction.DTGP_database
				,PublicFunction.DTGP_username ,PublicFunction.DTGP_password);
			string sql="Select SHI_ID from FILC02A";
			Func.RecordSet rs=new Func.RecordSet(sql,con);			
			sql="";
			for(int i=0;i<rs.rows;i++)
			{
				if (sql!="") sql+="|";
				sql+=rs.record(i,0);
			}
			vs.Cols["SHI_ID"].ComboList=sql;
			this.vs.AfterRowColChange += new C1.Win.C1FlexGrid.RangeEventHandler(this.vs_AfterRowColChange);
			nav.ToolBar_Auto=false;
			nav.TBarClick+=new ToolBarButtonClickEventHandler(nav_TBarClick);
			con.Close();
		}
		private void Init_VS1()
		{
			PublicFunction.InitNav(this,vs1,nav1);
			vs1.Cols["ATT_TM"].Format="##:##";
			Show_vs1();
		}
		private void Init_VS2()
		{
			PublicFunction.InitNav(this,vs2,nav2);	
			vs2.Cols["WOK_TM"].Format="##:##";
			Show_vs2();
		}
		private void Init_VS3()
		{			
			PublicFunction.InitNav(this,vs3,nav3);		
			vs3.Cols["ATT_TM"].Format="##:##";
			vs3.AfterEdit+=new C1.Win.C1FlexGrid.RowColEventHandler(vs3_AfterEdit);
		}
		#endregion

		#region Init Menu
//		
//		private void Init_Menu()
//		{		
//			mnu1=new ContextMenu();
//			nav.cmd_report.Style=ToolBarButtonStyle.DropDownButton;
//			nav.cmd_report.DropDownMenu =mnu1;
//				
//			int n=T_String.IsNullTo0(T_String.GetDataFromSQL("Count(*)","SYS_LABEL_PMENU","NAME=N'"+this.Name+"'"));
//			Init_ReportSTD(n);		
//			
//
//			Init_LabelForMenu();		
//		}
//
//		private void Init_ReportSTD(int n)
//		{				
//			for (int i=0;i<n;i++)
//			{		
//				mnu1.MenuItems.Add("a");
//			}	
//			for (int i=0;i<mnu1.MenuItems.Count;i++)
//			{
//				mnu1.MenuItems[i].Click+=new EventHandler(menu_Click);
//			}
//		}		
//
//		private void Init_LabelForMenu()
//		{				
//			for(int i=0;i<mnu1.MenuItems.Count;i++)
//			{
//				mnu1.MenuItems[i].Text=PublicFunction.L_Get_PopMenu(this.Name,i);
//			}
//		}
		#endregion
		#region showvs
		private void showdata()
		{
			Show_vs1();
			Show_vs2();
			vs3.Rows.Count=1;
		}

		private void Show_vs1()
		{
			string st=vs.Rows[vs.Row].UserData+"";
			if (vs.Row<1 || !nav.State || vs.Rows[vs.Row].UserData+""=="2" || vs.Rows[vs.Row].UserData+""=="")
			{
				vs1.Rows.Count=1;
				return;
			}				
			string sql="ATT_DT='"+
				DateTime.Parse(vs.Rows[vs.Row]["ATT_DT"]+"").ToString("yyyy/MM/dd")+"' and INN_NO=N'"+
				vs.Rows[vs.Row]["INN_NO"]+"' and SHI_ID=N'"+vs.Rows[vs.Row]["SHI_ID"]+"' ORDER BY DEP_ID ";
			nav1.Show_VS(sql);
			label5.Text=vs1.Rows.Count-1 +"";
			label1.Text=vs.Rows[vs.Row]["BLT_NM"]+"";
			label2.Text=vs.Rows[vs.Row]["BLT_DT"]+"";
		}
		private void Show_vs2()
		{
			if (vs.Row<1 || !nav.State || vs.Rows[vs.Row].UserData+""=="2" || vs.Rows[vs.Row].UserData+""=="")
			{
				vs2.Rows.Count=1;
				return;
			}				
			string sql="ATT_DT='"+
				DateTime.Parse(vs.Rows[vs.Row]["ATT_DT"]+"").ToString("yyyy/MM/dd")+"' and INN_NO=N'"+
				vs.Rows[vs.Row]["INN_NO"]+"' and SHI_ID=N'"+vs.Rows[vs.Row]["SHI_ID"]+"' and WOK_TM>0 ORDER BY DEP_ID ";
			nav2.Show_VS(sql);
			label6.Text=vs2.Rows.Count-1 +"";
		}
		private void Show_vs3()
		{
			if (vs.Row<1 || !nav.State || vs.Rows[vs.Row].UserData+""=="2" || vs.Rows[vs.Row].UserData+""=="")
			{
				vs3.Rows.Count=1;
				return;
			}				
			string sql="ATT_DT='"+
				DateTime.Parse(vs.Rows[vs.Row]["ATT_DT"]+"").ToString("yyyy/MM/dd")+"' and INN_NO=N'"+
				vs.Rows[vs.Row]["INN_NO"]+"' and SHI_ID=N'"+vs.Rows[vs.Row]["SHI_ID"]
				+"' and (WOK_TM is null or WOK_TM=0) ORDER BY DEP_ID ";
			nav3.Show_VS(sql);			
		}

		#endregion
		#region TBarClick
		private void nav_TBarClick(object sender, ToolBarButtonClickEventArgs e)
		{	
			if (e.Button.Equals(nav.cmd_delete))
			{	
				string sql="Delete from FILE01B where ATT_DT='"+
					DateTime.Parse(vs.Rows[vs.Row]["ATT_DT"]+"").ToString("yyyy/MM/dd")+"' and INN_NO=N'"+
					vs.Rows[vs.Row]["INN_NO"]+"' and SHI_ID=N'"+vs.Rows[vs.Row]["SHI_ID"]+"'";				
				nav.ToolBar_Click(e);				
				if (nav.Msg_Delete)
					PublicFunction.SQL_Execute(sql);	
				return;
			}

			nav.ToolBar_Click(e);
			if (e.Button.Equals(nav.cmd_add))
			{
				vs.Rows[vs.Rows.Count-1]["BLT_NM"]=PublicFunction.A_UserID;				
				vs.Rows[vs.Rows.Count-1]["BLT_DT"]=T_String.GetDate().ToString("yyyy/MM/dd HH:mm");
				vs.Rows[vs.Rows.Count-1]["ATT_DT"]=T_String.GetDate().ToString("yyyy/MM/dd");
				vs.Rows[vs.Rows.Count-1]["ONN_NO"]="In1";
				label1.Text=vs.Rows[vs.Rows.Count-1]["BLT_NM"]+"";
				label2.Text=vs.Rows[vs.Rows.Count-1]["BLT_DT"]+"";
			}			
			if (e.Button.Equals(nav.cmd_refresh))
			{					
				showdata();
			}
			
			if (e.Button.Equals(nav.cmd_search))
			{					
				ArrayList a=new ArrayList();
				ArrayList b=new ArrayList();
				b.Add("ATT_DT");
				a.Add("SHI_ID");
				a.Add("INN_NO");
				Basic.Form.frmSearch1 dlg=new Basic.Form.frmSearch1(a,b,vs,nav);
				dlg.ShowDialog();
			}
		}
		#endregion
		#region Event
//		private void cmd1_Click(object sender, System.EventArgs e)
//		{
//			if (vs.Row>0 && vs.Rows[vs.Row].UserData+""!="2")
//			{
//				frmTaTransfer dlg=new frmTaTransfer(vs,vs1,nav1);
//				dlg.ShowDialog();
//				label5.Text=vs1.Rows.Count-1 +"";
//			}
//		}

		private void vs_AfterRowColChange(object sender, C1.Win.C1FlexGrid.RangeEventArgs e)
		{
			if (e.OldRange.r1!=e.NewRange.r2)
			{					
				showdata();
			}			
		}		

//		private void cmd2_Click(object sender, System.EventArgs e)
//		{
//			if (vs.Row>0 && vs.Rows[vs.Row].UserData+""!="2")
//			{
//				if (vs1.Rows.Count<=1)
//				{
//					MessageBox.Show(PublicFunction.L_Get_Msg("msg",200));
//					//MessageBox.Show("Please, get attendance data!");
//					return;
//				}
//				frmTaScanCard dlg=new frmTaScanCard(vs);
//				if (dlg.ShowDialog()==DialogResult.OK)
//				{
//					Show_vs2();
//					label6.Text=vs2.Rows.Count-1 +"";
//				}
//			}
//		}

		private void cmd3_Click(object sender, System.EventArgs e)
		{
			Show_vs3();
		}
//		private void cmd5_Click(object sender, System.EventArgs e)
//		{
//			if (vs.Row>0 && vs.Rows[vs.Row].UserData+""!="2")
//			{
//				if (vs1.Rows.Count<=1)
//				{
//					MessageBox.Show(PublicFunction.L_Get_Msg("msg",200));
//					//MessageBox.Show("Please, get attendance data!");
//					return;
//				}
//				frmTaCompare dlg=new frmTaCompare(vs);
//				if (dlg.ShowDialog()==DialogResult.OK)
//				{
//					Show_vs2();
//					label6.Text=vs2.Rows.Count-1 +"";
//				}
//			}
//		}
		private void vs3_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			vs3.Rows[vs3.Row]["LST_NM"]=PublicFunction.A_UserID;				
			vs3.Rows[vs3.Row]["LST_DT"]=T_String.GetDate().ToString("yyyy/MM/dd HH:mm");
		}
		#endregion

		private void cmd4_Click(object sender, System.EventArgs e)
		{
			if (cmd4.Text=="<<")			
				cmd4.Text=">>";
			else
				cmd4.Text="<<";			
			panel9.Visible=panel6.Visible=!panel9.Visible;
		}

		private void frmTaCardComparison_Closed(object sender, System.EventArgs e)
		{
			nav3.Save_SEQ();
		}

		#region Menu Click
//		private void menu_Click(object sender, EventArgs e)
//		{
//			string sql="";			
//			switch (mnu1.MenuItems.IndexOf((MenuItem)sender))
//			{				
//				case 0:
//					Report.frmTaReport1 dlg=new GGM3000.COM.Report.frmTaReport1();
//					if (dlg.ShowDialog()==DialogResult.OK)
//					{
//						sql="Select * from FILE01B where " + dlg.sql +" ORDER By TRN_DT,SFT_ID,INN_NO,DEP_ID,WOK_ID";
//						Report.RPTTaCardComparison cc=new GGM3000.COM.Report.RPTTaCardComparison();
//						cc.RPT1(c1XLBook1,sql,((DateTime)dlg.dt1.Value).ToString("yyyy/MM/dd")+" ~ "+((DateTime)dlg.dt2.Value).ToString("yyyy/MM/dd"));
//					}
//					break;				
//
//			}
//		}
		#endregion
	}
}

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
using GP8000.Personnel.Report;

namespace GP8000.Personnel
{
	/// <summary>
	/// Summary description for frmTaSalaryInput.
	/// </summary>
	public class frmTaBonusAndFinedManager : System.Windows.Forms.Form
	{		
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.TextBox txt3;
		private System.Windows.Forms.TextBox txt2;
		private System.Windows.Forms.TextBox txt1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel4;
		private C1.Win.C1Command.C1CommandDock c1CommandDock1;
		private C1.Win.C1Command.C1DockingTab c1DockingTab1;
		private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage1;
		private GP8000.UserControl.CrtTaDepartment Dep;
		private C1.Win.C1FlexGrid.C1FlexGrid vs;
		private C1.Win.C1FlexGrid.C1FlexGrid vs3;		
		private string wh;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Panel panel9;
		private Navigator1._0.NavigatorAuto nav1;
		private Navigator1._0.NavigatorAuto nav;
		public string ACC_NO,ACC_NM,BNK_NM;
		private System.Windows.Forms.Panel p1;
		private System.Windows.Forms.Panel p2;
		private System.Windows.Forms.Splitter splitter2;
		private System.Windows.Forms.Panel panel10;
		private System.Windows.Forms.Button cmd_sea;
		private System.Windows.Forms.Button cmd_back;
		private System.Windows.Forms.Panel panel13;
		private System.Windows.Forms.Splitter splitter3;
		private System.Windows.Forms.Panel p5;
		private System.Windows.Forms.Panel p4;
		private System.Windows.Forms.Label lb;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private C1.Win.C1FlexGrid.C1FlexGrid vs1;
		private System.Windows.Forms.Button cmd_ok;
		private System.Windows.Forms.CheckBox ck;
		private System.Windows.Forms.DateTimePicker dt;
		private System.Windows.Forms.ComboBox cb;
		private System.Windows.Forms.TextBox txt_EMP_NM;
		private System.Windows.Forms.TextBox txt_EMP_ID;
		private System.Windows.Forms.TextBox txt_AMT_QT;
		private System.Windows.Forms.TextBox txt_TIM_QT;
		private System.Windows.Forms.TextBox txt_note;
		private System.Windows.Forms.Label label7;
		private string VAC_ID="";
		private System.Windows.Forms.CheckBox ck47;
		private System.Windows.Forms.CheckBox ck46;
		private System.Windows.Forms.CheckBox ck45;
		private System.Windows.Forms.CheckBox ck44;
		private System.Windows.Forms.CheckBox ck43;
		private System.Windows.Forms.CheckBox ck42;
		private System.Windows.Forms.CheckBox ck41;
		private System.Windows.Forms.ComboBox Tab_4_cb_DEP_ID;
		private System.Windows.Forms.TextBox tab_4_txt_DWID;
		private System.Windows.Forms.TextBox tab_4_txt_WID;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Button cmd_show;
		private System.Windows.Forms.DateTimePicker dt2;
		private System.Windows.Forms.DateTimePicker dt1;
		private System.Windows.Forms.ComboBox Tab_4_cb_POS_ID;
		private System.Windows.Forms.TextBox Tab_4_txt_EMP_N1;
		private System.Windows.Forms.TextBox Tab_4_txt_EMP_NM;
		private System.Windows.Forms.Label ck48;
		private C1.C1Excel.C1XLBook c1XLBook1;
		
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		
		public frmTaBonusAndFinedManager(string wh,C1.Win.C1FlexGrid.C1FlexGrid vs3)
		{
			//
			// Required for Windows Form Designer support
			//
			this.wh=wh;
			this.vs3=vs3;
			
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		public frmTaBonusAndFinedManager()
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
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel8 = new System.Windows.Forms.Panel();
			this.cmd_back = new System.Windows.Forms.Button();
			this.cmd_sea = new System.Windows.Forms.Button();
			this.vs = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.panel9 = new System.Windows.Forms.Panel();
			this.nav = new Navigator1._0.NavigatorAuto();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.p1 = new System.Windows.Forms.Panel();
			this.p2 = new System.Windows.Forms.Panel();
			this.panel10 = new System.Windows.Forms.Panel();
			this.p5 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.vs1 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.splitter3 = new System.Windows.Forms.Splitter();
			this.panel13 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.txt_note = new System.Windows.Forms.TextBox();
			this.cmd_ok = new System.Windows.Forms.Button();
			this.lb = new System.Windows.Forms.Label();
			this.txt_AMT_QT = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_TIM_QT = new System.Windows.Forms.TextBox();
			this.cb = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.ck = new System.Windows.Forms.CheckBox();
			this.txt_EMP_NM = new System.Windows.Forms.TextBox();
			this.txt_EMP_ID = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dt = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.p4 = new System.Windows.Forms.Panel();
			this.ck48 = new System.Windows.Forms.Label();
			this.cmd_show = new System.Windows.Forms.Button();
			this.dt2 = new System.Windows.Forms.DateTimePicker();
			this.dt1 = new System.Windows.Forms.DateTimePicker();
			this.Tab_4_cb_POS_ID = new System.Windows.Forms.ComboBox();
			this.Tab_4_cb_DEP_ID = new System.Windows.Forms.ComboBox();
			this.Tab_4_txt_EMP_N1 = new System.Windows.Forms.TextBox();
			this.Tab_4_txt_EMP_NM = new System.Windows.Forms.TextBox();
			this.tab_4_txt_DWID = new System.Windows.Forms.TextBox();
			this.tab_4_txt_WID = new System.Windows.Forms.TextBox();
			this.ck47 = new System.Windows.Forms.CheckBox();
			this.ck46 = new System.Windows.Forms.CheckBox();
			this.ck45 = new System.Windows.Forms.CheckBox();
			this.ck44 = new System.Windows.Forms.CheckBox();
			this.ck43 = new System.Windows.Forms.CheckBox();
			this.ck42 = new System.Windows.Forms.CheckBox();
			this.ck41 = new System.Windows.Forms.CheckBox();
			this.splitter2 = new System.Windows.Forms.Splitter();
			this.panel6 = new System.Windows.Forms.Panel();
			this.txt3 = new System.Windows.Forms.TextBox();
			this.txt2 = new System.Windows.Forms.TextBox();
			this.txt1 = new System.Windows.Forms.TextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.nav1 = new Navigator1._0.NavigatorAuto();
			this.c1CommandDock1 = new C1.Win.C1Command.C1CommandDock();
			this.c1DockingTab1 = new C1.Win.C1Command.C1DockingTab();
			this.c1DockingTabPage1 = new C1.Win.C1Command.C1DockingTabPage();
			this.Dep = new GP8000.UserControl.CrtTaDepartment();
			this.c1XLBook1 = new C1.C1Excel.C1XLBook();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel8.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
			this.p1.SuspendLayout();
			this.p2.SuspendLayout();
			this.panel10.SuspendLayout();
			this.p5.SuspendLayout();
			this.panel7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs1)).BeginInit();
			this.panel13.SuspendLayout();
			this.p4.SuspendLayout();
			this.panel6.SuspendLayout();
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
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(264, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(696, 520);
			this.panel1.TabIndex = 3;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.panel5);
			this.panel2.Controls.Add(this.panel6);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 36);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(696, 484);
			this.panel2.TabIndex = 6;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.panel8);
			this.panel5.Controls.Add(this.splitter1);
			this.panel5.Controls.Add(this.p1);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(0, 32);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(696, 452);
			this.panel5.TabIndex = 5;
			// 
			// panel8
			// 
			this.panel8.Controls.Add(this.cmd_back);
			this.panel8.Controls.Add(this.cmd_sea);
			this.panel8.Controls.Add(this.vs);
			this.panel8.Controls.Add(this.panel9);
			this.panel8.Controls.Add(this.nav);
			this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel8.Location = new System.Drawing.Point(0, 227);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(696, 225);
			this.panel8.TabIndex = 13;
			// 
			// cmd_back
			// 
			this.cmd_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmd_back.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_back.Location = new System.Drawing.Point(616, 8);
			this.cmd_back.Name = "cmd_back";
			this.cmd_back.Size = new System.Drawing.Size(75, 28);
			this.cmd_back.TabIndex = 14;
			this.cmd_back.Text = "button1";
			this.cmd_back.Visible = false;
			this.cmd_back.Click += new System.EventHandler(this.cmd_back_Click);
			// 
			// cmd_sea
			// 
			this.cmd_sea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmd_sea.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_sea.Location = new System.Drawing.Point(616, 8);
			this.cmd_sea.Name = "cmd_sea";
			this.cmd_sea.Size = new System.Drawing.Size(75, 28);
			this.cmd_sea.TabIndex = 13;
			this.cmd_sea.Text = "button1";
			this.cmd_sea.Click += new System.EventHandler(this.cmd_sea_Click);
			// 
			// vs
			// 
			this.vs.AllowEditing = false;
			this.vs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.vs.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vs.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs.Location = new System.Drawing.Point(4, 38);
			this.vs.Name = "vs";
			this.vs.Size = new System.Drawing.Size(688, 186);
			this.vs.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs.TabIndex = 10;
			// 
			// panel9
			// 
			this.panel9.BackColor = System.Drawing.Color.CornflowerBlue;
			this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel9.Location = new System.Drawing.Point(0, 0);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(696, 4);
			this.panel9.TabIndex = 12;
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
			this.nav.Location = new System.Drawing.Point(4, 5);
			this.nav.MSG_Exit = false;
			this.nav.MulltiDel = false;
			this.nav.Name = "nav";
			this.nav.Security = 0;
			this.nav.ShowPopupMenu = true;
			this.nav.Size = new System.Drawing.Size(344, 32);
			this.nav.TabIndex = 11;
			this.nav.Tag = "";
			this.nav.ToolBar_Auto = true;
			this.nav.UserID = null;
			this.nav.VisibleGrid = true;
			this.nav.Where = null;
			// 
			// splitter1
			// 
			this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
			this.splitter1.Location = new System.Drawing.Point(0, 224);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(696, 3);
			this.splitter1.TabIndex = 12;
			this.splitter1.TabStop = false;
			// 
			// p1
			// 
			this.p1.Controls.Add(this.p2);
			this.p1.Dock = System.Windows.Forms.DockStyle.Top;
			this.p1.Location = new System.Drawing.Point(0, 0);
			this.p1.Name = "p1";
			this.p1.Size = new System.Drawing.Size(696, 224);
			this.p1.TabIndex = 11;
			// 
			// p2
			// 
			this.p2.Controls.Add(this.panel10);
			this.p2.Controls.Add(this.splitter2);
			this.p2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.p2.Location = new System.Drawing.Point(0, 0);
			this.p2.Name = "p2";
			this.p2.Size = new System.Drawing.Size(696, 224);
			this.p2.TabIndex = 0;
			// 
			// panel10
			// 
			this.panel10.Controls.Add(this.p5);
			this.panel10.Controls.Add(this.p4);
			this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel10.Location = new System.Drawing.Point(0, 0);
			this.panel10.Name = "panel10";
			this.panel10.Size = new System.Drawing.Size(693, 224);
			this.panel10.TabIndex = 2;
			// 
			// p5
			// 
			this.p5.Controls.Add(this.panel7);
			this.p5.Controls.Add(this.splitter3);
			this.p5.Controls.Add(this.panel13);
			this.p5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.p5.Location = new System.Drawing.Point(0, 0);
			this.p5.Name = "p5";
			this.p5.Size = new System.Drawing.Size(605, 224);
			this.p5.TabIndex = 1;
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.vs1);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(174, 224);
			this.panel7.TabIndex = 2;
			// 
			// vs1
			// 
			this.vs1.AllowEditing = false;
			this.vs1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs1.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vs1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vs1.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs1.Location = new System.Drawing.Point(0, 0);
			this.vs1.Name = "vs1";
			this.vs1.Size = new System.Drawing.Size(174, 224);
			this.vs1.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs1.TabIndex = 11;
			// 
			// splitter3
			// 
			this.splitter3.Dock = System.Windows.Forms.DockStyle.Right;
			this.splitter3.Location = new System.Drawing.Point(174, 0);
			this.splitter3.Name = "splitter3";
			this.splitter3.Size = new System.Drawing.Size(3, 224);
			this.splitter3.TabIndex = 1;
			this.splitter3.TabStop = false;
			// 
			// panel13
			// 
			this.panel13.BackColor = System.Drawing.Color.Moccasin;
			this.panel13.Controls.Add(this.label7);
			this.panel13.Controls.Add(this.txt_note);
			this.panel13.Controls.Add(this.cmd_ok);
			this.panel13.Controls.Add(this.lb);
			this.panel13.Controls.Add(this.txt_AMT_QT);
			this.panel13.Controls.Add(this.label6);
			this.panel13.Controls.Add(this.label4);
			this.panel13.Controls.Add(this.txt_TIM_QT);
			this.panel13.Controls.Add(this.cb);
			this.panel13.Controls.Add(this.label3);
			this.panel13.Controls.Add(this.ck);
			this.panel13.Controls.Add(this.txt_EMP_NM);
			this.panel13.Controls.Add(this.txt_EMP_ID);
			this.panel13.Controls.Add(this.label2);
			this.panel13.Controls.Add(this.dt);
			this.panel13.Controls.Add(this.label1);
			this.panel13.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel13.Location = new System.Drawing.Point(177, 0);
			this.panel13.Name = "panel13";
			this.panel13.Size = new System.Drawing.Size(428, 224);
			this.panel13.TabIndex = 0;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Moccasin;
			this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.Location = new System.Drawing.Point(8, 116);
			this.label7.Name = "label7";
			this.label7.TabIndex = 135;
			this.label7.Text = "label7";
			// 
			// txt_note
			// 
			this.txt_note.BackColor = System.Drawing.SystemColors.Window;
			this.txt_note.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txt_note.Location = new System.Drawing.Point(108, 116);
			this.txt_note.MaxLength = 100;
			this.txt_note.Multiline = true;
			this.txt_note.Name = "txt_note";
			this.txt_note.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txt_note.Size = new System.Drawing.Size(316, 44);
			this.txt_note.TabIndex = 134;
			this.txt_note.Tag = "";
			this.txt_note.Text = "";
			// 
			// cmd_ok
			// 
			this.cmd_ok.BackColor = System.Drawing.Color.Moccasin;
			this.cmd_ok.Enabled = false;
			this.cmd_ok.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_ok.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmd_ok.Location = new System.Drawing.Point(152, 192);
			this.cmd_ok.Name = "cmd_ok";
			this.cmd_ok.Size = new System.Drawing.Size(112, 28);
			this.cmd_ok.TabIndex = 27;
			this.cmd_ok.Text = "button1";
			this.cmd_ok.Click += new System.EventHandler(this.cmd_ok_Click);
			// 
			// lb
			// 
			this.lb.BackColor = System.Drawing.Color.Black;
			this.lb.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lb.ForeColor = System.Drawing.Color.Red;
			this.lb.Location = new System.Drawing.Point(4, 164);
			this.lb.Name = "lb";
			this.lb.Size = new System.Drawing.Size(420, 24);
			this.lb.TabIndex = 26;
			this.lb.Text = "To get the sack";
			this.lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lb.Visible = false;
			// 
			// txt_AMT_QT
			// 
			this.txt_AMT_QT.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt_AMT_QT.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_AMT_QT.Location = new System.Drawing.Point(312, 88);
			this.txt_AMT_QT.Name = "txt_AMT_QT";
			this.txt_AMT_QT.ReadOnly = true;
			this.txt_AMT_QT.Size = new System.Drawing.Size(112, 23);
			this.txt_AMT_QT.TabIndex = 25;
			this.txt_AMT_QT.Text = "";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Moccasin;
			this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(224, 92);
			this.label6.Name = "label6";
			this.label6.TabIndex = 24;
			this.label6.Text = "label6";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Moccasin;
			this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(8, 92);
			this.label4.Name = "label4";
			this.label4.TabIndex = 23;
			this.label4.Text = "label4";
			// 
			// txt_TIM_QT
			// 
			this.txt_TIM_QT.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt_TIM_QT.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_TIM_QT.Location = new System.Drawing.Point(108, 88);
			this.txt_TIM_QT.Name = "txt_TIM_QT";
			this.txt_TIM_QT.ReadOnly = true;
			this.txt_TIM_QT.Size = new System.Drawing.Size(112, 23);
			this.txt_TIM_QT.TabIndex = 22;
			this.txt_TIM_QT.Text = "";
			// 
			// cb
			// 
			this.cb.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cb.ItemHeight = 16;
			this.cb.Location = new System.Drawing.Point(108, 60);
			this.cb.Name = "cb";
			this.cb.Size = new System.Drawing.Size(316, 24);
			this.cb.TabIndex = 21;
			this.cb.Text = "comboBox1";
			this.cb.SelectedIndexChanged += new System.EventHandler(this.cb_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Moccasin;
			this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(8, 64);
			this.label3.Name = "label3";
			this.label3.TabIndex = 20;
			this.label3.Text = "label3";
			// 
			// ck
			// 
			this.ck.BackColor = System.Drawing.Color.Moccasin;
			this.ck.Checked = true;
			this.ck.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ck.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ck.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ck.Location = new System.Drawing.Point(224, 32);
			this.ck.Name = "ck";
			this.ck.Size = new System.Drawing.Size(200, 24);
			this.ck.TabIndex = 19;
			this.ck.Text = "checkBox1";
			this.ck.Visible = false;
			this.ck.CheckedChanged += new System.EventHandler(this.ck_CheckedChanged);
			// 
			// txt_EMP_NM
			// 
			this.txt_EMP_NM.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt_EMP_NM.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_EMP_NM.Location = new System.Drawing.Point(220, 4);
			this.txt_EMP_NM.Name = "txt_EMP_NM";
			this.txt_EMP_NM.ReadOnly = true;
			this.txt_EMP_NM.Size = new System.Drawing.Size(204, 23);
			this.txt_EMP_NM.TabIndex = 18;
			this.txt_EMP_NM.Text = "";
			// 
			// txt_EMP_ID
			// 
			this.txt_EMP_ID.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt_EMP_ID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_EMP_ID.Location = new System.Drawing.Point(108, 4);
			this.txt_EMP_ID.Name = "txt_EMP_ID";
			this.txt_EMP_ID.Size = new System.Drawing.Size(112, 23);
			this.txt_EMP_ID.TabIndex = 17;
			this.txt_EMP_ID.Text = "";
			this.txt_EMP_ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Moccasin;
			this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 36);
			this.label2.Name = "label2";
			this.label2.TabIndex = 16;
			this.label2.Text = "label2";
			// 
			// dt
			// 
			this.dt.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dt.CustomFormat = "yyyy/MM/dd";
			this.dt.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dt.Location = new System.Drawing.Point(108, 32);
			this.dt.Name = "dt";
			this.dt.Size = new System.Drawing.Size(112, 23);
			this.dt.TabIndex = 15;
			this.dt.Value = new System.DateTime(2008, 8, 29, 16, 10, 53, 512);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Moccasin;
			this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.TabIndex = 14;
			this.label1.Text = "label1";
			// 
			// p4
			// 
			this.p4.BackColor = System.Drawing.Color.Moccasin;
			this.p4.Controls.Add(this.ck48);
			this.p4.Controls.Add(this.cmd_show);
			this.p4.Controls.Add(this.dt2);
			this.p4.Controls.Add(this.dt1);
			this.p4.Controls.Add(this.Tab_4_cb_POS_ID);
			this.p4.Controls.Add(this.Tab_4_cb_DEP_ID);
			this.p4.Controls.Add(this.Tab_4_txt_EMP_N1);
			this.p4.Controls.Add(this.Tab_4_txt_EMP_NM);
			this.p4.Controls.Add(this.tab_4_txt_DWID);
			this.p4.Controls.Add(this.tab_4_txt_WID);
			this.p4.Controls.Add(this.ck47);
			this.p4.Controls.Add(this.ck46);
			this.p4.Controls.Add(this.ck45);
			this.p4.Controls.Add(this.ck44);
			this.p4.Controls.Add(this.ck43);
			this.p4.Controls.Add(this.ck42);
			this.p4.Controls.Add(this.ck41);
			this.p4.Dock = System.Windows.Forms.DockStyle.Right;
			this.p4.Location = new System.Drawing.Point(605, 0);
			this.p4.Name = "p4";
			this.p4.Size = new System.Drawing.Size(88, 224);
			this.p4.TabIndex = 0;
			this.p4.Visible = false;
			// 
			// ck48
			// 
			this.ck48.BackColor = System.Drawing.Color.Moccasin;
			this.ck48.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ck48.Location = new System.Drawing.Point(304, 92);
			this.ck48.Name = "ck48";
			this.ck48.Size = new System.Drawing.Size(112, 23);
			this.ck48.TabIndex = 43;
			this.ck48.Text = "label8";
			// 
			// cmd_show
			// 
			this.cmd_show.BackColor = System.Drawing.SystemColors.Control;
			this.cmd_show.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_show.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmd_show.Location = new System.Drawing.Point(224, 120);
			this.cmd_show.Name = "cmd_show";
			this.cmd_show.Size = new System.Drawing.Size(104, 36);
			this.cmd_show.TabIndex = 42;
			this.cmd_show.Text = "button1";
			this.cmd_show.Click += new System.EventHandler(this.cmd_show_Click);
			// 
			// dt2
			// 
			this.dt2.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dt2.CustomFormat = "yyyy/MM/dd";
			this.dt2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dt2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dt2.Location = new System.Drawing.Point(416, 88);
			this.dt2.Name = "dt2";
			this.dt2.Size = new System.Drawing.Size(148, 23);
			this.dt2.TabIndex = 41;
			this.dt2.Value = new System.DateTime(2008, 8, 29, 16, 10, 53, 512);
			// 
			// dt1
			// 
			this.dt1.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dt1.CustomFormat = "yyyy/MM/dd";
			this.dt1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dt1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dt1.Location = new System.Drawing.Point(136, 88);
			this.dt1.Name = "dt1";
			this.dt1.Size = new System.Drawing.Size(148, 23);
			this.dt1.TabIndex = 40;
			this.dt1.Value = new System.DateTime(2008, 8, 29, 16, 10, 53, 512);
			// 
			// Tab_4_cb_POS_ID
			// 
			this.Tab_4_cb_POS_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Tab_4_cb_POS_ID.Enabled = false;
			this.Tab_4_cb_POS_ID.Location = new System.Drawing.Point(416, 60);
			this.Tab_4_cb_POS_ID.Name = "Tab_4_cb_POS_ID";
			this.Tab_4_cb_POS_ID.Size = new System.Drawing.Size(148, 24);
			this.Tab_4_cb_POS_ID.TabIndex = 33;
			// 
			// Tab_4_cb_DEP_ID
			// 
			this.Tab_4_cb_DEP_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Tab_4_cb_DEP_ID.Enabled = false;
			this.Tab_4_cb_DEP_ID.Location = new System.Drawing.Point(136, 60);
			this.Tab_4_cb_DEP_ID.Name = "Tab_4_cb_DEP_ID";
			this.Tab_4_cb_DEP_ID.Size = new System.Drawing.Size(148, 24);
			this.Tab_4_cb_DEP_ID.TabIndex = 35;
			// 
			// Tab_4_txt_EMP_N1
			// 
			this.Tab_4_txt_EMP_N1.Location = new System.Drawing.Point(416, 32);
			this.Tab_4_txt_EMP_N1.Name = "Tab_4_txt_EMP_N1";
			this.Tab_4_txt_EMP_N1.Size = new System.Drawing.Size(148, 23);
			this.Tab_4_txt_EMP_N1.TabIndex = 34;
			this.Tab_4_txt_EMP_N1.Text = "";
			// 
			// Tab_4_txt_EMP_NM
			// 
			this.Tab_4_txt_EMP_NM.Location = new System.Drawing.Point(136, 32);
			this.Tab_4_txt_EMP_NM.Name = "Tab_4_txt_EMP_NM";
			this.Tab_4_txt_EMP_NM.Size = new System.Drawing.Size(148, 23);
			this.Tab_4_txt_EMP_NM.TabIndex = 32;
			this.Tab_4_txt_EMP_NM.Text = "";
			// 
			// tab_4_txt_DWID
			// 
			this.tab_4_txt_DWID.Location = new System.Drawing.Point(416, 4);
			this.tab_4_txt_DWID.Name = "tab_4_txt_DWID";
			this.tab_4_txt_DWID.Size = new System.Drawing.Size(148, 23);
			this.tab_4_txt_DWID.TabIndex = 31;
			this.tab_4_txt_DWID.Text = "";
			// 
			// tab_4_txt_WID
			// 
			this.tab_4_txt_WID.Location = new System.Drawing.Point(136, 4);
			this.tab_4_txt_WID.Name = "tab_4_txt_WID";
			this.tab_4_txt_WID.Size = new System.Drawing.Size(148, 23);
			this.tab_4_txt_WID.TabIndex = 30;
			this.tab_4_txt_WID.Text = "";
			// 
			// ck47
			// 
			this.ck47.Location = new System.Drawing.Point(8, 88);
			this.ck47.Name = "ck47";
			this.ck47.Size = new System.Drawing.Size(128, 24);
			this.ck47.TabIndex = 28;
			this.ck47.Text = "checkBox8";
			this.ck47.CheckedChanged += new System.EventHandler(this.ck41_CheckedChanged);
			// 
			// ck46
			// 
			this.ck46.Location = new System.Drawing.Point(288, 60);
			this.ck46.Name = "ck46";
			this.ck46.Size = new System.Drawing.Size(128, 24);
			this.ck46.TabIndex = 27;
			this.ck46.Text = "checkBox6";
			this.ck46.CheckedChanged += new System.EventHandler(this.ck41_CheckedChanged);
			// 
			// ck45
			// 
			this.ck45.Location = new System.Drawing.Point(8, 60);
			this.ck45.Name = "ck45";
			this.ck45.Size = new System.Drawing.Size(128, 24);
			this.ck45.TabIndex = 26;
			this.ck45.Text = "checkBox5";
			this.ck45.CheckedChanged += new System.EventHandler(this.ck41_CheckedChanged);
			// 
			// ck44
			// 
			this.ck44.Location = new System.Drawing.Point(288, 32);
			this.ck44.Name = "ck44";
			this.ck44.Size = new System.Drawing.Size(128, 24);
			this.ck44.TabIndex = 25;
			this.ck44.Text = "checkBox4";
			this.ck44.CheckedChanged += new System.EventHandler(this.ck41_CheckedChanged);
			// 
			// ck43
			// 
			this.ck43.Location = new System.Drawing.Point(8, 32);
			this.ck43.Name = "ck43";
			this.ck43.Size = new System.Drawing.Size(128, 24);
			this.ck43.TabIndex = 24;
			this.ck43.Text = "checkBox3";
			this.ck43.CheckedChanged += new System.EventHandler(this.ck41_CheckedChanged);
			// 
			// ck42
			// 
			this.ck42.Location = new System.Drawing.Point(288, 4);
			this.ck42.Name = "ck42";
			this.ck42.Size = new System.Drawing.Size(128, 24);
			this.ck42.TabIndex = 23;
			this.ck42.Text = "checkBox2";
			this.ck42.CheckedChanged += new System.EventHandler(this.ck41_CheckedChanged);
			// 
			// ck41
			// 
			this.ck41.Location = new System.Drawing.Point(8, 4);
			this.ck41.Name = "ck41";
			this.ck41.Size = new System.Drawing.Size(128, 24);
			this.ck41.TabIndex = 22;
			this.ck41.Text = "checkBox1";
			this.ck41.CheckedChanged += new System.EventHandler(this.ck41_CheckedChanged);
			// 
			// splitter2
			// 
			this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
			this.splitter2.Location = new System.Drawing.Point(693, 0);
			this.splitter2.Name = "splitter2";
			this.splitter2.Size = new System.Drawing.Size(3, 224);
			this.splitter2.TabIndex = 1;
			this.splitter2.TabStop = false;
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.Moccasin;
			this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel6.Controls.Add(this.txt3);
			this.panel6.Controls.Add(this.txt2);
			this.panel6.Controls.Add(this.txt1);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel6.Location = new System.Drawing.Point(0, 0);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(696, 32);
			this.panel6.TabIndex = 4;
			// 
			// txt3
			// 
			this.txt3.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt3.Location = new System.Drawing.Point(272, 2);
			this.txt3.MaxLength = 20;
			this.txt3.Name = "txt3";
			this.txt3.Size = new System.Drawing.Size(132, 23);
			this.txt3.TabIndex = 73;
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
			this.txt2.Location = new System.Drawing.Point(140, 2);
			this.txt2.MaxLength = 20;
			this.txt2.Name = "txt2";
			this.txt2.Size = new System.Drawing.Size(132, 23);
			this.txt2.TabIndex = 72;
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
			this.txt1.Location = new System.Drawing.Point(8, 2);
			this.txt1.MaxLength = 20;
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(132, 23);
			this.txt1.TabIndex = 71;
			this.txt1.Tag = "EMP_ID";
			this.txt1.Text = "textBox3";
			this.txt1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
			this.txt1.Leave += new System.EventHandler(this.textBox1_Leave);
			this.txt1.Enter += new System.EventHandler(this.textBox1_Enter);
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
			this.panel3.Size = new System.Drawing.Size(696, 36);
			this.panel3.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Location = new System.Drawing.Point(352, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(344, 36);
			this.label5.TabIndex = 11;
			this.label5.Tag = "";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.panel4.Controls.Add(this.nav1);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(352, 36);
			this.panel4.TabIndex = 10;
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
			this.nav1.Location = new System.Drawing.Point(4, 3);
			this.nav1.MSG_Exit = false;
			this.nav1.MulltiDel = false;
			this.nav1.Name = "nav1";
			this.nav1.Security = 0;
			this.nav1.ShowPopupMenu = true;
			this.nav1.Size = new System.Drawing.Size(344, 32);
			this.nav1.TabIndex = 10;
			this.nav1.Tag = "";
			this.nav1.ToolBar_Auto = true;
			this.nav1.UserID = null;
			this.nav1.VisibleGrid = true;
			this.nav1.Where = null;
			// 
			// c1CommandDock1
			// 
			this.c1CommandDock1.Controls.Add(this.c1DockingTab1);
			this.c1CommandDock1.Dock = System.Windows.Forms.DockStyle.Left;
			this.c1CommandDock1.Id = 1;
			this.c1CommandDock1.Location = new System.Drawing.Point(0, 0);
			this.c1CommandDock1.Name = "c1CommandDock1";
			this.c1CommandDock1.Size = new System.Drawing.Size(264, 520);
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
			this.c1DockingTab1.Size = new System.Drawing.Size(264, 520);
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
			this.c1DockingTabPage1.Size = new System.Drawing.Size(259, 518);
			this.c1DockingTabPage1.TabIndex = 0;
			this.c1DockingTabPage1.Text = "Page1";
			// 
			// Dep
			// 
			this.Dep.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Dep.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Dep.Location = new System.Drawing.Point(0, 20);
			this.Dep.Name = "Dep";
			this.Dep.Size = new System.Drawing.Size(259, 498);
			this.Dep.TabIndex = 2;
			// 
			// frmTaBonusAndFinedManager
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(960, 520);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.c1CommandDock1);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaBonusAndFinedManager";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmTaBonusAndFinedManager";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmTaSalaryInput_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			this.p1.ResumeLayout(false);
			this.p2.ResumeLayout(false);
			this.panel10.ResumeLayout(false);
			this.p5.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs1)).EndInit();
			this.panel13.ResumeLayout(false);
			this.p4.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
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

		private void frmTaSalaryInput_Load(object sender, System.EventArgs e)
		{
			Init_vs();
			Init_vs1();
			Dep.Init_Tree(this.Tag+"");
			Dep.Show_Tree();
			Dep.vs1.AfterRowColChange+=new RangeEventHandler(Depvs1_AfterRowColChange);
			Basic.Function.PublicFunction.L_Init_Label(this);
			dt2.Value=dt1.Value=dt.Value=T_String.GetDate();
			dt2.CustomFormat=dt1.CustomFormat=vs.Cols["SEQ_DT"].Format= dt.CustomFormat=PublicFunction.GetOption("DATE");		
		}	
		#region Init
		private void Init_vs()
		{
			//nav.cmd_delete.Visible=false;						
			nav.cmd_copy.Visible=false;
			nav.cmd_save.Visible=false;
			nav.cmd_add.Visible=false;
			nav.cmd_search.Visible=false;		
			nav.cmd_exit.Visible=false;		
			PublicFunction.InitNav(this,vs,nav);	
			vs.EnabledChanged+=new EventHandler(vs_EnabledChanged);			
			nav.TBarClick+=new ToolBarButtonClickEventHandler(nav_TBarClick);
			nav.ToolBar_Auto=false;
			vs.Cols.Frozen=vs.Cols["EMP_NM"].Index;
		}
	
		private void Init_vs1()
		{			
			nav1.cmd_copy.Visible=false;
			nav1.cmd_save.Visible=false;
			nav1.cmd_add.Visible=false;
			nav1.cmd_delete.Visible=false;
			nav1.cmd_report.Visible=false;
			nav1.cmd_search.Visible=false;		
			PublicFunction.InitNav(this,vs1,nav1);			
			vs1.AllowEditing=false;
			vs1.AfterRowColChange+=new RangeEventHandler(vs1_AfterRowColChange);			
			Init_CB();
			nav1.ToolBar_Auto=false;
			nav1.TBarClick+=new ToolBarButtonClickEventHandler(nav1_TBarClick);
		}	
		
		
		private void  Init_CB()
		{			
			string sql;			
			//Department
			sql=PublicFunction.GetDep(this.Tag+"");			
			vs1.Cols["DEP_ID"].DataMap=PublicFunction.InitCBForVS(sql);	
			vs.Cols["DEP_ID"].DataMap=PublicFunction.InitCBForVS(sql);		
			PublicFunction.InitCB(Tab_4_cb_DEP_ID,sql);	
			//Position
			sql="Select POS_ID,POS_NM from FILA07A";		
			vs1.Cols["POS_ID"].DataMap=PublicFunction.InitCBForVS(sql);						
			vs.Cols["POS_ID"].DataMap=PublicFunction.InitCBForVS(sql);	
			PublicFunction.InitCB(Tab_4_cb_POS_ID,sql);			
			//Level
			sql="Select LEV_ID,LEV_NM from FILA19A";
			vs1.Cols["LEV_ID"].DataMap=PublicFunction.InitCBForVS(sql);	
			//Level
			sql="Select BAF_ID,BAF_NM from FILA13A";
			vs.Cols["BAF_ID"].DataMap=PublicFunction.InitCBForVS(sql);			
			PublicFunction.InitCB(cb,sql);

			sql="Select VAC_ID,VAC_NM from FILA06A";
			vs.Cols["VAC_ID"].DataMap=PublicFunction.InitCBForVS(sql);	
		}

		private void Depvs1_AfterRowColChange(object sender, RangeEventArgs e)
		{
			if(e.OldRange.r1!=e.NewRange.r1)
			{
				Show_VS();
			}
		}
		#endregion
		#region ShowData
		private void Show_VS()
		{
			if(Dep.vs1.Row<=0)
			{
				vs1.Rows.Count=1;			
				return;
			}
			nav1.Show_VS("DEP_ID=N'"+Dep.Get_Data("DEP_ID")+"' ");
			Show_VS1();
		}		
		private void Show_VS1()
		{
			Show_Text();
			if(vs1.Row<=0)
			{
				vs.Rows.Count=1;			
				return;
			}
			nav.Show_VS("a.EMP_ID=N'"+vs1.Rows[vs1.Row]["EMP_ID"]+"' ");					
		}	
		private void Show_Text()
		{
			VAC_ID="";
			lb.Visible=false;
			cmd_ok.Enabled=true;
			if(vs1.Row<=0)
			{
				txt_EMP_ID.Text=txt_EMP_NM.Text="";			
				cmd_ok.Enabled=false;
				return;
			}
			txt_EMP_ID.Text=vs1.Rows[vs1.Row]["EMP_ID"]+"";
			txt_EMP_NM.Text=vs1.Rows[vs1.Row]["EMP_NM"]+"";
			Get_bonus();
		}
		#endregion
		#region Search
		private void textBox1_Enter(object sender, System.EventArgs e)
		{
			TextBox txt=(TextBox)sender;
			if (txt.Text==vs1.Cols[txt.Tag+""].Caption)
				txt.Text="";
		}

		private void textBox1_Leave(object sender, System.EventArgs e)
		{
			TextBox txt=(TextBox)sender;
			if (txt.Text=="")
				txt.Text=vs1.Cols[txt.Tag+""].Caption;
		}

		private void textBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Enter)
			{
				string f=((TextBox)sender).Tag+"";			
				string sql;					
				if(((TextBox)sender).Text+""!="")
				{
					if(((TextBox)sender).Equals(txt_EMP_ID))
					{
						sql=" EMP_ID=N'"+((TextBox)sender).Text+"'";
					}
					else
						sql=f+" like N'%"+((TextBox)sender).Text+"%'";
				}
				else
					sql="1=1";
				sql=sql+"and  (VAC_BT=0 or VAC_BT is null)  and DEP_ID in (Select DEP_ID  from SYS_SECURITY_DEP"+
					" where MNU_ID="+this.Tag+" and ALL_BT=1  and USER_ID=N'"+PublicFunction.A_UserID+"')";					
				nav1.Show_VS(sql);	
				Show_VS1();	
			}
		}
	
		
		#endregion
		private void nav_TBarClick(object sender, ToolBarButtonClickEventArgs e)
		{	
			if (e.Button.Equals(nav.cmd_refresh))
			{
				Show_Text();
				return;
			}			
			if (e.Button.Equals(nav.cmd_report))
			{
				ReportFromVS rpt=new ReportFromVS();
				rpt.RPT2(c1XLBook1,vs,this.Text,"BonusAndFined");
			}
			nav.ToolBar_Click(e);
		}

		private void nav1_TBarClick(object sender, ToolBarButtonClickEventArgs e)
		{				
			if (e.Button.Equals(nav1.cmd_refresh))
			{	
				if(nav.wh!="")
					nav1.ToolBar_Click(e);
				else
					nav1.Show_VS("DEP_ID in "+T_String.DEP_ID(this.Tag));								
				Show_VS1();
				return;
			}					
		}

		private void vs_EnabledChanged(object sender, EventArgs e)
		{	
			txt1.Text=vs1.Cols[txt1.Tag+""].Caption;
			txt2.Text=vs1.Cols[txt2.Tag+""].Caption;
			txt3.Text=vs1.Cols[txt3.Tag+""].Caption;	
			vs.AutoSizeCols();
		}
		

		
		private void vs1_AfterRowColChange(object sender, RangeEventArgs e)
		{
			if(e.NewRange.r1!=e.OldRange.r1)			
				Show_VS1();                
		}

		private void cmd_sea_Click(object sender, System.EventArgs e)
		{
			panel6.Visible=cmd_sea.Visible=p5.Visible=false;
			cmd_back.Visible=p4.Visible=true;
			p4.Dock=DockStyle.Fill;
			
		}

		private void cmd_back_Click(object sender, System.EventArgs e)
		{
			panel6.Visible=cmd_sea.Visible=p5.Visible=true;
			cmd_back.Visible=p4.Visible=false;			
			p4.Dock=DockStyle.Right;			
		}

		private void ck_CheckedChanged(object sender, System.EventArgs e)
		{
//			string sql;
//			if(ck.Checked)
//				sql="Select BAF_ID,BAF_NM from FILA13A where TPE_ID=1";
//			else
//				sql="Select BAF_ID,BAF_NM from FILA13A where TPE_ID=0 or TPE_ID is null";			
//			PublicFunction.InitCB(cb,sql);
		}

		private void cb_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			Get_bonus();
		}

		private void Get_bonus()
		{				
			if(cb.SelectedValue+""=="" || vs1.Row<1)
			{
				txt_AMT_QT.Text="";
				txt_TIM_QT.Text="";
				return;
			}
			string sql="";
			int max=T_String.GetMax("count(*)","FILD04A","EMP_ID=N'"+txt_EMP_ID.Text+"' and BAF_ID=N'"+
				cb.SelectedValue+"'");
			txt_TIM_QT.Text=max+"";
			sql="select * from FILA13B where BAF_ID=N'"+cb.SelectedValue+"' and TIM_QT<="+max+" ORDER BY TIM_QT desc ";
			Func.RecordSet rs=new Func.RecordSet(sql,PublicFunction.C_con);
			if(rs.rows>0)
			{
				txt_AMT_QT.Text=rs.record(0,"AMT_QT");
				if(rs.record(0,"VAC_ID")+""!="")
				{
					lb.Visible=true;	
					VAC_ID=rs.record(0,"VAC_ID");
				}

			}
			else
			{
				txt_AMT_QT.Text="";				
			}

		}

		private void cmd_ok_Click(object sender, System.EventArgs e)
		{
			if(cb.SelectedValue+""=="")
			{
				MessageBox.Show(PublicFunction.L_Get_Msg("msg",101));
				return;
			}	
			SqlConnection con=new SqlConnection(PublicFunction.C_con.ConnectionString);
			con.Open();
			SqlTransaction tran=con.BeginTransaction();				
			try
			{
				string sql="";					
				string max=T_String.GetMax("MAX(SEQ_NO)","FILD04A","EMP_ID=N'"+txt_EMP_ID.Text+"'")+"";
				sql="Insert Into FILD04A(EMP_ID,SEQ_NO,SEQ_DT,BAF_ID,TPE_ID,TIM_QT,AMT_QT,VAC_ID,NOT_DR,BLT_NM,BLT_DT)"+
					" values(";
				sql+="N'"+txt_EMP_ID.Text+"',"+max+",'"+DateTime.Parse(dt.Value+"").ToString("yyyy/MM/dd")
					+"',N'"+cb.SelectedValue+"',";
				//tim loai thuong or phat
				if (T_String.GetDataFromSQL("TPE_ID","FILA13A","BAF_ID='"+cb.SelectedValue+"'")==null ||T_String.GetDataFromSQL("TPE_ID","FILA13A","BAF_ID='"+cb.SelectedValue+"'")=="False" )
				{
					sql+="0,";
				}
				else
				{
					sql+="1,";
				}

//				if(ck.Checked)
//					sql+="1,";
//				else
//					sql+="0,";
				sql+=txt_TIM_QT.Text+","+T_String.IsNullTo00(txt_AMT_QT.Text)+",N'"+VAC_ID+"',"
					+"N'"+txt_note.Text+"',N'"+PublicFunction.A_UserID+"','"+T_String.GetDate().ToString("yyyy/MM/dd HH:mm")+"')";
				SqlCommand cmd=new SqlCommand(sql,con,tran);
				cmd.ExecuteNonQuery();					
								
				tran.Commit();
				con.Close();				
				Show_VS1();
				Get_bonus();
				MessageBox.Show(PublicFunction.L_Get_Msg("Staff",1));	
				if(lb.Visible)
				{
					if(MessageBox.Show(this,PublicFunction.L_Get_Msg("msg",202),this.Text,MessageBoxButtons.YesNo)==DialogResult.Yes)
					{
						GP8000.Personnel.frmTaVacateManager dlg=new frmTaVacateManager(VAC_ID,txt_EMP_ID.Text);
						dlg.Tag=this.Tag;
						dlg.ShowDialog();
					}
				}
			}
			catch(Exception ex)
			{
				tran.Rollback();
				MessageBox.Show(ex.Message);
			}
		}

		private void cmd_show_Click(object sender, System.EventArgs e)
		{
			string sql="";
			if(ck41.Checked)
			{
				sql+=" a.EMP_ID=N'"+tab_4_txt_WID.Text+"' ";
			}
			if(ck42.Checked)
			{
				if(sql!="")	sql+=" and ";
				sql+=" EMP_I1=N'"+tab_4_txt_DWID.Text+"' ";
			}
			if(ck43.Checked)
			{
				if(sql!="")	sql+=" and ";
				sql+=" EMP_NM=N'"+Tab_4_txt_EMP_NM.Text+"' ";
			}
			if(ck44.Checked)
			{
				if(sql!="")	sql+=" and ";
				sql+=" EMP_N1=N'"+Tab_4_txt_EMP_N1.Text+"' ";
			}
			if(ck45.Checked)
			{				
				if(sql!="")	sql+=" and ";
				sql+=" DEP_ID=N'"+Tab_4_cb_DEP_ID.SelectedValue+"' ";
			}
			if(ck46.Checked)
			{
				if(sql!="")	sql+=" and ";
				sql+=" POS_ID=N'"+Tab_4_cb_POS_ID.SelectedValue+"' ";
			}
			if(ck47.Checked)
			{
				if(sql!="")	sql+=" and ";
				sql+="( SEQ_DT Between '"+DateTime.Parse(dt1.Value+"").ToString("yyyy/MM/dd")+"' and '"+
					DateTime.Parse(dt1.Value+"").ToString("yyyy/MM/dd")+"')";
			}
			
			if(sql!="")
				nav.Show_VS(sql +" Order by a.EMP_ID,SEQ_NO");
			else
				nav.Show_VS("1=1 Order by a.EMP_ID,SEQ_NO");
		}

		private void ck41_CheckedChanged(object sender, System.EventArgs e)
		{
			tab_4_txt_WID.Enabled=ck41.Checked;
			tab_4_txt_DWID.Enabled=ck42.Checked;
			Tab_4_txt_EMP_NM.Enabled=ck43.Checked;
			Tab_4_txt_EMP_N1.Enabled=ck44.Checked;
			Tab_4_cb_DEP_ID.Enabled=ck45.Checked;
			Tab_4_cb_POS_ID.Enabled=ck46.Checked;
			dt2.Enabled=dt1.Enabled=ck47.Checked;				
		}

	

		
	
	}
}

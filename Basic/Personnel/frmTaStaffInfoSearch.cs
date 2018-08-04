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
using GP8000.Personnel.Report;
namespace GP8000.Personnel
{
	/// <summary>
	/// Summary description for frmTaStaffInfoSearch.
	/// </summary>
	public class frmTaStaffInfoSearch : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel4;
		private Navigator1._0.NavigatorAuto nav;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Splitter splitter2;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Label label1;
		private C1.Win.C1FlexGrid.C1FlexGrid vs;
		private System.Windows.Forms.ComboBox cb1;
		private System.Windows.Forms.ComboBox cb2;
		private ArrayList a,b,c;
		private System.Windows.Forms.GroupBox gp1;
		private System.Windows.Forms.TextBox txt1;
		private System.Windows.Forms.Label lb1;
		private System.Windows.Forms.GroupBox gp2;
		private System.Windows.Forms.CheckBox ck;
		private System.Windows.Forms.Label lb2;
		private System.Windows.Forms.Label lb3;
		private System.Windows.Forms.ComboBox cb3;
		private System.Windows.Forms.GroupBox gp3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox gp4;
		private System.Windows.Forms.Label lb4;
		private C1.Win.C1Input.C1DateEdit dt1;
		private C1.Win.C1Input.C1DateEdit dt2;
		private System.Windows.Forms.Button cmd_add;
		private C1.Win.C1FlexGrid.C1FlexGrid vs1;
		private System.Windows.Forms.Button cmd_Show;
		private System.Windows.Forms.Button cmd_clear;
		private C1.C1Excel.C1XLBook c1XLBook1;
		private System.Windows.Forms.Panel p2;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Panel p1;
		private System.Windows.Forms.Button cmd_ad;
		private System.Windows.Forms.Button cmd_bk;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.GroupBox gp;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox gp_sex;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rd_INH_DT;
		private System.Windows.Forms.RadioButton rd_VAC_DT;
		private System.Windows.Forms.RadioButton rd_LAB_ED;
		private System.Windows.Forms.RadioButton rd_LA1_ED;
		private System.Windows.Forms.RadioButton rd_BHX_ED;
		private System.Windows.Forms.RadioButton rd_BHY_ED;
		private System.Windows.Forms.RadioButton rd_BHL_ED;
		private System.Windows.Forms.RadioButton rd_none;
		private System.Windows.Forms.Button cmd_search;
		private System.Windows.Forms.ComboBox cb_DEP_ID;
		private System.Windows.Forms.ComboBox cb_POS_ID;
		private System.Windows.Forms.ComboBox cb_GRT_ID;
		private System.Windows.Forms.ComboBox cb_GRP_ID;
		private System.Windows.Forms.ComboBox cb_LEV_ID;
		private System.Windows.Forms.ComboBox cb_EDU_ID;
		private System.Windows.Forms.ComboBox cb_PRO_ID;
		private System.Windows.Forms.ComboBox cb_TYP_ID;
		private System.Windows.Forms.ComboBox cb_CIT_ID;
		private System.Windows.Forms.ComboBox cb_GRA_ID;
		private System.Windows.Forms.ComboBox cb_COU_ID;
		private System.Windows.Forms.ComboBox cb_VAC_ID;
		private System.Windows.Forms.DateTimePicker dt5;
		private System.Windows.Forms.DateTimePicker dt6;
		private System.Windows.Forms.RadioButton rd13;
		private System.Windows.Forms.RadioButton rd12;
		private System.Windows.Forms.RadioButton rd11;
		private System.Windows.Forms.RadioButton rd22;
		private System.Windows.Forms.RadioButton rd21;
		private System.Windows.Forms.RadioButton rd23;
		private System.Windows.Forms.RadioButton rd32;
		private System.Windows.Forms.RadioButton rd31;
		private System.Windows.Forms.RadioButton rd33;
		private System.Windows.Forms.RadioButton rd42;
		private System.Windows.Forms.RadioButton rd41;
		private System.Windows.Forms.RadioButton rd43;
		private System.Windows.Forms.RadioButton rd52;
		private System.Windows.Forms.RadioButton rd51;
		private System.Windows.Forms.TextBox txt_EMP_ID11;
		private System.Windows.Forms.TextBox txt_EMP_ID12;
		private System.Windows.Forms.TextBox txt_EMP_N1;
		private System.Windows.Forms.TextBox txt_EMP_NM;
		private System.Windows.Forms.TextBox txt_EMP_ID22;
		private System.Windows.Forms.TextBox txt_EMP_ID21;
		private System.Windows.Forms.TextBox txt_CRD_NO2;
		private System.Windows.Forms.TextBox txt_CRD_NO1;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.TextBox text;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.RadioButton rd_WRK_ED;
		private System.Windows.Forms.RadioButton rd_VIS_ED;
		private System.Windows.Forms.RadioButton rd_PAS_ED;
		private System.Windows.Forms.TextBox txt_WRK_ID;
		private System.Windows.Forms.TextBox txt_PAS_ID;
		private System.Windows.Forms.TextBox txt_VIS_ID;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.RadioButton rd91;
		private System.Windows.Forms.RadioButton r92;
		private System.Windows.Forms.Label lb_ctf;
		private System.Windows.Forms.ComboBox cb_CTF_ID;
		private C1.Win.C1FlexGrid.C1FlexGrid vs2;
		private System.Windows.Forms.CheckBox ck_CTF;
		private Navigator1._0.NavigatorAuto nav2;
		private System.Windows.Forms.CheckBox congdoan;
		private System.Windows.Forms.CheckBox cb_BHX_BT;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaStaffInfoSearch()
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
			this.nav2 = new Navigator1._0.NavigatorAuto();
			this.text = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.nav = new Navigator1._0.NavigatorAuto();
			this.cmd_bk = new System.Windows.Forms.Button();
			this.cmd_ad = new System.Windows.Forms.Button();
			this.panel7 = new System.Windows.Forms.Panel();
			this.cmd_clear = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel8 = new System.Windows.Forms.Panel();
			this.vs2 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.vs = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.p2 = new System.Windows.Forms.Panel();
			this.cmd_search = new System.Windows.Forms.Button();
			this.congdoan = new System.Windows.Forms.CheckBox();
			this.ck_CTF = new System.Windows.Forms.CheckBox();
			this.cb_CTF_ID = new System.Windows.Forms.ComboBox();
			this.lb_ctf = new System.Windows.Forms.Label();
			this.txt_VIS_ID = new System.Windows.Forms.TextBox();
			this.label23 = new System.Windows.Forms.Label();
			this.txt_PAS_ID = new System.Windows.Forms.TextBox();
			this.label22 = new System.Windows.Forms.Label();
			this.txt_WRK_ID = new System.Windows.Forms.TextBox();
			this.label21 = new System.Windows.Forms.Label();
			this.cb_PRO_ID = new System.Windows.Forms.ComboBox();
			this.cb_COU_ID = new System.Windows.Forms.ComboBox();
			this.cb_TYP_ID = new System.Windows.Forms.ComboBox();
			this.txt_CRD_NO2 = new System.Windows.Forms.TextBox();
			this.txt_CRD_NO1 = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.rd52 = new System.Windows.Forms.RadioButton();
			this.rd51 = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rd42 = new System.Windows.Forms.RadioButton();
			this.rd41 = new System.Windows.Forms.RadioButton();
			this.rd43 = new System.Windows.Forms.RadioButton();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.rd32 = new System.Windows.Forms.RadioButton();
			this.rd31 = new System.Windows.Forms.RadioButton();
			this.rd33 = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rd22 = new System.Windows.Forms.RadioButton();
			this.rd21 = new System.Windows.Forms.RadioButton();
			this.rd23 = new System.Windows.Forms.RadioButton();
			this.gp_sex = new System.Windows.Forms.GroupBox();
			this.rd12 = new System.Windows.Forms.RadioButton();
			this.rd11 = new System.Windows.Forms.RadioButton();
			this.rd13 = new System.Windows.Forms.RadioButton();
			this.cb_EDU_ID = new System.Windows.Forms.ComboBox();
			this.label13 = new System.Windows.Forms.Label();
			this.cb_VAC_ID = new System.Windows.Forms.ComboBox();
			this.label14 = new System.Windows.Forms.Label();
			this.cb_LEV_ID = new System.Windows.Forms.ComboBox();
			this.label15 = new System.Windows.Forms.Label();
			this.txt_EMP_ID22 = new System.Windows.Forms.TextBox();
			this.txt_EMP_ID21 = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.cb_CIT_ID = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.cb_GRA_ID = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txt_EMP_N1 = new System.Windows.Forms.TextBox();
			this.txt_EMP_NM = new System.Windows.Forms.TextBox();
			this.cb_GRT_ID = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.cb_GRP_ID = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.cb_POS_ID = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.cb_DEP_ID = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txt_EMP_ID12 = new System.Windows.Forms.TextBox();
			this.txt_EMP_ID11 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.r92 = new System.Windows.Forms.RadioButton();
			this.rd91 = new System.Windows.Forms.RadioButton();
			this.gp = new System.Windows.Forms.GroupBox();
			this.rd_WRK_ED = new System.Windows.Forms.RadioButton();
			this.rd_VIS_ED = new System.Windows.Forms.RadioButton();
			this.rd_PAS_ED = new System.Windows.Forms.RadioButton();
			this.rd_BHX_ED = new System.Windows.Forms.RadioButton();
			this.rd_LA1_ED = new System.Windows.Forms.RadioButton();
			this.rd_LAB_ED = new System.Windows.Forms.RadioButton();
			this.dt6 = new System.Windows.Forms.DateTimePicker();
			this.dt5 = new System.Windows.Forms.DateTimePicker();
			this.rd_none = new System.Windows.Forms.RadioButton();
			this.rd_BHL_ED = new System.Windows.Forms.RadioButton();
			this.rd_BHY_ED = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.rd_VAC_DT = new System.Windows.Forms.RadioButton();
			this.rd_INH_DT = new System.Windows.Forms.RadioButton();
			this.p1 = new System.Windows.Forms.Panel();
			this.vs1 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.splitter2 = new System.Windows.Forms.Splitter();
			this.panel6 = new System.Windows.Forms.Panel();
			this.cmd_Show = new System.Windows.Forms.Button();
			this.cmd_add = new System.Windows.Forms.Button();
			this.cb2 = new System.Windows.Forms.ComboBox();
			this.cb1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.gp4 = new System.Windows.Forms.GroupBox();
			this.dt2 = new C1.Win.C1Input.C1DateEdit();
			this.dt1 = new C1.Win.C1Input.C1DateEdit();
			this.lb4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.gp3 = new System.Windows.Forms.GroupBox();
			this.cb3 = new System.Windows.Forms.ComboBox();
			this.lb3 = new System.Windows.Forms.Label();
			this.gp2 = new System.Windows.Forms.GroupBox();
			this.ck = new System.Windows.Forms.CheckBox();
			this.lb2 = new System.Windows.Forms.Label();
			this.gp1 = new System.Windows.Forms.GroupBox();
			this.txt1 = new System.Windows.Forms.TextBox();
			this.lb1 = new System.Windows.Forms.Label();
			this.c1XLBook1 = new C1.C1Excel.C1XLBook();
			this.cb_BHX_BT = new System.Windows.Forms.CheckBox();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel8.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
			this.p2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.gp_sex.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.gp.SuspendLayout();
			this.p1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs1)).BeginInit();
			this.panel6.SuspendLayout();
			this.gp4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dt2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dt1)).BeginInit();
			this.gp3.SuspendLayout();
			this.gp2.SuspendLayout();
			this.gp1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.panel4);
			this.panel3.Controls.Add(this.panel7);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1040, 36);
			this.panel3.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Location = new System.Drawing.Point(532, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(508, 36);
			this.label5.TabIndex = 11;
			this.label5.Tag = "";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.nav2);
			this.panel4.Controls.Add(this.text);
			this.panel4.Controls.Add(this.label20);
			this.panel4.Controls.Add(this.nav);
			this.panel4.Controls.Add(this.cmd_bk);
			this.panel4.Controls.Add(this.cmd_ad);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(532, 36);
			this.panel4.TabIndex = 10;
			// 
			// nav2
			// 
			this.nav2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.nav2.Connection = null;
			this.nav2.ConnectionDel = null;
			this.nav2.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.nav2.form = null;
			this.nav2.FormName = null;
			this.nav2.Grid = null;
			this.nav2.History = false;
			this.nav2.IsNull = true;
			this.nav2.Language = "EN";
			this.nav2.Location = new System.Drawing.Point(118, 2);
			this.nav2.MSG_Exit = false;
			this.nav2.MulltiDel = false;
			this.nav2.Name = "nav2";
			this.nav2.Security = 0;
			this.nav2.ShowPopupMenu = true;
			this.nav2.Size = new System.Drawing.Size(297, 32);
			this.nav2.TabIndex = 15;
			this.nav2.ToolBar_Auto = true;
			this.nav2.UserID = null;
			this.nav2.Visible = false;
			this.nav2.VisibleGrid = true;
			this.nav2.Where = null;
			// 
			// text
			// 
			this.text.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.text.ForeColor = System.Drawing.Color.Red;
			this.text.Location = new System.Drawing.Point(368, 8);
			this.text.Name = "text";
			this.text.ReadOnly = true;
			this.text.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.text.Size = new System.Drawing.Size(52, 23);
			this.text.TabIndex = 11;
			this.text.Text = "0";
			// 
			// label20
			// 
			this.label20.Location = new System.Drawing.Point(280, 12);
			this.label20.Name = "label20";
			this.label20.TabIndex = 10;
			this.label20.Text = "label20";
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
			this.nav.ShowPopupMenu = true;
			this.nav.Size = new System.Drawing.Size(297, 32);
			this.nav.TabIndex = 9;
			this.nav.ToolBar_Auto = true;
			this.nav.UserID = null;
			this.nav.VisibleGrid = true;
			this.nav.Where = null;
			// 
			// cmd_bk
			// 
			this.cmd_bk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmd_bk.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_bk.Location = new System.Drawing.Point(428, 3);
			this.cmd_bk.Name = "cmd_bk";
			this.cmd_bk.Size = new System.Drawing.Size(100, 32);
			this.cmd_bk.TabIndex = 14;
			this.cmd_bk.Text = "Add";
			this.cmd_bk.Visible = false;
			this.cmd_bk.Click += new System.EventHandler(this.cmd_bk_Click);
			// 
			// cmd_ad
			// 
			this.cmd_ad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmd_ad.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_ad.Location = new System.Drawing.Point(428, 3);
			this.cmd_ad.Name = "cmd_ad";
			this.cmd_ad.Size = new System.Drawing.Size(100, 32);
			this.cmd_ad.TabIndex = 13;
			this.cmd_ad.Text = "Add";
			this.cmd_ad.Click += new System.EventHandler(this.cmd_ad_Click);
			// 
			// panel7
			// 
			this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(1040, 36);
			this.panel7.TabIndex = 2;
			// 
			// cmd_clear
			// 
			this.cmd_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmd_clear.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_clear.Location = new System.Drawing.Point(328, 62);
			this.cmd_clear.Name = "cmd_clear";
			this.cmd_clear.Size = new System.Drawing.Size(100, 24);
			this.cmd_clear.TabIndex = 12;
			this.cmd_clear.Text = "Add";
			this.cmd_clear.Click += new System.EventHandler(this.cmd_clear_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel5);
			this.panel1.Controls.Add(this.p1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 36);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1040, 550);
			this.panel1.TabIndex = 5;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.panel8);
			this.panel5.Controls.Add(this.p2);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(0, 116);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(1040, 434);
			this.panel5.TabIndex = 2;
			// 
			// panel8
			// 
			this.panel8.Controls.Add(this.vs2);
			this.panel8.Controls.Add(this.vs);
			this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel8.Location = new System.Drawing.Point(0, 228);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(1040, 206);
			this.panel8.TabIndex = 11;
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
			this.vs2.Size = new System.Drawing.Size(1040, 206);
			this.vs2.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs2.TabIndex = 10;
			this.vs2.Visible = false;
			// 
			// vs
			// 
			this.vs.AllowEditing = false;
			this.vs.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vs.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs.Location = new System.Drawing.Point(0, 0);
			this.vs.Name = "vs";
			this.vs.Size = new System.Drawing.Size(1040, 206);
			this.vs.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs.TabIndex = 9;
			// 
			// p2
			// 
			this.p2.BackColor = System.Drawing.Color.Moccasin;
			this.p2.Controls.Add(this.cb_BHX_BT);
			this.p2.Controls.Add(this.cmd_search);
			this.p2.Controls.Add(this.congdoan);
			this.p2.Controls.Add(this.ck_CTF);
			this.p2.Controls.Add(this.cb_CTF_ID);
			this.p2.Controls.Add(this.lb_ctf);
			this.p2.Controls.Add(this.txt_VIS_ID);
			this.p2.Controls.Add(this.label23);
			this.p2.Controls.Add(this.txt_PAS_ID);
			this.p2.Controls.Add(this.label22);
			this.p2.Controls.Add(this.txt_WRK_ID);
			this.p2.Controls.Add(this.label21);
			this.p2.Controls.Add(this.cb_PRO_ID);
			this.p2.Controls.Add(this.cb_COU_ID);
			this.p2.Controls.Add(this.cb_TYP_ID);
			this.p2.Controls.Add(this.txt_CRD_NO2);
			this.p2.Controls.Add(this.txt_CRD_NO1);
			this.p2.Controls.Add(this.label17);
			this.p2.Controls.Add(this.label18);
			this.p2.Controls.Add(this.label19);
			this.p2.Controls.Add(this.label16);
			this.p2.Controls.Add(this.rd52);
			this.p2.Controls.Add(this.rd51);
			this.p2.Controls.Add(this.groupBox1);
			this.p2.Controls.Add(this.groupBox3);
			this.p2.Controls.Add(this.groupBox2);
			this.p2.Controls.Add(this.gp_sex);
			this.p2.Controls.Add(this.cb_EDU_ID);
			this.p2.Controls.Add(this.label13);
			this.p2.Controls.Add(this.cb_VAC_ID);
			this.p2.Controls.Add(this.label14);
			this.p2.Controls.Add(this.cb_LEV_ID);
			this.p2.Controls.Add(this.label15);
			this.p2.Controls.Add(this.txt_EMP_ID22);
			this.p2.Controls.Add(this.txt_EMP_ID21);
			this.p2.Controls.Add(this.label12);
			this.p2.Controls.Add(this.cb_CIT_ID);
			this.p2.Controls.Add(this.label10);
			this.p2.Controls.Add(this.cb_GRA_ID);
			this.p2.Controls.Add(this.label11);
			this.p2.Controls.Add(this.txt_EMP_N1);
			this.p2.Controls.Add(this.txt_EMP_NM);
			this.p2.Controls.Add(this.cb_GRT_ID);
			this.p2.Controls.Add(this.label8);
			this.p2.Controls.Add(this.cb_GRP_ID);
			this.p2.Controls.Add(this.label9);
			this.p2.Controls.Add(this.cb_POS_ID);
			this.p2.Controls.Add(this.label7);
			this.p2.Controls.Add(this.cb_DEP_ID);
			this.p2.Controls.Add(this.label6);
			this.p2.Controls.Add(this.txt_EMP_ID12);
			this.p2.Controls.Add(this.txt_EMP_ID11);
			this.p2.Controls.Add(this.label4);
			this.p2.Controls.Add(this.label2);
			this.p2.Controls.Add(this.groupBox4);
			this.p2.Controls.Add(this.gp);
			this.p2.Dock = System.Windows.Forms.DockStyle.Top;
			this.p2.Location = new System.Drawing.Point(0, 0);
			this.p2.Name = "p2";
			this.p2.Size = new System.Drawing.Size(1040, 228);
			this.p2.TabIndex = 10;
			// 
			// cmd_search
			// 
			this.cmd_search.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_search.Location = new System.Drawing.Point(896, 56);
			this.cmd_search.Name = "cmd_search";
			this.cmd_search.Size = new System.Drawing.Size(100, 28);
			this.cmd_search.TabIndex = 41;
			this.cmd_search.Text = "Add";
			this.cmd_search.Click += new System.EventHandler(this.cmd_search_Click);
			// 
			// congdoan
			// 
			this.congdoan.Location = new System.Drawing.Point(896, 84);
			this.congdoan.Name = "congdoan";
			this.congdoan.TabIndex = 54;
			this.congdoan.Tag = "congdoan";
			// 
			// ck_CTF
			// 
			this.ck_CTF.ForeColor = System.Drawing.Color.DeepPink;
			this.ck_CTF.Location = new System.Drawing.Point(608, 120);
			this.ck_CTF.Name = "ck_CTF";
			this.ck_CTF.Size = new System.Drawing.Size(148, 16);
			this.ck_CTF.TabIndex = 53;
			this.ck_CTF.Text = "Certificate";
			this.ck_CTF.Visible = false;
			this.ck_CTF.CheckedChanged += new System.EventHandler(this.ck_CTF_CheckedChanged);
			// 
			// cb_CTF_ID
			// 
			this.cb_CTF_ID.ForeColor = System.Drawing.Color.DeepPink;
			this.cb_CTF_ID.Location = new System.Drawing.Point(860, 116);
			this.cb_CTF_ID.Name = "cb_CTF_ID";
			this.cb_CTF_ID.Size = new System.Drawing.Size(164, 24);
			this.cb_CTF_ID.TabIndex = 52;
			this.cb_CTF_ID.Tag = "";
			this.cb_CTF_ID.Text = "comboBox1";
			this.cb_CTF_ID.Visible = false;
			// 
			// lb_ctf
			// 
			this.lb_ctf.ForeColor = System.Drawing.Color.DeepPink;
			this.lb_ctf.Location = new System.Drawing.Point(772, 120);
			this.lb_ctf.Name = "lb_ctf";
			this.lb_ctf.Size = new System.Drawing.Size(84, 16);
			this.lb_ctf.TabIndex = 51;
			this.lb_ctf.Text = "certificate";
			this.lb_ctf.Visible = false;
			// 
			// txt_VIS_ID
			// 
			this.txt_VIS_ID.Location = new System.Drawing.Point(316, 116);
			this.txt_VIS_ID.Name = "txt_VIS_ID";
			this.txt_VIS_ID.Size = new System.Drawing.Size(92, 23);
			this.txt_VIS_ID.TabIndex = 49;
			this.txt_VIS_ID.Text = "";
			// 
			// label23
			// 
			this.label23.Location = new System.Drawing.Point(220, 116);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(92, 20);
			this.label23.TabIndex = 48;
			this.label23.Text = "label23";
			// 
			// txt_PAS_ID
			// 
			this.txt_PAS_ID.Location = new System.Drawing.Point(116, 116);
			this.txt_PAS_ID.Name = "txt_PAS_ID";
			this.txt_PAS_ID.TabIndex = 47;
			this.txt_PAS_ID.Text = "";
			// 
			// label22
			// 
			this.label22.Location = new System.Drawing.Point(8, 116);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(116, 20);
			this.label22.TabIndex = 46;
			this.label22.Text = "label22";
			// 
			// txt_WRK_ID
			// 
			this.txt_WRK_ID.Location = new System.Drawing.Point(500, 116);
			this.txt_WRK_ID.Name = "txt_WRK_ID";
			this.txt_WRK_ID.TabIndex = 45;
			this.txt_WRK_ID.Text = "";
			// 
			// label21
			// 
			this.label21.Location = new System.Drawing.Point(412, 116);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(84, 20);
			this.label21.TabIndex = 44;
			this.label21.Text = "label21";
			// 
			// cb_PRO_ID
			// 
			this.cb_PRO_ID.Location = new System.Drawing.Point(600, 88);
			this.cb_PRO_ID.Name = "cb_PRO_ID";
			this.cb_PRO_ID.Size = new System.Drawing.Size(100, 24);
			this.cb_PRO_ID.TabIndex = 33;
			this.cb_PRO_ID.Text = "comboBox11";
			// 
			// cb_COU_ID
			// 
			this.cb_COU_ID.Location = new System.Drawing.Point(788, 88);
			this.cb_COU_ID.Name = "cb_COU_ID";
			this.cb_COU_ID.Size = new System.Drawing.Size(100, 24);
			this.cb_COU_ID.TabIndex = 35;
			this.cb_COU_ID.Text = "comboBox10";
			// 
			// cb_TYP_ID
			// 
			this.cb_TYP_ID.Location = new System.Drawing.Point(408, 88);
			this.cb_TYP_ID.Name = "cb_TYP_ID";
			this.cb_TYP_ID.Size = new System.Drawing.Size(100, 24);
			this.cb_TYP_ID.TabIndex = 31;
			this.cb_TYP_ID.Text = "comboBox12";
			// 
			// txt_CRD_NO2
			// 
			this.txt_CRD_NO2.Location = new System.Drawing.Point(216, 88);
			this.txt_CRD_NO2.Name = "txt_CRD_NO2";
			this.txt_CRD_NO2.TabIndex = 29;
			this.txt_CRD_NO2.Text = "";
			// 
			// txt_CRD_NO1
			// 
			this.txt_CRD_NO1.Location = new System.Drawing.Point(116, 88);
			this.txt_CRD_NO1.Name = "txt_CRD_NO1";
			this.txt_CRD_NO1.TabIndex = 28;
			this.txt_CRD_NO1.Text = "";
			this.txt_CRD_NO1.TextChanged += new System.EventHandler(this.txt_CRD_NO1_TextChanged);
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(704, 96);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(100, 20);
			this.label17.TabIndex = 34;
			this.label17.Text = "label17";
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(512, 96);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(100, 20);
			this.label18.TabIndex = 32;
			this.label18.Text = "label18";
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(320, 96);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(100, 20);
			this.label19.TabIndex = 30;
			this.label19.Text = "label19";
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(8, 96);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(116, 16);
			this.label16.TabIndex = 27;
			this.label16.Text = "label16";
			// 
			// rd52
			// 
			this.rd52.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rd52.Location = new System.Drawing.Point(892, 32);
			this.rd52.Name = "rd52";
			this.rd52.Size = new System.Drawing.Size(132, 20);
			this.rd52.TabIndex = 43;
			this.rd52.Text = "abc";
			// 
			// rd51
			// 
			this.rd51.Checked = true;
			this.rd51.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rd51.Location = new System.Drawing.Point(892, 8);
			this.rd51.Name = "rd51";
			this.rd51.Size = new System.Drawing.Size(132, 20);
			this.rd51.TabIndex = 42;
			this.rd51.TabStop = true;
			this.rd51.Text = "abc";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rd42);
			this.groupBox1.Controls.Add(this.rd41);
			this.groupBox1.Controls.Add(this.rd43);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(900, 140);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(104, 87);
			this.groupBox1.TabIndex = 40;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Sex";
			// 
			// rd42
			// 
			this.rd42.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rd42.Location = new System.Drawing.Point(4, 40);
			this.rd42.Name = "rd42";
			this.rd42.Size = new System.Drawing.Size(88, 20);
			this.rd42.TabIndex = 10;
			this.rd42.Tag = "(LCK_BT=0 or LCK_BT is null)";
			this.rd42.Text = "abc";
			// 
			// rd41
			// 
			this.rd41.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rd41.Location = new System.Drawing.Point(4, 16);
			this.rd41.Name = "rd41";
			this.rd41.Size = new System.Drawing.Size(88, 20);
			this.rd41.TabIndex = 9;
			this.rd41.Tag = "LCK_BT=1";
			this.rd41.Text = "abc";
			// 
			// rd43
			// 
			this.rd43.Checked = true;
			this.rd43.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rd43.Location = new System.Drawing.Point(4, 64);
			this.rd43.Name = "rd43";
			this.rd43.Size = new System.Drawing.Size(88, 20);
			this.rd43.TabIndex = 11;
			this.rd43.TabStop = true;
			this.rd43.Text = "abc";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.rd32);
			this.groupBox3.Controls.Add(this.rd31);
			this.groupBox3.Controls.Add(this.rd33);
			this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox3.Location = new System.Drawing.Point(796, 140);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(104, 87);
			this.groupBox3.TabIndex = 39;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Sex";
			// 
			// rd32
			// 
			this.rd32.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rd32.Location = new System.Drawing.Point(4, 40);
			this.rd32.Name = "rd32";
			this.rd32.Size = new System.Drawing.Size(88, 20);
			this.rd32.TabIndex = 10;
			this.rd32.Tag = "(VAC_BT=0 or VAC_BT is null)";
			this.rd32.Text = "abc";
			// 
			// rd31
			// 
			this.rd31.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rd31.Location = new System.Drawing.Point(4, 16);
			this.rd31.Name = "rd31";
			this.rd31.Size = new System.Drawing.Size(88, 20);
			this.rd31.TabIndex = 9;
			this.rd31.Tag = "VAC_BT=1";
			this.rd31.Text = "abc";
			// 
			// rd33
			// 
			this.rd33.Checked = true;
			this.rd33.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rd33.Location = new System.Drawing.Point(4, 64);
			this.rd33.Name = "rd33";
			this.rd33.Size = new System.Drawing.Size(88, 20);
			this.rd33.TabIndex = 11;
			this.rd33.TabStop = true;
			this.rd33.Text = "abc";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.rd22);
			this.groupBox2.Controls.Add(this.rd21);
			this.groupBox2.Controls.Add(this.rd23);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox2.Location = new System.Drawing.Point(692, 140);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(104, 87);
			this.groupBox2.TabIndex = 38;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Sex";
			// 
			// rd22
			// 
			this.rd22.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rd22.Location = new System.Drawing.Point(4, 40);
			this.rd22.Name = "rd22";
			this.rd22.Size = new System.Drawing.Size(88, 20);
			this.rd22.TabIndex = 10;
			this.rd22.Tag = "NEW_BT=1";
			this.rd22.Text = "abc";
			// 
			// rd21
			// 
			this.rd21.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rd21.Location = new System.Drawing.Point(4, 16);
			this.rd21.Name = "rd21";
			this.rd21.Size = new System.Drawing.Size(88, 20);
			this.rd21.TabIndex = 9;
			this.rd21.Tag = "(NEW_BT=0 or NEW_BT is null)";
			this.rd21.Text = "abc";
			// 
			// rd23
			// 
			this.rd23.Checked = true;
			this.rd23.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rd23.Location = new System.Drawing.Point(4, 64);
			this.rd23.Name = "rd23";
			this.rd23.Size = new System.Drawing.Size(88, 20);
			this.rd23.TabIndex = 11;
			this.rd23.TabStop = true;
			this.rd23.Text = "abc";
			// 
			// gp_sex
			// 
			this.gp_sex.Controls.Add(this.rd12);
			this.gp_sex.Controls.Add(this.rd11);
			this.gp_sex.Controls.Add(this.rd13);
			this.gp_sex.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gp_sex.Location = new System.Drawing.Point(588, 140);
			this.gp_sex.Name = "gp_sex";
			this.gp_sex.Size = new System.Drawing.Size(104, 87);
			this.gp_sex.TabIndex = 37;
			this.gp_sex.TabStop = false;
			this.gp_sex.Text = "Sex";
			// 
			// rd12
			// 
			this.rd12.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rd12.Location = new System.Drawing.Point(4, 40);
			this.rd12.Name = "rd12";
			this.rd12.Size = new System.Drawing.Size(88, 20);
			this.rd12.TabIndex = 7;
			this.rd12.Tag = "(SEX_BT=0 or SEX_BT is null)";
			this.rd12.Text = "abc";
			// 
			// rd11
			// 
			this.rd11.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rd11.Location = new System.Drawing.Point(4, 16);
			this.rd11.Name = "rd11";
			this.rd11.Size = new System.Drawing.Size(88, 20);
			this.rd11.TabIndex = 6;
			this.rd11.Tag = "SEX_BT=1";
			this.rd11.Text = "abc";
			// 
			// rd13
			// 
			this.rd13.Checked = true;
			this.rd13.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rd13.Location = new System.Drawing.Point(4, 64);
			this.rd13.Name = "rd13";
			this.rd13.Size = new System.Drawing.Size(88, 20);
			this.rd13.TabIndex = 8;
			this.rd13.TabStop = true;
			this.rd13.Text = "abc";
			// 
			// cb_EDU_ID
			// 
			this.cb_EDU_ID.Location = new System.Drawing.Point(788, 60);
			this.cb_EDU_ID.Name = "cb_EDU_ID";
			this.cb_EDU_ID.Size = new System.Drawing.Size(100, 24);
			this.cb_EDU_ID.TabIndex = 26;
			this.cb_EDU_ID.Text = "comboBox7";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(704, 68);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(100, 20);
			this.label13.TabIndex = 25;
			this.label13.Text = "label13";
			// 
			// cb_VAC_ID
			// 
			this.cb_VAC_ID.Location = new System.Drawing.Point(600, 60);
			this.cb_VAC_ID.Name = "cb_VAC_ID";
			this.cb_VAC_ID.Size = new System.Drawing.Size(100, 24);
			this.cb_VAC_ID.TabIndex = 24;
			this.cb_VAC_ID.Text = "comboBox8";
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(512, 68);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(100, 20);
			this.label14.TabIndex = 23;
			this.label14.Text = "label14";
			// 
			// cb_LEV_ID
			// 
			this.cb_LEV_ID.Location = new System.Drawing.Point(408, 60);
			this.cb_LEV_ID.Name = "cb_LEV_ID";
			this.cb_LEV_ID.Size = new System.Drawing.Size(100, 24);
			this.cb_LEV_ID.TabIndex = 22;
			this.cb_LEV_ID.Text = "comboBox9";
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(320, 68);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(100, 20);
			this.label15.TabIndex = 21;
			this.label15.Text = "label15";
			// 
			// txt_EMP_ID22
			// 
			this.txt_EMP_ID22.BackColor = System.Drawing.Color.PeachPuff;
			this.txt_EMP_ID22.Location = new System.Drawing.Point(216, 60);
			this.txt_EMP_ID22.Name = "txt_EMP_ID22";
			this.txt_EMP_ID22.TabIndex = 20;
			this.txt_EMP_ID22.Text = "";
			// 
			// txt_EMP_ID21
			// 
			this.txt_EMP_ID21.BackColor = System.Drawing.Color.PeachPuff;
			this.txt_EMP_ID21.Location = new System.Drawing.Point(116, 60);
			this.txt_EMP_ID21.Name = "txt_EMP_ID21";
			this.txt_EMP_ID21.TabIndex = 19;
			this.txt_EMP_ID21.Text = "";
			this.txt_EMP_ID21.TextChanged += new System.EventHandler(this.txt_EMP_ID21_TextChanged);
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(8, 68);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(116, 20);
			this.label12.TabIndex = 18;
			this.label12.Text = "label12";
			// 
			// cb_CIT_ID
			// 
			this.cb_CIT_ID.Location = new System.Drawing.Point(788, 32);
			this.cb_CIT_ID.Name = "cb_CIT_ID";
			this.cb_CIT_ID.Size = new System.Drawing.Size(100, 24);
			this.cb_CIT_ID.TabIndex = 17;
			this.cb_CIT_ID.Text = "comboBox5";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(704, 40);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 20);
			this.label10.TabIndex = 16;
			this.label10.Text = "label10";
			// 
			// cb_GRA_ID
			// 
			this.cb_GRA_ID.Location = new System.Drawing.Point(788, 4);
			this.cb_GRA_ID.Name = "cb_GRA_ID";
			this.cb_GRA_ID.Size = new System.Drawing.Size(100, 24);
			this.cb_GRA_ID.TabIndex = 15;
			this.cb_GRA_ID.Text = "comboBox6";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(704, 12);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(100, 20);
			this.label11.TabIndex = 14;
			this.label11.Text = "label11";
			// 
			// txt_EMP_N1
			// 
			this.txt_EMP_N1.Location = new System.Drawing.Point(216, 4);
			this.txt_EMP_N1.Name = "txt_EMP_N1";
			this.txt_EMP_N1.TabIndex = 13;
			this.txt_EMP_N1.Text = "";
			// 
			// txt_EMP_NM
			// 
			this.txt_EMP_NM.BackColor = System.Drawing.Color.LightBlue;
			this.txt_EMP_NM.Location = new System.Drawing.Point(116, 4);
			this.txt_EMP_NM.Name = "txt_EMP_NM";
			this.txt_EMP_NM.TabIndex = 12;
			this.txt_EMP_NM.Text = "";
			// 
			// cb_GRT_ID
			// 
			this.cb_GRT_ID.Location = new System.Drawing.Point(600, 32);
			this.cb_GRT_ID.Name = "cb_GRT_ID";
			this.cb_GRT_ID.Size = new System.Drawing.Size(100, 24);
			this.cb_GRT_ID.TabIndex = 11;
			this.cb_GRT_ID.Text = "comboBox3";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(512, 40);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 20);
			this.label8.TabIndex = 10;
			this.label8.Text = "label8";
			// 
			// cb_GRP_ID
			// 
			this.cb_GRP_ID.Location = new System.Drawing.Point(600, 4);
			this.cb_GRP_ID.Name = "cb_GRP_ID";
			this.cb_GRP_ID.Size = new System.Drawing.Size(100, 24);
			this.cb_GRP_ID.TabIndex = 9;
			this.cb_GRP_ID.Text = "comboBox4";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(512, 12);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 20);
			this.label9.TabIndex = 8;
			this.label9.Text = "label9";
			// 
			// cb_POS_ID
			// 
			this.cb_POS_ID.Location = new System.Drawing.Point(408, 32);
			this.cb_POS_ID.Name = "cb_POS_ID";
			this.cb_POS_ID.Size = new System.Drawing.Size(100, 24);
			this.cb_POS_ID.TabIndex = 7;
			this.cb_POS_ID.Text = "comboBox2";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(320, 40);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 20);
			this.label7.TabIndex = 6;
			this.label7.Text = "label7";
			// 
			// cb_DEP_ID
			// 
			this.cb_DEP_ID.Location = new System.Drawing.Point(408, 4);
			this.cb_DEP_ID.Name = "cb_DEP_ID";
			this.cb_DEP_ID.Size = new System.Drawing.Size(100, 24);
			this.cb_DEP_ID.TabIndex = 5;
			this.cb_DEP_ID.Tag = "";
			this.cb_DEP_ID.Text = "comboBox1";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(320, 12);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 20);
			this.label6.TabIndex = 4;
			this.label6.Text = "label6";
			// 
			// txt_EMP_ID12
			// 
			this.txt_EMP_ID12.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt_EMP_ID12.Location = new System.Drawing.Point(216, 32);
			this.txt_EMP_ID12.Name = "txt_EMP_ID12";
			this.txt_EMP_ID12.TabIndex = 3;
			this.txt_EMP_ID12.Text = "";
			// 
			// txt_EMP_ID11
			// 
			this.txt_EMP_ID11.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt_EMP_ID11.Location = new System.Drawing.Point(116, 32);
			this.txt_EMP_ID11.Name = "txt_EMP_ID11";
			this.txt_EMP_ID11.TabIndex = 2;
			this.txt_EMP_ID11.Text = "";
			this.txt_EMP_ID11.TextChanged += new System.EventHandler(this.txt_EMP_ID11_TextChanged);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 40);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(116, 20);
			this.label4.TabIndex = 1;
			this.label4.Text = "label4";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(116, 20);
			this.label2.TabIndex = 0;
			this.label2.Text = "label2";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.r92);
			this.groupBox4.Controls.Add(this.rd91);
			this.groupBox4.Location = new System.Drawing.Point(896, 48);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(56, 36);
			this.groupBox4.TabIndex = 50;
			this.groupBox4.TabStop = false;
			this.groupBox4.Tag = "N";
			this.groupBox4.Visible = false;
			// 
			// r92
			// 
			this.r92.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.r92.Location = new System.Drawing.Point(108, 12);
			this.r92.Name = "r92";
			this.r92.Size = new System.Drawing.Size(76, 20);
			this.r92.TabIndex = 8;
			this.r92.Tag = "";
			this.r92.Text = "abc";
			// 
			// rd91
			// 
			this.rd91.Checked = true;
			this.rd91.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rd91.Location = new System.Drawing.Point(8, 12);
			this.rd91.Name = "rd91";
			this.rd91.Size = new System.Drawing.Size(72, 20);
			this.rd91.TabIndex = 7;
			this.rd91.TabStop = true;
			this.rd91.Tag = "";
			this.rd91.Text = "abc";
			// 
			// gp
			// 
			this.gp.Controls.Add(this.rd_WRK_ED);
			this.gp.Controls.Add(this.rd_VIS_ED);
			this.gp.Controls.Add(this.rd_PAS_ED);
			this.gp.Controls.Add(this.rd_BHX_ED);
			this.gp.Controls.Add(this.rd_LA1_ED);
			this.gp.Controls.Add(this.rd_LAB_ED);
			this.gp.Controls.Add(this.dt6);
			this.gp.Controls.Add(this.dt5);
			this.gp.Controls.Add(this.rd_none);
			this.gp.Controls.Add(this.rd_BHL_ED);
			this.gp.Controls.Add(this.rd_BHY_ED);
			this.gp.Controls.Add(this.radioButton3);
			this.gp.Controls.Add(this.rd_VAC_DT);
			this.gp.Controls.Add(this.rd_INH_DT);
			this.gp.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gp.Location = new System.Drawing.Point(4, 140);
			this.gp.Name = "gp";
			this.gp.Size = new System.Drawing.Size(584, 87);
			this.gp.TabIndex = 36;
			this.gp.TabStop = false;
			this.gp.Tag = "N";
			// 
			// rd_WRK_ED
			// 
			this.rd_WRK_ED.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rd_WRK_ED.Location = new System.Drawing.Point(332, 60);
			this.rd_WRK_ED.Name = "rd_WRK_ED";
			this.rd_WRK_ED.Size = new System.Drawing.Size(148, 24);
			this.rd_WRK_ED.TabIndex = 13;
			this.rd_WRK_ED.Tag = "";
			this.rd_WRK_ED.Text = "radioButton7";
			// 
			// rd_VIS_ED
			// 
			this.rd_VIS_ED.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rd_VIS_ED.Location = new System.Drawing.Point(332, 36);
			this.rd_VIS_ED.Name = "rd_VIS_ED";
			this.rd_VIS_ED.Size = new System.Drawing.Size(148, 24);
			this.rd_VIS_ED.TabIndex = 12;
			this.rd_VIS_ED.Text = "radioButton8";
			// 
			// rd_PAS_ED
			// 
			this.rd_PAS_ED.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rd_PAS_ED.Location = new System.Drawing.Point(332, 12);
			this.rd_PAS_ED.Name = "rd_PAS_ED";
			this.rd_PAS_ED.Size = new System.Drawing.Size(148, 24);
			this.rd_PAS_ED.TabIndex = 11;
			this.rd_PAS_ED.Text = "radioButton9";
			// 
			// rd_BHX_ED
			// 
			this.rd_BHX_ED.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rd_BHX_ED.Location = new System.Drawing.Point(112, 60);
			this.rd_BHX_ED.Name = "rd_BHX_ED";
			this.rd_BHX_ED.Size = new System.Drawing.Size(116, 24);
			this.rd_BHX_ED.TabIndex = 5;
			this.rd_BHX_ED.Text = "radioButton4";
			// 
			// rd_LA1_ED
			// 
			this.rd_LA1_ED.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rd_LA1_ED.Location = new System.Drawing.Point(112, 36);
			this.rd_LA1_ED.Name = "rd_LA1_ED";
			this.rd_LA1_ED.Size = new System.Drawing.Size(116, 24);
			this.rd_LA1_ED.TabIndex = 4;
			this.rd_LA1_ED.Text = "radioButton5";
			// 
			// rd_LAB_ED
			// 
			this.rd_LAB_ED.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rd_LAB_ED.Location = new System.Drawing.Point(112, 12);
			this.rd_LAB_ED.Name = "rd_LAB_ED";
			this.rd_LAB_ED.Size = new System.Drawing.Size(116, 24);
			this.rd_LAB_ED.TabIndex = 3;
			this.rd_LAB_ED.Text = "radioButton6";
			// 
			// dt6
			// 
			this.dt6.CustomFormat = "yyyy/MM/dd";
			this.dt6.Enabled = false;
			this.dt6.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dt6.Location = new System.Drawing.Point(484, 52);
			this.dt6.Name = "dt6";
			this.dt6.Size = new System.Drawing.Size(96, 23);
			this.dt6.TabIndex = 10;
			// 
			// dt5
			// 
			this.dt5.CustomFormat = "yyyy/MM/dd";
			this.dt5.Enabled = false;
			this.dt5.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dt5.Location = new System.Drawing.Point(484, 20);
			this.dt5.Name = "dt5";
			this.dt5.Size = new System.Drawing.Size(96, 23);
			this.dt5.TabIndex = 9;
			// 
			// rd_none
			// 
			this.rd_none.Checked = true;
			this.rd_none.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rd_none.Location = new System.Drawing.Point(4, 12);
			this.rd_none.Name = "rd_none";
			this.rd_none.TabIndex = 8;
			this.rd_none.TabStop = true;
			this.rd_none.Tag = "1";
			this.rd_none.Text = "radioButton7";
			this.rd_none.CheckedChanged += new System.EventHandler(this.rd_none_CheckedChanged);
			// 
			// rd_BHL_ED
			// 
			this.rd_BHL_ED.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rd_BHL_ED.Location = new System.Drawing.Point(228, 36);
			this.rd_BHL_ED.Name = "rd_BHL_ED";
			this.rd_BHL_ED.TabIndex = 7;
			this.rd_BHL_ED.Text = "radioButton8";
			// 
			// rd_BHY_ED
			// 
			this.rd_BHY_ED.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rd_BHY_ED.Location = new System.Drawing.Point(228, 12);
			this.rd_BHY_ED.Name = "rd_BHY_ED";
			this.rd_BHY_ED.TabIndex = 6;
			this.rd_BHY_ED.Text = "radioButton9";
			// 
			// radioButton3
			// 
			this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.radioButton3.Location = new System.Drawing.Point(228, 60);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(116, 24);
			this.radioButton3.TabIndex = 2;
			this.radioButton3.Tag = "1";
			this.radioButton3.Text = "radioButton3";
			this.radioButton3.Visible = false;
			// 
			// rd_VAC_DT
			// 
			this.rd_VAC_DT.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rd_VAC_DT.Location = new System.Drawing.Point(4, 60);
			this.rd_VAC_DT.Name = "rd_VAC_DT";
			this.rd_VAC_DT.Size = new System.Drawing.Size(116, 24);
			this.rd_VAC_DT.TabIndex = 1;
			this.rd_VAC_DT.Text = "radioButton2";
			// 
			// rd_INH_DT
			// 
			this.rd_INH_DT.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rd_INH_DT.Location = new System.Drawing.Point(4, 36);
			this.rd_INH_DT.Name = "rd_INH_DT";
			this.rd_INH_DT.Size = new System.Drawing.Size(116, 24);
			this.rd_INH_DT.TabIndex = 0;
			this.rd_INH_DT.Text = "radioButton1";
			// 
			// p1
			// 
			this.p1.Controls.Add(this.vs1);
			this.p1.Controls.Add(this.splitter2);
			this.p1.Controls.Add(this.panel6);
			this.p1.Dock = System.Windows.Forms.DockStyle.Top;
			this.p1.Location = new System.Drawing.Point(0, 0);
			this.p1.Name = "p1";
			this.p1.Size = new System.Drawing.Size(1040, 116);
			this.p1.TabIndex = 0;
			this.p1.Visible = false;
			// 
			// vs1
			// 
			this.vs1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs1.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vs1.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs1.Location = new System.Drawing.Point(439, 0);
			this.vs1.Name = "vs1";
			this.vs1.Size = new System.Drawing.Size(601, 116);
			this.vs1.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs1.TabIndex = 10;
			// 
			// splitter2
			// 
			this.splitter2.Location = new System.Drawing.Point(436, 0);
			this.splitter2.Name = "splitter2";
			this.splitter2.Size = new System.Drawing.Size(3, 116);
			this.splitter2.TabIndex = 1;
			this.splitter2.TabStop = false;
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.Moccasin;
			this.panel6.Controls.Add(this.cmd_clear);
			this.panel6.Controls.Add(this.cmd_Show);
			this.panel6.Controls.Add(this.cmd_add);
			this.panel6.Controls.Add(this.cb2);
			this.panel6.Controls.Add(this.cb1);
			this.panel6.Controls.Add(this.label1);
			this.panel6.Controls.Add(this.gp4);
			this.panel6.Controls.Add(this.gp3);
			this.panel6.Controls.Add(this.gp2);
			this.panel6.Controls.Add(this.gp1);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel6.Location = new System.Drawing.Point(0, 0);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(436, 116);
			this.panel6.TabIndex = 0;
			// 
			// cmd_Show
			// 
			this.cmd_Show.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_Show.Location = new System.Drawing.Point(328, 88);
			this.cmd_Show.Name = "cmd_Show";
			this.cmd_Show.Size = new System.Drawing.Size(100, 24);
			this.cmd_Show.TabIndex = 8;
			this.cmd_Show.Text = "Show";
			this.cmd_Show.Click += new System.EventHandler(this.cmd_Show_Click);
			// 
			// cmd_add
			// 
			this.cmd_add.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_add.Location = new System.Drawing.Point(328, 36);
			this.cmd_add.Name = "cmd_add";
			this.cmd_add.Size = new System.Drawing.Size(100, 24);
			this.cmd_add.TabIndex = 7;
			this.cmd_add.Text = "Add";
			this.cmd_add.Click += new System.EventHandler(this.cmd_add_Click);
			// 
			// cb2
			// 
			this.cb2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb2.Location = new System.Drawing.Point(316, 8);
			this.cb2.Name = "cb2";
			this.cb2.Size = new System.Drawing.Size(116, 24);
			this.cb2.TabIndex = 1;
			// 
			// cb1
			// 
			this.cb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb1.Location = new System.Drawing.Point(104, 8);
			this.cb1.Name = "cb1";
			this.cb1.Size = new System.Drawing.Size(212, 24);
			this.cb1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 12);
			this.label1.Name = "label1";
			this.label1.TabIndex = 2;
			this.label1.Text = "label1";
			// 
			// gp4
			// 
			this.gp4.Controls.Add(this.dt2);
			this.gp4.Controls.Add(this.dt1);
			this.gp4.Controls.Add(this.lb4);
			this.gp4.Controls.Add(this.label3);
			this.gp4.Location = new System.Drawing.Point(8, 36);
			this.gp4.Name = "gp4";
			this.gp4.Size = new System.Drawing.Size(312, 76);
			this.gp4.TabIndex = 6;
			this.gp4.TabStop = false;
			this.gp4.Tag = "N";
			this.gp4.Visible = false;
			// 
			// dt2
			// 
			this.dt2.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt2.Location = new System.Drawing.Point(96, 44);
			this.dt2.Name = "dt2";
			this.dt2.Size = new System.Drawing.Size(212, 23);
			this.dt2.TabIndex = 127;
			this.dt2.Tag = "CRD_DT";
			// 
			// dt1
			// 
			this.dt1.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt1.Location = new System.Drawing.Point(96, 16);
			this.dt1.Name = "dt1";
			this.dt1.Size = new System.Drawing.Size(212, 23);
			this.dt1.TabIndex = 125;
			this.dt1.Tag = "CRD_DT";
			// 
			// lb4
			// 
			this.lb4.Location = new System.Drawing.Point(4, 20);
			this.lb4.Name = "lb4";
			this.lb4.TabIndex = 3;
			this.lb4.Tag = "N";
			this.lb4.Text = "label2";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(4, 48);
			this.label3.Name = "label3";
			this.label3.TabIndex = 126;
			this.label3.Tag = "N";
			this.label3.Text = "-->";
			// 
			// gp3
			// 
			this.gp3.Controls.Add(this.cb3);
			this.gp3.Controls.Add(this.lb3);
			this.gp3.Location = new System.Drawing.Point(244, 60);
			this.gp3.Name = "gp3";
			this.gp3.Size = new System.Drawing.Size(312, 48);
			this.gp3.TabIndex = 5;
			this.gp3.TabStop = false;
			this.gp3.Tag = "N";
			this.gp3.Visible = false;
			// 
			// cb3
			// 
			this.cb3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb3.Location = new System.Drawing.Point(96, 14);
			this.cb3.Name = "cb3";
			this.cb3.Size = new System.Drawing.Size(212, 24);
			this.cb3.TabIndex = 4;
			// 
			// lb3
			// 
			this.lb3.Location = new System.Drawing.Point(8, 20);
			this.lb3.Name = "lb3";
			this.lb3.Size = new System.Drawing.Size(100, 20);
			this.lb3.TabIndex = 3;
			this.lb3.Tag = "N";
			this.lb3.Text = "label2";
			// 
			// gp2
			// 
			this.gp2.Controls.Add(this.ck);
			this.gp2.Controls.Add(this.lb2);
			this.gp2.Location = new System.Drawing.Point(240, 76);
			this.gp2.Name = "gp2";
			this.gp2.Size = new System.Drawing.Size(312, 48);
			this.gp2.TabIndex = 4;
			this.gp2.TabStop = false;
			this.gp2.Tag = "N";
			this.gp2.Visible = false;
			// 
			// ck
			// 
			this.ck.Location = new System.Drawing.Point(12, 16);
			this.ck.Name = "ck";
			this.ck.Size = new System.Drawing.Size(24, 24);
			this.ck.TabIndex = 4;
			this.ck.Tag = "N";
			// 
			// lb2
			// 
			this.lb2.Location = new System.Drawing.Point(36, 20);
			this.lb2.Name = "lb2";
			this.lb2.Size = new System.Drawing.Size(264, 23);
			this.lb2.TabIndex = 3;
			this.lb2.Tag = "N";
			this.lb2.Text = "label2";
			// 
			// gp1
			// 
			this.gp1.Controls.Add(this.txt1);
			this.gp1.Controls.Add(this.lb1);
			this.gp1.Location = new System.Drawing.Point(228, 80);
			this.gp1.Name = "gp1";
			this.gp1.Size = new System.Drawing.Size(312, 48);
			this.gp1.TabIndex = 3;
			this.gp1.TabStop = false;
			this.gp1.Tag = "N";
			this.gp1.Visible = false;
			// 
			// txt1
			// 
			this.txt1.Location = new System.Drawing.Point(108, 16);
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(192, 23);
			this.txt1.TabIndex = 0;
			this.txt1.Text = "textBox1";
			// 
			// lb1
			// 
			this.lb1.Location = new System.Drawing.Point(8, 20);
			this.lb1.Name = "lb1";
			this.lb1.Size = new System.Drawing.Size(124, 23);
			this.lb1.TabIndex = 3;
			this.lb1.Tag = "N";
			this.lb1.Text = "label2";
			// 
			// cb_BHX_BT
			// 
			this.cb_BHX_BT.Location = new System.Drawing.Point(896, 112);
			this.cb_BHX_BT.Name = "cb_BHX_BT";
			this.cb_BHX_BT.TabIndex = 55;
			this.cb_BHX_BT.Tag = "BHX_BT";
			// 
			// frmTaStaffInfoSearch
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(1040, 586);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaStaffInfoSearch";
			this.Text = "frmTaStaffInfoSearch";
			this.Load += new System.EventHandler(this.frmTaStaffInfoSearch_Load);
			this.Closed += new System.EventHandler(this.frmTaStaffInfoSearch_Closed);
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			this.p2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.gp_sex.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.gp.ResumeLayout(false);
			this.p1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs1)).EndInit();
			this.panel6.ResumeLayout(false);
			this.gp4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dt2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dt1)).EndInit();
			this.gp3.ResumeLayout(false);
			this.gp2.ResumeLayout(false);
			this.gp1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaStaffInfoSearch_Load(object sender, System.EventArgs e)
		{
			Init_Form();	
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
			//string sql="";			
			switch (mnu1.MenuItems.IndexOf((MenuItem)sender))
			{
				case 0:		
					ReportFromVS rpt=new ReportFromVS();
					rpt.RPT2(c1XLBook1,vs,mnu1.MenuItems[mnu1.MenuItems.IndexOf((MenuItem)sender)].Text,"STD_HR_01");					
					break;
				
			}
		}
		#endregion
		
		#region Init Form
		string format;
		private void Init_Form()
		{		
			format=PublicFunction.GetOption("DATE");					
			Init_vs();			
			Init_vs1();
			vs2.Tag="N";
			nav2.Tag="N";
			if(PublicFunction.GetOption("CERTIFICATE")=="1")
			{
				lb_ctf.Visible=false;
				cb_CTF_ID.Visible=false;
				ck_CTF.Visible=true;
				vs2.Tag="";
				nav2.Tag="";
				Init_vs2();
			}
			Basic.Function.PublicFunction.L_Init_Label(this);					
			Init_CB();
			//City
			string sql;
			sql="Select FIE_NM,"+PublicFunction.L_Lag+" from GP_SYS_STAFFSEARCH a,SYS_LABEL_VS b"
				+" where FNAME=FIE_NM and NAME=N'"+this.Name+"_vs' ORDER BY "+PublicFunction.L_Lag;
			PublicFunction.InitCB(cb1,sql,false);		
			sql="Select * from GP_SYS_STAFFSEARCH ";
			a=new ArrayList();
			b=new ArrayList();
			c=new ArrayList();
			Func.RecordSet rs=new Func.RecordSet(sql,PublicFunction.C_con);
			for(int i=0;i<rs.rows;i++)
			{
				a.Add(rs.record(i,0));
				b.Add(rs.record(i,1));
				c.Add(rs.record(i,2));
			}
			cb1.SelectedIndexChanged+=new EventHandler(cb1_SelectedIndexChanged);
			InitCondition();	
		}
		private void Init_vs()
		{
			nav.cmd_copy.Visible=false;	
			nav.cmd_save.Visible=false;
			nav.cmd_search.Visible=false;	
			nav.cmd_delete.Visible=false;
			nav.cmd_add.Visible=false;	
			PublicFunction.InitNav(this,vs,nav);			
			
			
			vs.Cols["CRD_DT"].Format=format;
			vs.Cols["INH_DT"].Format=format;
			vs.Cols["BIR_DT"].Format=PublicFunction.GetOption("DOBDATE");

			vs.Cols["BHX_ST"].DataType=typeof(DateTime);
			vs.Cols["BHX_ED"].DataType=typeof(DateTime);
			vs.Cols["BHY_ST"].DataType=typeof(DateTime);
			vs.Cols["BHY_ED"].DataType=typeof(DateTime);
			vs.Cols["BHL_ST"].DataType=typeof(DateTime);
			vs.Cols["BHL_ED"].DataType=typeof(DateTime);
			vs.Cols["LAB_ST"].DataType=typeof(DateTime);
			vs.Cols["LAB_ED"].DataType=typeof(DateTime);
			vs.Cols["LA1_ST"].DataType=typeof(DateTime);
			vs.Cols["LA1_ED"].DataType=typeof(DateTime);

			vs.Cols["VIS_ED"].DataType=typeof(DateTime);
			vs.Cols["PAS_ED"].DataType=typeof(DateTime);
			vs.Cols["WRK_ED"].DataType=typeof(DateTime);
			vs.Cols["VIS_ST"].DataType=typeof(DateTime);
			vs.Cols["PAS_ST"].DataType=typeof(DateTime);
			vs.Cols["WRK_ST"].DataType=typeof(DateTime);

			vs.Cols["BHX_ST"].Format=format;
			vs.Cols["BHX_ED"].Format=format;
			vs.Cols["BHY_ST"].Format=format;
			vs.Cols["BHY_ED"].Format=format;
			vs.Cols["BHL_ST"].Format=format;
			vs.Cols["BHL_ED"].Format=format;
			vs.Cols["LAB_ST"].Format=format;
			vs.Cols["LAB_ED"].Format=format;
			vs.Cols["LA1_ST"].Format=format;
			vs.Cols["LA1_ED"].Format=format;
			vs.Cols["VIS_ED"].Format=format;
			vs.Cols["PAS_ED"].Format=format;
			vs.Cols["WRK_ED"].Format=format;
			vs.Cols["VIS_ST"].Format=format;
			vs.Cols["PAS_ST"].Format=format;
			vs.Cols["WRK_ST"].Format=format;
			dt5.CustomFormat=format;
			dt6.CustomFormat=format;			

			vs.Styles.Add("VAC_BT");
			vs.Styles.Add("EMP_NM");
			vs.Styles.Add("EMP_I1");
			vs.Styles["VAC_BT"].BackColor=Color.DarkGray;
			vs.Styles["EMP_NM"].BackColor=Color.LightBlue;
			vs.Styles["EMP_I1"].BackColor=Color.PeachPuff;
			//vs.Cols["VAC_BT"].Style=vs.Styles["VAC_BT"];
			vs.Cols["EMP_NM"].Style=vs.Styles["EMP_NM"];
			vs.Cols["EMP_I1"].Style=vs.Styles["EMP_I1"];		
			//vs.Cols["VAC_BT"].DataType=typeof(Boolean);

			nav.TBarClick+=new ToolBarButtonClickEventHandler(nav_TBarClick);
			vs.DoubleClick+=new EventHandler(vs_DoubleClick);
			nav.ToolBar_Auto=false;			
		}
		private void Init_vs2()
		{
			PublicFunction.InitNav(this,vs2,nav2);
			vs2.Cols["CRD_DT"].Format=format;
			vs2.Cols["INH_DT"].Format=format;
			vs2.Cols["BIR_DT"].Format=PublicFunction.GetOption("DOBDATE");
			vs2.Styles.Add("VAC_BT");
			vs2.Styles.Add("EMP_NM");
			vs2.Styles.Add("EMP_I1");
			vs2.Styles["VAC_BT"].BackColor=Color.DarkGray;
			vs2.Styles["EMP_NM"].BackColor=Color.LightBlue;
			vs2.Styles["EMP_I1"].BackColor=Color.PeachPuff;
			vs2.Cols["VAC_BT"].Style=vs.Styles["VAC_BT"];
			vs2.Cols["EMP_NM"].Style=vs.Styles["EMP_NM"];
			vs2.Cols["EMP_I1"].Style=vs.Styles["EMP_I1"];		
			vs2.Cols["VAC_BT"].DataType=typeof(Boolean);
		}
		private void Init_vs1()
		{
			vs1.Cols.Count=4;
			vs1.Cols[1].Name="AND";
			vs1.Cols[1].ComboList="And|OR";
			vs1.Cols[2].Name="SQL1";
			vs1.Cols[2].AllowEditing=false;
			vs1.Cols[3].Name="SQL";
			vs1.Cols[3].Visible=false;
			vs1.Rows.Count=1;
			vs1.AutoSizeCols();
			vs1.DoubleClick+=new EventHandler(vs1_DoubleClick);
		}		
		private void   Init_CB()
		{			
			string sql;			
			//Department
			sql=PublicFunction.GetDep(this.Tag+"");			
			vs.Cols["DEP_ID"].DataMap=PublicFunction.InitCBForVS(sql);
			if(PublicFunction.GetOption("CERTIFICATE")=="1")
				vs2.Cols["DEP_ID"].DataMap=PublicFunction.InitCBForVS(sql);
			PublicFunction.InitCB(cb_DEP_ID,sql);
			//City
			sql="Select CIT_ID,CIT_NM from FILA03A";		
			vs.Cols["CIT_ID"].DataMap=PublicFunction.InitCBForVS(sql);
			PublicFunction.InitCB(cb_CIT_ID,sql);
			//education
			sql="Select EDU_ID,EDU_NM from FILA04A";		
			vs.Cols["EDU_ID"].DataMap=PublicFunction.InitCBForVS(sql);
			PublicFunction.InitCB(cb_EDU_ID,sql);
			//Profession
			sql="Select PRO_ID,PRO_NM from FILA05A";		
			vs.Cols["PRO_ID"].DataMap=PublicFunction.InitCBForVS(sql);
			if(PublicFunction.GetOption("CERTIFICATE")=="1")
				vs2.Cols["PRO_ID"].DataMap=PublicFunction.InitCBForVS(sql);
			PublicFunction.InitCB(cb_PRO_ID,sql);
			//Graduation
			sql="Select GRA_ID,GRA_NM from FILA10A";	
			vs.Cols["GRA_ID"].DataMap=PublicFunction.InitCBForVS(sql);	
			PublicFunction.InitCB(cb_GRA_ID,sql);
			//Certificate
			if(PublicFunction.GetOption("CERTIFICATE")=="1")
			{
				sql="Select CTF_ID,CTF_NM from FILA10B";
				vs2.Cols["CTF_ID"].DataMap=PublicFunction.InitCBForVS(sql);
				PublicFunction.InitCB(cb_CTF_ID,sql);

			}
			//Position
			sql="Select POS_ID,POS_NM from FILA07A";		
			vs.Cols["POS_ID"].DataMap=PublicFunction.InitCBForVS(sql);
			if(PublicFunction.GetOption("CERTIFICATE")=="1")
				vs2.Cols["POS_ID"].DataMap=PublicFunction.InitCBForVS(sql);
			PublicFunction.InitCB(cb_POS_ID,sql);	
			//Nguyen Quan Native Place
			sql="Select NAT_ID,NAT_NM from FILA18A";
			vs.Cols["NAT_CO"].DataMap=PublicFunction.InitCBForVS(sql);			
			//Nature Loai Nhan Vien
			sql="Select TYP_ID,TYP_NM from FILA11A";
			vs.Cols["TYP_ID"].DataMap=PublicFunction.InitCBForVS(sql);
			if(PublicFunction.GetOption("CERTIFICATE")=="1")
				vs2.Cols["TYP_ID"].DataMap=PublicFunction.InitCBForVS(sql);
			PublicFunction.InitCB(cb_TYP_ID,sql);	
			//Group
			sql="Select GRP_ID,GRP_NM from FILA08A";	
			vs.Cols["GRP_ID"].DataMap=PublicFunction.InitCBForVS(sql);
			PublicFunction.InitCB(cb_GRP_ID,sql);	
			//Type Group
			sql="Select GRT_ID,GRT_NM from FILA09A";		
			vs.Cols["GRT_ID"].DataMap=PublicFunction.InitCBForVS(sql);
			PublicFunction.InitCB(cb_GRT_ID,sql);	
			//Nationality
			sql="Select COU_ID,COU_NM from FILA12A";			
			vs.Cols["COU_ID"].DataMap=PublicFunction.InitCBForVS(sql);	
			PublicFunction.InitCB(cb_COU_ID,sql);	
			//Vacate
			sql="Select VAC_ID,VAC_NM from FILA06A";			
			vs.Cols["VAC_ID"].DataMap=PublicFunction.InitCBForVS(sql);
			PublicFunction.InitCB(cb_VAC_ID,sql);	
			//Level
			sql="Select LEV_ID,LEV_NM from FILA19A";
			vs.Cols["LEV_ID"].DataMap=PublicFunction.InitCBForVS(sql);	
			PublicFunction.InitCB(cb_LEV_ID,sql);	
		}
		#endregion

		private void cb1_SelectedIndexChanged(object sender, EventArgs e)
		{		
			InitCondition();	
		}

		private void InitCondition()
		{
			switch(b[a.IndexOf(cb1.SelectedValue+"")]+"")
			{
				case "txt":			
					this.gp1.Location = new System.Drawing.Point(8, 36);
					gp1.Visible=true;
					lb1.Text=gp1.Text=cb1.Text;
					gp2.Visible=gp3.Visible=gp4.Visible=false;
					cb2.Items.Clear();
					cb2.Items.Add("=");
					cb2.Items.Add("like");
					txt1.Text="";					
					break;
				case "bit":
					this.gp2.Location = new System.Drawing.Point(8, 36);
					gp2.Visible=true;
					lb2.Text=gp2.Text=cb1.Text;
					gp1.Visible=gp3.Visible=gp4.Visible=false;
					cb2.Items.Clear();
					cb2.Items.Add("=");					
					break;		
				case "combo":
					this.gp3.Location = new System.Drawing.Point(8, 36);
					gp3.Visible=true;
					lb3.Text=gp3.Text=cb1.Text;
					gp1.Visible=gp2.Visible=gp4.Visible=false;
					cb2.Items.Clear();
					cb2.Items.Add("=");	
					cb3.DataSource=null;
					if(cb1.SelectedValue+""=="DEP_ID")
					{						
						PublicFunction.InitCB(cb3,PublicFunction.GetDep(this.Tag+""),false);
					}
					else
					{
						PublicFunction.InitCB(cb3,c[a.IndexOf(cb1.SelectedValue+"")]+"",false);
					}
					break;			
				case "datetime":
					this.gp4.Location = new System.Drawing.Point(8, 36);
					gp4.Visible=true;
					lb4.Text=gp4.Text=cb1.Text;
					gp1.Visible=gp2.Visible=gp3.Visible=false;
					cb2.Items.Clear();
					cb2.Items.Add("=");
					cb2.Items.Add(">");
					cb2.Items.Add(">=");
					cb2.Items.Add("<");
					cb2.Items.Add("<=");
					cb2.Items.Add("between");
					break;						
			}
			if(cb2.Items.Count>0)
				cb2.SelectedIndex=0;
		}

		private void cmd_add_Click(object sender, System.EventArgs e)
		{
			string sql="("+cb1.SelectedValue+"";
			string sql1=cb1.Text+"";
			switch(b[a.IndexOf(cb1.SelectedValue+"")]+"")
			{
				case "txt":			
					if(cb2.Text=="=")
						sql+="=N'"+txt1.Text+"'";
					else
						sql+=" like N'%"+txt1.Text+"%'";					
					sql1+=" "+cb2.Text +" "+ txt1.Text;
					break;
				case "bit":
					if(ck.Checked)
					{
						sql+="=1";
						sql1+=" "+cb2.Text +"Check";
					}
					else
					{
						sql+="=0 or "+cb1.SelectedValue+" is null";
						sql1+=" "+cb2.Text +"Uncheck";
					}
					break;							
				case "combo":
					sql+="=N'"+cb3.SelectedValue+"'";
					sql1+="="+cb3.Text;
					break;			
				case "datetime":
					if(cb2.Text=="between")
					{
						sql+=" between '"+((DateTime)dt1.Value).ToString("yyyy/MM/dd")
							+"' and '"+((DateTime)dt2.Value).ToString("yyyy/MM/dd")+"'";
						sql1+=" between '"+((DateTime)dt1.Value).ToString("yyyy/MM/dd")
							+"' and '"+((DateTime)dt2.Value).ToString("yyyy/MM/dd")+"'";
					}
					else
					{
						sql+=" = '"+((DateTime)dt1.Value).ToString("yyyy/MM/dd")+"'";
						sql1+=" = '"+((DateTime)dt1.Value).ToString("yyyy/MM/dd")+"'";
					}
					break;									
			}	
			vs1.Rows.Count++;
			vs1.Rows[vs1.Rows.Count-1]["AND"]="AND";
			vs1.Rows[vs1.Rows.Count-1]["SQL"]=sql+")";
			vs1.Rows[vs1.Rows.Count-1]["SQL1"]=sql1;
			vs1.AutoSizeCols();
		}

		private void cmd_Show_Click(object sender, System.EventArgs e)
		{
			string wh="";
			for(int i=1;i<vs1.Rows.Count;i++)
			{
				if(i!=1)
					wh+=" "+vs1.Rows[i]["AND"]+" ";
				wh+=vs1.Rows[i]["SQL"];
			}
			if(wh!="") wh+=" and ";
			wh+="DEP_ID in "+T_String.DEP_ID(this.Tag);
			nav.Show_VS(wh);
//			for(int i=1;i<vs.Rows.Count;i++)
//			{
//				if(vs.Rows[i]["VAC_BT"]+""=="True")
//				{
//					for(int c=1;c<vs.Cols.Count;c++)
//						vs.SetCellStyle(i,c, vs.Styles["VAC_BT"]);
//				}
//			}
			text.Text=vs.Rows.Count-1+"";
		}

		private void cmd_clear_Click(object sender, System.EventArgs e)
		{
			vs1.Rows.Count=1;
		}

		private void vs1_DoubleClick(object sender, EventArgs e)
		{
			if(vs1.Row>0)
				vs1.RemoveItem(vs1.Row);
		}

		private void txt_EMP_ID11_TextChanged(object sender, System.EventArgs e)
		{
			txt_EMP_ID12.Text=txt_EMP_ID11.Text;
		}

		private void txt_EMP_ID21_TextChanged(object sender, System.EventArgs e)
		{
			txt_EMP_ID22.Text=txt_EMP_ID21.Text;
		}

		private void txt_CRD_NO1_TextChanged(object sender, System.EventArgs e)
		{
			txt_CRD_NO2.Text=txt_CRD_NO1.Text;
		}

		#region Tbar
		private void nav_TBarClick(object sender, ToolBarButtonClickEventArgs e)
		{			
			
			if (e.Button.Equals(nav.cmd_refresh))
			{
				if(nav.wh!="")
					nav.ToolBar_Click(e);
				else
					nav.Show_VS("DEP_ID in "+T_String.DEP_ID(this.Tag));
				return;
			}
			nav.ToolBar_Click(e);
		}
		#endregion

		private void vs_DoubleClick(object sender, EventArgs e)
		{
			if(vs.Row>0)
			{
				if(PublicFunction.AccessLevel(30,5))
				{
					frmTaStaffInfo dlg=new frmTaStaffInfo();
					dlg.Tag=30;
					dlg.MdiParent=this.MdiParent;					
					dlg.Show();					
					dlg.Show_vs(vs.Rows[vs.Row]["EMP_ID"]+"");
				}
			}
		}

		private void cmd_ad_Click(object sender, System.EventArgs e)
		{
			cmd_ad.Visible= p2.Visible=false;
			cmd_bk.Visible=p1.Visible=true;
			
		}

		private void cmd_bk_Click(object sender, System.EventArgs e)
		{
			cmd_ad.Visible=p2.Visible=true;
			cmd_bk.Visible=p1.Visible=false;
		}

		private void rd_none_CheckedChanged(object sender, System.EventArgs e)
		{
			dt5.Enabled=dt6.Enabled=!rd_none.Checked; 
		}

		private void cmd_search_Click(object sender, System.EventArgs e)
		{
			string sql="";
			string sql1="";
			sql=Get_CB();
			if(txt_EMP_NM.Text!="")
			{
				sql=AndOr(sql);
				sql+="EMP_NM like N'%"+txt_EMP_NM.Text+"%'";
			}
			if(txt_EMP_N1.Text!="")
			{
				sql=AndOr(sql);
				sql+="EMP_N1 like N'%"+txt_EMP_N1.Text+"%'";
			}
			if(txt_EMP_ID11.Text!="")
			{
				sql=AndOr(sql);
				sql+="(a.EMP_ID between N'"+txt_EMP_ID11.Text+"' and N'"+txt_EMP_ID12.Text+"')";
			}
			if(txt_EMP_ID21.Text!="")
			{
				sql=AndOr(sql);
				sql+="(EMP_I1 between N'"+txt_EMP_ID21.Text+"' and N'"+txt_EMP_ID22.Text+"')";
			}
			if(txt_CRD_NO1.Text!="")
			{
				sql=AndOr(sql);
				sql+="(CRD_NO between N'"+txt_CRD_NO1.Text+"' and N'"+txt_CRD_NO2.Text+"')";
			}
			if(txt_PAS_ID.Text!="")
			{
				sql=AndOr(sql);
				sql+="(PAS_ID=N'"+txt_PAS_ID.Text+"')";
			}
			if(txt_VIS_ID.Text!="")
			{
				sql=AndOr(sql);
				sql+="(VIS_ID=N'"+txt_VIS_ID.Text+"')";
			}
			if(txt_WRK_ID.Text!="")
			{
				sql=AndOr(sql);
				sql+="(WRK_ID=N'"+txt_WRK_ID.Text+"')";
			}	
			if (congdoan.Checked)
			{
				sql+="congdoan=1";
			}
			/// khue them 29-12-2015
			if (cb_BHX_BT .Checked)
			{
				sql+="BHX_BT=1";
			}
			/// ket thuc them
			sql=Get_GP(sql,gp_sex);
			sql=Get_GP(sql,groupBox1);
			sql=Get_GP(sql,groupBox2);
			sql=Get_GP(sql,groupBox3);
			sql=Get_GP1(sql,gp);
			if(sql!="") sql+=" and ";
				sql+=" a.DEP_ID in "+T_String.DEP_ID(this.Tag);	
			//certificate
			sql1=sql;
			if(cb_CTF_ID.SelectedValue+""!="" )			
			{				
				sql1+=" AND (CTF_ID=N'"+cb_CTF_ID.SelectedValue+"')";				
			}		
			
			if(ck_CTF.Checked)
			{
				nav2.Show_VS(sql1);
				vs.Visible=false;
				vs2.Visible=true;
				text.Text=vs2.Rows.Count-1+"";
			}
		
			else
			{
				nav.Show_VS(sql);
//				for(int i=1;i<vs.Rows.Count;i++)
//				{
//					if(vs.Rows[i]["VAC_BT"]+""=="True")
//					{
//						for(int c=1;c<vs.Cols.Count;c++)
//							vs.SetCellStyle(i,c, vs.Styles["VAC_BT"]);
//					}
//				}
				vs.Visible=true;
				vs2.Visible=false;
				text.Text=vs.Rows.Count-1+"";
			}			
		}

		private string AndOr(string sql)
		{
			if(sql!="")
			{
				if(rd51.Checked)
					sql+=" and ";
				else
					sql+=" or ";
			}	
			return sql;
		}
		private string Get_CB()
		{
			string sql="";
			for(int i=0;i<p2.Controls.Count;i++ )
			{
				if(p2.Controls[i].GetType().FullName=="System.Windows.Forms.ComboBox")
				{
					ComboBox cb=(ComboBox)p2.Controls[i];
					if(cb.SelectedValue+""!="")
					{
						sql=AndOr(sql);
						if(cb.Name=="cb_CTF_ID")
						{
							//sql+=" a.EMP_ID IN (SELECT EMP_ID FROM FILB08A WHERE "+cb.Name.Replace("cb_","")+"=N'"+cb.SelectedValue+"')";
						}
						else
						{
							if(cb.Name=="cb_DEP_ID")
								sql+=cb.Name.Replace("cb_","a.")+"=N'"+cb.SelectedValue+"'";
							else
								sql+=cb.Name.Replace("cb_","")+"=N'"+cb.SelectedValue+"'";
						}
					}
				}
			}
			return sql;
		}

		private string Get_GP(string sql,GroupBox gpp)
		{			
			for(int i=0;i<gpp.Controls.Count;i++ )
			{
				if(gpp.Controls[i].GetType().FullName=="System.Windows.Forms.RadioButton")
				{
					RadioButton cb=(RadioButton)gpp.Controls[i];
					if(cb.Checked && cb.Tag+""!="")
					{
						sql=AndOr(sql);
						sql+=cb.Tag;
						return sql;
					}
				}
			}
			return sql;
		}

		private string Get_GP1(string sql,GroupBox gpp)
		{			
			for(int i=0;i<gpp.Controls.Count;i++ )
			{
				if(gpp.Controls[i].GetType().FullName=="System.Windows.Forms.RadioButton")
				{
					RadioButton cb=(RadioButton)gpp.Controls[i];
					if(cb.Checked && cb.Tag+""=="")
					{
						sql=AndOr(sql);
						sql+="("+cb.Name.Replace("rd_","")+" between '"+
							DateTime.Parse(dt5.Value+"").ToString("yyyy/MM/dd")+"' and '"+
							DateTime.Parse(dt6.Value+"").ToString("yyyy/MM/dd")+"')";
						return sql;
					}
				}
			}
			return sql;
		}

		private void frmTaStaffInfoSearch_Closed(object sender, System.EventArgs e)
		{
			nav.Save_SEQ();
		}

		private void ck_CTF_CheckedChanged(object sender, System.EventArgs e)
		{
			if(ck_CTF.Checked)
			{
				vs.Visible=false;
				vs2.Visible=true;
				lb_ctf.Visible=true;
				cb_CTF_ID.Visible=true;
				text.Text=vs2.Rows.Count-1+"";
			}
			else
			{
				vs.Visible=true;
				vs2.Visible=false;
				lb_ctf.Visible=false;
				cb_CTF_ID.Visible=false;
				text.Text=vs.Rows.Count-1+"";
			}
		}

		
	}
}


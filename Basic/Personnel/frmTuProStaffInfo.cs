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
using System.Globalization;
using C1.C1Pdf;
using GP8000.Personnel.Report;


namespace GP8000.Personnel
{
	/// <summary>
	/// Summary description for frmTaStaffInfo.
	/// </summary>
	public class frmTuProStaffInfo : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel5;
		private C1.Win.C1FlexGrid.C1FlexGrid vs;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel4;
		private Navigator1._0.NavigatorAuto nav;
		private C1.Win.C1Command.C1CommandDock c1CommandDock1;
		private C1.Win.C1Command.C1DockingTab c1DockingTab1;
		private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage1;
		private C1.Win.C1Command.C1CommandDock c1CommandDock2;
		private C1.Win.C1Command.C1DockingTab c1DockingTab2;
		private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage2;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.CheckBox ck_QEdit;
		private System.Windows.Forms.CheckBox ck_search;
		private System.Windows.Forms.TextBox S_EMP_NM;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txt_REM_DR;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.ComboBox cb_COU_ID;
		private System.Windows.Forms.ComboBox cb_NAT_CO;
		private System.Windows.Forms.ComboBox cb_GRA_ID;
		private System.Windows.Forms.ComboBox cb_PRO_ID;
		private System.Windows.Forms.ComboBox cb_CIT_ID;
		private System.Windows.Forms.ComboBox cb_EDU_ID;
		private System.Windows.Forms.TextBox txt_RAC_NM;
		private System.Windows.Forms.TextBox txt_BHX_NO;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label39;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button cmd_upload;
		private System.Windows.Forms.Button cmd_browser;
		private System.Windows.Forms.PictureBox pic;
		private System.Windows.Forms.TextBox txt_ACC_NM;
		private System.Windows.Forms.TextBox txt_ADD_D1;
		private System.Windows.Forms.TextBox txt_CRD_LC;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox txt_ACC_NO;
		private System.Windows.Forms.TextBox textBox11;
		private System.Windows.Forms.TextBox txt_ADD_DR;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txt_TEL_NO;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txt_CRD_ID;
		private System.Windows.Forms.TextBox txt_EMP_NM;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Label lll;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label10;
		private AxMSCommLib.AxMSComm Comport;
		private C1.Win.C1Input.C1DateEdit dt_CRD_DT;
		private GP8000.UserControl.CrtTaDepartment Dep;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.TextBox txt_VAC_NM;
		private System.Windows.Forms.TextBox txt_VAC_DT;
		private System.Windows.Forms.Panel p1;
		private System.Windows.Forms.ContextMenu mnu;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.PictureBox cmd_family;
		private C1.Win.C1Command.C1DockingTab c1DockingTab3;
		private C1.Win.C1Command.C1DockingTabPage Tab_HDLD;
		private C1.Win.C1Command.C1DockingTabPage Tab_BHXH;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.GroupBox gp;
		private System.Windows.Forms.GroupBox gp1;
		private System.Windows.Forms.Label label38;
		private System.Windows.Forms.Label label40;
		private System.Windows.Forms.Label label41;
		private System.Windows.Forms.Label label42;
		private System.Windows.Forms.Label label43;
		private System.Windows.Forms.Label label44;
		private System.Windows.Forms.Label label45;
		private System.Windows.Forms.Label label46;
		private C1.Win.C1Input.C1DateEdit dt_BHX_ST;
		private C1.Win.C1Input.C1DateEdit dt_BHX_ED;
		private C1.Win.C1Input.C1DateEdit dt_BHY_ED;
		private C1.Win.C1Input.C1DateEdit dt_BHY_ST;
		private System.Windows.Forms.TextBox txt_BHY_NO;
		private C1.Win.C1Input.C1DateEdit dt_BHL_ED;
		private C1.Win.C1Input.C1DateEdit dt_BHL_ST;
		private System.Windows.Forms.TextBox txt_BHL_NO;
		private System.Windows.Forms.Label label50;
		private System.Windows.Forms.Label label51;
		private System.Windows.Forms.Label label52;
		private System.Windows.Forms.Label label53;
		private System.Windows.Forms.Label label55;
		private C1.Win.C1Input.C1DateEdit dt_LA1_ED;
		private C1.Win.C1Input.C1DateEdit dt_LA1_ST;
		private System.Windows.Forms.TextBox txt_LA1_NO;
		private C1.Win.C1Input.C1DateEdit dt_LAB_ED;
		private C1.Win.C1Input.C1DateEdit dt_LAB_ST;
		private System.Windows.Forms.Label dd;
		private System.Windows.Forms.TextBox txt_LAB_NO;
		private System.Windows.Forms.TextBox txt_LAB_TM;
		private System.Windows.Forms.Label label47;
		private System.Windows.Forms.TextBox txt_LA1_TM;
		private System.Windows.Forms.Label label48;
		private System.Windows.Forms.PictureBox cmd_salary;
		private System.Windows.Forms.PictureBox cmd_visa;
		private C1.Win.C1Input.C1DateEdit dt_BIR_DT;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label57;
		private C1.Win.C1Input.C1TextBox txt_BIR_DT;		
		private ContextMenu mnu1;
		private AxGPRPT.AxReport rpt;
		private System.Windows.Forms.Button cmd_quick;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label58;
		private System.Windows.Forms.Panel p2;
		private System.Windows.Forms.TextBox txt_st;
		private System.Windows.Forms.TextBox txt_ed;
		private C1.C1Pdf.C1PdfDocument _c1pdf;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label59;
		private C1.Win.C1Input.C1DateEdit dt_INH_D1;
		private System.Windows.Forms.ComboBox cb_LEV_ID;
		private System.Windows.Forms.ComboBox cb_POS_ID;
		private System.Windows.Forms.Button cmd_com;
		private System.Windows.Forms.ComboBox cb_GRT_ID;
		private System.Windows.Forms.ComboBox cb_GRP_ID;
		private System.Windows.Forms.ComboBox cb_TYP_ID;
		private System.Windows.Forms.ComboBox cb_DEP_ID;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.TextBox txt_CRD_NO;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.TextBox txt_DEP_N1;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label56;
		private System.Windows.Forms.TextBox txt_EMP_I1;
		private System.Windows.Forms.TextBox txt_EMP_ID;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private C1.Win.C1Input.C1DateEdit dt_INH_DT;
		private System.Windows.Forms.Label label60;
		private System.Windows.Forms.GroupBox g2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private C1.C1Excel.C1XLBook c1XLBook1;
		private System.Windows.Forms.Label label49;
		private System.Windows.Forms.CheckBox ck_BHX_BT;
		private System.Windows.Forms.Label label37;
		private System.Windows.Forms.CheckBox ck_LCK_BT;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.CheckBox ck_ATT_BT;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.CheckBox ck_MEA_BT;
		private System.Windows.Forms.Label label54;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label61;
		private System.Windows.Forms.Label label62;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.Label lb2;
		private System.Windows.Forms.Label lb1;
		private System.Windows.Forms.TextBox S_EMP_I1;
		private System.Windows.Forms.TextBox S_CRD_NO;
		private System.Windows.Forms.TextBox S_EMP_ID;
		private System.Windows.Forms.TextBox S_CRD_ID;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.ComponentModel.IContainer components;		

		public frmTuProStaffInfo()
		{			
			InitializeComponent();				
			this.c1CommandDock2.Size = new System.Drawing.Size(600, 490);			
			this.c1DockingTab2.Size = new System.Drawing.Size(this.Width- pic.Left , 490);			
			this.c1DockingTabPage2.Size = new System.Drawing.Size(595, 488);					
			this.c1CommandDock1.Size = new System.Drawing.Size(256, 526);			
			this.c1DockingTab1.Size = new System.Drawing.Size(254, 524);						
			this.c1DockingTabPage1.Size = new System.Drawing.Size(251, 523);
			this.c1DockingTab1.AutoHiding=true;
			//this.c1DockingTab2.AutoHiding=true;
			this.c1DockingTab3.Location = new System.Drawing.Point(244, 280);
			this.txt_REM_DR.Location = new System.Drawing.Point(108, 347);
			this.c1DockingTab3.SelectedIndex=0;

			this.c1CommandDock1.Visible=false;
			this.Update();			
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmTuProStaffInfo));
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.S_EMP_ID = new System.Windows.Forms.TextBox();
			this.S_CRD_NO = new System.Windows.Forms.TextBox();
			this.S_EMP_I1 = new System.Windows.Forms.TextBox();
			this.lb2 = new System.Windows.Forms.Label();
			this.lb1 = new System.Windows.Forms.Label();
			this.label49 = new System.Windows.Forms.Label();
			this.ck_BHX_BT = new System.Windows.Forms.CheckBox();
			this.label37 = new System.Windows.Forms.Label();
			this.ck_LCK_BT = new System.Windows.Forms.CheckBox();
			this.label35 = new System.Windows.Forms.Label();
			this.ck_ATT_BT = new System.Windows.Forms.CheckBox();
			this.label33 = new System.Windows.Forms.Label();
			this.ck_MEA_BT = new System.Windows.Forms.CheckBox();
			this.label54 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.p2 = new System.Windows.Forms.Panel();
			this.txt_st = new System.Windows.Forms.TextBox();
			this.txt_ed = new System.Windows.Forms.TextBox();
			this.label58 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.cmd_quick = new System.Windows.Forms.Button();
			this.rpt = new AxGPRPT.AxReport();
			this.txt_BIR_DT = new C1.Win.C1Input.C1TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.dt_BIR_DT = new C1.Win.C1Input.C1DateEdit();
			this.dt_CRD_DT = new C1.Win.C1Input.C1DateEdit();
			this.panel7 = new System.Windows.Forms.Panel();
			this.cmd_salary = new System.Windows.Forms.PictureBox();
			this.mnu = new System.Windows.Forms.ContextMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.cmd_visa = new System.Windows.Forms.PictureBox();
			this.cmd_family = new System.Windows.Forms.PictureBox();
			this.p1 = new System.Windows.Forms.Panel();
			this.txt_VAC_NM = new System.Windows.Forms.TextBox();
			this.txt_VAC_DT = new System.Windows.Forms.TextBox();
			this.label36 = new System.Windows.Forms.Label();
			this.dt_INH_D1 = new C1.Win.C1Input.C1DateEdit();
			this.txt_REM_DR = new System.Windows.Forms.TextBox();
			this.cb_COU_ID = new System.Windows.Forms.ComboBox();
			this.cb_NAT_CO = new System.Windows.Forms.ComboBox();
			this.cb_GRA_ID = new System.Windows.Forms.ComboBox();
			this.cb_PRO_ID = new System.Windows.Forms.ComboBox();
			this.cb_CIT_ID = new System.Windows.Forms.ComboBox();
			this.cb_EDU_ID = new System.Windows.Forms.ComboBox();
			this.txt_RAC_NM = new System.Windows.Forms.TextBox();
			this.label24 = new System.Windows.Forms.Label();
			this.label39 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.cmd_upload = new System.Windows.Forms.Button();
			this.cmd_browser = new System.Windows.Forms.Button();
			this.pic = new System.Windows.Forms.PictureBox();
			this.txt_ACC_NM = new System.Windows.Forms.TextBox();
			this.txt_ADD_D1 = new System.Windows.Forms.TextBox();
			this.txt_CRD_LC = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.txt_ACC_NO = new System.Windows.Forms.TextBox();
			this.textBox11 = new System.Windows.Forms.TextBox();
			this.txt_ADD_DR = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txt_TEL_NO = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txt_CRD_ID = new System.Windows.Forms.TextBox();
			this.txt_EMP_NM = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label31 = new System.Windows.Forms.Label();
			this.lll = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.Comport = new AxMSCommLib.AxMSComm();
			this.label57 = new System.Windows.Forms.Label();
			this.label34 = new System.Windows.Forms.Label();
			this.label59 = new System.Windows.Forms.Label();
			this.g2 = new System.Windows.Forms.GroupBox();
			this.dt_INH_DT = new C1.Win.C1Input.C1DateEdit();
			this.txt_EMP_I1 = new System.Windows.Forms.TextBox();
			this.txt_EMP_ID = new System.Windows.Forms.TextBox();
			this.cb_LEV_ID = new System.Windows.Forms.ComboBox();
			this.cb_POS_ID = new System.Windows.Forms.ComboBox();
			this.cmd_com = new System.Windows.Forms.Button();
			this.cb_GRT_ID = new System.Windows.Forms.ComboBox();
			this.cb_GRP_ID = new System.Windows.Forms.ComboBox();
			this.cb_TYP_ID = new System.Windows.Forms.ComboBox();
			this.cb_DEP_ID = new System.Windows.Forms.ComboBox();
			this.label29 = new System.Windows.Forms.Label();
			this.txt_CRD_NO = new System.Windows.Forms.TextBox();
			this.label23 = new System.Windows.Forms.Label();
			this.txt_DEP_N1 = new System.Windows.Forms.TextBox();
			this.label56 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label60 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.c1DockingTab3 = new C1.Win.C1Command.C1DockingTab();
			this.Tab_HDLD = new C1.Win.C1Command.C1DockingTabPage();
			this.panel8 = new System.Windows.Forms.Panel();
			this.gp = new System.Windows.Forms.GroupBox();
			this.txt_LA1_TM = new System.Windows.Forms.TextBox();
			this.txt_LAB_TM = new System.Windows.Forms.TextBox();
			this.dt_LA1_ED = new C1.Win.C1Input.C1DateEdit();
			this.dt_LA1_ST = new C1.Win.C1Input.C1DateEdit();
			this.txt_LA1_NO = new System.Windows.Forms.TextBox();
			this.dt_LAB_ED = new C1.Win.C1Input.C1DateEdit();
			this.dt_LAB_ST = new C1.Win.C1Input.C1DateEdit();
			this.txt_LAB_NO = new System.Windows.Forms.TextBox();
			this.label48 = new System.Windows.Forms.Label();
			this.label47 = new System.Windows.Forms.Label();
			this.label50 = new System.Windows.Forms.Label();
			this.label51 = new System.Windows.Forms.Label();
			this.label52 = new System.Windows.Forms.Label();
			this.label53 = new System.Windows.Forms.Label();
			this.dd = new System.Windows.Forms.Label();
			this.label55 = new System.Windows.Forms.Label();
			this.Tab_BHXH = new C1.Win.C1Command.C1DockingTabPage();
			this.panel9 = new System.Windows.Forms.Panel();
			this.gp1 = new System.Windows.Forms.GroupBox();
			this.dt_BHL_ED = new C1.Win.C1Input.C1DateEdit();
			this.dt_BHL_ST = new C1.Win.C1Input.C1DateEdit();
			this.txt_BHL_NO = new System.Windows.Forms.TextBox();
			this.dt_BHY_ED = new C1.Win.C1Input.C1DateEdit();
			this.dt_BHY_ST = new C1.Win.C1Input.C1DateEdit();
			this.txt_BHY_NO = new System.Windows.Forms.TextBox();
			this.dt_BHX_ED = new C1.Win.C1Input.C1DateEdit();
			this.dt_BHX_ST = new C1.Win.C1Input.C1DateEdit();
			this.txt_BHX_NO = new System.Windows.Forms.TextBox();
			this.label44 = new System.Windows.Forms.Label();
			this.label45 = new System.Windows.Forms.Label();
			this.label46 = new System.Windows.Forms.Label();
			this.label41 = new System.Windows.Forms.Label();
			this.label42 = new System.Windows.Forms.Label();
			this.label43 = new System.Windows.Forms.Label();
			this.label40 = new System.Windows.Forms.Label();
			this.label38 = new System.Windows.Forms.Label();
			this.label30 = new System.Windows.Forms.Label();
			this.label62 = new System.Windows.Forms.Label();
			this.label61 = new System.Windows.Forms.Label();
			this.panel6 = new System.Windows.Forms.Panel();
			this.S_CRD_ID = new System.Windows.Forms.TextBox();
			this.ck_QEdit = new System.Windows.Forms.CheckBox();
			this.ck_search = new System.Windows.Forms.CheckBox();
			this.S_EMP_NM = new System.Windows.Forms.TextBox();
			this.c1CommandDock2 = new C1.Win.C1Command.C1CommandDock();
			this.c1DockingTab2 = new C1.Win.C1Command.C1DockingTab();
			this.c1DockingTabPage2 = new C1.Win.C1Command.C1DockingTabPage();
			this.vs = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.nav = new Navigator1._0.NavigatorAuto();
			this.c1CommandDock1 = new C1.Win.C1Command.C1CommandDock();
			this.c1DockingTab1 = new C1.Win.C1Command.C1DockingTab();
			this.c1DockingTabPage1 = new C1.Win.C1Command.C1DockingTabPage();
			this.Dep = new GP8000.UserControl.CrtTaDepartment();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.c1XLBook1 = new C1.C1Excel.C1XLBook();
			this.panel1.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.p2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.rpt)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_BIR_DT)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dt_BIR_DT)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dt_CRD_DT)).BeginInit();
			this.panel7.SuspendLayout();
			this.p1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dt_INH_D1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Comport)).BeginInit();
			this.g2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dt_INH_DT)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1DockingTab3)).BeginInit();
			this.c1DockingTab3.SuspendLayout();
			this.Tab_HDLD.SuspendLayout();
			this.panel8.SuspendLayout();
			this.gp.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dt_LA1_ED)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dt_LA1_ST)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dt_LAB_ED)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dt_LAB_ST)).BeginInit();
			this.Tab_BHXH.SuspendLayout();
			this.panel9.SuspendLayout();
			this.gp1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dt_BHL_ED)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dt_BHL_ST)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dt_BHY_ED)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dt_BHY_ST)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dt_BHX_ED)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dt_BHX_ST)).BeginInit();
			this.panel6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandDock2)).BeginInit();
			this.c1CommandDock2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1DockingTab2)).BeginInit();
			this.c1DockingTab2.SuspendLayout();
			this.c1DockingTabPage2.SuspendLayout();
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
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1028, 746);
			this.panel1.TabIndex = 3;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.panel2);
			this.panel5.Controls.Add(this.panel6);
			this.panel5.Controls.Add(this.c1CommandDock2);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(16, 36);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(1012, 710);
			this.panel5.TabIndex = 4;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.groupBox1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 32);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(984, 678);
			this.panel2.TabIndex = 5;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Controls.Add(this.S_EMP_ID);
			this.groupBox1.Controls.Add(this.S_CRD_NO);
			this.groupBox1.Controls.Add(this.S_EMP_I1);
			this.groupBox1.Controls.Add(this.lb2);
			this.groupBox1.Controls.Add(this.lb1);
			this.groupBox1.Controls.Add(this.label49);
			this.groupBox1.Controls.Add(this.ck_BHX_BT);
			this.groupBox1.Controls.Add(this.label37);
			this.groupBox1.Controls.Add(this.ck_LCK_BT);
			this.groupBox1.Controls.Add(this.label35);
			this.groupBox1.Controls.Add(this.ck_ATT_BT);
			this.groupBox1.Controls.Add(this.label33);
			this.groupBox1.Controls.Add(this.ck_MEA_BT);
			this.groupBox1.Controls.Add(this.label54);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Controls.Add(this.checkBox2);
			this.groupBox1.Controls.Add(this.checkBox3);
			this.groupBox1.Controls.Add(this.button5);
			this.groupBox1.Controls.Add(this.button4);
			this.groupBox1.Controls.Add(this.button3);
			this.groupBox1.Controls.Add(this.textBox3);
			this.groupBox1.Controls.Add(this.p2);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.cmd_quick);
			this.groupBox1.Controls.Add(this.rpt);
			this.groupBox1.Controls.Add(this.txt_BIR_DT);
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.dt_BIR_DT);
			this.groupBox1.Controls.Add(this.dt_CRD_DT);
			this.groupBox1.Controls.Add(this.panel7);
			this.groupBox1.Controls.Add(this.p1);
			this.groupBox1.Controls.Add(this.dt_INH_D1);
			this.groupBox1.Controls.Add(this.txt_REM_DR);
			this.groupBox1.Controls.Add(this.cb_COU_ID);
			this.groupBox1.Controls.Add(this.cb_NAT_CO);
			this.groupBox1.Controls.Add(this.cb_GRA_ID);
			this.groupBox1.Controls.Add(this.cb_PRO_ID);
			this.groupBox1.Controls.Add(this.cb_CIT_ID);
			this.groupBox1.Controls.Add(this.cb_EDU_ID);
			this.groupBox1.Controls.Add(this.txt_RAC_NM);
			this.groupBox1.Controls.Add(this.label24);
			this.groupBox1.Controls.Add(this.label39);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.cmd_upload);
			this.groupBox1.Controls.Add(this.cmd_browser);
			this.groupBox1.Controls.Add(this.pic);
			this.groupBox1.Controls.Add(this.txt_ACC_NM);
			this.groupBox1.Controls.Add(this.txt_ADD_D1);
			this.groupBox1.Controls.Add(this.txt_CRD_LC);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.txt_ACC_NO);
			this.groupBox1.Controls.Add(this.textBox11);
			this.groupBox1.Controls.Add(this.txt_ADD_DR);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.txt_TEL_NO);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.txt_CRD_ID);
			this.groupBox1.Controls.Add(this.txt_EMP_NM);
			this.groupBox1.Controls.Add(this.label16);
			this.groupBox1.Controls.Add(this.label18);
			this.groupBox1.Controls.Add(this.label17);
			this.groupBox1.Controls.Add(this.label15);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.label31);
			this.groupBox1.Controls.Add(this.lll);
			this.groupBox1.Controls.Add(this.label26);
			this.groupBox1.Controls.Add(this.label25);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.Comport);
			this.groupBox1.Controls.Add(this.label57);
			this.groupBox1.Controls.Add(this.label34);
			this.groupBox1.Controls.Add(this.label59);
			this.groupBox1.Controls.Add(this.g2);
			this.groupBox1.Controls.Add(this.c1DockingTab3);
			this.groupBox1.Controls.Add(this.label62);
			this.groupBox1.Controls.Add(this.label61);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(4, -4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(976, 680);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Tag = "N";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(536, 64);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(128, 172);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 174;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// S_EMP_ID
			// 
			this.S_EMP_ID.BackColor = System.Drawing.Color.LemonChiffon;
			this.S_EMP_ID.Location = new System.Drawing.Point(188, 644);
			this.S_EMP_ID.MaxLength = 20;
			this.S_EMP_ID.Name = "S_EMP_ID";
			this.S_EMP_ID.Size = new System.Drawing.Size(156, 23);
			this.S_EMP_ID.TabIndex = 173;
			this.S_EMP_ID.Tag = "CRD_ID";
			this.S_EMP_ID.Text = "textBox3";
			this.S_EMP_ID.Visible = false;
			// 
			// S_CRD_NO
			// 
			this.S_CRD_NO.BackColor = System.Drawing.Color.LemonChiffon;
			this.S_CRD_NO.Location = new System.Drawing.Point(188, 700);
			this.S_CRD_NO.MaxLength = 20;
			this.S_CRD_NO.Name = "S_CRD_NO";
			this.S_CRD_NO.Size = new System.Drawing.Size(156, 23);
			this.S_CRD_NO.TabIndex = 172;
			this.S_CRD_NO.Tag = "CRD_NO";
			this.S_CRD_NO.Text = "textBox3";
			this.S_CRD_NO.Visible = false;
			// 
			// S_EMP_I1
			// 
			this.S_EMP_I1.BackColor = System.Drawing.Color.PeachPuff;
			this.S_EMP_I1.Location = new System.Drawing.Point(188, 672);
			this.S_EMP_I1.MaxLength = 20;
			this.S_EMP_I1.Name = "S_EMP_I1";
			this.S_EMP_I1.Size = new System.Drawing.Size(156, 23);
			this.S_EMP_I1.TabIndex = 171;
			this.S_EMP_I1.Tag = "EMP_I1";
			this.S_EMP_I1.Text = "textBox3";
			this.S_EMP_I1.Visible = false;
			// 
			// lb2
			// 
			this.lb2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lb2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lb2.ForeColor = System.Drawing.Color.Red;
			this.lb2.Location = new System.Drawing.Point(532, 156);
			this.lb2.Name = "lb2";
			this.lb2.Size = new System.Drawing.Size(24, 23);
			this.lb2.TabIndex = 170;
			this.lb2.Tag = "N";
			this.lb2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lb2.Visible = false;
			// 
			// lb1
			// 
			this.lb1.Location = new System.Drawing.Point(560, 160);
			this.lb1.Name = "lb1";
			this.lb1.TabIndex = 169;
			this.lb1.Tag = "";
			this.lb1.Text = "MEA_BT";
			this.lb1.Visible = false;
			// 
			// label49
			// 
			this.label49.Location = new System.Drawing.Point(560, 136);
			this.label49.Name = "label49";
			this.label49.TabIndex = 168;
			this.label49.Tag = "BHX_BT";
			this.label49.Text = "MEA_BT";
			this.label49.Visible = false;
			// 
			// ck_BHX_BT
			// 
			this.ck_BHX_BT.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ck_BHX_BT.Location = new System.Drawing.Point(536, 132);
			this.ck_BHX_BT.Name = "ck_BHX_BT";
			this.ck_BHX_BT.Size = new System.Drawing.Size(16, 24);
			this.ck_BHX_BT.TabIndex = 160;
			this.ck_BHX_BT.Tag = "BHX_BT";
			this.ck_BHX_BT.Text = "MEA_BT";
			this.ck_BHX_BT.Visible = false;
			// 
			// label37
			// 
			this.label37.Location = new System.Drawing.Point(560, 116);
			this.label37.Name = "label37";
			this.label37.TabIndex = 167;
			this.label37.Tag = "LCK_BT";
			this.label37.Text = "MEA_BT";
			this.label37.Visible = false;
			// 
			// ck_LCK_BT
			// 
			this.ck_LCK_BT.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ck_LCK_BT.Location = new System.Drawing.Point(536, 112);
			this.ck_LCK_BT.Name = "ck_LCK_BT";
			this.ck_LCK_BT.Size = new System.Drawing.Size(16, 24);
			this.ck_LCK_BT.TabIndex = 159;
			this.ck_LCK_BT.Tag = "LCK_BT";
			this.ck_LCK_BT.Text = "MEA_BT";
			this.ck_LCK_BT.Visible = false;
			// 
			// label35
			// 
			this.label35.ForeColor = System.Drawing.Color.Red;
			this.label35.Location = new System.Drawing.Point(560, 96);
			this.label35.Name = "label35";
			this.label35.TabIndex = 166;
			this.label35.Tag = "ATT_BT";
			this.label35.Text = "MEA_BT";
			this.label35.Visible = false;
			// 
			// ck_ATT_BT
			// 
			this.ck_ATT_BT.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ck_ATT_BT.Location = new System.Drawing.Point(536, 92);
			this.ck_ATT_BT.Name = "ck_ATT_BT";
			this.ck_ATT_BT.Size = new System.Drawing.Size(16, 24);
			this.ck_ATT_BT.TabIndex = 158;
			this.ck_ATT_BT.Tag = "ATT_BT";
			this.ck_ATT_BT.Visible = false;
			// 
			// label33
			// 
			this.label33.Location = new System.Drawing.Point(560, 76);
			this.label33.Name = "label33";
			this.label33.TabIndex = 165;
			this.label33.Tag = "MEA_BT";
			this.label33.Text = "MEA_BT";
			this.label33.Visible = false;
			// 
			// ck_MEA_BT
			// 
			this.ck_MEA_BT.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ck_MEA_BT.Location = new System.Drawing.Point(536, 72);
			this.ck_MEA_BT.Name = "ck_MEA_BT";
			this.ck_MEA_BT.Size = new System.Drawing.Size(16, 24);
			this.ck_MEA_BT.TabIndex = 157;
			this.ck_MEA_BT.Tag = "MEA_BT";
			this.ck_MEA_BT.Text = "MEA_BT";
			this.ck_MEA_BT.Visible = false;
			// 
			// label54
			// 
			this.label54.Location = new System.Drawing.Point(560, 56);
			this.label54.Name = "label54";
			this.label54.TabIndex = 164;
			this.label54.Tag = "NEW_BT";
			this.label54.Text = "NEW_BT";
			this.label54.Visible = false;
			// 
			// checkBox1
			// 
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBox1.Location = new System.Drawing.Point(536, 52);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(16, 24);
			this.checkBox1.TabIndex = 156;
			this.checkBox1.Tag = "NEW_BT";
			this.checkBox1.Text = "MAR_BT";
			this.checkBox1.Visible = false;
			// 
			// checkBox2
			// 
			this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBox2.Location = new System.Drawing.Point(536, 32);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(16, 24);
			this.checkBox2.TabIndex = 155;
			this.checkBox2.Tag = "MAR_BT";
			this.checkBox2.Text = "MAR_BT";
			// 
			// checkBox3
			// 
			this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBox3.Location = new System.Drawing.Point(536, 12);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(16, 24);
			this.checkBox3.TabIndex = 154;
			this.checkBox3.Tag = "SEX_BT";
			this.checkBox3.Text = "SEX_BT";
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button5.Location = new System.Drawing.Point(262, 388);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(120, 28);
			this.button5.TabIndex = 153;
			this.button5.Tag = "";
			this.button5.Text = "Cancel";
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button4.Enabled = false;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button4.Location = new System.Drawing.Point(136, 388);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(120, 28);
			this.button4.TabIndex = 152;
			this.button4.Tag = "";
			this.button4.Text = "Save";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button3.Location = new System.Drawing.Point(8, 388);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(120, 28);
			this.button3.TabIndex = 151;
			this.button3.Tag = "";
			this.button3.Text = "Transfer into Staff";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(372, 151);
			this.textBox3.MaxLength = 20;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(160, 23);
			this.textBox3.TabIndex = 11;
			this.textBox3.Tag = "MST_DR";
			this.textBox3.Text = "textBox6";
			// 
			// p2
			// 
			this.p2.BackColor = System.Drawing.Color.DarkGray;
			this.p2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.p2.Controls.Add(this.txt_st);
			this.p2.Controls.Add(this.txt_ed);
			this.p2.Controls.Add(this.label58);
			this.p2.Location = new System.Drawing.Point(544, 265);
			this.p2.Name = "p2";
			this.p2.Size = new System.Drawing.Size(148, 72);
			this.p2.TabIndex = 147;
			this.p2.Visible = false;
			// 
			// txt_st
			// 
			this.txt_st.BackColor = System.Drawing.Color.Moccasin;
			this.txt_st.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_st.ForeColor = System.Drawing.Color.Black;
			this.txt_st.Location = new System.Drawing.Point(-1, 20);
			this.txt_st.Name = "txt_st";
			this.txt_st.ReadOnly = true;
			this.txt_st.Size = new System.Drawing.Size(144, 23);
			this.txt_st.TabIndex = 1;
			this.txt_st.Text = "textBox2";
			this.txt_st.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txt_ed
			// 
			this.txt_ed.BackColor = System.Drawing.Color.Moccasin;
			this.txt_ed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_ed.ForeColor = System.Drawing.Color.Black;
			this.txt_ed.Location = new System.Drawing.Point(-1, 44);
			this.txt_ed.Name = "txt_ed";
			this.txt_ed.ReadOnly = true;
			this.txt_ed.Size = new System.Drawing.Size(144, 23);
			this.txt_ed.TabIndex = 2;
			this.txt_ed.Text = "textBox3";
			this.txt_ed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label58
			// 
			this.label58.BackColor = System.Drawing.Color.CornflowerBlue;
			this.label58.Dock = System.Windows.Forms.DockStyle.Top;
			this.label58.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label58.ForeColor = System.Drawing.Color.Red;
			this.label58.Location = new System.Drawing.Point(0, 0);
			this.label58.Name = "label58";
			this.label58.Size = new System.Drawing.Size(144, 24);
			this.label58.TabIndex = 0;
			this.label58.Text = "label36";
			this.label58.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button2.Location = new System.Drawing.Point(676, 20);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(76, 32);
			this.button2.TabIndex = 73;
			this.button2.Text = "Preview";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(504, 291);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(28, 24);
			this.button1.TabIndex = 19;
			this.button1.Tag = "N";
			this.button1.Text = "...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// cmd_quick
			// 
			this.cmd_quick.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_quick.Location = new System.Drawing.Point(828, 56);
			this.cmd_quick.Name = "cmd_quick";
			this.cmd_quick.Size = new System.Drawing.Size(76, 40);
			this.cmd_quick.TabIndex = 144;
			this.cmd_quick.Text = "Quick Upload";
			this.cmd_quick.Click += new System.EventHandler(this.cmd_quick_Click);
			// 
			// rpt
			// 
			this.rpt.ContainingControl = this;
			this.rpt.Enabled = true;
			this.rpt.Location = new System.Drawing.Point(800, 280);
			this.rpt.Name = "rpt";
			this.rpt.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("rpt.OcxState")));
			this.rpt.Size = new System.Drawing.Size(99, 45);
			this.rpt.TabIndex = 143;
			this.rpt.Visible = false;
			// 
			// txt_BIR_DT
			// 
			this.txt_BIR_DT.Location = new System.Drawing.Point(108, 39);
			this.txt_BIR_DT.MaxLength = 10;
			this.txt_BIR_DT.Name = "txt_BIR_DT";
			this.txt_BIR_DT.Size = new System.Drawing.Size(156, 23);
			this.txt_BIR_DT.TabIndex = 4;
			this.txt_BIR_DT.Tag = "BIR_DT";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(108, 207);
			this.textBox2.MaxLength = 50;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(160, 23);
			this.textBox2.TabIndex = 14;
			this.textBox2.Tag = "REL_DR";
			this.textBox2.Text = "textBox7";
			// 
			// dt_BIR_DT
			// 
			this.dt_BIR_DT.EmptyAsNull = true;
			this.dt_BIR_DT.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt_BIR_DT.Location = new System.Drawing.Point(108, 39);
			this.dt_BIR_DT.Name = "dt_BIR_DT";
			this.dt_BIR_DT.Size = new System.Drawing.Size(160, 23);
			this.dt_BIR_DT.TabIndex = 4;
			this.dt_BIR_DT.Tag = null;
			this.dt_BIR_DT.Visible = false;
			// 
			// dt_CRD_DT
			// 
			this.dt_CRD_DT.EmptyAsNull = true;
			this.dt_CRD_DT.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt_CRD_DT.Location = new System.Drawing.Point(372, 123);
			this.dt_CRD_DT.Name = "dt_CRD_DT";
			this.dt_CRD_DT.Size = new System.Drawing.Size(160, 23);
			this.dt_CRD_DT.TabIndex = 9;
			this.dt_CRD_DT.Tag = "CRD_DT";
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.NavajoWhite;
			this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel7.Controls.Add(this.cmd_salary);
			this.panel7.Controls.Add(this.cmd_visa);
			this.panel7.Controls.Add(this.cmd_family);
			this.panel7.Location = new System.Drawing.Point(696, 220);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(184, 56);
			this.panel7.TabIndex = 39;
			this.panel7.Visible = false;
			// 
			// cmd_salary
			// 
			this.cmd_salary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmd_salary.ContextMenu = this.mnu;
			this.cmd_salary.Location = new System.Drawing.Point(120, 4);
			this.cmd_salary.Name = "cmd_salary";
			this.cmd_salary.Size = new System.Drawing.Size(52, 44);
			this.cmd_salary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.cmd_salary.TabIndex = 134;
			this.cmd_salary.TabStop = false;
			this.cmd_salary.Click += new System.EventHandler(this.cmd_salary_Click);
			// 
			// mnu
			// 
			this.mnu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				this.menuItem1});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.Text = "Delete";
			this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
			// 
			// cmd_visa
			// 
			this.cmd_visa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmd_visa.ContextMenu = this.mnu;
			this.cmd_visa.Location = new System.Drawing.Point(60, 4);
			this.cmd_visa.Name = "cmd_visa";
			this.cmd_visa.Size = new System.Drawing.Size(52, 44);
			this.cmd_visa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.cmd_visa.TabIndex = 133;
			this.cmd_visa.TabStop = false;
			this.cmd_visa.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// cmd_family
			// 
			this.cmd_family.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmd_family.ContextMenu = this.mnu;
			this.cmd_family.Location = new System.Drawing.Point(4, 4);
			this.cmd_family.Name = "cmd_family";
			this.cmd_family.Size = new System.Drawing.Size(52, 44);
			this.cmd_family.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.cmd_family.TabIndex = 132;
			this.cmd_family.TabStop = false;
			this.cmd_family.Click += new System.EventHandler(this.cmd_family_Click);
			// 
			// p1
			// 
			this.p1.BackColor = System.Drawing.Color.DarkGray;
			this.p1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.p1.Controls.Add(this.txt_VAC_NM);
			this.p1.Controls.Add(this.txt_VAC_DT);
			this.p1.Controls.Add(this.label36);
			this.p1.Location = new System.Drawing.Point(544, 264);
			this.p1.Name = "p1";
			this.p1.Size = new System.Drawing.Size(148, 72);
			this.p1.TabIndex = 128;
			this.p1.Visible = false;
			// 
			// txt_VAC_NM
			// 
			this.txt_VAC_NM.BackColor = System.Drawing.Color.Black;
			this.txt_VAC_NM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_VAC_NM.ForeColor = System.Drawing.Color.White;
			this.txt_VAC_NM.Location = new System.Drawing.Point(-1, 20);
			this.txt_VAC_NM.Name = "txt_VAC_NM";
			this.txt_VAC_NM.ReadOnly = true;
			this.txt_VAC_NM.Size = new System.Drawing.Size(144, 23);
			this.txt_VAC_NM.TabIndex = 1;
			this.txt_VAC_NM.Text = "textBox2";
			this.txt_VAC_NM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txt_VAC_DT
			// 
			this.txt_VAC_DT.BackColor = System.Drawing.Color.Black;
			this.txt_VAC_DT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_VAC_DT.ForeColor = System.Drawing.Color.White;
			this.txt_VAC_DT.Location = new System.Drawing.Point(-1, 44);
			this.txt_VAC_DT.Name = "txt_VAC_DT";
			this.txt_VAC_DT.ReadOnly = true;
			this.txt_VAC_DT.Size = new System.Drawing.Size(144, 23);
			this.txt_VAC_DT.TabIndex = 2;
			this.txt_VAC_DT.Text = "textBox3";
			this.txt_VAC_DT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label36
			// 
			this.label36.Dock = System.Windows.Forms.DockStyle.Top;
			this.label36.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label36.ForeColor = System.Drawing.Color.Red;
			this.label36.Location = new System.Drawing.Point(0, 0);
			this.label36.Name = "label36";
			this.label36.Size = new System.Drawing.Size(144, 24);
			this.label36.TabIndex = 0;
			this.label36.Text = "label36";
			this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dt_INH_D1
			// 
			this.dt_INH_D1.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt_INH_D1.Location = new System.Drawing.Point(372, 319);
			this.dt_INH_D1.Name = "dt_INH_D1";
			this.dt_INH_D1.Size = new System.Drawing.Size(160, 23);
			this.dt_INH_D1.TabIndex = 23;
			this.dt_INH_D1.Tag = "INH_D1";
			// 
			// txt_REM_DR
			// 
			this.txt_REM_DR.Location = new System.Drawing.Point(108, 347);
			this.txt_REM_DR.MaxLength = 500;
			this.txt_REM_DR.Multiline = true;
			this.txt_REM_DR.Name = "txt_REM_DR";
			this.txt_REM_DR.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txt_REM_DR.Size = new System.Drawing.Size(424, 37);
			this.txt_REM_DR.TabIndex = 24;
			this.txt_REM_DR.Tag = "REM_DR";
			this.txt_REM_DR.Text = "REM_DR";
			// 
			// cb_COU_ID
			// 
			this.cb_COU_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_COU_ID.Location = new System.Drawing.Point(372, 207);
			this.cb_COU_ID.Name = "cb_COU_ID";
			this.cb_COU_ID.Size = new System.Drawing.Size(160, 24);
			this.cb_COU_ID.TabIndex = 15;
			this.cb_COU_ID.Tag = "COU_ID";
			// 
			// cb_NAT_CO
			// 
			this.cb_NAT_CO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_NAT_CO.Location = new System.Drawing.Point(372, 179);
			this.cb_NAT_CO.Name = "cb_NAT_CO";
			this.cb_NAT_CO.Size = new System.Drawing.Size(160, 24);
			this.cb_NAT_CO.TabIndex = 13;
			this.cb_NAT_CO.Tag = "NAT_CO";
			// 
			// cb_GRA_ID
			// 
			this.cb_GRA_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_GRA_ID.Location = new System.Drawing.Point(108, 263);
			this.cb_GRA_ID.Name = "cb_GRA_ID";
			this.cb_GRA_ID.Size = new System.Drawing.Size(160, 24);
			this.cb_GRA_ID.TabIndex = 18;
			this.cb_GRA_ID.Tag = "GRA_ID";
			// 
			// cb_PRO_ID
			// 
			this.cb_PRO_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_PRO_ID.Location = new System.Drawing.Point(108, 235);
			this.cb_PRO_ID.Name = "cb_PRO_ID";
			this.cb_PRO_ID.Size = new System.Drawing.Size(160, 24);
			this.cb_PRO_ID.TabIndex = 16;
			this.cb_PRO_ID.Tag = "PRO_ID";
			// 
			// cb_CIT_ID
			// 
			this.cb_CIT_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_CIT_ID.Location = new System.Drawing.Point(372, 263);
			this.cb_CIT_ID.Name = "cb_CIT_ID";
			this.cb_CIT_ID.Size = new System.Drawing.Size(160, 24);
			this.cb_CIT_ID.TabIndex = 19;
			this.cb_CIT_ID.Tag = "CIT_ID";
			// 
			// cb_EDU_ID
			// 
			this.cb_EDU_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_EDU_ID.Location = new System.Drawing.Point(372, 235);
			this.cb_EDU_ID.Name = "cb_EDU_ID";
			this.cb_EDU_ID.Size = new System.Drawing.Size(160, 24);
			this.cb_EDU_ID.TabIndex = 17;
			this.cb_EDU_ID.Tag = "EDU_ID";
			// 
			// txt_RAC_NM
			// 
			this.txt_RAC_NM.Location = new System.Drawing.Point(108, 179);
			this.txt_RAC_NM.MaxLength = 50;
			this.txt_RAC_NM.Name = "txt_RAC_NM";
			this.txt_RAC_NM.Size = new System.Drawing.Size(160, 23);
			this.txt_RAC_NM.TabIndex = 12;
			this.txt_RAC_NM.Tag = "RAC_NM";
			this.txt_RAC_NM.Text = "textBox7";
			// 
			// label24
			// 
			this.label24.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.label24.Location = new System.Drawing.Point(272, 327);
			this.label24.Name = "label24";
			this.label24.TabIndex = 87;
			this.label24.Tag = "INH_D1";
			this.label24.Text = "INH_D1";
			// 
			// label39
			// 
			this.label39.BackColor = System.Drawing.Color.Transparent;
			this.label39.ForeColor = System.Drawing.Color.Red;
			this.label39.Location = new System.Drawing.Point(696, 36);
			this.label39.Name = "label39";
			this.label39.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label39.Size = new System.Drawing.Size(212, 20);
			this.label39.TabIndex = 75;
			this.label39.Text = "label39";
			this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label39.Visible = false;
			// 
			// label14
			// 
			this.label14.ForeColor = System.Drawing.Color.Blue;
			this.label14.Location = new System.Drawing.Point(668, 12);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(252, 23);
			this.label14.TabIndex = 74;
			this.label14.Tag = "";
			this.label14.Text = "label14";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cmd_upload
			// 
			this.cmd_upload.Enabled = false;
			this.cmd_upload.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_upload.Location = new System.Drawing.Point(828, 116);
			this.cmd_upload.Name = "cmd_upload";
			this.cmd_upload.Size = new System.Drawing.Size(76, 40);
			this.cmd_upload.TabIndex = 72;
			this.cmd_upload.Text = "upload";
			this.cmd_upload.Click += new System.EventHandler(this.cmd_upload_Click);
			// 
			// cmd_browser
			// 
			this.cmd_browser.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_browser.Location = new System.Drawing.Point(828, 176);
			this.cmd_browser.Name = "cmd_browser";
			this.cmd_browser.Size = new System.Drawing.Size(76, 40);
			this.cmd_browser.TabIndex = 71;
			this.cmd_browser.Text = "Browser";
			this.cmd_browser.Click += new System.EventHandler(this.cmd_browser_Click);
			// 
			// pic
			// 
			this.pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pic.ContextMenu = this.mnu;
			this.pic.Location = new System.Drawing.Point(696, 56);
			this.pic.Name = "pic";
			this.pic.Size = new System.Drawing.Size(120, 160);
			this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic.TabIndex = 70;
			this.pic.TabStop = false;
			// 
			// txt_ACC_NM
			// 
			this.txt_ACC_NM.BackColor = System.Drawing.SystemColors.Window;
			this.txt_ACC_NM.Location = new System.Drawing.Point(372, 291);
			this.txt_ACC_NM.MaxLength = 50;
			this.txt_ACC_NM.Name = "txt_ACC_NM";
			this.txt_ACC_NM.Size = new System.Drawing.Size(132, 23);
			this.txt_ACC_NM.TabIndex = 21;
			this.txt_ACC_NM.Tag = "ACC_NM";
			this.txt_ACC_NM.Text = "textBox7";
			// 
			// txt_ADD_D1
			// 
			this.txt_ADD_D1.Location = new System.Drawing.Point(108, 95);
			this.txt_ADD_D1.MaxLength = 255;
			this.txt_ADD_D1.Name = "txt_ADD_D1";
			this.txt_ADD_D1.Size = new System.Drawing.Size(424, 23);
			this.txt_ADD_D1.TabIndex = 7;
			this.txt_ADD_D1.Tag = "ADD_D1";
			this.txt_ADD_D1.Text = "textBox8";
			// 
			// txt_CRD_LC
			// 
			this.txt_CRD_LC.Location = new System.Drawing.Point(108, 151);
			this.txt_CRD_LC.MaxLength = 255;
			this.txt_CRD_LC.Name = "txt_CRD_LC";
			this.txt_CRD_LC.Size = new System.Drawing.Size(160, 23);
			this.txt_CRD_LC.TabIndex = 10;
			this.txt_CRD_LC.Tag = "CRD_LC";
			this.txt_CRD_LC.Text = "textBox2";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(320, 11);
			this.textBox1.MaxLength = 50;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(212, 23);
			this.textBox1.TabIndex = 3;
			this.textBox1.Tag = "EMP_N1";
			this.textBox1.Text = "";
			// 
			// txt_ACC_NO
			// 
			this.txt_ACC_NO.BackColor = System.Drawing.SystemColors.Window;
			this.txt_ACC_NO.Location = new System.Drawing.Point(108, 291);
			this.txt_ACC_NO.MaxLength = 20;
			this.txt_ACC_NO.Name = "txt_ACC_NO";
			this.txt_ACC_NO.Size = new System.Drawing.Size(160, 23);
			this.txt_ACC_NO.TabIndex = 20;
			this.txt_ACC_NO.Tag = "ACC_NO";
			this.txt_ACC_NO.Text = "textBox12";
			// 
			// textBox11
			// 
			this.textBox11.BackColor = System.Drawing.SystemColors.Window;
			this.textBox11.Location = new System.Drawing.Point(108, 319);
			this.textBox11.MaxLength = 100;
			this.textBox11.Name = "textBox11";
			this.textBox11.Size = new System.Drawing.Size(160, 23);
			this.textBox11.TabIndex = 22;
			this.textBox11.Tag = "BNK_NM";
			this.textBox11.Text = "BNK_NM";
			// 
			// txt_ADD_DR
			// 
			this.txt_ADD_DR.Location = new System.Drawing.Point(108, 67);
			this.txt_ADD_DR.MaxLength = 255;
			this.txt_ADD_DR.Name = "txt_ADD_DR";
			this.txt_ADD_DR.Size = new System.Drawing.Size(424, 23);
			this.txt_ADD_DR.TabIndex = 6;
			this.txt_ADD_DR.Tag = "ADD_DR";
			this.txt_ADD_DR.Text = "textBox8";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(276, 271);
			this.label8.Name = "label8";
			this.label8.TabIndex = 37;
			this.label8.Tag = "CIT_ID";
			this.label8.Text = "CIT_ID";
			// 
			// txt_TEL_NO
			// 
			this.txt_TEL_NO.Location = new System.Drawing.Point(372, 39);
			this.txt_TEL_NO.MaxLength = 30;
			this.txt_TEL_NO.Name = "txt_TEL_NO";
			this.txt_TEL_NO.Size = new System.Drawing.Size(160, 23);
			this.txt_TEL_NO.TabIndex = 5;
			this.txt_TEL_NO.Tag = "TEL_NO";
			this.txt_TEL_NO.Text = "textBox6";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(276, 43);
			this.label7.Name = "label7";
			this.label7.TabIndex = 35;
			this.label7.Tag = "TEL_NO";
			this.label7.Text = "TEL_NO";
			// 
			// txt_CRD_ID
			// 
			this.txt_CRD_ID.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt_CRD_ID.Location = new System.Drawing.Point(108, 123);
			this.txt_CRD_ID.MaxLength = 9;
			this.txt_CRD_ID.Name = "txt_CRD_ID";
			this.txt_CRD_ID.Size = new System.Drawing.Size(160, 23);
			this.txt_CRD_ID.TabIndex = 1;
			this.txt_CRD_ID.Tag = "CRD_ID";
			this.txt_CRD_ID.Text = "textBox5";
			this.txt_CRD_ID.Leave += new System.EventHandler(this.txt_CRD_ID_Leave);
			// 
			// txt_EMP_NM
			// 
			this.txt_EMP_NM.BackColor = System.Drawing.Color.Azure;
			this.txt_EMP_NM.Location = new System.Drawing.Point(108, 11);
			this.txt_EMP_NM.MaxLength = 50;
			this.txt_EMP_NM.Name = "txt_EMP_NM";
			this.txt_EMP_NM.Size = new System.Drawing.Size(212, 23);
			this.txt_EMP_NM.TabIndex = 2;
			this.txt_EMP_NM.Tag = "EMP_NM";
			this.txt_EMP_NM.Text = "";
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(276, 131);
			this.label16.Name = "label16";
			this.label16.TabIndex = 56;
			this.label16.Tag = "CRD_DT";
			this.label16.Text = "CRD_DT";
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(276, 243);
			this.label18.Name = "label18";
			this.label18.TabIndex = 61;
			this.label18.Tag = "EDU_ID";
			this.label18.Text = "EDU_ID";
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(12, 99);
			this.label17.Name = "label17";
			this.label17.TabIndex = 59;
			this.label17.Tag = "ADD_D1";
			this.label17.Text = "ADD_D1";
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(12, 159);
			this.label15.Name = "label15";
			this.label15.TabIndex = 54;
			this.label15.Tag = "CRD_LC";
			this.label15.Text = "CRD_LC";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(132, 32);
			this.label1.TabIndex = 52;
			this.label1.Tag = "BIR_DT";
			this.label1.Text = "BIR_DT";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(12, 299);
			this.label13.Name = "label13";
			this.label13.TabIndex = 47;
			this.label13.Tag = "ACC_NO";
			this.label13.Text = "ACC_NO";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(12, 327);
			this.label12.Name = "label12";
			this.label12.TabIndex = 45;
			this.label12.Tag = "BNK_NM";
			this.label12.Text = "BNK_NM";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(12, 71);
			this.label9.Name = "label9";
			this.label9.TabIndex = 39;
			this.label9.Tag = "ADD_DR";
			this.label9.Text = "ADD_DR";
			// 
			// label6
			// 
			this.label6.ForeColor = System.Drawing.Color.Red;
			this.label6.Location = new System.Drawing.Point(12, 131);
			this.label6.Name = "label6";
			this.label6.TabIndex = 33;
			this.label6.Tag = "CRD_ID";
			this.label6.Text = "CRD_ID";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 19);
			this.label2.Name = "label2";
			this.label2.TabIndex = 27;
			this.label2.Tag = "EMP_NM";
			this.label2.Text = "EMP_NM";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(12, 271);
			this.label11.Name = "label11";
			this.label11.TabIndex = 65;
			this.label11.Tag = "GRA_ID";
			this.label11.Text = "GRA_ID";
			// 
			// label31
			// 
			this.label31.Location = new System.Drawing.Point(12, 187);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(132, 23);
			this.label31.TabIndex = 102;
			this.label31.Tag = "RAC_NM";
			this.label31.Text = "RAC_NM Dan toc";
			// 
			// lll
			// 
			this.lll.Location = new System.Drawing.Point(276, 299);
			this.lll.Name = "lll";
			this.lll.TabIndex = 67;
			this.lll.Tag = "ACC_NM";
			this.lll.Text = "ACC_NM";
			// 
			// label26
			// 
			this.label26.Location = new System.Drawing.Point(276, 187);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(120, 23);
			this.label26.TabIndex = 91;
			this.label26.Tag = "NAT_CO";
			this.label26.Text = "NAT_CO Nguyen Quan";
			// 
			// label25
			// 
			this.label25.Location = new System.Drawing.Point(276, 215);
			this.label25.Name = "label25";
			this.label25.TabIndex = 89;
			this.label25.Tag = "COU_ID";
			this.label25.Text = "COU_ID Nation";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(12, 243);
			this.label10.Name = "label10";
			this.label10.TabIndex = 63;
			this.label10.Tag = "PRO_ID";
			this.label10.Text = "PRO_ID";
			// 
			// Comport
			// 
			this.Comport.ContainingControl = this;
			this.Comport.Enabled = true;
			this.Comport.Location = new System.Drawing.Point(900, 28);
			this.Comport.Name = "Comport";
			this.Comport.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Comport.OcxState")));
			this.Comport.Size = new System.Drawing.Size(38, 38);
			this.Comport.TabIndex = 6;
			// 
			// label57
			// 
			this.label57.Location = new System.Drawing.Point(12, 215);
			this.label57.Name = "label57";
			this.label57.Size = new System.Drawing.Size(132, 23);
			this.label57.TabIndex = 142;
			this.label57.Tag = "REL_DR";
			this.label57.Text = "REL_DR Ton Giao";
			// 
			// label34
			// 
			this.label34.Location = new System.Drawing.Point(12, 351);
			this.label34.Name = "label34";
			this.label34.TabIndex = 123;
			this.label34.Tag = "REM_DR";
			this.label34.Text = "REM_DR";
			// 
			// label59
			// 
			this.label59.Location = new System.Drawing.Point(276, 159);
			this.label59.Name = "label59";
			this.label59.TabIndex = 149;
			this.label59.Tag = "MST_DR";
			this.label59.Text = "TEL_NO";
			// 
			// g2
			// 
			this.g2.Controls.Add(this.dt_INH_DT);
			this.g2.Controls.Add(this.txt_EMP_I1);
			this.g2.Controls.Add(this.txt_EMP_ID);
			this.g2.Controls.Add(this.cb_LEV_ID);
			this.g2.Controls.Add(this.cb_POS_ID);
			this.g2.Controls.Add(this.cmd_com);
			this.g2.Controls.Add(this.cb_GRT_ID);
			this.g2.Controls.Add(this.cb_GRP_ID);
			this.g2.Controls.Add(this.cb_TYP_ID);
			this.g2.Controls.Add(this.cb_DEP_ID);
			this.g2.Controls.Add(this.label29);
			this.g2.Controls.Add(this.txt_CRD_NO);
			this.g2.Controls.Add(this.label23);
			this.g2.Controls.Add(this.txt_DEP_N1);
			this.g2.Controls.Add(this.label56);
			this.g2.Controls.Add(this.label4);
			this.g2.Controls.Add(this.label60);
			this.g2.Controls.Add(this.label28);
			this.g2.Controls.Add(this.label27);
			this.g2.Controls.Add(this.label22);
			this.g2.Controls.Add(this.label21);
			this.g2.Controls.Add(this.label3);
			this.g2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.g2.Location = new System.Drawing.Point(4, 412);
			this.g2.Name = "g2";
			this.g2.Size = new System.Drawing.Size(528, 196);
			this.g2.TabIndex = 150;
			this.g2.TabStop = false;
			this.g2.Tag = "N";
			this.g2.Visible = false;
			// 
			// dt_INH_DT
			// 
			this.dt_INH_DT.BackColor = System.Drawing.Color.Cornsilk;
			this.dt_INH_DT.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt_INH_DT.Location = new System.Drawing.Point(100, 158);
			this.dt_INH_DT.Name = "dt_INH_DT";
			this.dt_INH_DT.Size = new System.Drawing.Size(160, 23);
			this.dt_INH_DT.TabIndex = 34;
			this.dt_INH_DT.Tag = "INH_DT";
			// 
			// txt_EMP_I1
			// 
			this.txt_EMP_I1.BackColor = System.Drawing.SystemColors.Window;
			this.txt_EMP_I1.Location = new System.Drawing.Point(364, 18);
			this.txt_EMP_I1.MaxLength = 20;
			this.txt_EMP_I1.Name = "txt_EMP_I1";
			this.txt_EMP_I1.Size = new System.Drawing.Size(160, 23);
			this.txt_EMP_I1.TabIndex = 26;
			this.txt_EMP_I1.Tag = "EMP_I1";
			this.txt_EMP_I1.Text = "textBox4";
			// 
			// txt_EMP_ID
			// 
			this.txt_EMP_ID.BackColor = System.Drawing.Color.Cornsilk;
			this.txt_EMP_ID.Location = new System.Drawing.Point(100, 18);
			this.txt_EMP_ID.MaxLength = 20;
			this.txt_EMP_ID.Name = "txt_EMP_ID";
			this.txt_EMP_ID.Size = new System.Drawing.Size(156, 23);
			this.txt_EMP_ID.TabIndex = 25;
			this.txt_EMP_ID.Tag = "EMP_ID";
			this.txt_EMP_ID.Text = "textBox3";
			this.txt_EMP_ID.TextChanged += new System.EventHandler(this.txt_EMP_ID_TextChanged);
			// 
			// cb_LEV_ID
			// 
			this.cb_LEV_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_LEV_ID.Location = new System.Drawing.Point(364, 132);
			this.cb_LEV_ID.Name = "cb_LEV_ID";
			this.cb_LEV_ID.Size = new System.Drawing.Size(160, 24);
			this.cb_LEV_ID.TabIndex = 33;
			this.cb_LEV_ID.Tag = "LEV_ID";
			// 
			// cb_POS_ID
			// 
			this.cb_POS_ID.BackColor = System.Drawing.Color.Cornsilk;
			this.cb_POS_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_POS_ID.Location = new System.Drawing.Point(100, 75);
			this.cb_POS_ID.Name = "cb_POS_ID";
			this.cb_POS_ID.Size = new System.Drawing.Size(160, 24);
			this.cb_POS_ID.TabIndex = 28;
			this.cb_POS_ID.Tag = "POS_ID";
			// 
			// cmd_com
			// 
			this.cmd_com.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_com.Location = new System.Drawing.Point(232, 132);
			this.cmd_com.Name = "cmd_com";
			this.cmd_com.Size = new System.Drawing.Size(28, 24);
			this.cmd_com.TabIndex = 155;
			this.cmd_com.Tag = "N";
			this.cmd_com.Text = "...";
			// 
			// cb_GRT_ID
			// 
			this.cb_GRT_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_GRT_ID.Location = new System.Drawing.Point(364, 75);
			this.cb_GRT_ID.Name = "cb_GRT_ID";
			this.cb_GRT_ID.Size = new System.Drawing.Size(160, 24);
			this.cb_GRT_ID.TabIndex = 31;
			this.cb_GRT_ID.Tag = "GRT_ID";
			// 
			// cb_GRP_ID
			// 
			this.cb_GRP_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_GRP_ID.Location = new System.Drawing.Point(364, 103);
			this.cb_GRP_ID.Name = "cb_GRP_ID";
			this.cb_GRP_ID.Size = new System.Drawing.Size(160, 24);
			this.cb_GRP_ID.TabIndex = 32;
			this.cb_GRP_ID.Tag = "GRP_ID";
			// 
			// cb_TYP_ID
			// 
			this.cb_TYP_ID.BackColor = System.Drawing.Color.Cornsilk;
			this.cb_TYP_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_TYP_ID.Location = new System.Drawing.Point(100, 103);
			this.cb_TYP_ID.Name = "cb_TYP_ID";
			this.cb_TYP_ID.Size = new System.Drawing.Size(160, 24);
			this.cb_TYP_ID.TabIndex = 30;
			this.cb_TYP_ID.Tag = "TYP_ID";
			// 
			// cb_DEP_ID
			// 
			this.cb_DEP_ID.BackColor = System.Drawing.Color.Cornsilk;
			this.cb_DEP_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_DEP_ID.Location = new System.Drawing.Point(100, 47);
			this.cb_DEP_ID.Name = "cb_DEP_ID";
			this.cb_DEP_ID.Size = new System.Drawing.Size(160, 24);
			this.cb_DEP_ID.TabIndex = 27;
			this.cb_DEP_ID.Tag = "DEP_ID";
			this.cb_DEP_ID.SelectedIndexChanged += new System.EventHandler(this.cb_DEP_ID_SelectedIndexChanged_1);
			// 
			// label29
			// 
			this.label29.Location = new System.Drawing.Point(264, 82);
			this.label29.Name = "label29";
			this.label29.TabIndex = 154;
			this.label29.Tag = "GRT_ID";
			this.label29.Text = "GRT_ID";
			// 
			// txt_CRD_NO
			// 
			this.txt_CRD_NO.BackColor = System.Drawing.Color.Cornsilk;
			this.txt_CRD_NO.Location = new System.Drawing.Point(100, 132);
			this.txt_CRD_NO.MaxLength = 10;
			this.txt_CRD_NO.Name = "txt_CRD_NO";
			this.txt_CRD_NO.Size = new System.Drawing.Size(132, 23);
			this.txt_CRD_NO.TabIndex = 29;
			this.txt_CRD_NO.Tag = "CRD_NO";
			this.txt_CRD_NO.Text = "textBox7";
			// 
			// label23
			// 
			this.label23.ForeColor = System.Drawing.Color.Red;
			this.label23.Location = new System.Drawing.Point(4, 140);
			this.label23.Name = "label23";
			this.label23.TabIndex = 151;
			this.label23.Tag = "CRD_NO";
			this.label23.Text = "CRD_NO";
			this.label23.Click += new System.EventHandler(this.label23_Click);
			// 
			// txt_DEP_N1
			// 
			this.txt_DEP_N1.BackColor = System.Drawing.SystemColors.Window;
			this.txt_DEP_N1.Location = new System.Drawing.Point(260, 47);
			this.txt_DEP_N1.MaxLength = 20;
			this.txt_DEP_N1.Name = "txt_DEP_N1";
			this.txt_DEP_N1.ReadOnly = true;
			this.txt_DEP_N1.Size = new System.Drawing.Size(264, 23);
			this.txt_DEP_N1.TabIndex = 149;
			this.txt_DEP_N1.Tag = "";
			this.txt_DEP_N1.Text = "textBox6";
			// 
			// label56
			// 
			this.label56.Location = new System.Drawing.Point(268, 139);
			this.label56.Name = "label56";
			this.label56.TabIndex = 156;
			this.label56.Tag = "LEV_ID";
			this.label56.Text = "LEV_ID";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(268, 24);
			this.label4.Name = "label4";
			this.label4.TabIndex = 160;
			this.label4.Tag = "EMP_I1";
			this.label4.Text = "EMP_I1";
			// 
			// label60
			// 
			this.label60.ForeColor = System.Drawing.Color.Red;
			this.label60.Location = new System.Drawing.Point(4, 164);
			this.label60.Name = "label60";
			this.label60.TabIndex = 166;
			this.label60.Tag = "INH_DT";
			this.label60.Text = "INH_DT";
			// 
			// label28
			// 
			this.label28.Location = new System.Drawing.Point(268, 111);
			this.label28.Name = "label28";
			this.label28.TabIndex = 153;
			this.label28.Tag = "GRP_ID";
			this.label28.Text = "GRP_ID";
			this.label28.Click += new System.EventHandler(this.label28_Click);
			// 
			// label27
			// 
			this.label27.ForeColor = System.Drawing.Color.Red;
			this.label27.Location = new System.Drawing.Point(4, 111);
			this.label27.Name = "label27";
			this.label27.TabIndex = 152;
			this.label27.Tag = "TYP_ID";
			this.label27.Text = "TYP_ID  Nature";
			this.label27.Click += new System.EventHandler(this.label27_Click);
			// 
			// label22
			// 
			this.label22.ForeColor = System.Drawing.Color.Red;
			this.label22.Location = new System.Drawing.Point(4, 83);
			this.label22.Name = "label22";
			this.label22.TabIndex = 150;
			this.label22.Tag = "POS_ID";
			this.label22.Text = "POS_ID";
			this.label22.Click += new System.EventHandler(this.label22_Click);
			// 
			// label21
			// 
			this.label21.ForeColor = System.Drawing.Color.Red;
			this.label21.Location = new System.Drawing.Point(4, 55);
			this.label21.Name = "label21";
			this.label21.TabIndex = 148;
			this.label21.Tag = "DEP_ID";
			this.label21.Text = "DEP_ID";
			this.label21.Click += new System.EventHandler(this.label21_Click);
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.Color.Red;
			this.label3.Location = new System.Drawing.Point(4, 26);
			this.label3.Name = "label3";
			this.label3.TabIndex = 159;
			this.label3.Tag = "EMP_ID";
			this.label3.Text = "EMP_ID";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// c1DockingTab3
			// 
			this.c1DockingTab3.Controls.Add(this.Tab_HDLD);
			this.c1DockingTab3.Controls.Add(this.Tab_BHXH);
			this.c1DockingTab3.Location = new System.Drawing.Point(536, 340);
			this.c1DockingTab3.Name = "c1DockingTab3";
			this.c1DockingTab3.SelectedIndex = 1;
			this.c1DockingTab3.Size = new System.Drawing.Size(408, 308);
			this.c1DockingTab3.TabIndex = 37;
			this.c1DockingTab3.TabStyle = C1.Win.C1Command.TabStyleEnum.WindowsXP;
			this.c1DockingTab3.Visible = false;
			// 
			// Tab_HDLD
			// 
			this.Tab_HDLD.Controls.Add(this.panel8);
			this.Tab_HDLD.ImageIndex = -1;
			this.Tab_HDLD.Location = new System.Drawing.Point(2, 28);
			this.Tab_HDLD.Name = "Tab_HDLD";
			this.Tab_HDLD.Size = new System.Drawing.Size(402, 276);
			this.Tab_HDLD.TabIndex = 0;
			this.Tab_HDLD.Text = "HDLD";
			// 
			// panel8
			// 
			this.panel8.Controls.Add(this.gp);
			this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel8.Location = new System.Drawing.Point(0, 0);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(402, 276);
			this.panel8.TabIndex = 0;
			// 
			// gp
			// 
			this.gp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.gp.Controls.Add(this.txt_LA1_TM);
			this.gp.Controls.Add(this.txt_LAB_TM);
			this.gp.Controls.Add(this.dt_LA1_ED);
			this.gp.Controls.Add(this.dt_LA1_ST);
			this.gp.Controls.Add(this.txt_LA1_NO);
			this.gp.Controls.Add(this.dt_LAB_ED);
			this.gp.Controls.Add(this.dt_LAB_ST);
			this.gp.Controls.Add(this.txt_LAB_NO);
			this.gp.Controls.Add(this.label48);
			this.gp.Controls.Add(this.label47);
			this.gp.Controls.Add(this.label50);
			this.gp.Controls.Add(this.label51);
			this.gp.Controls.Add(this.label52);
			this.gp.Controls.Add(this.label53);
			this.gp.Controls.Add(this.dd);
			this.gp.Controls.Add(this.label55);
			this.gp.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gp.Location = new System.Drawing.Point(4, -4);
			this.gp.Name = "gp";
			this.gp.Size = new System.Drawing.Size(396, 276);
			this.gp.TabIndex = 0;
			this.gp.TabStop = false;
			this.gp.Tag = "N";
			// 
			// txt_LA1_TM
			// 
			this.txt_LA1_TM.Location = new System.Drawing.Point(156, 156);
			this.txt_LA1_TM.MaxLength = 3;
			this.txt_LA1_TM.Name = "txt_LA1_TM";
			this.txt_LA1_TM.Size = new System.Drawing.Size(160, 23);
			this.txt_LA1_TM.TabIndex = 5;
			this.txt_LA1_TM.Tag = "LA1_TM";
			this.txt_LA1_TM.Text = "";
			this.txt_LA1_TM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_LA1_TM_KeyPress);
			// 
			// txt_LAB_TM
			// 
			this.txt_LAB_TM.Location = new System.Drawing.Point(156, 40);
			this.txt_LAB_TM.MaxLength = 3;
			this.txt_LAB_TM.Name = "txt_LAB_TM";
			this.txt_LAB_TM.Size = new System.Drawing.Size(160, 23);
			this.txt_LAB_TM.TabIndex = 1;
			this.txt_LAB_TM.Tag = "LAB_TM";
			this.txt_LAB_TM.Text = "";
			this.txt_LAB_TM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_LA1_TM_KeyPress);
			// 
			// dt_LA1_ED
			// 
			this.dt_LA1_ED.EmptyAsNull = true;
			this.dt_LA1_ED.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt_LA1_ED.Location = new System.Drawing.Point(156, 212);
			this.dt_LA1_ED.Name = "dt_LA1_ED";
			this.dt_LA1_ED.Size = new System.Drawing.Size(160, 23);
			this.dt_LA1_ED.TabIndex = 7;
			this.dt_LA1_ED.Tag = "LA1_ED";
			// 
			// dt_LA1_ST
			// 
			this.dt_LA1_ST.EmptyAsNull = true;
			this.dt_LA1_ST.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt_LA1_ST.Location = new System.Drawing.Point(156, 184);
			this.dt_LA1_ST.Name = "dt_LA1_ST";
			this.dt_LA1_ST.Size = new System.Drawing.Size(160, 23);
			this.dt_LA1_ST.TabIndex = 6;
			this.dt_LA1_ST.Tag = "LA1_ST";
			// 
			// txt_LA1_NO
			// 
			this.txt_LA1_NO.Location = new System.Drawing.Point(156, 128);
			this.txt_LA1_NO.MaxLength = 50;
			this.txt_LA1_NO.Name = "txt_LA1_NO";
			this.txt_LA1_NO.Size = new System.Drawing.Size(160, 23);
			this.txt_LA1_NO.TabIndex = 4;
			this.txt_LA1_NO.Tag = "LA1_NO";
			this.txt_LA1_NO.Text = "";
			// 
			// dt_LAB_ED
			// 
			this.dt_LAB_ED.EmptyAsNull = true;
			this.dt_LAB_ED.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt_LAB_ED.Location = new System.Drawing.Point(156, 96);
			this.dt_LAB_ED.Name = "dt_LAB_ED";
			this.dt_LAB_ED.Size = new System.Drawing.Size(160, 23);
			this.dt_LAB_ED.TabIndex = 3;
			this.dt_LAB_ED.Tag = "LAB_ED";
			// 
			// dt_LAB_ST
			// 
			this.dt_LAB_ST.EmptyAsNull = true;
			this.dt_LAB_ST.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt_LAB_ST.Location = new System.Drawing.Point(156, 68);
			this.dt_LAB_ST.Name = "dt_LAB_ST";
			this.dt_LAB_ST.Size = new System.Drawing.Size(160, 23);
			this.dt_LAB_ST.TabIndex = 2;
			this.dt_LAB_ST.Tag = "LAB_ST";
			// 
			// txt_LAB_NO
			// 
			this.txt_LAB_NO.Location = new System.Drawing.Point(156, 12);
			this.txt_LAB_NO.MaxLength = 50;
			this.txt_LAB_NO.Name = "txt_LAB_NO";
			this.txt_LAB_NO.Size = new System.Drawing.Size(160, 23);
			this.txt_LAB_NO.TabIndex = 0;
			this.txt_LAB_NO.Tag = "LAB_NO";
			this.txt_LAB_NO.Text = "";
			// 
			// label48
			// 
			this.label48.Location = new System.Drawing.Point(4, 164);
			this.label48.Name = "label48";
			this.label48.Size = new System.Drawing.Size(160, 23);
			this.label48.TabIndex = 132;
			this.label48.Tag = "LA1_TM";
			this.label48.Text = "BHX_NO";
			// 
			// label47
			// 
			this.label47.Location = new System.Drawing.Point(4, 48);
			this.label47.Name = "label47";
			this.label47.Size = new System.Drawing.Size(160, 23);
			this.label47.TabIndex = 130;
			this.label47.Tag = "LAB_TM";
			this.label47.Text = "LAB_NO";
			// 
			// label50
			// 
			this.label50.Location = new System.Drawing.Point(4, 220);
			this.label50.Name = "label50";
			this.label50.Size = new System.Drawing.Size(160, 23);
			this.label50.TabIndex = 128;
			this.label50.Tag = "LA1_ED";
			this.label50.Text = "CRD_DT";
			// 
			// label51
			// 
			this.label51.Location = new System.Drawing.Point(4, 192);
			this.label51.Name = "label51";
			this.label51.Size = new System.Drawing.Size(160, 23);
			this.label51.TabIndex = 126;
			this.label51.Tag = "LA1_ST";
			this.label51.Text = "CRD_DT";
			// 
			// label52
			// 
			this.label52.Location = new System.Drawing.Point(4, 136);
			this.label52.Name = "label52";
			this.label52.Size = new System.Drawing.Size(160, 23);
			this.label52.TabIndex = 124;
			this.label52.Tag = "LA1_NO";
			this.label52.Text = "BHX_NO";
			// 
			// label53
			// 
			this.label53.Location = new System.Drawing.Point(4, 104);
			this.label53.Name = "label53";
			this.label53.Size = new System.Drawing.Size(160, 23);
			this.label53.TabIndex = 122;
			this.label53.Tag = "LAB_ED";
			this.label53.Text = "CRD_DT";
			// 
			// dd
			// 
			this.dd.Location = new System.Drawing.Point(4, 76);
			this.dd.Name = "dd";
			this.dd.Size = new System.Drawing.Size(160, 23);
			this.dd.TabIndex = 120;
			this.dd.Tag = "LAB_ST";
			this.dd.Text = "BHX_ST";
			// 
			// label55
			// 
			this.label55.Location = new System.Drawing.Point(4, 20);
			this.label55.Name = "label55";
			this.label55.Size = new System.Drawing.Size(160, 23);
			this.label55.TabIndex = 118;
			this.label55.Tag = "LAB_NO";
			this.label55.Text = "LAB_NO";
			// 
			// Tab_BHXH
			// 
			this.Tab_BHXH.Controls.Add(this.panel9);
			this.Tab_BHXH.ImageIndex = -1;
			this.Tab_BHXH.Location = new System.Drawing.Point(2, 28);
			this.Tab_BHXH.Name = "Tab_BHXH";
			this.Tab_BHXH.Size = new System.Drawing.Size(402, 276);
			this.Tab_BHXH.TabIndex = 1;
			this.Tab_BHXH.Text = "BH";
			// 
			// panel9
			// 
			this.panel9.Controls.Add(this.gp1);
			this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel9.Location = new System.Drawing.Point(0, 0);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(402, 276);
			this.panel9.TabIndex = 1;
			// 
			// gp1
			// 
			this.gp1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.gp1.Controls.Add(this.dt_BHL_ED);
			this.gp1.Controls.Add(this.dt_BHL_ST);
			this.gp1.Controls.Add(this.txt_BHL_NO);
			this.gp1.Controls.Add(this.dt_BHY_ED);
			this.gp1.Controls.Add(this.dt_BHY_ST);
			this.gp1.Controls.Add(this.txt_BHY_NO);
			this.gp1.Controls.Add(this.dt_BHX_ED);
			this.gp1.Controls.Add(this.dt_BHX_ST);
			this.gp1.Controls.Add(this.txt_BHX_NO);
			this.gp1.Controls.Add(this.label44);
			this.gp1.Controls.Add(this.label45);
			this.gp1.Controls.Add(this.label46);
			this.gp1.Controls.Add(this.label41);
			this.gp1.Controls.Add(this.label42);
			this.gp1.Controls.Add(this.label43);
			this.gp1.Controls.Add(this.label40);
			this.gp1.Controls.Add(this.label38);
			this.gp1.Controls.Add(this.label30);
			this.gp1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gp1.Location = new System.Drawing.Point(3, -4);
			this.gp1.Name = "gp1";
			this.gp1.Size = new System.Drawing.Size(396, 280);
			this.gp1.TabIndex = 1;
			this.gp1.TabStop = false;
			this.gp1.Tag = "N";
			// 
			// dt_BHL_ED
			// 
			this.dt_BHL_ED.EmptyAsNull = true;
			this.dt_BHL_ED.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt_BHL_ED.Location = new System.Drawing.Point(140, 236);
			this.dt_BHL_ED.Name = "dt_BHL_ED";
			this.dt_BHL_ED.Size = new System.Drawing.Size(160, 20);
			this.dt_BHL_ED.TabIndex = 8;
			this.dt_BHL_ED.Tag = "BHL_ED";
			// 
			// dt_BHL_ST
			// 
			this.dt_BHL_ST.EmptyAsNull = true;
			this.dt_BHL_ST.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt_BHL_ST.Location = new System.Drawing.Point(140, 208);
			this.dt_BHL_ST.Name = "dt_BHL_ST";
			this.dt_BHL_ST.Size = new System.Drawing.Size(160, 20);
			this.dt_BHL_ST.TabIndex = 7;
			this.dt_BHL_ST.Tag = "BHL_ST";
			// 
			// txt_BHL_NO
			// 
			this.txt_BHL_NO.Location = new System.Drawing.Point(140, 180);
			this.txt_BHL_NO.MaxLength = 20;
			this.txt_BHL_NO.Name = "txt_BHL_NO";
			this.txt_BHL_NO.Size = new System.Drawing.Size(160, 23);
			this.txt_BHL_NO.TabIndex = 6;
			this.txt_BHL_NO.Tag = "BHL_NO";
			this.txt_BHL_NO.Text = "";
			// 
			// dt_BHY_ED
			// 
			this.dt_BHY_ED.EmptyAsNull = true;
			this.dt_BHY_ED.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt_BHY_ED.Location = new System.Drawing.Point(140, 152);
			this.dt_BHY_ED.Name = "dt_BHY_ED";
			this.dt_BHY_ED.Size = new System.Drawing.Size(160, 20);
			this.dt_BHY_ED.TabIndex = 5;
			this.dt_BHY_ED.Tag = "BHY_ED";
			// 
			// dt_BHY_ST
			// 
			this.dt_BHY_ST.EmptyAsNull = true;
			this.dt_BHY_ST.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt_BHY_ST.Location = new System.Drawing.Point(140, 124);
			this.dt_BHY_ST.Name = "dt_BHY_ST";
			this.dt_BHY_ST.Size = new System.Drawing.Size(160, 20);
			this.dt_BHY_ST.TabIndex = 4;
			this.dt_BHY_ST.Tag = "BHY_ST";
			// 
			// txt_BHY_NO
			// 
			this.txt_BHY_NO.Location = new System.Drawing.Point(140, 96);
			this.txt_BHY_NO.MaxLength = 20;
			this.txt_BHY_NO.Name = "txt_BHY_NO";
			this.txt_BHY_NO.Size = new System.Drawing.Size(160, 23);
			this.txt_BHY_NO.TabIndex = 3;
			this.txt_BHY_NO.Tag = "BHY_NO";
			this.txt_BHY_NO.Text = "";
			// 
			// dt_BHX_ED
			// 
			this.dt_BHX_ED.EmptyAsNull = true;
			this.dt_BHX_ED.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt_BHX_ED.Location = new System.Drawing.Point(140, 68);
			this.dt_BHX_ED.Name = "dt_BHX_ED";
			this.dt_BHX_ED.Size = new System.Drawing.Size(160, 20);
			this.dt_BHX_ED.TabIndex = 2;
			this.dt_BHX_ED.Tag = "BHX_ED";
			// 
			// dt_BHX_ST
			// 
			this.dt_BHX_ST.EmptyAsNull = true;
			this.dt_BHX_ST.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt_BHX_ST.Location = new System.Drawing.Point(140, 40);
			this.dt_BHX_ST.Name = "dt_BHX_ST";
			this.dt_BHX_ST.Size = new System.Drawing.Size(160, 20);
			this.dt_BHX_ST.TabIndex = 1;
			this.dt_BHX_ST.Tag = "BHX_ST";
			// 
			// txt_BHX_NO
			// 
			this.txt_BHX_NO.Location = new System.Drawing.Point(140, 12);
			this.txt_BHX_NO.MaxLength = 20;
			this.txt_BHX_NO.Name = "txt_BHX_NO";
			this.txt_BHX_NO.Size = new System.Drawing.Size(160, 23);
			this.txt_BHX_NO.TabIndex = 0;
			this.txt_BHX_NO.Tag = "BHX_NO";
			this.txt_BHX_NO.Text = "";
			// 
			// label44
			// 
			this.label44.Location = new System.Drawing.Point(4, 244);
			this.label44.Name = "label44";
			this.label44.Size = new System.Drawing.Size(176, 16);
			this.label44.TabIndex = 116;
			this.label44.Tag = "BHL_ED";
			this.label44.Text = "CRD_DT";
			// 
			// label45
			// 
			this.label45.Location = new System.Drawing.Point(4, 216);
			this.label45.Name = "label45";
			this.label45.Size = new System.Drawing.Size(176, 23);
			this.label45.TabIndex = 114;
			this.label45.Tag = "BHL_ST";
			this.label45.Text = "CRD_DT";
			// 
			// label46
			// 
			this.label46.Location = new System.Drawing.Point(4, 188);
			this.label46.Name = "label46";
			this.label46.Size = new System.Drawing.Size(176, 23);
			this.label46.TabIndex = 112;
			this.label46.Tag = "BHL_NO";
			this.label46.Text = "BHX_NO";
			// 
			// label41
			// 
			this.label41.Location = new System.Drawing.Point(4, 160);
			this.label41.Name = "label41";
			this.label41.Size = new System.Drawing.Size(176, 23);
			this.label41.TabIndex = 110;
			this.label41.Tag = "BHY_ED";
			this.label41.Text = "CRD_DT";
			// 
			// label42
			// 
			this.label42.Location = new System.Drawing.Point(4, 132);
			this.label42.Name = "label42";
			this.label42.Size = new System.Drawing.Size(176, 23);
			this.label42.TabIndex = 108;
			this.label42.Tag = "BHY_ST";
			this.label42.Text = "CRD_DT";
			// 
			// label43
			// 
			this.label43.Location = new System.Drawing.Point(4, 104);
			this.label43.Name = "label43";
			this.label43.Size = new System.Drawing.Size(176, 23);
			this.label43.TabIndex = 106;
			this.label43.Tag = "BHY_NO";
			this.label43.Text = "BHX_NO";
			// 
			// label40
			// 
			this.label40.Location = new System.Drawing.Point(4, 76);
			this.label40.Name = "label40";
			this.label40.Size = new System.Drawing.Size(176, 23);
			this.label40.TabIndex = 104;
			this.label40.Tag = "BHX_ED";
			this.label40.Text = "CRD_DT";
			// 
			// label38
			// 
			this.label38.Location = new System.Drawing.Point(4, 48);
			this.label38.Name = "label38";
			this.label38.Size = new System.Drawing.Size(176, 23);
			this.label38.TabIndex = 102;
			this.label38.Tag = "BHX_ST";
			this.label38.Text = "BHX_ST";
			// 
			// label30
			// 
			this.label30.Location = new System.Drawing.Point(4, 20);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(176, 23);
			this.label30.TabIndex = 100;
			this.label30.Tag = "BHX_NO";
			this.label30.Text = "BHX_NO";
			// 
			// label62
			// 
			this.label62.Location = new System.Drawing.Point(560, 16);
			this.label62.Name = "label62";
			this.label62.TabIndex = 162;
			this.label62.Tag = "SEX_BT";
			this.label62.Text = "SEX_BT";
			// 
			// label61
			// 
			this.label61.Location = new System.Drawing.Point(560, 36);
			this.label61.Name = "label61";
			this.label61.TabIndex = 163;
			this.label61.Tag = "MAR_BT";
			this.label61.Text = "MAR_BT";
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.PaleGreen;
			this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel6.Controls.Add(this.S_CRD_ID);
			this.panel6.Controls.Add(this.ck_QEdit);
			this.panel6.Controls.Add(this.ck_search);
			this.panel6.Controls.Add(this.S_EMP_NM);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel6.Location = new System.Drawing.Point(0, 0);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(984, 32);
			this.panel6.TabIndex = 3;
			// 
			// S_CRD_ID
			// 
			this.S_CRD_ID.BackColor = System.Drawing.Color.LemonChiffon;
			this.S_CRD_ID.Location = new System.Drawing.Point(0, 4);
			this.S_CRD_ID.MaxLength = 9;
			this.S_CRD_ID.Name = "S_CRD_ID";
			this.S_CRD_ID.Size = new System.Drawing.Size(160, 23);
			this.S_CRD_ID.TabIndex = 0;
			this.S_CRD_ID.Tag = "CRD_ID";
			this.S_CRD_ID.Text = "textBox5";
			// 
			// ck_QEdit
			// 
			this.ck_QEdit.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ck_QEdit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ck_QEdit.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.ck_QEdit.Location = new System.Drawing.Point(436, 4);
			this.ck_QEdit.Name = "ck_QEdit";
			this.ck_QEdit.Size = new System.Drawing.Size(100, 24);
			this.ck_QEdit.TabIndex = 5;
			this.ck_QEdit.Tag = "SEX_BT";
			this.ck_QEdit.Text = "SEX_BT";
			this.ck_QEdit.CheckedChanged += new System.EventHandler(this.ck_QEdit_CheckedChanged);
			// 
			// ck_search
			// 
			this.ck_search.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ck_search.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ck_search.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.ck_search.Location = new System.Drawing.Point(324, 4);
			this.ck_search.Name = "ck_search";
			this.ck_search.Size = new System.Drawing.Size(100, 24);
			this.ck_search.TabIndex = 4;
			this.ck_search.Tag = "";
			this.ck_search.Text = "Exactly Find";
			// 
			// S_EMP_NM
			// 
			this.S_EMP_NM.BackColor = System.Drawing.Color.Azure;
			this.S_EMP_NM.Location = new System.Drawing.Point(164, 4);
			this.S_EMP_NM.MaxLength = 20;
			this.S_EMP_NM.Name = "S_EMP_NM";
			this.S_EMP_NM.Size = new System.Drawing.Size(156, 23);
			this.S_EMP_NM.TabIndex = 1;
			this.S_EMP_NM.Tag = "EMP_NM";
			this.S_EMP_NM.Text = "EMP_NM";
			this.S_EMP_NM.KeyDown += new System.Windows.Forms.KeyEventHandler(this.S_EMP_ID_KeyDown);
			this.S_EMP_NM.Leave += new System.EventHandler(this.S_EMP_NM_Leave);
			this.S_EMP_NM.Enter += new System.EventHandler(this.S_EMP_NM_Enter);
			// 
			// c1CommandDock2
			// 
			this.c1CommandDock2.Controls.Add(this.c1DockingTab2);
			this.c1CommandDock2.Dock = System.Windows.Forms.DockStyle.Right;
			this.c1CommandDock2.Id = 2;
			this.c1CommandDock2.Location = new System.Drawing.Point(984, 0);
			this.c1CommandDock2.Name = "c1CommandDock2";
			this.c1CommandDock2.Size = new System.Drawing.Size(28, 710);
			// 
			// c1DockingTab2
			// 
			this.c1DockingTab2.Alignment = System.Windows.Forms.TabAlignment.Bottom;
			this.c1DockingTab2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.c1DockingTab2.CanAutoHide = true;
			this.c1DockingTab2.CanMoveTabs = true;
			this.c1DockingTab2.Controls.Add(this.c1DockingTabPage2);
			this.c1DockingTab2.Location = new System.Drawing.Point(0, 0);
			this.c1DockingTab2.Name = "c1DockingTab2";
			this.c1DockingTab2.SelectedIndex = 0;
			this.c1DockingTab2.ShowCaption = true;
			this.c1DockingTab2.ShowSingleTab = false;
			this.c1DockingTab2.Size = new System.Drawing.Size(28, 710);
			this.c1DockingTab2.TabIndex = 0;
			this.c1DockingTab2.TabSizeMode = C1.Win.C1Command.TabSizeModeEnum.Fit;
			this.c1DockingTab2.TabStyle = C1.Win.C1Command.TabStyleEnum.WindowsXP;
			// 
			// c1DockingTabPage2
			// 
			this.c1DockingTabPage2.Controls.Add(this.vs);
			this.c1DockingTabPage2.ImageIndex = -1;
			this.c1DockingTabPage2.Location = new System.Drawing.Point(4, 1);
			this.c1DockingTabPage2.Name = "c1DockingTabPage2";
			this.c1DockingTabPage2.Size = new System.Drawing.Size(23, 708);
			this.c1DockingTabPage2.TabIndex = 0;
			this.c1DockingTabPage2.Text = "Page2";
			// 
			// vs
			// 
			this.vs.ColumnInfo = "10,1,0,0,0,100,Columns:";
			this.vs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vs.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Heavy;
			this.vs.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus;
			this.vs.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs.Location = new System.Drawing.Point(0, 20);
			this.vs.Name = "vs";
			this.vs.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell;
			this.vs.Size = new System.Drawing.Size(23, 688);
			this.vs.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs.TabIndex = 0;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.panel4);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(16, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1012, 36);
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
			this.label5.Size = new System.Drawing.Size(596, 36);
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
			this.nav.Location = new System.Drawing.Point(3, 2);
			this.nav.MSG_Exit = false;
			this.nav.MulltiDel = false;
			this.nav.Name = "nav";
			this.nav.Security = 0;
			this.nav.ShowPopupMenu = true;
			this.nav.Size = new System.Drawing.Size(472, 32);
			this.nav.TabIndex = 9;
			this.nav.ToolBar_Auto = true;
			this.nav.UserID = null;
			this.nav.VisibleGrid = true;
			this.nav.Where = null;
			this.nav.Load += new System.EventHandler(this.nav_Load);
			// 
			// c1CommandDock1
			// 
			this.c1CommandDock1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.c1CommandDock1.Controls.Add(this.c1DockingTab1);
			this.c1CommandDock1.Dock = System.Windows.Forms.DockStyle.Left;
			this.c1CommandDock1.Id = 1;
			this.c1CommandDock1.Location = new System.Drawing.Point(0, 0);
			this.c1CommandDock1.Name = "c1CommandDock1";
			this.c1CommandDock1.Size = new System.Drawing.Size(16, 746);
			// 
			// c1DockingTab1
			// 
			this.c1DockingTab1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
			this.c1DockingTab1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.c1DockingTab1.CanAutoHide = true;
			this.c1DockingTab1.CanMoveTabs = true;
			this.c1DockingTab1.Controls.Add(this.c1DockingTabPage1);
			this.c1DockingTab1.Location = new System.Drawing.Point(0, 0);
			this.c1DockingTab1.Name = "c1DockingTab1";
			this.c1DockingTab1.SelectedIndex = 0;
			this.c1DockingTab1.ShowCaption = true;
			this.c1DockingTab1.ShowSingleTab = false;
			this.c1DockingTab1.Size = new System.Drawing.Size(14, 744);
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
			this.c1DockingTabPage1.Size = new System.Drawing.Size(11, 743);
			this.c1DockingTabPage1.TabIndex = 0;
			this.c1DockingTabPage1.Text = "Page1";
			// 
			// Dep
			// 
			this.Dep.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Dep.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Dep.Location = new System.Drawing.Point(0, 20);
			this.Dep.Name = "Dep";
			this.Dep.Size = new System.Drawing.Size(11, 723);
			this.Dep.TabIndex = 0;
			this.Dep.Visible = false;
			// 
			// frmTuProStaffInfo
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(1028, 746);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTuProStaffInfo";
			this.Text = "frmTuProStaffInfo";
			this.Load += new System.EventHandler(this.frmTuProStaffInfo_Load);
			this.Closed += new System.EventHandler(this.frmTaStaffInfo_Closed);
			this.panel1.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.p2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.rpt)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_BIR_DT)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dt_BIR_DT)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dt_CRD_DT)).EndInit();
			this.panel7.ResumeLayout(false);
			this.p1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dt_INH_D1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Comport)).EndInit();
			this.g2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dt_INH_DT)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1DockingTab3)).EndInit();
			this.c1DockingTab3.ResumeLayout(false);
			this.Tab_HDLD.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.gp.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dt_LA1_ED)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dt_LA1_ST)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dt_LAB_ED)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dt_LAB_ST)).EndInit();
			this.Tab_BHXH.ResumeLayout(false);
			this.panel9.ResumeLayout(false);
			this.gp1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dt_BHL_ED)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dt_BHL_ST)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dt_BHY_ED)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dt_BHY_ST)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dt_BHX_ED)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dt_BHX_ST)).EndInit();
			this.panel6.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandDock2)).EndInit();
			this.c1CommandDock2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.c1DockingTab2)).EndInit();
			this.c1DockingTab2.ResumeLayout(false);
			this.c1DockingTabPage2.ResumeLayout(false);
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
		#region Load
		private void frmTuProStaffInfo_Load(object sender, System.EventArgs e)
		{
		
			Init_Form();		
			//			CheckNewStaffToOldStaff();
			button1.Enabled=PublicFunction.AccessLevel(84,5);
//			S_EMP_ID.Focus();
			S_CRD_ID.Focus ();
			cmd_upload.Visible=cmd_browser.Visible=cmd_quick.Visible=PublicFunction.AccessLevel(this.Tag,3);
			
		}
		private void CheckNewStaffToOldStaff()
		{
			string sql="Select EMP_ID,INH_DT,NEW_OD from FILB01A a Left JOIN FILA11A b on "
				+"a.TYP_ID=b.TYP_ID where (NEW_BT is " 
				+"null or NEW_BT=0) and (VAC_BT is null or VAC_BT=0) and (LCK_BT is null or LCK_BT=0)";
			DateTime dt=T_String.GetDate(); 
			Func.RecordSet rs=new Func.RecordSet(sql,PublicFunction.C_con);			
			for(int i=0;i<rs.rows;i++)
			{
				try
				{
					DateTime INH_DT=DateTime.Parse(rs.record(i,"INH_DT"));
					if(T_String.IsNullTo0(rs.record(i,"NEW_OD"))!=0 
						&& !T_String.CompareDate(INH_DT.AddDays( T_String.IsNullTo0(rs.record(i,"NEW_OD"))),dt) )
					{
						sql="Update FILB01A set NEW_BT=1 where EMP_ID=N'"+rs.record(i,"EMP_ID")+"'";
						PublicFunction.SQL_Execute(sql);
					}
				}
				catch(Exception){}
			}
		}
		#endregion
		#region Init Form
		string format;
		public void Show_vs(string EMP_ID)
		{
			if(EMP_ID+""!="")
			{
				while(true)
				{
					Thread.Sleep(1000);
					if(nav.State)
						break;
				}				
				nav.Show_VS("EMP_ID=N'"+EMP_ID+"' and "+PublicFunction.Get_TYP(this.Tag,""));				
				ShowData();
			}			
		}

		private void Init_Form()
		{					
			//			Dep.Init_Tree(this.Tag+"");
			//			Dep.vs1.AfterRowColChange+=new RangeEventHandler(Depvs1_AfterRowColChange);
			//			Dep.Show_Tree();
			Init_vs();
			//	Init_vs1();
			//Init_Menu();
			Basic.Function.PublicFunction.L_Init_Label(this);	
			Init_CB();
			ShowData();			
			format=dt_CRD_DT.CustomFormat=dt_INH_DT.CustomFormat=PublicFunction.GetOption("DATE");	
			string edit=PublicFunction.GetOption("DOBDATE");
			if(edit+""!="")
			{
				//				dt_BIR_DT.CustomFormat=PublicFunction.GetOption("DOBDATE");
				//				dt_BIR_DT.Tag="BIR_DT";
				//				dt_BIR_DT.Visible=true;
				//txt_BIR_DT.Tag="";
				//				txt_BIR_DT.Visible=false;
				label1.Text=label1.Text+"("+edit+")";
				edit=edit.Replace("yyyy","####");
				edit=edit.Replace("dd","##");
				edit=edit.Replace("MM","##");
				txt_BIR_DT.EditMask=edit;				
			}
			dt_INH_D1.CustomFormat =dt_BHL_ST.CustomFormat=dt_BHL_ED.CustomFormat=format;
			dt_BHX_ST.CustomFormat=dt_BHX_ED.CustomFormat=format;
			dt_BHY_ST.CustomFormat=dt_BHY_ED.CustomFormat=format;
			dt_LAB_ST.CustomFormat=dt_LAB_ED.CustomFormat=format;
			dt_LA1_ST.CustomFormat=dt_LA1_ED.CustomFormat=format;
			vs.AllowEditing=ck_QEdit.Checked;
			Func.RecordSet rs=new Func.RecordSet("Select * from GP_SYS_READER",PublicFunction.C_con);
			if(rs.rows>0)				
				txt_CRD_NO.MaxLength=T_String.IsNullTo0(rs.record(0,"CRD_LN"));			
			else
				txt_CRD_NO.MaxLength=10;
			
			
		}
		private void Init_vs()
		{
			nav.cmd_copy.Visible=false;	
			nav.cmd_delete.Visible=false;	
			PublicFunction.InitNav(this,vs,nav);

			nav.TBarClick+=new ToolBarButtonClickEventHandler(nav_TBarClick);		
			nav.ToolBar_Auto=false;	
			vs.EnabledChanged+=new EventHandler(vs_EnabledChanged);		
			
			vs.AfterRowColChange+=new RangeEventHandler(vs_AfterRowColChange);						
			vs.Cols["CRD_DT"].Format=PublicFunction.GetOption("DATE");
			vs.Cols["INH_DT"].Format=vs.Cols["INH_D1"].Format=PublicFunction.GetOption("DATE");	
			vs.Styles.Add("VAC_BT");
			vs.Styles["VAC_BT"].BackColor=Color.DarkGray;
			vs.Cols.Frozen=vs.Cols["EMP_NM"].Index;
			vs.Cols["EMP_NM"].Style.BackColor=Color.Azure; 
//			vs.Styles.EmptyArea.BackColor=Color.WhiteSmoke   ;
			vs.Styles.Fixed.BackColor = Color.PaleGreen;//DarkTurquoise;//DarkGray ;
//			vs.Styles.Fixed.ForeColor = Color.White;
			vs.SelectionMode=C1.Win.C1FlexGrid.SelectionModeEnum.CellRange;
			vs.Styles.Focus.BackColor=Color.DarkTurquoise;
			vs.HighLight= C1.Win.C1FlexGrid.HighLightEnum.WithFocus;
		}
		private void Init_vs1()
		{			
			//PublicFunction.InitNav(this,vs1,nav1);								
		}

		private void  Init_CB()
		{
			string sql;			
			//Department
			sql=PublicFunction.GetDep(this.Tag+"");
			PublicFunction.InitCB(cb_DEP_ID,sql);			
			//City
			sql="Select CIT_ID,CIT_NM from FILA03A";
			PublicFunction.InitCB(cb_CIT_ID,sql);			
			//education
			sql="Select EDU_ID,EDU_NM from FILA04A";
			PublicFunction.InitCB(cb_EDU_ID,sql);			
			//Profession
			sql="Select PRO_ID,PRO_NM from FILA05A";
			PublicFunction.InitCB(cb_PRO_ID,sql);			
			//Graduation
			sql="Select GRA_ID,GRA_NM from FILA10A";
			PublicFunction.InitCB(cb_GRA_ID,sql);			
			//Position
			sql="Select POS_ID,POS_NM from FILA07A";
			PublicFunction.InitCB(cb_POS_ID,sql);		
			//Nguyen Quan Native Place
			sql="Select NAT_ID,NAT_NM from FILA18A";
			PublicFunction.InitCB(cb_NAT_CO,sql);	
			//Nature Loai Nhan Vien
			sql="Select TYP_ID,TYP_NM from FILA11A";
			PublicFunction.InitCB(cb_TYP_ID,sql);		
			//Group
			sql="Select GRP_ID,GRP_NM from FILA08A";
			PublicFunction.InitCB(cb_GRP_ID,sql);	
			//Type Group
			sql="Select GRT_ID,GRT_NM from FILA09A";
			PublicFunction.InitCB(cb_GRT_ID,sql);	
			//Nationality
			sql="Select COU_ID,COU_NM from FILA12A";
			PublicFunction.InitCB(cb_COU_ID,sql);				
			//Level
			sql="Select LEV_ID,LEV_NM from FILA19A";
			PublicFunction.InitCB(cb_LEV_ID,sql);	
			Init_CBVS();
		}
		private void  Init_CBVS()
		{			
			string sql;			
			//Department
			sql=PublicFunction.GetDep(this.Tag+"");			
			vs.Cols["DEP_ID"].DataMap=PublicFunction.InitCBForVS(sql);			
			//City
			sql="Select CIT_ID,CIT_NM from FILA03A";		
			vs.Cols["CIT_ID"].DataMap=PublicFunction.InitCBForVS(sql);
			//education
			sql="Select EDU_ID,EDU_NM from FILA04A";		
			vs.Cols["EDU_ID"].DataMap=PublicFunction.InitCBForVS(sql);
			//Profession
			sql="Select PRO_ID,PRO_NM from FILA05A";		
			vs.Cols["PRO_ID"].DataMap=PublicFunction.InitCBForVS(sql);
			//Graduation
			sql="Select GRA_ID,GRA_NM from FILA10A";	
			vs.Cols["GRA_ID"].DataMap=PublicFunction.InitCBForVS(sql);			
			//Position
			sql="Select POS_ID,POS_NM from FILA07A";		
			vs.Cols["POS_ID"].DataMap=PublicFunction.InitCBForVS(sql);
			//Nguyen Quan Native Place
			sql="Select NAT_ID,NAT_NM from FILA18A";
			vs.Cols["NAT_CO"].DataMap=PublicFunction.InitCBForVS(sql);
			//Nature Loai Nhan Vien
			sql="Select TYP_ID,TYP_NM from FILA11A";
			vs.Cols["TYP_ID"].DataMap=PublicFunction.InitCBForVS(sql);
			//Group
			sql="Select GRP_ID,GRP_NM from FILA08A";	
			vs.Cols["GRP_ID"].DataMap=PublicFunction.InitCBForVS(sql);
			//Type Group
			sql="Select GRT_ID,GRT_NM from FILA09A";		
			vs.Cols["GRT_ID"].DataMap=PublicFunction.InitCBForVS(sql);
			//Nationality
			sql="Select COU_ID,COU_NM from FILA12A";			
			vs.Cols["COU_ID"].DataMap=PublicFunction.InitCBForVS(sql);		
			//Level
			sql="Select LEV_ID,LEV_NM from FILA19A";
			vs.Cols["LEV_ID"].DataMap=PublicFunction.InitCBForVS(sql);		
		}
		#endregion
		#region Init_menu		
		//		private void Init_Menu()
		//		{			
		//			mnu1=new ContextMenu();
		//			nav.cmd_report.Style=ToolBarButtonStyle.DropDownButton;
		//			nav.cmd_report.DropDownMenu =mnu1;
		//			int n=T_String.IsNullTo0(T_String.GetDataFromSQL("Count(*)","SYS_LABEL_PMENU","NAME=N'"+this.Name+"'"));
		//			Init_ReportSTD(n);					
		//			Init_LabelForMenu();	
		//		
		//		}
		//		
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
		//	
				#endregion	
		#region ShowData
		private void Show_VS()
		{
			if(Dep.vs1.Row<=0)
			{
				vs.Rows.Count=1;
				txt_DEP_N1.Text="";
				return;
			}
			nav.Show_VS("DEP_ID=N'"+Dep.Get_Data("DEP_ID")+"' and (DEL_BT is null or DEL_BT=0)");			
			ShowData();			
		}
		private void ShowData()
		{
			for(int i=1;i<vs.Rows.Count;i++)
			{
				if(vs.Rows[i]["VAC_BT"]+""=="True")
				{
					for(int c=1;c<vs.Cols.Count;c++)
						vs.SetCellStyle(i,c, vs.Styles["VAC_BT"]);
				}
			}
			p2.Visible=false;
			TextBoxAndVS.D_GetDataFromVS(groupBox1,vs);
			TextBoxAndVS.D_GetDataFromVS(g2,vs);
			Show_Image();			
			groupBox1.Enabled=vs.Rows.Count>1 && !ck_QEdit.Checked ;		
			txt_DEP_N1.Text=T_String.GetDataFromSQL("DEP_N1","FILA02A","DEP_ID=N'"+cb_DEP_ID.SelectedValue+"'");			
			if(vs.Row>0 && vs.Rows[vs.Row]["VAC_BT"]+""=="True")
			{
				p1.Visible=true;
				try
				{
					//					txt_VAC_NM.Text=T_String.GetDataFromSQL("VAC_NM","FILB01AC a, FILA06A b","a.VAC_ID=b.VAC_ID and EMP_ID=N'"+vs.Rows[vs.Row]["EMP_ID"]+"'");
					//					txt_VAC_DT.Text=DateTime.Parse(T_String.GetDataFromSQL("VAC_DT","FILB01AC a","EMP_ID=N'"+vs.Rows[vs.Row]["EMP_ID"]+"'")).ToString(format);
				}
				catch{}
			}
			else
			{
				p1.Visible=false;
				if(vs.Row>0)
				{
					string sql=T_String.GetDate().ToString("yyyy/MM/dd");
					sql="Select * from FILC09A where EMP_ID=N'"+vs.Rows[vs.Row]["EMP_ID"]+"' and "
						+"MAN_ST<='"+sql+"' and MAN_ED>='"+sql+"'";
					Func.RecordSet rs=new Func.RecordSet(sql,PublicFunction.C_con);
					if(rs.rows>0)
					{
						p2.Visible=true;
						txt_st.Text=DateTime.Parse(rs.record(0,"MAN_ST")+"").ToString(format);
						txt_ed.Text=DateTime.Parse(rs.record(0,"MAN_ED")+"").ToString(format);
					}
				}
			}			
			//			txt_EMP_I1.Enabled=cb_LEV_ID.Enabled=cb_GRT_ID.Enabled=cb_GRP_ID.Enabled=cb_DEP_ID.Enabled=
			//				cb_POS_ID.Enabled=(vs.Row>0 && vs.Rows[vs.Row].UserData+""=="2") ;
			//			if(vs.Row>0 && vs.Rows[vs.Row]["DEP_ID"]+""=="")
			//				cb_DEP_ID.Enabled=true;			
			//Show_VS1();			
		}
		private void Show_Image()
		{	
			lb1.Visible=lb2.Visible=false;
			if (vs.Row<1) 
			{				
				Set_Image(0);
				return;					
			}
			Set_Image(1);
			pic.Image=ImageFunction.LoadImageFromSQL("Select PIC_DR from FILB01AB where EMP_ID=N'"+
				vs.Rows[vs.Row]["EMP_ID"]+"'");
			ImageFile="";
			int i=T_String.IsNullTo0(T_String.GetDataFromSQL("COUNT(*)","FILB01ACA ","EMP_ID=N'"+vs.Rows[vs.Row]["EMP_ID"]+"'"));
			if(i>0)
			{
				lb1.Visible=lb2.Visible=true;
				lb2.Text=i+"";
			}
			else
				lb1.Visible=lb2.Visible=false;

		}
		private void Show_VS1()
		{
			//			if(vs.Row<1)
			//			{
			//				vs1.Rows.Count=1;				
			//			}
			//			else
			//			{
			//				nav1.Show_VS("EMP_ID=N'"+vs.Rows[vs.Row]["EMP_ID"]+"'");
			//			}
			//			TextBoxAndVS.D_GetDataFromVS(gp1,vs1);
			//			TextBoxAndVS.D_GetDataFromVS(gp,vs1);
		}
		#endregion
		#region Tbar
		private void nav_TBarClick(object sender, ToolBarButtonClickEventArgs e)
		{					
			
			if (e.Button.Equals(nav.cmd_add))
			{		
				if(ck_QEdit.Checked)
					return;
				if (vs.Rows.Count==1 || (int)vs.Rows[vs.Rows.Count-1].UserData!=2)					
					nav.ToolBar_Click(e);					
				TextBoxAndVS.D_AddNewOrEdit(groupBox1,false);
				TextBoxAndVS.D_AddNewOrEdit(g2,false);
//				cb_LEV_ID.Enabled=cb_GRP_ID.Enabled=cb_GRT_ID.Enabled=cb_DEP_ID.Enabled=cb_POS_ID.Enabled=(vs.Row>0 && vs.Rows[vs.Row].UserData+""=="2") ;
				dt_INH_D1.Value=T_String.GetDate();
//				if(Dep.vs1.Row>0)
//				{
//					cb_DEP_ID.SelectedValue=Dep.vs1.Rows[Dep.vs1.Row]["DEP_ID"];
//					txt_DEP_N1.Text=T_String.GetDataFromSQL("DEP_N1","FILA02A","DEP_ID=N'"+cb_DEP_ID.SelectedValue+"'");
//				}
				ck_ATT_BT.Checked=true;		
				txt_CRD_ID.Focus();
//				if(PublicFunction.WIDLEN>0)
//				{
//					txt_EMP_ID.ReadOnly=true;
//				}
				pic.Image=null;
//				txt_EMP_I1.Enabled=true;
				return;
			}	
			if (e.Button.Equals(nav.cmd_save))
			{
				if(vs.Row<=0)
					return;
				//				if((PublicFunction.WIDLEN<=0) && txt_EMP_ID.Text+""=="" )
				//				{
				//					MessageBox.Show(PublicFunction.L_Get_Msg(frmStaffInfo,0));
				//					return;
				//				}
				if(txt_CRD_ID.Text+""=="")
				{
					MessageBox.Show(PublicFunction.L_Get_Msg("frmTaStaffInfo",5));
					return;
				}
				//				if(txt_CRD_NO.Text!="" && T_String.IsNullTo0(T_String.GetDataFromSQL("Count(EMP_ID)","FILB01A","CRD_NO=N'"+txt_CRD_NO.Text+"' and EMP_ID<>N'"+vs.Rows[vs.Row]["EMP_ID"]+"'"))>0)
				//				{
				//					MessageBox.Show(PublicFunction.L_Get_Msg("POS",9));
				//					txt_CRD_NO.Focus();
				//					return;
				//				}	
				
				TextBoxAndVS.D_GetDataFromTextBox(groupBox1,vs);
				TextBoxAndVS.D_GetDataFromTextBox(g2,vs);
				if ((int)vs.Rows[vs.Row].UserData!=2)						
					vs.Rows[vs.Row].UserData=1;	
				else
				{
					vs.Rows[vs.Row]["BLT_NM"]=PublicFunction.A_UserID;
					vs.Rows[vs.Row]["BLT_DT"]=T_String.GetDate().ToString("yyyy/MM/dd HH:mm");
				}
				vs.Rows[vs.Row]["LST_NM"]=PublicFunction.A_UserID;
				vs.Rows[vs.Row]["LST_DT"]=T_String.GetDate().ToString("yyyy/MM/dd HH:mm");
				
				nav.ToolBar_Click(e);
				return ;
				
			}
			if (e.Button.Equals(nav.cmd_refresh))
			{		
				string WID="";
				if(vs.Row>0)
					WID=vs.Rows[vs.Row]["CRD_ID"]+"";
				if(nav.wh!="")
					nav.ToolBar_Click(e);
				else
					nav.Show_VS("(DEL_BT is null or DEL_BT=0)");
				ShowData();
				if(WID!="")
					for(int i=1;i<vs.Rows.Count;i++)
					{
						if(vs.Rows[i]["CRD_ID"]+""==WID)
						{
							vs.Row=i;
							break;
						}
					}
				return;
			}	
			if (e.Button.Equals(nav.cmd_search))
			{					
				ArrayList a=new ArrayList();
				ArrayList b=new ArrayList();
				b.Add("INH_D1");
				a.Add("CRD_ID");
				a.Add("EMP_NM");				
				frmSearch1 dlg=new frmSearch1(a,b,vs,nav);
				dlg.and="and (DEL_BT is null or DEL_BT=0)";
				if(dlg.ShowDialog()==DialogResult.OK)
				{
					ShowData();
				}
				return;
			}
			if (e.Button.Equals(nav.cmd_report))
			{
				ReportFromVS rpt=new ReportFromVS();
				rpt.RPT2(c1XLBook1,vs,this.Text,"HS");
				return;
			}
			
			nav.ToolBar_Click(e);				
		}

		private void SaveVS1()
		{
			//			if(vs.Row>0 && vs.Rows[vs.Row].UserData+""!="2" )
			//			{
			//				try
			//				{
			//					if(vs1.Rows.Count<=1)
			//					{					
			//						vs1.Rows.Count++;
			//						vs1.Row=vs1.Rows.Count-1;
			//						vs1.Rows[vs1.Row].UserData=2;	
			//						vs1.Rows[vs1.Row]["EMP_ID"]=vs.Rows[vs.Row]["EMP_ID"];				
			//					}
			//					else
			//					{				
			//						vs1.Row=1;
			//						vs1.Rows[vs1.Row].UserData=1;						
			//					}
			//					TextBoxAndVS.D_GetDataFromTextBox(gp1,vs1);
			//					TextBoxAndVS.D_GetDataFromTextBox(gp,vs1);
			//					nav1.SaveRow(vs1.Row);		
			//				}
			//				catch( Exception){}
			//			}
			
		}

		private Boolean CheckDepartment(string DEP_ID,string EMP_ID)
		{			
			int max=T_String.IsNullTo0(T_String.GetDataFromSQL("PEO_TT","FILA02A","DEP_ID=N'"+DEP_ID+"'"));
			if(max==0)
				return true;
			int dep=T_String.IsNullTo0(T_String.GetDataFromSQL("COUNT(EMP_ID)","FILB01A",
				"DEP_ID=N'"+DEP_ID+"' and (VAC_BT is null or VAC_BT=0) and EMP_ID not like N'"+EMP_ID+"'"));
			if(dep>=max)
			{
				MessageBox.Show(cb_DEP_ID.Text +" " +PublicFunction.L_Get_Msg("msg",30)+" ["+max+"]");
				return false;
			}
			return true;
		}
		#endregion		
		#region VS Event
		private void vs_EnabledChanged(object sender, EventArgs e)
		{
			TextBoxAndVS.L_GetLabelFromVS(groupBox1,vs);
			TextBoxAndVS.L_GetLabelFromVS(g2,vs);
			//			TextBoxAndVS.L_GetLabelFromVS(gp,vs1);
			//			TextBoxAndVS.L_GetLabelFromVS(gp1,vs1);
			S_EMP_I1.Text=label4.Text;
//			S_EMP_ID.Text=label3.Text;
			S_CRD_ID.Text=label6.Text;
			S_CRD_NO.Text=label23.Text;
			S_EMP_NM.Text=label2.Text;	
			ToolTip t1=new ToolTip();
			t1.SetToolTip(cmd_family,PublicFunction.L_GetLabel(this.Name,16));
			t1.SetToolTip(cmd_salary,PublicFunction.L_GetLabel(this.Name,17));			
			t1.SetToolTip(cmd_visa,PublicFunction.L_GetLabel(this.Name,18));			
			//Init_LabelForMenu();
		}
		private void vs_AfterRowColChange(object sender, RangeEventArgs e)
		{
			if(e.OldRange.r1!=e.NewRange.r1)
			{			
				ShowData();
			}
		}
		#endregion	
		#region Image
		string ImageFile;
		private void cmd_browser_Click(object sender, System.EventArgs e)
		{
			openFileDialog1.Filter =" Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF";
			DialogResult result = this.openFileDialog1.ShowDialog( this );
			try
			{			
				this.openFileDialog1.FilterIndex=1; 
				if( result == DialogResult.OK )					
				{
					System.IO.FileInfo a=new FileInfo(openFileDialog1.FileName);					
					if(a.Length<=100000)
					{
						pic.Image=ImageFunction.GetImageFromFile(openFileDialog1.FileName);
						ImageFile=this.openFileDialog1.FileName;
						Set_Image(2);
					}
					else
					{
						MessageBox.Show(PublicFunction.L_Get_Msg("msg",97));
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(this, ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			try 
			{				
				if (ImageFile=="" || ImageFile==null)
				{
					pic.Image.Save(PublicFunction.Path +"\\temp.jpg");					
					Process myProcess;
					myProcess = Process.Start(PublicFunction.Path +"\\temp.jpg");	
				}
				else
				{
					Process myProcess;
					myProcess = Process.Start(ImageFile);	
				}
			}
			catch(Exception){}
		}

		private void cmd_upload_Click(object sender, System.EventArgs e)
		{
			Thread th=new Thread(new System.Threading.ThreadStart(upload));
			th.Start();
			label39.Visible=true;			
		}
		
		private void upload()
		{					
			if (ImageFile+""=="")
			{
				MessageBox.Show(PublicFunction.L_Get_Msg("Staff",0));
				label39.Visible=false;
				return;
			}
			try
			{	
				if(T_String.IsNullTo0(T_String.GetDataFromSQL("COUNT(EMP_ID)","FILB01AB","EMP_ID=N'"+vs.Rows[vs.Row]["EMP_ID"]+"'"))<=0)
					PublicFunction.SQL_Execute("Insert Into FILB01AB(EMP_ID) values(N'"+vs.Rows[vs.Row]["EMP_ID"]+"')");
				ImageFunction.UploadImageToSQL(ImageFile,"PIC_DR","FILB01AB","EMP_ID=N'"+vs.Rows[vs.Row]["EMP_ID"]+"'");
				cmd_upload.Enabled=false;
				MessageBox.Show(PublicFunction.L_Get_Msg("Staff",1));
			}
			catch (Exception ex)
			{
				MessageBox.Show(this, ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				label39.Visible=false;
				Set_Image(1);
			}
			label39.Visible=false;
			ImageFile="";
			Set_Image(1);
		}
		private void menuItem1_Click(object sender, System.EventArgs e)
		{
			ImageFunction.UploadDelImage(ImageFile,"PIC_DR","FILB01AB","EMP_ID=N'"+vs.Rows[vs.Row]["EMP_ID"]+"'");
			ImageFile="";
			Set_Image(1);
			pic.Image=null;
		}

		private void Set_Image(int flag)
		{
			if (flag==0) 
			{
				cmd_upload.Enabled=cmd_browser.Enabled=false;
				pic.Image=null;
				return;
			}
			if (flag==1)
			{
				cmd_upload.Enabled=false;
				//				if ((vs.Rows[vs.Row].UserData+"")=="2")
				//					cmd_browser.Enabled=false;
				//				else
				cmd_browser.Enabled=true;
			}
			if (flag==2)
			{			
				cmd_upload.Enabled=cmd_browser.Enabled=true;
			}						
		}

		#endregion
		#region Event
		private void cmd_family_Click(object sender, System.EventArgs e)
		{
			frmTaFamily dlg=new frmTaFamily(txt_EMP_ID.Text,txt_ADD_DR.Text,txt_EMP_NM.Text);
			dlg.Tag=this.Tag;
			dlg.ShowDialog();
		}

		private void pictureBox1_Click(object sender, System.EventArgs e)
		{
			frmTaVisaPassport dlg=new frmTaVisaPassport(txt_EMP_ID.Text,txt_EMP_NM.Text);
			dlg.Tag=this.Tag;
			dlg.ShowDialog();
		}
		
		private void txt_LA1_TM_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Double result;
			if(e.KeyChar!=8)
				if( !Double.TryParse(e.KeyChar+"",System.Globalization.NumberStyles.Integer,System.Globalization.CultureInfo.CurrentCulture,out result))
					e.Handled=true;
		}

		private void txt_CRD_NO_Leave(object sender, System.EventArgs e)
		{
			if(txt_CRD_NO.Text+""!="" && txt_CRD_NO.MaxLength!=txt_CRD_NO.Text.Length)
			{
				MessageBox.Show(PublicFunction.L_Get_Msg("msg",66)+txt_CRD_NO.MaxLength +" !");
				//txt_CRD_NO.Focus();
			}
		}

		private void cmd_salary_Click(object sender, System.EventArgs e)
		{
			if(vs.Row>0)
			{
				GP8000.Payroll.frmTaSalaryInput dlg=new GP8000.Payroll.frmTaSalaryInput(false,vs.Rows[vs.Row]["EMP_ID"]+"");
				dlg.Tag=74;
				dlg.ShowDialog();
			}
		}
		private void Depvs1_AfterRowColChange(object sender, RangeEventArgs e)
		{
			if(e.OldRange.r1!=e.NewRange.r1)
			{
				Show_VS();
			}
		}
		private void frmTaStaffInfo_Closed(object sender, System.EventArgs e)
		{
			nav.Save_SEQ();
		}

		private void ck_QEdit_CheckedChanged(object sender, System.EventArgs e)
		{
			vs.AllowEditing=ck_QEdit.Checked;
			groupBox1.Enabled=vs.Rows.Count>1 && !ck_QEdit.Checked;
			
		}
		
		private void cb_DEP_ID_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			txt_DEP_N1.Text=T_String.GetDataFromSQL("DEP_N1","FILA02A","DEP_ID=N'"+cb_DEP_ID.SelectedValue+"'");
		}

		#endregion
		#region COM
		private void cmd_com_Click(object sender, System.EventArgs e)
		{
			Connect_Com();
		}
		private void Connect_Com()
		{
			
			try
			{
				Comport.RThreshold=1;
				Comport.CommPort=short.Parse(PublicFunction.C_port);
				Comport.Settings=PublicFunction.C_Setting;
				Comport.PortOpen=true;
				MessageBox.Show("connected to Sensor!!!");
			}
			catch(Exception)
			{
				MessageBox.Show("Can't connect to Sensor!!!");
			}
			
		}
		private void Comport_OnComm(object sender, System.EventArgs e)
		{
			if (Comport.InBufferCount==0)
				return;			
			string st=Comport.Input+"";		
			if(PublicFunction.C_WaitCOM=="1")
			{
				Thread.Sleep(100);								
				st+=Comport.Input+"";
				Thread.Sleep(100);				
				st+=Comport.Input+"";						
			}
			st=GetNUM(st);
			if(!txt_CRD_NO.ReadOnly)
				txt_CRD_NO.Text=st;			
		}

		private string GetNUM(string st)
		{
			string tam="";
			for (int i=0;i<st.Length;i++)
			{
				if ( isNumeric(st[i]+"",System.Globalization.NumberStyles.Integer))
					tam+=st[i];
			}
			return tam;
		}

		public bool isNumeric(string val, System.Globalization.NumberStyles NumberStyle)
		{
			Double result;
			return Double.TryParse(val,NumberStyle,System.Globalization.CultureInfo.CurrentCulture,out result);
		}
		#endregion
		#region Search
		private void S_EMP_ID_Enter(object sender, System.EventArgs e)
		{
			if (S_EMP_ID.Text==label3.Text)
				S_EMP_ID.Text="";
		}
		private void S_CRD_ID_Enter(object sender, System.EventArgs e)
		{
			if (S_CRD_ID.Text==label6.Text)
				S_CRD_ID.Text="";
		}
		
		private void S_EMP_ID_Leave(object sender, System.EventArgs e)
		{
			if (S_EMP_ID.Text=="")
				S_EMP_ID.Text=label3.Text;
		}	
		private void S_CRD_ID_Leave(object sender, System.EventArgs e)
		{
			if (S_CRD_ID.Text=="")
				S_CRD_ID.Text=label3.Text;
		}	
		private void S_EMP_I1_Enter(object sender, System.EventArgs e)
		{
			if (S_EMP_I1.Text==label4.Text)
				S_EMP_I1.Text="";
		}

		private void S_EMP_I1_Leave(object sender, System.EventArgs e)
		{
			if (S_EMP_I1.Text=="")
				S_EMP_I1.Text=label4.Text;
		}
		private void S_EMP_NM_Enter(object sender, System.EventArgs e)
		{
			if (S_EMP_NM.Text==label2.Text)
				S_EMP_NM.Text="";
		}

		private void S_EMP_NM_Leave(object sender, System.EventArgs e)
		{
			if (S_EMP_NM.Text=="")
				S_EMP_NM.Text=label2.Text;
		}
		private void S_CRD_NO_Enter(object sender, System.EventArgs e)
		{
			if (S_CRD_NO.Text==label23.Text)
				S_CRD_NO.Text="";					
		}

		private void S_CRD_NO_Leave(object sender, System.EventArgs e)
		{
			if (S_CRD_NO.Text=="")
				S_CRD_NO.Text=label23.Text;
		}
		private void S_EMP_ID_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Enter)
			{
				string sql;
				if(ck_search.Checked)
					sql="=N'"+((TextBox)sender).Text+"'";
				else
					sql=" like N'%"+((TextBox)sender).Text+"%'";
				sql= ((TextBox)sender).Tag+sql+" and (DEL_BT is null or DEL_BT=0) ";					
				nav.Show_VS(sql);				
				ShowData();				 	 
			}
		}
		private void S_CRD_ID_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Enter)
			{
				string sql;
				if(ck_search.Checked)
					sql="=N'"+((TextBox)sender).Text+"'";
				else
					sql=" like N'%"+((TextBox)sender).Text+"%'";
				sql= ((TextBox)sender).Tag+sql+" and (DEL_BT is null or DEL_BT=0) ";					
				nav.Show_VS(sql);				
				ShowData();				 	 
			}
		}
		#endregion	
		
		#region menu click
		//		private void menu_Click(object sender, EventArgs e)
		//		{
		//			//string sql="";			
		//			switch (mnu1.MenuItems.IndexOf((MenuItem)sender))
		//			{
		//				case 0:		
		//					GP8000.Personnel.FormRPT.frmTaPrintWID dlg=new GP8000.Personnel.FormRPT.frmTaPrintWID();
		//					dlg.Tag=this.Tag;
		//					if(vs.Row>0)
		//						dlg.stf=vs.Rows[vs.Row]["EMP_ID"]+"";
		//						
		//					if(dlg.ShowDialog(this)==DialogResult.OK)
		//					{
		//						//sql="Select  * from FILB01A a,FILA02A b,FILA07A c, FILB01AB d where a.DEP_ID=b.DEP_ID and a.POS_ID=c.POS_ID and a.EMP_ID=d.EMP_ID";
		//						rpt.WID(dlg.sql,PublicFunction.DT_server,PublicFunction.DT_database,PublicFunction.DT_username,PublicFunction.DT_password, T_String.IsNullTo0(PublicFunction.CUS_ID) );
		//					}
		//					break;
		//				case 1:		
		//					//					GP8000.Personnel.FormRPT.frmTaPrintWID dlg1=new GP8000.Personnel.FormRPT.frmTaPrintWID();
		//					//					if(vs.Row>0)
		//					//						dlg1.stf=vs.Rows[vs.Row]["EMP_ID"]+"";
		//					//					dlg1.Tag=this.Tag;
		//					//					dlg1.ck.Visible=false;
		//					//					dlg1.p1.Visible=false;
		//					//					if(dlg1.ShowDialog(this)==DialogResult.OK)
		//					//					{
		//					//						BDF(dlg1.sql);
		//					//						
		//					//					}
		//					break;
		//			}
		//		}
		#endregion

		private void cmd_quick_Click(object sender, System.EventArgs e)
		{
			frmTaQuickUploadImage dlg=new frmTaQuickUploadImage();
			dlg.ShowDialog();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			if(vs.Row>0)
			{
				frmTaATM dlg=new frmTaATM(vs.Rows[vs.Row]["EMP_ID"]+"",vs);		
				dlg.Tag=84;
				dlg.ShowDialog();
				txt_ACC_NO.Text=dlg.ACC_NO;
				vs.Rows[vs.Row]["ACC_NO"]=dlg.ACC_NO;
				txt_ACC_NM.Text=dlg.ACC_NM;
				vs.Rows[vs.Row]["ACC_NM"]=dlg.ACC_NM;
				textBox11.Text=dlg.BNK_NM;
				vs.Rows[vs.Row]["BNK_NM"]=dlg.ACC_NO;
			}
			
		}


		private void txt_CRD_ID_Leave(object sender, System.EventArgs e)
		{
			if(txt_CRD_ID.Text!="")
			{
				string sql="Select EMP_ID,EMP_I1,EMP_NM,CRD_ID from FILB01A where CRD_ID=N'"+txt_CRD_ID.Text+"' and "
					+" EMP_ID<>N'"+txt_EMP_ID.Text+"'";
				Func.RecordSet rs=new Func.RecordSet(sql,PublicFunction.C_con);
				if(rs.rows>0)
				{
					MessageBox.Show(txt_CRD_ID.Text +" "+ PublicFunction.L_Get_Msg("msg",11));
					frmSearch dlg=new frmSearch(rs,4,this.Name+"_vs");
					dlg.ShowDialog();

				}
			}
		}

		private void nav_Load(object sender, System.EventArgs e)
		{
		
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			if (vs.Row<1) 
				return;
			if(cb_DEP_ID.SelectedValue+""=="")
			{
				MessageBox.Show(PublicFunction.L_Get_Msg("frmTaStaffInfo",1));
				cb_DEP_ID.Focus();
				return;
			}				
			if(cb_POS_ID.SelectedValue+""=="")
			{
				MessageBox.Show(PublicFunction.L_Get_Msg("frmTaStaffInfo",2));
				cb_POS_ID.Focus();
				return;
			}
			if(cb_TYP_ID.SelectedValue+""=="")
			{
				MessageBox.Show(PublicFunction.L_Get_Msg("frmTaStaffInfo",4));
				cb_TYP_ID.Focus();
				return;
			}
			if(dt_INH_DT.Text+""=="")
			{
				MessageBox.Show(PublicFunction.L_Get_Msg("frmTaStaffInfo",3));
				dt_INH_DT.Focus();
				return;
			}
			if(txt_EMP_I1.Text!="")
			{
				if(T_String.IsNullTo0(T_String.GetDataFromSQL("Count(EMP_ID)","FILB01A","EMP_I1=N'"+txt_EMP_I1.Text+"' and EMP_ID<>N'"+vs.Rows[vs.Row]["EMP_ID"]+"'"))>0)
				{
					MessageBox.Show(PublicFunction.L_Get_Msg("POS",7));
					txt_EMP_I1.Focus();
					return;
				}					
			}
			if(txt_CRD_ID.Text!="" && T_String.IsNullTo0(T_String.GetDataFromSQL("Count(EMP_ID)","FILB01A","CRD_ID=N'"+txt_CRD_ID.Text+"' "))>0)
			{
				MessageBox.Show(PublicFunction.L_GetLabel_VS("frmTaStaffInfo_vs","CRD_ID")+ " " +PublicFunction.L_Get_Msg("nav",4));
				txt_CRD_ID.Focus();
				return;
			}	
			if(txt_EMP_ID.Text!="" && T_String.IsNullTo0(T_String.GetDataFromSQL("Count(EMP_ID)","FILB01A","EMP_ID=N'"+txt_EMP_ID.Text+"' "))>0)
			{
				MessageBox.Show(PublicFunction.L_GetLabel_VS("frmTaStaffInfo_vs","EMP_ID")+" " +PublicFunction.L_Get_Msg("nav",4));
				txt_EMP_ID.Focus();
				return;
			}	
			//			if(!CheckDepartment(cb_DEP_ID.SelectedValue+"" ,vs.Rows[vs.Row]["EMP_ID"]+""))
			//				return;
			//			try
			//			{
			if(!ck_QEdit.Checked)
			{
				if ((int)vs.Rows[vs.Rows.Count-1].UserData==2)	
				{
					if(PublicFunction.WIDLEN>0)
					{
						string sql="0000000000";
						sql=PublicFunction.S_Left(sql,PublicFunction.WIDLEN);
						int len;								
						len=T_String.GetMax( "MAX(RIGHT(EMP_ID,"+PublicFunction.WIDLEN+"))","FILB01A");
						txt_EMP_ID.Text=PublicFunction.WID+len.ToString(sql);
					}
				}
				TextBoxAndVS.D_GetDataFromTextBox(groupBox1,vs);
				TextBoxAndVS.D_GetDataFromTextBox(g2,vs);
				if ((int)vs.Rows[vs.Row].UserData!=2)						
					vs.Rows[vs.Row].UserData=1;	
				else
				{
					vs.Rows[vs.Row]["BLT_NM"]=PublicFunction.A_UserID;
					vs.Rows[vs.Row]["BLT_DT"]=T_String.GetDate().ToString("yyyy/MM/dd HH:mm");
				}
				vs.Rows[vs.Row]["LST_NM"]=PublicFunction.A_UserID;
				vs.Rows[vs.Row]["LST_DT"]=T_String.GetDate().ToString("yyyy/MM/dd HH:mm");
					
				nav.ToolBar_Click(new ToolBarButtonClickEventArgs(nav.cmd_save));
					

				string s= " INSERT INTO [dbo].[FILB01A]([EMP_ID], [EMP_I1], [EMP_NM], [EMP_N1], [MST_DR], [BIR_DT], [SEX_BT], [MAR_BT], [DEP_ID], [COU_ID], [CRD_NO], [POS_ID], [ADD_DR], [ADD_D1], [INH_DT], [CRD_ID], [CRD_DT], [CRD_LC], [CIT_ID], [RAC_NM], [NAT_CO], [EDU_ID], [PRO_ID], [GRA_ID], [TEL_NO], [TYP_ID], [ACC_NO], [ACC_NM], [BNK_NM], [REL_DR], [NEW_BT], [MEA_BT], [REM_DR], [ATT_BT], [VAC_BT], [DEL_BT], [GRT_ID], [GRP_ID], [LEV_ID], [LCK_BT], [BHX_BT], [DIR_BT], [BLT_NM], [BLT_DT], [LST_NM], [LST_DT])"
					+ " select [EMP_ID], [EMP_I1], [EMP_NM], [EMP_N1], [MST_DR], [BIR_DT], [SEX_BT], [MAR_BT], [DEP_ID], [COU_ID], [CRD_NO], [POS_ID], [ADD_DR], [ADD_D1], [INH_DT], [CRD_ID], [CRD_DT], [CRD_LC], [CIT_ID], [RAC_NM], [NAT_CO], [EDU_ID], [PRO_ID], [GRA_ID], [TEL_NO], [TYP_ID], [ACC_NO], [ACC_NM], [BNK_NM], [REL_DR], [NEW_BT], [MEA_BT], [REM_DR], [ATT_BT], [VAC_BT], [DEL_BT], [GRT_ID], [GRP_ID], [LEV_ID], [LCK_BT], [BHX_BT], [DIR_BT], [BLT_NM], [BLT_DT], [LST_NM], [LST_DT]"
					+ " from FILT01A where EMP_ID='"+ txt_EMP_ID.Text  +"'";

				PublicFunction.SQL_Execute(s,PublicFunction.C_con ); 
				s= " update FILT01A set DEL_BT=1 where EMP_ID='"+ txt_EMP_ID.Text  +"'";

				PublicFunction.SQL_Execute(s,PublicFunction.C_con ); 
			}
			else
			{
				//					nav.ToolBar_Click(e);
				TextBoxAndVS.D_GetDataFromVS(groupBox1,vs);
				TextBoxAndVS.D_GetDataFromVS(g2,vs);
				string s= " INSERT INTO [dbo].[FILB01A]([EMP_ID], [EMP_I1], [EMP_NM], [EMP_N1], [MST_DR], [BIR_DT], [SEX_BT], [MAR_BT], [DEP_ID], [COU_ID], [CRD_NO], [POS_ID], [ADD_DR], [ADD_D1], [INH_DT], [CRD_ID], [CRD_DT], [CRD_LC], [CIT_ID], [RAC_NM], [NAT_CO], [EDU_ID], [PRO_ID], [GRA_ID], [TEL_NO], [TYP_ID], [ACC_NO], [ACC_NM], [BNK_NM], [REL_DR], [NEW_BT], [MEA_BT], [REM_DR], [ATT_BT], [VAC_BT], [DEL_BT], [GRT_ID], [GRP_ID], [LEV_ID], [LCK_BT], [BHX_BT], [DIR_BT], [BLT_NM], [BLT_DT], [LST_NM], [LST_DT])" +
					" select [EMP_ID], [EMP_I1], [EMP_NM], [EMP_N1], [MST_DR], [BIR_DT], [SEX_BT], [MAR_BT], [DEP_ID], [COU_ID], [CRD_NO], [POS_ID], [ADD_DR], [ADD_D1], [INH_DT], [CRD_ID], [CRD_DT], [CRD_LC], [CIT_ID], [RAC_NM], [NAT_CO], [EDU_ID], [PRO_ID], [GRA_ID], [TEL_NO], [TYP_ID], [ACC_NO], [ACC_NM], [BNK_NM], [REL_DR], [NEW_BT], [MEA_BT], [REM_DR], [ATT_BT], [VAC_BT], [DEL_BT], [GRT_ID], [GRP_ID], [LEV_ID], [LCK_BT], [BHX_BT], [DIR_BT], [BLT_NM], [BLT_DT], [LST_NM], [LST_DT]";
				PublicFunction.SQL_Execute(s,PublicFunction.C_con );
				s+=" update FILT01A set DEL_BT=1 where EMP_ID='"+ txt_EMP_ID.Text  +"'";
				PublicFunction.SQL_Execute(s,PublicFunction.C_con ); 
			}
			//			}catch( Exception){}
			int i=-1 ;
			i=vs.Row ;
			//			nav_TBarClick(nav.cmd_refresh,new ToolBarButtonClickEventArgs(nav.cmd_refresh));
			vs.RemoveItem(i);
			ShowData();

			
			//			g2.Visible=false;
			//			nav.Enabled=true;
			
			//			vs.Row=i;
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			g2.Visible=true;
			txt_EMP_ID.Focus();
			button4.Enabled=true;
			dt_INH_DT.Value=T_String.GetDate();
			//			nav.Enabled=false;
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			g2.Visible=false;
			nav.Enabled=true;
			button4.Enabled=false;
		}

		private void label22_Click(object sender, System.EventArgs e)
		{
		
		}

		private void label21_Click(object sender, System.EventArgs e)
		{
		
		}

		private void label3_Click(object sender, System.EventArgs e)
		{
		
		}

		private void cb_DEP_ID_SelectedIndexChanged_1(object sender, System.EventArgs e)
		{
		
		}

		private void txt_EMP_ID_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void label23_Click(object sender, System.EventArgs e)
		{
		
		}

		private void groupBox1_Enter(object sender, System.EventArgs e)
		{
		
		}

		private void label28_Click(object sender, System.EventArgs e)
		{
		
		}

		private void label27_Click(object sender, System.EventArgs e)
		{
		
		}

		private void pictureBox1_Click_1(object sender, System.EventArgs e)
		{
		
		}
		
	


			
	}
}


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
using System.Net;
//using System.Web ;
//using System.Web.Mail;
using EASendMail;
namespace GP8000.Personnel
{
	/// <summary>
	/// Summary description for frmTaStaffInfo.
	/// </summary>
	public class frmTaStaffInfo : System.Windows.Forms.Form
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
		private System.Windows.Forms.TextBox S_CRD_NO;
		private System.Windows.Forms.TextBox S_EMP_I1;
		private System.Windows.Forms.TextBox S_EMP_ID;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txt_REM_DR;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.CheckBox ck_MEA_BT;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.CheckBox ck_NEW_BT;
		private System.Windows.Forms.ComboBox cb_POS_ID;
		private System.Windows.Forms.Button cmd_com;
		private System.Windows.Forms.ComboBox cb_GRT_ID;
		private System.Windows.Forms.ComboBox cb_GRP_ID;
		private System.Windows.Forms.ComboBox cb_TYP_ID;
		private System.Windows.Forms.ComboBox cb_COU_ID;
		private System.Windows.Forms.ComboBox cb_NAT_CO;
		private System.Windows.Forms.ComboBox cb_GRA_ID;
		private System.Windows.Forms.ComboBox cb_PRO_ID;
		private System.Windows.Forms.ComboBox cb_CIT_ID;
		private System.Windows.Forms.ComboBox cb_EDU_ID;
		private System.Windows.Forms.ComboBox cb_DEP_ID;
		private System.Windows.Forms.TextBox txt_RAC_NM;
		private System.Windows.Forms.TextBox txt_BHX_NO;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.TextBox txt_CRD_NO;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.TextBox txt_DEP_N1;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label39;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button cmd_upload;
		private System.Windows.Forms.Button cmd_browser;
		private System.Windows.Forms.PictureBox pic;
		private System.Windows.Forms.CheckBox ck_MAR_BT;
		private System.Windows.Forms.CheckBox ck_SEX_BT;
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
		private System.Windows.Forms.TextBox txt_EMP_I1;
		private System.Windows.Forms.TextBox txt_EMP_ID;
		private System.Windows.Forms.TextBox txt_EMP_NM;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Label lll;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label10;
		private AxMSCommLib.AxMSComm Comport;
		private C1.Win.C1Input.C1DateEdit dt_CRD_DT;
		private C1.Win.C1Input.C1DateEdit dt_INH_DT;
		private GP8000.UserControl.CrtTaDepartment Dep;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.CheckBox ck_ATT_BT;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.TextBox txt_VAC_NM;
		private System.Windows.Forms.TextBox txt_VAC_DT;
		private System.Windows.Forms.Panel p1;
		private System.Windows.Forms.ContextMenu mnu;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.Label label37;
		private System.Windows.Forms.CheckBox ck_LCK_BT;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.PictureBox cmd_family;
		private C1.Win.C1Command.C1DockingTab c1DockingTab3;
		private C1.Win.C1Command.C1DockingTabPage Tab_HDLD;
		private C1.Win.C1Command.C1DockingTabPage Tab_BHXH;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.GroupBox gp;
		private System.Windows.Forms.GroupBox gp1;
		private Navigator1._0.NavigatorAuto nav1;
		private C1.Win.C1FlexGrid.C1FlexGrid vs1;
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
		private System.Windows.Forms.Label label49;
		private System.Windows.Forms.CheckBox ck_BHX_BT;
		private System.Windows.Forms.Label label54;
		private System.Windows.Forms.CheckBox ck_DIR_BT;
		private System.Windows.Forms.PictureBox cmd_salary;
		private System.Windows.Forms.PictureBox cmd_visa;
		private C1.Win.C1Input.C1DateEdit dt_BIR_DT;
		private System.Windows.Forms.Label label56;
		private System.Windows.Forms.ComboBox cb_LEV_ID;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label57;
		private C1.Win.C1Input.C1TextBox txt_BIR_DT;		
		private ContextMenu mnu1;		
		private System.Windows.Forms.Button cmd_quick;
		private System.Windows.Forms.Label lb1;
		private System.Windows.Forms.Label lb2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label58;
		private System.Windows.Forms.Panel p2;
		private System.Windows.Forms.TextBox txt_st;
		private System.Windows.Forms.TextBox txt_ed;
		private C1.C1Pdf.C1PdfDocument _c1pdf;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label59;
		private System.Windows.Forms.Label label60;
		private C1.Win.C1Input.C1DateEdit dt_SEN_DT;
		private C1.Win.C1Command.C1DockingTabPage Tab_REM;
		private System.Windows.Forms.GroupBox g2;
		private System.Windows.Forms.TextBox txt_REM_D2;
		private AxGPRPT.AxReport rpt;
		private System.Windows.Forms.Button btem;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Panel panel10;
		private System.Windows.Forms.Panel panel11;
		private Navigator1._0.NavigatorAuto nav2;
		private C1.Win.C1Command.C1DockingTabPage tabVanBang;
		private C1.Win.C1FlexGrid.C1FlexGrid vs2;
		private System.Windows.Forms.CheckBox ckVAC;
		private System.Windows.Forms.Button btn_UpdateGGM;
		private System.Windows.Forms.CheckBox chk_congdoan;
		private System.Windows.Forms.Label congdoan;
		private System.ComponentModel.IContainer components;
		public Boolean edit=false;//save

		public frmTaStaffInfo()
		{			
			InitializeComponent();				
			this.c1CommandDock2.Size = new System.Drawing.Size(600, 490);			
			this.c1DockingTab2.Size = new System.Drawing.Size(600, 490);			
			this.c1DockingTabPage2.Size = new System.Drawing.Size(595, 488);					
			this.c1CommandDock1.Size = new System.Drawing.Size(256, 526);			
			this.c1DockingTab1.Size = new System.Drawing.Size(254, 524);						
			this.c1DockingTabPage1.Size = new System.Drawing.Size(251, 523);
			this.c1DockingTab1.AutoHiding=true;
			this.c1DockingTab2.AutoHiding=true;
			this.c1DockingTab3.Location = new System.Drawing.Point(544, 280);
			this.txt_REM_DR.Location = new System.Drawing.Point(108, 532);
			this.c1DockingTab3.SelectedIndex=0;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmTaStaffInfo));
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.congdoan = new System.Windows.Forms.Label();
			this.chk_congdoan = new System.Windows.Forms.CheckBox();
			this.button3 = new System.Windows.Forms.Button();
			this.btem = new System.Windows.Forms.Button();
			this.rpt = new AxGPRPT.AxReport();
			this.dt_SEN_DT = new C1.Win.C1Input.C1DateEdit();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.p2 = new System.Windows.Forms.Panel();
			this.txt_st = new System.Windows.Forms.TextBox();
			this.txt_ed = new System.Windows.Forms.TextBox();
			this.label58 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.cmd_quick = new System.Windows.Forms.Button();
			this.txt_BIR_DT = new C1.Win.C1Input.C1TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.cb_LEV_ID = new System.Windows.Forms.ComboBox();
			this.dt_BIR_DT = new C1.Win.C1Input.C1DateEdit();
			this.nav1 = new Navigator1._0.NavigatorAuto();
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
			this.vs1 = new C1.Win.C1FlexGrid.C1FlexGrid();
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
			this.Tab_REM = new C1.Win.C1Command.C1DockingTabPage();
			this.g2 = new System.Windows.Forms.GroupBox();
			this.txt_REM_D2 = new System.Windows.Forms.TextBox();
			this.tabVanBang = new C1.Win.C1Command.C1DockingTabPage();
			this.panel11 = new System.Windows.Forms.Panel();
			this.vs2 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.panel10 = new System.Windows.Forms.Panel();
			this.nav2 = new Navigator1._0.NavigatorAuto();
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
			this.dt_INH_DT = new C1.Win.C1Input.C1DateEdit();
			this.txt_REM_DR = new System.Windows.Forms.TextBox();
			this.cb_POS_ID = new System.Windows.Forms.ComboBox();
			this.cmd_com = new System.Windows.Forms.Button();
			this.cb_GRT_ID = new System.Windows.Forms.ComboBox();
			this.cb_GRP_ID = new System.Windows.Forms.ComboBox();
			this.cb_TYP_ID = new System.Windows.Forms.ComboBox();
			this.cb_COU_ID = new System.Windows.Forms.ComboBox();
			this.cb_NAT_CO = new System.Windows.Forms.ComboBox();
			this.cb_GRA_ID = new System.Windows.Forms.ComboBox();
			this.cb_PRO_ID = new System.Windows.Forms.ComboBox();
			this.cb_CIT_ID = new System.Windows.Forms.ComboBox();
			this.cb_EDU_ID = new System.Windows.Forms.ComboBox();
			this.cb_DEP_ID = new System.Windows.Forms.ComboBox();
			this.txt_RAC_NM = new System.Windows.Forms.TextBox();
			this.label29 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.txt_CRD_NO = new System.Windows.Forms.TextBox();
			this.label23 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.txt_DEP_N1 = new System.Windows.Forms.TextBox();
			this.label21 = new System.Windows.Forms.Label();
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
			this.txt_EMP_I1 = new System.Windows.Forms.TextBox();
			this.txt_EMP_ID = new System.Windows.Forms.TextBox();
			this.txt_EMP_NM = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label31 = new System.Windows.Forms.Label();
			this.lll = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label57 = new System.Windows.Forms.Label();
			this.label34 = new System.Windows.Forms.Label();
			this.label56 = new System.Windows.Forms.Label();
			this.lb2 = new System.Windows.Forms.Label();
			this.lb1 = new System.Windows.Forms.Label();
			this.label54 = new System.Windows.Forms.Label();
			this.ck_DIR_BT = new System.Windows.Forms.CheckBox();
			this.label49 = new System.Windows.Forms.Label();
			this.ck_BHX_BT = new System.Windows.Forms.CheckBox();
			this.label37 = new System.Windows.Forms.Label();
			this.ck_LCK_BT = new System.Windows.Forms.CheckBox();
			this.label35 = new System.Windows.Forms.Label();
			this.ck_ATT_BT = new System.Windows.Forms.CheckBox();
			this.label33 = new System.Windows.Forms.Label();
			this.ck_MEA_BT = new System.Windows.Forms.CheckBox();
			this.label32 = new System.Windows.Forms.Label();
			this.ck_NEW_BT = new System.Windows.Forms.CheckBox();
			this.label20 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.ck_MAR_BT = new System.Windows.Forms.CheckBox();
			this.ck_SEX_BT = new System.Windows.Forms.CheckBox();
			this.label59 = new System.Windows.Forms.Label();
			this.label60 = new System.Windows.Forms.Label();
			this.panel6 = new System.Windows.Forms.Panel();
			this.ckVAC = new System.Windows.Forms.CheckBox();
			this.ck_QEdit = new System.Windows.Forms.CheckBox();
			this.ck_search = new System.Windows.Forms.CheckBox();
			this.S_EMP_NM = new System.Windows.Forms.TextBox();
			this.S_CRD_NO = new System.Windows.Forms.TextBox();
			this.S_EMP_I1 = new System.Windows.Forms.TextBox();
			this.S_EMP_ID = new System.Windows.Forms.TextBox();
			this.c1CommandDock2 = new C1.Win.C1Command.C1CommandDock();
			this.c1DockingTab2 = new C1.Win.C1Command.C1DockingTab();
			this.c1DockingTabPage2 = new C1.Win.C1Command.C1DockingTabPage();
			this.vs = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.panel3 = new System.Windows.Forms.Panel();
			this.btn_UpdateGGM = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.nav = new Navigator1._0.NavigatorAuto();
			this.c1CommandDock1 = new C1.Win.C1Command.C1CommandDock();
			this.c1DockingTab1 = new C1.Win.C1Command.C1DockingTab();
			this.c1DockingTabPage1 = new C1.Win.C1Command.C1DockingTabPage();
			this.Dep = new GP8000.UserControl.CrtTaDepartment();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.panel1.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.rpt)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dt_SEN_DT)).BeginInit();
			this.p2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txt_BIR_DT)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dt_BIR_DT)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1DockingTab3)).BeginInit();
			this.c1DockingTab3.SuspendLayout();
			this.Tab_HDLD.SuspendLayout();
			this.panel8.SuspendLayout();
			this.gp.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dt_LA1_ED)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dt_LA1_ST)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dt_LAB_ED)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dt_LAB_ST)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vs1)).BeginInit();
			this.Tab_BHXH.SuspendLayout();
			this.panel9.SuspendLayout();
			this.gp1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dt_BHL_ED)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dt_BHL_ST)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dt_BHY_ED)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dt_BHY_ST)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dt_BHX_ED)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dt_BHX_ST)).BeginInit();
			this.Tab_REM.SuspendLayout();
			this.g2.SuspendLayout();
			this.tabVanBang.SuspendLayout();
			this.panel11.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs2)).BeginInit();
			this.panel10.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dt_CRD_DT)).BeginInit();
			this.panel7.SuspendLayout();
			this.p1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dt_INH_DT)).BeginInit();
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
			this.panel1.Size = new System.Drawing.Size(1020, 731);
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
			this.panel5.Size = new System.Drawing.Size(1004, 695);
			this.panel5.TabIndex = 4;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.groupBox1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 32);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(925, 663);
			this.panel2.TabIndex = 5;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.congdoan);
			this.groupBox1.Controls.Add(this.chk_congdoan);
			this.groupBox1.Controls.Add(this.button3);
			this.groupBox1.Controls.Add(this.btem);
			this.groupBox1.Controls.Add(this.rpt);
			this.groupBox1.Controls.Add(this.dt_SEN_DT);
			this.groupBox1.Controls.Add(this.textBox3);
			this.groupBox1.Controls.Add(this.p2);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.cmd_quick);
			this.groupBox1.Controls.Add(this.txt_BIR_DT);
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.cb_LEV_ID);
			this.groupBox1.Controls.Add(this.dt_BIR_DT);
			this.groupBox1.Controls.Add(this.nav1);
			this.groupBox1.Controls.Add(this.c1DockingTab3);
			this.groupBox1.Controls.Add(this.dt_CRD_DT);
			this.groupBox1.Controls.Add(this.panel7);
			this.groupBox1.Controls.Add(this.p1);
			this.groupBox1.Controls.Add(this.dt_INH_DT);
			this.groupBox1.Controls.Add(this.txt_REM_DR);
			this.groupBox1.Controls.Add(this.cb_POS_ID);
			this.groupBox1.Controls.Add(this.cmd_com);
			this.groupBox1.Controls.Add(this.cb_GRT_ID);
			this.groupBox1.Controls.Add(this.cb_GRP_ID);
			this.groupBox1.Controls.Add(this.cb_TYP_ID);
			this.groupBox1.Controls.Add(this.cb_COU_ID);
			this.groupBox1.Controls.Add(this.cb_NAT_CO);
			this.groupBox1.Controls.Add(this.cb_GRA_ID);
			this.groupBox1.Controls.Add(this.cb_PRO_ID);
			this.groupBox1.Controls.Add(this.cb_CIT_ID);
			this.groupBox1.Controls.Add(this.cb_EDU_ID);
			this.groupBox1.Controls.Add(this.cb_DEP_ID);
			this.groupBox1.Controls.Add(this.txt_RAC_NM);
			this.groupBox1.Controls.Add(this.label29);
			this.groupBox1.Controls.Add(this.label28);
			this.groupBox1.Controls.Add(this.label27);
			this.groupBox1.Controls.Add(this.label24);
			this.groupBox1.Controls.Add(this.txt_CRD_NO);
			this.groupBox1.Controls.Add(this.label23);
			this.groupBox1.Controls.Add(this.label22);
			this.groupBox1.Controls.Add(this.txt_DEP_N1);
			this.groupBox1.Controls.Add(this.label21);
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
			this.groupBox1.Controls.Add(this.txt_EMP_I1);
			this.groupBox1.Controls.Add(this.txt_EMP_ID);
			this.groupBox1.Controls.Add(this.txt_EMP_NM);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label16);
			this.groupBox1.Controls.Add(this.label18);
			this.groupBox1.Controls.Add(this.label17);
			this.groupBox1.Controls.Add(this.label15);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.label31);
			this.groupBox1.Controls.Add(this.lll);
			this.groupBox1.Controls.Add(this.label26);
			this.groupBox1.Controls.Add(this.label25);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label57);
			this.groupBox1.Controls.Add(this.label34);
			this.groupBox1.Controls.Add(this.label56);
			this.groupBox1.Controls.Add(this.lb2);
			this.groupBox1.Controls.Add(this.lb1);
			this.groupBox1.Controls.Add(this.label54);
			this.groupBox1.Controls.Add(this.ck_DIR_BT);
			this.groupBox1.Controls.Add(this.label49);
			this.groupBox1.Controls.Add(this.ck_BHX_BT);
			this.groupBox1.Controls.Add(this.label37);
			this.groupBox1.Controls.Add(this.ck_LCK_BT);
			this.groupBox1.Controls.Add(this.label35);
			this.groupBox1.Controls.Add(this.ck_ATT_BT);
			this.groupBox1.Controls.Add(this.label33);
			this.groupBox1.Controls.Add(this.ck_MEA_BT);
			this.groupBox1.Controls.Add(this.label32);
			this.groupBox1.Controls.Add(this.ck_NEW_BT);
			this.groupBox1.Controls.Add(this.label20);
			this.groupBox1.Controls.Add(this.label19);
			this.groupBox1.Controls.Add(this.ck_MAR_BT);
			this.groupBox1.Controls.Add(this.ck_SEX_BT);
			this.groupBox1.Controls.Add(this.label59);
			this.groupBox1.Controls.Add(this.label60);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(4, -4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(917, 665);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Tag = "N";
			// 
			// congdoan
			// 
			this.congdoan.Location = new System.Drawing.Point(572, 180);
			this.congdoan.Name = "congdoan";
			this.congdoan.TabIndex = 157;
			this.congdoan.Tag = "congdoan";
			this.congdoan.Text = "congdoan";
			// 
			// chk_congdoan
			// 
			this.chk_congdoan.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.chk_congdoan.Location = new System.Drawing.Point(548, 176);
			this.chk_congdoan.Name = "chk_congdoan";
			this.chk_congdoan.Size = new System.Drawing.Size(16, 24);
			this.chk_congdoan.TabIndex = 156;
			this.chk_congdoan.Tag = "congdoan";
			this.chk_congdoan.Text = "MEA_BT";
			// 
			// button3
			// 
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button3.Location = new System.Drawing.Point(240, 296);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(28, 24);
			this.button3.TabIndex = 155;
			this.button3.Tag = "N";
			this.button3.Text = "...";
			this.button3.Visible = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// btem
			// 
			this.btem.Location = new System.Drawing.Point(884, 268);
			this.btem.Name = "btem";
			this.btem.Size = new System.Drawing.Size(24, 16);
			this.btem.TabIndex = 154;
			this.btem.Text = "button3";
			this.btem.Visible = false;
			this.btem.Click += new System.EventHandler(this.btem_Click);
			// 
			// rpt
			// 
			this.rpt.ContainingControl = this;
			this.rpt.Enabled = true;
			this.rpt.Location = new System.Drawing.Point(644, 156);
			this.rpt.Name = "rpt";
			this.rpt.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("rpt.OcxState")));
			this.rpt.Size = new System.Drawing.Size(99, 45);
			this.rpt.TabIndex = 153;
			this.rpt.Visible = false;
			// 
			// dt_SEN_DT
			// 
			this.dt_SEN_DT.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt_SEN_DT.Location = new System.Drawing.Point(372, 504);
			this.dt_SEN_DT.Name = "dt_SEN_DT";
			this.dt_SEN_DT.Size = new System.Drawing.Size(160, 23);
			this.dt_SEN_DT.TabIndex = 152;
			this.dt_SEN_DT.Tag = "SEN_DT";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(372, 184);
			this.textBox3.MaxLength = 20;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(160, 23);
			this.textBox3.TabIndex = 148;
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
			this.p2.Location = new System.Drawing.Point(544, 208);
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
			this.button2.Location = new System.Drawing.Point(676, 52);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(76, 32);
			this.button2.TabIndex = 73;
			this.button2.Text = "Preview";
			this.button2.Visible = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(504, 324);
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
			this.cmd_quick.Location = new System.Drawing.Point(828, 40);
			this.cmd_quick.Name = "cmd_quick";
			this.cmd_quick.Size = new System.Drawing.Size(76, 40);
			this.cmd_quick.TabIndex = 144;
			this.cmd_quick.Text = "Quick Upload";
			this.cmd_quick.Click += new System.EventHandler(this.cmd_quick_Click);
			// 
			// txt_BIR_DT
			// 
			this.txt_BIR_DT.Location = new System.Drawing.Point(108, 68);
			this.txt_BIR_DT.MaxLength = 10;
			this.txt_BIR_DT.Name = "txt_BIR_DT";
			this.txt_BIR_DT.Size = new System.Drawing.Size(160, 23);
			this.txt_BIR_DT.TabIndex = 4;
			this.txt_BIR_DT.Tag = "BIR_DT";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(108, 240);
			this.textBox2.MaxLength = 50;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(160, 23);
			this.textBox2.TabIndex = 14;
			this.textBox2.Tag = "REL_DR";
			this.textBox2.Text = "textBox7";
			// 
			// cb_LEV_ID
			// 
			this.cb_LEV_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_LEV_ID.Location = new System.Drawing.Point(108, 504);
			this.cb_LEV_ID.Name = "cb_LEV_ID";
			this.cb_LEV_ID.Size = new System.Drawing.Size(160, 24);
			this.cb_LEV_ID.TabIndex = 27;
			this.cb_LEV_ID.Tag = "LEV_ID";
			// 
			// dt_BIR_DT
			// 
			this.dt_BIR_DT.EmptyAsNull = true;
			this.dt_BIR_DT.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt_BIR_DT.Location = new System.Drawing.Point(108, 72);
			this.dt_BIR_DT.Name = "dt_BIR_DT";
			this.dt_BIR_DT.Size = new System.Drawing.Size(160, 23);
			this.dt_BIR_DT.TabIndex = 4;
			this.dt_BIR_DT.Tag = null;
			this.dt_BIR_DT.Visible = false;
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
			this.nav1.Location = new System.Drawing.Point(12, 572);
			this.nav1.MSG_Exit = false;
			this.nav1.MulltiDel = false;
			this.nav1.Name = "nav1";
			this.nav1.Security = 0;
			this.nav1.ShowPopupMenu = false;
			this.nav1.Size = new System.Drawing.Size(44, 32);
			this.nav1.TabIndex = 133;
			this.nav1.ToolBar_Auto = true;
			this.nav1.UserID = null;
			this.nav1.Visible = false;
			this.nav1.VisibleGrid = false;
			this.nav1.Where = null;
			// 
			// c1DockingTab3
			// 
			this.c1DockingTab3.Controls.Add(this.Tab_HDLD);
			this.c1DockingTab3.Controls.Add(this.Tab_BHXH);
			this.c1DockingTab3.Controls.Add(this.Tab_REM);
			this.c1DockingTab3.Controls.Add(this.tabVanBang);
			this.c1DockingTab3.Location = new System.Drawing.Point(544, 340);
			this.c1DockingTab3.Name = "c1DockingTab3";
			this.c1DockingTab3.SelectedIndex = 3;
			this.c1DockingTab3.Size = new System.Drawing.Size(408, 308);
			this.c1DockingTab3.TabIndex = 37;
			this.c1DockingTab3.TabStyle = C1.Win.C1Command.TabStyleEnum.WindowsXP;
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
			this.gp.Controls.Add(this.vs1);
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
			// vs1
			// 
			this.vs1.ColumnInfo = "10,1,0,0,0,100,Columns:";
			this.vs1.Location = new System.Drawing.Point(12, 252);
			this.vs1.Name = "vs1";
			this.vs1.Size = new System.Drawing.Size(380, 60);
			this.vs1.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Tahoma, 9.75pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.vs1.TabIndex = 102;
			this.vs1.Visible = false;
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
			// Tab_REM
			// 
			this.Tab_REM.CaptionText = "REM2";
			this.Tab_REM.Controls.Add(this.g2);
			this.Tab_REM.ImageIndex = -1;
			this.Tab_REM.Location = new System.Drawing.Point(2, 28);
			this.Tab_REM.Name = "Tab_REM";
			this.Tab_REM.Size = new System.Drawing.Size(402, 276);
			this.Tab_REM.TabIndex = 2;
			this.Tab_REM.Text = "Page3";
			this.Tab_REM.Visible = false;
			// 
			// g2
			// 
			this.g2.Controls.Add(this.txt_REM_D2);
			this.g2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.g2.Location = new System.Drawing.Point(4, 0);
			this.g2.Name = "g2";
			this.g2.Size = new System.Drawing.Size(396, 272);
			this.g2.TabIndex = 0;
			this.g2.TabStop = false;
			this.g2.Tag = "N";
			// 
			// txt_REM_D2
			// 
			this.txt_REM_D2.Location = new System.Drawing.Point(4, 12);
			this.txt_REM_D2.MaxLength = 500;
			this.txt_REM_D2.Multiline = true;
			this.txt_REM_D2.Name = "txt_REM_D2";
			this.txt_REM_D2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txt_REM_D2.Size = new System.Drawing.Size(388, 256);
			this.txt_REM_D2.TabIndex = 30;
			this.txt_REM_D2.Tag = "REM_D2";
			this.txt_REM_D2.Text = "REM_D2";
			// 
			// tabVanBang
			// 
			this.tabVanBang.Controls.Add(this.panel11);
			this.tabVanBang.Controls.Add(this.panel10);
			this.tabVanBang.ImageIndex = -1;
			this.tabVanBang.Location = new System.Drawing.Point(2, 28);
			this.tabVanBang.Name = "tabVanBang";
			this.tabVanBang.Size = new System.Drawing.Size(402, 276);
			this.tabVanBang.TabIndex = 3;
			this.tabVanBang.Text = "Certificate";
			this.tabVanBang.Visible = false;
			// 
			// panel11
			// 
			this.panel11.Controls.Add(this.vs2);
			this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel11.Location = new System.Drawing.Point(0, 36);
			this.panel11.Name = "panel11";
			this.panel11.Size = new System.Drawing.Size(402, 240);
			this.panel11.TabIndex = 1;
			// 
			// vs2
			// 
			this.vs2.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs2.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vs2.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs2.Location = new System.Drawing.Point(0, 0);
			this.vs2.Name = "vs2";
			this.vs2.Size = new System.Drawing.Size(402, 240);
			this.vs2.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Tahoma, 9.75pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.vs2.TabIndex = 9;
			// 
			// panel10
			// 
			this.panel10.Controls.Add(this.nav2);
			this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel10.Location = new System.Drawing.Point(0, 0);
			this.panel10.Name = "panel10";
			this.panel10.Size = new System.Drawing.Size(402, 36);
			this.panel10.TabIndex = 0;
			// 
			// nav2
			// 
			this.nav2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.nav2.Connection = null;
			this.nav2.ConnectionDel = null;
			this.nav2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.nav2.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.nav2.form = null;
			this.nav2.FormName = null;
			this.nav2.Grid = null;
			this.nav2.History = false;
			this.nav2.IsNull = true;
			this.nav2.Language = "EN";
			this.nav2.Location = new System.Drawing.Point(0, 0);
			this.nav2.MSG_Exit = false;
			this.nav2.MulltiDel = false;
			this.nav2.Name = "nav2";
			this.nav2.Security = 0;
			this.nav2.ShowPopupMenu = true;
			this.nav2.Size = new System.Drawing.Size(402, 36);
			this.nav2.TabIndex = 10;
			this.nav2.ToolBar_Auto = true;
			this.nav2.UserID = null;
			this.nav2.VisibleGrid = true;
			this.nav2.Where = null;
			// 
			// dt_CRD_DT
			// 
			this.dt_CRD_DT.EmptyAsNull = true;
			this.dt_CRD_DT.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt_CRD_DT.Location = new System.Drawing.Point(372, 156);
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
			this.panel7.Location = new System.Drawing.Point(696, 236);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(184, 56);
			this.panel7.TabIndex = 39;
			// 
			// cmd_salary
			// 
			this.cmd_salary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmd_salary.ContextMenu = this.mnu;
			this.cmd_salary.Image = ((System.Drawing.Image)(resources.GetObject("cmd_salary.Image")));
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
			this.cmd_visa.Image = ((System.Drawing.Image)(resources.GetObject("cmd_visa.Image")));
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
			this.cmd_family.Image = ((System.Drawing.Image)(resources.GetObject("cmd_family.Image")));
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
			this.p1.Location = new System.Drawing.Point(544, 208);
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
			// dt_INH_DT
			// 
			this.dt_INH_DT.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt_INH_DT.Location = new System.Drawing.Point(372, 448);
			this.dt_INH_DT.Name = "dt_INH_DT";
			this.dt_INH_DT.Size = new System.Drawing.Size(160, 23);
			this.dt_INH_DT.TabIndex = 24;
			this.dt_INH_DT.Tag = "INH_DT";
			// 
			// txt_REM_DR
			// 
			this.txt_REM_DR.Location = new System.Drawing.Point(108, 532);
			this.txt_REM_DR.MaxLength = 500;
			this.txt_REM_DR.Multiline = true;
			this.txt_REM_DR.Name = "txt_REM_DR";
			this.txt_REM_DR.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txt_REM_DR.Size = new System.Drawing.Size(424, 56);
			this.txt_REM_DR.TabIndex = 28;
			this.txt_REM_DR.Tag = "REM_DR";
			this.txt_REM_DR.Text = "BNK_NM";
			// 
			// cb_POS_ID
			// 
			this.cb_POS_ID.BackColor = System.Drawing.Color.LemonChiffon;
			this.cb_POS_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_POS_ID.Location = new System.Drawing.Point(108, 420);
			this.cb_POS_ID.Name = "cb_POS_ID";
			this.cb_POS_ID.Size = new System.Drawing.Size(160, 24);
			this.cb_POS_ID.TabIndex = 21;
			this.cb_POS_ID.Tag = "POS_ID";
			// 
			// cmd_com
			// 
			this.cmd_com.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_com.Location = new System.Drawing.Point(504, 420);
			this.cmd_com.Name = "cmd_com";
			this.cmd_com.Size = new System.Drawing.Size(28, 24);
			this.cmd_com.TabIndex = 117;
			this.cmd_com.Tag = "N";
			this.cmd_com.Text = "...";
			this.cmd_com.Click += new System.EventHandler(this.cmd_com_Click);
			// 
			// cb_GRT_ID
			// 
			this.cb_GRT_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_GRT_ID.Location = new System.Drawing.Point(372, 476);
			this.cb_GRT_ID.Name = "cb_GRT_ID";
			this.cb_GRT_ID.Size = new System.Drawing.Size(160, 24);
			this.cb_GRT_ID.TabIndex = 26;
			this.cb_GRT_ID.Tag = "GRT_ID";
			// 
			// cb_GRP_ID
			// 
			this.cb_GRP_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_GRP_ID.Location = new System.Drawing.Point(108, 476);
			this.cb_GRP_ID.Name = "cb_GRP_ID";
			this.cb_GRP_ID.Size = new System.Drawing.Size(160, 24);
			this.cb_GRP_ID.TabIndex = 25;
			this.cb_GRP_ID.Tag = "GRP_ID";
			// 
			// cb_TYP_ID
			// 
			this.cb_TYP_ID.BackColor = System.Drawing.Color.LemonChiffon;
			this.cb_TYP_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_TYP_ID.Location = new System.Drawing.Point(108, 448);
			this.cb_TYP_ID.Name = "cb_TYP_ID";
			this.cb_TYP_ID.Size = new System.Drawing.Size(160, 24);
			this.cb_TYP_ID.TabIndex = 23;
			this.cb_TYP_ID.Tag = "TYP_ID";
			// 
			// cb_COU_ID
			// 
			this.cb_COU_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_COU_ID.Location = new System.Drawing.Point(372, 240);
			this.cb_COU_ID.Name = "cb_COU_ID";
			this.cb_COU_ID.Size = new System.Drawing.Size(160, 24);
			this.cb_COU_ID.TabIndex = 13;
			this.cb_COU_ID.Tag = "COU_ID";
			// 
			// cb_NAT_CO
			// 
			this.cb_NAT_CO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_NAT_CO.Location = new System.Drawing.Point(372, 212);
			this.cb_NAT_CO.Name = "cb_NAT_CO";
			this.cb_NAT_CO.Size = new System.Drawing.Size(160, 24);
			this.cb_NAT_CO.TabIndex = 11;
			this.cb_NAT_CO.Tag = "NAT_CO";
			// 
			// cb_GRA_ID
			// 
			this.cb_GRA_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_GRA_ID.Location = new System.Drawing.Point(108, 296);
			this.cb_GRA_ID.Name = "cb_GRA_ID";
			this.cb_GRA_ID.Size = new System.Drawing.Size(128, 24);
			this.cb_GRA_ID.TabIndex = 18;
			this.cb_GRA_ID.Tag = "GRA_ID";
			// 
			// cb_PRO_ID
			// 
			this.cb_PRO_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_PRO_ID.Location = new System.Drawing.Point(108, 268);
			this.cb_PRO_ID.Name = "cb_PRO_ID";
			this.cb_PRO_ID.Size = new System.Drawing.Size(160, 24);
			this.cb_PRO_ID.TabIndex = 16;
			this.cb_PRO_ID.Tag = "PRO_ID";
			// 
			// cb_CIT_ID
			// 
			this.cb_CIT_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_CIT_ID.Location = new System.Drawing.Point(372, 296);
			this.cb_CIT_ID.Name = "cb_CIT_ID";
			this.cb_CIT_ID.Size = new System.Drawing.Size(160, 24);
			this.cb_CIT_ID.TabIndex = 17;
			this.cb_CIT_ID.Tag = "CIT_ID";
			// 
			// cb_EDU_ID
			// 
			this.cb_EDU_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_EDU_ID.Location = new System.Drawing.Point(372, 268);
			this.cb_EDU_ID.Name = "cb_EDU_ID";
			this.cb_EDU_ID.Size = new System.Drawing.Size(160, 24);
			this.cb_EDU_ID.TabIndex = 15;
			this.cb_EDU_ID.Tag = "EDU_ID";
			// 
			// cb_DEP_ID
			// 
			this.cb_DEP_ID.BackColor = System.Drawing.Color.LemonChiffon;
			this.cb_DEP_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_DEP_ID.Location = new System.Drawing.Point(108, 392);
			this.cb_DEP_ID.Name = "cb_DEP_ID";
			this.cb_DEP_ID.Size = new System.Drawing.Size(160, 24);
			this.cb_DEP_ID.TabIndex = 20;
			this.cb_DEP_ID.Tag = "DEP_ID";
			this.cb_DEP_ID.SelectedValueChanged += new System.EventHandler(this.cb_DEP_ID_SelectedIndexChanged);
			// 
			// txt_RAC_NM
			// 
			this.txt_RAC_NM.Location = new System.Drawing.Point(108, 212);
			this.txt_RAC_NM.MaxLength = 50;
			this.txt_RAC_NM.Name = "txt_RAC_NM";
			this.txt_RAC_NM.Size = new System.Drawing.Size(160, 23);
			this.txt_RAC_NM.TabIndex = 12;
			this.txt_RAC_NM.Tag = "RAC_NM";
			this.txt_RAC_NM.Text = "textBox7";
			// 
			// label29
			// 
			this.label29.Location = new System.Drawing.Point(272, 484);
			this.label29.Name = "label29";
			this.label29.TabIndex = 98;
			this.label29.Tag = "GRT_ID";
			this.label29.Text = "GRT_ID";
			// 
			// label28
			// 
			this.label28.Location = new System.Drawing.Point(12, 484);
			this.label28.Name = "label28";
			this.label28.TabIndex = 96;
			this.label28.Tag = "GRP_ID";
			this.label28.Text = "GRP_ID";
			// 
			// label27
			// 
			this.label27.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.label27.Location = new System.Drawing.Point(12, 456);
			this.label27.Name = "label27";
			this.label27.TabIndex = 94;
			this.label27.Tag = "TYP_ID";
			this.label27.Text = "TYP_ID  Nature";
			// 
			// label24
			// 
			this.label24.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.label24.Location = new System.Drawing.Point(272, 456);
			this.label24.Name = "label24";
			this.label24.TabIndex = 87;
			this.label24.Tag = "INH_DT";
			this.label24.Text = "INH_DT";
			// 
			// txt_CRD_NO
			// 
			this.txt_CRD_NO.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt_CRD_NO.Location = new System.Drawing.Point(372, 420);
			this.txt_CRD_NO.MaxLength = 10;
			this.txt_CRD_NO.Name = "txt_CRD_NO";
			this.txt_CRD_NO.Size = new System.Drawing.Size(132, 23);
			this.txt_CRD_NO.TabIndex = 22;
			this.txt_CRD_NO.Tag = "CRD_NO";
			this.txt_CRD_NO.Text = "textBox7";
			this.txt_CRD_NO.Leave += new System.EventHandler(this.txt_CRD_NO_Leave);
			// 
			// label23
			// 
			this.label23.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.label23.Location = new System.Drawing.Point(272, 428);
			this.label23.Name = "label23";
			this.label23.TabIndex = 85;
			this.label23.Tag = "CRD_NO";
			this.label23.Text = "CRD_NO";
			// 
			// label22
			// 
			this.label22.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.label22.Location = new System.Drawing.Point(12, 428);
			this.label22.Name = "label22";
			this.label22.TabIndex = 83;
			this.label22.Tag = "POS_ID";
			this.label22.Text = "POS_ID";
			// 
			// txt_DEP_N1
			// 
			this.txt_DEP_N1.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt_DEP_N1.Location = new System.Drawing.Point(268, 392);
			this.txt_DEP_N1.MaxLength = 20;
			this.txt_DEP_N1.Name = "txt_DEP_N1";
			this.txt_DEP_N1.ReadOnly = true;
			this.txt_DEP_N1.Size = new System.Drawing.Size(264, 23);
			this.txt_DEP_N1.TabIndex = 81;
			this.txt_DEP_N1.Tag = "";
			this.txt_DEP_N1.Text = "textBox6";
			// 
			// label21
			// 
			this.label21.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.label21.Location = new System.Drawing.Point(12, 400);
			this.label21.Name = "label21";
			this.label21.TabIndex = 80;
			this.label21.Tag = "DEP_ID";
			this.label21.Text = "DEP_ID";
			// 
			// label39
			// 
			this.label39.BackColor = System.Drawing.Color.Transparent;
			this.label39.ForeColor = System.Drawing.Color.Red;
			this.label39.Location = new System.Drawing.Point(696, 68);
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
			this.cmd_upload.Location = new System.Drawing.Point(828, 100);
			this.cmd_upload.Name = "cmd_upload";
			this.cmd_upload.Size = new System.Drawing.Size(76, 40);
			this.cmd_upload.TabIndex = 72;
			this.cmd_upload.Text = "upload";
			this.cmd_upload.Click += new System.EventHandler(this.cmd_upload_Click);
			// 
			// cmd_browser
			// 
			this.cmd_browser.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_browser.Location = new System.Drawing.Point(828, 160);
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
			this.pic.Location = new System.Drawing.Point(696, 40);
			this.pic.Name = "pic";
			this.pic.Size = new System.Drawing.Size(120, 160);
			this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic.TabIndex = 70;
			this.pic.TabStop = false;
			// 
			// txt_ACC_NM
			// 
			this.txt_ACC_NM.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt_ACC_NM.Location = new System.Drawing.Point(372, 324);
			this.txt_ACC_NM.MaxLength = 50;
			this.txt_ACC_NM.Name = "txt_ACC_NM";
			this.txt_ACC_NM.ReadOnly = true;
			this.txt_ACC_NM.Size = new System.Drawing.Size(132, 23);
			this.txt_ACC_NM.TabIndex = 40;
			this.txt_ACC_NM.Tag = "ACC_NM";
			this.txt_ACC_NM.Text = "textBox7";
			// 
			// txt_ADD_D1
			// 
			this.txt_ADD_D1.Location = new System.Drawing.Point(108, 128);
			this.txt_ADD_D1.MaxLength = 255;
			this.txt_ADD_D1.Name = "txt_ADD_D1";
			this.txt_ADD_D1.Size = new System.Drawing.Size(424, 23);
			this.txt_ADD_D1.TabIndex = 7;
			this.txt_ADD_D1.Tag = "ADD_D1";
			this.txt_ADD_D1.Text = "textBox8";
			// 
			// txt_CRD_LC
			// 
			this.txt_CRD_LC.Location = new System.Drawing.Point(108, 184);
			this.txt_CRD_LC.MaxLength = 255;
			this.txt_CRD_LC.Name = "txt_CRD_LC";
			this.txt_CRD_LC.Size = new System.Drawing.Size(160, 23);
			this.txt_CRD_LC.TabIndex = 10;
			this.txt_CRD_LC.Tag = "CRD_LC";
			this.txt_CRD_LC.Text = "textBox2";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(320, 44);
			this.textBox1.MaxLength = 50;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(212, 23);
			this.textBox1.TabIndex = 3;
			this.textBox1.Tag = "EMP_N1";
			this.textBox1.Text = "";
			// 
			// txt_ACC_NO
			// 
			this.txt_ACC_NO.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt_ACC_NO.Location = new System.Drawing.Point(108, 324);
			this.txt_ACC_NO.MaxLength = 20;
			this.txt_ACC_NO.Name = "txt_ACC_NO";
			this.txt_ACC_NO.ReadOnly = true;
			this.txt_ACC_NO.Size = new System.Drawing.Size(160, 23);
			this.txt_ACC_NO.TabIndex = 41;
			this.txt_ACC_NO.Tag = "ACC_NO";
			this.txt_ACC_NO.Text = "textBox12";
			// 
			// textBox11
			// 
			this.textBox11.BackColor = System.Drawing.Color.LemonChiffon;
			this.textBox11.Location = new System.Drawing.Point(108, 352);
			this.textBox11.MaxLength = 100;
			this.textBox11.Name = "textBox11";
			this.textBox11.ReadOnly = true;
			this.textBox11.Size = new System.Drawing.Size(424, 23);
			this.textBox11.TabIndex = 42;
			this.textBox11.Tag = "BNK_NM";
			this.textBox11.Text = "BNK_NM";
			// 
			// txt_ADD_DR
			// 
			this.txt_ADD_DR.Location = new System.Drawing.Point(108, 100);
			this.txt_ADD_DR.MaxLength = 255;
			this.txt_ADD_DR.Name = "txt_ADD_DR";
			this.txt_ADD_DR.Size = new System.Drawing.Size(424, 23);
			this.txt_ADD_DR.TabIndex = 6;
			this.txt_ADD_DR.Tag = "ADD_DR";
			this.txt_ADD_DR.Text = "textBox8";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(276, 304);
			this.label8.Name = "label8";
			this.label8.TabIndex = 37;
			this.label8.Tag = "CIT_ID";
			this.label8.Text = "CIT_ID";
			// 
			// txt_TEL_NO
			// 
			this.txt_TEL_NO.Location = new System.Drawing.Point(372, 72);
			this.txt_TEL_NO.MaxLength = 30;
			this.txt_TEL_NO.Name = "txt_TEL_NO";
			this.txt_TEL_NO.Size = new System.Drawing.Size(160, 23);
			this.txt_TEL_NO.TabIndex = 5;
			this.txt_TEL_NO.Tag = "TEL_NO";
			this.txt_TEL_NO.Text = "textBox6";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(276, 76);
			this.label7.Name = "label7";
			this.label7.TabIndex = 35;
			this.label7.Tag = "TEL_NO";
			this.label7.Text = "TEL_NO";
			// 
			// txt_CRD_ID
			// 
			this.txt_CRD_ID.Location = new System.Drawing.Point(108, 156);
			this.txt_CRD_ID.MaxLength = 12;
			this.txt_CRD_ID.Name = "txt_CRD_ID";
			this.txt_CRD_ID.Size = new System.Drawing.Size(160, 23);
			this.txt_CRD_ID.TabIndex = 8;
			this.txt_CRD_ID.Tag = "CRD_ID";
			this.txt_CRD_ID.Text = "textBox5";
			this.txt_CRD_ID.Leave += new System.EventHandler(this.txt_CRD_ID_Leave);
			// 
			// txt_EMP_I1
			// 
			this.txt_EMP_I1.BackColor = System.Drawing.Color.PeachPuff;
			this.txt_EMP_I1.Location = new System.Drawing.Point(372, 16);
			this.txt_EMP_I1.MaxLength = 20;
			this.txt_EMP_I1.Name = "txt_EMP_I1";
			this.txt_EMP_I1.Size = new System.Drawing.Size(160, 23);
			this.txt_EMP_I1.TabIndex = 1;
			this.txt_EMP_I1.Tag = "EMP_I1";
			this.txt_EMP_I1.Text = "textBox4";
			// 
			// txt_EMP_ID
			// 
			this.txt_EMP_ID.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt_EMP_ID.Location = new System.Drawing.Point(108, 16);
			this.txt_EMP_ID.MaxLength = 20;
			this.txt_EMP_ID.Name = "txt_EMP_ID";
			this.txt_EMP_ID.Size = new System.Drawing.Size(156, 23);
			this.txt_EMP_ID.TabIndex = 0;
			this.txt_EMP_ID.Tag = "EMP_ID";
			this.txt_EMP_ID.Text = "textBox3";
			// 
			// txt_EMP_NM
			// 
			this.txt_EMP_NM.BackColor = System.Drawing.Color.LightBlue;
			this.txt_EMP_NM.Location = new System.Drawing.Point(108, 44);
			this.txt_EMP_NM.MaxLength = 50;
			this.txt_EMP_NM.Name = "txt_EMP_NM";
			this.txt_EMP_NM.Size = new System.Drawing.Size(212, 23);
			this.txt_EMP_NM.TabIndex = 2;
			this.txt_EMP_NM.Tag = "EMP_NM";
			this.txt_EMP_NM.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(272, 24);
			this.label4.Name = "label4";
			this.label4.TabIndex = 31;
			this.label4.Tag = "EMP_I1";
			this.label4.Text = "EMP_I1";
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(276, 164);
			this.label16.Name = "label16";
			this.label16.TabIndex = 56;
			this.label16.Tag = "CRD_DT";
			this.label16.Text = "CRD_DT";
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(276, 276);
			this.label18.Name = "label18";
			this.label18.TabIndex = 61;
			this.label18.Tag = "EDU_ID";
			this.label18.Text = "EDU_ID";
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(12, 132);
			this.label17.Name = "label17";
			this.label17.TabIndex = 59;
			this.label17.Tag = "ADD_D1";
			this.label17.Text = "ADD_D1";
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(12, 192);
			this.label15.Name = "label15";
			this.label15.TabIndex = 54;
			this.label15.Tag = "CRD_LC";
			this.label15.Text = "CRD_LC";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(132, 32);
			this.label1.TabIndex = 52;
			this.label1.Tag = "BIR_DT";
			this.label1.Text = "BIR_DT";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(12, 332);
			this.label13.Name = "label13";
			this.label13.TabIndex = 47;
			this.label13.Tag = "ACC_NO";
			this.label13.Text = "ACC_NO";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(12, 360);
			this.label12.Name = "label12";
			this.label12.TabIndex = 45;
			this.label12.Tag = "BNK_NM";
			this.label12.Text = "BNK_NM";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(12, 104);
			this.label9.Name = "label9";
			this.label9.TabIndex = 39;
			this.label9.Tag = "ADD_DR";
			this.label9.Text = "ADD_DR";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(12, 164);
			this.label6.Name = "label6";
			this.label6.TabIndex = 33;
			this.label6.Tag = "CRD_ID";
			this.label6.Text = "CRD_ID";
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 24);
			this.label3.Name = "label3";
			this.label3.TabIndex = 29;
			this.label3.Tag = "EMP_ID";
			this.label3.Text = "EMP_ID";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 52);
			this.label2.Name = "label2";
			this.label2.TabIndex = 27;
			this.label2.Tag = "EMP_NM";
			this.label2.Text = "EMP_NM";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(12, 304);
			this.label11.Name = "label11";
			this.label11.TabIndex = 65;
			this.label11.Tag = "GRA_ID";
			this.label11.Text = "GRA_ID";
			// 
			// label31
			// 
			this.label31.Location = new System.Drawing.Point(12, 220);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(132, 23);
			this.label31.TabIndex = 102;
			this.label31.Tag = "RAC_NM";
			this.label31.Text = "RAC_NM Dan toc";
			// 
			// lll
			// 
			this.lll.Location = new System.Drawing.Point(276, 332);
			this.lll.Name = "lll";
			this.lll.TabIndex = 67;
			this.lll.Tag = "ACC_NM";
			this.lll.Text = "ACC_NM";
			// 
			// label26
			// 
			this.label26.Location = new System.Drawing.Point(276, 220);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(120, 23);
			this.label26.TabIndex = 91;
			this.label26.Tag = "NAT_CO";
			this.label26.Text = "NAT_CO Nguyen Quan";
			// 
			// label25
			// 
			this.label25.Location = new System.Drawing.Point(276, 248);
			this.label25.Name = "label25";
			this.label25.TabIndex = 89;
			this.label25.Tag = "COU_ID";
			this.label25.Text = "COU_ID Nation";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(12, 276);
			this.label10.Name = "label10";
			this.label10.TabIndex = 63;
			this.label10.Tag = "PRO_ID";
			this.label10.Text = "PRO_ID";
			// 
			// label57
			// 
			this.label57.Location = new System.Drawing.Point(12, 248);
			this.label57.Name = "label57";
			this.label57.Size = new System.Drawing.Size(132, 23);
			this.label57.TabIndex = 142;
			this.label57.Tag = "REL_DR";
			this.label57.Text = "REL_DR Ton Giao";
			// 
			// label34
			// 
			this.label34.Location = new System.Drawing.Point(12, 532);
			this.label34.Name = "label34";
			this.label34.TabIndex = 123;
			this.label34.Tag = "REM_DR";
			this.label34.Text = "REM_DR";
			// 
			// label56
			// 
			this.label56.Location = new System.Drawing.Point(12, 512);
			this.label56.Name = "label56";
			this.label56.TabIndex = 140;
			this.label56.Tag = "LEV_ID";
			this.label56.Text = "LEV_ID";
			// 
			// lb2
			// 
			this.lb2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lb2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lb2.ForeColor = System.Drawing.Color.Red;
			this.lb2.Location = new System.Drawing.Point(704, 208);
			this.lb2.Name = "lb2";
			this.lb2.Size = new System.Drawing.Size(24, 23);
			this.lb2.TabIndex = 146;
			this.lb2.Tag = "N";
			this.lb2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lb2.Visible = false;
			// 
			// lb1
			// 
			this.lb1.Location = new System.Drawing.Point(732, 212);
			this.lb1.Name = "lb1";
			this.lb1.TabIndex = 145;
			this.lb1.Tag = "";
			this.lb1.Text = "MEA_BT";
			this.lb1.Visible = false;
			// 
			// label54
			// 
			this.label54.Location = new System.Drawing.Point(572, 160);
			this.label54.Name = "label54";
			this.label54.TabIndex = 137;
			this.label54.Tag = "DIR_BT";
			this.label54.Text = "MEA_BT";
			// 
			// ck_DIR_BT
			// 
			this.ck_DIR_BT.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ck_DIR_BT.Location = new System.Drawing.Point(548, 156);
			this.ck_DIR_BT.Name = "ck_DIR_BT";
			this.ck_DIR_BT.Size = new System.Drawing.Size(16, 24);
			this.ck_DIR_BT.TabIndex = 36;
			this.ck_DIR_BT.Tag = "DIR_BT";
			this.ck_DIR_BT.Text = "MEA_BT";
			// 
			// label49
			// 
			this.label49.Location = new System.Drawing.Point(572, 140);
			this.label49.Name = "label49";
			this.label49.TabIndex = 135;
			this.label49.Tag = "BHX_BT";
			this.label49.Text = "BHX_BT";
			// 
			// ck_BHX_BT
			// 
			this.ck_BHX_BT.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ck_BHX_BT.Location = new System.Drawing.Point(548, 136);
			this.ck_BHX_BT.Name = "ck_BHX_BT";
			this.ck_BHX_BT.Size = new System.Drawing.Size(16, 24);
			this.ck_BHX_BT.TabIndex = 35;
			this.ck_BHX_BT.Tag = "BHX_BT";
			this.ck_BHX_BT.Text = "BHX_BT";
			// 
			// label37
			// 
			this.label37.Location = new System.Drawing.Point(572, 120);
			this.label37.Name = "label37";
			this.label37.TabIndex = 130;
			this.label37.Tag = "LCK_BT";
			this.label37.Text = "MEA_BT";
			// 
			// ck_LCK_BT
			// 
			this.ck_LCK_BT.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ck_LCK_BT.Location = new System.Drawing.Point(548, 116);
			this.ck_LCK_BT.Name = "ck_LCK_BT";
			this.ck_LCK_BT.Size = new System.Drawing.Size(16, 24);
			this.ck_LCK_BT.TabIndex = 34;
			this.ck_LCK_BT.Tag = "LCK_BT";
			this.ck_LCK_BT.Text = "MEA_BT";
			// 
			// label35
			// 
			this.label35.ForeColor = System.Drawing.Color.Red;
			this.label35.Location = new System.Drawing.Point(572, 100);
			this.label35.Name = "label35";
			this.label35.TabIndex = 127;
			this.label35.Tag = "ATT_BT";
			this.label35.Text = "MEA_BT";
			// 
			// ck_ATT_BT
			// 
			this.ck_ATT_BT.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ck_ATT_BT.Location = new System.Drawing.Point(548, 96);
			this.ck_ATT_BT.Name = "ck_ATT_BT";
			this.ck_ATT_BT.Size = new System.Drawing.Size(16, 24);
			this.ck_ATT_BT.TabIndex = 33;
			this.ck_ATT_BT.Tag = "ATT_BT";
			// 
			// label33
			// 
			this.label33.Location = new System.Drawing.Point(572, 80);
			this.label33.Name = "label33";
			this.label33.TabIndex = 121;
			this.label33.Tag = "MEA_BT";
			this.label33.Text = "MEA_BT";
			// 
			// ck_MEA_BT
			// 
			this.ck_MEA_BT.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ck_MEA_BT.Location = new System.Drawing.Point(548, 76);
			this.ck_MEA_BT.Name = "ck_MEA_BT";
			this.ck_MEA_BT.Size = new System.Drawing.Size(16, 24);
			this.ck_MEA_BT.TabIndex = 32;
			this.ck_MEA_BT.Tag = "MEA_BT";
			this.ck_MEA_BT.Text = "MEA_BT";
			// 
			// label32
			// 
			this.label32.Location = new System.Drawing.Point(572, 60);
			this.label32.Name = "label32";
			this.label32.TabIndex = 119;
			this.label32.Tag = "NEW_BT";
			this.label32.Text = "NEW_BT";
			// 
			// ck_NEW_BT
			// 
			this.ck_NEW_BT.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ck_NEW_BT.Location = new System.Drawing.Point(548, 56);
			this.ck_NEW_BT.Name = "ck_NEW_BT";
			this.ck_NEW_BT.Size = new System.Drawing.Size(16, 24);
			this.ck_NEW_BT.TabIndex = 31;
			this.ck_NEW_BT.Tag = "NEW_BT";
			this.ck_NEW_BT.Text = "MAR_BT";
			// 
			// label20
			// 
			this.label20.Location = new System.Drawing.Point(572, 40);
			this.label20.Name = "label20";
			this.label20.TabIndex = 77;
			this.label20.Tag = "MAR_BT";
			this.label20.Text = "MAR_BT";
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(572, 20);
			this.label19.Name = "label19";
			this.label19.TabIndex = 76;
			this.label19.Tag = "SEX_BT";
			this.label19.Text = "SEX_BT";
			// 
			// ck_MAR_BT
			// 
			this.ck_MAR_BT.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ck_MAR_BT.Location = new System.Drawing.Point(548, 36);
			this.ck_MAR_BT.Name = "ck_MAR_BT";
			this.ck_MAR_BT.Size = new System.Drawing.Size(16, 24);
			this.ck_MAR_BT.TabIndex = 30;
			this.ck_MAR_BT.Tag = "MAR_BT";
			this.ck_MAR_BT.Text = "MAR_BT";
			// 
			// ck_SEX_BT
			// 
			this.ck_SEX_BT.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ck_SEX_BT.Location = new System.Drawing.Point(548, 16);
			this.ck_SEX_BT.Name = "ck_SEX_BT";
			this.ck_SEX_BT.Size = new System.Drawing.Size(16, 24);
			this.ck_SEX_BT.TabIndex = 29;
			this.ck_SEX_BT.Tag = "SEX_BT";
			this.ck_SEX_BT.Text = "SEX_BT";
			// 
			// label59
			// 
			this.label59.Location = new System.Drawing.Point(276, 192);
			this.label59.Name = "label59";
			this.label59.TabIndex = 149;
			this.label59.Tag = "MST_DR";
			this.label59.Text = "TEL_NO";
			// 
			// label60
			// 
			this.label60.ForeColor = System.Drawing.Color.Black;
			this.label60.Location = new System.Drawing.Point(272, 512);
			this.label60.Name = "label60";
			this.label60.TabIndex = 151;
			this.label60.Tag = "SEN_DT";
			this.label60.Text = "SEN_DT";
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.Moccasin;
			this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel6.Controls.Add(this.ckVAC);
			this.panel6.Controls.Add(this.ck_QEdit);
			this.panel6.Controls.Add(this.ck_search);
			this.panel6.Controls.Add(this.S_EMP_NM);
			this.panel6.Controls.Add(this.S_CRD_NO);
			this.panel6.Controls.Add(this.S_EMP_I1);
			this.panel6.Controls.Add(this.S_EMP_ID);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel6.Location = new System.Drawing.Point(0, 0);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(925, 32);
			this.panel6.TabIndex = 3;
			// 
			// ckVAC
			// 
			this.ckVAC.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ckVAC.Location = new System.Drawing.Point(856, 3);
			this.ckVAC.Name = "ckVAC";
			this.ckVAC.Size = new System.Drawing.Size(60, 24);
			this.ckVAC.TabIndex = 6;
			this.ckVAC.Tag = "N";
			this.ckVAC.Text = "Vacate";
			// 
			// ck_QEdit
			// 
			this.ck_QEdit.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ck_QEdit.Location = new System.Drawing.Point(764, 4);
			this.ck_QEdit.Name = "ck_QEdit";
			this.ck_QEdit.Size = new System.Drawing.Size(84, 24);
			this.ck_QEdit.TabIndex = 5;
			this.ck_QEdit.Tag = "SEX_BT";
			this.ck_QEdit.Text = "SEX_BT";
			this.ck_QEdit.CheckedChanged += new System.EventHandler(this.ck_QEdit_CheckedChanged);
			// 
			// ck_search
			// 
			this.ck_search.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ck_search.Location = new System.Drawing.Point(656, 4);
			this.ck_search.Name = "ck_search";
			this.ck_search.Size = new System.Drawing.Size(88, 24);
			this.ck_search.TabIndex = 4;
			this.ck_search.Tag = "";
			this.ck_search.Text = "Exactly Find";
			// 
			// S_EMP_NM
			// 
			this.S_EMP_NM.BackColor = System.Drawing.Color.LightBlue;
			this.S_EMP_NM.Location = new System.Drawing.Point(324, 4);
			this.S_EMP_NM.MaxLength = 20;
			this.S_EMP_NM.Name = "S_EMP_NM";
			this.S_EMP_NM.Size = new System.Drawing.Size(156, 23);
			this.S_EMP_NM.TabIndex = 2;
			this.S_EMP_NM.Tag = "EMP_NM";
			this.S_EMP_NM.Text = "EMP_NM";
			this.S_EMP_NM.KeyDown += new System.Windows.Forms.KeyEventHandler(this.S_EMP_ID_KeyDown);
			this.S_EMP_NM.Leave += new System.EventHandler(this.S_EMP_NM_Leave);
			this.S_EMP_NM.Enter += new System.EventHandler(this.S_EMP_NM_Enter);
			// 
			// S_CRD_NO
			// 
			this.S_CRD_NO.BackColor = System.Drawing.Color.LemonChiffon;
			this.S_CRD_NO.Location = new System.Drawing.Point(484, 4);
			this.S_CRD_NO.MaxLength = 20;
			this.S_CRD_NO.Name = "S_CRD_NO";
			this.S_CRD_NO.Size = new System.Drawing.Size(156, 23);
			this.S_CRD_NO.TabIndex = 3;
			this.S_CRD_NO.Tag = "CRD_NO";
			this.S_CRD_NO.Text = "textBox3";
			this.S_CRD_NO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.S_EMP_ID_KeyDown);
			this.S_CRD_NO.Leave += new System.EventHandler(this.S_CRD_NO_Leave);
			this.S_CRD_NO.Enter += new System.EventHandler(this.S_CRD_NO_Enter);
			// 
			// S_EMP_I1
			// 
			this.S_EMP_I1.BackColor = System.Drawing.Color.PeachPuff;
			this.S_EMP_I1.Location = new System.Drawing.Point(164, 4);
			this.S_EMP_I1.MaxLength = 20;
			this.S_EMP_I1.Name = "S_EMP_I1";
			this.S_EMP_I1.Size = new System.Drawing.Size(156, 23);
			this.S_EMP_I1.TabIndex = 1;
			this.S_EMP_I1.Tag = "EMP_I1";
			this.S_EMP_I1.Text = "textBox3";
			this.S_EMP_I1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.S_EMP_ID_KeyDown);
			this.S_EMP_I1.Leave += new System.EventHandler(this.S_EMP_I1_Leave);
			this.S_EMP_I1.Enter += new System.EventHandler(this.S_EMP_I1_Enter);
			// 
			// S_EMP_ID
			// 
			this.S_EMP_ID.BackColor = System.Drawing.Color.LemonChiffon;
			this.S_EMP_ID.Location = new System.Drawing.Point(4, 4);
			this.S_EMP_ID.MaxLength = 20;
			this.S_EMP_ID.Name = "S_EMP_ID";
			this.S_EMP_ID.Size = new System.Drawing.Size(156, 23);
			this.S_EMP_ID.TabIndex = 0;
			this.S_EMP_ID.Tag = "EMP_ID";
			this.S_EMP_ID.Text = "textBox3";
			this.S_EMP_ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.S_EMP_ID_KeyDown);
			this.S_EMP_ID.Leave += new System.EventHandler(this.S_EMP_ID_Leave);
			this.S_EMP_ID.Enter += new System.EventHandler(this.S_EMP_ID_Enter);
			// 
			// c1CommandDock2
			// 
			this.c1CommandDock2.Controls.Add(this.c1DockingTab2);
			this.c1CommandDock2.Dock = System.Windows.Forms.DockStyle.Right;
			this.c1CommandDock2.Id = 2;
			this.c1CommandDock2.Location = new System.Drawing.Point(925, 0);
			this.c1CommandDock2.Name = "c1CommandDock2";
			this.c1CommandDock2.Size = new System.Drawing.Size(79, 695);
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
			this.c1DockingTab2.Size = new System.Drawing.Size(79, 695);
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
			this.c1DockingTabPage2.Size = new System.Drawing.Size(74, 693);
			this.c1DockingTabPage2.TabIndex = 0;
			this.c1DockingTabPage2.Text = "Page2";
			// 
			// vs
			// 
			this.vs.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vs.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs.Location = new System.Drawing.Point(0, 23);
			this.vs.Name = "vs";
			this.vs.Size = new System.Drawing.Size(74, 670);
			this.vs.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Tahoma, 9.75pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.vs.TabIndex = 8;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.panel3.Controls.Add(this.btn_UpdateGGM);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.panel4);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(16, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1004, 36);
			this.panel3.TabIndex = 3;
			// 
			// btn_UpdateGGM
			// 
			this.btn_UpdateGGM.ForeColor = System.Drawing.Color.Red;
			this.btn_UpdateGGM.Location = new System.Drawing.Point(428, 2);
			this.btn_UpdateGGM.Name = "btn_UpdateGGM";
			this.btn_UpdateGGM.Size = new System.Drawing.Size(148, 32);
			this.btn_UpdateGGM.TabIndex = 13;
			this.btn_UpdateGGM.Text = "Update to GGM";
			this.btn_UpdateGGM.Visible = false;
			this.btn_UpdateGGM.Click += new System.EventHandler(this.btn_UpdateGGM_Click);
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Location = new System.Drawing.Point(416, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(588, 36);
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
			// 
			// c1CommandDock1
			// 
			this.c1CommandDock1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.c1CommandDock1.Controls.Add(this.c1DockingTab1);
			this.c1CommandDock1.Dock = System.Windows.Forms.DockStyle.Left;
			this.c1CommandDock1.Id = 1;
			this.c1CommandDock1.Location = new System.Drawing.Point(0, 0);
			this.c1CommandDock1.Name = "c1CommandDock1";
			this.c1CommandDock1.Size = new System.Drawing.Size(16, 731);
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
			this.c1DockingTab1.Size = new System.Drawing.Size(14, 729);
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
			this.c1DockingTabPage1.Size = new System.Drawing.Size(11, 728);
			this.c1DockingTabPage1.TabIndex = 0;
			this.c1DockingTabPage1.Text = "Page1";
			// 
			// Dep
			// 
			this.Dep.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Dep.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Dep.Location = new System.Drawing.Point(0, 23);
			this.Dep.Name = "Dep";
			this.Dep.Size = new System.Drawing.Size(11, 705);
			this.Dep.TabIndex = 0;
			// 
			// frmTaStaffInfo
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(1020, 731);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaStaffInfo";
			this.Text = "frmTaStaffInfo";
			this.Load += new System.EventHandler(this.frmTaStaffInfo_Load);
			this.Closed += new System.EventHandler(this.frmTaStaffInfo_Closed);
			this.panel1.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.rpt)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dt_SEN_DT)).EndInit();
			this.p2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txt_BIR_DT)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dt_BIR_DT)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1DockingTab3)).EndInit();
			this.c1DockingTab3.ResumeLayout(false);
			this.Tab_HDLD.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.gp.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dt_LA1_ED)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dt_LA1_ST)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dt_LAB_ED)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dt_LAB_ST)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vs1)).EndInit();
			this.Tab_BHXH.ResumeLayout(false);
			this.panel9.ResumeLayout(false);
			this.gp1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dt_BHL_ED)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dt_BHL_ST)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dt_BHY_ED)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dt_BHY_ST)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dt_BHX_ED)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dt_BHX_ST)).EndInit();
			this.Tab_REM.ResumeLayout(false);
			this.g2.ResumeLayout(false);
			this.tabVanBang.ResumeLayout(false);
			this.panel11.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs2)).EndInit();
			this.panel10.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dt_CRD_DT)).EndInit();
			this.panel7.ResumeLayout(false);
			this.p1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dt_INH_DT)).EndInit();
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
		private void frmTaStaffInfo_Load(object sender, System.EventArgs e)
		{		
			Init_Form();		
			CheckNewStaffToOldStaff();
			button1.Enabled=PublicFunction.AccessLevel(84,5);
			S_EMP_ID.Focus();
			cmd_upload.Visible=cmd_browser.Visible=cmd_quick.Visible=PublicFunction.AccessLevel(this.Tag,3);

			if(PublicFunction.GPS)
			{
				btn_UpdateGGM.Visible=false;
			}			
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
			Dep.Init_Tree(this.Tag+"");
			Dep.vs1.AfterRowColChange+=new RangeEventHandler(Depvs1_AfterRowColChange);
			Dep.Show_Tree();
			Init_vs();
			Init_vs1();
			vs2.Tag="N";
			nav2.Tag="N";	
			tabVanBang.TabVisible=false;
			if(PublicFunction.GetOption("CERTIFICATE")=="1")
			{
				tabVanBang.TabVisible =true;
				nav2.Visible=vs2.Visible=true;
				vs2.Tag="";
				nav2.Tag="";
				Init_vs2();
				Init_CBVS2();
			}
			Init_Menu();
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
			else
			{
				dt_BIR_DT.CustomFormat=PublicFunction.GetOption("DATE");
				dt_BIR_DT.Tag="BIR_DT";
				dt_BIR_DT.Visible=true;
				txt_BIR_DT.Tag="";
				txt_BIR_DT.Visible=false;
			}
			dt_BHL_ST.CustomFormat=dt_BHL_ED.CustomFormat=format;
			dt_BHX_ST.CustomFormat=dt_BHX_ED.CustomFormat=format;
			dt_BHY_ST.CustomFormat=dt_BHY_ED.CustomFormat=format;
			dt_LAB_ST.CustomFormat=dt_LAB_ED.CustomFormat=format;
			dt_LA1_ST.CustomFormat=dt_LA1_ED.CustomFormat=format;
			dt_SEN_DT.CustomFormat=format;			
			vs.AllowEditing=ck_QEdit.Checked;
			Func.RecordSet rs=new Func.RecordSet("Select * from GP_SYS_READER",PublicFunction.C_con);
			if(rs.rows>0)				
				txt_CRD_NO.MaxLength=T_String.IsNullTo0(rs.record(0,"CRD_LN"));			
			else
				txt_CRD_NO.MaxLength=10;	
			////////////////chi co user pha1,vinhtuyen,admin moi duoc khoa//////////////////
			if(PublicFunction.A_UserID=="pha1" || PublicFunction.A_UserID=="vinhtuyen" || PublicFunction.A_UserID=="admin")
				ck_LCK_BT.Enabled=true;
			else
				ck_LCK_BT.Enabled=false;
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
			vs.Cols["INH_DT"].Format=PublicFunction.GetOption("DATE");		
			vs.Styles.Add("VAC_BT");
			vs.Styles["VAC_BT"].BackColor=Color.DarkGray;
			vs.Cols.Frozen=vs.Cols["EMP_NM"].Index;
		}
		private void Init_vs2()
		{
			nav2.cmd_copy.Visible=false;	
			nav2.cmd_exit.Visible=nav2.cmd_refresh.Visible=nav2.cmd_search.Visible =nav2.cmd_report.Visible =false;	
			PublicFunction.InitNav(this,vs2,nav2);
			nav2.TBarClick+=new ToolBarButtonClickEventHandler(nav2_TBarClick);		
			nav2.ToolBar_Auto=false;
			//vs2.EnabledChanged+=new EventHandler(vs2_EnabledChanged);
			vs2.BeforeEdit+=new RowColEventHandler(vs2_BeforeEdit);					
			
		}
		private void Init_vs1()
		{			
			PublicFunction.InitNav(this,vs1,nav1);								
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
		private void  Init_CBVS2()
		{			
			string sql;			
			//CERTIFICATE
			sql="Select CTF_ID,CTF_NM from FILA10B";		
			vs2.Cols["CTF_ID"].DataMap=PublicFunction.InitCBForVS(sql);						
				
		}
		private void vs2_BeforeEdit(object sender, RowColEventArgs e)
		{
			if(vs2.Rows[e.Row].UserData+""!="2")
				e.Cancel=true;			
		}
		private void nav2_TBarClick(object sender, ToolBarButtonClickEventArgs e)
		{	
			if (e.Button.Equals(nav2.cmd_add))
			{
				if(vs.Row<=0)
					return;
				if(vs2.Rows[vs2.Rows.Count-1].UserData+""=="2")
					return;
				nav2.ToolBar_Click(e);						
				vs2.Rows[vs2.Rows.Count-1]["EMP_ID"]=vs.Rows[vs.Row]["EMP_ID"];	
				int max=T_String.GetMax("MAX(SEQ_NO)","FILB08A","EMP_ID=N'"+vs.Rows[vs.Row]["EMP_ID"]+"'");
				vs2.Rows[vs2.Rows.Count-1]["SEQ_NO"]=max;				
				vs2.Rows[vs2.Rows.Count-1]["BLT_NM"]=PublicFunction.A_UserID;
				vs2.Rows[vs2.Rows.Count-1]["BLT_DT"]=T_String.GetDate().ToString("yyyy/MM/dd HH:mm");
				return;
			}			
			nav2.ToolBar_Click(e);
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
		private void Init_Menu()
		{			
			mnu1=new ContextMenu();
			nav.cmd_report.Style=ToolBarButtonStyle.DropDownButton;
			nav.cmd_report.DropDownMenu =mnu1;
			int n=T_String.IsNullTo0(T_String.GetDataFromSQL("Count(*)","SYS_LABEL_PMENU","NAME=N'"+this.Name+"'"));
			Init_ReportSTD(n);					
			Init_LabelForMenu();	
			mnu1.MenuItems[1].Visible=false;
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
		#region ShowData
		private void Show_VS()
		{
			if(Dep.vs1.Row<=0)
			{
				vs.Rows.Count=1;
				txt_DEP_N1.Text="";
				return;
			}
			if(ckVAC.Checked)
				nav.Show_VS("DEP_ID in "+Dep.Get_DepAll()+"  and (DEL_BT is null or DEL_BT=0) and isnull(VAC_BT,0)=1 and "+PublicFunction.Get_TYP(this.Tag,"") +" order by EMP_ID");			
			else
				nav.Show_VS("DEP_ID in "+Dep.Get_DepAll()+"  and (DEL_BT is null or DEL_BT=0) and isnull(VAC_BT,0)=0 and "+PublicFunction.Get_TYP(this.Tag,"") +" order by EMP_ID");			
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
					txt_VAC_NM.Text=T_String.GetDataFromSQL("VAC_NM","FILB01AC a, FILA06A b","a.VAC_ID=b.VAC_ID and EMP_ID=N'"+vs.Rows[vs.Row]["EMP_ID"]+"'");
					txt_VAC_DT.Text=DateTime.Parse(T_String.GetDataFromSQL("VAC_DT","FILB01AC a","EMP_ID=N'"+vs.Rows[vs.Row]["EMP_ID"]+"'")).ToString(format);
				}
				catch{}
			}
			else
			{
				p1.Visible=false;
				if(vs.Row>0)
				{
					string sql=T_String.GetDate().ToString("yyyy/MM/dd");
					sql="Select FILC09A.*,FILA20A.MAT_NM from FILC09A left join FILA20A on FILC09A.MAT_ID = FILA20A.MAT_ID where EMP_ID=N'"+vs.Rows[vs.Row]["EMP_ID"]+"' and "
						+"MAN_ST<='"+sql+"' and MAN_ED>='"+sql+"'";
					Func.RecordSet rs=new Func.RecordSet(sql,PublicFunction.C_con);
					if(rs.rows>0)
					{
						p2.Visible=true;
						//TrungLv(22/06/2018) thêm phan hien thi loai thai san
						label58.Text = rs.record(0,"MAT_NM")+"" == "" ? "Thai sản":rs.record(0,"MAT_NM")+""; 
						txt_st.Text=DateTime.Parse(rs.record(0,"MAN_ST")+"").ToString(format);
						txt_ed.Text=DateTime.Parse(rs.record(0,"MAN_ED")+"").ToString(format);
					}
				}
			}		
	
			txt_EMP_I1.Enabled=cb_LEV_ID.Enabled=cb_GRT_ID.Enabled=cb_GRP_ID.Enabled=cb_DEP_ID.Enabled=
				cb_POS_ID.Enabled=(vs.Row>0 && vs.Rows[vs.Row].UserData+""=="2") ;
			if(PublicFunction.GetOption("TYP_BT")=="1")//quang viet
				cb_TYP_ID.Enabled=(vs.Row>0 && vs.Rows[vs.Row].UserData+""=="2") ;
			if (PublicFunction.CUS_ID=="1" ) txt_EMP_I1.Enabled=true;
			if(vs.Row>0 && vs.Rows[vs.Row]["DEP_ID"]+""=="")
				cb_DEP_ID.Enabled=true;			
			Show_VS1();
			if(PublicFunction.GetOption("CERTIFICATE")=="1")			
				Show_VS2();
			//format ngay sinh
//			if (PublicFunction.IsDate(txt_BIR_DT.Text))
//				txt_BIR_DT.Text = DateTime.Parse(txt_BIR_DT.Text).ToString(PublicFunction.GetOption("DOBDATE"));
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
			pic.Image= (Bitmap)ImageFunction.LoadImageFromSQL("Select PIC_DR from FILB01AB where EMP_ID=N'"+
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
			if(vs.Row<1)
			{
				vs1.Rows.Count=1;				
			}
			else
			{
				nav1.Show_VS("EMP_ID=N'"+vs.Rows[vs.Row]["EMP_ID"]+"'");
			}
			TextBoxAndVS.D_GetDataFromVS(gp1,vs1);
			TextBoxAndVS.D_GetDataFromVS(gp,vs1);
		}
		private void Show_VS2()
		{
			if(vs.Row<1)
			{
				vs2.Rows.Count=1;				
			}
			else
			{
				nav2.Show_VS("EMP_ID=N'"+vs.Rows[vs.Row]["EMP_ID"]+"'");
			}			
		}
		#endregion
		#region Tbar
		
		private void nav_TBarClick(object sender, ToolBarButtonClickEventArgs e)
		{				
			if (e.Button.Equals(nav.cmd_add))
			{
				edit=true;//thêm mới thì được save
				if(ck_QEdit.Checked)
					return;
				if (vs.Rows.Count==1 || (int)vs.Rows[vs.Rows.Count-1].UserData!=2)					
					nav.ToolBar_Click(e);					
				TextBoxAndVS.D_AddNewOrEdit(groupBox1,false);
				TextBoxAndVS.D_AddNewOrEdit(g2,false);
				cb_LEV_ID.Enabled=cb_GRP_ID.Enabled=cb_GRT_ID.Enabled=cb_DEP_ID.Enabled=cb_POS_ID.Enabled=cb_TYP_ID.Enabled  =(vs.Row>0 && vs.Rows[vs.Row].UserData+""=="2") ;
				if(PublicFunction.CUS_ID=="50")
					cb_TYP_ID.Enabled=(vs.Row>0 && vs.Rows[vs.Row].UserData+""=="2") ;
				dt_INH_DT.Value=T_String.GetDate();
				if(Dep.vs1.Row>0)
				{
					cb_DEP_ID.SelectedValue=Dep.vs1.Rows[Dep.vs1.Row]["DEP_ID"];
					txt_DEP_N1.Text=T_String.GetDataFromSQL("DEP_N1","FILA02A","DEP_ID=N'"+cb_DEP_ID.SelectedValue+"'");
				}
				ck_ATT_BT.Checked=true;		
				txt_EMP_ID.Focus();
				if(PublicFunction.WIDLEN>0)
				{
					txt_EMP_ID.ReadOnly=true;
				}
				pic.Image=null;
				txt_EMP_I1.Enabled=true;
				return;
			}	
			if (e.Button.Equals(nav.cmd_save))
			{
				//chỉ có user pha1,vinhtuyen,admin mới được sửa
				if(PublicFunction.A_UserID!="pha1" && PublicFunction.A_UserID!="vinhtuyen" && edit==false)
				{
					MessageBox.Show("No save!!!");
					return;
				}
				if(vs.Row<=0)
					return;
				if((PublicFunction.WIDLEN<=0) && txt_EMP_ID.Text+""=="" )
				{
					MessageBox.Show(PublicFunction.L_Get_Msg(this.Name,0));
					return;
				}
				if(txt_CRD_ID.Text+""=="")
				{
					MessageBox.Show(PublicFunction.L_Get_Msg(this.Name,5));
					return;
				}
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
						if (dlg.DialogResult==DialogResult.Cancel )
						{
							txt_CRD_ID.Text =vs.Rows[vs.Row]["CRD_ID"]+"";
							return;
						}			
					}
				}
				if(txt_CRD_NO.Text!="" && T_String.IsNullTo0(T_String.GetDataFromSQL("Count(EMP_ID)","FILB01A","CRD_NO=N'"+txt_CRD_NO.Text+"' and EMP_ID<>N'"+vs.Rows[vs.Row]["EMP_ID"]+"'"))>0)
				{
					MessageBox.Show(PublicFunction.L_Get_Msg("POS",9));
					txt_CRD_NO.Focus();
					return;
				}
				if(txt_CRD_NO.Text +""=="" && PublicFunction.CUS_ID=="51") //QVTG
				{
					MessageBox.Show("Please input Card No!!");
					return;
				}
				if(cb_DEP_ID.SelectedValue+""=="")
				{
					MessageBox.Show(PublicFunction.L_Get_Msg(this.Name,1));
					return;
				}				
				if(cb_POS_ID.SelectedValue+""=="")
				{
					MessageBox.Show(PublicFunction.L_Get_Msg(this.Name,2));
					return;
				}
				if(cb_TYP_ID.SelectedValue+""=="")
				{
					MessageBox.Show(PublicFunction.L_Get_Msg(this.Name,4));
					return;
				}
				if(dt_INH_DT.Text+""=="")
				{
					MessageBox.Show(PublicFunction.L_Get_Msg(this.Name,3));
					return;
				}
				if(txt_EMP_I1.Text!="")
				{
					if(PublicFunction.CUS_ID!="51" && PublicFunction.GetOption("DWID")=="0") //QuangViet Tien giang, Domex QN duoc quyen trung ma so thu hai
					{
						if(T_String.IsNullTo0(T_String.GetDataFromSQL("Count(EMP_ID)","FILB01A","EMP_I1=N'"+txt_EMP_I1.Text+"' and EMP_ID<>N'"+vs.Rows[vs.Row]["EMP_ID"]+"'"))>0)
						{
							MessageBox.Show(PublicFunction.L_Get_Msg("POS",7));
							return;
						}
					}
				}
				if(!CheckDepartment(cb_DEP_ID.SelectedValue+"",vs.Rows[vs.Row]["EMP_ID"]+""))
					return;
				//Thu them confirm BHXH--sep Patrick yeu cau
//				if (PublicFunction.CUS_ID != "3") // WeiSheng
//				{
//					if (ck_BHX_BT.Checked )
//						if(MessageBox.Show(this,PublicFunction.L_Get_Msg(this.Name ,6),this.Text,MessageBoxButtons.YesNo)==DialogResult.No)
//							return;
//				}
				//
				try
				{
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
						
						nav.ToolBar_Click(e);
					}
					else
					{
						nav.ToolBar_Click(e);
						TextBoxAndVS.D_GetDataFromVS(groupBox1,vs);
						TextBoxAndVS.D_GetDataFromVS(g2,vs);
					}
					SaveVS1();
					//cus_id=300. cty KenYa chau phi, cap nhat dlnv sang GGM
					if (PublicFunction.CUS_ID=="300")
					{
						string s="",sdata="";
						if (vs.Rows.Count==1 || (int)vs.Rows[vs.Rows.Count-1].UserData!=2)
						{
							sdata="'"+vs.Rows[vs.Row]["EMP_ID"]+"','"+vs.Rows[vs.Row]["EMP_NM"]+"','"+vs.Rows[vs.Row]["EMP_N1"]+"',";
							if(vs.Rows[vs.Row]["SEX_BT"]+""=="True")
								sdata+=1;
							else
								sdata+=0;
							sdata+=",'"+vs.Rows[vs.Row]["DEP_ID"]+"','"+vs.Rows[vs.Row]["CRD_ID"]+"','"+vs.Rows[vs.Row]["BIR_DT"]+"','";
							sdata+=vs.Rows[vs.Row]["TEL_NO"]+"','"+vs.Rows[vs.Row]["ADD_DR"]+"','"+vs.Rows[vs.Row]["INH_DT"]+"')";
							s="INSERT INTO FC05A (EMP_ID,EMP_NM,ENG_NM,SEX_ID,DEP_ID,PER_ID,BIR_DT,TEL_NO,ADD_DR,INT_DT) VALUES (";
							s+=sdata;
							PublicFunction.SQL_Execute(s,PublicFunction.C_conGGM);
						}
					}
					//end
//					int nv=T_String.IsNullTo0(T_String.GetDataFromSQL("*","FILB01A","EMP_ID=N'"+txt_EMP_ID.Text+"'"));
//					if(nv==0)
//						edit=true;
//					else
						edit=false;//trả edit về false
					return ;					
				}
				catch( Exception){}				
			}
			if (e.Button.Equals(nav.cmd_refresh))
			{		
				string WID="";
				if(vs.Row>0)
					WID=vs.Rows[vs.Row]["EMP_ID"]+"";
//				if(nav.wh!="")
//					nav.ToolBar_Click(e);
//				else
//					if(ckVAC.Checked)
//						nav.Show_VS("(DEL_BT is null or DEL_BT=0) and isnull(VAC_BT,0)=1 and DEP_ID in "+T_String.DEP_ID(this.Tag)+" and "+PublicFunction.Get_TYP(this.Tag,"") +" order by EMP_ID");
//					else
//						nav.Show_VS("(DEL_BT is null or DEL_BT=0) AND isnull(VAC_BT,0)=0 and DEP_ID in "+T_String.DEP_ID(this.Tag)+" and "+PublicFunction.Get_TYP(this.Tag,"") +" order by EMP_ID");
//				ShowData();
				Show_VS();
				if(WID!="")
					for(int i=1;i<vs.Rows.Count;i++)
					{
						if(vs.Rows[i]["EMP_ID"]+""==WID)
						{
							vs.Row=i;
							break;
						}
					}
				return;
			}					
			nav.ToolBar_Click(e);				
		}

		private void SaveVS1()
		{
			if(vs.Row>0 && vs.Rows[vs.Row].UserData+""!="2" )
			{
				try
				{
					if(vs1.Rows.Count<=1)
					{					
						vs1.Rows.Count++;
						vs1.Row=vs1.Rows.Count-1;
						vs1.Rows[vs1.Row].UserData=2;	
						vs1.Rows[vs1.Row]["EMP_ID"]=vs.Rows[vs.Row]["EMP_ID"];				
					}
					else
					{				
						vs1.Row=1;
						vs1.Rows[vs1.Row].UserData=1;						
					}
					TextBoxAndVS.D_GetDataFromTextBox(gp1,vs1);
					TextBoxAndVS.D_GetDataFromTextBox(gp,vs1);
					nav1.SaveRow(vs1.Row);		
				}
				catch( Exception){}
			}
			
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
			TextBoxAndVS.L_GetLabelFromVS(gp,vs1);
			TextBoxAndVS.L_GetLabelFromVS(gp1,vs1);
			S_EMP_I1.Text=label4.Text;
			S_EMP_ID.Text=label3.Text;
			S_CRD_NO.Text=label23.Text;
			S_EMP_NM.Text=label2.Text;	
			ToolTip t1=new ToolTip();
			t1.SetToolTip(cmd_family,PublicFunction.L_GetLabel(this.Name,16));
			t1.SetToolTip(cmd_salary,PublicFunction.L_GetLabel(this.Name,17));			
			t1.SetToolTip(cmd_visa,PublicFunction.L_GetLabel(this.Name,18));			
			Init_LabelForMenu();
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
						return;
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
				txt_CRD_NO.Focus();
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
		
		private void S_EMP_ID_Leave(object sender, System.EventArgs e)
		{
			if (S_EMP_ID.Text=="")
				S_EMP_ID.Text=label3.Text;
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
				sql= ((TextBox)sender).Tag+sql+" and (DEL_BT is null or DEL_BT=0) and DEP_ID in "+T_String.DEP_ID(this.Tag)+" and "+PublicFunction.Get_TYP(this.Tag,"");					
				nav.Show_VS(sql);				
				ShowData();				 	 
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
					GP8000.Personnel.FormRPT.frmTaPrintWID dlg=new GP8000.Personnel.FormRPT.frmTaPrintWID();
					dlg.Tag=this.Tag;
					if(vs.Row>0)
						dlg.stf=vs.Rows[vs.Row]["EMP_ID"]+"";
						
					if(dlg.ShowDialog(this)==DialogResult.OK)
					{
						//sql="Select  * from FILB01A a,FILA02A b,FILA07A c, FILB01AB d where a.DEP_ID=b.DEP_ID and a.POS_ID=c.POS_ID and a.EMP_ID=d.EMP_ID";
						rpt.WID(dlg.sql,PublicFunction.DT_server,PublicFunction.DT_database,PublicFunction.DT_username,PublicFunction.DT_password, T_String.IsNullTo0(PublicFunction.CUS_ID) );
						
					}
					break;
				case 1:		
					GP8000.Personnel.FormRPT.frmTaPrintWID dlg1=new GP8000.Personnel.FormRPT.frmTaPrintWID();
					if(vs.Row>0)
						dlg1.stf=vs.Rows[vs.Row]["EMP_ID"]+"";
					dlg1.Tag=this.Tag;
					dlg1.ck.Visible=false;
					dlg1.p1.Visible=false;
					if(dlg1.ShowDialog(this)==DialogResult.OK)
					{
						BDF(dlg1.sql);
						
					}
					break;
			}
		}
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

		private void BDF(string sql1)
		{
			// create pdf document
			_c1pdf.Clear();
			_c1pdf.DocumentInfo.Title = this.Text;
			_c1pdf.PaperKind=System.Drawing.Printing.PaperKind.A4;
						
			// calculate page rect (discounting margins)
			RectangleF rcPage = GetPageRect();
			RectangleF rc = rcPage;

			// add title
			Font titleFont = new Font("Tahoma", 24, FontStyle.Bold);		
			_c1pdf.DrawString(this.Text,titleFont, Brushes.Black, rc);
			rc.Height = _c1pdf.MeasureString("Staff", titleFont, rc.Width).Height;
			rc.Offset(0, rc.Height);


			string sql=sql1;
			Func.RecordSet rs=new Func.RecordSet(sql,PublicFunction.C_con);
			Font txtFont = new Font("Tahoma", 10);
			Font hdrFont = new Font("Tahoma", 12,FontStyle.Bold);
			string []f1=new string[5];
			f1[0]=PublicFunction.L_GetLabel_VS(this.Name+"_vs","EMP_ID");
			f1[1]=PublicFunction.L_GetLabel_VS(this.Name+"_vs","EMP_NM");
			f1[2]=PublicFunction.L_GetLabel_VS(this.Name+"_vs","DEP_ID");
			f1[3]=PublicFunction.L_GetLabel_VS(this.Name+"_vs","POS_ID"); 	
			f1[4]=PublicFunction.L_GetLabel_VS(this.Name+"_vs","PIC_DR");
	
			rc = RenderTableHeader(hdrFont, rc, f1);
			for(int i=0;i<rs.rows;i++)
			{
				string []f=new string[5];
				f[0]=rs.record(i,"EMP_ID");
				f[1]=rs.record(i,"EMP_NM");
				f[2]=rs.record(i,"DEP_NM");
				f[3]=rs.record(i,"POS_NM");		
				f[4]="";	
				rc=RenderTableRow(txtFont,hdrFont,rcPage, rc, f1,f);
			}
			AddFooters();
			
			string fileName = Path.GetDirectoryName(Application.ExecutablePath) + @"\staff.pdf";
			_c1pdf.Save(fileName);
			Process.Start(fileName);		
		}

		private void AddFooters()
		{
			Font fontHorz = new Font("Tahoma", 7, FontStyle.Bold);
			Font fontVert = new Font("Viner Hand ITC", 14, FontStyle.Bold);
			
			StringFormat sfRight = new StringFormat();
			sfRight.Alignment = StringAlignment.Far;

			StringFormat sfVert  = new StringFormat();
			sfVert.FormatFlags |= StringFormatFlags.DirectionVertical;
			sfVert.Alignment = StringAlignment.Center;

			for (int page = 0; page < _c1pdf.Pages.Count; page++)
			{
				// select page we want (could change PageSize)
				_c1pdf.CurrentPage = page;

				// build rectangles for rendering text
				RectangleF rcPage = GetPageRect();
				RectangleF rcFooter = rcPage;
				rcFooter.Y = rcFooter.Bottom + 6;
				rcFooter.Height = 12;
				RectangleF rcVert = rcPage;
				rcVert.X = rcPage.Right + 6;

				//				// add left-aligned footer
								string text = _c1pdf.DocumentInfo.Title;
				//				_c1pdf.DrawString(text, fontHorz, Brushes.Gray, rcFooter);

								// add right-aligned footer
								text = string.Format("Page {0} of {1}", page+1, _c1pdf.Pages.Count);
								_c1pdf.DrawString(text, fontHorz, Brushes.Gray, rcFooter, sfRight);

				//				// add vertical text
				//				text = _c1pdf.DocumentInfo.Title + " (document created using the C1Pdf .NET component)";
				//				_c1pdf.DrawString(text, fontVert, Brushes.LightGray, rcVert, sfVert);

				// draw lines on bottom and right of the page
				_c1pdf.DrawLine(Pens.Gray, rcPage.Left, rcPage.Bottom, rcPage.Right, rcPage.Bottom);
//				_c1pdf.DrawLine(Pens.Gray, rcPage.Right, rcPage.Top, rcPage.Right, rcPage.Bottom);
			}
		}

		private RectangleF RenderTableRow(Font font, Font hdrFont, RectangleF rcPage, RectangleF rc, string[] fields, string[] fields1)
		{
			// calculate cell width (same for all columns)
			RectangleF rcCell = rc;
			rcCell.Width = rc.Width / fields.Length;
			rcCell.Height = 0;

			// calculate cell height (max of all columns)
			rcCell.Inflate(-4, 0);
			foreach (string field in fields1)
			{
				string text = field;
//				float height = _c1pdf.MeasureString(text, font, rcCell.Width).Height;
//				rcCell.Height = Math.Max(rcCell.Height, height);
			}

			//float height = 50;
			rcCell.Height = 50;
			
			rcCell.Inflate(4, 0);

			// break page if we have to
			if (rcCell.Bottom > rcPage.Bottom)
			{
				_c1pdf.NewPage();
				rc = RenderTableHeader(hdrFont, rcPage, fields);
				rcCell.Y = rc.Y;
			}

			// center vertically just to show how
			StringFormat sf = new StringFormat();
			sf.LineAlignment = StringAlignment.Center;

			// render data cells
			Pen pen = new Pen(Brushes.Gray, 0.1f);
			int i=0;
			foreach (string field in fields1)
			{
				i++;
				// get content
				string text = field;

				// set horizontal alignment
				double d;
				sf.Alignment = (double.TryParse(text, NumberStyles.Any, CultureInfo.CurrentCulture, out d))
					? StringAlignment.Far
					: StringAlignment.Near;

				// render cell
				_c1pdf.DrawRectangle(pen, rcCell);
				rcCell.Inflate(-4, 0);
				if(i==5)
				{
					Image img=ImageFunction.LoadImageFromSQL("Select PIC_DR from FILB01AB where EMP_ID=N'"+
						fields1[0]+"'");
					_c1pdf.DrawImage(img, rcCell, ContentAlignment.MiddleCenter, ImageSizeModeEnum.Scale);
				}
				else
				{
					_c1pdf.DrawString(text, font, Brushes.Black, rcCell, sf);
				}
				rcCell.Inflate(4, 0);
				rcCell.Offset(rcCell.Width, 0);
			}
			pen.Dispose();

			// update rectangle and return it
			rc.Offset(0, rcCell.Height);
			return rc;
		}
		private RectangleF RenderTableHeader(Font font, RectangleF rc, string[] fields)
		{
			// calculate cell width (same for all columns)
			RectangleF rcCell = rc;
			rcCell.Width = rc.Width / fields.Length;
			rcCell.Height = 0;

			// calculate cell height (max of all columns)
			foreach (string field in fields)
			{
				float height = _c1pdf.MeasureString(field, font, rcCell.Width).Height;
				rcCell.Height = Math.Max(rcCell.Height, height);
			}

			// render header cells
			foreach (string field in fields)
			{
				_c1pdf.FillRectangle(Brushes.Black, rcCell);
				_c1pdf.DrawString(field, font, Brushes.White, rcCell);
				rcCell.Offset(rcCell.Width, 0);
			}

			// update rectangle and return it
			rc.Offset(0, rcCell.Height);
			return rc;
		}

		internal RectangleF GetPageRect()
		{
			RectangleF rcPage = _c1pdf.PageRectangle;
			rcPage.Inflate(-72, -72);
			return rcPage;
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
					if (dlg.DialogResult==DialogResult.Cancel )
					{
						txt_CRD_ID.Text =vs.Rows[vs.Row]["CRD_ID"]+"";						
					}
				}
			}
		}

		private void btem_Click(object sender, System.EventArgs e)
		{

// cach 2
			SmtpMail oMail = new SmtpMail("TryIt");
			SmtpClient oSmtp = new SmtpClient();
        
			// Your yahoo email address
			oMail.From = "mooncakebtt@gmail.com";

			// Set recipient email address
			oMail.To = "minhtri_huflit@yahoo.com.vn";
            oMail.Cc ="trung_thu@glinton.com.tw; eric_chi@glinton.com.tw";
			// Set email subject
			oMail.Subject = "test email from gmail account";
            
			// Set email body
			oMail.TextBody = "this is a test email sent from c# project with gmail.";
			String sFile = @"D:\Schema.txt"; 
			
			// Yahoo SMTP server address
			SmtpServer oServer = new SmtpServer("smtp.gmail.com"); //smtp.mail.yahoo.com

			// For example: your email is "myid@yahoo.com", then the user should be "myid@yahoo.com"
			oServer.User = "mooncakebtt@gmail.com";
			oServer.Password = "nhknttt26082701";

			// Set 25 port, if you want to use 587 port, please change 25 to 587
			//oServer.Port = 25;
            
			// detect SSL/TLS type automatically
			oServer.ConnectType = SmtpConnectType.ConnectSSLAuto;

			try
			{
				oMail.AddAttachment(sFile); 
				MessageBox.Show("start to send email over SSL ...");
				oSmtp.SendMail(oServer, oMail);
				MessageBox.Show("email was sent successfully!");
			}
			catch (Exception ep)
			{
				MessageBox.Show("failed to send email with the following error:");
				MessageBox.Show(ep.Message);
			}		
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			if(vs.Row>0)
			{
				frmTaGraduationHistory dlg=new frmTaGraduationHistory(vs.Rows[vs.Row]["EMP_ID"]+"",vs);		
				dlg.Tag=84;
				dlg.ShowDialog();
				cb_GRA_ID.Text =dlg.GRA_ID ;
				vs.Rows[vs.Row]["ACC_NO"]=dlg.GRA_ID  ;				
			}
		}

		private void btn_UpdateGGM_Click(object sender, System.EventArgs e)
		{
			string s1="";
			string s="",sdata="";
			if (vs.Rows.Count<=1)
			{
				MessageBox.Show("No datta !");
			}
			else
			{
				for(int i=1 ;i< vs.Rows.Count ;i++)
				{
					sdata="'"+vs.Rows[i]["EMP_ID"]+"','"+vs.Rows[i]["EMP_NM"]+"','"+vs.Rows[i]["EMP_N1"]+"',";
					if(vs.Rows[i]["SEX_BT"]+""=="True")
						sdata+=1;
					else
						sdata+=0;
					s1=T_String.GetDataFromSQL("VAC_DT","FILB01AC","EMP_ID='"+vs.Rows[i]["EMP_ID"]+"'");
					sdata+=",'"+vs.Rows[i]["DEP_ID"]+"','"+vs.Rows[i]["CRD_ID"]+"','";
					sdata+=vs.Rows[i]["TEL_NO"]+"','"+vs.Rows[i]["ADD_DR"]+"','"+vs.Rows[i]["ACC_NO"]+"','','"+DateTime.Parse( vs.Rows[i]["INH_DT"]+"").ToString("yyyy/MM/dd")+"')";
					/// udate or insert
					/// 
					Func.RecordSet rsGGM=new Func.RecordSet("SELECT * FROM FC05A WHERE EMP_ID='"+vs.Rows[i]["EMP_ID"]+"'",PublicFunction.C_conGGM);
					if(T_String.GetDataFromSQL("EMP_ID","FC05A","EMP_ID='"+vs.Rows[i]["EMP_ID"]+"'",PublicFunction.C_conGGM)==null || rsGGM.rows <=0)
					{
						s="INSERT INTO FC05A (EMP_ID,EMP_NM,ENG_NM,SEX_ID,DEP_ID,PER_ID,TEL_NO,ADD_DR,ACC_NO,OUT_DT,INT_DT) VALUES (";
						s+=sdata;
					}
					else
					{
						s="UPDATE FC05A SET EMP_NM='"+T_String.sqlsql(vs.Rows[i]["EMP_NM"]+"")+"',";
						s=s+"SEX_ID='";
						if(vs.Rows[i]["SEX_BT"]+""=="True")
							s+=1;
						else
							s+=0;
						s=s+"',PER_ID='"+vs.Rows[i]["CRD_ID"]+"'";
						s+=" WHERE EMP_ID='"+vs.Rows[i]["EMP_ID"]+"'";
					}
					PublicFunction.SQL_Execute(s,PublicFunction.C_conGGM);

				}
				MessageBox.Show(" Succeeded !");				
			}



//			string s1="";
//			string s="",sdata="";
//			if (vs.Rows.Count==1 || (int)vs.Rows[vs.Rows.Count-1].UserData!=2)
//			{
//				sdata="'"+vs.Rows[vs.Row]["EMP_ID"]+"','"+vs.Rows[vs.Row]["EMP_NM"]+"','"+vs.Rows[vs.Row]["EMP_N1"]+"',";
//				if(vs.Rows[vs.Row]["SEX_BT"]+""=="True")
//					sdata+=1;
//				else
//					sdata+=0;
//				s1=T_String.GetDataFromSQL("VAC_DT","FILB01AC","EMP_ID='"+vs.Rows[vs.Row]["EMP_ID"]+"'");
//				sdata+=",'"+vs.Rows[vs.Row]["DEP_ID"]+"','"+vs.Rows[vs.Row]["CRD_ID"]+"','"+DateTime.Parse( vs.Rows[vs.Row]["BIR_DT"]+"").ToString("yyyy/MM/dd")+"','";
//				sdata+=vs.Rows[vs.Row]["TEL_NO"]+"','"+vs.Rows[vs.Row]["ADD_DR"]+"','"+vs.Rows[vs.Row]["ACC_NO"]+"','','"+DateTime.Parse( vs.Rows[vs.Row]["INH_DT"]+"").ToString("yyyy/MM/dd")+"')";
//				/// udate or insert
//				/// 
//				Func.RecordSet rsGGM=new Func.RecordSet("SELECT * FROM FC05A WHERE EMP_ID='"+vs.Rows[vs.Row]["EMP_ID"]+"'",PublicFunction.C_conGGM);
//				if(T_String.GetDataFromSQL("EMP_ID","FC05A","EMP_ID='"+vs.Rows[vs.Row]["EMP_ID"]+"'",PublicFunction.C_conGGM)==null || rsGGM.rows <=0)
//				{
//					s="INSERT INTO FC05A (EMP_ID,EMP_NM,ENG_NM,SEX_ID,DEP_ID,PER_ID,BIR_DT,TEL_NO,ADD_DR,ACC_NO,OUT_DT,INT_DT) VALUES (";
//					s+=sdata;
//				}
//				else
//				{
//					s="UPDATE FC05A SET EMP_NM='"+T_String.sqlsql(vs.Rows[vs.Row]["EMP_NM"]+"")+"',";
//					s=s+"SEX_ID='";
//					if(vs.Rows[vs.Row]["SEX_BT"]+""=="True")
//						s+=1;
//					else
//						s+=0;
//					s=s+"',PER_ID='"+vs.Rows[vs.Row]["CRD_ID"]+"'";
//					s+=" WHERE EMP_ID='"+vs.Rows[vs.Row]["EMP_ID"]+"'";
//				}
//				PublicFunction.SQL_Execute(s,PublicFunction.C_conGGM);
//			}
		

//    		string databasename=PublicFunction.GetOption("GGMDATABASE");
////			//string sql1="Delete " + databasename+ ".dbo.FC05A where EMP_Id in (select EMP_ID from FILB01A";
////			//PublicFunction.SQL_Execute(sql1,PublicFunction.C_conGGM);
////
//			string sql="INSERT INTO " + databasename+ ".dbo.FC05A(EMP_ID,EMP_NM,ENG_NM,SEX_ID,DEP_ID,PER_ID,BIR_DT,TEL_NO,ADD_DR,ACC_NO,OUT_DT,INT_DT)";
//            sql+=" select EMP_ID,EMP_NM,EMP_N1,CASE WHEN SEX_BT='1' THEN 1 ELSE 0 END,DEP_ID,CRD_ID,Convert(varchar(10),CONVERT(date,eDOB,103),103),TEL_NO,ADD_DR,ACC_NO,'',INH_DT from FILB01A ";
//            sql+=" where EMP_ID not in (select EMP_ID from " + databasename+ ".dbo.FC05A)";
//            PublicFunction.SQL_Execute(sql,PublicFunction.C_con);
////			
////		
//
//			string sql1="Update " + databasename+ ".dbo.FC05A set EMP_NM=select EMP_NM from FILB01A where " + databasename+ ".dbo.FC05A.EMP_ID=FILB01A.EMP_ID";
//			PublicFunction.SQL_Execute(sql1,PublicFunction.C_con);
//
//			string sql2="Update " + databasename+ ".dbo.FC05A set ENG_NM=select EMP_N1 from FILB01A where " + databasename+ ".dbo.FC05A.EMP_ID=FILB01A.EMP_ID";
//			PublicFunction.SQL_Execute(sql2,PublicFunction.C_con);
//
//			string sql3="Update " + databasename+ ".dbo.FC05A set SEX_ID=select SEX_BT from FILB01A where " + databasename+ ".dbo.FC05A.EMP_ID=FILB01A.EMP_ID";
//			PublicFunction.SQL_Execute(sql3,PublicFunction.C_con);
//
//			string sql4="Update " + databasename+ ".dbo.FC05A set DEP_ID=select DEP_ID from FILB01A where " + databasename+ ".dbo.FC05A.EMP_ID=FILB01A.EMP_ID";
//			PublicFunction.SQL_Execute(sql4,PublicFunction.C_con);
//
//			string sql5="Update " + databasename+ ".dbo.FC05A set PER_ID=select CRD_ID from FILB01A where " + databasename+ ".dbo.FC05A.EMP_ID=FILB01A.EMP_ID";
//			PublicFunction.SQL_Execute(sql5,PublicFunction.C_con);
//
//			string sql6="Update " + databasename+ ".dbo.FC05A set BIR_DT=select BIR_DT from FILB01A where " + databasename+ ".dbo.FC05A.EMP_ID=FILB01A.EMP_ID";
//			PublicFunction.SQL_Execute(sql6,PublicFunction.C_con);
//
//			string sql7="Update " + databasename+ ".dbo.FC05A set TEL_NO=select TEL_NO from FILB01A where " + databasename+ ".dbo.FC05A.EMP_ID=FILB01A.EMP_ID";
//			PublicFunction.SQL_Execute(sql7,PublicFunction.C_con);
//
//			string sql8="Update " + databasename+ ".dbo.FC05A set ADD_DR=select ADD_DR from FILB01A where " + databasename+ ".dbo.FC05A.EMP_ID=FILB01A.EMP_ID";
//			PublicFunction.SQL_Execute(sql8,PublicFunction.C_con);
//
//			string sql9="Update " + databasename+ ".dbo.FC05A set ACC_NO=select ACC_NO from FILB01A where " + databasename+ ".dbo.FC05A.EMP_ID=FILB01A.EMP_ID";
//			PublicFunction.SQL_Execute(sql9,PublicFunction.C_con);
//
//			string sql10="Update " + databasename+ ".dbo.FC05A set INT_DT=select INH_DT from FILB01A where " + databasename+ ".dbo.FC05A.EMP_ID=FILB01A.EMP_ID";
//			PublicFunction.SQL_Execute(sql10,PublicFunction.C_con);
//////
//
//          MessageBox.Show(PublicFunction.L_Get_Msg("Staff",1));

//			string sql= "INSERT INTO FC05A(EMP_ID,EMP_NM,ENG_NM,SEX_ID,DEP_ID,PER_ID,BIR_DT,TEL_NO,ADD_DR,ACC_NO,OUT_DT,INT_DT) VALUES (";
//            sql+="select EMP_ID,EMP_NM,ENG_N1,SEX_ID,DEP_ID,PER_ID,BIR_DT,TEL_NO,ADD_DR,ACC_NO,'',INT_DT";
		}			
	}
}


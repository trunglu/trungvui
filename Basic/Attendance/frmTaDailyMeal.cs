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
using GP8000.Function;
namespace GP8000.Attendance
{
	/// <summary>
	/// Summary description for frmTaMonthSubsidy.
	/// </summary>
	public class frmTaDailyMeal : System.Windows.Forms.Form
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
		private C1.Win.C1FlexGrid.C1FlexGrid vs;
		private System.Windows.Forms.Panel panel5;
		Func.RecordSet rs1,rs2;
		private System.Windows.Forms.Label label1;
		private C1.Win.C1Input.C1DateEdit dt1;
		private System.Windows.Forms.Label label4;
		private C1.Win.C1Input.C1DateEdit dt2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt1;
		private System.Windows.Forms.TextBox txt2;
		private System.Windows.Forms.Button cmd_cal;
		private System.Windows.Forms.CheckBox ck;
		private System.Windows.Forms.Button cmdEdit;
		private System.Windows.Forms.Button cmdCancel;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaDailyMeal()
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
			this.panel5 = new System.Windows.Forms.Panel();
			this.cmd_cal = new System.Windows.Forms.Button();
			this.txt2 = new System.Windows.Forms.TextBox();
			this.txt1 = new System.Windows.Forms.TextBox();
			this.dt2 = new C1.Win.C1Input.C1DateEdit();
			this.label2 = new System.Windows.Forms.Label();
			this.ck = new System.Windows.Forms.CheckBox();
			this.dt1 = new C1.Win.C1Input.C1DateEdit();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.vs = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.nav = new Navigator1._0.NavigatorAuto();
			this.cmdEdit = new System.Windows.Forms.Button();
			this.cmdCancel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandDock1)).BeginInit();
			this.c1CommandDock1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).BeginInit();
			this.c1DockingTab1.SuspendLayout();
			this.c1DockingTabPage1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dt2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dt1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// c1CommandDock1
			// 
			this.c1CommandDock1.Controls.Add(this.c1DockingTab1);
			this.c1CommandDock1.Dock = System.Windows.Forms.DockStyle.Left;
			this.c1CommandDock1.Id = 1;
			this.c1CommandDock1.Location = new System.Drawing.Point(0, 0);
			this.c1CommandDock1.Name = "c1CommandDock1";
			this.c1CommandDock1.Size = new System.Drawing.Size(244, 496);
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
			this.c1DockingTab1.Size = new System.Drawing.Size(244, 496);
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
			this.c1DockingTabPage1.Size = new System.Drawing.Size(239, 494);
			this.c1DockingTabPage1.TabIndex = 0;
			this.c1DockingTabPage1.Text = "Page1";
			// 
			// Dep
			// 
			this.Dep.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Dep.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Dep.Location = new System.Drawing.Point(0, 23);
			this.Dep.Name = "Dep";
			this.Dep.Size = new System.Drawing.Size(239, 471);
			this.Dep.TabIndex = 3;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(244, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(980, 496);
			this.panel1.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.panel5);
			this.panel2.Controls.Add(this.vs);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 36);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(980, 460);
			this.panel2.TabIndex = 7;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.Moccasin;
			this.panel5.Controls.Add(this.cmd_cal);
			this.panel5.Controls.Add(this.txt2);
			this.panel5.Controls.Add(this.txt1);
			this.panel5.Controls.Add(this.dt2);
			this.panel5.Controls.Add(this.label2);
			this.panel5.Controls.Add(this.ck);
			this.panel5.Controls.Add(this.dt1);
			this.panel5.Controls.Add(this.label4);
			this.panel5.Controls.Add(this.label1);
			this.panel5.Controls.Add(this.cmdCancel);
			this.panel5.Controls.Add(this.cmdEdit);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel5.Location = new System.Drawing.Point(0, 0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(980, 32);
			this.panel5.TabIndex = 12;
			// 
			// cmd_cal
			// 
			this.cmd_cal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmd_cal.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_cal.Location = new System.Drawing.Point(728, 4);
			this.cmd_cal.Name = "cmd_cal";
			this.cmd_cal.Size = new System.Drawing.Size(100, 24);
			this.cmd_cal.TabIndex = 161;
			this.cmd_cal.Text = "Cal";
			this.cmd_cal.Click += new System.EventHandler(this.cmd_cal_Click);
			// 
			// txt2
			// 
			this.txt2.BackColor = System.Drawing.Color.PeachPuff;
			this.txt2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt2.Location = new System.Drawing.Point(520, 4);
			this.txt2.MaxLength = 20;
			this.txt2.Name = "txt2";
			this.txt2.Size = new System.Drawing.Size(96, 23);
			this.txt2.TabIndex = 160;
			this.txt2.Tag = "EMP_I1";
			this.txt2.Text = "";
			this.txt2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
			this.txt2.TextChanged += new System.EventHandler(this.txt2_TextChanged);
			// 
			// txt1
			// 
			this.txt1.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt1.Location = new System.Drawing.Point(412, 4);
			this.txt1.MaxLength = 20;
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(96, 23);
			this.txt1.TabIndex = 159;
			this.txt1.Tag = "EMP_ID";
			this.txt1.Text = "";
			this.txt1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
			this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
			// 
			// dt2
			// 
			this.dt2.CustomFormat = "yyyy/MM/dd";
			this.dt2.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt2.Location = new System.Drawing.Point(276, 4);
			this.dt2.Name = "dt2";
			this.dt2.Size = new System.Drawing.Size(120, 23);
			this.dt2.TabIndex = 158;
			this.dt2.Tag = null;
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label2.Location = new System.Drawing.Point(232, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 23);
			this.label2.TabIndex = 157;
			this.label2.Tag = "";
			this.label2.Text = "date";
			// 
			// ck
			// 
			this.ck.Checked = true;
			this.ck.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ck.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ck.Location = new System.Drawing.Point(8, 8);
			this.ck.Name = "ck";
			this.ck.Size = new System.Drawing.Size(20, 16);
			this.ck.TabIndex = 156;
			this.ck.Tag = "N";
			this.ck.CheckedChanged += new System.EventHandler(this.ck_CheckedChanged);
			// 
			// dt1
			// 
			this.dt1.CustomFormat = "yyyy/MM/dd";
			this.dt1.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt1.Location = new System.Drawing.Point(72, 4);
			this.dt1.Name = "dt1";
			this.dt1.Size = new System.Drawing.Size(120, 23);
			this.dt1.TabIndex = 155;
			this.dt1.Tag = null;
			this.dt1.TextChanged += new System.EventHandler(this.dt1_TextChanged);
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label4.Location = new System.Drawing.Point(28, 8);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 23);
			this.label4.TabIndex = 154;
			this.label4.Tag = "";
			this.label4.Text = "date";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(200, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(28, 16);
			this.label1.TabIndex = 153;
			this.label1.Tag = "N";
			this.label1.Text = "-->";
			// 
			// vs
			// 
			this.vs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.vs.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs.Location = new System.Drawing.Point(6, 36);
			this.vs.Name = "vs";
			this.vs.Size = new System.Drawing.Size(968, 420);
			this.vs.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs.TabIndex = 11;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.panel4);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(980, 36);
			this.panel3.TabIndex = 6;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Location = new System.Drawing.Point(416, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(564, 36);
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
			this.nav.Location = new System.Drawing.Point(0, 2);
			this.nav.MSG_Exit = false;
			this.nav.MulltiDel = false;
			this.nav.Name = "nav";
			this.nav.Security = 0;
			this.nav.ShowPopupMenu = true;
			this.nav.Size = new System.Drawing.Size(416, 32);
			this.nav.TabIndex = 10;
			this.nav.Tag = "";
			this.nav.ToolBar_Auto = true;
			this.nav.UserID = null;
			this.nav.VisibleGrid = true;
			this.nav.Where = null;
			this.nav.Load += new System.EventHandler(this.nav_Load);
			// 
			// cmdEdit
			// 
			this.cmdEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdEdit.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmdEdit.Location = new System.Drawing.Point(844, 4);
			this.cmdEdit.Name = "cmdEdit";
			this.cmdEdit.Size = new System.Drawing.Size(100, 24);
			this.cmdEdit.TabIndex = 162;
			this.cmdEdit.Text = "Edit";
			this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click);
			// 
			// cmdCancel
			// 
			this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmdCancel.Location = new System.Drawing.Point(844, 4);
			this.cmdCancel.Name = "cmdCancel";
			this.cmdCancel.Size = new System.Drawing.Size(100, 24);
			this.cmdCancel.TabIndex = 163;
			this.cmdCancel.Text = "Cancel";
			this.cmdCancel.Visible = false;
			this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
			// 
			// frmTaDailyMeal
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(1224, 496);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.c1CommandDock1);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaDailyMeal";
			this.Text = "frmTaDailyMeal";
			this.Load += new System.EventHandler(this.frmTaDailyMeal_Load);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandDock1)).EndInit();
			this.c1CommandDock1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).EndInit();
			this.c1DockingTab1.ResumeLayout(false);
			this.c1DockingTabPage1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dt2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dt1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaDailyMeal_Load(object sender, System.EventArgs e)
		{ 
			MessageBox.Show("a");
			vs.Rows[0].HeightDisplay= vs.Rows[0].HeightDisplay*3;
			//vs.Styles["Fixed"].WordWrap=true;
			Init_Form();		
			dt2.Value=dt1.Value=T_String.GetDate();
			vs.Cols["MEAL_DT"].Format=dt1.CustomFormat=dt2.CustomFormat=PublicFunction.GetOption("DATE");
			nav.cmd_search.Visible=false;
			nav.cmd_copy.Visible=false;
			nav.cmd_delete.Visible=false;	
			nav.cmd_add.Visible=false;
			nav.cmd_report.Visible=false;
			//Basic.Function.PublicFunction.L_Init_Label(this);	
			Set_w();
			//Init_Menu();
			//Set_LB();
		}
		#region Init_menu
		private ContextMenu mnu1;
		private void Init_Menu()
		{			
			mnu1=new ContextMenu();
			nav.cmd_report.Style=ToolBarButtonStyle.DropDownButton;
			nav.cmd_report.DropDownMenu =mnu1;
			//int n=T_String.IsNullTo0(T_String.GetDataFromSQL("Count(*)","SYS_LABEL_PMENU","NAME=N'"+this.Name+"'"));
			//Init_ReportSTD(n);					
			//Init_LabelForMenu();			
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
					rpt.RPT2(c1XLBook1,vs,mnu1.MenuItems[mnu1.MenuItems.IndexOf((MenuItem)sender)].Text,"STD_TA_05");					
					break;
				
			}
		}
		#endregion			
		#region Init Form
		private void Init_Form()
		{					
			Dep.Init_Tree(this.Tag+"");
			Dep.Show_Tree();	
			Dep.vs1.AfterRowColChange+=new C1.Win.C1FlexGrid.RangeEventHandler(Depvs1_AfterRowColChange);	
			Dep.vs1.KeyDown+=new KeyEventHandler(Dep_KeyDown);			
			Init_vs();		
			InitCB();			
			Basic.Function.PublicFunction.L_Init_Label(this);							
		}
		private void Init_vs()
		{			
			PublicFunction.InitNav(this,vs,nav);			
			//nav.Init_Control();
			vs.AllowEditing=false;
			
			vs.Tag="";		
			vs.Cols.Frozen=vs.Cols["DEP_ID"].Index;
			for(int i=1;i<=10;i++)
			{
				vs.Cols["ONN_"+i.ToString("00")].Format="#0:00";
				vs.Cols["OFF_"+i.ToString("00")].Format="#0:00";
			}	
			string sql="Select TYP_ID from GP_SYS_SHIFT";
			rs1=new Func.RecordSet(sql,PublicFunction.C_con);
			for(int i=0;i<rs1.rows;i++)
			{	
				try
				{
					vs.Cols[rs1.record(i,0)].Format="#0:00";
				}
				catch{}
			}	
			vs.Cols["EMP_I1"].Style.BackColor=Color.PeachPuff;
			vs.Cols["EMP_NM"].Style.BackColor=Color.PeachPuff;
			vs.Cols["DEP_ID"].Style.BackColor=Color.PeachPuff;
			vs.Cols["DEP_ID"].Style.BackColor=Color.PeachPuff;
			vs.Cols["MEAL_DT"].Style.BackColor=Color.PeachPuff;
			vs.Cols["SHI_ID"].Style.BackColor=Color.PeachPuff;
			vs.Cols["LOCK_BT"].Style.BackColor=Color.PaleGreen;
			vs.Cols["USR_NM"].Style.BackColor=Color.PaleGreen;
			vs.Cols["USR_NM"].Width=45;
			vs.SelectionMode=C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;						
//			vs.EnabledChanged+=new EventHandler(vs_EnabledChanged);
			//vs.KeyDown+=new KeyEventHandler(vs_KeyDown);
			nav.ToolBar_Auto=false;
			
			vs.SelectionMode=C1.Win.C1FlexGrid.SelectionModeEnum.CellRange; 

			nav.TBarClick+=new ToolBarButtonClickEventHandler(nav_TBarClick);
			vs.BeforeEdit+=new C1.Win.C1FlexGrid.RowColEventHandler(vs_BeforeEdit);
			vs.AfterEdit+=new C1.Win.C1FlexGrid.RowColEventHandler(vs_AfterEdit);	
		}	

		private void nav_TBarClick(object sender, ToolBarButtonClickEventArgs e)
		{
			if (e.Button.Equals(nav.cmd_refresh))
			{
				vs.AllowEditing=false;
				cmdCancel.Visible=false;
				cmdEdit.Visible=true;
				Show_VS();
				return;
			}
			
			if (e.Button.Equals(nav.cmd_save))
			{
				

				vs.AllowEditing=false;
				cmdCancel.Visible=false;
				cmdEdit.Visible=true;

			}
			nav.ToolBar_Click(e);
		}
		private void InitCB()
		{
			string sql;			
			//Department
			sql=PublicFunction.GetDep(this.Tag+"");			
			vs.Cols["DEP_ID"].DataMap=PublicFunction.InitCBForVS(sql);	
			//			vs.Cols["DEP_I1"].DataMap=PublicFunction.InitCBForVS(sql);			
		}
		#endregion
		#region ShowData
		private void Show_VS()
		{
			string sql;
			if(Dep.vs1.Row<0)
			{
				vs.Rows.Count=1;
				return;
			}
			if(txt1.Text+""!="")					
				sql=" a.EMP_ID like N'%"+txt1.Text+"%'";
			else if(txt2.Text+""!="")					
				sql=" a.EMP_I1 like N'%"+txt2.Text+"%'";
			else
				sql=" 1=1";
			string dk=Dep.Get_Data("DEP_ID");
				
			if(dk+""!="")
				sql=sql+" and b.DEP_ID=N'"+dk+"'";				
			else
				sql=sql+" and b.DEP_ID in "+T_String.DEP_ID(this.Tag)+" ";
			
			if(ck.Checked)
				sql=sql+" and  (DEL_BT=0 or DEL_BT is null) and "
					+"(MEAL_DT Between '"+((DateTime)dt1.Value).ToString("yyyy/MM/dd")+"' and '"
					+((DateTime)dt2.Value).ToString("yyyy/MM/dd")+"') "
					+" and b.DEP_ID in (Select DEP_ID  from SYS_SECURITY_DEP"+
					" where MNU_ID="+this.Tag+" and ALL_BT=1 and USER_ID=N'"+PublicFunction.A_UserID+"')";
			else
				sql=sql+" and  (DEL_BT=0 or DEL_BT is null) and b.DEP_ID in (Select DEP_ID  from SYS_SECURITY_DEP"+
					" where MNU_ID="+this.Tag+" and ALL_BT=1 and USER_ID=N'"+PublicFunction.A_UserID+"')";

			nav.Show_VS(sql);	
			CheckCols();
		}					
		private void CheckCols()
		{
			
			Set_w();
		}
		private void Depvs1_AfterRowColChange(object sender, C1.Win.C1FlexGrid.RangeEventArgs e)
		{
			if(e.OldRange.r1!=e.NewRange.r1)
			{
				Show_VS();
			}
		}
		private void vs_EnabledChanged(object sender, EventArgs e)
		{
			Basic.Function.PublicFunction.L_Init_Label(vs,this.Name+"_vs");							
			//			txt1.Text=vs.Cols[txt1.Tag+""].Caption;
			//			txt2.Text=vs.Cols[txt2.Tag+""].Caption;			
			//Set_LB();
			nav.Init_PMenu_Color();
		}
		
		private void vs_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
//			if(vs.Rows[e.Row]["LOCK_BT"]+""=="True")
//			{
//				if(PublicFunction.A_UserID!= vs.Rows[e.Row]["USR_NM"]+"" || vs.Cols[e.Col].Name!="LOCK_BT")
//					e.Cancel=true;
////					vs.AllowEditing=false;
//			}
//			else
//			{
//				if(vs.Cols[e.Col].Name!="LOCK_BT" && vs.Tag+""=="")
//				{
//					e.Cancel=true;
////					vs.AllowEditing=false;
//				}
//				else
//				{
//					e.Cancel=false;
////					vs.AllowEditing=true;
//				}
//			}
		}

		private void vs_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{			
			if(vs.Cols[e.Col].Name=="LOCK_BT" && e.Row>0)
			{
				if(vs.Rows[e.Row]["LOCK_BT"]+""=="True")
				{
					vs.Rows[e.Row]["USR_NM"]=PublicFunction.A_UserID;
				}
				else
				{
					vs.Rows[e.Row]["USR_NM"]="";
				}				
			}
			string sql="";
			int tam=0;
			for (int i=vs.Selection.r1;i<=vs.Selection.r2;i++)
			{				
				if (vs.Rows[i]["LOCK_BT"]+""!="True")
				{
					vs[i,e.Col ]=vs[e.Row,e.Col];
					vs.Rows[i].UserData=1;
				}
				
			}
			
			DateTime ngay;
			for (int i=vs.Selection.r1;i<=vs.Selection.r2;i++)
			{	
				if (vs.Rows[i]["LOCK_BT"]+""=="True")
				{
					tam=1;
				}
				else
				{
					tam=0;
				}
				ngay=(DateTime)(vs.Rows[i]["MEAL_DT"]);
				
				sql="UPDATE FILC15A SET USR_NM='"+ vs.Rows[e.Row]["USR_NM"] +"',LOCK_BT='"+ tam +"' where EMP_ID=N'"+vs.Rows[i]["EMP_ID"]+"' and MEAL_DT='" + ngay.ToString("yyyy/MM/dd") + "'";
				PublicFunction.SQL_Execute(sql);
			}
			
		}
		private void Set_w()
		{		
			vs.AllowEditing=false;
			cmdCancel.Visible=false;
			cmdEdit.Visible=true;
		}
		#endregion		
		#region Search	
		private void txt_Enter(object sender, System.EventArgs e)
		{			
			TextBox txt=(TextBox)sender;
			if (txt.Text==vs.Cols[txt.Tag+""].Caption)
				txt.Text="";
		}
		private void txt_Leave(object sender, System.EventArgs e)		
		{
			TextBox txt=(TextBox)sender;
			if (txt.Text=="")
				txt.Text=vs.Cols[txt.Tag+""].Caption;
		}
		private void txt_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Enter)
			{
				
				string sql;	
				//				string f=((TextBox)sender).Tag+"";
				//				if(f=="EMP_ID" || f=="EMP_I1")
				//					f="a."+f;
				//				if(((TextBox)sender).Text+""!="")
				//					
				//					sql=f+" like N'%"+((TextBox)sender).Text+"%'";
				//				else
				//					sql="1=1";
				if(txt1.Text+""!="")					
					sql=" a.EMP_ID like N'%"+txt1.Text+"%'";
				else if(txt2.Text+""!="")					
					sql=" a.EMP_I1 like N'%"+txt2.Text+"%'";
				else
					sql=" 1=1";
				string dk=Dep.Get_Data("DEP_ID");
				
				if(dk+""!="")
					sql=sql+" and b.DEP_ID=N'"+dk+"'";				
				else
					sql=sql+" and b.DEP_ID in "+T_String.DEP_ID(this.Tag)+" ";
			
				if(ck.Checked)
					sql=sql+" and  (DEL_BT=0 or DEL_BT is null) and "
						+"(MEAL_DT Between '"+((DateTime)dt1.Value).ToString("yyyy/MM/dd")+"' and '"
						+((DateTime)dt2.Value).ToString("yyyy/MM/dd")+"') "
						+" and b.DEP_ID in (Select DEP_ID  from SYS_SECURITY_DEP"+
						" where MNU_ID="+this.Tag+" and ALL_BT=1 and USER_ID=N'"+PublicFunction.A_UserID+"')";
				else
					sql=sql+" and  (DEL_BT=0 or DEL_BT is null) and b.DEP_ID in (Select DEP_ID  from SYS_SECURITY_DEP"+
						" where MNU_ID="+this.Tag+" and ALL_BT=1 and USER_ID=N'"+PublicFunction.A_UserID+"')";

				
				nav.Show_VS(sql);	
				Set_w();				
			}
		}
		#endregion		

		private void Dep_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode==Keys.F10 && (PublicFunction.A_UserID=="admin" || PublicFunction.A_UserID=="vinhtuyen"))
			{
				frmTaMealFormula dlg=new frmTaMealFormula();
				dlg.Tag=this.Tag;
				dlg.ShowDialog();
			}
		}

		private void ck_CheckedChanged(object sender, System.EventArgs e)
		{
			dt1.Enabled=dt2.Enabled=ck.Checked;
		}
		private void dt1_TextChanged(object sender, System.EventArgs e)
		{
			dt2.Value=dt1.Value;
		}
		

		private void nav_Load(object sender, System.EventArgs e)
		{
		
		}
		private void panel5_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}

		private void txt1_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void txt2_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void cmd_cal_Click(object sender, System.EventArgs e)
		{
			frmTaMealCalculate dlg=new frmTaMealCalculate();
			dlg.Tag=this.Tag;
			dlg.ShowDialog();
		}

		private void cmdEdit_Click(object sender, System.EventArgs e)
		{
			vs.AllowEditing=true;
			cmdCancel.Visible=true;
			cmdEdit.Visible=false;
		}

		private void cmdCancel_Click(object sender, System.EventArgs e)
		{
			vs.AllowEditing=false;
			cmdCancel.Visible=false;
			cmdEdit.Visible=true;
		}

		

		
	}
}

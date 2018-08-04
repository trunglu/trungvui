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
	public class frmTaAnnualLeave : System.Windows.Forms.Form
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
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.TextBox txt3;
		private System.Windows.Forms.TextBox txt2;
		private System.Windows.Forms.TextBox txt1;
		private Navigator1._0.NavigatorAuto nav;
		private C1.Win.C1FlexGrid.C1FlexGrid vs;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.DateTimePicker dt;
		private System.Windows.Forms.Label label1;
		private GP8000.Database.frmTaRace dlg;
		public System.Windows.Forms.RadioButton optVacate;
		public System.Windows.Forms.RadioButton optWorking;
		public System.Windows.Forms.RadioButton optAll;
		private System.Windows.Forms.Button cmd_tran;
		private System.Windows.Forms.Button cmd_cal;
		private System.Windows.Forms.Button cmd_set;	
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaAnnualLeave()
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
			this.panel9 = new System.Windows.Forms.Panel();
			this.txt3 = new System.Windows.Forms.TextBox();
			this.txt2 = new System.Windows.Forms.TextBox();
			this.txt1 = new System.Windows.Forms.TextBox();
			this.vs = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.dt = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			this.optVacate = new System.Windows.Forms.RadioButton();
			this.optWorking = new System.Windows.Forms.RadioButton();
			this.optAll = new System.Windows.Forms.RadioButton();
			this.cmd_tran = new System.Windows.Forms.Button();
			this.cmd_cal = new System.Windows.Forms.Button();
			this.cmd_set = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.nav = new Navigator1._0.NavigatorAuto();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandDock1)).BeginInit();
			this.c1CommandDock1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).BeginInit();
			this.c1DockingTab1.SuspendLayout();
			this.c1DockingTabPage1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel9.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
			this.panel5.SuspendLayout();
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
			this.panel6.Controls.Add(this.panel7);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panel6.Location = new System.Drawing.Point(0, 60);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(744, 580);
			this.panel6.TabIndex = 1;
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.panel9);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(744, 580);
			this.panel7.TabIndex = 0;
			// 
			// panel9
			// 
			this.panel9.Controls.Add(this.txt3);
			this.panel9.Controls.Add(this.txt2);
			this.panel9.Controls.Add(this.txt1);
			this.panel9.Controls.Add(this.vs);
			this.panel9.Controls.Add(this.dt);
			this.panel9.Controls.Add(this.label1);
			this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel9.Location = new System.Drawing.Point(0, 0);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(744, 580);
			this.panel9.TabIndex = 0;
			// 
			// txt3
			// 
			this.txt3.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt3.Location = new System.Drawing.Point(384, 4);
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
			this.txt2.Location = new System.Drawing.Point(268, 4);
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
			this.txt1.Location = new System.Drawing.Point(152, 4);
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
			this.vs.Size = new System.Drawing.Size(736, 548);
			this.vs.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.vs.TabIndex = 10;
			// 
			// dt
			// 
			this.dt.CustomFormat = "yyyy";
			this.dt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dt.Location = new System.Drawing.Point(76, 4);
			this.dt.Name = "dt";
			this.dt.Size = new System.Drawing.Size(72, 23);
			this.dt.TabIndex = 15;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.TabIndex = 14;
			this.label1.Text = "label1";
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.Moccasin;
			this.panel5.Controls.Add(this.optVacate);
			this.panel5.Controls.Add(this.optWorking);
			this.panel5.Controls.Add(this.optAll);
			this.panel5.Controls.Add(this.cmd_tran);
			this.panel5.Controls.Add(this.cmd_cal);
			this.panel5.Controls.Add(this.cmd_set);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel5.Location = new System.Drawing.Point(0, 0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(744, 60);
			this.panel5.TabIndex = 0;
			// 
			// optVacate
			// 
			this.optVacate.Location = new System.Drawing.Point(12, 40);
			this.optVacate.Name = "optVacate";
			this.optVacate.Size = new System.Drawing.Size(104, 16);
			this.optVacate.TabIndex = 17;
			this.optVacate.Tag = "optVacate";
			this.optVacate.Text = "radioButton3";
			// 
			// optWorking
			// 
			this.optWorking.Location = new System.Drawing.Point(12, 24);
			this.optWorking.Name = "optWorking";
			this.optWorking.Size = new System.Drawing.Size(104, 16);
			this.optWorking.TabIndex = 16;
			this.optWorking.Tag = "optWorking";
			this.optWorking.Text = "radioButton2";
			// 
			// optAll
			// 
			this.optAll.Location = new System.Drawing.Point(12, 8);
			this.optAll.Name = "optAll";
			this.optAll.Size = new System.Drawing.Size(104, 16);
			this.optAll.TabIndex = 15;
			this.optAll.Tag = "optAll";
			this.optAll.Text = "radioButton1";
			// 
			// cmd_tran
			// 
			this.cmd_tran.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_tran.Location = new System.Drawing.Point(428, 8);
			this.cmd_tran.Name = "cmd_tran";
			this.cmd_tran.Size = new System.Drawing.Size(144, 42);
			this.cmd_tran.TabIndex = 14;
			this.cmd_tran.Text = "Transfer To Next Year";
			this.cmd_tran.Click += new System.EventHandler(this.cmd_tran_Click_1);
			// 
			// cmd_cal
			// 
			this.cmd_cal.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_cal.Location = new System.Drawing.Point(276, 8);
			this.cmd_cal.Name = "cmd_cal";
			this.cmd_cal.Size = new System.Drawing.Size(144, 42);
			this.cmd_cal.TabIndex = 13;
			this.cmd_cal.Text = "Calculate";
			this.cmd_cal.Click += new System.EventHandler(this.cmd_cal_Click_1);
			// 
			// cmd_set
			// 
			this.cmd_set.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_set.Location = new System.Drawing.Point(124, 8);
			this.cmd_set.Name = "cmd_set";
			this.cmd_set.Size = new System.Drawing.Size(144, 42);
			this.cmd_set.TabIndex = 12;
			this.cmd_set.Text = "Setting";
			this.cmd_set.Click += new System.EventHandler(this.cmd_set_Click_1);
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
			this.label5.Location = new System.Drawing.Point(420, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(324, 36);
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
			this.panel4.Size = new System.Drawing.Size(420, 36);
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
			this.nav.Location = new System.Drawing.Point(0, 1);
			this.nav.MSG_Exit = false;
			this.nav.MulltiDel = false;
			this.nav.Name = "nav";
			this.nav.Security = 0;
			this.nav.ShowPopupMenu = true;
			this.nav.Size = new System.Drawing.Size(420, 32);
			this.nav.TabIndex = 9;
			this.nav.Tag = "";
			this.nav.ToolBar_Auto = true;
			this.nav.UserID = null;
			this.nav.VisibleGrid = true;
			this.nav.Where = null;
			// 
			// frmTaAnnualLeave
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(1020, 676);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.c1CommandDock1);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaAnnualLeave";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmTaAnnualLeave";
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
			this.panel9.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			this.panel5.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaVacateManager_Load(object sender, System.EventArgs e)
		{		
			dt.CustomFormat="yyyy";
			dt.Value=T_String.GetDate();
			optAll.Checked=true;
			//dt.TextChanged+=new EventHandler(dt_TextChanged);
			Init_Form();	
			cmd_set.Enabled=cmd_tran.Enabled=cmd_cal.Enabled=PublicFunction.AccessLevel(this.Tag,3);
			Init_Menu();

			vs.Cols["CAN_QT"].Format ="0.00";
			vs.Cols["HAV_QT"].Format ="0.00";
			vs.Cols["BOR_QT"].Format ="0.00";
			vs.Cols["ADD_QT"].Format ="0.00";
			vs.Cols["LST_QT"].Format ="0.00";
			vs.Cols["SUP_QT"].Format ="0.00";
			vs.Cols["DID_QT"].Format ="0.00";
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
			C1.C1Excel.C1XLBook c1XLBook1=new C1.C1Excel.C1XLBook();;
			//string sql="";			
			switch (mnu1.MenuItems.IndexOf((MenuItem)sender))
			{
				case 0:		
					GP8000.Personnel.Report.ReportFromVS rpt=new GP8000.Personnel.Report.ReportFromVS();
					rpt.RPT2(c1XLBook1,vs,mnu1.MenuItems[mnu1.MenuItems.IndexOf((MenuItem)sender)].Text,"STD_TA_02");					
					break;
				
			}
		}
		#endregion
		private void dt_TextChanged(object sender, EventArgs e)
		{		
			if(nav.Where!="")
				nav.Show_VS(nav.Where +" and YYY_YY=N'"+ dt.Text+"'");	
		}
		
		#region Init Form
		private void Init_Form()
		{					
			Dep.Init_Tree(this.Tag+"");
			Dep.vs1.AfterRowColChange+=new C1.Win.C1FlexGrid.RangeEventHandler(Depvs1_AfterRowColChange);
			Dep.Show_Tree();
			Init_vs();					
			Basic.Function.PublicFunction.L_Init_Label(this);									
		}
		private void Init_vs()
		{			
			nav.cmd_add.Visible=nav.cmd_copy.Visible=false;
			PublicFunction.InitNav(this,vs,nav);			
			vs.SelectionMode=C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			vs.Cols["INH_DT"].DataType=typeof(System.DateTime);
			vs.Cols["INH_DT"].Format=PublicFunction.GetOption("DATE");
			vs.Cols["VAC_DT"].DataType=typeof(System.DateTime);
			vs.Cols["VAC_DT"].Format=PublicFunction.GetOption("DATE");
			vs.EnabledChanged+=new EventHandler(vs_EnabledChanged);
			nav.ToolBar_Auto=false;
			nav.TBarClick+=new ToolBarButtonClickEventHandler(nav_TBarClick);
			vs.SelectionMode=C1.Win.C1FlexGrid.SelectionModeEnum.CellRange; 			
			vs.AfterEdit+=new C1.Win.C1FlexGrid.RowColEventHandler(vs_AfterEdit);
			string sql=PublicFunction.GetDep(this.Tag+"");						
			vs.Cols["DEP_ID"].DataMap=PublicFunction.InitCBForVS(sql);
			vs.Styles.Add("VAC_BT");
			vs.Styles["VAC_BT"].BackColor=Color.DarkGray;
		}	
		private void nav_TBarClick(object sender, ToolBarButtonClickEventArgs e)
		{
			if (e.Button.Equals(nav.cmd_refresh))
			{
//				if(nav.wh!="")
//					nav.ToolBar_Click(e);
//				else
//					nav.Show_VS("DEP_ID in "+T_String.DEP_ID(this.Tag));	
				if(txt1.Text!=vs.Cols[txt1.Tag+""].Caption && txt1.Text!="" )
				{
					textBox1_KeyDown(txt1, new System.Windows.Forms.KeyEventArgs(Keys.Enter));
				}
				else
				{
					if(txt2.Text!=vs.Cols[txt2.Tag+""].Caption && txt2.Text!="" )
					{
						textBox1_KeyDown(txt2, new System.Windows.Forms.KeyEventArgs(Keys.Enter));
					}
					else
					{
						if(txt3.Text!=vs.Cols[txt3.Tag+""].Caption && txt3.Text!="" )
						{
							textBox1_KeyDown(txt3, new System.Windows.Forms.KeyEventArgs(Keys.Enter));
						}
						else
						{
							if (optAll.Checked==true)
							{
								nav.Show_VS("DEP_ID in "+T_String.DEP_ID(this.Tag) +" and YYY_YY=N'"+dt.Text+"' order by a.EMP_ID" );	
								//nav.Show_VS("DEP_ID=N'"+Dep.Get_Data("DEP_ID")+"' and YYY_YY=N'"+ dt.Text+"'");				
							}
							else
							{
								if (optWorking.Checked==true)
								{
									nav.Show_VS("DEP_ID in "+T_String.DEP_ID(this.Tag)+" and YYY_YY=N'"+ dt.Text+"' and (VAC_BT=0 or VAC_BT is null) order by a.EMP_ID");				
								}
								else
								{
									nav.Show_VS("DEP_ID in "+T_String.DEP_ID(this.Tag)+" and YYY_YY=N'"+ dt.Text+"' and VAC_BT=1 order by a.EMP_ID");				
								}
							}
//							nav.Show_VS("DEP_ID in "+T_String.DEP_ID(this.Tag) +" and YYY_YY=N'"+dt.Text+"'" );	
						}
					}
				}

				for(int i=1;i<vs.Rows.Count;i++)
				{
//					if(vs.Rows[i]["VAC_BT"]+""=="True")
//					{
//						for(int c=1;c<vs.Cols.Count;c++)
//							vs.SetCellStyle(i,c, vs.Styles["VAC_BT"]);
//					}
					CAL(i);
				}
				return;
			}			
			nav.ToolBar_Click(e);
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
			if (optAll.Checked==true)
			{
				nav.Show_VS("DEP_ID in "+Dep.Get_DepAll()+" and YYY_YY=N'"+ dt.Text+"' order by a.EMP_ID");				
			}
			else
			{
				if (optWorking.Checked==true)
				{
					nav.Show_VS("DEP_ID in "+Dep.Get_DepAll()+" and YYY_YY=N'"+ dt.Text+"' and (VAC_BT=0 or VAC_BT is null) order by a.EMP_ID");				
				}
				else
				{
					nav.Show_VS("DEP_ID in "+Dep.Get_DepAll()+" and YYY_YY=N'"+ dt.Text+"' and VAC_BT=1 order by a.EMP_ID");				
				}
			}
//			nav.Show_VS("DEP_ID=N'"+Dep.Get_Data("DEP_ID")+"' and (VAC_BT=0 or VAC_BT is null) and YYY_YY=N'"+ dt.Text+"'");				
			for(int i=1;i<vs.Rows.Count;i++)
			{
//				if(vs.Rows[i]["VAC_BT"]+""=="True")
//				{
//					for(int c=1;c<vs.Cols.Count;c++)
//						vs.SetCellStyle(i,c, vs.Styles["VAC_BT"]);
//				}			
				CAL(i);
			}
		}			

		private void CAL(int i)
		{
			if(i>0)			
			{
				Double con=0;
				Double con1=0;
				con1=T_String.IsNullTo00(vs.Rows[i]["HAV_QT"]+"");
				if(con1==0)
					vs.Rows[i]["TLCN"]=0;
				con=T_String.IsNullTo00(vs.Rows[i]["TLCN"]+"");
				con+=T_String.IsNullTo00(vs.Rows[i]["BOR_QT"]+"");
				con+=T_String.IsNullTo00(vs.Rows[i]["ADD_QT"]+"");
				con+=T_String.IsNullTo00(vs.Rows[i]["LST_QT"]+"");
				con+=T_String.IsNullTo00(vs.Rows[i]["SUP_QT"]+"");
				con-=T_String.IsNullTo00(vs.Rows[i]["DID_QT"]+"");
				vs.Rows[i]["CAN_QT"]=con;				
			}
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
				if(f=="EMP_ID")
					f="a."+f;
				string sql;				
				if(((TextBox)sender).Text+""!="")
					sql=f+" like N'%"+((TextBox)sender).Text+"%'";
				else
					sql="1=1";
				if (optAll.Checked==true)
				{

				}
				else
				{
					if (optWorking.Checked==true)
						sql=sql+" and (VAC_BT=0 or VAC_BT is null)";				
					else
						sql=sql+" and VAC_BT=1 and year(c.VAC_DT)=N'"+ dt.Text+"'";
				}				
				sql=sql+" and YYY_YY=N'"+ dt.Text+"' and DEP_ID in (Select DEP_ID  from SYS_SECURITY_DEP"+
					" where MNU_ID="+this.Tag+" and ALL_BT=1 and USER_ID=N'"+PublicFunction.A_UserID+"')";									
				nav.Show_VS(sql);	
				for(int i=1;i<vs.Rows.Count;i++)
				{
					CAL(i);
				}						
			}
		}
		
		#endregion		

		private void cmd_set_Click_1(object sender, System.EventArgs e)
		{					
			dlg=new GP8000.Database.frmTaRace(6);
			dlg.Tag=this.Tag;
			//dlg.MdiParent=this.MdiParent;
			dlg.ShowDialog();		
		}

		private void cmd_cal_Click_1(object sender, System.EventArgs e)
		{
			int tinh;
			if(optWorking.Checked==true)
				tinh=1;
			else if(optVacate.Checked==true)
				tinh=2;
			else
				tinh=0;
			frmTaCalAnnualLeave dlg=new frmTaCalAnnualLeave(DateTime.Parse(dt.Value+""),tinh);
			dlg.Tag=this.Tag;
			dlg.ShowDialog();
		}

		private void cmd_tran_Click_1(object sender, System.EventArgs e)
		{
			frmTaTransferNextYear dlg=new frmTaTransferNextYear();
			dlg.Tag=this.Tag;
			dlg.ShowDialog();
		}

		private void cmd_tran_Click(object sender, System.EventArgs e)
		{
			frmTaTransferNextYear dlg=new frmTaTransferNextYear();
			dlg.Tag=this.Tag;
			dlg.ShowDialog();
		}

		private void vs_EnabledChanged(object sender, EventArgs e)
		{
			txt1.Text=vs.Cols[txt1.Tag+""].Caption;
			txt2.Text=vs.Cols[txt2.Tag+""].Caption;
			txt3.Text=vs.Cols[txt3.Tag+""].Caption;	
		}

		private void vs_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			string dt=T_String.GetDate().ToString("yyyy/MM/dd HH:mm");
			for (int i=vs.Selection.r1;i<=vs.Selection.r2;i++)
			{
				for (int j=vs.Selection.c1;j<=vs.Selection.c2;j++)
				{
					if (vs.Cols[j].AllowEditing)
					{
						vs[i,j ]=vs[e.Row,e.Col];										
					}
				}
				vs.Rows[i].UserData=1;		
				CAL(i);
				
				vs.Rows[i]["LST_NM"]=PublicFunction.A_UserID;				
				vs.Rows[i]["LST_DT"]=dt;
			}		
		}
	}
}

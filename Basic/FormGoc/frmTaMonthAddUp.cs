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
	/// Summary description for frmTaMonthAddUp.
	/// </summary>
	public class frmTaMonthAddUp : System.Windows.Forms.Form
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
		private System.Windows.Forms.CheckBox ck;
		private C1.Win.C1Input.C1DateEdit dt1;
		private System.Windows.Forms.TextBox txt2;
		private System.Windows.Forms.TextBox txt1;
		Func.RecordSet rs1,rs2;
		private C1.Win.C1Input.C1DateEdit dt2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cb_type;
		private System.Windows.Forms.CheckBox ck_type;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaMonthAddUp()
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
			this.cb_type = new System.Windows.Forms.ComboBox();
			this.ck_type = new System.Windows.Forms.CheckBox();
			this.dt1 = new C1.Win.C1Input.C1DateEdit();
			this.dt2 = new C1.Win.C1Input.C1DateEdit();
			this.txt2 = new System.Windows.Forms.TextBox();
			this.txt1 = new System.Windows.Forms.TextBox();
			this.ck = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.vs = new C1.Win.C1FlexGrid.C1FlexGrid();
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
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dt1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dt2)).BeginInit();
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
			this.Dep.Location = new System.Drawing.Point(0, 20);
			this.Dep.Name = "Dep";
			this.Dep.Size = new System.Drawing.Size(239, 474);
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
			this.panel5.Controls.Add(this.cb_type);
			this.panel5.Controls.Add(this.ck_type);
			this.panel5.Controls.Add(this.dt1);
			this.panel5.Controls.Add(this.dt2);
			this.panel5.Controls.Add(this.txt2);
			this.panel5.Controls.Add(this.txt1);
			this.panel5.Controls.Add(this.ck);
			this.panel5.Controls.Add(this.label1);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel5.Location = new System.Drawing.Point(0, 0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(980, 32);
			this.panel5.TabIndex = 12;
			this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
			// 
			// cb_type
			// 
			this.cb_type.DisplayMember = "2";
			this.cb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_type.Items.AddRange(new object[] {
														 "1",
														 "2",
														 "3",
														 "4"});
			this.cb_type.Location = new System.Drawing.Point(670, 2);
			this.cb_type.Name = "cb_type";
			this.cb_type.Size = new System.Drawing.Size(136, 24);
			this.cb_type.TabIndex = 167;
			this.cb_type.Tag = "GRP_ID";
			// 
			// ck_type
			// 
			this.ck_type.Checked = true;
			this.ck_type.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ck_type.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ck_type.Location = new System.Drawing.Point(586, 6);
			this.ck_type.Name = "ck_type";
			this.ck_type.TabIndex = 168;
			this.ck_type.Text = "CK_GRP_ID";
			// 
			// dt1
			// 
			this.dt1.CustomFormat = "yyyyMM";
			this.dt1.Enabled = false;
			this.dt1.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt1.Location = new System.Drawing.Point(100, 4);
			this.dt1.Name = "dt1";
			this.dt1.Size = new System.Drawing.Size(100, 23);
			this.dt1.TabIndex = 148;
			this.dt1.Tag = null;
			// 
			// dt2
			// 
			this.dt2.CustomFormat = "yyyyMM";
			this.dt2.Enabled = false;
			this.dt2.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt2.Location = new System.Drawing.Point(228, 4);
			this.dt2.Name = "dt2";
			this.dt2.Size = new System.Drawing.Size(100, 23);
			this.dt2.TabIndex = 152;
			this.dt2.Tag = null;
			// 
			// txt2
			// 
			this.txt2.BackColor = System.Drawing.Color.PeachPuff;
			this.txt2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt2.Location = new System.Drawing.Point(448, 4);
			this.txt2.MaxLength = 20;
			this.txt2.Name = "txt2";
			this.txt2.Size = new System.Drawing.Size(112, 23);
			this.txt2.TabIndex = 151;
			this.txt2.Tag = "EMP_I1";
			this.txt2.Text = "";
			this.txt2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
			this.txt2.Leave += new System.EventHandler(this.txt_Leave);
			this.txt2.Enter += new System.EventHandler(this.txt_Enter);
			// 
			// txt1
			// 
			this.txt1.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt1.Location = new System.Drawing.Point(332, 4);
			this.txt1.MaxLength = 20;
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(112, 23);
			this.txt1.TabIndex = 150;
			this.txt1.Tag = "EMP_ID";
			this.txt1.Text = "";
			this.txt1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
			this.txt1.Leave += new System.EventHandler(this.txt_Leave);
			this.txt1.Enter += new System.EventHandler(this.txt_Enter);
			// 
			// ck
			// 
			this.ck.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ck.Location = new System.Drawing.Point(8, 12);
			this.ck.Name = "ck";
			this.ck.Size = new System.Drawing.Size(96, 16);
			this.ck.TabIndex = 149;
			this.ck.Tag = "";
			this.ck.CheckedChanged += new System.EventHandler(this.ck_CheckedChanged);
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
			// frmTaMonthAddUp
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(1224, 496);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.c1CommandDock1);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaMonthAddUp";
			this.Text = "frmTaMonthAddUp";
			this.Load += new System.EventHandler(this.frmTaMonthAddUp_Load);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandDock1)).EndInit();
			this.c1CommandDock1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).EndInit();
			this.c1DockingTab1.ResumeLayout(false);
			this.c1DockingTabPage1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dt1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dt2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaMonthAddUp_Load(object sender, System.EventArgs e)
		{  
			vs.Rows[0].HeightDisplay= vs.Rows[0].HeightDisplay*3;
			vs.Styles["Fixed"].WordWrap=true;
			Init_Form();		
			dt2.Value=dt1.Value=T_String.GetDate();
			Set_w();
			Init_Menu();
			Set_LB();
			cb_type.Text="2";
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
			Init_vs();		
			InitCB();			
			Basic.Function.PublicFunction.L_Init_Label(this);							
			Basic.Function.PublicFunction.L_Init_Label(vs,this.Name+"000_vs");							
		}
		private void Init_vs()
		{			
			PublicFunction.InitNav(this,vs,nav,this.Name+"000_vs");			
			nav.TBForm="GP_SYS_SQL_FROM";
			nav.TBSelect="GP_SYS_SQL_SELECT";
			nav.Init_Control();
			nav.cmd_copy.Visible=false;
			nav.cmd_delete.Visible=false;									
			vs.SelectionMode=C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;						
			vs.Cols.Frozen=vs.Cols["EMP_NM"].Index;			
			vs.Cols["EMP_I1"].Style.BackColor=Color.PeachPuff;			
			vs.Cols["ATT_DY"].Format="#,##0.0000";
			vs.Cols["NIG_DY"].Format="#,##0.0000";
			string sql="Select FNAME,"+PublicFunction.L_Lag+" from  SYS_LABEL where [NAME]=N'frmTaMonthAddUpCal' and (FName='1' or FName='2' or FName='3' or FName='4')";
			vs.Cols["SEQ_NO"].DataMap=PublicFunction.InitCBForVS(sql);
			vs.EnabledChanged+=new EventHandler(vs_EnabledChanged);	
//			nav.ToolBar_Auto=false;
			//nav.TBarClick+=new ToolBarButtonClickEventHandler(nav_TBarClick);
			vs.AfterEdit+=new C1.Win.C1FlexGrid.RowColEventHandler(vs_AfterEdit);
			vs.BeforeEdit+=new C1.Win.C1FlexGrid.RowColEventHandler(vs_BeforeEdit);
			vs.Cols["LOC_B1"].Style.BackColor=Color.Silver;
			vs.Styles.Add("VAC_BT");
			vs.Styles["VAC_BT"].BackColor=Color.DarkGray;

			sql="Select TYP_ID from GP_SYS_SHIFT";
			rs1=new Func.RecordSet(sql,PublicFunction.C_con);
			sql="Select COL_NM from FILC07A";
			rs2=new Func.RecordSet(sql,PublicFunction.C_con);
			nav.ToolBar_Auto=false;
			nav.TBarClick+=new ToolBarButtonClickEventHandler(nav_TBarClick);
			vs.SelectionMode=C1.Win.C1FlexGrid.SelectionModeEnum.CellRange; 
			vs.BeforeEdit+=new C1.Win.C1FlexGrid.RowColEventHandler(vs_BeforeEdit);
			vs.AfterEdit+=new C1.Win.C1FlexGrid.RowColEventHandler(vs_AfterEdit);	

		}	

		private void nav_TBarClick(object sender, ToolBarButtonClickEventArgs e)
		{
			if (e.Button.Equals(nav.cmd_refresh))
			{
				if(txt1.Text!="")
					txt_KeyDown((object)txt1,new System.Windows.Forms.KeyEventArgs(Keys.Enter));
				else
				{
					if(txt2.Text!="")
						txt_KeyDown((object)txt2,new System.Windows.Forms.KeyEventArgs(Keys.Enter));
					else
						txt_KeyDown((object)txt1,new System.Windows.Forms.KeyEventArgs(Keys.Enter));
				}				
				return;
			}
			nav.ToolBar_Click(e);
		}
		private void InitCB()
		{
			string sql;			
			//Department
			sql=PublicFunction.GetDep(this.Tag+"");			
			vs.Cols["DEP_ID"].DataMap=PublicFunction.InitCBForVS(sql);	
			vs.Cols["DEP_I1"].DataMap=PublicFunction.InitCBForVS(sql);			
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
			if(ck.Checked)
			{				
				sql="DEP_ID=N'"+Dep.Get_Data("DEP_ID")+"' and (DEL_BT=0 or DEL_BT is null) and YYY_MM='"+dt1.Text+"' and DEP_ID in "+T_String.DEP_ID(this.Tag);							
			}
			else
			{				
				sql="DEP_ID=N'"+Dep.Get_Data("DEP_ID")+"' and (DEL_BT=0 or DEL_BT is null) and DEP_ID in "+T_String.DEP_ID(this.Tag);				
			}		
			nav.Show_VS(sql);	
			CheckCols();
		}					
		private void CheckCols()
		{
			for(int i=1;i<vs.Rows.Count;i++)
			{
				if(vs.Rows[i]["VAC_BT"]+""=="True")
				{
					for(int c=1;c<vs.Cols.Count;c++)
						vs.SetCellStyle(i,c, vs.Styles["VAC_BT"]);
				}
			}
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
			Basic.Function.PublicFunction.L_Init_Label(vs,this.Name+"000_vs");							
//			txt1.Text=vs.Cols[txt1.Tag+""].Caption;
//			txt2.Text=vs.Cols[txt2.Tag+""].Caption;			
			Set_LB();
			nav.Init_PMenu_Color();
		}
		private void Set_LB()
		{
			string sql="";
			for(int i=1;i<=20;i++)
			{
                Func.RecordSet rs=new Func.RecordSet("Select * from FILA15A where LEA_ID='"+i.ToString("000")+"'",PublicFunction.C_con);
				if(rs.rows>0)
				{
					vs.Cols["LEA_"+i.ToString("000")].Caption=rs.record(0,"LEA_NM");
					sql="update GP_SYS_SQL_SELECT set HIDE=0 where ID=N'frmTaMonthAddUp000_vs' and NAME=N'"+"LEA_"+i.ToString("000")+"'";
					PublicFunction.SQL_Execute(sql);
				}
				else
				{
					sql="update GP_SYS_SQL_SELECT set HIDE=1 where ID=N'frmTaMonthAddUp000_vs' and NAME=N'"+"LEA_"+i.ToString("000")+"'";
					PublicFunction.SQL_Execute(sql);
					vs.Cols["LEA_"+i.ToString("000")].Visible=false;
				}
			}
		}
		private void Set_w()
		{		
			for(int i=0;i<rs1.rows;i++)
			{	
				try
				{
					vs.Cols[rs1.record(i,0)].Width=50;
				}
				catch{}
			}	
			for(int i=0;i<rs2.rows;i++)
			{	
				try
				{
					vs.Cols[rs2.record(i,0)].Width=50;
				}
				catch{}
			}				
			vs.Cols["OTR_HR"].Width=50;
			vs.Cols["LAT_MN"].Width=50;
			vs.Cols["EAR_MN"].Width=50;
			vs.Cols["LAT_TM"].Width=50;
			vs.Cols["EAR_TM"].Width=50;

			vs.Cols["ABS_MN"].Width=50;
			vs.Cols["ABS_TM"].Width=50;
			vs.Cols["ATT_DY"].Width=50;
			vs.Cols["NIG_DY"].Width=50;
			vs.Cols["LEA_QT"].Width=50;
		}
		#endregion		
		#region Search	
		private void txt_Enter(object sender, System.EventArgs e)
		{			
//			TextBox txt=(TextBox)sender;
//			if (txt.Text==vs.Cols[txt.Tag+""].Caption)
//				txt.Text="";
		}
		private void txt_Leave(object sender, System.EventArgs e)		
		{
//			TextBox txt=(TextBox)sender;
//			if (txt.Text=="")
//				txt.Text=vs.Cols[txt.Tag+""].Caption;			

		}
		private void txt_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
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
				if (ck_type.Checked && cb_type.Text+""!="")  
				{
					sql=sql+ " and SEQ_NO=" + cb_type.Text ;
				}
				
				if(ck.Checked)
					sql=sql+" and  (DEL_BT=0 or DEL_BT is null) and "
						+"(YYY_MM between N'"+dt1.Text+"' and N'"+dt2.Text+"')"
						+" and DEP_ID in (Select DEP_ID  from SYS_SECURITY_DEP"+
						" where MNU_ID="+this.Tag+" and ALL_BT=1 and USER_ID=N'"+PublicFunction.A_UserID+"')";
				else
					sql=sql+" and  (DEL_BT=0 or DEL_BT is null) and DEP_ID in (Select DEP_ID  from SYS_SECURITY_DEP"+
						" where MNU_ID="+this.Tag+" and ALL_BT=1 and USER_ID=N'"+PublicFunction.A_UserID+"')";				
				nav.Show_VS(sql);		
				CheckCols();
			}
		}
		#endregion		

		private void ck_CheckedChanged(object sender, System.EventArgs e)
		{
			dt2.Enabled=dt1.Enabled=ck.Checked;
		}

		private void vs_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{		
			string sUser,sDate;
			vs.Rows[e.Row]["LST_NM"]=PublicFunction.A_UserID;
			vs.Rows[e.Row]["LST_DT"]=T_String.GetDate().ToString("yyyy/MM/dd HH:mm");
			for (int i=vs.Selection.r1;i<=vs.Selection.r2;i++)
			{				
				if (vs.Rows[i]["LOC_B1"]+""!="True")
				{
					vs[i,e.Col ]=vs[e.Row,e.Col];					
					vs.Rows[i].UserData=1;
				}				
			}
			string sql="";
			int tam=0;
			if (vs.Rows[e.Row]["LOC_B1"]+""=="True")
			{
				tam=1;
				sUser=PublicFunction.A_UserID;
				sDate=T_String.GetDate().ToString("yyyy/MM/dd HH:mm");
			}
			else
			{
				tam=0;
				sUser="";
				sDate="";
			}
			for (int i=vs.Selection.r1;i<=vs.Selection.r2;i++)
			{				
				sql="UPDATE FILC06AA SET LOC_B1='"+ tam +"', LST_NM=N'"+ sUser +"', LST_DT='"+ sDate +"'";
				sql=sql+" where EMP_ID=N'"+vs.Rows[i]["EMP_ID"]+"' and YYY_MM='"+vs.Rows[i]["YYY_MM"]+"'  and SEQ_NO='"+vs.Rows[i]["SEQ_NO"]+"'";
				PublicFunction.SQL_Execute(sql);
			}

		}

		private void vs_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			if(vs.Rows[e.Row]["LOC_B1"]+""=="True")
			{
				if(PublicFunction.A_UserID!= vs.Rows[e.Row]["LST_NM"]+"" || vs.Cols[e.Col].Name!="LOC_B1")
					e.Cancel=true;
			}
		}

		private void nav_Load(object sender, System.EventArgs e)
		{
		
		}

		private void panel5_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}
	}
}

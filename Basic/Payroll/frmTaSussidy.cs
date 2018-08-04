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
using GP8000.Personnel.Report;

namespace GP8000.Attendance
{
	/// <summary>
	/// Summary description for frmTaDailyAttendanceList.
	/// </summary>
	public class frmTaSussidy : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private C1.Win.C1Command.C1CommandDock c1CommandDock1;
		private C1.Win.C1Command.C1DockingTab c1DockingTab1;
		private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage1;
		private GP8000.UserControl.CrtTaDepartment Dep;
		private System.Windows.Forms.Panel panel5;
		private C1.Win.C1FlexGrid.C1FlexGrid vs;
		private Navigator1._0.NavigatorAuto nav;
		private C1.Win.C1Input.C1DateEdit dt1;
		private C1.Win.C1Input.C1DateEdit dt2;
		private System.Windows.Forms.TextBox txt2;
		private System.Windows.Forms.TextBox txt1;
		private System.Windows.Forms.CheckBox ck;
		private int x,y;
		Func.RecordSet rs1,rs2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaSussidy()
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
			this.label3 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.nav = new Navigator1._0.NavigatorAuto();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.vs = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.c1CommandDock1 = new C1.Win.C1Command.C1CommandDock();
			this.c1DockingTab1 = new C1.Win.C1Command.C1DockingTab();
			this.c1DockingTabPage1 = new C1.Win.C1Command.C1DockingTabPage();
			this.Dep = new GP8000.UserControl.CrtTaDepartment();
			this.panel2 = new System.Windows.Forms.Panel();
			this.ck = new System.Windows.Forms.CheckBox();
			this.txt2 = new System.Windows.Forms.TextBox();
			this.txt1 = new System.Windows.Forms.TextBox();
			this.dt1 = new C1.Win.C1Input.C1DateEdit();
			this.dt2 = new C1.Win.C1Input.C1DateEdit();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandDock1)).BeginInit();
			this.c1CommandDock1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).BeginInit();
			this.c1DockingTab1.SuspendLayout();
			this.c1DockingTabPage1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dt1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dt2)).BeginInit();
			this.SuspendLayout();
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.panel4);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1016, 36);
			this.panel3.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label3.Location = new System.Drawing.Point(416, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(600, 36);
			this.label3.TabIndex = 11;
			this.label3.Tag = "";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			// panel1
			// 
			this.panel1.Controls.Add(this.panel5);
			this.panel1.Controls.Add(this.c1CommandDock1);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 36);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1016, 504);
			this.panel1.TabIndex = 6;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.vs);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(260, 60);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(756, 444);
			this.panel5.TabIndex = 2;
			// 
			// vs
			// 
			this.vs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.vs.AutoResize = false;
			this.vs.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs.Location = new System.Drawing.Point(4, 4);
			this.vs.Name = "vs";
			this.vs.Size = new System.Drawing.Size(748, 436);
			this.vs.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Tahoma, 9.75pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.vs.TabIndex = 10;
			this.vs.Click += new System.EventHandler(this.vs_Click);
			// 
			// c1CommandDock1
			// 
			this.c1CommandDock1.Controls.Add(this.c1DockingTab1);
			this.c1CommandDock1.Dock = System.Windows.Forms.DockStyle.Left;
			this.c1CommandDock1.Id = 1;
			this.c1CommandDock1.Location = new System.Drawing.Point(0, 60);
			this.c1CommandDock1.Name = "c1CommandDock1";
			this.c1CommandDock1.Size = new System.Drawing.Size(260, 444);
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
			this.c1DockingTab1.Size = new System.Drawing.Size(260, 444);
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
			this.c1DockingTabPage1.Size = new System.Drawing.Size(255, 442);
			this.c1DockingTabPage1.TabIndex = 0;
			this.c1DockingTabPage1.Text = "Page1";
			// 
			// Dep
			// 
			this.Dep.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Dep.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Dep.Location = new System.Drawing.Point(0, 20);
			this.Dep.Name = "Dep";
			this.Dep.Size = new System.Drawing.Size(255, 422);
			this.Dep.TabIndex = 2;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Moccasin;
			this.panel2.Controls.Add(this.ck);
			this.panel2.Controls.Add(this.txt2);
			this.panel2.Controls.Add(this.txt1);
			this.panel2.Controls.Add(this.dt1);
			this.panel2.Controls.Add(this.dt2);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1016, 60);
			this.panel2.TabIndex = 0;
			// 
			// ck
			// 
			this.ck.Checked = true;
			this.ck.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ck.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ck.Location = new System.Drawing.Point(4, 8);
			this.ck.Name = "ck";
			this.ck.Size = new System.Drawing.Size(20, 16);
			this.ck.TabIndex = 146;
			this.ck.Tag = "N";
			this.ck.CheckedChanged += new System.EventHandler(this.ck_CheckedChanged);
			// 
			// txt2
			// 
			this.txt2.BackColor = System.Drawing.Color.PeachPuff;
			this.txt2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt2.Location = new System.Drawing.Point(188, 32);
			this.txt2.MaxLength = 20;
			this.txt2.Name = "txt2";
			this.txt2.Size = new System.Drawing.Size(96, 23);
			this.txt2.TabIndex = 145;
			this.txt2.Tag = "EMP_I1";
			this.txt2.Text = "";
			this.txt2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
			this.txt2.TextChanged += new System.EventHandler(this.txt2_TextChanged);
			// 
			// txt1
			// 
			this.txt1.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt1.Location = new System.Drawing.Point(188, 4);
			this.txt1.MaxLength = 20;
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(96, 23);
			this.txt1.TabIndex = 144;
			this.txt1.Tag = "EMP_ID";
			this.txt1.Text = "";
			this.txt1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
			this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
			// 
			// dt1
			// 
			this.dt1.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt1.Location = new System.Drawing.Point(68, 4);
			this.dt1.Name = "dt1";
			this.dt1.Size = new System.Drawing.Size(120, 23);
			this.dt1.TabIndex = 143;
			this.dt1.Tag = null;
			this.dt1.TextChanged += new System.EventHandler(this.dt1_TextChanged);
			// 
			// dt2
			// 
			this.dt2.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt2.Location = new System.Drawing.Point(68, 32);
			this.dt2.Name = "dt2";
			this.dt2.Size = new System.Drawing.Size(120, 23);
			this.dt2.TabIndex = 141;
			this.dt2.Tag = null;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label1.Location = new System.Drawing.Point(24, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 23);
			this.label1.TabIndex = 142;
			this.label1.Tag = "";
			this.label1.Text = "date";
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label2.Location = new System.Drawing.Point(24, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 23);
			this.label2.TabIndex = 140;
			this.label2.Tag = "";
			this.label2.Text = "date";
			// 
			// frmTaSussidy
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(1016, 540);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaSussidy";
			this.Text = "frmTaSussidy";
			this.Load += new System.EventHandler(this.frmTaDailyAttendanceList_Load);
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandDock1)).EndInit();
			this.c1CommandDock1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).EndInit();
			this.c1DockingTab1.ResumeLayout(false);
			this.c1DockingTabPage1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dt1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dt2)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaDailyAttendanceList_Load(object sender, System.EventArgs e)
		{				
			vs.Rows[0].HeightDisplay= vs.Rows[0].HeightDisplay*3;
			//vs.Styles["Fixed"].WordWrap=true;
			Init_Form();
			dt1.Value=dt2.Value=T_String.GetDate();
			vs.Cols["YYY_MM"].Format=dt1.CustomFormat=dt2.CustomFormat=PublicFunction.GetOption("DATE");
			this.Closed+=new EventHandler(frmTaDailyAttendanceList_Closed);	
			nav.cmd_add.Visible=false;
			nav.cmd_copy.Visible=false;
			nav.cmd_search.Visible=false;
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
			C1.C1Excel.C1XLBook c1XLBook1=new C1.C1Excel.C1XLBook();;
			//string sql="";			
			switch (mnu1.MenuItems.IndexOf((MenuItem)sender))
			{
				case 0:		
					GP8000.Personnel.Report.ReportFromVS rpt=new GP8000.Personnel.Report.ReportFromVS();
					rpt.RPT2(c1XLBook1,vs,mnu1.MenuItems[mnu1.MenuItems.IndexOf((MenuItem)sender)].Text,"STD_TA_04");					
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
			//Dep.vs1.KeyDown+=new KeyEventHandler(Dep_KeyDown);
			Init_vs();		
			InitCB();
			//vs.Tag="N";
			Basic.Function.PublicFunction.L_Init_Label(this);				
			//vs.Tag="";
			//Basic.Function.PublicFunction.L_Init_Label(vs,this.Name+"_vs");				
			//vs.Tag="N";

		}

		private void Init_vs()
		{			
			PublicFunction.InitNav(this,vs,nav);			
			//nav.Init_Control();
			vs.AllowEditing=false;	
			vs.Tag="";						
			vs.SelectionMode=C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;						
			//vs.EnabledChanged+=new EventHandler(vs_EnabledChanged);
			vs.KeyDown+=new KeyEventHandler(vs_KeyDown);
			nav.ToolBar_Auto=false;
			
			vs.SelectionMode=C1.Win.C1FlexGrid.SelectionModeEnum.CellRange; 

			nav.TBarClick+=new ToolBarButtonClickEventHandler(nav_TBarClick);
			vs.BeforeEdit+=new C1.Win.C1FlexGrid.RowColEventHandler(vs_BeforeEdit);
			vs.AfterEdit+=new C1.Win.C1FlexGrid.RowColEventHandler(vs_AfterEdit);			
		}	
		private void InitCB()
		{
			string sql;			
			//Department
			sql=PublicFunction.GetDep(this.Tag+"");			
			//vs.Cols["DEP_ID"].DataMap=PublicFunction.InitCBForVS(sql);				
		}
		#endregion
		#region ShowData
		private void Show_VS()
		{
			string sql,wh;
			if(Dep.vs1.Row<0)
			{
				vs.Rows.Count=1;
				return;
			}
			string dk=Dep.Get_Data("DEP_ID");
			if(ck.Checked)
			{		
				if(dk+""!="")
					sql="b.DEP_ID=N'"+Dep.Get_Data("DEP_ID")+"' and (DEL_BT=0 or DEL_BT is null) and (ATT_DT Between '"
						+((DateTime)dt1.Value).ToString("yyyy/MM/dd")+"' and '"
						+((DateTime)dt2.Value).ToString("yyyy/MM/dd")+"')";			
				else
				{
					sql="b.DEP_ID  in "+T_String.DEP_ID(this.Tag)+" and (DEL_BT=0 or DEL_BT is null) and (ATT_DT Between '"
						+((DateTime)dt1.Value).ToString("yyyy/MM/dd")+"' and '"
						+((DateTime)dt2.Value).ToString("yyyy/MM/dd")+"')";	
					
				}
			}
			else
			{		
				if(dk+""!="")
					sql="b.DEP_ID=N'"+Dep.Get_Data("DEP_ID")+"' and (DEL_BT=0 or DEL_BT is null)";				
				else
					sql="b.DEP_ID in "+T_String.DEP_ID(this.Tag)+" and (DEL_BT=0 or DEL_BT is null)";
			}
			wh=GetWh();		
			if (wh!="")
				sql+=" and ("+wh+")";	
			nav.Show_VS(sql);
			CheckCols();					
		}			
		
		private void CheckCols()
		{			
//			for(int i=1;i<vs.Rows.Count;i++)
//			{
//				if(vs.Rows[i]["VAC_BT"]+""=="True")
//				{
//					for(int c=1;c<vs.Cols.Count;c++)
//						vs.SetCellStyle(i,c, vs.Styles["VAC_BT"]);
//				}
//			}
		}
		private void Depvs1_AfterRowColChange(object sender, C1.Win.C1FlexGrid.RangeEventArgs e)
		{
			if(e.OldRange.r1!=e.NewRange.r1)
			{
				 txt_KeyDown(txt1,new KeyEventArgs(Keys.Enter));
//				Show_VS();
			}
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
						+"(a.YYY_MM Between '"+((DateTime)dt1.Value).ToString("yyyy/MM/dd")+"' and '"
						+((DateTime)dt2.Value).ToString("yyyy/MM/dd")+"') "
						+" and b.DEP_ID in (Select DEP_ID  from SYS_SECURITY_DEP"+
						" where MNU_ID="+this.Tag+" and ALL_BT=1 and USER_ID=N'"+PublicFunction.A_UserID+"')";
				else
					sql=sql+" and  (DEL_BT=0 or DEL_BT is null) and b.DEP_ID in (Select DEP_ID  from SYS_SECURITY_DEP"+
						" where MNU_ID="+this.Tag+" and ALL_BT=1 and USER_ID=N'"+PublicFunction.A_UserID+"')";

				string wh=GetWh();		
				if (wh!="")
					sql+=" and ("+wh+")";	
				nav.Show_VS(sql);	
				CheckCols();				
			}
		}
		#endregion		
		#region Tbar
		private void nav_TBarClick(object sender, ToolBarButtonClickEventArgs e)
		{		
			if (e.Button.Equals(nav.cmd_save))
			{				
				vs.Select();
				string dt=T_String.GetDate().ToString("yyyy/MM/dd HH:mm");
				for (int i=1;i<vs.Rows.Count;i++)
				{								
					if (T_String.IsNullTo0(vs.Rows[i].UserData+"")==1)
					{		
						string st=vs.Rows[i]["NOT_DR"]+"";
						if(st.IndexOf("Sign")<0)
							vs.Rows[i]["NOT_OR"]=vs.Rows[i]["NOT_DR"];
						vs.Rows[i]["NOT_DR"]=PublicFunction.A_UserID +" Sign";
						vs.Rows[i]["NOT_D1"]="";
						vs.Rows[i]["LOC_BT"]="True";
						double max=0;
						for(int j=1;j<=10;j++)
						{
							double c1=T_String.IsNullTo00(vs.Rows[i]["ONN_"+j.ToString("00")]+"");
							double c2=T_String.IsNullTo00(vs.Rows[i]["OFF_"+j.ToString("00")]+"");
							if(c2>c1 || c1>max)
							{
								string sql="update FILC01A set YSD_BT=0 where CRD_DT='"
									+DateTime.Parse(vs.Rows[i]["ATT_DT"]+"").AddDays(1).ToString("yyyy/MM/dd")+"'";
								PublicFunction.SQL_Execute(sql);
								break;
							}
						}	
						//							vs.Rows[i]["LST_NM"]=PublicFunction.A_UserID;
						//							vs.Rows[i]["LST_DT"]=dt;
					}											
				}					
			}						
			if (e.Button.Equals(nav.cmd_refresh))
			{				
				txt_KeyDown(txt1,new KeyEventArgs(Keys.Enter));
				return;
			}
			nav.ToolBar_Click(e);			
		}

		private void nav_Refresh(object sender, ToolBarButtonClickEventArgs e)
		{		
			if (e.Button.Equals(nav.cmd_save))
			{				
				vs.Select();
				string dt=T_String.GetDate().ToString("yyyy/MM/dd HH:mm");
				for (int i=1;i<vs.Rows.Count;i++)
				{								
					if (T_String.IsNullTo0(vs.Rows[i].UserData+"")==1)
					{		
						vs.Rows[i]["NOT_D1"]="";
						vs.Rows[i]["LOC_BT"]="True";
						double max=0;
						for(int j=1;j<=10;j++)
						{
							double c1=T_String.IsNullTo00(vs.Rows[i]["ONN_"+j.ToString("00")]+"");
							double c2=T_String.IsNullTo00(vs.Rows[i]["OFF_"+j.ToString("00")]+"");
							if(c2>c1 || c1>max)
							{
								string sql="update FILC01A set YSD_BT=0 where CRD_DT='"
									+DateTime.Parse(vs.Rows[i]["ATT_DT"]+"").AddDays(1).ToString("yyyy/MM/dd")+"'";
								PublicFunction.SQL_Execute(sql);
								break;
							}
						}	
						//							vs.Rows[i]["LST_NM"]=PublicFunction.A_UserID;
						//							vs.Rows[i]["LST_DT"]=dt;
					}											
				}					
			}						
			if (e.Button.Equals(nav.cmd_refresh))
			{				
				txt_KeyDown(txt1,new KeyEventArgs(Keys.Enter));
				//				if(txt1.Text!="")
				//					show_search(txt1.Text,txt1.Tag+"");
				//				else
				//				{
				//					if(txt2.Text!="")
				//						show_search(txt2.Text,txt2.Tag+"");
				//					else 					
				//					Show_VS();
				//				}
				return;
			}
			nav.ToolBar_Click(e);			
		}

		private void show_search(string txt,string tag)
		{		
			string f=tag;
			if(f=="EMP_ID")
				f="a."+f;
			string sql;				
			if(txt+""!="")
				sql=f+" like N'%"+txt+"%'";
			else
				sql="1=1";
			if(ck.Checked)
				sql=sql+" and  (DEL_BT=0 or DEL_BT is null) and "
					+"(ATT_DT Between '"+((DateTime)dt1.Value).ToString("yyyy/MM/dd")+"' and '"
					+((DateTime)dt2.Value).ToString("yyyy/MM/dd")+"') "
					+" and b.DEP_ID in (Select DEP_ID  from SYS_SECURITY_DEP"+
					" where MNU_ID="+this.Tag+" and ALL_BT=1 and USER_ID=N'"+PublicFunction.A_UserID+"')";
			else
				sql=sql+" and  (DEL_BT=0 or DEL_BT is null) and b.DEP_ID in (Select DEP_ID  from SYS_SECURITY_DEP"+
					" where MNU_ID="+this.Tag+" and ALL_BT=1 and USER_ID=N'"+PublicFunction.A_UserID+"')";
			string wh=GetWh();		
			if (wh!="")
				sql+=" and ("+wh+")";	
			nav.Show_VS(sql);				
			CheckCols();
		}

		#endregion
		#region event
		private void ck_CheckedChanged(object sender, System.EventArgs e)
		{
			dt1.Enabled=dt2.Enabled=ck.Checked;
		}

		private void frmTaDailyAttendanceList_Closed(object sender, EventArgs e)
		{
			nav.Save_SEQ();
		}

		private void vs_KeyDown(object sender, KeyEventArgs e)
		{		
			if(e.KeyCode==Keys.Insert)
			{
				int i=0;
				for(i=vs.Cols["OFF_10"].Index  ;i>=vs.Col+1 ;i--)
				{
					vs.Rows[vs.Row][i]=vs.Rows[vs.Row][i-1];
				}	
				
				vs.Rows[vs.Row].UserData=1;
				vs.Rows[vs.Row][vs.Col]="0";
				return;
			}
			
			if(e.KeyCode==Keys.Delete)
			{
				int i=0;
				for(i=vs.Col  ;i<=vs.Cols["OFF_10"].Index ;i++)
				{
					vs.Rows[vs.Row][i]=vs.Rows[vs.Row][i+1];
				}	
				
				vs.Rows[vs.Row].UserData=1;
				vs.Rows[vs.Row]["OFF_10"]="0";
				
				
			}
		}

		private void cmd_cal_Click(object sender, System.EventArgs e)
		{
			if(MessageBox.Show(this,PublicFunction.L_Get_Msg("msg",78),this.Text,MessageBoxButtons.YesNo)==DialogResult.No)
				return;
			ArrayList a=new ArrayList();
			for(int n=1;n<vs.Rows.Count;n++)
			{
				if(vs.Rows[n].UserData+""=="1")
				{
					a.Add(n);
					string st=vs.Rows[n]["NOT_DR"]+"";
					if(st.IndexOf("Sign")<0)
						
						vs.Rows[n]["NOT_OR"]=vs.Rows[n]["NOT_DR"];
				}
			}
			nav_TBarClick(nav.cmd_save,new ToolBarButtonClickEventArgs(nav.cmd_save));
			Func.RecordSet rsTypeShift=new Func.RecordSet("Select * from GP_SYS_SHIFT",PublicFunction.C_con);
			Func.RecordSet Set=new Func.RecordSet("Select * from GP_SYS_SETTING",PublicFunction.C_con);	
			SqlConnection con=new SqlConnection(PublicFunction.C_con.ConnectionString);
			if(con.State==ConnectionState.Closed )
				con.Open();
			int dem=0,i=0;
			for(int m=0;m<a.Count;m++)
			{
				i=(int)a[m];				
				string EMP_ID=vs.Rows[i]["EMP_ID"]+"";
				DateTime d1=DateTime.Parse(vs.Rows[i]["ATT_DT"]+"");

				string SHI_ID=vs.Rows[i]["SHI_ID"]+"";
				string sql="Select * from FILC02B where SHI_ID=N'"+SHI_ID+"' ORDER BY SEQ_NO";
				Func.RecordSet rsca=new Func.RecordSet(sql,con);	
				
				ArrayList Ca=new ArrayList();
				ArrayList ATT=new ArrayList();
				for(int j=0;j<rsca.rows;j++)
				{
					Ca.Add(rsca.record(j,"ONN_TM"));
					Ca.Add(rsca.record(j,"OFF_TM"));
				}
				Ca.Add(0);
				Ca.Add(0);
				Ca.Add(0);
				Ca.Add(0);
				for(int j=1;j<=10;j++)
				{
					ATT.Add(T_String.IsNullTo00(vs.Rows[i]["ONN_"+j.ToString("00")]+""));
					ATT.Add(T_String.IsNullTo00(vs.Rows[i]["OFF_"+j.ToString("00")]+""));						
				}	
				TaAttendance tm=new TaAttendance(EMP_ID,d1.ToString("yyyy/MM/dd"),con,Ca,ATT,SHI_ID,rsca,Set,rsTypeShift);			
				tm.tb="FILC06A";
				tm.NIG_TM=T_String.IsNullTo00(vs.Rows[i]["NIG_TM"]+"");
				tm.NOT_DD=vs.Rows[i]["NOT_DR"]+"";
				tm.UpdateSql();
				ForCal(EMP_ID,d1.ToString("yyyy/MM/dd"));
				dem++;				
			}
			int vat=T_String.GetMax("MAX(SEQ_NO)","FILC10A");
			for(int m=0;m<a.Count;m++)
			{
				string EMP_ID=vs.Rows[i]["EMP_ID"]+"";
				DateTime d1=DateTime.Parse(vs.Rows[i]["ATT_DT"]+"");
				TaAttendance.AbsentToVacate(EMP_ID,d1.ToString("yyyy/MM/dd"),con,"FILC06A");
			}
			if(T_String.GetMax("MAX(SEQ_NO)","FILC10A")>vat)
			{
				frmTaAbsentVacate dlg=new frmTaAbsentVacate();
				dlg.Tag=this.Tag;
				dlg.ShowDialog();
			}
			if(dem>0)
			{
				int row=vs.Row;
				nav.Show_VS(nav.Where+"");
				if(row>0 &&  vs.Rows.Count >1)
					vs.Row=row;
			}
			vs.Tag="";
			CheckCols();		
		}

		private void ForCal(string  EMP_ID,string d1)
		{		
			SqlConnection con=new SqlConnection(PublicFunction.C_con.ConnectionString);
			if(con.State==ConnectionState.Closed )
				con.Open();
			string sql="";
			sql="Select * from FILC08A where RUN_BT=1 order by SEQ_N1";
			Func.RecordSet rs=new Func.RecordSet(sql,con);
			try
			{
				for(int i=0;i<rs.rows;i++)
				{
					sql=" "+rs.record(i,"SQL_DR")+" ";
					if(sql+""!="")
					{				
						sql+=" and a.EMP_ID=N'"+EMP_ID+"' and ATT_DT='"+d1+"'" ;
						PublicFunction.SQL_Execute(sql,con,true);
					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);				
				return;
			}		
			
		}

		
		private void cmd_save_Click(object sender, System.EventArgs e)
		{
			if(MessageBox.Show(this,PublicFunction.L_Get_Msg("msg",79),this.Text,MessageBoxButtons.YesNo)==DialogResult.No)
				return;
			nav_TBarClick(nav.cmd_save,new ToolBarButtonClickEventArgs(nav.cmd_save));
			vs.Tag="";
		}

		private string GetWh()
		{
			string sql="";
			
			//tuyen them 20090407
			
//			if(txt1.Text+""!="")					
//				sql+=" EMP_ID like N'%"+txt1.Text+"%'";
//			if(txt2.Text+""!="")					
//				sql+=" EMP_I1 like N'%"+txt2.Text+"%'";
//			if(ck.Checked)
//				sql=sql+" and  (DEL_BT=0 or DEL_BT is null) and "
//					+"(ATT_DT Between '"+((DateTime)dt1.Value).ToString("yyyy/MM/dd")+"' and '"
//					+((DateTime)dt2.Value).ToString("yyyy/MM/dd")+"') "
//					+" and b.DEP_ID in (Select DEP_ID  from SYS_SECURITY_DEP"+
//					" where MNU_ID="+this.Tag+" and ALL_BT=1 and USER_ID=N'"+PublicFunction.A_UserID+"')";
//			else
//				sql=sql+" and  (DEL_BT=0 or DEL_BT is null) and b.DEP_ID in (Select DEP_ID  from SYS_SECURITY_DEP"+
//					" where MNU_ID="+this.Tag+" and ALL_BT=1 and USER_ID=N'"+PublicFunction.A_UserID+"')";
//			string wh=GetWh();		
//			if (wh!="")
//				sql+=" and ("+wh+")";	
//			nav.Show_VS(sql);	
//			CheckCols();		
			//tuyen them 20090407 end
			return sql;
		}
		private string GetWh(string sql,CheckBox ck,string st)
		{
			if(ck.Checked)
			{
				if(sql!="") sql+=" OR ";
				sql+="NOT_DR like N'%"+st+"%'";
			}
			return sql;
		}

		private void vs_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			if(vs.Rows[e.Row]["LOC_B1"]+""=="True")
			{
				if(PublicFunction.A_UserID!= vs.Rows[e.Row]["USR_CK"]+"" || vs.Cols[e.Col].Name!="LOC_B1")
					e.Cancel=true;
			}
			else
			{
				if(vs.Cols[e.Col].Name!="LOC_B1" && vs.Tag+""=="")
				{
					e.Cancel=true;
					//vs.AllowEditing=false;
				}
				else
				{
					e.Cancel=false;
					//vs.AllowEditing=true;
				}
			}
		}

		private void vs_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{			
			if(vs.Cols[e.Col].Name=="LOC_B1" && e.Row>0)
			{
				if(vs.Rows[e.Row]["LOC_B1"]+""=="True")
				{
					vs.Rows[e.Row]["USR_CK"]=PublicFunction.A_UserID;
				}
				else
				{
					vs.Rows[e.Row]["USR_CK"]="";
				}				
			}
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
			}
			else
			{
				tam=0;
			}
			sql="UPDATE FILC06A SET USR_CK='"+ vs.Rows[e.Row]["USR_CK"] +"',LOC_B1='"+ tam +"' where EMP_ID=N'"+vs.Rows[e.Row]["EMP_ID"]+"'";
			PublicFunction.SQL_Execute(sql);
			//nav.ToolBar_Click(new ToolBarButtonClickEventArgs(nav.cmd_save));
			//nav_Refresh(nav.cmd_save,new ToolBarButtonClickEventArgs(nav.cmd_save));
		}

		
		private void p1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			x=e.X;y=e.Y;
		}

		#endregion

		private void dt1_TextChanged(object sender, System.EventArgs e)
		{
			dt2.Value=dt1.Value;
		}

		private void txt2_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void txt1_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void vs_Click(object sender, System.EventArgs e)
		{
		
		}

		private void nav_Load(object sender, System.EventArgs e)
		{
		
		}
		
	}
}

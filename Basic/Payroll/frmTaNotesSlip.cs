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

namespace GP8000.Payroll
{
	/// <summary>
	/// Summary description for frmTaSalary.
	/// </summary>
	public class frmTaNotesSlip : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel4;
		private Navigator1._0.NavigatorAuto nav;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel5;
		private C1.Win.C1Command.C1CommandDock c1CommandDock1;
		private C1.Win.C1Command.C1DockingTab c1DockingTab1;
		private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage1;
		private GP8000.UserControl.CrtTaDepartment Dep;
		private Func.RecordSet rsitem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt2;
		private System.Windows.Forms.TextBox txt1;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private C1.Win.C1FlexGrid.C1FlexGrid vs;
		private System.Windows.Forms.Button cmd_add;
		private C1.Win.C1FlexGrid.C1FlexGrid vs1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cb;
		private System.Windows.Forms.Button cmd_cal;
		private C1.Win.C1Input.C1DateEdit dt;
		private System.Windows.Forms.Button cmd_round;		
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaNotesSlip()
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
			this.nav = new Navigator1._0.NavigatorAuto();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel8 = new System.Windows.Forms.Panel();
			this.vs = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.panel7 = new System.Windows.Forms.Panel();
			this.vs1 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.c1CommandDock1 = new C1.Win.C1Command.C1CommandDock();
			this.c1DockingTab1 = new C1.Win.C1Command.C1DockingTab();
			this.c1DockingTabPage1 = new C1.Win.C1Command.C1DockingTabPage();
			this.Dep = new GP8000.UserControl.CrtTaDepartment();
			this.panel2 = new System.Windows.Forms.Panel();
			this.cmd_round = new System.Windows.Forms.Button();
			this.dt = new C1.Win.C1Input.C1DateEdit();
			this.cmd_cal = new System.Windows.Forms.Button();
			this.cb = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cmd_add = new System.Windows.Forms.Button();
			this.txt2 = new System.Windows.Forms.TextBox();
			this.txt1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel8.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
			this.panel7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandDock1)).BeginInit();
			this.c1CommandDock1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).BeginInit();
			this.c1DockingTab1.SuspendLayout();
			this.c1DockingTabPage1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dt)).BeginInit();
			this.SuspendLayout();
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.panel4);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(964, 36);
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
			this.label5.Size = new System.Drawing.Size(548, 36);
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
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel5);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 36);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(964, 516);
			this.panel1.TabIndex = 7;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.panel6);
			this.panel5.Controls.Add(this.c1CommandDock1);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(0, 32);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(964, 484);
			this.panel5.TabIndex = 1;
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.panel8);
			this.panel6.Controls.Add(this.panel7);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panel6.Location = new System.Drawing.Point(260, 0);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(704, 484);
			this.panel6.TabIndex = 2;
			// 
			// panel8
			// 
			this.panel8.Controls.Add(this.vs);
			this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel8.Location = new System.Drawing.Point(0, 0);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(704, 416);
			this.panel8.TabIndex = 1;
			// 
			// vs
			// 
			this.vs.AllowEditing = false;
			this.vs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.vs.AutoResize = false;
			this.vs.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs.Location = new System.Drawing.Point(4, 4);
			this.vs.Name = "vs";
			this.vs.Size = new System.Drawing.Size(696, 408);
			this.vs.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs.TabIndex = 12;
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.MistyRose;
			this.panel7.Controls.Add(this.vs1);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel7.Location = new System.Drawing.Point(0, 416);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(704, 68);
			this.panel7.TabIndex = 0;
			// 
			// vs1
			// 
			this.vs1.AllowEditing = false;
			this.vs1.AutoResize = false;
			this.vs1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs1.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vs1.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs1.Location = new System.Drawing.Point(0, 0);
			this.vs1.Name = "vs1";
			this.vs1.Size = new System.Drawing.Size(704, 68);
			this.vs1.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs1.TabIndex = 13;
			this.vs1.Tag = "N";
			// 
			// c1CommandDock1
			// 
			this.c1CommandDock1.Controls.Add(this.c1DockingTab1);
			this.c1CommandDock1.Dock = System.Windows.Forms.DockStyle.Left;
			this.c1CommandDock1.Id = 1;
			this.c1CommandDock1.Location = new System.Drawing.Point(0, 0);
			this.c1CommandDock1.Name = "c1CommandDock1";
			this.c1CommandDock1.Size = new System.Drawing.Size(260, 484);
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
			this.c1DockingTab1.Size = new System.Drawing.Size(260, 484);
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
			this.c1DockingTabPage1.Size = new System.Drawing.Size(255, 482);
			this.c1DockingTabPage1.TabIndex = 0;
			this.c1DockingTabPage1.Text = "Page1";
			// 
			// Dep
			// 
			this.Dep.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Dep.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Dep.Location = new System.Drawing.Point(0, 20);
			this.Dep.Name = "Dep";
			this.Dep.Size = new System.Drawing.Size(255, 462);
			this.Dep.TabIndex = 2;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Moccasin;
			this.panel2.Controls.Add(this.cmd_round);
			this.panel2.Controls.Add(this.dt);
			this.panel2.Controls.Add(this.cmd_cal);
			this.panel2.Controls.Add(this.cb);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.cmd_add);
			this.panel2.Controls.Add(this.txt2);
			this.panel2.Controls.Add(this.txt1);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(964, 32);
			this.panel2.TabIndex = 0;
			// 
			// cmd_round
			// 
			this.cmd_round.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmd_round.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_round.Location = new System.Drawing.Point(652, 4);
			this.cmd_round.Name = "cmd_round";
			this.cmd_round.Size = new System.Drawing.Size(100, 24);
			this.cmd_round.TabIndex = 154;
			this.cmd_round.Text = "Back";
			this.cmd_round.Click += new System.EventHandler(this.cmd_round_Click);
			// 
			// dt
			// 
			this.dt.CustomFormat = "yyyyMM";
			this.dt.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt.Location = new System.Drawing.Point(76, 6);
			this.dt.Name = "dt";
			this.dt.Size = new System.Drawing.Size(88, 23);
			this.dt.TabIndex = 13;
			this.dt.Tag = null;
			// 
			// cmd_cal
			// 
			this.cmd_cal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmd_cal.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_cal.Location = new System.Drawing.Point(860, 4);
			this.cmd_cal.Name = "cmd_cal";
			this.cmd_cal.Size = new System.Drawing.Size(100, 24);
			this.cmd_cal.TabIndex = 153;
			this.cmd_cal.Text = "Cal";
			this.cmd_cal.Click += new System.EventHandler(this.cmd_cal_Click);
			// 
			// cb
			// 
			this.cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb.Location = new System.Drawing.Point(260, 4);
			this.cb.Name = "cb";
			this.cb.Size = new System.Drawing.Size(144, 24);
			this.cb.TabIndex = 152;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(168, 8);
			this.label2.Name = "label2";
			this.label2.TabIndex = 151;
			this.label2.Text = "label2";
			// 
			// cmd_add
			// 
			this.cmd_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmd_add.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_add.Location = new System.Drawing.Point(756, 4);
			this.cmd_add.Name = "cmd_add";
			this.cmd_add.Size = new System.Drawing.Size(100, 24);
			this.cmd_add.TabIndex = 150;
			this.cmd_add.Text = "Back";
			this.cmd_add.Click += new System.EventHandler(this.cmd_add_Click);
			// 
			// txt2
			// 
			this.txt2.BackColor = System.Drawing.Color.PeachPuff;
			this.txt2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt2.Location = new System.Drawing.Point(508, 4);
			this.txt2.MaxLength = 20;
			this.txt2.Name = "txt2";
			this.txt2.Size = new System.Drawing.Size(96, 23);
			this.txt2.TabIndex = 147;
			this.txt2.Tag = "EMP_I1";
			this.txt2.Text = "textBox3";
			this.txt2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
			this.txt2.Leave += new System.EventHandler(this.txt_Leave);
			this.txt2.Enter += new System.EventHandler(this.txt_Enter);
			// 
			// txt1
			// 
			this.txt1.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt1.Location = new System.Drawing.Point(408, 4);
			this.txt1.MaxLength = 20;
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(96, 23);
			this.txt1.TabIndex = 146;
			this.txt1.Tag = "EMP_ID";
			this.txt1.Text = "textBox3";
			this.txt1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
			this.txt1.Leave += new System.EventHandler(this.txt_Leave);
			this.txt1.Enter += new System.EventHandler(this.txt_Enter);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(4, 8);
			this.label1.Name = "label1";
			this.label1.TabIndex = 0;
			this.label1.Text = "label1";
			// 
			// frmTaNotesSlip
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(964, 552);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaNotesSlip";
			this.Text = "frmTaNotesSlip";
			this.Load += new System.EventHandler(this.frmTaSalary_Load);
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			this.panel7.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandDock1)).EndInit();
			this.c1CommandDock1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).EndInit();
			this.c1DockingTab1.ResumeLayout(false);
			this.c1DockingTabPage1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dt)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaSalary_Load(object sender, System.EventArgs e)
		{
			Init_vs();			
			Dep.Init_Tree(this.Tag+"");
			Dep.vs1.AfterRowColChange+=new C1.Win.C1FlexGrid.RangeEventHandler(depvs1_AfterRowColChange);
			Dep.Show_Tree();
			Init_CB();
			Basic.Function.PublicFunction.L_Init_Label(this);	
			dt.Value=T_String.GetDate();
//			if(wh+""!="")
//				nav.Show_VS("a.EMP_ID=N'"+wh+"'");
							
		}	
		#region Init
		private void Init_vs()
		{
			nav.cmd_copy.Visible=false;
			nav.cmd_delete.Visible=false;
			nav.cmd_report.Visible=false;
			nav.cmd_search.Visible=false;
			nav.cmd_add.Visible=false;			
			nav.sql="SELECT a.EMP_ID,EMP_I1,EMP_NM,DEP_ID,POS_ID,LEV_ID,YYY_MM,SEQ_NO,AMT_QT,AMT_Q1";
			string sql="";
			sql="Select * from FILD05A order by MON_QT";
			rsitem=new Func.RecordSet(sql,PublicFunction.C_con);
			vs1.Cols.Count=rsitem.rows+1;
			vs1.Rows.Count=2;
			for(int i=1;i<=12;i++)
			{
				nav.sql+=",[COL_"+i.ToString("00")+"]";
			}
			nav.sql+=",a.BLT_NM,a.BLT_DT,a.LST_NM,a.LST_DT";
			nav.sql+=" from FILD06A a Left JOIN FILB01A b on a.EMP_ID=b.EMP_ID";
			nav.tb="FILD06A";
			PublicFunction.InitNav(this,vs,nav);		
			nav.Msg_ExitSave=true;					
			
			vs.EnabledChanged+=new EventHandler(vs_EnabledChanged);						
		
		
			for(int i=1;i<=12;i++)
			{					
				vs.Cols["COL_"+i.ToString("00")].Format="#,###";
			}
			
			
			Init_Color();
			vs.Cols.Frozen=vs.Cols["EMP_NM"].Index;
			vs.Cols["EMP_I1"].AllowEditing=false;
			vs.Cols["EMP_NM"].AllowEditing=false;
			vs.Cols["DEP_ID"].AllowEditing=false;
			vs.Cols["POS_ID"].AllowEditing=false;
			vs.Cols["LEV_ID"].AllowEditing=false;

			vs.Cols["BLT_NM"].AllowEditing=false;
			vs.Cols["BLT_DT"].AllowEditing=false;
			vs.Cols["LST_NM"].AllowEditing=false;
			vs.Cols["LST_DT"].AllowEditing=false;
			
		}
	
		private void Init_Color()
		{
			nav.Lock=new ArrayList();
			nav.Lock.Add("EMP_I1");
			nav.Lock.Add("EMP_NM");		
			nav.Lock.Add("POS_ID");
			nav.Lock.Add("LEV_ID");
//			nav.Lock.Add("BLT_DT");
//			nav.Lock.Add("BLT_NM");
//			nav.Lock.Add("LST_DT");
//			nav.Lock.Add("LST_NM");
			nav.Lock.Add("SEQ_NO");
//			nav.Lock.Add("REA_DR");
			nav.Color_VS();
		}
		private void  Init_CB()
		{			
			string sql;			
			//Department
			sql=PublicFunction.GetDep(this.Tag+"");			
			vs.Cols["DEP_ID"].DataMap=PublicFunction.InitCBForVS(sql);						
			//Position
			sql="Select POS_ID,POS_NM from FILA07A";		
			vs.Cols["POS_ID"].DataMap=PublicFunction.InitCBForVS(sql);						
			//Level
			sql="Select LEV_ID,LEV_NM from FILA19A";
			vs.Cols["LEV_ID"].DataMap=PublicFunction.InitCBForVS(sql);		

			sql="Select [ID] as SEQ_NO,"+PublicFunction.L_Lag+" from SYS_LABEL where [NAME]=N'frmTaNotesSlip_Type'";
			PublicFunction.InitCB(cb,sql,false);
		}

		private void depvs1_AfterRowColChange(object sender, C1.Win.C1FlexGrid.RangeEventArgs e)
		{
			if(e.OldRange.r1!=e.NewRange.r1)
			{
				nav.Show_VS("DEP_ID=N'"+Dep.Get_Data("DEP_ID")+"' and (DEL_BT=0 or DEL_BT is null)  and  "+PublicFunction.Get_TYP(this.Tag,""));
				Show_vs();				
			}
		}
		#endregion
		#region Show_vs
		private void Show_vs()
		{
			for(int c=1;c<vs1.Cols.Count;c++)
			{
				double count=0;
				for(int i=1;i<vs.Rows.Count;i++)
				{
					count+=T_String.IsNullTo00(vs.Rows[i][vs1.Cols[c].Name]+"");
				}
				vs1.Rows[1][c]=count;
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
				string f=((TextBox)sender).Tag+"";
				if(f=="EMP_ID")
					f="a."+f;				
				
				string sql;				
				if(((TextBox)sender).Text+""!="")
					sql=f+" like N'%"+((TextBox)sender).Text+"%'";
				else
					sql="1=1";
//				if(ck.Checked)
//					sql=sql+" and  (DEL_BT=0 or DEL_BT is null) and "
//						+"(ATT_DT Between '"+((DateTime)dt1.Value).ToString("yyyy/MM/dd")+"' and '"
//						+((DateTime)dt2.Value).ToString("yyyy/MM/dd")+"') "
//						+" and b.DEP_ID in (Select DEP_ID  from SYS_SECURITY_DEP"+
//						" where MNU_ID="+this.Tag+" and ALL_BT=1 and USER_ID=N'"+PublicFunction.A_UserID+"')";
//				else
				
					sql=sql+" and YYY_MM=N'"+dt.Text+"' and  (DEL_BT=0 or DEL_BT is null) and DEP_ID in (Select DEP_ID  from SYS_SECURITY_DEP"+
						" where MNU_ID="+this.Tag+" and ALL_BT=1 and USER_ID=N'"+PublicFunction.A_UserID+"')  and  "+PublicFunction.Get_TYP(this.Tag,"");
					
//				if (wh!="")
//					sql+=" and ("+wh+")";					
				nav.Show_VS(sql);	
				Show_vs();				
			}
		}
		#endregion	
		#region Event
		private void vs_EnabledChanged(object sender, EventArgs e)
		{			
			string sql="Select * from FILD05A order by MON_QT DESC";			
			Func.RecordSet rs=new Func.RecordSet(sql,PublicFunction.C_con);
			vs1.Cols.Count=rs.rows+1;
			vs1.Rows.Count=2;
			for(int i=1;i<=12;i++)
			{
				vs.Cols["COL_"+i.ToString("00")].Visible=false;
			}
			for(int i=0;i<rs.rows;i++)
			{
				try
				{				
					vs1.Cols[i+1].Name =rs.record(i,"COL_NO");				
					vs1.Cols[i+1].Caption=T_String.IsNullTo00(rs.record(i,"MON_QT")).ToString("#,###");	

					vs.Cols[rs.record(i,"COL_NO")].Visible=true;
					vs.Cols[rs.record(i,"COL_NO")].Caption=T_String.IsNullTo00(rs.record(i,"MON_QT")).ToString("#,###");				
				}
				catch{}
			}
			txt1.Text=vs.Cols[txt1.Tag+""].Caption;
			txt2.Text=vs.Cols[txt2.Tag+""].Caption;
//			//txt3.Text=vs.Cols[txt3.Tag+""].Caption;	
			vs.AutoSizeCols();
		}

	

		#endregion

		private void cmd_add_Click(object sender, System.EventArgs e)
		{
			frmTaAddNote dlg=new frmTaAddNote();
			dlg.Tag=this.Tag;
			dlg.ShowDialog();			
			vs_EnabledChanged(vs,new EventArgs());			
		}

		private void cmd_cal_Click(object sender, System.EventArgs e)
		{
			frmTaNotesSlipCal dlg=new frmTaNotesSlipCal();
			dlg.Tag=this.Tag;
			dlg.ShowDialog();
		}

		private void cmd_round_Click(object sender, System.EventArgs e)
		{
			frmTaRound dlg=new frmTaRound();
			dlg.Tag=this.Tag;
			dlg.ShowDialog();			
		}

		
	}
}

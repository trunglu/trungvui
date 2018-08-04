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

namespace GP8000.Personnel
{
	/// <summary>
	/// Summary description for frmTaSalaryInput.
	/// </summary>
	public class frmTaATM : System.Windows.Forms.Form
	{
		private Boolean ACC;
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
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Panel panel9;
		private Navigator1._0.NavigatorAuto nav1;
		private Navigator1._0.NavigatorAuto nav;
		private C1.Win.C1FlexGrid.C1FlexGrid vs1;
		public string ACC_NO,ACC_NM,BNK_NM;
		
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		
		public frmTaATM(string wh,C1.Win.C1FlexGrid.C1FlexGrid vs3)
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

		public frmTaATM()
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
			this.vs = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.panel9 = new System.Windows.Forms.Panel();
			this.nav = new Navigator1._0.NavigatorAuto();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.panel7 = new System.Windows.Forms.Panel();
			this.vs1 = new C1.Win.C1FlexGrid.C1FlexGrid();
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
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel8.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
			this.panel7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs1)).BeginInit();
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
			this.panel5.Controls.Add(this.panel7);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(0, 28);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(696, 456);
			this.panel5.TabIndex = 5;
			// 
			// panel8
			// 
			this.panel8.Controls.Add(this.vs);
			this.panel8.Controls.Add(this.panel9);
			this.panel8.Controls.Add(this.nav);
			this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel8.Location = new System.Drawing.Point(0, 191);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(696, 265);
			this.panel8.TabIndex = 13;
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
			this.vs.Location = new System.Drawing.Point(4, 38);
			this.vs.Name = "vs";
			this.vs.Size = new System.Drawing.Size(688, 226);
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
			this.splitter1.Location = new System.Drawing.Point(0, 188);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(696, 3);
			this.splitter1.TabIndex = 12;
			this.splitter1.TabStop = false;
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.vs1);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(696, 188);
			this.panel7.TabIndex = 11;
			// 
			// vs1
			// 
			this.vs1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.vs1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs1.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vs1.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs1.Location = new System.Drawing.Point(4, 4);
			this.vs1.Name = "vs1";
			this.vs1.Size = new System.Drawing.Size(688, 184);
			this.vs1.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs1.TabIndex = 11;
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
			this.panel6.Size = new System.Drawing.Size(696, 28);
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
			this.label5.Location = new System.Drawing.Point(348, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(348, 36);
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
			this.panel4.Size = new System.Drawing.Size(348, 36);
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
			// frmTaATM
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(960, 520);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.c1CommandDock1);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaATM";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmTaATM";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmTaSalaryInput_Load);
			this.Closed += new System.EventHandler(this.frmTaATM_Closed);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			this.panel7.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs1)).EndInit();
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
			if(wh+""!="")
			{
				nav1.Show_VS("EMP_ID=N'"+wh+"'");
				Show_VS1();
			}
							
		}	
		#region Init
		private void Init_vs()
		{
			nav.cmd_copy.Visible=false;						
			nav.cmd_delete.Visible=false;
			nav.cmd_report.Visible=false;
			nav.cmd_search.Visible=false;		
			nav.cmd_exit.Visible=false;		
			PublicFunction.InitNav(this,vs,nav);	
			vs.EnabledChanged+=new EventHandler(vs_EnabledChanged);
			vs.BeforeEdit+=new RowColEventHandler(vs_BeforeEdit);
			nav.TBarClick+=new ToolBarButtonClickEventHandler(nav_TBarClick);
			nav.ToolBar_Auto=false;
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
			nav1.TBarClick+=new ToolBarButtonClickEventHandler(nav1_TBarClick);
			nav1.ToolBar_Auto=false;
		}	
		
		private void Init_Color()
		{
			nav.Lock=new ArrayList();			
			nav.Lock.Add("BLT_DT");
			nav.Lock.Add("BLT_NM");
			nav.Lock.Add("LST_DT");
			nav.Lock.Add("LST_NM");
			nav.Lock.Add("SEQ_NO");
			nav.Lock.Add("REA_DR");
			nav.Color_VS();
		}
		private void  Init_CB()
		{			
			string sql;			
			//Department
			sql=PublicFunction.GetDep(this.Tag+"");			
			vs1.Cols["DEP_ID"].DataMap=PublicFunction.InitCBForVS(sql);						
			//Position
			sql="Select POS_ID,POS_NM from FILA07A";		
			vs1.Cols["POS_ID"].DataMap=PublicFunction.InitCBForVS(sql);						
			//Level
			sql="Select LEV_ID,LEV_NM from FILA19A";
			vs1.Cols["LEV_ID"].DataMap=PublicFunction.InitCBForVS(sql);		
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
			if(vs1.Row<=0)
			{
				vs.Rows.Count=1;			
				return;
			}
			nav.Show_VS("EMP_ID=N'"+vs1.Rows[vs1.Row]["EMP_ID"]+"' ");					
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
					sql=f+" like N'%"+((TextBox)sender).Text+"%'";
				else
					sql="1=1";
				sql=sql+" and DEP_ID in (Select DEP_ID  from SYS_SECURITY_DEP"+
					" where MNU_ID="+this.Tag+" and ALL_BT=1  and USER_ID=N'"+PublicFunction.A_UserID+"')";					
				nav1.Show_VS(sql);	
				Show_VS1();	
			}
		}
	
		
		#endregion
		private void nav_TBarClick(object sender, ToolBarButtonClickEventArgs e)
		{	
			if (e.Button.Equals(nav.cmd_add))
			{
				if(vs1.Row<=0)
					return;
				if(vs.Rows[vs.Rows.Count-1].UserData+""=="2")
					return;
				nav.ToolBar_Click(e);						
				vs.Rows[vs.Rows.Count-1]["EMP_ID"]=vs1.Rows[vs1.Row]["EMP_ID"];	
				int max=T_String.GetMax("MAX(SEQ_NO)","FILB06A","EMP_ID=N'"+vs1.Rows[vs1.Row]["EMP_ID"]+"'");
				vs.Rows[vs.Rows.Count-1]["SEQ_NO"]=max;
				Func.RecordSet rs=new Func.RecordSet("Select * from FILB06A where EMP_ID=N'"+vs1.Rows[vs1.Row]["EMP_ID"]+"' and SEQ_NO="+(max-1),PublicFunction.C_con);
				if(rs.rows>0)
				{
					vs.Rows[vs.Rows.Count-1]["ACC_NO"]=rs.record(0,"ACC_NO");
					vs.Rows[vs.Rows.Count-1]["ACC_NM"]=rs.record(0,"ACC_NM");
					vs.Rows[vs.Rows.Count-1]["BNK_NM"]=rs.record(0,"BNK_NM");
				}
				vs.Rows[vs.Rows.Count-1]["BLT_NM"]=PublicFunction.A_UserID;
				vs.Rows[vs.Rows.Count-1]["BLT_DT"]=T_String.GetDate().ToString("yyyy/MM/dd HH:mm");

				return;
			}
			if (e.Button.Equals(nav.cmd_save))
			{		
				if(vs1.Row<=0)
					return;
				nav.ToolBar_Click(e);
				int max=T_String.GetMax("MAX(SEQ_NO)","FILB06A","EMP_ID=N'"+vs1.Rows[vs1.Row]["EMP_ID"]+"'");
				Func.RecordSet rs=new Func.RecordSet("Select * from FILB06A where EMP_ID=N'"+vs1.Rows[vs1.Row]["EMP_ID"]+"' and SEQ_NO="+(max-1),PublicFunction.C_con);
				string sql="";
				if(rs.rows>0)
				{
					sql="update FILB01A set ACC_NO=N'"+rs.record(0,"ACC_NO")+"',"
						+"ACC_NM=N'"+rs.record(0,"ACC_NM")+"',"
						+"BNK_NM=N'"+rs.record(0,"BNK_NM")+"' where EMP_ID=N'"+vs1.Rows[vs1.Row]["EMP_ID"]+"'";					
				}
				else
					sql="update FILB01A set ACC_NO=Default,ACC_NM=Default,BNK_NM=Default where EMP_ID=N'"+vs1.Rows[vs1.Row]["EMP_ID"]+"'";					
				PublicFunction.SQL_Execute(sql);
				return;
			}		
			if (e.Button.Equals(nav.cmd_refresh))
			{
				if(nav.wh!="")
					nav.ToolBar_Click(e);				
				return;
			}
			nav.ToolBar_Click(e);
		}

		private void nav1_TBarClick(object sender, ToolBarButtonClickEventArgs e)
		{	
			if (e.Button.Equals(nav1.cmd_refresh))
			{
				if(nav1.wh!="")
					nav1.ToolBar_Click(e);
				else
					nav1.Show_VS("DEP_ID in "+T_String.DEP_ID(this.Tag));				
				return;
			}
			nav1.ToolBar_Click(e);								
		}

		private void vs_EnabledChanged(object sender, EventArgs e)
		{	
			txt1.Text=vs1.Cols[txt1.Tag+""].Caption;
			txt2.Text=vs1.Cols[txt2.Tag+""].Caption;
			txt3.Text=vs1.Cols[txt3.Tag+""].Caption;	
			vs.AutoSizeCols();
		}

		private void vs_CellButtonClick(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			string sql="";
			sql="Select EMP_ID,EMP_I1,EMP_NM,DEP_ID,POS_ID,LEV_ID from FILB01A where (VAC_BT is null or VAC_BT=0) and DEP_ID in (Select DEP_ID  from SYS_SECURITY_DEP"+
				" where MNU_ID="+this.Tag+" and ALL_BT=1 and USER_ID=N'"+PublicFunction.A_UserID+"')";
			if(vs.Rows[vs.Row]["DEP_ID"]+""!="")
				sql+=" and DEP_ID=N'"+vs.Rows[vs.Row]["DEP_ID"]+"'";
			Func.RecordSet rs=new Func.RecordSet(sql,PublicFunction.C_con);
			frmSearch dlg=new frmSearch(rs,3,"frmTaStaffInfo_vs");
			if(dlg.ShowDialog()==DialogResult.OK)
			{
				vs.Rows[vs.Row]["EMP_ID"]=rs.record(rs.Bookmarks,"EMP_ID");
			}
			vs.AutoSizeCols();
		}

		private void vs_BeforeEdit(object sender, RowColEventArgs e)
		{
			if(vs.Rows[e.Row].UserData+""!="2")
				e.Cancel=true;			
		}

		
		private void vs1_AfterRowColChange(object sender, RangeEventArgs e)
		{
			if(e.NewRange.r1!=e.OldRange.r1)
				Show_VS1();
		}

		private void frmTaATM_Closed(object sender, System.EventArgs e)
		{			
			int max=T_String.GetMax("MAX(SEQ_NO)","FILB06A","EMP_ID=N'"+wh+"'");
			Func.RecordSet rs=new Func.RecordSet("Select * from FILB06A where EMP_ID=N'"+wh+"' and SEQ_NO="+(max-1),PublicFunction.C_con);			
			if(rs.rows>0)
			{
				ACC_NO=rs.record(0,"ACC_NO");
				ACC_NM=rs.record(0,"ACC_NM");
				BNK_NM=rs.record(0,"BNK_NM");
			}
			else				
			{
				ACC_NO=ACC_NM=BNK_NM="";
			}			
		}
	}
}

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Basic.Form;
using Basic.Function;

namespace GP8000.Database
{
	/// <summary>
	/// Summary description for frmTaBonusAndFined.
	/// </summary>
	public class frmTaBonusAndFined : System.Windows.Forms.Form
	{
		private C1.Win.C1FlexGrid.C1FlexGrid vs;
		private System.Windows.Forms.Panel panel1;
		private C1.Win.C1Command.C1CommandDock c1CommandDock1;
		private C1.Win.C1Command.C1DockingTab c1DockingTab1;
		private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label5;
		private C1.Win.C1FlexGrid.C1FlexGrid vs1;
		private Navigator1._0.NavigatorAuto nav1;
		private Navigator1._0.NavigatorAuto nav;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaBonusAndFined()
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
			this.nav1 = new Navigator1._0.NavigatorAuto();
			this.vs = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.panel1 = new System.Windows.Forms.Panel();
			this.c1CommandDock1 = new C1.Win.C1Command.C1CommandDock();
			this.c1DockingTab1 = new C1.Win.C1Command.C1DockingTab();
			this.c1DockingTabPage1 = new C1.Win.C1Command.C1DockingTabPage();
			this.panel2 = new System.Windows.Forms.Panel();
			this.nav = new Navigator1._0.NavigatorAuto();
			this.vs1 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandDock1)).BeginInit();
			this.c1CommandDock1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).BeginInit();
			this.c1DockingTab1.SuspendLayout();
			this.c1DockingTabPage1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs1)).BeginInit();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
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
			this.nav1.Location = new System.Drawing.Point(0, 2);
			this.nav1.MSG_Exit = false;
			this.nav1.MulltiDel = false;
			this.nav1.Name = "nav1";
			this.nav1.Security = 0;
			this.nav1.ShowPopupMenu = false;
			this.nav1.Size = new System.Drawing.Size(392, 32);
			this.nav1.TabIndex = 9;
			this.nav1.ToolBar_Auto = true;
			this.nav1.UserID = null;
			this.nav1.VisibleGrid = true;
			this.nav1.Where = null;
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
			this.vs.Location = new System.Drawing.Point(4, 60);
			this.vs.Name = "vs";
			this.vs.Size = new System.Drawing.Size(272, 328);
			this.vs.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs.TabIndex = 23;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.c1CommandDock1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(768, 396);
			this.panel1.TabIndex = 24;
			// 
			// c1CommandDock1
			// 
			this.c1CommandDock1.Controls.Add(this.c1DockingTab1);
			this.c1CommandDock1.Dock = System.Windows.Forms.DockStyle.Left;
			this.c1CommandDock1.Id = 1;
			this.c1CommandDock1.Location = new System.Drawing.Point(0, 0);
			this.c1CommandDock1.Name = "c1CommandDock1";
			this.c1CommandDock1.Size = new System.Drawing.Size(284, 396);
			// 
			// c1DockingTab1
			// 
			this.c1DockingTab1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
			this.c1DockingTab1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.c1DockingTab1.CanAutoHide = true;
			this.c1DockingTab1.CanCloseTabs = true;
			this.c1DockingTab1.CanMoveTabs = true;
			this.c1DockingTab1.Controls.Add(this.c1DockingTabPage1);
			this.c1DockingTab1.Location = new System.Drawing.Point(0, 0);
			this.c1DockingTab1.Name = "c1DockingTab1";
			this.c1DockingTab1.SelectedIndex = 0;
			this.c1DockingTab1.ShowCaption = true;
			this.c1DockingTab1.ShowSingleTab = false;
			this.c1DockingTab1.Size = new System.Drawing.Size(284, 396);
			this.c1DockingTab1.TabIndex = 0;
			this.c1DockingTab1.TabSizeMode = C1.Win.C1Command.TabSizeModeEnum.Fit;
			this.c1DockingTab1.TabStyle = C1.Win.C1Command.TabStyleEnum.WindowsXP;
			// 
			// c1DockingTabPage1
			// 
			this.c1DockingTabPage1.Controls.Add(this.vs);
			this.c1DockingTabPage1.Controls.Add(this.nav);
			this.c1DockingTabPage1.ImageIndex = -1;
			this.c1DockingTabPage1.Location = new System.Drawing.Point(1, 1);
			this.c1DockingTabPage1.Name = "c1DockingTabPage1";
			this.c1DockingTabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.c1DockingTabPage1.Size = new System.Drawing.Size(279, 394);
			this.c1DockingTabPage1.TabIndex = 0;
			this.c1DockingTabPage1.Tag = "N";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Controls.Add(this.vs1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(284, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(484, 396);
			this.panel2.TabIndex = 25;
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
			this.nav.Location = new System.Drawing.Point(4, 24);
			this.nav.MSG_Exit = false;
			this.nav.MulltiDel = false;
			this.nav.Name = "nav";
			this.nav.Security = 0;
			this.nav.ShowPopupMenu = false;
			this.nav.Size = new System.Drawing.Size(304, 32);
			this.nav.TabIndex = 10;
			this.nav.ToolBar_Auto = true;
			this.nav.UserID = null;
			this.nav.VisibleGrid = true;
			this.nav.Where = null;
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
			this.vs1.Location = new System.Drawing.Point(4, 40);
			this.vs1.Name = "vs1";
			this.vs1.Size = new System.Drawing.Size(476, 352);
			this.vs1.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs1.TabIndex = 24;
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
			this.panel3.Size = new System.Drawing.Size(484, 36);
			this.panel3.TabIndex = 25;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.nav1);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(428, 36);
			this.panel4.TabIndex = 0;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Location = new System.Drawing.Point(428, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 36);
			this.label5.TabIndex = 12;
			this.label5.Tag = "";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmTaBonusAndFined
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(768, 396);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaBonusAndFined";
			this.Text = "frmTaBonusAndFined";
			this.Load += new System.EventHandler(this.frmTaBonusAndFined_Load);
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandDock1)).EndInit();
			this.c1CommandDock1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).EndInit();
			this.c1DockingTab1.ResumeLayout(false);
			this.c1DockingTabPage1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs1)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaBonusAndFined_Load(object sender, System.EventArgs e)
		{
			nav.cmd_copy.Visible=false;
			nav.cmd_report.Visible=false;
			nav.cmd_search.Visible=false;
			PublicFunction.InitNav(this,vs,nav);			
			nav.Msg_ExitSave=true;
			nav.Show_VS();	
		
			nav1.cmd_copy.Visible=false;
			nav1.cmd_report.Visible=false;
			nav1.cmd_search.Visible=false;
			PublicFunction.InitNav(this,vs1,nav1);			
			nav.Msg_ExitSave=true;

			show_vs1();	
							
			nav.ToolBar_Auto=false;
			Basic.Function.PublicFunction.L_Init_Label(this);	
			nav.TBarClick+=new ToolBarButtonClickEventHandler(nav_TBarClick);		
			nav1.TBarClick+=new ToolBarButtonClickEventHandler(nav1_TBarClick);	
			vs1.Cols["AMT_QT"].Format="#,###";
			nav1.ToolBar_Auto=false;
			string sql="Select VAC_ID,VAC_NM from FILA06A";
			vs1.Cols["VAC_ID"].DataMap=PublicFunction.InitCBForVS(sql);
			vs.AfterRowColChange+=new C1.Win.C1FlexGrid.RangeEventHandler(vs_AfterRowColChange);
			vs1.Cols["TPE_ID"].DataType=typeof(Boolean);
		}	
		private void show_vs1()
		{
			if(vs.Row<1)
			{
				vs1.Rows.Count=1;
				return;
			}
			nav1.Show_VS("a.BAF_ID=N'"+vs.Rows[vs.Row]["BAF_ID"]+"'");
		}
		
		private void nav_TBarClick(object sender, ToolBarButtonClickEventArgs e)
		{					
			if (e.Button.Equals(nav.cmd_add))
			{
				if (vs.Rows.Count==1 || (int)vs.Rows[vs.Rows.Count-1].UserData!=2)					
					nav.ToolBar_Click(e);									
				vs.Rows[vs.Rows.Count-1]["BAF_ID"]=T_String.GetMax("MAX(BAF_ID)","FILA13A").ToString("000");
				return;
			}
			nav.ToolBar_Click(e);
		}

		private void nav1_TBarClick(object sender, ToolBarButtonClickEventArgs e)
		{					
			if (e.Button.Equals(nav1.cmd_add))
			{
				if(vs1.Rows[vs1.Row].UserData+""=="2" && vs1.Row<1)
					return;
				nav1.ToolBar_Click(e);
				vs1.Rows[vs1.Rows.Count-1]["BAF_ID"]=vs.Rows[vs.Row]["BAF_ID"];				
				vs1.Rows[vs1.Rows.Count-1]["BAF_NM"]=vs.Rows[vs.Row]["BAF_NM"];				
				vs1.Rows[vs1.Rows.Count-1]["TPE_ID"]=vs.Rows[vs.Row]["TPE_ID"];				
				return;
			}	
			nav1.ToolBar_Click(e);
		}

		private void vs_AfterRowColChange(object sender, C1.Win.C1FlexGrid.RangeEventArgs e)
		{
			if(e.NewRange.r1!=e.OldRange.r1)
				show_vs1();
		}
	}
}

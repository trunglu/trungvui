using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Basic.Form;
using Basic.Function;

namespace GP8000.Product
{
	/// <summary>
	/// Summary description for frmTaStyle.
	/// </summary>
	public class frmTaStyle : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel4;
		private Navigator1._0.NavigatorAuto nav;
		private System.Windows.Forms.Panel panel2;
		private C1.Win.C1FlexGrid.C1FlexGrid vs;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel panel5;
		private Navigator1._0.NavigatorAuto nav1;
		private C1.Win.C1FlexGrid.C1FlexGrid vs1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaStyle()
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
			this.panel5 = new System.Windows.Forms.Panel();
			this.vs1 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.nav1 = new Navigator1._0.NavigatorAuto();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.panel2 = new System.Windows.Forms.Panel();
			this.vs = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.nav = new Navigator1._0.NavigatorAuto();
			this.panel1.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs1)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel5);
			this.panel1.Controls.Add(this.splitter1);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 36);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(704, 412);
			this.panel1.TabIndex = 14;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.vs1);
			this.panel5.Controls.Add(this.nav1);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(0, 232);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(704, 180);
			this.panel5.TabIndex = 2;
			// 
			// vs1
			// 
			this.vs1.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.Both;
			this.vs1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs1.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vs1.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs1.Location = new System.Drawing.Point(0, 32);
			this.vs1.Name = "vs1";
			this.vs1.Size = new System.Drawing.Size(704, 148);
			this.vs1.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs1.TabIndex = 11;
			// 
			// nav1
			// 
			this.nav1.BackColor = System.Drawing.SystemColors.Control;
			this.nav1.Connection = null;
			this.nav1.ConnectionDel = null;
			this.nav1.Dock = System.Windows.Forms.DockStyle.Top;
			this.nav1.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.nav1.form = null;
			this.nav1.FormName = null;
			this.nav1.Grid = null;
			this.nav1.History = false;
			this.nav1.IsNull = true;
			this.nav1.Language = "EN";
			this.nav1.Location = new System.Drawing.Point(0, 0);
			this.nav1.MSG_Exit = false;
			this.nav1.MulltiDel = false;
			this.nav1.Name = "nav1";
			this.nav1.Security = 0;
			this.nav1.ShowPopupMenu = false;
			this.nav1.Size = new System.Drawing.Size(704, 32);
			this.nav1.TabIndex = 10;
			this.nav1.ToolBar_Auto = true;
			this.nav1.UserID = null;
			this.nav1.VisibleGrid = true;
			this.nav1.Where = null;
			// 
			// splitter1
			// 
			this.splitter1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
			this.splitter1.Location = new System.Drawing.Point(0, 228);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(704, 4);
			this.splitter1.TabIndex = 1;
			this.splitter1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.vs);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(704, 228);
			this.panel2.TabIndex = 0;
			// 
			// vs
			// 
			this.vs.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vs.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs.Location = new System.Drawing.Point(0, 0);
			this.vs.Name = "vs";
			this.vs.Size = new System.Drawing.Size(704, 228);
			this.vs.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs.TabIndex = 10;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.panel4);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(704, 36);
			this.panel3.TabIndex = 13;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Location = new System.Drawing.Point(416, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(288, 36);
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
			this.nav.ShowPopupMenu = false;
			this.nav.Size = new System.Drawing.Size(472, 32);
			this.nav.TabIndex = 9;
			this.nav.ToolBar_Auto = true;
			this.nav.UserID = null;
			this.nav.VisibleGrid = true;
			this.nav.Where = null;
			// 
			// frmTaStyle
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(704, 448);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaStyle";
			this.Text = "frmTaStyle";
			this.Load += new System.EventHandler(this.frmTaStyle_Load);
			this.panel1.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs1)).EndInit();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaStyle_Load(object sender, System.EventArgs e)
		{
			string sql="Delete from P_FILB01A where STY_NO not in(Select STY_NO from P_FILB01A)";
			PublicFunction.SQL_Execute(sql);
			init_vs();
			init_vs1();	
			Show_vs1();
			Basic.Function.PublicFunction.L_Init_Label(this);	
		}

		private void init_vs()
		{
			nav.cmd_copy.Visible=false;
			nav.cmd_report.Visible=false;
			nav.cmd_search.Visible=false;
			PublicFunction.InitNav(this,vs,nav);						
			nav.Show_VS();
			nav.ToolBar_Auto=false;
			nav.TBarClick+=new ToolBarButtonClickEventHandler(nav_TBarClick);
			vs.AfterRowColChange+=new C1.Win.C1FlexGrid.RangeEventHandler(vs_AfterRowColChange);
		}
		private void init_vs1()
		{
			nav1.cmd_copy.Visible=false;
			nav1.cmd_report.Visible=false;
			nav1.cmd_search.Visible=false;
			nav1.cmd_exit.Visible=false;
			PublicFunction.InitNav(this,vs1,nav1);		
			vs1.Cols["SEC_ID"].ComboList="...";
			nav1.ToolBar_Auto=false;
			nav1.TBarClick+=new ToolBarButtonClickEventHandler(nav1_TBarClick);				
			vs1.CellButtonClick+=new C1.Win.C1FlexGrid.RowColEventHandler(vs1_CellButtonClick);
			vs1.AfterEdit+=new C1.Win.C1FlexGrid.RowColEventHandler(vs1_AfterEdit);
		}

		private void Show_vs1()
		{			
			if(vs.Row<=0)
			{
				vs1.Rows.Count=1;
				return;
			}
			nav1.Show_VS("STY_NO=N'"+vs.Rows[vs.Row]["STY_NO"]+"' Order BY SEQ_NO");
			CAL_TT();
		}

		private void nav_TBarClick(object sender, ToolBarButtonClickEventArgs e)
		{
			if (e.Button.Equals(nav.cmd_add))
			{				
				nav.ToolBar_Click(e);
				vs.Rows[vs.Rows.Count-1]["BLT_NM"]=PublicFunction.A_UserID;
				vs.Rows[vs.Rows.Count-1]["BLT_DT"]=T_String.GetDate().ToString("yyyy/MM/dd HH:mm");								
				return;
			}	
			if (e.Button.Equals(nav.cmd_save))
			{				
				if (T_String.IsNullTo0(vs.Rows[vs.Row].UserData+"")==1)
				{							
					vs.Rows[vs.Row]["LST_NM"]=PublicFunction.A_UserID;
					vs.Rows[vs.Row]["LST_DT"]=T_String.GetDate().ToString("yyyy/MM/dd HH:mm");
				}	
				nav.ToolBar_Click(e);
				return;
			}						
			if (e.Button.Equals(nav.cmd_delete))
			{	
				nav.ToolBar_Click(e);
				string sql="Delete from P_FILB01A where STY_NO not in(Select STY_NO from P_FILB01A)";
				PublicFunction.SQL_Execute(sql);
				return;
			}			
			if (e.Button.Equals(nav.cmd_refresh ))
			{	
				Show_vs1();
				return;
			}
			nav.ToolBar_Click(e);
		}

		private void nav1_TBarClick(object sender, ToolBarButtonClickEventArgs e)
		{
			if (e.Button.Equals(nav1.cmd_add))
			{					
				nav1.ToolBar_Click(e);
				vs1.Rows[vs1.Rows.Count-1]["STY_NO"]=vs.Rows[vs.Row]["STY_NO"];								
				return;
			}	
			if (e.Button.Equals(nav1.cmd_save))
			{	
				Boolean a=true;
				for (int i=1;i<vs1.Rows.Count;i++)
				{
					if (vs1.Rows[i]["SEQ_NO"]+""!=i.ToString("000"))
						a=false;
				}
				for (int i=1;i<vs1.Rows.Count;i++)
				{
					vs1.Rows[i]["SEQ_NO"]=i.ToString("000");
					if (T_String.IsNullTo0(vs1.Rows[i].UserData+"")!=2)
					{	
						if (T_String.IsNullTo0(vs1.Rows[i].UserData+"")==1)
						{							
							vs1.Rows[i]["LST_NM"]=PublicFunction.A_UserID;
							vs1.Rows[i]["LST_DT"]=T_String.GetDate().ToString("yyyy/MM/dd HH:mm");
						}
						if (!a)
						{
							vs1.Rows[i].UserData=1;
							vs1.Rows[i]["LST_NM"]=PublicFunction.A_UserID;
							vs1.Rows[i]["LST_DT"]=T_String.GetDate().ToString("yyyy/MM/dd HH:mm");
						}
					}
					else
					{
						vs1.Rows[i]["BLT_NM"]=vs1.Rows[i]["LST_NM"]=PublicFunction.A_UserID;
						vs1.Rows[i]["LST_DT"]=vs1.Rows[i]["BLT_DT"]=T_String.GetDate().ToString("yyyy/MM/dd HH:mm");
					}
				}
				nav1.ToolBar_Click(e);	
			}						
			if (e.Button.Equals(nav1.cmd_delete))
			{				
				nav1.ToolBar_Click(e);
				for (int i=1;i<vs1.Rows.Count;i++)
				{
					vs1.Rows[i]["SEQ_NO"]=i.ToString("000");
					if (T_String.IsNullTo0(vs1.Rows[i].UserData+"")!=2)
					{							
						vs1.Rows[i].UserData=1;
						vs1.Rows[i]["LST_NM"]=PublicFunction.A_UserID;
						vs1.Rows[i]["LST_DT"]=T_String.GetDate().ToString("yyyy/MM/dd HH:mm");					
					}
					else
					{
						vs1.Rows[i]["BLT_NM"]=vs1.Rows[i]["LST_NM"]=PublicFunction.A_UserID;
						vs1.Rows[i]["LST_DT"]=vs1.Rows[i]["BLT_DT"]=T_String.GetDate().ToString("yyyy/MM/dd HH:mm");
					}
				}
				nav1.ToolBar_Click(new ToolBarButtonClickEventArgs(nav1.cmd_save));
				return;
			}			
			if (e.Button.Equals(nav1.cmd_refresh ))
			{	
				Show_vs1();
				return;
			}
			nav1.ToolBar_Click(e);
		}

		private void vs_AfterRowColChange(object sender, C1.Win.C1FlexGrid.RangeEventArgs e)
		{
			if(e.OldRange.r1!=e.NewRange.r1)
				Show_vs1();
		}

		private void vs1_CellButtonClick(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			Func.RecordSet rs=new Func.RecordSet("Select SEC_ID,SEC_NM from P_FILA10A",PublicFunction.C_con);
			frmSearch dlg=new frmSearch(rs,2,"frmTaSection_vs");
			if(dlg.ShowDialog()==DialogResult.OK)
			{
				vs1.Rows[e.Row]["SEC_ID"]=rs.record(rs.Bookmarks,"SEC_ID");
				vs1.Rows[e.Row]["SEC_NM"]=rs.record(rs.Bookmarks,"SEC_NM");
			}
		}

		private void vs1_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			if(vs1.Cols[e.Col].Name=="UNT_PR" || vs1.Cols[e.Col].Name=="TOP_PR")
			{
				vs1.Rows[e.Row]["AMT_PR"]=T_String.IsNullTo00(vs1.Rows[e.Row]["UNT_PR"]+"")+T_String.IsNullTo00(vs1.Rows[e.Row]["TOP_PR"]+"");
			}
		}

		private void CAL_TT()
		{
			for(int i=1;i<vs1.Rows.Count;i++)
				vs1.Rows[i]["AMT_PR"]=T_String.IsNullTo00(vs1.Rows[i]["UNT_PR"]+"")+T_String.IsNullTo00(vs1.Rows[i]["TOP_PR"]+"");
		}
	}
}

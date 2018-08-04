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
	/// Summary description for frmTaRouters.
	/// </summary>
	public class frmTaRosters : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel4;
		private Navigator1._0.NavigatorAuto nav;
		private System.Windows.Forms.Panel panel1;
		private C1.Win.C1FlexGrid.C1FlexGrid vs;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel panel5;
		private Navigator1._0.NavigatorAuto nav1;
		private C1.Win.C1FlexGrid.C1FlexGrid vs1;
		private string st;
		private System.Windows.Forms.Label lb;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaRosters()
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
			this.lb = new System.Windows.Forms.Label();
			this.vs1 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.nav1 = new Navigator1._0.NavigatorAuto();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.panel2 = new System.Windows.Forms.Panel();
			this.vs = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs1)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
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
			this.panel3.Size = new System.Drawing.Size(836, 36);
			this.panel3.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Location = new System.Drawing.Point(416, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(420, 36);
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
			// panel1
			// 
			this.panel1.Controls.Add(this.panel5);
			this.panel1.Controls.Add(this.splitter1);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 36);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(836, 408);
			this.panel1.TabIndex = 5;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.lb);
			this.panel5.Controls.Add(this.vs1);
			this.panel5.Controls.Add(this.nav1);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(0, 295);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(836, 113);
			this.panel5.TabIndex = 12;
			// 
			// lb
			// 
			this.lb.BackColor = System.Drawing.Color.LightSteelBlue;
			this.lb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lb.Location = new System.Drawing.Point(396, 4);
			this.lb.Name = "lb";
			this.lb.Size = new System.Drawing.Size(272, 28);
			this.lb.TabIndex = 12;
			this.lb.Tag = "N";
			this.lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// vs1
			// 
			this.vs1.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.Rows;
			this.vs1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.vs1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs1.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs1.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs1.Location = new System.Drawing.Point(4, 36);
			this.vs1.Name = "vs1";
			this.vs1.Size = new System.Drawing.Size(828, 76);
			this.vs1.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs1.TabIndex = 11;
			// 
			// nav1
			// 
			this.nav1.BackColor = System.Drawing.SystemColors.Control;
			this.nav1.Connection = null;
			this.nav1.ConnectionDel = null;
			this.nav1.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.nav1.form = null;
			this.nav1.FormName = null;
			this.nav1.Grid = null;
			this.nav1.History = false;
			this.nav1.IsNull = true;
			this.nav1.Language = "EN";
			this.nav1.Location = new System.Drawing.Point(4, 4);
			this.nav1.MSG_Exit = false;
			this.nav1.MulltiDel = false;
			this.nav1.Name = "nav1";
			this.nav1.Security = 0;
			this.nav1.ShowPopupMenu = false;
			this.nav1.Size = new System.Drawing.Size(472, 32);
			this.nav1.TabIndex = 10;
			this.nav1.ToolBar_Auto = true;
			this.nav1.UserID = null;
			this.nav1.VisibleGrid = true;
			this.nav1.Where = null;
			// 
			// splitter1
			// 
			this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
			this.splitter1.Location = new System.Drawing.Point(0, 292);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(836, 3);
			this.splitter1.TabIndex = 11;
			this.splitter1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.vs);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(836, 292);
			this.panel2.TabIndex = 10;
			// 
			// vs
			// 
			this.vs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.vs.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs.Location = new System.Drawing.Point(4, 4);
			this.vs.Name = "vs";
			this.vs.Size = new System.Drawing.Size(828, 288);
			this.vs.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs.TabIndex = 9;
			// 
			// frmTaRosters
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(836, 444);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaRosters";
			this.Text = "frmTaRosters";
			this.Load += new System.EventHandler(this.frmTaRouters_Load);
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs1)).EndInit();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaRouters_Load(object sender, System.EventArgs e)
		{
			string sql="Delete from FILC02B where SHI_ID not in (Select SHI_ID from FILC02A )";
			PublicFunction.SQL_Execute(sql);

			Init_Form();				
			Func.RecordSet Set=new Func.RecordSet("Select * from GP_SYS_SETTING",PublicFunction.C_con);
			if(Set.rows>0)
				st=T_String.IsNullTo0(Set.record(0,"SEQ_HR")).ToString("00")+"-"+T_String.IsNullTo0(Set.record(0,"ROU_MN")).ToString("00");
		}
		
		#region Init Form
		private void Init_Form()
		{		
			Init_vs();	
			Init_vs1();		
			Basic.Function.PublicFunction.L_Init_Label(this);
			string sql;			
			//Department
			sql="Select TYP_ID,TYP_"+PublicFunction.L_Lag+" from GP_SYS_SHIFT";					
			vs1.Cols["TYP_ID"].DataMap=PublicFunction.InitCBForVS(sql,true);				
			show_vs1();
		}
		private void Init_vs()
		{
			nav.cmd_search.Visible=nav.cmd_report.Visible=nav.cmd_copy.Visible=false;
			PublicFunction.InitNav(this,vs,nav);
			nav.Show_VS();
			nav.ToolBar_Auto=false;
			nav.TBarClick+=new ToolBarButtonClickEventHandler(nav_TBarClick);
			vs.AfterRowColChange+=new C1.Win.C1FlexGrid.RangeEventHandler(vs_AfterRowColChange);
			vs.Cols["OFF_TM"].Format="#0:00";
			vs.Cols["MAX_HR"].Format="#0:00";
			vs.Cols["MIN_HR"].Format="#0:00";
			vs.Cols["ADD_H1"].Format="#0:00";
			vs.Cols["ADD_h2"].Format="#0:00";
			vs.Cols["CON_H1"].Format="#0:00";
			vs.Cols["CON_h2"].Format="#0:00";
			
		}	
		private void Init_vs1()
		{			
			nav1.cmd_exit.Visible=nav1.cmd_search.Visible=nav1.cmd_report.Visible=nav1.cmd_copy.Visible=false;
			PublicFunction.InitNav(this,vs1,nav1);						
			nav1.ToolBar_Auto=false;
			nav1.TBarClick+=new ToolBarButtonClickEventHandler(nav1_TBarClick);
			vs1.Cols["MIN_ST"].Format=vs1.Cols["ONN_TM"].Format=vs1.Cols["OFF_TM"].Format="###";
			vs1.Cols["ONN_RD"].EditMask=vs1.Cols["OFF_RD"].EditMask="00-00";
			vs1.Cols["ONN_RD"].ComboList=vs1.Cols["OFF_RD"].ComboList="|...";
			vs1.BeforeEdit+=new C1.Win.C1FlexGrid.RowColEventHandler(vs1_BeforeEdit);
			vs1.CellButtonClick+=new C1.Win.C1FlexGrid.RowColEventHandler(vs1_CellButtonClick);
			vs1.Cols["ONN_TM"].Format="#0:00";
			vs1.Cols["OFF_TM"].Format="#0:00";
			vs1.Cols["WRK_HR"].Format="#0:00";
			vs1.Cols["MAN_IN"].Format="#0:00";
			vs1.Cols["MAN_OU"].Format="#0:00";
		}	
		
		private void show_vs1()
		{
			if(vs.Row<=0)
			{
				vs1.Rows.Count=1;
				return;
			}
			nav1.Show_VS("SHI_ID=N'"+vs.Rows[vs.Row]["SHI_ID"]+"' ORDER BY SEQ_NO");
			lb.Text=vs.Rows[vs.Row]["SHI_NM"]+"";
		}		
		#endregion

		private void nav_TBarClick(object sender, ToolBarButtonClickEventArgs e)
		{
			if (e.Button.Equals(nav.cmd_add))
			{
				if (vs.Rows.Count==1 || (int)vs.Rows[vs.Rows.Count-1].UserData!=2)					
					nav.ToolBar_Click(e);									
			//	vs.Rows[vs.Rows.Count-1]["SHI_ID"]=T_String.GetMax("MAX(SHI_ID)","FILC02A").ToString("000");						
				return;
			}
			if (e.Button.Equals(nav.cmd_save))
			{
				vs.Select();
				string dt=T_String.GetDate().ToString("yyyy/MM/dd HH:mm");
				for (int i=1;i<vs.Rows.Count;i++)
				{					
					if (T_String.IsNullTo0(vs.Rows[i].UserData+"")!=2)
					{	
						if (T_String.IsNullTo0(vs.Rows[i].UserData+"")==1)
						{							
							vs.Rows[i]["LST_NM"]=PublicFunction.A_UserID;
							vs.Rows[i]["LST_DT"]=dt;
						}						
					}
					else
					{
						vs.Rows[i]["BLT_NM"]=vs.Rows[i]["LST_NM"]=PublicFunction.A_UserID;
						vs.Rows[i]["LST_DT"]=vs.Rows[i]["BLT_DT"]=dt;
					}
				}			
			}			
			nav.ToolBar_Click(e);
			if (e.Button.Equals(nav.cmd_refresh))
			{
				show_vs1();
			}
		}
		private void nav1_TBarClick(object sender, ToolBarButtonClickEventArgs e)
		{
			if(vs.Row<=0) return;
			
			if (e.Button.Equals(nav1.cmd_add))
			{
				if(vs1.Rows[vs1.Row].UserData+""=="2")
					return;
				nav1.ToolBar_Click(e);
				vs1.Rows[vs1.Rows.Count-1]["SHI_ID"]=vs.Rows[vs.Row]["SHI_ID"];
				vs1.Rows[vs1.Rows.Count-1]["SEQ_N1"]=T_String.GetMax("MAX(SEQ_N1)","FILC02B","SHI_ID=N'"+vs.Rows[vs.Row]["SHI_ID"]+"'");
				vs1.Rows[vs1.Rows.Count-1]["SEQ_NO"]=(vs1.Rows.Count-1).ToString("00");
				vs1.Rows[vs1.Rows.Count-1]["TYP_ID"]="ATT_HR";	
				vs1.Rows[vs1.Rows.Count-1]["LAT_BT"]="1";	
				return;
			}	
			if (e.Button.Equals(nav1.cmd_save))
			{
				Boolean a=true;
				vs.Select();
				for (int i=1;i<vs1.Rows.Count;i++)
				{
					if (vs1.Rows[i]["SEQ_NO"]+""!=i.ToString("00"))
						a=false;
				}
				for (int i=1;i<vs1.Rows.Count;i++)
				{
					vs1.Rows[i]["SEQ_NO"]=i.ToString("00");
					if (vs1.Rows[i].UserData+""!="2")
					{	
						if (vs1.Rows[i].UserData+""=="1")
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
			}
			nav1.ToolBar_Click(e);
		}

		private void vs_AfterRowColChange(object sender, C1.Win.C1FlexGrid.RangeEventArgs e)
		{
			if(e.NewRange.r1!=e.OldRange.r1)
			{
				show_vs1();
			}
		}

		private void vs1_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			if(vs1.Cols[e.Col].Name=="ONN_TM" || vs1.Cols[e.Col].Name=="OFF_TM")
			{
				if (T_String.IsNullTo00(vs1.Rows[e.Row][e.Col]+"")>2400)
					e.Cancel=true;
			}
		}

		private void vs1_CellButtonClick(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			frmTaRound dlg=new frmTaRound(vs1.Rows[e.Row][e.Col]+"");
			if( dlg.ShowDialog()==DialogResult.OK)
			{
				vs1.Rows[e.Row][e.Col]=dlg.st;
			}
		}
	}
}

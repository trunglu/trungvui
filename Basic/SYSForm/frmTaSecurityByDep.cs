using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Basic.Form;
using Basic.Function;
using System.IO;
using C1.Win.C1FlexGrid;

namespace GP8000.SYSForm
{
	/// <summary>
	/// Summary description for frmTaSecurityByDep.
	/// </summary>
	public class frmTaSecurityByDep : System.Windows.Forms.Form
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
		private C1.Win.C1FlexGrid.C1FlexGrid vs1;
		private System.Windows.Forms.Button cmd_to;
		private System.Windows.Forms.Button cmd_frm;
		private Navigator1._0.Navigator nav1;
		private string GROUP_ID,MNU_ID,label;		
		public ArrayList ar;		
		Boolean edit;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaSecurityByDep(string GROUP_ID,string MNU_ID,string label)
		{
			this.GROUP_ID=GROUP_ID;
			this.MNU_ID=MNU_ID;
			this.label=label;
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
			this.cmd_frm = new System.Windows.Forms.Button();
			this.cmd_to = new System.Windows.Forms.Button();
			this.vs1 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.nav1 = new Navigator1._0.Navigator();
			this.c1CommandDock1 = new C1.Win.C1Command.C1CommandDock();
			this.c1DockingTab1 = new C1.Win.C1Command.C1DockingTab();
			this.c1DockingTabPage1 = new C1.Win.C1Command.C1DockingTabPage();
			this.vs = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.nav = new Navigator1._0.NavigatorAuto();
			this.panel1.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs1)).BeginInit();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandDock1)).BeginInit();
			this.c1CommandDock1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).BeginInit();
			this.c1DockingTab1.SuspendLayout();
			this.c1DockingTabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
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
			this.panel1.Size = new System.Drawing.Size(820, 384);
			this.panel1.TabIndex = 3;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.cmd_frm);
			this.panel5.Controls.Add(this.cmd_to);
			this.panel5.Controls.Add(this.vs1);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(264, 36);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(556, 348);
			this.panel5.TabIndex = 4;
			// 
			// cmd_frm
			// 
			this.cmd_frm.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_frm.Location = new System.Drawing.Point(160, 8);
			this.cmd_frm.Name = "cmd_frm";
			this.cmd_frm.Size = new System.Drawing.Size(148, 28);
			this.cmd_frm.TabIndex = 9;
			this.cmd_frm.Text = "Copy From";
			this.cmd_frm.Click += new System.EventHandler(this.cmd_frm_Click);
			// 
			// cmd_to
			// 
			this.cmd_to.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_to.Location = new System.Drawing.Point(8, 8);
			this.cmd_to.Name = "cmd_to";
			this.cmd_to.Size = new System.Drawing.Size(148, 28);
			this.cmd_to.TabIndex = 8;
			this.cmd_to.Text = "Copy To";
			this.cmd_to.Click += new System.EventHandler(this.cmd_to_Click);
			// 
			// vs1
			// 
			this.vs1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.vs1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D;
			this.vs1.ColumnInfo = "10,0,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs1.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs1.Location = new System.Drawing.Point(6, 40);
			this.vs1.Name = "vs1";
			this.vs1.Rows.Count = 10;
			this.vs1.Size = new System.Drawing.Size(544, 304);
			this.vs1.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs1.TabIndex = 7;
			this.vs1.Tag = "";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.panel4);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(264, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(556, 36);
			this.panel3.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Location = new System.Drawing.Point(108, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(448, 36);
			this.label5.TabIndex = 11;
			this.label5.Tag = "";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.nav1);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(108, 36);
			this.panel4.TabIndex = 10;
			// 
			// nav1
			// 
			this.nav1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.nav1.form = null;
			this.nav1.Grid = null;
			this.nav1.Location = new System.Drawing.Point(1, 2);
			this.nav1.Name = "nav1";
			this.nav1.Size = new System.Drawing.Size(103, 32);
			this.nav1.TabIndex = 0;
			// 
			// c1CommandDock1
			// 
			this.c1CommandDock1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.c1CommandDock1.Controls.Add(this.c1DockingTab1);
			this.c1CommandDock1.Dock = System.Windows.Forms.DockStyle.Left;
			this.c1CommandDock1.Id = 1;
			this.c1CommandDock1.Location = new System.Drawing.Point(0, 0);
			this.c1CommandDock1.Name = "c1CommandDock1";
			this.c1CommandDock1.Size = new System.Drawing.Size(264, 384);
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
			this.c1DockingTab1.Size = new System.Drawing.Size(262, 382);
			this.c1DockingTab1.TabIndex = 0;
			this.c1DockingTab1.TabSizeMode = C1.Win.C1Command.TabSizeModeEnum.Fit;
			this.c1DockingTab1.TabStyle = C1.Win.C1Command.TabStyleEnum.WindowsXP;
			// 
			// c1DockingTabPage1
			// 
			this.c1DockingTabPage1.Controls.Add(this.vs);
			this.c1DockingTabPage1.Controls.Add(this.nav);
			this.c1DockingTabPage1.ImageIndex = -1;
			this.c1DockingTabPage1.Location = new System.Drawing.Point(0, 0);
			this.c1DockingTabPage1.Name = "c1DockingTabPage1";
			this.c1DockingTabPage1.Size = new System.Drawing.Size(259, 381);
			this.c1DockingTabPage1.TabIndex = 0;
			this.c1DockingTabPage1.Text = "Page1";
			// 
			// vs
			// 
			this.vs.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vs.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs.Location = new System.Drawing.Point(0, 20);
			this.vs.Name = "vs";
			this.vs.Size = new System.Drawing.Size(259, 361);
			this.vs.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs.TabIndex = 8;
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
			this.nav.Location = new System.Drawing.Point(-56, 92);
			this.nav.MSG_Exit = false;
			this.nav.MulltiDel = false;
			this.nav.Name = "nav";
			this.nav.Security = 0;
			this.nav.ShowPopupMenu = false;
			this.nav.Size = new System.Drawing.Size(472, 32);
			this.nav.TabIndex = 9;
			this.nav.ToolBar_Auto = true;
			this.nav.UserID = null;
			this.nav.Visible = false;
			this.nav.VisibleGrid = true;
			this.nav.Where = null;
			// 
			// frmTaSecurityByDep
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(820, 384);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmTaSecurityByDep";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmTaSecurityByDep";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.frmTaSecurityByDep_Closing);
			this.Load += new System.EventHandler(this.frmTaSecurityByDep_Load);
			this.panel1.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs1)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandDock1)).EndInit();
			this.c1CommandDock1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).EndInit();
			this.c1DockingTab1.ResumeLayout(false);
			this.c1DockingTabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
		#region load
		private void frmTaSecurityByDep_Load(object sender, System.EventArgs e)
		{	
			string sql;
			sql="Delete from SYS_SECURITY_DEP where DEP_ID not in (Select DEP_ID from  FILA02A )";
			PublicFunction.SQL_Execute(sql);			
			sql="Delete from SYS_SECURITY_DEP where USER_ID not in (Select USER_ID from  SYS_USER )";
			PublicFunction.SQL_Execute(sql);			
			sql="Delete from SYS_SECURITY_DEP where MNU_ID not in (Select ID as MNU_ID from  SYS_MENU where DEP_BT=1)";
			PublicFunction.SQL_Execute(sql);			

			nav.cmd_copy.Visible=false;
			nav.cmd_report.Visible=false;
			nav.cmd_search.Visible=false;
			PublicFunction.InitNav(this,vs,nav);					
			nav.Show_VS("GROUP_ID=N'"+GROUP_ID+"'");	
			
			vs1.Cols.Count=3;								
			vs1.Cols[1].Name="DEP_NM";
			vs1.Cols[0].Name="DEP_ID";
			vs1.Cols[0].Visible=false;
			vs1.Cols[2].Name="ALL_BT";
			vs1.Cols[1].AllowEditing=false;
			vs1.Cols[2].DataType=typeof(System.Boolean);
			
			vs1.Tree.Column = 1;	
			PublicFunction.L_Init_Label(this);					

			nav1.form=this;
			nav1.TBarClick+=new ToolBarButtonClickEventHandler(nav1_TBarClick);
			nav1.cmd_add.Visible=nav1.cmd_copy.Visible=nav1.cmd_delete.Visible=
				nav1.cmd_fisrt.Visible=nav1.cmd_last.Visible=nav1.cmd_next.Visible=
				nav1.cmd_previous.Visible=nav1.cmd_refresh.Visible=nav1.cmd_report.Visible=
				nav1.cmd_refresh.Visible=nav1.cmd_search.Visible=false;

			Init_Tree();
			edit=false;			
			vs.AfterRowColChange+=new RangeEventHandler(vs_AfterRowColChange);
			vs1.AfterEdit+=new RowColEventHandler(vs1_AfterEdit);
			vs1.DoubleClick+=new EventHandler(vs1_DoubleClick);
			label5.Text=label5.Text+" - " +label;
			this.Text=label5.Text;
			for(int i=1;i<vs.Rows.Count;i++)
			{
				if(  (vs.Rows[i]["USER_ID"]+"").ToUpper() ==PublicFunction.A_UserID.ToUpper())
				{
					vs.Row=i;
					break;
				}
			}
		}
		#endregion
		#region Init Tree
		private void CheckSEC(string USER_ID)
		{			
			//tao
			string sql;
			sql="insert into SYS_SECURITY_DEP(USER_ID,DEP_ID,MNU_ID,ALL_BT) ";
			sql+="Select N'"+USER_ID+"' as USER_ID,DEP_ID,"+MNU_ID+" as MNU_ID,0 as ALL_BT"+
				" from FILA02A where DEP_ID not in (Select DEP_ID from  SYS_SECURITY_DEP where USER_ID=N'"
				+USER_ID+"' and MNU_ID="+MNU_ID+")";
			PublicFunction.SQL_Execute(sql);			
		}
		
		private void Init_Tree()
		{	
			if(vs.Row<1)
			{
				vs1.Rows.Count=1;
				return;
			}	
			ar=new ArrayList();
			ar.Add(null);
			string USER_ID=vs.Rows[vs.Row]["USER_ID"]+"";
			CheckSEC(USER_ID);
			vs1.Styles["Normal"].BackColor=System.Drawing.Color.WhiteSmoke;
			vs1.Styles["Normal"].Border.Color=System.Drawing.Color.WhiteSmoke;
			vs1.Styles["EmptyArea"].BackColor=System.Drawing.Color.WhiteSmoke;
			vs1.Styles["EmptyArea"].Border.Color=System.Drawing.Color.WhiteSmoke;
			vs1.Rows.Count=1;				
			Node a;
			a=vs1.Rows.InsertNode(vs1.Rows.Count, 0);	
			ar.Add(a);
			vs1.Rows[vs1.Rows.Count-1]["DEP_NM"]=T_String.GetDataFromSQL("COM_N2","FILA01A","ACT_BT=1");
			vs1.Rows[vs1.Rows.Count-1]["ALL_BT"]=false;
			vs1.Rows[vs1.Rows.Count-1].AllowEditing=false;
			Init_TreeDetail("(DEP_HG is null OR DEP_HG='')",1,a,USER_ID);		
			vs1.AutoSizeCols();

		}	
		private void Init_TreeDetail(string wh,int level,Node p,string USER_ID)
		{
			string sql="Select a.DEP_ID,DEP_NM,DEP_N1,ALL_BT from SYS_SECURITY_DEP a,FILA02A b where a.DEP_ID=b.DEP_ID "
				+"and USER_ID=N'"+USER_ID+"' and MNU_ID="+MNU_ID+" and "+ wh;
			Func.RecordSet rs=new Func.RecordSet(sql,PublicFunction.C_con);
			Node a;
			for(int i=0;i<rs.rows;i++)
			{
				a=vs1.Rows.InsertNode(vs1.Rows.Count, level);
				ar.Add(a);
				if(rs.record(i,"DEP_N1")+""!="")
					vs1.Rows[vs1.Rows.Count-1]["DEP_NM"]=rs.record(i,"DEP_NM")+" - "+rs.record(i,"DEP_N1");
				else
					vs1.Rows[vs1.Rows.Count-1]["DEP_NM"]=rs.record(i,"DEP_NM");
				vs1.Rows[vs1.Rows.Count-1]["DEP_ID"]=rs.record(i,"DEP_ID");
				vs1.Rows[vs1.Rows.Count-1]["ALL_BT"]=rs.record(i,"ALL_BT");
				Init_TreeDetail("DEP_HG=N'"+rs.record(i,"DEP_ID")+"'",level+1,a,USER_ID);
			}
			if (rs.rows>0)
				p.Expanded=false;
		}
		#endregion
		private void nav_TBarClick(object sender, ToolBarButtonClickEventArgs e)
		{					
			if (e.Button.Equals(nav.cmd_add))
			{				
				nav.ToolBar_Click(e);	
				vs.Rows[vs.Rows.Count-1]["DEP_HG"]=vs1.Rows[vs1.Row]["DEP_ID"]+"";
				return;
			}		
			if (e.Button.Equals(nav.cmd_refresh))
			{			
				Init_Tree();
				return;
			}
			if (e.Button.Equals(nav.cmd_delete))
			{
				string sql="Select Count(*) from FILA02A where DEP_ID=N'"+vs.Rows[vs.Row]["DEP_ID"]+"'";
				if(T_String.IsNullTo0(T_String.GetDataFromSQL("Count(*)","FILA02A","DEP_HG=N'"+vs.Rows[vs.Row]["DEP_ID"]+"'"))>0)
				{
					MessageBox.Show("ko the xoa");
					return;
				}
			}
			nav.ToolBar_Click(e);							
		}

		private void nav1_TBarClick(object sender, ToolBarButtonClickEventArgs e)
		{
			if(vs.Row<1)
			{
				vs1.Rows.Count=1;
				return;
			}		
			if (e.Button.Equals(nav1.cmd_save))
			{	
				string sql;
				string USER_ID=vs.Rows[vs.Row]["USER_ID"]+"";
				for(int i=1;i<vs1.Rows.Count;i++)
				{
					if(vs1.Rows[i]["ALL_BT"]+""=="True")
						sql="update SYS_SECURITY_DEP set ALL_BT=1 where USER_ID=N'"+USER_ID+"'  and DEP_ID=N'"+
						vs1.Rows[i]["DEP_ID"]+"' and MNU_ID="+MNU_ID;
					else
						sql="update SYS_SECURITY_DEP set ALL_BT=0 where USER_ID=N'"+USER_ID+"'  and DEP_ID=N'"+
							vs1.Rows[i]["DEP_ID"]+"' and MNU_ID="+MNU_ID;
					PublicFunction.SQL_Execute(sql);
				}
				edit=false;
				return;
			}	
		}

		private void vs_AfterRowColChange(object sender, RangeEventArgs e)
		{			
			if(e.NewRange.r1!=e.OldRange.r1)
			{
				if(edit)			
				{
					if(MessageBox.Show(this,PublicFunction.L_Get_Msg("msg",999),this.Text,MessageBoxButtons.YesNo)==DialogResult.Yes)
					{						
						string sql;
						string USER_ID=vs.Rows[e.OldRange.r1]["USER_ID"]+"";
						for(int i=1;i<vs1.Rows.Count;i++)
						{
							if(vs1.Rows[i]["ALL_BT"]+""=="True")
								sql="update SYS_SECURITY_DEP set ALL_BT=1 where USER_ID=N'"+USER_ID+"'  and DEP_ID=N'"+
									vs1.Rows[i]["DEP_ID"]+"' and MNU_ID="+MNU_ID;
							else
								sql="update SYS_SECURITY_DEP set ALL_BT=0 where USER_ID=N'"+USER_ID+"'  and DEP_ID=N'"+
									vs1.Rows[i]["DEP_ID"]+"' and MNU_ID="+MNU_ID;
							PublicFunction.SQL_Execute(sql);
						}
						edit=false;		
						
					}
				}
				edit=false;	
				Init_Tree();
			}
		}

		private void vs1_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			if (vs1.Cols[e.Col].Name=="ALL_BT" && e.Row>0)
			{
				int lv=((Node)ar[e.Row]).Level;
				((Node)ar[e.Row]).Expanded=(vs1.GetCellCheck(e.Row,e.Col)==CheckEnum.Checked);
				for(int i=e.Row+1;i<vs1.Rows.Count;i++)
				{
					if (((Node)ar[i]).Level<=lv)
						break;
					vs1.Rows[i]["ALL_BT"]=vs1.Rows[e.Row]["ALL_BT"];
				}
				edit=true;
			}
		}

		private void vs1_DoubleClick(object sender, EventArgs e)
		{			
			((Node)ar[vs1.Row]).Expanded=!((Node)ar[vs1.Row]).Expanded;
		}

		private void cmd_to_Click(object sender, System.EventArgs e)
		{
			string sql="",USER_ID=vs.Rows[vs.Row]["USER_ID"]+"";			
			sql="Select 0 as SYS_SEL,EN,CH,VN,ID  from SYS_MENU b where ";
			sql=sql+"DEP_BT=1  and SEC=1 order by EN";
			Func.RecordSet rs=new Func.RecordSet(sql,PublicFunction.C_con );
			Basic.Form.frmSearch dlg=new frmSearch(rs,4,"frmSecurity_vs1",true);
			if  (dlg.ShowDialog()==DialogResult.OK)
			{
				for(int j=1;j<dlg.vs.Rows.Count;j++)
				{
					sql="Select DEP_ID,MNU_ID,ALL_BT from SYS_SECURITY_DEP a where MNU_ID="
						+MNU_ID+" and USER_ID=N'"+USER_ID+"'";
					Func.RecordSet rs1=new Func.RecordSet(sql,PublicFunction.C_con );
					if (dlg.vs.Rows[j]["SYS_SEL"]+""=="True")
					{
						sql="insert into SYS_SECURITY_DEP(USER_ID,DEP_ID,MNU_ID,ALL_BT) ";
						sql+="Select N'"+USER_ID+"' as USER_ID,DEP_ID,"+rs.record(j-1,"ID")+" as MNU_ID,0 as ALL_BT"+
							" from FILA02A where DEP_ID not in (Select DEP_ID from  SYS_SECURITY_DEP where USER_ID=N'"
							+USER_ID+"' and MNU_ID="+rs.record(j-1,"ID")+")";
						PublicFunction.SQL_Execute(sql);						
						for(int i=0;i<rs1.rows;i++)
						{
							if(rs1.record(i,"ALL_BT")=="True")					
								sql="Update SYS_SECURITY_DEP  set ALL_BT=1"
									+" where DEP_ID=N'"+rs1.record(i,"DEP_ID")+"' and USER_ID=N'"
									+USER_ID+ "' and MNU_ID="+rs.record(j-1,"ID");
							else
								sql="Update SYS_SECURITY_DEP  set ALL_BT=0"
									+" where DEP_ID=N'"+rs1.record(i,"DEP_ID")+"' and USER_ID=N'"
									+USER_ID+ "' and MNU_ID="+rs.record(j-1,"ID");
							PublicFunction.SQL_Execute(sql);
						}
					}
				}
			}
		}

		private void cmd_frm_Click(object sender, System.EventArgs e)
		{
			string sql="";			
			sql="Select EN,CH,VN,ID  from SYS_MENU b where ";
			sql=sql+"DEP_BT=1  and SEC=1 order by EN";
			Func.RecordSet rs=new Func.RecordSet(sql,PublicFunction.C_con );
			Basic.Form.frmSearch dlg=new frmSearch(rs,3,"frmSecurity_vs1",true);
			if  (dlg.ShowDialog()==DialogResult.OK)
			{
				sql="Select DEP_ID,MNU_ID,ALL_BT from SYS_SECURITY_DEP a where MNU_ID="
					+rs.record(rs.Bookmarks,"ID")+" and USER_ID=N'"+vs.Rows[vs.Row]["USER_ID"]+"'";
				Func.RecordSet rs1=new Func.RecordSet(sql,PublicFunction.C_con );
				for(int i=0;i<rs1.rows;i++)
				{
					if(rs1.record(i,"ALL_BT")=="True")					
						sql="Update SYS_SECURITY_DEP  set ALL_BT=1"
							+" where DEP_ID=N'"+rs1.record(i,"DEP_ID")+"' and USER_ID=N'"
							+vs.Rows[vs.Row]["USER_ID"]+ "' and MNU_ID="+MNU_ID;
					else
						sql="Update SYS_SECURITY_DEP  set ALL_BT=0"
							+" where DEP_ID=N'"+rs1.record(i,"DEP_ID")+"' and USER_ID=N'"
							+vs.Rows[vs.Row]["USER_ID"]+ "' and MNU_ID="+MNU_ID;
					PublicFunction.SQL_Execute(sql);
				}
				Init_Tree();
			}
		}

		private void frmTaSecurityByDep_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if(edit)			
			{
				if(MessageBox.Show(this,PublicFunction.L_Get_Msg("msg",16),this.Text,MessageBoxButtons.YesNo)==DialogResult.Yes)
				{						
					nav1_TBarClick(nav1,new ToolBarButtonClickEventArgs(nav1.cmd_save));					
					edit=false;								
				}
			}
		}
	}
}

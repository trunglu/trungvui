using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Basic.Form;
using Basic.Function;
using System.IO;
using C1.Win.C1FlexGrid;
using System.Drawing.Drawing2D;

namespace GP8000.Database
{
	/// <summary>
	/// Summary description for frmTaDepartment.
	/// </summary>
	public class frmTaDepartment : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel4;
		private Navigator1._0.NavigatorAuto nav;
		private C1.Win.C1Command.C1CommandDock c1CommandDock1;
		private C1.Win.C1Command.C1DockingTab c1DockingTab1;
		private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage1;
		private C1.Win.C1FlexGrid.C1FlexGrid vs;
		private C1.Win.C1FlexGrid.C1FlexGrid vs1;
		private System.Windows.Forms.CheckBox ck;
		private System.Windows.Forms.ColorDialog color;		
		private ArrayList a;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaDepartment()
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
			this.vs = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.panel3 = new System.Windows.Forms.Panel();
			this.ck = new System.Windows.Forms.CheckBox();
			this.label5 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.nav = new Navigator1._0.NavigatorAuto();
			this.c1CommandDock1 = new C1.Win.C1Command.C1CommandDock();
			this.c1DockingTab1 = new C1.Win.C1Command.C1DockingTab();
			this.c1DockingTabPage1 = new C1.Win.C1Command.C1DockingTabPage();
			this.vs1 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.color = new System.Windows.Forms.ColorDialog();
			this.panel1.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandDock1)).BeginInit();
			this.c1CommandDock1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).BeginInit();
			this.c1DockingTab1.SuspendLayout();
			this.c1DockingTabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs1)).BeginInit();
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
			this.panel1.Size = new System.Drawing.Size(956, 490);
			this.panel1.TabIndex = 2;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.vs);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(340, 36);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(616, 454);
			this.panel5.TabIndex = 4;
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
			this.vs.Size = new System.Drawing.Size(608, 448);
			this.vs.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs.TabIndex = 8;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.panel3.Controls.Add(this.ck);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.panel4);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(340, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(616, 36);
			this.panel3.TabIndex = 3;
			// 
			// ck
			// 
			this.ck.Checked = true;
			this.ck.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ck.Location = new System.Drawing.Point(348, 8);
			this.ck.Name = "ck";
			this.ck.TabIndex = 12;
			this.ck.Text = "Show All";
			this.ck.CheckedChanged += new System.EventHandler(this.ck_CheckedChanged);
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Location = new System.Drawing.Point(356, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(260, 36);
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
			this.panel4.Size = new System.Drawing.Size(356, 36);
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
			this.nav.Location = new System.Drawing.Point(4, 2);
			this.nav.MSG_Exit = false;
			this.nav.MulltiDel = false;
			this.nav.Name = "nav";
			this.nav.Security = 0;
			this.nav.ShowPopupMenu = false;
			this.nav.Size = new System.Drawing.Size(353, 32);
			this.nav.TabIndex = 9;
			this.nav.ToolBar_Auto = true;
			this.nav.UserID = null;
			this.nav.VisibleGrid = true;
			this.nav.Where = null;
			// 
			// c1CommandDock1
			// 
			this.c1CommandDock1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.c1CommandDock1.Controls.Add(this.c1DockingTab1);
			this.c1CommandDock1.Dock = System.Windows.Forms.DockStyle.Left;
			this.c1CommandDock1.Id = 1;
			this.c1CommandDock1.Location = new System.Drawing.Point(0, 0);
			this.c1CommandDock1.Name = "c1CommandDock1";
			this.c1CommandDock1.Size = new System.Drawing.Size(340, 490);
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
			this.c1DockingTab1.Size = new System.Drawing.Size(338, 488);
			this.c1DockingTab1.TabIndex = 0;
			this.c1DockingTab1.TabSizeMode = C1.Win.C1Command.TabSizeModeEnum.Fit;
			this.c1DockingTab1.TabStyle = C1.Win.C1Command.TabStyleEnum.WindowsXP;
			// 
			// c1DockingTabPage1
			// 
			this.c1DockingTabPage1.Controls.Add(this.vs1);
			this.c1DockingTabPage1.ImageIndex = -1;
			this.c1DockingTabPage1.Location = new System.Drawing.Point(0, 0);
			this.c1DockingTabPage1.Name = "c1DockingTabPage1";
			this.c1DockingTabPage1.Size = new System.Drawing.Size(335, 487);
			this.c1DockingTabPage1.TabIndex = 0;
			this.c1DockingTabPage1.Text = "Page1";
			// 
			// vs1
			// 
			this.vs1.AllowEditing = false;
			this.vs1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D;
			this.vs1.ColumnInfo = "1,0,0,0,0,100,Columns:0{Width:600;}\t";
			this.vs1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vs1.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs1.Location = new System.Drawing.Point(0, 20);
			this.vs1.Name = "vs1";
			this.vs1.Rows.Count = 10;
			this.vs1.Rows.Fixed = 0;
			this.vs1.Size = new System.Drawing.Size(335, 467);
			this.vs1.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs1.TabIndex = 8;
			this.vs1.Tag = "N";
			// 
			// frmTaDepartment
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(956, 490);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaDepartment";
			this.Text = "frmTaDepartment";
			this.Load += new System.EventHandler(this.frmTaDepartment_Load);
			this.panel1.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandDock1)).EndInit();
			this.c1CommandDock1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).EndInit();
			this.c1DockingTab1.ResumeLayout(false);
			this.c1DockingTabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaDepartment_Load(object sender, System.EventArgs e)
		{
			Init_Tree();
			nav.cmd_copy.Visible=false;
			nav.cmd_report.Visible=false;
			nav.cmd_search.Visible=false;
			PublicFunction.InitNav(this,vs,nav);
			nav.Msg_ExitSave=true;		
			nav.TBarClick+=new ToolBarButtonClickEventHandler(nav_TBarClick);		
			nav.ToolBar_Auto=false;						
			Basic.Function.PublicFunction.L_Init_Label(this);		
			vs1.AfterRowColChange+=new RangeEventHandler(vs1_AfterRowColChange);			
			Show_Data();	
			vs.SetupEditor+=new RowColEventHandler(vs_SetupEditor);
			vs.Cols.Frozen=3;
			vs.Cols["COL_NO"].ComboList="...";
			vs.CellButtonClick+=new RowColEventHandler(vs_CellButtonClick);			
			vs1.SizeChanged+=new EventHandler(vs1_SizeChanged);
			vs.DrawMode = DrawModeEnum.OwnerDraw;
			vs.OwnerDrawCell+=new OwnerDrawCellEventHandler(vs_OwnerDrawCell);
			vs1.Cols[0].Width=vs1.Width ;
			Init_CB();
		}	
		private void vs_OwnerDrawCell(object sender, C1.Win.C1FlexGrid.OwnerDrawCellEventArgs e)
		{
			if (vs.Cols[e.Col].Name=="COL_NO" && e.Row>0 && vs.Rows[e.Row][e.Col]+""!="")
			{            			
				System.Drawing.RectangleF r =new RectangleF(e.Bounds.X,e.Bounds.Y,e.Bounds.Width,e.Bounds.Height);												
				string st=vs.Rows[e.Row][e.Col]+"";
				int index=st.IndexOf(".",0,st.Length);
				Byte R=System.Byte.Parse(st.Remove(index,st.Length-index));
				st=st.Remove(0,index+1);
				index=st.IndexOf(".",0,st.Length);
				Byte G=System.Byte.Parse(st.Remove(index,st.Length-index));
				Byte B=System.Byte.Parse(st.Remove(0,index+1));				
				Color color=System.Drawing.Color.FromArgb(R,G,B);				
				Brush b = new HatchBrush(HatchStyle.Max,color,color);				
				e.Graphics.FillRectangle(b, r);
				e.Handled = true; // we're done drawing this cell
			}
		}
		private void Init_CB()
		{
			string sql="Select DEP_ID as DEP_HG,isnull(DEP_NM,'')+isnull(DEP_N1,'') as DEP from FILA02A";			
			vs.Cols["DEP_HG"].DataMap=PublicFunction.InitCBForVS(sql);			
		}
		private void Init_Tree()
		{			
			vs1.Styles["Normal"].BackColor=System.Drawing.Color.WhiteSmoke;
			vs1.Styles["Normal"].Border.Color=System.Drawing.Color.WhiteSmoke;
			vs1.Styles["EmptyArea"].BackColor=System.Drawing.Color.WhiteSmoke;
			vs1.Styles["EmptyArea"].Border.Color=System.Drawing.Color.WhiteSmoke;

			vs1.Cols.Count=2;			
			vs1.Rows.Count=0;			
			vs1.Cols[0].Name="DEP_NM";
			vs1.Cols[1].Name="DEP_ID";
			vs1.Cols[1].Visible=false;
			vs1.Tree.Column = 0;	
			Node a;
			a=vs1.Rows.InsertNode(vs1.Rows.Count, 0);	
			vs1.Rows[vs1.Rows.Count-1]["DEP_NM"]=T_String.GetDataFromSQL("COM_N2","FILA01A","ACT_BT=1");
			Init_TreeDetail("DEP_HG is null or DEP_HG=''",1,a);					
		}	
		private void Init_TreeDetail(string wh,int level,Node p)
		{
			string sql="Select DEP_ID,DEP_NM,DEP_N1 from FILA02A where "+ wh;
			Func.RecordSet rs=new Func.RecordSet(sql,PublicFunction.C_con);
			Node a;
			for(int i=0;i<rs.rows;i++)
			{
				a=vs1.Rows.InsertNode(vs1.Rows.Count, level);
				if(rs.record(i,"DEP_N1")+""!="")
					vs1.Rows[vs1.Rows.Count-1]["DEP_NM"]=rs.record(i,"DEP_NM")+" - "+rs.record(i,"DEP_N1");
				else
					vs1.Rows[vs1.Rows.Count-1]["DEP_NM"]=rs.record(i,"DEP_NM");
				vs1.Rows[vs1.Rows.Count-1]["DEP_ID"]=rs.record(i,"DEP_ID");
				Init_TreeDetail("DEP_HG=N'"+rs.record(i,"DEP_ID")+"'",level+1,a);
			}
			if (rs.rows>0)
				p.Expanded=false;
		}

		private void Show_Data()
		{
			if(ck.Checked)
				nav.Show_VS("");
			else
			{
				if(vs1.Row>=0)
				{				
					if(vs1.Rows[vs1.Row]["DEP_ID"]+""=="")
						nav.Show_VS("DEP_HG is null");
					else
						nav.Show_VS("DEP_HG=N'"+vs1.Rows[vs1.Row]["DEP_ID"]+"'");
				}
			}
			a=new ArrayList();
//			for(int i=1;i<vs.Rows.Count;i++)
//			{
//				CellStyle cs;
//				cs.BackColor=vs.Styles[2].inde
//				a.Add(cs);				
//			}
		}

		private void nav_TBarClick(object sender, ToolBarButtonClickEventArgs e)
		{					
			if (e.Button.Equals(nav.cmd_add))
			{				
				nav.ToolBar_Click(e);	
				Init_CB();
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
				if(T_String.IsNullTo0(T_String.GetDataFromSQL("Count(*)","FILA02A","DEP_HG=N'"+vs.Rows[vs.Row]["DEP_ID"]+"'"))>0)
				{
					MessageBox.Show("ko the xoa");
					return;
				}
				if(T_String.IsNullTo0(T_String.GetDataFromSQL("Count(*)","FILB01A","DEP_ID=N'"+vs.Rows[vs.Row]["DEP_ID"]+"'"))>0)
				{
					MessageBox.Show("ko the xoa");
					return;
				}
			}
			nav.ToolBar_Click(e);							
			if (e.Button.Equals(nav.cmd_save))
			{	
				Init_CB();				
			}			
		}

		private void vs1_AfterRowColChange(object sender, RangeEventArgs e)
		{
			if(e.NewRange.r1!=e.OldRange.r1)
			{				
					Show_Data();
			}
		}
		private void vs_SetupEditor(object sender, RowColEventArgs e)
		{
			Control ctl = vs.Editor;
			if (ctl is TextBox) 
			{
				switch(vs.Cols[e.Col].Name)
				{	
					case "DEP_ID":
					case "DEP_HG":
						((TextBox)ctl).MaxLength = 10;
						break;
					case "DEP_NM":
					case "DEP_N1":
						((TextBox)ctl).MaxLength = 100;
						break;
				}
			}
		}

		private void ck_CheckedChanged(object sender, System.EventArgs e)
		{			
			Show_Data();
		}

		private void vs_CellButtonClick(object sender, RowColEventArgs e)
		{
			if(color.ShowDialog()==DialogResult.OK )
			{				
				vs.Rows[vs.Row]["COL_NO"]=color.Color.R+"."+color.Color.G+"."+color.Color.B ;
			}
		}

		private void vs1_SizeChanged(object sender, EventArgs e)
		{
			//vs1.Cols[0].Width=vs1.Width ;
		}
	}
}

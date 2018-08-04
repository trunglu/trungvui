using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Basic.Function;
using GP8000.SYSForm;
namespace Basic.Form
{
	/// <summary>
	/// Summary description for frmSecurity.
	/// </summary>
	public class frmSecurity : System.Windows.Forms.Form
	{
		private C1.Win.C1FlexGrid.C1FlexGrid vs;
		private Navigator1._0.NavigatorAuto nav1;
		private string lag;
		private System.Windows.Forms.Panel panel1;
		private C1.Win.C1FlexGrid.C1FlexGrid vs1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Splitter splitter1;
		private Navigator1._0.NavigatorAuto nav2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Splitter splitter2;
		private System.Windows.Forms.Panel panel6;
		private C1.Win.C1FlexGrid.C1FlexGrid vs3;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Splitter splitter3;
		private System.Windows.Forms.Panel panel8;
		private System.ComponentModel.IContainer components;

		public frmSecurity()
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmSecurity));
			this.vs = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.nav1 = new Navigator1._0.NavigatorAuto();
			this.panel1 = new System.Windows.Forms.Panel();
			this.vs1 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.nav2 = new Navigator1._0.NavigatorAuto();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.splitter2 = new System.Windows.Forms.Splitter();
			this.panel6 = new System.Windows.Forms.Panel();
			this.vs3 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.panel7 = new System.Windows.Forms.Panel();
			this.splitter3 = new System.Windows.Forms.Splitter();
			this.panel8 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs1)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs3)).BeginInit();
			this.panel7.SuspendLayout();
			this.panel8.SuspendLayout();
			this.SuspendLayout();
			// 
			// vs
			// 
			this.vs.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Columns;
			this.vs.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.vs.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs.Location = new System.Drawing.Point(0, 40);
			this.vs.Name = "vs";
			this.vs.Size = new System.Drawing.Size(224, 240);
			this.vs.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs.TabIndex = 1;
			this.vs.DoubleClick += new System.EventHandler(this.vs_DoubleClick);
			this.vs.AfterRowColChange += new C1.Win.C1FlexGrid.RangeEventHandler(this.vs_AfterRowColChange);
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
			this.nav1.Size = new System.Drawing.Size(220, 32);
			this.nav1.TabIndex = 8;
			this.nav1.ToolBar_Auto = true;
			this.nav1.UserID = null;
			this.nav1.VisibleGrid = true;
			this.nav1.Where = null;
			this.nav1.TBarClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.nav1_TBarClick_1);
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.BackColor = System.Drawing.SystemColors.Control;
			this.panel1.Controls.Add(this.panel8);
			this.panel1.Controls.Add(this.splitter3);
			this.panel1.Controls.Add(this.panel7);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(224, 400);
			this.panel1.TabIndex = 9;
			// 
			// vs1
			// 
			this.vs1.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vs1.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs1.Location = new System.Drawing.Point(0, 0);
			this.vs1.Name = "vs1";
			this.vs1.Size = new System.Drawing.Size(592, 361);
			this.vs1.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs1.TabIndex = 5;
			// 
			// panel2
			// 
			this.panel2.AutoScroll = true;
			this.panel2.BackColor = System.Drawing.SystemColors.Control;
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(224, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(592, 400);
			this.panel2.TabIndex = 12;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.ImageIndex = 0;
			this.button1.ImageList = this.imageList1;
			this.button1.Location = new System.Drawing.Point(268, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(44, 32);
			this.button1.TabIndex = 106;
			this.button1.Tag = "N";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(25, 25);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// nav2
			// 
			this.nav2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.nav2.Connection = null;
			this.nav2.ConnectionDel = null;
			this.nav2.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.nav2.form = null;
			this.nav2.FormName = null;
			this.nav2.Grid = null;
			this.nav2.History = false;
			this.nav2.IsNull = true;
			this.nav2.Language = "EN";
			this.nav2.Location = new System.Drawing.Point(4, 4);
			this.nav2.MSG_Exit = false;
			this.nav2.MulltiDel = false;
			this.nav2.Name = "nav2";
			this.nav2.Security = 0;
			this.nav2.ShowPopupMenu = false;
			this.nav2.Size = new System.Drawing.Size(260, 32);
			this.nav2.TabIndex = 105;
			this.nav2.Tag = "";
			this.nav2.ToolBar_Auto = true;
			this.nav2.UserID = null;
			this.nav2.VisibleGrid = true;
			this.nav2.Where = null;
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(224, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(4, 400);
			this.splitter1.TabIndex = 13;
			this.splitter1.TabStop = false;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.panel3.Controls.Add(this.nav2);
			this.panel3.Controls.Add(this.button1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(592, 36);
			this.panel3.TabIndex = 107;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.panel6);
			this.panel4.Controls.Add(this.splitter2);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(0, 36);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(592, 364);
			this.panel4.TabIndex = 108;
			// 
			// splitter2
			// 
			this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
			this.splitter2.Location = new System.Drawing.Point(0, 0);
			this.splitter2.Name = "splitter2";
			this.splitter2.Size = new System.Drawing.Size(592, 3);
			this.splitter2.TabIndex = 7;
			this.splitter2.TabStop = false;
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.vs1);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel6.Location = new System.Drawing.Point(0, 3);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(592, 361);
			this.panel6.TabIndex = 8;
			// 
			// vs3
			// 
			this.vs3.AllowEditing = false;
			this.vs3.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
			this.vs3.BackColor = System.Drawing.SystemColors.Highlight;
			this.vs3.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs3.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vs3.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs3.Location = new System.Drawing.Point(0, 0);
			this.vs3.Name = "vs3";
			this.vs3.Size = new System.Drawing.Size(224, 117);
			this.vs3.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs3.TabIndex = 6;
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.nav1);
			this.panel7.Controls.Add(this.vs);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(224, 280);
			this.panel7.TabIndex = 9;
			// 
			// splitter3
			// 
			this.splitter3.Dock = System.Windows.Forms.DockStyle.Top;
			this.splitter3.Location = new System.Drawing.Point(0, 280);
			this.splitter3.Name = "splitter3";
			this.splitter3.Size = new System.Drawing.Size(224, 3);
			this.splitter3.TabIndex = 10;
			this.splitter3.TabStop = false;
			// 
			// panel8
			// 
			this.panel8.Controls.Add(this.vs3);
			this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel8.Location = new System.Drawing.Point(0, 283);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(224, 117);
			this.panel8.TabIndex = 11;
			// 
			// frmSecurity
			// 
			this.AutoScale = false;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(816, 400);
			this.Controls.Add(this.splitter1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmSecurity";
			this.Text = "frmSecurity";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmSecurity_Load);
			this.Closed += new System.EventHandler(this.frmSecurity_Closed);
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs3)).EndInit();
			this.panel7.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmSecurity_Load(object sender, System.EventArgs e)
		{	
			lag=PublicFunction.L_Lag;
			Func.Fun.ExecuteSQL("Delete from SYS_SECURITY where MNU_ID not in(Select ID from SYS_MENU)",PublicFunction.C_con,true);
			Func.Fun.ExecuteSQL("Delete from SYS_SECURITY where GROUP_ID not in(Select GROUP_ID from SYS_GROUP)",PublicFunction.C_con,true);
			nav2.cmd_search.Visible=false;
			nav2.cmd_report.Visible=false;
			nav2.cmd_copy.Visible=false;
			nav2.cmd_delete.Visible=false;
			nav2.cmd_add.Visible=false;	
			nav2.cmd_refresh.Visible=false;			
			nav2.Grid=vs1;			
			nav2.FormName=this.Name+"_vs1";
			nav2.Connection=Function.PublicFunction.C_con;
			// Security
			nav2.Security=(int)this.Tag;
			nav2.UserID=PublicFunction.A_UserID;
			// 
			//nav2.TableName="SYS_SECURITY";
			nav2.Init_Control();
			nav2.form=this;

			nav1.cmd_search.Visible=false;
			nav1.cmd_report.Visible=false;
			nav1.cmd_copy.Visible=false;
			nav1.cmd_fisrt.Visible=false;
			nav1.cmd_last.Visible=false;
			nav1.Grid=vs;			
			nav1.FormName=this.Name+"_vs";
			nav1.Connection=Function.PublicFunction.C_con;						
			// Security
			nav1.Security=(int)this.Tag;
			nav1.UserID=PublicFunction.A_UserID;
			// Security
			
			nav1.Init_Control();
			nav1.Show_VS();	
			init_vs3();	

			PublicFunction.L_Init_Label(this);
//			nav1.Init_PMenu_Color();
//			nav2.Init_PMenu_Color();	
			vs1.Cols["SYSSEL"].Visible=false;
			nav2.ToolBar_Auto=true;
			vs1.AfterEdit+=new C1.Win.C1FlexGrid.RowColEventHandler(vs1_AfterEdit);
			vs1.BeforeEdit+=new C1.Win.C1FlexGrid.RowColEventHandler(vs1_BeforeEdit);
			vs1.SelectionMode=C1.Win.C1FlexGrid.SelectionModeEnum.CellRange; 
			vs1.CellButtonClick+=new C1.Win.C1FlexGrid.RowColEventHandler(vs1_CellButtonClick);
			vs1.Styles.Add("DEP_ID");
			vs1.Styles["DEP_ID"].Font=new  Font(vs1.Font, FontStyle.Bold);				
			vs1.Styles["DEP_ID"].BackColor=Color.LemonChiffon;

			vs1.Styles.Add("POS_BT");
			vs1.Styles["POS_BT"].Font=new  Font(vs1.Font, FontStyle.Bold);				
			vs1.Styles["POS_BT"].BackColor=Color.Silver;
			vs1.Cols["EN"].ComboList="...";
			vs1.Cols["CH"].ComboList="...";
			vs1.Cols["VN"].ComboList="...";
			vs1.Cols["TYP"].ComboList="...";
			vs1.Cols["EN"].AllowEditing=true;
			vs1.Cols["VN"].AllowEditing=true;
			vs1.Cols["CH"].AllowEditing=true;
			Show_VS1();				
		}

		private void  init_vs3()
		{
			vs3.Rows.Count=1;
			vs3.Cols.Count=3;
			vs3.Cols[1].Name="GRP_NM";
			vs3.Cols[2].Name="GRP_ID";
			vs3.Cols[2].Visible=false;
			Func.RecordSet rs=new  Func.RecordSet("Select * from SYS_MENU where H_ID=-1 and ID<>0 and ID<>7",PublicFunction.C_con);				
			vs3.Rows.Count++;
			vs3.Rows[vs3.Rows.Count-1][0]=vs3.Rows.Count-1;
			vs3.Rows[vs3.Rows.Count-1]["GRP_NM"]=PublicFunction.L_GetLabel_VS(this.Name,"All");
			vs3.Rows[vs3.Rows.Count-1]["GRP_ID"]="ALL";
			for(int i=0;i<rs.rows;i++)
			{
				vs3.Rows.Count++;
				vs3.Rows[vs3.Rows.Count-1][0]=vs3.Rows.Count-1;
				vs3.Rows[vs3.Rows.Count-1]["GRP_NM"]=rs.record(i,PublicFunction.L_Lag);
				vs3.Rows[vs3.Rows.Count-1]["GRP_ID"]=rs.record(i,"ID");
			}
			vs3.AutoSizeCols();
			vs3.AfterRowColChange+=new C1.Win.C1FlexGrid.RangeEventHandler(vs3_AfterRowColChange);
			vs3.BackColor=Color.LemonChiffon;
		}

		private void nav1_TBarClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{			
			switch (nav1.TBar.Buttons.IndexOf(e.Button))
			{
				case 7:
					Show_VS1();	
					break;
			}
		}

		private void vs_AfterRowColChange(object sender, C1.Win.C1FlexGrid.RangeEventArgs e)
		{
			if (e.OldRange.r1!=e.NewRange.r2)
			{				
				Show_VS1();
			}
		}

		private void Show_VS1()
		{
			if (vs.Row<1) return;
			if (nav1.State && (int)vs.Rows[vs.Row].UserData==2)
			{
				vs1.Rows.Count =1;
				return;
			}
			if (nav1.State )
			{
				string sql;
				sql="Insert Into SYS_SECURITY(GROUP_ID,MNU_ID) Select '" +
					vs.Rows[vs.Row]["GROUP_ID"]+"' as GROUP_ID,[ID] as MNU_ID from SYS_MENU where SEC=1 and [ID] not in (" +
					"select MNU_ID from SYS_SECURITY where GROUP_ID=N'"+vs.Rows[vs.Row]["GROUP_ID"]+"') and [ID] not in (Select H_ID from SYS_MENU)";
				Func.Fun.ExecuteSQL(sql,PublicFunction.C_con);
				if(vs3.Row<=1)
					nav2.Show_VS("GROUP_ID=N'"+vs.Rows[vs.Row]["GROUP_ID"]+"' and a.MNU_ID=ID and SEC=1 order by EN");
				else
				{
					string ID=vs3.Rows[vs3.Row]["GRP_ID"]+"";
					ID=getsql(ID);
					if(ID.Length>1)
					{
						ID=ID.Remove(0,1);
					}
					nav2.Show_VS("GROUP_ID=N'"+vs.Rows[vs.Row]["GROUP_ID"]+"' and a.MNU_ID=ID and SEC=1 and ID in("+ID+")  order by EN");
				}
				for(int i=1;i<vs1.Rows.Count;i++)
				{
					if(vs1.Rows[i]["DEP_BT"]+""=="True")
					{
						vs1.SetCellStyle(i,vs1.Cols["EN"].Index,vs1.Styles["DEP_ID"]);						
						vs1.SetCellStyle(i,vs1.Cols["CH"].Index,vs1.Styles["DEP_ID"]);						
						vs1.SetCellStyle(i,vs1.Cols["VN"].Index,vs1.Styles["DEP_ID"]);						
					}

					if(vs1.Rows[i]["TYP_BT"]+""=="True")
					{
						vs1.SetCellStyle(i,vs1.Cols["TYP"].Index,vs1.Styles["POS_BT"]);															
						vs1.Rows[i]["TYP"]=vs1.Rows[0]["TYP"];
					}
				}
			}
		}
		
		private string getsql(string DID)
		{
			string sql="";
			Func.RecordSet rs=new Func.RecordSet("Select * from SYS_MENU where H_ID="+DID,PublicFunction.C_con);
			for(int i=0;i<rs.rows;i++)
			{
				sql+=","+rs.record(i,"ID");
				sql+=getsql(rs.record(i,"ID"));
			}
			return sql;
		}
		private void vs1_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			if(vs1.Cols[e.Col].Name=="EN"||vs1.Cols[e.Col].Name=="VN"||vs1.Cols[e.Col].Name=="CH")
			{
				if(vs1.Rows[e.Row]["DEP_BT"]+""!="True")
				{
					e.Cancel=true;
				}		
				return;
			}

			if(vs1.Cols[e.Col].Name=="TYP")
			{
				if(vs1.Rows[e.Row]["TYP_BT"]+""!="True")
				{
					e.Cancel=true;
				}
				return;
			}
		}
		private void vs1_CellButtonClick(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			if(vs1.Cols[e.Col].Name=="EN"||vs1.Cols[e.Col].Name=="VN"||vs1.Cols[e.Col].Name=="CH")
			{
				if(vs1.Rows[e.Row]["DEP_BT"]+""=="True")
				{
					frmTaSecurityByDep dlg=new frmTaSecurityByDep(vs1.Rows[e.Row]["GROUP_ID"]+"",vs1.Rows[e.Row]["MNU_ID"]+"",vs1.Rows[e.Row][e.Col]+"");
					dlg.Tag=this.Tag;
					dlg.ShowDialog();
				}
			}
			if(vs1.Cols[e.Col].Name=="TYP")
			{
				if(vs1.Rows[e.Row]["TYP_BT"]+""=="True")
				{
					frmTaSecurityByPos dlg=new frmTaSecurityByPos(vs1.Rows[e.Row]["GROUP_ID"]+"",vs1.Rows[e.Row]["MNU_ID"]+"",vs1.Rows[e.Row][PublicFunction.L_Lag]+"");
					dlg.Tag=this.Tag;
					dlg.ShowDialog();
				}
			}		
		}

		private void frmSecurity_Closed(object sender, System.EventArgs e)
		{
			nav2.Save_SEQ();
			nav1.Save_SEQ();
		}

		private void vs_DoubleClick(object sender, System.EventArgs e)
		{
			if ((int)vs.Rows[vs.Row].UserData!=2)
			{
				frmUser dlg=new frmUser(vs.Rows[vs.Row]["GROUP_ID"]+"");
				dlg.Tag=this.Tag;
				dlg.ShowDialog();
			}
		}

		private void nav1_TBarClick_1(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			if (e.Button.Equals(nav1.cmd_save))
				nav1.Show_VS();
		}

		private void vs1_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			for (int i=vs1.Selection.r1;i<=vs1.Selection.r2;i++)
			{
				for (int j=vs1.Selection.c1;j<=vs1.Selection.c2;j++)
				{
					if (vs1.Cols[j].DataType==typeof(Boolean))
					{
						vs1[i,j ]=vs1[e.Row,e.Col];
						vs1.Rows[i].UserData=1;
					}
				}
			}
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			if ((int)vs.Rows[vs.Row].UserData!=2)
			{				
				frmUser dlg=new frmUser(vs.Rows[vs.Row]["GROUP_ID"]+"");
				dlg.Tag=this.Tag;
				dlg.ShowDialog();
			}
		}

		private void vs3_AfterRowColChange(object sender, C1.Win.C1FlexGrid.RangeEventArgs e)
		{
			if (e.OldRange.r1!=e.NewRange.r2)
			{				
				Show_VS1();
			}
		}
	}
}

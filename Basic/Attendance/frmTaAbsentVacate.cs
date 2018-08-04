using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Basic.Form;
using Basic.Function;

namespace GP8000.Attendance
{
	/// <summary>
	/// Summary description for frmTaGraduation.
	/// </summary>
	public class frmTaAbsentVacate : System.Windows.Forms.Form
	{
		private C1.Win.C1FlexGrid.C1FlexGrid vs;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel4;
		private Navigator1._0.NavigatorAuto nav;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton r3;
		private System.Windows.Forms.RadioButton r2;
		private System.Windows.Forms.RadioButton r1;
		private System.Windows.Forms.TextBox txt2;
		private System.Windows.Forms.TextBox txt1;
		private System.Windows.Forms.Panel panel2;
//		private AxGPRPT.AxReport axReport1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaAbsentVacate()
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
			this.vs = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.nav = new Navigator1._0.NavigatorAuto();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.r3 = new System.Windows.Forms.RadioButton();
			this.r2 = new System.Windows.Forms.RadioButton();
			this.r1 = new System.Windows.Forms.RadioButton();
			this.txt2 = new System.Windows.Forms.TextBox();
			this.txt1 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
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
			this.vs.Location = new System.Drawing.Point(4, 36);
			this.vs.Name = "vs";
			this.vs.Size = new System.Drawing.Size(760, 368);
			this.vs.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs.TabIndex = 19;
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
			this.panel3.Size = new System.Drawing.Size(768, 36);
			this.panel3.TabIndex = 18;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Location = new System.Drawing.Point(416, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(352, 36);
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
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.vs);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 36);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(768, 408);
			this.panel1.TabIndex = 20;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Moccasin;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.r3);
			this.panel2.Controls.Add(this.r2);
			this.panel2.Controls.Add(this.r1);
			this.panel2.Controls.Add(this.txt2);
			this.panel2.Controls.Add(this.txt1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(768, 32);
			this.panel2.TabIndex = 20;
			// 
			// r3
			// 
			this.r3.BackColor = System.Drawing.Color.Moccasin;
			this.r3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.r3.Location = new System.Drawing.Point(592, 3);
			this.r3.Name = "r3";
			this.r3.Size = new System.Drawing.Size(144, 24);
			this.r3.TabIndex = 77;
			this.r3.Text = "radioButton3";
			this.r3.CheckedChanged += new System.EventHandler(this.r1_CheckedChanged);
			// 
			// r2
			// 
			this.r2.BackColor = System.Drawing.Color.Moccasin;
			this.r2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.r2.Location = new System.Drawing.Point(448, 3);
			this.r2.Name = "r2";
			this.r2.Size = new System.Drawing.Size(144, 24);
			this.r2.TabIndex = 76;
			this.r2.Text = "radioButton2";
			this.r2.CheckedChanged += new System.EventHandler(this.r1_CheckedChanged);
			// 
			// r1
			// 
			this.r1.BackColor = System.Drawing.Color.Moccasin;
			this.r1.Checked = true;
			this.r1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.r1.Location = new System.Drawing.Point(288, 4);
			this.r1.Name = "r1";
			this.r1.Size = new System.Drawing.Size(144, 24);
			this.r1.TabIndex = 75;
			this.r1.TabStop = true;
			this.r1.Text = "radioButton1";
			this.r1.CheckedChanged += new System.EventHandler(this.r1_CheckedChanged);
			// 
			// txt2
			// 
			this.txt2.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt2.Location = new System.Drawing.Point(144, 4);
			this.txt2.MaxLength = 20;
			this.txt2.Name = "txt2";
			this.txt2.Size = new System.Drawing.Size(132, 23);
			this.txt2.TabIndex = 74;
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
			this.txt1.Location = new System.Drawing.Point(8, 4);
			this.txt1.MaxLength = 20;
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(132, 23);
			this.txt1.TabIndex = 73;
			this.txt1.Tag = "EMP_ID";
			this.txt1.Text = "textBox3";
			this.txt1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
			this.txt1.Leave += new System.EventHandler(this.textBox1_Leave);
			this.txt1.Enter += new System.EventHandler(this.textBox1_Enter);
			// 
			// frmTaAbsentVacate
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(768, 444);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaAbsentVacate";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmTaAbsentVacate";
			this.Load += new System.EventHandler(this.frmTaGraduation_Load);
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaGraduation_Load(object sender, System.EventArgs e)
		{
			nav.cmd_copy.Visible=false;			
			nav.cmd_search.Visible=false;
			PublicFunction.InitNav(this,vs,nav);						
			vs.Cols["TOO_DT"].Format=vs.Cols["FRM_DT"].Format=vs.Cols["SEQ_DT"].Format=PublicFunction.GetOption("DATE");
			nav.Show_VS("(a.VAC_BT is null or a.VAC_BT=0) and (a.DON_AP is null or a.DON_AP=0) and DEP_ID in "+T_String.DEP_ID(this.Tag));										
			nav.ToolBar_Auto=false;
			vs.EnabledChanged+=new EventHandler(vs_EnabledChanged);
			vs.BeforeEdit+=new C1.Win.C1FlexGrid.RowColEventHandler(vs_BeforeEdit);
			vs.AfterEdit+=new C1.Win.C1FlexGrid.RowColEventHandler(vs_AfterEdit);
			Basic.Function.PublicFunction.L_Init_Label(this);	
			nav.TBarClick+=new ToolBarButtonClickEventHandler(nav_TBarClick);				
			Init_CB();			
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
					rpt.RPT2(c1XLBook1,vs,mnu1.MenuItems[mnu1.MenuItems.IndexOf((MenuItem)sender)].Text,"STD_TA_06");					
					break;
				
			}
		}
		#endregion	
		private void vs_EnabledChanged(object sender, EventArgs e)
		{	
			txt1.Text=vs.Cols[txt1.Tag+""].Caption;
			txt2.Text=vs.Cols[txt2.Tag+""].Caption;			
			vs.AutoSizeCols();
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
			
		}
		
		private void nav_TBarClick(object sender, ToolBarButtonClickEventArgs e)
		{					
			
			nav.ToolBar_Click(e);
		}

		private void r1_CheckedChanged(object sender, System.EventArgs e)
		{
			if(r1.Checked)
				nav.Show_VS("(a.VAC_BT is null or a.VAC_BT=0) and (a.DON_AP is null or a.DON_AP=0) and DEP_ID in "+T_String.DEP_ID(this.Tag));			
			else
			{
				if(r2.Checked)
					nav.Show_VS("a.VAC_BT=1 and DEP_ID in "+T_String.DEP_ID(this.Tag));			
				else
					nav.Show_VS("a.DON_AP=1 and DEP_ID in "+T_String.DEP_ID(this.Tag));			
			}

		}		
		#region Search
		private void textBox1_Enter(object sender, System.EventArgs e)
		{
			TextBox txt=(TextBox)sender;
			if (txt.Text==vs.Cols[txt.Tag+""].Caption)
				txt.Text="";
		}

		private void textBox1_Leave(object sender, System.EventArgs e)
		{
			TextBox txt=(TextBox)sender;
			if (txt.Text=="")
				txt.Text=vs.Cols[txt.Tag+""].Caption;
		}

		private void textBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Enter)
			{
				string f="b." + ((TextBox)sender).Tag+"";			
				string sql;				
				if(((TextBox)sender).Text+""!="")
					sql=f+" like N'%"+((TextBox)sender).Text+"%'";
				else
					sql="1=1";
				sql=sql+" and DEP_ID in (Select DEP_ID  from SYS_SECURITY_DEP"+
					" where MNU_ID="+this.Tag+" and ALL_BT=1  and USER_ID=N'"+PublicFunction.A_UserID+"')";					
				nav.Show_VS(sql);					
			}
		}
	
		
		#endregion

		private void vs_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			if(!PublicFunction.AccessLevel(this.Tag,3))
				e.Cancel=true;
			if(e.Row<=0)	return;
			if(vs.Cols[e.Col].Name=="DON_AP" || vs.Cols[e.Col].Name=="VAC_BT" )
			{
				if(vs.Rows[e.Row]["DON_AP"]+""=="True" || vs.Rows[e.Row]["VAC_BT"]+""=="True")
					e.Cancel=true;
			}
		}

		private void vs_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			if(vs.Cols[e.Col].Name=="DON_AP")
			{
				GP8000.Payroll.frmTaTXT dlg=new GP8000.Payroll.frmTaTXT();
				if(dlg.ShowDialog()==DialogResult.OK)
				{
					vs.Rows[e.Row]["REA_DR"]=dlg.txt.Text;
					vs.Rows[e.Row]["LST_NM"]=PublicFunction.A_UserID;
					vs.Rows[e.Row]["LST_DT"]=T_String.GetDate().ToString("yyyy/MM/dd HH:mm");
					nav.SaveRow(e.Row);
				}
				else
				{
					vs.Rows[e.Row]["DON_AP"]=false;
				}
			}
			if(vs.Cols[e.Col].Name=="VAC_BT")
			{
				if(T_String.GetMax("COUNT(EMP_ID)","FILB01A","EMP_ID=N'"+
					vs.Rows[e.Row]["EMP_ID"]+"' and VAC_BT=1")>1)
				{
					MessageBox.Show(PublicFunction.L_Get_Msg("msg",120));
					vs.Rows[e.Row]["VAC_BT"]=false;
				}
				else
				{
					frmTaVacate dlg1=new frmTaVacate();
					dlg1.EMP_ID.Text=vs.Rows[e.Row]["EMP_ID"]+"";
					dlg1.EMP_NM.Text=vs.Rows[e.Row]["EMP_NM"]+"";
					dlg1.DEP_ID.Text=vs.GetDataDisplay(e.Row,"DEP_ID");
					dlg1.POS_ID.Text=vs.GetDataDisplay(e.Row,"EMP_I1");
					if(dlg1.ShowDialog()==DialogResult.OK)
					{
						vs.Rows[e.Row]["LST_NM"]=PublicFunction.A_UserID;
						vs.Rows[e.Row]["LST_DT"]=T_String.GetDate().ToString("yyyy/MM/dd HH:mm");
						nav.SaveRow(e.Row);
					}
					else
						vs.Rows[e.Row]["VAC_BT"]=false;
				}
			}
		}
	}
}

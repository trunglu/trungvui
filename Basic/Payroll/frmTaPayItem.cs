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

namespace GP8000.Payroll
{
	/// <summary>
	/// Summary description for frmTaPayItem.
	/// </summary>
	public class frmTaPayItem : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel3;
		private Navigator1._0.NavigatorAuto nav;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private C1.Win.C1FlexGrid.C1FlexGrid vs;
		private System.Windows.Forms.Panel panel7;
		private C1.Win.C1FlexGrid.C1FlexGrid vs1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rd1;
		private System.Windows.Forms.RadioButton rd2;
		private System.Windows.Forms.RadioButton rd3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Splitter splitter2;
		private System.Windows.Forms.Panel panel8;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaPayItem()
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
			this.panel7 = new System.Windows.Forms.Panel();
			this.nav = new Navigator1._0.NavigatorAuto();
			this.panel1 = new System.Windows.Forms.Panel();
			this.vs1 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.vs = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.panel2 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rd3 = new System.Windows.Forms.RadioButton();
			this.rd2 = new System.Windows.Forms.RadioButton();
			this.rd1 = new System.Windows.Forms.RadioButton();
			this.panel4 = new System.Windows.Forms.Panel();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.splitter2 = new System.Windows.Forms.Splitter();
			this.panel8 = new System.Windows.Forms.Panel();
			this.panel3.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
			this.panel2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel8.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.panel7);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(920, 36);
			this.panel3.TabIndex = 6;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Location = new System.Drawing.Point(412, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(508, 36);
			this.label5.TabIndex = 12;
			this.label5.Tag = "";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.nav);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(412, 36);
			this.panel7.TabIndex = 0;
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
			this.nav.Location = new System.Drawing.Point(4, 4);
			this.nav.MSG_Exit = false;
			this.nav.MulltiDel = false;
			this.nav.Name = "nav";
			this.nav.Security = 0;
			this.nav.ShowPopupMenu = true;
			this.nav.Size = new System.Drawing.Size(400, 32);
			this.nav.TabIndex = 13;
			this.nav.Tag = "";
			this.nav.ToolBar_Auto = true;
			this.nav.UserID = null;
			this.nav.VisibleGrid = true;
			this.nav.Where = null;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 36);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(920, 512);
			this.panel1.TabIndex = 7;
			// 
			// vs1
			// 
			this.vs1.AllowEditing = false;
			this.vs1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs1.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vs1.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs1.Location = new System.Drawing.Point(0, 0);
			this.vs1.Name = "vs1";
			this.vs1.Size = new System.Drawing.Size(733, 285);
			this.vs1.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs1.TabIndex = 13;
			// 
			// vs
			// 
			this.vs.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.Both;
			this.vs.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vs.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs.Location = new System.Drawing.Point(0, 0);
			this.vs.Name = "vs";
			this.vs.Size = new System.Drawing.Size(920, 224);
			this.vs.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs.TabIndex = 12;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.panel5);
			this.panel2.Controls.Add(this.splitter1);
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(920, 512);
			this.panel2.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.rd3);
			this.groupBox1.Controls.Add(this.rd2);
			this.groupBox1.Controls.Add(this.rd1);
			this.groupBox1.Location = new System.Drawing.Point(8, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(172, 108);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Tag = "N";
			// 
			// rd3
			// 
			this.rd3.Location = new System.Drawing.Point(12, 76);
			this.rd3.Name = "rd3";
			this.rd3.Size = new System.Drawing.Size(156, 24);
			this.rd3.TabIndex = 2;
			this.rd3.Text = "Non-Caculation";
			this.rd3.CheckedChanged += new System.EventHandler(this.rd1_CheckedChanged);
			// 
			// rd2
			// 
			this.rd2.Location = new System.Drawing.Point(12, 48);
			this.rd2.Name = "rd2";
			this.rd2.Size = new System.Drawing.Size(156, 24);
			this.rd2.TabIndex = 1;
			this.rd2.Text = "Deductible";
			this.rd2.CheckedChanged += new System.EventHandler(this.rd1_CheckedChanged);
			// 
			// rd1
			// 
			this.rd1.Checked = true;
			this.rd1.Location = new System.Drawing.Point(12, 20);
			this.rd1.Name = "rd1";
			this.rd1.Size = new System.Drawing.Size(156, 24);
			this.rd1.TabIndex = 0;
			this.rd1.TabStop = true;
			this.rd1.Text = "Payable";
			this.rd1.CheckedChanged += new System.EventHandler(this.rd1_CheckedChanged);
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.vs);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(920, 224);
			this.panel4.TabIndex = 13;
			// 
			// splitter1
			// 
			this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
			this.splitter1.Location = new System.Drawing.Point(0, 224);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(920, 3);
			this.splitter1.TabIndex = 14;
			this.splitter1.TabStop = false;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.panel8);
			this.panel5.Controls.Add(this.splitter2);
			this.panel5.Controls.Add(this.panel6);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(0, 227);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(920, 285);
			this.panel5.TabIndex = 15;
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.groupBox1);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel6.Location = new System.Drawing.Point(736, 0);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(184, 285);
			this.panel6.TabIndex = 0;
			// 
			// splitter2
			// 
			this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
			this.splitter2.Location = new System.Drawing.Point(733, 0);
			this.splitter2.Name = "splitter2";
			this.splitter2.Size = new System.Drawing.Size(3, 285);
			this.splitter2.TabIndex = 1;
			this.splitter2.TabStop = false;
			// 
			// panel8
			// 
			this.panel8.Controls.Add(this.vs1);
			this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel8.Location = new System.Drawing.Point(0, 0);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(733, 285);
			this.panel8.TabIndex = 2;
			// 
			// frmTaPayItem
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(920, 548);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaPayItem";
			this.Text = "frmTaPayItem";
			this.Load += new System.EventHandler(this.frmTaPayItem_Load);
			this.panel3.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			this.panel2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaPayItem_Load(object sender, System.EventArgs e)
		{
			Init_Form();			
		}
		private void Init_Form()
		{		
			Init_vs();	
			Init_vs1();
			Basic.Function.PublicFunction.L_Init_Label(this);				
		}
		private void Init_vs()
		{		
			nav.cmd_copy.Visible=false;
			nav.cmd_report.Visible=false;
			nav.cmd_search.Visible=false;
			PublicFunction.InitNav(this,vs,nav);	
			nav.Show_VS("1=1 order by SEQ_NO");			
			nav.ToolBar_Auto=false;
			nav.TBarClick+=new ToolBarButtonClickEventHandler(nav_TBarClick);
			vs.AfterEdit+=new C1.Win.C1FlexGrid.RowColEventHandler(vs_AfterEdit);
			vs.BeforeEdit+=new C1.Win.C1FlexGrid.RowColEventHandler(vs_BeforeEdit);
		}
		private void Init_vs1()
		{				
//			PublicFunction.InitNav(this,vs1,nav1);	
//			nav1.Show_VS();	
			//vs1.AllowEditing=true;
			vs1.Cols.Count=7;
			vs1.Cols[1].Name="COL_ID";
			vs1.Cols[1].Visible=false;
			vs1.Cols[2].Name="COL_NM";
			vs1.Cols[3].Name="COL_DR";
			vs1.Cols[3].AllowEditing=false;
			vs1.Cols[4].Name="COL_TB";
			vs1.Cols[4].Visible=false;	
			vs1.Cols[5].Name="COL_FD";
			vs1.Cols[5].Visible=false;	
			vs1.Cols[6].Name="COL_UD";
			vs1.Cols[6].Visible=false;	
			Show_VS1();
			vs1.AfterEdit+=new C1.Win.C1FlexGrid.RowColEventHandler(vs1_AfterEdit);
		}
		private void Show_VS1()
		{
			vs1.Rows.Count=1;
			Func.RecordSet rs;
			if(rd3.Checked)
			{
				rs=new Func.RecordSet("Select * from GP_SYS_GET_PAYROLLFOR",PublicFunction.C_con);
				for(int i=0;i<rs.rows;i++)
				{
					vs1.Rows.Count++;
					vs1.Rows[vs1.Rows.Count-1][0]=vs1.Rows.Count-1;
					vs1.Rows[vs1.Rows.Count-1]["COL_ID"]=rs.record(i,"COL_ID");
					if(rs.record(i,"COL_NM")+""!="")
						vs1.Rows[vs1.Rows.Count-1]["COL_NM"]=rs.record(i,"COL_NM");
					else
						vs1.Rows[vs1.Rows.Count-1]["COL_NM"]=rs.record(i,"COL_ID");
					vs1.Rows[vs1.Rows.Count-1]["COL_DR"]=PublicFunction.L_GetLabel_VS(rs.record(i,"DES_NM"),rs.record(i,"COL_ID"));
					vs1.Rows[vs1.Rows.Count-1]["COL_TB"]="GP_SYS_GET_PAYROLLFOR";
					vs1.Rows[vs1.Rows.Count-1]["COL_FD"]="COL_NM";
					vs1.Rows[vs1.Rows.Count-1]["COL_UD"]="COL_ID";
				}
			}
			if(rd1.Checked)
			{			
				rs=new Func.RecordSet("Select * from GP_SYS_SHIFT",PublicFunction.C_con);
				for(int i=0;i<rs.rows;i++)
				{
					vs1.Rows.Count++;
					vs1.Rows[vs1.Rows.Count-1][0]=vs1.Rows.Count-1;
					vs1.Rows[vs1.Rows.Count-1]["COL_ID"]=rs.record(i,"TYP_ID");
					if(rs.record(i,"TYP_NM")+""!="")
						vs1.Rows[vs1.Rows.Count-1]["COL_NM"]=rs.record(i,"TYP_NM");
					else
						vs1.Rows[vs1.Rows.Count-1]["COL_NM"]=rs.record(i,"TYP_ID");
					vs1.Rows[vs1.Rows.Count-1]["COL_DR"]=rs.record(i,"TYP_"+PublicFunction.L_Lag);
					vs1.Rows[vs1.Rows.Count-1]["COL_TB"]="GP_SYS_SHIFT";
					vs1.Rows[vs1.Rows.Count-1]["COL_FD"]="TYP_NM";
					vs1.Rows[vs1.Rows.Count-1]["COL_UD"]="TYP_ID";
				}

				rs=new Func.RecordSet("Select * from GP_MONTHADDUP",PublicFunction.C_con);
				for(int i=0;i<rs.rows;i++)
				{
					vs1.Rows.Count++;
					vs1.Rows[vs1.Rows.Count-1][0]=vs1.Rows.Count-1;
					vs1.Rows[vs1.Rows.Count-1]["COL_ID"]=rs.record(i,"TYP_ID");
					if(rs.record(i,"TYP_NM")+""!="")
						vs1.Rows[vs1.Rows.Count-1]["COL_NM"]=rs.record(i,"TYP_NM");
					else
						vs1.Rows[vs1.Rows.Count-1]["COL_NM"]=rs.record(i,"TYP_ID");
					vs1.Rows[vs1.Rows.Count-1]["COL_DR"]=rs.record(i,"TYP_"+PublicFunction.L_Lag);
					vs1.Rows[vs1.Rows.Count-1]["COL_TB"]="GP_SYS_SHIFT";
					vs1.Rows[vs1.Rows.Count-1]["COL_FD"]="TYP_NM";
					vs1.Rows[vs1.Rows.Count-1]["COL_UD"]="TYP_ID";
				}

				rs=new Func.RecordSet("Select * from FILC07A",PublicFunction.C_con);
				for(int i=0;i<rs.rows;i++)
				{
					vs1.Rows.Count++;
					vs1.Rows[vs1.Rows.Count-1][0]=vs1.Rows.Count-1;
					vs1.Rows[vs1.Rows.Count-1]["COL_ID"]=rs.record(i,"COL_NM");
					if(rs.record(i,"COL_MM")+""!="")
						vs1.Rows[vs1.Rows.Count-1]["COL_NM"]=rs.record(i,"COL_MM");
					else
						vs1.Rows[vs1.Rows.Count-1]["COL_NM"]=rs.record(i,"COL_NM");
					vs1.Rows[vs1.Rows.Count-1]["COL_DR"]=rs.record(i,"COL_"+PublicFunction.L_Lag);
					vs1.Rows[vs1.Rows.Count-1]["COL_TB"]="FILC07A";
					vs1.Rows[vs1.Rows.Count-1]["COL_FD"]="COL_MM";
					vs1.Rows[vs1.Rows.Count-1]["COL_UD"]="COL_NM";					
				}
			}
			if(rd2.Checked)
			{
				rs=new Func.RecordSet("Select * from FILA15A",PublicFunction.C_con);
				for(int i=0;i<rs.rows;i++)
				{
					vs1.Rows.Count++;
					vs1.Rows[vs1.Rows.Count-1][0]=vs1.Rows.Count-1;
					if(rs.record(i,"COL_NM")+""!="")				
						vs1.Rows[vs1.Rows.Count-1]["COL_NM"]=rs.record(i,"COL_NM");
					else
						vs1.Rows[vs1.Rows.Count-1]["COL_NM"]=rs.record(i,"LEA_NM");
				
					vs1.Rows[vs1.Rows.Count-1]["COL_DR"]=rs.record(i,"LEA_NM");
					vs1.Rows[vs1.Rows.Count-1]["COL_TB"]="FILA15A";
					vs1.Rows[vs1.Rows.Count-1]["COL_ID"]=rs.record(i,"LEA_ID");
					vs1.Rows[vs1.Rows.Count-1]["COL_FD"]="COL_NM";
					vs1.Rows[vs1.Rows.Count-1]["COL_UD"]="LEA_ID";	
				}
				//vs1.Cols["COL_NM"].Visible=false;
			}
			//else{vs1.Cols["COL_NM"].Visible=true;}
			vs1.AutoSizeCols();
		}
		
		private void CheckShift()
		{
			string sql="Select * from GP_SYS_SHIFT where TYP_ID not in(Select COL_NM from GP_SYS_GET_PAYROLLFOR)";
			Func.RecordSet rs=new Func.RecordSet(sql,PublicFunction.C_con);
			for(int i=0;i<rs.rows;i++)
			{
				sql="Insert Into GP_SYS_GET_PAYROLLFOR(COL_NM,DES_NM,MON_BT) values";
			}
			
		}
	

		private void nav_TBarClick(object sender, ToolBarButtonClickEventArgs e)
		{
			if (e.Button.Equals(nav.cmd_add))
			{
				frmTaAddColPayroll dlg=new frmTaAddColPayroll();
				if(dlg.ShowDialog()==DialogResult.OK)
				{
					nav.Show_VS("1=1 order by SEQ_NO");			
				}		
				return;
			}			
			if (e.Button.Equals(nav.cmd_delete))
			{
				if(vs.Rows[vs.Row]["LCK_BT"]+""=="True")
				{
					MessageBox.Show(PublicFunction.L_Get_Msg("msg",178));
					return;
				}
				if(MessageBox.Show(this,PublicFunction.L_Get_Msg("msg",92)+" ["+vs.Rows[vs.Row]["COL_NM"]+"]?",this.Text,MessageBoxButtons.YesNo)==DialogResult.Yes)
				{
					if(MessageBox.Show(this,PublicFunction.L_Get_Msg("msg",93)+"",this.Text,MessageBoxButtons.YesNo)==DialogResult.Yes)
					{	
						string sCol = vs.Rows[vs.Row]["COL_NM"].ToString();
						if (nav.DeleteRow(vs.Row, false))
						{
							try
							{
								DropColumn("FILD02A", sCol);
								DropColumn("FILD03A", sCol);
								DropColumn("FILA19A", sCol);
							}
							catch(SqlException ex)
							{
								MessageBox.Show(ex.Message);
							}
						}
					}
				}
				return;
			}
			
			if (e.Button.Equals(nav.cmd_save))
			{
				for(int i=1;i<vs.Rows.Count;i++)
				{
					vs.Rows[i]["SEQ_NO"]=i;
					vs.Rows[i].UserData=1;
				}
			}
			nav.ToolBar_Click(e);
		}

		private void rd1_CheckedChanged(object sender, System.EventArgs e)
		{
			Show_VS1();
		}

		private void vs1_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			if(e.Row>0)
			{
				string sql="";
				sql="Update [" +vs1.Rows[e.Row]["COL_TB"]+"] set ["+T_String.sqlsql(vs1.Rows[e.Row]["COL_FD"]+"")+"]=N'"
					+vs1.Rows[e.Row]["COL_NM"]+"' where ["+vs1.Rows[e.Row]["COL_UD"]+"]=N'"
					+vs1.Rows[e.Row]["COL_ID"]+"'";
				PublicFunction.SQL_Execute(sql);
			}
		}

		private void vs_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{			
			if(vs.Cols[e.Col].Name=="BAS_BT")
			{
				if(vs.Rows[e.Row][e.Col]+""!="True")
				{
					vs.Rows[e.Row]["HUR_BT"]=vs.Rows[e.Row]["ACC_BT"]=0;
				}
			}
		}

		private void vs_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			if((vs.Cols[e.Col].Name=="HUR_BT" || vs.Cols[e.Col].Name=="ACC_BT" ) && vs.Rows[e.Row]["BAS_BT"]+""!="True")
			{
				e.Cancel=true;
			}
		}

		private void DropColumn(string _tbl, string _col)
		{
			string s;
			s = "SELECT name FROM sysobjects o WHERE xtype='D' AND OBJECT_NAME(parent_obj)='" + _tbl + "'"
				+ " AND (SELECT name FROM syscolumns c WHERE o.id=c.cdefault)='" + _col + "'";
			Func.RecordSet rs = new Func.RecordSet(s, PublicFunction.C_con);
			if (rs.rows > 0)
			{
				s = "ALTER TABLE [" + _tbl + "] DROP CONSTRAINT " + rs.record(0, 0).ToString();
				PublicFunction.SQL_Execute(s);
			}
			s = "ALTER TABLE [" + _tbl + "] DROP COLUMN [" + _col + "]";
			PublicFunction.SQL_Execute(s);
		}
	}
}

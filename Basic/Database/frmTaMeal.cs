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
using System.Data.SqlClient;
using GP8000.Function;
using System.Data;
namespace GP8000.Database
{
	/// <summary>
	/// Summary description for frmTaPosition.
	/// </summary>
	public class frmTaMeal : System.Windows.Forms.Form
	{
		private C1.Win.C1FlexGrid.C1FlexGrid vs;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel4;
		private Navigator1._0.NavigatorAuto nav;
		private System.Windows.Forms.ColorDialog color;
		private System.Windows.Forms.Panel panel1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaMeal()
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
			this.color = new System.Windows.Forms.ColorDialog();
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel1.SuspendLayout();
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
			this.vs.Location = new System.Drawing.Point(4, 4);
			this.vs.Name = "vs";
			this.vs.Size = new System.Drawing.Size(460, 226);
			this.vs.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs.TabIndex = 15;
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
			this.panel3.Size = new System.Drawing.Size(468, 36);
			this.panel3.TabIndex = 14;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Location = new System.Drawing.Point(416, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(52, 36);
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
			this.panel1.Controls.Add(this.vs);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 36);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(468, 230);
			this.panel1.TabIndex = 16;
			// 
			// frmTaPosition
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(468, 266);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaMeal";
			this.Text = "frmTaMeal";
			this.Load += new System.EventHandler(this.frmTaMeal_Load);
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaMeal_Load(object sender, System.EventArgs e)
		{
			nav.cmd_copy.Visible=false;
			nav.cmd_report.Visible=false;
			nav.cmd_search.Visible=false;
			PublicFunction.InitNav(this,vs,nav);			
			nav.Msg_ExitSave=true;
			nav.Show_VS();			
							
			nav.ToolBar_Auto=false;
			Basic.Function.PublicFunction.L_Init_Label(this);	
			nav.TBarClick+=new ToolBarButtonClickEventHandler(nav_TBarClick);
			
			
		}	
		
		
		private void nav_TBarClick(object sender, ToolBarButtonClickEventArgs e)
		{					
			if (e.Button.Equals(nav.cmd_add))
			{
				if (vs.Rows.Count==1 || (int)vs.Rows[vs.Rows.Count-1].UserData!=2)					
					nav.ToolBar_Click(e);									
				vs.Rows[vs.Rows.Count-1]["MEAL_ID"]="M"+T_String.GetMax("MAX(cast(right(MEAL_ID,3) AS int))","FILA20A").ToString("000");
				return;
			}
			if (e.Button.Equals(nav.cmd_save ))
			{	
				SqlConnection con=new SqlConnection(PublicFunction.C_con.ConnectionString);
				if(con.State==ConnectionState.Closed )
					con.Open();
				try
				{
					string sql="if not exists (select * from syscolumns where id=object_id('FILC15A') and name='" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "') ALTER TABLE FILC15A ADD " + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + " bit NULL";
					PublicFunction.SQL_Execute(sql,con);

					sql="if not exists (select * from syscolumns where id=object_id('FILC06AA') and name='" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "') ALTER TABLE FILC06AA ADD " + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + " int NULL";
					PublicFunction.SQL_Execute(sql,con);

					int max=T_String.GetMax("MAX(ID1)","SYS_SQL_SELECT","ID=N'frmTaDailyMeal_vs'");
					sql="delete from SYS_SQL_SELECT where ID=N'frmTaDailyMeal_vs' and FIELD='" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "'";
					PublicFunction.SQL_Execute(sql,con);
					sql="Insert into SYS_SQL_SELECT(ID,ID1,NAME,FIELD,SHOW,SEQ) values('frmTaDailyMeal_vs','" + max + "','" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "','" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "',1,'" + max + "')";
					PublicFunction.SQL_Execute(sql,con);

					max=T_String.GetMax("MAX(ID)","SYS_LABEL_VS","NAME=N'frmTaDailyMeal_vs'");
					sql="delete from SYS_LABEL_VS where NAME=N'frmTaDailyMeal_vs' and FNAME='" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "'";
					PublicFunction.SQL_Execute(sql,con);	
					sql="Insert into SYS_LABEL_VS(NAME,ID,EN,CH,VN,TT,FNAME) values('frmTaDailyMeal_vs','" + max + "','" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "','" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "','" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "','" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "','" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "')";
					PublicFunction.SQL_Execute(sql,con);

					max=T_String.GetMax("MAX(ID1)","GP_SYS_SQL_SELECT","ID=N'frmTaMonthAddUp000_vs'");
					sql="delete from GP_SYS_SQL_SELECT where ID=N'frmTaMonthAddUp000_vs' and FIELD='" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "'";
					PublicFunction.SQL_Execute(sql,con);	
					sql="Insert into GP_SYS_SQL_SELECT(ID,ID1,NAME,FIELD,SHOW,SEQ) values('frmTaMonthAddUp000_vs','" + max + "','" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "','" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "',1,'" + max + "')";
					PublicFunction.SQL_Execute(sql,con);

					max=T_String.GetMax("MAX(ID1)","GP_SYS_SQL_SELECT","ID=N'frmTaMonthAddUp001_vs'");
					sql="delete from GP_SYS_SQL_SELECT where ID=N'frmTaMonthAddUp001_vs' and  FIELD='" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "'";
					PublicFunction.SQL_Execute(sql,con);	
					sql="Insert into GP_SYS_SQL_SELECT(ID,ID1,NAME,FIELD,SHOW,SEQ) values('frmTaMonthAddUp001_vs','" + max + "','" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "','" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "',1,'" + max + "')";
					PublicFunction.SQL_Execute(sql,con);

					max=T_String.GetMax("MAX(ID1)","GP_SYS_SQL_SELECT","ID=N'frmTaMonthAddUp002_vs'");
					sql="delete from GP_SYS_SQL_SELECT where ID=N'frmTaMonthAddUp002_vs' and FIELD='" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "'";
					PublicFunction.SQL_Execute(sql,con);	
					sql="Insert into GP_SYS_SQL_SELECT(ID,ID1,NAME,FIELD,SHOW,SEQ) values('frmTaMonthAddUp002_vs','" + max + "','" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "','" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "',1,'" + max + "')";
					PublicFunction.SQL_Execute(sql,con);

					max=T_String.GetMax("MAX(ID1)","GP_SYS_SQL_SELECT","ID=N'frmTaMonthAddUp003_vs'");
					sql="delete from GP_SYS_SQL_SELECT where ID=N'frmTaMonthAddUp003_vs' and  FIELD='" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "'";
					PublicFunction.SQL_Execute(sql,con);	
					sql="Insert into GP_SYS_SQL_SELECT(ID,ID1,NAME,FIELD,SHOW,SEQ) values('frmTaMonthAddUp003_vs','" + max + "','" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "','" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "',1,'" + max + "')";
					PublicFunction.SQL_Execute(sql,con);
					
					max=T_String.GetMax("MAX(ID1)","GP_SYS_SQL_SELECT","ID=N'frmTaMonthAddUp004_vs'");
					sql="delete from GP_SYS_SQL_SELECT where ID=N'frmTaMonthAddUp004_vs' and  FIELD='" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "'";
					PublicFunction.SQL_Execute(sql,con);	
					sql="Insert into GP_SYS_SQL_SELECT(ID,ID1,NAME,FIELD,SHOW,SEQ) values('frmTaMonthAddUp004_vs','" + max + "','" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "','" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "',1,'" + max + "')";
					PublicFunction.SQL_Execute(sql,con);

					max=T_String.GetMax("MAX(ID)","SYS_LABEL_VS_ATT","NAME=N'frmTaMonthAddUp000_vs'");
					sql="delete from SYS_LABEL_VS_ATT where NAME=N'frmTaMonthAddUp000_vs' and FNAME='" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "'";
					PublicFunction.SQL_Execute(sql,con);	
					sql="Insert into SYS_LABEL_VS_ATT(NAME,ID,EN,CH,VN,TT,FNAME) values('frmTaMonthAddUp000_vs','" + max + "','" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "','" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "','" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "','" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "','" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "')";
					PublicFunction.SQL_Execute(sql,con);
		
					max=T_String.GetMax("MAX(ID)","SYS_LABEL_VS_ATT","NAME=N'frmTaMonthAddUp001_vs'");
					sql="delete from SYS_LABEL_VS_ATT where NAME=N'frmTaMonthAddUp001_vs' and FNAME='" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "'";
					PublicFunction.SQL_Execute(sql,con);	
					sql="Insert into SYS_LABEL_VS_ATT(NAME,ID,EN,CH,VN,TT,FNAME) values('frmTaMonthAddUp001_vs','" + max + "','" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "','" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "','" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "','" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "','" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "')";
					PublicFunction.SQL_Execute(sql,con);

					max=T_String.GetMax("MAX(ID)","SYS_LABEL_VS_ATT","NAME=N'frmTaMonthAddUp002_vs'");
					sql="delete from SYS_LABEL_VS_ATT where NAME=N'frmTaMonthAddUp002_vs' and FNAME='" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "'";
					PublicFunction.SQL_Execute(sql,con);	
					sql="Insert into SYS_LABEL_VS_ATT(NAME,ID,EN,CH,VN,TT,FNAME) values('frmTaMonthAddUp002_vs','" + max + "','" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "','" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "','" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "','" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "','" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "')";
					PublicFunction.SQL_Execute(sql,con);

					max=T_String.GetMax("MAX(ID)","SYS_LABEL_VS_ATT","NAME=N'frmTaMonthAddUp003_vs'");
					sql="delete from SYS_LABEL_VS_ATT where NAME=N'frmTaMonthAddUp003_vs' and FNAME='" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "'";
					PublicFunction.SQL_Execute(sql,con);	
					sql="Insert into SYS_LABEL_VS_ATT(NAME,ID,EN,CH,VN,TT,FNAME) values('frmTaMonthAddUp003_vs','" + max + "','" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "','" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "','" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "','" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "','" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "')";
					PublicFunction.SQL_Execute(sql,con);

					max=T_String.GetMax("MAX(ID)","SYS_LABEL_VS_ATT","NAME=N'frmTaMonthAddUp004_vs'");
					sql="delete from SYS_LABEL_VS_ATT where NAME=N'frmTaMonthAddUp004_vs' and FNAME='" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "'";
					PublicFunction.SQL_Execute(sql,con);	
					sql="Insert into SYS_LABEL_VS_ATT(NAME,ID,EN,CH,VN,TT,FNAME) values('frmTaMonthAddUp004_vs','" + max + "','" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "','" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "','" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "','" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "','" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "')";
					PublicFunction.SQL_Execute(sql,con);

				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
					return;
				}
			}
			if (e.Button.Equals(nav.cmd_delete ))
			{
				SqlConnection con=new SqlConnection(PublicFunction.C_con.ConnectionString);
				if(con.State==ConnectionState.Closed )
					con.Open();
				try
				{
					string sql="if exists (select * from syscolumns where id=object_id('FILC15A') and name='" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "') ALTER TABLE FILC15A DROP COLUMN " + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "";
					PublicFunction.SQL_Execute(sql,con);

					sql="if exists (select * from syscolumns where id=object_id('FILC06AA') and name='" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "') ALTER TABLE FILC06AA DROP COLUMN " + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "";
					PublicFunction.SQL_Execute(sql,con);

					sql="delete from SYS_SQL_SELECT where ID=N'frmTaDailyMeal_vs' and FIELD='" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "'";
					PublicFunction.SQL_Execute(sql,con);

					sql="delete from SYS_LABEL_VS where NAME=N'frmTaDailyMeal_vs' and FNAME='" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "'";
					PublicFunction.SQL_Execute(sql,con);

					sql="delete from GP_SYS_SQL_SELECT where ID=N'frmTaMonthAddUp000_vs' and FIELD='" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "'";
					PublicFunction.SQL_Execute(sql,con);	

					sql="delete from GP_SYS_SQL_SELECT where ID=N'frmTaMonthAddUp001_vs' and FIELD='" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "'";
					PublicFunction.SQL_Execute(sql,con);	

					sql="delete from GP_SYS_SQL_SELECT where ID=N'frmTaMonthAddUp002_vs' and FIELD='" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "'";
					PublicFunction.SQL_Execute(sql,con);	

					sql="delete from GP_SYS_SQL_SELECT where ID=N'frmTaMonthAddUp003_vs' and FIELD='" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "'";
					PublicFunction.SQL_Execute(sql,con);	

					sql="delete from GP_SYS_SQL_SELECT where ID=N'frmTaMonthAddUp004_vs' and FIELD='" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "'";
					PublicFunction.SQL_Execute(sql,con);	

					sql="delete from SYS_LABEL_VS_ATT where NAME=N'frmTaMonthAddUp000_vs' and FNAME='" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "'";
					PublicFunction.SQL_Execute(sql,con);	

					sql="delete from SYS_LABEL_VS_ATT where NAME=N'frmTaMonthAddUp001_vs' and FNAME='" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "'";
					PublicFunction.SQL_Execute(sql,con);	

					sql="delete from SYS_LABEL_VS_ATT where NAME=N'frmTaMonthAddUp002_vs' and FNAME='" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "'";
					PublicFunction.SQL_Execute(sql,con);	

					sql="delete from SYS_LABEL_VS_ATT where NAME=N'frmTaMonthAddUp003_vs' and FNAME='" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "'";
					PublicFunction.SQL_Execute(sql,con);	

					sql="delete from SYS_LABEL_VS_ATT where NAME=N'frmTaMonthAddUp004_vs' and FNAME='" + vs.Rows[vs.Rows.Count-1]["MEAL_ID"] + "'";
					PublicFunction.SQL_Execute(sql,con);	

				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
					return;
				}
			}
			nav.ToolBar_Click(e);
			
			
		}		
	}
}

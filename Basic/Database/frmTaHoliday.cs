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
	/// Summary description for frmTaHoliday.
	/// </summary>
	public class frmTaHoliday : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel4;
		private Navigator1._0.NavigatorAuto nav;
		private C1.Win.C1FlexGrid.C1FlexGrid vs;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private C1.Win.C1Input.C1DateEdit dt;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaHoliday()
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
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.nav = new Navigator1._0.NavigatorAuto();
			this.vs = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dt = new C1.Win.C1Input.C1DateEdit();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dt)).BeginInit();
			this.SuspendLayout();
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.panel3.Controls.Add(this.dt);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.panel4);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(908, 36);
			this.panel3.TabIndex = 12;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(312, 12);
			this.label1.Name = "label1";
			this.label1.TabIndex = 12;
			this.label1.Text = "label1";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Location = new System.Drawing.Point(300, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(608, 36);
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
			this.panel4.Size = new System.Drawing.Size(300, 36);
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
			this.nav.Size = new System.Drawing.Size(293, 32);
			this.nav.TabIndex = 9;
			this.nav.ToolBar_Auto = true;
			this.nav.UserID = null;
			this.nav.VisibleGrid = true;
			this.nav.Where = null;
			// 
			// vs
			// 
			this.vs.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
			this.vs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.vs.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs.Location = new System.Drawing.Point(4, 4);
			this.vs.Name = "vs";
			this.vs.Size = new System.Drawing.Size(900, 460);
			this.vs.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs.TabIndex = 13;
			this.vs.Tag = "N";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.vs);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 36);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(908, 468);
			this.panel1.TabIndex = 14;
			// 
			// dt
			// 
			this.dt.CustomFormat = "yyyy";
			this.dt.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt.Location = new System.Drawing.Point(360, 8);
			this.dt.Name = "dt";
			this.dt.Size = new System.Drawing.Size(104, 23);
			this.dt.TabIndex = 14;
			this.dt.Tag = null;
			// 
			// frmTaHoliday
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(908, 504);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaHoliday";
			this.Text = "frmTaHoliday";
			this.Load += new System.EventHandler(this.frmTaHoliday_Load);
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dt)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaHoliday_Load(object sender, System.EventArgs e)
		{	
			dt.Value=T_String.GetDate();
			nav.cmd_add.Visible=false;
			nav.cmd_delete.Visible=false;
			nav.cmd_copy.Visible=false;
			nav.cmd_report.Visible=false;
			nav.cmd_search.Visible=false;
			PublicFunction.InitNav(this,vs,nav);
			nav.Msg_ExitSave=true;
			nav.Show_VS("YYY_YY=N'"+ dt.Text+"'");	
										
			Basic.Function.PublicFunction.L_Init_Label(this);	
			for(int i=3;i<vs.Cols.Count;i++)
				vs.Cols[i].Caption=vs.Cols[i].Name.Replace("h","");
			insert();
			dt.TextChanged+=new EventHandler(dt_TextChanged);			
			
			vs.SelectionMode=C1.Win.C1FlexGrid.SelectionModeEnum.CellRange; 
			vs.AfterEdit+=new C1.Win.C1FlexGrid.RowColEventHandler(vs_AfterEdit);
		}		
		
		private void insert()
		{
			string sql;
			if(T_String.IsNullTo0(T_String.GetDataFromSQL("COUNT(*)","FILA16A","YYY_YY=N'"+ dt.Text+"'"))==0)
			{
				for(int i=1;i<13;i++)
				{
					sql="Insert Into FILA16A(YYY_YY,MMM_MM) values(N'"+dt.Text+"',"+i+")";
					PublicFunction.SQL_Execute(sql);
				}
			}
		}

		private void dt_TextChanged(object sender, EventArgs e)
		{
			try
			{
				insert();
				nav.Show_VS("YYY_YY=N'"+ dt.Text+"'");	
			}
			catch{}
		}

		private void vs_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			for (int i=vs.Selection.r1;i<=vs.Selection.r2;i++)
			{
				for (int j=vs.Selection.c1;j<=vs.Selection.c2;j++)
				{
					if (vs.Cols[j].DataType==typeof(Boolean))
					{
						vs[i,j ]=vs[e.Row,e.Col];
						vs.Rows[i].UserData=1;
					}
				}
			}
		}
		

//		private void dt_ValueChanged(object sender, System.EventArgs e)
//		{
//			try
//			{
//				insert();
//				nav.Show_VS("YYY_YY=N'"+ dt.Text+"'");	
//			}
//			catch{}
//		}
	}
}

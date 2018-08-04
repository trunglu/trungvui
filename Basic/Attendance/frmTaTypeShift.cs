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
	/// Summary description for frmTaTypeShift.
	/// </summary>
	public class frmTaTypeShift : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel4;
		private Navigator1._0.NavigatorAuto nav;
		private System.Windows.Forms.Panel panel1;
		private C1.Win.C1FlexGrid.C1FlexGrid vs;
		private System.Windows.Forms.Button cmd_get;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaTypeShift()
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
			this.vs = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.cmd_get = new System.Windows.Forms.Button();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
			this.SuspendLayout();
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
			this.panel3.Size = new System.Drawing.Size(616, 36);
			this.panel3.TabIndex = 19;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Location = new System.Drawing.Point(364, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(252, 36);
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
			this.panel4.Size = new System.Drawing.Size(364, 36);
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
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(616, 376);
			this.panel1.TabIndex = 20;
			// 
			// vs
			// 
			this.vs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.vs.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs.Location = new System.Drawing.Point(4, 40);
			this.vs.Name = "vs";
			this.vs.Size = new System.Drawing.Size(608, 328);
			this.vs.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs.TabIndex = 11;
			// 
			// cmd_get
			// 
			this.cmd_get.Location = new System.Drawing.Point(376, 4);
			this.cmd_get.Name = "cmd_get";
			this.cmd_get.Size = new System.Drawing.Size(100, 28);
			this.cmd_get.TabIndex = 21;
			this.cmd_get.Text = "button1";
			this.cmd_get.Click += new System.EventHandler(this.cmd_get_Click);
			// 
			// frmTaTypeShift
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(616, 376);
			this.Controls.Add(this.cmd_get);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaTypeShift";
			this.Text = "frmTaTypeShift";
			this.Load += new System.EventHandler(this.frmTaTypeShift_Load);
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaTypeShift_Load(object sender, System.EventArgs e)
		{
			nav.cmd_add.Visible=false;
			nav.cmd_copy.Visible=false;
			nav.cmd_report.Visible=false;
			nav.cmd_search.Visible=false;
			vs.EnabledChanged+=new EventHandler(vs_EnabledChanged);
			PublicFunction.InitNav(this,vs,nav);
			nav.Msg_ExitSave=true;
			nav.Show_VS();													
			Basic.Function.PublicFunction.L_Init_Label(this);			
			vs.Cols["ROU_DR"].ComboList="|...";
			vs.CellButtonClick+=new C1.Win.C1FlexGrid.RowColEventHandler(vs_CellButtonClick);
			vs.AfterEdit+=new C1.Win.C1FlexGrid.RowColEventHandler(vs_AfterEdit);
			vs.SelectionMode=C1.Win.C1FlexGrid.SelectionModeEnum.CellRange; 			
		}

		private void vs_CellButtonClick(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			frmTaRound dlg=new frmTaRound(vs.Rows[vs.Row]["ROU_DR"]+"");
			if(dlg.ShowDialog()==DialogResult.OK)
			{
				vs.Rows[vs.Row]["ROU_DR"]=dlg.st;
			}
		}

		private void cmd_get_Click(object sender, System.EventArgs e)
		{
			string st;
			st=T_String.IsNullTo0(T_String.GetDataFromSQL("SEQ_HR","GP_SYS_SETTING")).ToString("00");
			st+="-"+T_String.IsNullTo0(T_String.GetDataFromSQL("ROU_MN","GP_SYS_SETTING")).ToString("00");
			for(int i=1;i<vs.Rows.Count;i++)
			{
				vs.Rows[i]["ROU_DR"]=st;
				vs.Rows[i].UserData=1;
			}
		}
		private void vs_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			if(vs.Cols[e.Col].Name=="ROU_DR" )
				for (int i=vs.Selection.r1;i<=vs.Selection.r2;i++)
				{				
					vs[i,e.Col ]=vs[e.Row,e.Col];
					vs.Rows[i].UserData=1;							
				}
		}

		private void vs_EnabledChanged(object sender, EventArgs e)
		{
			vs.Cols["TYP_EN"].Visible=false;
			vs.Cols["TYP_CH"].Visible=false;
			vs.Cols["TYP_VN"].Visible=false;
			vs.Cols["TYP_TT"].Visible=false;
			vs.Cols["TYP_"+PublicFunction.L_Lag].Visible=true;
		}
	}
}

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Basic.Function;

namespace Basic.Form
{
	/// <summary>
	/// Summary description for frmControlStateUser.
	/// </summary>
	public class frmControlStateUser : System.Windows.Forms.Form
	{
		private C1.Win.C1FlexGrid.C1FlexGrid vs;
		private Navigator1._0.NavigatorAuto nav;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmControlStateUser()
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
			this.nav = new Navigator1._0.NavigatorAuto();
			((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
			this.SuspendLayout();
			// 
			// vs
			// 
			this.vs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.vs.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs.Location = new System.Drawing.Point(4, 32);
			this.vs.Name = "vs";
			this.vs.Size = new System.Drawing.Size(644, 364);
			this.vs.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs.TabIndex = 22;
			// 
			// nav
			// 
			this.nav.BackColor = System.Drawing.SystemColors.Control;
			this.nav.Connection = null;
			this.nav.ConnectionDel = null;
			this.nav.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.nav.form = null;
			this.nav.FormName = null;
			this.nav.Grid = null;
			this.nav.Location = new System.Drawing.Point(4, 0);
			this.nav.MulltiDel = false;
			this.nav.Name = "nav";
			this.nav.Security = 0;
			this.nav.ShowPopupMenu = false;
			this.nav.Size = new System.Drawing.Size(464, 32);
			this.nav.TabIndex = 21;
			this.nav.ToolBar_Auto = true;
			this.nav.UserID = null;
			this.nav.Where = null;
			// 
			// frmControlStateUser
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(644, 402);
			this.Controls.Add(this.vs);
			this.Controls.Add(this.nav);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmControlStateUser";
			this.Text = "frmControlStateUser";
			this.Load += new System.EventHandler(this.frmControlStateUser_Load);
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmControlStateUser_Load(object sender, System.EventArgs e)
		{
			Init_vs();
			PublicFunction.L_Init_Label(this);
			nav.Init_PMenu_Color();
		}
		private void Init_vs()
		{
			nav.cmd_report.Visible=false;
			nav.cmd_copy.Visible=false;
			nav.cmd_search.Visible=false;
			nav.cmd_add.Visible=false;
			nav.cmd_add.Visible=false;
			PublicFunction.InitNav(this,vs,nav);		
			nav.Show_VS();	
			nav.ToolBar_Auto=false;
			nav.TBarClick +=new ToolBarButtonClickEventHandler(nav_TBarClick);
		}
		private void nav_TBarClick(object sender, ToolBarButtonClickEventArgs e)
		{
			nav.ToolBar_Click(e);
		}
	}
}

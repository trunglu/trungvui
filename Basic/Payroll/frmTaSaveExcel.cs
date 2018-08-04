using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Basic.Form;
using Basic.Function;

namespace GP8000.Payroll
{
	/// <summary>
	/// Summary description for frmTaSaveExcel.
	/// </summary>
	public class frmTaSaveExcel : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel7;
		private Navigator1._0.NavigatorAuto nav;
		private C1.Win.C1FlexGrid.C1FlexGrid vs;		
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.TextBox txt;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Panel p1;
		public string ketqua, ketqua1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaSaveExcel()
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
			this.vs = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.p1 = new System.Windows.Forms.Panel();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.txt = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel3.SuspendLayout();
			this.panel7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel4.SuspendLayout();
			this.p1.SuspendLayout();
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
			this.panel3.Size = new System.Drawing.Size(448, 36);
			this.panel3.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Location = new System.Drawing.Point(244, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(204, 36);
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
			this.panel7.Size = new System.Drawing.Size(244, 36);
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
			this.nav.Location = new System.Drawing.Point(0, 2);
			this.nav.MSG_Exit = false;
			this.nav.MulltiDel = false;
			this.nav.Name = "nav";
			this.nav.Security = 0;
			this.nav.ShowPopupMenu = true;
			this.nav.Size = new System.Drawing.Size(252, 32);
			this.nav.TabIndex = 14;
			this.nav.Tag = "";
			this.nav.ToolBar_Auto = true;
			this.nav.UserID = null;
			this.nav.VisibleGrid = true;
			this.nav.Where = null;
			// 
			// vs
			// 
			this.vs.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.Both;
			this.vs.AllowEditing = false;
			this.vs.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vs.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs.Location = new System.Drawing.Point(0, 0);
			this.vs.Name = "vs";
			this.vs.Size = new System.Drawing.Size(448, 240);
			this.vs.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs.TabIndex = 14;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Controls.Add(this.p1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 36);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(448, 312);
			this.panel1.TabIndex = 15;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.vs);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(448, 240);
			this.panel4.TabIndex = 16;
			// 
			// p1
			// 
			this.p1.Controls.Add(this.button2);
			this.p1.Controls.Add(this.button1);
			this.p1.Controls.Add(this.txt);
			this.p1.Controls.Add(this.label1);
			this.p1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.p1.Location = new System.Drawing.Point(0, 240);
			this.p1.Name = "p1";
			this.p1.Size = new System.Drawing.Size(448, 72);
			this.p1.TabIndex = 15;
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button2.Location = new System.Drawing.Point(255, 36);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(104, 28);
			this.button2.TabIndex = 3;
			this.button2.Text = "button2";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(89, 36);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(104, 28);
			this.button1.TabIndex = 2;
			this.button1.Text = "button1";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// txt
			// 
			this.txt.Location = new System.Drawing.Point(96, 4);
			this.txt.Name = "txt";
			this.txt.Size = new System.Drawing.Size(344, 23);
			this.txt.TabIndex = 1;
			this.txt.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 4);
			this.label1.Name = "label1";
			this.label1.TabIndex = 0;
			this.label1.Text = "label1";
			// 
			// frmTaSaveExcel
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(448, 348);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaSaveExcel";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmTaSaveExcel";
			this.Load += new System.EventHandler(this.frmTaSaveExcel_Load);
			this.panel3.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.p1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaSaveExcel_Load(object sender, System.EventArgs e)
		{
			nav.cmd_copy.Visible=false;
			nav.cmd_report.Visible=false;
			nav.cmd_search.Visible=false;
			nav.cmd_save.Visible=false;
			nav.cmd_add.Visible=false;	
			nav.cmd_refresh.Visible=false;
			PublicFunction.InitNav(this,vs,nav);	
			nav.Msg_ExitSave=true;
			nav.Show_VS();						
			Basic.Function.PublicFunction.L_Init_Label(this);	
			vs.DoubleClick+=new EventHandler(vs_DoubleClick);
			PublicFunction.SQL_Execute("Delete from GP_EXCEL_DETAIL where EXC_ID not in(Select EXC_ID from GP_EXCEL_MASTER)");
			if(ketqua=="1")
				p1.Visible=false;
			this.Text=ketqua1;
			label5.Text=ketqua1;
		}

		private void vs_DoubleClick(object sender, EventArgs e)
		{
			if(vs.Row>0)
			{
				if((ketqua=="1"))
				{
					ketqua=vs.Rows[vs.Row]["EXC_ID"]+"";
					this.DialogResult=DialogResult.OK;				
				}
				else
					txt.Text=vs.Rows[vs.Row]["EXC_ID"]+"";
			}
		}
		
		private void button1_Click(object sender, System.EventArgs e)
		{
			PublicFunction.SQL_Execute("Delete from GP_EXCEL_DETAIL where EXC_ID not in(Select EXC_ID from GP_EXCEL_MASTER)");
			string sql="Insert Into GP_EXCEL_MASTER values (N'"+txt.Text+"') ";
			if(PublicFunction.SQL_Execute(sql,true)!=0)
			{
				if(MessageBox.Show(this,PublicFunction.L_Get_Msg("msg",210),this.Text,MessageBoxButtons.YesNo)==DialogResult.Yes)
				{
					PublicFunction.SQL_Execute("Delete from GP_EXCEL_MASTER where EXC_ID=N'"+txt.Text+"' ");
					PublicFunction.SQL_Execute("Delete from GP_EXCEL_DETAIL where EXC_ID not in(Select EXC_ID from GP_EXCEL_MASTER)");
					PublicFunction.SQL_Execute(sql);
				}
				else
					return;
			}			
			this.DialogResult=DialogResult.OK;
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Func;
using Basic.Function;
using C1.Win.C1FlexGrid;

namespace GP8000.GPS
{
	/// <summary>
	/// Summary description for frmTaAddfor.
	/// </summary>
	public class frmTaAddfor : System.Windows.Forms.Form
	{
		public C1.Win.C1FlexGrid.C1FlexGrid vs;
		private System.Windows.Forms.Button cmd_can;
		private System.Windows.Forms.Button cmd_ok;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaAddfor()
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
			this.cmd_can = new System.Windows.Forms.Button();
			this.cmd_ok = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
			this.SuspendLayout();
			// 
			// vs
			// 
			this.vs.AllowEditing = false;
			this.vs.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
			this.vs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.vs.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs.Location = new System.Drawing.Point(3, 8);
			this.vs.Name = "vs";
			this.vs.Size = new System.Drawing.Size(428, 340);
			this.vs.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs.TabIndex = 50;
			this.vs.Tag = "";
			this.vs.DoubleClick += new System.EventHandler(this.vs_DoubleClick);
			this.vs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.vs_KeyDown);
			// 
			// cmd_can
			// 
			this.cmd_can.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmd_can.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cmd_can.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_can.Location = new System.Drawing.Point(269, 356);
			this.cmd_can.Name = "cmd_can";
			this.cmd_can.Size = new System.Drawing.Size(88, 32);
			this.cmd_can.TabIndex = 52;
			this.cmd_can.Text = "Cancel";
			// 
			// cmd_ok
			// 
			this.cmd_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cmd_ok.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_ok.Location = new System.Drawing.Point(77, 356);
			this.cmd_ok.Name = "cmd_ok";
			this.cmd_ok.Size = new System.Drawing.Size(88, 32);
			this.cmd_ok.TabIndex = 51;
			this.cmd_ok.Tag = "";
			this.cmd_ok.Text = "OK";
			this.cmd_ok.Click += new System.EventHandler(this.cmd_ok_Click);
			// 
			// frmTaAddfor
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(434, 394);
			this.Controls.Add(this.vs);
			this.Controls.Add(this.cmd_can);
			this.Controls.Add(this.cmd_ok);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmTaAddfor";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmTaAddfor";
			this.Load += new System.EventHandler(this.frmTaAddfor_Load);
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaAddfor_Load(object sender, System.EventArgs e)
		{
			vs.Cols.Count=3;
			vs.Cols[1].Name="COL_NM";
			vs.Cols[2].Name="COL_MM";
			vs.Rows.Count=1;
			Func.RecordSet rs=new RecordSet("Select * from GP_SYS_SHIFT",PublicFunction.C_con);
			for(int i=0;i<rs.rows;i++)
			{
				vs.Rows.Count++;
				vs.Rows[vs.Rows.Count-1][0]=vs.Rows.Count-1;
				vs.Rows[vs.Rows.Count-1]["COL_NM"]=rs.record(i,"TYP_ID");
				vs.Rows[vs.Rows.Count-1]["COL_MM"]=rs.record(i,"TYP_NM");				
			}
			rs=new RecordSet("Select * from FILC07A",PublicFunction.C_con);
			for(int i=0;i<rs.rows;i++)
			{
				vs.Rows.Count++;
				vs.Rows[vs.Rows.Count-1][0]=vs.Rows.Count-1;
				vs.Rows[vs.Rows.Count-1]["COL_NM"]=rs.record(i,"COL_NM");
				vs.Rows[vs.Rows.Count-1]["COL_MM"]=rs.record(i,"COL_MM");				
			}
			vs.AutoSizeCols();
			Basic.Function.PublicFunction.L_Init_Label(this);		
		}

		private void cmd_ok_Click(object sender, System.EventArgs e)
		{
			Accept();			
		}

		private void vs_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.Down:		// initialize selection if we have to
					if (vs.Row < 0 && vs.Rows.Count > 1)
						vs.Row = 0;						
					break;
				case Keys.Tab:		// close form on Tab, Enter, Left, Right keys
				case Keys.Enter:
					//				case Keys.Left:
					//				case Keys.Right:
					e.Handled = true;
					Accept();
					break;
				case Keys.Escape:	// cancel editing on escape key
					e.Handled = true;
					this.DialogResult=DialogResult.Cancel;					
					Close();
					break;
			}
		}

		public string COL_NM="",COL_MM="";
		private void Accept()
		{
			try
			{
				// save selection
				if (vs.Row > 0)
				{					
					COL_NM=vs.Rows[vs.Row]["COL_NM"]+"";
					COL_MM=vs.Rows[vs.Row]["COL_MM"]+"";
					this.DialogResult=DialogResult.OK;
				}
			}
			catch(Exception){}			

			// close the form
			Close();
		}

		private void vs_DoubleClick(object sender, System.EventArgs e)
		{			
			Accept();		
			
		}
	}
}

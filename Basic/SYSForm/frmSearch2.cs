using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Basic.Function;
using System.Data;
using Func;
using C1.Win.C1FlexGrid;

namespace Basic.Form
{
	
	public class frmSearch2 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button cmd_can;
		private System.Windows.Forms.Button cmd_ok;
		public C1.Win.C1FlexGrid.C1FlexGrid vs;
		private Boolean sel;
		private int _Cols;
		private RecordSet _rs;
		private string _LabelID;
		private System.ComponentModel.Container components = null;

		public frmSearch2(RecordSet rs,int Cols,string LabelID)
		{
			this._Cols =Cols;
			this._rs=rs;
			this._LabelID=LabelID;
			this.sel=false;
			InitializeComponent();
		}
		public frmSearch2(RecordSet rs,int Cols,string LabelID,Boolean sel)
		{
			this._Cols =Cols;
			this._rs=rs;
			this._LabelID=LabelID;
			this.sel=sel;
			InitializeComponent();
		}

		
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
			this.cmd_can = new System.Windows.Forms.Button();
			this.cmd_ok = new System.Windows.Forms.Button();
			this.vs = new C1.Win.C1FlexGrid.C1FlexGrid();
			((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
			this.SuspendLayout();
			// 
			// cmd_can
			// 
			this.cmd_can.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmd_can.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_can.Location = new System.Drawing.Point(360, 352);
			this.cmd_can.Name = "cmd_can";
			this.cmd_can.Size = new System.Drawing.Size(90, 32);
			this.cmd_can.TabIndex = 52;
			this.cmd_can.Text = "Cancel";
			this.cmd_can.Click += new System.EventHandler(this.cmd_can_Click);
			// 
			// cmd_ok
			// 
			this.cmd_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cmd_ok.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_ok.Location = new System.Drawing.Point(215, 352);
			this.cmd_ok.Name = "cmd_ok";
			this.cmd_ok.Size = new System.Drawing.Size(90, 32);
			this.cmd_ok.TabIndex = 51;
			this.cmd_ok.Tag = "";
			this.cmd_ok.Text = "OK";
			this.cmd_ok.Click += new System.EventHandler(this.cmd_ok_Click);
			// 
			// vs
			// 
			this.vs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.vs.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs.Location = new System.Drawing.Point(0, 0);
			this.vs.Name = "vs";
			this.vs.Size = new System.Drawing.Size(664, 340);
			this.vs.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs.TabIndex = 50;
			this.vs.Tag = "N";
			this.vs.DoubleClick += new System.EventHandler(this.vs_DoubleClick);
			this.vs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.vs_KeyDown);
			// 
			// frmSearch2
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(664, 394);
			this.Controls.Add(this.cmd_can);
			this.Controls.Add(this.cmd_ok);
			this.Controls.Add(this.vs);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSearch2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmSearch2";
			this.Load += new System.EventHandler(this.frmSearch2_Load);
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmSearch2_Load(object sender, System.EventArgs e)
		{
			try
			{
				vs.AllowEditing  = true;
				vs.AutoSearch	= AutoSearchEnum.FromCursor;
				vs.KeyActionTab	= KeyActionEnum.MoveDown;
				vs.TabIndex		= 0;
				vs.SelectionMode = SelectionModeEnum.Row;

				PublicFunction.L_Init_Label(this);			

				vs.Cols.Count =_Cols+1;
				vs.Rows.Count =_rs.rows+1;
				for (int c=1;c<_Cols+1;c++)
				{
					vs.Cols[c].Name=_rs.Field(c-1);
					if (vs.Cols[c].Name=="SYS_SEL")
					{
						vs.Cols[c].Caption=PublicFunction.L_GetLabel_VS("Public",vs.Cols[c].Name); 
						vs.Cols[c].AllowEditing = true;
						vs.Cols[c].DataType=typeof(System.Boolean);
					}
					else
					{
						vs.Cols[c].Caption=PublicFunction.L_GetLabel_VS(_LabelID,vs.Cols[c].Name); 
						vs.Cols[c].AllowEditing= false;
					}
				}

				for (int r = 0; r < _rs.rows; r++)
				{	
					vs[r+1, 0]=r+1;
					for (int c = 1; c < _Cols+1; c++)
						vs[r+1, c] = _rs.record(r,c-1);
				}
				vs.AutoSizeCols();
				vs.DoubleClick +=new EventHandler(vs_DoubleClick);
				vs.KeyDown +=new KeyEventHandler(vs_KeyDown);
				this.KeyDown+=new KeyEventHandler(vs_KeyDown);
			}
			catch
			{
				MessageBox.Show("Load Form Error");
			}
		}
		private void Accept()
		{
			try
			{
				// save selection
				if (vs.Row > 0)
				{					
					_rs.Bookmarks=vs.Row-1;
					this.DialogResult=DialogResult.OK;
				}
			}
			catch(Exception){}			

			// close the form
			Close();
		}

		private void vs_DoubleClick(object sender, System.EventArgs e)
		{
			if (!sel)
				Accept();
		}

		private void vs_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
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

		private void cmd_ok_Click(object sender, System.EventArgs e)
		{
			Accept();
		}

		private void cmd_can_Click(object sender, System.EventArgs e)
		{
			this.DialogResult=DialogResult.Cancel;	
		}
	}
}

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Func;
using Basic.Function;
using C1.Win.C1FlexGrid;
namespace Basic.Form
{
	/// <summary>
	/// 
	/// Summary description for frmSearch.
	/// </summary>
	public class frmSearch : System.Windows.Forms.Form
	{
		public C1.Win.C1FlexGrid.C1FlexGrid vs;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private int _Cols;
		private RecordSet _rs;
		private string _LabelID;
		private System.Windows.Forms.Button cmd_can;
		private System.Windows.Forms.Button cmd_ok;
		private Boolean sel;
		public Boolean LB=true;
		private System.Windows.Forms.TextBox txt2;
		private System.Windows.Forms.TextBox txt1;
		public ArrayList a;
		int row;

		public frmSearch(RecordSet rs,int Cols,string LabelID)
		{
			//
			// Required for Windows Form Designer support
			//
			this._Cols =Cols;
			this._rs=rs;
			this._LabelID=LabelID;
			this.sel=false;
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		public frmSearch(RecordSet rs,int Cols,string LabelID,Boolean sel)
		{
			//
			// Required for Windows Form Designer support
			//
			this._Cols =Cols;
			this._rs=rs;
			this._LabelID=LabelID;
			this.sel=sel;
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
			this.txt2 = new System.Windows.Forms.TextBox();
			this.txt1 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
			this.SuspendLayout();
			// 
			// vs
			// 
			this.vs.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
			this.vs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.vs.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs.Location = new System.Drawing.Point(5, 32);
			this.vs.Name = "vs";
			this.vs.Size = new System.Drawing.Size(327, 312);
			this.vs.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs.TabIndex = 18;
			this.vs.Tag = "N";
			// 
			// cmd_can
			// 
			this.cmd_can.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmd_can.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_can.Location = new System.Drawing.Point(191, 356);
			this.cmd_can.Name = "cmd_can";
			this.cmd_can.Size = new System.Drawing.Size(88, 32);
			this.cmd_can.TabIndex = 49;
			this.cmd_can.Text = "Cancel";
			this.cmd_can.Click += new System.EventHandler(this.cmd_can_Click);
			// 
			// cmd_ok
			// 
			this.cmd_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cmd_ok.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_ok.Location = new System.Drawing.Point(59, 356);
			this.cmd_ok.Name = "cmd_ok";
			this.cmd_ok.Size = new System.Drawing.Size(88, 32);
			this.cmd_ok.TabIndex = 48;
			this.cmd_ok.Tag = "";
			this.cmd_ok.Text = "OK";
			this.cmd_ok.Click += new System.EventHandler(this.cmd_ok_Click);
			// 
			// txt2
			// 
			this.txt2.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt2.Location = new System.Drawing.Point(168, 4);
			this.txt2.MaxLength = 20;
			this.txt2.Name = "txt2";
			this.txt2.Size = new System.Drawing.Size(164, 23);
			this.txt2.TabIndex = 51;
			this.txt2.Tag = "";
			this.txt2.Text = "textBox3";
			this.txt2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
			this.txt2.Leave += new System.EventHandler(this.textBox1_Leave);
			this.txt2.Enter += new System.EventHandler(this.textBox1_Enter);
			// 
			// txt1
			// 
			this.txt1.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt1.Location = new System.Drawing.Point(4, 4);
			this.txt1.MaxLength = 20;
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(164, 23);
			this.txt1.TabIndex = 50;
			this.txt1.Tag = "";
			this.txt1.Text = "textBox3";
			this.txt1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
			this.txt1.Leave += new System.EventHandler(this.textBox1_Leave);
			this.txt1.Enter += new System.EventHandler(this.textBox1_Enter);
			// 
			// frmSearch
			// 
			this.AutoScale = false;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(338, 396);
			this.Controls.Add(this.txt2);
			this.Controls.Add(this.txt1);
			this.Controls.Add(this.vs);
			this.Controls.Add(this.cmd_can);
			this.Controls.Add(this.cmd_ok);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSearch";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmSearch";
			this.Load += new System.EventHandler(this.frmSearch_Load);
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmSearch_Load(object sender, System.EventArgs e)
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
				int cou=0;
				for (int c=1;c<_Cols+1;c++)
				{
					vs.Cols[c].Name=_rs.Field(c-1);
					if (vs.Cols[c].Name=="SYS_SEL")
					{
						vs.Cols[c].Caption=PublicFunction.L_GetLabel_VS("Public",vs.Cols[c].Name); 
						vs.Cols[c].AllowEditing = true;
						vs.Cols[c].DataType=typeof(System.Boolean);
						vs.SelectionMode=C1.Win.C1FlexGrid.SelectionModeEnum.CellRange;
						vs.AfterEdit+=new RowColEventHandler(vs_AfterEdit);
					}
					else
					{
						if(cou==0)
							txt1.Tag=vs.Cols[c].Name;
						if(cou==1)
							txt2.Tag=vs.Cols[c].Name;
						cou++;
						if (LB)
							vs.Cols[c].Caption=PublicFunction.L_GetLabel_VS(_LabelID,vs.Cols[c].Name); 
						else
						{
							try
							{
								vs.Cols[c].Caption=a[c-1]+"";
							}
							catch(Exception){}
						}
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
				if(txt1.Tag+""!="")
					txt1.Text=vs.Cols[txt1.Tag+""].Caption;
				if(txt2.Tag+""!="")
					txt2.Text=vs.Cols[txt2.Tag+""].Caption;
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

		private void vs_DoubleClick(object sender, EventArgs e)		
		{
			if (!sel)
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

		private void cmd_ok_Click(object sender, System.EventArgs e)
		{
			Accept();
		}

		private void cmd_can_Click(object sender, System.EventArgs e)
		{			
			this.DialogResult=DialogResult.Cancel;				
		}

		private void vs_AfterEdit(object sender, RowColEventArgs e)
		{
			if(vs.Cols[e.Col].Name=="SYS_SEL" )
			{
				for (int i=vs.Selection.r1;i<=vs.Selection.r2;i++)
				{				
					vs[i,e.Col ]=vs[e.Row,e.Col];				
				}
			}
		}

		private void textBox1_Enter(object sender, System.EventArgs e)
		{
			TextBox txt=(TextBox)sender;
			if (txt.Text==vs.Cols[txt.Tag+""].Caption)
				txt.Text="";
			row=1;			
		}

		private void textBox1_Leave(object sender, System.EventArgs e)
		{
			TextBox txt=(TextBox)sender;
			if (txt.Text=="")
				txt.Text=vs.Cols[txt.Tag+""].Caption;
		}

		private void textBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			TextBox txt=(TextBox)sender;
			if(e.KeyCode==Keys.Enter && txt.Tag+""!="")
			{
				int i;
				for(i=row;i<vs.Rows.Count;i++)					
				{
					string st=vs.Rows[i][txt.Tag+""]+"";
					string st1=txt.Text;
					st=st.ToUpper();
					st1=st1.ToUpper();
					if(st!="")
					{
						if(st.IndexOf(st1)>=0)
						{
							vs.Row=i;
							vs.ShowCell(i,vs.Cols[txt.Tag+""].Index);
							break;
						}
					}
				}
				row=i+1;
				if(row>=vs.Rows.Count-1)
					row=1;				
			}				
		}
	}
}

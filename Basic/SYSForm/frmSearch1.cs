using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Basic.Function ;
using C1.Win.C1FlexGrid;

namespace Basic.Form
{
	/// <summary>
	/// Summary description for frmSearch1.
	/// </summary>
	public class frmSearch1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button cmd_search;
		private System.Windows.Forms.Button cmd_can;
		private ArrayList a,b,ct,cbox;
		private C1.Win.C1FlexGrid.C1FlexGrid _vs;
		public C1.Win.C1FlexGrid.C1FlexGrid vs;
		private Navigator1._0.NavigatorAuto nav1;
		public string where,orderby,and;
		private System.Windows.Forms.Panel panel1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmSearch1(ArrayList normal,ArrayList datetime,C1.Win.C1FlexGrid.C1FlexGrid vs,Navigator1._0.NavigatorAuto nav1,string orderby)
		{
			this.a=normal;
			this.b=datetime;
			this._vs=vs;
			this.nav1=nav1;
			this.orderby=orderby;

			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}
		public frmSearch1(ArrayList normal,ArrayList datetime,C1.Win.C1FlexGrid.C1FlexGrid vs,Navigator1._0.NavigatorAuto nav1)
		{
			this.a=normal;
			this.b=datetime;
			this._vs=vs;
			this.nav1=nav1;
			this.orderby="";

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
			this.cmd_search = new System.Windows.Forms.Button();
			this.cmd_can = new System.Windows.Forms.Button();
			this.vs = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// cmd_search
			// 
			this.cmd_search.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_search.Location = new System.Drawing.Point(151, 104);
			this.cmd_search.Name = "cmd_search";
			this.cmd_search.Size = new System.Drawing.Size(80, 32);
			this.cmd_search.TabIndex = 18;
			this.cmd_search.Text = "Search";
			this.cmd_search.Click += new System.EventHandler(this.cmd_search_Click);
			// 
			// cmd_can
			// 
			this.cmd_can.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_can.Location = new System.Drawing.Point(315, 104);
			this.cmd_can.Name = "cmd_can";
			this.cmd_can.Size = new System.Drawing.Size(80, 32);
			this.cmd_can.TabIndex = 19;
			this.cmd_can.Text = "Cancel";
			this.cmd_can.Click += new System.EventHandler(this.cmd_can_Click);
			// 
			// vs
			// 
			this.vs.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
			this.vs.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
			this.vs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.vs.AutoClipboard = true;
			this.vs.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs.ColumnInfo = "5,0,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs.Location = new System.Drawing.Point(4, 4);
			this.vs.Name = "vs";
			this.vs.Rows.Count = 2;
			this.vs.Size = new System.Drawing.Size(540, 92);
			this.vs.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs.TabIndex = 20;
			this.vs.Tag = "N";
			//this.vs.Click += new System.EventHandler(this.vs_Click);
			this.vs.Paint += new System.Windows.Forms.PaintEventHandler(this.vs_Paint);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.cmd_can);
			this.panel1.Controls.Add(this.cmd_search);
			this.panel1.Controls.Add(this.vs);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(546, 144);
			this.panel1.TabIndex = 21;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// frmSearch1
			// 
			this.AutoScale = false;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(546, 144);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSearch1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Search";
			this.Load += new System.EventHandler(this.frmSearch1_Load);
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmSearch1_Load(object sender, System.EventArgs e)
		{
			PublicFunction.L_Init_Label(this);
			ComboBox cb=new ComboBox();
			cbox=new ArrayList();
			ct=new ArrayList();
			vs.Cols.Count=0;
			vs.Rows.Count=3;
			cb.Font=this.Font;
			if (this.Font.Size>9)
				vs.Rows[1].Height=cb.Height+1;
			else
				vs.Rows[1].Height=cb.Height;
			int n=0,k;
			
			if (a!=null)
			{
				vs.Cols.Count=a.Count;
				for (int i=0;i<a.Count;i++)
				{
					vs.Cols[i].Caption =_vs.Cols[(string)a[i]].Caption ;
					vs.Cols[i].DataType=_vs.Cols[(string)a[i]].DataType;
					vs.Cols[i].Name=_vs.Cols[(string)a[i]].Name;
					//vs.Cols[i].Name=(string)a1[i];
					k=nav1.name.IndexOf(vs.Cols[i].Name,0,nav1.name.Count);
					cb=new ComboBox();
					cb.DropDownStyle=ComboBoxStyle.DropDownList;
					switch ((string)nav1.datatype[k])// DataType
					{
						case "1": //string		
							vs.Cols[i].DataMap=_vs.Cols[(string)a[i]].DataMap;	
							cb.Items.Add("like");
							cb.Items.Add("=");
							cb.Text="=";
							ct.Add(new HostedControl(vs, cb, 1, i));
							break;
						case "3": //boolean							
							cb.Items.Add("=");							
							vs.Rows[1][i]="=";
							cb.Text="=";
							ct.Add(new HostedControl(vs, cb, 1, i));
							break;
						case "4"://int							
						case "5"://double							
							cb.Items.Add("<");
							cb.Items.Add("=");
							cb.Items.Add(">");
							cb.Text="=";							
							ct.Add(new HostedControl(vs, cb, 1, i));
//							vs.Cols[i].ComboList=">|=|<";
//							vs.Rows[1][i]="=";
							break;
						default:				
							vs.Cols[i].DataMap=_vs.Cols[(string)a[i]].DataMap;	
							cb.Items.Add("like");
							cb.Items.Add("=");
							cb.Text="=";
							ct.Add(new HostedControl(vs, cb, 1, i));
							break;
					}
					cbox.Add(cb);
					
				}
			}
			if (b!=null)
			{
				n=vs.Cols.Count;
				vs.Cols.Count=vs.Cols.Count+(b.Count*2);
				for (int i=0;i<b.Count;i++)
				{
					vs.Cols[n].Caption =_vs.Cols[(string)b[i]].Caption ;//+" ["+ PublicFunction.L_GetLabel("Public",0)+"]";
					vs.Cols[n].DataType=_vs.Cols[(string)b[i]].DataType;										
					vs.Cols[n].Name=_vs.Cols[(string)b[i]].Name;
					cb=new ComboBox();						
					cb.DropDownStyle=ComboBoxStyle.DropDownList;
					cb.Items.Add("<");
					cb.Items.Add("=");
					cb.Items.Add(">");
					cb.Items.Add("Between");
					cb.Text="=";			
					cb.SelectedIndexChanged+=new EventHandler(cb_SelectedIndexChanged);
					cb.Click+=new EventHandler(cb_Click);
					cbox.Add(cb);					
					ct.Add(new HostedControl(vs, cb, 1, n));					
					n++;
					cb=new ComboBox();
					cb.DropDownStyle=ComboBoxStyle.DropDownList;
					ct.Add(new HostedControl(vs, cb, 1, n));
					cbox.Add(cb);
					vs.Cols[n-1].Format=_vs.Cols[(string)b[i]].Format;
					vs.Cols[n].Format=_vs.Cols[(string)b[i]].Format;
					vs.Cols[n].Caption =_vs.Cols[(string)b[i]].Caption;//+" ["+ PublicFunction.L_GetLabel("Public",1)+"]";
					vs.Cols[n].DataType=_vs.Cols[(string)b[i]].DataType;
					vs.Cols[n].Name=_vs.Cols[(string)b[i]].Name+"[To]";					
					vs.Cols[n].Visible=false;						
					n++;
				}
			}
			foreach (HostedControl hc in ct)
				hc.UpdatePosition();	
		}

		private void cmd_search_Click(object sender, System.EventArgs e)
		{
			string sql="",name;
			int k,j=2;
			for (int i=0;i<vs.Cols.Count;i++)
			{
				if (vs.Cols[i].Name.IndexOf("[To]")<0)
				if (vs[j,i]!=null)
				{
					if (sql!="") sql+=" and ";
					k=nav1.name.IndexOf(vs.Cols[i].Name,0,nav1.name.Count);
					name=(string)nav1.namesql[k-2];
					switch ((string)nav1.datatype[k])// DataType
					{
						case "1":
							if ( ((HostedControl)ct[i])._ctl.Text=="=")
								sql=sql+"("+name + "=N'" + (vs.Rows[j][i]+"").Replace("'","''") +"')";
							else
								sql=sql+"("+name + " like N'%" + (vs.Rows[j][i]+"").Replace("'","''") +"%')";
							break;
						case "2":
							if ( ((HostedControl)ct[i])._ctl.Text=="Between")
							{
								if (vs.GetDataDisplay(j,vs.Cols[i].Name+"[To]")==null || vs.GetDataDisplay(j,vs.Cols[i].Name+"[To]")=="")
									sql=sql+""+ name + "='" + DateTime.Parse(vs.Rows[j][i]+"").ToString("yyyy/MM/dd")+"'";
								else
								{
									sql=sql+"("+ name + " Between '" + DateTime.Parse(vs.Rows[j][i]+"").ToString("yyyy/MM/dd")+"'"
										+" and '"+DateTime.Parse(vs.Rows[j][vs.Cols[i].Name+"[To]"]+"").ToString("yyyy/MM/dd")+"')";
								}
							}
							else
							{
								if ( ((HostedControl)ct[i])._ctl.Text=="=")
									sql=sql+""+ name + "='" + DateTime.Parse(vs.Rows[j][i]+"").ToString("yyyy/MM/dd")+"'";
								else
								{
									if ( ((HostedControl)ct[i])._ctl.Text==">")
										 sql=sql+""+ name + ">'" + DateTime.Parse(vs.Rows[j][i]+"").ToString("yyyy/MM/dd")+"'";
									else
										 sql=sql+""+ name + "<'" + DateTime.Parse(vs.Rows[j][i]+"").ToString("yyyy/MM/dd")+"'";
								 }

								 }
							break;
						case "3":
							if ((Boolean)vs.Rows[j][i]==true)
								sql=sql+"("+name + "=" + 1+")";
							else if ((Boolean)vs.Rows[1][i]==false)
								sql=sql+"("+name + "=" +0+")";
							else
								sql=sql+"("+name + "=" + vs.Rows[j][i]+")";
							break;
						case "4":
							if (((HostedControl)ct[i])._ctl.Text=="=")
							{
								sql=sql+"("+name + "=" + vs.Rows[j][i]+")";
								break;
							}
							if (((HostedControl)ct[i])._ctl.Text==">")
							{
								sql=sql+"("+name + ">" + vs.Rows[j][i]+")";
								break;
							}
							sql=sql+"("+name + "<" + vs.Rows[j][i]+")";
							break;
						case "5":
							if (((HostedControl)ct[i])._ctl.Text=="=")
							{
								sql=sql+"("+name + "=" + vs.Rows[j][i]+")";
								break;
							}
							if (((HostedControl)ct[i])._ctl.Text==">")
							{
								sql=sql+"("+name + ">" + vs.Rows[j][i]+")";
								break;
							}
							sql=sql+"("+name + "<" + vs.Rows[j][i]+")";
							break;							
						default:
							if (((HostedControl)ct[i])._ctl.Text=="=")
								sql=sql+"("+name + "=N'" + (vs.Rows[j][i]+"").Replace("'","''") +"')";
							else
								sql=sql+"("+name + " like N'" + (vs.Rows[j][i]+"").Replace("'","''") +"')";
							break;
					}
				}
			}
			//MessageBox.Show(sql);
			if (sql!="")			
				sql=sql+and;
			else
				sql=sql+"1=1 "+and;

			if (sql!="")
				nav1.Show_VS(sql+orderby);
			else
				nav1.Show_VS("1=1 "+orderby);
			this.DialogResult=DialogResult.OK;
		}
		

		private void vs_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
//			foreach (HostedControl hc in ct)
//				hc.UpdatePosition();	
		}

		private void cb_SelectedIndexChanged(object sender, EventArgs e)
		{
			int n=cbox.IndexOf(sender);
			if (((ComboBox)cbox[n]).Text=="Between")			
				vs.Cols[vs.Cols[n].Name+"[To]"].Visible=true;
			else
				vs.Cols[vs.Cols[n].Name+"[To]"].Visible=false;
		}
		private void cb_Click(object sender,EventArgs e)
		{
			int n=cbox.IndexOf(sender);
			HostedControl hc =(HostedControl)ct[n];
			hc.UpdatePosition();
		}

		private void cmd_can_Click(object sender, System.EventArgs e)
		{
			this.DialogResult=DialogResult.Cancel;
			this.Close();
		}

		private void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}

		
	}


	internal class HostedControl
	{
		internal C1FlexGrid _grd;
		internal Control _ctl;
		internal Row _row;
		internal Column _col;

		internal HostedControl(C1FlexGrid grd, Control hosted, int row, int col)
		{
			// save info
			_grd = grd;
			_ctl = hosted;
			_row = grd.Rows[row];
			_col = grd.Cols[col];

			// insert hosted control into grid
			_grd.Controls.Add(_ctl);
		}
		internal bool UpdatePosition()
		{
			// get row/col indices
			int r = _row.Index;
			int c = _col.Index;
			if (r < 0 || c < 0) return false;

			// save work
			if (r < _grd.TopRow || r > _grd.BottomRow || 
				c < _grd.LeftCol || c > _grd.RightCol)
			{
				if (_ctl.Visible) _ctl.Visible = false;
				return true;
			}

			// get cell rect
			Rectangle rcCell = _grd.GetCellRect(r, c, false);

			// intersect with scrollable part of the grid
			Rectangle rcScroll = _grd.ClientRectangle;
			rcScroll.X = _grd.Cols[_grd.Cols.Fixed].Left;
			rcScroll.Y = _grd.Rows[_grd.Rows.Fixed].Top;
			rcScroll.Width -= rcScroll.X;
			rcScroll.Height -= rcScroll.Y;
			rcCell = Rectangle.Intersect(rcCell, rcScroll);

			// and move the control
			if (_ctl.Bounds != rcCell) _ctl.Bounds = rcCell;
			if (!_ctl.Visible) _ctl.Visible = true;

			// done
			return true;
		}
	}
}

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
	/// Summary description for frmTaMultiSelect.
	/// </summary>
	public class frmTaMultiSelect : System.Windows.Forms.Form
	{
		public C1.Win.C1FlexGrid.C1FlexGrid vs;
		private System.Windows.Forms.Button cmd_can;
		private System.Windows.Forms.Button cmd_ok;
		private string Master,Detail,key1,key2,_LabelID,orderby;
		private int cols;
		public ArrayList ar;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaMultiSelect(string  sqlMaster,string sqlDetail,string key1,string key2,int cols,string LabelID)
		{
			this.Master=sqlMaster;
			this.Detail=sqlDetail;
			this.key1=key1;
			this.key2=key2;
			this._LabelID=LabelID;
			this.cols=cols;
			//this.colhid=colhid;
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();			
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}
		public frmTaMultiSelect(string  sqlMaster,string sqlDetail,string orderby,string key1,string key2,int cols,string LabelID)
		{
			this.Master=sqlMaster;
			this.Detail=sqlDetail;
			this.key1=key1;
			this.key2=key2;
			this._LabelID=LabelID;
			this.cols=cols;
			this.orderby=orderby;
			//this.colhid=colhid;
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
			this.vs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.vs.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs.Location = new System.Drawing.Point(8, 8);
			this.vs.Name = "vs";
			this.vs.Size = new System.Drawing.Size(384, 344);
			this.vs.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs.TabIndex = 19;
			this.vs.Tag = "N";
			this.vs.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.vs_AfterEdit);
			// 
			// cmd_can
			// 
			this.cmd_can.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmd_can.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_can.Location = new System.Drawing.Point(222, 364);
			this.cmd_can.Name = "cmd_can";
			this.cmd_can.Size = new System.Drawing.Size(88, 32);
			this.cmd_can.TabIndex = 51;
			this.cmd_can.Text = "Cancel";
			this.cmd_can.Click += new System.EventHandler(this.cmd_can_Click);
			// 
			// cmd_ok
			// 
			this.cmd_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cmd_ok.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_ok.Location = new System.Drawing.Point(90, 364);
			this.cmd_ok.Name = "cmd_ok";
			this.cmd_ok.Size = new System.Drawing.Size(88, 32);
			this.cmd_ok.TabIndex = 50;
			this.cmd_ok.Tag = "";
			this.cmd_ok.Text = "OK";
			this.cmd_ok.Click += new System.EventHandler(this.cmd_ok_Click);
			// 
			// frmTaMultiSelect
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(400, 402);
			this.Controls.Add(this.cmd_can);
			this.Controls.Add(this.cmd_ok);
			this.Controls.Add(this.vs);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaMultiSelect";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmTaMultiSelect";
			this.Load += new System.EventHandler(this.frmTaMultiSelect_Load);
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaMultiSelect_Load(object sender, System.EventArgs e)
		{
			ar=new ArrayList();
			ar.Add(null);
			PublicFunction.L_Init_Label(this);							
			Func.RecordSet rs =new Func.RecordSet(Detail + " where "+key1+"=N''",PublicFunction.C_con); 	
			vs.Cols.Count=rs.cols+1;
			for (int c=1;c<vs.Cols.Count;c++)
			{
				if (c>cols ) vs.Cols[c].Visible=false;
				vs.Cols[c].Name=rs.Field(c-1);
				if (vs.Cols[c].Name=="SYS_SEL")
				{
					vs.Cols[c].Caption=PublicFunction.L_GetLabel_VS("Public",vs.Cols[c].Name); 
					vs.Cols[c].DataType=typeof(System.Boolean);
				}
				else
				{
					vs.Cols[c].Caption=PublicFunction.L_GetLabel_VS(_LabelID,vs.Cols[c].Name); 					
				}
			}
//			//vs.Cols[key1].Visible=false;
//			//if (key2!="") vs.Cols[key2].Visible=false;
			InitTree();		
		}
		
		private void InitTree()
		{
			Func.RecordSet rs =new Func.RecordSet(Master,PublicFunction.C_con); 
			vs.Tree.Column = 1;
			vs.Rows.Count = 1;
			for (int i=2;i<vs.Cols.Count;i++)
			{
				vs.Cols[i].AllowEditing =false;
			}
			vs.Cols[1].AllowEditing =true;			
			Node a;
			for (int i=0;i<rs.rows;i++)
			{
				
				a=vs.Rows.InsertNode(vs.Rows.Count, 0);	
				ar.Add(a);
				//vs.Rows[vs.Rows.Count-1].AllowEditing=false;
				//vs.SetCellCheck(vs.Rows.Count-1,1, CheckEnum.Unchecked);
				vs.SetCellCheck(vs.Rows.Count-1,1, CheckEnum.Unchecked);
				for (int j=0;j<rs.cols;j++)
				{
					vs[vs.Rows.Count-1,j+1]=rs.record(i,j);
				}
				if (key1!="" && key2!="")
					InitDetail(rs.record(i,key1),rs.record(i,key2));
				else
				{
					if (key1!="")
					{
						InitDetail(rs.record(i,key1),"");
					}
				}
				a.Expanded=false;
			
			}
		}

		private void InitDetail(string f1,string f2)
		{
			Func.RecordSet rs ;
			if (f2!="")
				rs =new Func.RecordSet(Detail + " where "+key1+"=N'"+f1+"' and "+key2+"=N'"+f2+"'" + orderby  ,PublicFunction.C_con); 			
			else
				rs =new Func.RecordSet(Detail + " where "+key1+"=N'"+f1+"'" + orderby ,PublicFunction.C_con); 			
			Node a;
			for (int i=0;i<rs.rows;i++)
			{
				a=vs.Rows.InsertNode(vs.Rows.Count, 1);
				vs.SetCellCheck(vs.Rows.Count-1,1, CheckEnum.Unchecked);
				ar.Add(a);
				for (int j=0;j<rs.cols;j++)
				{
					vs[vs.Rows.Count-1,j+1]=rs.record(i,j);					
				}
				
			}
		}

		private void cmd_ok_Click(object sender, System.EventArgs e)
		{
			this.DialogResult=DialogResult.OK;
		}

		private void cmd_can_Click(object sender, System.EventArgs e)
		{
			this.DialogResult=DialogResult.Cancel;			
		}

		private void vs_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			if (e.Col==1 && e.Row>0)
			{
				if (((Node)ar[e.Row]).Level==1)
					return;
				((Node)ar[e.Row]).Expanded=(vs.GetCellCheck(e.Row,e.Col)==CheckEnum.Checked);
				for(int i=e.Row+1;i<vs.Rows.Count;i++)
				{
					if (((Node)ar[i]).Level==0)
						break;
					vs.SetCellCheck(i,1, vs.GetCellCheck(e.Row,e.Col));
				}
			}
		}

	}
}

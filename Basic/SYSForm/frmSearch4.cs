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
	/// <summary>
	/// Summary description for frmSearch4.
	/// </summary>
	public class frmSearch4 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button cmd_can;
		private System.Windows.Forms.Button cmd_ok;
		public C1.Win.C1FlexGrid.C1FlexGrid vs;
		//private Boolean sel;
		private int _Cols;
		private RecordSet _rs;
		private string _LabelID;
		private string TRN_NO;
		private System.ComponentModel.Container components = null;
		
		public frmSearch4(RecordSet rs,int Cols,string LabelID,string TRN_NO)
		{
			this._Cols =Cols;
			this._rs=rs;
			this._LabelID=LabelID;
			//this.sel=false;
			this.TRN_NO=TRN_NO;
			InitializeComponent();
		}
//		public frmSearch4(RecordSet rs,int Cols,string LabelID,Boolean sel)
//		{
//			this._Cols =Cols;
//			this._rs=rs;
//			this._LabelID=LabelID;
//			this.sel=sel;
//			InitializeComponent();
//		}
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
			this.cmd_can.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.cmd_can.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_can.Location = new System.Drawing.Point(423, 424);
			this.cmd_can.Name = "cmd_can";
			this.cmd_can.Size = new System.Drawing.Size(90, 32);
			this.cmd_can.TabIndex = 58;
			this.cmd_can.Text = "Cancel";
			this.cmd_can.Click += new System.EventHandler(this.cmd_can_Click);
			// 
			// cmd_ok
			// 
			this.cmd_ok.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.cmd_ok.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_ok.Location = new System.Drawing.Point(279, 424);
			this.cmd_ok.Name = "cmd_ok";
			this.cmd_ok.Size = new System.Drawing.Size(90, 32);
			this.cmd_ok.TabIndex = 57;
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
			this.vs.Location = new System.Drawing.Point(-2, 0);
			this.vs.Name = "vs";
			this.vs.Size = new System.Drawing.Size(796, 408);
			this.vs.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs.TabIndex = 56;
			this.vs.Tag = "N";
			this.vs.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.vs_AfterEdit);
			// 
			// frmSearch4
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(792, 470);
			this.Controls.Add(this.cmd_can);
			this.Controls.Add(this.cmd_ok);
			this.Controls.Add(this.vs);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmSearch4";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmSearch4";
			this.Load += new System.EventHandler(this.frmSearch4_Load);
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmSearch4_Load(object sender, System.EventArgs e)
		{
			try
			{
				//vs.AllowEditing  = true;
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
						vs.Cols[c].DataType=typeof(System.Boolean);
					}
					else
					{
						vs.Cols[c].Caption=PublicFunction.L_GetLabel_VS(_LabelID,vs.Cols[c].Name); 
					}
					if(c!=8)
					{
						vs.Cols[c].AllowEditing=false;
					}
				}
				for (int r = 0; r < _rs.rows; r++)
				{	
					vs[r+1, 0]=r+1;
					for (int c = 1; c < _Cols+1; c++)
						vs[r+1, c] = _rs.record(r,c-1);
				}
				vs.AutoSizeCols();
//				vs.DoubleClick +=new EventHandler(vs_DoubleClick);
//				vs.KeyDown +=new KeyEventHandler(vs_KeyDown);
//				this.KeyDown+=new KeyEventHandler(vs_KeyDown);
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
			SaveReceivedDetail();
			Accept();

		}

		private void cmd_can_Click(object sender, System.EventArgs e)
		{
			this.DialogResult=DialogResult.Cancel;	
		}

		private void vs_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			switch (vs.Cols[e.Col].Name)
			{
				case "REV_QT":
					CalculateBalanceQTY(e.Row);
					break;
			}
		}
		private void CalculateBalanceQTY(int row)
		{
			int trn_qt,acc_qt,rev_qt,bal_qt;
			trn_qt=T_String.IsNullTo0(vs.Rows[row]["TRN_QT"]+"");
			acc_qt=T_String.IsNullTo0(vs.Rows[row]["ACC_QT"]+"");
			rev_qt=T_String.IsNullTo0(vs.Rows[row]["REV_QT"]+"");
			bal_qt=T_String.IsNullTo0(vs.Rows[row]["BAL_QT"]+"");
			if(rev_qt<=0 || (trn_qt-acc_qt==0))//|| bal_qt==0)
			{
				vs.Rows[row]["REV_QT"]=0;
				bal_qt=trn_qt-acc_qt;
				vs.Rows[row]["BAL_QT"]=bal_qt;
				return;
			}
			if(rev_qt>=(trn_qt-acc_qt))
			{
				rev_qt=trn_qt-acc_qt;
				vs.Rows[row]["REV_QT"]=rev_qt;
				vs.Rows[row]["BAL_QT"]=0;
				return;
			}
			else
			{
				vs.Rows[row]["BAL_QT"]=trn_qt-acc_qt-rev_qt;
				return;
			}
		}
		private void SaveReceivedDetail()
		{
//			string sql;
//			for(int i=1;i<vs.Rows.Count;i++)
//			{
//				if(T_String.IsNullTo0(vs.Rows[i]["REV_QT"]+"")==0)
//					continue;
//				sql=CreateQueryString(i);
//				Func.RecordSet rs=new RecordSet(sql,PublicFunction.C_con);
//				if(rs.rows>0)
//					continue;
//				sql=CreateInsertString(i);
//				PublicFunction.SQL_Execute(sql);
//
//			}
			string sql;
			for(int i=1;i<vs.Rows.Count;i++)
			{
				if(T_String.IsNullTo0(vs.Rows[i]["REV_QT"]+"")==0)
					continue;
				sql=CreateQueryString(i);
				Func.RecordSet rs=new RecordSet(sql,PublicFunction.C_con);
				if(rs.rows>0)
				{
					//continue;
					sql=CreateUpdateString(i);
					PublicFunction.SQL_Execute(sql);
				}
				else
				{
					sql=CreateInsertString(i);
					PublicFunction.SQL_Execute(sql);
				}

			}
		}
		private string CreateInsertString(int i)
		{
			string sql="";
			sql="Insert into FILJ12B (TRN_NO,ORD_NO,TYP_ID,SIZ_NO,COL_NO,TRN_QT,UNT_PR) values (N'"+TRN_NO+"',N'"+
				vs.Rows[i]["ORD_NO"]+"',N'"+
				vs.Rows[i]["TYP_ID"]+"',N'"+vs.Rows[i]["SIZ_NO"]+"',N'"+
				vs.Rows[i]["COL_NO"]+"',"+ vs.Rows[i]["REV_QT"]+","+
				//T_String.IsNullTo0(vs.Rows[i]["LOT_QT"]+"")+","+vs.Rows[i]["ACC_QT"]+","+
				T_String.IsNullTo00(vs.Rows[i]["UNT_PR"]+"")+")";
			return sql;
		}
		private string CreateQueryString(int i)
		{
			string sql="";
			sql="select * from filj12b where TRN_NO=N'"+TRN_NO+
				"' AND ORD_NO=N'"+vs.Rows[i]["ORD_NO"]+
				"' AND TYP_ID=N'"+vs.Rows[i]["TYP_ID"]+
				"' AND SIZ_NO=N'"+vs.Rows[i]["SIZ_NO"]+
				"' AND COL_NO=N'"+vs.Rows[i]["COL_NO"]+"'";
			return sql;
		}
		private string CreateUpdateString(int i)
		{
			string sql="";
			sql="UPDATE FILJ12B SET TRN_QT="+vs.Rows[i]["REV_QT"]+" WHERE TRN_NO=N'"+TRN_NO+
				"' AND ORD_NO=N'"+vs.Rows[i]["ORD_NO"]+
				"' AND TYP_ID=N'"+vs.Rows[i]["TYP_ID"]+
				"' AND SIZ_NO=N'"+vs.Rows[i]["SIZ_NO"]+
				"' AND COL_NO=N'"+vs.Rows[i]["COL_NO"]+"'"; 
			return sql;
		}

		
			
			
		
	}
}

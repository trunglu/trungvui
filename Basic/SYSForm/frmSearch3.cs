using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Basic.Function;
using System.Data;
using Func;
using C1.Win.C1FlexGrid;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace GGM3000.Outsourcing
{
	/// <summary>
	/// Summary description for frmSearch3.
	/// </summary>
	public class frmSearch3 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button cmd_can;
		private System.Windows.Forms.Button cmd_ok;
		public C1.Win.C1FlexGrid.C1FlexGrid vs;
		//private Boolean sel;
		private int _Cols;
		private RecordSet _rs;
		private string _LabelID;
		private System.ComponentModel.Container components = null;
		private string keep_amount;
		private string eff_ym;
		private string sub_id1,sub_id2;
		private string rcv_dt1,rcv_dt2;

		public frmSearch3(RecordSet rs,int Cols,string LabelID,string eff_ym,string sub_id1,string sub_id2,string rcv_dt1,string rcv_dt2,string keep_amount)
		{
			this._Cols =Cols;
			this._rs=rs;
			this._LabelID=LabelID;
		//	this.sel=false;
			this.eff_ym=eff_ym;
			this.sub_id1=sub_id1;
			this.sub_id2=sub_id2;
			this.rcv_dt1=rcv_dt1;
			this.rcv_dt2=rcv_dt2;
			this.keep_amount=keep_amount;
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
			this.cmd_can.Location = new System.Drawing.Point(423, 428);
			this.cmd_can.Name = "cmd_can";
			this.cmd_can.Size = new System.Drawing.Size(90, 32);
			this.cmd_can.TabIndex = 61;
			this.cmd_can.Text = "Cancel";
			this.cmd_can.Click += new System.EventHandler(this.cmd_can_Click);
			// 
			// cmd_ok
			// 
			this.cmd_ok.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.cmd_ok.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_ok.Location = new System.Drawing.Point(279, 428);
			this.cmd_ok.Name = "cmd_ok";
			this.cmd_ok.Size = new System.Drawing.Size(90, 32);
			this.cmd_ok.TabIndex = 60;
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
			this.vs.Location = new System.Drawing.Point(-2, 7);
			this.vs.Name = "vs";
			this.vs.Size = new System.Drawing.Size(796, 408);
			this.vs.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs.TabIndex = 59;
			this.vs.Tag = "N";
			this.vs.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.vs_AfterEdit);
			// 
			// frmSearch3
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(792, 470);
			this.Controls.Add(this.cmd_can);
			this.Controls.Add(this.cmd_ok);
			this.Controls.Add(this.vs);
			this.Name = "frmSearch3";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmSearch3";
			this.Load += new System.EventHandler(this.frmSearch3_Load);
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmSearch3_Load(object sender, System.EventArgs e)
		{
			try
			{
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
					if(c==11)// An cot send qty
					{
						vs.Cols[c].Visible=false;
					}
				}
				for (int r = 0; r < _rs.rows; r++)
				{	
					vs[r+1, 0]=r+1;
					for (int c = 1; c < _Cols+1; c++)
						vs[r+1, c] = _rs.record(r,c-1);
				}
				vs.AutoSizeCols();
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

		private void cmd_ok_Click(object sender, System.EventArgs e)
		{
			int RCV_QT=0,PAY_QT=0;
			double INC_MY=0,BAL_MY=0,HLD_MY=0,DES_MY=0;
			string SUB_NO=PublicFunction.L_GetLabel("frmSearch3",3);
			if(_rs.rows<=0)
			{
				InsertPre_Pay(SUB_NO);// dua vao cac payment thang truoc chua thanh toan
				this.DialogResult=DialogResult.OK;
				return;
			}
			else
			{
				string sql="";
				if(keep_amount=="Y")
				{
					sql="select EFF_YM,SUB_ID,CAS_DT,ORD_NO,TYP_ID,COL_NO,INC_MY,DES_MY,TRN_NO from FILJ13A where EFF_YM='"+eff_ym+"' AND SUB_ID between N'"+sub_id1+"' and N'"+sub_id2+"'";
					Func.RecordSet rs1=new Func.RecordSet(sql,PublicFunction.C_con);
					if(rs1.rows>0)
					{
						sql="DELETE FROM FILJ13A WHERE EFF_YM='"+eff_ym+"' AND SUB_ID between N'"+sub_id1+"' and N'"+sub_id2+"'";
						PublicFunction.SQL_Execute(sql);
						InsertPre_Pay(SUB_NO); // dua vao cac payment thang truoc chua thanh toan
						if(WriteToTextFile(rs1))
						{
							ArrayList a=ReadFromTextFile();
							for(int i=0;i<_rs.rows;i++)
							{
								bool flag=false;
								for(int j=0;j<a.Count;j++)
								{
									string[] row=(string[])a[j];
									if(_rs.record(i,"SUB_ID")==row[1] && _rs.record(i,"ORD_NO")==row[3] && _rs.record(i,"TYP_ID")==row[4] && _rs.record(i,"COL_NO")==row[5]&& _rs.record(i,"TRN_NO")==row[7] && CalculatePre_Pay(DateTime.Now.ToString("yyyy/MM/dd"))!=row[2].Substring(0,7)) 
									{
										flag=true;
										RCV_QT=T_String.IsNullTo0(vs.Rows[i+1]["RCV_QT"]+"");
										PAY_QT=T_String.IsNullTo0(vs.Rows[i+1]["PAY_QT"]+"");
										INC_MY=PAY_QT*T_String.IsNullTo00(_rs.record(i,"UNT_PR")+"");
										HLD_MY=(RCV_QT-PAY_QT)*T_String.IsNullTo00(_rs.record(i,"UNT_PR")+"");
										DES_MY=T_String.IsNullTo00(row[6]+"");
										BAL_MY=INC_MY-DES_MY;
										sql="INSERT INTO FILJ13A (EFF_YM,SUB_ID,CAS_DT,SUB_NO,ORD_NO,TYP_ID,COL_NO,COL_DR,RET_QT,ACC_QT,UNT_PR,INC_MY,HLD_MY,DES_MY,RSV_FG,BAL_MY,TRN_NO,OUT_QT) "+
											"VALUES ('"+eff_ym+"',N'"+_rs.record(i,"SUB_ID")+"','"+DateTime.Now.ToString("yyyy/MM/dd")+"','"+SUB_NO+"', "+
											"'"+_rs.record(i,"ORD_NO")+"', '"+_rs.record(i,"TYP_ID")+"','"+_rs.record(i,"COL_NO")+"','"+_rs.record(i,"LOT_DR")+"', "+
											RCV_QT+", "+PAY_QT+","+T_String.IsNullTo00(_rs.record(i,"UNT_PR")+"")+
											","+INC_MY+","+HLD_MY+","+DES_MY+","+0+","+BAL_MY+",'"+vs.Rows[i+1]["TRN_NO"]+"', "+
											T_String.IsNullTo0(_rs.record(i,"SEND_QT")+"")+")";
										PublicFunction.SQL_Execute(sql);
										break;
									}
								}
								if(flag==false)
								{
									RCV_QT=T_String.IsNullTo0(vs.Rows[i+1]["RCV_QT"]+"");
									PAY_QT=T_String.IsNullTo0(vs.Rows[i+1]["PAY_QT"]+"");
									INC_MY=PAY_QT*T_String.IsNullTo00(_rs.record(i,"UNT_PR")+"");
									HLD_MY=(RCV_QT-PAY_QT)*T_String.IsNullTo00(_rs.record(i,"UNT_PR")+"");
									DES_MY=INC_MY-HLD_MY;
									BAL_MY=INC_MY-DES_MY;
									sql="INSERT INTO FILJ13A (EFF_YM,SUB_ID,CAS_DT,SUB_NO,ORD_NO,TYP_ID,COL_NO,COL_DR,RET_QT,ACC_QT,UNT_PR,INC_MY,HLD_MY,DES_MY,RSV_FG,BAL_MY,TRN_NO,OUT_QT) "+
										"VALUES ('"+eff_ym+"',N'"+_rs.record(i,"SUB_ID")+"','"+DateTime.Now.ToString("yyyy/MM/dd")+"','"+SUB_NO+"', "+
										"'"+_rs.record(i,"ORD_NO")+"', '"+_rs.record(i,"TYP_ID")+"','"+_rs.record(i,"COL_NO")+"', '"+_rs.record(i,"LOT_DR")+"', "+
										RCV_QT+", "+PAY_QT+","+T_String.IsNullTo00(_rs.record(i,"UNT_PR")+"")+", "+
										INC_MY+","+HLD_MY+","+DES_MY+","+0+","+BAL_MY+",'"+vs.Rows[i+1]["TRN_NO"]+"', "+
										T_String.IsNullTo0(_rs.record(i,"SEND_QT")+"")+")";
									PublicFunction.SQL_Execute(sql);
								}	
							}
						}
					}
					else // co giu lai debit nhung ko co trong database
					{
						InsertPre_Pay(SUB_NO);// dua vao cac payment thang truoc chua thanh toan
						for(int i=0;i<_rs.rows;i++)
						{
							RCV_QT=T_String.IsNullTo0(vs.Rows[i+1]["RCV_QT"]+"");
							PAY_QT=T_String.IsNullTo0(vs.Rows[i+1]["PAY_QT"]+"");
							INC_MY=PAY_QT*T_String.IsNullTo00(_rs.record(i,"UNT_PR")+"");
							HLD_MY=(RCV_QT-PAY_QT)*T_String.IsNullTo00(_rs.record(i,"UNT_PR")+"");
							DES_MY=INC_MY-HLD_MY;
							BAL_MY=INC_MY-DES_MY;
							sql="INSERT INTO FILJ13A (EFF_YM,SUB_ID,CAS_DT,SUB_NO,ORD_NO,TYP_ID,COL_NO,COL_DR,RET_QT,ACC_QT,UNT_PR,INC_MY,HLD_MY,DES_MY,RSV_FG,BAL_MY,TRN_NO,OUT_QT) "+
								"VALUES ('"+eff_ym+"',N'"+_rs.record(i,"SUB_ID")+"','"+DateTime.Now.ToString("yyyy/MM/dd")+"','"+SUB_NO+"', "+
								"'"+_rs.record(i,"ORD_NO")+"', '"+_rs.record(i,"TYP_ID")+"','"+_rs.record(i,"COL_NO")+"','"+_rs.record(i,"LOT_DR")+"', "+
								RCV_QT+", "+
								PAY_QT+","+T_String.IsNullTo00(_rs.record(i,"UNT_PR")+"")+", "+
								INC_MY+","+HLD_MY+","+DES_MY+","+0+","+BAL_MY+",'"+vs.Rows[i+1]["TRN_NO"]+"', "+
								T_String.IsNullTo0(_rs.record(i,"SEND_QT")+"")+")";
							PublicFunction.SQL_Execute(sql);
						}
					}
					
				}
				else // ko giu lai debit 
				{
					sql="DELETE FROM FILJ13A WHERE EFF_YM='"+eff_ym+"' AND SUB_ID between N'"+sub_id1+"' and N'"+sub_id2+"'";
					PublicFunction.SQL_Execute(sql);
					InsertPre_Pay(SUB_NO);// dua vao cac payment thang truoc chua thanh toan
					for(int i=0;i<_rs.rows;i++)
					{
						RCV_QT=T_String.IsNullTo0(vs.Rows[i+1]["RCV_QT"]+"");
						PAY_QT=T_String.IsNullTo0(vs.Rows[i+1]["PAY_QT"]+"");
						INC_MY=PAY_QT*T_String.IsNullTo00(_rs.record(i,"UNT_PR")+"");
						HLD_MY=(RCV_QT-PAY_QT)*T_String.IsNullTo00(_rs.record(i,"UNT_PR")+"");
						DES_MY=INC_MY-HLD_MY;
						BAL_MY=INC_MY-DES_MY;
						sql="INSERT INTO FILJ13A (EFF_YM,SUB_ID,CAS_DT,SUB_NO,ORD_NO,TYP_ID,COL_NO,COL_DR,RET_QT,ACC_QT,UNT_PR,INC_MY,HLD_MY,DES_MY,RSV_FG,BAL_MY,TRN_NO,OUT_QT) "+
							"VALUES ('"+eff_ym+"',N'"+_rs.record(i,"SUB_ID")+"','"+DateTime.Now.ToString("yyyy/MM/dd")+"','"+SUB_NO+"', "+
							"'"+_rs.record(i,"ORD_NO")+"', '"+_rs.record(i,"TYP_ID")+"','"+_rs.record(i,"COL_NO")+"','"+_rs.record(i,"LOT_DR")+"', "+
							RCV_QT+", "+PAY_QT+","+T_String.IsNullTo00(_rs.record(i,"UNT_PR")+"")+", "+
							INC_MY+","+HLD_MY+","+DES_MY+","+0+","+BAL_MY+",'"+vs.Rows[i+1]["TRN_NO"]+"', "+
							T_String.IsNullTo0(_rs.record(i,"SEND_QT")+"")+")";
						PublicFunction.SQL_Execute(sql);
					}
				}
			}
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
				case "PAY_QT":
					CalculatePayQTY(e.Row);
					CalculateAmount(e.Row);
					break;
			}
		}
		private void CalculatePayQTY(int row)
		{
			int rev_qt,pay_qt;
			rev_qt=T_String.IsNullTo0(vs.Rows[row]["RCV_QT"]+"");
			pay_qt=T_String.IsNullTo0(vs.Rows[row]["PAY_QT"]+"");
			if(pay_qt>rev_qt)
			{
				pay_qt=rev_qt;
				vs.Rows[row]["PAY_QT"]=pay_qt;
				return;
			}
			if(pay_qt<=0)
			{
				vs.Rows[row]["PAY_QT"]=0;
				return;
			}
		}

		private void CalculateAmount(int row)
		{
			int pay_qt;
			double unt_pr,inc_my;
			pay_qt=T_String.IsNullTo0(vs.Rows[row]["PAY_QT"]+"");
			unt_pr=T_String.IsNullTo00(vs.Rows[row]["UNT_PR"]+"");
			inc_my=pay_qt*unt_pr;
			vs.Rows[row]["INC_MY"]=inc_my;
		}

		//Cac phuong thuc de doc ghi file
		private bool WriteToTextFile(Func.RecordSet rs)
		{
			StringBuilder obj=new StringBuilder();
			for(int i=0;i<rs.rows;i++)
			{
				if(i<rs.rows-1)
				{
					obj.AppendFormat("{0}~!~!~!~!~{1}~!~!~!~!~{2}~!~!~!~!~{3}~!~!~!~!~{4}~!~!~!~!~{5}~!~!~!~!~{6}~!~!~!~!~{7}\r\n",rs.record(i,"EFF_YM"),rs.record(i,"SUB_ID"),rs.record(i,"CAS_DT"),rs.record(i,"ORD_NO"),rs.record(i,"TYP_ID"),rs.record(i,"COL_NO"),rs.record(i,"DES_MY"),rs.record(i,"TRN_NO"));
				}
				else
				{
					obj.AppendFormat("{0}~!~!~!~!~{1}~!~!~!~!~{2}~!~!~!~!~{3}~!~!~!~!~{4}~!~!~!~!~{5}~!~!~!~!~{6}~!~!~!~!~{7}",rs.record(i,"EFF_YM"),rs.record(i,"SUB_ID"),rs.record(i,"CAS_DT"),rs.record(i,"ORD_NO"),rs.record(i,"TYP_ID"),rs.record(i,"COL_NO"),rs.record(i,"DES_MY"),rs.record(i,"TRN_NO"));
				}
			}
			try
			{
				FileInfo f=new FileInfo("tam.txt");
				if(f.Exists)
					f.Delete();
				StreamWriter writer =new StreamWriter(@"tam.txt",false);
				writer.Write(obj.ToString());
				writer.Close();
			}
			catch(Exception)
			{
				return false;
			}
			return true;
		}

		private ArrayList ReadFromTextFile()
		{
			ArrayList a=new ArrayList();
			try
			{
				FileInfo f=new FileInfo(@"tam.txt");
				if(f.Exists)
				{	
					StreamReader reader = f.OpenText(); 
					string text;
					text=reader.ReadLine();
					while(text!=null)
					{
						int k=0;
						string[] row=new string[8];
						foreach(string substr in Regex.Split(text,"~!~!~!~!~"))
						{
							row[k]=substr;
							k++;
						}
						a.Add(row);
						text = reader.ReadLine();
					}
					reader.Close();
				}
			}
			catch(Exception)
			{
				return a;
			}
			return a;
		}
		public string CalculatePre_Pay(string eff_ym)
		{
			int pre_month=T_String.IsNullTo0(eff_ym.Substring(5,2)+"");
			int pre_year=T_String.IsNullTo0(eff_ym.Substring(0,4)+"");
			if(pre_month==1)
			{
				pre_month=12;	
				pre_year=pre_year-1;
			}
			else
				pre_month=pre_month-1;
			string pre_pay=pre_year.ToString("0000")+"/"+pre_month.ToString("00");
			return pre_pay;
		}
		
		public void InsertPre_Pay(string subject)
		{
			string SUB_NO=subject;
			string sql_pre="SELECT * FROM FILJ13A WHERE EFF_YM='"+CalculatePre_Pay(eff_ym)+"' AND SUB_ID between N'"+sub_id1+"' and N'"+sub_id2+"' AND RSV_FG=1";
			string sql_insert="";
			Func.RecordSet rs_pre=new Func.RecordSet(sql_pre,PublicFunction.C_con);
			if(rs_pre.rows>0)
			{
				for(int i=0;i<rs_pre.rows;i++)
				{
					sql_insert="INSERT INTO FILJ13A VALUES ('"+eff_ym+"','"+rs_pre.record(i,"SUB_ID")+"','"+
						rs_pre.record(i,"CAS_DT")+"','"+SUB_NO+"','"+rs_pre.record(i,"ORD_NO")+"','"+
						rs_pre.record(i,"TYP_ID")+"','"+rs_pre.record(i,"COL_NO")+"','"+rs_pre.record(i,"COL_DR")+"',"+T_String.IsNullTo0(rs_pre.record(i,"OUT_QT")+"")+","+
						T_String.IsNullTo0(rs_pre.record(i,"RET_QT")+"")+","+T_String.IsNullTo0(rs_pre.record(i,"ACC_QT")+"")+","+
						T_String.IsNullTo00(rs_pre.record(i,"UNT_PR")+"")+","+T_String.IsNullTo00(rs_pre.record(i,"INC_MY")+"")+","+
						T_String.IsNullTo00(rs_pre.record(i,"HLD_MY")+"")+","+
						T_String.IsNullTo00(rs_pre.record(i,"DES_MY")+"")+",0,"+T_String.IsNullTo00(rs_pre.record(i,"BAL_MY")+"")+",'"+
						rs_pre.record(i,"TRN_NO")+"')";
					PublicFunction.SQL_Execute(sql_insert);
				}
			}
		}	
	}
}

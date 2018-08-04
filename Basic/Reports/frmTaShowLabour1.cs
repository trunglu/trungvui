using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Basic.Form;
using Basic.Function;
using System.IO;
using System.Diagnostics;
using System.Threading;
using C1.Win.C1FlexGrid;
using System.Data;
using System.Data.SqlClient;
namespace GP8000.Reports
{
	/// <summary>
	/// Summary description for frmTaShowLabour.
	/// </summary>
	public class frmTaShowLabour : System.Windows.Forms.Form
	{
		string wh,LAB_NO,day,LAB_N1,date;
		C1.Win.C1FlexGrid.C1FlexGrid vs;
		private System.Windows.Forms.ProgressBar pro;
		private System.Windows.Forms.Label lb;
		private int ngaytinh;
		private Boolean ngaytru;
		private Boolean NEW_BT;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaShowLabour(string wh,string LAB_NO,C1.Win.C1FlexGrid.C1FlexGrid vs,string day,string LAB_N1,string date,int ngaytinh, Boolean NEW_BT)
		{
			this.wh=wh;
			this.LAB_NO=LAB_NO;
			this.vs=vs;
			this.day=day;
			this.LAB_N1=LAB_N1;
			this.date=date;
			this.ngaytinh=ngaytinh;
			this.NEW_BT=NEW_BT;
//			this.ngaytru=ngaytru;
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
			this.pro = new System.Windows.Forms.ProgressBar();
			this.lb = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// pro
			// 
			this.pro.Dock = System.Windows.Forms.DockStyle.Top;
			this.pro.Location = new System.Drawing.Point(0, 0);
			this.pro.Name = "pro";
			this.pro.Size = new System.Drawing.Size(524, 23);
			this.pro.TabIndex = 0;
			// 
			// lb
			// 
			this.lb.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lb.Location = new System.Drawing.Point(0, 23);
			this.lb.Name = "lb";
			this.lb.Size = new System.Drawing.Size(524, 29);
			this.lb.TabIndex = 1;
			this.lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmTaShowLabour
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.BackColor = System.Drawing.Color.LightBlue;
			this.ClientSize = new System.Drawing.Size(524, 52);
			this.Controls.Add(this.lb);
			this.Controls.Add(this.pro);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmTaShowLabour";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmTaShowLabour";
			this.TransparencyKey = System.Drawing.Color.LightBlue;
			this.Load += new System.EventHandler(this.frmTaShowLabour_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaShowLabour_Load(object sender, System.EventArgs e)
		{
			Thread th=new Thread(new ThreadStart(show));
			th.Start();
		}

		private void show()
		{
			vs.Visible=false;
			SqlConnection con=new SqlConnection(PublicFunction.C_con.ConnectionString);
			if(con.State==ConnectionState.Closed )
				con.Open();
			string sql="";
			sql="Select * from FILE01A";
			Func.RecordSet rs2=new Func.RecordSet(sql,con);	
			ArrayList a=new ArrayList();
			ArrayList b=new ArrayList();
			for(int i=0;i<rs2.rows;i++)
			{
				a.Add(rs2.record(i,"LAB_NO"));
				int tam=T_String.IsNullTo0(T_String.GetDataFromSQL("MAX(SEQ_N1)","FILE03A","LAB_NO=N'"+rs2.record(i,"LAB_NO")+"'"));
				if(tam==1)
					tam=T_String.IsNullTo0(rs2.record(i,"STT_N2")+"");
				b.Add(tam);
			}
			double maxx=T_String.GetMax("MAX(SEQ_N2)","FILE03A");

			sql="Select EMP_ID,EMP_I1,EMP_NM,INH_DT,TYP_ID,POS_ID,DEP_ID from FILB01A where (VAC_BT is null or VAC_BT=0)";		
			if (NEW_BT)
			{
				sql=sql+" and isnull(NEW_BT,0)=1 and isnull(LCK_BT,0)=0";
			}
			if(wh!="")
				sql+=" and "+wh;
			DateTime dt1= T_String.GetDate();
			dt1=dt1.AddDays(T_String.IsNullTo0(day));
			sql+=" and EMP_ID not in(Select Distinct EMP_ID from FILE03A where LAB_ED>'"+dt1.ToString("yyyy/MM/dd")
				+"' or LIM_NO=1)";						
			vs.Rows.Count=1;
			Func.RecordSet rs=new Func.RecordSet(sql,con);			
			for(int i=0;i<rs.rows;i++)			
			{	
				try
				{
					sql="Select * from FILE03A where EMP_ID=N'"+rs.record(i,"EMP_ID")+"' ORDER BY LAB_ST DESC";
					Func.RecordSet rslb=new Func.RecordSet(sql,con);
					DateTime dt;
					int max;
					if(rslb.rows==0)
					{
						dt=DateTime.Parse(rs.record(i,"INH_DT"));
						max=1;
					}
					else
					{
						dt=DateTime.Parse(rslb.record(0,"LAB_ED"));
						//dt=dt.AddDays(1);
						max=1+T_String.IsNullTo0(rslb.record(0,"SEQ_NO"));
					}	
//					if(ngaytinh>0)//ngaytinh
//					{
//						if(dt.Day<ngaytinh)
//							dt=new DateTime (dt.Year,dt.Month,1);
//						else
//						{
//							dt=dt.AddMonths(1);
//							dt=new DateTime (dt.Year,dt.Month,1);
//						}
//					}
					if(LAB_N1!="")
						sql="Select * from FILE02A a, FILE01A b where TYP_ID=N'"
							+rs.record(i,"TYP_ID")+"' and a.LAB_NO=N'"+LAB_N1+"' and a.LAB_NO=b.LAB_NO";
					else
						sql="Select * from FILE02A a, FILE01A b where TYP_ID=N'"
							+rs.record(i,"TYP_ID")+"' and SEQ_NO="+max +" and a.LAB_NO=b.LAB_NO";
					Func.RecordSet rs1=new Func.RecordSet(sql,con);
					if(rs1.rows==0)
					{
						sql="Select * from FILE02A a, FILE01A b where TYP_ID=N'"
							+rs.record(i,"TYP_ID")+"' and REP_BT=1 and a.LAB_NO=b.LAB_NO";
						rs1=new Func.RecordSet(sql,con);
					}
					try
					{
						if(rs1.rows>0 && rs1.record(0,"LAB_ID")+""!="" && (this.LAB_NO=="" || this.LAB_NO==rs1.record(0,"LAB_NO")))
						{
							vs.Rows.Count++;
							vs.Rows[vs.Rows.Count-1].UserData=2;
							vs.Rows[vs.Rows.Count-1][0]=vs.Rows.Count-1;
							vs.Rows[vs.Rows.Count-1]["EMP_ID"]=rs.record(i,"EMP_ID");
							vs.Rows[vs.Rows.Count-1]["EMP_I1"]=rs.record(i,"EMP_I1");
							vs.Rows[vs.Rows.Count-1]["EMP_NM"]=rs.record(i,"EMP_NM");
							vs.Rows[vs.Rows.Count-1]["TYP_ID"]=rs.record(i,"TYP_ID");
							vs.Rows[vs.Rows.Count-1]["POS_ID"]=rs.record(i,"POS_ID");
							vs.Rows[vs.Rows.Count-1]["DEP_ID"]=rs.record(i,"DEP_ID");
							vs.Rows[vs.Rows.Count-1]["INH_DT"]=rs.record(i,"INH_DT");
							vs.Rows[vs.Rows.Count-1]["SEQ_NO"]=rs1.record(0,"SEQ_NO");
							if(date!="")
							{
								vs.Rows[vs.Rows.Count-1]["LAB_ST"]=date;
								dt=DateTime.Parse(date);
							}
							else
								vs.Rows[vs.Rows.Count-1]["LAB_ST"]=dt.ToString("yyyy/MM/dd");

							if(rs1.record(0,"LIM_NO")+""=="True")
								vs.Rows[vs.Rows.Count-1]["LIM_NO"]="True";	
							else
							{								
								if(rs1.record(0,"YYY_YY")+""!="")
								{
									dt=dt.AddYears(T_String.IsNullTo0(rs1.record(0,"YYY_YY")+""));
								}
								else
								{
									dt=dt.AddMonths(T_String.IsNullTo0(rs1.record(0,"MMM_MM")+""));
								}
								if(ngaytinh>0)//ngaytinh
								{
									if(dt.Day<ngaytinh)
										dt=new DateTime (dt.Year,dt.Month,1);
									else
									{
										dt=dt.AddMonths(1);
										dt=new DateTime (dt.Year,dt.Month,1);
									}
								}
								if (ngaytru)
									vs.Rows[vs.Rows.Count-1]["LAB_ED"]=dt.AddDays(-1).ToString("yyyy/MM/dd");
								else
									vs.Rows[vs.Rows.Count-1]["LAB_ED"]=dt.ToString("yyyy/MM/dd");
							}							
							vs.Rows[vs.Rows.Count-1]["LAB_NO"]=rs1.record(0,"LAB_NO");
							vs.Rows[vs.Rows.Count-1]["LAB_TP"]=rs1.record(0,"LAB_TP");
							// LAB_ID  ma so hop dong
							string LAB_ID=rs1.record(0,"LAB_ID");							
							LAB_ID=LAB_ID.Replace("#",rs.record(i,"EMP_ID")+"");
							LAB_ID=LAB_ID.Replace("&",rs.record(i,"EMP_I1")+"");
							if(LAB_ID.IndexOf("@")>=0)
							{
								int index=a.IndexOf(rs1.record(0,"LAB_NO"));
								int vl=T_String.IsNullTo0(b[index]+"")+T_String.IsNullTo0(rs1.record(0,"STT_N3"));
								vs.Rows[vs.Rows.Count-1]["SEQ_N1"]=vl;
								string st="000000000000";
								b[index]=vl;
								st=PublicFunction.S_Left(st,T_String.IsNullTo0(rs1.record(0,"STT_N1")));
								LAB_ID=LAB_ID.Replace("@",vl.ToString(st));
							}

							DateTime ngayky= DateTime.Parse( vs.Rows[vs.Rows.Count-1]["LAB_ST"]+"");
							LAB_ID=LAB_ID.Replace("*(Year)",ngayky.ToString("yyyy")+"");
							LAB_ID=LAB_ID.Replace("*(Month)",ngayky.ToString("MM")+"");
							LAB_ID=LAB_ID.Replace("*(Day)",ngayky.ToString("dd")+"");

							int count=T_String.IsNullTo0(T_String.GetDataFromSQL("Count(*)","FILE03A","EMP_ID=N'"+rs.record(i,"EMP_ID")+"'"));
							LAB_ID=LAB_ID.Replace("*(Count)",(count+1)+"");
							LAB_ID=LAB_ID.Replace("*(DEP)",rs.record(i,"DEP_ID")+"");
							LAB_ID=LAB_ID.Replace("*(POS)",rs.record(i,"POS_ID")+"");
							LAB_ID=LAB_ID.Replace("*(NATURE)",rs.record(i,"TYP_ID")+"");
							


							////////////
							vs.Rows[vs.Rows.Count-1]["LAB_ID"]=LAB_ID;

							vs.Rows[vs.Rows.Count-1]["SEQ_N2"]=maxx;
							maxx++;
						}
					}
					catch(Exception ex){MessageBox.Show(ex.Message);vs.Rows.Count--;}
				}
				catch(Exception ex){MessageBox.Show(ex.Message);}
				lb.Text=((int)(i*100)/rs.rows)+"% - "+rs.record(i,"EMP_NM");
				pro.Value=(int)(i*100)/rs.rows;
			}
			vs.AutoSizeCols();
			pro.Value=100;
			con.Close();
			this.Close();
			vs.Visible=true;
		}
	}
}

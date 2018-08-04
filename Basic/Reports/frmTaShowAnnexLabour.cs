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
	public class frmTaShowAnnexLabour : System.Windows.Forms.Form
	{
		string LAB_NO,dt,dt1,day;
		C1.Win.C1FlexGrid.C1FlexGrid vs,vs1,vs2;
		private System.Windows.Forms.ProgressBar pro;
		private System.Windows.Forms.Label lb;
		Navigator1._0.NavigatorAuto nav;
		private Boolean Tab_3_dt1;
		private Boolean ck411;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaShowAnnexLabour(C1.Win.C1FlexGrid.C1FlexGrid vs,C1.Win.C1FlexGrid.C1FlexGrid vs1,
			C1.Win.C1FlexGrid.C1FlexGrid vs2,string LAB_NO,string dt, string dt1,Navigator1._0.NavigatorAuto nav,Boolean ck411,string day)
		{			
			this.vs=vs;
			this.vs1=vs1;
			this.vs2=vs2;
			this.LAB_NO=LAB_NO;
			this.dt=dt;
			this.dt1=dt1;
			this.nav=nav;
			this.Tab_3_dt1=Tab_3_dt1;
			this.ck411=ck411;
			this.day=day;
		
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
			// frmTaShowAnnexLabour
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.BackColor = System.Drawing.Color.LightBlue;
			this.ClientSize = new System.Drawing.Size(524, 52);
			this.Controls.Add(this.lb);
			this.Controls.Add(this.pro);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmTaShowAnnexLabour";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmTaShowAnnexLabour";
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
			DateTime dt5;
			double seqMax=0;
			vs.Visible=false;
			string sql="";
			SqlConnection con=new SqlConnection(PublicFunction.C_con.ConnectionString);
			if(con.State==ConnectionState.Closed )
				con.Open();
			double maxx=T_String.GetMax("MAX(SEQ_N2)","FILE06A");
			double max=T_String.GetMax("MAX(SEQ_N1)","FILE06A","LAB_NO=N'"+LAB_NO+"'")-1;

			DateTime dt6= T_String.GetDate();
			dt6=dt6.AddDays(T_String.IsNullTo0(day));
			for(int i=1;i<vs1.Rows.Count;i++)
			{	
				sql="Select * from FILE03A where EMP_ID=N'"+vs1.Rows[i]["EMP_ID"]+"' ORDER BY SEQ_NO DESC";
				Func.RecordSet rslb=new Func.RecordSet(sql,con);
				sql="Select * from FILE06A where EMP_ID=N'"+vs1.Rows[i]["EMP_ID"]+"' ORDER BY SEQ_NO DESC";
				Func.RecordSet rse=new Func.RecordSet(sql,con);
				DateTime dtHienTai= T_String.GetDate();
				DateTime dtKT= T_String.GetDate();
				dtKT=Convert.ToDateTime(rslb.record(0,"LAB_ST"));
//					if((ck411==false && rslb.record(0,"LAB_NO") =="HDVTH" && rslb.rows>=1 && rse.rows>=0 && Convert.ToDateTime(rse.record(0,"LA1_ST"))<=dt6))
					if((ck411==false && rslb.rows>=1 && rse.rows==0 && rslb.record(0,"LAB_NO") =="HDVTH" && dtKT.AddYears(1)<=dt6)||(ck411==false && rslb.rows>=1 && rse.rows>0 && Convert.ToDateTime(rse.record(0,"LA1_ED"))<=dt6))
					{
						seqMax= T_String.GetMax("MAX(SEQ_NO)","FILE06A","EMP_ID=N'"+vs1.Rows[i]["EMP_ID"]+"'");
						nav.ToolBar_Click(new ToolBarButtonClickEventArgs(nav.cmd_add));
						vs.Rows[vs.Rows.Count-1].UserData=2;
						vs.Rows[vs.Rows.Count-1]["LAB_ID"]=rslb.record(0,"LAB_ID");			
						vs.Rows[vs.Rows.Count-1]["LAB_ST"]=rslb.record(0,"LAB_ST");
						vs.Rows[vs.Rows.Count-1]["LAB_ED"]=rslb.record(0,"LAB_ED");
						dt5=Convert.ToDateTime(rslb.record(0,"LAB_ST"));
						vs.Rows[vs.Rows.Count-1]["LA1_ST"]=dt5.AddYears(1).ToString("yyyy/MM/dd");
						vs.Rows[vs.Rows.Count-1]["LA1_ED"]=dt5.AddYears(2).ToString("yyyy/MM/dd");
						vs.Rows[vs.Rows.Count-1]["LA1_ED"]=Convert.ToDateTime(vs.Rows[vs.Rows.Count-1]["LA1_ED"]).AddDays(-1).ToString("yyyy/MM/dd");
					
						if(rse.rows>0)
						{
							vs.Rows[vs.Rows.Count-1]["LA1_ST"]=rse.record(0,"LA1_ED");
							vs.Rows[vs.Rows.Count-1]["LA1_ED"]=Convert.ToDateTime(vs.Rows[vs.Rows.Count-1]["LA1_ST"]).AddYears(1).ToString("yyyy/MM/dd");
							vs.Rows[vs.Rows.Count-1]["LA1_ST"]=Convert.ToDateTime(vs.Rows[vs.Rows.Count-1]["LA1_ST"]).AddDays(1).ToString("yyyy/MM/dd");							
						}

						vs.Rows[vs.Rows.Count-1]["LA1_SG"]=dt1;		
						vs.Rows[vs.Rows.Count-1]["LAB_NO"]=LAB_NO;
						vs.Rows[vs.Rows.Count-1]["SEQ_N2"]=maxx;
						vs.Rows[vs.Rows.Count-1]["SEQ_NO"]=seqMax;
						maxx++;
						vs.Rows[vs.Rows.Count-1][0]=vs.Rows.Count-1;
						for(int c=1;c<vs1.Cols.Count;c++)
						{
							vs.Rows[vs.Rows.Count-1][vs1.Cols[c].Name]=	vs1.Rows[i][c];
						}
						for(int c=1;c<vs2.Cols.Count;c++)
						{
							vs.Rows[vs.Rows.Count-1]["SAL_N"+c]=vs2.Cols[c].Name;
							vs.Rows[vs.Rows.Count-1]["SAL_Q"+c]=vs2.Rows[1][c];
						}
						// LAB_ID
						Func.RecordSet rs1=new Func.RecordSet("Select * from FILE05A where LAB_NO=N'"+LAB_NO+"'",con);
						if(rs1.rows>0)
						{
							string LAB_ID=T_String.GetDataFromSQL("LAB_ID","FILE05A","LAB_NO=N'"+LAB_NO+"'");							
							LAB_ID=LAB_ID.Replace("#",vs1.Rows[i]["EMP_ID"]+"");
							LAB_ID=LAB_ID.Replace("#",vs1.Rows[i]["EMP_I1"]+"");
							if(LAB_ID.IndexOf("@")>=0)
							{							
								double vl=max+T_String.IsNullTo0(rs1.record(0,"STT_N3"));
								vs.Rows[vs.Rows.Count-1]["SEQ_N1"]=vl;
								string st="000000000000";
								max=vl;
								st=PublicFunction.S_Left(st,T_String.IsNullTo0(rs1.record(0,"STT_N1")));
								LAB_ID=LAB_ID.Replace("@",vl.ToString(st));
							}
							DateTime ngayky= DateTime.Parse( vs.Rows[vs.Rows.Count-1]["LA1_ST"]+"");
							LAB_ID=LAB_ID.Replace("*(Year)",ngayky.ToString("yyyy")+"");
							vs.Rows[vs.Rows.Count-1]["LA1_ID"]=LAB_ID;

							vs.Rows[vs.Rows.Count-1]["SEQ_N2"]=maxx;
							maxx++;						
						}
						lb.Text=((int)(i*100)/vs1.Rows.Count)+"% - "+vs1.Rows[i]["EMP_NM"];
						pro.Value=(int)(i*100)/vs1.Rows.Count;
					}
					//if(ck411==true && rslb.rows>=1 && Convert.ToDateTime(dt)<=dt6)
					if(ck411==true && rslb.rows>=1)
					{
						seqMax= T_String.GetMax("MAX(SEQ_NO)","FILE06A","emp_id=N'"+vs1.Rows[i]["EMP_ID"]+"'");
						nav.ToolBar_Click(new ToolBarButtonClickEventArgs(nav.cmd_add));
						vs.Rows[vs.Rows.Count-1].UserData=2;
						vs.Rows[vs.Rows.Count-1]["LAB_ID"]=rslb.record(0,"LAB_ID");			
						vs.Rows[vs.Rows.Count-1]["LAB_ST"]=rslb.record(0,"LAB_ST");
						vs.Rows[vs.Rows.Count-1]["LAB_ED"]=rslb.record(0,"LAB_ED");
						dt5=Convert.ToDateTime(rslb.record(0,"LAB_ST"));
//						vs.Rows[vs.Rows.Count-1]["LA1_ST"]=dt5.AddYears(1).ToString("yyyy/MM/dd");
//						vs.Rows[vs.Rows.Count-1]["LA1_ED"]=dt5.AddYears(2).ToString("yyyy/MM/dd");
						vs.Rows[vs.Rows.Count-1]["LA1_ST"]=dt;
						vs.Rows[vs.Rows.Count-1]["LA1_ED"]=Convert.ToDateTime(vs.Rows[vs.Rows.Count-1]["LA1_ST"]).AddYears(1).ToString("yyyy/MM/dd");
						vs.Rows[vs.Rows.Count-1]["LA1_ED"]=Convert.ToDateTime(vs.Rows[vs.Rows.Count-1]["LA1_ED"]).AddDays(-1).ToString("yyyy/MM/dd");
//						if(rse.rows==0 && rslb.record(0,"LAB_NO")!="HDVTH")
//						{
//							vs.Rows[vs.Rows.Count-1]["LA1_ED"]=Convert.ToDateTime(vs.Rows[vs.Rows.Count-1]["LAB_ED"]).AddDays(+1).ToString("yyyy/MM/dd");
//						}
//						vs.Rows[vs.Rows.Count-1]["LA1_ED"]=Convert.ToDateTime(vs.Rows[vs.Rows.Count-1]["LA1_ED"]).AddDays(-1).ToString("yyyy/MM/dd");
//					
//						vs.Rows[vs.Rows.Count-1]["LA1_ST"]=dt;
//					
//						if(rse.rows>0)
//						{
//							vs.Rows[vs.Rows.Count-1]["LA1_ST"]=rse.record(0,"LA1_ED");
//							vs.Rows[vs.Rows.Count-1]["LA1_ED"]=Convert.ToDateTime(vs.Rows[vs.Rows.Count-1]["LA1_ST"]).AddYears(0).ToString("yyyy/MM/dd");
//							vs.Rows[vs.Rows.Count-1]["LA1_ST"]=dt;			
//						}

						vs.Rows[vs.Rows.Count-1]["LA1_SG"]=dt1;		
						vs.Rows[vs.Rows.Count-1]["LAB_NO"]=LAB_NO;
						vs.Rows[vs.Rows.Count-1]["SEQ_N2"]=maxx;
						vs.Rows[vs.Rows.Count-1]["SEQ_NO"]=seqMax;
						maxx++;
						vs.Rows[vs.Rows.Count-1][0]=vs.Rows.Count-1;
						for(int c=1;c<vs1.Cols.Count;c++)
						{
							vs.Rows[vs.Rows.Count-1][vs1.Cols[c].Name]=	vs1.Rows[i][c];
						}
						for(int c=1;c<vs2.Cols.Count;c++)
						{
							vs.Rows[vs.Rows.Count-1]["SAL_N"+c]=vs2.Cols[c].Name;
							vs.Rows[vs.Rows.Count-1]["SAL_Q"+c]=vs2.Rows[1][c];
						}
						Func.RecordSet rs1=new Func.RecordSet("Select * from FILE05A where LAB_NO=N'"+LAB_NO+"'",con);
						if(rs1.rows>0)
						{
							string LAB_ID=T_String.GetDataFromSQL("LAB_ID","FILE05A","LAB_NO=N'"+LAB_NO+"'");							
							LAB_ID=LAB_ID.Replace("#",vs1.Rows[i]["EMP_ID"]+"");
							LAB_ID=LAB_ID.Replace("#",vs1.Rows[i]["EMP_I1"]+"");
							if(LAB_ID.IndexOf("@")>=0)
							{							
								double vl=max+T_String.IsNullTo0(rs1.record(0,"STT_N3"));
								vs.Rows[vs.Rows.Count-1]["SEQ_N1"]=vl;
								string st="000000000000";
								max=vl;
								st=PublicFunction.S_Left(st,T_String.IsNullTo0(rs1.record(0,"STT_N1")));
								LAB_ID=LAB_ID.Replace("@",vl.ToString(st));
							}
							DateTime ngayky= DateTime.Parse( vs.Rows[vs.Rows.Count-1]["LAB_ST"]+"");
							LAB_ID=LAB_ID.Replace("*(Year)",ngayky.ToString("yyyy")+"");
							vs.Rows[vs.Rows.Count-1]["LA1_ID"]=LAB_ID;

							vs.Rows[vs.Rows.Count-1]["SEQ_N2"]=maxx;
							maxx++;						
						}
						lb.Text=((int)(i*100)/vs1.Rows.Count)+"% - "+vs1.Rows[i]["EMP_NM"];
						pro.Value=(int)(i*100)/vs1.Rows.Count;
					}
				}

				vs.AutoSizeCols();
				pro.Value=100;
				con.Close();
				this.Close();
				vs.Visible=true;
			}
		}
	}



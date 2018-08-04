using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Basic.Form;
using Basic.Function;
using System.IO;
using System.Threading;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualBasic;
namespace GP8000.Attendance
{
	/// <summary>
	/// Summary description for frmTaCalAnnualLeave.
	/// </summary>
	public class frmTaCalAnnualLeave : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button cmd_close;
		private GP8000.UserControl.CrtTaCondition1 control1;
		private System.Windows.Forms.Button cmd_OK;
		private System.Windows.Forms.ProgressBar pro;
		private System.Windows.Forms.Label lb;
		private Boolean stop;
		private System.Windows.Forms.Label lb2;
		private DateTime dt;			
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaCalAnnualLeave(DateTime dtt)
		{
			if(dtt.Year<T_String.GetDate().Year)	
			{
				dt=new DateTime(dtt.Year+1,1,1) ;
				dt=dt.AddDays(-1);
			}
			else
				dt=T_String.GetDate();
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
			this.control1 = new GP8000.UserControl.CrtTaCondition1();
			this.cmd_close = new System.Windows.Forms.Button();
			this.cmd_OK = new System.Windows.Forms.Button();
			this.pro = new System.Windows.Forms.ProgressBar();
			this.lb = new System.Windows.Forms.Label();
			this.lb2 = new System.Windows.Forms.Label();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.panel3.Controls.Add(this.label5);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(446, 36);
			this.panel3.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Location = new System.Drawing.Point(0, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(446, 36);
			this.label5.TabIndex = 11;
			this.label5.Tag = "";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// control1
			// 
			this.control1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.control1.Location = new System.Drawing.Point(0, 32);
			this.control1.Name = "control1";
			this.control1.Size = new System.Drawing.Size(444, 164);
			this.control1.TabIndex = 6;
			// 
			// cmd_close
			// 
			this.cmd_close.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_close.Location = new System.Drawing.Point(261, 260);
			this.cmd_close.Name = "cmd_close";
			this.cmd_close.Size = new System.Drawing.Size(116, 36);
			this.cmd_close.TabIndex = 27;
			this.cmd_close.Text = "Close";
			this.cmd_close.Click += new System.EventHandler(this.cmd_close_Click);
			// 
			// cmd_OK
			// 
			this.cmd_OK.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_OK.Location = new System.Drawing.Point(69, 260);
			this.cmd_OK.Name = "cmd_OK";
			this.cmd_OK.Size = new System.Drawing.Size(116, 36);
			this.cmd_OK.TabIndex = 26;
			this.cmd_OK.Text = "OK";
			this.cmd_OK.Click += new System.EventHandler(this.cmd_OK_Click);
			// 
			// pro
			// 
			this.pro.Location = new System.Drawing.Point(4, 196);
			this.pro.Name = "pro";
			this.pro.Size = new System.Drawing.Size(436, 16);
			this.pro.TabIndex = 28;
			// 
			// lb
			// 
			this.lb.BackColor = System.Drawing.Color.Black;
			this.lb.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lb.ForeColor = System.Drawing.Color.White;
			this.lb.Location = new System.Drawing.Point(4, 212);
			this.lb.Name = "lb";
			this.lb.Size = new System.Drawing.Size(436, 23);
			this.lb.TabIndex = 29;
			this.lb.Tag = "N";
			this.lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lb2
			// 
			this.lb2.BackColor = System.Drawing.Color.Black;
			this.lb2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lb2.ForeColor = System.Drawing.Color.White;
			this.lb2.Location = new System.Drawing.Point(4, 232);
			this.lb2.Name = "lb2";
			this.lb2.Size = new System.Drawing.Size(436, 23);
			this.lb2.TabIndex = 30;
			this.lb2.Tag = "N";
			this.lb2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmTaCalAnnualLeave
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(446, 302);
			this.Controls.Add(this.lb2);
			this.Controls.Add(this.lb);
			this.Controls.Add(this.pro);
			this.Controls.Add(this.cmd_close);
			this.Controls.Add(this.cmd_OK);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.control1);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmTaCalAnnualLeave";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmTaCalAnnualLeave";
			this.Load += new System.EventHandler(this.frmTaCalAnnualLeave_Load);
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
		#region Load
		private void frmTaCalAnnualLeave_Load(object sender, System.EventArgs e)
		{			
			Basic.Function.PublicFunction.L_Init_Label(this);				
			control1.InitCB(this.Tag);
			control1.Initlabel();
			this.Closed+=new EventHandler(frmTaCalAnnualLeave_Closed);
			label5.Text=label5.Text+"-"+dt.Year.ToString("0000");
			
		}
		#endregion
		#region Event
		private void cmd_close_Click(object sender, System.EventArgs e)
		{
			this.DialogResult=DialogResult.Cancel;
		}

		private void cmd_OK_Click(object sender, System.EventArgs e)
		{
			stop=false;			
			Thread th=new Thread(new System.Threading.ThreadStart(Cal));
			th.Start();		
		}
		#endregion
		#region TinhPhepNam


		/// <summary>
		
		/// </summary>
		private void Cal()
		{
			//dt=T_String.GetDate();
			string nghiviec;
			DateTime dt2;
			lb.Text= "";
			lb2.Text= "";
			cmd_OK.Enabled=false;
			SqlConnection con=new SqlConnection(PublicFunction.C_con.ConnectionString);
			con.Open();
			//string sql="Select EMP_ID,EMP_NM,TYP_ID,INH_DT from FILB01A";
			//sql+=" where "+control1.GetWhere("");

			string str="delete from FILC04B where YYY_YY=N'"+dt.ToString("yyyy")+"' AND  EMP_ID IN (Select FILB01A.EMP_ID from FILB01A JOIN FILB01AC ON year(VAC_DT)<'"+dt.Year+"' AND FILB01A.EMP_ID=FILB01AC.EMP_ID ) ";
			PublicFunction.SQL_Execute(str,con);

			str="delete from FILC04B where EMP_ID IN (Select EMP_ID from FILB01A where year(INH_DT)>'"+dt.Year+"') and YYY_YY=N'"+dt.ToString("yyyy")+"'";
			PublicFunction.SQL_Execute(str,con);

			string sql="Select FILB01A.EMP_ID,EMP_NM,TYP_ID,INH_DT from FILB01A LEFT JOIN FILB01AC ON FILB01A.EMP_ID=FILB01AC.EMP_ID and year(VAC_DT)>='"+dt.Year+"'";
			sql+=" where "+control1.GetWhere("",false).Replace("EMP_ID","FILB01A.EMP_ID");
			sql+=" and year(INH_DT)<='"+dt.Year+"'";
			sql+=" and (isnull(VAC_BT,0)=0 OR year(VAC_DT)>='"+dt.Year+"')";
			Func.RecordSet rs=new Func.RecordSet(sql,con);
			for(int i=0;i<rs.rows;i++)
			{
				if(stop)
				{
					return;
				}
				nghiviec=T_String.GetDataFromSQL("VAC_BT","FILB01A,FILB01AC","FILB01A.EMP_ID=FILB01AC.EMP_ID AND FILB01A.EMP_ID='"+rs.record(i,"EMP_ID")+"' AND YEAR(VAC_DT)='"+dt.Year+"'");
				
				if (nghiviec=="True")
				{
					dt2=DateTime.Parse(T_String.GetDataFromSQL("VAC_DT","FILB01AC","EMP_ID='"+rs.record(i,"EMP_ID")+"'"));
					if(PublicFunction.CUS_ID=="52") //domex quang nam
					{
						dt2=DateTime.Parse(dt2.ToString("yyyy")+"/"+dt2.ToString("MM")+"/01").AddMonths(1);
						dt2=dt2.AddDays(-1);
					}
					if(PublicFunction.tinhphepnam==0)
					{					
						CalStaff(rs.record(i,"EMP_ID")+"",rs.record(i,"TYP_ID")+"",rs.record(i,"INH_DT")+"",con,dt.ToString("yyyy"),dt2,true);
					}
					else
					{
						if(PublicFunction.tinhphepnam==1)
							CalStaff1(rs.record(i,"EMP_ID")+"",rs.record(i,"TYP_ID")+"",rs.record(i,"INH_DT")+"",con,dt2);
					}
				}
				else
				{

					if(PublicFunction.tinhphepnam==0)
					{					
						CalStaff(rs.record(i,"EMP_ID")+"",rs.record(i,"TYP_ID")+"",rs.record(i,"INH_DT")+"",con,dt.ToString("yyyy"),dt,false);
					}
					else
					{
						if(PublicFunction.tinhphepnam==1)
							CalStaff1(rs.record(i,"EMP_ID")+"",rs.record(i,"TYP_ID")+"",rs.record(i,"INH_DT")+"",con,dt);
					}
				}
				CalStaffDaNghi(rs.record(i,"EMP_ID")+"",con,dt,rs.record(i,"INH_DT")+"");
				lb.Text= (i+1)+"/"+rs.rows+" __ "+((int)(i+1)*100/rs.rows)+"%";
				lb2.Text= rs.record(i,"EMP_ID")+" __ "+rs.record(i,"EMP_NM");
				pro.Value=(int)(i+1)*100/rs.rows;
			}
			lb2.Text=PublicFunction.L_Get_Msg("Staff",1);
			cmd_OK.Enabled=true;
		}
		
		public static void CalStaffDaNghi(string EMP_ID,SqlConnection con,DateTime dt,string ngayvaolam)
		{
			string sql="",str="'001'";;	
			if(PublicFunction.CUS_ID=="52")//domex qn su dung 2 loai pn
				str="'001','015'";
			DateTime tam;
			tam=DateTime.Parse(ngayvaolam);	
//			if(PublicFunction.CUS_ID=="52")//domex QN su dung 2 loai PN
//				sql="(Select isnull(SUM(DAY_TT),0) from FILC04A where (LEA_ID=N'001' or LEA_ID=N'015') and EMP_ID=N'"+EMP_ID+"' and STR_DT>='"
//					+dt.ToString("yyyy")+"/01/01' and STR_DT<'"+dt.AddMonths(1).ToString("yyyy/MM")+"/01')";
//			else
//				sql="(Select isnull(SUM(DAY_TT),0) from FILC04A where LEA_ID=N'001' and EMP_ID=N'"+EMP_ID+"' and STR_DT>='"
//					+dt.ToString("yyyy")+"/01/01' and STR_DT<'"+dt.AddMonths(1).ToString("yyyy/MM")+"/01')";
			
			if(DateTime.Parse(ngayvaolam) > DateTime.Parse(dt.ToString("yyyy")+"/01/01"))
			{
				sql="(Select isnull(SUM(DAY_TT),0) from FILC04A where LEA_ID IN (" + str + ") and EMP_ID=N'"+EMP_ID+"' and STR_DT>='"
					+tam.ToString("yyyy/MM/dd")+"' and STR_DT<'"+dt.AddMonths(1).ToString("yyyy/MM")+"/01')";
			}
			else
			{
				sql="(Select isnull(SUM(DAY_TT),0) from FILC04A where LEA_ID IN (" + str + ") and EMP_ID=N'"+EMP_ID+"' and STR_DT>='"
					+dt.ToString("yyyy")+"/01/01' and STR_DT<'"+dt.AddMonths(1).ToString("yyyy/MM")+"/01')";
				//			sql="(Select isnull(SUM(DAY_TT),0) from FILC04A where LEA_ID=N'001' and EMP_ID=N'"+EMP_ID+"' and STR_DT>='"
				//				+dt.ToString("yyyy")+"/01/01' and STR_DT<'"+dt.AddYears(1).ToString("yyyy")+"/01/01')";
			}
			sql="update FILC04B set DID_QT="+sql+" where EMP_ID=N'"+EMP_ID+"' and YYY_YY=N'"+dt.ToString("yyyy")+"'";
			PublicFunction.SQL_Execute(sql,con);
		}
		public static double CalStaff_Sub(string EMP_ID,string TYP_ID,string INH_DT,SqlConnection con,string YYY,DateTime dt, Boolean nghiviec) 
		{
			
			if(DateTime.Parse(INH_DT)>=dt)
				return 0;
			string sql;
			sql="Select * from FILA11A where TYP_ID=N'"+TYP_ID+"'";
			Func.RecordSet rs=new Func.RecordSet(sql,con);
			if(rs.rows<=0) // ko co loai nhan vien 
			{
				UpdateStaff0(EMP_ID,con,YYY);
				return 0;				
			}
			int WAG_MM=T_String.IsNullTo0(rs.record(0,"WAG_MM"));
			int ngaytinh=T_String.IsNullTo0(rs.record(0,"STR_DT"));
			int phepnam=T_String.IsNullTo0(rs.record(0,"LEA_DY"));
			//if (TYP_ID== )
			float heso=(float)phepnam/12;
			DateTime dt1=  new DateTime();
			//kiem tra ngay vao lam
			if (DateTime.Parse(T_String.GetDataFromSQL("INH_DT","FILB01A","EMP_ID='"+EMP_ID+"'"))==DateTime.Parse(INH_DT))
				dt1=DateTime.Parse(INH_DT).AddMonths(WAG_MM);
				//dt1=DateTime.Parse(INH_DT);
			else
				dt1=DateTime.Parse(INH_DT);
			if (nghiviec)
			{
				if (dt.Year<T_String.GetDate(con).Year)
				{
					if(T_String.CompareDate(dt1,dt)) // ko du thoi gian lam viec de tinh phep
				
					{
						UpdateStaff0(EMP_ID,con,YYY);
						return 0;
					}
				}
				else
				{
					if(T_String.CompareDate(dt1,dt)) // ko du thoi gian lam viec de tinh phep
				
					{
						UpdateStaff0(EMP_ID,con,YYY);
						return 0;
					}
				}
			}
			else
			{
				if (dt.Year<T_String.GetDate(con).Year)
				{
					if(T_String.CompareDate(dt1,dt)) // ko du thoi gian lam viec de tinh phep
				
					{
						UpdateStaff0(EMP_ID,con,YYY);
						return 0;
					}
				}
				else
				{
					if(T_String.CompareDate(dt1,T_String.GetDate(con))) // ko du thoi gian lam viec de tinh phep
				
					{
						UpdateStaff0(EMP_ID,con,YYY);
						return 0;
					}
				}
			}
			if(T_String.CompareDate(new DateTime(dt.Year,1,1),dt1))
			{
				dt1=new DateTime(dt.Year,1,1);
				//ngaytinh=32;
			}
			double ngayphep=0,dem=0;// tinh phep nam
			if(dt1.Day<=ngaytinh)
			{			
				ngayphep+= heso;
				dem++;				
			}
			dt1=dt1.AddMonths(1);
			while (dt1.Month<=dt.Month && dt1.Year==dt.Year)//// luc truoc tinh <= nhung khuend sua lai < 
			{
				ngayphep+= heso;

				dt1=dt1.AddMonths(1);
				dem++;
			}
			if((dt.Day>=ngaytinh || DateTime.Parse(INH_DT).Year <dt.Year||ngayphep>0 ) && dt1.Month==dt.Month)
			{
				if(dem+1==12)
				{
					ngayphep=phepnam;
				}
				else
				{
					ngayphep+= heso;	
				}
				
				
			}
			string PNcalday=PublicFunction.GetOption("PNcalday");
			if(PNcalday=="1")
			{
				// DateTime dateTime = Convert.ToDateTime(vs4.Rows[i]["LAB_ED"]);
				// // dateTime=dateTime.AddDays(-1);
				// vs4.Rows[i]["LAB_ED"]=dateTime;
				int test=DateTime.Parse(INH_DT).Day;
				// string ngaytemp=Convert.ToString((test));
				ngaytinh=test;

				if (ngayphep>0 && test>15 && DateTime.Parse(INH_DT).Year ==dt.Year)/// luc truoc la the nay test>dt.Day
				{
					ngayphep=ngayphep-heso ;
				}
			}
			
			return ngayphep;			
		}

		public static void CalStaff(string EMP_ID,string TYP_ID,string INH_DT,SqlConnection con,string YYY,DateTime dt, Boolean nghiviec)
		{
			checkStaff(EMP_ID,con,YYY);
			if(INH_DT+""=="") // ko co ngay vao
			{
				UpdateStaff0(EMP_ID,con,YYY);
				return;
			}
			//LAY OPTION XEM CO TINH TRUOC PHEP NAM DEN CUOI NAM KO??
			if(T_String.IsNullTo0(PublicFunction.GetOption("ALLASTYEAR"))==1)
				if(!nghiviec)
				{
					if(PublicFunction.CUS_ID=="22")//omexey,vao lam >=1 nam moi duoc muon truoc
					{
						if(double.Parse(DateTime.Parse(INH_DT).AddYears(1).ToString("yyyyMMdd"))<= double.Parse(dt.ToString("yyyyMMdd"))) 
							dt=new DateTime(dt.Year,12,31);
					}
					else
						dt=new DateTime(dt.Year,12,31);
				}

			string sql;
			double ngayphep=0;			
			sql="Select * from FILA11A where TYP_ID=N'"+TYP_ID+"'";
			Func.RecordSet rs=new Func.RecordSet(sql,con);
			if(rs.rows<=0) // ko co loai nhan vien 
			{
				UpdateStaff0(EMP_ID,con,YYY);
				return;				
			}
			//KIEM TRA LICH SU CHUYEN LOAI NHAN VIEN
			if(PublicFunction.GetOption("TYP_BT")=="1")//quang viet
			{
				int ngaytinh=T_String.IsNullTo0(T_String.GetDataFromSQL("STR_DT","FILA11A","TYP_ID='"+TYP_ID+"'"));
				sql="SELECT * FROM FILB09A WHERE EMP_ID='"+EMP_ID+"' AND YEAR(SWI_DT)="+YYY+" ORDER BY SWI_DT";
				Func.RecordSet rs1=new Func.RecordSet(sql,con);
				if(rs1.rows>0)
				{
					string TYP_NEW="",TYP_OLD="",dt_INH="";
					DateTime dt_DT=DateTime.Parse(rs1.record(0,"SWI_DT")+"") ;
					if(dt_DT<dt)
					{
						for(int i=0;i<rs1.rows ;i++)
						{
							TYP_NEW=rs1.record(i,"TYP_I1")+"";
							TYP_OLD=rs1.record(i,"TYP_I2")+"";
							if(i==0)
								dt_INH=INH_DT;
							else
								dt_INH=DateTime.Parse(rs1.record(i-1,"SWI_DT")+"").ToString();
						
							dt_DT=DateTime.Parse(rs1.record(i,"SWI_DT")+"");
							if(dt_DT.Month>1 && dt_DT.Day>1)  dt_DT=dt_DT.AddDays(-1);
							if(dt_DT>dt)
							{
								dt_DT=dt;
								if(dt_DT.Day<ngaytinh )//neu ngay chuyen nho hon ngay tinh thi thang do ko tinh								
									if(dt_DT.Month==1)
										ngayphep+=0;
									else
										ngayphep+=CalStaff_Sub(EMP_ID,TYP_OLD,dt_INH,con,YYY,dt_DT.AddMonths(-1),nghiviec);
								else
									ngayphep+=CalStaff_Sub(EMP_ID,TYP_OLD,dt_INH,con,YYY,dt_DT,nghiviec);
								i=rs1.rows ;//ket thuc for
							}
							else
							{
								if(dt_DT.Day<ngaytinh)
									if(dt_DT.Month==1)
										ngayphep+=0;
									else
										ngayphep+=CalStaff_Sub(EMP_ID,TYP_OLD,dt_INH,con,YYY,dt_DT.AddMonths(-1),nghiviec);
										//ngayphep+=CalStaff_Sub(EMP_ID,TYP_OLD,dt_INH,con,YYY,dt_DT,nghiviec);
								else
									ngayphep+=CalStaff_Sub(EMP_ID,TYP_OLD,dt_INH,con,YYY,dt_DT,nghiviec);
								if(i==rs1.rows-1 ) //dong cuoi cung
								{
									//dt_DT=dt_DT.AddDays(1);
									if(dt_DT>dt)
									{
										i=rs1.rows;//ket thuc for
									}
									else
									{
										if(DateTime.Parse(dt_INH)<dt_DT) dt_INH=dt_DT.ToString();
										if(i+1<rs1.rows)
										{
											dt_DT=DateTime.Parse(rs1.record(i+1,"SWI_DT")+"");
											if(dt_DT>dt)
											{
												dt_DT=dt;
												i=rs1.rows ;
											}
										}
										else
											dt_DT=dt;
										ngayphep+=CalStaff_Sub(EMP_ID,TYP_NEW,dt_INH,con,YYY,dt_DT,nghiviec);
									}
								}
							}					
					
						}// end for
					}
					else
						ngayphep=CalStaff_Sub(EMP_ID,TYP_ID,INH_DT,con,YYY,dt,nghiviec);
				}
				else
				{
					ngayphep=CalStaff_Sub(EMP_ID,TYP_ID,INH_DT,con,YYY,dt,nghiviec);
				}
			}
			else
				ngayphep=CalStaff_Sub(EMP_ID,TYP_ID,INH_DT,con,YYY,dt,nghiviec);
			//truong hop nghi viec
			if(nghiviec)
			{
				if(PublicFunction.CUS_ID=="52")//domex quang nam
				{
					DateTime dtoff=DateTime.Parse(T_String.GetDataFromSQL("VAC_DT","FILB01AC","EMP_ID='"+EMP_ID+"'"));
					if(dtoff.Day<16) ngayphep=ngayphep-(float)T_String.IsNullTo0(rs.record(0,"LEA_DY"))/12;
					if(dtoff.Day>=16 && dtoff.Day <=24) ngayphep=ngayphep-((float)T_String.IsNullTo0(rs.record(0,"LEA_DY"))/12)*0.5;
					if(dtoff.Day>24) ngayphep=ngayphep;
				}
			}					
			//end nghi viec
			// tinh tham nien
			int thamnien=0;
			DateTime dt1=DateTime.Parse(INH_DT);
			int sonam=T_String.IsNullTo0(rs.record(0,"SEN_YY"));
			int songay=T_String.IsNullTo0(rs.record(0,"SEN_DY"));
			if(sonam!=0 && songay!=0)
			{
				while(true)
				{
					dt1=dt1.AddYears(sonam);
					if(T_String.CompareDate(dt,dt1))
						thamnien+=songay;
					else
						break;
				}
			}
			//NEU OPTION WAGMM_BT=1-> TINH LUON NHUNG THANG KHOI TINH KHI DU DK TINH PHEP NAM
			if(PublicFunction.GetOption("WAGMM_BT")=="1" && DateTime.Parse(INH_DT).Year ==dt.Year )
			{
				ngayphep=ngayphep+T_String.IsNullTo0(rs.record(0,"WAG_MM"))*(float)T_String.IsNullTo0(rs.record(0,"LEA_DY"))/12; ;
			}			//END
			if (PublicFunction.CUS_ID=="51"  )//cong ty Quang viet TG
			{
				ngayphep=Math.Floor(Math.Round(ngayphep,1)); //Math.Round(ngayphep,2);
			}
			else if(PublicFunction.CUS_ID=="50")//QV Cu Chi
			{
				ngayphep=Math.Round(ngayphep,1);
				if (ngayphep-Math.Floor(ngayphep)<0.5)
					ngayphep=Math.Floor(ngayphep);
				else 
					ngayphep=Math.Floor(ngayphep)+1;
			}
			else
			{
				if(PublicFunction.CUS_ID=="62")//DOMEX
				{
					ngayphep=Math.Round(ngayphep,1);
					if (ngayphep-Math.Floor(ngayphep)<=0.4)
						ngayphep=Math.Floor(ngayphep);
					else 
						ngayphep=Math.Floor(ngayphep)+1;
				}
				else
				{
					if (ngayphep-Math.Floor(ngayphep)>0.49 && (ngayphep-Math.Floor(ngayphep)<0.99))
						//ngayphep=Math.Floor(ngayphep)+0.5;
						ngayphep=ngayphep;
					else if (ngayphep-Math.Floor(ngayphep)>=0.99)
						//ngayphep=Math.Floor(ngayphep)+1;
						ngayphep=ngayphep;
					else
						ngayphep=ngayphep;
				}
			}
//			//if (PublicFunction.CUS_ID=="300")//cong ty KenYa
//			if (ngayphep-Math.Floor(ngayphep)>0.49 && (ngayphep-Math.Floor(ngayphep)<0.99))
//				ngayphep=Math.Floor(ngayphep)+0.5;
//			else if (ngayphep-Math.Floor(ngayphep)>=0.99)
//				ngayphep=Math.Floor(ngayphep)+1;
//			else
//				ngayphep=Math.Floor(ngayphep);
//======== THU SUA PHEP NAM TINH THEO LICH SU THAY DOI LOAI NHAN VIEN END=========
			sql="update FILC04B set HAV_QT="+ngayphep+",ADD_QT="+thamnien+" where EMP_ID=N'"+EMP_ID+"' and YYY_YY=N'"+dt.ToString("yyyy")+"'";
			PublicFunction.SQL_Execute(sql,con);	
			
		}
	// Dau nam tinh duoc ngay phep 1 nam
		public static void CalStaff1(string EMP_ID,string TYP_ID,string INH_DT,SqlConnection con,DateTime dt)
		{
			checkStaff(EMP_ID,con,dt.ToString("yyyy"));
			if(INH_DT+""=="") // ko co ngay vao
			{
				UpdateStaff0(EMP_ID,con,dt.ToString("yyyy"));
				return;
			}
			string sql;
			sql="Select * from FILA11A where TYP_ID=N'"+TYP_ID+"'";
			Func.RecordSet rs=new Func.RecordSet(sql,con);
			if(rs.rows<=0) // ko co loai nhan vien 
			{
				UpdateStaff0(EMP_ID,con,dt.ToString("yyyy"));
				return;				
			}
			int WAG_MM=T_String.IsNullTo0(rs.record(0,"WAG_MM"));
			int ngaytinh=T_String.IsNullTo0(rs.record(0,"STR_DT"));
			int phepnam=T_String.IsNullTo0(rs.record(0,"LEA_DY"));
			int heso=(int)phepnam/12;
			DateTime dt1=DateTime.Parse(INH_DT).AddMonths(WAG_MM);
			if(T_String.CompareDate(dt1,dt)) // ko du thoi gian lam viec de tinh phep
			{
				UpdateStaff0(EMP_ID,con,dt.ToString("yyyy"));
				return;
			}
			if(T_String.CompareDate(new DateTime(dt.Year,1,1),dt1))
				dt1=new DateTime(dt.Year,1,1);
//			else
//			{
//				phepnam=(int)DateAndTime.DateDiff( DateInterval.Month,dt1 , DateAndTime.DateSerial(dt.Year,12,31),FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
//				if (phepnam<0)
//					phepnam=0;
//			}
					
					//new TimeSpan(DateAndTime.DateSerial(dt.Year,12,31).Ticks  - dt1.Ticks).mon
					//DateAndTime.DateDiff( DateInterval.Month , DateAndTime.DateSerial(dt.Year,12,31),dt1);
			int ngayphep=0;// tinh phep nam
			ngayphep=phepnam;
//			if(dt1.Day<=ngaytinh)
//			{			
//				ngayphep+= heso;
//				dem++;				
//			}
//			dt1=dt1.AddMonths(1);
//			while (dt1.Month<dt.Month)
//			{
//				ngayphep+= heso;
//				dt1=dt1.AddMonths(1);
//				dem++;
//			}
//			if(dt.Day>=ngaytinh && dt1.Month==dt.Month)
//			{
//				if(dem+1==12)
//				{
//					ngayphep=phepnam;
//				}
//				else
//				{
//					ngayphep+= heso;	
//				}
//
//			}
			// tinh tham nien
			long thamnien=0;
			dt1=DateTime.Parse(INH_DT);
			int sonam=T_String.IsNullTo0(rs.record(0,"SEN_YY"));
			int songay=T_String.IsNullTo0(rs.record(0,"SEN_DY"));
			thamnien=DateAndTime.DateDiff(DateInterval.Year ,dt1,dt,FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
			thamnien=thamnien/5;
//			if(sonam!=0 && songay!=0)
//			{
//				while(true)
//				{
//					dt1=dt1.AddYears(sonam);
//					if(T_String.CompareDate(dt,dt1))
//						thamnien+=songay;
//					else
//						break;
//				}
//			}

			sql="update FILC04B set HAV_QT="+ngayphep+",ADD_QT="+thamnien+" where EMP_ID=N'"+EMP_ID+"' and YYY_YY=N'"+dt.ToString("yyyy")+"'";
			PublicFunction.SQL_Execute(sql,con);
//			sql="update FILC04B set DID_QT=(select SUM(DAY_TT) from FILC04A where  EMP_ID=N'"+EMP_ID+"' "
//				+")where EMP_ID=N'"+EMP_ID+"' and YYY_YY=N'"+dt.ToString("yyyy")+"'";
//			PublicFunction.SQL_Execute(sql,con);
			
		}
		#endregion		
		#region Fun
		public static void UpdateStaff0(string EMP_ID,SqlConnection con,string YYY)
		{
			string sql="update FILC04B set HAV_QT="+0+",ADD_QT=0 where EMP_ID=N'"+EMP_ID+"' and YYY_YY=N'"+YYY+"'";
			PublicFunction.SQL_Execute(sql,con);
		}

		public static void checkStaff(string EMP_ID,SqlConnection con,string YYY)
		{			
			if(T_String.IsNullTo0(T_String.GetDataFromSQL("Count(*)","FILC04B","EMP_ID=N'"+EMP_ID+"' and YYY_YY=N'"+YYY+"'"))<=0)
			{
				string sql="";
				sql="Insert Into FILC04B(YYY_YY,EMP_ID,BLT_NM,BLT_DT) values (N'"
					+YYY+"',N'"+EMP_ID+"',N'"+PublicFunction.A_UserID+"','"+T_String.GetDate(con).ToString("yyyy/MM/dd HH:mm")+"')";
				PublicFunction.SQL_Execute(sql,con);
			}
		}

		private void frmTaCalAnnualLeave_Closed(object sender, EventArgs e)
		{
			stop=true;
		}
		#endregion
	}
}

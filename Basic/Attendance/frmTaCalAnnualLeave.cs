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
		private int Op_Tinh;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaCalAnnualLeave(DateTime dtt,Int32 tinh)
		{
			if(dtt.Year<T_String.GetDate().Year)	
			{
				dt=new DateTime(dtt.Year+1,1,1) ;
				dt=dt.AddDays(-1);
			}
			else
				dt=T_String.GetDate();
			Op_Tinh=tinh;
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
			//label5.Text=label5.Text+"-"+dt.Year.ToString("0000");			
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
		private void Cal()
		{
			//dt=T_String.GetDate();			
			DateTime da;
			da=dt;

			string nghiviec;
			lb.Text= "";
			lb2.Text= "";
			cmd_OK.Enabled=false;
			SqlConnection con=new SqlConnection(PublicFunction.C_con.ConnectionString);
			con.Open();
			string str="delete from FILC04B where EMP_ID IN (Select EMP_ID from FILB01A where year(INH_DT)>'"+dt.Year+"') and YYY_YY=N'"+dt.ToString("yyyy")+"'";
			PublicFunction.SQL_Execute(str,con);
			string sql="Select a.EMP_ID,EMP_NM,TYP_ID,INH_DT from FILB01A a left join FILB01AC b on a.EMP_ID=b.EMP_ID";
			
			if (Op_Tinh==1) //con lam
			{
				sql+=" where "+control1.GetWhere1("").Replace("EMP_ID", "a.EMP_ID");
				sql+=" and (VAC_BT=0 or VAC_BT is null)"; 				
			}
			else if(Op_Tinh==2) // nghi viec
			{
				sql+=" where "+control1.GetWhere1("").Replace("EMP_ID", "a.EMP_ID");
				sql+=" and (VAC_BT=1 and year(VAC_DT)='"+dt.Year+"')"; 
			}
			else //tat ca
			{
				sql+=" where "+control1.GetWhere1("").Replace("EMP_ID", "a.EMP_ID");
				sql+=" and ((VAC_BT=0 or VAC_BT is null) or (VAC_BT=1 and year(VAC_DT)='"+dt.Year+"'))"; 
			}

			sql+=" and year(INH_DT)<='"+dt.Year+"'";
			Func.RecordSet rs=new Func.RecordSet(sql,con);
			for(int i=0;i<rs.rows;i++)
			{
				if(stop)
				{
					return;
				}
				dt=da;
				if(PublicFunction.tinhphepnam==0)
				{
					nghiviec=T_String.GetDataFromSQL("VAC_BT","FILB01A","EMP_ID='"+rs.record(i,"EMP_ID")+"'");
					if (nghiviec=="True")
						dt=DateTime.Parse(T_String.GetDataFromSQL("VAC_DT","FILB01AC","EMP_ID='"+rs.record(i,"EMP_ID")+"'"));
					CalStaff(rs.record(i,"EMP_ID")+"",rs.record(i,"TYP_ID")+"",rs.record(i,"INH_DT")+"",con,dt.ToString("yyyy"),dt);
				}
				else
				{
					nghiviec=T_String.GetDataFromSQL("VAC_BT","FILB01A","EMP_ID='"+rs.record(i,"EMP_ID")+"'");
					if (nghiviec=="True")
						dt=DateTime.Parse(T_String.GetDataFromSQL("VAC_DT","FILB01AC","EMP_ID='"+rs.record(i,"EMP_ID")+"'"));

					if(PublicFunction.tinhphepnam==1)
						CalStaff1(rs.record(i,"EMP_ID")+"",rs.record(i,"TYP_ID")+"",rs.record(i,"INH_DT")+"",con,dt);
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
			string sql="";		
			DateTime tam;
			tam=DateTime.Parse(ngayvaolam);
			if(DateTime.Parse(ngayvaolam) > DateTime.Parse(dt.ToString("yyyy")+"/01/01"))
			{
				sql="(Select isnull(SUM(DAY_TT),0) from FILC04A where LEA_ID=N'001' and EMP_ID=N'"+EMP_ID+"' and STR_DT>='"
					+tam.ToString("yyyy/MM/dd")+"' and STR_DT<'"+dt.AddMonths(1).ToString("yyyy/MM")+"/01')";
			}
			else
			{
				sql="(Select isnull(SUM(DAY_TT),0) from FILC04A where LEA_ID=N'001' and EMP_ID=N'"+EMP_ID+"' and STR_DT>='"
					+dt.ToString("yyyy")+"/01/01' and STR_DT<'"+dt.AddMonths(1).ToString("yyyy/MM")+"/01')";
				//			sql="(Select isnull(SUM(DAY_TT),0) from FILC04A where LEA_ID=N'001' and EMP_ID=N'"+EMP_ID+"' and STR_DT>='"
				//				+dt.ToString("yyyy")+"/01/01' and STR_DT<'"+dt.AddYears(1).ToString("yyyy")+"/01/01')";
			}
			sql="update FILC04B set DID_QT="+sql+" where EMP_ID=N'"+EMP_ID+"' and YYY_YY=N'"+dt.ToString("yyyy")+"'";
			PublicFunction.SQL_Execute(sql,con);
		}
		#region basic
/*		public static void CalStaff(string EMP_ID,string TYP_ID,string INH_DT,SqlConnection con,string YYY,DateTime dt)
		{
			checkStaff(EMP_ID,con,YYY);
			if(INH_DT+""=="") // ko co ngay vao
			{
				UpdateStaff0(EMP_ID,con,YYY);
				return;
			}
			string sql;
			sql="Select * from FILA11A where TYP_ID=N'"+TYP_ID+"'";
			Func.RecordSet rs=new Func.RecordSet(sql,con);
			if(rs.rows<=0) // ko co loai nhan vien 
			{
				UpdateStaff0(EMP_ID,con,YYY);
				return;				
			}
			int WAG_MM=T_String.IsNullTo0(rs.record(0,"WAG_MM"));
			int ngaytinh=T_String.IsNullTo0(rs.record(0,"STR_DT"));
			int phepnam=T_String.IsNullTo0(rs.record(0,"LEA_DY"));
			int heso=(int)phepnam/12;
			DateTime dt1=DateTime.Parse(INH_DT).AddMonths(WAG_MM);
			//if(T_String.CompareDate(dt1,T_String.GetDate(con))) // ko du thoi gian lam viec de tinh phep
			if(T_String.CompareDate(dt1,dt))
			{
				UpdateStaff0(EMP_ID,con,YYY);
				return;
			}
			if(T_String.CompareDate(new DateTime(dt.Year,1,1),dt1))
				dt1=new DateTime(dt.Year,1,1);
			int ngayphep=0,dem=0;// tinh phep nam
			if(dt1.Day<=ngaytinh)
			{			
				ngayphep+= heso;
				dem++;				
			}
			dt1=dt1.AddMonths(1);
			while (dt1.Month<dt.Month && dt1.Year==dt.Year)
			{
				ngayphep+= heso;
				dt1=dt1.AddMonths(1);
				dem++;
			}
			if(dt.Day>=ngaytinh && dt1.Month==dt.Month)
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
			// tinh tham nien
			int thamnien=0;
			dt1=DateTime.Parse(INH_DT);
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

			sql="update FILC04B set HAV_QT="+ngayphep+",ADD_QT="+thamnien+" where EMP_ID=N'"+EMP_ID+"' and YYY_YY=N'"+dt.ToString("yyyy")+"'";
			PublicFunction.SQL_Execute(sql,con);		
		}
*/		
		#endregion
		public static void CalStaff(string EMP_ID,string TYP_ID,string INH_DT,SqlConnection con,string YYY,DateTime dt)
		{
			checkStaff(EMP_ID,con,YYY);

			if(INH_DT+""=="") // ko co ngay vao
			{
				UpdateStaff0(EMP_ID,con,YYY);
				return;
			}
			string sql;
			sql="Select * from FILA11A where TYP_ID=N'"+TYP_ID+"'";
			Func.RecordSet rs=new Func.RecordSet(sql,con);
			if(rs.rows<=0) // ko co loai nhan vien 
			{
				UpdateStaff0(EMP_ID,con,YYY);
				return;				
			}
			int WAG_MM=T_String.IsNullTo0(rs.record(0,"WAG_MM"));
			int ngaytinh=T_String.IsNullTo0(rs.record(0,"STR_DT"));
			
//			//////////////kien
			string PNcalday=PublicFunction.GetOption("PNcalday");
			////kien cho phep sua trung ma bo phan
			if(PNcalday=="1")
			{
				int test=DateTime.Parse(INH_DT).Day;
				// string ngaytemp=Convert.ToString((test));				    
				ngaytinh=test;
			}
			int phepnam=T_String.IsNullTo0(rs.record(0,"LEA_DY"));
			int heso=(int)phepnam/12;
			DateTime dt1=DateTime.Parse(INH_DT).AddMonths(WAG_MM);

			if (dt.Year<T_String.GetDate(con).Year)
			{
				if(T_String.CompareDate(dt1,dt)) // ko du thoi gian lam viec de tinh phep				
				{
					UpdateStaff0(EMP_ID,con,YYY);
					return;
				}
			}
			else
			{
				if(T_String.CompareDate(dt1,T_String.GetDate(con))) // ko du thoi gian lam viec de tinh phep				
				{
					UpdateStaff0(EMP_ID,con,YYY);
					return;
				}
			}
			/// khuend them vao de nhan biet nguoi cu tinh tu thang 1
			/// 
			if(T_String.CompareDate(new DateTime(dt.Year,1,1),dt1))
			{
				dt1=new DateTime(dt.Year,1,1);
			}
			int ngayphep=0,dem=0;// tinh phep nam
			Decimal ngayphep1=0;
			//////////////////////////////////////Kien tinh so ngay toi thoi diem hien tai hoa toi nghi viec/////////////////////////////////////////
			while (dt1.Month<=dt.Month && dt1.Year==dt.Year)
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
			//////////////kien phep nam tinh ngay
			////string PNcalday=PublicFunction.GetOption("PNcalday");
			////kien cho phep sua trung ma bo phan
			if(PNcalday=="1")
			{
				int test=DateTime.Parse(INH_DT).Day;
				ngaytinh=test;
			}
			//////////////////////kien ket thuc phep nam tinh ngay 
			//moi thang duoc 1 ngay phep nam ,neu cong nhan 14 du 1 nam se duoc cong 2 ngay, nguoc lai thi moi thang duoc 1 ngay
			string ALEtop=PublicFunction.GetOption("ALEtop");
			string ALAngelbell=PublicFunction.GetOption("ALAngelbell");
			if(ALEtop=="1" || ALAngelbell=="1")
			{
				if (phepnam==14 && T_String.GetDate(con).Month==12)
				{
					DateTime dateTime = Convert.ToDateTime(T_String.GetDate(con));
					DateTime temp=Convert.ToDateTime(INH_DT);
					temp=temp.AddYears(+1);
					if (temp<=dateTime)
					{
						ngayphep=ngayphep+2;
					}
					else
					{

					}
				}
				else
				{
					//ngayphep=T_String.GetDate(con).Month;
				}

				if (ALEtop=="1")
				{
					if (dt1.Day>T_String.GetDate(con).Day)
					{
						ngayphep=ngayphep-1 ;
					}
				}

				if (ALAngelbell=="1")
				{
					if (DateTime.Parse(INH_DT).Year ==T_String.GetDate(con).Year)
					{
						ngayphep=0 ;
					}
					if (DateTime.Parse(INH_DT).Year+1==T_String.GetDate(con).Year)
					{						
						ngayphep=ngayphep+phepnam -DateTime.Parse(INH_DT).Month ;
					}
					if (DateTime.Parse(INH_DT).Year+1==T_String.GetDate(con).Year && DateTime.Parse(INH_DT).Month>T_String.GetDate(con).Month)
					{						
						ngayphep=0 ;
					}
				}
			}

			if (PublicFunction.CUS_ID=="22")
			{
				dt1=DateTime.Parse(INH_DT);
				if ((dt1.Day>15 ) && (dt1.Year==dt.Year))
				{
					if(ngayphep!=0)
						ngayphep-=1;
				}			
			}
			
			// tinh tham nien
			int thamnien=0;
			dt1=DateTime.Parse(INH_DT);
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

			//luan sua de tinh ngay vao 15
			DateTime  dtResult = dt;
			
			if (dt.Day < 15  && ngayphep>0)
			{
				ngayphep=ngayphep-1;
			}

			ngayphep1=ngayphep;
				
		    if (phepnam==14)
			{
				//Math.Round(Convert.ToDecimal(temp), 4)
				ngayphep1=ngayphep1*Math.Round(Convert.ToDecimal(14/12.0), 2); //ngayphep1*Math.Round(Convert.ToDecimal(14/12.0), 2);
				if(ngayphep1>14)
					ngayphep1=14;
			}
			//nhieu loai nhan vien 
			if (T_String.IsNullTo0(T_String.GetDataFromSQL("Count(*)","FILB02AA","year(SEQ_DT)='"+dt.ToString("yyyy")+"' and EMP_ID='"+EMP_ID+"'"))>0)
			{
				ngayphep1=0;
				dt1=DateTime.Parse(INH_DT);
				if(dt1.Year<T_String.GetDate(con).Year)
				{
					//dt1=T_String.DT_GetDays(DateTime.Parse(T_String.GetDate(con).Year + "/01/01"),T_String.GetDate(con));
					dt1=Convert.ToDateTime((T_String.GetDate(con).Year + "/01/01"));
					//ngayk2=T_String.DT_GetDays(Convert.ToDateTime(INH_DT),T_String.GetDate(con));
				}

				string sqlkk="Select * from FILB02AA where EMP_ID='"+EMP_ID+"' order by SEQ_DT";
				Func.RecordSet rsk=new Func.RecordSet(sqlkk,con);
				for (int k=0;k<rsk.rows;k++)
				{	
					dt=Convert.ToDateTime(rsk.record(k,"SEQ_DT"));
					while (dt1.Month<dt.Month && dt1.Year==dt.Year)
					{						
						dt1=dt1.AddMonths(1);
                        string TYP_IDt=rsk.record(k,"TYP_ID"); 
						string ngay=T_String.GetDataFromSQL("LEA_DY","FILA11A","TYP_ID='"+TYP_IDt+"'");
						if (ngay=="14")
						{
							ngayphep1+= Math.Round(Convert.ToDecimal(14/12.0), 2); //Convert.ToDecimal(14/12.0); //Math.Round(Convert.ToDecimal(14/12.0), 2);
						}
						else
						{
							ngayphep1+= 1;
						}
					}
				    DateTime dtt=Convert.ToDateTime(rsk.record(rsk.rows-1,"SEQ_DT"));
					DateTime monthtt=T_String.GetDate(con);

					string vacate=T_String.GetDataFromSQL("VAC_BT","FILB01A","EMP_ID='"+EMP_ID+"'");
					//DateTime vacate_date;
					if (vacate=="True")
					{
						monthtt=DateTime.Parse(T_String.GetDataFromSQL("VAC_DT","FILB01AC","EMP_ID='"+EMP_ID+"'"));
					}
					while (dtt.Month<=monthtt.Month && dtt.Year==T_String.GetDate(con).Year && k==rsk.rows-1)
					{						
						dtt=dtt.AddMonths(1);
						string TYP_IDtt=rsk.record(k,"TYP_I1"); 
						string ngayt=T_String.GetDataFromSQL("LEA_DY","FILA11A","TYP_ID='"+TYP_IDtt+"'");
						if (ngayt=="14")
						{
							ngayphep1+= Math.Round(Convert.ToDecimal(14/12.0), 2);
						}
						else
						{
							ngayphep1+= 1;
						}
					}
				}
			}
			Decimal ngayphep2=0;
			if(PublicFunction.CUS_ID=="22")//Rehong
			{
				ngayphep2=Math.Round(Convert.ToDecimal(ngayphep1),2);
				if (ngayphep1- Decimal.Floor(ngayphep1)> (Decimal)0.5000)
					ngayphep2=Decimal.Floor(ngayphep1)+1; 
			}
			
//			///////doi voi nv chua lam du 1 thang da nghi/////////////
			string nghiviec=T_String.GetDataFromSQL("VAC_BT","FILB01A","EMP_ID='"+EMP_ID+"'");
			if(nghiviec=="True")
			{
				DateTime ngayvao=DateTime.Parse(INH_DT);
				DateTime ngaynghi=DateTime.Parse(T_String.GetDataFromSQL("VAC_DT","FILB01AC","EMP_ID='"+EMP_ID+"'"));
				TimeSpan m=ngaynghi.Subtract(ngayvao);
				int thang=m.Days;
				if(thang/30<=1)
				{
					ngayphep1=0;
					ngayphep2=0;
				}
			}
			////////////////////////////
			sql="update FILC04B set HAV_QT="+ngayphep1+",ADD_QT="+thamnien+",TLCN="+ngayphep2+" where EMP_ID=N'"+EMP_ID+"' and YYY_YY=N'"+dt.ToString("yyyy")+"'";
			PublicFunction.SQL_Execute(sql,con);		
		}
		#endregion
		#region tinh PN den cuoi nam
		/// <summary>
		/// Tinh phep den cuoi nam  2016-05-21
		/// </summary>
		/// <param name="EMP_ID"></param>
		/// <param name="TYP_ID"></param>
		/// <param name="INH_DT"></param>
		/// <param name="con"></param>
		/// <param name="dt"></param>
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
			int Loainhanvien=T_String.IsNullTo0(rs.record(0,"LEA_DY"));
			int heso=(int)phepnam/12;
			DateTime dt1=DateTime.Parse(INH_DT).AddMonths(WAG_MM);
			if(T_String.CompareDate(dt1,dt)) // ko du thoi gian lam viec de tinh phep
			{
				UpdateStaff0(EMP_ID,con,dt.ToString("yyyy"));
				return;
			}
			if(T_String.CompareDate(new DateTime(dt.Year,1,1),dt1))
				dt1=new DateTime(dt.Year,1,1);
			
			int ngayphep=0;// tinh phep nam
			Decimal ngayphep1=0;
             

			if (dt1.Year==T_String.GetDate(con).Year)
			{
				ngayphep=phepnam-((int) dt1.Month) + 1;
			}
			else
			{
				ngayphep=phepnam;
			}

			//Kien phep nam Cheng long [PNchenglong]=1
			string PNchenglong=PublicFunction.GetOption("PNchenglong");
			string ALEtop=PublicFunction.GetOption("ALEtop");
			
			if(PNchenglong=="1" || ALEtop=="1")
			{
				if (DateTime.Parse(INH_DT).Year==T_String.GetDate(con).Year)
				{
					ngayphep=T_String.GetDate(con
						).Month-((int) dt1.Month);
					if (dt1.Day<=ngaytinh)
					{
						ngayphep=T_String.GetDate(con
							).Month-((int) dt1.Month);
					}
					else
					{
						if (dt1.Day>ngaytinh)
						{
							ngayphep=T_String.GetDate(con
								).Month-((int) dt1.Month)-1 ;
						}
						// tinh theo ngay neu ngay vao lam nho hon ngay he thong thi thang do khong tinh
						if (ALEtop=="1")
						{
							if (dt1.Day>T_String.GetDate(con).Day)
							{
								ngayphep=ngayphep-1 ;
							}
						}
					}
				}
				else
				{
					if (phepnam==14 && T_String.GetDate(con).Month==12)
					{
						ngayphep=T_String.GetDate(con).Month+2;
					}
					else
					{
						ngayphep=T_String.GetDate(con).Month;
					}
				}
			}

			///ket thuc cheng long
			string vacate=T_String.GetDataFromSQL("VAC_BT","FILB01A","EMP_ID='"+EMP_ID+"'");
			DateTime vacate_date;
			if (vacate=="True")
			{
				vacate_date=DateTime.Parse(T_String.GetDataFromSQL("VAC_DT","FILB01AC","EMP_ID='"+EMP_ID+"'"));
				if (vacate_date.Year==T_String.GetDate(con).Year)
				{
					if (dt1.Year==vacate_date.Year)
					{		
						ngayphep=((int) vacate_date.Month) - ((int) dt1.Month) +1;
					}
					else
					{
						ngayphep=((int) vacate_date.Month);
					}
				}
			}

            //phep nam esprinta  
			string filePath = PublicFunction.Path  + "/Esprinta.dll";

			// tinh tham nien
			int thamnien=0;
			Double thamnien1=0;
			DateTime dtk=DateTime.Parse(INH_DT);
			dt1=DateTime.Parse(INH_DT);
			int sonam=T_String.IsNullTo0(rs.record(0,"SEN_YY"));
			int songay=T_String.IsNullTo0(rs.record(0,"SEN_DY"));			
			filePath = PublicFunction.Path  + "/Esprinta.dll";
			if (System.IO.File.Exists(filePath))
			{
				if(sonam!=0 && songay!=0)
				{
					while(true)
					{						
						dt1=dt1.AddYears(sonam);
						dtk=dtk.AddYears(sonam-1);
						if(T_String.CompareDate(T_String.GetDate(con),dt1))
							thamnien1+=songay;
						else
						{	
							//dateTime1=dateTime1.AddDays(+1);
							//int ngayk1=T_String.DT_GetDays(DateTime.Parse(T_String.GetDate(con).Year + "/01/01"),T_String.GetDate(con));
							//DateTime dateTime10 = DateTime.Parse(T_String.GetDate(con).Year + "/" + Convert.ToDateTime(INH_DT).Month + "/" + Convert.ToDateTime(INH_DT).Day);//Convert.ToDateTime(INH_DT);
							DateTime dateTime10 = Convert.ToDateTime(INH_DT);
							//dateTime10 = dateTime10.AddYears(+5);
							dateTime10 = dateTime10.AddDays(+1826);
							//DateTime dateTime1 = Convert.ToDateTime(INH_DT);//Convert.ToDateTime(INH_DT);
							
							int ngaytest= 0;
							//T_String.DT_GetDays1(dateTime1,T_String.GetDate(con));
							ngaytest=T_String.DT_GetDays(dateTime10,T_String.GetDate(con));	
							if(T_String.CompareDate(T_String.GetDate(con),dtk))
							{	
								thamnien1+=0.00273972602739726 * T_String.DT_GetDays(dateTime10,T_String.GetDate(con));
								break;
							}
						}
					}
				}
			}
			else
			{
				if(sonam!=0 && songay!=0)
				{
					while(true)
					{
						dt1=dt1.AddYears(sonam);
						if(T_String.CompareDate(DateTime.Parse(dt.Year+"/12/31"),dt1))
							thamnien+=songay;
						else
							break;
					}
				}
			}
			if (System.IO.File.Exists(filePath))
			{
				sql="update FILC04B set HAV_QT="+ngayphep1+" where EMP_ID=N'"+EMP_ID+"' and YYY_YY=N'"+dt.ToString("yyyy")+"' and (nature='' or nature is null)";
				PublicFunction.SQL_Execute(sql,con);

				sql="update FILC04B set ADD_QT="+thamnien1+" where EMP_ID=N'"+EMP_ID+"' and YYY_YY=N'"+dt.ToString("yyyy")+"'";
				PublicFunction.SQL_Execute(sql,con);

			}
			else
			{
				sql="update FILC04B set HAV_QT="+ngayphep+" where EMP_ID=N'"+EMP_ID+"' and YYY_YY=N'"+dt.ToString("yyyy")+"' and (nature='' or nature is null)";
				PublicFunction.SQL_Execute(sql,con);

				sql="update FILC04B set ADD_QT="+thamnien+" where EMP_ID=N'"+EMP_ID+"' and YYY_YY=N'"+dt.ToString("yyyy")+"'";
				PublicFunction.SQL_Execute(sql,con);
			}
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

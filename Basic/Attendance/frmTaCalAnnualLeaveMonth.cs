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
	public class frmTaCalAnnualLeaveMonth : System.Windows.Forms.Form
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
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private C1.Win.C1Input.C1DateEdit dtpto;
		private C1.Win.C1Input.C1DateEdit dtpfrom;			
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaCalAnnualLeaveMonth(DateTime dtt)
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
			this.dtpto = new C1.Win.C1Input.C1DateEdit();
			this.dtpfrom = new C1.Win.C1Input.C1DateEdit();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtpto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtpfrom)).BeginInit();
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
			this.control1.Location = new System.Drawing.Point(0, 71);
			this.control1.Name = "control1";
			this.control1.Size = new System.Drawing.Size(444, 164);
			this.control1.TabIndex = 6;
			// 
			// cmd_close
			// 
			this.cmd_close.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_close.Location = new System.Drawing.Point(261, 299);
			this.cmd_close.Name = "cmd_close";
			this.cmd_close.Size = new System.Drawing.Size(116, 36);
			this.cmd_close.TabIndex = 27;
			this.cmd_close.Text = "Close";
			this.cmd_close.Click += new System.EventHandler(this.cmd_close_Click);
			// 
			// cmd_OK
			// 
			this.cmd_OK.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_OK.Location = new System.Drawing.Point(69, 299);
			this.cmd_OK.Name = "cmd_OK";
			this.cmd_OK.Size = new System.Drawing.Size(116, 36);
			this.cmd_OK.TabIndex = 26;
			this.cmd_OK.Text = "OK";
			this.cmd_OK.Click += new System.EventHandler(this.cmd_OK_Click);
			// 
			// pro
			// 
			this.pro.Location = new System.Drawing.Point(4, 235);
			this.pro.Name = "pro";
			this.pro.Size = new System.Drawing.Size(436, 16);
			this.pro.TabIndex = 28;
			// 
			// lb
			// 
			this.lb.BackColor = System.Drawing.Color.Black;
			this.lb.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lb.ForeColor = System.Drawing.Color.White;
			this.lb.Location = new System.Drawing.Point(4, 251);
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
			this.lb2.Location = new System.Drawing.Point(4, 271);
			this.lb2.Name = "lb2";
			this.lb2.Size = new System.Drawing.Size(436, 23);
			this.lb2.TabIndex = 30;
			this.lb2.Tag = "N";
			this.lb2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dtpto
			// 
			this.dtpto.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dtpto.Location = new System.Drawing.Point(311, 39);
			this.dtpto.Name = "dtpto";
			this.dtpto.Size = new System.Drawing.Size(132, 23);
			this.dtpto.TabIndex = 154;
			this.dtpto.Tag = null;
			// 
			// dtpfrom
			// 
			this.dtpfrom.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dtpfrom.Location = new System.Drawing.Point(88, 39);
			this.dtpfrom.Name = "dtpfrom";
			this.dtpfrom.Size = new System.Drawing.Size(132, 23);
			this.dtpfrom.TabIndex = 153;
			this.dtpfrom.Tag = null;
			this.dtpfrom.TextChanged += new System.EventHandler(this.dtpfrom_TextChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(4, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 23);
			this.label1.TabIndex = 152;
			this.label1.Tag = "label1";
			this.label1.Text = "label1";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(227, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 23);
			this.label2.TabIndex = 155;
			this.label2.Tag = "label2";
			this.label2.Text = "label2";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// frmTaCalAnnualLeaveMonth
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(446, 344);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dtpto);
			this.Controls.Add(this.dtpfrom);
			this.Controls.Add(this.label2);
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
			this.Name = "frmTaCalAnnualLeaveMonth";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmTaCalAnnualLeave";
			this.Load += new System.EventHandler(this.frmTaCalAnnualLeave_Load);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dtpto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtpfrom)).EndInit();
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

			//DateTime dt=T_String.GetDate();
			dtpfrom.Value=dt;	
			dtpto.Value=dt;	
			dtpfrom.CustomFormat=dtpto.CustomFormat="yyyyMM";		
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
			lb.Text= "";
			lb2.Text= "";
			cmd_OK.Enabled=false;
			SqlConnection con=new SqlConnection(PublicFunction.C_con.ConnectionString);
			con.Open();
			//Tinh phep nam tu thang den thang
			DateTime fromdate=(DateTime)dtpfrom.Value;
			DateTime todate=(DateTime)dtpto.Value;
			while(T_String.IsNullTo0(fromdate.ToString("yyyyMM"))<=T_String.IsNullTo0(todate.ToString("yyyyMM")))// tung Ngay
			{
				string str="delete FILC04C from FILC04C LEFT OUTER JOIN FILB01A ON FILB01A.EMP_ID=FILC04C.EMP_ID";
				str+=" LEFT OUTER JOIN FILB01AC ON FILB01A.EMP_ID=FILB01AC.EMP_ID";
				str+=" where ((VAC_BT=0 or VAC_BT is null) or (VAC_BT=1 and VAC_DT>='"+ fromdate.ToString("yyyy/MM") +"/01'))";
				str+=" and YYY_YY=N'"+fromdate.ToString("yyyyMM")+"' and "+control1.GetWhere("",false);
				PublicFunction.SQL_Execute(str,con);
				//Kiem tra thu tinh dua vao ngay vao lam hay ngay hop dong

				string sql="Select FILB01A.EMP_ID,EMP_NM,FILB01A.TYP_ID,INH_DT,LAB_NO,LAB_ST,LAB_ED,LAB_TM,";
				sql+="LEA_DY,NEW_OD,STR_DT,WAG_MM,SEN_YY,SEN_DY,LEA_PY,LEA_DM,CHK_LB";
				sql+=" from FILB01A left outer join FILB01AF on FILB01A.EMP_ID=FILB01AF.EMP_ID";
				sql+=" left outer join FILA11A on FILA11A.TYP_ID=FILB01A.TYP_ID";
				sql+=" LEFT OUTER JOIN FILB01AC ON FILB01A.EMP_ID=FILB01AC.EMP_ID";
				sql+=" where "+control1.GetWhere("",false);
				sql+=" and ((VAC_BT=0 or VAC_BT is null) or (VAC_BT=1 and VAC_DT>='"+ fromdate.ToString("yyyy/MM") +"/01'))";
				sql+=" and INH_DT<'"+fromdate.AddMonths(1).ToString("yyyy/MM")+"/01'"; 
				Func.RecordSet rs=new Func.RecordSet(sql,con);
				for(int i=0;i<rs.rows;i++)
				{
					if(stop)
					{
						return;
					}
					//Phep nam cho ung truoc hay ko
					if(PublicFunction.tinhphepnam==0)
					{
						String EMP_ID=rs.record(i,"EMP_ID");
						String INH_DT=rs.record(i,"INH_DT");
						string TYP_ID=rs.record(i,"TYP_ID");
						string LAB_ST=rs.record(i,"LAB_ST");
						//xet co ngay vao lam va loai nhan vien hay ko
						//Chuyen nhan vien vao FILC04C
						checkStaff(EMP_ID,con,fromdate.ToString("yyyyMM"));
						if(INH_DT+""=="") // ko co ngay vao
						{
							UpdateStaff0(EMP_ID,con,fromdate.ToString("yyyyMM"));
							return;
						}
						//string sql;
						sql="Select * from FILA11A where TYP_ID=N'"+TYP_ID+"'";
						Func.RecordSet rrs=new Func.RecordSet(sql,con);
						if(rrs.rows<=0) // ko co loai nhan vien 
						{
							UpdateStaff0(EMP_ID,con,fromdate.ToString("yyyyMM"));
							return;				
						}
						string checkHD=rs.record(0,"CHK_LB");
						if (checkHD=="True")
						{
							//Thang bat dau tinh phep nam
							int WAG_MM=T_String.IsNullTo0(rs.record(0,"WAG_MM"));
							/////////
							///Ngay tinh de doi chieu voi ngay tinh cua chuong trinh
							int ngaytinh=T_String.IsNullTo0(rs.record(0,"STR_DT"));
							int phepnam1nam=T_String.IsNullTo0(rs.record(0,"LEA_DY"));
							int phepnamnuanam=T_String.IsNullTo0(rs.record(0,"LEA_PY"));
							int phepnam1thang=T_String.IsNullTo0(rs.record(0,"LEA_DM"));
							//Thang bat dau tinh cong them vao ngay vao lam
							DateTime Batdautinh=DateTime.Parse(LAB_ST).AddMonths(WAG_MM);
							DateTime dt1=DateTime.Parse(LAB_ST);
							int phepduochuongtuden=0,phepduochuongtrongthang=0,phepnghitrongthang=0,phepnghituden=0,phepconlaitrongthang=0,phepconlaituden=0;
							label5.Text=fromdate.ToString("yyyy/MM");
							sql="Select (Select isnull(SUM(DAY_TT),0) from FILC04A where LEA_ID=N'001' and EMP_ID=N'"+EMP_ID+"' and STR_DT>='"
								+fromdate.ToString("yyyy")+"/01/01' and STR_DT<'"+fromdate.AddMonths(1).ToString("yyyy/MM")+"/01') AS Tuden,";
							sql+="(Select isnull(SUM(DAY_TT),0) from FILC04A where LEA_ID=N'001' and EMP_ID=N'"+EMP_ID+"' and STR_DT>='"
								+fromdate.ToString("yyyy/MM")+"/01' and STR_DT<'"+fromdate.AddMonths(1).ToString("yyyy/MM")+"/01') AS Trongthang";
							sql+=" from FILC04C where EMP_ID=N'"+EMP_ID+"' and YYY_YY=N'"+fromdate.ToString("yyyyMM")+"'";
							//sql="Select FILC04C set DID_QT="+sqltuden+",DID_MM="+sqltrongthang+" where EMP_ID=N'"+EMP_ID+"' and YYY_YY=N'"+fromdate.ToString("yyyyMM")+"'";
							Func.RecordSet rrss=new Func.RecordSet(sql,con);
							if (Batdautinh.Year> fromdate.Year)
							{
								UpdateStaff0(EMP_ID,con,fromdate.ToString("yyyyMM"));
								return;
							}
							else
							{
								if (fromdate.Year==Batdautinh.Year)
								{
									if (fromdate.Month-Batdautinh.Month+1>=12)
									{
										phepduochuongtuden=phepnam1nam;
									}
									else
									{
										if (fromdate.Month-Batdautinh.Month+1>=6)
										{
											phepduochuongtuden=phepnamnuanam+(fromdate.Month-Batdautinh.Month+1-6)*phepnam1thang;
										}
										else
										{
											if (fromdate.Month-Batdautinh.Month+1>=0 && (fromdate.Month-Batdautinh.Month+1<6))
											{
												phepduochuongtuden=phepnam1thang*(fromdate.Month-Batdautinh.Month+1);
											}
										}
									}
									phepduochuongtrongthang=phepnam1thang;
									phepnghitrongthang=T_String.IsNullTo0(rrss.record(0,"Trongthang"));
									phepconlaitrongthang=phepduochuongtrongthang-phepnghitrongthang;
									phepnghituden=T_String.IsNullTo0(rrss.record(0,"Tuden"));
									phepconlaituden=phepduochuongtuden-phepnghituden;
								}
								else
								{
									DateTime ngaytinhmoi=fromdate.AddMonths(-fromdate.Month+1);	
									if (fromdate.Month-ngaytinhmoi.Month+1>=12)
									{
										phepduochuongtuden=phepnam1nam;
									}
									else
									{
										if (fromdate.Month-ngaytinhmoi.Month+1>=6)
										{
											phepduochuongtuden=phepnamnuanam+(fromdate.Month-ngaytinhmoi.Month+1-6)*phepnam1thang;
										}
										else
										{
											if (fromdate.Month-ngaytinhmoi.Month+1>=0 && (fromdate.Month-ngaytinhmoi.Month+1<6))
											{
												phepduochuongtuden=phepnam1thang*(fromdate.Month-ngaytinhmoi.Month+1);
											}
										}
									}
									phepduochuongtrongthang=phepnam1thang;
									phepnghitrongthang=T_String.IsNullTo0(rrss.record(0,"Trongthang"));
									phepconlaitrongthang=phepduochuongtrongthang-phepnghitrongthang;
									phepnghituden=T_String.IsNullTo0(rrss.record(0,"Tuden"));
									phepconlaituden=phepduochuongtuden-phepnghituden;
								}
							}
							// tinh tham nien
							int thamnien=0;
							DateTime Ngayvaolam=DateTime.Parse(INH_DT);
							int sonam=T_String.IsNullTo0(rs.record(0,"SEN_YY"));
							int songay=T_String.IsNullTo0(rs.record(0,"SEN_DY"));
							if(sonam!=0 && songay!=0)
							{
								while(true)
								{
									Ngayvaolam=Ngayvaolam.AddYears(sonam);
									if(T_String.CompareDate(fromdate,Ngayvaolam))
										thamnien+=songay;
									else
										break;
								}
							}
							sql="update FILC04C set HAV_QT="+phepconlaituden+",HAV_MM="+phepconlaitrongthang+",ADD_QT="+thamnien+",";
							sql+="DID_QT="+phepnghituden+",DID_MM="+phepnghitrongthang+",CAN_QT="+phepduochuongtuden+",APP_MM="+phepduochuongtrongthang+" ";
							sql+=" where EMP_ID=N'"+EMP_ID+"' and YYY_YY=N'"+fromdate.ToString("yyyyMM")+"'";
							PublicFunction.SQL_Execute(sql,con);
						}
						else
						{
							//Thang bat dau tinh phep nam
							int WAG_MM=T_String.IsNullTo0(rs.record(0,"WAG_MM"));
							/////////
							///Ngay tinh de doi chieu voi ngay tinh cua chuong trinh
							int ngaytinh=T_String.IsNullTo0(rs.record(0,"STR_DT"));
							int phepnam1nam=T_String.IsNullTo0(rs.record(0,"LEA_DY"));
							int phepnamnuanam=T_String.IsNullTo0(rs.record(0,"LEA_PY"));
							int phepnam1thang=T_String.IsNullTo0(rs.record(0,"LEA_DM"));
							//Thang bat dau tinh cong them vao ngay vao lam
							DateTime Batdautinh=DateTime.Parse(INH_DT).AddMonths(WAG_MM);
							DateTime dt1=DateTime.Parse(INH_DT);
							int phepduochuongtuden=0,phepduochuongtrongthang=0,phepnghitrongthang=0,phepnghituden=0,phepconlaitrongthang=0,phepconlaituden=0;
							label5.Text=fromdate.ToString("yyyy/MM");
							sql="Select (Select isnull(SUM(DAY_TT),0) from FILC04A where LEA_ID=N'001' and EMP_ID=N'"+EMP_ID+"' and STR_DT>='"
								+fromdate.ToString("yyyy")+"/01/01' and STR_DT<'"+fromdate.AddMonths(1).ToString("yyyy/MM")+"/01') AS Tuden,";
							sql+="(Select isnull(SUM(DAY_TT),0) from FILC04A where LEA_ID=N'001' and EMP_ID=N'"+EMP_ID+"' and STR_DT>='"
								+fromdate.ToString("yyyy/MM")+"/01' and STR_DT<'"+fromdate.AddMonths(1).ToString("yyyy/MM")+"/01') AS Trongthang";
							sql+=" from FILC04C where EMP_ID=N'"+EMP_ID+"' and YYY_YY=N'"+fromdate.ToString("yyyyMM")+"'";
							//sql="Select FILC04C set DID_QT="+sqltuden+",DID_MM="+sqltrongthang+" where EMP_ID=N'"+EMP_ID+"' and YYY_YY=N'"+fromdate.ToString("yyyyMM")+"'";
							Func.RecordSet rrss=new Func.RecordSet(sql,con);
							if (Batdautinh.Year> fromdate.Year)
							{
								UpdateStaff0(EMP_ID,con,fromdate.ToString("yyyyMM"));
								return;
							}
							else
							{
								if (fromdate.Year==Batdautinh.Year)
								{
									if (fromdate.Month-Batdautinh.Month+1>=12)
									{
										phepduochuongtuden=phepnam1nam;
									}
									else
									{
										if (fromdate.Month-Batdautinh.Month+1>=6)
										{
											phepduochuongtuden=phepnamnuanam+(fromdate.Month-Batdautinh.Month+1-6)*phepnam1thang;
										}
										else
										{
											if (fromdate.Month-Batdautinh.Month+1>=0 && (fromdate.Month-Batdautinh.Month+1<6))
											{
												phepduochuongtuden=phepnam1thang*(fromdate.Month-Batdautinh.Month+1);
											}
										}
									}
									phepduochuongtrongthang=phepnam1thang;
									phepnghitrongthang=T_String.IsNullTo0(rrss.record(0,"Trongthang"));
									phepconlaitrongthang=phepduochuongtrongthang-phepnghitrongthang;
									phepnghituden=T_String.IsNullTo0(rrss.record(0,"Tuden"));
									phepconlaituden=phepduochuongtuden-phepnghituden;
								}
								else
								{
									DateTime ngaytinhmoi=fromdate.AddMonths(-fromdate.Month+1);	
									if (fromdate.Month-ngaytinhmoi.Month+1>=12)
									{
										phepduochuongtuden=phepnam1nam;
									}
									else
									{
										if (fromdate.Month-ngaytinhmoi.Month+1>=6)
										{
											phepduochuongtuden=phepnamnuanam+(fromdate.Month-ngaytinhmoi.Month+1-6)*phepnam1thang;
										}
										else
										{
											if (fromdate.Month-ngaytinhmoi.Month+1>=0 && (fromdate.Month-ngaytinhmoi.Month+1<6))
											{
												phepduochuongtuden=phepnam1thang*(fromdate.Month-ngaytinhmoi.Month+1);
											}
										}
									}
									phepduochuongtrongthang=phepnam1thang;
									phepnghitrongthang=T_String.IsNullTo0(rrss.record(0,"Trongthang"));
									phepconlaitrongthang=phepduochuongtrongthang-phepnghitrongthang;
									phepnghituden=T_String.IsNullTo0(rrss.record(0,"Tuden"));
									phepconlaituden=phepduochuongtuden-phepnghituden;
								}
							}
							// tinh tham nien
							int thamnien=0;
							DateTime Ngayvaolam=DateTime.Parse(INH_DT);
							int sonam=T_String.IsNullTo0(rs.record(0,"SEN_YY"));
							int songay=T_String.IsNullTo0(rs.record(0,"SEN_DY"));
							if(sonam!=0 && songay!=0)
							{
								while(true)
								{
									Ngayvaolam=Ngayvaolam.AddYears(sonam);
									if(T_String.CompareDate(fromdate,Ngayvaolam))
										thamnien+=songay;
									else
										break;
								}
							}
							sql="update FILC04C set HAV_QT="+phepconlaituden+",HAV_MM="+phepconlaitrongthang+",ADD_QT="+thamnien+",";
							sql+="DID_QT="+phepnghituden+",DID_MM="+phepnghitrongthang+",CAN_QT="+phepduochuongtuden+",APP_MM="+phepduochuongtrongthang+" ";
							sql+=" where EMP_ID=N'"+EMP_ID+"' and YYY_YY=N'"+fromdate.ToString("yyyyMM")+"'";
							PublicFunction.SQL_Execute(sql,con);
						}			
					}
					else
					{
						if(PublicFunction.tinhphepnam==1)
							CalStaff1(rs.record(i,"EMP_ID")+"",rs.record(i,"TYP_ID")+"",rs.record(i,"INH_DT")+"",con,dt);
						CalStaffDaNghi(rs.record(i,"EMP_ID")+"",con,fromdate);
					}
					lb.Text= (i+1)+"/"+rs.rows+" __ "+((int)(i+1)*100/rs.rows)+"%";
					lb2.Text= rs.record(i,"EMP_ID")+" __ "+rs.record(i,"EMP_NM");
					pro.Value=(int)(i+1)*100/rs.rows;
				}
				lb2.Text=PublicFunction.L_Get_Msg("Staff",1);
				cmd_OK.Enabled=true;

				fromdate=fromdate.AddMonths(1);
			}
		}
		
		//Tinh ngay nghi trong thang va tu dau nam den thang tinh
		public static void CalStaffDaNghi(string EMP_ID,SqlConnection con,DateTime dt)
		{
			string sqltuden="";		
			string sqltrongthang="";
			string sql="";
			sqltuden="(Select isnull(SUM(DAY_TT),0) from FILC04A where LEA_ID=N'001' and EMP_ID=N'"+EMP_ID+"' and STR_DT>='"
				+dt.ToString("yyyy")+"/01/01' and STR_DT<'"+dt.AddMonths(1).ToString("yyyy/MM")+"/01')";
			sqltrongthang="(Select isnull(SUM(DAY_TT),0) from FILC04A where LEA_ID=N'001' and EMP_ID=N'"+EMP_ID+"' and STR_DT>='"
				+dt.ToString("yyyy/MM")+"/01' and STR_DT<'"+dt.AddMonths(1).ToString("yyyy/MM")+"/01')";
			sql="update FILC04C set DID_QT="+sqltuden+",DID_MM="+sqltrongthang+" where EMP_ID=N'"+EMP_ID+"' and YYY_YY=N'"+dt.ToString("yyyyMM")+"'";
			PublicFunction.SQL_Execute(sql,con);
		}

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

			sql="update FILC04C set HAV_QT="+ngayphep+",ADD_QT="+thamnien+" where EMP_ID=N'"+EMP_ID+"' and YYY_YY=N'"+dt.ToString("yyyy")+"'";
			PublicFunction.SQL_Execute(sql,con);
			
			
		}
*/	

		//Tinh dua tren ngay vao lam 
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

			sql="update FILC04C set HAV_QT="+ngayphep+",ADD_QT="+thamnien+" where EMP_ID=N'"+EMP_ID+"' and YYY_YY=N'"+dt.ToString("yyyy")+"'";
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

			sql="update FILC04C set HAV_QT="+ngayphep+",ADD_QT="+thamnien+" where EMP_ID=N'"+EMP_ID+"' and YYY_YY=N'"+dt.ToString("yyyy")+"'";
			PublicFunction.SQL_Execute(sql,con);
//			sql="update FILC04C set DID_QT=(select SUM(DAY_TT) from FILC04A where  EMP_ID=N'"+EMP_ID+"' "
//				+")where EMP_ID=N'"+EMP_ID+"' and YYY_YY=N'"+dt.ToString("yyyy")+"'";
//			PublicFunction.SQL_Execute(sql,con);
			
		}
		#endregion		
		#region Fun
		public static void UpdateStaff0(string EMP_ID,SqlConnection con,string YYY)
		{
			string sql="update FILC04C set HAV_QT="+0+",ADD_QT=0 where EMP_ID=N'"+EMP_ID+"' and YYY_YY=N'"+YYY+"'";
			PublicFunction.SQL_Execute(sql,con);
		}

		public static void checkStaff(string EMP_ID,SqlConnection con,string YYY)
		{			
			if(T_String.IsNullTo0(T_String.GetDataFromSQL("Count(*)","FILC04C","EMP_ID=N'"+EMP_ID+"' and YYY_YY=N'"+YYY+"'"))<=0)
			{
				string sql="";
				sql="Insert Into FILC04C(YYY_YY,EMP_ID,BLT_NM,BLT_DT) values (N'"
					+YYY+"',N'"+EMP_ID+"',N'"+PublicFunction.A_UserID+"','"+T_String.GetDate(con).ToString("yyyy/MM/dd HH:mm")+"')";
				PublicFunction.SQL_Execute(sql,con);
			}
		}

		private void frmTaCalAnnualLeave_Closed(object sender, EventArgs e)
		{
			stop=true;
		}
		#endregion

		private void dtpfrom_TextChanged(object sender, System.EventArgs e)
		{
		
		}
	}
}

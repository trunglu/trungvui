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
using ADODB;

namespace GP8000.Attendance
{
	/// <summary>
	/// Summary description for frmTaTransferFromTXT.
	/// </summary>
	public class frmTaTransferFromTXT : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel5;
		private Double d1,d2; // so dong them vao cua 1 va 2
		private string dt;// ngay hien tai
		private string TYP_NM1,TYP_NM2;//TYP_NM1 loai may cho duong dan 1, 2 duong dan 2
		private SqlConnection con11,con21;
		private int CRD_MN;// so phut the lap lai
		private ArrayList EMP_ID,CRD_NO;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.ListBox lb1;
		private System.Windows.Forms.ListBox lb2;
		private System.Windows.Forms.ListBox lb3;
		private System.Windows.Forms.ListBox lb4;
		private System.Windows.Forms.Label c1;
		private System.Windows.Forms.Button button1;
		private Boolean stop,fin1,fin2;
		private System.Windows.Forms.Label c2;
		private string BT;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaTransferFromTXT()
		{
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.c1 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.lb4 = new System.Windows.Forms.ListBox();
			this.lb3 = new System.Windows.Forms.ListBox();
			this.panel6 = new System.Windows.Forms.Panel();
			this.lb2 = new System.Windows.Forms.ListBox();
			this.lb1 = new System.Windows.Forms.ListBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.c2 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(780, 400);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.panel5);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 36);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(780, 364);
			this.panel2.TabIndex = 14;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.button1);
			this.panel5.Controls.Add(this.panel4);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(0, 0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(780, 364);
			this.panel5.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(336, 324);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(108, 36);
			this.button1.TabIndex = 7;
			this.button1.Text = "Stop";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// c1
			// 
			this.c1.BackColor = System.Drawing.Color.Black;
			this.c1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.c1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.c1.ForeColor = System.Drawing.Color.White;
			this.c1.Location = new System.Drawing.Point(0, 293);
			this.c1.Name = "c1";
			this.c1.Size = new System.Drawing.Size(384, 23);
			this.c1.TabIndex = 6;
			this.c1.Tag = "N";
			this.c1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.panel7);
			this.panel4.Controls.Add(this.panel6);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(780, 316);
			this.panel4.TabIndex = 0;
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.lb4);
			this.panel7.Controls.Add(this.lb3);
			this.panel7.Controls.Add(this.c2);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel7.Location = new System.Drawing.Point(384, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(396, 316);
			this.panel7.TabIndex = 1;
			// 
			// lb4
			// 
			this.lb4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lb4.ItemHeight = 16;
			this.lb4.Location = new System.Drawing.Point(136, 0);
			this.lb4.Name = "lb4";
			this.lb4.Size = new System.Drawing.Size(260, 292);
			this.lb4.TabIndex = 6;			
			// 
			// lb3
			// 
			this.lb3.Dock = System.Windows.Forms.DockStyle.Left;
			this.lb3.ItemHeight = 16;
			this.lb3.Location = new System.Drawing.Point(0, 0);
			this.lb3.Name = "lb3";
			this.lb3.Size = new System.Drawing.Size(136, 292);
			this.lb3.TabIndex = 4;
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.lb2);
			this.panel6.Controls.Add(this.lb1);
			this.panel6.Controls.Add(this.c1);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel6.Location = new System.Drawing.Point(0, 0);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(384, 316);
			this.panel6.TabIndex = 0;
			// 
			// lb2
			// 
			this.lb2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lb2.ItemHeight = 16;
			this.lb2.Location = new System.Drawing.Point(136, 0);
			this.lb2.Name = "lb2";
			this.lb2.Size = new System.Drawing.Size(248, 292);
			this.lb2.TabIndex = 5;
			// 
			// lb1
			// 
			this.lb1.Dock = System.Windows.Forms.DockStyle.Left;
			this.lb1.ItemHeight = 16;
			this.lb1.Location = new System.Drawing.Point(0, 0);
			this.lb1.Name = "lb1";
			this.lb1.Size = new System.Drawing.Size(136, 292);
			this.lb1.TabIndex = 3;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.panel3.Controls.Add(this.label5);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(780, 36);
			this.panel3.TabIndex = 13;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Location = new System.Drawing.Point(0, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(780, 36);
			this.label5.TabIndex = 11;
			this.label5.Tag = "";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// c2
			// 
			this.c2.BackColor = System.Drawing.Color.Black;
			this.c2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.c2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.c2.ForeColor = System.Drawing.Color.White;
			this.c2.Location = new System.Drawing.Point(0, 293);
			this.c2.Name = "c2";
			this.c2.Size = new System.Drawing.Size(396, 23);
			this.c2.TabIndex = 7;
			this.c2.Tag = "N";
			this.c2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmTaTransferFromTXT
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(780, 400);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaTransferFromTXT";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmTaTransferFromTXT";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.frmTaTransferFromTXT_Closing);
			this.Load += new System.EventHandler(this.frmTaTransferFromTXT_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaTransferFromTXT_Load(object sender, System.EventArgs e)
		{	
			fin1=fin2=false;
//			Basic.Function.PublicFunction.L_Init_Label(this);
			stop=false;
			Get_Staff();
			dt=T_String.GetDate().ToString("yyyy/MM/dd HH:mm");
			CRD_MN=T_String.IsNullTo0(T_String.GetDataFromSQL("CRD_MN","GP_SYS_SETTING"));

			Thread th=new Thread(new ThreadStart(Transfer1));
			th.Priority=ThreadPriority.Highest;
			th.Start();
			Thread th1=new Thread(new ThreadStart(Transfer2));
			th1.Priority=ThreadPriority.Highest;
			th1.Start();
		}


		private void Transfer1()
		{	
//			try
//			{
				con11=new SqlConnection(PublicFunction.C_con.ConnectionString);
				con11.Open();
				d1=0;			
				TYP_NM1=T_String.GetDataFromSQL("TYP_NM","GP_SYS_READER","SEQ_NO='0'",con11);
			
				GetFileName1();			

				string fname=T_String.GetDataFromSQL("FIL_NM","GP_SYS_READER","SEQ_NO='0'",con11);
				double book=T_String.IsNullTo00(T_String.GetDataFromSQL("RCD_FG","GP_SYS_READER","SEQ_NO='0'",con11));
				Double b=0;
				for(int f=0;f<lb1.Items.Count;f++)
				{			
					lb1.SelectedIndex=f;
					try
					{
						string st="";					
						string filename=lb1.Items[f]+"";
						StreamReader read=File.OpenText(filename);				
						b=0;
						while (true)
						{
							if(stop)
							{
								string sql="update  GP_SYS_READER set RCD_FG="+b+",FIL_NM=N'"+filename+"' where SEQ_NO='0'";
								PublicFunction.SQL_Execute(sql,con11);
								read.Close();
								con11.Close();
								return;
							}
							st=read.ReadLine();
							if (st==null) 
							{
								read.Close();
								break;
							}	

							if(fname==filename)
							{
								if(b>=book)
									CardNo(st,"0",filename,con11);
							}
							else
								CardNo(st,"0",filename,con11);
							b++;
						}						
					}
					catch (IOException ex)
					{
						MessageBox.Show("File :"+ ex.Message);
						return;
					}
				}
				if(lb1.Items.Count>0)
				{
					string sql="update  GP_SYS_READER set RCD_FG="+b+", FIL_NM=N'"+lb1.Items[lb1.Items.Count-1]+"' where SEQ_NO=N'0'";
					PublicFunction.SQL_Execute(sql,con11);
				}
				c1.Text=c1.Text+". Completed!";
				con11.Close();
				fin1=true;
			if(fin2)
			{
				if(BT+""!="")
					MessageBox.Show(BT);
				this.Close();
			}
//			}
//			catch (Exception ex)
//			{
//				MessageBox.Show( ex.Message);
//			}
		}

		private void Transfer2()
		{				
//			try
//			{
				con21=new SqlConnection(PublicFunction.C_con.ConnectionString);
				con21.Open();
				d2=0;			
				TYP_NM2=T_String.GetDataFromSQL("TYP_NM","GP_SYS_READER","SEQ_NO='1'",con21);
			
				GetFileName2();			

				string fname=T_String.GetDataFromSQL("FIL_NM","GP_SYS_READER","SEQ_NO='1'",con21);
				double book=T_String.IsNullTo00(T_String.GetDataFromSQL("RCD_FG","GP_SYS_READER","SEQ_NO='1'",con21));
				Double b=0;
				for(int f=0;f<lb3.Items.Count;f++)
				{		
					lb3.SelectedIndex=f;
					try
					{
						string st="";					
						string filename=lb3.Items[f]+"";
						StreamReader read=File.OpenText(filename);				
						b=0;
						while (true)
						{
							if(stop)
							{
								string sql="update  GP_SYS_READER set RCD_FG="+b+",FIL_NM=N'"+filename+"' where SEQ_NO='1'";
								PublicFunction.SQL_Execute(sql,con21);
								con21.Close();
								read.Close();
								return;
							}
							st=read.ReadLine();
							if (st==null) 
							{
								read.Close();
								break;
							}	
							if(fname==filename)
							{
								if(b>=book)
									CardNo(st,"1",filename,con21);
							}
							else
								CardNo(st,"1",filename,con21);
							b++;
						}						
					}
					catch (IOException ex)
					{
						MessageBox.Show("File :"+ ex.Message);
						return;
					}
				}
				if(lb3.Items.Count>0)
				{
					string sql="update  GP_SYS_READER set RCD_FG="+b+", FIL_NM=N'"+lb3.Items[lb3.Items.Count-1]+"' where SEQ_NO=N'1'";
					PublicFunction.SQL_Execute(sql,con21);
				}
				c2.Text=c2.Text+". Completed!";
				con21.Close();
				fin2=true;
			if(fin1)
			{
				if(BT+""!="")
					MessageBox.Show(BT);
				this.Close();
			}
//			}
//			catch (Exception ex)
//			{
//				MessageBox.Show( ex.Message);
//			}
		}

		private void Get_Staff()
		{
			Func.RecordSet rs=new Func.RecordSet("Select EMP_ID,CRD_NO from FILB01A where VAC_BT is null OR VAC_BT=0",PublicFunction.C_con);
			EMP_ID=new ArrayList();
			CRD_NO=new ArrayList();
			for(int i=0;i<rs.rows;i++)
			{
				EMP_ID.Add(rs.record(i,"EMP_ID"));
				CRD_NO.Add(rs.record(i,"CRD_NO"));
			}
		}
		#region  Lay danh sach file chuyen du lieu
		private void GetFileName1()// Lay danh sach file chuyen du lieu
		{
			try
			{
			string dir=T_String.GetDataFromSQL("DIR_DR","GP_SYS_READER","SEQ_NO='0'",con11);
			string FIL_NM=T_String.GetDataFromSQL("FIL_NM","GP_SYS_READER","SEQ_NO='0'",con11);
			DateTime dt=GetDateOfFileTXT(FIL_NM,"0");
			string []f1=Directory.GetFiles(dir);

			for(int i=0;i<f1.Length;i++)
			{	
				if ( PublicFunction.S_Right( f1[i] ,4).ToUpper()==".TXT") 
				{
					DateTime dt1=GetDateOfFileTXT(f1[i],"0");
					if(T_String.CompareDate(dt1,dt))
					{
						int j=0;
						for (j=0;j<lb1.Items.Count;j++)
						{
							if(T_String.CompareDate(GetDateOfFileTXT(lb1.Items[j]+"","0"),dt1))
							{
								break;
							}
						}
						//					if(j!=0)
						//						lb1.Items.Insert(j-1,f1[i]);
						//					else
						lb1.Items.Insert(j,f1[i]);
					}
				}
			}	
			}
			catch(Exception)
			{
			}
		}
		private void GetFileName2()// Lay danh sach file chuyen du lieu
		{
			try
			{
				string dir=T_String.GetDataFromSQL("DIR_DR","GP_SYS_READER","SEQ_NO='1'",con21);
				string FIL_NM=T_String.GetDataFromSQL("FIL_NM","GP_SYS_READER","SEQ_NO='1'",con21);
				DateTime dt=GetDateOfFileTXT(FIL_NM,"1");
				string []f1=Directory.GetFiles(dir);

				for(int i=0;i<f1.Length;i++)
				{
					if ( PublicFunction.S_Right( f1[i] ,4).ToUpper()==".TXT") 
					{
						DateTime dt1=GetDateOfFileTXT(f1[i],"1");
						if(T_String.CompareDate(dt1,dt))
						{
							int j=0;
							for (j=0;j<lb3.Items.Count;j++)
							{
								if(T_String.CompareDate(GetDateOfFileTXT(lb3.Items[j]+"","1"),dt1))
								{
									break;
								}
							}
							lb3.Items.Insert(j,f1[i]);
						}
					}
						
				}		
			}
			catch(Exception)
			{
			}
		}


		private DateTime GetDateOfFileTXT(string st1,string SEQ_NO)
		{
			string TYP_NM;
			if(SEQ_NO=="0")
				TYP_NM=TYP_NM1;
			else
				TYP_NM=TYP_NM2;
			string st=GetName(st1);
			switch(TYP_NM)
			{
				case "01"://510L
					return M510L(st);						
				case "02": //AQ800
					return AQ800(st);
				default:
					return AQ800(st);

			}
			//return new DateTime(1,1,1);
		}
		private DateTime M510L(string st)
		{
			try
			{
				
				string st1=st;
				int m=T_String.IsNullTo0(PublicFunction.S_Left(st1,2));
				st1=PublicFunction.S_Right(st1,st1.Length-3);
				int d=T_String.IsNullTo0(PublicFunction.S_Left(st1,2));
				st1=PublicFunction.S_Right(st1,st1.Length-3);
				int y=T_String.IsNullTo0( PublicFunction.S_Left(st1,4));			
				DateTime dt=new DateTime(y,m,d);
				return dt;
			}
			catch(Exception)
			{
				return new DateTime(1,1,1);
			}
		}
		private DateTime AQ800(string st)
		{
			try
			{
				
				string st1=st;
				int y=T_String.IsNullTo0( PublicFunction.S_Left(st1,4));
				st1=PublicFunction.S_Right(st1,st1.Length-4);
				int m=T_String.IsNullTo0(PublicFunction.S_Left(st1,2));
				st1=PublicFunction.S_Right(st1,st1.Length-2);
				int d=T_String.IsNullTo0(PublicFunction.S_Left(st1,2));
				DateTime dt=new DateTime(y,m,d);
				return dt;
			}
			catch(Exception)
			{
				return new DateTime(1,1,1);
			}
		}

		private string GetName(string thumuc)
		{
			try
			{
				int n=thumuc.LastIndexOf("\\");
				if(n<0)
					return thumuc;
				return thumuc.Remove(0,n+1);
			}
			catch(Exception)
			{
				return "";
			}
		}		
		#endregion
#region Reader
		private void CardNo(string st,string SEQ_NO,string filename,SqlConnection con)
		{			
			string TYP_NM;
			if(SEQ_NO=="0")
				TYP_NM=TYP_NM1;
			else
				TYP_NM=TYP_NM2;
			switch(TYP_NM)
			{
				case "01":
					Data_M510L(st,filename,con,SEQ_NO);
					break;
				case "02": //AQ800
					Data_AQ800(st,filename,con,SEQ_NO);
					break;
				default:
					Data_Nooption(st,filename,con,SEQ_NO);
					break;
			}

			
		}
		
		private void Data_M510L(string st1,string filename,SqlConnection con,string SEQ_NO)
		{
			try
			{
				string st=st1;
				st=PublicFunction.S_Right(st,st.Length-1);
				string REA_NO=PublicFunction.S_Left(st,2);
				st=PublicFunction.S_Right(st,st.Length-2);
				string CRD_NO=PublicFunction.S_Right(st,10);
				st=PublicFunction.S_Left(st,st.Length-15);
				string CRD_DT=PublicFunction.S_Left(st,8);
				st=PublicFunction.S_Right(st,st.Length-8);
				string CRD_TM=PublicFunction.S_Left(st,4);			
				Double TM= T_String.IsNullTo00(PublicFunction.S_Left(st,4));
				
			
				DateTime dt1=GetDateTime(CRD_DT,CRD_TM).AddMinutes(-CRD_MN);
				DateTime dt2=GetDateTime(CRD_DT,CRD_TM).AddMinutes(CRD_MN);

				if(TM==0000)
				{
					CRD_TM="2400";
					TM=2400;
				}

				string sql="",EMP_ID;
				sql="Select EMP_ID from FILC01A where DAT_TM=N'"+CRD_DT+CRD_TM+"' and CRD_NO=N'"+CRD_NO+"'";
				//PublicFunction.SQL_Execute(sql,con);
				Func.RecordSet rr=new Func.RecordSet(sql,con);
				if(rr.rows<=0)
				{
					sql="(DAT_TM>"+dt1.ToString("yyyyMMddHHmm")+" and DAT_TM<"+dt2.ToString("yyyyMMddHHmm")
						+") and CRD_NO=N'"+CRD_NO+"'";
					if(T_String.IsNullTo0(T_String.GetDataFromSQL("COUNT(DAT_TM)","FILC01A",sql,con))<=0)// thoi cho phep duoc lap lai the
					{
						int index=this.CRD_NO.IndexOf(CRD_NO);
						if(index>=0)
							EMP_ID=this.EMP_ID[index]+"";
						else
							EMP_ID="";
						sql="Insert into FILC01A(DAT_TM,EMP_ID,SWI_DT,USR_NM,CRD_DT,CRD_TM,CRD_NO,REA_NO,FIL_NM) values(";
						sql+="N'"+CRD_DT+CRD_TM+"',N'"+EMP_ID+"','"+dt+"',N'"+PublicFunction.A_UserID+"',";
						sql+="'"+CRD_DT+"',"+TM+",";
						sql+="N'"+CRD_NO+"',N'"+REA_NO+"',";
						sql+="N'"+filename+"')";
				
						try
						{				
							PublicFunction.SQL_Execute(sql,con);
						}
						catch(SqlException ex)
						{
							if (ex.Number!=2627 )
							{
								MessageBox.Show(ex.Message+"");
							}
						}		
					}
				}
				else
				{
					if(rr.record(0,0)+""=="")
					{
						int index=this.CRD_NO.IndexOf(CRD_NO);
						if(index>=0)
							EMP_ID=this.EMP_ID[index]+"";
						else
							EMP_ID="";
						if(EMP_ID!="")
						{
							sql="Update FILC01A set EMP_ID=N'"+EMP_ID+"'where DAT_TM=N'"+CRD_DT+CRD_TM+"' and CRD_NO=N'"+CRD_NO+"'";
							PublicFunction.SQL_Execute(sql,con);
						}
					}
				}

				//PublicFunction.SQL_Execute(sql,con);
				if(SEQ_NO=="0")
				{					
					lb2.Items.Add(CRD_NO+"  "+CRD_DT+"  "+CRD_TM );
					d1++;
					c1.Text=d1+"";
				}
				else
				{
					lb4.Items.Add(CRD_NO+"  "+CRD_DT+"  "+CRD_TM );
					d2++;
					c2.Text=d2+"";
				}
				//Tao khoa lam cho chuyen du lieu chay cham-- cty weisheng
				//LAY NGAY KHOA DUOI SQL
				if (PublicFunction.CUS_ID=="3" || int.Parse(PublicFunction.CUS_ID)>=100) //weisheng
				{
						
					string keyD="";
					int iphut=0;
					Func.RecordSet rsK=new Func.RecordSet ("Select * from GP_KEY",PublicFunction.C_con);
					if (rsK.rows>0)
					{
						keyD=PublicFunction.encode(rsK.record(0,"COL_DT"),"") ;
						iphut=T_String.IsNullTo0(rsK.record(0,"COL_MN"));
						if ( T_String.GetDate()>= DateTime.Parse( keyD))
						{
							for (int i=1;i<=iphut;i++)
							{									
								Thread.Sleep(50) ;
							}
							//PublicFunction.SQL_Execute("UPDATE GP_KEY SET COL_MN="+iphut,PublicFunction.C_con);
						}
					}
				}
				//
			}
			catch(Exception)
			{BT+=st1+"--- "+SEQ_NO+"----"+filename+" \n";}
		}
		private void Data_AQ800(string st1,string filename,SqlConnection con,string SEQ_NO)
		{
//			try
			{
				string st=st1;
				string REA_NO=PublicFunction.S_Left(st,3);
				st=PublicFunction.S_Right(st,st.Length-3);
				string CRD_NO=PublicFunction.S_Left(st,10);			
				st=PublicFunction.S_Right(st,st.Length-10);
				string CRD_DT=PublicFunction.S_Left(st,8);
				st=PublicFunction.S_Right(st,st.Length-8);
				string CRD_TM=PublicFunction.S_Left(st,4);			
				Double TM= T_String.IsNullTo00(PublicFunction.S_Left(st,4));
			
				DateTime dt1=GetDateTime(CRD_DT,CRD_TM).AddMinutes(-CRD_MN);
				DateTime dt2=GetDateTime(CRD_DT,CRD_TM).AddMinutes(CRD_MN);

				
				string sql="",EMP_ID;
				//Kiem tra neu ma co roi thi ko them nua
				sql="Select EMP_ID from FILC01A where DAT_TM=N'"+CRD_DT+CRD_TM+"' and CRD_NO=N'"+CRD_NO+"'";
				Func.RecordSet rs=new Func.RecordSet(sql,con);
				if (rs.rows<=0)
				{
//					sql="Delete from FILC01A where DAT_TM=N'"+CRD_DT+CRD_TM+"' and CRD_NO=N'"+CRD_NO+"'";
//					PublicFunction.SQL_Execute(sql,con);
					if(TM==0000)
					{
						CRD_TM="2400";
						TM=2400;
						CRD_DT=GetDate(CRD_DT).AddDays(-1).ToString("yyyyMMdd");
						
					}
					sql="(DAT_TM>"+dt1.ToString("yyyyMMddHHmm")+" and DAT_TM<"+dt2.ToString("yyyyMMddHHmm")
						+") and CRD_NO=N'"+CRD_NO+"'";
					if(T_String.IsNullTo0(T_String.GetDataFromSQL("COUNT(DAT_TM)","FILC01A",sql,con))<=0)// thoi cho phep duoc lap lai the
					{
						int index=this.CRD_NO.IndexOf(CRD_NO);
						if(index>=0)
							EMP_ID=this.EMP_ID[index]+"";
						else
							EMP_ID="";
						sql="Insert into FILC01A(DAT_TM,EMP_ID,SWI_DT,USR_NM,CRD_DT,CRD_TM,CRD_NO,REA_NO,FIL_NM) values(";
						sql+="N'"+CRD_DT+CRD_TM+"',N'"+EMP_ID+"','"+dt+"',N'"+PublicFunction.A_UserID+"',";
						sql+="'"+CRD_DT+"',"+TM+",";
						sql+="N'"+CRD_NO+"',N'"+REA_NO+"',";
						sql+="N'"+filename+"')";
					
						try
						{				
							PublicFunction.SQL_Execute(sql,con);
						}
						catch(SqlException ex)
						{
							if (ex.Number!=2627 )
							{
								MessageBox.Show(ex.Message+"");
							}
						}		
					}
					
					if(SEQ_NO=="0")
					{					
						lb2.Items.Add(CRD_NO+"  "+CRD_DT+"  "+CRD_TM );
						d1++;
						c1.Text=d1+"";
					}
					else
					{
						lb4.Items.Add(CRD_NO+"  "+CRD_DT+"  "+CRD_TM );
						d2++;
						c2.Text=d2+"";
					}
					//PublicFunction.SQL_Execute(sql,con);
					//Tao khoa lam cho chuyen du lieu chay cham-- cty weisheng
					//LAY NGAY KHOA DUOI SQL					
					string stype="";	
					string keyD="";
					int iphut=0;
					SqlConnection SqlCon1 = new SqlConnection(PublicFunction.C_con.ConnectionString);
					SqlCon1.Open();
					Func.RecordSet rsK=new Func.RecordSet ("Select * from GP_KEY",con);
					if (rsK.rows>0)
					{
						stype=rsK.record(0,"TYP_MN") ;
						keyD=PublicFunction.encode(rsK.record(0,"COL_DT"),"") ;
						iphut=T_String.IsNullTo0(rsK.record(0,"COL_MN"));
						if(stype.ToUpper()=="AS")
						{
							if ( T_String.GetDate(SqlCon1)>= DateTime.Parse( keyD))
							{
															
								Thread.Sleep(500*iphut) ;
								
								//PublicFunction.SQL_Execute("UPDATE GP_KEY SET COL_MN="+iphut,PublicFunction.C_con);
							}
						}
					}
					
					//end
				}
				
			}
//			catch(Exception)
//			{BT+=st1+"--- "+SEQ_NO+"----"+filename+" \n";}
		}
		private void Data_Nooption(string st1,string filename,SqlConnection con,string SEQ_NO)
		{
			//			try
		{
//			string dir=T_String.GetDataFromSQL("DIR_DR","GP_SYS_READER","SEQ_NO='1'",con21);
//			
//			ConnectionClass conn = new ConnectionClass();
//
//			conn.ConnectionString = "Driver={Microsoft Text Driver (*.txt;*.csv)};Dbq="+dir+";Extensions=asc,csv,tab,txt; Persist Security Info=False";
//		
//			conn.Open( "Driver={Microsoft Text Driver (*.txt;*.csv)};Dbq="+dir+";Extensions=asc,csv,tab,txt; Persist Security Info=False");
//
//			RecordClass rs = new RecordClass();
//			rs.Source="select * from " + filename; 
//			rs.ActiveConnection=conn;
//			rs.Open();
			string st=st1;
			string REA_NO=PublicFunction.S_Left(st,3);//st.Substring(1,3); 
			st=PublicFunction.S_Right(st,st.Length-4);
			string CRD_NO=PublicFunction.S_Left(st,14);	
			
			st=PublicFunction.S_Right(st,st.Length-17);
			string CRD_DT= PublicFunction.S_Left(st,10);
			CRD_DT=CRD_DT.Replace("/","");
			CRD_DT=CRD_DT.Replace("-","");
			st=PublicFunction.S_Right(st,st.Length-11);
			string CRD_TM=PublicFunction.S_Left(st,5);			
			CRD_TM=CRD_TM.Replace(":","");
			Double TM= T_String.IsNullTo00(CRD_TM);
			
			DateTime dt1=GetDateTime(CRD_DT,CRD_TM).AddMinutes(-CRD_MN);
			
			DateTime dt2=GetDateTime(CRD_DT,CRD_TM).AddMinutes(CRD_MN);

				
			string sql="",EMP_ID;
			sql="Select EMP_ID from FILC01A where DAT_TM=N'"+CRD_DT+CRD_TM+"' and CRD_NO=N'"+CRD_NO+"'";
			Func.RecordSet rs1=new Func.RecordSet(sql,PublicFunction.C_con);
			if (rs1.rows<=0)
				//			sql="Delete from FILC01A where DAT_TM=N'"+CRD_DT+CRD_TM+"' and CRD_NO=N'"+CRD_NO+"'";
				//			PublicFunction.SQL_Execute(sql,con);
			{
				if(TM==0000)
				{
					CRD_TM="2400";
					TM=2400;
					CRD_DT=GetDate(CRD_DT).AddDays(-1).ToString("yyyyMMdd");
					
				}
				sql="(DAT_TM>"+dt1.ToString("yyyyMMddHHmm")+" and DAT_TM<"+dt2.ToString("yyyyMMddHHmm")
					+") and CRD_NO=N'"+CRD_NO+"'";
				if(T_String.IsNullTo0(T_String.GetDataFromSQL("COUNT(DAT_TM)","FILC01A",sql,con))<=0)// thoi cho phep duoc lap lai the
				{
					int index=this.CRD_NO.IndexOf(CRD_NO);
					if(index>=0)
						EMP_ID=this.EMP_ID[index]+"";
					else
						EMP_ID="";
					sql="Insert into FILC01A(DAT_TM,EMP_ID,SWI_DT,USR_NM,CRD_DT,CRD_TM,CRD_NO,REA_NO,FIL_NM) values(";
					sql+="N'"+CRD_DT+CRD_TM+"',N'"+EMP_ID+"','"+dt+"',N'"+PublicFunction.A_UserID+"',";
					sql+="'"+CRD_DT+"',"+TM+",";
					sql+="N'"+CRD_NO+"',N'"+REA_NO+"',";
					sql+="N'"+filename+"')";
				
					try
					{				
						PublicFunction.SQL_Execute(sql,con);
					}
					catch(SqlException ex)
					{
						if (ex.Number!=2627 )
						{
							MessageBox.Show(ex.Message+"");
						}
					}		
				}
				//PublicFunction.SQL_Execute(sql,con);
				if(SEQ_NO=="0")
				{					
					lb2.Items.Add(CRD_NO+"  "+CRD_DT+"  "+CRD_TM );
					d1++;
					c1.Text=d1+"";
				}
				else
				{
					lb4.Items.Add(CRD_NO+"  "+CRD_DT+"  "+CRD_TM );
					d2++;
					c2.Text=d2+"";
				}
			}
		}
			//			catch(Exception)
			//			{BT+=st1+"--- "+SEQ_NO+"----"+filename+" \n";}
		}
		private void Data_Nooption2(string st1,string filename,SqlConnection con,string SEQ_NO)
		{
			//			try
		{
//			private SqlConnection contxt;
//			contxt.ConnectionString="DefaultDir=C:\\Documents and Settings\\MinhTuyen\\Desktop\\txt\\,Driver={Microsoft Text Driver (*.txt, *.csv)},Columns=4,datatype=char";
//			contxt.Open(); 
			string st=st1;
			string REA_NO=PublicFunction.S_Left(st,3);
			st=PublicFunction.S_Right(st,st.Length-4);
			string CRD_NO=PublicFunction.S_Left(st,14);	
			
			st=PublicFunction.S_Right(st,st.Length-17);
			string CRD_DT= PublicFunction.S_Left(st,10);
			CRD_DT=CRD_DT.Replace("/","");
			st=PublicFunction.S_Right(st,st.Length-11);
			string CRD_TM=PublicFunction.S_Left(st,5);			
			CRD_TM=CRD_TM.Replace(":","");
			Double TM= T_String.IsNullTo00(CRD_TM);
			
			DateTime dt1=GetDateTime(CRD_DT,CRD_TM).AddMinutes(-CRD_MN);
			
			DateTime dt2=GetDateTime(CRD_DT,CRD_TM).AddMinutes(CRD_MN);

				
			string sql="",EMP_ID;
//			sql="Delete from FILC01A where DAT_TM=N'"+CRD_DT+CRD_TM+"' and CRD_NO=N'"+CRD_NO+"'";
//			PublicFunction.SQL_Execute(sql,con);

			//Kiem tra neu ma co roi thi ko them nua
			sql="Select EMP_ID from FILC01A where DAT_TM=N'"+CRD_DT+CRD_TM+"' and CRD_NO=N'"+CRD_NO+"'";
			Func.RecordSet rs11=new Func.RecordSet(sql,PublicFunction.C_con);
			if (rs11.rows<=0)
			{
				if(TM==0000)
				{
					CRD_TM="2400";
					TM=2400;
					CRD_DT=GetDate(CRD_DT).AddDays(-1).ToString("yyyyMMdd");
					
				}
				sql="(DAT_TM>"+dt1.ToString("yyyyMMddHHmm")+" and DAT_TM<"+dt2.ToString("yyyyMMddHHmm")
					+") and CRD_NO=N'"+CRD_NO+"'";
				if(T_String.IsNullTo0(T_String.GetDataFromSQL("COUNT(DAT_TM)","FILC01A",sql,con))<=0)// thoi cho phep duoc lap lai the
				{
					int index=this.CRD_NO.IndexOf(CRD_NO);
					if(index>=0)
						EMP_ID=this.EMP_ID[index]+"";
					else
						EMP_ID="";
					sql="Insert into FILC01A(DAT_TM,EMP_ID,SWI_DT,USR_NM,CRD_DT,CRD_TM,CRD_NO,REA_NO,FIL_NM) values(";
					sql+="N'"+CRD_DT+CRD_TM+"',N'"+EMP_ID+"','"+dt+"',N'"+PublicFunction.A_UserID+"',";
					sql+="'"+CRD_DT+"',"+TM+",";
					sql+="N'"+CRD_NO+"',N'"+REA_NO+"',";
					sql+="N'"+filename+"')";
				
					try
					{				
						PublicFunction.SQL_Execute(sql,con);
					}
					catch(SqlException ex)
					{
						if (ex.Number!=2627 )
						{
							MessageBox.Show(ex.Message+"");
						}
					}		
				}
				//PublicFunction.SQL_Execute(sql,con);
				if(SEQ_NO=="0")
				{					
					lb2.Items.Add(CRD_NO+"  "+CRD_DT+"  "+CRD_TM );
					d1++;
					c1.Text=d1+"";
				}
				else
				{
					lb4.Items.Add(CRD_NO+"  "+CRD_DT+"  "+CRD_TM );
					d2++;
					c2.Text=d2+"";
				}
			}
		}
			//			catch(Exception)
			//			{BT+=st1+"--- "+SEQ_NO+"----"+filename+" \n";}
		}
		private DateTime GetDateTime(string st,string time)
		{
			try
			{
				
				string st1=st;
				int y=T_String.IsNullTo0( PublicFunction.S_Left(st1,4));
				st1=PublicFunction.S_Right(st1,st1.Length-4);
				int MM=T_String.IsNullTo0(PublicFunction.S_Left(st1,2));
				st1=PublicFunction.S_Right(st1,st1.Length-2);
				int d=T_String.IsNullTo0(PublicFunction.S_Left(st1,2));
				int HH=T_String.IsNullTo0( PublicFunction.S_Left(time,2));
				int mm=T_String.IsNullTo0( PublicFunction.S_Right(time,2));
				DateTime dt=new DateTime( y,MM,d,HH,mm,0,0);
				return dt;
			}
			catch(Exception)
			{
				return new DateTime(1,1,1);
			}
		}
		private DateTime GetDate(string st)
		{
			try
			{
				
				string st1=st;
				int y=T_String.IsNullTo0( PublicFunction.S_Left(st1,4));
				st1=PublicFunction.S_Right(st1,st1.Length-4);
				int MM=T_String.IsNullTo0(PublicFunction.S_Left(st1,2));
				st1=PublicFunction.S_Right(st1,st1.Length-2);
				int d=T_String.IsNullTo0(PublicFunction.S_Left(st1,2));
				DateTime dt=new DateTime(y,MM,d);
				return dt;
			}
			catch(Exception)
			{
				return new DateTime(1,1,1);
			}
		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void frmTaTransferFromTXT_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			stop=true;
		}

	}
}

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
using System.Text;

namespace GP8000.Attendance
{
	/// <summary>
	/// Summary description for frmTaGetDataFrDT.
	/// </summary>
	public class frmTaGetDataFrDT : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private Navigator1._0.NavigatorAuto nav;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
		private C1.Win.C1FlexGrid.C1FlexGrid vs;
		private System.Windows.Forms.Label c1;
		private System.Windows.Forms.Label c2;
		private System.Windows.Forms.Button button1;
		private ArrayList EMP_ID,CRD_NO;
		private int CRD_MN;
		private Boolean stop,fin1,fin2;
		private string BT;
		private Double d1,d2;
		private string dt;// ngay hien tai
		private SqlConnection con11,con21;
		private AxDT.AxDT6000 dt1;
		private AxDT.AxDT6000 dt2;
		private System.Windows.Forms.Label l2;
		private System.Windows.Forms.Label l1;
		private System.Windows.Forms.ListBox lb4;
		private System.Windows.Forms.ListBox lb2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaGetDataFrDT()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmTaGetDataFrDT));
			this.label5 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.vs = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.l2 = new System.Windows.Forms.Label();
			this.c1 = new System.Windows.Forms.Label();
			this.l1 = new System.Windows.Forms.Label();
			this.nav = new Navigator1._0.NavigatorAuto();
			this.c2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.dt1 = new AxDT.AxDT6000();
			this.dt2 = new AxDT.AxDT6000();
			this.lb4 = new System.Windows.Forms.ListBox();
			this.lb2 = new System.Windows.Forms.ListBox();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
			this.panel4.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dt1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dt2)).BeginInit();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label5.Dock = System.Windows.Forms.DockStyle.Top;
			this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Location = new System.Drawing.Point(0, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(784, 36);
			this.label5.TabIndex = 12;
			this.label5.Tag = "";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 36);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(784, 456);
			this.panel1.TabIndex = 13;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.panel5);
			this.panel3.Controls.Add(this.panel4);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(784, 356);
			this.panel3.TabIndex = 1;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.dt1);
			this.panel5.Controls.Add(this.dt2);
			this.panel5.Controls.Add(this.vs);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(0, 0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(516, 356);
			this.panel5.TabIndex = 1;
			// 
			// vs
			// 
			this.vs.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vs.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs.Location = new System.Drawing.Point(0, 0);
			this.vs.Name = "vs";
			this.vs.Size = new System.Drawing.Size(516, 356);
			this.vs.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs.TabIndex = 13;
			this.vs.Tag = "";
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.lb2);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel4.Location = new System.Drawing.Point(516, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(268, 356);
			this.panel4.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.button1);
			this.panel2.Controls.Add(this.c2);
			this.panel2.Controls.Add(this.l2);
			this.panel2.Controls.Add(this.c1);
			this.panel2.Controls.Add(this.l1);
			this.panel2.Controls.Add(this.lb4);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 356);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(784, 100);
			this.panel2.TabIndex = 0;
			// 
			// l2
			// 
			this.l2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.l2.Dock = System.Windows.Forms.DockStyle.Top;
			this.l2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.l2.ForeColor = System.Drawing.Color.RoyalBlue;
			this.l2.Location = new System.Drawing.Point(0, 46);
			this.l2.Name = "l2";
			this.l2.Size = new System.Drawing.Size(784, 23);
			this.l2.TabIndex = 10;
			this.l2.Tag = "N";
			this.l2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.l2.Visible = false;
			// 
			// c1
			// 
			this.c1.BackColor = System.Drawing.Color.Black;
			this.c1.Dock = System.Windows.Forms.DockStyle.Top;
			this.c1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.c1.ForeColor = System.Drawing.Color.White;
			this.c1.Location = new System.Drawing.Point(0, 23);
			this.c1.Name = "c1";
			this.c1.Size = new System.Drawing.Size(784, 23);
			this.c1.TabIndex = 7;
			this.c1.Tag = "N";
			this.c1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// l1
			// 
			this.l1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.l1.Dock = System.Windows.Forms.DockStyle.Top;
			this.l1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.l1.ForeColor = System.Drawing.Color.RoyalBlue;
			this.l1.Location = new System.Drawing.Point(0, 0);
			this.l1.Name = "l1";
			this.l1.Size = new System.Drawing.Size(784, 23);
			this.l1.TabIndex = 1;
			this.l1.Tag = "N";
			this.l1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// nav
			// 
			this.nav.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.nav.Connection = null;
			this.nav.ConnectionDel = null;
			this.nav.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.nav.form = null;
			this.nav.FormName = null;
			this.nav.Grid = null;
			this.nav.History = false;
			this.nav.IsNull = true;
			this.nav.Language = "EN";
			this.nav.Location = new System.Drawing.Point(12, 4);
			this.nav.MSG_Exit = false;
			this.nav.MulltiDel = false;
			this.nav.Name = "nav";
			this.nav.Security = 0;
			this.nav.ShowPopupMenu = false;
			this.nav.Size = new System.Drawing.Size(472, 32);
			this.nav.TabIndex = 14;
			this.nav.ToolBar_Auto = true;
			this.nav.UserID = null;
			this.nav.Visible = false;
			this.nav.VisibleGrid = true;
			this.nav.Where = null;
			// 
			// c2
			// 
			this.c2.BackColor = System.Drawing.Color.Black;
			this.c2.Dock = System.Windows.Forms.DockStyle.Top;
			this.c2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.c2.ForeColor = System.Drawing.Color.White;
			this.c2.Location = new System.Drawing.Point(0, 69);
			this.c2.Name = "c2";
			this.c2.Size = new System.Drawing.Size(784, 23);
			this.c2.TabIndex = 11;
			this.c2.Tag = "N";
			this.c2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.c2.Visible = false;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(344, 52);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(108, 36);
			this.button1.TabIndex = 12;
			this.button1.Text = "Stop";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dt1
			// 
			this.dt1.ContainingControl = this;
			this.dt1.Enabled = true;
			this.dt1.Location = new System.Drawing.Point(48, 188);
			this.dt1.Name = "dt1";
			this.dt1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("dt1.OcxState")));
			this.dt1.Size = new System.Drawing.Size(80, 27);
			this.dt1.TabIndex = 7;
			this.dt1.Visible = false;
			// 
			// dt2
			// 
			this.dt2.ContainingControl = this;
			this.dt2.Enabled = true;
			this.dt2.Location = new System.Drawing.Point(112, 116);
			this.dt2.Name = "dt2";
			this.dt2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("dt2.OcxState")));
			this.dt2.Size = new System.Drawing.Size(80, 27);
			this.dt2.TabIndex = 8;
			this.dt2.Visible = false;
			// 
			// lb4
			// 
			this.lb4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lb4.ItemHeight = 16;
			this.lb4.Location = new System.Drawing.Point(0, 0);
			this.lb4.Name = "lb4";
			this.lb4.Size = new System.Drawing.Size(784, 100);
			this.lb4.TabIndex = 13;
			this.lb4.Visible = false;
			// 
			// lb2
			// 
			this.lb2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lb2.ItemHeight = 16;
			this.lb2.Location = new System.Drawing.Point(0, 0);
			this.lb2.Name = "lb2";
			this.lb2.Size = new System.Drawing.Size(268, 356);
			this.lb2.TabIndex = 6;
			// 
			// frmTaGetDataFrDT
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(784, 492);
			this.Controls.Add(this.nav);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label5);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaGetDataFrDT";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmTaGetDataFrDT";
			this.Load += new System.EventHandler(this.frmTaGetDataFrDT_Load);
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dt1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dt2)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaGetDataFrDT_Load(object sender, System.EventArgs e)
		{			
			PublicFunction.InitNav(this,vs,nav);	
			nav.Msg_ExitSave=true;
			nav.Show_VS("ATT_BT=1");								
			nav.ToolBar_Auto=false;
			Basic.Function.PublicFunction.L_Init_Label(this);
			vs.AllowEditing=false;
			
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
			//th1.Start();
		}

		private void Transfer1()
		{	
			//			try
			//			{						
			con11=new SqlConnection(PublicFunction.C_con.ConnectionString);
			con11.Open();
			d1=0;						
			for(int f=1;f<vs.Rows.Count;f++)
			{			
				if(vs.Rows[f]["FIN"]+""=="FIN")
					break;
				vs.Rows[f]["FIN"]="FIN";
				vs.Rows[f]["SAT"]="Downloading";
				vs.AutoSizeCols();
				try
				{
					string st="";					
					string ip=vs.Rows[f]["ADD_IP"]+"";						
					string MCH_ID=vs.Rows[f]["MCH_ID"]+"";					
					l1.Text=MCH_ID+" - "+ ip;
					if(dt1.Connect(ip)!="1")
					{														
						vs.Rows[f]["SAT"]="Fail!!!";						
					}
					else
					{
						string tm=DateToHex(T_String.GetDate());
						st=dt1.SetTime(tm);	
						while (true)
						{
							if(stop)
							{
								dt1.Disconnect();
								con11.Close();
								return;
							}
							st=dt1.GetRecord();							
							if(st.Length<20)
							{
								if(st+""=="" || st+""=="1" || st+""=="-3")
								{
									vs.Rows[f]["SAT"]="Finished!!!";
									dt1.Disconnect();
									break;
								}					
								// loi
								vs.Rows[f]["SAT"]="Fail!!!";
								dt1.Disconnect();
								break;
							}
							else
							{								
								int gt=T_String.IsNullTo0(PublicFunction.S_Left(st,2));
								if( (gt>0 && gt<=77) ||  PublicFunction.S_Left(st,2)=="00" )
								{
									string tam=PublicFunction.S_Right("000"+MCH_ID,3)+"20";
									//lb2.Items.Add("st:"+st);
									string st1=st.Remove(0,2);									
									tam=PublicFunction.S_Right("000"+MCH_ID,3)+st1;
									//lb2.Items.Add("tam:"+tam);
									try
									{
										Data_AQ800(tam,"DT6000",con11,"0");
									}
									catch
									{
										vs.Rows[f]["SAT"]="Fail!!!";
										dt1.Disconnect();
									}
								}
							}
						}	
					}
				}
				catch (IOException ex)
				{
					MessageBox.Show("File :"+ ex.Message);
					return;
				}
			}
			
			c1.Text=c1.Text+". Completed!";
			con11.Close();
			fin1=true;
//			if(fin2)
//			{
//				if(BT+""!="")
//					MessageBox.Show(BT);
				//this.Close();
		//	}
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
			
			for(int f=vs.Rows.Count-1;f>0;f--)
			{			
				if(vs.Rows[f]["FIN"]+""=="FIN")
					break;
				vs.Rows[f]["FIN"]="FIN";
				vs.Rows[f]["SAT"]="Downloading";
				try
				{
					string st="";					
					string ip=vs.Rows[f]["ADD_IP"]+"";	
					string MCH_ID=vs.Rows[f]["MCH_ID"]+"";	
					l2.Text=MCH_ID+" - "+ ip;
					if(dt2.Connect(ip)!="1")
					{
						vs.Rows[f]["SAT"]="Fail!!!";						
					}
					else
					{		
						while (true)
						{
							if(stop)
							{
								dt2.Disconnect();
								con11.Close();
								return;
							}
							st=dt1.GetRecord();
							if(st.Length<4)
							{
								if(st+""=="" || st+""=="1" || st+""=="-3")
								{
									vs.Rows[f]["SAT"]="Finished!!!";
									dt2.Disconnect();
									break;
								}					
								// loi
								vs.Rows[f]["SAT"]="Fail!!!";
								dt2.Disconnect();
								break;
							}
							else
							{				
								int gt=T_String.IsNullTo0(PublicFunction.S_Left(st,2));
								if( (gt>0 && gt<=77) ||  PublicFunction.S_Left(st,2)=="00" )
								{
									string tam=PublicFunction.S_Right("000"+MCH_ID,3)+"20";
									//lb2.Items.Add("st:"+st);
									string st1=st.Remove(0,2);									
									tam=PublicFunction.S_Right("000"+MCH_ID,3)+st1;
									//lb2.Items.Add("tam:"+tam);
									try
									{
										Data_AQ800(tam,"DT6000",con21,"1");
									}
									catch
									{
										vs.Rows[f]["SAT"]="Fail!!!";
										dt2.Disconnect();
									}
								}
							}
						}	
					}
				}
				catch (IOException ex)
				{
					MessageBox.Show("File :"+ ex.Message);
					return;
				}
			}
		
			c2.Text=c2.Text+". Completed!";
			con21.Close();
			fin2=true;
			if(fin1)
			{
				if(BT+""!="")
					MessageBox.Show(BT);
				//this.Close();
			}
			//			}
			//			catch (Exception ex)
			//			{
			//				MessageBox.Show( ex.Message);
			//			}
		}

		#region Function
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
	
		
		private void WriteFile(string dt,string txt)
		{		
//			try
//			{			
			string filename=dt+".txt";
			if(!Directory.Exists(PublicFunction.Path +"\\BackupTxt\\"))
				Directory.CreateDirectory(PublicFunction.Path +"\\BackupTxt\\");
			FileStream f=File.Open(PublicFunction.Path +"\\BackupTxt\\"+filename,FileMode.OpenOrCreate);		
			
			f.Position=f.Length;
			byte []data=new byte[1024];
			string st=PublicFunction.code(txt,"");
			data=Encoding.ASCII.GetBytes(st+"\r\n");			
			f.Write(data,0,data.Length);			
			f.Close();			
//			}
//			catch(Exception){}
		}

		private void Data_AQ800(string st1,string filename,SqlConnection con,string SEQ_NO)
		{
			try
			{
				string st=st1;
				string REA_NO=PublicFunction.S_Left(st,3);
				st=PublicFunction.S_Right(st,st.Length-3);
				string CRD_NO=PublicFunction.S_Left(st,10);			
				st="20"+PublicFunction.S_Right(st,st.Length-10);
				string CRD_DT=PublicFunction.S_Left(st,8);
				st=PublicFunction.S_Right(st,st.Length-8);
				string CRD_TM=PublicFunction.S_Left(st,4);			
				Double TM= T_String.IsNullTo00(PublicFunction.S_Left(st,4));
				
				DateTime dt1=GetDateTime(CRD_DT,CRD_TM).AddMinutes(-CRD_MN);
				DateTime dt2=GetDateTime(CRD_DT,CRD_TM).AddMinutes(CRD_MN);

				WriteFile(CRD_DT,REA_NO+CRD_NO+CRD_DT+CRD_TM);
									
				string sql="",EMP_ID;
				sql="Delete from FILC01A where DAT_TM=N'"+CRD_DT+CRD_TM+"' and CRD_NO=N'"+CRD_NO+"'";
				PublicFunction.SQL_Execute(sql,con);
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
			catch(Exception)
			{
					throw;

					//BT+=st1+"--- "+SEQ_NO+"----"+filename+" \n";
			}
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

		private string DateToHex(DateTime dt)
		{				
			string yy ,mm,dd,hh,pp,ss,th1;	
			int th=0;
			switch(dt.DayOfWeek.ToString())
			{
				case "Sunday":
					th=0;
					break;
				case "Monday":
					th=1;
					break;
				case "Tuesday":
					th=2;
					break;
				case "Wednesday":
					th=3;
					break;
				case "Thursday":
					th=4;
					break;
				case "Friday":
					th=5;
					break;
				case "Saturday":
					th=5;
					break;

			}
			yy= DecToHex(int.Parse(dt.ToString("yy")));
			mm= DecToHex(int.Parse(dt.ToString("MM")));			
			dd= DecToHex(int.Parse(dt.ToString("dd")));
			th1= DecToHex(th );
			hh= DecToHex(int.Parse(dt.ToString("HH")));
			pp= DecToHex(int.Parse(dt.ToString("mm")));
			ss= DecToHex(int.Parse(dt.ToString("ss")) );
			
			
			return yy+mm+dd+th1+hh+pp+ss;
		}


		private string DecToHex(int dec)
		{
			string hexa = "0123456789ABCDEF";
			string hex="";
			int tmp=0;
			while (dec>15) 
			{	
				
				tmp=dec-(int)(Math.Floor(dec/16))*16; 
				hex=hexa[tmp]+hex;
				dec=(int) Math.Floor(dec/16);
			}
	
			hex=hexa[dec]+hex;
			return  PublicFunction.S_Right((00+(hex)),2);
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

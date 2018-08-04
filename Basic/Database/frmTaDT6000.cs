using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Basic.Form;
using Basic.Function;
using System.Threading;

namespace GP8000.Database
{
	/// <summary>
	/// Summary description for frmTaDT6000.
	/// </summary>
	public class frmTaDT6000 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel4;
		private Navigator1._0.NavigatorAuto nav;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel panel6;
		private C1.Win.C1FlexGrid.C1FlexGrid vs;
		private System.Windows.Forms.Button cmd_test;
		private System.Windows.Forms.Button cmd_time;
		private System.Windows.Forms.Button cmd_getTime;
		private AxDT.AxDT6000 dt;
		private System.Windows.Forms.Button cmd_close;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaDT6000()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmTaDT6000));
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.vs = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.panel5 = new System.Windows.Forms.Panel();
			this.cmd_close = new System.Windows.Forms.Button();
			this.dt = new AxDT.AxDT6000();
			this.cmd_getTime = new System.Windows.Forms.Button();
			this.cmd_time = new System.Windows.Forms.Button();
			this.cmd_test = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.nav = new Navigator1._0.NavigatorAuto();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dt)).BeginInit();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(556, 424);
			this.panel1.TabIndex = 13;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.panel6);
			this.panel2.Controls.Add(this.splitter1);
			this.panel2.Controls.Add(this.panel5);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 36);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(556, 388);
			this.panel2.TabIndex = 12;
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.vs);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel6.Location = new System.Drawing.Point(0, 0);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(412, 388);
			this.panel6.TabIndex = 2;
			// 
			// vs
			// 
			this.vs.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vs.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs.Location = new System.Drawing.Point(0, 0);
			this.vs.Name = "vs";
			this.vs.Size = new System.Drawing.Size(412, 388);
			this.vs.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs.TabIndex = 12;
			this.vs.Tag = "";
			// 
			// splitter1
			// 
			this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
			this.splitter1.Location = new System.Drawing.Point(412, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(4, 388);
			this.splitter1.TabIndex = 1;
			this.splitter1.TabStop = false;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.LightSteelBlue;
			this.panel5.Controls.Add(this.cmd_close);
			this.panel5.Controls.Add(this.dt);
			this.panel5.Controls.Add(this.cmd_getTime);
			this.panel5.Controls.Add(this.cmd_time);
			this.panel5.Controls.Add(this.cmd_test);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel5.Location = new System.Drawing.Point(416, 0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(140, 388);
			this.panel5.TabIndex = 0;
			// 
			// cmd_close
			// 
			this.cmd_close.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_close.Location = new System.Drawing.Point(13, 119);
			this.cmd_close.Name = "cmd_close";
			this.cmd_close.Size = new System.Drawing.Size(112, 28);
			this.cmd_close.TabIndex = 4;
			this.cmd_close.Text = "Close";
			this.cmd_close.Click += new System.EventHandler(this.cmd_close_Click);
			// 
			// dt
			// 
			this.dt.ContainingControl = this;
			this.dt.Enabled = true;
			this.dt.Location = new System.Drawing.Point(36, 320);
			this.dt.Name = "dt";
			this.dt.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("dt.OcxState")));
			this.dt.Size = new System.Drawing.Size(80, 27);
			this.dt.TabIndex = 3;
			this.dt.Visible = false;
			// 
			// cmd_getTime
			// 
			this.cmd_getTime.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_getTime.Location = new System.Drawing.Point(15, 82);
			this.cmd_getTime.Name = "cmd_getTime";
			this.cmd_getTime.Size = new System.Drawing.Size(112, 28);
			this.cmd_getTime.TabIndex = 2;
			this.cmd_getTime.Text = "Get Time";
			this.cmd_getTime.Click += new System.EventHandler(this.cmd_getTime_Click);
			// 
			// cmd_time
			// 
			this.cmd_time.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_time.Location = new System.Drawing.Point(15, 45);
			this.cmd_time.Name = "cmd_time";
			this.cmd_time.Size = new System.Drawing.Size(112, 28);
			this.cmd_time.TabIndex = 1;
			this.cmd_time.Text = "Set Time";
			this.cmd_time.Click += new System.EventHandler(this.cmd_time_Click);
			// 
			// cmd_test
			// 
			this.cmd_test.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_test.Location = new System.Drawing.Point(15, 8);
			this.cmd_test.Name = "cmd_test";
			this.cmd_test.Size = new System.Drawing.Size(112, 28);
			this.cmd_test.TabIndex = 0;
			this.cmd_test.Text = "Test Connection";
			this.cmd_test.Click += new System.EventHandler(this.cmd_test_Click);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.panel4);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(556, 36);
			this.panel3.TabIndex = 11;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Location = new System.Drawing.Point(416, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(140, 36);
			this.label5.TabIndex = 11;
			this.label5.Tag = "";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.nav);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(416, 36);
			this.panel4.TabIndex = 10;
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
			this.nav.Location = new System.Drawing.Point(3, 2);
			this.nav.MSG_Exit = false;
			this.nav.MulltiDel = false;
			this.nav.Name = "nav";
			this.nav.Security = 0;
			this.nav.ShowPopupMenu = false;
			this.nav.Size = new System.Drawing.Size(472, 32);
			this.nav.TabIndex = 9;
			this.nav.ToolBar_Auto = true;
			this.nav.UserID = null;
			this.nav.VisibleGrid = true;
			this.nav.Where = null;
			// 
			// frmTaDT6000
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(556, 424);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaDT6000";
			this.Text = "frmTaDT6000";
			this.Load += new System.EventHandler(this.frmTaDT6000_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			this.panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dt)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaDT6000_Load(object sender, System.EventArgs e)
		{
			nav.cmd_copy.Visible=false;
			nav.cmd_report.Visible=false;
			nav.cmd_search.Visible=false;
			PublicFunction.InitNav(this,vs,nav);	
		//	nav.Msg_ExitSave=true;
			nav.Show_VS();			
							
			nav.ToolBar_Auto=false;
			Basic.Function.PublicFunction.L_Init_Label(this);	
			nav.TBarClick+=new ToolBarButtonClickEventHandler(nav_TBarClick);	
		}		
		
		private void nav_TBarClick(object sender, ToolBarButtonClickEventArgs e)
		{					
			if (e.Button.Equals(nav.cmd_add))
			{
				if (vs.Rows.Count==1 || (int)vs.Rows[vs.Rows.Count-1].UserData!=2)					
					nav.ToolBar_Click(e);									
				vs.Rows[vs.Rows.Count-1]["SEQ_NO"]=T_String.GetMax("MAX(SEQ_NO)","FILA17AA");
				vs.Rows[vs.Rows.Count-1]["ATT_BT"]=1;
				vs.Rows[vs.Rows.Count-1]["CON_TP"]=1;
				return;
			}			
			nav.ToolBar_Click(e);
		}

		private void cmd_close_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void cmd_test_Click(object sender, System.EventArgs e)
		{
			Thread th=new Thread(new ThreadStart(test));
			th.Start();
		}

		private void test()
		{
			for(int i=1;i<vs.Rows.Count;i++)
			{
				try
				{
					string ip=vs.Rows[i]["ADD_IP"]+"";
					if(ip+""=="")
					{
						vs.Rows[i]["SAT_DR"]=PublicFunction.L_Get_Msg("DT",0);
					}	
					else
					{
						if(dt.Connect(ip)=="1")
						{
							vs.Rows[i]["SAT_DR"]=PublicFunction.L_Get_Msg("DT",1);
							dt.Disconnect();
						}
						else
						{
							vs.Rows[i]["SAT_DR"]=PublicFunction.L_Get_Msg("DT",0);
						}
					}					
				}
				catch{vs.Rows[i]["SAT_DR"]=PublicFunction.L_Get_Msg("DT",0);}
			}
			vs.AutoSizeCols();
		}

		private void cmd_time_Click(object sender, System.EventArgs e)
		{
			Thread th=new Thread(new ThreadStart(SetTime));
			th.Start();		
		}

		private void SetTime()
		{
			for(int i=1;i<vs.Rows.Count;i++)
			{
				try
				{
					string ip=vs.Rows[i]["ADD_IP"]+"";
					if(ip=="")
					{
						vs.Rows[i]["SAT_DR"]=PublicFunction.L_Get_Msg("DT",0);
					}	
					else
					{
						if(dt.Connect(ip)=="1")
						{
							string st=DateToHex( T_String.GetDate() );
							st=dt.SetTime(st);			
							if(st+""=="1")								
								vs.Rows[i]["SAT_DR"]=PublicFunction.L_Get_Msg("DT",1);
							else
								vs.Rows[i]["SAT_DR"]=PublicFunction.L_Get_Msg("DT",0);
							dt.Disconnect();
						}
					}					
				}
				catch
				{
					vs.Rows[i]["SAT_DR"]=PublicFunction.L_Get_Msg("DT",0);
				}
			}	
			vs.AutoSizeCols();
		}

		#region Func
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
			return S_Right((00+(hex)),2);
		}

		public string hexToDec(string hex)
		{
			hex=hex.ToUpper();
			string hexa = "0123456789ABCDEF";
			int len = hex.Length - 1;
			int dec = 0;

			for (int i = 0; i <= len; i++ )
			{
				int tam = len - i;
				int index = hexa.IndexOf(hex[i]);
				dec += index * luythua(16, tam);
			}

			return dec.ToString("00");
		}

		//Ham tinh x luy thua y
		public int luythua(int x, int y)
		{
			int ketqua = 1;
			for (int i = 0; i < y; i++)
				ketqua *= x;
			return ketqua;
		}

		public static string S_Right(string st,int count)
		{
			if (count>st.Length)
				return "";
			return st.Remove(0,st.Length-count);
		}

		public static string S_Left(string st,int count)
		{
			if (count>st.Length)
				return "";
			return st.Remove(count,st.Length-count);
		}

		private string HexToDate(string date)
		{
			string yy,mm,dd,hh,pp,ss,st,th;
			st=date;
			yy= hexToDec(S_Left(st,2));
			st=S_Right(st,st.Length-2);

			mm=hexToDec(S_Left(st,2));
			st=S_Right(st,st.Length-2);

			dd=hexToDec(S_Left(st,2));
			st=S_Right(st,st.Length-2);

			th=hexToDec(S_Left(st,2));
			st=S_Right(st,st.Length-2);

			hh=hexToDec(S_Left(st,2));
			st=S_Right(st,st.Length-2);

			pp=hexToDec(S_Left(st,2));			
			st=S_Right(st,st.Length-2);

			ss=hexToDec(S_Left(st,2));
			
			return yy+mm+dd+hh+pp+ss;
		}

		#endregion

		private void cmd_getTime_Click(object sender, System.EventArgs e)
		{
			Thread th=new Thread(new ThreadStart(GetTime));
			th.Start();		
		}

		private void GetTime()
		{
			for(int i=1;i<vs.Rows.Count;i++)
			{
				try
				{
					string ip=vs.Rows[i]["ADD_IP"]+"";
					if(ip=="")
					{
						vs.Rows[i]["SAT_DR"]=PublicFunction.L_Get_Msg("DT",0);
					}	
					else
					{
						if(dt.Connect(ip)=="1")
						{
							string st;
							st=dt.GetTime();	
							if(st.Length>4)					
								vs.Rows[i]["SAT_DR"]=HexToDate(st);
							else
								vs.Rows[i]["SAT_DR"]=PublicFunction.L_Get_Msg("DT",0);
							dt.Disconnect();
						}
					}					
				}
				catch
				{
					vs.Rows[i]["SAT_DR"]=PublicFunction.L_Get_Msg("DT",0);
				}
			}		
			vs.AutoSizeCols();
		}
	}
}

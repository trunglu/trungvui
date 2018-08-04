// 12/05/2008 Begin

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Basic.Form;
using Basic.Function;
using Navigator1;
using GP8000.Database;
using GP8000.Personnel;
using GP8000.Attendance;
using System.Drawing.Drawing2D;
using System.Threading;
using GP8000.SYSForm;
using GP8000.Payroll;
using GP8000.Reports;
using GP8000.CardComparison ;
using GP8000.Product;
using GP8000.GPS;
using GP8000.Backup;


namespace Basic
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmMDI : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mnu;
		private MenuItem [] submnu;
		private ArrayList SubMenu;		
		private System.Windows.Forms.StatusBar status;
		private System.Windows.Forms.StatusBarPanel sta1;
		private System.Windows.Forms.StatusBarPanel sta2;
		private System.Windows.Forms.StatusBarPanel sta3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private Dev4Arabs.OfficeMenus M;
		private System.ComponentModel.IContainer components;
		Boolean close;		
		int i;
		string lb;
		
		public frmMDI()
		{
			//
			// Required for Windows Form Designer support
			//
			
			//			if (System.Diagnostics.Process.GetProcessesByName(System.Diagnostics.Process.GetCurrentProcess().ProcessName).Length>1)
			//				System.Diagnostics.Process.GetCurrentProcess().Kill();			
			//System.Diagnostics.Process.GetCurrentProcess().PriorityClass=System.Diagnostics.ProcessPriorityClass.High;
			
			InitializeComponent();
			
			PublicFunction.CUS_ID=PublicFunction.F_GetNote("[CUS_ID]",PublicFunction.Path+"//CUS.ini");	
			CUS_GPS();
			i=0;
			//lb="Glinton Vĩnh Tuyền "+ this.Text ;										
			PublicFunction.Init_System();

		//khoa GP TU DONG
			string ss="";
			Func.RecordSet rsk=new Func.RecordSet("select * from dbo.sysobjects where id = object_id('GP_KEY')",PublicFunction.C_con);
			if (rsk.rows <=0)
			{
				ss="CREATE TABLE GP_KEY (COL_MN int,COL_DT nvarchar(100),TYP_MN nvarchar(2) )";
				PublicFunction.SQL_Execute(ss,PublicFunction.C_con);
				ss="INSERT INTO GP_KEY VALUES(1,'"+ PublicFunction.code("2100/12/31","")+"','no')" ;
				PublicFunction.SQL_Execute(ss,PublicFunction.C_con);
			}
			//them vao cuoi pass moi user *** de ko xai lai phien ban cu trc khi tao khoa
//			if(PublicFunction.CUS_ID!="3")//weisheng da cap nhat roi
//			{
//				ss="UPDATE SYS_USER SET PASS=PASS+'***' WHERE RIGHT(PASS,3)!='***'";
//				PublicFunction.SQL_Execute(ss,PublicFunction.C_con);
//			}
			ss="UPDATE SYS_USER SET PASS=LEFT(PASS,LEN(PASS)-3)  WHERE RIGHT(PASS,3)='***'";
			PublicFunction.SQL_Execute(ss,PublicFunction.C_con);
			//end user
		// end khoa
//			if(PublicFunction.CUS_ID!="22")//great super da cap nhat roi
//			{
//				if (!T_String.CheckColumnInTable("SUM_BT", "GP_SYS_SETTING"))
//				{
//					string ssql;
//					ssql = "ALTER TABLE GP_SYS_SETTING ADD SUM_BT BIT NULL";
//					PublicFunction.SQL_Execute(ssql);
//				}
//			}
			PublicFunction.L_Init_Label(this);	
			string id=System.Diagnostics.Process.GetCurrentProcess().Id+"";
			string id1=PublicFunction.F_GetNote("[ID]",PublicFunction.Path+"\\ID.ini");
			try
			{
				if(id!=id1 && System.Diagnostics.Process.GetProcessById(T_String.IsNullTo0(id1)).ProcessName=="GP8000" )
				{
					System.Diagnostics.Process.GetCurrentProcess().Kill();	
				}
			}
			catch{}
			PublicFunction.SaveID(id);
			//System.Diagnostics.Process.GetProcessById(1).ProcessName
			sta3.Text=T_String.GetDate().ToString("yyyy/MM/dd");
			frmLogin dlg=new frmLogin(true);			
			dlg.ShowDialog();
			if (dlg.DialogResult==DialogResult.OK)
			{								
				Func.RecordSet rs=new Func.RecordSet("Select GROUP_NM,a.GROUP_ID from SYS_USER a,SYS_GROUP b"+ 
					" where USER_ID=N'"+PublicFunction.A_UserID+"' and a.GROUP_ID=b.GROUP_ID",PublicFunction.C_con);
				if (rs.rows>0)
				{
					Func.RecordSet rscomp=new Func.RecordSet("Select COM_N1 from FILA01A",PublicFunction.C_con);
					sta1.Text=PublicFunction.A_UserID+"/"+rs.record(0,0)+" - "+ rscomp.record(0,0);
					PublicFunction.A_Group_ID=rs.record(0,1);
				}
				Init_Menu();
			}		
			else
			{					
				System.Diagnostics.Process.GetCurrentProcess().Kill();						
			}

			string sql="";
//			sql="Delete from FILC06A where ATT_DT>='"+DateTime.Parse(rs.record(i,"VAC_DT")+"").ToString("yyyy/MM/dd")
//							+"' and EMP_ID=N'"+rs.record(i,"EMP_ID")+"'";
//						PublicFunction.SQL_Execute(sql,con1);
//						break;

			sql="Update FILB01A set VAC_BT=1,CRD_NO='' where (VAC_BT=0 OR VAC_BT is null) and   EMP_ID";
			sql+=" in (Select EMP_ID from FILB01AC where VAC_DT<=GetDate())"; // and (VAT_BT=1) ) ";
			PublicFunction.SQL_Execute(sql);	
			sql="Update FILB01AC set VAT_BT=0 where VAC_DT<=GetDate() and (VAT_BT=1)  ";
			PublicFunction.SQL_Execute(sql);	
			sql="Update FILB01A set VAC_BT=0 where (VAC_BT=1) and   EMP_ID";
			sql+=" not in (Select EMP_ID from FILB01AC )"; // and (VAT_BT=1) ) ";
			PublicFunction.SQL_Execute(sql);
//			if(PublicFunction.C_con.State==ConnectionState.Open)
//			{
//				lb=T_String.GetDataFromSQL("MSG_DR","GP_SYS_MESSAGE");
//			}
//			else
//				lb="Taiwan: 台北市民生東路五段171號4樓之2 "+
//					"Tel: 8862-27648036 Fax: 8862-27617048 "+
//					"Email: service@glinton.com.tw " +
				lb=	"Việt Nam:" +
					"Công Ty TNHH Vĩnh Tuyền 永泉資訊有限公司 "+
					"40/12 Lam Sơn P.2, Q.Tân Bình,TP. HCM "+
					"Tel:848-2968469/70 Fax:848-2968473 "+
					"Email:vnservice@glinton.com.tw ";		
			//pictureBox1.Paint+=new PaintEventHandler(pictureBox1_Paint);

			switch (PublicFunction.CUS_ID)
			{
				case "100":
					if(T_String.IsNullTo0(T_String.GetDate().ToString("yyyyMMdd"))>20100815)
					{
						//PublicFunction.SQL_Execute("Delete from SYS_LABEL");
//						MessageBox.Show(PublicFunction.L_Get_Msg("msg",222));
						System.Diagnostics.Process.GetCurrentProcess().Kill(); 
					}
					break;

			}			
		}

		private void Customer()
		{		
			try
			{
				BK(false);
				try
				{
					submnu[97].Visible=false;	
				}
				catch{}
				try
				{
				submnu[102].Visible=false;	
				}
				catch{}

				switch (PublicFunction.CUS_ID)
				{
					case "0":
						submnu[106].Visible=true;
						submnu[102].Visible=true;
						submnu[97].Visible=true;
						BK(true);
						break;
					case "7": // Demo
						submnu[97].Visible=true;
						break;
					case "2": // majestic
						submnu[102].Visible=true;
						break;
					case "9": // place,tunglung
						PublicFunction.CUS_GPS=true;
						break;
					case "17": // textma
						PublicFunction.CUS_GPS=true;
						break;
					case "12": // ki works
						PublicFunction.CUS_GPS=true;
						break;
					case "22": // Great super
						PublicFunction.CUS_GPS=true;
						break;
					case "3": // weisheng
						PublicFunction.CUS_GPS=true;
						break;
					case "300": // KenYa
						PublicFunction.CUS_GPS=true;
						break;
					case "50": // Quang Viet
						PublicFunction.CUS_GPS=true;
						break;
					case "51": // Quang Viet TG
						PublicFunction.CUS_GPS=true;
						break;
				}	
			}
			catch{}
			GPS();
		}
		private void CUS_GPS()
		{
			try
			{				
				switch (PublicFunction.CUS_ID)
				{
					case "0":											
					case "9": // place
						PublicFunction.CUS_GPS=true;
						break;
					case "17": // textma
						PublicFunction.CUS_GPS=true;
						break;
					case "12": // ki works
						PublicFunction.CUS_GPS=true;
						break;
					case "22": // Great Super
						PublicFunction.CUS_GPS=true;
						break;
					case "3": // Weisheng
						PublicFunction.CUS_GPS=true;
						break;
					case "300": // KenYa
						PublicFunction.CUS_GPS=true;
						break;
					case "50": // QuangViet
						PublicFunction.CUS_GPS=true;
						break;
					case "51": // Quang Viet tg
						PublicFunction.CUS_GPS=true;
						break;
				}			
			}
			catch{}
		}

		private void GPS()
		{
			try
			{
				if(PublicFunction.GPS)
				{
					submnu[106].Visible=false;	
					submnu[94].Visible=false;	
				}
				else
				{
					submnu[106].Visible=PublicFunction.CUS_GPS;
				}
			}
			catch{}
		}
	
		private void BK(Boolean f)
		{
//			if(PublicFunction.A_UserID.ToUpper()!="ADMIN" && PublicFunction.A_UserID.ToUpper()!="VINHTUYEN")
//				f=false;
//			try
//			{
//				submnu[110].Visible=f;	
//				submnu[111].Visible=f;	
//				submnu[112].Visible=f;	
//			}
//			catch{}
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmMDI));
			this.mnu = new System.Windows.Forms.MainMenu();
			this.status = new System.Windows.Forms.StatusBar();
			this.sta1 = new System.Windows.Forms.StatusBarPanel();
			this.sta2 = new System.Windows.Forms.StatusBarPanel();
			this.sta3 = new System.Windows.Forms.StatusBarPanel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.M = new Dev4Arabs.OfficeMenus(this.components);
			((System.ComponentModel.ISupportInitialize)(this.sta1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sta2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sta3)).BeginInit();
			this.SuspendLayout();
			// 
			// status
			// 
			this.status.Location = new System.Drawing.Point(0, 396);
			this.status.Name = "status";
			this.status.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
																					  this.sta1,
																					  this.sta2,
																					  this.sta3});
			this.status.ShowPanels = true;
			this.status.Size = new System.Drawing.Size(603, 28);
			this.status.TabIndex = 1;
			// 
			// sta1
			// 
			this.sta1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.sta1.Text = "statusBarPanel1";
			this.sta1.Width = 234;
			// 
			// sta2
			// 
			this.sta2.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.sta2.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
			this.sta2.Width = 233;
			// 
			// sta3
			// 
			this.sta3.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.sta3.Text = "statusBarPanel1";
			this.sta3.Width = 120;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.pictureBox1.Location = new System.Drawing.Point(236, 396);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(229, 25);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// M
			// 
			this.M.ImageList = null;
			// 
			// frmMDI
			// 
			this.AutoScale = false;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(603, 424);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.status);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.Menu = this.mnu;
			this.Name = "frmMDI";
			this.Text = "Main";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Closing += new System.ComponentModel.CancelEventHandler(this.frmMDI_Closing);
			this.SizeChanged += new System.EventHandler(this.frmMDI_SizeChanged);
			this.Load += new System.EventHandler(this.frmMDI_Load);
			this.Closed += new System.EventHandler(this.frmMDI_Closed);
			((System.ComponentModel.ISupportInitialize)(this.sta1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sta2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sta3)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{			
			Application.EnableVisualStyles();
			Application.DoEvents();
			Application.Run(new frmMDI());			
		}		
		#region chu chay
		private void show()
		{
			while(true)
			{
				if(close)
					return;
				SizeF textSize;
				Graphics g = pictureBox1.CreateGraphics();
				g.Clear(Color.White);
				Brush myBrush = Brushes.Blue;
				Font myFont = new Font("Tahoma", Convert.ToSingle(12), FontStyle.Bold);
				textSize = g.MeasureString(lb, myFont);
				myBrush = new HatchBrush(HatchStyle.Shingle  , Color.Black, Color.Black);
				if(pictureBox1.Width -i<textSize.Width*-1)
					i=0;				
				HatchBrush hb = new HatchBrush(HatchStyle.Percent40,SystemColors.Control ,SystemColors.Control);
				g.FillRectangle(hb,0, 0, pictureBox1.Width, pictureBox1.Height);
				g.DrawString(lb, myFont, myBrush, pictureBox1.Width -i, (pictureBox1.Height - textSize.Height) / 2);												
				Thread.Sleep(150);
				i=i+4;
			}
		}			
		//		private void pictureBox1_Paint(object sender, PaintEventArgs e)
		//		{
		//			if(close)
		//				return;
		//			SizeF textSize;
		//			Graphics g = e.Graphics;
		//			g.Clear(Color.White);
		//			Brush myBrush = Brushes.Blue;
		//			Font myFont = new Font("Tahoma", Convert.ToSingle(12), FontStyle.Bold);
		//			textSize = g.MeasureString(lb, myFont);
		//			myBrush = new HatchBrush(HatchStyle.Shingle  , Color.Black, Color.Black);
		//			if(pictureBox1.Width -i<textSize.Width*-1)
		//				i=0;
		//			g.DrawString(lb, myFont, myBrush, 0, 0);//(pictureBox1.Height - textSize.Height) / 2);							
		//				i=i+4;
		//			Thread.Sleep(150);			
		//			HatchBrush hb = new HatchBrush(HatchStyle.ZigZag,Color.AntiqueWhite ,Color.Black);
		//			g.FillEllipse(hb,0, 0, Width-50, 30);
		//		}

		private void frmMDI_Load(object sender, System.EventArgs e)
		{		
			close=false;
			Thread th=new Thread(new ThreadStart(show));
			th.Start();			
		}

		#endregion
		#region init menu
		private void Init_Menu()
		{				
			string sql="";
			int k;
			k=0;						
			mnu.MenuItems.Clear();
			SubMenu=new ArrayList();
			Func.RecordSet rs=new Func.RecordSet("Select MAX(ID) from SYS_MENU",PublicFunction.C_con);
			if (rs.rows>0)
				k=T_String.IsNullTo0((rs.record(0,0)))+1;
			submnu=new MenuItem[k];			
			sql="Select * from SYS_MENU where (H_ID=-1 or  H_ID is null) and (HIDE<>1 or  HIDE is null) ORDER BY SEQ";
			rs=new Func.RecordSet(sql,PublicFunction.C_con);
			for (int i=0;i<rs.rows;i++)
			{
				submnu[T_String.IsNullTo0(rs.record(i,"ID"))]=new MenuItem();
				submnu[T_String.IsNullTo0(rs.record(i,"ID"))].Text=rs.record(i,PublicFunction.L_Lag);
				submnu[T_String.IsNullTo0(rs.record(i,"ID"))].Index=T_String.IsNullTo0(rs.record(i,"SEQ"));
				mnu.MenuItems.Add(i,submnu[T_String.IsNullTo0(rs.record(i,"ID"))]);
				Init_MenuItem(submnu[T_String.IsNullTo0(rs.record(i,"ID"))],T_String.IsNullTo0(rs.record(i,"ID")));				
			}				
			submnu[0].Index=rs.rows-1;			
			submnu[0].MdiList=true;						
			switch(PublicFunction.L_Lag)
			{
				case "EN":
					submnu[8].Checked=true;
					break;					
				case "CH":
					submnu[9].Checked=true;
					break;
				case "VN":
					submnu[10].Checked=true;
					break;
			}
			sql="Select MNU_ID from SYS_SECURITY a,SYS_MENU b where GROUP_ID=N'"+PublicFunction.A_Group_ID+"' and " +
				"(([ADD]=1 and [ADD] is not null) or  ([UPDATE]=1 and [UPDATE] is not null) or ([DELETE]=1 and [DELETE] is not null) or "+
				"([USAGE]=1 and [USAGE] is not null) or  ([PRINT]=1 and [PRINT] is not null)) and (b.[ID]=a.MNU_ID) and (SEC=1) and (b.HIDE=0 OR b.HIDE is null)" ;
			rs=new Func.RecordSet(sql,PublicFunction.C_con);
			for (int i=0;i<rs.rows;i++)
			{	
				if (submnu[T_String.IsNullTo0(rs.record(i,0))]!=null)
					submnu[T_String.IsNullTo0(rs.record(i,0))].Enabled=true;
			}
			for (int i=0;i<k;i++)
				SubMenu.Add(submnu[i]);			
			M.Start(this);
			if (PublicFunction.A_UserID==PublicFunction.AD_Login && PublicFunction.A_Pass==PublicFunction.AD_Key)
				submnu[5].Visible=submnu[12].Visible=submnu[59].Visible=true;
			else
				submnu[5].Visible=submnu[12].Visible=submnu[59].Visible=false;	
#if DEBUG
submnu[5].Visible=submnu[12].Visible=submnu[59].Visible=true;
#endif
			Customer();			
		}		

		private void Init_MenuItem(MenuItem mnu,int ID)
		{
			string sql;			
			sql="Select * from SYS_MENU where H_ID="+ID+"  and (HIDE<>1 or  HIDE is null) ORDER BY SEQ";
			Func.RecordSet rs=new Func.RecordSet(sql,PublicFunction.C_con);
			for (int i=0;i<rs.rows;i++)
			{
				submnu[T_String.IsNullTo0(rs.record(i,"ID"))]=new MenuItem();
				if (rs.record(i,"SEC")=="True")
					submnu[T_String.IsNullTo0(rs.record(i,"ID"))].Enabled=false;
				else
					submnu[T_String.IsNullTo0(rs.record(i,"ID"))].Enabled=true;
				submnu[T_String.IsNullTo0(rs.record(i,"ID"))].Text=rs.record(i,PublicFunction.L_Lag);
				submnu[T_String.IsNullTo0(rs.record(i,"ID"))].Index=T_String.IsNullTo0(rs.record(i,"SEQ"));
				mnu.MenuItems.Add(i,submnu[T_String.IsNullTo0(rs.record(i,"ID"))]);
				Init_MenuItem(submnu[T_String.IsNullTo0(rs.record(i,"ID"))],T_String.IsNullTo0(rs.record(i,"ID")));
			}
			if (rs.rows==0)
			{
				mnu.Click+=new EventHandler(menu_Click);				
				//mnu.Enabled=false;
			}
		}
		#endregion
		#region code
		private void Init_Label()
		{	
			this.Visible=false;
			PublicFunction.L_Init_Label(this);
			Init_Menu();	
			for(int i=0;i<this.MdiChildren.Length;i++)		
			{
				switch (this.MdiChildren[i].Name)
				{
					default:
						if (this.MdiChildren[i].Name=="frmTaRace")
						{
							frmTaRace  TaRace =new frmTaRace();
							Show_Form(TaRace ,24);		
						}
						else
						{
							PublicFunction.L_Init_Label(this.MdiChildren[i]);
							this.MdiChildren[i].Update();
						}
						break;
				}
			}
			this.Visible=true;
		}

		private void frmMDI_Closed(object sender, System.EventArgs e)
		{
			try
			{
				PublicFunction.savefileconfig();
				PublicFunction.C_con.Close();
				close=true;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void frmMDI_SizeChanged(object sender, System.EventArgs e)
		{
			pictureBox1.Width=sta2.Width+3;			
		}

		private void frmMDI_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (MessageBox.Show(this,PublicFunction.L_Get_Msg("msg",4),this.Text,MessageBoxButtons.YesNo)==DialogResult.No)
			{
				e.Cancel=true;
				
			}
			else
			{
				e.Cancel=false;
			}
		}
		private void Show_Form(System.Windows.Forms.Form f,int sec)
		{
			//			try
		{
			
			foreach (System.Windows.Forms.Form frm in this.MdiChildren)
			{
				if( frm.Name == f.Name)
				{
					frm.BringToFront();
					f.Dispose();
					return;	
				}
			}
			f.Tag=sec;
			f.MdiParent=this;
			f.WindowState=FormWindowState.Maximized;				
			f.Show();			
		}	
			//			catch(Exception ex)
			//			{
			//				MessageBox.Show ( ex.Message);
			//			}

		}

		
		#endregion

		private void menu_Click(object sender, EventArgs e)
		{			
			int ff=SubMenu.IndexOf(sender,0,SubMenu.Count);
			switch (ff)
			{
				case 2:
					this.Visible=false;
					frmLogin dlg=new frmLogin(false);
					dlg.ShowDialog();
					if (dlg.DialogResult==DialogResult.OK)
					{								
						for(int i=0;i<this.MdiChildren.Length;i++)		
						{
							this.MdiChildren[i].Close();
						}
						Func.RecordSet rs=new Func.RecordSet("Select GROUP_NM,a.GROUP_ID from SYS_USER a,SYS_GROUP b"+ 
							" where USER_ID=N'"+PublicFunction.A_UserID+"' and a.GROUP_ID=b.GROUP_ID",PublicFunction.C_con);
						if (rs.rows>0)
						{
							Func.RecordSet rscomp=new Func.RecordSet("Select COM_N1 from FILA01A",PublicFunction.C_con);
							sta1.Text=PublicFunction.A_UserID+"/"+rs.record(0,0)+" - "+rscomp.record(0,0);
							PublicFunction.A_Group_ID=rs.record(0,1);
						}
						Init_Menu();
					}
					this.Visible=true;
					break;
				case 3:
					frmChangePassword dlg1=new frmChangePassword();										
					dlg1.Tag=ff;
					dlg1.ShowDialog();
					break;
				case 4:
					frmSecurity dlgSecurity=new frmSecurity();					
					Show_Form(dlgSecurity,ff);
					break;
				case 5:
					frmSysMenu SysMenu=new frmSysMenu();
					Show_Form(SysMenu,ff);
					break;
				case 6:
					this.Close();
					break;
				case 8: //"EN"
					//((MenuItem)sender).Checked=true;
					submnu[8].Checked =true;
					submnu[9].Checked =false;
					submnu[10].Checked =false;
					submnu[58].Checked =false;
					if (PublicFunction.L_Lag!="EN")
					{
						PublicFunction.L_Lag="EN";
						Init_Label();
					}
					break;
				case 9: //"CH"
					//((MenuItem)sender).Checked=true;
					submnu[8].Checked =false;
					submnu[9].Checked =true;
					submnu[10].Checked =false;
					submnu[58].Checked =false;
					if (PublicFunction.L_Lag!="CH")
					{
						PublicFunction.L_Lag="CH";
						Init_Label();
					}
					break;
				case 10: //VN
					//((MenuItem)sender).Checked=true;
					submnu[8].Checked =false;
					submnu[9].Checked =false;
					submnu[10].Checked =true;
					submnu[58].Checked =false;
					if (PublicFunction.L_Lag!="VN")
					{
						PublicFunction.L_Lag="VN";						
						Init_Label();
					}					
					break;
				case 58: //TT
					//((MenuItem)sender).Checked=true;
					submnu[8].Checked =false;
					submnu[9].Checked =false;
					submnu[10].Checked =false;
					submnu[58].Checked =true;
					if (PublicFunction.L_Lag!="TT")
					{
						PublicFunction.L_Lag="TT";						
						Init_Label();
					}					
					break;
				case 12:
					frmControlTable dlgControlTable=new frmControlTable();
					Show_Form(dlgControlTable,ff);					
					break;
				case 59:
					frmControlTable1 dlgControlTable1=new frmControlTable1();
					Show_Form(dlgControlTable1,ff);					
					break;
				case 76:
					frmControlStateUser ControlStateUser=new frmControlStateUser();
					Show_Form(ControlStateUser,ff);					
					break;
					//*************************************************************				
				case 13:
					frmTaCompany TaCompany=new frmTaCompany();
					Show_Form(TaCompany,ff);					
					break;
				case 14:
					frmTaDepartment TaDepartment=new frmTaDepartment();
					Show_Form(TaDepartment,ff);					
					break;
				case 15:
					frmTaLeave TaLeave=new frmTaLeave();
					Show_Form(TaLeave,ff);					
					break;
				case 16:
					frmTaCity TaCity=new frmTaCity();
					Show_Form(TaCity,ff);					
					break;
				case 17:
					frmTaEducation TaEducation=new frmTaEducation();
					Show_Form(TaEducation,ff);					
					break;
				case 18:
					frmTaProfession TaProfession=new frmTaProfession();
					Show_Form(TaProfession,ff);					
					break;
				case 19:
					frmTaVacateWay TaVacateWay=new frmTaVacateWay();
					Show_Form(TaVacateWay,ff);					
					break;
				case 20:
					frmTaPosition TaPosition=new frmTaPosition();
					Show_Form(TaPosition,ff);					
					break;
				case 21:
					frmTaGroup TaGroup=new frmTaGroup();
					Show_Form(TaGroup,ff);					
					break;
				case 22:
					frmTaGroupType TaGroupType=new frmTaGroupType();
					Show_Form(TaGroupType,ff);					
					break;
				case 23:
					frmTaGraduation TaGraduation=new frmTaGraduation();
					Show_Form(TaGraduation,ff);					
					break;
				case 24:
					frmTaRace  TaRace =new frmTaRace();
					Show_Form(TaRace ,ff);					
					break;
				case 25:
					frmTaNationality TaNationality=new frmTaNationality();
					Show_Form(TaNationality,ff);					
					break;
				case 26:
					frmTaBonusAndFined  TaBonusAndFined =new frmTaBonusAndFined();
					Show_Form(TaBonusAndFined ,ff);					
					break;
				case 27:
					frmTaJuryType TaJuryType=new frmTaJuryType();
					Show_Form(TaJuryType,ff);					
					break;
					//Staff
				case 30:
					frmTaStaffInfo TaStaffInfo=new frmTaStaffInfo();
					Show_Form(TaStaffInfo,ff);					
					break;
				case 31:
					frmTaPositionMobilize TaPositionMobilize=new frmTaPositionMobilize();
					Show_Form(TaPositionMobilize,ff);					
					break;
				case 32:
					frmTaDepartmentSwitch TaDepartmentSwitch=new frmTaDepartmentSwitch();
					Show_Form(TaDepartmentSwitch,ff);					
					break;
				case 33:
					frmTaChangeCard ChangeCard=new frmTaChangeCard();
					Show_Form(ChangeCard,ff);					
					break;
				case 34:
					frmTaVacateManager TaVacateManager=new frmTaVacateManager();
					Show_Form(TaVacateManager,ff);					
					break;
				case 35:
					frmTaRecycleBin TaRecycleBin=new frmTaRecycleBin();
					Show_Form(TaRecycleBin,ff);					
					break;
				case 36:			
					string dt=PublicFunction.GetOption("DT6000");
					if(dt+""=="1")
					{
						frmTaDT6000 TaDT6000=new frmTaDT6000();
						Show_Form(TaDT6000,ff);
					}
					else
					{
						frmTaCardReader TaCardReader=new frmTaCardReader();
						Show_Form(TaCardReader,ff);					
					}
					break;
				case 37:
					frmTaEducationRecords TaEducationRecords =new frmTaEducationRecords();
					Show_Form(TaEducationRecords ,ff);					
					break;
				case 38:
					frmTaHoliday TaHoliday =new frmTaHoliday();
					Show_Form(TaHoliday ,ff);					
					break;
				case 41:
//					if(PublicFunction.GPS)
//					{
//						frmTaDataSwitch TaCardDataSwitch =new frmTaDataSwitch();
//						Show_Form(TaDataSwitch ,ff);
//					}
//					else
//					{
						frmTaCardDataSwitch TaCardDataSwitch =new frmTaCardDataSwitch();
						Show_Form(TaCardDataSwitch ,ff);					
//					}
					break;

				case 45:
					frmTaRosters TaRosters =new frmTaRosters();
					Show_Form(TaRosters ,ff);					
					break;
				case 46:
					frmTaStaffInfoSearch TaStaffInfoSearch =new frmTaStaffInfoSearch();
					Show_Form(TaStaffInfoSearch ,ff);					
					break;
				case 47:
					frmTaSetting TaSetting =new frmTaSetting();
					Show_Form(TaSetting ,ff);					
					break;
				case 48:
					frmTaMonthSetup TaMonthSetup =new frmTaMonthSetup();
					Show_Form(TaMonthSetup ,ff);					
					break;
				case 49:
					frmTaShiftReset TaShiftReset =new frmTaShiftReset();
					Show_Form(TaShiftReset ,ff);					
					break;
				case 50:
					frmTaCopyShift TaCopyShift =new frmTaCopyShift();
					Show_Form(TaCopyShift ,ff);					
					break;
				case 52:
					frmTaLeaveManager TaLeaveManager =new frmTaLeaveManager();
					Show_Form(TaLeaveManager ,ff);					
					break;
				case 53:
					frmTaOutTripControl TaOutTripControl  =new frmTaOutTripControl();
					Show_Form(TaOutTripControl  ,ff);					
					break;
				case 54:
					frmTaAnnualLeave TaAnnualLeave =new frmTaAnnualLeave();
					Show_Form(TaAnnualLeave ,ff);					
					break;
				case 55:
					frmTaDailyAttendanceList  TaDailyAttendanceList  =new frmTaDailyAttendanceList();
					Show_Form(TaDailyAttendanceList ,ff);					
					break;
				case 56:
					frmTaMonthAddUp  TaMonthAddUp   =new frmTaMonthAddUp();
					Show_Form(TaMonthAddUp  ,ff);					
					break;
				case 57:
					frmTaNativePlace  TaNativePlace   =new frmTaNativePlace();
					Show_Form(TaNativePlace  ,ff);					
					break;
				case 60:
					frmTaTransfer  TaTransfer   =new frmTaTransfer();
					Show_Form(TaTransfer  ,ff);					
					break;
				case 61:
					frmTaMonthAddUpCal  TaMonthAddUpCal   =new frmTaMonthAddUpCal();
					Show_Form(TaMonthAddUpCal  ,ff);					
					break;
				case 65:
					frmTaPayItem  TaPayItem   =new frmTaPayItem();
					Show_Form(TaPayItem  ,ff);					
					break;
				case 66:
					frmTaLevel  TaLevel=new frmTaLevel();
					Show_Form(TaLevel  ,ff);					
					break;
				case 67:
					frmTaTypeShift  TaTypeShift =new frmTaTypeShift();
					Show_Form(TaTypeShift   ,ff);					
					break;
				case 69:
					frmTaInitATT  TaInitATT=new frmTaInitATT();
					Show_Form(TaInitATT    ,ff);					
					break;
				case 70:
					frmTaInitMonthAddUp  InitMonthAddUp=new frmTaInitMonthAddUp();
					Show_Form(InitMonthAddUp    ,ff);					
					break;
				case 71:
					frmTaSalaryLevel  TaSalaryLevel=new frmTaSalaryLevel();
					Show_Form(TaSalaryLevel ,ff);					
					break;
				case 72:
					frmTaSalaryInput TaSalaryInput=new frmTaSalaryInput(true);
					Show_Form(TaSalaryInput ,ff);					
					break;
				case 73:
					frmTaSalaryFormula TaSalaryFormula=new frmTaSalaryFormula();
					Show_Form(TaSalaryFormula ,ff);					
					break;
				case 74:
					frmTaSalaryInput TaSalaryInput1=new frmTaSalaryInput(false);
					Show_Form(TaSalaryInput1 ,ff);				
					break;
				case 77:
					frmTaHRReport  TaHRReport=new frmTaHRReport();
					Show_Form(TaHRReport ,ff);				
					break;
				case 78:
					frmTaACCReport  TaACCReport =new frmTaACCReport();
					Show_Form(TaACCReport  ,ff);				
					break;
				case 79:
					frmTaPayrollCal  TaPayrollCal=new frmTaPayrollCal();
					Show_Form(TaPayrollCal ,ff);				
					break;
				case 80:
					frmTaSalary  TaSalary=new frmTaSalary();
					Show_Form(TaSalary ,ff);				
					break;
				case 81:
					frmTaLabourContract  TaLabourContract=new frmTaLabourContract();
					Show_Form(TaLabourContract ,ff);				
					break;
				case 83:
					frmTaAnnexLabourContract  TaAnnexLabourContract =new frmTaAnnexLabourContract();
					Show_Form(TaAnnexLabourContract  ,ff);				
					break;
				case 84:
					frmTaATM  TaATM =new frmTaATM();
					Show_Form(TaATM  ,ff);				
					break;
				case 85:
					frmTaManagerReport  TaManagerReport =new frmTaManagerReport();
					Show_Form(TaManagerReport  ,ff);				
					break;
				case 86:
					frmTaManternity  TaManternity =new frmTaManternity();
					Show_Form(TaManternity  ,ff);				
					break;
				case 87:
					frmTaXetHach TaXetHach =new frmTaXetHach();
					Show_Form(TaXetHach  ,ff);				
					break;				
				case 89:
					frmTaBonusAndFinedManager TaBonusAndFinedManager  =new frmTaBonusAndFinedManager();
					Show_Form(TaBonusAndFinedManager   ,ff);				
					break;
				case 90:
					frmTaNotesSlip TaNotesSlip  =new frmTaNotesSlip();
					Show_Form(TaNotesSlip   ,ff);				
					break;
				case 91:
					frmTaAbsentVacate TaAbsentVacate  =new frmTaAbsentVacate();
					Show_Form(TaAbsentVacate ,ff);				
					break;
				case 92:
					//					frmTaTransferStaff TaTransferStaff  =new frmTaTransferStaff();
					//					Show_Form(TaTransferStaff ,ff);			
					frmTaStaffSalary StaffSalary   =new frmTaStaffSalary ();
					Show_Form(StaffSalary  ,ff);	
					break;
				case 93:
					frmTaInitSalary TaInitSalary   =new frmTaInitSalary ();
					Show_Form(TaInitSalary  ,ff);				
					break;
				case 94:
					frmTaCardData  TaCardData   =new frmTaCardData ();
					Show_Form(TaCardData  ,ff);				
					break;
				case 95:
					frmTaTAPrintOut TaTAPrintOut    =new frmTaTAPrintOut ();
					Show_Form(TaTAPrintOut ,ff);				
					break;
				case 98:
					frmTaCardComparison TaCardComparison    =new frmTaCardComparison ();
					Show_Form(TaCardComparison ,ff);				
					break;
				case 99:
					frmTaSeachReport TaSeachReport     =new frmTaSeachReport ();
					Show_Form(TaSeachReport  ,ff);				
					break;
				case 100:
					frmTaComparison TaComparison    =new frmTaComparison ();
					Show_Form(TaComparison ,ff);				
					break;

				case 103:
					frmTaSection TaSection    =new frmTaSection ();
					Show_Form(TaSection ,ff);				
					break;
				case 104:
					frmTaStyle TaStyle     =new frmTaStyle ();
					Show_Form(TaStyle  ,ff);				
					break;
				case 105:
					frmTaTransferToGPS  TaTransferToGPS     =new frmTaTransferToGPS ();
					Show_Form(TaTransferToGPS  ,ff);				
					break;
				case 107:
					
					frmTuProStaffInfo  TuProStaffInfo     =new frmTuProStaffInfo ();
					Show_Form(TuProStaffInfo  ,ff);				
					break;
				case 109:
					
					frmTaSchedule  TaSchedule      =new frmTaSchedule ();
					Show_Form(TaSchedule  ,ff);				
					break;
//				case 111:					
//					frmTaBackup  TaBackup      =new frmTaBackup ();
//					Show_Form(TaBackup  ,ff);				
//					break;
				case 112:					
					frmTaRestore  TaRestore       =new frmTaRestore ();
					Show_Form(TaRestore   ,ff);				
					break;
				case 113:
					frmTaAnnualLeaveMonth  TaAnnualLeaveMonth       =new frmTaAnnualLeaveMonth ();
					Show_Form(TaAnnualLeaveMonth   ,ff);				
					break;
				case 114:
//					frmTaSussidy  TaSussidy       =new frmTaSussidy ();
//					Show_Form(TaSussidy   ,ff);	
					frmTaPieceRateTransferTXT  TaPieceRateTransferTXT =new frmTaPieceRateTransferTXT ();
					Show_Form(TaPieceRateTransferTXT,ff);
					break;
				case 115:
					frmTaSubsidyCal  TaSubsidyCal       =new frmTaSubsidyCal ();
					Show_Form(TaSubsidyCal   ,ff);				
					break;
				case 116:
					frmTaMonthSubsidy  TaMonthSubsidy       =new frmTaMonthSubsidy ();
					Show_Form(TaMonthSubsidy   ,ff);				
					break;
				case 117:
					frmTaCertificate  TaCertificate       =new frmTaCertificate ();
					Show_Form(TaCertificate   ,ff);				
					break;
				case 118:
					frmTaNatureSwitch  TaNatureSwitch     =new frmTaNatureSwitch ();
					Show_Form(TaNatureSwitch   ,ff);				
					break;
				case 119:
					frmTaAttendanceLock  TaAttendanceLock     =new frmTaAttendanceLock ();
					Show_Form(TaAttendanceLock   ,ff);				
					break;
				//palace meal
				case 110:
					frmTaMeal TaMeal=new frmTaMeal();
					Show_Form(TaMeal,ff);	
					break;
				case 111:
					frmTaDailyMeal TaDailyMeal  =new frmTaDailyMeal();
					Show_Form(TaDailyMeal ,ff);
					break;
				case 120:
					frmTaLichTrinhBoPhan taLichTrinhBoPhan  =new frmTaLichTrinhBoPhan();
					Show_Form(taLichTrinhBoPhan ,ff);
					break;
				case 121:
					frmTaCardDataSwitchVS TaCardDataSwitchVS  =new frmTaCardDataSwitchVS();
					Show_Form(TaCardDataSwitchVS ,ff);
					break;
				case 122:
					frmTaNationality_Toilet TaNationality_Toilet  =new frmTaNationality_Toilet();
					Show_Form(TaNationality_Toilet ,ff);
					break;
			}
		}

	
	}
}

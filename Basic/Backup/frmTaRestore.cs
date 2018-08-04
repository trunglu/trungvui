using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Basic.Form;
using Basic.Function;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Data.OleDb;
using System.IO;
using System.Diagnostics;


namespace GP8000.Backup
{
	/// <summary>
	/// Summary description for frmTaRestore.
	/// </summary>
	public class frmTaRestore : System.Windows.Forms.Form
	{
		private System.Windows.Forms.FolderBrowserDialog ff;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label l;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Label ll;
		private System.Windows.Forms.Button cmd_close;
		private System.Windows.Forms.Button cmd_OK;
		private System.Windows.Forms.Button cmd_stop;
		private System.Windows.Forms.Label lll;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.ProgressBar pro;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox txt3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lb2;
		private System.Windows.Forms.TextBox user;
		private System.Windows.Forms.TextBox dt;
		private System.Windows.Forms.TextBox info;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox db;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button cmd_run;
		private System.Windows.Forms.Panel p1;
		private System.Windows.Forms.TextBox txt;
		private System.Windows.Forms.PictureBox pp;
		private System.Windows.Forms.RadioButton r1;
		private System.Windows.Forms.RadioButton r2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaRestore()
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
			this.ff = new System.Windows.Forms.FolderBrowserDialog();
			this.panel2 = new System.Windows.Forms.Panel();
			this.l = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.p1 = new System.Windows.Forms.Panel();
			this.cmd_run = new System.Windows.Forms.Button();
			this.txt = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.ll = new System.Windows.Forms.Label();
			this.cmd_close = new System.Windows.Forms.Button();
			this.cmd_OK = new System.Windows.Forms.Button();
			this.cmd_stop = new System.Windows.Forms.Button();
			this.lll = new System.Windows.Forms.Label();
			this.panel6 = new System.Windows.Forms.Panel();
			this.pro = new System.Windows.Forms.ProgressBar();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.r2 = new System.Windows.Forms.RadioButton();
			this.r1 = new System.Windows.Forms.RadioButton();
			this.pp = new System.Windows.Forms.PictureBox();
			this.db = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.info = new System.Windows.Forms.TextBox();
			this.dt = new System.Windows.Forms.TextBox();
			this.user = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.txt3 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lb2 = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel7.SuspendLayout();
			this.p1.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel4.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.panel2.Controls.Add(this.l);
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(884, 36);
			this.panel2.TabIndex = 9;
			// 
			// l
			// 
			this.l.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.l.Dock = System.Windows.Forms.DockStyle.Fill;
			this.l.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.l.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.l.Location = new System.Drawing.Point(4, 0);
			this.l.Name = "l";
			this.l.Size = new System.Drawing.Size(880, 36);
			this.l.TabIndex = 6;
			this.l.Tag = "";
			this.l.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel3
			// 
			this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(4, 36);
			this.panel3.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel7);
			this.panel1.Controls.Add(this.lll);
			this.panel1.Controls.Add(this.panel6);
			this.panel1.Controls.Add(this.panel5);
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 36);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(884, 400);
			this.panel1.TabIndex = 10;
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.p1);
			this.panel7.Controls.Add(this.ll);
			this.panel7.Controls.Add(this.cmd_close);
			this.panel7.Controls.Add(this.cmd_OK);
			this.panel7.Controls.Add(this.cmd_stop);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel7.Location = new System.Drawing.Point(0, 184);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(884, 216);
			this.panel7.TabIndex = 15;
			// 
			// p1
			// 
			this.p1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.p1.Controls.Add(this.cmd_run);
			this.p1.Controls.Add(this.txt);
			this.p1.Controls.Add(this.label3);
			this.p1.Location = new System.Drawing.Point(4, 84);
			this.p1.Name = "p1";
			this.p1.Size = new System.Drawing.Size(876, 120);
			this.p1.TabIndex = 20;
			// 
			// cmd_run
			// 
			this.cmd_run.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_run.Location = new System.Drawing.Point(680, 8);
			this.cmd_run.Name = "cmd_run";
			this.cmd_run.Size = new System.Drawing.Size(116, 24);
			this.cmd_run.TabIndex = 19;
			this.cmd_run.Text = "Run";
			this.cmd_run.Click += new System.EventHandler(this.cmd_run_Click);
			// 
			// txt
			// 
			this.txt.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt.Location = new System.Drawing.Point(100, 8);
			this.txt.Name = "txt";
			this.txt.ReadOnly = true;
			this.txt.Size = new System.Drawing.Size(576, 23);
			this.txt.TabIndex = 18;
			this.txt.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 12);
			this.label3.Name = "label3";
			this.label3.TabIndex = 17;
			this.label3.Tag = "";
			this.label3.Text = "label4";
			// 
			// ll
			// 
			this.ll.BackColor = System.Drawing.Color.Black;
			this.ll.Dock = System.Windows.Forms.DockStyle.Top;
			this.ll.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ll.ForeColor = System.Drawing.Color.White;
			this.ll.Location = new System.Drawing.Point(0, 0);
			this.ll.Name = "ll";
			this.ll.Size = new System.Drawing.Size(884, 28);
			this.ll.TabIndex = 16;
			this.ll.Tag = "N";
			this.ll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cmd_close
			// 
			this.cmd_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmd_close.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_close.Location = new System.Drawing.Point(522, 44);
			this.cmd_close.Name = "cmd_close";
			this.cmd_close.Size = new System.Drawing.Size(116, 36);
			this.cmd_close.TabIndex = 14;
			this.cmd_close.Text = "Close";
			this.cmd_close.Click += new System.EventHandler(this.cmd_close_Click);
			// 
			// cmd_OK
			// 
			this.cmd_OK.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_OK.Location = new System.Drawing.Point(246, 44);
			this.cmd_OK.Name = "cmd_OK";
			this.cmd_OK.Size = new System.Drawing.Size(116, 36);
			this.cmd_OK.TabIndex = 13;
			this.cmd_OK.Text = "Backup";
			this.cmd_OK.Click += new System.EventHandler(this.cmd_OK_Click);
			// 
			// cmd_stop
			// 
			this.cmd_stop.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_stop.Location = new System.Drawing.Point(248, 44);
			this.cmd_stop.Name = "cmd_stop";
			this.cmd_stop.Size = new System.Drawing.Size(116, 36);
			this.cmd_stop.TabIndex = 15;
			this.cmd_stop.Text = "Stop";
			this.cmd_stop.Visible = false;
			this.cmd_stop.Click += new System.EventHandler(this.cmd_stop_Click);
			// 
			// lll
			// 
			this.lll.BackColor = System.Drawing.Color.Black;
			this.lll.Dock = System.Windows.Forms.DockStyle.Top;
			this.lll.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lll.ForeColor = System.Drawing.Color.White;
			this.lll.Location = new System.Drawing.Point(0, 156);
			this.lll.Name = "lll";
			this.lll.Size = new System.Drawing.Size(884, 28);
			this.lll.TabIndex = 12;
			this.lll.Tag = "N";
			this.lll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.pro);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel6.Location = new System.Drawing.Point(0, 136);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(884, 20);
			this.panel6.TabIndex = 11;
			// 
			// pro
			// 
			this.pro.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pro.Location = new System.Drawing.Point(0, 0);
			this.pro.Name = "pro";
			this.pro.Size = new System.Drawing.Size(884, 20);
			this.pro.TabIndex = 0;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.LightSteelBlue;
			this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel5.Location = new System.Drawing.Point(0, 132);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(884, 4);
			this.panel5.TabIndex = 10;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.groupBox1);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(884, 132);
			this.panel4.TabIndex = 9;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.r2);
			this.groupBox1.Controls.Add(this.r1);
			this.groupBox1.Controls.Add(this.pp);
			this.groupBox1.Controls.Add(this.db);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.info);
			this.groupBox1.Controls.Add(this.dt);
			this.groupBox1.Controls.Add(this.user);
			this.groupBox1.Controls.Add(this.button3);
			this.groupBox1.Controls.Add(this.txt3);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.lb2);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(884, 132);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Tag = "N";
			// 
			// r2
			// 
			this.r2.Location = new System.Drawing.Point(344, 100);
			this.r2.Name = "r2";
			this.r2.Size = new System.Drawing.Size(176, 24);
			this.r2.TabIndex = 19;
			this.r2.Text = "r2";
			// 
			// r1
			// 
			this.r1.Checked = true;
			this.r1.Location = new System.Drawing.Point(344, 72);
			this.r1.Name = "r1";
			this.r1.Size = new System.Drawing.Size(176, 24);
			this.r1.TabIndex = 18;
			this.r1.TabStop = true;
			this.r1.Text = "r1";
			// 
			// pp
			// 
			this.pp.Location = new System.Drawing.Point(640, 76);
			this.pp.Name = "pp";
			this.pp.Size = new System.Drawing.Size(152, 52);
			this.pp.TabIndex = 17;
			this.pp.TabStop = false;
			this.pp.Visible = false;
			// 
			// db
			// 
			this.db.BackColor = System.Drawing.Color.LightBlue;
			this.db.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.db.Location = new System.Drawing.Point(104, 100);
			this.db.Name = "db";
			this.db.ReadOnly = true;
			this.db.Size = new System.Drawing.Size(232, 23);
			this.db.TabIndex = 16;
			this.db.Text = "";
			this.db.TextChanged += new System.EventHandler(this.db_TextChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 104);
			this.label2.Name = "label2";
			this.label2.TabIndex = 15;
			this.label2.Tag = "";
			this.label2.Text = "label4";
			// 
			// info
			// 
			this.info.BackColor = System.Drawing.Color.LightBlue;
			this.info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.info.Location = new System.Drawing.Point(336, 44);
			this.info.Name = "info";
			this.info.ReadOnly = true;
			this.info.Size = new System.Drawing.Size(460, 23);
			this.info.TabIndex = 14;
			this.info.Text = "";
			// 
			// dt
			// 
			this.dt.BackColor = System.Drawing.Color.LightBlue;
			this.dt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.dt.Location = new System.Drawing.Point(104, 72);
			this.dt.Name = "dt";
			this.dt.ReadOnly = true;
			this.dt.Size = new System.Drawing.Size(232, 23);
			this.dt.TabIndex = 13;
			this.dt.Text = "";
			// 
			// user
			// 
			this.user.BackColor = System.Drawing.Color.LightBlue;
			this.user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.user.Location = new System.Drawing.Point(104, 44);
			this.user.Name = "user";
			this.user.ReadOnly = true;
			this.user.Size = new System.Drawing.Size(232, 23);
			this.user.TabIndex = 12;
			this.user.Text = "";
			// 
			// button3
			// 
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button3.Location = new System.Drawing.Point(768, 16);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(28, 23);
			this.button3.TabIndex = 10;
			this.button3.Tag = "N";
			this.button3.Text = "...";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// txt3
			// 
			this.txt3.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt3.Location = new System.Drawing.Point(104, 16);
			this.txt3.Name = "txt3";
			this.txt3.ReadOnly = true;
			this.txt3.Size = new System.Drawing.Size(668, 23);
			this.txt3.TabIndex = 9;
			this.txt3.Text = "";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(12, 24);
			this.label6.Name = "label6";
			this.label6.TabIndex = 8;
			this.label6.Tag = "";
			this.label6.Text = "label4";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 48);
			this.label1.Name = "label1";
			this.label1.TabIndex = 11;
			this.label1.Tag = "";
			this.label1.Text = "label4";
			// 
			// lb2
			// 
			this.lb2.Location = new System.Drawing.Point(12, 76);
			this.lb2.Name = "lb2";
			this.lb2.TabIndex = 4;
			this.lb2.Tag = "";
			this.lb2.Text = "label4";
			// 
			// frmTaRestore
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(884, 436);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaRestore";
			this.Text = "frmTaRestore";
			this.Load += new System.EventHandler(this.frmTaRestore_Load);
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.p1.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaRestore_Load(object sender, System.EventArgs e)
		{
			Basic.Function.PublicFunction.L_Init_Label(this);	
		}
	
		OleDbConnection conmdb;
		string thumuc;
		private void button3_Click(object sender, System.EventArgs e)
		{
			if(ff.ShowDialog()==DialogResult.OK)
			{
				txt3.Text=ff.SelectedPath;
				conmdb=ConnectMDB(txt3.Text+"\\hqt_data.mdb");
				if (conmdb==null || conmdb.State!=ConnectionState.Open)
				{
					MessageBox.Show(PublicFunction.L_GetLabel(this.Name,9));
					return;
				}
				RecordSetMDB rs=new RecordSetMDB("Select * from SENDER ",conmdb);
				if(rs.rows>0)
				{
					user.Text=rs.record(0,0);
					dt.Text=rs.record(0,1);
				}
				rs=new RecordSetMDB("Select * from EXP_INFO ",conmdb);
				if(rs.rows>0)
				{
					info.Text=rs.record(0,0);	
					thumuc=rs.record(0,1);	
				}
				db.Text="hqtan_temp";
				PublicFunction.savefilekey1( txt3.Text+"\\"+thumuc+"\\VT.BS",db.Text);
				txt.Text=txt3.Text+"\\"+thumuc+"\\GP8000.exe";
			}
		}

		private void cmd_OK_Click(object sender, System.EventArgs e)
		{
			if(txt3.Text!="")
			{
				stop=false;
				CL();
				Thread th=new Thread(new ThreadStart(BK));
				th.Priority=ThreadPriority.Highest;
				th.Start();
			}
			else
			{
				MessageBox.Show(PublicFunction.L_GetLabel(this.Name,12));
			}
		}

		private void BK()
		{
//
//			 constr = "Provider=MSDASQL.1;Extended Properties=DRIVER=SQL Server;" & _
//            "SERVER=" & Text1(0).Text & ";UID=" & Text1(1).Text & ";PWD=" & Text1(2).Text & ";APP=Visual Basic;WSID=" & Text1(0).Text & _
//            ";DATABASE=" & ";AutoTranslate=False"
//				concr.ConnectionString = constr
//				concr.Open
//				concr.execute " CREATE DATABASE [" & Text1(3).Text & "]"
			
			lll.Text=PublicFunction.L_GetLabel(this.Name,10);
			SqlConnection con=PublicFunction.connect(PublicFunction.DT_server
				,"",PublicFunction.DT_username,PublicFunction.DT_password);
			
			try
			{
				PublicFunction.SQL_Execute(" Drop DATABASE ["+db.Text+"]",con);
			}
			catch{}
			try
			{
				PublicFunction.SQL_Execute("CREATE DATABASE ["+db.Text+"]",con);
			}
			catch
			{
				stop=true;
				CL();
				MessageBox.Show("Can not create database "+db.Text);
				return;
			}
			con=PublicFunction.connect(PublicFunction.DT_server
				,db.Text,PublicFunction.DT_username,PublicFunction.DT_password);		
			
			if (conmdb==null ||  conmdb.State!=ConnectionState.Open)
			{
				stop=true;
				CL();
				MessageBox.Show(PublicFunction.L_GetLabel(this.Name,9));
				return;
			}	

			string sql="";
			
			lll.Text=PublicFunction.L_GetLabel(this.Name,11);
			if(!CreateStructure(conmdb,con))
			{
				stop=true;
				MessageBox.Show("Error!!!!");
				lll.Text="Error!!!!";			
				CL();
				return;
			}

			lll.Text=PublicFunction.L_GetLabel(this.Name,12);
			sql = "select *  from EXP_TB ";
			RecordSetMDB rstb=new RecordSetMDB(sql,conmdb);
			for(int i=0;i<rstb.rows;i++)
			{
				if(stop)
				{
					CL();
					return;
				}
				ll.Text=rstb.record(i,"name");				
				
				if(r1.Checked)
				{			
					if(!ImportTable1(rstb.record(i,0),conmdb,con))
					{
						stop=true;
						MessageBox.Show("Error!!!! " +rstb.record(i,"name"));
						lll.Text="Error!!!!";						
						CL();
						return;
					}
				}
				else
				{
					if(!ImportTable(rstb.record(i,0),conmdb,con))
					{
						stop=true;
						MessageBox.Show("Error!!!! " +rstb.record(i,"name"));
						lll.Text="Error!!!!";						
						CL();
						return;
					}
				}
				
				pro.Value=(int)((i+1)*100/rstb.rows);
			}	
			pro.Value=100;

			PublicFunction.savefilekey1( txt3.Text+"\\"+thumuc+"\\VT.BS",db.Text);
			txt.Text=txt3.Text+"\\"+thumuc+"\\GP8000.exe";
			p1.Visible=true;

			lll.Text=PublicFunction.L_GetLabel("frmTaBackup",10);
			MessageBox.Show(PublicFunction.L_GetLabel("frmTaBackup",10));
			con.Close();
			conmdb.Close();
			stop=true;
			CL();
		}

		private void CL()
		{
			cmd_stop.Visible=!stop;
			cmd_OK.Visible=stop;
		}
		#region import table
		private Boolean ImportTable(string table,OleDbConnection conm,SqlConnection con)
		{			
			ArrayList fname=new ArrayList();
			ArrayList key=new ArrayList();
			ArrayList type=new ArrayList();
			ArrayList pic=new ArrayList();
			string sql,sql1,wh,st,st1;
			if (!PublicFunction.CheckFieldOfTable(con,table))
				return false;			

			sql="select * from "+table;
			RecordSetMDB rs=new RecordSetMDB(sql,conm);
			sql="Insert Into ["+table+"] (";
			for(int i=0;i<rs.cols;i++)
			{		
				if (Func.Fun.CheckFieldOfTable(con,table,rs.Field(i)))
				{
					fname.Add(rs.Field(i));
					key.Add(Func.Fun.CheckPrimaryKey(con,table,rs.Field(i)));
					st=Func.Fun.GetTypeField(con,table,rs.Field(i));
					type.Add(st);
					if (i!=0) sql+=",";
					sql+="["+rs.Field(i)+"]";	
					if (st=="6")
						pic.Add(rs.Field(i));			
				}
			}
			
			sql+=") values(";
			for(int j=0;j<rs.rows;j++)
			{
				if(stop)
				{
					CL();
					return false;
				}
				sql1="";wh="";st1="";
				for(int i=0;i<fname.Count;i++)
				{	
				
					//insert
					if (sql1!="") sql1+=",";
					
					if (pic.IndexOf(fname[i]+"")>=0 || rs.record(j,fname[i]+"")==null || rs.record(j,fname[i]+"")=="" )			
					{
						if ((Boolean)key[i])
							sql1= sql1 + "''";
						else
							sql1= sql1 + "Default";
					}
						// Get TypeName of Field,  return {1 (nvarchar,char..), 2 (datetime), 3 (bit), 4 (float), 5 (int)}					
					else
					{						
						switch ((string)type[i])// DataType
						{
							case "1":
								sql1=sql1+"N'" + T_String.sqlsql(rs.record(j,fname[i]+"")) +"'";
								break;
							case "2":						
								sql1=sql1+doiDT(rs.record(j,fname[i]+""));
								break;
							case "3":
								if (rs.record(j,fname[i]+"")=="True")
									sql1=sql1+ "1";
								else if (rs.record(j,fname[i]+"")=="False")
									sql1=sql1+"0";
								else
									sql1=sql1+ rs.record(j,fname[i]+"");
								break;												
							case "4":
								sql1=sql1 + rs.record(j,fname[i]+"");
								break;
							case "5":
								sql1=sql1 + rs.record(j,fname[i]+"");
								break;
							default:
								sql1=sql1+"N'" + T_String.sqlsql(rs.record(j,fname[i]+"")) +"'";					
								break;
						}
					}
					
					//Delete
					if ((Boolean)key[i])
					{
						if (wh!="") wh+=" and ";
						
						// Get TypeName of Field,  return {1 (nvarchar,char..), 2 (datetime), 3 (bit), 4 (float), 5 (int)}
						switch ((string)type[i])// DataType
						{
							case "1":
								wh=wh+fname[i]+"=N'" + T_String.sqlsql(rs.record(j,fname[i]+"")) +"'";
								break;
							case "2":						
								wh=wh+fname[i]+"="+ doiDT(rs.record(j,fname[i]+""))+"";
								break;
							case "3":
								if (rs.record(j,fname[i]+"")=="True")
									wh=wh+fname[i]+ "=1";
								else if (rs.record(j,fname[i]+"")=="False")
									wh=wh+fname[i]+"=0";
								else
									wh=wh+fname[i]+"="+ rs.record(j,fname[i]+"");
								break;												
							case "4":
								wh=wh+fname[i]+"=" + rs.record(j,fname[i]+"");
								break;
							case "5":
								wh=wh+fname[i]+"=" + rs.record(j,fname[i]+"");
								break;
							default:
								wh=wh+fname[i]+"=N'" + T_String.sqlsql(rs.record(j,fname[i]+"")) +"'";					
								break;
						}
					}
					if ((Boolean)key[i])
					{
						if (st1!="") st1+=" and ";
						//cu
						//						if (Func.Fun.GetTypeField(con,table,fname[i]+"")=="2")
						//						{
						//							if (rs.record(j,fname[i]+"")+""=="")
						//								st1+=fname[i]+"=''";
						//							else
						//								st1+=fname[i]+"='"+  DateTime.Parse(rs.record(j,fname[i]+"")).ToString("yyyy/MM/dd HH:mm:ss") +"'";
						//						}
						//						else
						//						{
						//							st1+=fname[i]+"='"+  T_String.sqlsql(rs.record(j,fname[i]+""))+"'";
						//						}

						if (Func.Fun.GetTypeField(con,table,fname[i]+"")=="2")
						{
							if (rs.record(j,fname[i]+"")+""=="")
								st1+=fname[i]+"=''";
							else
								st1+=fname[i]+"='"+  DateTime.Parse(rs.record(j,fname[i]+"")).ToString("yyyy/MM/dd HH:mm:ss") +"'";
						}
						else
						{
							if (Func.Fun.GetTypeField(con,table,fname[i]+"")=="1")
							{
								st1+=fname[i]+"='"+  T_String.sqlsql(rs.record(j,fname[i]+""))+"'";
							}
							else
							{
								st1+=fname[i]+"="+  T_String.sqlsql(rs.record(j,fname[i]+""))+"";
							}
						}
					}
				}
				
				
				//PublicFunction.SQL_Execute("Delete from ["+table+"] where "+wh,con);								
				PublicFunction.SQL_Execute(sql+sql1+")",con);		
				for(int m=0;m<pic.Count;m++)
				{
					
					if(st1!="")
					{
						st="Select ["+pic[m]+"] from ["+table+"] where " + st1;
						UploadImageToSQL(LoadImageFromMDB(st,conm),pic[m]+"",table,wh,con);
					}
				}				
				
				///lb1.Text=r+"/"+txt5.Text+" records.";
				ll.Text="*"+table +"* __ "+(j+1)+"/"+rs.rows+" records. " +(int)((j+1)*100/rs.rows) +"% ";
				pro.Value=(int)((j+1)*100/rs.rows);				
				//	pro.Value=(int)(r*100/T_String.IsNullTo0(txt5.Text));
			}
			pro.Value=100;
			return true;	
		}

		private string doiDT(string dt)
		{
			try
			{
				return "'"+DateTime.Parse(dt).ToString("yyyy/MM/dd HH:mm")+"'";
			}
			catch
			{
				return "Default";
			}
		}	

		public  void UploadImageToSQL(byte[] bytes,string Field,string Table,string where,SqlConnection con)
		{
			
			try
			{
				string sql=null;
				sql="update "+Table+" set "+Field+" =@image";
				if (where !="")
				{
					sql=sql+" where " + where;
				}				
				//byte[] bytes = ImageFunction.ReadBitmapFromFile(ImageFile);
				
				System.IO.MemoryStream stream = new System.IO.MemoryStream(bytes);
				Bitmap image = new Bitmap(stream);
				pp.Image= image;
				
				SqlCommand cmd =new SqlCommand(sql,con); 
				SqlParameter  imageParameter = cmd.Parameters.Add("@image",SqlDbType.Binary );
				imageParameter.Value =bytes ;
				imageParameter.Size =bytes.Length ;
				cmd.ExecuteNonQuery();				
			}
			catch
			{
				throw;
			}
		
		}
		public byte[] LoadImageFromMDB(string sql,OleDbConnection conm)
		{		
			try
			{
				OleDbCommand Sqlcmd=new OleDbCommand(sql,conm );
			
				object obj = Sqlcmd.ExecuteScalar();
				if (obj == System.DBNull.Value || obj==null)
				{				
					return null;
				}
				byte[] content = (byte[])obj;
				if (content.Length<=0) 
					return null;
				System.IO.MemoryStream stream = new System.IO.MemoryStream(content);
				return stream.ToArray();
			}
			catch(OleDbException ex)
			{
				MessageBox.Show(ex.Message);
				return null;
			}
		}
		#endregion
		#region MDB
		private Boolean ImportTable1(string table,OleDbConnection conm,SqlConnection con)
		{
			string sql="";			
			//OPENROWSET('Microsoft.Jet.OLEDB.4.0','E:\Code\UpdateDatabaseY_New\DATA\aa.mdb'
			//;'Admin';'',TransferExcelToDB_Setting) AS a 


//			SELECT     *
//FROM OpenDataSource( 'Microsoft.Jet.OLEDB.4.0',
//  'Data Source="C:\data\hqt_data.mdb";Jet OLEDB:Database Password=p@ssw0rd411982;')...FILA01A

	
			ll.Text="~*"+table +"*~";
			sql="insert into ["+table+"] select * from " +
				"OpenDataSource('Microsoft.Jet.OLEDB.4.0','Data Source=\""+
				txt3.Text+"\\hqt_data.mdb\"Jet OLEDB:Database Password=p@ssw0rd411982;')..."+table;

			try
			{
				PublicFunction.SQL_Execute(sql,con);					
			}
			catch(SqlException ex)
			{
				MessageBox.Show( " \n Execute Sql Error . Number:" + ex.Number 
					+ ". Description Error:" + ex.Message  );				
				return false;
			}

			return true;
		}


		private Boolean CreateStructure(OleDbConnection conm,SqlConnection con)
		{			
			RecordSetMDB rs=new RecordSetMDB("Select * from hqtan_TB order by name ",conm);
			for(int tb=0;tb<rs.rows;tb++)
			{
				ll.Text=rs.record (tb,"name");
				if(rs.record (tb,"name")!="dtproperties")
					Copy_Table(rs.record (tb,"name")+"",rs.record(tb,"name"),rs.record(tb,"id"),conm,con);
			}
			return true;			
		}

		public static void  Copy_Table(string FromTable, string NewTable,string IDTable,OleDbConnection conm,SqlConnection con)
		{
			string sql,st="",key="";
				
			sql=  "SELECT * from hqtan_FD where id="+IDTable+" order by colid ";
			RecordSetMDB rs =new RecordSetMDB(sql,conm);
			for(int i=0;i<rs.rows;i++)
			{
				if(i!=0) st+=",";
				st+="["+rs.record(i,"name")+"] "; // ten bang
				st+=rs.record(i,"datatype");
				if(PublicFunction.S_Right(rs.record(i,"datatype"),4)=="char" || PublicFunction.S_Right(rs.record(i,"datatype"),6)=="binary")
				{
					st+= "(" + T_String.IsNullTo0(rs.record(i,"length"))/2+ ") "; // chieu dai
				}
				if(rs.record(i,"cdefault")+""!="0") // default
				{					
					string tam=T_String.GetDataFromSQL("text","syscomments","id="+rs.record(i,"cdefault"));	
					if(tam!="")
					{
						st+=" Default "+tam;
					}
				}
				if(rs.record(i,"isnullable")+""=="0") // allow null
					st+=" not null";
				int count=T_String.IsNullTo0(T_String.GetDataFromSQL("Count(*)","sysindexkeys","indid=1 and id="+IDTable+" and colid="+rs.record(i,"colid"))+"");
				if(count>0)
				{
					if (key!="") key+=",";
					key+="["+rs.record(i,"name")+"] ";
				}
			}
			st="Create Table ["+NewTable+"]("+st;
			if(key!="")
			{
				int count=T_String.IsNullTo0(T_String.GetDataFromSQL("Count(*)","sysobjects","name='"+NewTable+"'"));
				if(count<=0)				
					st+=" , CONSTRAINT PK_"+NewTable+" PRIMARY KEY ("+key+"))";
				else
					st+=" , CONSTRAINT PK1_"+NewTable+" PRIMARY KEY ("+key+"))";       
				
			}
			else
				st+=")";
			PublicFunction.SQL_Execute(st,con);
		}

		private OleDbConnection  ConnectMDB(string filename)
		{			
			try
			{				
				string st="Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
					+filename+";Jet OLEDB:Database Password=p@ssw0rd411982;";
				OleDbConnection conm = new OleDbConnection(st);	
				
				conm.Open();										
				return conm;
			}
			catch(Exception)
			{
				//MessageBox.Show("Can't connect to MDB file");
				return null;
			}
		}
	

		private Boolean Excute_MDB(string sql,OleDbConnection conm)
		{
			try
			{
				OleDbCommand cmd=new OleDbCommand(sql,conm);
				cmd.ExecuteNonQuery();
				return true;
			}
			catch(OleDbException ex)
			{
				MessageBox.Show(ex.Message);
				return false;
			}
		}
		#endregion

		Boolean stop=false;
		private void cmd_stop_Click(object sender, System.EventArgs e)
		{
			stop=true;;
		}

		private void cmd_close_Click(object sender, System.EventArgs e)
		{
			stop=true;;
			this.Close();
		}

		private void cmd_run_Click(object sender, System.EventArgs e)
		{
			Process myProcess;
			myProcess = Process.Start(txt.Text);		
		}

		private void db_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		

		#region	 record
		public class RecordSetMDB
		{
			public DataSet ds;
			public int  rows;
			public int cols;
			public int Bookmarks;
			public RecordSetMDB(string sql,OleDbConnection con)
			{
				ds=new DataSet();			
				try
				{				
					OleDbDataAdapter cmd=new OleDbDataAdapter(sql,con);			
					cmd.Fill(ds);
					rows=ds.Tables[0].Rows.Count;
					cols=ds.Tables[0].Columns.Count;				
				}
				catch(OleDbException ex )
				{
					MessageBox.Show(ex.Message +"..SQL Error. Sql: " + sql);				
				}
			}
		
			public string record(int row,int col)
			{
				try
				{
					if (ds.Tables[0].Rows[row][col].ToString()=="")
						return null;
					return ds.Tables[0].Rows[row][col].ToString();
				}
				catch(Exception)
				{
			
					return null;
				}
			}

			public string record(int row,string col)
			{
				try
				{
					if (ds.Tables[0].Rows[row][col].ToString()=="")
						return null;
					return ds.Tables[0].Rows[row][col].ToString();
				}
				catch(Exception)
				{
					return null;
				}
			}

			public string Field(int col)
			{
				try
				{
					return ds.Tables[0].Columns[col].ColumnName;
				}
				catch(Exception ex)
				{
					MessageBox.Show( ds.Tables[0].TableName+ " . Description Error:" + ex.Message  );
					return "";
				}
			}

		}
		#endregion		
	}
}

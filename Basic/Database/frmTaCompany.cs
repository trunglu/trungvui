using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Basic.Form;
using Basic.Function;

namespace GP8000.Database
{
	/// <summary>
	/// Summary description for frmTaCompany.
	/// </summary>
	public class frmTaCompany : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel4;
		private Navigator1._0.NavigatorAuto nav;
		private C1.Win.C1Command.C1CommandDock c1CommandDock1;
		private C1.Win.C1Command.C1DockingTab c1DockingTab1;
		private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage1;
		private C1.Win.C1FlexGrid.C1FlexGrid vs;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textBox11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox textBox12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox textBox13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel6;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaCompany()
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
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBox13 = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.textBox12 = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.textBox11 = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.nav = new Navigator1._0.NavigatorAuto();
			this.c1CommandDock1 = new C1.Win.C1Command.C1CommandDock();
			this.c1DockingTab1 = new C1.Win.C1Command.C1DockingTab();
			this.c1DockingTabPage1 = new C1.Win.C1Command.C1DockingTabPage();
			this.vs = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.panel1.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandDock1)).BeginInit();
			this.c1CommandDock1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).BeginInit();
			this.c1DockingTab1.SuspendLayout();
			this.c1DockingTabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel5);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.c1CommandDock1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(912, 528);
			this.panel1.TabIndex = 1;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.panel6);
			this.panel5.Controls.Add(this.panel2);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(200, 36);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(712, 492);
			this.panel5.TabIndex = 4;
			// 
			// panel6
			// 
			this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel6.Location = new System.Drawing.Point(0, 276);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(712, 216);
			this.panel6.TabIndex = 12;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.groupBox1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(712, 276);
			this.panel2.TabIndex = 11;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.textBox13);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.textBox12);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.textBox11);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.textBox10);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.textBox9);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.textBox8);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.textBox7);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.textBox6);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.textBox5);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.textBox4);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.textBox3);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(4, -4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(708, 276);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Tag = "N";
			// 
			// textBox13
			// 
			this.textBox13.Location = new System.Drawing.Point(376, 244);
			this.textBox13.MaxLength = 20;
			this.textBox13.Name = "textBox13";
			this.textBox13.Size = new System.Drawing.Size(160, 23);
			this.textBox13.TabIndex = 24;
			this.textBox13.Tag = "COM_CD";
			this.textBox13.Text = "textBox13";
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(280, 248);
			this.label14.Name = "label14";
			this.label14.TabIndex = 25;
			this.label14.Tag = "COM_CD";
			this.label14.Text = "COM_CD";
			// 
			// textBox12
			// 
			this.textBox12.Location = new System.Drawing.Point(116, 244);
			this.textBox12.MaxLength = 20;
			this.textBox12.Name = "textBox12";
			this.textBox12.Size = new System.Drawing.Size(160, 23);
			this.textBox12.TabIndex = 22;
			this.textBox12.Tag = "ACC_NO";
			this.textBox12.Text = "textBox12";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(8, 248);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(108, 23);
			this.label13.TabIndex = 23;
			this.label13.Tag = "ACC_NO";
			this.label13.Text = "ACC_NO";
			// 
			// textBox11
			// 
			this.textBox11.Location = new System.Drawing.Point(116, 216);
			this.textBox11.MaxLength = 100;
			this.textBox11.Name = "textBox11";
			this.textBox11.Size = new System.Drawing.Size(420, 23);
			this.textBox11.TabIndex = 20;
			this.textBox11.Tag = "BNK_NM";
			this.textBox11.Text = "BNK_NM";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(8, 220);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(108, 23);
			this.label12.TabIndex = 21;
			this.label12.Tag = "BNK_NM";
			this.label12.Text = "BNK_NM";
			// 
			// textBox10
			// 
			this.textBox10.Location = new System.Drawing.Point(116, 188);
			this.textBox10.MaxLength = 200;
			this.textBox10.Name = "textBox10";
			this.textBox10.Size = new System.Drawing.Size(420, 23);
			this.textBox10.TabIndex = 18;
			this.textBox10.Tag = "WEB_AD";
			this.textBox10.Text = "textBox10";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(8, 192);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(108, 23);
			this.label11.TabIndex = 19;
			this.label11.Tag = "WEB_AD";
			this.label11.Text = "ADD_DR";
			// 
			// textBox9
			// 
			this.textBox9.Location = new System.Drawing.Point(116, 160);
			this.textBox9.MaxLength = 50;
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(420, 23);
			this.textBox9.TabIndex = 16;
			this.textBox9.Tag = "EMA_NM";
			this.textBox9.Text = "textBox9";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(8, 164);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(108, 23);
			this.label10.TabIndex = 17;
			this.label10.Tag = "EMA_NM";
			this.label10.Text = "Email";
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(116, 132);
			this.textBox8.MaxLength = 200;
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(420, 23);
			this.textBox8.TabIndex = 14;
			this.textBox8.Tag = "ADD_DR";
			this.textBox8.Text = "textBox8";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(8, 136);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(108, 23);
			this.label9.TabIndex = 15;
			this.label9.Tag = "ADD_DR";
			this.label9.Text = "ADD_DR";
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(376, 104);
			this.textBox7.MaxLength = 20;
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(160, 23);
			this.textBox7.TabIndex = 12;
			this.textBox7.Tag = "FAX_N2";
			this.textBox7.Text = "textBox7";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(280, 108);
			this.label8.Name = "label8";
			this.label8.TabIndex = 13;
			this.label8.Tag = "FAX_N2";
			this.label8.Text = "Fax2";
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(116, 104);
			this.textBox6.MaxLength = 20;
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(160, 23);
			this.textBox6.TabIndex = 10;
			this.textBox6.Tag = "FAX_N1";
			this.textBox6.Text = "textBox6";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(8, 108);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(108, 23);
			this.label7.TabIndex = 11;
			this.label7.Tag = "FAX_N1";
			this.label7.Text = "Fax1";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(376, 76);
			this.textBox5.MaxLength = 20;
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(160, 23);
			this.textBox5.TabIndex = 8;
			this.textBox5.Tag = "TEL_N2";
			this.textBox5.Text = "textBox5";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(280, 80);
			this.label6.Name = "label6";
			this.label6.TabIndex = 9;
			this.label6.Tag = "TEL_N2";
			this.label6.Text = "Tel2";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(116, 76);
			this.textBox4.MaxLength = 20;
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(160, 23);
			this.textBox4.TabIndex = 6;
			this.textBox4.Tag = "TEL_N1";
			this.textBox4.Text = "textBox4";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 80);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(108, 23);
			this.label4.TabIndex = 7;
			this.label4.Tag = "TEL_N1";
			this.label4.Text = "Tel1";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(116, 20);
			this.textBox3.MaxLength = 80;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(420, 23);
			this.textBox3.TabIndex = 4;
			this.textBox3.Tag = "COM_N2";
			this.textBox3.Text = "textBox3";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(108, 23);
			this.label3.TabIndex = 5;
			this.label3.Tag = "COM_N2";
			this.label3.Text = "Full Name";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(116, 48);
			this.textBox2.MaxLength = 80;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(420, 23);
			this.textBox2.TabIndex = 2;
			this.textBox2.Tag = "COM_N1";
			this.textBox2.Text = "textBox2";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(108, 23);
			this.label2.TabIndex = 3;
			this.label2.Tag = "COM_N1";
			this.label2.Text = "Short Name";
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.LemonChiffon;
			this.textBox1.Location = new System.Drawing.Point(636, 16);
			this.textBox1.MaxLength = 12;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(52, 23);
			this.textBox1.TabIndex = 0;
			this.textBox1.Tag = "COM_ID";
			this.textBox1.Text = "textBox1";
			this.textBox1.Visible = false;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(540, 20);
			this.label1.Name = "label1";
			this.label1.TabIndex = 1;
			this.label1.Tag = "COM_ID";
			this.label1.Text = "ID";
			this.label1.Visible = false;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.panel4);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(200, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(712, 36);
			this.panel3.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Location = new System.Drawing.Point(416, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(296, 36);
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
			// c1CommandDock1
			// 
			this.c1CommandDock1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.c1CommandDock1.Controls.Add(this.c1DockingTab1);
			this.c1CommandDock1.Dock = System.Windows.Forms.DockStyle.Left;
			this.c1CommandDock1.Id = 1;
			this.c1CommandDock1.Location = new System.Drawing.Point(0, 0);
			this.c1CommandDock1.Name = "c1CommandDock1";
			this.c1CommandDock1.Size = new System.Drawing.Size(200, 528);
			// 
			// c1DockingTab1
			// 
			this.c1DockingTab1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
			this.c1DockingTab1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.c1DockingTab1.CanAutoHide = true;
			this.c1DockingTab1.CanMoveTabs = true;
			this.c1DockingTab1.Controls.Add(this.c1DockingTabPage1);
			this.c1DockingTab1.Location = new System.Drawing.Point(0, 0);
			this.c1DockingTab1.Name = "c1DockingTab1";
			this.c1DockingTab1.SelectedIndex = 0;
			this.c1DockingTab1.ShowCaption = true;
			this.c1DockingTab1.ShowSingleTab = false;
			this.c1DockingTab1.Size = new System.Drawing.Size(198, 526);
			this.c1DockingTab1.TabIndex = 0;
			this.c1DockingTab1.TabSizeMode = C1.Win.C1Command.TabSizeModeEnum.Fit;
			this.c1DockingTab1.TabStyle = C1.Win.C1Command.TabStyleEnum.WindowsXP;
			// 
			// c1DockingTabPage1
			// 
			this.c1DockingTabPage1.Controls.Add(this.vs);
			this.c1DockingTabPage1.ImageIndex = -1;
			this.c1DockingTabPage1.Location = new System.Drawing.Point(0, 0);
			this.c1DockingTabPage1.Name = "c1DockingTabPage1";
			this.c1DockingTabPage1.Size = new System.Drawing.Size(195, 525);
			this.c1DockingTabPage1.TabIndex = 0;
			this.c1DockingTabPage1.Text = "Page1";
			// 
			// vs
			// 
			this.vs.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vs.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs.Location = new System.Drawing.Point(0, 20);
			this.vs.Name = "vs";
			this.vs.Size = new System.Drawing.Size(195, 505);
			this.vs.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs.TabIndex = 7;
			// 
			// frmTaCompany
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(912, 528);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaCompany";
			this.Text = "frmTaCompany";
			this.Load += new System.EventHandler(this.frmTaCompany_Load);
			this.panel1.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandDock1)).EndInit();
			this.c1CommandDock1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).EndInit();
			this.c1DockingTab1.ResumeLayout(false);
			this.c1DockingTabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaCompany_Load(object sender, System.EventArgs e)
		{
			nav.cmd_copy.Visible=false;
			nav.cmd_report.Visible=false;
			nav.cmd_search.Visible=false;
			PublicFunction.InitNav(this,vs,nav);			
			nav.Show_VS();			
			
			vs.AfterRowColChange+=new C1.Win.C1FlexGrid.RangeEventHandler(vs_AfterRowColChange);
			nav.TBarClick+=new ToolBarButtonClickEventHandler(nav_TBarClick);
			vs.EnabledChanged+=new EventHandler(vs_EnabledChanged);
			vs.AfterEdit+=new C1.Win.C1FlexGrid.RowColEventHandler(vs_AfterEdit);
			vs.BeforeEdit+=new C1.Win.C1FlexGrid.RowColEventHandler(vs_BeforeEdit);
			nav.ToolBar_Auto=false;			
			show_data();
			Basic.Function.PublicFunction.L_Init_Label(this);						
		}
		private void vs_EnabledChanged(object sender, System.EventArgs e)
		{			
			TextBoxAndVS.L_GetLabelFromVS(groupBox1,vs);
		}

		private void show_data()
		{
			TextBoxAndVS.D_GetDataFromVS(groupBox1,vs);			
			if (vs.Row<1) 
			{					
				return;					
			}		
		}

		private void vs_AfterRowColChange(object sender, C1.Win.C1FlexGrid.RangeEventArgs e)
		{			
			if (nav.State==false) return;
			if (e.NewRange.r1!=e.OldRange.r1 && vs.Row>0)
			{
				show_data();
			}		
		}

		private void nav_TBarClick(object sender, ToolBarButtonClickEventArgs e)
		{					
			if (e.Button.Equals(nav.cmd_add))
			{
				if(vs.Rows.Count>=2)
					return;
				if (vs.Rows.Count==1 || (int)vs.Rows[vs.Rows.Count-1].UserData!=2)					
					nav.ToolBar_Click(e);					
				TextBoxAndVS.D_AddNewOrEdit(groupBox1,false);
				vs.Rows[vs.Rows.Count-1]["ACT_BT"]=1;
				textBox1.Text=T_String.GetMax("MAX(COM_ID)","FILA01A")+"";
				return;
			}
			if (e.Button.Equals(nav.cmd_save))
			{
				try
				{
					TextBoxAndVS.D_GetDataFromTextBox(groupBox1,vs);
					if ((int)vs.Rows[vs.Row].UserData!=2)
						vs.Rows[vs.Row].UserData=1;						
					nav.ToolBar_Click(e);
					return ;
				}
				catch( Exception){}
				
			}
			if (e.Button.Equals(nav.cmd_refresh))
			{
				nav.ToolBar_Click(e);				
				show_data();	
				return;
			}
			if (e.Button.Equals(nav.cmd_delete))
			{
				nav.DeleteRow(vs.Row);
				return;
			}
			nav.ToolBar_Click(e);							
		}

		private void vs_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			if(vs.Cols[e.Col].Name=="ACT_BT")
			{
				for(int i=1;i<vs.Rows.Count;i++ )
				{
					vs.Rows[i]["ACT_BT"]="False";
					if ((int)vs.Rows[i].UserData!=2)
						vs.Rows[i].UserData=1;	
				}		
				vs.Rows[e.Row]["ACT_BT"]="True";
			}
		}

		private void vs_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			if(vs.Cols[e.Col].Name=="ACT_BT")
			{
				if(vs.Rows[e.Row]["ACT_BT"]+""=="True")
                    e.Cancel=true;					
			}
		}
	}
}

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
using System.Data;
using System.Data.SqlClient;
using GP8000.Attendance;
using GP8000.Function;
namespace GP8000.UserControl
{
	/// <summary>
	/// Summary description for frmChon.
	/// </summary>
	public class frmChon : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Button btnChon;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel10;
		private C1.Win.C1FlexGrid.C1FlexGrid vs1;
		private Navigator1._0.NavigatorAuto nav1;
		private System.Windows.Forms.Splitter splitter2;
		private System.Windows.Forms.Panel panel9;
		private C1.Win.C1FlexGrid.C1FlexGrid vs;
		private Navigator1._0.NavigatorAuto nav;
		private System.Windows.Forms.Button btnQuit;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button cmd_clear;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnAll;
		private System.Windows.Forms.TextBox txtPOS_NM2;
		private System.Windows.Forms.TextBox txtPOS_ID2;
		private System.Windows.Forms.TextBox txtPOS_NM1;
		private System.Windows.Forms.TextBox txtPOS_ID1;
		private System.Windows.Forms.Label lblTitle;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmChon()
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
			this.panel6 = new System.Windows.Forms.Panel();
			this.btnChon = new System.Windows.Forms.Button();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.panel7 = new System.Windows.Forms.Panel();
			this.panel10 = new System.Windows.Forms.Panel();
			this.nav1 = new Navigator1._0.NavigatorAuto();
			this.txtPOS_NM2 = new System.Windows.Forms.TextBox();
			this.txtPOS_ID2 = new System.Windows.Forms.TextBox();
			this.vs1 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.splitter2 = new System.Windows.Forms.Splitter();
			this.panel9 = new System.Windows.Forms.Panel();
			this.nav = new Navigator1._0.NavigatorAuto();
			this.txtPOS_NM1 = new System.Windows.Forms.TextBox();
			this.txtPOS_ID1 = new System.Windows.Forms.TextBox();
			this.vs = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.btnQuit = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnAll = new System.Windows.Forms.Button();
			this.cmd_clear = new System.Windows.Forms.Button();
			this.lblTitle = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel10.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs1)).BeginInit();
			this.panel9.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
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
			this.panel1.Size = new System.Drawing.Size(480, 362);
			this.panel1.TabIndex = 6;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.panel6);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 36);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(480, 326);
			this.panel2.TabIndex = 5;
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.btnChon);
			this.panel6.Controls.Add(this.splitter1);
			this.panel6.Controls.Add(this.panel7);
			this.panel6.Controls.Add(this.btnQuit);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel6.Location = new System.Drawing.Point(0, 0);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(480, 326);
			this.panel6.TabIndex = 1;
			// 
			// btnChon
			// 
			this.btnChon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnChon.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnChon.Location = new System.Drawing.Point(324, 288);
			this.btnChon.Name = "btnChon";
			this.btnChon.Size = new System.Drawing.Size(72, 32);
			this.btnChon.TabIndex = 146;
			this.btnChon.Tag = "btnChon";
			this.btnChon.Text = "Chọn";
			this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
			// 
			// splitter1
			// 
			this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
			this.splitter1.Location = new System.Drawing.Point(0, 280);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(480, 4);
			this.splitter1.TabIndex = 1;
			this.splitter1.TabStop = false;
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.panel10);
			this.panel7.Controls.Add(this.splitter2);
			this.panel7.Controls.Add(this.panel9);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(480, 280);
			this.panel7.TabIndex = 0;
			// 
			// panel10
			// 
			this.panel10.Controls.Add(this.nav1);
			this.panel10.Controls.Add(this.txtPOS_NM2);
			this.panel10.Controls.Add(this.txtPOS_ID2);
			this.panel10.Controls.Add(this.vs1);
			this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel10.Location = new System.Drawing.Point(244, 0);
			this.panel10.Name = "panel10";
			this.panel10.Size = new System.Drawing.Size(236, 280);
			this.panel10.TabIndex = 2;
			// 
			// nav1
			// 
			this.nav1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.nav1.Connection = null;
			this.nav1.ConnectionDel = null;
			this.nav1.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.nav1.form = null;
			this.nav1.FormName = null;
			this.nav1.Grid = null;
			this.nav1.History = false;
			this.nav1.IsNull = true;
			this.nav1.Language = "EN";
			this.nav1.Location = new System.Drawing.Point(56, 140);
			this.nav1.MSG_Exit = false;
			this.nav1.MulltiDel = false;
			this.nav1.Name = "nav1";
			this.nav1.Security = 0;
			this.nav1.ShowPopupMenu = false;
			this.nav1.Size = new System.Drawing.Size(144, 32);
			this.nav1.TabIndex = 12;
			this.nav1.Tag = "";
			this.nav1.ToolBar_Auto = true;
			this.nav1.UserID = null;
			this.nav1.Visible = false;
			this.nav1.VisibleGrid = true;
			this.nav1.Where = null;
			// 
			// txtPOS_NM2
			// 
			this.txtPOS_NM2.BackColor = System.Drawing.Color.LemonChiffon;
			this.txtPOS_NM2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtPOS_NM2.Location = new System.Drawing.Point(120, 4);
			this.txtPOS_NM2.MaxLength = 20;
			this.txtPOS_NM2.Name = "txtPOS_NM2";
			this.txtPOS_NM2.Size = new System.Drawing.Size(112, 23);
			this.txtPOS_NM2.TabIndex = 38;
			this.txtPOS_NM2.Tag = "POS_NM";
			this.txtPOS_NM2.Text = "textBox3";
			this.txtPOS_NM2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt8_KeyDown);
			this.txtPOS_NM2.Leave += new System.EventHandler(this.textBox1_Leave);
			this.txtPOS_NM2.Enter += new System.EventHandler(this.textBox1_Enter);
			// 
			// txtPOS_ID2
			// 
			this.txtPOS_ID2.BackColor = System.Drawing.Color.LemonChiffon;
			this.txtPOS_ID2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtPOS_ID2.Location = new System.Drawing.Point(4, 4);
			this.txtPOS_ID2.MaxLength = 20;
			this.txtPOS_ID2.Name = "txtPOS_ID2";
			this.txtPOS_ID2.Size = new System.Drawing.Size(112, 23);
			this.txtPOS_ID2.TabIndex = 37;
			this.txtPOS_ID2.Tag = "POS_ID";
			this.txtPOS_ID2.Text = "txt8";
			this.txtPOS_ID2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt8_KeyDown);
			this.txtPOS_ID2.Leave += new System.EventHandler(this.textBox1_Leave);
			this.txtPOS_ID2.Enter += new System.EventHandler(this.textBox1_Enter);
			// 
			// vs1
			// 
			this.vs1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.vs1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs1.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vs1.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs1.Location = new System.Drawing.Point(4, 32);
			this.vs1.Name = "vs1";
			this.vs1.Size = new System.Drawing.Size(227, 244);
			this.vs1.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.vs1.TabIndex = 11;
			// 
			// splitter2
			// 
			this.splitter2.Location = new System.Drawing.Point(240, 0);
			this.splitter2.Name = "splitter2";
			this.splitter2.Size = new System.Drawing.Size(4, 280);
			this.splitter2.TabIndex = 1;
			this.splitter2.TabStop = false;
			// 
			// panel9
			// 
			this.panel9.Controls.Add(this.nav);
			this.panel9.Controls.Add(this.txtPOS_NM1);
			this.panel9.Controls.Add(this.txtPOS_ID1);
			this.panel9.Controls.Add(this.vs);
			this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel9.Location = new System.Drawing.Point(0, 0);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(240, 280);
			this.panel9.TabIndex = 0;
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
			this.nav.Location = new System.Drawing.Point(48, 144);
			this.nav.MSG_Exit = false;
			this.nav.MulltiDel = false;
			this.nav.Name = "nav";
			this.nav.Security = 0;
			this.nav.ShowPopupMenu = false;
			this.nav.Size = new System.Drawing.Size(144, 32);
			this.nav.TabIndex = 9;
			this.nav.Tag = "";
			this.nav.ToolBar_Auto = true;
			this.nav.UserID = null;
			this.nav.Visible = false;
			this.nav.VisibleGrid = true;
			this.nav.Where = null;
			// 
			// txtPOS_NM1
			// 
			this.txtPOS_NM1.BackColor = System.Drawing.Color.LemonChiffon;
			this.txtPOS_NM1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtPOS_NM1.Location = new System.Drawing.Point(120, 4);
			this.txtPOS_NM1.MaxLength = 20;
			this.txtPOS_NM1.Name = "txtPOS_NM1";
			this.txtPOS_NM1.Size = new System.Drawing.Size(112, 23);
			this.txtPOS_NM1.TabIndex = 35;
			this.txtPOS_NM1.Tag = "POS_NM";
			this.txtPOS_NM1.Text = "textBox3";
			this.txtPOS_NM1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
			this.txtPOS_NM1.Leave += new System.EventHandler(this.textBox1_Leave);
			this.txtPOS_NM1.Enter += new System.EventHandler(this.textBox1_Enter);
			// 
			// txtPOS_ID1
			// 
			this.txtPOS_ID1.BackColor = System.Drawing.Color.LemonChiffon;
			this.txtPOS_ID1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtPOS_ID1.Location = new System.Drawing.Point(4, 4);
			this.txtPOS_ID1.MaxLength = 20;
			this.txtPOS_ID1.Name = "txtPOS_ID1";
			this.txtPOS_ID1.Size = new System.Drawing.Size(112, 23);
			this.txtPOS_ID1.TabIndex = 34;
			this.txtPOS_ID1.Tag = "POS_ID";
			this.txtPOS_ID1.Text = "textBox3";
			this.txtPOS_ID1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
			this.txtPOS_ID1.Leave += new System.EventHandler(this.textBox1_Leave);
			this.txtPOS_ID1.Enter += new System.EventHandler(this.textBox1_Enter);
			// 
			// vs
			// 
			this.vs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.vs.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vs.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs.Location = new System.Drawing.Point(4, 28);
			this.vs.Name = "vs";
			this.vs.Size = new System.Drawing.Size(232, 248);
			this.vs.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.vs.TabIndex = 10;
			// 
			// btnQuit
			// 
			this.btnQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnQuit.Location = new System.Drawing.Point(404, 288);
			this.btnQuit.Name = "btnQuit";
			this.btnQuit.Size = new System.Drawing.Size(72, 32);
			this.btnQuit.TabIndex = 146;
			this.btnQuit.Tag = "btnQuit";
			this.btnQuit.Text = "Đóng";
			this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.panel3.Controls.Add(this.btnClear);
			this.panel3.Controls.Add(this.btnAll);
			this.panel3.Controls.Add(this.cmd_clear);
			this.panel3.Controls.Add(this.lblTitle);
			this.panel3.Controls.Add(this.panel4);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(480, 36);
			this.panel3.TabIndex = 4;
			// 
			// btnClear
			// 
			this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClear.BackColor = System.Drawing.Color.Moccasin;
			this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnClear.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnClear.Location = new System.Drawing.Point(368, 4);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(108, 28);
			this.btnClear.TabIndex = 148;
			this.btnClear.Tag = "btnClear";
			this.btnClear.Text = "Clear";
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnAll
			// 
			this.btnAll.BackColor = System.Drawing.Color.Moccasin;
			this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnAll.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnAll.Location = new System.Drawing.Point(8, 4);
			this.btnAll.Name = "btnAll";
			this.btnAll.Size = new System.Drawing.Size(108, 28);
			this.btnAll.TabIndex = 147;
			this.btnAll.Tag = "btnAll";
			this.btnAll.Text = "ALL";
			this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
			// 
			// cmd_clear
			// 
			this.cmd_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmd_clear.BackColor = System.Drawing.Color.Moccasin;
			this.cmd_clear.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_clear.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmd_clear.Location = new System.Drawing.Point(612, 4);
			this.cmd_clear.Name = "cmd_clear";
			this.cmd_clear.Size = new System.Drawing.Size(108, 28);
			this.cmd_clear.TabIndex = 146;
			this.cmd_clear.Text = "Clear";
			// 
			// lblTitle
			// 
			this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblTitle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.lblTitle.Location = new System.Drawing.Point(8, 0);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(472, 36);
			this.lblTitle.TabIndex = 11;
			this.lblTitle.Tag = "lblTitle";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(8, 36);
			this.panel4.TabIndex = 10;
			// 
			// frmChon
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(480, 362);
			this.Controls.Add(this.panel1);
			this.Name = "frmChon";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Tag = "";
			this.Text = "frmChon";
			this.Load += new System.EventHandler(this.frmChon_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel10.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs1)).EndInit();
			this.panel9.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnQuit_Click(object sender, System.EventArgs e)
		{
			this.DialogResult=DialogResult.Cancel;
			this.Close();
		}

		private void btnChon_Click(object sender, System.EventArgs e)
		{
			arrListMaChucVu=new ArrayList();
			for (int x=1; x< vs1.Rows.Count; x++)			
				arrListMaChucVu.Add(vs1.Rows[x]["POS_ID"].ToString());
			
			this.DialogResult=DialogResult.OK;
		}
		
		public ArrayList arrListMaChucVu;
		private void frmChon_Load(object sender, System.EventArgs e)
		{
			Init_vs();	
			Init_vs1();
			Basic.Function.PublicFunction.L_Init_Label(this);	
					
			btnChon.Enabled=vs1.Rows.Count>1;

			//string sql="select POS_ID,POS_NM from FILA07A";						
			//vs.Cols["POS_ID"].DataMap=PublicFunction.InitCBForVS(sql,false);
			//vs1.Cols["POS_ID"].DataMap=PublicFunction.InitCBForVS(sql,false);

			//nav.Show_VS();
			//nav1.Show_VS();
		}

		private void Init_vs()
		{
			nav.cmd_save.Visible=nav.cmd_search.Visible=nav.cmd_report.Visible=nav.cmd_delete.Visible=nav.cmd_add.Visible=nav.cmd_copy.Visible=false;
			PublicFunction.InitNav(this,vs,nav);
			vs.AllowEditing=false;					
			vs.DoubleClick+=new EventHandler(vs_DoubleClick);
			vs.SelectionMode=C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;	
			vs.EnabledChanged+=new EventHandler(vs_EnabledChanged);
		}	

		private void Init_vs1()
		{			
			nav1.cmd_save.Visible=nav1.cmd_search.Visible=nav1.cmd_report.Visible=nav1.cmd_delete.Visible=nav1.cmd_add.Visible=nav1.cmd_copy.Visible=false;
			PublicFunction.InitNav(this,vs1,nav1);
			vs1.AllowEditing=false;						
			vs1.SelectionMode=C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;		
			vs1.DoubleClick+=new EventHandler(vs1_DoubleClick);			
		}	

		private void vs_DoubleClick(object sender, EventArgs e)
		{		
			if(vs.Row>0)
			{
				for(int i=1;i<vs1.Rows.Count;i++)
				{
					if(	vs1.Rows[i]["POS_ID"]+""==vs.Rows[vs.Row]["POS_ID"]+"")
						return;
				}
				vs1.Rows.Count++;
				vs1.Rows[vs1.Rows.Count-1][0]=vs1.Rows.Count-1;
				for(int i=1;i<vs.Cols.Count;i++)
				{
					vs1.Rows[vs1.Rows.Count-1][vs.Cols[i].Name]=vs.Rows[vs.Row][i];
				}
			}			
			btnChon.Enabled=vs1.Rows.Count>1;
		}

		private void vs1_DoubleClick(object sender, EventArgs e)
		{		
			if(vs1.Row>0)
				vs1.RemoveItem(vs1.Row);
			btnChon.Enabled=vs1.Rows.Count>1;
		}

		private void textBox1_Enter(object sender, System.EventArgs e)
		{
			//this.AcceptButton=null;
			TextBox txt=(TextBox)sender;
			if (txt.Text == vs.Cols[txt.Tag+""].Caption)
				txt.Text="";
		}

		private void textBox1_Leave(object sender, System.EventArgs e)
		{
			//this.AcceptButton=null;
			TextBox txt=(TextBox)sender;
			if (txt.Text=="")
				txt.Text=vs.Cols[txt.Tag+""].Caption;
		}

		private void textBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			//this.AcceptButton=null;
			if(e.KeyCode==Keys.Enter)
			{
				string f=((TextBox)sender).Tag+"";				
				string sql;				
				if(((TextBox)sender).Text+""!="")
					sql=f+" like N'%"+((TextBox)sender).Text+"%'";
				else
					sql="1=1";
////				sql= sql+" and  (VAC_BT=0 or VAC_BT is null) and DEP_ID in (Select DEP_ID  from SYS_SECURITY_DEP"+
////					" where MNU_ID="+this.Tag+" and ALL_BT=1  and USER_ID=N'"+PublicFunction.A_UserID+"')";					
				nav.Show_VS(sql);						
			}
		}

		private void txt8_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Enter)
			{
				string f=((TextBox)sender).Tag+"";				
				string sql;				
				if(((TextBox)sender).Text+""!="")
					sql=f+" like N'%"+((TextBox)sender).Text+"%'";
				else
					sql="1=1";
////				sql= sql+" and  (VAC_BT=0 or VAC_BT is null) and DEP_ID in (Select DEP_ID  from SYS_SECURITY_DEP"+
////					" where MNU_ID="+this.Tag+" and ALL_BT=1  and USER_ID=N'"+PublicFunction.A_UserID+"')";					
				nav1.Show_VS(sql);						
			}
			btnChon.Enabled=vs1.Rows.Count>1;
		}

		private void vs_EnabledChanged(object sender, EventArgs e)
		{
			txtPOS_ID1.Text=vs.Cols[txtPOS_ID1.Tag+""].Caption;
			txtPOS_NM1.Text=vs.Cols[txtPOS_NM1.Tag+""].Caption;	
			
			txtPOS_ID2.Text=vs.Cols[txtPOS_ID2.Tag+""].Caption;
			txtPOS_NM2.Text=vs.Cols[txtPOS_NM2.Tag+""].Caption;		
		}

		private void btnClear_Click(object sender, System.EventArgs e)
		{
			vs1.Rows.Count=1;
			btnChon.Enabled=vs1.Rows.Count>1;
		}

		private void btnAll_Click(object sender, System.EventArgs e)
		{
			for(int j=1;j<vs.Rows.Count;j++)
			{
				int i;
				for(i=1;i<vs1.Rows.Count;i++)
				{
					if(	vs1.Rows[i]["POS_ID"]+""==vs.Rows[j]["POS_ID"]+"")
						break;
				}
				if(i>=vs1.Rows.Count)
				{
					vs1.Rows.Count++;
					vs1.Rows[vs1.Rows.Count-1][0]=vs1.Rows.Count-1;
					for(int m=1;m<vs.Cols.Count;m++)
					{
						//vs1.Rows[vs1.Rows.Count-1][m]=vs.Rows[j][m];
						vs1.Rows[vs1.Rows.Count-1][vs.Cols[m].Name]=vs.Rows[j][m];
						
					}
				}
			}					
			btnChon.Enabled=vs1.Rows.Count>1;
		}
	}
}

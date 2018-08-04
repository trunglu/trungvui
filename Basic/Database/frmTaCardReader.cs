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
namespace GP8000.Database
{
	/// <summary>
	/// Summary description for frmTaCardReader.
	/// </summary>
	public class frmTaCardReader : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button cmd_save;
		private System.Windows.Forms.Button cmd_close;
		private System.Windows.Forms.Button cmd1;
		private System.Windows.Forms.Button cmd3;
		private System.Windows.Forms.Button cmd2;
		private System.Windows.Forms.Button cmd4;
		private System.Windows.Forms.TextBox txt_path1;
		private System.Windows.Forms.TextBox txt_file1;
		private System.Windows.Forms.ComboBox cb1;
		private System.Windows.Forms.ComboBox cb2;
		private System.Windows.Forms.TextBox txt_file2;
		private System.Windows.Forms.TextBox txt_path2;
		private System.Windows.Forms.OpenFileDialog f2;
		private System.Windows.Forms.FolderBrowserDialog f1;
		private System.Windows.Forms.OpenFileDialog f3;
		private C1.Win.C1Input.C1TextBox txt_len;
		private C1.Win.C1Input.C1TextBox txt_book1;
		private C1.Win.C1Input.C1TextBox txt_book2;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.Panel panel10;
		private C1.Win.C1FlexGrid.C1FlexGrid vs;
		private Navigator1._0.NavigatorAuto nav;
		private System.Windows.Forms.Panel panel11;
		private System.Windows.Forms.Label label9;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaCardReader()
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
			this.panel3 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.panel9 = new System.Windows.Forms.Panel();
			this.panel11 = new System.Windows.Forms.Panel();
			this.label9 = new System.Windows.Forms.Label();
			this.nav = new Navigator1._0.NavigatorAuto();
			this.vs = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.panel10 = new System.Windows.Forms.Panel();
			this.panel8 = new System.Windows.Forms.Panel();
			this.cmd4 = new System.Windows.Forms.Button();
			this.txt_book2 = new C1.Win.C1Input.C1TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.cb2 = new System.Windows.Forms.ComboBox();
			this.cmd3 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.txt_file2 = new System.Windows.Forms.TextBox();
			this.cmd_close = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.cmd_save = new System.Windows.Forms.Button();
			this.txt_path2 = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.txt_book1 = new C1.Win.C1Input.C1TextBox();
			this.txt_len = new C1.Win.C1Input.C1TextBox();
			this.cmd2 = new System.Windows.Forms.Button();
			this.label12 = new System.Windows.Forms.Label();
			this.cb1 = new System.Windows.Forms.ComboBox();
			this.cmd1 = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.txt_file1 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_path1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.f2 = new System.Windows.Forms.OpenFileDialog();
			this.f1 = new System.Windows.Forms.FolderBrowserDialog();
			this.f3 = new System.Windows.Forms.OpenFileDialog();
			this.panel3.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel9.SuspendLayout();
			this.panel11.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
			this.panel8.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txt_book2)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txt_book1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_len)).BeginInit();
			this.SuspendLayout();
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.panel3.Controls.Add(this.label5);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(820, 36);
			this.panel3.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Location = new System.Drawing.Point(0, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(820, 36);
			this.label5.TabIndex = 11;
			this.label5.Tag = "";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 36);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(820, 628);
			this.panel1.TabIndex = 5;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.panel6);
			this.panel4.Controls.Add(this.panel5);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(0, 164);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(820, 464);
			this.panel4.TabIndex = 1;
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.panel7);
			this.panel6.Controls.Add(this.label13);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel6.Location = new System.Drawing.Point(0, 4);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(820, 460);
			this.panel6.TabIndex = 1;
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.panel9);
			this.panel7.Controls.Add(this.panel8);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel7.Location = new System.Drawing.Point(0, 36);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(820, 424);
			this.panel7.TabIndex = 28;
			// 
			// panel9
			// 
			this.panel9.Controls.Add(this.panel11);
			this.panel9.Controls.Add(this.vs);
			this.panel9.Controls.Add(this.panel10);
			this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel9.Location = new System.Drawing.Point(0, 168);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(820, 256);
			this.panel9.TabIndex = 29;
			// 
			// panel11
			// 
			this.panel11.Controls.Add(this.label9);
			this.panel11.Controls.Add(this.nav);
			this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel11.Location = new System.Drawing.Point(0, 4);
			this.panel11.Name = "panel11";
			this.panel11.Size = new System.Drawing.Size(820, 32);
			this.panel11.TabIndex = 27;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.LightSteelBlue;
			this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label9.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.Blue;
			this.label9.Location = new System.Drawing.Point(360, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(460, 32);
			this.label9.TabIndex = 28;
			this.label9.Tag = "";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// nav
			// 
			this.nav.BackColor = System.Drawing.Color.LightSteelBlue;
			this.nav.Connection = null;
			this.nav.ConnectionDel = null;
			this.nav.Dock = System.Windows.Forms.DockStyle.Left;
			this.nav.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.nav.form = null;
			this.nav.FormName = null;
			this.nav.Grid = null;
			this.nav.History = false;
			this.nav.IsNull = true;
			this.nav.Language = "EN";
			this.nav.Location = new System.Drawing.Point(0, 0);
			this.nav.MSG_Exit = false;
			this.nav.MulltiDel = true;
			this.nav.Name = "nav";
			this.nav.Security = 0;
			this.nav.ShowPopupMenu = true;
			this.nav.Size = new System.Drawing.Size(360, 32);
			this.nav.TabIndex = 27;
			this.nav.Tag = "";
			this.nav.ToolBar_Auto = true;
			this.nav.UserID = null;
			this.nav.VisibleGrid = true;
			this.nav.Where = null;
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
			this.vs.Location = new System.Drawing.Point(4, 40);
			this.vs.Name = "vs";
			this.vs.Size = new System.Drawing.Size(812, 216);
			this.vs.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs.TabIndex = 26;
			// 
			// panel10
			// 
			this.panel10.BackColor = System.Drawing.Color.CornflowerBlue;
			this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel10.Location = new System.Drawing.Point(0, 0);
			this.panel10.Name = "panel10";
			this.panel10.Size = new System.Drawing.Size(820, 4);
			this.panel10.TabIndex = 24;
			// 
			// panel8
			// 
			this.panel8.Controls.Add(this.cmd4);
			this.panel8.Controls.Add(this.txt_book2);
			this.panel8.Controls.Add(this.label10);
			this.panel8.Controls.Add(this.label11);
			this.panel8.Controls.Add(this.cb2);
			this.panel8.Controls.Add(this.cmd3);
			this.panel8.Controls.Add(this.label7);
			this.panel8.Controls.Add(this.txt_file2);
			this.panel8.Controls.Add(this.cmd_close);
			this.panel8.Controls.Add(this.label8);
			this.panel8.Controls.Add(this.cmd_save);
			this.panel8.Controls.Add(this.txt_path2);
			this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel8.Location = new System.Drawing.Point(0, 0);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(820, 168);
			this.panel8.TabIndex = 28;
			// 
			// cmd4
			// 
			this.cmd4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd4.Location = new System.Drawing.Point(568, 64);
			this.cmd4.Name = "cmd4";
			this.cmd4.Size = new System.Drawing.Size(28, 23);
			this.cmd4.TabIndex = 26;
			this.cmd4.Tag = "N";
			this.cmd4.Text = "...";
			this.cmd4.Click += new System.EventHandler(this.cmd4_Click);
			// 
			// txt_book2
			// 
			this.txt_book2.CustomFormat = "######";
			this.txt_book2.DataType = typeof(short);
			this.txt_book2.Location = new System.Drawing.Point(124, 92);
			this.txt_book2.MaxLength = 100;
			this.txt_book2.Name = "txt_book2";
			this.txt_book2.Size = new System.Drawing.Size(176, 23);
			this.txt_book2.TabIndex = 27;
			this.txt_book2.Tag = null;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(20, 40);
			this.label10.Name = "label10";
			this.label10.TabIndex = 13;
			this.label10.Text = "Path";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(20, 16);
			this.label11.Name = "label11";
			this.label11.TabIndex = 12;
			this.label11.Text = "Type";
			// 
			// cb2
			// 
			this.cb2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb2.Location = new System.Drawing.Point(124, 8);
			this.cb2.Name = "cb2";
			this.cb2.Size = new System.Drawing.Size(176, 24);
			this.cb2.TabIndex = 22;
			// 
			// cmd3
			// 
			this.cmd3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd3.Location = new System.Drawing.Point(568, 36);
			this.cmd3.Name = "cmd3";
			this.cmd3.Size = new System.Drawing.Size(28, 23);
			this.cmd3.TabIndex = 21;
			this.cmd3.Tag = "N";
			this.cmd3.Text = "...";
			this.cmd3.Click += new System.EventHandler(this.cmd3_Click);
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(20, 96);
			this.label7.Name = "label7";
			this.label7.TabIndex = 19;
			this.label7.Text = "Type";
			// 
			// txt_file2
			// 
			this.txt_file2.Location = new System.Drawing.Point(124, 64);
			this.txt_file2.Name = "txt_file2";
			this.txt_file2.Size = new System.Drawing.Size(444, 23);
			this.txt_file2.TabIndex = 18;
			this.txt_file2.Text = "";
			// 
			// cmd_close
			// 
			this.cmd_close.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_close.Location = new System.Drawing.Point(340, 128);
			this.cmd_close.Name = "cmd_close";
			this.cmd_close.Size = new System.Drawing.Size(116, 36);
			this.cmd_close.TabIndex = 25;
			this.cmd_close.Text = "Close";
			this.cmd_close.Click += new System.EventHandler(this.cmd_close_Click);
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(20, 68);
			this.label8.Name = "label8";
			this.label8.TabIndex = 17;
			this.label8.Text = "Type";
			// 
			// cmd_save
			// 
			this.cmd_save.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_save.Location = new System.Drawing.Point(160, 128);
			this.cmd_save.Name = "cmd_save";
			this.cmd_save.Size = new System.Drawing.Size(116, 36);
			this.cmd_save.TabIndex = 24;
			this.cmd_save.Text = "Save";
			this.cmd_save.Click += new System.EventHandler(this.cmd_save_Click);
			// 
			// txt_path2
			// 
			this.txt_path2.Location = new System.Drawing.Point(124, 36);
			this.txt_path2.Name = "txt_path2";
			this.txt_path2.Size = new System.Drawing.Size(444, 23);
			this.txt_path2.TabIndex = 14;
			this.txt_path2.Text = "";
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.LightSteelBlue;
			this.label13.Dock = System.Windows.Forms.DockStyle.Top;
			this.label13.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.Blue;
			this.label13.Location = new System.Drawing.Point(0, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(820, 36);
			this.label13.TabIndex = 23;
			this.label13.Tag = "";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.CornflowerBlue;
			this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel5.Location = new System.Drawing.Point(0, 0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(820, 4);
			this.panel5.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.txt_book1);
			this.panel2.Controls.Add(this.txt_len);
			this.panel2.Controls.Add(this.cmd2);
			this.panel2.Controls.Add(this.label12);
			this.panel2.Controls.Add(this.cb1);
			this.panel2.Controls.Add(this.cmd1);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.txt_file1);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.txt_path1);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(820, 164);
			this.panel2.TabIndex = 0;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			// 
			// txt_book1
			// 
			this.txt_book1.CustomFormat = "######";
			this.txt_book1.DataType = typeof(short);
			this.txt_book1.Location = new System.Drawing.Point(124, 128);
			this.txt_book1.MaxLength = 100;
			this.txt_book1.Name = "txt_book1";
			this.txt_book1.Size = new System.Drawing.Size(176, 23);
			this.txt_book1.TabIndex = 15;
			this.txt_book1.Tag = null;
			// 
			// txt_len
			// 
			this.txt_len.CustomFormat = "##";
			this.txt_len.DataType = typeof(short);
			this.txt_len.Location = new System.Drawing.Point(420, 44);
			this.txt_len.MaxLength = 2;
			this.txt_len.Name = "txt_len";
			this.txt_len.Size = new System.Drawing.Size(176, 23);
			this.txt_len.TabIndex = 14;
			this.txt_len.Tag = null;
			// 
			// cmd2
			// 
			this.cmd2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd2.Location = new System.Drawing.Point(568, 100);
			this.cmd2.Name = "cmd2";
			this.cmd2.Size = new System.Drawing.Size(28, 23);
			this.cmd2.TabIndex = 13;
			this.cmd2.Tag = "N";
			this.cmd2.Text = "...";
			this.cmd2.Click += new System.EventHandler(this.cmd2_Click);
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.LightSteelBlue;
			this.label12.Dock = System.Windows.Forms.DockStyle.Top;
			this.label12.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.Blue;
			this.label12.Location = new System.Drawing.Point(0, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(820, 36);
			this.label12.TabIndex = 12;
			this.label12.Tag = "";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cb1
			// 
			this.cb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb1.Location = new System.Drawing.Point(124, 44);
			this.cb1.Name = "cb1";
			this.cb1.Size = new System.Drawing.Size(176, 24);
			this.cb1.TabIndex = 11;
			// 
			// cmd1
			// 
			this.cmd1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd1.Location = new System.Drawing.Point(568, 72);
			this.cmd1.Name = "cmd1";
			this.cmd1.Size = new System.Drawing.Size(28, 23);
			this.cmd1.TabIndex = 10;
			this.cmd1.Tag = "N";
			this.cmd1.Text = "...";
			this.cmd1.Click += new System.EventHandler(this.cmd1_Click);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(20, 136);
			this.label6.Name = "label6";
			this.label6.TabIndex = 8;
			this.label6.Text = "Type";
			// 
			// txt_file1
			// 
			this.txt_file1.Location = new System.Drawing.Point(124, 100);
			this.txt_file1.Name = "txt_file1";
			this.txt_file1.Size = new System.Drawing.Size(444, 23);
			this.txt_file1.TabIndex = 7;
			this.txt_file1.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(20, 108);
			this.label4.Name = "label4";
			this.label4.TabIndex = 6;
			this.label4.Text = "Type";
			// 
			// txt_path1
			// 
			this.txt_path1.Location = new System.Drawing.Point(124, 72);
			this.txt_path1.Name = "txt_path1";
			this.txt_path1.Size = new System.Drawing.Size(444, 23);
			this.txt_path1.TabIndex = 3;
			this.txt_path1.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(316, 52);
			this.label3.Name = "label3";
			this.label3.TabIndex = 4;
			this.label3.Text = "label3";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(20, 80);
			this.label2.Name = "label2";
			this.label2.TabIndex = 2;
			this.label2.Text = "Path";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(20, 52);
			this.label1.Name = "label1";
			this.label1.TabIndex = 0;
			this.label1.Text = "Type";
			// 
			// frmTaCardReader
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(820, 664);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaCardReader";
			this.Text = "frmTaCardReader";
			this.Load += new System.EventHandler(this.frmTaCardReader_Load);
			this.panel3.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel9.ResumeLayout(false);
			this.panel11.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			this.panel8.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txt_book2)).EndInit();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txt_book1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_len)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaCardReader_Load(object sender, System.EventArgs e)
		{
			PublicFunction.InitNav(this,vs,nav);
			nav.cmd_copy.Visible=false;
			nav.cmd_report.Visible=false;			
			nav.cmd_search.Visible=false;
			Basic.Function.PublicFunction.L_Init_Label(this);	
			string sql;			
			//Department
			sql="Select TYP_ID,TYP_NM from GP_SYS_READER_TYPE";						
			PublicFunction.InitCB(cb1,sql);	
			PublicFunction.InitCB(cb2,sql);	
			show_txt();
		}

		private void show_txt()
		{
			Func.RecordSet rs=new Func.RecordSet("Select * from GP_SYS_READER",PublicFunction.C_con);
			if(rs.rows>0)
			{
				cb1.SelectedValue=rs.record(0,"TYP_NM")+"";				
				txt_book1.Value=rs.record(0,"RCD_FG");				
				txt_file1.Text=rs.record(0,"FIL_NM");				
				txt_path1.Text=rs.record(0,"DIR_DR");				
				txt_len.Value=rs.record(0,"CRD_LN");
			}
			if(rs.rows>1)
			{				
				cb2.SelectedValue=rs.record(1,"TYP_NM")+"";			
				txt_book2.Value=rs.record(1,"RCD_FG");				
				txt_file2.Text=rs.record(1,"FIL_NM");				
				txt_path2.Text=rs.record(1,"DIR_DR");				
			}			

		}
		private void cmd_close_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void cmd_save_Click(object sender, System.EventArgs e)
		{
			SqlConnection con=new SqlConnection(PublicFunction.C_con.ConnectionString);
			con.Open();													
			SqlTransaction tran=con.BeginTransaction();				
			try
			{
				string sql="";	
				SqlCommand cmd;												
				sql="delete from GP_SYS_READER ";
				cmd=new SqlCommand(sql,con,tran);
				cmd.ExecuteNonQuery();						

				sql="Insert Into GP_SYS_READER(SEQ_NO,TYP_NM,CRD_LN,DIR_DR,FIL_NM,RCD_FG) values(N'0',"
					+"N'"+cb1.SelectedValue+"',"
					+"N'"+txt_len.Text+"',"
					+"N'"+txt_path1.Text+"',"
					+"N'"+txt_file1.Text+"',"
					+"N'"+txt_book1.Text+"')";
				cmd=new SqlCommand(sql,con,tran);
				cmd.ExecuteNonQuery();	

				sql="Insert Into GP_SYS_READER(SEQ_NO,TYP_NM,CRD_LN,DIR_DR,FIL_NM,RCD_FG) values(N'1',"
					+"N'"+cb2.SelectedValue+"',"
					+"N'"+txt_len.Text+"',"
					+"N'"+txt_path2.Text+"',"
					+"N'"+txt_file2.Text+"',"
					+"N'"+txt_book2.Text+"')";
				cmd=new SqlCommand(sql,con,tran);
				cmd.ExecuteNonQuery();
				tran.Commit();																								
			}				
			catch(Exception ex)
			{
				tran.Rollback();
				MessageBox.Show(ex.Message);
				con.Close();	
				return;
			}									
			MessageBox.Show(PublicFunction.L_Get_Msg("Staff",1));
			con.Close();	
		}

		private void cmd1_Click(object sender, System.EventArgs e)
		{
			f1.SelectedPath=txt_path1.Text;
			if (f1.ShowDialog(this)==DialogResult.OK)
			{
				txt_path1.Text=f1.SelectedPath;
			}
		}

		private void cmd3_Click(object sender, System.EventArgs e)
		{
			f1.SelectedPath=txt_path2.Text;

			if (f1.ShowDialog(this)==DialogResult.OK)
			{
				txt_path2.Text=f1.SelectedPath;
			}
		}

		private void cmd2_Click(object sender, System.EventArgs e)
		{				
			f2.InitialDirectory=txt_path1.Text;	
			f2.Filter =" Text File (*.txt)|*.txt";
			if (f2.ShowDialog(this)== DialogResult.OK)			
			{				
				txt_file1.Text=f2.FileName;
			}
		}

		private void cmd4_Click(object sender, System.EventArgs e)
		{
			f3.Filter =" Text File (*.txt)|*.txt";
			f3.InitialDirectory=txt_path2.Text;			
			if (f3.ShowDialog(this)== DialogResult.OK)			
			{				
				txt_file2.Text=f3.FileName;
			}
		}

		private void panel2_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}

		
	}
}

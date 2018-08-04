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

namespace GP8000.Attendance
{
	/// <summary>
	/// Summary description for frmTaAttendanceFormula.
	/// </summary>
	public class frmTaAttendanceFormula : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private C1.Win.C1FlexGrid.C1FlexGrid vs;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel panel4;
		private Navigator1._0.NavigatorAuto nav;
		private System.Windows.Forms.Button cmd_addcol;
		private System.Windows.Forms.Splitter splitter2;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Splitter splitter3;
		private System.Windows.Forms.Panel panel8;
		private C1.Win.C1FlexGrid.C1FlexGrid vs1;
		private System.Windows.Forms.Splitter splitter4;
		private System.Windows.Forms.Panel panel9;
		private Navigator1._0.NavigatorAuto nav1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Button button14;
		private System.Windows.Forms.Button button15;
		private System.Windows.Forms.Button button16;
		private System.Windows.Forms.Button button17;
		private System.Windows.Forms.Button button18;
		private System.Windows.Forms.Button button19;
		private System.Windows.Forms.Button button20;
		private System.Windows.Forms.Button button21;
		private System.Windows.Forms.Button button22;
		private System.Windows.Forms.Button button23;
		private System.Windows.Forms.Button button24;
		private System.Windows.Forms.Button button25;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private C1.Win.C1FlexGrid.C1FlexGrid vs2;
		private Navigator1._0.NavigatorAuto nav2;
		private System.Windows.Forms.TextBox txt;
		private System.Windows.Forms.TextBox txt1;
		private System.Windows.Forms.TextBox txt_con;
		private System.Windows.Forms.TextBox txt_value;
		private System.Windows.Forms.TextBox txt_item;
		private System.Windows.Forms.Button cmd_check;
		private System.Windows.Forms.TextBox txt_rem;
		Func.RecordSet rsshift;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaAttendanceFormula()
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
			this.cmd_check = new System.Windows.Forms.Button();
			this.cmd_addcol = new System.Windows.Forms.Button();
			this.nav1 = new Navigator1._0.NavigatorAuto();
			this.nav = new Navigator1._0.NavigatorAuto();
			this.label5 = new System.Windows.Forms.Label();
			this.vs = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.txt = new System.Windows.Forms.TextBox();
			this.button21 = new System.Windows.Forms.Button();
			this.button22 = new System.Windows.Forms.Button();
			this.button23 = new System.Windows.Forms.Button();
			this.button24 = new System.Windows.Forms.Button();
			this.button25 = new System.Windows.Forms.Button();
			this.button16 = new System.Windows.Forms.Button();
			this.button17 = new System.Windows.Forms.Button();
			this.button18 = new System.Windows.Forms.Button();
			this.button19 = new System.Windows.Forms.Button();
			this.button20 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button14 = new System.Windows.Forms.Button();
			this.button15 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.panel2 = new System.Windows.Forms.Panel();
			this.splitter2 = new System.Windows.Forms.Splitter();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel9 = new System.Windows.Forms.Panel();
			this.nav2 = new Navigator1._0.NavigatorAuto();
			this.vs2 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.splitter4 = new System.Windows.Forms.Splitter();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel8 = new System.Windows.Forms.Panel();
			this.txt_rem = new System.Windows.Forms.TextBox();
			this.txt_con = new System.Windows.Forms.TextBox();
			this.txt_item = new System.Windows.Forms.TextBox();
			this.txt_value = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.splitter3 = new System.Windows.Forms.Splitter();
			this.panel7 = new System.Windows.Forms.Panel();
			this.vs1 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel9.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs2)).BeginInit();
			this.panel6.SuspendLayout();
			this.panel8.SuspendLayout();
			this.panel7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.panel3.Controls.Add(this.cmd_check);
			this.panel3.Controls.Add(this.cmd_addcol);
			this.panel3.Controls.Add(this.nav1);
			this.panel3.Controls.Add(this.nav);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(956, 32);
			this.panel3.TabIndex = 6;
			// 
			// cmd_check
			// 
			this.cmd_check.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_check.Location = new System.Drawing.Point(832, 2);
			this.cmd_check.Name = "cmd_check";
			this.cmd_check.Size = new System.Drawing.Size(120, 28);
			this.cmd_check.TabIndex = 14;
			this.cmd_check.Text = "button1";
			this.cmd_check.Visible = false;
			this.cmd_check.Click += new System.EventHandler(this.cmd_check_Click);
			// 
			// cmd_addcol
			// 
			this.cmd_addcol.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_addcol.Location = new System.Drawing.Point(4, 2);
			this.cmd_addcol.Name = "cmd_addcol";
			this.cmd_addcol.Size = new System.Drawing.Size(120, 28);
			this.cmd_addcol.TabIndex = 7;
			this.cmd_addcol.Text = "button1";
			this.cmd_addcol.Click += new System.EventHandler(this.cmd_addcol_Click);
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
			this.nav1.Location = new System.Drawing.Point(92, 0);
			this.nav1.MSG_Exit = false;
			this.nav1.MulltiDel = false;
			this.nav1.Name = "nav1";
			this.nav1.Security = 0;
			this.nav1.ShowPopupMenu = true;
			this.nav1.Size = new System.Drawing.Size(126, 32);
			this.nav1.TabIndex = 13;
			this.nav1.Tag = "";
			this.nav1.ToolBar_Auto = true;
			this.nav1.UserID = null;
			this.nav1.Visible = false;
			this.nav1.VisibleGrid = true;
			this.nav1.Where = null;
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
			this.nav.Location = new System.Drawing.Point(292, 2);
			this.nav.MSG_Exit = false;
			this.nav.MulltiDel = false;
			this.nav.Name = "nav";
			this.nav.Security = 0;
			this.nav.ShowPopupMenu = true;
			this.nav.Size = new System.Drawing.Size(340, 32);
			this.nav.TabIndex = 12;
			this.nav.Tag = "";
			this.nav.ToolBar_Auto = true;
			this.nav.UserID = null;
			this.nav.VisibleGrid = true;
			this.nav.Where = null;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Location = new System.Drawing.Point(0, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(956, 32);
			this.label5.TabIndex = 11;
			this.label5.Tag = "";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// vs
			// 
			this.vs.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vs.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs.Location = new System.Drawing.Point(0, 0);
			this.vs.Name = "vs";
			this.vs.Size = new System.Drawing.Size(312, 172);
			this.vs.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs.TabIndex = 11;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Controls.Add(this.splitter1);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 32);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(956, 172);
			this.panel1.TabIndex = 12;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.PeachPuff;
			this.panel4.Controls.Add(this.txt);
			this.panel4.Controls.Add(this.button21);
			this.panel4.Controls.Add(this.button22);
			this.panel4.Controls.Add(this.button23);
			this.panel4.Controls.Add(this.button24);
			this.panel4.Controls.Add(this.button25);
			this.panel4.Controls.Add(this.button16);
			this.panel4.Controls.Add(this.button17);
			this.panel4.Controls.Add(this.button18);
			this.panel4.Controls.Add(this.button19);
			this.panel4.Controls.Add(this.button20);
			this.panel4.Controls.Add(this.button11);
			this.panel4.Controls.Add(this.button12);
			this.panel4.Controls.Add(this.button13);
			this.panel4.Controls.Add(this.button14);
			this.panel4.Controls.Add(this.button15);
			this.panel4.Controls.Add(this.button6);
			this.panel4.Controls.Add(this.button7);
			this.panel4.Controls.Add(this.button8);
			this.panel4.Controls.Add(this.button9);
			this.panel4.Controls.Add(this.button10);
			this.panel4.Controls.Add(this.button5);
			this.panel4.Controls.Add(this.button4);
			this.panel4.Controls.Add(this.button3);
			this.panel4.Controls.Add(this.button2);
			this.panel4.Controls.Add(this.button1);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(315, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(641, 172);
			this.panel4.TabIndex = 2;
			// 
			// txt
			// 
			this.txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.txt.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt.Location = new System.Drawing.Point(388, 4);
			this.txt.Multiline = true;
			this.txt.Name = "txt";
			this.txt.ReadOnly = true;
			this.txt.Size = new System.Drawing.Size(248, 164);
			this.txt.TabIndex = 25;
			this.txt.Text = "";
			// 
			// button21
			// 
			this.button21.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button21.Location = new System.Drawing.Point(316, 136);
			this.button21.Name = "button21";
			this.button21.Size = new System.Drawing.Size(68, 28);
			this.button21.TabIndex = 24;
			this.button21.Tag = "N";
			this.button21.Text = "YEAR()";
			this.button21.Click += new System.EventHandler(this.cmd_click);
			this.button21.MouseEnter += new System.EventHandler(this.button21_MouseEnter);
			// 
			// button22
			// 
			this.button22.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button22.Location = new System.Drawing.Point(316, 104);
			this.button22.Name = "button22";
			this.button22.Size = new System.Drawing.Size(68, 28);
			this.button22.TabIndex = 23;
			this.button22.Tag = "N";
			this.button22.Click += new System.EventHandler(this.cmd_click);
			this.button22.MouseEnter += new System.EventHandler(this.button21_MouseEnter);
			// 
			// button23
			// 
			this.button23.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button23.Location = new System.Drawing.Point(316, 72);
			this.button23.Name = "button23";
			this.button23.Size = new System.Drawing.Size(68, 28);
			this.button23.TabIndex = 22;
			this.button23.Tag = "N";
			this.button23.Text = "NOT LIKE N\'%%\'";
			this.button23.Click += new System.EventHandler(this.cmd_click);
			this.button23.MouseEnter += new System.EventHandler(this.button21_MouseEnter);
			// 
			// button24
			// 
			this.button24.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button24.Location = new System.Drawing.Point(316, 40);
			this.button24.Name = "button24";
			this.button24.Size = new System.Drawing.Size(68, 28);
			this.button24.TabIndex = 21;
			this.button24.Tag = "N";
			this.button24.Text = "MAX()";
			this.button24.Click += new System.EventHandler(this.cmd_click);
			this.button24.MouseEnter += new System.EventHandler(this.button21_MouseEnter);
			// 
			// button25
			// 
			this.button25.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button25.Location = new System.Drawing.Point(316, 8);
			this.button25.Name = "button25";
			this.button25.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.button25.Size = new System.Drawing.Size(68, 28);
			this.button25.TabIndex = 20;
			this.button25.Tag = "N";
			this.button25.Text = "ROUND(,)";
			this.button25.Click += new System.EventHandler(this.cmd_click);
			this.button25.MouseEnter += new System.EventHandler(this.button21_MouseEnter);
			// 
			// button16
			// 
			this.button16.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button16.Location = new System.Drawing.Point(240, 136);
			this.button16.Name = "button16";
			this.button16.Size = new System.Drawing.Size(68, 28);
			this.button16.TabIndex = 19;
			this.button16.Tag = "N";
			this.button16.Text = "MONTH()";
			this.button16.Click += new System.EventHandler(this.cmd_click);
			this.button16.MouseEnter += new System.EventHandler(this.button21_MouseEnter);
			// 
			// button17
			// 
			this.button17.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button17.Location = new System.Drawing.Point(240, 104);
			this.button17.Name = "button17";
			this.button17.Size = new System.Drawing.Size(68, 28);
			this.button17.TabIndex = 18;
			this.button17.Tag = "N";
			this.button17.Click += new System.EventHandler(this.cmd_click);
			this.button17.MouseEnter += new System.EventHandler(this.button21_MouseEnter);
			// 
			// button18
			// 
			this.button18.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button18.Location = new System.Drawing.Point(240, 72);
			this.button18.Name = "button18";
			this.button18.Size = new System.Drawing.Size(68, 28);
			this.button18.TabIndex = 17;
			this.button18.Tag = "N";
			this.button18.Text = "LIKE N\'%%\'";
			this.button18.Click += new System.EventHandler(this.cmd_click);
			this.button18.MouseEnter += new System.EventHandler(this.button21_MouseEnter);
			// 
			// button19
			// 
			this.button19.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button19.Location = new System.Drawing.Point(240, 40);
			this.button19.Name = "button19";
			this.button19.Size = new System.Drawing.Size(68, 28);
			this.button19.TabIndex = 16;
			this.button19.Tag = "N";
			this.button19.Text = "MIN()";
			this.button19.Click += new System.EventHandler(this.cmd_click);
			this.button19.MouseEnter += new System.EventHandler(this.button21_MouseEnter);
			// 
			// button20
			// 
			this.button20.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button20.Location = new System.Drawing.Point(240, 8);
			this.button20.Name = "button20";
			this.button20.Size = new System.Drawing.Size(68, 28);
			this.button20.TabIndex = 15;
			this.button20.Tag = "N";
			this.button20.Text = "FLOOR()";
			this.button20.Click += new System.EventHandler(this.cmd_click);
			this.button20.MouseEnter += new System.EventHandler(this.button21_MouseEnter);
			// 
			// button11
			// 
			this.button11.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button11.Location = new System.Drawing.Point(164, 136);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(68, 28);
			this.button11.TabIndex = 14;
			this.button11.Tag = "N";
			this.button11.Text = "DAY()";
			this.button11.Click += new System.EventHandler(this.cmd_click);
			this.button11.MouseEnter += new System.EventHandler(this.button21_MouseEnter);
			// 
			// button12
			// 
			this.button12.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button12.Location = new System.Drawing.Point(164, 104);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(68, 28);
			this.button12.TabIndex = 13;
			this.button12.Tag = "N";
			this.button12.Text = "OR";
			this.button12.Click += new System.EventHandler(this.cmd_click);
			this.button12.MouseEnter += new System.EventHandler(this.button21_MouseEnter);
			// 
			// button13
			// 
			this.button13.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button13.Location = new System.Drawing.Point(164, 72);
			this.button13.Name = "button13";
			this.button13.Size = new System.Drawing.Size(68, 28);
			this.button13.TabIndex = 12;
			this.button13.Tag = "N";
			this.button13.Text = "AND";
			this.button13.Click += new System.EventHandler(this.cmd_click);
			this.button13.MouseEnter += new System.EventHandler(this.button21_MouseEnter);
			// 
			// button14
			// 
			this.button14.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button14.Location = new System.Drawing.Point(164, 40);
			this.button14.Name = "button14";
			this.button14.Size = new System.Drawing.Size(68, 28);
			this.button14.TabIndex = 11;
			this.button14.Tag = "N";
			this.button14.Text = ")";
			this.button14.Click += new System.EventHandler(this.cmd_click);
			this.button14.MouseEnter += new System.EventHandler(this.button21_MouseEnter);
			// 
			// button15
			// 
			this.button15.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button15.Location = new System.Drawing.Point(164, 8);
			this.button15.Name = "button15";
			this.button15.Size = new System.Drawing.Size(68, 28);
			this.button15.TabIndex = 10;
			this.button15.Tag = "N";
			this.button15.Text = "(";
			this.button15.Click += new System.EventHandler(this.cmd_click);
			this.button15.MouseEnter += new System.EventHandler(this.button21_MouseEnter);
			// 
			// button6
			// 
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button6.Location = new System.Drawing.Point(88, 136);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(68, 28);
			this.button6.TabIndex = 9;
			this.button6.Tag = "N";
			this.button6.Text = "<>";
			this.button6.Click += new System.EventHandler(this.cmd_click);
			this.button6.MouseEnter += new System.EventHandler(this.button21_MouseEnter);
			// 
			// button7
			// 
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button7.Location = new System.Drawing.Point(88, 104);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(68, 28);
			this.button7.TabIndex = 8;
			this.button7.Tag = "N";
			this.button7.Text = "<=";
			this.button7.Click += new System.EventHandler(this.cmd_click);
			this.button7.MouseEnter += new System.EventHandler(this.button21_MouseEnter);
			// 
			// button8
			// 
			this.button8.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button8.Location = new System.Drawing.Point(88, 72);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(68, 28);
			this.button8.TabIndex = 7;
			this.button8.Tag = "N";
			this.button8.Text = "<";
			this.button8.Click += new System.EventHandler(this.cmd_click);
			this.button8.MouseEnter += new System.EventHandler(this.button21_MouseEnter);
			// 
			// button9
			// 
			this.button9.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button9.Location = new System.Drawing.Point(88, 40);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(68, 28);
			this.button9.TabIndex = 6;
			this.button9.Tag = "N";
			this.button9.Text = ">=";
			this.button9.Click += new System.EventHandler(this.cmd_click);
			this.button9.MouseEnter += new System.EventHandler(this.button21_MouseEnter);
			// 
			// button10
			// 
			this.button10.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button10.Location = new System.Drawing.Point(88, 8);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(68, 28);
			this.button10.TabIndex = 5;
			this.button10.Tag = "N";
			this.button10.Text = ">";
			this.button10.Click += new System.EventHandler(this.cmd_click);
			this.button10.MouseEnter += new System.EventHandler(this.button21_MouseEnter);
			// 
			// button5
			// 
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button5.Location = new System.Drawing.Point(12, 136);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(68, 28);
			this.button5.TabIndex = 4;
			this.button5.Tag = "N";
			this.button5.Text = "=";
			this.button5.Click += new System.EventHandler(this.cmd_click);
			this.button5.MouseEnter += new System.EventHandler(this.button21_MouseEnter);
			// 
			// button4
			// 
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button4.Location = new System.Drawing.Point(12, 104);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(68, 28);
			this.button4.TabIndex = 3;
			this.button4.Tag = "N";
			this.button4.Text = "/";
			this.button4.Click += new System.EventHandler(this.cmd_click);
			this.button4.MouseEnter += new System.EventHandler(this.button21_MouseEnter);
			// 
			// button3
			// 
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button3.Location = new System.Drawing.Point(12, 72);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(68, 28);
			this.button3.TabIndex = 2;
			this.button3.Tag = "N";
			this.button3.Text = "*";
			this.button3.Click += new System.EventHandler(this.cmd_click);
			this.button3.MouseEnter += new System.EventHandler(this.button21_MouseEnter);
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button2.Location = new System.Drawing.Point(12, 40);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(68, 28);
			this.button2.TabIndex = 1;
			this.button2.Tag = "N";
			this.button2.Text = "-";
			this.button2.Click += new System.EventHandler(this.cmd_click);
			this.button2.MouseEnter += new System.EventHandler(this.button21_MouseEnter);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(12, 8);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(68, 28);
			this.button1.TabIndex = 0;
			this.button1.Tag = "N";
			this.button1.Text = "+";
			this.button1.Click += new System.EventHandler(this.cmd_click);
			this.button1.MouseEnter += new System.EventHandler(this.button21_MouseEnter);
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(312, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(3, 172);
			this.splitter1.TabIndex = 1;
			this.splitter1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.vs);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(312, 172);
			this.panel2.TabIndex = 0;
			// 
			// splitter2
			// 
			this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
			this.splitter2.Location = new System.Drawing.Point(0, 204);
			this.splitter2.Name = "splitter2";
			this.splitter2.Size = new System.Drawing.Size(956, 3);
			this.splitter2.TabIndex = 13;
			this.splitter2.TabStop = false;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.panel9);
			this.panel5.Controls.Add(this.splitter4);
			this.panel5.Controls.Add(this.panel6);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(0, 207);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(956, 453);
			this.panel5.TabIndex = 14;
			// 
			// panel9
			// 
			this.panel9.Controls.Add(this.nav2);
			this.panel9.Controls.Add(this.vs2);
			this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel9.Location = new System.Drawing.Point(0, 219);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(956, 234);
			this.panel9.TabIndex = 2;
			// 
			// nav2
			// 
			this.nav2.BackColor = System.Drawing.SystemColors.Control;
			this.nav2.Connection = null;
			this.nav2.ConnectionDel = null;
			this.nav2.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.nav2.form = null;
			this.nav2.FormName = null;
			this.nav2.Grid = null;
			this.nav2.History = false;
			this.nav2.IsNull = true;
			this.nav2.Language = "EN";
			this.nav2.Location = new System.Drawing.Point(4, 4);
			this.nav2.MSG_Exit = false;
			this.nav2.MulltiDel = false;
			this.nav2.Name = "nav2";
			this.nav2.Security = 0;
			this.nav2.ShowPopupMenu = true;
			this.nav2.Size = new System.Drawing.Size(480, 32);
			this.nav2.TabIndex = 14;
			this.nav2.Tag = "";
			this.nav2.ToolBar_Auto = true;
			this.nav2.UserID = null;
			this.nav2.VisibleGrid = true;
			this.nav2.Where = null;
			this.nav2.Load += new System.EventHandler(this.nav2_Load);
			// 
			// vs2
			// 
			this.vs2.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.Both;
			this.vs2.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Both;
			this.vs2.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
			this.vs2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.vs2.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs2.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs2.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs2.Location = new System.Drawing.Point(4, 36);
			this.vs2.Name = "vs2";
			this.vs2.Size = new System.Drawing.Size(948, 196);
			this.vs2.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs2.TabIndex = 13;
			this.vs2.Click += new System.EventHandler(this.vs2_Click);
			// 
			// splitter4
			// 
			this.splitter4.Dock = System.Windows.Forms.DockStyle.Top;
			this.splitter4.Location = new System.Drawing.Point(0, 216);
			this.splitter4.Name = "splitter4";
			this.splitter4.Size = new System.Drawing.Size(956, 3);
			this.splitter4.TabIndex = 1;
			this.splitter4.TabStop = false;
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.panel8);
			this.panel6.Controls.Add(this.splitter3);
			this.panel6.Controls.Add(this.panel7);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel6.Location = new System.Drawing.Point(0, 0);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(956, 216);
			this.panel6.TabIndex = 0;
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.NavajoWhite;
			this.panel8.Controls.Add(this.txt_rem);
			this.panel8.Controls.Add(this.txt_con);
			this.panel8.Controls.Add(this.txt_item);
			this.panel8.Controls.Add(this.txt_value);
			this.panel8.Controls.Add(this.label2);
			this.panel8.Controls.Add(this.label1);
			this.panel8.Controls.Add(this.label4);
			this.panel8.Controls.Add(this.label3);
			this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel8.Location = new System.Drawing.Point(315, 0);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(641, 216);
			this.panel8.TabIndex = 2;
			// 
			// txt_rem
			// 
			this.txt_rem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.txt_rem.Location = new System.Drawing.Point(104, 160);
			this.txt_rem.MaxLength = 500;
			this.txt_rem.Multiline = true;
			this.txt_rem.Name = "txt_rem";
			this.txt_rem.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txt_rem.Size = new System.Drawing.Size(528, 52);
			this.txt_rem.TabIndex = 6;
			this.txt_rem.Text = "";
			// 
			// txt_con
			// 
			this.txt_con.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.txt_con.Location = new System.Drawing.Point(104, 76);
			this.txt_con.MaxLength = 1000;
			this.txt_con.Multiline = true;
			this.txt_con.Name = "txt_con";
			this.txt_con.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txt_con.Size = new System.Drawing.Size(528, 84);
			this.txt_con.TabIndex = 4;
			this.txt_con.Text = "";
			this.txt_con.Leave += new System.EventHandler(this.textBox3_Leave);
			// 
			// txt_item
			// 
			this.txt_item.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.txt_item.Location = new System.Drawing.Point(104, 4);
			this.txt_item.MaxLength = 8;
			this.txt_item.Name = "txt_item";
			this.txt_item.Size = new System.Drawing.Size(528, 23);
			this.txt_item.TabIndex = 2;
			this.txt_item.Tag = "N";
			this.txt_item.Text = "";
			this.txt_item.Leave += new System.EventHandler(this.textBox3_Leave);
			// 
			// txt_value
			// 
			this.txt_value.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.txt_value.Location = new System.Drawing.Point(104, 28);
			this.txt_value.MaxLength = 500;
			this.txt_value.Multiline = true;
			this.txt_value.Name = "txt_value";
			this.txt_value.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txt_value.Size = new System.Drawing.Size(528, 48);
			this.txt_value.TabIndex = 1;
			this.txt_value.Text = "";
			this.txt_value.Leave += new System.EventHandler(this.textBox3_Leave);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(4, 28);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "label2";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(4, 4);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "label1";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(4, 160);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(112, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "label4";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(4, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(112, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "label3";
			// 
			// splitter3
			// 
			this.splitter3.Location = new System.Drawing.Point(312, 0);
			this.splitter3.Name = "splitter3";
			this.splitter3.Size = new System.Drawing.Size(3, 216);
			this.splitter3.TabIndex = 1;
			this.splitter3.TabStop = false;
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.vs1);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(312, 216);
			this.panel7.TabIndex = 0;
			// 
			// vs1
			// 
			this.vs1.AllowEditing = false;
			this.vs1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs1.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vs1.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs1.Location = new System.Drawing.Point(0, 0);
			this.vs1.Name = "vs1";
			this.vs1.Size = new System.Drawing.Size(312, 216);
			this.vs1.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs1.TabIndex = 12;
			// 
			// frmTaAttendanceFormula
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(956, 660);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.splitter2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaAttendanceFormula";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmTaAttendanceFormula";
			this.Load += new System.EventHandler(this.frmTaAttendanceFormula_Load);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel9.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs2)).EndInit();
			this.panel6.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
		#region init
		private void frmTaAttendanceFormula_Load(object sender, System.EventArgs e)
		{
			Init_Form();
			string sql="Select TYP_ID from GP_SYS_SHIFT";
			rsshift=new Func.RecordSet(sql,PublicFunction.C_con);			
		}
		private void Init_Form()
		{		
			Init_vs();
			Init_vs1();
			Init_vs2();
			Basic.Function.PublicFunction.L_Init_Label(this);				
		}
		private void Init_vs()
		{				
			PublicFunction.InitNav(this,vs,nav);	
			nav.Show_VS();
			nav.ToolBar_Auto = false;
			nav.TBarClick += new ToolBarButtonClickEventHandler(nav_TBarClick);
			vs.DoubleClick+=new EventHandler(vs_DoubleClick);
			vs.BeforeEdit+=new C1.Win.C1FlexGrid.RowColEventHandler(vs_BeforeEdit);
		}
		private void Init_vs1()
		{				
			PublicFunction.InitNav(this,vs1,nav1);
			nav1.Show_VS();   
			vs1.DoubleClick+=new EventHandler(vs1_DoubleClick);
			string sql="Select * from GP_SYS_GET_ATTFOR";
			Func.RecordSet rs=new Func.RecordSet(sql,PublicFunction.C_con);
			for(int i=0;i<rs.rows;i++)
			{
				vs1.Rows.Count++;
				vs1.Rows[vs1.Rows.Count-1][0]=vs1.Rows.Count;
				vs1.Rows[vs1.Rows.Count-1]["TYP_ID"]=rs.record(i,"COL_NM");
				vs1.Rows[vs1.Rows.Count-1]["DAT_TP"]=rs.record(i,"DAT_TP");

				sql="Select * from SYS_LABEL_VS where [NAME]=N'"+rs.record(i,"LAB_DR")+"' and FNAME=N'"+rs.record(i,"COL_NM")+"'";
				Func.RecordSet rs1=new Func.RecordSet(sql,PublicFunction.C_con);
				if(rs1.rows>0)
				{
					vs1.Rows[vs1.Rows.Count-1]["TYP_EN"]=rs1.record(0,"EN");
					vs1.Rows[vs1.Rows.Count-1]["TYP_CH"]=rs1.record(0,"CH");
					vs1.Rows[vs1.Rows.Count-1]["TYP_VN"]=rs1.record(0,"VN");
					vs1.Rows[vs1.Rows.Count-1]["TYP_TT"]=rs1.record(0,"TT");
				}

			}
		}
		private void Init_vs2()
		{				
			PublicFunction.InitNav(this,vs2,nav2);
			nav2.Show_VS("1=1 ORDER BY SEQ_N1");         
			nav2.ToolBar_Auto=false;
			nav2.TBarClick+=new ToolBarButtonClickEventHandler(nav2_TBarClick);
			//vs2.AfterRowColChange+=new C1.Win.C1FlexGrid.RangeEventHandler(vs2_AfterRowColChange);
			vs2.DoubleClick+=new EventHandler(vs2_DoubleClick);		
		}
		#endregion
		#region event
		private void cmd_addcol_Click(object sender, System.EventArgs e)
		{
			frmTaAddCol dlg=new frmTaAddCol();
			if(dlg.ShowDialog()==DialogResult.OK)
			{
				nav.Show_VS();
			}
		}

		private void button21_MouseEnter(object sender, System.EventArgs e)
		{
			Button cmd=(Button)sender;
			switch(cmd.Text)
			{
				case "+":
				case "-":
				case "*":
				case "/":
				case "=":
				case ">":
				case ">=":
				case "<":
				case "<=":
				case "<>":
				case ".":										
				case "(":
				case ")":					
				case "":
				case "AND":										
				case "OR":
					txt.Text=cmd.Text;
					break;
				default:
					txt.Text=PublicFunction.L_Get_Msg("ATTF",cmd.Text);
					break;
			}
			
		}

		private void cmd_click(object sender, System.EventArgs e)
		{
			Button cmd=(Button)sender;
			if(txt1==null || txt1.Equals(txt_item))
				txt1=txt_value;			
			switch(cmd.Text)
			{
				case "1:30->1.5":
					txt1.Text+=	""+ " (FLOOR([Item]/100)+([Item]/100-FLOOR([Item]/100))/0.6)";
					break;
				case "1.5->1:30":
					txt1.Text+=	""+ " (FLOOR([Item])*100+([Item]-FLOOR([Item]))*60)";
					break;
				default:					
					txt1.Text+=	""+ cmd.Text;
					break;
			}
		}

		private void textBox3_Leave(object sender, System.EventArgs e)
		{
			txt1=(TextBox)sender;			
		}

		private void vs_DoubleClick(object sender, EventArgs e)
		{
			if(vs.Row>0)
			{
				if(txt1!=null )
					txt1.Text="["+vs.Rows[vs.Row]["COL_NM"]+"]";				
			}
		}
		private void vs1_DoubleClick(object sender, EventArgs e)
		{
			if(vs1.Row>0)
			{
				if(txt1!=null )				
					txt1.Text+="["+vs1.Rows[vs1.Row]["TYP_ID"]+"]";
			}
		}
		
		private void cmd_check_Click(object sender, System.EventArgs e)
		{
			string st=txt_value.Text+" ";
			CheckFor(st);
		}
		#endregion
		private void CheckFor(string st1)
		{
//			string st=st1+"";
//			string bien="",bthuc="";
//			double m=0;
//			double m1=0;
//			ArrayList m=new ArrayList();			
//			string toantu="";
//			
//			while(st+" "!=" ")
//			{
//				if(st[0]+""==" ")
//					st=st.Remove(0,1);
//				else
//				{
//					if(st[0]+""=="[") // Bien
//					{
//						bien=T_String.Left(st,"]");
//						bien=bien.Replace("[","");
//						bien=bien.Replace("]","");
//						st=st.Remove(0,bien.Length+1);
//						frmTaInputData dlg=new frmTaInputData();
//						dlg.lb.Text=bien;
//						dlg.txt.Text=bthuc;
//						if(dlg.ShowDialog()==DialogResult.OK)
//						{
//							if(toantu=="")
//								m=T_String.IsNullTo00(dlg.txt1.Text);
//							else
//								m+=T_String.IsNullTo00(dlg.txt1.Text);
//						}
//						else
//							return;
//					}
//					else //ham
//					{
//						if(st[0]+""=="(") // Bien
//						{
//						}
//						else
//						{
//							st=st.Remove(0,1);
//						}
//					}
//				}
//			}
//
//			frmTaInputData dlg1=new frmTaInputData();
//			dlg1.lb.Text=bien;
//			dlg1.txt.Text=bthuc+"="+m;
//			dlg1.ShowDialog();
			
		}

		private void nav_TBarClick(object sender, ToolBarButtonClickEventArgs e)
		{
			if (e.Button.Equals(nav.cmd_delete))
			{
				SqlConnection con = new SqlConnection(PublicFunction.C_con.ConnectionString);
				con.Open();
				SqlTransaction tran = con.BeginTransaction();
				string sql = "";
				sql="SELECT df.name as cname , t.name , c.NAME FROM sys.default_constraints df"
					+" INNER JOIN sys.tables t ON df.parent_object_id = t.object_id"
					+" INNER JOIN sys.columns c ON df.parent_object_id = c.object_id AND df.parent_column_id = c.column_id"
					+" where t.name='FILC06A' and c.name='"+ vs.Rows[vs.Row]["COL_NM"] + "' ";
				Func.RecordSet rsc=new Func.RecordSet(sql,PublicFunction.C_con);
				sql="SELECT df.name as cname , t.name , c.NAME FROM sys.default_constraints df"
					+" INNER JOIN sys.tables t ON df.parent_object_id = t.object_id"
					+" INNER JOIN sys.columns c ON df.parent_object_id = c.object_id AND df.parent_column_id = c.column_id"
					+" where t.name='FILC06B' and c.name='"+ vs.Rows[vs.Row]["COL_NM"] + "' ";
				Func.RecordSet rsc1=new Func.RecordSet(sql,PublicFunction.C_con );
				try
				{
					
					if (rsc.rows>0)
					{
						sql="alter table FILC06A drop constraint ["+rsc.record(0,"cname")+"]";
						SqlCommand cmd1 = new SqlCommand(sql, con, tran);
						cmd1.ExecuteNonQuery();
					}
					sql = "Alter table FILC06A DROP COLUMN [" + vs.Rows[vs.Row]["COL_NM"] + "] ";
					SqlCommand cmd = new SqlCommand(sql, con, tran);
					cmd.ExecuteNonQuery();
					
					if (rsc1.rows>0)
					{
						sql="alter table FILC06B drop constraint ["+rsc1.record(0,"cname")+"]";
						cmd = new SqlCommand(sql, con, tran);
						cmd.ExecuteNonQuery();
					}
					sql = "Alter table FILC06B DROP COLUMN [" + vs.Rows[vs.Row]["COL_NM"] + "] ";                    
					cmd = new SqlCommand(sql, con, tran);
					cmd.ExecuteNonQuery();

					if (vs.Rows[vs.Row]["MON_BT"]+""=="True")
					{
						sql = "Alter table FILC06AA DROP COLUMN [" + vs.Rows[vs.Row]["COL_NM"] + "] ";   
						cmd = new SqlCommand(sql, con, tran);
						cmd.ExecuteNonQuery();
					}
					sql = "DELETE SYS_LABEL_VS_ATT WHERE [NAME]=N'frmTaDailyAttendanceList000_vs' AND [FNAME]='" + vs.Rows[vs.Row]["COL_NM"]+"'";
					cmd = new SqlCommand(sql, con, tran);
					cmd.ExecuteNonQuery();
					sql = "DELETE GP_SYS_SQL_SELECT WHERE [ID]=N'frmTaDailyAttendanceList000_vs' AND [FIELD]='" + vs.Rows[vs.Row]["COL_NM"] + "'";
					cmd = new SqlCommand(sql, con, tran);
					cmd.ExecuteNonQuery();

					if (vs.Rows[vs.Row]["MON_BT"] + "" == "True")
					{
						sql = "DELETE SYS_LABEL_VS_ATT WHERE [NAME]=N'frmTaMonthAddUp000_vs' AND [FNAME]='" + vs.Rows[vs.Row]["COL_NM"] + "'";
						cmd = new SqlCommand(sql, con, tran);
						cmd.ExecuteNonQuery();
						sql = "DELETE GP_SYS_SQL_SELECT WHERE [ID]=N'frmTaMonthAddUp000_vs' AND [FIELD]='" + vs.Rows[vs.Row]["COL_NM"] + "'";
						cmd = new SqlCommand(sql, con, tran);
						cmd.ExecuteNonQuery();
					}

					tran.Commit();
				}
				catch (SqlException ex)
				{
					tran.Rollback();
					MessageBox.Show(ex.Message);
					return;
				}
				con.Close();
				nav.ToolBar_Click(e);
				return;
			}
            
			nav.ToolBar_Click(e);
		}
		private void nav2_TBarClick(object sender, ToolBarButtonClickEventArgs e)
		{								
			if (e.Button.Equals(nav2.cmd_add))
			{	
				string con=txt_con.Text	;	
				string item=txt_item.Text	;	
				string va=txt_value.Text	;	
				string rem=txt_rem.Text	;	
				int rr=vs2.Row+1;
				nav2.ToolBar_Click(e);	
				vs2.Row	=vs2.Rows.Count-1;			
				vs2.Rows[vs2.Rows.Count-1]["SEQ_NO"]=T_String.GetMax("MAX(SEQ_NO)","FILC08A")+"";
				vs2.Rows[vs2.Rows.Count-1]["SEQ_N1"]=vs2.Rows.Count-1;
				vs2.Rows[vs2.Row]["RUN_BT"]=1;
				vs2.Rows[vs2.Row]["CON_DR"]=con;
				vs2.Rows[vs2.Row]["ITE_NM"]=item;
				vs2.Rows[vs2.Row]["VAL_DR"]=va;
				vs2.Rows[vs2.Row]["REM_DR"]=rem;
				vs2.Rows[vs2.Row]["SQL_DR"]=GetSQL(item,va,con);;
				nav2.SaveRow(vs2.Row);
				txt_con.Text=vs2.Rows[vs2.Row]["CON_DR"]+"";
				txt_item.Text=vs2.Rows[vs2.Row]["ITE_NM"]+"";
				txt_value.Text=vs2.Rows[vs2.Row]["VAL_DR"]+"";
				txt_rem.Text=vs2.Rows[vs2.Row]["REM_DR"]+"";
				vs2.Rows[vs2.Row].Move(rr);
				for (int i=1;i<vs2.Rows.Count;i++)
				{
					vs2.Rows[i]["SEQ_N1"]=i.ToString("000");
					if (vs2.Rows[i].UserData+""!="2")					
						vs2.Rows[i].UserData=1;		
					nav2.SaveRow(i);
				}	
				row=0;
				txt_con.Text="";
				txt_item.Text="";
				txt_value.Text="";
				txt_rem.Text="";
				return;
			}
			if (e.Button.Equals(nav2.cmd_save))
			{				
				for (int i=1;i<vs2.Rows.Count;i++)
				{
					vs2.Rows[i]["SEQ_N1"]=i.ToString("000");
					if (vs2.Rows[i].UserData+""!="2")					
						vs2.Rows[i].UserData=1;					
				}	
				if(row>0)
				{
				
					vs2.Rows[row]["CON_DR"]=txt_con.Text;
					vs2.Rows[row]["ITE_NM"]=txt_item.Text;
					vs2.Rows[row]["VAL_DR"]=txt_value.Text;
					vs2.Rows[row]["REM_DR"]=txt_rem.Text;									
					vs2.Rows[row]["SQL_DR"]=GetSQL(txt_item.Text,txt_value.Text,txt_con.Text);
					vs2.Rows[row].UserData=1;		
				}
				row=-1;
				txt_con.Text="";
				txt_item.Text="";
				txt_value.Text="";
				txt_rem.Text="";
			}
			if (e.Button.Equals(nav2.cmd_refresh))
			{
				row=-1;
				txt_con.Text="";
				txt_item.Text="";
				txt_value.Text="";
				txt_rem.Text="";
			}
			nav2.ToolBar_Click(e);		
		}
		private string GetSQL(string item,string vl,string con)
		{
//			for(int i=0;i<rsshift.rows;i++)
//			{	
			int item_type=0;
			for(int i=1;i<vs.Rows.Count;i++)
			{				
				try
				{
					string Item=vs.Rows[i]["COL_NM"]+"";//rsshift.record(i,0);		
					if(item=="["+Item+"]")
						item_type=1;								
					vl=vl.Replace("["+Item+"]","(FLOOR(["+Item+"]/100)+Round((["+Item+"]/100.0-FLOOR(["+Item+"]/100))/0.6,3))");					
					con=con.Replace("["+Item+"]","(FLOOR(["+Item+"]/100)+Round((["+Item+"]/100.0-FLOOR(["+Item+"]/100))/0.6,3))");											
				}
				catch{}
			}
			for(int i=1;i<vs1.Rows.Count;i++)
			{
				try
				{
					string Item=vs1.Rows[i]["TYP_ID"]+"";//rsshift.record(i,0);	
					if(item=="["+Item+"]")
						item_type=T_String.IsNullTo0(vs1.Rows[i]["DAT_TP"]+"");
					if(vs1.Rows[i]["DAT_TP"]+""=="1")
					{						
						vl=vl.Replace("["+Item+"]","(FLOOR(["+Item+"]/100)+Round((["+Item+"]/100.0-FLOOR(["+Item+"]/100))/0.6,3))");					
						con=con.Replace("["+Item+"]","(FLOOR(["+Item+"]/100)+Round((["+Item+"]/100.0-FLOOR(["+Item+"]/100))/0.6,3))");											
					}
				}
				catch{}
			}
			if(item_type==1)
				vl= "FLOOR("+vl+") * 100 + ("+vl+" - FLOOR("+vl+")) * 60";
			string sql="Update FILC06A SET"+item+"="+vl+" from"
				+" FILB01A b, FILC06A a where ( a.EMP_ID=b.EMP_ID)";
			if(con+""!="")
				sql+= " and " + con;
			return sql;
		}
		private void vs2_AfterRowColChange(object sender, C1.Win.C1FlexGrid.RangeEventArgs e)
		{			
			Show_Text();	
		}
		private void Show_Text()
		{
			if(vs2.Row>0)
			{
				if (vs2.Rows[vs2.Row].UserData+""!="2")	
				{
					txt_con.Text=vs2.Rows[vs2.Row]["CON_DR"]+"";
					txt_item.Text=vs2.Rows[vs2.Row]["ITE_NM"]+"";
					txt_value.Text=vs2.Rows[vs2.Row]["VAL_DR"]+"";
					txt_rem.Text=vs2.Rows[vs2.Row]["REM_DR"]+"";
				}
			}
			else
			{
				if (vs2.Rows[vs2.Row].UserData+""!="2")	
				{
					txt_con.Text=txt_item.Text=txt_value.Text=txt_rem.Text="";
				}
			}		
		}

		int row=-1;
		private void vs2_DoubleClick(object sender, EventArgs e)
		{
			row=vs2.Row;
			Show_Text();	
		}

		private void vs_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			if(vs.Cols[e.Col].Name!="FOR_DR" && vs.Cols[e.Col].Name!="GIO_BT")
				e.Cancel=true;
		}

		private void nav2_Load(object sender, System.EventArgs e)
		{
		
		}

		private void vs2_Click(object sender, System.EventArgs e)
		{
		
		}
	}
}

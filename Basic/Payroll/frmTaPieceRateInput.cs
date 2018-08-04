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


namespace GP8000.Payroll
{
	/// <summary>
	/// Summary description for frmTaPieceRateInput.
	/// </summary>
	public class frmTaPieceRateInput : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel7;
		private Navigator1._0.NavigatorAuto nav;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Splitter splitter2;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel6;
		private C1.Win.C1FlexGrid.C1FlexGrid vs;
		private System.Windows.Forms.DateTimePicker dt;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton r2;
		private System.Windows.Forms.RadioButton r1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label DWID;
		private System.Windows.Forms.Label WID;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_WID;
		private System.Windows.Forms.TextBox txt_Name;
		private System.Windows.Forms.TextBox txt_Dep;
		private System.Windows.Forms.TextBox txt_INH;
		private System.Windows.Forms.Button button1;
		private C1.Win.C1Input.C1TextBox txt_item;
		private C1.Win.C1FlexGrid.C1FlexGrid vs2;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.Button cmd_clear;
		private System.Windows.Forms.Label lb;
		private System.Windows.Forms.Label lb1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaPieceRateInput()
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
			this.panel7 = new System.Windows.Forms.Panel();
			this.nav = new Navigator1._0.NavigatorAuto();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel9 = new System.Windows.Forms.Panel();
			this.vs2 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.panel8 = new System.Windows.Forms.Panel();
			this.cmd_clear = new System.Windows.Forms.Button();
			this.splitter2 = new System.Windows.Forms.Splitter();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.vs = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.panel5 = new System.Windows.Forms.Panel();
			this.lb1 = new System.Windows.Forms.Label();
			this.lb = new System.Windows.Forms.Label();
			this.txt_item = new C1.Win.C1Input.C1TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_INH = new System.Windows.Forms.TextBox();
			this.txt_Dep = new System.Windows.Forms.TextBox();
			this.txt_Name = new System.Windows.Forms.TextBox();
			this.txt_WID = new System.Windows.Forms.TextBox();
			this.WID = new System.Windows.Forms.Label();
			this.DWID = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.dt = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.r2 = new System.Windows.Forms.RadioButton();
			this.r1 = new System.Windows.Forms.RadioButton();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.panel3.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel9.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs2)).BeginInit();
			this.panel8.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txt_item)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.panel7);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(824, 36);
			this.panel3.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Location = new System.Drawing.Point(348, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(476, 36);
			this.label5.TabIndex = 12;
			this.label5.Tag = "";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.nav);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(348, 36);
			this.panel7.TabIndex = 0;
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
			this.nav.Location = new System.Drawing.Point(0, 2);
			this.nav.MSG_Exit = false;
			this.nav.MulltiDel = false;
			this.nav.Name = "nav";
			this.nav.Security = 0;
			this.nav.ShowPopupMenu = true;
			this.nav.Size = new System.Drawing.Size(400, 32);
			this.nav.TabIndex = 14;
			this.nav.Tag = "";
			this.nav.ToolBar_Auto = true;
			this.nav.UserID = null;
			this.nav.VisibleGrid = true;
			this.nav.Where = null;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Controls.Add(this.splitter2);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.splitter1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 36);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(824, 516);
			this.panel1.TabIndex = 9;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.panel9);
			this.panel4.Controls.Add(this.panel8);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(279, 3);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(545, 513);
			this.panel4.TabIndex = 4;
			// 
			// panel9
			// 
			this.panel9.Controls.Add(this.vs2);
			this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel9.Location = new System.Drawing.Point(0, 28);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(545, 485);
			this.panel9.TabIndex = 17;
			// 
			// vs2
			// 
			this.vs2.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.Both;
			this.vs2.AllowEditing = false;
			this.vs2.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs2.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vs2.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs2.Location = new System.Drawing.Point(0, 0);
			this.vs2.Name = "vs2";
			this.vs2.Size = new System.Drawing.Size(545, 485);
			this.vs2.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs2.TabIndex = 15;
			// 
			// panel8
			// 
			this.panel8.Controls.Add(this.cmd_clear);
			this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel8.Location = new System.Drawing.Point(0, 0);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(545, 28);
			this.panel8.TabIndex = 16;
			// 
			// cmd_clear
			// 
			this.cmd_clear.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_clear.Location = new System.Drawing.Point(4, 4);
			this.cmd_clear.Name = "cmd_clear";
			this.cmd_clear.TabIndex = 0;
			this.cmd_clear.Text = "button2";
			this.cmd_clear.Click += new System.EventHandler(this.cmd_clear_Click);
			// 
			// splitter2
			// 
			this.splitter2.Location = new System.Drawing.Point(276, 3);
			this.splitter2.Name = "splitter2";
			this.splitter2.Size = new System.Drawing.Size(3, 513);
			this.splitter2.TabIndex = 3;
			this.splitter2.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Moccasin;
			this.panel2.Controls.Add(this.panel6);
			this.panel2.Controls.Add(this.panel5);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel2.Location = new System.Drawing.Point(0, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(276, 513);
			this.panel2.TabIndex = 2;
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.vs);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel6.Location = new System.Drawing.Point(0, 340);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(276, 173);
			this.panel6.TabIndex = 1;
			// 
			// vs
			// 
			this.vs.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.Both;
			this.vs.AllowEditing = false;
			this.vs.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vs.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs.Location = new System.Drawing.Point(0, 0);
			this.vs.Name = "vs";
			this.vs.Size = new System.Drawing.Size(276, 173);
			this.vs.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs.TabIndex = 14;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.lb1);
			this.panel5.Controls.Add(this.lb);
			this.panel5.Controls.Add(this.txt_item);
			this.panel5.Controls.Add(this.button1);
			this.panel5.Controls.Add(this.label2);
			this.panel5.Controls.Add(this.txt_INH);
			this.panel5.Controls.Add(this.txt_Dep);
			this.panel5.Controls.Add(this.txt_Name);
			this.panel5.Controls.Add(this.txt_WID);
			this.panel5.Controls.Add(this.WID);
			this.panel5.Controls.Add(this.DWID);
			this.panel5.Controls.Add(this.checkBox1);
			this.panel5.Controls.Add(this.dt);
			this.panel5.Controls.Add(this.label1);
			this.panel5.Controls.Add(this.groupBox1);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel5.Location = new System.Drawing.Point(0, 0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(276, 340);
			this.panel5.TabIndex = 0;
			// 
			// lb1
			// 
			this.lb1.BackColor = System.Drawing.Color.Black;
			this.lb1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lb1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lb1.ForeColor = System.Drawing.Color.White;
			this.lb1.Location = new System.Drawing.Point(0, 200);
			this.lb1.Name = "lb1";
			this.lb1.Size = new System.Drawing.Size(276, 116);
			this.lb1.TabIndex = 185;
			this.lb1.Tag = "N";
			this.lb1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lb
			// 
			this.lb.BackColor = System.Drawing.Color.LemonChiffon;
			this.lb.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lb.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lb.ForeColor = System.Drawing.Color.Red;
			this.lb.Location = new System.Drawing.Point(0, 316);
			this.lb.Name = "lb";
			this.lb.Size = new System.Drawing.Size(276, 24);
			this.lb.TabIndex = 184;
			this.lb.Tag = "";
			this.lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txt_item
			// 
			this.txt_item.CustomFormat = "#########";
			this.txt_item.DataType = typeof(int);
			this.txt_item.EmptyAsNull = true;
			this.txt_item.Location = new System.Drawing.Point(96, 172);
			this.txt_item.MaxLength = 100;
			this.txt_item.Name = "txt_item";
			this.txt_item.Size = new System.Drawing.Size(176, 23);
			this.txt_item.TabIndex = 183;
			this.txt_item.Tag = null;
			this.txt_item.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Item_KeyDown);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(236, 68);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(32, 23);
			this.button1.TabIndex = 182;
			this.button1.Tag = "N";
			this.button1.Text = "...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(4, 176);
			this.label2.Name = "label2";
			this.label2.TabIndex = 179;
			this.label2.Text = "label3";
			// 
			// txt_INH
			// 
			this.txt_INH.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.txt_INH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_INH.Location = new System.Drawing.Point(4, 144);
			this.txt_INH.Name = "txt_INH";
			this.txt_INH.ReadOnly = true;
			this.txt_INH.Size = new System.Drawing.Size(268, 23);
			this.txt_INH.TabIndex = 178;
			this.txt_INH.Text = "";
			this.txt_INH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txt_Dep
			// 
			this.txt_Dep.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.txt_Dep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Dep.Location = new System.Drawing.Point(4, 120);
			this.txt_Dep.Name = "txt_Dep";
			this.txt_Dep.ReadOnly = true;
			this.txt_Dep.Size = new System.Drawing.Size(268, 23);
			this.txt_Dep.TabIndex = 177;
			this.txt_Dep.Text = "";
			this.txt_Dep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txt_Name
			// 
			this.txt_Name.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Name.Location = new System.Drawing.Point(4, 96);
			this.txt_Name.Name = "txt_Name";
			this.txt_Name.ReadOnly = true;
			this.txt_Name.Size = new System.Drawing.Size(268, 23);
			this.txt_Name.TabIndex = 176;
			this.txt_Name.Text = "";
			this.txt_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txt_WID
			// 
			this.txt_WID.Location = new System.Drawing.Point(96, 68);
			this.txt_WID.Name = "txt_WID";
			this.txt_WID.Size = new System.Drawing.Size(140, 23);
			this.txt_WID.TabIndex = 175;
			this.txt_WID.Text = "";
			this.txt_WID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
			this.txt_WID.TextChanged += new System.EventHandler(this.txt_WID_TextChanged);
			this.txt_WID.Leave += new System.EventHandler(this.txt_WID_Leave);
			// 
			// WID
			// 
			this.WID.Location = new System.Drawing.Point(4, 72);
			this.WID.Name = "WID";
			this.WID.TabIndex = 174;
			this.WID.Text = "label3";
			// 
			// DWID
			// 
			this.DWID.Location = new System.Drawing.Point(4, 72);
			this.DWID.Name = "DWID";
			this.DWID.TabIndex = 173;
			this.DWID.Text = "label2";
			this.DWID.Visible = false;
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(168, 4);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.TabIndex = 172;
			this.checkBox1.Text = "checkBox1";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// dt
			// 
			this.dt.CustomFormat = "yyyyMM";
			this.dt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dt.Location = new System.Drawing.Point(88, 4);
			this.dt.Name = "dt";
			this.dt.Size = new System.Drawing.Size(72, 23);
			this.dt.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(4, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 18);
			this.label1.TabIndex = 9;
			this.label1.Text = "label1";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.r2);
			this.groupBox1.Controls.Add(this.r1);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(4, 24);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(272, 40);
			this.groupBox1.TabIndex = 171;
			this.groupBox1.TabStop = false;
			this.groupBox1.Tag = "N";
			// 
			// r2
			// 
			this.r2.Checked = true;
			this.r2.Location = new System.Drawing.Point(148, 16);
			this.r2.Name = "r2";
			this.r2.Size = new System.Drawing.Size(120, 20);
			this.r2.TabIndex = 1;
			this.r2.TabStop = true;
			this.r2.Text = "radioButton2";
			// 
			// r1
			// 
			this.r1.Location = new System.Drawing.Point(12, 16);
			this.r1.Name = "r1";
			this.r1.Size = new System.Drawing.Size(120, 20);
			this.r1.TabIndex = 0;
			this.r1.Text = "radioButton1";
			// 
			// splitter1
			// 
			this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
			this.splitter1.Location = new System.Drawing.Point(0, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(824, 3);
			this.splitter1.TabIndex = 1;
			this.splitter1.TabStop = false;
			// 
			// frmTaPieceRateInput
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(824, 552);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaPieceRateInput";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmTaPieceRateInput";
			this.Load += new System.EventHandler(this.frmTaPieceRateInput_Load);
			this.panel3.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel9.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs2)).EndInit();
			this.panel8.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			this.panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txt_item)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaPieceRateInput_Load(object sender, System.EventArgs e)
		{
			Init_Form();	
		}
		#region Init
		String format;
		private void Init_Form()
		{		
			Init_vs();	
			init_vs2();
			dt.Value=T_String.GetDate();
			Basic.Function.PublicFunction.L_Init_Label(this);				
			format=PublicFunction.GetOption("DATE");
		}

		private void Init_vs()
		{		
			nav.cmd_copy.Visible=false;
			nav.cmd_report.Visible=false;
			nav.cmd_search.Visible=false;
			nav.cmd_delete.Visible=false;
			nav.cmd_add.Visible=false;		
			nav.cmd_save.Visible=false;		
			PublicFunction.InitNav(this,vs,nav);	
			nav.Show_VS("BAS_BT=1 order by SEQ_NO");		
			vs.DoubleClick+=new EventHandler(vs_DoubleClick);
		}
		private void init_vs2()
		{
			vs2.Cols.Count=7;
			vs2.Cols[1].Name="YYY_MM";			
			vs2.Cols[2].Name="EMP_ID";
			vs2.Cols[3].Name="EMP_I1";
			vs2.Cols[4].Name="EMP_NM";
			vs2.Cols[5].Name="COL_NM";
			vs2.Cols[6].Name="COL_VL";
			vs2.Rows.Count=1;
		}
		#endregion
		Boolean ok;
		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{			
			WID.Visible=!checkBox1.Checked;
			DWID.Visible=checkBox1.Checked;
		}

		private void textBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Enter)
			{
				show_EMP();
			}
		}
		string EMP_ID="";
		string EMP_I1="";
		private void show_EMP()
		{
			string sql="Select EMP_ID,EMP_I1,EMP_NM,DEP_ID,INH_DT From FILB01A Where  "
				+" (DEL_BT is null or DEL_BT=0) and DEP_ID in (Select DEP_ID  from SYS_SECURITY_DEP"+
				" where MNU_ID="+this.Tag+" and ALL_BT=1 and USER_ID=N'"+PublicFunction.A_UserID+"')";
			if(checkBox1.Checked)
				sql+=" and EMP_I1=N'"+txt_WID.Text+"'";
			else
				sql+=" and EMP_ID=N'"+txt_WID.Text+"'";
			Func.RecordSet rs=new Func.RecordSet(sql,PublicFunction.C_con);
			if(rs.rows<=0)
			{
				MessageBox.Show(PublicFunction.L_Get_Msg("msg",212));
				ok=false;
				txt_Name.Text="";
				txt_Dep.Text="";			
				txt_INH.Text="";
				txt_WID.Focus();
				return;
			}
			txt_Name.Text=rs.record(0,"EMP_NM");
			EMP_ID=rs.record(0,"EMP_ID");
			EMP_I1=rs.record(0,"EMP_I1");
			txt_Dep.Text=T_String.GetDataFromSQL("DEP_NM","FILA02A","DEP_ID=N'"+ rs.record(0,"DEP_ID")+"'");
			try
			{
				txt_INH.Text=DateTime.Parse(rs.record(0,"INH_DT")+"").ToString(format);
			}
			catch{}
			txt_item.Focus();
			ok=true;
		}

		private void txt_Item_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Enter)
			{
				if(Row<=0)
				{
					MessageBox.Show(PublicFunction.L_Get_Msg("msg",214));
					txt_item.Focus();
					return;
				}
				if(!ok)
				{
					MessageBox.Show(PublicFunction.L_Get_Msg("msg",213));
					txt_WID.Focus();
					return;
				}
				Double vl=T_String.IsNullTo00(txt_item.Text+"");
				string sql="Update FILD02A SET ["+vs.Rows[Row]["COL_NM"]+"]="+vl+
					" where YYY_MM=N'"+dt.Text+"' and EMP_ID=N'"+EMP_ID+"'";
				if(r1.Checked)
					sql+=" and SEQ_NO=1";
				else
					sql+=" and SEQ_NO=2";
				string st="";
				if(checkBox1.Checked)
					st=DWID.Text+": "+txt_WID.Text+" \n ";
				else
					st=WID.Text+": "+txt_WID.Text+" \n ";
				st+=txt_Name.Text +"\n" + lb.Text+": "+txt_item.Text+"\n " ;
				if(PublicFunction.SQL_Execute(sql,true)==0)
				{
					lb1.Text=st+PublicFunction.L_Get_Msg("Staff",1);					
				}
				else
				{
					lb1.Text=st+PublicFunction.L_Get_Msg("Staff",2);
					return;
				}
				Double max=T_String.GetMax0("MAX(ID)","GP_HISTORYINPUTPIECERATE");
				sql="Insert Into GP_HISTORYINPUTPIECERATE values("+max+",N'"+dt.Text+"',N'"
					+ vs.Rows[Row]["COL_NM"]+"',"+vl+",N'"+PublicFunction.A_UserID+"','"
					+T_String.GetDate().ToString("yyyy/MM/dd HH:mm")+"')";
				PublicFunction.SQL_Execute(sql);
				vs2.Rows.Count++;
				vs2.Rows[vs2.Rows.Count-1][0]=vs2.Rows.Count-1;
				vs2.Rows[vs2.Rows.Count-1]["YYY_MM"]=dt.Text;
				vs2.Rows[vs2.Rows.Count-1]["EMP_ID"]=EMP_ID;
				vs2.Rows[vs2.Rows.Count-1]["EMP_I1"]=EMP_I1;
				vs2.Rows[vs2.Rows.Count-1]["EMP_NM"]=txt_Name.Text;
				vs2.Rows[vs2.Rows.Count-1]["COL_NM"]=lb.Text ;
				vs2.Rows[vs2.Rows.Count-1]["COL_VL"]=vl;
				vs2.AutoSizeCols();
				
				txt_Name.Text="";
				txt_Dep.Text="";			
				txt_INH.Text="";
				txt_WID.Text="";
				txt_item.Text="";
				txt_WID.Focus();
			}
		}
		#region Button Search
		private void button1_Click(object sender, System.EventArgs e)
		{
			string sql="Select EMP_ID,EMP_I1,EMP_NM,DEP_ID,INH_DT From FILB01A Where  "
				+" DEL_BT is null or DEL_BT=0 and DEP_ID in (Select DEP_ID  from SYS_SECURITY_DEP"+
				" where MNU_ID="+this.Tag+" and ALL_BT=1 and USER_ID=N'"+PublicFunction.A_UserID+"')";
			Func.RecordSet rs=new Func.RecordSet(sql,PublicFunction.C_con);
			frmSearch dlg=new frmSearch(rs,5,"frmTaStaffInfo_vs");
			if(dlg.ShowDialog()==DialogResult.OK)
			{
				if(checkBox1.Checked)
					txt_WID.Text=rs.record(rs.Bookmarks,"EMP_I1");					
				else
					txt_WID.Text=rs.record(rs.Bookmarks,"EMP_ID");
				EMP_ID=rs.record(rs.Bookmarks,"EMP_ID");
				EMP_I1=rs.record(rs.Bookmarks,"EMP_I1");
				txt_Name.Text=rs.record(rs.Bookmarks,"EMP_NM");
				txt_Dep.Text=T_String.GetDataFromSQL("DEP_NM","FILA02A","DEP_ID=N'"+ rs.record(rs.Bookmarks,"DEP_ID")+"'");
				try
				{
					txt_INH.Text=DateTime.Parse(rs.record(rs.Bookmarks,"INH_DT")+"").ToString(format);
				}
				catch{}
				txt_item.Focus();
				ok=true;
			}
		}	
		int Row=0;
		private void vs_DoubleClick(object sender, EventArgs e)
		{
			Row=vs.Row;
			lb.Text=vs.Rows[vs.Row]["COL_"+PublicFunction.L_Lag]+"";
		}
		#endregion

		private void txt_WID_Leave(object sender, System.EventArgs e)
		{
			//show_EMP();
		}

		private void cmd_clear_Click(object sender, System.EventArgs e)
		{
			vs2.Rows.Count=1;
		}

		private void txt_WID_TextChanged(object sender, System.EventArgs e)
		{
			txt_Name.Text="";
			txt_Dep.Text="";			
			txt_INH.Text="";
			ok=false;
		}

		
	}
}

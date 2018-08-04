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
	/// Summary description for frmTaVacateManager.
	/// </summary>
	public class frmTaShiftReset : System.Windows.Forms.Form
	{
		private C1.Win.C1Command.C1CommandDock c1CommandDock1;
		private C1.Win.C1Command.C1DockingTab c1DockingTab1;
		private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage1;
		private GP8000.UserControl.CrtTaDepartment Dep;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.TextBox txt5;
		private System.Windows.Forms.TextBox txt7;
		private System.Windows.Forms.TextBox txt6;
		private System.Windows.Forms.Panel panel11;
		private System.Windows.Forms.Panel panel12;
		private C1.Win.C1Input.C1DateEdit dt3;
		private C1.Win.C1FlexGrid.C1FlexGrid vs;
		private Navigator1._0.NavigatorAuto nav;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Label label2;
		private C1.Win.C1Input.C1DateEdit dt4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button cmd_ok;
		private C1.Win.C1Input.C1DateEdit dt1;
		private frmTaCopyShift dlg;
		private System.Windows.Forms.Button cmd_copy;
		private System.Windows.Forms.Button cmd_change;
		private System.Windows.Forms.Button cmd_q;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaShiftReset()
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
			this.c1CommandDock1 = new C1.Win.C1Command.C1CommandDock();
			this.c1DockingTab1 = new C1.Win.C1Command.C1DockingTab();
			this.c1DockingTabPage1 = new C1.Win.C1Command.C1DockingTabPage();
			this.Dep = new GP8000.UserControl.CrtTaDepartment();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel8 = new System.Windows.Forms.Panel();
			this.panel12 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.cmd_change = new System.Windows.Forms.Button();
			this.cmd_copy = new System.Windows.Forms.Button();
			this.nav = new Navigator1._0.NavigatorAuto();
			this.vs = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.panel5 = new System.Windows.Forms.Panel();
			this.cmd_ok = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.dt4 = new C1.Win.C1Input.C1DateEdit();
			this.label2 = new System.Windows.Forms.Label();
			this.dt1 = new C1.Win.C1Input.C1DateEdit();
			this.panel11 = new System.Windows.Forms.Panel();
			this.txt6 = new System.Windows.Forms.TextBox();
			this.txt7 = new System.Windows.Forms.TextBox();
			this.txt5 = new System.Windows.Forms.TextBox();
			this.dt3 = new C1.Win.C1Input.C1DateEdit();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.cmd_q = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandDock1)).BeginInit();
			this.c1CommandDock1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).BeginInit();
			this.c1DockingTab1.SuspendLayout();
			this.c1DockingTabPage1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel8.SuspendLayout();
			this.panel12.SuspendLayout();
			this.panel7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dt4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dt1)).BeginInit();
			this.panel11.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dt3)).BeginInit();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// c1CommandDock1
			// 
			this.c1CommandDock1.Controls.Add(this.c1DockingTab1);
			this.c1CommandDock1.Dock = System.Windows.Forms.DockStyle.Left;
			this.c1CommandDock1.Id = 1;
			this.c1CommandDock1.Location = new System.Drawing.Point(0, 0);
			this.c1CommandDock1.Name = "c1CommandDock1";
			this.c1CommandDock1.Size = new System.Drawing.Size(276, 320);
			// 
			// c1DockingTab1
			// 
			this.c1DockingTab1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
			this.c1DockingTab1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.c1DockingTab1.CanAutoHide = true;
			this.c1DockingTab1.CanMoveTabs = true;
			this.c1DockingTab1.Controls.Add(this.c1DockingTabPage1);
			this.c1DockingTab1.Location = new System.Drawing.Point(0, 0);
			this.c1DockingTab1.Name = "c1DockingTab1";
			this.c1DockingTab1.SelectedIndex = 0;
			this.c1DockingTab1.ShowCaption = true;
			this.c1DockingTab1.ShowSingleTab = false;
			this.c1DockingTab1.Size = new System.Drawing.Size(276, 320);
			this.c1DockingTab1.TabIndex = 0;
			this.c1DockingTab1.TabSizeMode = C1.Win.C1Command.TabSizeModeEnum.Fit;
			this.c1DockingTab1.TabStyle = C1.Win.C1Command.TabStyleEnum.WindowsXP;
			// 
			// c1DockingTabPage1
			// 
			this.c1DockingTabPage1.Controls.Add(this.Dep);
			this.c1DockingTabPage1.ImageIndex = -1;
			this.c1DockingTabPage1.Location = new System.Drawing.Point(1, 1);
			this.c1DockingTabPage1.Name = "c1DockingTabPage1";
			this.c1DockingTabPage1.Size = new System.Drawing.Size(271, 318);
			this.c1DockingTabPage1.TabIndex = 0;
			this.c1DockingTabPage1.Text = "Page1";
			// 
			// Dep
			// 
			this.Dep.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Dep.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Dep.Location = new System.Drawing.Point(0, 20);
			this.Dep.Name = "Dep";
			this.Dep.Size = new System.Drawing.Size(271, 298);
			this.Dep.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(276, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(636, 320);
			this.panel1.TabIndex = 3;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.panel6);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 36);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(636, 284);
			this.panel2.TabIndex = 5;
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.panel8);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel6.Location = new System.Drawing.Point(0, 0);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(636, 284);
			this.panel6.TabIndex = 1;
			// 
			// panel8
			// 
			this.panel8.Controls.Add(this.panel12);
			this.panel8.Controls.Add(this.panel11);
			this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel8.Location = new System.Drawing.Point(0, 0);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(636, 284);
			this.panel8.TabIndex = 2;
			// 
			// panel12
			// 
			this.panel12.Controls.Add(this.panel7);
			this.panel12.Controls.Add(this.splitter1);
			this.panel12.Controls.Add(this.panel5);
			this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel12.Location = new System.Drawing.Point(0, 32);
			this.panel12.Name = "panel12";
			this.panel12.Size = new System.Drawing.Size(636, 252);
			this.panel12.TabIndex = 41;
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.cmd_q);
			this.panel7.Controls.Add(this.cmd_change);
			this.panel7.Controls.Add(this.cmd_copy);
			this.panel7.Controls.Add(this.nav);
			this.panel7.Controls.Add(this.vs);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(636, 209);
			this.panel7.TabIndex = 18;
			// 
			// cmd_change
			// 
			this.cmd_change.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_change.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmd_change.Location = new System.Drawing.Point(284, 4);
			this.cmd_change.Name = "cmd_change";
			this.cmd_change.Size = new System.Drawing.Size(172, 24);
			this.cmd_change.TabIndex = 150;
			this.cmd_change.Text = "Quick Change";
			this.cmd_change.Click += new System.EventHandler(this.cmd_change_Click);
			// 
			// cmd_copy
			// 
			this.cmd_copy.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_copy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmd_copy.Location = new System.Drawing.Point(460, 4);
			this.cmd_copy.Name = "cmd_copy";
			this.cmd_copy.Size = new System.Drawing.Size(164, 24);
			this.cmd_copy.TabIndex = 149;
			this.cmd_copy.Text = "Copy";
			this.cmd_copy.Visible = false;
			this.cmd_copy.Click += new System.EventHandler(this.cmd_copy_Click);
			// 
			// nav
			// 
			this.nav.BackColor = System.Drawing.SystemColors.Control;
			this.nav.Connection = null;
			this.nav.ConnectionDel = null;
			this.nav.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.nav.form = null;
			this.nav.FormName = null;
			this.nav.Grid = null;
			this.nav.History = false;
			this.nav.IsNull = true;
			this.nav.Language = "EN";
			this.nav.Location = new System.Drawing.Point(4, 0);
			this.nav.MSG_Exit = false;
			this.nav.MulltiDel = false;
			this.nav.Name = "nav";
			this.nav.Security = 0;
			this.nav.ShowPopupMenu = false;
			this.nav.Size = new System.Drawing.Size(276, 32);
			this.nav.TabIndex = 15;
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
			this.vs.Location = new System.Drawing.Point(4, 32);
			this.vs.Name = "vs";
			this.vs.Size = new System.Drawing.Size(628, 176);
			this.vs.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs.TabIndex = 14;
			this.vs.Tag = "";
			// 
			// splitter1
			// 
			this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.splitter1.Location = new System.Drawing.Point(0, 209);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(636, 3);
			this.splitter1.TabIndex = 17;
			this.splitter1.TabStop = false;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.Moccasin;
			this.panel5.Controls.Add(this.cmd_ok);
			this.panel5.Controls.Add(this.label3);
			this.panel5.Controls.Add(this.dt4);
			this.panel5.Controls.Add(this.label2);
			this.panel5.Controls.Add(this.dt1);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel5.Location = new System.Drawing.Point(0, 212);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(636, 40);
			this.panel5.TabIndex = 16;
			// 
			// cmd_ok
			// 
			this.cmd_ok.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_ok.Location = new System.Drawing.Point(344, 4);
			this.cmd_ok.Name = "cmd_ok";
			this.cmd_ok.Size = new System.Drawing.Size(108, 32);
			this.cmd_ok.TabIndex = 148;
			this.cmd_ok.Text = "OK";
			this.cmd_ok.Visible = false;
			this.cmd_ok.Click += new System.EventHandler(this.cmd_ok_Click);
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label3.Location = new System.Drawing.Point(200, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 23);
			this.label3.TabIndex = 147;
			this.label3.Tag = "";
			this.label3.Text = "To";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.label3.Visible = false;
			// 
			// dt4
			// 
			this.dt4.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt4.Location = new System.Drawing.Point(104, 8);
			this.dt4.Name = "dt4";
			this.dt4.Size = new System.Drawing.Size(96, 23);
			this.dt4.TabIndex = 145;
			this.dt4.Tag = null;
			this.dt4.Visible = false;
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label2.Location = new System.Drawing.Point(12, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(92, 23);
			this.label2.TabIndex = 144;
			this.label2.Tag = "";
			this.label2.Text = "VAC_ID";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.label2.Visible = false;
			// 
			// dt1
			// 
			this.dt1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dt1.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt1.Location = new System.Drawing.Point(240, 8);
			this.dt1.Name = "dt1";
			this.dt1.Size = new System.Drawing.Size(96, 23);
			this.dt1.TabIndex = 143;
			this.dt1.Tag = null;
			this.dt1.Visible = false;
			// 
			// panel11
			// 
			this.panel11.Controls.Add(this.txt6);
			this.panel11.Controls.Add(this.txt7);
			this.panel11.Controls.Add(this.txt5);
			this.panel11.Controls.Add(this.dt3);
			this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel11.Location = new System.Drawing.Point(0, 0);
			this.panel11.Name = "panel11";
			this.panel11.Size = new System.Drawing.Size(636, 32);
			this.panel11.TabIndex = 40;
			// 
			// txt6
			// 
			this.txt6.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt6.Location = new System.Drawing.Point(124, 4);
			this.txt6.MaxLength = 20;
			this.txt6.Name = "txt6";
			this.txt6.Size = new System.Drawing.Size(112, 23);
			this.txt6.TabIndex = 38;
			this.txt6.Tag = "EMP_I1";
			this.txt6.Text = "textBox3";
			this.txt6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt5_KeyDown);
			this.txt6.Leave += new System.EventHandler(this.txt5_Leave);
			this.txt6.Enter += new System.EventHandler(this.txt5_Enter);
			// 
			// txt7
			// 
			this.txt7.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt7.Location = new System.Drawing.Point(240, 4);
			this.txt7.MaxLength = 20;
			this.txt7.Name = "txt7";
			this.txt7.Size = new System.Drawing.Size(132, 23);
			this.txt7.TabIndex = 39;
			this.txt7.Tag = "EMP_NM";
			this.txt7.Text = "textBox3";
			this.txt7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt5_KeyDown);
			this.txt7.Leave += new System.EventHandler(this.txt5_Leave);
			this.txt7.Enter += new System.EventHandler(this.txt5_Enter);
			// 
			// txt5
			// 
			this.txt5.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt5.Location = new System.Drawing.Point(8, 4);
			this.txt5.MaxLength = 20;
			this.txt5.Name = "txt5";
			this.txt5.Size = new System.Drawing.Size(112, 23);
			this.txt5.TabIndex = 37;
			this.txt5.Tag = "EMP_ID";
			this.txt5.Text = "textBox3";
			this.txt5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt5_KeyDown);
			this.txt5.Leave += new System.EventHandler(this.txt5_Leave);
			this.txt5.Enter += new System.EventHandler(this.txt5_Enter);
			// 
			// dt3
			// 
			this.dt3.BackColor = System.Drawing.Color.LemonChiffon;
			this.dt3.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt3.Location = new System.Drawing.Point(376, 4);
			this.dt3.Name = "dt3";
			this.dt3.Size = new System.Drawing.Size(96, 23);
			this.dt3.TabIndex = 140;
			this.dt3.Tag = null;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.panel4);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(636, 36);
			this.panel3.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Location = new System.Drawing.Point(8, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(628, 36);
			this.label5.TabIndex = 11;
			this.label5.Tag = "";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			// cmd_q
			// 
			this.cmd_q.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_q.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmd_q.Location = new System.Drawing.Point(460, 4);
			this.cmd_q.Name = "cmd_q";
			this.cmd_q.Size = new System.Drawing.Size(172, 24);
			this.cmd_q.TabIndex = 151;
			this.cmd_q.Text = "Quick Change";
			this.cmd_q.Click += new System.EventHandler(this.cmd_q_Click);
			// 
			// frmTaShiftReset
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(912, 320);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.c1CommandDock1);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaShiftReset";
			this.Text = "frmTaShiftReset";
			this.Load += new System.EventHandler(this.frmTaVacateManager_Load);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandDock1)).EndInit();
			this.c1CommandDock1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).EndInit();
			this.c1DockingTab1.ResumeLayout(false);
			this.c1DockingTabPage1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.panel12.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			this.panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dt4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dt1)).EndInit();
			this.panel11.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dt3)).EndInit();
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion		
		
		#region Init Form
		private void frmTaVacateManager_Load(object sender, System.EventArgs e)
		{
			dt3.CustomFormat=dt1.CustomFormat=dt4.CustomFormat="yyyyMM";
			dt3.Value=dt4.Value=T_String.GetDate();	
			dt1.Value=T_String.GetDate().AddMonths(1);
			Init_Form();	
		}
		private void Init_Form()
		{					
			Dep.Init_Tree(this.Tag+"");
			Dep.vs1.AfterRowColChange+=new C1.Win.C1FlexGrid.RangeEventHandler(Depvs1_AfterRowColChange);
			Dep.Show_Tree();			
			Init_vs();			
			Basic.Function.PublicFunction.L_Init_Label(this);	
		}
	
		private void Init_vs()
		{
			nav.cmd_search.Visible=nav.cmd_report.Visible=nav.cmd_add.Visible=nav.cmd_copy.Visible=false;			
			PublicFunction.InitNav(this,vs,nav);
			string sql,st="";
			sql="Select SHI_ID from FILC02A";
			Func.RecordSet rs=new Func.RecordSet(sql,PublicFunction.C_con);
			for(int i=0;i<rs.rows;i++)
			{
				st+="|"+rs.record(i,0);
			}
			for(int i=1;i<=31;i++)
			{				
				//vs.Cols["DAY_"+i.ToString("00")].DataMap=InitCBForVS(sql);
				vs.Cols["DAY_"+i.ToString("00")].ComboList=st;
			}
			//nav.Show_VS("YYY_MM=N'"+ ((DateTime)dt3.Value).ToString("yyyyMM")+"'");			
		//	vs.AllowEditing=false;
			vs.Cols.Frozen=vs.Cols["EMP_NM"].Index;
			vs.EnabledChanged+=new EventHandler(vs_EnabledChanged);
			vs.AfterEdit+=new C1.Win.C1FlexGrid.RowColEventHandler(vs_AfterEdit);			
			vs.SelectionMode=C1.Win.C1FlexGrid.SelectionModeEnum.CellRange; 
			nav.ToolBar_Auto=false;
			nav.TBarClick+=new ToolBarButtonClickEventHandler(nav_TBarClick);
			vs.Styles.Add("CN");
			vs.Styles["CN"].BackColor=Color.Silver;
		}	
		private void show_cn()
		{
			for(int i=1;i<=31;i++)
			{
				try
				{
					DateTime d=new DateTime(DateTime.Parse(dt3.Value+"").Year, DateTime.Parse(dt3.Value+"").Month,i);
					if(d.DayOfWeek==System.DayOfWeek.Sunday)
						vs.Cols["DAY_"+i.ToString("00")].Style.BackColor=vs.Styles["CN"].BackColor;
					else
						vs.Cols["DAY_"+i.ToString("00")].Style.BackColor=vs.Styles["Normal"].BackColor;
				}
				catch{}
			}
		}
		private void nav_TBarClick(object sender, ToolBarButtonClickEventArgs e)
		{
			if (e.Button.Equals(nav.cmd_refresh))
			{
				if(nav.wh!="")
					nav.ToolBar_Click(e);
				else
					nav.Show_VS("YYY_MM=N'"+dt3.Text+"' and  DEP_ID in "+T_String.DEP_ID(this.Tag));				
				show_cn();
				return;
			}
			nav.ToolBar_Click(e);
		}
		public static Hashtable InitCBForVS(string sql)
		{
			Func.RecordSet rs=new Func.RecordSet(sql,PublicFunction.C_con);
			Hashtable a=new Hashtable();			
			a.Add("00","00");
			for(int i=0;i<rs.rows;i++)
			{
				a.Add(rs.record(i,0),rs.record(i,1));
			}
			return a;
		}
		private void vs_EnabledChanged(object sender, EventArgs e)
		{
			txt5.Text=vs.Cols[txt5.Tag+""].Caption;
			txt6.Text=vs.Cols[txt6.Tag+""].Caption;
			txt7.Text=vs.Cols[txt7.Tag+""].Caption;	
			for(int i=1;i<=31;i++)
			{
				vs.Cols["DAY_"+i.ToString("00")].Caption="__"+i+"__";				
			}
			vs.AutoSizeCols();
		}
		#endregion
		#region ShowData
		private void Show_VS()
		{
			if(Dep.vs1.Row<=0)
			{
				vs.Rows.Count=1;
				return;
			}
			nav.Show_VS("DEP_ID in "+Dep.Get_DepAll()+" and (VAC_BT=0 or VAC_BT is null)"
				+"and YYY_MM=N'"+ ((DateTime)dt3.Value).ToString("yyyyMM")+"'");				
		}			
		#endregion
		#region  event
		private void vs_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			string dt=T_String.GetDate().ToString("yyyy/MM/dd HH:mm");
			for (int i=vs.Selection.r1;i<=vs.Selection.r2;i++)
			{
				for (int j=vs.Selection.c1;j<=vs.Selection.c2;j++)
				{
					if (PublicFunction.S_Left(vs.Cols[j].Name,4)=="DAY_" )
					{
						vs[i,j ]=vs[e.Row,e.Col];										
					}
				}
				vs.Rows[i].UserData=1;		
				vs.Rows[i]["LST_NM"]=PublicFunction.A_UserID;
				vs.Rows[i]["LST_DT"]=dt;
			}
		}
		private void Depvs1_AfterRowColChange(object sender, C1.Win.C1FlexGrid.RangeEventArgs e)
		{
			if(e.OldRange.r1!=e.NewRange.r1)
			{
				Show_VS();
			}
		}		

		#endregion
		#region Search
		private void txt5_Enter(object sender, System.EventArgs e)
		{			
			TextBox txt=(TextBox)sender;
			if (txt.Text==vs.Cols[txt.Tag+""].Caption)
				txt.Text="";
		}

		private void txt5_Leave(object sender, System.EventArgs e)
		{
			TextBox txt=(TextBox)sender;
			if (txt.Text=="")
				txt.Text=vs.Cols[txt.Tag+""].Caption;
		}

		private void txt5_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Enter)
			{
				string f=((TextBox)sender).Tag+"";
				if(f=="EMP_ID")
					f="a."+f;
				string sql;				
				sql=" like N'%"+((TextBox)sender).Text+"%'";
				sql=f+sql+" and  (VAC_BT=0 or VAC_BT is null) and YYY_MM=N'"+ ((DateTime)dt3.Value).ToString("yyyyMM")+"'"
					+"and DEP_ID in (Select DEP_ID  from SYS_SECURITY_DEP"+
					" where MNU_ID="+this.Tag+" and ALL_BT=1 and USER_ID=N'"+PublicFunction.A_UserID+"')";									
				nav.Show_VS(sql);	
				show_cn();						
			}
		}

		#endregion		
		#region Func
		private void cmd_ok_Click(object sender, System.EventArgs e)
		{
			string sql;
			string d1=dt1.Text;
			string d4=dt4.Text;
			SqlConnection con=new SqlConnection(PublicFunction.C_con.ConnectionString);
			con.Open();	
			string insert="Insert Into FILC03A(EMP_ID,YYY_MM,BLT_NM,BLT_DT,LST_NM,LST_DT";
			string dt=T_String.GetDate().ToString("yyyy/MM/dd HH:mm");
			for(int i=1;i<=31;i++)
			{
				insert+=",DAY_"+i.ToString("00");
			}
			insert+=") Select ";
			for(int i=1;i<vs.Rows.Count;i++)
			{
				SqlTransaction tran=con.BeginTransaction();			
				try
				{					
					sql="Delete From FILC03A where YYY_MM='"+d1+"' and EMP_ID=N'"+vs.Rows[i]["EMP_ID"]+"'";
					SqlCommand cmd=new SqlCommand(sql,con,tran);
					cmd.ExecuteNonQuery();	
					sql=" EMP_ID"
						+",N'"+d1+"' as YYY_MM"
						+",N'"+PublicFunction.A_UserID+"' as BLT_NM "
						+",'"+dt+"' as BLT_DT "
						+",N'"+PublicFunction.A_UserID+"' as LST_NM "
						+",'"+dt+"' as LST_DT ";					
					for(int j=1;j<=31;j++)
					{
						sql+=",DAY_"+i.ToString("00");
					}
					sql=insert + sql + " from FILC03A where YYY_MM='"+d4+"' and EMP_ID=N'"+vs.Rows[i]["EMP_ID"]+"'";
					cmd=new SqlCommand(sql,con,tran);
					cmd.ExecuteNonQuery();						
					tran.Commit();				
				}				
				catch(Exception ex)
				{
					tran.Rollback();
					MessageBox.Show(ex.Message);
				}
			}
			MessageBox.Show(PublicFunction.L_Get_Msg("Staff",1));
		}

		private void cmd_copy_Click(object sender, System.EventArgs e)
		{
			if(dlg==null)
			{
				dlg=new frmTaCopyShift();
				dlg.Tag=this.Tag;
				dlg.MdiParent=this.MdiParent;
				dlg.Show();
			}
			else
				dlg.WindowState=FormWindowState.Maximized;
			txt5.Focus();
		}
		#endregion

		private void cmd_change_Click(object sender, System.EventArgs e)
		{
			frmTaQuickChangeShift dlg=new frmTaQuickChangeShift();
			dlg.Tag=this.Tag;
			dlg.ShowDialog();
		}

		private void cmd_q_Click(object sender, System.EventArgs e)
		{
			frmTaQuick dlg=new frmTaQuick();
			dlg.Tag=this.Tag;
			dlg.ShowDialog();
		}


	

		

		
		

		
	}
}

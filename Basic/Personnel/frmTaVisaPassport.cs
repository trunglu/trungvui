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

namespace GP8000.Personnel
{
	/// <summary>
	/// Summary description for frmTaSetting.
	/// </summary>
	public class frmTaVisaPassport : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Button cmd_close;
		private System.Windows.Forms.Button cmd_save;
		private Navigator1._0.NavigatorAuto nav;
		private C1.Win.C1FlexGrid.C1FlexGrid vs;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label lb1;
		private C1.Win.C1Input.C1DateEdit dt_PAS_ST;
		private System.Windows.Forms.Label f;
		private System.Windows.Forms.TextBox txt_PAS_ID;
		private C1.Win.C1Input.C1DateEdit dt_PAS_ED;
		private C1.Win.C1Input.C1DateEdit dt_VIS_ED;
		private System.Windows.Forms.TextBox txt_VIS_ID;
		private C1.Win.C1Input.C1DateEdit dt_VIS_ST;
		private System.Windows.Forms.TextBox txt_WRK_ID;
		private C1.Win.C1Input.C1DateEdit dt_WRK_ST;
		private string EMP_ID;
		private C1.Win.C1Input.C1DateEdit dt_WRK_ED;
		private C1.Win.C1Input.C1DateEdit dt_WRK_I1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaVisaPassport(string EMP_ID,string EMP_NM)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			this.EMP_ID=EMP_ID;
			lb1.Text=EMP_NM;
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
			this.panel5 = new System.Windows.Forms.Panel();
			this.cmd_close = new System.Windows.Forms.Button();
			this.cmd_save = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.dt_WRK_I1 = new C1.Win.C1Input.C1DateEdit();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lb1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dt_WRK_ED = new C1.Win.C1Input.C1DateEdit();
			this.label7 = new System.Windows.Forms.Label();
			this.txt_WRK_ID = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.dt_WRK_ST = new C1.Win.C1Input.C1DateEdit();
			this.label9 = new System.Windows.Forms.Label();
			this.dt_VIS_ED = new C1.Win.C1Input.C1DateEdit();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_VIS_ID = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.dt_VIS_ST = new C1.Win.C1Input.C1DateEdit();
			this.label6 = new System.Windows.Forms.Label();
			this.dt_PAS_ED = new C1.Win.C1Input.C1DateEdit();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_PAS_ID = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.dt_PAS_ST = new C1.Win.C1Input.C1DateEdit();
			this.f = new System.Windows.Forms.Label();
			this.nav = new Navigator1._0.NavigatorAuto();
			this.vs = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.panel3.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dt_WRK_I1)).BeginInit();
			this.panel2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dt_WRK_ED)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dt_WRK_ST)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dt_VIS_ED)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dt_VIS_ST)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dt_PAS_ED)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dt_PAS_ST)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
			this.SuspendLayout();
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.panel3.Controls.Add(this.label5);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(678, 36);
			this.panel3.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Location = new System.Drawing.Point(0, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(678, 36);
			this.label5.TabIndex = 11;
			this.label5.Tag = "";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel5);
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 36);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(678, 274);
			this.panel1.TabIndex = 6;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.cmd_close);
			this.panel5.Controls.Add(this.cmd_save);
			this.panel5.Controls.Add(this.label10);
			this.panel5.Controls.Add(this.dt_WRK_I1);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(0, 224);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(678, 50);
			this.panel5.TabIndex = 24;
			// 
			// cmd_close
			// 
			this.cmd_close.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_close.Location = new System.Drawing.Point(371, 8);
			this.cmd_close.Name = "cmd_close";
			this.cmd_close.Size = new System.Drawing.Size(116, 36);
			this.cmd_close.TabIndex = 1;
			this.cmd_close.Text = "Close";
			this.cmd_close.Click += new System.EventHandler(this.cmd_close_Click);
			// 
			// cmd_save
			// 
			this.cmd_save.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_save.Location = new System.Drawing.Point(191, 8);
			this.cmd_save.Name = "cmd_save";
			this.cmd_save.Size = new System.Drawing.Size(116, 36);
			this.cmd_save.TabIndex = 0;
			this.cmd_save.Text = "Save";
			this.cmd_save.Click += new System.EventHandler(this.cmd_save_Click);
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(12, 20);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(152, 16);
			this.label10.TabIndex = 76;
			this.label10.Tag = "WRK_I1";
			this.label10.Text = "CRD_DT";
			this.label10.Visible = false;
			// 
			// dt_WRK_I1
			// 
			this.dt_WRK_I1.EmptyAsNull = true;
			this.dt_WRK_I1.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt_WRK_I1.Location = new System.Drawing.Point(92, 16);
			this.dt_WRK_I1.Name = "dt_WRK_I1";
			this.dt_WRK_I1.Size = new System.Drawing.Size(160, 23);
			this.dt_WRK_I1.TabIndex = 9;
			this.dt_WRK_I1.Tag = "WRK_I1";
			this.dt_WRK_I1.Visible = false;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.CornflowerBlue;
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 220);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(678, 4);
			this.panel4.TabIndex = 23;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.lb1);
			this.panel2.Controls.Add(this.groupBox1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(678, 220);
			this.panel2.TabIndex = 22;
			// 
			// lb1
			// 
			this.lb1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.lb1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lb1.Dock = System.Windows.Forms.DockStyle.Top;
			this.lb1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lb1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.lb1.Location = new System.Drawing.Point(0, 0);
			this.lb1.Name = "lb1";
			this.lb1.Size = new System.Drawing.Size(678, 36);
			this.lb1.TabIndex = 31;
			this.lb1.Tag = "N";
			this.lb1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.dt_WRK_ED);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.txt_WRK_ID);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.dt_WRK_ST);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.dt_VIS_ED);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txt_VIS_ID);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.dt_VIS_ST);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.dt_PAS_ED);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txt_PAS_ID);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.dt_PAS_ST);
			this.groupBox1.Controls.Add(this.f);
			this.groupBox1.Controls.Add(this.nav);
			this.groupBox1.Controls.Add(this.vs);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(4, 36);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(670, 184);
			this.groupBox1.TabIndex = 30;
			this.groupBox1.TabStop = false;
			this.groupBox1.Tag = "N";
			// 
			// dt_WRK_ED
			// 
			this.dt_WRK_ED.EmptyAsNull = true;
			this.dt_WRK_ED.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt_WRK_ED.Location = new System.Drawing.Point(496, 152);
			this.dt_WRK_ED.Name = "dt_WRK_ED";
			this.dt_WRK_ED.Size = new System.Drawing.Size(160, 23);
			this.dt_WRK_ED.TabIndex = 8;
			this.dt_WRK_ED.Tag = "WRK_ED";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(344, 160);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(152, 16);
			this.label7.TabIndex = 74;
			this.label7.Tag = "WRK_ED";
			this.label7.Text = "CRD_DT";
			// 
			// txt_WRK_ID
			// 
			this.txt_WRK_ID.Location = new System.Drawing.Point(168, 124);
			this.txt_WRK_ID.MaxLength = 30;
			this.txt_WRK_ID.Name = "txt_WRK_ID";
			this.txt_WRK_ID.Size = new System.Drawing.Size(160, 23);
			this.txt_WRK_ID.TabIndex = 6;
			this.txt_WRK_ID.Tag = "WRK_ID";
			this.txt_WRK_ID.Text = "textBox4";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(16, 132);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(152, 23);
			this.label8.TabIndex = 72;
			this.label8.Tag = "WRK_ID";
			this.label8.Text = "EMP_I1";
			// 
			// dt_WRK_ST
			// 
			this.dt_WRK_ST.EmptyAsNull = true;
			this.dt_WRK_ST.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt_WRK_ST.Location = new System.Drawing.Point(168, 152);
			this.dt_WRK_ST.Name = "dt_WRK_ST";
			this.dt_WRK_ST.Size = new System.Drawing.Size(160, 23);
			this.dt_WRK_ST.TabIndex = 7;
			this.dt_WRK_ST.Tag = "WRK_ST";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(16, 160);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(152, 16);
			this.label9.TabIndex = 70;
			this.label9.Tag = "WRK_ST";
			this.label9.Text = "CRD_DT";
			// 
			// dt_VIS_ED
			// 
			this.dt_VIS_ED.EmptyAsNull = true;
			this.dt_VIS_ED.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt_VIS_ED.Location = new System.Drawing.Point(496, 96);
			this.dt_VIS_ED.Name = "dt_VIS_ED";
			this.dt_VIS_ED.Size = new System.Drawing.Size(160, 23);
			this.dt_VIS_ED.TabIndex = 5;
			this.dt_VIS_ED.Tag = "VIS_ED";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(344, 104);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(152, 23);
			this.label2.TabIndex = 68;
			this.label2.Tag = "VIS_ED";
			this.label2.Text = "CRD_DT";
			// 
			// txt_VIS_ID
			// 
			this.txt_VIS_ID.Location = new System.Drawing.Point(168, 68);
			this.txt_VIS_ID.MaxLength = 30;
			this.txt_VIS_ID.Name = "txt_VIS_ID";
			this.txt_VIS_ID.Size = new System.Drawing.Size(160, 23);
			this.txt_VIS_ID.TabIndex = 3;
			this.txt_VIS_ID.Tag = "VIS_ID";
			this.txt_VIS_ID.Text = "textBox4";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 76);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(152, 23);
			this.label3.TabIndex = 66;
			this.label3.Tag = "VIS_ID";
			this.label3.Text = "EMP_I1";
			// 
			// dt_VIS_ST
			// 
			this.dt_VIS_ST.EmptyAsNull = true;
			this.dt_VIS_ST.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt_VIS_ST.Location = new System.Drawing.Point(168, 96);
			this.dt_VIS_ST.Name = "dt_VIS_ST";
			this.dt_VIS_ST.Size = new System.Drawing.Size(160, 23);
			this.dt_VIS_ST.TabIndex = 4;
			this.dt_VIS_ST.Tag = "VIS_ST";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(16, 104);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(152, 23);
			this.label6.TabIndex = 64;
			this.label6.Tag = "VIS_ST";
			this.label6.Text = "CRD_DT";
			// 
			// dt_PAS_ED
			// 
			this.dt_PAS_ED.EmptyAsNull = true;
			this.dt_PAS_ED.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt_PAS_ED.Location = new System.Drawing.Point(496, 40);
			this.dt_PAS_ED.Name = "dt_PAS_ED";
			this.dt_PAS_ED.Size = new System.Drawing.Size(160, 23);
			this.dt_PAS_ED.TabIndex = 2;
			this.dt_PAS_ED.Tag = "PAS_ED";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(344, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(152, 23);
			this.label1.TabIndex = 62;
			this.label1.Tag = "PAS_ED";
			this.label1.Text = "CRD_DT";
			// 
			// txt_PAS_ID
			// 
			this.txt_PAS_ID.Location = new System.Drawing.Point(168, 12);
			this.txt_PAS_ID.MaxLength = 30;
			this.txt_PAS_ID.Name = "txt_PAS_ID";
			this.txt_PAS_ID.Size = new System.Drawing.Size(160, 23);
			this.txt_PAS_ID.TabIndex = 0;
			this.txt_PAS_ID.Tag = "PAS_ID";
			this.txt_PAS_ID.Text = "textBox4";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 20);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(152, 23);
			this.label4.TabIndex = 60;
			this.label4.Tag = "PAS_ID";
			this.label4.Text = "PAS_ID";
			// 
			// dt_PAS_ST
			// 
			this.dt_PAS_ST.EmptyAsNull = true;
			this.dt_PAS_ST.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt_PAS_ST.Location = new System.Drawing.Point(168, 40);
			this.dt_PAS_ST.Name = "dt_PAS_ST";
			this.dt_PAS_ST.Size = new System.Drawing.Size(160, 23);
			this.dt_PAS_ST.TabIndex = 1;
			this.dt_PAS_ST.Tag = "PAS_ST";
			// 
			// f
			// 
			this.f.Location = new System.Drawing.Point(16, 48);
			this.f.Name = "f";
			this.f.Size = new System.Drawing.Size(152, 23);
			this.f.TabIndex = 58;
			this.f.Tag = "PAS_ST";
			this.f.Text = "CRD_DT";
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
			this.nav.Location = new System.Drawing.Point(600, 16);
			this.nav.MSG_Exit = false;
			this.nav.MulltiDel = false;
			this.nav.Name = "nav";
			this.nav.Security = 0;
			this.nav.ShowPopupMenu = false;
			this.nav.Size = new System.Drawing.Size(52, 32);
			this.nav.TabIndex = 28;
			this.nav.ToolBar_Auto = true;
			this.nav.UserID = null;
			this.nav.Visible = false;
			this.nav.VisibleGrid = false;
			this.nav.Where = null;
			// 
			// vs
			// 
			this.vs.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs.Location = new System.Drawing.Point(608, 48);
			this.vs.Name = "vs";
			this.vs.Size = new System.Drawing.Size(132, 24);
			this.vs.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs.TabIndex = 29;
			this.vs.Visible = false;
			// 
			// frmTaVisaPassport
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(678, 310);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmTaVisaPassport";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmTaVisaPassport";
			this.Load += new System.EventHandler(this.frmTaSetting_Load);
			this.panel3.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dt_WRK_I1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dt_WRK_ED)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dt_WRK_ST)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dt_VIS_ED)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dt_VIS_ST)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dt_PAS_ED)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dt_PAS_ST)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaSetting_Load(object sender, System.EventArgs e)
		{		
			PublicFunction.InitNav(this,vs,nav);			
			nav.Show_VS("EMP_ID=N'"+EMP_ID+"'");									
			nav.ToolBar_Auto=false;			
			show_data();
			Basic.Function.PublicFunction.L_Init_Label(this);						
			TextBoxAndVS.L_GetLabelFromVS(groupBox1,vs);

			dt_PAS_ED.CustomFormat=dt_PAS_ST.CustomFormat=dt_VIS_ED.CustomFormat=dt_VIS_ST.CustomFormat=
				dt_WRK_ED.CustomFormat=dt_WRK_ST.CustomFormat=dt_PAS_ED.CustomFormat=PublicFunction.GetOption("DATE");			
		}	

		private void show_data()
		{
			TextBoxAndVS.D_GetDataFromVS(groupBox1,vs);			
			if (vs.Row<1) 
			{					
				return;					
			}		
		}		

		private void cmd_save_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(vs.Rows.Count<=1)
				{					
					vs.Rows.Count++;
					vs.Row=vs.Rows.Count-1;
					vs.Rows[vs.Row].UserData=2;	
					vs.Rows[vs.Row]["EMP_ID"]=EMP_ID;				
				}
				else
				{				
					vs.Rows[vs.Row].UserData=1;						
				}
				TextBoxAndVS.D_GetDataFromTextBox(groupBox1,vs);
				nav.SaveRow(vs.Row);
				this.Close();
			}
			catch( Exception){}
			
		}

		private void cmd_close_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		

		
	}
}

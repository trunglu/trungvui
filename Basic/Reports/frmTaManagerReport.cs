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

namespace GP8000.Reports
{
	/// <summary>
	/// Summary description for frmTaHRReport.
	/// </summary>
	public class frmTaManagerReport : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel panel4;
		private Navigator1._0.NavigatorAuto nav;
		private C1.Win.C1FlexGrid.C1FlexGrid vs;
		private System.Windows.Forms.Panel p1;
		private System.Windows.Forms.Panel p2;
		private System.Windows.Forms.Panel p3;
		private System.Windows.Forms.Panel p4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.DateTimePicker dt_dt1;
		private System.Windows.Forms.DateTimePicker dt_dt2;
		private System.Windows.Forms.DateTimePicker dt_y;
		private System.Windows.Forms.DateTimePicker dt_m;
		private System.Windows.Forms.ComboBox cb_q;
		private System.Windows.Forms.CheckBox ck_labour;
		private System.Windows.Forms.CheckBox ck_vat;
		private System.Windows.Forms.Button cmd_close;
		private System.Windows.Forms.Button cmd_ok;
		private GP8000.UserControl.CrtTaCondition1 control1;
		private System.Windows.Forms.Panel p5;
		private System.Windows.Forms.Panel panel5;
//		private AxPrintReportExcel.AxReportExcel rp;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaManagerReport()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmTaManagerReport));
			this.panel3 = new System.Windows.Forms.Panel();
			this.nav = new Navigator1._0.NavigatorAuto();
			this.label5 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
//			this.rp = new AxPrintReportExcel.AxReportExcel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.cmd_ok = new System.Windows.Forms.Button();
			this.cmd_close = new System.Windows.Forms.Button();
			this.panel6 = new System.Windows.Forms.Panel();
			this.p5 = new System.Windows.Forms.Panel();
			this.control1 = new GP8000.UserControl.CrtTaCondition1();
			this.p4 = new System.Windows.Forms.Panel();
			this.ck_vat = new System.Windows.Forms.CheckBox();
			this.ck_labour = new System.Windows.Forms.CheckBox();
			this.p3 = new System.Windows.Forms.Panel();
			this.dt_m = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.p2 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.dt_y = new System.Windows.Forms.DateTimePicker();
			this.cb_q = new System.Windows.Forms.ComboBox();
			this.p1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.dt_dt2 = new System.Windows.Forms.DateTimePicker();
			this.dt_dt1 = new System.Windows.Forms.DateTimePicker();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.panel2 = new System.Windows.Forms.Panel();
			this.vs = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.panel3.SuspendLayout();
			this.panel1.SuspendLayout();
//			this.panel4.SuspendLayout();
//			((System.ComponentModel.ISupportInitialize)(this.rp)).BeginInit();
			this.panel5.SuspendLayout();
			this.p5.SuspendLayout();
			this.p4.SuspendLayout();
			this.p3.SuspendLayout();
			this.p2.SuspendLayout();
			this.p1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
			this.SuspendLayout();
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.panel3.Controls.Add(this.nav);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(904, 36);
			this.panel3.TabIndex = 5;
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
			this.nav.MulltiDel = false;
			this.nav.Name = "nav";
			this.nav.Security = 0;
			this.nav.ShowPopupMenu = true;
			this.nav.Size = new System.Drawing.Size(360, 36);
			this.nav.TabIndex = 28;
			this.nav.Tag = "";
			this.nav.ToolBar_Auto = true;
			this.nav.UserID = null;
			this.nav.Visible = false;
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
			this.label5.Size = new System.Drawing.Size(904, 36);
			this.label5.TabIndex = 11;
			this.label5.Tag = "N";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Controls.Add(this.splitter1);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 36);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(904, 468);
			this.panel1.TabIndex = 6;
			// 
			// panel4
			// 
//			this.panel4.Controls.Add(this.rp);
			this.panel4.Controls.Add(this.panel5);
			this.panel4.Controls.Add(this.panel6);
			this.panel4.Controls.Add(this.p5);
			this.panel4.Controls.Add(this.p4);
			this.panel4.Controls.Add(this.p3);
			this.panel4.Controls.Add(this.p2);
			this.panel4.Controls.Add(this.p1);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(367, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(537, 468);
			this.panel4.TabIndex = 2;
			// 
			// rp
			// 
//			this.rp.ContainingControl = this;
//			this.rp.Enabled = true;
//			this.rp.Location = new System.Drawing.Point(148, 392);
//			this.rp.Name = "rp";
//			this.rp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("rp.OcxState")));
//			this.rp.Size = new System.Drawing.Size(85, 20);
//			this.rp.TabIndex = 29;
//			this.rp.Visible = false;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.cmd_ok);
			this.panel5.Controls.Add(this.cmd_close);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel5.Location = new System.Drawing.Point(0, 308);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(537, 56);
			this.panel5.TabIndex = 28;
			// 
			// cmd_ok
			// 
			this.cmd_ok.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_ok.Location = new System.Drawing.Point(80, 8);
			this.cmd_ok.Name = "cmd_ok";
			this.cmd_ok.Size = new System.Drawing.Size(116, 36);
			this.cmd_ok.TabIndex = 26;
			this.cmd_ok.Text = "Save";
			this.cmd_ok.Click += new System.EventHandler(this.cmd_ok_Click);
			// 
			// cmd_close
			// 
			this.cmd_close.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_close.Location = new System.Drawing.Point(260, 8);
			this.cmd_close.Name = "cmd_close";
			this.cmd_close.Size = new System.Drawing.Size(116, 36);
			this.cmd_close.TabIndex = 27;
			this.cmd_close.Text = "Close";
			this.cmd_close.Click += new System.EventHandler(this.cmd_close_Click);
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.CornflowerBlue;
			this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel6.Location = new System.Drawing.Point(0, 304);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(537, 4);
			this.panel6.TabIndex = 5;
			// 
			// p5
			// 
			this.p5.Controls.Add(this.control1);
			this.p5.Dock = System.Windows.Forms.DockStyle.Top;
			this.p5.Location = new System.Drawing.Point(0, 132);
			this.p5.Name = "p5";
			this.p5.Size = new System.Drawing.Size(537, 172);
			this.p5.TabIndex = 4;
			// 
			// control1
			// 
			this.control1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.control1.Location = new System.Drawing.Point(8, 0);
			this.control1.Name = "control1";
			this.control1.Size = new System.Drawing.Size(460, 176);
			this.control1.TabIndex = 0;
			// 
			// p4
			// 
			this.p4.Controls.Add(this.ck_vat);
			this.p4.Controls.Add(this.ck_labour);
			this.p4.Dock = System.Windows.Forms.DockStyle.Top;
			this.p4.Location = new System.Drawing.Point(0, 100);
			this.p4.Name = "p4";
			this.p4.Size = new System.Drawing.Size(537, 32);
			this.p4.TabIndex = 3;
			// 
			// ck_vat
			// 
			this.ck_vat.Location = new System.Drawing.Point(280, 4);
			this.ck_vat.Name = "ck_vat";
			this.ck_vat.TabIndex = 1;
			this.ck_vat.Text = "checkBox2";
			// 
			// ck_labour
			// 
			this.ck_labour.Location = new System.Drawing.Point(148, 4);
			this.ck_labour.Name = "ck_labour";
			this.ck_labour.TabIndex = 0;
			this.ck_labour.Text = "checkBox1";
			// 
			// p3
			// 
			this.p3.Controls.Add(this.dt_m);
			this.p3.Controls.Add(this.label3);
			this.p3.Dock = System.Windows.Forms.DockStyle.Top;
			this.p3.Location = new System.Drawing.Point(0, 68);
			this.p3.Name = "p3";
			this.p3.Size = new System.Drawing.Size(537, 32);
			this.p3.TabIndex = 2;
			// 
			// dt_m
			// 
			this.dt_m.CustomFormat = "yyyyMM";
			this.dt_m.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dt_m.Location = new System.Drawing.Point(144, 4);
			this.dt_m.Name = "dt_m";
			this.dt_m.Size = new System.Drawing.Size(108, 23);
			this.dt_m.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(140, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "label3";
			// 
			// p2
			// 
			this.p2.Controls.Add(this.label2);
			this.p2.Controls.Add(this.dt_y);
			this.p2.Controls.Add(this.cb_q);
			this.p2.Dock = System.Windows.Forms.DockStyle.Top;
			this.p2.Location = new System.Drawing.Point(0, 36);
			this.p2.Name = "p2";
			this.p2.Size = new System.Drawing.Size(537, 32);
			this.p2.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(136, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "label2";
			// 
			// dt_y
			// 
			this.dt_y.CustomFormat = "yyyy";
			this.dt_y.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dt_y.Location = new System.Drawing.Point(144, 4);
			this.dt_y.Name = "dt_y";
			this.dt_y.Size = new System.Drawing.Size(108, 23);
			this.dt_y.TabIndex = 3;
			// 
			// cb_q
			// 
			this.cb_q.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_q.Items.AddRange(new object[] {
													  "1",
													  "2",
													  "3",
													  "4"});
			this.cb_q.Location = new System.Drawing.Point(276, 4);
			this.cb_q.Name = "cb_q";
			this.cb_q.Size = new System.Drawing.Size(108, 24);
			this.cb_q.TabIndex = 7;
			// 
			// p1
			// 
			this.p1.Controls.Add(this.label1);
			this.p1.Controls.Add(this.dt_dt2);
			this.p1.Controls.Add(this.dt_dt1);
			this.p1.Dock = System.Windows.Forms.DockStyle.Top;
			this.p1.Location = new System.Drawing.Point(0, 0);
			this.p1.Name = "p1";
			this.p1.Size = new System.Drawing.Size(537, 36);
			this.p1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(136, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "label1";
			// 
			// dt_dt2
			// 
			this.dt_dt2.CustomFormat = "yyyy/MM/dd";
			this.dt_dt2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dt_dt2.Location = new System.Drawing.Point(276, 8);
			this.dt_dt2.Name = "dt_dt2";
			this.dt_dt2.Size = new System.Drawing.Size(108, 23);
			this.dt_dt2.TabIndex = 1;
			// 
			// dt_dt1
			// 
			this.dt_dt1.CustomFormat = "yyyy/MM/dd";
			this.dt_dt1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dt_dt1.Location = new System.Drawing.Point(144, 8);
			this.dt_dt1.Name = "dt_dt1";
			this.dt_dt1.Size = new System.Drawing.Size(108, 23);
			this.dt_dt1.TabIndex = 0;
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(364, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(3, 468);
			this.splitter1.TabIndex = 1;
			this.splitter1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.vs);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(364, 468);
			this.panel2.TabIndex = 0;
			// 
			// vs
			// 
			this.vs.AllowEditing = false;
			this.vs.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vs.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vs.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs.Location = new System.Drawing.Point(0, 0);
			this.vs.Name = "vs";
			this.vs.Size = new System.Drawing.Size(364, 468);
			this.vs.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs.TabIndex = 27;
			// 
			// frmTaManagerReport
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(904, 504);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaManagerReport";
			this.Text = "frmTaManagerReport";
			this.Load += new System.EventHandler(this.frmTaHRReport_Load);
			this.panel3.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
//			this.panel4.ResumeLayout(false);
//			((System.ComponentModel.ISupportInitialize)(this.rp)).EndInit();
			this.panel5.ResumeLayout(false);
			this.p5.ResumeLayout(false);
			this.p4.ResumeLayout(false);
			this.p3.ResumeLayout(false);
			this.p2.ResumeLayout(false);
			this.p1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaHRReport_Load(object sender, System.EventArgs e)
		{
			PublicFunction.InitNav(this,vs,nav);
			vs.EnabledChanged+=new EventHandler(vs_EnabledChanged);
			Basic.Function.PublicFunction.L_Init_Label(this);
			nav.Show_VS("[NAME]=N'MAN_"+PublicFunction.CUS_ID+"' or [NAME]=N'MAN_0'");
			dt_dt1.CustomFormat=dt_dt2.CustomFormat=PublicFunction.GetOption("DATE");
			control1.InitCB(this.Tag);
			control1.Initlabel();
			vs.AfterRowColChange+=new C1.Win.C1FlexGrid.RangeEventHandler(vs_AfterRowColChange);
			Show_con();
		}

		private void vs_EnabledChanged(object sender, EventArgs e)
		{
			label5.Text=PublicFunction.L_Get_PopMenu("COM",T_String.IsNullTo0(PublicFunction.CUS_ID));
			vs.Cols["EN"].Visible=false;
			vs.Cols["VN"].Visible=false;
			vs.Cols["CH"].Visible=false;
			vs.Cols["TT"].Visible=false;
			vs.Cols[PublicFunction.L_Lag].Visible=true;
			vs.AutoSizeCols();
		}

		private void cmd_close_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void vs_AfterRowColChange(object sender, C1.Win.C1FlexGrid.RangeEventArgs e)
		{
			if(e.NewRange.r1!=e.OldRange.r1)
			{
				Show_con();
			}
		}
		private void Show_con()
		{			
			panel4.Visible=!(vs.Row<=0);	
			p1.Visible=(vs.Rows[vs.Row]["DT_BT"]+""=="True");
			p2.Visible=(vs.Rows[vs.Row]["QT_BT"]+""=="True");
			p3.Visible=(vs.Rows[vs.Row]["MT_BT"]+""=="True");
			p4.Visible=(vs.Rows[vs.Row]["CK_BT"]+""=="True");
			p5.Visible=(vs.Rows[vs.Row]["DP_BT"]+""=="True");
		}

		private void cmd_ok_Click(object sender, System.EventArgs e)
		{
			if(vs.Row<=0)
				return;
			try
			{
				string filename="";
				filename=PublicFunction.Path+"\\ReportsVBA\\"+vs.Rows[vs.Row]["FIL_NM"];
				string where,where1,where2,where3,where4,where5,where6,where7;
				where=where1=where2=where3=where4=where5=where6=where7="";

				where=control1.GetWhere("FILB01A",false);
				where1=dt_m.Text;
				where2=((DateTime)dt_dt1.Value).ToString("yyyy/MM/dd");
				where3=((DateTime)dt_dt2.Value).ToString("yyyy/MM/dd");
				where4=dt_y.Text;
				where5=cb_q.Text;
				where6=ck_labour.Checked+"";
				where7=ck_vat.Checked+"";

//				rp.PrintExcel(filename,PublicFunction.C_ConStrForRPT,vs.Rows[vs.Row][PublicFunction.L_Lag]+"","",
//					PublicFunction.L_Lag,where,where1,where2,where3,where4,where5,where6,where7,"","","",PublicFunction.A_UserID);
				ReportExcel.PrintExcel(filename,PublicFunction.C_ConStrForRPT,"","",
					PublicFunction.L_Lag,where,where1,where2,where3,where4,where5,where6,where7,"","","","","","",PublicFunction.A_UserID );


			}
			catch{}
		}
	}
}

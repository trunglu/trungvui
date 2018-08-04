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

using C1.C1Excel;
using C1.Win.C1FlexGrid;
namespace GP8000.Payroll
{
	/// <summary>
	/// Summary description for frmTaExcel.
	/// </summary>
	public class frmTaExcel : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.ListBox _list;
		private System.Windows.Forms.Button button1;
		private C1.C1Excel.C1XLBook _book;

		ArrayList _grids = new ArrayList();
		private C1.Win.C1FlexGrid.C1FlexGrid _flex;
		private System.Windows.Forms.Panel panel5;
		private Navigator1._0.NavigatorAuto nav;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel8;
		private C1.Win.C1FlexGrid.C1FlexGrid vs;
		private System.Windows.Forms.Label lb;
		private System.Windows.Forms.Button cmd_WID;
		private System.Windows.Forms.Button cmd_DWID;
		private System.Windows.Forms.DateTimePicker dt;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button cmd_to;
		private System.Windows.Forms.Button cmd_fr;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton r2;
		private System.Windows.Forms.RadioButton r1;
		private System.Windows.Forms.TextBox txt_WID;
		private System.Windows.Forms.TextBox txt_DWID;
		private System.Windows.Forms.TextBox txt_to;
		private System.Windows.Forms.TextBox txt_fr;
		private System.Windows.Forms.Button cmd_import;
		private System.Windows.Forms.Button cmd_save;
		private System.Windows.Forms.Button cmd_load;
		private System.Windows.Forms.Button cmd_del;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaExcel()
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
			this._flex = new C1.Win.C1FlexGrid.C1FlexGrid();
			this._list = new System.Windows.Forms.ListBox();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.vs = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.panel8 = new System.Windows.Forms.Panel();
			this.dt = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.cmd_to = new System.Windows.Forms.Button();
			this.cmd_fr = new System.Windows.Forms.Button();
			this.txt_to = new System.Windows.Forms.TextBox();
			this.txt_fr = new System.Windows.Forms.TextBox();
			this.cmd_DWID = new System.Windows.Forms.Button();
			this.cmd_WID = new System.Windows.Forms.Button();
			this.txt_DWID = new System.Windows.Forms.TextBox();
			this.txt_WID = new System.Windows.Forms.TextBox();
			this.lb = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.r2 = new System.Windows.Forms.RadioButton();
			this.r1 = new System.Windows.Forms.RadioButton();
			this.panel5 = new System.Windows.Forms.Panel();
			this.cmd_del = new System.Windows.Forms.Button();
			this.cmd_load = new System.Windows.Forms.Button();
			this.cmd_save = new System.Windows.Forms.Button();
			this.cmd_import = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this._book = new C1.C1Excel.C1XLBook();
			this.panel3.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
			this.panel8.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.panel5.SuspendLayout();
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
			this.panel3.Size = new System.Drawing.Size(768, 36);
			this.panel3.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Location = new System.Drawing.Point(348, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(420, 36);
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
			this.panel1.Controls.Add(this.splitter1);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 36);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(768, 456);
			this.panel1.TabIndex = 8;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this._flex);
			this.panel4.Controls.Add(this._list);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(0, 147);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(768, 309);
			this.panel4.TabIndex = 2;
			// 
			// _flex
			// 
			this._flex.AllowEditing = false;
			this._flex.AutoResize = false;
			this._flex.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this._flex.ColumnInfo = "10,1,0,0,0,115,Columns:0{Width:38;}\t";
			this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
			this._flex.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this._flex.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this._flex.Location = new System.Drawing.Point(152, 0);
			this._flex.Name = "_flex";
			this._flex.Size = new System.Drawing.Size(616, 309);
			this._flex.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this._flex.TabIndex = 14;
			this._flex.Tag = "N";
			// 
			// _list
			// 
			this._list.Dock = System.Windows.Forms.DockStyle.Left;
			this._list.IntegralHeight = false;
			this._list.ItemHeight = 16;
			this._list.Location = new System.Drawing.Point(0, 0);
			this._list.Name = "_list";
			this._list.Size = new System.Drawing.Size(152, 309);
			this._list.TabIndex = 3;
			this._list.SelectedIndexChanged += new System.EventHandler(this._list_SelectedIndexChanged);
			// 
			// splitter1
			// 
			this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
			this.splitter1.Location = new System.Drawing.Point(0, 144);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(768, 3);
			this.splitter1.TabIndex = 1;
			this.splitter1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Moccasin;
			this.panel2.Controls.Add(this.panel6);
			this.panel2.Controls.Add(this.panel5);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(768, 144);
			this.panel2.TabIndex = 0;
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.vs);
			this.panel6.Controls.Add(this.panel8);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel6.Location = new System.Drawing.Point(0, 0);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(648, 144);
			this.panel6.TabIndex = 2;
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
			this.vs.Size = new System.Drawing.Size(364, 144);
			this.vs.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs.TabIndex = 13;
			// 
			// panel8
			// 
			this.panel8.Controls.Add(this.dt);
			this.panel8.Controls.Add(this.label1);
			this.panel8.Controls.Add(this.cmd_to);
			this.panel8.Controls.Add(this.cmd_fr);
			this.panel8.Controls.Add(this.txt_to);
			this.panel8.Controls.Add(this.txt_fr);
			this.panel8.Controls.Add(this.cmd_DWID);
			this.panel8.Controls.Add(this.cmd_WID);
			this.panel8.Controls.Add(this.txt_DWID);
			this.panel8.Controls.Add(this.txt_WID);
			this.panel8.Controls.Add(this.lb);
			this.panel8.Controls.Add(this.groupBox1);
			this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel8.Location = new System.Drawing.Point(364, 0);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(284, 144);
			this.panel8.TabIndex = 0;
			// 
			// dt
			// 
			this.dt.CustomFormat = "yyyyMM";
			this.dt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dt.Location = new System.Drawing.Point(88, 84);
			this.dt.Name = "dt";
			this.dt.Size = new System.Drawing.Size(192, 23);
			this.dt.TabIndex = 8;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 90);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 18);
			this.label1.TabIndex = 7;
			this.label1.Text = "label1";
			// 
			// cmd_to
			// 
			this.cmd_to.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_to.Location = new System.Drawing.Point(144, 56);
			this.cmd_to.Name = "cmd_to";
			this.cmd_to.Size = new System.Drawing.Size(84, 24);
			this.cmd_to.TabIndex = 12;
			this.cmd_to.Text = "button3";
			this.cmd_to.Click += new System.EventHandler(this.cmd_to_Click);
			// 
			// cmd_fr
			// 
			this.cmd_fr.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_fr.Location = new System.Drawing.Point(144, 28);
			this.cmd_fr.Name = "cmd_fr";
			this.cmd_fr.Size = new System.Drawing.Size(84, 24);
			this.cmd_fr.TabIndex = 11;
			this.cmd_fr.Text = "button2";
			this.cmd_fr.Click += new System.EventHandler(this.cmd_fr_Click);
			// 
			// txt_to
			// 
			this.txt_to.Location = new System.Drawing.Point(228, 56);
			this.txt_to.Name = "txt_to";
			this.txt_to.Size = new System.Drawing.Size(52, 23);
			this.txt_to.TabIndex = 10;
			this.txt_to.Text = "";
			// 
			// txt_fr
			// 
			this.txt_fr.Location = new System.Drawing.Point(228, 28);
			this.txt_fr.Name = "txt_fr";
			this.txt_fr.Size = new System.Drawing.Size(52, 23);
			this.txt_fr.TabIndex = 9;
			this.txt_fr.Text = "";
			// 
			// cmd_DWID
			// 
			this.cmd_DWID.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_DWID.Location = new System.Drawing.Point(4, 56);
			this.cmd_DWID.Name = "cmd_DWID";
			this.cmd_DWID.Size = new System.Drawing.Size(84, 24);
			this.cmd_DWID.TabIndex = 6;
			this.cmd_DWID.Text = "button3";
			this.cmd_DWID.Click += new System.EventHandler(this.cmd_DWID_Click);
			// 
			// cmd_WID
			// 
			this.cmd_WID.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_WID.Location = new System.Drawing.Point(4, 28);
			this.cmd_WID.Name = "cmd_WID";
			this.cmd_WID.Size = new System.Drawing.Size(84, 24);
			this.cmd_WID.TabIndex = 5;
			this.cmd_WID.Text = "button2";
			this.cmd_WID.Click += new System.EventHandler(this.cmd_WID_Click);
			// 
			// txt_DWID
			// 
			this.txt_DWID.Location = new System.Drawing.Point(88, 56);
			this.txt_DWID.Name = "txt_DWID";
			this.txt_DWID.Size = new System.Drawing.Size(52, 23);
			this.txt_DWID.TabIndex = 4;
			this.txt_DWID.Text = "";
			// 
			// txt_WID
			// 
			this.txt_WID.Location = new System.Drawing.Point(88, 28);
			this.txt_WID.Name = "txt_WID";
			this.txt_WID.Size = new System.Drawing.Size(52, 23);
			this.txt_WID.TabIndex = 2;
			this.txt_WID.Text = "";
			// 
			// lb
			// 
			this.lb.BackColor = System.Drawing.Color.LemonChiffon;
			this.lb.Dock = System.Windows.Forms.DockStyle.Top;
			this.lb.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lb.ForeColor = System.Drawing.Color.Red;
			this.lb.Location = new System.Drawing.Point(0, 0);
			this.lb.Name = "lb";
			this.lb.Size = new System.Drawing.Size(284, 24);
			this.lb.TabIndex = 0;
			this.lb.Tag = "N";
			this.lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.r2);
			this.groupBox1.Controls.Add(this.r1);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(4, 104);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(276, 40);
			this.groupBox1.TabIndex = 170;
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
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.LightSteelBlue;
			this.panel5.Controls.Add(this.cmd_del);
			this.panel5.Controls.Add(this.cmd_load);
			this.panel5.Controls.Add(this.cmd_save);
			this.panel5.Controls.Add(this.cmd_import);
			this.panel5.Controls.Add(this.button1);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel5.Location = new System.Drawing.Point(648, 0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(120, 144);
			this.panel5.TabIndex = 1;
			// 
			// cmd_del
			// 
			this.cmd_del.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_del.Location = new System.Drawing.Point(8, 116);
			this.cmd_del.Name = "cmd_del";
			this.cmd_del.Size = new System.Drawing.Size(104, 24);
			this.cmd_del.TabIndex = 4;
			this.cmd_del.Text = "button3";
			this.cmd_del.Click += new System.EventHandler(this.cmd_del_Click);
			// 
			// cmd_load
			// 
			this.cmd_load.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_load.Location = new System.Drawing.Point(8, 88);
			this.cmd_load.Name = "cmd_load";
			this.cmd_load.Size = new System.Drawing.Size(104, 24);
			this.cmd_load.TabIndex = 3;
			this.cmd_load.Text = "button3";
			this.cmd_load.Click += new System.EventHandler(this.cmd_load_Click);
			// 
			// cmd_save
			// 
			this.cmd_save.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_save.Location = new System.Drawing.Point(8, 60);
			this.cmd_save.Name = "cmd_save";
			this.cmd_save.Size = new System.Drawing.Size(104, 24);
			this.cmd_save.TabIndex = 2;
			this.cmd_save.Text = "button3";
			this.cmd_save.Click += new System.EventHandler(this.cmd_save_Click);
			// 
			// cmd_import
			// 
			this.cmd_import.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_import.Location = new System.Drawing.Point(8, 32);
			this.cmd_import.Name = "cmd_import";
			this.cmd_import.Size = new System.Drawing.Size(104, 24);
			this.cmd_import.TabIndex = 1;
			this.cmd_import.Text = "button2";
			this.cmd_import.Click += new System.EventHandler(this.cmd_import_Click);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(8, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(104, 24);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// frmTaExcel
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(768, 492);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaExcel";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmTaExcel";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmTaExcel_Load);
			this.panel3.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this._flex)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			this.panel8.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion



		private void frmTaExcel_Load(object sender, System.EventArgs e)
		{
			Init_Form();						
		}
		private void Init_Form()
		{		
			dt.Value=T_String.GetDate();
			Init_vs();			
			Basic.Function.PublicFunction.L_Init_Label(this);				
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
			vs.DoubleClick+=new System.EventHandler(vs_DoubleClick);
			_flex.DoubleClick+=new System.EventHandler(_flex_DoubleClick);
		}


		#region ** Load an XLSheet into a C1FlexGrid
		private void button1_Click(object sender, System.EventArgs e)
		{
			// choose file
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.DefaultExt = "xls";
			dlg.FileName = "*.xls";
			if (dlg.ShowDialog() != DialogResult.OK)
				return;

			// clear everything
			_book.Clear();
			_grids.Clear();
			_list.Items.Clear();

			// load book
			_book.Load(dlg.FileName);

			// create one grid per sheet and add them to listbox
			foreach (XLSheet sheet in _book.Sheets)
			{
				// add sheet name to list box
				_list.Items.Add(sheet.Name);

				// create a new grid for this sheet, add to list
				C1FlexGrid flex = new C1FlexGrid();
				flex.Name = sheet.Name;
				_grids.Add(flex);

				// load sheet into new grid
				LoadSheet(flex, sheet, true);
			}

			// select current sheet
			_list.SelectedIndex = _book.Sheets.SelectedIndex;
			txt_fr.Text=1+"";
			txt_to.Text=_flex.Rows.Count-1+"";
		}

		private void _list_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			// get the selected grid
			C1FlexGrid flex = _grids[_list.SelectedIndex] as C1FlexGrid;

			// bind it to the visible grid
			_flex.DataSource = flex;
		}

	
		
		
		Hashtable _styles;

		// load sheet into grid
		private void LoadSheet(C1FlexGrid flex, XLSheet sheet, bool fixedCells)
		{
			// account for fixed cells
			int frows = flex.Rows.Fixed;
			int fcols = flex.Cols.Fixed;

			// copy dimensions
			flex.Rows.Count = sheet.Rows.Count    + frows;
			flex.Cols.Count = sheet.Columns.Count + fcols;

			// initialize fixed cells
			if (fixedCells && frows > 0 && fcols > 0)
			{
				flex.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter;
				for (int r = 1; r < flex.Rows.Count; r++)
				{
					flex[r, 0] = r;
				}
				for (int c = 1; c < flex.Cols.Count; c++)
				{
//					string hdr = string.Format("{0}", (char)('A' + c - 1));
//					flex[0, c] = hdr;
					flex[0, c]=c;
				}
			}

			// set default properties
			flex.Font = sheet.Book.DefaultFont;
			flex.Rows.DefaultSize = C1XLBook.TwipsToPixels(sheet.DefaultRowHeight);
			flex.Cols.DefaultSize = C1XLBook.TwipsToPixels(sheet.DefaultColumnWidth);

			// prepare to convert styles
			_styles = new Hashtable();

			// set row/column properties
			for (int r = 0; r < sheet.Rows.Count; r++)
			{
				// size/visibility
				Row   fr = flex.Rows[r + frows];
				XLRow xr = sheet.Rows[r];
				if (xr.Height >= 0)
					fr.Height = C1XLBook.TwipsToPixels(xr.Height);
				fr.Visible = xr.Visible;

				// style
				CellStyle cs = StyleFromExcel(flex, xr.Style);
				if (cs != null)
				{
					//cs.DefinedElements &= ~StyleElementFlags.TextAlign; // << need to fix the grid
					fr.Style = cs;
				}
			}
			for (int c = 0; c < sheet.Columns.Count; c++)
			{
				// size/visibility
				Column   fc = flex.Cols[c + fcols];
				XLColumn xc = sheet.Columns[c];
				if (xc.Width >= 0)
					fc.Width = C1XLBook.TwipsToPixels(xc.Width);
				fc.Visible = xc.Visible;

				// style
				CellStyle cs = StyleFromExcel(flex, xc.Style);
				if (cs != null)
				{
					//cs.DefinedElements &= ~StyleElementFlags.TextAlign; // << need to fix the grid
					fc.Style = cs;
				}
			}

			// load cells
			for (int r = 0; r < sheet.Rows.Count; r++)
			{
				for (int c = 0; c < sheet.Columns.Count; c++)
				{
					// get cell
					XLCell cell = sheet.GetCell(r, c);
					if (cell == null) continue;

					// apply content
					flex[r + frows, c + fcols] = cell.Value;

					// apply style
					CellStyle cs = StyleFromExcel(flex, cell.Style);
					if (cs != null)
						flex.SetCellStyle(r + frows, c + fcols, cs);
				}
			}
		}

		// convert Excel style into FlexGrid style
		private CellStyle StyleFromExcel(C1FlexGrid flex, XLStyle style)
		{
			// sanity
			if (style == null)
				return null;

			// look it up on list
			if (_styles.Contains(style))
				return _styles[style] as CellStyle;

			// create new flex style
			CellStyle cs = flex.Styles.Add(_styles.Count.ToString());

			// set up new style
			if (style.Font != null)						cs.Font = style.Font;
			if (style.ForeColor != Color.Transparent)	cs.ForeColor = style.ForeColor;
			if (style.BackColor != Color.Transparent)	cs.BackColor = style.BackColor;
			if (style.Rotation == 90)					cs.TextDirection = TextDirectionEnum.Up;
			if (style.Rotation == 180)					cs.TextDirection = TextDirectionEnum.Down;
			if (style.Format != null && style.Format.Length > 0)
				cs.Format = XLStyle.FormatXLToDotNet(style.Format);
			switch (style.AlignHorz)
			{
				case XLAlignHorzEnum.Center:
					cs.WordWrap = style.WordWrap;
				switch (style.AlignVert)
				{
					case XLAlignVertEnum.Top:
						cs.TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterTop;
						break;
					case XLAlignVertEnum.Center:
						cs.TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter;
						break;
					default:
						cs.TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterBottom;
						break;
				}
					break;
				case XLAlignHorzEnum.Right:
					cs.WordWrap = style.WordWrap;
				switch (style.AlignVert)
				{
					case XLAlignVertEnum.Top:
						cs.TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.RightTop;
						break;
					case XLAlignVertEnum.Center:
						cs.TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.RightCenter;
						break;
					default:
						cs.TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.RightBottom;
						break;
				}
					break;
				case XLAlignHorzEnum.Left:
					cs.WordWrap = style.WordWrap;
				switch (style.AlignVert)
				{
					case XLAlignVertEnum.Top:
						cs.TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.LeftTop;
						break;
					case XLAlignVertEnum.Center:
						cs.TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.LeftCenter;
						break;
					default:
						cs.TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.LeftBottom;
						break;
				}
					break;
				default:
					cs.WordWrap = style.WordWrap;
				switch (style.AlignVert)
				{
					case XLAlignVertEnum.Top:
						cs.TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.GeneralTop;
						break;
					case XLAlignVertEnum.Center:
						cs.TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.GeneralCenter;
						break;
					default:
						cs.TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.GeneralBottom;
						break;
				}
					break;
			}
		
			// save it
			_styles.Add(style, cs);

			// return it
			return cs;
		}
		#endregion
		
		private TextBox txt=new TextBox();
		int Row=0;
		int col=0;
		private void cmd_WID_Click(object sender, System.EventArgs e)
		{
			txt=txt_WID;
			Row=0;
			lb.Text=cmd_WID.Text;
			col=1;
		}

		private void cmd_DWID_Click(object sender, System.EventArgs e)
		{
			txt=txt_DWID;
			Row=0;
			lb.Text=cmd_DWID.Text;
			col=1;
		}

		private void cmd_fr_Click(object sender, System.EventArgs e)
		{
			txt=txt_fr;
			Row=0;
			lb.Text=cmd_fr.Text;
			col=0;
		}

		private void cmd_to_Click(object sender, System.EventArgs e)
		{
			txt=txt_to;
			Row=0;
			lb.Text=cmd_to.Text;
			col=0;
		}

		private void vs_DoubleClick(object sender, System.EventArgs e)
		{
			Row=vs.Row;
			lb.Text=vs.Rows[vs.Row]["COL_"+PublicFunction.L_Lag]+"";
		}

		private void _flex_DoubleClick(object sender, System.EventArgs e)
		{
			if(Row>0)
			{
				vs.Rows[Row]["COL"]=_flex.Col;
			}
			else
			{
				if(col==1)
					txt.Text=_flex.Col+"";
				else
					txt.Text=_flex.Row+"";
			}
		}
		#region import
		frmTaExceldlg dlg;
		private void cmd_import_Click(object sender, System.EventArgs e)
		{
			if(MessageBox.Show(this,PublicFunction.L_Get_Msg("msg",211),this.Text,MessageBoxButtons.YesNo)==DialogResult.Yes)
			{
				dlg=new frmTaExceldlg();
				Thread th=new Thread(new ThreadStart(import));
				th.Start();				
				dlg.ShowDialog();
			}
		}
		private void import()
		{			
			SqlConnection con=new SqlConnection(PublicFunction.C_con.ConnectionString);
			con.Open();
			string sql="";
			int n=T_String.IsNullTo0(txt_fr.Text);
			int m=T_String.IsNullTo0(txt_to.Text);
			for(int i=n;i<=m;i++)
			{
//				try
				{
					//				sql="update FILD02A set ";
					sql="";
					if(txt_WID.Text+""!="" )						
						dlg.lb.Text= _flex.Rows[i][T_String.IsNullTo0(txt_WID.Text+"")]+" - " + i+"/"+m+" - "+ ((int)i*100/m)+"%";
					else
						dlg.lb.Text= _flex.Rows[i][T_String.IsNullTo0(txt_DWID.Text+"")]+" - " + i+"/"+m+" - "+ ((int)i*100/m)+"%";
					for(int j=1;j<vs.Rows.Count;j++)
					{
						if(vs.Rows[j]["COL"]+""!="")
						{
							if(sql!="")
								sql+=",";
							sql+="["+vs.Rows[j]["COL_NM"]+"]="+
								T_String.IsNullTo00(_flex.Rows[i][T_String.IsNullTo0(vs.Rows[j]["COL"]+"")]+"");
						}
					}
					if(sql!="")
					{
						sql="update FILD02A set "+sql+ " where YYY_MM=N'"+
							dt.Text+"' and " ;
						if(txt_WID.Text+""!="" )
							sql+="EMP_ID=N'"+_flex.Rows[i][T_String.IsNullTo0(txt_WID.Text+"")]+"'";
						else
						{
							string st=T_String.GetDataFromSQL("EMP_ID","FILF01A","EMP_I1=N'"+_flex.Rows[i][T_String.IsNullTo0(txt_DWID.Text+"")]+"'");								
							sql+="EMP_ID=N'"+st+"'";
						}
						if(r1.Checked )
							sql+=" and SEQ_NO=1";
						else
							sql+=" and SEQ_NO=2";
						try
						{
							PublicFunction.SQL_Execute(sql,con);
						}
						catch(SqlException)					
						{
							_flex.Rows[i][0]="Error";
							MessageBox.Show(sql);
						}
					}
					dlg.pro.Value=(int)i*100/m;
				}
//				catch(Exception ex)					
//				{
//					vs.Rows[i][0]="Error";
//				}
			}
			dlg.pro.Value=100;
			dlg.Close();
			con.Close();
		}
		#endregion

		private void cmd_save_Click(object sender, System.EventArgs e)
		{
			frmTaSaveExcel dlg=new frmTaSaveExcel();	
			dlg.ketqua="0";
			dlg.ketqua1=cmd_save.Text;
			dlg.Tag=this.Tag;
			if(dlg.ShowDialog()==DialogResult.OK)
			{
				string sql="";
				for(int i=1;i<vs.Rows.Count;i++)
				{
					sql="Insert into GP_EXCEL_DETAIL Values(N'"
						+dlg.txt.Text+"',N'"+vs.Rows[i]["COL_NM"]+"',N'"+vs.Rows[i]["COL"]+"')";
					PublicFunction.SQL_Execute(sql);
				}
				sql="Insert into GP_EXCEL_DETAIL Values(N'"
					+dlg.txt.Text+"',N'EMP_ID',N'"+txt_WID.Text +"')";
				PublicFunction.SQL_Execute(sql);
				sql="Insert into GP_EXCEL_DETAIL Values(N'"
					+dlg.txt.Text+"',N'EMP_I1',N'"+txt_DWID.Text+"')";
				PublicFunction.SQL_Execute(sql);				
			}
		}

		private void cmd_load_Click(object sender, System.EventArgs e)
		{
			frmTaSaveExcel dlg=new frmTaSaveExcel();
			dlg.ketqua="1";
			dlg.ketqua1=cmd_load.Text;
			dlg.Tag=this.Tag;
			if(dlg.ShowDialog()==DialogResult.OK)
			{
				for(int i=1;i<vs.Rows.Count;i++)
				{
					vs.Rows[i]["COL"]=T_String.GetDataFromSQL("COL_ID","GP_EXCEL_DETAIL","EXC_ID=N'"+dlg.ketqua+"' and "
						+" COL_NM=N'"+vs.Rows[i]["COL_NM"]+"'");
				}
				txt_WID.Text=T_String.GetDataFromSQL("COL_ID","GP_EXCEL_DETAIL","EXC_ID=N'"+dlg.ketqua+"' and "
					+" COL_NM=N'EMP_ID'");
				txt_DWID.Text=T_String.GetDataFromSQL("COL_ID","GP_EXCEL_DETAIL","EXC_ID=N'"+dlg.ketqua+"' and "
					+" COL_NM=N'EMP_I1'");
			}
		}

		private void cmd_del_Click(object sender, System.EventArgs e)
		{
			if(Row>0)
			{
				vs.Rows[Row]["COL"]="";
			}
			else
			{
				if(col==1)
					txt.Text="";
				else
					txt.Text="";
			}
		}


	}
}

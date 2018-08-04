using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Basic.Form;
using Basic.Function;
using System.Data;
using System.Data.SqlClient;
namespace GP8000.Database
{
	/// <summary>
	/// Summary description for frmTaNationality.
	/// </summary>
	public class frmTaNationality_Toilet : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel4;
		private Navigator1._0.NavigatorAuto nav;
		private C1.Win.C1FlexGrid.C1FlexGrid vs;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.CheckBox ck;
		private System.Windows.Forms.TextBox txt2;
		private System.Windows.Forms.TextBox txt1;
		private C1.Win.C1Input.C1DateEdit dt1;
		private C1.Win.C1Input.C1DateEdit dt2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button cmd_un;
		private System.Windows.Forms.Button cmd_cal;
		private System.Windows.Forms.Button cmd_edit;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaNationality_Toilet()
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
			this.panel4 = new System.Windows.Forms.Panel();
			this.nav = new Navigator1._0.NavigatorAuto();
			this.vs = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cmd_un = new System.Windows.Forms.Button();
			this.cmd_cal = new System.Windows.Forms.Button();
			this.cmd_edit = new System.Windows.Forms.Button();
			this.ck = new System.Windows.Forms.CheckBox();
			this.txt2 = new System.Windows.Forms.TextBox();
			this.txt1 = new System.Windows.Forms.TextBox();
			this.dt1 = new C1.Win.C1Input.C1DateEdit();
			this.dt2 = new C1.Win.C1Input.C1DateEdit();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dt1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dt2)).BeginInit();
			this.SuspendLayout();
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
			this.panel3.Size = new System.Drawing.Size(892, 36);
			this.panel3.TabIndex = 20;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Location = new System.Drawing.Point(416, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(476, 36);
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
			// vs
			// 
			this.vs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.vs.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vs.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs.Location = new System.Drawing.Point(4, 64);
			this.vs.Name = "vs";
			this.vs.Size = new System.Drawing.Size(884, 436);
			this.vs.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs.TabIndex = 21;
			this.vs.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.vs_AfterEdit);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.cmd_un);
			this.panel1.Controls.Add(this.cmd_cal);
			this.panel1.Controls.Add(this.cmd_edit);
			this.panel1.Controls.Add(this.ck);
			this.panel1.Controls.Add(this.txt2);
			this.panel1.Controls.Add(this.txt1);
			this.panel1.Controls.Add(this.dt1);
			this.panel1.Controls.Add(this.dt2);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.vs);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 36);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(892, 502);
			this.panel1.TabIndex = 22;
			// 
			// cmd_un
			// 
			this.cmd_un.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmd_un.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_un.Location = new System.Drawing.Point(652, 8);
			this.cmd_un.Name = "cmd_un";
			this.cmd_un.Size = new System.Drawing.Size(108, 24);
			this.cmd_un.TabIndex = 156;
			this.cmd_un.Text = "Unedit";
			this.cmd_un.Visible = false;
			this.cmd_un.Click += new System.EventHandler(this.cmd_un_Click);
			// 
			// cmd_cal
			// 
			this.cmd_cal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmd_cal.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_cal.Location = new System.Drawing.Point(768, 8);
			this.cmd_cal.Name = "cmd_cal";
			this.cmd_cal.Size = new System.Drawing.Size(108, 24);
			this.cmd_cal.TabIndex = 155;
			this.cmd_cal.Text = "Cal";
			this.cmd_cal.Visible = false;
			this.cmd_cal.Click += new System.EventHandler(this.cmd_cal_Click);
			// 
			// cmd_edit
			// 
			this.cmd_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmd_edit.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_edit.Location = new System.Drawing.Point(540, 8);
			this.cmd_edit.Name = "cmd_edit";
			this.cmd_edit.Size = new System.Drawing.Size(108, 24);
			this.cmd_edit.TabIndex = 154;
			this.cmd_edit.Text = "Edit";
			this.cmd_edit.Click += new System.EventHandler(this.cmd_edit_Click);
			// 
			// ck
			// 
			this.ck.Checked = true;
			this.ck.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ck.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ck.Location = new System.Drawing.Point(20, 8);
			this.ck.Name = "ck";
			this.ck.Size = new System.Drawing.Size(20, 16);
			this.ck.TabIndex = 153;
			this.ck.Tag = "N";
			// 
			// txt2
			// 
			this.txt2.BackColor = System.Drawing.Color.PeachPuff;
			this.txt2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt2.Location = new System.Drawing.Point(204, 32);
			this.txt2.MaxLength = 20;
			this.txt2.Name = "txt2";
			this.txt2.Size = new System.Drawing.Size(96, 23);
			this.txt2.TabIndex = 152;
			this.txt2.Tag = "EMP_I1";
			this.txt2.Text = "";
			// 
			// txt1
			// 
			this.txt1.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt1.Location = new System.Drawing.Point(204, 4);
			this.txt1.MaxLength = 20;
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(96, 23);
			this.txt1.TabIndex = 151;
			this.txt1.Tag = "EMP_ID";
			this.txt1.Text = "";
			this.txt1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt1_KeyDown);
			// 
			// dt1
			// 
			this.dt1.CustomFormat = "dd/MM/yyyy";
			this.dt1.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt1.Location = new System.Drawing.Point(84, 4);
			this.dt1.Name = "dt1";
			this.dt1.Size = new System.Drawing.Size(120, 23);
			this.dt1.TabIndex = 150;
			this.dt1.Tag = null;
			// 
			// dt2
			// 
			this.dt2.CustomFormat = "dd/MM/yyyy";
			this.dt2.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt2.Location = new System.Drawing.Point(84, 32);
			this.dt2.Name = "dt2";
			this.dt2.Size = new System.Drawing.Size(120, 23);
			this.dt2.TabIndex = 148;
			this.dt2.Tag = null;
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label4.Location = new System.Drawing.Point(40, 4);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 23);
			this.label4.TabIndex = 149;
			this.label4.Tag = "";
			this.label4.Text = "date";
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label1.Location = new System.Drawing.Point(40, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 23);
			this.label1.TabIndex = 147;
			this.label1.Tag = "";
			this.label1.Text = "date";
			// 
			// frmTaNationality_Toilet
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(892, 538);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaNationality_Toilet";
			this.Text = "frmTaNationality_Toilet";
			this.Load += new System.EventHandler(this.frmTaNationality_Toilet_Load);
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dt1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dt2)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaNationality_Toilet_Load(object sender, System.EventArgs e)
		{
			//an nav
			nav.cmd_search.Visible=false;
			nav.cmd_copy.Visible=false;
			nav.cmd_delete.Visible=false;
			nav.cmd_save.Visible=false;
			nav.cmd_add.Visible=false;
			nav.cmd_report.Visible=false;
			PublicFunction.InitNav(this,vs,nav);	
			nav.Msg_ExitSave=true;
			//nav.Show_VS();			
							
			nav.ToolBar_Auto=false;
			Basic.Function.PublicFunction.L_Init_Label(this);	
			nav.TBarClick+=new ToolBarButtonClickEventHandler(nav_TBarClick);
			Show_VS();
			//khoa sua
			for (int i = 7; i <= 26; i++)
			{
				vs.Cols[i].AllowEditing = false;
			}
			//lay ngay hien tai
			dt1.Value=dt2.Value=T_String.GetDate();
		}	
		private void Show_VS()
		{
			//dinh dang gio
			for(int i=1;i<=10;i++)
			{
				vs.Cols["ONN_"+i.ToString("00")].Format="#0:00";
				vs.Cols["OFF_"+i.ToString("00")].Format="#0:00";
			}	
			vs.Cols["SUM_TM"].Format="#0:00";
			vs.Cols["ATT_DT"].DataType = typeof(DateTime);
			vs.Cols["NOT_DR"].Width=150;			
		}
		
		private void nav_TBarClick(object sender, ToolBarButtonClickEventArgs e)
		{					
			if (e.Button.Equals(nav.cmd_add))
			{
				if (vs.Rows.Count==1 || (int)vs.Rows[vs.Rows.Count-1].UserData!=2)					
					nav.ToolBar_Click(e);									
				vs.Rows[vs.Rows.Count-1]["COU_ID"]=T_String.GetMax("MAX(COU_ID)","FILA12A").ToString("000");
				return;
			}
			if (e.Button.Equals(nav.cmd_delete ))
			{
				if( T_String.IsNullTo0(T_String.GetDataFromSQL("Count(EMP_ID)","FILB01A",vs.Cols[2].Name+"=N'"+vs.Rows[vs.Row ][2]+"' "))>0)
				{
					MessageBox.Show(PublicFunction.L_Get_Msg("msg",217));
					 
					return;
				}
			}
			nav.ToolBar_Click(e);
		}

		private void txt1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				if(txt1.Text=="")
				{
					string sql="ONN_01>0 and a.EMP_ID is not null and a.EMP_ID<>'' and (ATT_DT Between '"
						+((DateTime)dt1.Value).ToString("yyyy/MM/dd")+"' and '"
						+((DateTime)dt2.Value).ToString("yyyy/MM/dd")+"') order by a.EMP_ID,ATT_DT";			
					nav.Show_VS(sql);	
					Show_VS();
				}
				else
				{
					string sql="ONN_01>0 and a.EMP_ID is not null and a.EMP_ID<>'' and (ATT_DT Between '"
						+((DateTime)dt1.Value).ToString("yyyy/MM/dd")+"' and '"
						+((DateTime)dt2.Value).ToString("yyyy/MM/dd")+"' and a.EMP_ID='"+txt1.Text+"') order by a.EMP_ID,ATT_DT";			
					nav.Show_VS(sql);	
					Show_VS();
				}              
			}
		}

		private void cmd_edit_Click(object sender, System.EventArgs e)
		{
			cmd_un.Visible=!cmd_un.Visible;			
			cmd_edit.Visible=!cmd_edit.Visible;
			cmd_cal.Visible=!cmd_cal.Visible;
			//Mo len cho sua
			for (int i = 7; i <= 26; i++)
			{
				vs.Cols[i].AllowEditing = true;
			}
		}

		private void cmd_cal_Click(object sender, System.EventArgs e)
		{
			DateTime d1 = (DateTime)dt1.Value;
			DateTime d2 = (DateTime)dt2.Value;
			if (MessageBox.Show(this,PublicFunction.L_Get_Msg("msg",78), "Thông Báo!", MessageBoxButtons.YesNo)==DialogResult.No)
				return;
			for (int n = 1; n < vs.Rows.Count; n++)
			{
//				int vs1 = T_String.IsNullTo0(T_String.GetDataFromSQL("(LEFT(OFF_01,LEN(OFF_01)-2)*60+RIGHT(OFF_01,2))-(LEFT(ONN_01,LEN(ONN_01)-2)*60+RIGHT(ONN_01,2))", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[n]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[n]["ATT_DT"]).ToString("yyyy/MM/dd")+ "" + "')", PublicFunction.C_con));//- (LEFT(ONN_01,2)*60+RIGHT(ONN_01,2))/60
//				int vs2 = T_String.IsNullTo0(T_String.GetDataFromSQL("(LEFT(OFF_02,LEN(OFF_02)-2)*60+RIGHT(OFF_02,2))-(LEFT(ONN_02,LEN(ONN_02)-2)*60+RIGHT(ONN_02,2))", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[n]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[n]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));				
//				int vs3 = T_String.IsNullTo0(T_String.GetDataFromSQL("(LEFT(OFF_03,LEN(OFF_03)-2)*60+RIGHT(OFF_03,2))-(LEFT(ONN_03,LEN(ONN_03)-2)*60+RIGHT(ONN_03,2))", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[n]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[n]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));				
//				int vs4 = T_String.IsNullTo0(T_String.GetDataFromSQL("(LEFT(OFF_04,LEN(OFF_04)-2)*60+RIGHT(OFF_04,2))-(LEFT(ONN_04,LEN(ONN_04)-2)*60+RIGHT(ONN_04,2))", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[n]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[n]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));				
//				int vs5 = T_String.IsNullTo0(T_String.GetDataFromSQL("(LEFT(OFF_05,LEN(OFF_05)-2)*60+RIGHT(OFF_05,2))-(LEFT(ONN_05,LEN(ONN_05)-2)*60+RIGHT(ONN_05,2))", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[n]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[n]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));				
//				int vs6 = T_String.IsNullTo0(T_String.GetDataFromSQL("(LEFT(OFF_06,LEN(OFF_06)-2)*60+RIGHT(OFF_06,2))-(LEFT(ONN_06,LEN(ONN_06)-2)*60+RIGHT(ONN_06,2))", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[n]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[n]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));				
//				int vs7 = T_String.IsNullTo0(T_String.GetDataFromSQL("(LEFT(OFF_07,LEN(OFF_07)-2)*60+RIGHT(OFF_07,2))-(LEFT(ONN_07,LEN(ONN_07)-2)*60+RIGHT(ONN_07,2))", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[n]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[n]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));				
//				int vs8 = T_String.IsNullTo0(T_String.GetDataFromSQL("(LEFT(OFF_08,LEN(OFF_08)-2)*60+RIGHT(OFF_08,2))-(LEFT(ONN_08,LEN(ONN_08)-2)*60+RIGHT(ONN_08,2))", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[n]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[n]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));				
//				int vs9 = T_String.IsNullTo0(T_String.GetDataFromSQL("(LEFT(OFF_09,LEN(OFF_09)-2)*60+RIGHT(OFF_09,2))-(LEFT(ONN_09,LEN(ONN_09)-2)*60+RIGHT(ONN_09,2))", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[n]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[n]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));				
//				int vs10 = T_String.IsNullTo0(T_String.GetDataFromSQL("(LEFT(OFF_10,LEN(OFF_10)-2)*60+RIGHT(OFF_10,2))-(LEFT(ONN_10,LEN(ONN_10)-2)*60+RIGHT(ONN_10,2))", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[n]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[n]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));

				int vs1=0,vs2=0,vs3=0,vs4=0,vs5=0,vs6=0,vs7=0,vs8=0,vs9=0,vs10=0;
				int ONN_01=T_String.IsNullTo0(vs.Rows[n]["ONN_01"]+"");
				int ONN_02=T_String.IsNullTo0(vs.Rows[n]["ONN_02"]+"");
				int ONN_03=T_String.IsNullTo0(vs.Rows[n]["ONN_03"]+"");
				int ONN_04=T_String.IsNullTo0(vs.Rows[n]["ONN_04"]+"");
				int ONN_05=T_String.IsNullTo0(vs.Rows[n]["ONN_05"]+"");
				int ONN_06=T_String.IsNullTo0(vs.Rows[n]["ONN_06"]+"");
				int ONN_07=T_String.IsNullTo0(vs.Rows[n]["ONN_07"]+"");
				int ONN_08=T_String.IsNullTo0(vs.Rows[n]["ONN_08"]+"");
				int ONN_09=T_String.IsNullTo0(vs.Rows[n]["ONN_09"]+"");
				int ONN_10=T_String.IsNullTo0(vs.Rows[n]["ONN_10"]+"");

				int OFF_01=T_String.IsNullTo0(vs.Rows[n]["OFF_01"]+"");
				int OFF_02=T_String.IsNullTo0(vs.Rows[n]["OFF_02"]+"");
				int OFF_03=T_String.IsNullTo0(vs.Rows[n]["OFF_03"]+"");
				int OFF_04=T_String.IsNullTo0(vs.Rows[n]["OFF_04"]+"");
				int OFF_05=T_String.IsNullTo0(vs.Rows[n]["OFF_05"]+"");
				int OFF_06=T_String.IsNullTo0(vs.Rows[n]["OFF_06"]+"");
				int OFF_07=T_String.IsNullTo0(vs.Rows[n]["OFF_07"]+"");
				int OFF_08=T_String.IsNullTo0(vs.Rows[n]["OFF_08"]+"");
				int OFF_09=T_String.IsNullTo0(vs.Rows[n]["OFF_09"]+"");
				int OFF_10=T_String.IsNullTo0(vs.Rows[n]["OFF_10"]+"");

				if(ONN_01!=0 && OFF_01!=0)
					vs1 = T_String.IsNullTo0(T_String.GetDataFromSQL(" (LEFT(OFF_01,LEN(OFF_01)-2)*60+RIGHT(OFF_01,2))-(LEFT(ONN_01,LEN(ONN_01)-2)*60+RIGHT(ONN_01,2)) ", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[n]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[n]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));
				else
					vs1 = T_String.IsNullTo0(T_String.GetDataFromSQL(" OFF_01-ONN_01 ", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[n]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[n]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));
				if(ONN_02!=0 && OFF_02!=0)
					vs2 = T_String.IsNullTo0(T_String.GetDataFromSQL(" (LEFT(OFF_02,LEN(OFF_02)-2)*60+RIGHT(OFF_02,2))-(LEFT(ONN_02,LEN(ONN_02)-2)*60+RIGHT(ONN_02,2)) ", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[n]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[n]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));	
				else
					vs2 = T_String.IsNullTo0(T_String.GetDataFromSQL(" OFF_02-ONN_02 ", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[n]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[n]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));	
				if(ONN_03!=0 && OFF_03!=0)
					vs3 = T_String.IsNullTo0(T_String.GetDataFromSQL(" (LEFT(OFF_03,LEN(OFF_03)-2)*60+RIGHT(OFF_03,2))-(LEFT(ONN_03,LEN(ONN_03)-2)*60+RIGHT(ONN_03,2)) ", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[n]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[n]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));
				else
					vs3 = T_String.IsNullTo0(T_String.GetDataFromSQL(" OFF_03-ONN_03 ", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[n]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[n]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));		
				if(ONN_04!=0 && OFF_04!=0)
					vs4 = T_String.IsNullTo0(T_String.GetDataFromSQL(" (LEFT(OFF_04,LEN(OFF_04)-2)*60+RIGHT(OFF_04,2))-(LEFT(ONN_04,LEN(ONN_04)-2)*60+RIGHT(ONN_04,2)) ", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[n]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[n]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));	
				else
					vs4 = T_String.IsNullTo0(T_String.GetDataFromSQL(" OFF_04-ONN_04 ", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[n]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[n]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));	
				if(ONN_05!=0 && OFF_05!=0)
					vs5 = T_String.IsNullTo0(T_String.GetDataFromSQL(" (LEFT(OFF_05,LEN(OFF_05)-2)*60+RIGHT(OFF_05,2))-(LEFT(ONN_05,LEN(ONN_05)-2)*60+RIGHT(ONN_05,2)) ", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[n]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[n]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));	
				else
					vs5 = T_String.IsNullTo0(T_String.GetDataFromSQL(" OFF_05-ONN_05 ", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[n]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[n]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));	
				if(ONN_06!=0 && OFF_06!=0)
					vs6 = T_String.IsNullTo0(T_String.GetDataFromSQL(" (LEFT(OFF_06,LEN(OFF_06)-2)*60+RIGHT(OFF_06,2))-(LEFT(ONN_06,LEN(ONN_06)-2)*60+RIGHT(ONN_06,2)) ", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[n]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[n]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));
				else
					vs6 = T_String.IsNullTo0(T_String.GetDataFromSQL(" OFF_06-ONN_06 ", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[n]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[n]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));		
				if(ONN_07!=0 && OFF_07!=0)
					vs7 = T_String.IsNullTo0(T_String.GetDataFromSQL(" (LEFT(OFF_07,LEN(OFF_07)-2)*60+RIGHT(OFF_07,2))-(LEFT(ONN_07,LEN(ONN_07)-2)*60+RIGHT(ONN_07,2)) ", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[n]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[n]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));	
				else
					vs7 = T_String.IsNullTo0(T_String.GetDataFromSQL(" OFF_07-ONN_07 ", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[n]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[n]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));	
				if(ONN_08!=0 && OFF_08!=0)
					vs8 = T_String.IsNullTo0(T_String.GetDataFromSQL(" (LEFT(OFF_08,LEN(OFF_08)-2)*60+RIGHT(OFF_08,2))-(LEFT(ONN_08,LEN(ONN_08)-2)*60+RIGHT(ONN_08,2)) ", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[n]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[n]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));	
				else
					vs8 = T_String.IsNullTo0(T_String.GetDataFromSQL(" OFF_08-ONN_08 ", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[n]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[n]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));	
				if(ONN_09!=0 && OFF_09!=0)
					vs9 = T_String.IsNullTo0(T_String.GetDataFromSQL(" (LEFT(OFF_09,LEN(OFF_09)-2)*60+RIGHT(OFF_09,2))-(LEFT(ONN_09,LEN(ONN_09)-2)*60+RIGHT(ONN_09,2)) ", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[n]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[n]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));	
				else
					vs9 = T_String.IsNullTo0(T_String.GetDataFromSQL(" OFF_09-ONN_09 ", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[n]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[n]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));	
				if(ONN_10!=0 && OFF_10!=0)
					vs10 = T_String.IsNullTo0(T_String.GetDataFromSQL(" (LEFT(OFF_10,LEN(OFF_10)-2)*60+RIGHT(OFF_10,2))-(LEFT(ONN_10,LEN(ONN_10)-2)*60+RIGHT(ONN_10,2)) ", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[n]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[n]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));
				else
					vs10 = T_String.IsNullTo0(T_String.GetDataFromSQL(" OFF_10-ONN_10 ", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[n]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[n]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));	

				if (vs1 < 0 || vs2 < 0 ||vs3 < 0 ||vs4 < 0 ||vs5 < 0 ||vs6 < 0 ||vs7 < 0 ||vs8 < 0 ||vs9 < 0 ||vs10 < 0 )
				{
					vs.Rows[n]["NOT_DR"] = "Abnormal;";
					vs.Rows[n]["SUM_TM"] =0;
				}
				else
				{
					int giotong=vs1 + vs2 + vs3 + vs4 + vs5 + vs6 + vs7 + vs8 + vs9 + vs10;
					int gio=giotong/60;
					//vs.Rows[n]["SUM_TM"] = vs1 + vs2 + vs3 + vs4 + vs5 + vs6 + vs7 + vs8 + vs9 + vs10;
					if(giotong>=60)
						giotong=giotong+(100*gio)-60*gio;
					vs.Rows[n]["SUM_TM"] =giotong;
				}
				string capnhattinh = "Update FILC06A_VS Set ONN_01=" + vs.Rows[n]["ONN_01"] + ",OFF_01=" + vs.Rows[n]["OFF_01"] + 
				",ONN_02=" + vs.Rows[n]["ONN_02"] + ",OFF_02=" + vs.Rows[n]["OFF_02"] + 
				",ONN_03=" + vs.Rows[n]["ONN_03"] + ",OFF_03=" + vs.Rows[n]["OFF_03"] + 
				",ONN_04=" + vs.Rows[n]["ONN_04"] + ",OFF_04=" + vs.Rows[n]["OFF_04"] + 
				",ONN_05=" + vs.Rows[n]["ONN_05"] + ",OFF_05=" + vs.Rows[n]["OFF_05"] + 
				",ONN_06=" + vs.Rows[n]["ONN_06"] + ",OFF_06=" + vs.Rows[n]["OFF_06"] + 
				",ONN_07=" + vs.Rows[n]["ONN_07"] + ",OFF_07=" + vs.Rows[n]["OFF_07"] +
				",ONN_08=" + vs.Rows[n]["ONN_08"] + ",OFF_08=" + vs.Rows[n]["OFF_08"] +
				",ONN_09=" + vs.Rows[n]["ONN_09"] + ",OFF_09=" + vs.Rows[n]["OFF_09"] +
				",ONN_10=" + vs.Rows[n]["ONN_10"] + ",OFF_10=" + vs.Rows[n]["OFF_10"] +
				",NOT_DR='" + vs.Rows[n]["NOT_DR"] + "',SUM_TM=" + vs.Rows[n]["SUM_TM"] + 
				" Where (LCK_BT=0 or LCK_BT is null) and  EMP_ID = '" + vs.Rows[n]["EMP_ID"] + "" + "' and ATT_DT = '"+Convert.ToDateTime(vs.Rows[n]["ATT_DT"]).ToString("yyyy/MM/dd")+ "'  ";
				PublicFunction.SQL_Execute(capnhattinh);
			}
			MessageBox.Show("Finish!");
			cmd_un.Visible=!cmd_un.Visible;			
			cmd_edit.Visible=!cmd_edit.Visible;
			cmd_cal.Visible=!cmd_cal.Visible;
			//Khoa lai khi sua xong
			for (int i = 7; i <= 26; i++)
			{
				vs.Cols[i].AllowEditing = false;
			}
		}

		private void cmd_un_Click(object sender, System.EventArgs e)
		{
			cmd_un.Visible=!cmd_un.Visible;			
			cmd_edit.Visible=!cmd_edit.Visible;
			cmd_cal.Visible=!cmd_cal.Visible;
			//Khoa sua
			for (int i = 7; i <= 26; i++)
			{
				vs.Cols[i].AllowEditing = false;
			}
		}

		private void vs_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			string capnhat = "Update FILC06A_VS Set ONN_01=" + vs.Rows[vs.Row]["ONN_01"] + ",OFF_01=" + vs.Rows[vs.Row]["OFF_01"] + 
			",ONN_02=" + vs.Rows[vs.Row]["ONN_02"] + ",OFF_02=" + vs.Rows[vs.Row]["OFF_02"] + 
			",ONN_03=" + vs.Rows[vs.Row]["ONN_03"] + ",OFF_03=" + vs.Rows[vs.Row]["OFF_03"] + 
			",ONN_04=" + vs.Rows[vs.Row]["ONN_04"] + ",OFF_04=" + vs.Rows[vs.Row]["OFF_04"] + 
			",ONN_05=" + vs.Rows[vs.Row]["ONN_05"] + ",OFF_05=" + vs.Rows[vs.Row]["OFF_05"] + 
			",ONN_06=" + vs.Rows[vs.Row]["ONN_06"] + ",OFF_06=" + vs.Rows[vs.Row]["OFF_06"] + 
			",ONN_07=" + vs.Rows[vs.Row]["ONN_07"] + ",OFF_07=" + vs.Rows[vs.Row]["OFF_07"] +
			",ONN_08=" + vs.Rows[vs.Row]["ONN_08"] + ",OFF_08=" + vs.Rows[vs.Row]["OFF_08"] +
			",ONN_09=" + vs.Rows[vs.Row]["ONN_09"] + ",OFF_09=" + vs.Rows[vs.Row]["OFF_09"] +
			",ONN_10=" + vs.Rows[vs.Row]["ONN_10"] + ",OFF_10=" + vs.Rows[vs.Row]["OFF_10"] +
			" Where (EMP_ID = '" + vs.Rows[vs.Row]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[vs.Row]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')";
			PublicFunction.SQL_Execute(capnhat);

//			int vs1 = T_String.IsNullTo0(T_String.GetDataFromSQL(" (LEFT(OFF_01,LEN(OFF_01)-2)*60+RIGHT(OFF_01,2))-(LEFT(ONN_01,LEN(ONN_01)-2)*60+RIGHT(ONN_01,2)) ", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[vs.Row]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[vs.Row]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));
//			int vs2 = T_String.IsNullTo0(T_String.GetDataFromSQL(" (LEFT(OFF_02,LEN(OFF_02)-2)*60+RIGHT(OFF_02,2))-(LEFT(ONN_02,LEN(ONN_02)-2)*60+RIGHT(ONN_02,2)) ", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[vs.Row]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[vs.Row]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));				
//			int vs3 = T_String.IsNullTo0(T_String.GetDataFromSQL(" (LEFT(OFF_03,LEN(OFF_03)-2)*60+RIGHT(OFF_03,2))-(LEFT(ONN_03,LEN(ONN_03)-2)*60+RIGHT(ONN_03,2)) ", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[vs.Row]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[vs.Row]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));				
//			int vs4 = T_String.IsNullTo0(T_String.GetDataFromSQL(" (LEFT(OFF_04,LEN(OFF_04)-2)*60+RIGHT(OFF_04,2))-(LEFT(ONN_04,LEN(ONN_04)-2)*60+RIGHT(ONN_04,2)) ", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[vs.Row]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[vs.Row]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));				
//			int vs5 = T_String.IsNullTo0(T_String.GetDataFromSQL(" (LEFT(OFF_05,LEN(OFF_05)-2)*60+RIGHT(OFF_05,2))-(LEFT(ONN_05,LEN(ONN_05)-2)*60+RIGHT(ONN_05,2)) ", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[vs.Row]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[vs.Row]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));				
//			int vs6 = T_String.IsNullTo0(T_String.GetDataFromSQL(" (LEFT(OFF_06,LEN(OFF_06)-2)*60+RIGHT(OFF_06,2))-(LEFT(ONN_06,LEN(ONN_06)-2)*60+RIGHT(ONN_06,2)) ", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[vs.Row]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[vs.Row]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));				
//			int vs7 = T_String.IsNullTo0(T_String.GetDataFromSQL(" (LEFT(OFF_07,LEN(OFF_07)-2)*60+RIGHT(OFF_07,2))-(LEFT(ONN_07,LEN(ONN_07)-2)*60+RIGHT(ONN_07,2)) ", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[vs.Row]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[vs.Row]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));				
//			int vs8 = T_String.IsNullTo0(T_String.GetDataFromSQL(" (LEFT(OFF_08,LEN(OFF_08)-2)*60+RIGHT(OFF_08,2))-(LEFT(ONN_08,LEN(ONN_08)-2)*60+RIGHT(ONN_08,2)) ", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[vs.Row]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[vs.Row]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));				
//			int vs9 = T_String.IsNullTo0(T_String.GetDataFromSQL(" (LEFT(OFF_09,LEN(OFF_09)-2)*60+RIGHT(OFF_09,2))-(LEFT(ONN_09,LEN(ONN_09)-2)*60+RIGHT(ONN_09,2)) ", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[vs.Row]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[vs.Row]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));				
//			int vs10 = T_String.IsNullTo0(T_String.GetDataFromSQL(" (LEFT(OFF_10,LEN(OFF_10)-2)*60+RIGHT(OFF_10,2))-(LEFT(ONN_10,LEN(ONN_10)-2)*60+RIGHT(ONN_10,2)) ", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[vs.Row]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[vs.Row]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));

			int vs1=0,vs2=0,vs3=0,vs4=0,vs5=0,vs6=0,vs7=0,vs8=0,vs9=0,vs10=0;
			int ONN_01=T_String.IsNullTo0(vs.Rows[vs.Row]["ONN_01"]+"");
			int ONN_02=T_String.IsNullTo0(vs.Rows[vs.Row]["ONN_02"]+"");
			int ONN_03=T_String.IsNullTo0(vs.Rows[vs.Row]["ONN_03"]+"");
			int ONN_04=T_String.IsNullTo0(vs.Rows[vs.Row]["ONN_04"]+"");
			int ONN_05=T_String.IsNullTo0(vs.Rows[vs.Row]["ONN_05"]+"");
			int ONN_06=T_String.IsNullTo0(vs.Rows[vs.Row]["ONN_06"]+"");
			int ONN_07=T_String.IsNullTo0(vs.Rows[vs.Row]["ONN_07"]+"");
			int ONN_08=T_String.IsNullTo0(vs.Rows[vs.Row]["ONN_08"]+"");
			int ONN_09=T_String.IsNullTo0(vs.Rows[vs.Row]["ONN_09"]+"");
			int ONN_10=T_String.IsNullTo0(vs.Rows[vs.Row]["ONN_10"]+"");

			int OFF_01=T_String.IsNullTo0(vs.Rows[vs.Row]["OFF_01"]+"");
			int OFF_02=T_String.IsNullTo0(vs.Rows[vs.Row]["OFF_02"]+"");
			int OFF_03=T_String.IsNullTo0(vs.Rows[vs.Row]["OFF_03"]+"");
			int OFF_04=T_String.IsNullTo0(vs.Rows[vs.Row]["OFF_04"]+"");
			int OFF_05=T_String.IsNullTo0(vs.Rows[vs.Row]["OFF_05"]+"");
			int OFF_06=T_String.IsNullTo0(vs.Rows[vs.Row]["OFF_06"]+"");
			int OFF_07=T_String.IsNullTo0(vs.Rows[vs.Row]["OFF_07"]+"");
			int OFF_08=T_String.IsNullTo0(vs.Rows[vs.Row]["OFF_08"]+"");
			int OFF_09=T_String.IsNullTo0(vs.Rows[vs.Row]["OFF_09"]+"");
			int OFF_10=T_String.IsNullTo0(vs.Rows[vs.Row]["OFF_10"]+"");

			if(ONN_01!=0 && OFF_01!=0)
				vs1 = T_String.IsNullTo0(T_String.GetDataFromSQL(" (LEFT(OFF_01,LEN(OFF_01)-2)*60+RIGHT(OFF_01,2))-(LEFT(ONN_01,LEN(ONN_01)-2)*60+RIGHT(ONN_01,2)) ", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[vs.Row]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[vs.Row]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));
			else
				vs1 = T_String.IsNullTo0(T_String.GetDataFromSQL(" OFF_01-ONN_01 ", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[vs.Row]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[vs.Row]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));
			if(ONN_02!=0 && OFF_02!=0)
				vs2 = T_String.IsNullTo0(T_String.GetDataFromSQL(" (LEFT(OFF_02,LEN(OFF_02)-2)*60+RIGHT(OFF_02,2))-(LEFT(ONN_02,LEN(ONN_02)-2)*60+RIGHT(ONN_02,2)) ", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[vs.Row]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[vs.Row]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));	
			else
				vs2 = T_String.IsNullTo0(T_String.GetDataFromSQL(" OFF_02-ONN_02 ", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[vs.Row]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[vs.Row]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));	
			if(ONN_03!=0)
				vs3 = T_String.IsNullTo0(T_String.GetDataFromSQL(" (LEFT(OFF_03,LEN(OFF_03)-2)*60+RIGHT(OFF_03,2))-(LEFT(ONN_03,LEN(ONN_03)-2)*60+RIGHT(ONN_03,2)) ", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[vs.Row]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[vs.Row]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));
			else
				vs3 = T_String.IsNullTo0(T_String.GetDataFromSQL(" OFF_03-ONN_03 ", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[vs.Row]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[vs.Row]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));		
			if(ONN_04!=0)
				vs4 = T_String.IsNullTo0(T_String.GetDataFromSQL(" (LEFT(OFF_04,LEN(OFF_04)-2)*60+RIGHT(OFF_04,2))-(LEFT(ONN_04,LEN(ONN_04)-2)*60+RIGHT(ONN_04,2)) ", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[vs.Row]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[vs.Row]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));	
			else
				vs4 = T_String.IsNullTo0(T_String.GetDataFromSQL(" OFF_04-ONN_04 ", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[vs.Row]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[vs.Row]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));	
			if(ONN_05!=0)
				vs5 = T_String.IsNullTo0(T_String.GetDataFromSQL(" (LEFT(OFF_05,LEN(OFF_05)-2)*60+RIGHT(OFF_05,2))-(LEFT(ONN_05,LEN(ONN_05)-2)*60+RIGHT(ONN_05,2)) ", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[vs.Row]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[vs.Row]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));	
			else
				vs5 = T_String.IsNullTo0(T_String.GetDataFromSQL(" OFF_05-ONN_05 ", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[vs.Row]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[vs.Row]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));	
			if(ONN_06!=0)
				vs6 = T_String.IsNullTo0(T_String.GetDataFromSQL(" (LEFT(OFF_06,LEN(OFF_06)-2)*60+RIGHT(OFF_06,2))-(LEFT(ONN_06,LEN(ONN_06)-2)*60+RIGHT(ONN_06,2)) ", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[vs.Row]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[vs.Row]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));
			else
				vs6 = T_String.IsNullTo0(T_String.GetDataFromSQL(" OFF_06-ONN_06 ", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[vs.Row]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[vs.Row]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));		
			if(ONN_07!=0)
				vs7 = T_String.IsNullTo0(T_String.GetDataFromSQL(" (LEFT(OFF_07,LEN(OFF_07)-2)*60+RIGHT(OFF_07,2))-(LEFT(ONN_07,LEN(ONN_07)-2)*60+RIGHT(ONN_07,2)) ", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[vs.Row]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[vs.Row]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));	
			else
				vs7 = T_String.IsNullTo0(T_String.GetDataFromSQL(" OFF_07-ONN_07 ", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[vs.Row]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[vs.Row]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));	
			if(ONN_08!=0)
				vs8 = T_String.IsNullTo0(T_String.GetDataFromSQL(" (LEFT(OFF_08,LEN(OFF_08)-2)*60+RIGHT(OFF_08,2))-(LEFT(ONN_08,LEN(ONN_08)-2)*60+RIGHT(ONN_08,2)) ", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[vs.Row]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[vs.Row]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));	
			else
				vs8 = T_String.IsNullTo0(T_String.GetDataFromSQL(" OFF_08-ONN_08 ", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[vs.Row]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[vs.Row]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));	
			if(ONN_09!=0)
				vs9 = T_String.IsNullTo0(T_String.GetDataFromSQL(" (LEFT(OFF_09,LEN(OFF_09)-2)*60+RIGHT(OFF_09,2))-(LEFT(ONN_09,LEN(ONN_09)-2)*60+RIGHT(ONN_09,2)) ", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[vs.Row]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[vs.Row]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));	
			else
				vs9 = T_String.IsNullTo0(T_String.GetDataFromSQL(" OFF_09-ONN_09 ", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[vs.Row]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[vs.Row]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));	
			if(ONN_10!=0)
				vs10 = T_String.IsNullTo0(T_String.GetDataFromSQL(" (LEFT(OFF_10,LEN(OFF_10)-2)*60+RIGHT(OFF_10,2))-(LEFT(ONN_10,LEN(ONN_10)-2)*60+RIGHT(ONN_10,2)) ", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[vs.Row]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[vs.Row]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));
			else
				vs10 = T_String.IsNullTo0(T_String.GetDataFromSQL(" OFF_10-ONN_10 ", " FILC06A_VS", " (EMP_ID = '" + vs.Rows[vs.Row]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[vs.Row]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')", PublicFunction.C_con));	

			if (vs1 < 0 || vs2 < 0 ||vs3 < 0 ||vs4 < 0 ||vs5 < 0 ||vs6 < 0 ||vs7 < 0 ||vs8 < 0 ||vs9 < 0 ||vs10 < 0 )
			{
				vs.Rows[vs.Row]["NOT_DR"] = "Arnormal;" +PublicFunction.A_UserID + "Sign;";
				vs.Rows[vs.Row]["SUM_TM"] =0;
			}   
			else
			{
				vs.Rows[vs.Row]["NOT_DR"] = PublicFunction.A_UserID + "Sign;";
				//vs.Rows[vs.Row]["SUM_TM"] = vs1 + vs2 + vs3 + vs4 + vs5 + vs6 + vs7 + vs8 + vs9 + vs10;

				int giotong=vs1 + vs2 + vs3 + vs4 + vs5 + vs6 + vs7 + vs8 + vs9 + vs10;
				int gio=giotong/60;
				if(giotong>=60)
					giotong=giotong+(100*gio)-60*gio;
				vs.Rows[vs.Row]["SUM_TM"] =giotong;
			}						
			string capnhatthongtin = "Update FILC06A_VS Set NOT_DR='" + vs.Rows[vs.Row]["NOT_DR"] + "',SUM_TM=" + vs.Rows[vs.Row]["SUM_TM"] + ",LCK_BT=1 Where (EMP_ID = '" + vs.Rows[vs.Row]["EMP_ID"] + "" + "' and ATT_DT = '" + Convert.ToDateTime(vs.Rows[vs.Row]["ATT_DT"]).ToString("yyyy/MM/dd") + "" + "')";
			PublicFunction.SQL_Execute(capnhatthongtin);
		}		
	}
}

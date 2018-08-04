using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Basic.Form;
using Basic.Function;

namespace GP8000.UserControl
{
	/// <summary>
	/// Summary description for frmTaCondition1.
	/// </summary>
	public class CrtTaCondition1 : System.Windows.Forms.UserControl
	{
		public System.Windows.Forms.Panel panel1;
		public System.Windows.Forms.GroupBox G_0;
		public System.Windows.Forms.RadioButton R_Par;
		public System.Windows.Forms.RadioButton R_ALL;
		public System.Windows.Forms.GroupBox G_1;
		public System.Windows.Forms.RadioButton R_NON;
		public System.Windows.Forms.RadioButton R_WID;
		public System.Windows.Forms.RadioButton R_DEP;
		public System.Windows.Forms.GroupBox G_DEP;
		public System.Windows.Forms.Button cmd_NON;
		public System.Windows.Forms.ComboBox CB_DEP;
		public System.Windows.Forms.GroupBox G_WID;
		public System.Windows.Forms.TextBox txt_fr;
		public System.Windows.Forms.TextBox txt_to;
		public System.Windows.Forms.Label label1;
		public System.Windows.Forms.Label label2;
		public ArrayList list;
		public System.Windows.Forms.CheckBox ck;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public CrtTaCondition1()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call

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

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.G_0 = new System.Windows.Forms.GroupBox();
			this.R_Par = new System.Windows.Forms.RadioButton();
			this.R_ALL = new System.Windows.Forms.RadioButton();
			this.G_1 = new System.Windows.Forms.GroupBox();
			this.ck = new System.Windows.Forms.CheckBox();
			this.R_NON = new System.Windows.Forms.RadioButton();
			this.R_WID = new System.Windows.Forms.RadioButton();
			this.R_DEP = new System.Windows.Forms.RadioButton();
			this.G_DEP = new System.Windows.Forms.GroupBox();
			this.cmd_NON = new System.Windows.Forms.Button();
			this.CB_DEP = new System.Windows.Forms.ComboBox();
			this.G_WID = new System.Windows.Forms.GroupBox();
			this.txt_fr = new System.Windows.Forms.TextBox();
			this.txt_to = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.G_0.SuspendLayout();
			this.G_1.SuspendLayout();
			this.G_DEP.SuspendLayout();
			this.G_WID.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.G_0);
			this.panel1.Controls.Add(this.G_1);
			this.panel1.Controls.Add(this.G_DEP);
			this.panel1.Controls.Add(this.G_WID);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(452, 176);
			this.panel1.TabIndex = 0;
			// 
			// G_0
			// 
			this.G_0.Controls.Add(this.R_Par);
			this.G_0.Controls.Add(this.R_ALL);
			this.G_0.Location = new System.Drawing.Point(6, 0);
			this.G_0.Name = "G_0";
			this.G_0.Size = new System.Drawing.Size(434, 44);
			this.G_0.TabIndex = 15;
			this.G_0.TabStop = false;
			this.G_0.Tag = "N";
			// 
			// R_Par
			// 
			this.R_Par.Location = new System.Drawing.Point(216, 16);
			this.R_Par.Name = "R_Par";
			this.R_Par.Size = new System.Drawing.Size(172, 24);
			this.R_Par.TabIndex = 2;
			this.R_Par.Text = "Partial";
			this.R_Par.CheckedChanged += new System.EventHandler(this.R_Par_CheckedChanged);
			// 
			// R_ALL
			// 
			this.R_ALL.Checked = true;
			this.R_ALL.Location = new System.Drawing.Point(68, 16);
			this.R_ALL.Name = "R_ALL";
			this.R_ALL.Size = new System.Drawing.Size(128, 24);
			this.R_ALL.TabIndex = 1;
			this.R_ALL.TabStop = true;
			this.R_ALL.Text = "All";
			this.R_ALL.CheckedChanged += new System.EventHandler(this.R_Par_CheckedChanged);
			// 
			// G_1
			// 
			this.G_1.Controls.Add(this.ck);
			this.G_1.Controls.Add(this.R_NON);
			this.G_1.Controls.Add(this.R_WID);
			this.G_1.Controls.Add(this.R_DEP);
			this.G_1.Location = new System.Drawing.Point(6, 40);
			this.G_1.Name = "G_1";
			this.G_1.Size = new System.Drawing.Size(434, 44);
			this.G_1.TabIndex = 16;
			this.G_1.TabStop = false;
			this.G_1.Tag = "N";
			// 
			// ck
			// 
			this.ck.Location = new System.Drawing.Point(328, 16);
			this.ck.Name = "ck";
			this.ck.Size = new System.Drawing.Size(100, 24);
			this.ck.TabIndex = 4;
			this.ck.Text = "DWID";
			this.ck.CheckedChanged += new System.EventHandler(this.ck_CheckedChanged);
			// 
			// R_NON
			// 
			this.R_NON.Location = new System.Drawing.Point(212, 14);
			this.R_NON.Name = "R_NON";
			this.R_NON.Size = new System.Drawing.Size(112, 24);
			this.R_NON.TabIndex = 3;
			this.R_NON.Text = "Non-sequent";
			this.R_NON.CheckedChanged += new System.EventHandler(this.R_Par_CheckedChanged);
			// 
			// R_WID
			// 
			this.R_WID.Location = new System.Drawing.Point(116, 14);
			this.R_WID.Name = "R_WID";
			this.R_WID.Size = new System.Drawing.Size(92, 24);
			this.R_WID.TabIndex = 2;
			this.R_WID.Text = "WID";
			this.R_WID.CheckedChanged += new System.EventHandler(this.R_Par_CheckedChanged);
			// 
			// R_DEP
			// 
			this.R_DEP.Location = new System.Drawing.Point(4, 14);
			this.R_DEP.Name = "R_DEP";
			this.R_DEP.Size = new System.Drawing.Size(108, 24);
			this.R_DEP.TabIndex = 1;
			this.R_DEP.Text = "Department";
			this.R_DEP.CheckedChanged += new System.EventHandler(this.R_Par_CheckedChanged);
			// 
			// G_DEP
			// 
			this.G_DEP.Controls.Add(this.cmd_NON);
			this.G_DEP.Controls.Add(this.CB_DEP);
			this.G_DEP.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(163)));
			this.G_DEP.Location = new System.Drawing.Point(6, 82);
			this.G_DEP.Name = "G_DEP";
			this.G_DEP.Size = new System.Drawing.Size(218, 76);
			this.G_DEP.TabIndex = 17;
			this.G_DEP.TabStop = false;
			this.G_DEP.Text = "Dept";
			// 
			// cmd_NON
			// 
			this.cmd_NON.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_NON.Location = new System.Drawing.Point(13, 46);
			this.cmd_NON.Name = "cmd_NON";
			this.cmd_NON.Size = new System.Drawing.Size(192, 24);
			this.cmd_NON.TabIndex = 1;
			this.cmd_NON.Text = "Non-sequent WID";
			this.cmd_NON.Click += new System.EventHandler(this.cmd_NON_Click);
			// 
			// CB_DEP
			// 
			this.CB_DEP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CB_DEP.Location = new System.Drawing.Point(13, 20);
			this.CB_DEP.Name = "CB_DEP";
			this.CB_DEP.Size = new System.Drawing.Size(192, 24);
			this.CB_DEP.TabIndex = 0;
			// 
			// G_WID
			// 
			this.G_WID.Controls.Add(this.txt_fr);
			this.G_WID.Controls.Add(this.txt_to);
			this.G_WID.Controls.Add(this.label1);
			this.G_WID.Controls.Add(this.label2);
			this.G_WID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(163)));
			this.G_WID.Location = new System.Drawing.Point(228, 82);
			this.G_WID.Name = "G_WID";
			this.G_WID.Size = new System.Drawing.Size(212, 76);
			this.G_WID.TabIndex = 18;
			this.G_WID.TabStop = false;
			this.G_WID.Text = "WID";
			// 
			// txt_fr
			// 
			this.txt_fr.Location = new System.Drawing.Point(64, 17);
			this.txt_fr.MaxLength = 20;
			this.txt_fr.Name = "txt_fr";
			this.txt_fr.Size = new System.Drawing.Size(140, 23);
			this.txt_fr.TabIndex = 0;
			this.txt_fr.Text = "";
			this.txt_fr.Leave += new System.EventHandler(this.txt_fr_Leave);
			// 
			// txt_to
			// 
			this.txt_to.Location = new System.Drawing.Point(64, 45);
			this.txt_to.MaxLength = 20;
			this.txt_to.Name = "txt_to";
			this.txt_to.Size = new System.Drawing.Size(140, 23);
			this.txt_to.TabIndex = 0;
			this.txt_to.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(4, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Fr";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(4, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "To";
			// 
			// CrtTaCondition1
			// 
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "CrtTaCondition1";
			this.Size = new System.Drawing.Size(452, 176);
			this.Load += new System.EventHandler(this.frmTaCondition1_Load);
			this.panel1.ResumeLayout(false);
			this.G_0.ResumeLayout(false);
			this.G_1.ResumeLayout(false);
			this.G_DEP.ResumeLayout(false);
			this.G_WID.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void R_Par_CheckedChanged(object sender, System.EventArgs e)
		{
			Radio_Change();
		}
		private void Radio_Change()
		{
			G_1.Enabled=!R_ALL.Checked;
			CB_DEP.Enabled=R_DEP.Checked && !R_ALL.Checked;
			cmd_NON.Enabled=R_NON.Checked && !R_ALL.Checked;
			G_WID.Enabled=R_WID.Checked && !R_ALL.Checked;			
		}

		public void InitCB(Object Tag)
		{
			//Department
			this.Tag=Tag;
			string sql=PublicFunction.GetDep(Tag+"");			
			PublicFunction.InitCB(CB_DEP,sql);
			R_ALL.Checked=true;
			R_DEP.Checked=true;
		}
		public void Initlabel()
		{
			Basic.Function.PublicFunction.L_Init_Label(panel1,"TaCondition",new ArrayList());			
		}
		public string GetWhere(string table)
		{
			return GetWhere(table,true);
		}
		public string GetWhere1(string table)
		{
			return GetWhere(table,false);
		}
		public string GetWhere(string table,Boolean vacate)
		{
			string wh="",tb=table;
			if(tb!="")
				tb=tb+".";
			if(R_NON.Checked && !R_ALL.Checked)
			{
				for (int i=0;i<list.Count;i++)
				{
					if(wh!="")
						wh+=",";
					wh+="N'"+list[i]+"'";
				}
				if(wh!="")
				{
					if(ck.Checked)
					{
						wh=tb+"EMP_I1 in ("+wh+")";
					}
					else
					{
						wh=tb+"EMP_ID in ("+wh+")";
					}
				}
				else
					wh="(1=1)";
			}
			else
			{
				if(R_ALL.Checked)
				{
					wh="(1=1)";
				}
				else
				{
					if(R_DEP.Checked)
					{
						wh=tb+"DEP_ID=N'"+CB_DEP.SelectedValue+"'";		
		
					}
					if(R_WID.Checked)
					{
						if(ck.Checked)
						{							
							wh="("+tb+"EMP_I1 Between N'"+txt_fr.Text +"' and N'"+txt_to.Text+"')";
						}
						else
						{
							wh="("+tb+"EMP_ID Between N'"+txt_fr.Text +"' and N'"+txt_to.Text+"')";
//							if(System.Windows.Forms==frmTaCalAnnualLeave)
//								wh.Replace("EMP_ID", "a.EMP_ID");//
						}						
					}
				}
			}
			wh+=" and (DEL_BT is null Or DEL_BT=0)";
			if(vacate)
				wh+=" and (VAC_BT is null Or VAC_BT=0) ";
			wh+=" and "+tb+"DEP_ID in (Select DEP_ID  from SYS_SECURITY_DEP"+
					" where MNU_ID="+this.Tag+" and ALL_BT=1 and USER_ID=N'"
				+PublicFunction.A_UserID+"') and "+PublicFunction.Get_TYP(this.Tag,"");
			return wh;
		}

		private void frmTaCondition1_Load(object sender, System.EventArgs e)
		{
		
		}

		private void cmd_NON_Click(object sender, System.EventArgs e)
		{
			frmTaNonSeq dlg=new frmTaNonSeq();
			if(dlg.ShowDialog()==DialogResult.OK)
			{
				list=dlg.list;
			}
		}

		private void ck_CheckedChanged(object sender, System.EventArgs e)
		{
			if(ck.Checked)
				G_WID.Text=ck.Text;
			else
				G_WID.Text=R_WID.Text;
		}

		private void txt_fr_Leave(object sender, System.EventArgs e)
		{
			txt_to.Text=txt_fr.Text;
		}
	}
}

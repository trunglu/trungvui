using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Basic.Function;
namespace Basic.Form
{
	/// <summary>
	/// Summary description for frmUser.
	/// </summary>
	public class frmUser : System.Windows.Forms.Form
	{
		private string Group_ID;
		
		private C1.Win.C1FlexGrid.C1FlexGrid vs;
		private System.Windows.Forms.TextBox txt1;
		private System.Windows.Forms.Label lb1;
		private System.Windows.Forms.Label lb2;
		private System.Windows.Forms.TextBox txt2;
		private System.Windows.Forms.Label lb3;
		private System.Windows.Forms.TextBox txt3;
		private System.Windows.Forms.Label lb4;
		private System.Windows.Forms.TextBox txt4;
		private int row;
		private Navigator1._0.NavigatorAuto nav1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmUser(string Group_ID)
		{
			//
			// Required for Windows Form Designer support
			//
			this.Group_ID=Group_ID;
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
			this.vs = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.txt1 = new System.Windows.Forms.TextBox();
			this.lb1 = new System.Windows.Forms.Label();
			this.lb2 = new System.Windows.Forms.Label();
			this.txt2 = new System.Windows.Forms.TextBox();
			this.lb3 = new System.Windows.Forms.Label();
			this.txt3 = new System.Windows.Forms.TextBox();
			this.lb4 = new System.Windows.Forms.Label();
			this.txt4 = new System.Windows.Forms.TextBox();
			this.nav1 = new Navigator1._0.NavigatorAuto();
			((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
			this.SuspendLayout();
			// 
			// vs
			// 
			this.vs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.vs.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs.ColumnInfo = "10,1,0,0,0,100,Columns:";
			this.vs.Location = new System.Drawing.Point(8, 96);
			this.vs.Name = "vs";
			this.vs.Size = new System.Drawing.Size(512, 268);
			this.vs.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs.TabIndex = 1;
			this.vs.AfterRowColChange += new C1.Win.C1FlexGrid.RangeEventHandler(this.vs_AfterRowColChange);
			// 
			// txt1
			// 
			this.txt1.Location = new System.Drawing.Point(100, 32);
			this.txt1.MaxLength = 20;
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(164, 23);
			this.txt1.TabIndex = 2;
			this.txt1.Text = "";
			// 
			// lb1
			// 
			this.lb1.Location = new System.Drawing.Point(8, 40);
			this.lb1.Name = "lb1";
			this.lb1.Size = new System.Drawing.Size(120, 16);
			this.lb1.TabIndex = 3;
			this.lb1.Text = "label1";
			// 
			// lb2
			// 
			this.lb2.Location = new System.Drawing.Point(8, 72);
			this.lb2.Name = "lb2";
			this.lb2.Size = new System.Drawing.Size(120, 16);
			this.lb2.TabIndex = 5;
			this.lb2.Text = "label1";
			// 
			// txt2
			// 
			this.txt2.Location = new System.Drawing.Point(100, 64);
			this.txt2.Name = "txt2";
			this.txt2.Size = new System.Drawing.Size(164, 23);
			this.txt2.TabIndex = 4;
			this.txt2.Text = "";
			// 
			// lb3
			// 
			this.lb3.Location = new System.Drawing.Point(272, 40);
			this.lb3.Name = "lb3";
			this.lb3.Size = new System.Drawing.Size(128, 16);
			this.lb3.TabIndex = 7;
			this.lb3.Text = "label1";
			// 
			// txt3
			// 
			this.txt3.Location = new System.Drawing.Point(388, 32);
			this.txt3.MaxLength = 20;
			this.txt3.Name = "txt3";
			this.txt3.PasswordChar = '*';
			this.txt3.Size = new System.Drawing.Size(128, 23);
			this.txt3.TabIndex = 6;
			this.txt3.Text = "";
			// 
			// lb4
			// 
			this.lb4.Location = new System.Drawing.Point(272, 72);
			this.lb4.Name = "lb4";
			this.lb4.Size = new System.Drawing.Size(128, 16);
			this.lb4.TabIndex = 9;
			this.lb4.Text = "label1";
			// 
			// txt4
			// 
			this.txt4.Location = new System.Drawing.Point(388, 64);
			this.txt4.MaxLength = 20;
			this.txt4.Name = "txt4";
			this.txt4.PasswordChar = '*';
			this.txt4.Size = new System.Drawing.Size(128, 23);
			this.txt4.TabIndex = 8;
			this.txt4.Text = "";
			// 
			// nav1
			// 
			this.nav1.BackColor = System.Drawing.SystemColors.Control;
			this.nav1.Connection = null;
			this.nav1.ConnectionDel = null;
			this.nav1.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.nav1.form = null;
			this.nav1.FormName = null;
			this.nav1.Grid = null;
			this.nav1.History = false;
			this.nav1.IsNull = true;
			this.nav1.Language = "EN";
			this.nav1.Location = new System.Drawing.Point(4, 0);
			this.nav1.MSG_Exit = false;
			this.nav1.MulltiDel = false;
			this.nav1.Name = "nav1";
			this.nav1.Security = 0;
			this.nav1.ShowPopupMenu = false;
			this.nav1.Size = new System.Drawing.Size(448, 32);
			this.nav1.TabIndex = 11;
			this.nav1.ToolBar_Auto = true;
			this.nav1.UserID = null;
			this.nav1.VisibleGrid = true;
			this.nav1.Where = null;
			this.nav1.TBarClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.nav1_TBarClick);
			// 
			// frmUser
			// 
			this.AutoScale = false;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(528, 374);
			this.Controls.Add(this.nav1);
			this.Controls.Add(this.txt2);
			this.Controls.Add(this.txt1);
			this.Controls.Add(this.txt4);
			this.Controls.Add(this.txt3);
			this.Controls.Add(this.lb2);
			this.Controls.Add(this.lb1);
			this.Controls.Add(this.vs);
			this.Controls.Add(this.lb4);
			this.Controls.Add(this.lb3);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmUser";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmUser";
			this.Load += new System.EventHandler(this.frmUser_Load);
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmUser_Load(object sender, System.EventArgs e)
		{
			Func.Fun.ExecuteSQL("Delete from SYS_USER where GROUP_ID not in(Select GROUP_ID from SYS_GROUP)",PublicFunction.C_con,true);
			nav1.Grid=vs;			
			nav1.FormName=this.Name+"_vs";
			nav1.Connection=Function.PublicFunction.C_con;			
			nav1.Init_Control();
			nav1.Show_VS("GROUP_ID=N'"+Group_ID+"'");
			nav1.Security=(int)this.Tag;
			nav1.UserID=PublicFunction.A_UserID;
			nav1.ToolBar_Auto=false;
			nav1.form=this;
			PublicFunction.L_Init_Label(this);
			txt1.ReadOnly=txt2.ReadOnly=txt3.ReadOnly=txt4.ReadOnly=true;
			//show_txt();
			
			
		}


		private void vs_AfterRowColChange(object sender, C1.Win.C1FlexGrid.RangeEventArgs e)
		{
			if (e.OldRange.r1!=e.NewRange.r2)
			{				
				//show_txt();
			}
		}

		private void show_txt()
		{
			if (vs.Row>0 && nav1.State)
			{
				txt1.Text=vs.Rows[vs.Row]["USER_ID"]+"";
				txt2.Text=vs.Rows[vs.Row]["USER_NAME"]+"";
				txt3.Text=txt4.Text="";
				try
				{
					if ((int)vs.Rows[vs.Row].UserData!=2)
						txt1.ReadOnly=txt2.ReadOnly=txt3.ReadOnly=txt4.ReadOnly=true;
					else
						txt1.ReadOnly=txt2.ReadOnly=txt3.ReadOnly=txt4.ReadOnly=false;
				}
				catch(Exception){}
			}
		}

		private void nav1_TBarClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			try
			{			
				if (e.Button.Equals(nav1.cmd_add))
				{
					if (vs.Rows.Count==1 || (int)vs.Rows[vs.Rows.Count-1].UserData!=2)					
						nav1.ToolBar_Click(e);						
					vs.Rows[vs.Rows.Count-1]["GROUP_ID"]=Group_ID;
					row=vs.Rows.Count-1;
					txt1.ReadOnly=txt2.ReadOnly=txt3.ReadOnly=txt4.ReadOnly=false;
					return;
				}
				if (e.Button.Equals(nav1.cmd_save))
				{
					if (txt3.Text!=txt4.Text)
					{
						MessageBox.Show("Password not match!");
						return ;					
					}
//					if (txt1.Text=="")
//					{
//						MessageBox.Show(PublicFunction.L_Get_Msg("msg",4));
//						return ;					
//					}
					if ((int)vs.Rows[vs.Rows.Count-1].UserData==2 & (vs.Rows[vs.Row]["USER_ID"]+""=="admin" || vs.Rows[vs.Row]["USER_ID"]+""=="vinhtuyen"))
					{
						MessageBox.Show("Can't create user admin or vinhtuyen");
						return;
					}
					vs.Rows[row]["USER_ID"]=txt1.Text;
					vs.Rows[row]["PASS"]=Function.PublicFunction.code(txt3.Text,txt1.Text);
					vs.Rows[row]["USER_ID"]=txt1.Text;
					vs.Rows[row]["USER_NAME"]=txt2.Text;
					vs.Rows[row]["GROUP_ID"]=Group_ID;
					nav1.ToolBar_Click(e);
					//key
					//PublicFunction.SQL_Execute("Update SYS_USER set PASS=PASS+'***' where USER_ID='"+txt1.Text +"'",PublicFunction.C_con);
					if (vs.Rows.Count==1 || (int)vs.Rows[vs.Rows.Count-1].UserData!=2)
					{
						txt1.ReadOnly=txt2.ReadOnly=txt3.ReadOnly=txt4.ReadOnly=true;
						txt1.Text=txt2.Text=txt3.Text=txt4.Text="";
					}
					return;
				}
				if (e.Button.Equals(nav1.cmd_refresh))
				{					
					nav1.ToolBar_Click(e);
					//show_txt();
					txt1.ReadOnly=txt2.ReadOnly=txt3.ReadOnly=txt4.ReadOnly=true;
					txt1.Text=txt2.Text=txt3.Text=txt4.Text="";
					return;
				}		
				if (e.Button.Equals(nav1.cmd_delete))
				{
					if (vs.Rows[vs.Row]["USER_ID"]+""=="admin" || vs.Rows[vs.Row]["USER_ID"]+""=="vinhtuyen")
					{
						MessageBox.Show("Can't Delete user admin or vinhtuyen");
						return;
					}
				}	
				nav1.ToolBar_Click(e);				
			}
			catch(Exception){}
		}		
	}
}

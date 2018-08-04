using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Basic.Form;
using Basic.Function;
using System.IO;
using C1.Win.C1FlexGrid;
namespace GP8000.UserControl
{
	/// <summary>
	/// Summary description for CrtTaDepartment.
	/// </summary>
	public class CrtTaDepartment : System.Windows.Forms.UserControl
	{
		public C1.Win.C1FlexGrid.C1FlexGrid vs1;
		public ArrayList ar;
		public string ID;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.CheckBox ck;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public CrtTaDepartment()
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
			this.vs1 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.panel1 = new System.Windows.Forms.Panel();
			this.ck = new System.Windows.Forms.CheckBox();
			this.panel2 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.vs1)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// vs1
			// 
			this.vs1.AllowEditing = false;
			this.vs1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D;
			this.vs1.ColumnInfo = "1,0,0,0,0,100,Columns:0{Width:412;}\t";
			this.vs1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vs1.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs1.Location = new System.Drawing.Point(0, 0);
			this.vs1.Name = "vs1";
			this.vs1.Rows.Count = 10;
			this.vs1.Rows.Fixed = 0;
			this.vs1.Size = new System.Drawing.Size(412, 444);
			this.vs1.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs1.TabIndex = 8;
			this.vs1.Tag = "N";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.ck);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(412, 28);
			this.panel1.TabIndex = 9;
			// 
			// ck
			// 
			this.ck.Checked = true;
			this.ck.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ck.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ck.Location = new System.Drawing.Point(8, 4);
			this.ck.Name = "ck";
			this.ck.Size = new System.Drawing.Size(384, 24);
			this.ck.TabIndex = 0;
			this.ck.Text = "checkBox1";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.vs1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 28);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(412, 444);
			this.panel2.TabIndex = 10;
			// 
			// CrtTaDepartment
			// 
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "CrtTaDepartment";
			this.Size = new System.Drawing.Size(412, 472);
			this.Load += new System.EventHandler(this.CrtTaDepartment_Load);
			((System.ComponentModel.ISupportInitialize)(this.vs1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void CrtTaDepartment_Load(object sender, System.EventArgs e)
		{				
			vs1.Cols[0].Width=vs1.Width;
		}	
		public string Get_Data(string FieldName)
		{
			try
			{
				if(vs1.Row<=0)
					return null;
				string st="";
//				if(ck.Checked)
//				{
//					int lv=((Node)ar[vs1.Row]).Level;
//					st+="(N'"+vs1.Rows[vs1.Row]["DEP_ID"]+"'";
//					for(int i=vs1.Row+1;i<vs1.Rows.Count;i++)
//					{
//						if (((Node)ar[i]).Level<=lv)
//							break;					
//						st+=",N'"+vs1.Rows[i]["DEP_ID"]+"'";					
//					}
//					return st+")";
//				}
//				else
					return vs1.Rows[vs1.Row][FieldName]+"";
			}
			catch(Exception){return null;}
		}
		public string Get_Data(int Index)
		{
			try
			{
			if(vs1.Row<=0)
				return null;
			return vs1.Rows[vs1.Row][Index]+"";
			}
			catch(Exception){return null;}
		}

		public string Get_DepAll()
		{
			if(vs1.Row<0)
				return null;
			
			string st="";
			try
			{
				if(ck.Checked)
				{
					int lv=((Node)ar[vs1.Row]).Level;
					st+="(N'"+vs1.Rows[vs1.Row]["DEP_ID"]+"'";
					for(int i=vs1.Row+1;i<vs1.Rows.Count;i++)
					{
						if (((Node)ar[i]).Level<=lv)
							break;					
						st+=",N'"+vs1.Rows[i]["DEP_ID"]+"'";					
					}
					return st+")";
				}
				return "(N'"+vs1.Rows[vs1.Row]["DEP_ID"]+"')";
				
			}
			catch(Exception){return null;}
		}
		public void Init_Tree(string MNU_ID)
		{
			vs1.Styles["Normal"].BackColor=System.Drawing.Color.WhiteSmoke;
			vs1.Styles["Normal"].Border.Color=System.Drawing.Color.WhiteSmoke;
			vs1.Styles["EmptyArea"].BackColor=System.Drawing.Color.WhiteSmoke;
			vs1.Styles["EmptyArea"].Border.Color=System.Drawing.Color.WhiteSmoke;
			vs1.DoubleClick+=new EventHandler(vs1_DoubleClick);
			vs1.Cols.Count=2;			
			vs1.Rows.Count=0;			
			vs1.Cols[0].Name="DEP_NM";
			vs1.Cols[1].Name="DEP_ID";
			vs1.Cols[1].Visible=false;
			vs1.Tree.Column = 0;
			ID=MNU_ID;
			vs1.SizeChanged+=new EventHandler(vs1_SizeChanged);
			vs1.Cols[0].Width=vs1.Width;	
			label();
			ck.Checked=PublicFunction.DEP_Show_ALL;
		}		
		public void label()
		{
			ck.Text=PublicFunction.L_GetLabel("dep","ck");
		}
		public void Show_Tree()
		{					
			vs1.Rows.Count=0;						
			Node a;
			ar=new ArrayList();			
			a=vs1.Rows.InsertNode(vs1.Rows.Count, 0);	
			ar.Add(a);
			vs1.Rows[vs1.Rows.Count-1]["DEP_NM"]=T_String.GetDataFromSQL("COM_N2","FILA01A","ACT_BT=1");
			Init_TreeDetail("(DEP_HG is null or DEP_HG='')",1,a);		
//			vs1.AutoSizeCols();
		}	
		private void Init_TreeDetail(string wh,int level,Node p)
		{
			string sql;//="Select a.DEP_ID,DEP_NM,DEP_N1 from FILA02A where "+ wh;
			sql="Select a.DEP_ID,DEP_NM,DEP_N1  from SYS_SECURITY_DEP a,FILA02A b where a.MNU_ID="+ID
				+" and a.ALL_BT=1 and a.DEP_ID=b.DEP_ID and USER_ID=N'"+PublicFunction.A_UserID+"' and "+wh;	
			Func.RecordSet rs=new Func.RecordSet(sql,PublicFunction.C_con);
			Node a;
			for(int i=0;i<rs.rows;i++)
			{
				a=vs1.Rows.InsertNode(vs1.Rows.Count, level);
				ar.Add(a);
				if(rs.record(i,"DEP_N1")+""!="")
					vs1.Rows[vs1.Rows.Count-1]["DEP_NM"]=rs.record(i,"DEP_NM")+" - "+rs.record(i,"DEP_N1");
				else
					vs1.Rows[vs1.Rows.Count-1]["DEP_NM"]=rs.record(i,"DEP_NM");
				vs1.Rows[vs1.Rows.Count-1]["DEP_ID"]=rs.record(i,"DEP_ID");
				Init_TreeDetail("DEP_HG=N'"+rs.record(i,"DEP_ID")+"'",level+1,a);
			}
			if (rs.rows>0)
				p.Expanded=false;
		}
		private void vs1_DoubleClick(object sender, EventArgs e)
		{			
			((Node)ar[vs1.Row]).Expanded=!((Node)ar[vs1.Row]).Expanded;
		}

		private void vs1_SizeChanged(object sender, EventArgs e)
		{
			vs1.Cols[0].Width=vs1.Width;	
		}

		
	}
}

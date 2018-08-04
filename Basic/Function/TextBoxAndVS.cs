using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Basic.Function;

namespace Basic.Function
{
	/// <summary>
	/// Summary description for TextBoxAndVS.
	/// </summary>
	public class TextBoxAndVS
	{
		public TextBoxAndVS()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		public static void L_GetLabelFromVS(System.Windows.Forms.GroupBox fr,C1.Win.C1FlexGrid.C1FlexGrid vs)
		{
			try
			{
				for (int i=0;i<fr.Controls.Count;i++)
				{
					switch (fr.Controls[i].GetType().FullName)
					{					
						case "System.Windows.Forms.Label":
							if ((((System.Windows.Forms.Label)fr.Controls[i]).Tag+"")!="")
								((System.Windows.Forms.Label)fr.Controls[i]).Text= L_GetLabelFromVS1(vs,((System.Windows.Forms.Label)fr.Controls[i]).Tag+"");
							break;
					}
				}
			}
			catch(Exception)
			{
				MessageBox.Show("Get Label from VS error");
			}
		}

		public static string L_GetLabelFromVS1(C1.Win.C1FlexGrid.C1FlexGrid vs,string colname)
		{
			try
			{
				return vs.Cols[colname].Caption;
			}
			catch(Exception)
			{
				return colname;
			}
		}

		public static void D_GetDataFromVS(System.Windows.Forms.GroupBox fr,C1.Win.C1FlexGrid.C1FlexGrid vs)
		{
			int i=0;
			if (vs.Row<=0)
			{				
				try
				{
					for (i=0;i<fr.Controls.Count;i++)
					{
						switch (fr.Controls[i].GetType().FullName)
						{
							case "C1.Win.C1Input.C1TextBox":
								C1.Win.C1Input.C1TextBox c1txt=(C1.Win.C1Input.C1TextBox)fr.Controls[i];
								if ((c1txt.Tag+"")!="")								
									c1txt.Value =null;
								break;
							case "System.Windows.Forms.TextBox":
								if ((((System.Windows.Forms.TextBox)fr.Controls[i]).Tag+"")!="")
									((System.Windows.Forms.TextBox)fr.Controls[i]).Text=null;
								break;
							case "System.Windows.Forms.DateTimePicker" :
								System.Windows.Forms.DateTimePicker dt=(System.Windows.Forms.DateTimePicker)fr.Controls[i];
								if (dt.Tag+""!="")
								{								
									dt.Text=null;									
								}
								break;
							case "C1.Win.C1Input.C1DateEdit" :
								C1.Win.C1Input.C1DateEdit dt1=(C1.Win.C1Input.C1DateEdit)fr.Controls[i];
								if (dt1.Tag+""!="")
								{
									dt1.Value=null;		
								}
								break;
							case "System.Windows.Forms.CheckBox" :
								CheckBox chbox=(System.Windows.Forms.CheckBox)fr.Controls[i];
								if ((chbox.Tag+"")!="")
									chbox.Checked=false;
								break;
							case "System.Windows.Forms.ComboBox" :
								ComboBox cbbox=(System.Windows.Forms.ComboBox)fr.Controls[i];
								if ((cbbox.Tag+"")!="")
								{									
									cbbox.SelectedValue="";									
								}
								break;
						}
					}					
				}
				catch(Exception)
				{
					MessageBox.Show("Get data from VS error" + fr.Controls[i].Tag);
				}
				return;
			}			
			else
			{
				string st="";				
				try
				{
					for (i=0;i<fr.Controls.Count;i++)
					{
						switch (fr.Controls[i].GetType().FullName)
						{
							case "C1.Win.C1Input.C1TextBox":
								C1.Win.C1Input.C1TextBox c1txt=(C1.Win.C1Input.C1TextBox)fr.Controls[i];						
								st="";
								if ((c1txt.Tag+"")!="")
									st=D_GetDataFromVS1(vs,c1txt.Tag+"");
								if (st=="") st=null;
								c1txt.Value =st;
								break;
							case "System.Windows.Forms.TextBox":
								if ((((System.Windows.Forms.TextBox)fr.Controls[i]).Tag+"")!="")
									((System.Windows.Forms.TextBox)fr.Controls[i]).Text= D_GetDataFromVS1(vs,((System.Windows.Forms.TextBox)fr.Controls[i]).Tag+"");
								break;
							case "System.Windows.Forms.DateTimePicker" :
								System.Windows.Forms.DateTimePicker dt=(System.Windows.Forms.DateTimePicker)fr.Controls[i];
								if (dt.Tag+""!="")
								{
									st="";
									st=D_GetDataFromVS1(vs,dt.Tag+"");
									if (st=="" || st==null)
										dt.Text=null;
									else
										dt.Text=st;
								}
								break;
							case "C1.Win.C1Input.C1DateEdit" :
								C1.Win.C1Input.C1DateEdit dt1=(C1.Win.C1Input.C1DateEdit)fr.Controls[i];
								if (dt1.Tag+""!="")
								{
									st="";
									st=D_GetDataFromVS1(vs,dt1.Tag+"");
									if (st=="" || st==null)
										dt1.Value=null;
									else
										dt1.Value=DateTime.Parse(st).ToString("yyyy/MM/dd");
								}
								break;
							case "System.Windows.Forms.CheckBox" :
								CheckBox chbox=(System.Windows.Forms.CheckBox)fr.Controls[i];
								if ((chbox.Tag+"")!="")
									chbox.Checked=ConvertStringToBoolean(D_GetDataFromVS1(vs,chbox.Tag+""));
								break;
							case "System.Windows.Forms.ComboBox" :
								ComboBox cbbox=(System.Windows.Forms.ComboBox)fr.Controls[i];
								if ((cbbox.Tag+"")!="")
								{
									cbbox.SelectedValue="";
									string st1=D_GetDataFromVS1(vs,cbbox.Tag+"");
									if (st1=="")
									{
										cbbox.SelectedValue="";
									}
									else
										cbbox.SelectedValue=st1;
								}
								break;
						}
					}
					TextBoxAndVS.D_AddNewOrEdit(fr,(T_String.IsNullTo0(vs.Rows[vs.Row].UserData+"")!=2));
				}
				catch(Exception)
				{
					MessageBox.Show("Get data from VS error" + fr.Controls[i].Tag);
				}
			}
		}

		public static Boolean ConvertStringToBoolean(string st)
		{
			if (st=="True")
				return true;
			return false;
		}

		public static string  D_GetDataFromVS1(C1.Win.C1FlexGrid.C1FlexGrid vs,string colname)
		{
			try
			{
				if (vs.GetData(vs.Row,colname)==null)
					return "";
				return vs.GetData(vs.Row,colname)+"";
			}
			catch(Exception)
			{
				return colname;
			}

		}
		public static void D_AddNewOrEdit(System.Windows.Forms.GroupBox fr,Boolean ReadOnly)
		{
			for (int i=0;i<fr.Controls.Count;i++)
			{
				switch (fr.Controls[i].GetType().FullName)
				{					
					case "System.Windows.Forms.TextBox":
						if (((System.Windows.Forms.TextBox)fr.Controls[i]).BackColor==Color.LemonChiffon)
							((System.Windows.Forms.TextBox)fr.Controls[i]).ReadOnly=ReadOnly;
						break;
				}
			}
		}

		public static void D_GetDataFromTextBox(System.Windows.Forms.GroupBox fr,C1.Win.C1FlexGrid.C1FlexGrid vs)
		{
			if (vs.Row<=0) return;
						try
						{
			for (int i=0;i<fr.Controls.Count;i++)
			{
				switch (fr.Controls[i].GetType().FullName)
				{
					case "C1.Win.C1Input.C1DateEdit" :
						C1.Win.C1Input.C1DateEdit dt1=(C1.Win.C1Input.C1DateEdit)fr.Controls[i];
						if (dt1.Tag+""!="")
						{
							if (dt1.Value+"" =="")
								vs.SetData(vs.Row,dt1.Tag+"",null);
							else
							{
//								if (dt1.CustomFormat!="" || dt1.CustomFormat!=null)
//									vs.SetData(vs.Row,dt1.Tag+"",Set_vs(DateTime.Parse(dt1.Value+"").ToString(dt1.CustomFormat)));
//								else
									vs.SetData(vs.Row,dt1.Tag+"",Set_vs(dt1.Value));
							}
						}
						break;
					case "C1.Win.C1Input.C1TextBox":
						C1.Win.C1Input.C1TextBox c1txt=(C1.Win.C1Input.C1TextBox)fr.Controls[i];
						if ((c1txt.Tag+"")!="")								
						{													
							vs.SetData(vs.Row,c1txt.Tag+"",Set_vs(c1txt.Value));		
						}
						break;
					case "System.Windows.Forms.TextBox":
						TextBox txt=(System.Windows.Forms.TextBox)fr.Controls[i];
						if ((txt.Tag+"")!="")								
							vs.SetData(vs.Row,txt.Tag+"",Set_vs(txt.Text));								
						break;
					case "System.Windows.Forms.CheckBox":
						CheckBox chbox=(System.Windows.Forms.CheckBox)fr.Controls[i];
						if ((chbox.Tag+"")!="")								
							vs.SetData(vs.Row,chbox.Tag+"",Set_vs(chbox.Checked))	;
						break;
					case "System.Windows.Forms.ComboBox":
						ComboBox cbbox=(System.Windows.Forms.ComboBox)fr.Controls[i];
						if ((cbbox.Tag+"")!="")								
							vs.SetData(vs.Row,cbbox.Tag+"",Set_vs(cbbox.SelectedValue))	;
						break;
				}
			}
			TextBoxAndVS.D_AddNewOrEdit(fr,(T_String.IsNullTo0(vs.Rows[vs.Row].UserData+"")!=2));
						}
						catch(Exception)
						{
							MessageBox.Show("Get data from VS error");
						}
		}

		private static Object Set_vs(Object st)
		{
			if (st+""=="")
				return null;
			return st;
		}
	}
}

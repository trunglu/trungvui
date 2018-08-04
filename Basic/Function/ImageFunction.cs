using System;
using System.IO;
using System.Windows;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Navigator1;
using System.Collections;
using System.Drawing;

namespace Basic.Function
{
	/// <summary>
	/// Summary description for Image.
	/// </summary>
	public class ImageFunction
	{
		public ImageFunction()
		{
			//
			// TODO: Add constructor logic here
			//
		}
		
		public static Bitmap LoadImageFromSQL(string sql)
		{		
			SqlConnection con =new SqlConnection(PublicFunction.C_con.ConnectionString);
			con.Open();
			SqlCommand Sqlcmd=new SqlCommand(sql,con );
			
			object obj = Sqlcmd.ExecuteScalar();
			con.Close();
			if (obj == System.DBNull.Value || obj==null)
			{							
				return null;
			}			
			byte[] content = (byte[])obj;
			if (content.Length<=0) 							
				return null;
			System.IO.MemoryStream stream = new System.IO.MemoryStream(content);
			Bitmap image = new Bitmap(stream);
			return image;
		}

		public static object LoadImageObjectFromSQL(string sql)
		{		
			SqlConnection con =new SqlConnection(PublicFunction.C_con.ConnectionString);
			con.Open();
			SqlCommand Sqlcmd=new SqlCommand(sql,con );
			
			object obj = Sqlcmd.ExecuteScalar();
			con.Close();
			if (obj == System.DBNull.Value || obj==null)
			{							
				return null;
			}			
			byte[] content = (byte[])obj;
			if (content.Length<=0) 							
				return null;
			System.IO.MemoryStream stream = new System.IO.MemoryStream(content);
			Bitmap image = new Bitmap(stream);
			return image;
		}

		public static Image GetImageFromFile( string imageFile )
		{
			try
			{
				System.IO.FileStream f = new System.IO.FileStream( imageFile, System.IO.FileMode.Open);
				Image img = Image.FromStream( f, true );
				f.Close();
				return img; 				
			}
			catch { throw; }
		}
		public static byte[] ReadBitmapFromFile(string fileName)
		{
			using(Bitmap image = new Bitmap(fileName))
			{
				System.IO.MemoryStream stream = new System.IO.MemoryStream();
				image.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp);				
				return stream.ToArray();
			}
		}
		public static void UploadImageToSQL(string ImageFile,string Field,string Table,string where)
		{
			
			try
			{
				string sql=null;
				sql="update "+Table+" set "+Field+" =@image";
				if (where !="")
				{
					sql=sql+" where " + where;
				}
				SqlConnection con=new SqlConnection(PublicFunction.C_con.ConnectionString);
				con.Open();
				byte[] bytes = ImageFunction.ReadBitmapFromFile(ImageFile);
				SqlCommand sqlcmd =new SqlCommand(sql,con ); 
				SqlParameter  imageParameter = sqlcmd.Parameters.Add("@image",SqlDbType.Binary );
				imageParameter.Value =bytes ;
				imageParameter.Size =bytes.Length ;
				sqlcmd.ExecuteNonQuery(); 				
				con.Close();
			}
			catch
			{
				throw;
			}
		
		}

		public static void UploadDelImage(string ImageFile,string Field,string Table,string where)
		{
			
			try
			{
				string sql=null;
				sql="Delete from "+Table+" ";
				if (where !="")
				{
					sql=sql+" where " + where;
				}
				SqlConnection con=new SqlConnection(PublicFunction.C_con.ConnectionString);
				con.Open();
				//byte[] bytes=new byte(;
				SqlCommand sqlcmd =new SqlCommand(sql,con ); 				
				sqlcmd.ExecuteNonQuery(); 				
				con.Close();
			}
			catch
			{
				throw;
			}
		
		}

	}
}

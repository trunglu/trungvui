using System;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using Func;
using Basic;
using Basic.Function;

namespace Basic.Form
{
	internal class MultiColumnDropDown : System.Windows.Forms.Form
	{
		private int _row, _col,_cols;
		private C1.Win.C1FlexGrid.C1FlexGrid _ctl;
		private C1.Win.C1FlexGrid.C1FlexGrid _flex;
		private RecordSet rs;
		private string Field1,Field2,LabelID,SetField2;
		
		
		internal MultiColumnDropDown(C1.Win.C1FlexGrid.C1FlexGrid grid, int row, int col,RecordSet rs,string GetFieldName1,string LabelID,int Cols)
		{
			_ctl = grid;
			_row = row;
			_col = col;
			SetField2="";
			Field1=GetFieldName1;
			Field2="";
			this.rs=rs;
			this.LabelID=LabelID;
			_cols=Cols;
			Init();
		}
		internal MultiColumnDropDown(C1.Win.C1FlexGrid.C1FlexGrid grid, int row, int col,RecordSet rs,string GetFieldName1,string LabelID)
		{
			_ctl = grid;
			_row = row;
			_col = col;
			SetField2="";
			Field1=GetFieldName1;
			Field2="";
			this.rs=rs;
			this.LabelID=LabelID;
			_cols=rs.cols;
			Init();
		}
		internal MultiColumnDropDown(C1.Win.C1FlexGrid.C1FlexGrid grid, int row, int col,RecordSet rs,string GetFieldName1,string  SetFieldName2,string GetFieldName2,string LabelID,int Cols)
		{
			// save info to set value when done
			_ctl = grid;
			_row = row;
			_col = col;			
			Field1=GetFieldName1;
			SetField2=SetFieldName2;
			Field2=GetFieldName2;
			this.rs=rs;
			this.LabelID=LabelID;
			_cols=Cols;
			Init();
		}

		internal MultiColumnDropDown(C1.Win.C1FlexGrid.C1FlexGrid grid, int row, int col,RecordSet rs,string GetFieldName1,string  SetFieldName2,string GetFieldName2,string LabelID)
		{
			// save info to set value when done
			_ctl = grid;
			_row = row;
			_col = col;			
			Field1=GetFieldName1;
			SetField2=SetFieldName2;
			Field2=GetFieldName2;
			this.rs=rs;
			this.LabelID=LabelID;
			_cols=rs.cols;
			Init();
		}

		private void Init()
		{

			// initialize child flex control control
			_flex = new C1.Win.C1FlexGrid.C1FlexGrid();
			((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
			_flex.Dock			= DockStyle.Fill;
			_flex.BorderStyle	= C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			_flex.SelectionMode = SelectionModeEnum.Row;
			_flex.FocusRect		= FocusRectEnum.None;
			_flex.AllowEditing  = false;
			_flex.AutoSearch	= AutoSearchEnum.FromCursor;
			_flex.Rows.Count	= rs.rows+1;
			_flex.Cols.Fixed	= 0;
			_flex.KeyActionTab	= KeyActionEnum.MoveDown;
			_flex.TabIndex		= 0;
			_flex.Font			= _ctl.Font;
			_flex.Styles        = _ctl.Styles;
			((System.ComponentModel.ISupportInitialize)(this._flex)).EndInit();
			_flex.Cols.Count=_cols;
			for (int c=0;c<_cols;c++)
			{
				_flex.Cols[c].Name=rs.Field(c);
				_flex.Cols[c].Caption=Function.PublicFunction.L_GetLabel_VS(LabelID,_flex.Cols[c].Name); 
			}

			// populate child flex control control
			for (int r = 0; r < rs.rows; r++)
			{			
				for (int c = 0; c < _cols; c++)
					_flex[r+1, c] = rs.record(r,c);
			}

			// initialize selection
			_flex.Row = -1;
			string s = _ctl.GetDataDisplay(_row,_col);
			for (int r = 1; r < _flex.Rows.Count && _flex.Row < 0; r++)
				if (_flex.GetDataDisplay(r, 0) == s)
					_flex.Row = r;

			// initialize form
			Controls.Add(_flex);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			StartPosition = FormStartPosition.Manual;
			
			//SystemInformation.MaxWindowTrackSize.IsEmpty ;
			//MessageBox.Show(""+SystemInformation.MaxWindowTrackSize.Height);
			//MessageBox.Show(""+System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height);
	

			// set form size
			_flex.AutoSizeCols(4);
			int rows = Math.Min(10, _flex.Rows.Count);
			int cols = _flex.Cols.Count;
			int wid  = _flex.Cols[cols-1].Right + 2;
			int hei  = rows * _flex.Rows.DefaultSize + 2;
			if (rows < _flex.Rows.Count) wid += SystemInformation.VerticalScrollBarWidth;
			ClientSize = new Size(wid, hei);

			int ww=System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width;
			int hh=System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height;
			int x,y;

			// set form location
			Rectangle rc = _ctl.GetCellRect(_row, _col, true);
			rc = _ctl.RectangleToScreen(rc);
			if ((rc.Left+wid)<ww-50)
				x=rc.Left;
			else
				x=rc.Right-wid ;

			if ((rc.Bottom+hei)<hh-50)
				y=rc.Bottom  ;
			else
				y=rc.Top-hei ;

			Location = new Point(x ,y);




			// initialize event handlers
			Deactivate     += new System.EventHandler(_flex_Click);
			_flex.Click    += new System.EventHandler(_flex_Click);
			_flex.KeyDown  += new System.Windows.Forms.KeyEventHandler(_flex_KeyDown);
		}


		private void _flex_Click(object sender, System.EventArgs e)
		{
			Accept();
		}
		private void _flex_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.Down:		// initialize selection if we have to
					if (_flex.Row < 0 && _flex.Rows.Count > 1)
						_flex.Row = 0;						
					break;
				case Keys.Tab:		// close form on Tab, Enter, Left, Right keys
				case Keys.Enter:
				case Keys.Left:
				case Keys.Right:
					e.Handled = true;
					Accept();
					break;
				case Keys.Escape:	// cancel editing on escape key
					e.Handled = true;
					this.DialogResult=DialogResult.Cancel;
					_flex.Row = -1;					
					Close();
					break;
			}
		}
		private void Accept()
		{
			try
			{
				// save selection
				if (_flex.Row > -1)
				{
					_ctl[_row, _col] = _flex[_flex.Row,Field1];
					if (Field2!="")
						_ctl[_row, SetField2] = _flex[_flex.Row,Field2];
					rs.Bookmarks=_flex.Row-1;
					this.DialogResult=DialogResult.OK;
				}
			}
			catch(Exception){}			

			// close the form
			Close();
		}

		private void InitializeComponent()
		{
			// 
			// MultiColumnDropDown
			// 
			this.AutoScale = false;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
			this.ClientSize = new System.Drawing.Size(350, 306);
			this.Name = "MultiColumnDropDown";

		}


		
	}
}

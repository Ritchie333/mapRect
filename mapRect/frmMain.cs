using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MapRect
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			_points = new Stack<Point>();
			_tracks = new Stack<Point>();
			InitializeComponent();
		}		

		private void cmdOpen_Click( object sender, EventArgs e )
		{
			OpenFileDialog dialog = new OpenFileDialog();
			if ( dialog.ShowDialog() == DialogResult.OK ) {
				_fileName = dialog.FileName;
				this.Cursor = Cursors.WaitCursor;
				picMap.Image = Image.FromFile( _fileName );
				Text = "Map point tracker - " + _fileName;
				this.Cursor = Cursors.Default;
				_points.Clear();
				_tracks.Clear();
				if( _config != null && _config.Horizontal.Start > 0 && _config.Vertical.Start > 0 ) {
					_tracks.Push( new Point( _config.Horizontal.Start, _config.Vertical.Start ) );
				}
			}
		}

		private void cmdClose_Click( object sender, EventArgs e )
		{		
			Close();
		}

		private Point GetPosition( MouseEventArgs e )
		{
			//return new Point( e.X - picMap.Left, e.Y - picMap.Top );
			return new Point( e.X, e.Y );
		}

		private Point NextTrack()
		{
			Point current = _tracks.Peek();
			Point next = new Point();
			if ( current.X == _config.Horizontal.End ) {
				int nextY = current.Y - ( _config.Vertical.Every - ( current.Y % _config.Vertical.Every ) );
				if( current.Y == _config.Vertical.Start && ( current.Y % _config.Vertical.Every > 0 ) ) {
					nextY = current.Y - ( current.Y % _config.Vertical.Every );
				}
				if ( nextY < _config.Vertical.End ) {
					nextY = _config.Vertical.End;
				}
				next.Y = nextY;
				next.X = _config.Horizontal.Start;
			} else {
				int nextX = current.X + ( _config.Horizontal.Every - ( current.X % _config.Horizontal.Every ) );
				if ( nextX > _config.Horizontal.End ) {
					nextX = _config.Horizontal.End;
				}
				next.X = nextX;
				next.Y = current.Y;
			}
			return next;
		}

		private string FormatPosition( MouseEventArgs e, bool useConfig )
		{
			Point p = GetPosition( e );
			string text = string.Empty;
			if ( useConfig && _config != null && _tracks.Count > 0 ) {
				Point current = _tracks.Peek();
				text = string.Format( "os,{0}:{1},{2},{3}", current.X, current.Y, p.X, p.Y );				
			} else {
				text = string.Format( "{0},{1}", p.X, p.Y );
			}
			return text;
		}

		private void picMap_MouseUp( object sender, MouseEventArgs e )
		{			
			txtTrack.Text += ( FormatPosition( e, true ) + Environment.NewLine );
			txtTrack.SelectionStart = txtTrack.TextLength;
			AddPoint( e );
		}

		private void picMap_MouseMove( object sender, MouseEventArgs e )
		{
			lblTrack.Text = FormatPosition( e, false );			
		}

		private void AddPoint( MouseEventArgs e )
		{
			_points.Push( new Point( e.X, e.Y ) );
			if ( _config != null && _tracks.Count > 0 ) {
				_tracks.Push( NextTrack() );
			}
			picMap.Invalidate( true );
		}	

		private void cmdClear_Click( object sender, EventArgs e )
		{
			lblTrack.Text = string.Empty;
			txtTrack.Text = string.Empty;
			_points.Clear();
			if ( _config != null ) {
				_tracks.Clear();
				_tracks.Push( new Point( _config.Horizontal.Start, _config.Vertical.Start ) );
			}
		}

		private void ClearLine()		
		{
			string newText = string.Empty;
			for ( int i = 0; i < txtTrack.Lines.Length - 2; i++ ) {
				newText += txtTrack.Lines[ i ] + Environment.NewLine;
			}
			txtTrack.Text = newText;
			txtTrack.SelectionStart = txtTrack.TextLength;
		}

		private void cmdUndo_Click( object sender, EventArgs e )
		{
			if ( _points.Count > 0 ) {
				_points.Pop();
				if ( _tracks.Count > 0 ) {
					_tracks.Pop();
				}
				ClearLine();
				picMap.Invalidate( true );
			}
		}

		private void picMap_Paint( object sender, PaintEventArgs e )
		{			
			foreach ( Point p in _points ) {
				e.Graphics.FillEllipse( Brushes.Red, p.X - 5, p.Y - 5, 10, 10 );
			}			
		}

		private void cmdSave_Click( object sender, EventArgs e )
		{
			SaveFileDialog dialog = new SaveFileDialog();
			if ( !string.IsNullOrEmpty( _fileName ) ) {
				dialog.FileName = Path.GetFileNameWithoutExtension( _fileName ) + ".csv";
				dialog.DefaultExt = "csv";
			}
			if ( DialogResult.OK == dialog.ShowDialog() ) {
				try {
					using ( StreamWriter writer = new StreamWriter( dialog.FileName ) ) {
						writer.Write( txtTrack.Text );
					}
				} catch ( InvalidOperationException ex ) {
					MessageBox.Show( ex.Message );
				}
			}
		}

		private void cmdConfig_Click( object sender, EventArgs e )
		{
			ConfigDialog dialog = new ConfigDialog();
			dialog.Init( _config );
			dialog.FormClosed += OnConfigClosed;
			dialog.Show( this /* owner */ );
		}

		private void OnConfigClosed( object sender, EventArgs e )
		{
			ConfigDialog dialog = ( ConfigDialog ) sender;			
			if ( DialogResult.OK == dialog.DialogResult ) {
				_config = dialog.Config;
				_tracks.Clear();
				_tracks.Push( new Point( _config.Horizontal.Start, _config.Vertical.Start ) );
			}
		}

		private Stack<Point> _tracks;		

		private Stack<Point> _points;

		private Configuration _config;

		private string _fileName;
	}
}

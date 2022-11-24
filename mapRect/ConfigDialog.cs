using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MapRect
{
	public partial class ConfigDialog : Form
	{
		public ConfigDialog()
		{
			InitializeComponent();
		}

		public void Init( Configuration config )
		{
			if ( config != null ) {

				SetConfigValue( txtHorizStart, config.Horizontal.Start );
				SetConfigValue( txtHorizRepeat, config.Horizontal.Every );
				SetConfigValue( txtHorizEnd, config.Horizontal.End );

				SetConfigValue( txtVertStart, config.Vertical.Start );
				SetConfigValue( txtVertRepeat, config.Vertical.Every );
				SetConfigValue( txtVertEnd, config.Vertical.End );
			} else {
				ClearValues();
			}
		}

		public Configuration Config
		{
			get
			{
				ConfigurationEntry horiz = new ConfigurationEntry( GetConfigValue( txtHorizStart ),
						GetConfigValue( txtHorizRepeat ), GetConfigValue( txtHorizEnd ) );
				ConfigurationEntry vert = new ConfigurationEntry( GetConfigValue( txtVertStart ),
						GetConfigValue( txtVertRepeat ), GetConfigValue( txtVertEnd ) );
				return new Configuration( horiz, vert );
			}
		}

		private int GetConfigValue( TextBox box )
		{
			if( !string.IsNullOrEmpty( box.Text ) ) {
				return Convert.ToInt32( box.Text );
			} else {
				return 0;
			}
		}

		private void SetConfigValue( TextBox box, int value )
		{
			if( value > 0 ) {
				box.Text = value.ToString();
			} else {
				box.Text = string.Empty;
			}
		}

		private void ClearValues()
		{
			Array.ForEach( new TextBox[] { txtHorizStart, txtHorizRepeat, txtHorizEnd, txtVertStart, txtVertRepeat, txtVertEnd },
						( box ) => { box.Text = string.Empty; } );
		}

		private void OnTextChanged( object sender, EventArgs e )
		{
			TextBox box = ( TextBox ) sender;
			int result;
			if ( !Int32.TryParse( box.Text, out result ) ) {
				box.Text = string.Empty;
			}
		}

		private void cmdCancel_Click( object sender, EventArgs e )
		{
			Close();
		}

		private void cmdOK_Click( object sender, EventArgs e )
		{
			Close();
		}

		private void cmdClear_Click( object sender, EventArgs e )
		{
			ClearValues();
		}
	}
}

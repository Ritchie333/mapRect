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

		public Configuration Config
		{
			get
			{
				ConfigurationEntry horiz = new ConfigurationEntry( Convert.ToInt32( txtHorizStart.Text ),
						Convert.ToInt32( txtHorizRepeat.Text ), Convert.ToInt32( txtHorizEnd.Text ) );
				ConfigurationEntry vert = new ConfigurationEntry( Convert.ToInt32( txtVertStart.Text ),
						Convert.ToInt32( txtVertRepeat.Text ), Convert.ToInt32( txtVertEnd.Text ) );
				return new Configuration( horiz, vert );
			}
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
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MapRect
{
	public class ConfigurationEntry
	{
		public ConfigurationEntry( int _start, int _every, int _end )
		{
			Start = _start;
			Every = _every;
			End = _end;
		}

		public int Start;
		public int Every;
		public int End;
	}

	public class Configuration
	{
		public Configuration( ConfigurationEntry _horizontal, ConfigurationEntry _vertical )
		{
			Horizontal = _horizontal;
			Vertical = _vertical;
		}

		public ConfigurationEntry Horizontal;
		public ConfigurationEntry Vertical;
	}
}

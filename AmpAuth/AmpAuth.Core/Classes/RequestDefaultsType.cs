using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace AmpAuth.Core
{
	[DebuggerStepThrough]
	public class RequestDefaultsType
	{
		#region Private fields
		private string _item;
		#endregion

		public string Item
		{
			get
			{
				return _item;
			}
			set
			{
				_item = value;
			}
		}
	}
}

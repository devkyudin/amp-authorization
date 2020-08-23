using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Serialization;

namespace AmpAuth.Core
{
	[DebuggerStepThrough]
	public class StatusDetailType
	{
		#region Private fields
		private List<System.Xml.XmlElement> _any;
		#endregion

		[XmlAnyElement()]
		public List<System.Xml.XmlElement> Any
		{
			get
			{
				return _any;
			}
			set
			{
				_any = value;
			}
		}
	}
}
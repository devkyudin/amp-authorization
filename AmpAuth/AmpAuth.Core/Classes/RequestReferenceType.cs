using System.Collections.Generic;
using System.Diagnostics;

namespace AmpAuth.Core
{
	[DebuggerStepThrough]
	public class RequestReferenceType
	{
		#region Private fields
		private List<AttributesReferenceType> _attributesReference;
		#endregion

		public List<AttributesReferenceType> AttributesReference
		{
			get
			{
				return _attributesReference;
			}
			set
			{
				_attributesReference = value;
			}
		}
	}
}
using System.Collections.Generic;
using System.Diagnostics;

namespace AmpAuth.Core
{
	[DebuggerStepThrough]
	public class MultiRequestsType
	{
		#region Private fields
		private List<AttributesReferenceType> _requestReference;
		#endregion

		public List<AttributesReferenceType> RequestReference
		{
			get
			{
				return _requestReference;
			}
			set
			{
				_requestReference = value;
			}
		}
	}
}
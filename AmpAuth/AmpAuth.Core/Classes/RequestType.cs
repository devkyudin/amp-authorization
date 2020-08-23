using System.Collections.Generic;
using System.Diagnostics;

namespace AmpAuth.Core
{
	[DebuggerStepThrough]
	public class RequestType
	{
		#region Private fields
		private List<RequestDefaultsType> _requestDefaults;
		private List<AttributesType> _attributes;
		private AttributesReferenceType[][][] _multiRequests;
		private bool _returnPolicyIdList;
		#endregion

		public List<RequestDefaultsType> RequestDefaults
		{
			get
			{
				return _requestDefaults;
			}
			set
			{
				_requestDefaults = value;
			}
		}

		public List<AttributesType> Attributes
		{
			get
			{
				return _attributes;
			}
			set
			{
				_attributes = value;
			}
		}

		public AttributesReferenceType[][][] MultiRequests
		{
			get
			{
				return _multiRequests;
			}
			set
			{
				_multiRequests = value;
			}
		}

		public bool ReturnPolicyIdList
		{
			get
			{
				return _returnPolicyIdList;
			}
			set
			{
				_returnPolicyIdList = value;
			}
		}
	}
}

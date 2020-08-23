using System.Diagnostics;

namespace AmpAuth.Core
{
	[DebuggerStepThrough]
	public class StatusType
	{
		#region Private fields
		private StatusCodeType _statusCode;
		private string _statusMessage;
		private StatusDetailType _statusDetail;
		#endregion

		public StatusCodeType StatusCode
		{
			get
			{
				return _statusCode;
			}
			set
			{
				_statusCode = value;
			}
		}

		public string StatusMessage
		{
			get
			{
				return _statusMessage;
			}
			set
			{
				_statusMessage = value;
			}
		}

		public StatusDetailType StatusDetail
		{
			get
			{
				return _statusDetail;
			}
			set
			{
				_statusDetail = value;
			}
		}
	}
}
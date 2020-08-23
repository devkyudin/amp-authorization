using System.Collections.Generic;
using System.Diagnostics;

namespace AmpAuth.Core
{
	[DebuggerStepThrough]
	public class ResponseType
	{
		#region Private fields
		private List<ResultType> _result;
		#endregion

		public List<ResultType> Result
		{
			get
			{
				return _result;
			}
			set
			{
				_result = value;
			}
		}
	}
}
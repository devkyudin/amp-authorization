using System.Diagnostics;

namespace AmpAuth.Core
{
	[DebuggerStepThrough]
	public class AttributesReferenceType
	{
		#region Private fields
		private string _referenceId;
		#endregion

		public string ReferenceId
		{
			get
			{
				return _referenceId;
			}
			set
			{
				_referenceId = value;
			}
		}
	}
}
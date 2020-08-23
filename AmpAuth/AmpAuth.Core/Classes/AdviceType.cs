using System.Collections.Generic;
using System.Diagnostics;

namespace AmpAuth.Core
{
	[DebuggerStepThrough]
	public class AdviceType
	{
		#region Private fields
		private List<AttributeAssignmentType> _attributeAssignment;
		private string _adviceId;
		#endregion

		public List<AttributeAssignmentType> AttributeAssignment
		{
			get
			{
				return _attributeAssignment;
			}
			set
			{
				_attributeAssignment = value;
			}
		}

		public string AdviceId
		{
			get
			{
				return _adviceId;
			}
			set
			{
				_adviceId = value;
			}
		}
	}
}
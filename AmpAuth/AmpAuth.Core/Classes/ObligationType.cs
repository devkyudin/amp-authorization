using System.Collections.Generic;
using System.Diagnostics;

namespace AmpAuth.Core
{
	[DebuggerStepThrough]
	public class ObligationType
	{
		#region Private fields
		private List<AttributeAssignmentType> _attributeAssignment;
		private string _obligationId;
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

		public string ObligationId
		{
			get
			{
				return _obligationId;
			}
			set
			{
				_obligationId = value;
			}
		}
	}
}
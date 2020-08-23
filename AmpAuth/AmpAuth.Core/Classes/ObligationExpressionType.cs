using System.Collections.Generic;
using System.Diagnostics;

namespace AmpAuth.Core
{
	[DebuggerStepThrough]
	public class ObligationExpressionType
	{
		#region Private fields
		private List<AttributeAssignmentExpressionType> _attributeAssignmentExpression;
		private string _obligationId;
		private EffectType _fulfillOn;
		#endregion

		public List<AttributeAssignmentExpressionType> AttributeAssignmentExpression
		{
			get
			{
				return _attributeAssignmentExpression;
			}
			set
			{
				_attributeAssignmentExpression = value;
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

		public EffectType FulfillOn
		{
			get
			{
				return _fulfillOn;
			}
			set
			{
				_fulfillOn = value;
			}
		}
	}
}
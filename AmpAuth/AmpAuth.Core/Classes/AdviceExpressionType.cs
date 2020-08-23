using System.Collections.Generic;
using System.Diagnostics;

namespace AmpAuth.Core
{
	[DebuggerStepThrough]
	public class AdviceExpressionType
	{
		#region Private fields
		private List<AttributeAssignmentExpressionType> _attributeAssignmentExpression;
		private string _adviceId;
		private EffectType _appliesTo;
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

		public EffectType AppliesTo
		{
			get
			{
				return _appliesTo;
			}
			set
			{
				_appliesTo = value;
			}
		}
	}
}
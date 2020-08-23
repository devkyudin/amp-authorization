using System.Collections.Generic;
using System.Diagnostics;

namespace AmpAuth.Core
{
	[DebuggerStepThrough]
	public class RuleType
	{
		#region Private fields
		private string _description;
		private TargetType _target;
		private ConditionType _condition;
		private List<ObligationExpressionType> _obligationExpressions;
		private List<AdviceExpressionType> _adviceExpressions;
		private string _ruleId;
		private EffectType _effect;
		#endregion

		public string Description
		{
			get
			{
				return _description;
			}
			set
			{
				_description = value;
			}
		}

		public TargetType Target
		{
			get
			{
				return _target;
			}
			set
			{
				_target = value;
			}
		}

		public ConditionType Condition
		{
			get
			{
				return _condition;
			}
			set
			{
				_condition = value;
			}
		}

		public List<ObligationExpressionType> ObligationExpressions
		{
			get
			{
				return _obligationExpressions;
			}
			set
			{
				_obligationExpressions = value;
			}
		}

		public List<AdviceExpressionType> AdviceExpressions
		{
			get
			{
				return _adviceExpressions;
			}
			set
			{
				_adviceExpressions = value;
			}
		}

		public string RuleId
		{
			get
			{
				return _ruleId;
			}
			set
			{
				_ruleId = value;
			}
		}

		public EffectType Effect
		{
			get
			{
				return _effect;
			}
			set
			{
				_effect = value;
			}
		}
	}
}
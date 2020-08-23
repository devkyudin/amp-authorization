using System.Collections.Generic;
using System.Diagnostics;

namespace AmpAuth.Core
{
	[DebuggerStepThrough]
	public class PolicyType
	{
		#region Private fields
		private string _description;
		private PolicyIssuerType _policyIssuer;
		private DefaultsType _policyDefaults;
		private TargetType _target;
		private List<object> _items;
		private List<ObligationExpressionType> _obligationExpressions;
		private List<AdviceExpressionType> _adviceExpressions;
		private string _policyId;
		private string _version;
		private string _ruleCombiningAlgId;
		private string _maxDelegationDepth;
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

		public PolicyIssuerType PolicyIssuer
		{
			get
			{
				return _policyIssuer;
			}
			set
			{
				_policyIssuer = value;
			}
		}

		public DefaultsType PolicyDefaults
		{
			get
			{
				return _policyDefaults;
			}
			set
			{
				_policyDefaults = value;
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

		public List<object> Items
		{
			get
			{
				return _items;
			}
			set
			{
				_items = value;
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

		public string PolicyId
		{
			get
			{
				return _policyId;
			}
			set
			{
				_policyId = value;
			}
		}

		public string Version
		{
			get
			{
				return _version;
			}
			set
			{
				_version = value;
			}
		}

		public string RuleCombiningAlgId
		{
			get
			{
				return _ruleCombiningAlgId;
			}
			set
			{
				_ruleCombiningAlgId = value;
			}
		}

		public string MaxDelegationDepth
		{
			get
			{
				return _maxDelegationDepth;
			}
			set
			{
				_maxDelegationDepth = value;
			}
		}
	}
}
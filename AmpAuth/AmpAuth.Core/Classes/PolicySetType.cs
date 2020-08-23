using System.Collections.Generic;
using System.Diagnostics;

namespace AmpAuth.Core
{
	[DebuggerStepThrough]
	public class PolicySetType
	{
		#region Private fields
		private string _description;
		private PolicyIssuerType _policyIssuer;
		private DefaultsType _policySetDefaults;
		private TargetType _target;
		private object[] _items;
		private ItemsChoiceType[] _itemsElementName;
		private List<ObligationExpressionType> _obligationExpressions;
		private List<AdviceExpressionType> _adviceExpressions;
		private string _policySetId;
		private string _version;
		private string _policyCombiningAlgId;
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

		public DefaultsType PolicySetDefaults
		{
			get
			{
				return _policySetDefaults;
			}
			set
			{
				_policySetDefaults = value;
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

		public object[] Items
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

		public ItemsChoiceType[] ItemsElementName
		{
			get
			{
				return _itemsElementName;
			}
			set
			{
				_itemsElementName = value;
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

		public string PolicySetId
		{
			get
			{
				return _policySetId;
			}
			set
			{
				_policySetId = value;
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

		public string PolicyCombiningAlgId
		{
			get
			{
				return _policyCombiningAlgId;
			}
			set
			{
				_policyCombiningAlgId = value;
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
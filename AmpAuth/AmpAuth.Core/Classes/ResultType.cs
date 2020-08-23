using System.Collections.Generic;
using System.Diagnostics;

namespace AmpAuth.Core
{
	[DebuggerStepThrough]
	public class ResultType
	{
		#region Private fields
		private DecisionType _decision;
		private StatusType _status;
		private List<ObligationType> _obligations;
		private List<AdviceType> _associatedAdvice;
		private List<AttributesType> _attributes;
		private List<PolicyIdentifierType> _policyIdentifierList;
		#endregion

		public DecisionType Decision
		{
			get
			{
				return _decision;
			}
			set
			{
				_decision = value;
			}
		}

		public StatusType Status
		{
			get
			{
				return _status;
			}
			set
			{
				_status = value;
			}
		}

		public List<ObligationType> Obligations
		{
			get
			{
				return _obligations;
			}
			set
			{
				_obligations = value;
			}
		}

		public List<AdviceType> AssociatedAdvice
		{
			get
			{
				return _associatedAdvice;
			}
			set
			{
				_associatedAdvice = value;
			}
		}

		public List<AttributesType> Attributes
		{
			get
			{
				return _attributes;
			}
			set
			{
				_attributes = value;
			}
		}

		public List<PolicyIdentifierType> PolicyIdentifierList
		{
			get
			{
				return _policyIdentifierList;
			}
			set
			{
				_policyIdentifierList = value;
			}
		}
	}
}
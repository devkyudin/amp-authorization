using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace AmpAuth.Core.Classes
{
	[Serializable]
	[DesignerCategory("code")]
	[XmlType(AnonymousType = true, Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-11")]
	public class Policy
	{
		private PolicyCombinerParameter[] combinerParametersField;

		private string descriptionField;

		private string maxDelegationDepthField;

		private PolicySetPolicyPolicyDefaults policyDefaultsField;

		private string policyIdField;

		private PolicySetPolicyRuleCombinerParameters ruleCombinerParametersField;

		private string ruleCombiningAlgIdField;

		private PolicyAnyOfAllOfMatch[][][] targetField;

		private PolicySetPolicyVariableDefinition variableDefinitionField;

		private string versionField;

		/// <remarks />
		public string Description
		{
			get => descriptionField;
			set => descriptionField = value;
		}

		/// <remarks />
		public PolicySetPolicyPolicyDefaults PolicyDefaults
		{
			get => policyDefaultsField;
			set => policyDefaultsField = value;
		}

		/// <remarks />
		[XmlArrayItem("AnyOf", IsNullable = false)]
		[XmlArrayItem("AllOf", IsNullable = false, NestingLevel = 1)]
		[XmlArrayItem("Match", IsNullable = false, NestingLevel = 2)]
		public PolicyAnyOfAllOfMatch[][][] Target
		{
			get => targetField;
			set => targetField = value;
		}

		/// <remarks />
		[XmlArrayItem("CombinerParameter", IsNullable = false)]
		public PolicyCombinerParameter[] CombinerParameters
		{
			get => combinerParametersField;
			set => combinerParametersField = value;
		}

		/// <remarks />
		public PolicySetPolicyRuleCombinerParameters RuleCombinerParameters
		{
			get => ruleCombinerParametersField;
			set => ruleCombinerParametersField = value;
		}

		/// <remarks />
		public PolicySetPolicyVariableDefinition VariableDefinition
		{
			get => variableDefinitionField;
			set => variableDefinitionField = value;
		}

		/// <remarks />
		[XmlAttribute]
		public string PolicyId
		{
			get => policyIdField;
			set => policyIdField = value;
		}

		/// <remarks />
		[XmlAttribute]
		public string Version
		{
			get => versionField;
			set => versionField = value;
		}

		/// <remarks />
		[XmlAttribute]
		public string RuleCombiningAlgId
		{
			get => ruleCombiningAlgIdField;
			set => ruleCombiningAlgIdField = value;
		}

		/// <remarks />
		[XmlAttribute(DataType = "integer")]
		public string MaxDelegationDepth
		{
			get => maxDelegationDepthField;
			set => maxDelegationDepthField = value;
		}
	}
}

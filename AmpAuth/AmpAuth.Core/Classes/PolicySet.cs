using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace AmpAuth.Core.Classes
{
	[Serializable]
	[DesignerCategory("code")]
	[XmlType(AnonymousType = true, Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-11")]
	[XmlRoot(Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-11", IsNullable = false)]
	public class PolicySet
	{
		private string descriptionField;

		private byte maxDelegationDepthField;

		private string policyCombiningAlgIdField;

		private Policy policyField;

		private PolicySetPolicyIssuer policyIssuerField;

		private PolicySet policySet;

		private PolicySetPolicySetDefaults policySetDefaultsField;

		private string policySetIdField;

		private PolicySetPolicySetIdReference policySetIdReferenceField;

		private PolicySetAnyOfAllOfMatch[][][] targetField;

		private string versionField;

		/// <remarks />
		public string Description
		{
			get => descriptionField;
			set => descriptionField = value;
		}

		/// <remarks />
		public PolicySetPolicyIssuer PolicyIssuer
		{
			get => policyIssuerField;
			set => policyIssuerField = value;
		}

		/// <remarks />
		public PolicySetPolicySetDefaults PolicySetDefaults
		{
			get => policySetDefaultsField;
			set => policySetDefaultsField = value;
		}

		/// <remarks />
		[XmlArrayItem("AnyOf", IsNullable = false)]
		[XmlArrayItem("AllOf", IsNullable = false, NestingLevel = 1)]
		[XmlArrayItem("Match", IsNullable = false, NestingLevel = 2)]
		public PolicySetAnyOfAllOfMatch[][][] Target
		{
			get => targetField;
			set => targetField = value;
		}

		/// <remarks />
		[XmlElement("PolicySet")]
		public PolicySet PolicySet1
		{
			get => policySet;
			set => policySet = value;
		}

		/// <remarks />
		public Policy Policy
		{
			get => policyField;
			set => policyField = value;
		}

		/// <remarks />
		public PolicySetPolicySetIdReference PolicySetIdReference
		{
			get => policySetIdReferenceField;
			set => policySetIdReferenceField = value;
		}

		/// <remarks />
		[XmlAttribute]
		public string PolicySetId
		{
			get => policySetIdField;
			set => policySetIdField = value;
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
		public string PolicyCombiningAlgId
		{
			get => policyCombiningAlgIdField;
			set => policyCombiningAlgIdField = value;
		}

		/// <remarks />
		[XmlAttribute]
		public byte MaxDelegationDepth
		{
			get => maxDelegationDepthField;
			set => maxDelegationDepthField = value;
		}
	}

}

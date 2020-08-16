using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace AmpAuth.Core.Classes
{
	[Serializable]
	[DesignerCategory("code")]
	[XmlType(AnonymousType = true, Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-11")]
	public class PolicySetPolicySetPolicyAnyOfAllOfMatch
	{
		private PolicySetPolicySetPolicyAnyOfAllOfMatchAttributeDesignator attributeDesignatorField;

		private PolicySetPolicySetPolicyAnyOfAllOfMatchAttributeValue attributeValueField;

		private string matchIdField;

		/// <remarks />
		public PolicySetPolicySetPolicyAnyOfAllOfMatchAttributeValue AttributeValue
		{
			get => attributeValueField;
			set => attributeValueField = value;
		}

		/// <remarks />
		public PolicySetPolicySetPolicyAnyOfAllOfMatchAttributeDesignator AttributeDesignator
		{
			get => attributeDesignatorField;
			set => attributeDesignatorField = value;
		}

		/// <remarks />
		[XmlAttribute]
		public string MatchId
		{
			get => matchIdField;
			set => matchIdField = value;
		}
	}
}

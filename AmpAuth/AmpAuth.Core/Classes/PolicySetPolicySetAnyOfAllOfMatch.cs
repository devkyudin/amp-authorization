using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace AmpAuth.Core.Classes
{
	[Serializable]
	[DesignerCategory("code")]
	[XmlType(AnonymousType = true, Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-11")]
	public class PolicySetPolicySetAnyOfAllOfMatch
	{
		private PolicySetPolicySetAnyOfAllOfMatchAttributeDesignator attributeDesignatorField;

		private PolicySetPolicySetAnyOfAllOfMatchAttributeValue attributeValueField;

		private string matchIdField;

		/// <remarks />
		public PolicySetPolicySetAnyOfAllOfMatchAttributeValue AttributeValue
		{
			get => attributeValueField;
			set => attributeValueField = value;
		}

		/// <remarks />
		public PolicySetPolicySetAnyOfAllOfMatchAttributeDesignator AttributeDesignator
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

using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace AmpAuth.Core.Classes
{
	[Serializable]
	[DesignerCategory("code")]
	[XmlType(AnonymousType = true, Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-11")]
	public class PolicySetPolicySetPolicyIssuer
	{
		private PolicySetPolicySetPolicyIssuerAttribute[] attributeField;

		private PolicySetPolicySetPolicyIssuerContent contentField;

		/// <remarks />
		public PolicySetPolicySetPolicyIssuerContent Content
		{
			get => contentField;
			set => contentField = value;
		}

		/// <remarks />
		[XmlElement("Attribute")]
		public PolicySetPolicySetPolicyIssuerAttribute[] Attribute
		{
			get => attributeField;
			set => attributeField = value;
		}
	}

}

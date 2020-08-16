using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace AmpAuth.Core.Classes
{
	[Serializable]
	[DesignerCategory("code")]
	[XmlType(AnonymousType = true, Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-11")]
	public class PolicySetPolicySetPolicyIssuerAttribute
	{
		private string attributeIdField;

		private PolicySetPolicySetPolicyIssuerAttributeAttributeValue[] attributeValueField;

		private bool includeInResultField;

		private string issuerField;

		/// <remarks />
		[XmlElement("AttributeValue")]
		public PolicySetPolicySetPolicyIssuerAttributeAttributeValue[] AttributeValue
		{
			get => attributeValueField;
			set => attributeValueField = value;
		}

		/// <remarks />
		[XmlAttribute]
		public string AttributeId
		{
			get => attributeIdField;
			set => attributeIdField = value;
		}

		/// <remarks />
		[XmlAttribute]
		public string Issuer
		{
			get => issuerField;
			set => issuerField = value;
		}

		/// <remarks />
		[XmlAttribute]
		public bool IncludeInResult
		{
			get => includeInResultField;
			set => includeInResultField = value;
		}
	}

}

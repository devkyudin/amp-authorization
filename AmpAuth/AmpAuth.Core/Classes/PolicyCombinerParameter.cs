using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace AmpAuth.Core.Classes
{
	[Serializable]
	[DesignerCategory("code")]
	[XmlType(AnonymousType = true, Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-11")]
	public class PolicyCombinerParameter
	{
		private PolicySetPolicyCombinerParameterAttributeValue attributeValueField;

		private string parameterNameField;

		/// <remarks />
		public PolicySetPolicyCombinerParameterAttributeValue AttributeValue
		{
			get => attributeValueField;
			set => attributeValueField = value;
		}

		/// <remarks />
		[XmlAttribute]
		public string ParameterName
		{
			get => parameterNameField;
			set => parameterNameField = value;
		}
	}
}

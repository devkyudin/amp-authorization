using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace AmpAuth.Core.Classes
{
	[Serializable]
	[DesignerCategory("code")]
	[XmlType(AnonymousType = true, Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-11")]
	public class PolicySetPolicySetPolicyVariableDefinition
	{
		private string variableIdField;

		private PolicySetPolicySetPolicyVariableDefinitionVariableReference variableReferenceField;

		/// <remarks />
		public PolicySetPolicySetPolicyVariableDefinitionVariableReference VariableReference
		{
			get => variableReferenceField;
			set => variableReferenceField = value;
		}

		/// <remarks />
		[XmlAttribute]
		public string VariableId
		{
			get => variableIdField;
			set => variableIdField = value;
		}
	}
}

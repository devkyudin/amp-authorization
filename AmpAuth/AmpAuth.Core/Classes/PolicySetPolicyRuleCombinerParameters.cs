using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace AmpAuth.Core.Classes
{
	[Serializable]
	[DesignerCategory("code")]
	[XmlType(AnonymousType = true, Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-11")]
	public class PolicySetPolicyRuleCombinerParameters
	{
		private string ruleIdRefField;

		/// <remarks />
		[XmlAttribute]
		public string RuleIdRef
		{
			get => ruleIdRefField;
			set => ruleIdRefField = value;
		}
	}
}

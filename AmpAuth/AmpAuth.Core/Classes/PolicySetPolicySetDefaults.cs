using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace AmpAuth.Core.Classes
{
	[Serializable]
	[DesignerCategory("code")]
	[XmlType(AnonymousType = true, Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-11")]
	public class PolicySetPolicySetDefaults
	{
		private string xPathVersionField;

		/// <remarks />
		public string XPathVersion
		{
			get => xPathVersionField;
			set => xPathVersionField = value;
		}
	}
}

using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace AmpAuth.Core.Classes
{
	[Serializable]
	[DesignerCategory("code")]
	[XmlType(AnonymousType = true, Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-11")]
	public class PolicySetPolicyIssuerContent
	{
		private string any_AttrField;

		private string valueField;

		/// <remarks />
		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string any_Attr
		{
			get => any_AttrField;
			set => any_AttrField = value;
		}

		/// <remarks />
		[XmlText]
		public string Value
		{
			get => valueField;
			set => valueField = value;
		}
	}
}

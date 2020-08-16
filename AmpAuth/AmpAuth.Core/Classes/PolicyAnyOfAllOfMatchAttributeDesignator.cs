using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace AmpAuth.Core.Classes
{
	[Serializable]
	[DesignerCategory("code")]
	[XmlType(AnonymousType = true, Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-11")]
	public class PolicyAnyOfAllOfMatchAttributeDesignator
	{
		private string attributeIdField;

		private string categoryField;

		private string dataTypeField;

		private string issuerField;

		private bool mustBePresentField;

		/// <remarks />
		[XmlAttribute]
		public string Category
		{
			get => categoryField;
			set => categoryField = value;
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
		public string DataType
		{
			get => dataTypeField;
			set => dataTypeField = value;
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
		public bool MustBePresent
		{
			get => mustBePresentField;
			set => mustBePresentField = value;
		}
	}

}

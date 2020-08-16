using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Xml.Serialization;

namespace AmpAuth.Core.Classes
{
	[Serializable]
	[DesignerCategory("code")]
	[XmlType(AnonymousType = true, Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-11")]
	public class PolicySetPolicySetIdReference
	{
		private string earliestVersionField;

		private string latestVersionField;

		private string valueField;

		private string versionField;

		/// <remarks />
		[XmlAttribute]
		public string Version
		{
			get => versionField;
			set => versionField = value;
		}

		/// <remarks />
		[XmlAttribute]
		public string EarliestVersion
		{
			get => earliestVersionField;
			set => earliestVersionField = value;
		}

		/// <remarks />
		[XmlAttribute]
		public string LatestVersion
		{
			get => latestVersionField;
			set => latestVersionField = value;
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

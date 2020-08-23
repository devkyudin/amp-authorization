namespace AmpAuth.Core
{
	public class AttributeDesignatorType : ExpressionType
	{
		public string Category { get; set; }

		public string AttributeId { get; set; }

		public string DataType { get; set; }

		public string Issuer { get; set; }

		public bool MustBePresent { get; set; }
	}
}

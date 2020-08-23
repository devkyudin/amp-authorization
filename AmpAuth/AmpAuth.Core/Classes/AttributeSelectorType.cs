namespace AmpAuth.Core
{
	public class AttributeSelectorType : ExpressionType
	{
		public string Category { get; set; }

		public string RequestContextPath { get; set; }

		public string DataType { get; set; }

		public bool MustBePresent { get; set; }
	}
}

using System.Collections.Generic;

namespace AmpAuth.Core
{
	public class ApplyType : ExpressionType
	{
		public string Description { get; set; }

		public List<ExpressionType> Items { get; set; }

		public string FunctionId { get; set; }
	}
}

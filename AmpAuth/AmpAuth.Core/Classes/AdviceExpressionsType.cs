using System.Collections.Generic;
using System.Diagnostics;

namespace AmpAuth.Core
{
	[DebuggerStepThrough]
	public class AdviceExpressionsType
	{
		#region Private fields
		private List<AdviceExpressionType> _adviceExpression;
		#endregion

		public List<AdviceExpressionType> AdviceExpression
		{
			get
			{
				return _adviceExpression;
			}
			set
			{
				_adviceExpression = value;
			}
		}
	}
}
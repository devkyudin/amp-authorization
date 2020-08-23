using System.Collections.Generic;
using System.Diagnostics;

namespace AmpAuth.Core
{
	[DebuggerStepThrough]
	public class ObligationExpressionsType
	{
		#region Private fields
		private List<ObligationExpressionType> _obligationExpression;
		#endregion

		public List<ObligationExpressionType> ObligationExpression
		{
			get
			{
				return _obligationExpression;
			}
			set
			{
				_obligationExpression = value;
			}
		}
	}
}
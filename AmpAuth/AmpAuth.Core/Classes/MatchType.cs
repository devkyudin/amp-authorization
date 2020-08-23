using System.Diagnostics;

namespace AmpAuth.Core
{
	[DebuggerStepThrough]
	public class MatchType
	{
		#region Private fields
		private AttributeValueType _attributeValue;
		private ExpressionType _item;
		private string _matchId;
		#endregion

		public AttributeValueType AttributeValue
		{
			get
			{
				return _attributeValue;
			}
			set
			{
				_attributeValue = value;
			}
		}

		public ExpressionType Item
		{
			get
			{
				return _item;
			}
			set
			{
				_item = value;
			}
		}

		public string MatchId
		{
			get
			{
				return _matchId;
			}
			set
			{
				_matchId = value;
			}
		}
	}
}
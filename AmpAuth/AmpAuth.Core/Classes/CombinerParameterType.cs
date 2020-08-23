using System.Diagnostics;

namespace AmpAuth.Core
{
	[DebuggerStepThrough]
	public class CombinerParameterType
	{
		#region Private fields
		private AttributeValueType _attributeValue;
		private string _parameterName;
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

		public string ParameterName
		{
			get
			{
				return _parameterName;
			}
			set
			{
				_parameterName = value;
			}
		}
	}
}
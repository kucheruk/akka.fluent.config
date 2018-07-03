namespace Akka.Fluent.Config
{
	public class HoconKeyListValue : HoconKeyValue
	{
		private readonly string[] _values;

		public HoconKeyListValue(string name, string[] values) : base(name)
		{
			_values = values;
		}

		protected override string SerializedValue()
		{
			return $"[\"{string.Join("\", \"", _values)}\"]";
		}
	}
}
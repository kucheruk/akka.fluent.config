namespace Akka.Fluent.Config
{
	public class HoconKeyStringValue : HoconKeyValue
	{
		private readonly string _value;

		public HoconKeyStringValue(string name, string value) : base(name)
		{
			_value = value;
		}

		protected override string SerializedValue()
		{
			return $"\"{_value}\"";
		}
	}
}
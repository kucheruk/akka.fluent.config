namespace Akka.Fluent.Config
{
	public abstract class HoconKeyValue : HoconSection
	{
		protected HoconKeyValue(string name) : base(name)
		{
		}

		public override string ToConfig()
		{
			return $"{Name} = {SerializedValue()}\n";
		}

		protected abstract string SerializedValue();
	}
}
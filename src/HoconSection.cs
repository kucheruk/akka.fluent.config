namespace Akka.Fluent.Config
{
	public abstract class HoconSection
	{
		protected readonly string Name;

	    public HoconSection(string name)
		{
			Name = name;
		}

		public abstract string ToConfig();
	}
}
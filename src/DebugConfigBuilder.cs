namespace Akka.Fluent.Config
{
	public class DebugConfigBuilder : HoconConfigBuilder
	{
		public DebugConfigBuilder() : base("debug")

		{
		}

		public DebugConfigBuilder LogLifecycleChanges()
		{
			AddKeyValue("lifecycle", "on");
			return this;
		}

		public DebugConfigBuilder LogUnhandledMessages()
		{
			AddKeyValue("unhandled", "on");
			return this;
		}
	}
}
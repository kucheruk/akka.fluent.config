using System;

namespace Akka.Fluent.Config
{
	public class ActorConfigBuilder : HoconConfigBuilder
	{
		public ActorConfigBuilder() : base("actor")
		{
		}

		public ActorConfigBuilder SetClusterActorProvider()
		{
			AddKeyValue("provider", "cluster");
			return this;
		}


		public ActorConfigBuilder Debug(Action<DebugConfigBuilder> action)
		{
			var d = GetOrAdd("debug", () => new DebugConfigBuilder());
			action(d);
			return this;
		}
	}
}
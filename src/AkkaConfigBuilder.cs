using System;
using System.Collections.Generic;
using System.Linq;
using Akka.Event;
using Akka.Util;

namespace Akka.Fluent.Config
{
	public class AkkaConfigBuilder : HoconConfigBuilder
	{
		private static readonly Dictionary<LogLevel, string> logLevels = new Dictionary<LogLevel, string>
		{
			{Event.LogLevel.DebugLevel, "debug"},
			{Event.LogLevel.ErrorLevel, "error"},
			{Event.LogLevel.InfoLevel, "info"},
			{Event.LogLevel.WarningLevel, "warning"},
			{(LogLevel) int.MaxValue, "off"}
		};

		public AkkaConfigBuilder() : base("akka")
		{
		}

		public static LogLevel Off => (LogLevel) int.MaxValue;


		public AkkaConfigBuilder Actor(Action<ActorConfigBuilder> builder)
		{
			SectionBuilder("actor", builder);
			return this;
		}

		public AkkaConfigBuilder Cluster(Action<ClusterConfigBuilder> builder)
		{
			SectionBuilder("cluster", builder);
			return this;
		}

		public AkkaConfigBuilder LogConfigOnStart()
		{
			AddKeyValue("log-config-on-start", "on");
			return this;
		}

		public AkkaConfigBuilder LogLevel(LogLevel value)
		{
			var strValue = logLevels[value];
			AddKeyValue("loglevel", strValue);
			return this;
		}

		public AkkaConfigBuilder StdOutLogLevel(LogLevel level)
		{
			var strValue = logLevels[level];
			AddKeyValue("stdout-loglevel", strValue);
			return this;
		}

		public AkkaConfigBuilder Loggers(params Type[] types)
		{
			var strs = types.Select(t => t.TypeQualifiedName()).ToArray();
			AddKeyValue("loggers", strs);
			return this;
		}

		public AkkaConfigBuilder Persistence(Action<PersistenceConfigBuilder> builder)
		{
			SectionBuilder("persistence", builder);
			return this;
		}
	}
}
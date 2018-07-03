using System;

namespace Akka.Fluent.Config
{
    public class JournalConfigBuilder : HoconConfigBuilder
    {
        public JournalConfigBuilder() : base("journal")
        {
        }

        public JournalConfigBuilder Plugin(string plugin)
        {
            AddKeyValue("plugin", plugin);
            return this;
        }

        public JournalConfigBuilder MongoDB(Action<MongoDBConfigBuilder> action)
        {
            SectionBuilder("mongodb", action);
            return this;
        }
    }
}
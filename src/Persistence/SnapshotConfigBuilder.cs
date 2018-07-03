using System;

namespace Akka.Fluent.Config
{
    public class SnapshotConfigBuilder : HoconConfigBuilder
    {
        public SnapshotConfigBuilder() : base("snapshot-store")
        {
        }

        public SnapshotConfigBuilder Plugin(string plugin)
        {
            AddKeyValue("plugin", plugin);
            return this;
        }

        public SnapshotConfigBuilder MongoDB(Action<MongoDBConfigBuilder> action)
        {
            SectionBuilder("mongodb", action);
            return this;
        }

    }
}
using System;

namespace Akka.Fluent.Config
{
    public class PersistenceConfigBuilder : HoconConfigBuilder
    {
        public PersistenceConfigBuilder() : base("persistence")
        {
        }

        public PersistenceConfigBuilder Journal(Action<JournalConfigBuilder> builder)
        {
            SectionBuilder("journal", builder);
            return this;
        }

        public PersistenceConfigBuilder SnapshotStore(Action<SnapshotConfigBuilder> builder)
        {
            SectionBuilder("snapshot-store", builder);
            return this;
        }
    }
}
using System;
using Akka.Util;

namespace Akka.Fluent.Config
{
    public class MongoDBConfigBuilder : HoconConfigBuilder
    {
        public MongoDBConfigBuilder() : base("mongodb")
        {
        }

        public MongoDBConfigBuilder Class(Type @class)
        {
            AddKeyValue("class", @class.TypeQualifiedName());
            return this;
        }

        public MongoDBConfigBuilder ConnectionString(string cs)
        {
            AddKeyValue("connection-string", cs);
            return this;
        }

        public MongoDBConfigBuilder AutoInitialize(bool state)
        {
            AddKeyValue("auto-initialize", state);
            return this;
        }

        public MongoDBConfigBuilder Collection(string collection)
        {
            AddKeyValue("collection", collection);
            return this;
        }

        public MongoDBConfigBuilder DB(string db)
        {
            AddKeyValue("database", db);
            return this;
        }

        public MongoDBConfigBuilder PluginDispatcher(string dispatcher)
        {
            AddKeyValue("plugin-dispatcher", dispatcher);
            return this;
        }
        public MongoDBConfigBuilder MetadataCollection(string collection)
        {
            AddKeyValue("metadata-collection", collection);
            return this;
        }
    }
}
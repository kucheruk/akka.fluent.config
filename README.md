draft of fluent config builder for akka.net

```csharp
            AkkaConfigBuilder conf = new AkkaConfigBuilder()
                .Actor(a =>
                {
                    a.Debug(d =>
                    {
                        d.LogLifecycleChanges();
                        d.LogUnhandledMessages();
                    });
                    //a.SetClusterActorProvider();
                })
                .Persistence(p =>
                {
                    p.Journal(j =>
                    {
                        j.Plugin("akka.persistence.journal.mongodb");
                        j.MongoDB(m =>
                        {
                            m.ConnectionString(scc.Value.MongoConfig.MongoConnectionString + db);
                            m.AutoInitialize(false);
                            m.Collection("akka_persistence_journal");
                            m.MetadataCollection("akka_persistence_journal_meta");
                            m.Class(typeof(MongoDbJournal));
                        });
                    });
                    p.SnapshotStore(s =>
                    {
                        s.Plugin("akka.persistence.snapshot-store.mongodb");
                        s.MongoDB(m =>
                        {
                            m.ConnectionString(scc.Value.MongoConfig.MongoConnectionString + db);
                            m.AutoInitialize(false);
                            m.Collection("akka_persistence_snapshots");
                            m.MetadataCollection("akka_persistence_snapshots_meta");
                            m.Class(typeof(MongoDbSnapshotStore));
                        });
                    });
                })
                .Cluster(c => c.SeedNodes(new[] {"akka.tcp://postman@localhost:8081"}))
                .LogConfigOnStart()
                .LogLevel(LogLevel.Debug)
                .StdOutLogLevel(LogLevel.Info)
                .Loggers(typeof(StandardOutLogger), typeof(SerilogLogger));
'''
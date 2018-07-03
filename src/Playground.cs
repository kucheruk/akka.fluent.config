using System;
using System.Collections.Generic;
using System.Text;
using Akka.Event;

namespace Akka.Fluent.Config
{
//    class Playground
//    {
//	    public static string Test()
//	    {
//		    var conf = new AkkaConfigBuilder()
//			    .Actor(a =>
//			    {
//				    a.Debug(d =>
//				    {
//					    d.LogLifecycleChanges();
//					    d.LogUnhandledMessages();
//				    });
//				    //a.SetClusterActorProvider();
//			    })
//			    .Persistence(p =>
//			    {
//				    p.Journal(j =>
//				    {
//					    j.Plugin("akka.persistence.journal.mongodb");
//					    j.MongoDB(m =>
//					    {
//						    m.ConnectionString("...");
//						    m.AutoInitialize(false);
//						    m.Collection($"persistence_journal");
//						    m.MetadataCollection($"persistence_journal_meta");
//						    m.Class(typeof(MongoDbJournal));
//					    });
//				    });
//				    p.SnapshotStore(s =>
//				    {
//					    s.Plugin("akka.persistence.snapshot-store.mongodb");
//					    s.MongoDB(m =>
//					    {
//						    m.ConnectionString(cs);
//						    m.AutoInitialize(false);
//						    m.Collection($"{akkaPersistence}_snapshots");
//						    m.MetadataCollection($"{akkaPersistence}_snapshots_meta");
//						    m.Class(typeof(MongoDbSnapshotStore));
//					    });
//				    });
//			    })
//			    .Cluster(c => c.SeedNodes(new[] { "akka.tcp://postman@localhost:8081" }))
//			    .LogConfigOnStart()
//			    .LogLevel(AkkaLogLevel.Debug)
//			    .StdOutLogLevel(AkkaLogLevel.Info)
//			    .Loggers(typeof(StandardOutLogger), typeof(SerilogLogger));
//		    return conf.ToConfig();
//
//		}
//	}
}

namespace Akka.Fluent.Config
{
	public class ClusterConfigBuilder : HoconConfigBuilder
	{
		public ClusterConfigBuilder() : base("cluster")
		{
		}

		public ClusterConfigBuilder SeedNodes(string[] nodes)
		{
			AddKeyValue("seed-nodes", nodes);
			return this;
		}
	}
}
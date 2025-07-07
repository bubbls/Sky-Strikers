using Moon.MultiPlay;

namespace Moon.Profiler
{
	public class NetworkSimulationDebugPanel : IDebugPanelInterface
	{
		private ConnectionManager _connectionManager;

		public string DebugPanelName => null;

		public bool DebugPanelEnable => false;

		public string DebugPanelTitle => null;

		public void OnDebugPanelInitialize(IDebugPanelDrawContext ctx)
		{
		}

		public void OnDebugPanelRelease()
		{
		}
	}
}

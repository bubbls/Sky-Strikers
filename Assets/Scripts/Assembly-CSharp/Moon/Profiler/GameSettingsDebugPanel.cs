namespace Moon.Profiler
{
	public class GameSettingsDebugPanel : IDebugPanelInterface
	{
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

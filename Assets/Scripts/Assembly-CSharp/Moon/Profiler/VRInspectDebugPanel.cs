namespace Moon.Profiler
{
	public class VRInspectDebugPanel : IDebugPanelInterface
	{
		private VRInspectMode _inspectMode;

		public string DebugPanelName => null;

		public bool DebugPanelEnable => false;

		public string DebugPanelTitle => null;

		public VRInspectDebugPanel(VRInspectMode inspectMode)
		{
		}

		public void OnDebugPanelInitialize(IDebugPanelDrawContext ctx)
		{
		}

		public void OnDebugPanelRelease()
		{
		}
	}
}

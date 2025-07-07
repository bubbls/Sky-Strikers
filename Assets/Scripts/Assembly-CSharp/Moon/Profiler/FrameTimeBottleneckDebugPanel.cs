namespace Moon.Profiler
{
	public class FrameTimeBottleneckDebugPanel : IDebugPanelInterface
	{
		private TextGetter _GetBalancedCount;

		private TextGetter _GetCPUCount;

		private TextGetter _GetGPUCount;

		private TextGetter _GetPresentLimitedCount;

		public string DebugPanelName => null;

		public bool DebugPanelEnable => false;

		public string DebugPanelTitle => null;

		public void OnDebugPanelInitialize(IDebugPanelDrawContext ctx)
		{
		}

		public void OnDebugPanelRelease()
		{
		}

		private string GetBalancedCount()
		{
			return null;
		}

		private string GetCPUCount()
		{
			return null;
		}

		private string GetGPUCount()
		{
			return null;
		}

		private string GetPresentLimitedCount()
		{
			return null;
		}
	}
}

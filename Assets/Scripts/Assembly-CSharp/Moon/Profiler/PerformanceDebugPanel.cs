namespace Moon.Profiler
{
	public class PerformanceDebugPanel : IDebugPanelInterface
	{
		private TextGetter _GetCurrentFPS;

		private TextGetter _GetCurrentJank;

		private TextGetter _GetCurrentStutter;

		private TextGetter _GetCurrentStandardDeviation;

		private bool _singlePause;

		public string DebugPanelName => null;

		public bool DebugPanelEnable => false;

		public string DebugPanelTitle => null;

		public void OnDebugPanelInitialize(IDebugPanelDrawContext ctx)
		{
		}

		public void OnDebugPanelRelease()
		{
		}

		private string GetCurrentFPS()
		{
			return null;
		}

		private string GetCurrentJank()
		{
			return null;
		}

		private string GetCurrentStutter()
		{
			return null;
		}

		private string GetCurrentStandardDeviation()
		{
			return null;
		}
	}
}

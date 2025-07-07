using UnityEngine.Scripting;

namespace Moon.Profiler
{
	[Preserve]
	public class ProfilerDebugPanel : IDebugPanelInterface
	{
		private string _name;

		private ProfilerLogFileExporter _exporter;

		public string DebugPanelName => null;

		public bool DebugPanelEnable => false;

		public string DebugPanelTitle => null;

		public ProfilerDebugPanel(string name, ProfilerLogFileExporter exporter)
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

namespace Moon.Profiler
{
	public interface IDebugPanelInterface
	{
		string DebugPanelName { get; }

		bool DebugPanelEnable { get; }

		string DebugPanelTitle { get; }

		void OnDebugPanelInitialize(IDebugPanelDrawContext ctx);

		void OnDebugPanelRelease();
	}
}

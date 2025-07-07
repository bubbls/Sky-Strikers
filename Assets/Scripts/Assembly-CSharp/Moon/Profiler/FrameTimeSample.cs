namespace Moon.Profiler
{
	public struct FrameTimeSample
	{
		public float FramesPerSecond;

		public float FullFrameTime;

		public float MainThreadCPUFrameTime;

		public float MainThreadCPUPresentWaitTime;

		public float RenderThreadCPUFrameTime;

		public float GPUFrameTime;

		public FrameTimeSample(float initValue)
		{
			FramesPerSecond = 0f;
			FullFrameTime = 0f;
			MainThreadCPUFrameTime = 0f;
			MainThreadCPUPresentWaitTime = 0f;
			RenderThreadCPUFrameTime = 0f;
			GPUFrameTime = 0f;
		}
	}
}

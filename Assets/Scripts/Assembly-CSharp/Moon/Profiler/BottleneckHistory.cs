using System.Collections.Generic;

namespace Moon.Profiler
{
	public class BottleneckHistory
	{
		private List<PerformanceBottleneck> _bottlenecks;

		public BottleneckHistogram Histogram;

		public BottleneckHistory(int initialCapacity)
		{
		}

		public void DiscardOldSamples(int historySize)
		{
		}

		public void AddBottleneckFromAveragedSample(FrameTimeSample frameHistorySampleAverage)
		{
		}

		public void ComputeHistogram()
		{
		}

		private static PerformanceBottleneck DetermineBottleneck(FrameTimeSample s)
		{
			return default(PerformanceBottleneck);
		}

		public void Clear()
		{
		}
	}
}

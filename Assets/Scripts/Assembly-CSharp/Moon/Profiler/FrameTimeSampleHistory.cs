using System;
using System.Collections.Generic;

namespace Moon.Profiler
{
	public class FrameTimeSampleHistory
	{
		private List<FrameTimeSample> _samples;

		public FrameTimeSample SampleAverage;

		public FrameTimeSample SampleMin;

		public FrameTimeSample SampleMax;

		private static readonly Func<float, float, float> _sampleValueAdd;

		private static readonly Func<float, float, float> _sampleValueMin;

		private static readonly Func<float, float, float> _sampleValueMax;

		private static readonly Func<float, float, float> _sampleValueCountValid;

		private static readonly Func<float, float, float> _sampleValueEnsureValid;

		private static readonly Func<float, float, float> _sampleValueDivide;

		public FrameTimeSampleHistory(int initialCapacity)
		{
		}

		public void Add(FrameTimeSample sample)
		{
		}

		public void ComputeAggregateValues()
		{
		}

		public void DiscardOldSamples(int sampleHistorySize)
		{
		}

		public void Clear()
		{
		}
	}
}

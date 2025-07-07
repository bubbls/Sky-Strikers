using UnityEngine;

namespace Moon.Profiler
{
	public class DebugFrameTiming : MonoBehaviour
	{
		private const float _refreshRate = 0.2f;

		private static FrameTimeSampleHistory _frameHistory;

		private static BottleneckHistory _bottleneckHistory;

		private static bool _enabled;

		private FrameTiming[] _timing;

		private FrameTimeSample _sample;

		public static bool Enabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static int BottleneckHistorySize { get; set; }

		public static int SampleHistorySize { get; set; }

		public void Update()
		{
		}

		public static float GetBalancedCount()
		{
			return 0f;
		}

		public static float GetCPUCount()
		{
			return 0f;
		}

		public static float GetGPUCount()
		{
			return 0f;
		}

		public static float GetPresentLimitedCount()
		{
			return 0f;
		}

		public static void Reset()
		{
		}
	}
}

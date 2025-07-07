using System.Collections.Generic;
using Chamber8.Framework.Common;
using Unity.Profiling;

namespace Moon.Benchmark
{
	public class RuntimeProfiler : Singleton<RuntimeProfiler>
	{
		private ProfilerRecorder _totalUsedMemory;

		private ProfilerRecorder _totalReservedMemory;

		private ProfilerRecorder _systemUsedMemory;

		private ProfilerRecorder _gcUsedMemory;

		private ProfilerRecorder _gcReservedMemory;

		private readonly List<string> _startedFrom;

		public void Start(string from)
		{
		}

		public void Stop(string from)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}

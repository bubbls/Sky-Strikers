using System;
using System.Collections.Generic;
using System.Diagnostics;
using Chamber8.Framework.Common;

namespace Moon.Analytics
{
	public class Session : Singleton<Session>
	{
		private readonly Dictionary<string, Stopwatch> _stopwatches;

		private readonly Dictionary<string, TimeSpan> _timeSpans;

		private readonly Dictionary<string, int> _touches;

		private readonly Stopwatch _sessionStopwatch;

		private TimeSpan _lastSessionDuration;

		public double LastSessionDuration => 0.0;

		public double SessionElapsedTime => 0.0;

		public bool IsIsNewAccount { get; private set; }

		public void Touch(string name)
		{
		}

		private void IncrTimeSpan(string name, TimeSpan timeSpan)
		{
		}

		public void StartTimer(string name)
		{
		}

		public void StopTimer(string name)
		{
		}

		public void StopAllTimers()
		{
		}

		public void SessionStart()
		{
		}

		public void SessionEnd()
		{
		}

		public void SetNewInstallSession(bool isNewAccount)
		{
		}

		public void FillParameters(Dictionary<string, object> parameters)
		{
		}
	}
}

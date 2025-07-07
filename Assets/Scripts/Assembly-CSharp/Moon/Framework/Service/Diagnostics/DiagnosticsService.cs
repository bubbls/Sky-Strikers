using System;
using System.Collections.Generic;
using UnityEngine.Scripting;

namespace Moon.Framework.Service.Diagnostics
{
	[Preserve]
	public class DiagnosticsService
	{
		public enum Result
		{
			Success = 0,
			Failed = 1,
			InProgress = 2
		}

		public void SendDiag(string userId, string source, string reportSummaryAppendage, Dictionary<string, byte[]>? attachements = null, Dictionary<string, string>? metaData = null, Action<float, string?>? onProgressUpdated = null, Action<Result, string?>? onComplete = null)
		{
		}
	}
}

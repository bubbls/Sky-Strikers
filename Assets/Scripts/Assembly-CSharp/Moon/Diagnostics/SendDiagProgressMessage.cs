using Moon.Framework.Service.Diagnostics;

namespace Moon.Diagnostics
{
	public class SendDiagProgressMessage
	{
		public DiagnosticsService.Result Result;

		public float? Progress;

		public string? ReportId;

		private static readonly SendDiagProgressMessage _static;

		public static SendDiagProgressMessage Reset(string? reportId, float progress, DiagnosticsService.Result result)
		{
			return null;
		}

		public static SendDiagProgressMessage Reset(string? reportId, DiagnosticsService.Result result)
		{
			return null;
		}
	}
}

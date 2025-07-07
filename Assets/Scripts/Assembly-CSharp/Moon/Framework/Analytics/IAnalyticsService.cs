using System.Collections.Generic;

namespace Moon.Framework.Analytics
{
	public interface IAnalyticsService
	{
		void Register(IAnalytics analytics);

		void Log(string eventName, IDictionary<string, object> parameters = null);

		void FlushLogs();

		void SetSuperProperties(IDictionary<string, object> properties);

		void SetUserProperties(IDictionary<string, object> properties);
	}
}

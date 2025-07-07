using System.Collections.Generic;
using Chamber8.Framework.Common;

namespace Moon.Framework.Analytics
{
	public interface IAnalytics : IInitializer
	{
		string Name { get; }

		void Log(string eventName, IDictionary<string, object> parameters = null);

		void FlushLogs();

		void SetSuperProperties(IDictionary<string, object> properties);

		void SetUserProperties(IDictionary<string, object> properties);
	}
}

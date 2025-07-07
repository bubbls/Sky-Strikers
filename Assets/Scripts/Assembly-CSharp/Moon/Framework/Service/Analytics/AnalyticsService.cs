using System.Collections.Generic;
using Chamber8.Framework.Common;
using Chamber8.Framework.Core;
using Moon.Framework.Analytics;
using UnityEngine.Scripting;

namespace Moon.Framework.Service.Analytics
{
	[Preserve]
	public class AnalyticsService : IAnalyticsService, IInitializer, IConditionalCreation
	{
		private readonly List<IAnalytics> _analyticsList;

		public void Initialize()
		{
		}

		public void Register(IAnalytics analytics)
		{
		}

		public void Log(string eventName, IDictionary<string, object> parameters = null)
		{
		}

		public void FlushLogs()
		{
		}

		public void SetSuperProperties(IDictionary<string, object> properties)
		{
		}

		public void SetUserProperties(IDictionary<string, object> properties)
		{
		}

		private static string ParametersToString(IDictionary<string, object> parameters)
		{
			return null;
		}

		public bool CreateOnCondition()
		{
			return false;
		}
	}
}

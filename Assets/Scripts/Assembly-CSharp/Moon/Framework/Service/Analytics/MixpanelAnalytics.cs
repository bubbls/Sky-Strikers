using System.Collections.Generic;
using Chamber8.Framework.Common;
using Moon.Framework.Analytics;
using Moon.Framework.Service.Analytics.Unity;
using UnityEngine.Scripting;
using mixpanel;

namespace Moon.Framework.Service.Analytics
{
	[Preserve]
	public class MixpanelAnalytics : IAnalytics, IInitializer
	{
		private const string UserApplication = "userApplication";

		private readonly EventQueue _eventQueue;

		private readonly List<IDictionary<string, object>> _pendingSuperProperties;

		private readonly List<IDictionary<string, object>> _pendingUserProperties;

		private bool _initialProperiesRegistered;

		public string Name => null;

		public void Initialize()
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

		private void SetSuperPropertyInternal(IDictionary<string, object> properties)
		{
		}

		public void SetUserProperties(IDictionary<string, object> properties)
		{
		}

		private void SetUserPropertyInternal(IDictionary<string, object> properties)
		{
		}

		private void TryRegisterInitialProperties()
		{
		}

		private static Value ToValue(object valueObject)
		{
			return null;
		}

		private static void LogInternal(string eventName, IDictionary<string, object> parameters)
		{
		}
	}
}

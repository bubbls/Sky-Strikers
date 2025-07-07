using System;
using System.Collections.Generic;

namespace Moon.Framework.Service.Analytics.Unity
{
	public class EventQueue
	{
		private struct Event
		{
			public string EventName;

			public Dictionary<string, object> Parameters;
		}

		private readonly Queue<Event> _events;

		private static Dictionary<string, object> Alloc(IDictionary<string, object> parameters)
		{
			return null;
		}

		public void Enqueue(string eventName, IDictionary<string, object> parameters)
		{
		}

		public void Flush(Action<string, IDictionary<string, object>> sink)
		{
		}
	}
}

using System;
using Chamber8.Framework.Messaging;
using DP.Takeaway.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Moon.Tutorial
{
	public class GameIndicatorMessageHandler : MonoBehaviour
	{
		[Serializable]
		private class TasListCompletedEventLookup : SerializableDictionary<string, UnityEvent>
		{
		}

		public static readonly ISubscriptionModel OnTagListCompleted;

		private IMessageSubscriber? _subscriber;

		[SerializeField]
		private TasListCompletedEventLookup _tagListCompletedEvents;

		private void OnDisable()
		{
		}

		private void OnEnable()
		{
		}

		private int OnTagListCompletedHandler(IMessage<string> message)
		{
			return 0;
		}
	}
}

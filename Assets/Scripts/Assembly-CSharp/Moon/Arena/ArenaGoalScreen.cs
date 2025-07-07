using Chamber8.Framework.Messaging;
using UnityEngine;

namespace Moon.Arena
{
	public class ArenaGoalScreen : MonoBehaviour
	{
		private ArenaScreenView[] _views;

		private ArenaScreenView _currentView;

		private IMessageSubscriber[] _messageSubscribers;

		private MatchEventMessage _cachedPayload;

		protected ArenaCountDownViewData CountDownViewData { get; private set; }

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnDisable()
		{
		}

		private void Dispose()
		{
		}

		protected void EnterView<T>(object viewData = null)
		{
		}

		private int HandleMatchEvent(IMessage<MatchEventMessage> message)
		{
			return 0;
		}

		protected virtual void HandleMatchEvent(MatchEventMessage payload)
		{
		}
	}
}

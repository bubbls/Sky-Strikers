using Chamber8.Framework.Messaging;
using UnityEngine;

namespace Moon.Hub
{
	public abstract class HubAnalyticsTracking : MonoBehaviour
	{
		[SerializeField]
		private LocalPlayerCheckVolume _localPlayerCheckVolume;

		private IMessageSubscriber[] _subscribers;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private int HandleOnSessionStared(IMessage<object> message)
		{
			return 0;
		}

		private int HandleOnSessionEnded(IMessage<object> message)
		{
			return 0;
		}

		protected virtual void HandleOnSessionStartedInternal()
		{
		}

		protected virtual void HandleOnSessionEndedInternal()
		{
		}

		private void CheckVolume_HandleOnChanged(bool hasPlayer)
		{
		}

		protected virtual void HandleLocalPlayerVolumeChanged(bool hasPlayer)
		{
		}
	}
}

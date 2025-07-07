using Chamber8.Framework.Messaging;
using UnityEngine;

namespace Moon.MultiPlay
{
	public abstract class AdditiveSceneHandler : MonoBehaviour
	{
		private IMessageSubscriber _subscriber;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Start()
		{
		}

		private int HandleAdditiveSceneLoaded(IMessage<object> _)
		{
			return 0;
		}

		protected abstract void OnAdditiveSceneLoaded();
	}
}

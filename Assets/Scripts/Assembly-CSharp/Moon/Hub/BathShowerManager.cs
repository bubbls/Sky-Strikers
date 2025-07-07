using System.Collections.Generic;
using Chamber8.Framework.Messaging;
using UnityEngine;

namespace Moon.Hub
{
	public class BathShowerManager : MonoBehaviour
	{
		[SerializeField]
		private List<BathShower> _bathShowers;

		private bool _hasInteracted;

		private IMessageSubscriber[] _subscribers;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void HandleOnBathShowerInteracted()
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
	}
}

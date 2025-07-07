using Chamber8.Framework.Messaging;
using UnityEngine;

namespace Moon.TempFeatures
{
	public class ModelVisibilityController : MonoBehaviour
	{
		[SerializeField]
		private GameObject _elevatorDoor;

		[SerializeField]
		private GameObject _sceneSwitcher;

		private IMessageSubscriber _configSubscriber;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private int HandleRemoteConfigUpdated<T>(IMessage<T> message) where T : class
		{
			return 0;
		}

		private void ToggleVisibility()
		{
		}
	}
}

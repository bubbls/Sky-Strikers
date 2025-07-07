using Chamber8.Framework.Messaging;
using Moon.Arena;
using UnityEngine;

namespace Moon.Class
{
	public class ClassSwitchEntrance : MonoBehaviour
	{
		[SerializeField]
		private GameObject[] _shopNodes;

		[SerializeField]
		private GameObject[] _arenaNodes;

		private IMessageSubscriber _subscriber;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private int HandleFieldTypeChanged(IMessage<object> message)
		{
			return 0;
		}

		private void SwitchNodes(FieldType fieldType)
		{
		}
	}
}

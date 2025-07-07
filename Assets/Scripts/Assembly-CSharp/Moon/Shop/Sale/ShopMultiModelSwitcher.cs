using DG.Tweening;
using UnityEngine;

namespace Moon.Shop.Sale
{
	public class ShopMultiModelSwitcher : MonoBehaviour
	{
		[SerializeField]
		private float _switchDuration;

		[SerializeField]
		private GameObject[] _objectsToSwitch;

		private Sequence _sequence;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void StartSwitchSequence()
		{
		}
	}
}

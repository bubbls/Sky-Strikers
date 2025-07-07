using UnityEngine;

namespace Moon.Shop.HandPoseArea
{
	public class ShopHandPoseArea : MonoBehaviour
	{
		[SerializeField]
		private float _fingerThumbValue;

		[SerializeField]
		private float _fingerIndexValue;

		[SerializeField]
		private float _fingerOthersValue;

		private void OnTriggerStay(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}

		private void OnDrawGizmos()
		{
		}
	}
}

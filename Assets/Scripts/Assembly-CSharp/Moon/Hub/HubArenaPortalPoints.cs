using Moon.AI.VisualScripting;
using UnityEngine;

namespace Moon.Hub
{
	public class HubArenaPortalPoints : MonoBehaviour
	{
		[SerializeField]
		private Transform[] _leftPortalPoints;

		[SerializeField]
		private Transform[] _rightPortalPoints;

		[SerializeField]
		private OverlapShapeDesc _leftArea;

		[SerializeField]
		private OverlapShapeDesc _rightArea;

		public Transform[] LeftPortalPoints => null;

		public Transform[] RightPortalPoints => null;

		public void GetRandomPortalPoints(out Vector3 leftPos, out Quaternion leftRotation, out Vector3 rightPos, out Quaternion rightRotation)
		{
			leftPos = default(Vector3);
			leftRotation = default(Quaternion);
			rightPos = default(Vector3);
			rightRotation = default(Quaternion);
		}
	}
}

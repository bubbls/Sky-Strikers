using UnityEngine;

namespace Moon.Arena
{
	public class ArenaGateDeathZone : MonoBehaviour
	{
		[SerializeField]
		private Transform _teleportTargetTransform;

		private void OnTriggerEnter(Collider other)
		{
		}
	}
}

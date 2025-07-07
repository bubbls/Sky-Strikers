using UnityEngine;

namespace Moon.Player.Pad
{
	public class PlayerPadScreenHapticTrigger : MonoBehaviour
	{
		[SerializeField]
		private HapticImpulse _screenTouchedHapticImpulse;

		private void OnTriggerEnter(Collider other)
		{
		}
	}
}

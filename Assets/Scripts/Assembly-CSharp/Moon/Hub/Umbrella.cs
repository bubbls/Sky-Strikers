using DP.Takeaway.Sound;
using UnityEngine;

namespace Moon.Hub
{
	public class Umbrella : MonoBehaviour
	{
		[SerializeField]
		private SoundInfo _bounceSoundInfo;

		[SerializeField]
		private float _minVelocityForBounceSound;

		private void OnTriggerEnter(Collider other)
		{
		}
	}
}

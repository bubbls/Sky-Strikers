using DP.Takeaway.Game;
using UnityEngine;

namespace Moon.Tutorial
{
	public class TutorialChallengePlayerDeathZone : MonoBehaviour
	{
		[SerializeField]
		private Trigger _trigger;

		[SerializeField]
		private Transform _teleportPoint;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void HandleOnTriggerEnter(Collider other)
		{
		}
	}
}

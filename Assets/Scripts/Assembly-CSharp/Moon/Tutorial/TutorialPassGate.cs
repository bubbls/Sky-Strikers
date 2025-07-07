using DG.Tweening;
using DP.Takeaway.Game;
using DP.Takeaway.Sound;
using UnityEngine;

namespace Moon.Tutorial
{
	public class TutorialPassGate : MonoBehaviour
	{
		[SerializeField]
		private Transform _gateTransform;

		[SerializeField]
		private float _animationDuration;

		[SerializeField]
		private float _gateEndYValue;

		[SerializeField]
		private bool _autoTrigger;

		[SerializeField]
		private Trigger _trigger;

		[SerializeField]
		private SoundInfo _soundInfo;

		private Sequence _sequence;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void HandleOnTriggerEnter(Collider other)
		{
		}

		private void HandleOnTriggerExit(Collider other)
		{
		}

		private void KillSequence()
		{
		}

		public void ToggleGate(bool open)
		{
		}

		public void ToggleAutoTrigger(bool enable)
		{
		}
	}
}

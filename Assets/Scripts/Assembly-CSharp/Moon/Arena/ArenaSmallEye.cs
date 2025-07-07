using DG.Tweening;
using UnityEngine;

namespace Moon.Arena
{
	public class ArenaSmallEye : MonoBehaviour
	{
		[SerializeField]
		private float _duration;

		[SerializeField]
		private float _divisor;

		[SerializeField]
		private Transform _smallEyeTransform;

		[SerializeField]
		private Transform _arenaEyeTransform;

		[SerializeField]
		private Transform _pivotTransform;

		private Tween _rotateTween;

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnDestroy()
		{
		}

		private void KillTween()
		{
		}
	}
}

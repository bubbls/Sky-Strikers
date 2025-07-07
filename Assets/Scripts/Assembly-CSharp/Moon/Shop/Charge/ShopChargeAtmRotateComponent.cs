using DG.Tweening;
using UnityEngine;

namespace Moon.Shop.Charge
{
	public class ShopChargeAtmRotateComponent : MonoBehaviour
	{
		[SerializeField]
		private Vector3 _targetRotation;

		[SerializeField]
		private float _duration;

		[SerializeField]
		private bool _looping;

		[SerializeField]
		private Ease _easeType;

		[SerializeField]
		private LoopType _loopType;

		private Tween _rotateTween;

		public void Animate()
		{
		}

		public void KillAnimation()
		{
		}

		private void OnDestroy()
		{
		}
	}
}

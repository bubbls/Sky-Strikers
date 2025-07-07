using System;
using DG.Tweening;
using UnityEngine;

namespace Moon.Shop.Charge
{
	public class ShopChargeAtmEnergyBar : MonoBehaviour
	{
		[SerializeField]
		private Transform _capsule;

		[SerializeField]
		private Transform _capsuleTargetPosition;

		[SerializeField]
		private Transform _glass;

		[SerializeField]
		private Transform _glassTargetPosition;

		private Sequence _sequence;

		private Vector3 _capsuleStartPosition;

		private Vector3 _glassStartPosition;

		public void Initialize()
		{
		}

		public void Animate(bool animateIn, Action callback = null)
		{
		}

		private void OnDestroy()
		{
		}
	}
}

using System;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

namespace Moon.Shop.Charge
{
	public class ShopChargeAtmGate : MonoBehaviour
	{
		[SerializeField]
		private Transform _leftGate;

		[SerializeField]
		private Transform _rightGate;

		[SerializeField]
		private Transform _bottomBigGate;

		[SerializeField]
		private Transform _topBigGate;

		[SerializeField]
		private Vector3 _leftGateTargetPosition;

		[SerializeField]
		private Vector3 _rightGateTargetPosition;

		[SerializeField]
		private Vector3 _topGateTargetRotation;

		[SerializeField]
		private Vector3 _bottomTargetRotation;

		[SerializeField]
		private List<ShopChargeAtmRotateComponent> _gateGearRotateComponents;

		private Sequence _sequence;

		private Vector3 _leftGateStartPosition;

		private Vector3 _rightGateStartPosition;

		public void Initialize()
		{
		}

		public void Animate(bool animateIn, Action callback)
		{
		}

		private void OnDestroy()
		{
		}
	}
}

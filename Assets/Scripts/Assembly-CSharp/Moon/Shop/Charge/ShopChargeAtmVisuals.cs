using System;
using DG.Tweening;
using UnityEngine;

namespace Moon.Shop.Charge
{
	public class ShopChargeAtmVisuals : MonoBehaviour
	{
		private enum ChargeProduct : byte
		{
			ProductOne = 0,
			ProductTwo = 1,
			ProductThree = 2
		}

		[SerializeField]
		private MeshRenderer _buttonGlassMeshRender;

		[SerializeField]
		private MeshRenderer _baseBoardMeshRender;

		[SerializeField]
		private MeshRenderer _ledArrowsMeshRender;

		[SerializeField]
		[Range(-0.5f, 1f)]
		private float _buttonGlassStartValue;

		[SerializeField]
		[Range(0f, 1f)]
		private float _baseBoardStartValue;

		[SerializeField]
		[Range(0f, 1f)]
		private float _ledArrowsStartValue;

		private static readonly int _switch;

		private Sequence _sequence;

		public void SetIdleState(bool animate = false)
		{
		}

		public void SetPurchasingState(int index)
		{
		}

		public void SetPurchaseSucceedState(Action callback)
		{
		}

		private void OnDestroy()
		{
		}
	}
}

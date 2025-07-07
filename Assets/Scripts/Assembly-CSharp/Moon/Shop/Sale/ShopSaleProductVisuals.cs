using System;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

namespace Moon.Shop.Sale
{
	public class ShopSaleProductVisuals : MonoBehaviour
	{
		[SerializeField]
		private List<MeshRenderer> _meshRenderers;

		[SerializeField]
		private List<SkinnedMeshRenderer> _skinnedMeshRenderers;

		[SerializeField]
		private List<GameObject> _commonVisuals;

		[SerializeField]
		private float _meltingInEndValue;

		[SerializeField]
		private float _meltingOutEndValue;

		private static readonly int _switch;

		private static readonly int _pivotOffset;

		private static readonly int _reverse;

		private Sequence _skinLightUpSequence;

		private Sequence _meltingSequence;

		public void KillSequence()
		{
		}

		public void SetMelting(bool meltingOut, bool reverse)
		{
		}

		public void MeltingVisuals(bool meltingOut, bool reverse, float duration, Action callback = null)
		{
		}

		public void SetPurchaseSucceedState(Action callback = null)
		{
		}

		private void ToggleCommonVisuals(bool enable)
		{
		}

		private void MeshRendersAnimation(float endValue, float duration)
		{
		}

		private void SkinnedMeshRendersAnimation(float endValue, float duration)
		{
		}

		private void OnDestroy()
		{
		}
	}
}

using DG.Tweening;
using UnityEngine;

namespace Moon
{
	public class LODScaleGroup : GameObjectLODListener
	{
		[SerializeField]
		private Transform[] _transforms;

		[SerializeField]
		private float _scaleDuration;

		private Sequence _sequence;

		private Tween _cachedTween;

		protected override void ActivateLODStateInternal()
		{
		}

		protected override void DeactivateLODStateInternal()
		{
		}

		private void Scale(bool scaleUp)
		{
		}

		private void OnDisable()
		{
		}
	}
}

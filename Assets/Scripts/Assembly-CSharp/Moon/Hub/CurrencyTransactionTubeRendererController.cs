using System;
using DG.Tweening;
using DP.Takeaway.Runtime;
using Moon.Economy;
using UnityEngine;

namespace Moon.Hub
{
	public class CurrencyTransactionTubeRendererController : MonoBehaviour
	{
		[Serializable]
		private class CurrencyTypeMaterial : SerializableDictionary<PlayerEconomyConstants.CurrencyType, Material>
		{
		}

		private const float TubeAnimDuration = 0.2f;

		private const float TubeAnimEndDuration = 1f;

		private static readonly int _levelingWidth;

		private static readonly int _levelingMove;

		[SerializeField]
		[Space(5f)]
		private CurrencyTypeMaterial _currencyTypeMaterial;

		[SerializeField]
		private MeshRenderer _tubeMeshRenderer;

		private Tween? _tubeTween;

		private float _tubeAnimProgress;

		private void OnDestroy()
		{
		}

		public void PlayForCurrency(PlayerEconomyConstants.CurrencyType currencyType)
		{
		}

		public void Play()
		{
		}

		public void Stop()
		{
		}

		private void UpdateTubeAnim()
		{
		}

		private static float Remap01(float value, float start, float end)
		{
			return 0f;
		}
	}
}

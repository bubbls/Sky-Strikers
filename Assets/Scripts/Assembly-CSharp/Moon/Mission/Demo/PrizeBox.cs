using System;
using DG.Tweening;
using DP.Takeaway.Sound;
using Moon.Shop;
using NaughtyAttributes;
using UnityEngine;

namespace Moon.Mission.Demo
{
	public class PrizeBox : MonoBehaviour
	{
		private static readonly int _propEmissionColor;

		[SerializeField]
		private ParticleSystem _fxExplosion;

		[SerializeField]
		private Transform _stoneStartPivot;

		[SerializeField]
		private Transform _stoneEndPivot;

		[SerializeField]
		private Transform _stonePivot;

		[SerializeField]
		private MeshRenderer _coneLight;

		[SerializeField]
		private float _blinkDuration;

		[SerializeField]
		private float _finalizeDuration;

		[SerializeField]
		private SoundInfo _sfxRolling;

		[SerializeField]
		private SoundInfo _sfxItem;

		[SerializeField]
		private SoundInfo _sfxExplode;

		private Rarity? _stopRandomAtCategory;

		private Action _onStart;

		private Action _onComplete;

		private Sequence _sequence;

		private Sequence _finalizeSequence;

		private Material _coneLightMaterial;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		[Button(null, EButtonEnableMode.Always)]
		public void PlayRandomLight()
		{
		}

		public void StopRandomAt(Rarity prizeCategory, Action onStart, Action onComplete)
		{
		}

		private void OnReachLoopEnd()
		{
		}

		[Button(null, EButtonEnableMode.Always)]
		public void Stop()
		{
		}

		[Button(null, EButtonEnableMode.Always)]
		private void PlayRandomAndStopAtRandomRarity()
		{
		}
	}
}

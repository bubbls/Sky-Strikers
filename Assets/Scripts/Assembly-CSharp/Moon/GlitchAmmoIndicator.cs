using System.Collections.Generic;
using DG.Tweening;
using Moon.Arena;
using UnityEngine;

namespace Moon
{
	public class GlitchAmmoIndicator : PlayerAmmoIndicator
	{
		[SerializeField]
		private GlitchAmmo _ammoPrefab;

		[SerializeField]
		private float _rotateDuration;

		[SerializeField]
		private float _spawnOffset;

		[SerializeField]
		private float _ammoIdleSpeed;

		private readonly List<GlitchAmmo> _indicators;

		[SerializeField]
		private Transform[] _startPoints;

		[SerializeField]
		private Transform[] _endPoints;

		private Sequence _ammoShiftSequence;

		private GlitchAmmo _cachedAmmoRef;

		private Vector3 _cachedAmmoPos;

		private int _cachedChangeAmount;

		private Material _curAmmoMaterial;

		private void OnDisable()
		{
		}

		private void OnEnable()
		{
		}

		public override void SetAmmo(int targetAmount)
		{
		}

		protected override void HandleOnTeamMaterialChanged(PlayerMaterial material, TeamNo teamNo)
		{
		}

		private void ShowIdleAnimation()
		{
		}

		private void KillTweens()
		{
		}

		private void OnDestroy()
		{
		}

		private void AddAmmo(int amountToAdd)
		{
		}

		private void RemoveAmmo(int amountToRemove)
		{
		}

		private void AddShiftTweenToSequence(in GlitchAmmo indicator, int pointIndex)
		{
		}
	}
}

using System;
using Moon.Arena;
using Moon.Player.Visual;
using UnityEngine;

namespace Moon.Player.Ability.Jetstream
{
	public class JetstreamWeaponVisual : PlayerSuitWeaponVisual
	{
		[Serializable]
		private class CustomTeamMaterialsRenderer
		{
			[SerializeField]
			private MeshRenderer _meshRenderer;

			[SerializeField]
			private CustomTeamMaterials[] _customTeamMaterials;

			public void SetTeamColor(TeamNo teamNo, bool isSpawned)
			{
			}
		}

		[Serializable]
		private class CustomTeamMaterials
		{
			public Material _default;

			public Material _spawningMaterial;
		}

		private static readonly int _outlineColorProperty;

		private static readonly int _outlineStrengthProperty;

		[SerializeField]
		private JetstreamWeaponAnimator _weaponAnimator;

		[SerializeField]
		private JetstreamBallSuckerLine _ballSuckerLine;

		[SerializeField]
		private Renderer[] _bestShotRangeRenderers;

		[SerializeField]
		private ParticleSystem[] _blastFx;

		[SerializeField]
		private ParticleSystem[] _noAmmoBlastFx;

		[SerializeField]
		private ParticleSystem[] _showWeaponFx;

		[SerializeField]
		private GameObject _spawnedVisuals;

		[SerializeField]
		private JetstreamBallSuckerSoundPlayer _soundPlayer;

		[SerializeField]
		private CustomTeamMaterialsRenderer[] _customTeamMaterials;

		private Transform _ball;

		private bool _hasWeaponAnimator;

		protected override void InitializeInternal()
		{
		}

		protected override void InitializeVisualOnHand()
		{
		}

		private void WeaponAnimator_OnAnimateOutComplete()
		{
		}

		private void LateUpdate()
		{
		}

		private void OnDisable()
		{
		}

		public override void SetTeamColor(TeamNo teamNo)
		{
		}

		protected override void HandleSpawnedVisuals(bool isSpawned)
		{
		}

		public void HandleBallBlastAreaStatusChanged(bool isBallInBlastArea)
		{
		}

		public void HandleOnBallEnteredInWeaponArea(Transform ballTransform)
		{
		}

		public void HandleOnBallExitWeaponArea()
		{
		}

		protected override void HandleShow()
		{
		}

		protected override void HandleHide(bool instantly)
		{
		}

		public void StopSounds()
		{
		}

		public void PlaySuckingSound(bool hasConnectionToBall)
		{
		}

		public void PlayBlastFx()
		{
		}

		public void PlayNoAmmoBlastFx()
		{
		}

		public void EnterBallShotState(Transform ballTransform, float ballControlDuration)
		{
		}

		private void UpdatedCustomTeamMaterials()
		{
		}

		public void AnimateSuckingRange(float t)
		{
		}

		public void ShowInBestShotRangeVisuals()
		{
		}

		public void HideInBestShotRangeVisuals()
		{
		}

		private void ToggleBestShotRangeOutline(bool show)
		{
		}

		public void PlayBallShotFromBestRangeFx()
		{
		}
	}
}

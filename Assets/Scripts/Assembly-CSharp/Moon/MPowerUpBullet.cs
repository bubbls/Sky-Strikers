using DP.Takeaway.Sound;
using DP.Takeaway.Utils;
using Fusion;
using UnityEngine;

namespace Moon
{
	[NetworkBehaviourWeaved(5)]
	public class MPowerUpBullet : MPowerUp
	{
		private static readonly int PropTimeSimulation;

		[SerializeField]
		private WeaponType _weaponType;

		[SerializeField]
		private int _amount;

		[SerializeField]
		private GameObject _visual;

		[SerializeField]
		private GameObject _powerUpVisual;

		[SerializeField]
		private SoundInfo _sfxGenerated;

		[SerializeField]
		private SoundInfo _sfxConsumedByOthers;

		[SerializeField]
		private GameObject _consumedVisual;

		[SerializeField]
		private Renderer[] _refillRenderers;

		[SerializeField]
		private ParticleSystem _fxConsume;

		[SerializeField]
		private ParticleSystem _fxRespawn;

		[SerializeField]
		private ParticleSystem _coverParticleSystem;

		[SerializeField]
		private Material _refillMaterial;

		private Material _refillMaterialInst;

		private bool _isVisualsActive;

		private static Changed<MPowerUpBullet> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MPowerUpBullet> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MPowerUpBullet> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		protected override void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public override void Render()
		{
		}

		public override void Spawned()
		{
		}

		protected override ICommand GetPowerUpCommand(MHitter hitter, out int amount)
		{
			amount = default(int);
			return null;
		}

		protected override void UpdateVisual(bool wasGenerated)
		{
		}

		private void HandleVisuals()
		{
		}

		private void HandleSfx(bool wasGenerated)
		{
		}

		protected override void ToggleVisuals(bool show)
		{
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}
	}
}

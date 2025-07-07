using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Fusion;
using Moon.Interaction;
using UnityEngine;

namespace Moon.Backpack
{
	public class BackpackHolder : MonoBehaviour
	{
		[SerializeField]
		private Hitbox _hitbox;

		private List<LagCompensatedHit> _hits;

		private Transform _holderTransform;

		private bool _isInitialized;

		public MGrabInteractor TryGrabLeftInteractor { get; private set; }

		public MGrabInteractor TryGrabRightInteractor { get; private set; }

		public event Action<bool> OnInteractorExit
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void Initialize()
		{
		}

		public void Toggle(bool enable)
		{
		}

		public void HandleOnDespawned()
		{
		}
	}
}

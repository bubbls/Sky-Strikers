using System;
using System.Runtime.CompilerServices;
using Fusion;
using Moon.Arena;
using Moon.Player.Visual;
using UnityEngine;

namespace Moon
{
	public abstract class VisualBase : MonoBehaviour, IVisualEventNotifier
	{
		[SerializeField]
		private GameObject[] _objectsToHideInHologram;

		protected bool IsLocalPlayerVisual { get; set; }

		public PlayerRef OwnerPlayer { get; private set; }

		public PlayerVisualAttachPointType AttachPointType { get; protected set; }

		public event Action<PlayerRef, PlayerVisualAttachPointType, bool> OnVisualInitialized
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

		public event Action<TeamNo> OnTeamNoUpdated
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

		public event Action<PlayerRef> OnOwnerChanged
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

		public event Action OnVisualAboutToUnload
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

		protected void SetupVisualEventReceivers()
		{
		}

		protected void NotifyVisualInitialized()
		{
		}

		protected void NotifyTeamNoUpdated(TeamNo teamNo)
		{
		}

		public void PrepareForUnload()
		{
		}

		protected virtual void PrepareForUnloadInternal()
		{
		}

		public virtual void SetVisibleInMainCamera(bool visible)
		{
		}

		public void SetVisibleInMainCamera(bool visible, int parentLayer)
		{
		}

		public void SetOwnerPlayer(PlayerRef ownerPlayer)
		{
		}

		public virtual void SetTeamColor(TeamNo teamNo)
		{
		}

		public virtual void EnableHologramMaterial()
		{
		}

		public void DisableHologramMaterial(TeamNo teamNo)
		{
		}

		private void ToggleObjectsToHideInHologram(bool visible)
		{
		}
	}
}

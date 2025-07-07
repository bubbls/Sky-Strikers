using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Moon.Interaction
{
	public abstract class LocalGrabbable : MonoBehaviour, IGrabbable
	{
		[SerializeField]
		private bool _allowHandSwitching;

		[Tooltip("Players can only grab one of these objects at a time")]
		[SerializeField]
		private bool _isSingleGrab;

		private IGrabbableEventListener[] _eventListeners;

		public MGrabInteractor Interactor { get; private set; }

		public bool IsLocalGrabbable => false;

		public bool IsGrabbed { get; private set; }

		public event Action OnGrabbed
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

		public event Action OnReleased
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

		protected virtual void Start()
		{
		}

		public void Grab(MGrabInteractor interactor)
		{
		}

		public void ForceGrab(MGrabInteractor interactor)
		{
		}

		private void DoGrab(MGrabInteractor interactor)
		{
		}

		protected abstract void HandleOnGrabbedInternal();

		public void Release()
		{
		}

		protected abstract void HandleOnReleaseInternal();

		public virtual bool CanBeGrabbedByInteractor(MGrabInteractor interactor)
		{
			return false;
		}

		private bool IsPlayerHoldingSameGrabbableType(MGrabInteractor interactor)
		{
			return false;
		}

		public void PlayGrabRejected(MGrabInteractor mGrabInteractor)
		{
		}
	}
}

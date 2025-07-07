using Autohand;
using DP.Takeaway.Game;
using Moon.Player.Visual;
using Moon.XRSystem;
using UnityEngine;

namespace Moon
{
	public abstract class PlayerHandBase : MonoBehaviour
	{
		[SerializeField]
		protected PlayerFingerBender _fingerThumb;

		[SerializeField]
		protected PlayerFingerBender _fingerIndex;

		[SerializeField]
		protected PlayerFingerBender _fingerOthers;

		[SerializeField]
		private PhysicalUICanvasPointer _handCanvasPointer;

		[SerializeField]
		private Collider _handCollider;

		[SerializeField]
		private VelocityTracker _velocityTracker;

		[SerializeField]
		private GameObjectIdentifier _gameObjectIdentifier;

		private Finger[] _fingers;

		private bool _enableInput;

		public PlayerSuitHandVisual PlayerSuitHandVisual { get; private set; }

		private void Awake()
		{
		}

		public virtual void TryGrab()
		{
		}

		public virtual void TryDrop()
		{
		}

		public virtual void TrySqueeze()
		{
		}

		public virtual void TryUnsqueeze()
		{
		}

		public abstract void Reset();

		public void ToggleHandCollider(bool enable)
		{
		}

		public void ToggleInput(bool enable)
		{
		}

		public virtual void SetFingerThumb(float value)
		{
		}

		public virtual void SetFingerIndex(float value)
		{
		}

		public virtual void SetFingerOthers(float value)
		{
		}

		public void SetPlayerHandVisual(PlayerSuitHandVisual visual)
		{
		}

		private static void SyncFingersValue(Finger[] currentFingers, Finger[] newFingers)
		{
		}

		public void ResetVelocityTrackers()
		{
		}

		public Vector3 ThrowVelocity()
		{
			return default(Vector3);
		}

		private void SetVelocityTrackerParameters()
		{
		}
	}
}

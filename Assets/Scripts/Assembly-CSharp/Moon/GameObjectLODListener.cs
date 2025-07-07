using UnityEngine;

namespace Moon
{
	public abstract class GameObjectLODListener : MonoBehaviour
	{
		public bool IsActive { get; private set; }

		public void ActivateLODState()
		{
		}

		protected abstract void ActivateLODStateInternal();

		public void DeactivateLODState()
		{
		}

		public void ForceDeactivateLODState()
		{
		}

		protected abstract void DeactivateLODStateInternal();
	}
}

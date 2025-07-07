using NaughtyAttributes;
using UnityEngine;

namespace Moon
{
	public class LODGameObjectTogglerGroup : GameObjectLODListener
	{
		[SerializeField]
		private GameObject[] _gameObjects;

		[Button("Simulate Activate", EButtonEnableMode.Always)]
		protected override void ActivateLODStateInternal()
		{
		}

		[Button("Simulate Deactivate", EButtonEnableMode.Always)]
		protected override void DeactivateLODStateInternal()
		{
		}
	}
}

using System;
using Fusion;
using Moon.Arena;
using UnityEngine;

namespace Moon.Hub
{
	[SimulationBehaviour(Stages = SimulationStages.Forward, Modes = (SimulationModes.Server | SimulationModes.Host))]
	[NetworkBehaviourWeaved(6)]
	public class MHubArenaGroundItemsSpawner : MHubArenaFieldObjectSpawner
	{
		[Serializable]
		private class GroundItemsPair
		{
			public GroundItems GroundItemType;

			public MHubArenaFieldObject PlatformGroup;

			public Transform SpawnPoint;
		}

		[SerializeField]
		private GroundItemsPair[] _platformLayoutPairs;

		[SerializeField]
		[DefaultForProperty("CurrentGroundItem", 5, 1)]
		private GroundItems _CurrentGroundItem;

		private static Changed<MHubArenaGroundItemsSpawner> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MHubArenaGroundItemsSpawner> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MHubArenaGroundItemsSpawner> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[Networked]
		[NetworkedWeaved(5, 1)]
		public GroundItems CurrentGroundItem
		{
			get
			{
				return default(GroundItems);
			}
			private set
			{
			}
		}

		protected override bool ShouldChangeFieldObject(GameSettings gameSettings)
		{
			return false;
		}

		protected override bool TryGetPrefabToSpawn(GameSettings gameSettings, out GameObject prefab, out Transform spawnPoint)
		{
			prefab = null;
			spawnPoint = null;
			return false;
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}
	}
}

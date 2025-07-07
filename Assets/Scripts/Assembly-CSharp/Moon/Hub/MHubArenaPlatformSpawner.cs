using System;
using Fusion;
using Moon.Arena;
using UnityEngine;

namespace Moon.Hub
{
	[SimulationBehaviour(Stages = SimulationStages.Forward, Modes = (SimulationModes.Server | SimulationModes.Host))]
	[NetworkBehaviourWeaved(6)]
	public class MHubArenaPlatformSpawner : MHubArenaFieldObjectSpawner
	{
		[Serializable]
		private class PlatformPair
		{
			public PlatformLayout PlatformLayoutType;

			public MHubArenaFieldObject PlatformGroup;
		}

		[SerializeField]
		private PlatformPair[] _platformLayoutPairs;

		[DefaultForProperty("CurrentPlatformLayout", 5, 1)]
		[SerializeField]
		private PlatformLayout _CurrentPlatformLayout;

		private static Changed<MHubArenaPlatformSpawner> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MHubArenaPlatformSpawner> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MHubArenaPlatformSpawner> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[NetworkedWeaved(5, 1)]
		[Networked]
		public PlatformLayout CurrentPlatformLayout
		{
			get
			{
				return default(PlatformLayout);
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

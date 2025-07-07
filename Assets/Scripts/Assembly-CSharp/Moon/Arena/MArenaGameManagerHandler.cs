using System;
using Fusion;
using UnityEngine;

namespace Moon.Arena
{
	[NetworkBehaviourWeaved(2)]
	[OrderBefore(new Type[] { typeof(MGameManager) })]
	public class MArenaGameManagerHandler : NetworkBehaviour
	{
		[SerializeField]
		private MArenaGameManager _customGameManager;

		[SerializeField]
		private MArenaGameManagerRanked _rankedGameManager;

		[SerializeField]
		private GameObject _customGameItemsContainer;

		[SerializeField]
		private GameObject _rankedGameItemsContainer;

		[SerializeField]
		[DefaultForProperty("GameManager", 0, 2)]
		private MGameManager _GameManager;

		private static Changed<MArenaGameManagerHandler> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MArenaGameManagerHandler> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MArenaGameManagerHandler> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[Networked]
		[NetworkedWeaved(0, 2)]
		public MGameManager GameManager
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public override void Spawned()
		{
		}

		public override void FixedUpdateNetwork()
		{
		}

		public override void Despawned(NetworkRunner runner, bool hasState)
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

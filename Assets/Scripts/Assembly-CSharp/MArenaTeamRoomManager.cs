using Chamber8.Framework.Messaging;
using Fusion;
using Moon;
using Moon.Arena;
using Moon.Bootstrap;
using UnityEngine;
using UnityEngine.Scripting;

[NetworkBehaviourWeaved(6)]
public class MArenaTeamRoomManager : NetworkBehaviour
{
	[DefaultForProperty("TeamOnePlayers", 0, 3)]
	private PlayerRef[] _TeamOnePlayers;

	[DefaultForProperty("TeamTwoPlayers", 3, 3)]
	private PlayerRef[] _TeamTwoPlayers;

	[SerializeField]
	private PlayerStatsFrameManager _playerStatsFrameManager;

	[SerializeField]
	private TeamRoomLockerManager _teamRoomLockerManager;

	private IMessageSubscriber[] _subscribers;

	private static Changed<MArenaTeamRoomManager> _0024IL2CPP_CHANGED;

	private static ChangedDelegate<MArenaTeamRoomManager> _0024IL2CPP_CHANGED_DELEGATE;

	private static NetworkBehaviourCallbacks<MArenaTeamRoomManager> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

	[NetworkedWeaved(0, 3)]
	[Capacity(3)]
	[Networked(OnChanged = "HandleOnTeamOnePlayersChanged")]
	private NetworkArray<PlayerRef> TeamOnePlayers => default(NetworkArray<PlayerRef>);

	[NetworkedWeaved(3, 3)]
	[Capacity(3)]
	[Networked(OnChanged = "HandleOnTeamTwoPlayersChanged")]
	private NetworkArray<PlayerRef> TeamTwoPlayers => default(NetworkArray<PlayerRef>);

	public override void Spawned()
	{
	}

	public override void Despawned(NetworkRunner runner, bool hasState)
	{
	}

	private int HandleOnTeamPlayersUpdated(IMessage<TeamPlayersUpdatedMessage> message)
	{
		return 0;
	}

	[Preserve]
	private static void HandleOnTeamOnePlayersChanged(Changed<MArenaTeamRoomManager> changed)
	{
	}

	[Preserve]
	private static void HandleOnTeamTwoPlayersChanged(Changed<MArenaTeamRoomManager> changed)
	{
	}

	private void UpdateTeamOneObjects()
	{
	}

	private void UpdateTeamTwoObjects()
	{
	}

	public override void CopyBackingFieldsToState(bool P_0)
	{
	}

	public override void CopyStateToBackingFields()
	{
	}
}

using System;
using System.Runtime.CompilerServices;
using Fusion;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.Arena
{
	[NetworkBehaviourWeaved(31)]
	public class MTeamScoreTracker : NetworkBehaviour
	{
		private const int GoalLimits = 99;

		[SerializeField]
		[DefaultForProperty("TeamScores", 0, 31)]
		private SerializableDictionary<TeamNo, TeamScore> _TeamScores;

		private static Changed<MTeamScoreTracker> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MTeamScoreTracker> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MTeamScoreTracker> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[Capacity(4)]
		[NetworkedWeaved(0, 31)]
		[Networked(OnChanged = "OnTeamScoreChanged")]
		public NetworkDictionary<TeamNo, TeamScore> TeamScores => default(NetworkDictionary<TeamNo, TeamScore>);

		public event Action<TeamScore, TeamScore> OnTeamScoresUpdated
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

		public override void Spawned()
		{
		}

		private void RaiseOnTeamScoreChanged()
		{
		}

		[Preserve]
		private static void OnTeamScoreChanged(Changed<MTeamScoreTracker> changed)
		{
		}

		public void AddScore(TeamNo teamNo)
		{
		}

		public void ResetScores()
		{
		}

		public bool HasSameScore()
		{
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

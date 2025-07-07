using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DP.Takeaway.Runtime;
using DP.Takeaway.Sound;
using Fusion;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.Arena
{
	[NetworkBehaviourWeaved(4)]
	public class MArenaCrowdManager : NetworkBehaviour
	{
		[StructLayout((LayoutKind)2, Size = 8)]
		[NetworkStructWeaved(2)]
		private struct SoundDetail : INetworkStruct
		{
			[FieldOffset(0)]
			public byte SfxType;

			[FieldOffset(4)]
			public byte SfxIndex;
		}

		[Serializable]
		private class IdleSfxLookup : DP.Takeaway.Runtime.SerializableDictionary<IdleSfxType, SoundInfo>
		{
		}

		[Serializable]
		private class ReactionsSfxLookup : DP.Takeaway.Runtime.SerializableDictionary<ReactionSfxType, SoundInfo>
		{
		}

		[Space(5f)]
		[SerializeField]
		private IdleSfxLookup _idleSfxLookup;

		[Space(5f)]
		[SerializeField]
		private ReactionsSfxLookup _reactionsSfxLookup;

		[DefaultForProperty("IdleSoundDetail", 0, 2)]
		private SoundDetail _IdleSoundDetail;

		[DefaultForProperty("ReactionSoundDetail", 2, 2)]
		private SoundDetail _ReactionSoundDetail;

		private int _idleSoundIndex;

		private int _reactionSoundIndex;

		private SoundDetail _cachedIdleSoundDetail;

		private SoundDetail _cachedSoundDetail;

		[SerializeField]
		private CrowdIdleResponseChecker _idleCrowdResponseChecker;

		[SerializeField]
		private CrowdResponseChecker[] _playerActionCrowdResponseCheckers;

		[SerializeField]
		private CrowdVolumeController _crowdVolumeController;

		[SerializeField]
		private float _reactionSoundFadeInTime;

		[SerializeField]
		private float _reactionSoundFadeOutTime;

		private List<CrowdResponseChecker> _crowdResponseCheckers;

		private IdleSfxType _currentIdleSfxType;

		private static Changed<MArenaCrowdManager> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MArenaCrowdManager> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MArenaCrowdManager> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[Networked(OnChanged = "HandleIdleSoundChanged")]
		[NetworkedWeaved(0, 2)]
		private SoundDetail IdleSoundDetail
		{
			get
			{
				return default(SoundDetail);
			}
			set
			{
			}
		}

		[NetworkedWeaved(2, 2)]
		[Networked(OnChanged = "HandleReactionSoundChanged")]
		private SoundDetail ReactionSoundDetail
		{
			get
			{
				return default(SoundDetail);
			}
			set
			{
			}
		}

		public override void Spawned()
		{
		}

		public override void Despawned(NetworkRunner runner, bool hasState)
		{
		}

		private void InitializeResponseCheckers()
		{
		}

		private void DisposeResponseCheckers()
		{
		}

		private void HandleIdleCrowdResponse(byte responseType)
		{
		}

		private void HandlePlayerActionCrowdResponse(byte responseType)
		{
		}

		[Preserve]
		private static void HandleIdleSoundChanged(Changed<MArenaCrowdManager> changed)
		{
		}

		private void PlayIdleSound(SoundDetail soundDetail)
		{
		}

		[Preserve]
		private static void HandleReactionSoundChanged(Changed<MArenaCrowdManager> changed)
		{
		}

		private void PlayReactionSound(SoundDetail soundDetail)
		{
		}

		private void FadeSwitch(ref int soundId, SoundInfo soundInfo, Vector3 position, int clipIndex)
		{
		}

		private void TryStopSound(ref int soundId)
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

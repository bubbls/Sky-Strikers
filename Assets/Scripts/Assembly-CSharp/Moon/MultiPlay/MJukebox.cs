using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Fusion;
using UnityEngine;

namespace Moon.MultiPlay
{
	[NetworkBehaviourWeaved(1)]
	public class MJukebox : NetworkBehaviour
	{
		[StructLayout((LayoutKind)2, Size = 4)]
		[NetworkStructWeaved(1)]
		private struct MusicData : INetworkStruct
		{
			[FieldOffset(0)]
			public int MusicIndex;
		}

		[CompilerGenerated]
		private sealed class _003CPlayCurrentMusicRoutine_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public MJukebox _003C_003E4__this;

			private JukeboxScheme.JukeboxSchemeConfig _003CjukeboxSchemeConfig_003E5__2;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CPlayCurrentMusicRoutine_003Ed__12(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[DefaultForProperty("NetworkedMusicData", 0, 1)]
		private MusicData _NetworkedMusicData;

		[SerializeField]
		private MusicArea _musicArea;

		[SerializeField]
		private bool _randomizeMusic;

		private Coroutine _coroutine;

		private static Changed<MJukebox> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MJukebox> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MJukebox> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[NetworkedWeaved(0, 1)]
		[Networked]
		private MusicData NetworkedMusicData
		{
			get
			{
				return default(MusicData);
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

		private void PlayMusic()
		{
		}

		public void PlayMusicLocal()
		{
		}

		[IteratorStateMachine(typeof(_003CPlayCurrentMusicRoutine_003Ed__12))]
		private IEnumerator PlayCurrentMusicRoutine()
		{
			return null;
		}

		private void ChangeToNextMusic(JukeboxScheme.JukeboxSchemeConfig config)
		{
		}

		private void StopMusicCoroutine()
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

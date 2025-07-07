using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Chamber8.Framework.Common;
using DP.Takeaway.Sound;
using Moon.Arena;
using UnityEngine;
using UnityEngine.Audio;

namespace Moon
{
	public class Jukebox : SingleMonoBehaviour<Jukebox, DefaultSingleMonoBehaviourSettings<Jukebox>>
	{
		[CompilerGenerated]
		private sealed class _003CSwitchClip_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Jukebox _003C_003E4__this;

			public SoundInfo soundInfo;

			public int clipIndex;

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
			public _003CSwitchClip_003Ed__18(int _003C_003E1__state)
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

		private const string MusicGroupVolume = "MusicGroupVolume";

		private const string VFXVolume = "VFXGroupVolume";

		private const string CrowdGroupVolume = "CrowdGroupVolume";

		[SerializeField]
		private AudioMixerGroup _mixerMusicGroup;

		[SerializeField]
		private AnimationCurve _musicVolumeCurve;

		[SerializeField]
		private AudioMixerGroup _vfxGroup;

		[SerializeField]
		private AnimationCurve _vfxVolumeCurve;

		[SerializeField]
		private AnimationCurve _crowdVolumeCurve;

		[SerializeField]
		private float _fadeTimeBetweenMusic;

		private Coroutine _coroutine;

		private SoundInfo _currentSoundInfo;

		private int _soundID;

		private void Awake()
		{
		}

		public void SetMusicVolume(GameOption.Volume volume)
		{
		}

		public void SetVFXVolume(GameOption.Volume volume)
		{
		}

		public void SetCrowdVolume(GameOption.Volume volume)
		{
		}

		public void TryPlayMusic(SoundInfo soundInfo, int clipIndex)
		{
		}

		private void PlayMusic(SoundInfo soundInfo, int clipIndex)
		{
		}

		[IteratorStateMachine(typeof(_003CSwitchClip_003Ed__18))]
		private IEnumerator SwitchClip(SoundInfo soundInfo, int clipIndex)
		{
			return null;
		}

		private void StopMusicCoroutine()
		{
		}

		public void StopMusic()
		{
		}
	}
}

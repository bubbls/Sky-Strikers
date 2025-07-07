using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Chamber8.Framework.Common;
using Chamber8.Framework.Messaging;
using DP.Takeaway.Sound;
using UnityEngine;

namespace Moon.Arena
{
	public class ArenaSoundManager : SingleMonoBehaviour<ArenaSoundManager, InSceneSingleMonoBehaviourSettings>
	{
		[CompilerGenerated]
		private sealed class _003CLoopCountdown_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ArenaSoundManager _003C_003E4__this;

			public int count;

			private int _003Ci_003E5__2;

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
			public _003CLoopCountdown_003Ed__27(int _003C_003E1__state)
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

		[SerializeField]
		private FieldType _targetFieldType;

		[SerializeField]
		private SoundInfo _tutorialCompleteSoundInfo;

		[SerializeField]
		private SoundInfo _ballHitGoalFrameSoundInfo;

		[SerializeField]
		private SoundInfo _ballBouncingSoundInfo;

		[SerializeField]
		private SoundInfo _ballBouncingBoundarySoundInfo;

		[SerializeField]
		private SoundInfo _ballRespawnSoundInfo;

		[SerializeField]
		private SoundInfo _votingCountdownStartSoundInfo;

		[SerializeField]
		private Transform _soundCenter;

		[SerializeField]
		private float _goalSfxDelay;

		private IMessageSubscriber[] _messageSubscribers;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public void SetTargetFieldType(FieldType fieldType)
		{
		}

		private int HandleMatchEvent(IMessage<MatchEventMessage> message)
		{
			return 0;
		}

		private void TryPlayGoalSfx(GoalMessageData goalMessageData)
		{
		}

		private void PlayGoalSfxs()
		{
		}

		public void PlayTutorialCompleteSounds()
		{
		}

		public void PlayBallBouncingBoundarySound(Vector3 position)
		{
		}

		public void PlayBallCollisionOnSurfaceSfx(SurfaceTagType collisionInfoSurfaceTagType, Vector3 position)
		{
		}

		public void PlayBallRespawnSound(Vector3 position)
		{
		}

		private void PlayGameStartSfx()
		{
		}

		private void PlayOvertimeEnteredSfx()
		{
		}

		private void PlayCountdownTickSfx(int index)
		{
		}

		public void PlayCountdownEndSfx()
		{
		}

		private void PlayGameEndSfx()
		{
		}

		public void PlayVotingCountdownStartSfx()
		{
		}

		private void PlayCountdownLoop(int loops)
		{
		}

		[IteratorStateMachine(typeof(_003CLoopCountdown_003Ed__27))]
		private IEnumerator LoopCountdown(int count)
		{
			return null;
		}

		private int PlaySound(SoundInfo soundInfo)
		{
			return 0;
		}

		private int PlaySound(SoundInfo soundInfo, Vector3 position)
		{
			return 0;
		}
	}
}

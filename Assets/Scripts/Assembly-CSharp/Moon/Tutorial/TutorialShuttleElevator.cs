using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening;
using DP.Takeaway.Game;
using DP.Takeaway.Sound;
using Moon.Arena;
using Moon.Framework.Base;
using Moon.Hub;
using Moon.Player;
using TMPro;
using UnityEngine;

namespace Moon.Tutorial
{
	public class TutorialShuttleElevator : MonoBehaviour, IAdditionalScene
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass33_0
		{
			public bool loadingCompleted;

			internal void _003CLoadToTutorialRoutine_003Eb__0()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass34_0
		{
			public FieldType fieldType;

			public Action completeAction;

			public bool loadingComplete;

			internal void _003CLoadAndConnectRoutine_003Eb__0(Action complete)
			{
			}

			internal void _003CLoadAndConnectRoutine_003Eb__1(Action complete)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CLoadAndConnectRoutine_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public FieldType fieldType;

			public TutorialShuttleElevator _003C_003E4__this;

			public float delay;

			private _003C_003Ec__DisplayClass34_0 _003C_003E8__1;

			public PlayFabRegion region;

			public string roomName;

			public bool isPublic;

			public Action flowComplete;

			private float _003CstartTime_003E5__2;

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
			public _003CLoadAndConnectRoutine_003Ed__34(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CLoadToTutorialRoutine_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TutorialShuttleElevator _003C_003E4__this;

			public float delay;

			private _003C_003Ec__DisplayClass33_0 _003C_003E8__1;

			public FieldType fieldType;

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
			public _003CLoadToTutorialRoutine_003Ed__33(int _003C_003E1__state)
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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CSwitchMainSceneOfflineAsync_003Ed__35 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public FieldType fieldType;

			public Action complete;

			private TaskAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[SerializeField]
		private ManualToggle _shuttleToTutorialToggleButton;

		[SerializeField]
		private GameObject _gate;

		[SerializeField]
		private Transform _upGate;

		[SerializeField]
		private Transform _bottomGate;

		[SerializeField]
		private float _gateToggleDuration;

		[SerializeField]
		private float _upGateOpenYValue;

		[SerializeField]
		private float _upGateCloseYValue;

		[SerializeField]
		private float _bottomGateOpenYValue;

		[SerializeField]
		private float _bottomGateCloseYValue;

		[SerializeField]
		private Trigger _gateTrigger;

		[SerializeField]
		private NotificationMessage _notificationMessage;

		[SerializeField]
		private GameObject _serverUnderMaintenanceScreen;

		[SerializeField]
		private TMP_Text _screenText;

		[SerializeField]
		[Header("Sound")]
		private SoundInfo _startShuttlingSound;

		[SerializeField]
		private SoundInfo _shuttlingSound;

		[SerializeField]
		private SoundInfo _endShuttlingSound;

		[SerializeField]
		private SoundInfo _gateSound;

		private const float GeneralDelay = 3.5f;

		private bool _shouldMovePlayer;

		private Coroutine _shuttleCoroutine;

		private bool _isShuttling;

		private int _shuttlingSoundId;

		private Sequence _sequence;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void HandleOnExit(Collider other)
		{
		}

		private void HandleOnEnter(Collider other)
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void StopCoroutine()
		{
		}

		private void KillSequence()
		{
		}

		private void ToggleGate(bool open, bool mute = false)
		{
		}

		private void HandleOnShuttleToTutorialToggleValueChanged()
		{
		}

		[IteratorStateMachine(typeof(_003CLoadToTutorialRoutine_003Ed__33))]
		private IEnumerator LoadToTutorialRoutine(float delay, FieldType fieldType)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CLoadAndConnectRoutine_003Ed__34))]
		private IEnumerator LoadAndConnectRoutine(float delay, FieldType fieldType, string roomName, bool isPublic, PlayFabRegion region, Action flowComplete)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CSwitchMainSceneOfflineAsync_003Ed__35))]
		private static void SwitchMainSceneOfflineAsync(FieldType fieldType, Action complete)
		{
		}

		private void HandleOnConnectedToTutorial()
		{
		}

		public void MoveTo(AdditionalSceneHandler handler)
		{
		}

		private void MoveToTargetPlace(Transform elevator, Transform targetPlace)
		{
		}

		public void Hide()
		{
		}

		private void ToggleInteractions(bool enable)
		{
		}
	}
}

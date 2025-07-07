using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DP.Takeaway.Sound;
using Fusion;
using Moon.Arena;
using Moon.Framework.Base;
using Moon.MultiPlay.Aoi;
using NaughtyAttributes;
using TMPro;
using UnityEngine;

namespace Moon.Hub
{
	public class SceneShuttleRoom : MonoBehaviour, IAdditionalScene
	{
		private enum ShuttleConnectionType
		{
			ShuttleWithMatchmaking = 0,
			ShuttleNoMatchmaking = 1,
			Kick = 2
		}

		private struct LoadAndConnectData
		{
			public FieldType FieldType;

			public bool WaitForMatchmakingToCancel;

			public bool IsPublic;

			public PlayFabRegion PlayFabRegion;

			public string RoomName;

			public string PhotonRegion;

			public ShuttleConnectionType ConnectionType;
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass49_0
		{
			public bool loadingComplete;

			internal void _003CLoadRankedArenaRoutine_003Eb__0()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass55_0
		{
			public Action connectCompleteAction;

			public bool loadingComplete;

			public bool? connectionResult;

			public ShutdownReason shutdownReason;

			internal void _003CLoadAndConnectRoutine_003Eb__0(Action connectedToSingleCompleteAction)
			{
			}

			internal void _003CLoadAndConnectRoutine_003Eb__1(bool connectedSuccessfully, ShutdownReason shutDownReason)
			{
			}

			internal void _003CLoadAndConnectRoutine_003Eb__2(Action connectedToSingleCompleteAction)
			{
			}

			internal void _003CLoadAndConnectRoutine_003Eb__3(bool connectedSuccessfully, ShutdownReason shutDownReason)
			{
			}

			internal void _003CLoadAndConnectRoutine_003Eb__4(Action connectedToSingleCompleteAction)
			{
			}

			internal void _003CLoadAndConnectRoutine_003Eb__5(bool connectedSuccessfully, ShutdownReason shutDownReason)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CLoadAndConnectRoutine_003Ed__55 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SceneShuttleRoom _003C_003E4__this;

			public LoadAndConnectData loadAndConnectData;

			public float delay;

			private _003C_003Ec__DisplayClass55_0 _003C_003E8__1;

			public Action<bool, ShutdownReason> flowComplete;

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
			public _003CLoadAndConnectRoutine_003Ed__55(int _003C_003E1__state)
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
		private sealed class _003CLoadRankedArenaRoutine_003Ed__49 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SceneShuttleRoom _003C_003E4__this;

			private _003C_003Ec__DisplayClass49_0 _003C_003E8__1;

			public Action complete;

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
			public _003CLoadRankedArenaRoutine_003Ed__49(int _003C_003E1__state)
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
		private struct _003CSwitchMainSceneOfflineAsync_003Ed__61 : IAsyncStateMachine
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

		private static readonly int _gLightProbeOn;

		private const float GeneralDelay = 2f;

		public const string DefaultScreenText = "READY FOR LAUNCH\nTO HUB";

		[SerializeField]
		private DoorController _teamOneDoor;

		[SerializeField]
		private DoorController _teamTwoDoor;

		[SerializeField]
		private NetworkAoiArea _aoiArea;

		[SerializeField]
		private TMP_Text _screenText;

		[SerializeField]
		private SoundInfo _startShuttlingSound;

		[SerializeField]
		private SoundInfo _shuttlingSound;

		[SerializeField]
		private SoundInfo _endShuttlingSound;

		[SerializeField]
		private LocalPlayerCheckVolume _localPlayerCheckVolume;

		[SerializeField]
		private LocalPlayerCheckVolume _lightProbeOffVolume;

		[SerializeField]
		private float _observerQuitToHubWaitTime;

		[Header("Hub")]
		[SerializeField]
		private GameObject _hubConsoleVisuals;

		[SerializeField]
		private ManualToggle _launchBtnHub;

		[SerializeField]
		private Transform _playerTeleportPoint;

		private int _shuttlingSoundId;

		private WaitingMessage _waitingMessage;

		private bool _isWaitingMessageActive;

		private bool _allowQuitToHubCountdownCheck;

		private string _latestScreenText;

		private float _timeToReturnToHub;

		private bool _isExecutingObserverQuitTimer;

		public static SceneShuttleRoom Instance { get; private set; }

		public bool IsShuttling { get; private set; }

		private void Awake()
		{
		}

		private void LateUpdate()
		{
		}

		private void LocalPlayerCheckVolume_OnChanged(bool hasPlayer)
		{
		}

		private void LightProbeOffVolume_OnChanged(bool hasPlayer)
		{
		}

		private void OnDestroy()
		{
		}

		private void OnEnable()
		{
		}

		private void HandleOnPlayerUnableToRejoinSession(FieldType fieldType, ShutdownReason shutdownReason)
		{
		}

		private void HandleHubLaunchButtonChanged()
		{
		}

		private void ToggleLaunchButtons(bool toggleOn)
		{
		}

		private void EnableOperations(bool inputEnabled)
		{
		}

		private void CancelShuttling()
		{
		}

		private void MoveToOtherPlaceWithPlayer(Transform otherPlace)
		{
		}

		private void MoveToOtherPlace(Transform otherPlace)
		{
		}

		public void MoveTo(AdditionalSceneHandler handler)
		{
		}

		public void Hide()
		{
		}

		public void ShuttlePlayerToRankedArena(Action teleported, Action complete)
		{
		}

		[IteratorStateMachine(typeof(_003CLoadRankedArenaRoutine_003Ed__49))]
		private IEnumerator LoadRankedArenaRoutine(Action complete)
		{
			return null;
		}

		public void ShuttlePlayerToUnrankedArenNoMatchmaking(string roomName, string photonRegion, string playfabRegion, bool isObserver, Action<bool, ShutdownReason> flowComplete = null)
		{
		}

		public void ShuttlePlayerToUnrankedArenaWithMatchmaking(string roomName, PlayFabRegion playFabRegion, bool isObserver, Action<bool, ShutdownReason> flowComplete = null)
		{
		}

		private void ShuttlePlayerToUnrankedArena(LoadAndConnectData loadAndConnectData, bool isObserver, Action<bool, ShutdownReason> flowComplete)
		{
		}

		public void SetShuttleAoi(NetworkAreaFlag areaFlag)
		{
		}

		public void ShuttlePlayerToHub(Action flowComplete = null)
		{
		}

		[IteratorStateMachine(typeof(_003CLoadAndConnectRoutine_003Ed__55))]
		private IEnumerator LoadAndConnectRoutine(float delay, LoadAndConnectData loadAndConnectData, Action<bool, ShutdownReason> flowComplete)
		{
			return null;
		}

		public void ShuttlePlayerToHubFromKick(string customScreenText = null)
		{
		}

		private void ExecutePreShuttleActions(FieldType fieldType)
		{
		}

		private void ShuttleWithNoMatchmaking(LoadAndConnectData loadAndConnectData, Action<Action> onConnected, Action<bool, ShutdownReason> onConnectionCompleteResult)
		{
		}

		private void ShuttleWithMatchmaking(LoadAndConnectData loadAndConnectData, Action<Action> onConnected, Action<bool, ShutdownReason> onConnectionCompleteResult)
		{
		}

		private void ShuttleFromKick(LoadAndConnectData loadAndConnectData, Action<Action> onConnected, Action<bool, ShutdownReason> onConnectionCompleteResult)
		{
		}

		[AsyncStateMachine(typeof(_003CSwitchMainSceneOfflineAsync_003Ed__61))]
		private static void SwitchMainSceneOfflineAsync(FieldType fieldType, Action complete)
		{
		}

		private void CloseDoorsImmediately()
		{
		}

		public void OpenDoorForTeam(TeamNo teamNo)
		{
		}

		public void ShowHubConsole()
		{
		}

		public void HideHubConsole()
		{
		}

		public void SetScreenText(string text, bool isWaitingMessage = false)
		{
		}

		private void ToggleLightProbe(bool hasPlayer)
		{
		}

		private void TryToggleLightProbe()
		{
		}

		public static bool HasPlayerInShuttle()
		{
			return false;
		}

		[Button(null, EButtonEnableMode.Always)]
		private void TeleportPlayer()
		{
		}
	}
}

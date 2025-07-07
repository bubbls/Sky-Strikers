using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DP.Takeaway.Utils;
using Moon.Arena;
using TMPro;
using UnityEngine;

namespace Moon.Hub
{
	public class ShuttleElevator : MonoBehaviour, IAdditionalScene
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CSwitchMainSceneOfflineAsync_003Ed__31 : IAsyncStateMachine
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

		[CompilerGenerated]
		private sealed class _003CTeleportAndOpenDoorRoutine_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Transform thisPlace;

			public Transform otherPlace;

			public ShuttleElevator _003C_003E4__this;

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
			public _003CTeleportAndOpenDoorRoutine_003Ed__39(int _003C_003E1__state)
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
		private ElevatorShaft _elevatorShaft;

		[SerializeField]
		[Header("Quick Play")]
		private ShuttleRoomRegionSelector _regionSelectorQuickPlay;

		[SerializeField]
		private ManualButton _btnSwitchRegionQuickPlay;

		[SerializeField]
		private TMP_Text _textRttQuickPlay;

		[SerializeField]
		private ManualToggle _launchBtnQuickPlay;

		[SerializeField]
		[Header("Custom Game")]
		private ShuttleRoomRegionSelector _regionSelectorCustomGame;

		[SerializeField]
		private ManualButton _btnSwitchRegionCustomGame;

		[SerializeField]
		private TMP_Text _textRttCustomGame;

		[SerializeField]
		private ManualToggle _launchBtnCustomGame;

		[SerializeField]
		private ShuttleRoomSessionNamePad _sessionNamePad;

		[SerializeField]
		private TMP_Text _textOperation;

		[Header("Hub")]
		[SerializeField]
		private ManualToggle _launchBtnHub;

		[SerializeField]
		private Transform _playerTeleportPoint;

		private readonly Cooldown _updateCd;

		private bool _shouldTeleportPlayer;

		private bool _enableOperation;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void HandleQuickPlayLaunchButtonChanged()
		{
		}

		private void HandleHubLaunchButtonChanged()
		{
		}

		private void HandleCustomGameLaunchButtonChanged()
		{
		}

		private void HandleCustomGameBtnSwitchRegionPressed()
		{
		}

		private void HandleQuickPlayBtnSwitchRegionPressed()
		{
		}

		private void EnableOperations(bool b)
		{
		}

		private void ToggleLaunchButtons(bool toggleOn)
		{
		}

		private void LaunchElevatorToHub()
		{
		}

		private void LaunchElevatorToArena(bool forQuickPlay)
		{
		}

		private bool CheckConnection()
		{
			return false;
		}

		private void TeleportBeforeDoorOpen(FieldType fieldType, bool isPublic)
		{
		}

		private void TeleportToOtherScene(FieldType fieldType, bool isPublic)
		{
		}

		[AsyncStateMachine(typeof(_003CSwitchMainSceneOfflineAsync_003Ed__31))]
		private static void SwitchMainSceneOfflineAsync(FieldType fieldType, Action complete)
		{
		}

		private void UpdateConsoleTextsArrived(FieldType fieldType, bool isPublic)
		{
		}

		private void UpdateConsoleTextsCustomGame()
		{
		}

		private void UpdateLaunchButtons()
		{
		}

		private void HandleCustomGameRoomNameChanged()
		{
		}

		private void Update()
		{
		}

		private void UpdateRtt(int rtt)
		{
		}

		private void MoveToOtherPlaceWithPlayer(Transform otherPlace)
		{
		}

		[IteratorStateMachine(typeof(_003CTeleportAndOpenDoorRoutine_003Ed__39))]
		private IEnumerator TeleportAndOpenDoorRoutine(Transform thisPlace, Transform otherPlace)
		{
			return null;
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

		public void ShuttlePlayerToRankedArena(Action startLoadAction)
		{
		}

		public void HandleRankedArenaConnectingResult()
		{
		}

		public void ShuttlePlayerToHub(string message = "SHUTTLING...")
		{
		}

		public void OpenDoor()
		{
		}
	}
}

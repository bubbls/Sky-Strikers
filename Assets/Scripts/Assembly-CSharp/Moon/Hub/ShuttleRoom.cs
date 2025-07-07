using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using DG.Tweening;
using DP.Takeaway.VisualScripting;
using Moon.Arena;
using UnityEngine;

namespace Moon.Hub
{
	public class ShuttleRoom : ElevatorCabin
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass7_0
		{
			public TaskCompletionSource<int> closingDoorTcs;

			public FieldType fieldType;

			public ShuttleRoom _003C_003E4__this;

			public TaskCompletionSource<int> joiningTcs;

			internal void _003CConnectArea_003Eb__0()
			{
			}

			internal void _003CConnectArea_003Eb__1(Action complete)
			{
			}

			internal void _003CConnectArea_003Eb__2(Action complete)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CConnectArea_003Ed__7 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public FieldType fieldType;

			public ShuttleRoom _003C_003E4__this;

			private _003C_003Ec__DisplayClass7_0 _003C_003E8__1;

			public string roomName;

			public bool isPublic;

			private TaskAwaiter<int> _003C_003Eu__1;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CSwitchToArenaSceneOfflineAsync_003Ed__9 : IAsyncStateMachine
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

		private const string RegName = "b3b0b4e0-0b4e-4b0b-b0b4-e00b4e0b4e0";

		[SerializeField]
		private ShuttleRoomConsole _console;

		private CustomEventHandler _customEventHandler;

		private Sequence _sequence;

		private bool _connected;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		[AsyncStateMachine(typeof(_003CConnectArea_003Ed__7))]
		private void ConnectArea(FieldType fieldType, string roomName, bool isPublic)
		{
		}

		private void PlayerPlayerToLoadedRoom(Action complete)
		{
		}

		[AsyncStateMachine(typeof(_003CSwitchToArenaSceneOfflineAsync_003Ed__9))]
		private static void SwitchToArenaSceneOfflineAsync(FieldType fieldType, Action complete)
		{
		}

		private void HandleBtnPressed(string btnName)
		{
		}
	}
}

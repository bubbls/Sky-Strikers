using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Chamber8.Framework.Service.Rpc;
using Fusion;
using Moon.Backpack;
using UnityEngine;

namespace Moon.SNS
{
	public class MailBoxJoyoSpawner : MonoBehaviour, IRpcServer
	{
		[Serializable]
		public class SpawnData
		{
			public string[] ItemsIds;

			public ushort PlayerId;
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CSpawnJoyosAsync_003Ed__6 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public SpawnData spawnData;

			public NetworkRunner runner;

			public MailBoxJoyoSpawner _003C_003E4__this;

			public int delay;

			private BackpackItemNetworkStruct[] _003C_003E7__wrap1;

			private int _003C_003E7__wrap2;

			private BackpackItemNetworkStruct _003Citem_003E5__4;

			private int _003Ci_003E5__5;

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

		private const string JoyoFriendlyIdPrefix = "com.chamber8.skystrikersvr.consumable.";

		[SerializeField]
		private Transform _joyoSpawnPosition;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void OnRequestFromClient(Request request, Action<Response?> onComplete)
		{
		}

		[AsyncStateMachine(typeof(_003CSpawnJoyosAsync_003Ed__6))]
		private Task SpawnJoyosAsync(SpawnData spawnData, NetworkRunner runner, int delay)
		{
			return null;
		}

		private static BackpackItemNetworkStruct[] CreateItemList(SpawnData spawnData)
		{
			return null;
		}

		public void OnBroadcastFromServer(Request request)
		{
		}
	}
}

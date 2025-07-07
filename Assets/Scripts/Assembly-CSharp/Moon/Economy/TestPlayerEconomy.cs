using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using NaughtyAttributes;
using UnityEngine;

namespace Moon.Economy
{
	public class TestPlayerEconomy : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CAddSiplets_003Ed__0 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			private TaskAwaiter<bool> _003C_003Eu__1;

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
		private string _inventoryFilter;

		[SerializeField]
		private string _collectionId;

		[Button(null, EButtonEnableMode.Always)]
		[AsyncStateMachine(typeof(_003CAddSiplets_003Ed__0))]
		private void AddSiplets()
		{
		}

		[Button(null, EButtonEnableMode.Always)]
		private void GetUserInventory()
		{
		}
	}
}

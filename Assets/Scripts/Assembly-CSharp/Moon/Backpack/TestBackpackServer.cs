using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using NaughtyAttributes;
using UnityEngine;

namespace Moon.Backpack
{
	public class TestBackpackServer : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CTransferInventoryItems_003Ed__0 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

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

		[AsyncStateMachine(typeof(_003CTransferInventoryItems_003Ed__0))]
		[Button(null, EButtonEnableMode.Always)]
		private void TransferInventoryItems()
		{
		}
	}
}

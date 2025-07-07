using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using NaughtyAttributes;
using UnityEngine;

namespace Moon
{
	public class TestPlayerWebStore : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CAddPurchasedItemsFromWebStore_003Ed__1 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public TestPlayerWebStore _003C_003E4__this;

			private TaskAwaiter<PlayerWebStoreService.AddPurchasedItemsFromWebStoreResponseData> _003C_003Eu__1;

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
		private List<string> _skuIds;

		[AsyncStateMachine(typeof(_003CAddPurchasedItemsFromWebStore_003Ed__1))]
		[Button(null, EButtonEnableMode.Always)]
		private void AddPurchasedItemsFromWebStore()
		{
		}
	}
}

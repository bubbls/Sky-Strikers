using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Chamber8.Framework.Economy.API;
using Chamber8.Framework.Economy.Model;
using Oculus.Platform;
using Oculus.Platform.Models;
using UnityEngine.Scripting;

namespace Chamber8.Framework.Service.Oculus.IAP
{
	public class CheckoutRequest : AbstractApiRequest<PurchaseResult>
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCheckTimeout_003Ed__10 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public CheckoutRequest _003C_003E4__this;

			public TimeSpan timeSpan;

			private TaskAwaiter<string> _003C_003Eu__1;

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
		private struct _003CMockCheckout_003Ed__8 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public CheckoutRequest _003C_003E4__this;

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

		private readonly TaskCompletionSource<string> _tcs;

		private bool _isTimeout;

		public string SkuId { get; set; }

		public override void Execute()
		{
		}

		[AsyncStateMachine(typeof(_003CMockCheckout_003Ed__8))]
		private void MockCheckout()
		{
		}

		[Preserve]
		private void LaunchCheckoutFlowCallback(Message<Purchase> message)
		{
		}

		[AsyncStateMachine(typeof(_003CCheckTimeout_003Ed__10))]
		private void CheckTimeout(TimeSpan timeSpan)
		{
		}
	}
}

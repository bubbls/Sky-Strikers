using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

namespace Moon.Bootstrap
{
	public class ClientPreparingCycle : AbstractAsyncGameCycle
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass0_0
		{
			public GameObject go;

			public CancellationToken cancellationToken;

			internal void _003CBegin_003Eb__0()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CBegin_003Ed__0 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public CancellationToken cancellationToken;

			public ClientPreparingCycle _003C_003E4__this;

			private _003C_003Ec__DisplayClass0_0 _003C_003E8__1;

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

		[AsyncStateMachine(typeof(_003CBegin_003Ed__0))]
		public override Task Begin(CancellationToken cancellationToken)
		{
			return null;
		}

		private static void OnPermissionGranted(Object helper, CancellationToken cancellationToken)
		{
		}
	}
}

using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Chamber8.Framework.Common;
using Moon.Framework.Analytics;
using UnityEngine.Scripting;

namespace Moon.Framework.Service.Analytics.Unity
{
	[Preserve]
	public class UnityAnalytics : IAnalytics, IInitializer
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CInitializeAsync_003Ed__5 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public UnityAnalytics _003C_003E4__this;

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

		private bool _initialized;

		private readonly EventQueue _eventQueue;

		public string Name => null;

		public void Initialize()
		{
		}

		[AsyncStateMachine(typeof(_003CInitializeAsync_003Ed__5))]
		private void InitializeAsync()
		{
		}

		public void Log(string eventName, IDictionary<string, object> parameters = null)
		{
		}

		public void FlushLogs()
		{
		}

		public void SetSuperProperties(IDictionary<string, object> properties)
		{
		}

		public void SetUserProperties(IDictionary<string, object> properties)
		{
		}

		private static void LogInternal(string eventName, IDictionary<string, object> parameters)
		{
		}
	}
}

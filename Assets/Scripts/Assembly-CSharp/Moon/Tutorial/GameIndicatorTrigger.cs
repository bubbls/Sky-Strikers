using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DP.Takeaway.Sound;
using Moon.Player;
using UnityEngine;

namespace Moon.Tutorial
{
	public class GameIndicatorTrigger : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CStart_003Ed__7 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public GameIndicatorTrigger _003C_003E4__this;

			private TaskAwaiter<GameIndicators.GetGameTagsResult?> _003C_003Eu__1;

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
		private struct _003CTrigger_003Ed__8 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public GameIndicatorTrigger _003C_003E4__this;

			private TaskAwaiter<GameIndicators.SetGameTagResult?> _003C_003Eu__1;

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
		private string _tagListName;

		[SerializeField]
		private string _tagName;

		[SerializeField]
		private SoundInfo? _sfxTriggered;

		[SerializeField]
		private GameObject? _triggerGameObject;

		[SerializeField]
		private NotificationMessage _message;

		private bool _enableIndicator;

		private bool _isSendingRequest;

		[AsyncStateMachine(typeof(_003CStart_003Ed__7))]
		private void Start()
		{
		}

		[AsyncStateMachine(typeof(_003CTrigger_003Ed__8))]
		public void Trigger()
		{
		}

		private void UpdateVisual()
		{
		}
	}
}

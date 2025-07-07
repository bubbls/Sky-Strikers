using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using NaughtyAttributes;
using UnityEngine;

namespace Moon
{
	public class PlayerVisualsPrewarmer : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CPreloadAndPrewarm_003Ed__4 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public PlayerVisualsPrewarmer _003C_003E4__this;

			private List<GameObject>.Enumerator _003C_003E7__wrap1;

			private YieldAwaitable.YieldAwaiter _003C_003Eu__1;

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
		private struct _003CStart_003Ed__3 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public PlayerVisualsPrewarmer _003C_003E4__this;

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

		[SerializeField]
		private List<GameObject> _preloadedGameObjects;

		[SerializeField]
		private List<GameObject> _prewarmableGameObjects;

		[SerializeField]
		private float _prewarmDuration;

		[AsyncStateMachine(typeof(_003CStart_003Ed__3))]
		private void Start()
		{
		}

		[AsyncStateMachine(typeof(_003CPreloadAndPrewarm_003Ed__4))]
		private Task PreloadAndPrewarm()
		{
			return null;
		}

		[Button(null, EButtonEnableMode.Always)]
		public void FindPrewarmableObjects()
		{
		}

		private void FindPrewarmSchemes<T>() where T : VisualThemeScheme
		{
		}

		public void ClearPrewarmableObjects()
		{
		}
	}
}

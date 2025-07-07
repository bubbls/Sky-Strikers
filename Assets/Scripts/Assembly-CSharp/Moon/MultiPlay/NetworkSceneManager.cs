using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Fusion;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Moon.MultiPlay
{
	public class NetworkSceneManager : NetworkSceneManagerDefault
	{
		public enum SceneSlot
		{
			Main = 0,
			Additive0 = 1,
			Additive1 = 2,
			Additive2 = 3,
			_Count = 4
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass10_0
		{
			public Scene loadedScene;

			internal void _003CSwitchSceneSinglePeer_003Eb__0(Scene scene)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass11_0
		{
			public Scene loadedScene;

			internal void _003CSwitchMainSceneOfflineRoutine_003Eb__0(Scene scene)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass17_0
		{
			public Scene loadedScene;

			internal void _003CLoadAdditiveSceneRoutine_003Eb__0(Scene scene)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CLoadAdditiveSceneRoutine_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SceneSlot sceneSlot;

			public SceneRef oldSceneRef;

			public SceneRef newSceneRef;

			public NetworkSceneManager _003C_003E4__this;

			private _003C_003Ec__DisplayClass17_0 _003C_003E8__1;

			private int _003Ci_003E5__2;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CLoadAdditiveSceneRoutine_003Ed__17(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CSwitchMainSceneOfflineAsync_003Ed__12 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public NetworkSceneManager _003C_003E4__this;

			public string newScenePath;

			private TaskAwaiter<Scene> _003C_003Eu__1;

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

		[CompilerGenerated]
		private sealed class _003CSwitchMainSceneOfflineRoutine_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public NetworkSceneManager _003C_003E4__this;

			public string newScenePath;

			public TaskCompletionSource<Scene> tcs;

			private _003C_003Ec__DisplayClass11_0 _003C_003E8__1;

			private SceneRef _003CnewSceneRef_003E5__2;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CSwitchMainSceneOfflineRoutine_003Ed__11(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CSwitchSceneSinglePeer_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SceneRef prevScene;

			public NetworkSceneManager _003C_003E4__this;

			public SceneRef newScene;

			private _003C_003Ec__DisplayClass10_0 _003C_003E8__1;

			public FinishedLoadingDelegate finished;

			private Scene _003CemptyScene_003E5__2;

			private int _003Ci_003E5__3;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CSwitchSceneSinglePeer_003Ed__10(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CWaitForLoadingScreen_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public NetworkSceneManager _003C_003E4__this;

			public SceneRef[] newSceneRefs;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CWaitForLoadingScreen_003Ed__15(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private readonly SceneRef[] _sceneRefs;

		public static bool LoadingScreenDisplayFinished;

		private Coroutine _loadingScreenCoroutine;

		public event Action<SceneSlot> OnSceneLoaded
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<SceneSlot> OnSceneRegisteredToNetwork
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		[IteratorStateMachine(typeof(_003CSwitchSceneSinglePeer_003Ed__10))]
		protected override IEnumerator SwitchSceneSinglePeer(SceneRef prevScene, SceneRef newScene, FinishedLoadingDelegate finished)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CSwitchMainSceneOfflineRoutine_003Ed__11))]
		private IEnumerator SwitchMainSceneOfflineRoutine(string newScenePath, TaskCompletionSource<Scene> tcs)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CSwitchMainSceneOfflineAsync_003Ed__12))]
		public Task SwitchMainSceneOfflineAsync(string newScenePath)
		{
			return null;
		}

		public void NotifyNetworkedSceneChanged(SceneRef[] newSceneRefs)
		{
		}

		private void LoadScenesInternal(SceneRef[] newSceneRefs)
		{
		}

		[IteratorStateMachine(typeof(_003CWaitForLoadingScreen_003Ed__15))]
		private IEnumerator WaitForLoadingScreen(SceneRef[] newSceneRefs)
		{
			return null;
		}

		private void LoadScene(SceneSlot sceneSlot, SceneRef oldSceneRef, SceneRef newSceneRef)
		{
		}

		[IteratorStateMachine(typeof(_003CLoadAdditiveSceneRoutine_003Ed__17))]
		private IEnumerator LoadAdditiveSceneRoutine(SceneSlot sceneSlot, SceneRef oldSceneRef, SceneRef newSceneRef)
		{
			return null;
		}
	}
}

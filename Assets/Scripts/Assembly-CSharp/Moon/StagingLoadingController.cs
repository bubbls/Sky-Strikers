using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Chamber8.Framework.Common;
using Chamber8.Framework.Messaging;
using Moon.Bootstrap;
using Moon.MultiPlay;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Moon
{
	public class StagingLoadingController : SingleMonoBehaviour<StagingLoadingController, DefaultSingleMonoBehaviourSettings<StagingLoadingController>>
	{
		private enum LoadingStage
		{
			None = 0,
			Logo = 1,
			Connecting = 2,
			Loading = 3,
			End = 4
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CEnterNextStage_003Ed__27 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public StagingLoadingController _003C_003E4__this;

			private TaskAwaiter _003C_003Eu__1;

			private NetworkSceneManager _003CsceneManager_003E5__2;

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
		private struct _003CUnloadUnusedAssetsAsync_003Ed__28 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

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

		private const string FadeOutAnimationName = "BlackBackdrop_FadeOut";

		private const int FadeOutWaitTime = 600;

		private const int FadeOutDelayAfterLoadingComplete = 4000;

		[SerializeField]
		private Transform _cameraTransform;

		[SerializeField]
		private InputActionAsset _loadingInputActionAsset;

		[SerializeField]
		private GameObject _preload;

		[SerializeField]
		private ConnectionStatusHUD _connectionStatus;

		[SerializeField]
		private Transform _trackerPivot;

		[SerializeField]
		private Animator _bgAnimator;

		[SerializeField]
		private GameObject _fadeOutBg;

		private LoadingStage _stage;

		private IMessageSubscriber _subscriber;

		private bool _connected;

		private bool _stageEnd;

		private bool _lookForward;

		private bool _allScenesLoaded;

		public static bool IsLoading { get; private set; }

		public static event Action OnLoadingComplete
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

		private void Awake()
		{
		}

		private void LateUpdate()
		{
		}

		private void OnDestroy()
		{
		}

		[AsyncStateMachine(typeof(_003CEnterNextStage_003Ed__27))]
		private void EnterNextStage()
		{
		}

		[AsyncStateMachine(typeof(_003CUnloadUnusedAssetsAsync_003Ed__28))]
		private static void UnloadUnusedAssetsAsync()
		{
		}

		private void HandleOnSceneLoaded(NetworkSceneManager.SceneSlot sceneSlot)
		{
		}

		private int HandleConnChangedMessage(IMessage<ConnChangedMessage> message)
		{
			return 0;
		}

		private void LookForward()
		{
		}
	}
}

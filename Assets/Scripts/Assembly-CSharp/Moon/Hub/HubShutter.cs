using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using DG.Tweening;
using DP.Takeaway.Utils;
using Fusion;
using Moon.Arena;
using Moon.Bootstrap;
using Moon.MultiPlay;
using NaughtyAttributes;
using SVGImporter;
using TMPro;
using UnityEngine;

namespace Moon.Hub
{
	public class HubShutter : MonoBehaviour
	{
		[Serializable]
		private class ButtonVisualConfig
		{
			public SVGAsset SvgAsset;

			public Color TextColor;
		}

		[CompilerGenerated]
		private sealed class _003CEnableInteractions_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public HubShutter _003C_003E4__this;

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
			public _003CEnableInteractions_003Ed__42(int _003C_003E1__state)
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
		private struct _003CStartFetchingServerSessionInfo_003Ed__36 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public int delay;

			public HubShutter _003C_003E4__this;

			public CancellationToken cancellationToken;

			private bool _003CgotInfo_003E5__2;

			private TaskAwaiter<bool> _003C_003Eu__1;

			private TaskAwaiter _003C_003Eu__2;

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
		private struct _003CSwitchMainSceneOfflineAsync_003Ed__46 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public FieldType fieldType;

			public Action complete;

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
		[Header("Launch Button")]
		private ManualToggle _launchButton;

		[SerializeField]
		private TMP_Text _launchButtonText;

		[SerializeField]
		private SVGImage _launchButtonSvg;

		[SerializeField]
		private ButtonVisualConfig _normalStateVisualConfig;

		[SerializeField]
		private ButtonVisualConfig _disableStateVisualConfig;

		[Header("Region Selector")]
		[SerializeField]
		private ShuttleRoomRegionSelector _regionSelector;

		[SerializeField]
		private ManualButton _regionSelectorButton;

		[Header("Hub Session Number")]
		[SerializeField]
		private ShuttleRoomSessionNamePad _sessionNamePad;

		[Header("Operations Information")]
		[SerializeField]
		private TMP_Text _operationText;

		[SerializeField]
		private TMP_Text _rttText;

		[SerializeField]
		private GameObject _lookingForHubPage;

		[SerializeField]
		private GameObject _connectFailedPage;

		[SerializeField]
		private TMP_Text _failedText;

		[SerializeField]
		private GameObject _connectSucceedPage;

		[SerializeField]
		private List<TMP_Text> _codesText;

		[SerializeField]
		private TMP_Text _regionText;

		[SerializeField]
		private float _operationCooldown;

		[Header("Door")]
		[SerializeField]
		private GameObject _doorCollider;

		[SerializeField]
		private Transform _leftDoor;

		[SerializeField]
		private Transform _rightDoor;

		[SerializeField]
		private float _doorOpenDelay;

		[SerializeField]
		private MeshRenderer _windowRenderer;

		private readonly Cooldown _updateCd;

		private CancellationTokenSource _serverSessionInfoToken;

		private ServerSessionInfo _serverSessionInfo;

		private Sequence _sequence;

		private Coroutine _enableInteractionsCoroutine;

		[SerializeField]
		private string testCode;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void UpdateRtt(int rtt)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void HandleOnConnectionStatusChanged(ConnectionManager.Status status, ShutdownReason shutdownReason)
		{
		}

		private void InitiateServerSessionInfoFetching()
		{
		}

		private void JoinNewSession(bool isRandomPublic, string sessionId)
		{
		}

		[AsyncStateMachine(typeof(_003CStartFetchingServerSessionInfo_003Ed__36))]
		private void StartFetchingServerSessionInfo(int delay, CancellationToken cancellationToken)
		{
		}

		private void OnServerSessionInfoFetched(ServerSessionInfo info)
		{
		}

		private void UpdateServerSessionInfo(ServerSessionInfo info)
		{
		}

		private void CancelServerSessionInfoToken()
		{
		}

		private void HandleOnRegionSelectorButtonPressed()
		{
		}

		private void HandleOnLaunchButtonValueChanged()
		{
		}

		[IteratorStateMachine(typeof(_003CEnableInteractions_003Ed__42))]
		private IEnumerator EnableInteractions()
		{
			return null;
		}

		private void StartEnableInteractionsCoroutine()
		{
		}

		private void StopEnableInteractionsCoroutine()
		{
		}

		private void HandleOnSessionNameValueChanged()
		{
		}

		[AsyncStateMachine(typeof(_003CSwitchMainSceneOfflineAsync_003Ed__46))]
		private static void SwitchMainSceneOfflineAsync(FieldType fieldType, Action complete)
		{
		}

		private bool CheckConnection()
		{
			return false;
		}

		private void ToggleLaunchButton(bool toggleOn)
		{
		}

		private void ToggleInteractions(bool enable)
		{
		}

		private void SetLaunchButtonVisuals(ButtonVisualConfig buttonVisualConfig)
		{
		}

		private void ToggleDoor(bool open)
		{
		}

		[Button("Connect To Photon Server", EButtonEnableMode.Always)]
		private void DebugConnectToPhotonServer()
		{
		}
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DP.Takeaway.Utils;
using Fusion;
using Moon.MultiPlay;
using Moon.Player.Visual;
using Moon.Player.Visuals;
using Photon.Voice.Fusion;
using UnityEngine;

namespace Moon
{
	public class PlayerVisualsController : MonoBehaviour, ICommandExecutor, IDisposable
	{
		private const string PlayerVisualsControllerVisibleSource = "PlayerVisualsController";

		private readonly List<string> _invisibleReason;

		[SerializeField]
		private PlayerSkeleton _playerSkeleton;

		[SerializeField]
		private Transform _headPivot;

		[SerializeField]
		private Transform _bodyPivot;

		[SerializeField]
		private Transform _leftHandPivot;

		[SerializeField]
		private Transform _rightHandPivot;

		[SerializeField]
		private LocalPlayerSpeedLines _speedLines;

		[SerializeField]
		private Transform _debugPivot;

		[SerializeField]
		private PlayerHand _leftHand;

		[SerializeField]
		private PlayerHand _rightHand;

		[SerializeField]
		private GameObject _leftHandOfflineVfx;

		[SerializeField]
		private GameObject _rightHandOfflineVfx;

		[SerializeField]
		private Transform _playerPadFollowTarget;

		[SerializeField]
		private Transform _playerPadNotificationFollowTarget;

		[SerializeField]
		private PlayerInfoBoard _playerInfoBoard;

		[SerializeField]
		private PlayerInfoVisualsHandler _playerInfoVisualsHandler;

		[SerializeField]
		private GameObject _livCameraContainer;

		private PlayerNameTagVisual _currentNameTagVisual;

		private PlayerAvatarHeadVisual _currentAvatarHead;

		private PlayerAvatarBodyVisual _currentAvatarBody;

		private PlayerAvatarLegVisual _currentAvatarLeg;

		private PlayerSuitArmVisual _currentSuit;

		private PlayerSuitHandVisual _currentLeftSuitHandVisual;

		private PlayerSuitHandVisual _currentRightSuitHandVisual;

		private PlayerSuitWeaponVisual _currentSuitWeaponOnBack;

		private PlayerBackpackVisual _currentBackpack;

		private PlayerSuitWeaponVisual _currentLeftHandWeapon;

		private PlayerSuitWeaponVisual _currentRightHandWeapon;

		private bool _isLocalPlayer;

		private bool _visible;

		private VoiceNetworkObject _voiceNetworkObject;

		private PlayerVisualsConfig _loadedVisualsConfig;

		private PlayerRef _ownerPlayer;

		public Transform HeadPivot => null;

		public Transform BodyPivot => null;

		public Transform LeftHandPivot => null;

		public Transform RightHandPivot => null;

		public PlayerHand LeftHand => null;

		public PlayerHand RightHand => null;

		public bool IsVisible => false;

		public PlayerBackpackVisual BackpackVisual => null;

		public event Action OnSuitChanged
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

		public event Action<Transform, PlayerSuitHandVisual, bool> OnHandChanged
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

		public event Action<Transform, PlayerSuitWeaponVisual, bool> OnHeldWeaponChanged
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

		public void Initialize(VoiceNetworkObject voiceNetworkObject, PlayerRef ownerPlayer, bool isLocalPlayer)
		{
		}

		public void Dispose()
		{
		}

		public void ClearInvisibleReasons()
		{
		}

		private void LocalPlayerRig_OnRequestToggleHandMenu()
		{
		}

		public void UpdateVisuals(PlayerInfo playerInfo)
		{
		}

		private bool TryUnloadVisual(in PlayerVisualBase targetVisual, int currentTheme, int targetTheme)
		{
			return false;
		}

		private void UnloadVisual(in PlayerVisualBase targetVisual)
		{
		}

		private bool TryUpdateHandVisuals(ref PlayerSuitHandVisual suitHandVisual, SuitVisualTheme targetHandTheme, bool isLeft)
		{
			return false;
		}

		private bool TryUpdateHeldWeaponVisual(ref PlayerSuitWeaponVisual suitWeaponVisual, SuitWeaponVisualTheme targetTheme, bool isLeft)
		{
			return false;
		}

		private void HandleHandChanged(PlayerSuitHandVisual suitHandVisual, bool isLeft)
		{
		}

		private void HandleOnNewVisualLoaded(in PlayerVisualBase visual)
		{
		}

		public ICommand ExecuteCommand(ICommand command)
		{
			return null;
		}

		private void TryExecuteCommandOnVisual(in PlayerVisualBase playerVisual, ICommand command)
		{
		}

		public void ToggleCarriedItemVisibility(bool showCarriedItem)
		{
		}

		private void UpdateOwnerPlayer()
		{
		}

		private void SetOwnerOnVisual(VisualBase visual)
		{
		}

		public void RemoveAllVisuals()
		{
		}

		public void Render(ITrackerPositionRotationProvider provider)
		{
		}

		public void RaiseChangedEvents()
		{
		}

		public void ToggleLivCameraContainer(bool show)
		{
		}

		public void SetVisible(bool visible)
		{
		}

		public void SetVisible(bool visible, string source)
		{
		}

		private void HandleConnChanged(ConnectionManager.Status status, ShutdownReason shutdownReason)
		{
		}

		private void UpdateOfflineFx(ConnectionManager.Status status)
		{
		}
	}
}

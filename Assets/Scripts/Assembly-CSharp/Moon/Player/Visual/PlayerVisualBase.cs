using DP.Takeaway.Utils;
using Fusion;
using JetBrains.Annotations;
using Moon.Arena;
using NaughtyAttributes;
using UnityEngine;

namespace Moon.Player.Visual
{
	public abstract class PlayerVisualBase : VisualBase, ICommandExecutor
	{
		[SerializeField]
		protected PlayerMaterials _playerMaterials;

		[SerializeField]
		protected GameObject _priceTag;

		[SerializeField]
		private PlayerInfoVisual[] _playerInfoVisuals;

		[SerializeField]
		private CustomAttachPointAdjustments _attachPointAdjustments;

		public PlayerInfoVisual[] PlayerInfoVisuals => null;

		public abstract int ThemeInt { get; }

		protected PlayerSkeleton PlayerSkeleton { get; private set; }

		public void Initialize(PlayerRef ownerPlayer, bool isLocalPlayerVisual, int theme, PlayerVisualAttachPointType attachPointType)
		{
		}

		public void SetPlayerSkeleton(PlayerSkeleton playerSkeleton)
		{
		}

		protected virtual void HandleOnPlayerSkeletonChanged(PlayerSkeleton playerSkeleton)
		{
		}

		protected abstract void SetTheme(int theme);

		protected abstract void InitializeInternal();

		protected bool IsAttachedOnPlayer()
		{
			return false;
		}

		public ICommand ExecuteCommand(ICommand command)
		{
			return null;
		}

		protected virtual void HandleCommandExecution(ICommand command)
		{
		}

		public void TogglePriceTag(bool visible)
		{
		}

		protected abstract PlayerMaterial GetPlayerMaterial(TeamNo teamNo);

		public override void SetTeamColor(TeamNo teamNo)
		{
		}

		public override void EnableHologramMaterial()
		{
		}

		protected void TryConfigurePlayerMaterial(bool enableOutline = true, bool enablePerformanceMode = true)
		{
		}

		[Button("Try Assign Common Components", EButtonEnableMode.Always)]
		[UsedImplicitly]
		private void TryAssignCommonComponents()
		{
		}

		protected virtual void TryAssignCommonComponentsInternal()
		{
		}
	}
}

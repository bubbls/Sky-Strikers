using Moon.Arena;
using UnityEngine;

namespace Moon.Player.Visual
{
	public class PlayerAvatarBodyVisual : PlayerAvatarVisual
	{
		[SerializeField]
		private Transform _avatarHand_Left;

		[SerializeField]
		private Transform _avatarHand_Right;

		private Transform _handLeft;

		private Transform _handRight;

		private bool _hasAvatarHands;

		private bool _hasBindedHands;

		public AvatarBodyVisualTheme AvatarBodyVisualTheme { get; private set; }

		public override int ThemeInt => 0;

		protected override void SetTheme(int theme)
		{
		}

		protected override void InitializeInternal()
		{
		}

		protected override PlayerMaterial GetPlayerMaterial(TeamNo teamNo)
		{
			return default(PlayerMaterial);
		}

		private void LateUpdate()
		{
		}

		private void UpdateHands()
		{
		}

		protected override void HandleOnPlayerSkeletonChanged(PlayerSkeleton playerSkeleton)
		{
		}
	}
}

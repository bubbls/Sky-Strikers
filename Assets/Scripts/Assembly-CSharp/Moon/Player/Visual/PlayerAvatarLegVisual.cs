using Moon.Arena;
using UnityEngine;

namespace Moon.Player.Visual
{
	public class PlayerAvatarLegVisual : PlayerAvatarVisual
	{
		[SerializeField]
		private RotateByVelocity _rotateByVelocity;

		[SerializeField]
		private PlayerVisualsVelocityTracker _velocityTracker;

		public AvatarLegVisualTheme AvatarLegVisualTheme { get; private set; }

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
	}
}

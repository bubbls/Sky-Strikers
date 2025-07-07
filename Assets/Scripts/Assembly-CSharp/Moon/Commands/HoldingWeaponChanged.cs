using Moon.Player.Visual;

namespace Moon.Commands
{
	public class HoldingWeaponChanged : PlayerCommand
	{
		private readonly bool _isLeftHandHoldingWeapon;

		private readonly bool _isRightHandHoldingWeapon;

		public HoldingWeaponChanged(bool isLeftHandHoldingWeapon, bool isRightHandHoldingWeapon)
		{
		}

		protected override void Execute(PlayerAvatarHeadVisual headVisual)
		{
		}

		protected override void Execute(PlayerAvatarBodyVisual bodyVisual)
		{
		}

		protected override void Execute(PlayerAvatarLegVisual legVisual)
		{
		}

		protected override void Execute(PlayerSuitArmVisual armVisual)
		{
		}

		protected override void Execute(PlayerSuitHandVisual suitHandVisual)
		{
		}

		protected override void Execute(PlayerVisualsController playerVisualsController)
		{
		}
	}
}

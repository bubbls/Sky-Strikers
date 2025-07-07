using Moon.MultiPlay;
using Moon.Player.Visual;
using Moon.Player.Visuals;

namespace Moon.Commands
{
	public class UpdatePlayerInfo : PlayerCommand
	{
		private PlayerInfo _playerInfo;

		private PlayerInfo? _oldPlayerInfo;

		private bool _doNotUpdateModel;

		private static readonly UpdatePlayerInfo _instance;

		private UpdatePlayerInfo()
		{
		}

		public static UpdatePlayerInfo Reset(PlayerInfo playerInfo, PlayerInfo? oldPlayerInfo, bool doNotUpdateModel = false)
		{
			return null;
		}

		protected override void Execute(PlayerVisualsController playerVisualsController)
		{
		}

		protected override void Execute(PlayerInfoVisualsHandler playerInfoVisualsHandler)
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

		protected override void Execute(PlayerSuitHandVisual handVisual)
		{
		}

		protected override void Execute(PlayerSuitWeaponVisual visual)
		{
		}

		protected override void Execute(PlayerBackpackVisual backpackVisual)
		{
		}

		protected override void Execute(PlayerNameTagVisual nameTagVisual)
		{
		}

		protected override void Execute(MAmmoBox ammoBox)
		{
		}

		private bool DidTeamChange()
		{
			return false;
		}
	}
}

using DP.Takeaway.Utils;
using Moon.Player.Visual;
using Moon.Player.Visuals;

namespace Moon.Commands
{
	public abstract class PlayerCommand : ICommand
	{
		public void Accept(ICommandExecutor executor)
		{
		}

		protected virtual void Execute(MAmmoBox ammoBox)
		{
		}

		protected virtual void Execute(PlayerVisualsController playerVisualsController)
		{
		}

		protected virtual void Execute(PlayerInfoVisualsHandler playerInfoVisualsHandler)
		{
		}

		protected virtual void Execute(PlayerMaterials playerMaterials)
		{
		}

		protected virtual void Execute(LocalPlayerRig localPlayerRig)
		{
		}

		protected virtual void Execute(PlayerAvatarHeadVisual headVisual)
		{
		}

		protected virtual void Execute(PlayerSuitWeaponVisual visual)
		{
		}

		protected virtual void Execute(PlayerAvatarBodyVisual bodyVisual)
		{
		}

		protected virtual void Execute(PlayerAvatarLegVisual legVisual)
		{
		}

		protected virtual void Execute(PlayerSuitArmVisual armVisual)
		{
		}

		protected virtual void Execute(PlayerSuitHandVisual handVisual)
		{
		}

		protected virtual void Execute(PlayerBackpackVisual backpackVisual)
		{
		}

		protected virtual void Execute(PlayerNameTagVisual playerInfoVisualsHandler)
		{
		}
	}
}

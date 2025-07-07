using Moon.Arena;
using UnityEngine;

namespace Moon.Player.Visual
{
	public abstract class PlayerInfoVisual : MonoBehaviour
	{
		[SerializeField]
		private PlayerMaterials _playerMaterials;

		public PlayerMaterials PlayerMaterials => null;

		public void NotifyTeamMaterialChanged(PlayerMaterial material, TeamNo teamNo)
		{
		}

		protected virtual void HandleOnTeamMaterialChanged(PlayerMaterial material, TeamNo teamNo)
		{
		}
	}
}

using UnityEngine;

namespace Moon.Player.Visual
{
	public class DefaultPlayerRoleVisual : PlayerRoleVisual
	{
		[SerializeField]
		private GameObject _gameMasterIndicator;

		public override void SetGameRole(bool isGameMaster)
		{
		}
	}
}

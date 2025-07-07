using Moon.Arena;
using Moon.Player.Visual;
using UnityEngine;

namespace Moon.Player.Visuals
{
	public class PlayerNameTagVisual : PlayerVisualBase
	{
		[SerializeField]
		private PlayerNameVisual _playerNameVisual;

		private Transform _followTransform;

		private bool _isPlayerNameVisualActive;

		public override int ThemeInt => 0;

		public NameTagVisualTheme NameTagVisualTheme { get; private set; }

		protected override void SetTheme(int theme)
		{
		}

		protected override void InitializeInternal()
		{
		}

		private void OnDestroy()
		{
		}

		protected override PlayerMaterial GetPlayerMaterial(TeamNo teamNo)
		{
			return default(PlayerMaterial);
		}

		public void SetFollowTransform(Transform followTransform)
		{
		}

		private void LateUpdate()
		{
		}

		private void GameOption_OnOptionsSaved(GameOption.Options options)
		{
		}
	}
}

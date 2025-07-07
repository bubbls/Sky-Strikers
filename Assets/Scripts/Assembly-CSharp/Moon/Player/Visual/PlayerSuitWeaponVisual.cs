using System.Collections.Generic;
using Moon.Arena;
using UnityEngine;

namespace Moon.Player.Visual
{
	public class PlayerSuitWeaponVisual : PlayerVisualBase, IWeaponVisual
	{
		[SerializeField]
		private List<GameObject> _objectsToShowWhenSpawned;

		private bool _shouldShowWeapon;

		public GameObject GameObject => null;

		public SuitWeaponVisualTheme SuitWeaponVisualTheme { get; private set; }

		public override int ThemeInt => 0;

		protected bool IsAttachedToHand { get; private set; }

		protected bool IsSpawnedOnServer { get; private set; }

		protected TeamNo TeamNo { get; private set; }

		protected override void SetTheme(int theme)
		{
		}

		protected override void InitializeInternal()
		{
		}

		protected virtual void InitializeVisualOnHand()
		{
		}

		protected override PlayerMaterial GetPlayerMaterial(TeamNo teamNo)
		{
			return default(PlayerMaterial);
		}

		public override void SetTeamColor(TeamNo teamNo)
		{
		}

		void IWeaponVisual.ToggleSpawnedOnServerVisuals(bool show)
		{
		}

		protected virtual void HandleSpawnedVisuals(bool isSpawned)
		{
		}

		public void Show()
		{
		}

		protected virtual void HandleShow()
		{
		}

		public void Hide(bool instantly)
		{
		}

		protected virtual void HandleHide(bool instantly)
		{
		}
	}
}

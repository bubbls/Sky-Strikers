using System;
using Moon.Arena;
using UnityEngine;

namespace Moon.Player.Visual
{
	public class ChampionWeaponFxMaterialColorToggler : ChampionWeaponFx
	{
		[Serializable]
		private class MaterialColorPair
		{
			[SerializeField]
			private Renderer[] _renderers;

			[SerializeField]
			private string _colorProperty;

			[SerializeField]
			private Color _enabledColor;

			[SerializeField]
			private Color _disabledColor;

			public void UpdateColor(bool enabled)
			{
			}
		}

		[SerializeField]
		private VisualBase _visualBase;

		[SerializeField]
		private MaterialColorPair[] _materialColorPairs;

		protected override void InitializeInternal()
		{
		}

		protected override void DisposeInternal()
		{
		}

		private void OnTeamNoUpdated(TeamNo _)
		{
		}

		protected override void EnableFxInternal()
		{
		}

		protected override void DisableFxInternal()
		{
		}

		private void RefreshMaterialColors()
		{
		}
	}
}

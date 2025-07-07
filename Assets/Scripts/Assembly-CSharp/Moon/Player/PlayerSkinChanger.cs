using System;
using JetBrains.Annotations;
using NaughtyAttributes;
using UnityEngine;

namespace Moon.Player
{
	public class PlayerSkinChanger : MonoBehaviour
	{
		[SerializeField]
		private UIButton _uiButtonObj;

		[SerializeField]
		private Transform _buttonParent;

		private Array _visualThemes;

		[SerializeField]
		private SuitVisualTheme _forcedFullTheme;

		[SerializeField]
		private AvatarHeadVisualTheme _forcedAvatarTheme;

		[SerializeField]
		private SuitWeaponVisualTheme _forcedWeaponTheme;

		private void Start()
		{
		}

		private void ChangeSkin(SuitVisualTheme theme)
		{
		}

		private void ChangeSkin(SuitWeaponVisualTheme theme)
		{
		}

		[UsedImplicitly]
		[Button("Force Full Theme", EButtonEnableMode.Playmode)]
		private void ForceSetTheme()
		{
		}

		[Button("Force Change Avatar", EButtonEnableMode.Playmode)]
		[UsedImplicitly]
		private void ForceSetAvatar()
		{
		}

		[UsedImplicitly]
		[Button("Force Weapon Theme", EButtonEnableMode.Playmode)]
		private void ForceSetWeaponTheme()
		{
		}

		[Button("Force Change Team", EButtonEnableMode.Playmode)]
		[UsedImplicitly]
		private void ForceChangeTeam()
		{
		}

		[UsedImplicitly]
		[Button("Change To Observer", EButtonEnableMode.Playmode)]
		public void ChangeToObserver()
		{
		}
	}
}

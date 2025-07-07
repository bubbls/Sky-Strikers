using UnityEngine;

namespace Moon
{
	public interface IWeaponVisual
	{
		GameObject GameObject { get; }

		void ToggleSpawnedOnServerVisuals(bool isSpawnedOnServer);

		void Show();

		void Hide(bool instant);
	}
}

using JetBrains.Annotations;
using Moon.Arena;
using NaughtyAttributes;
using UnityEngine;

namespace Moon.Hub
{
	public class CustomArenaObserverModePanel : MonoBehaviour
	{
		private const string ObserverModeInstructionsSeenKey = "ObserverModeInstructionsSeen";

		[SerializeField]
		private ManualButton _manualButton;

		[SerializeField]
		private ScreenToggleController _screenToggleController;

		private void Start()
		{
		}

		private void ManualButton_OnPressed()
		{
		}

		[Button(null, EButtonEnableMode.Always)]
		[UsedImplicitly]
		private void ClearPlayerPref()
		{
		}
	}
}

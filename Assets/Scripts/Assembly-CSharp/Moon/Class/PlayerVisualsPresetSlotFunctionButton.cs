using Moon.Hub;
using SVGImporter;
using TMPro;
using UnityEngine;

namespace Moon.Class
{
	public class PlayerVisualsPresetSlotFunctionButton : ManualButton
	{
		public enum State
		{
			Empty = 0,
			Save = 1,
			Equip = 2,
			DeleteConfirm = 3
		}

		[SerializeField]
		private TMP_Text _text;

		[SerializeField]
		private SVGRenderer _svgRenderer;

		[SerializeField]
		private SVGAsset _greenBg;

		[SerializeField]
		private SVGAsset _redBg;

		public State CurrentState { get; private set; }

		public void ShowEmptyState()
		{
		}

		public void ShowSaveState()
		{
		}

		public void ShowEquipState()
		{
		}

		public void ShowConfirmState()
		{
		}
	}
}

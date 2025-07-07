using System;
using DP.Takeaway.Utils;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Moon.Player.Pad
{
	public class PlayerPadBatteryLevel : MonoBehaviour
	{
		[Serializable]
		private class BatteryLevelColor
		{
			public int Level;

			public Color Color;
		}

		[SerializeField]
		private BatteryLevelColor[] _batteryLevelColors;

		[SerializeField]
		private TMP_Text _batteryText;

		[SerializeField]
		private Image _batteryLevelFill;

		[SerializeField]
		private Graphic _batteryBg;

		[SerializeField]
		private float _updateInterval;

		private float _batteryLevelPrecise;

		private int _batteryLevel;

		private Cooldown _cd;

		public void Initialize()
		{
		}

		public void TryUpdateBattery()
		{
		}

		public void ForceUpdateBattery()
		{
		}

		private Color GetBatteryColor(int batteryLevel)
		{
			return default(Color);
		}
	}
}

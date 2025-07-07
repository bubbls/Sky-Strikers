using DP.Takeaway.Utils;
using TMPro;
using UnityEngine;

namespace Moon.Player.Pad
{
	public class PlayerPadTime : MonoBehaviour
	{
		[SerializeField]
		private TMP_Text _timeText;

		private bool _is24HourFormat;

		private string _timeFormat;

		private float _cachedUpdateInterval;

		private Cooldown _cd;

		public void Initialize()
		{
		}

		public void RefreshTimeInterval()
		{
		}

		public void TryUpdateTime()
		{
		}
	}
}

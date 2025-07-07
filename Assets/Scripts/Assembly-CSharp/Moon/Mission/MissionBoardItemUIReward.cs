using TMPro;
using UnityEngine;

namespace Moon.Mission
{
	public class MissionBoardItemUIReward : MonoBehaviour
	{
		[SerializeField]
		private TMP_Text _rewardText;

		[SerializeField]
		private GameObject _iconHasReward;

		[SerializeField]
		private GameObject _iconNoReward;

		[SerializeField]
		[Space(3f)]
		private StateColors _colors;

		public void ToggleVisual(bool enable)
		{
		}

		public void UpdateVisuals(MissionStatus missionStatus, string reward)
		{
		}
	}
}

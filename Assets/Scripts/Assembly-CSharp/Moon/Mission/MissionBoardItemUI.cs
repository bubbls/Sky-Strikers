using Chamber8.Framework.Common;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Moon.Mission
{
	public class MissionBoardItemUI : MonoBehaviour, IMissionItemUI, IInitializer
	{
		[Header("Visuals")]
		[Space(3f)]
		[SerializeField]
		private TMP_Text _descriptionText;

		[SerializeField]
		private Image _progressFillImage;

		[SerializeField]
		private TMP_Text _progressText;

		[SerializeField]
		private GameObject _claimedText;

		[SerializeField]
		private MissionBoardItemUIReward _freeCurrencyRewardUI;

		[SerializeField]
		private MissionBoardItemUIReward _activityRewardUI;

		private MissionRecord _missionData;

		public IMissionItemUI Previous { get; set; }

		public bool IsFirst { get; set; }

		public bool IsLast { get; set; }

		public MissionRecord Mission()
		{
			return null;
		}

		public void Initialize()
		{
		}

		public void Render(MissionRecord missionData)
		{
		}

		private void UpdateProgress(MissionStatus status)
		{
		}
	}
}

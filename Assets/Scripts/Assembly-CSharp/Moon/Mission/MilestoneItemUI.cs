using Chamber8.Framework.Common;
using UnityEngine;
using UnityEngine.UI;

namespace Moon.Mission
{
	public class MilestoneItemUI : MonoBehaviour, IMissionItemUI, IInitializer
	{
		[SerializeField]
		private Image _progressIconUpperPart;

		[SerializeField]
		private Image _progressIconMiddlePart;

		[SerializeField]
		private Image _progressIconLowerPart;

		[SerializeField]
		private Image _bottomBorderLine;

		[Space(6f)]
		[SerializeField]
		private StatsLabel _progressLabel;

		[SerializeField]
		private StatsLabel _milestoneLabel;

		[SerializeField]
		private StatsLabel _rewardLabel;

		[SerializeField]
		[Space(6f)]
		private MissionItemVisualConfig _visualConfig;

		private MissionRecord _mission;

		private int _index;

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

		public void Render(MissionRecord mission)
		{
		}

		private void SetTextColor(Color color)
		{
		}

		private void SetProgressIconColor(Color upperPartColor, Color middlePartColor, Color lowerPartColor)
		{
		}

		private void SetProgressLowerPartIconColor(Color color)
		{
		}

		private void SetProgress(string progress, Color color)
		{
		}
	}
}

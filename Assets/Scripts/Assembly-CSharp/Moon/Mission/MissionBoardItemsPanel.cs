using System;
using System.Collections.Generic;
using UnityEngine;

namespace Moon.Mission
{
	public class MissionBoardItemsPanel : MissionUIBase
	{
		[SerializeField]
		private Transform _missionSpawnPoint;

		private readonly List<IMissionItemUI> _missionItems;

		public Func<Transform, IMissionItemUI> RequestSpawnItem;

		public void UpdateMissions(List<MissionRecord> missions)
		{
		}
	}
}

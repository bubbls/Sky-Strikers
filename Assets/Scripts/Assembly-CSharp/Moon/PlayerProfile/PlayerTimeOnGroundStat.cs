using System.Collections.Generic;
using Moon.AI.VisualScripting;
using UnityEngine;

namespace Moon.PlayerProfile
{
	public class PlayerTimeOnGroundStat : MonoBehaviour
	{
		public PlayerOnGroundType groundType;

		public OverlapShapeDesc overlapShapeDesc;

		private static float _onGroundTimer;

		private static float _lowAirTimer;

		private static float _highAirTimer;

		public static float OnGroundTime;

		public static float LowAirTime;

		public static float HighAirTime;

		private static PlayerTimeOnGroundStat _onlyOneStat;

		public static List<PlayerTimeOnGroundStat> PlayerTimeOnGroundStats;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public static void Reset()
		{
		}

		public void Enter()
		{
		}

		public void Exit()
		{
		}
	}
}

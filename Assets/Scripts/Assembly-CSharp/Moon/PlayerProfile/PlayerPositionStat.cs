using System;
using System.Collections.Generic;
using Moon.AI.VisualScripting;
using Moon.Arena;
using UnityEngine;

namespace Moon.PlayerProfile
{
	public class PlayerPositionStat : MonoBehaviour
	{
		[SerializeField]
		public TeamNo teamNo;

		[SerializeField]
		public OverlapShapeDesc overlapShapeDesc;

		private bool _entered;

		private float _timer;

		[NonSerialized]
		public float time;

		public static List<PlayerPositionStat> PlayerPositionStats;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public void Reset()
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

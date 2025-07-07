using System;
using DP.Takeaway.Runtime;
using Moon.Class;
using UnityEngine;

namespace Moon.Leaderboard
{
	public class PlayerVisualsPresetPointsProvider : MonoBehaviour
	{
		[Serializable]
		private class PointsLookup : SerializableDictionary<PlayerSuitClass, PlayerVisualsPresetPoints>
		{
		}

		[SerializeField]
		private PointsLookup _presetPoints;

		public PlayerVisualsPresetPoints? GetPresetPoints(PlayerSuitClass preferredSuitClass)
		{
			return null;
		}
	}
}

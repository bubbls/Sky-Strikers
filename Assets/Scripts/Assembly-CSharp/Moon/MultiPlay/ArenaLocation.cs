using System.Collections.Generic;
using DP.Takeaway.Utils;
using Fusion;
using Moon.AI.VisualScripting;
using UnityEngine;

namespace Moon.MultiPlay
{
	public class ArenaLocation : InPlaceList<ArenaLocation>
	{
		private static Vector3 CachedLocalPlayerPosition;

		private static Location CachedLocationMask;

		private static ArenaLocation CachedLocation;

		[SerializeField]
		private OverlapShapeDesc _overlapShapeDesc;

		[SerializeField]
		private Location _location;

		private void CheckPlayerInternal(NetworkObject networkObject, List<(PlayerRef, Location)> playerRefs, PlayerRef overlapPerspective)
		{
		}

		private Location CheckSinglePlayerInternal(PlayerRef playerRef)
		{
			return default(Location);
		}

		public static Location CheckSinglePlayer(PlayerRef playerRef)
		{
			return default(Location);
		}

		public static Location CheckLocalPlayer()
		{
			return default(Location);
		}

		public static void CheckPlayers(NetworkObject networkObject, List<(PlayerRef, Location)> playerRefs, PlayerRef overlapPerspective)
		{
		}

		public static Location CheckPosition(Vector3 position)
		{
			return default(Location);
		}
	}
}

using DP.Takeaway.Utils;
using Fusion;
using Moon.AI.VisualScripting;
using UnityEngine;

namespace Moon.MultiPlay.Aoi
{
	[DisallowMultipleComponent]
	public sealed class NetworkAoiArea : InPlaceList<NetworkAoiArea>
	{
		[SerializeField]
		private OverlapShapeDesc[] _overlapShapeDescs;

		[SerializeField]
		private NetworkAreaFlag _areaFlag;

		private static NetworkRunner _runner;

		public static void CheckAreaForLocalPlayer()
		{
		}

		private bool CheckLocalPlayerInternal()
		{
			return false;
		}

		private bool CheckSinglePlayerInternal(PlayerRef playerRef)
		{
			return false;
		}

		private void HandleLocalPlayer(bool inside)
		{
		}

		private static void SetLocalPlayerVisionFlag(NetworkVisionFlag visionFlag)
		{
		}

		public void SetFlag(NetworkAreaFlag flag)
		{
		}
	}
}

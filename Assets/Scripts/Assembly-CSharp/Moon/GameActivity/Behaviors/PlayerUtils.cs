using Fusion;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.GameActivity.Behaviors
{
	public class PlayerUtils : MonoBehaviour
	{
		[Preserve]
		public bool IsMe(MPlayer player)
		{
			return false;
		}

		[Preserve]
		public bool IsMe(PlayerRef playerRef)
		{
			return false;
		}

		[Preserve]
		public MPlayer GetPlayer(GameObject playerObject)
		{
			return null;
		}

		[Preserve]
		public Transform GetInterpolationPart(MPlayer player, PlayerParts part)
		{
			return null;
		}

		[Preserve]
		public bool HasSiplets(MPlayer player)
		{
			return false;
		}
	}
}

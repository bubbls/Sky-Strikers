using Fusion;
using Moon.AI.VisualScripting;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.GameActivity.Behaviors
{
	[Preserve]
	public class AnyPlayerPartInSight : MonoBehaviour
	{
		private struct PlayerPartDistance
		{
			public readonly float Distance;

			public readonly PlayerParts Part;

			public PlayerPartDistance(PlayerParts part, float distance)
			{
				Distance = 0f;
				Part = default(PlayerParts);
			}
		}

		[Preserve]
		public PlayerParts Any(MPlayer player, OverlapShapeDesc sight, PlayerParts parts, bool sortByDistance = true)
		{
			return default(PlayerParts);
		}

		private static bool IsInsideRange(NetworkTransform networkTransform, OverlapShapeDesc sight, out float distance)
		{
			distance = default(float);
			return false;
		}
	}
}

using DP.Takeaway.Utils;
using NaughtyAttributes;
using UnityEngine;

namespace Moon.MultiPlay
{
	public class MArenaLocations : MonoBehaviour
	{
		private readonly Cooldown _cooldown;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		[Button(null, EButtonEnableMode.Always)]
		private void LogArenaLocations()
		{
		}

		public static void CheckLocationForLocalPlayer()
		{
		}

		public static Location CheckLocationForPosition(Vector3 position)
		{
			return default(Location);
		}
	}
}

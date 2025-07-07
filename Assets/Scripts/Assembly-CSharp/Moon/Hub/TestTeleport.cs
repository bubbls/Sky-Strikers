using NaughtyAttributes;
using UnityEngine;

namespace Moon.Hub
{
	public class TestTeleport : MonoBehaviour
	{
		[Button(null, EButtonEnableMode.Always)]
		private void Teleport()
		{
		}

		[Button(null, EButtonEnableMode.Always)]
		private void TeleportAndFreeze()
		{
		}
	}
}

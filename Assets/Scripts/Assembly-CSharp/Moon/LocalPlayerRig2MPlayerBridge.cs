using UnityEngine;

namespace Moon
{
	public class LocalPlayerRig2MPlayerBridge : MonoBehaviour
	{
		public LocalPlayerRig LocalPlayerRig { get; private set; }

		public MPlayer MPlayer { get; private set; }

		private void Awake()
		{
		}

		public void SetMPlayer(MPlayer player)
		{
		}
	}
}

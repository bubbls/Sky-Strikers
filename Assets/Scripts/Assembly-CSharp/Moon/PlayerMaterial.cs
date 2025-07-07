using System;
using TMPro;
using UnityEngine;

namespace Moon
{
	[Serializable]
	public struct PlayerMaterial
	{
		public Material Default;

		public Material Emission;

		public Material Glass;

		public Material Spawning;

		public Material Hologram;

		public TMP_FontAsset TeamFont;
	}
}

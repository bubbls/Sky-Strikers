using System;
using Chamber8.Framework.Common;
using DP.Takeaway.Runtime;
using DP.Takeaway.Sound;
using UnityEngine;

namespace Moon
{
	[CreateAssetMenu(menuName = "Moon/Create JukeboxScheme", fileName = "JukeboxScheme", order = 0)]
	public class JukeboxScheme : SingleScriptableObject<JukeboxScheme, DefaultResourcePathProvider<JukeboxScheme>>
	{
		[Serializable]
		public class JukeboxSchemeConfig
		{
			public SoundInfo BGMSoundInfo;
		}

		[Serializable]
		private class JukeboxSchemes : SerializableDictionary<MusicArea, JukeboxSchemeConfig>
		{
		}

		[SerializeField]
		private JukeboxSchemes jukeboxSchemes;

		public bool TryGetJukeboxSchemeConfig(MusicArea musicArea, out JukeboxSchemeConfig jukeboxSchemeConfig)
		{
			jukeboxSchemeConfig = null;
			return false;
		}
	}
}

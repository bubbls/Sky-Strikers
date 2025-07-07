using System;
using Chamber8.Framework.Common;
using DP.Takeaway.Runtime;
using DP.Takeaway.Sound;
using UnityEngine;

namespace Moon.Arena
{
	[CreateAssetMenu(menuName = "Moon/Create ArenaFieldEffectsScheme", fileName = "ArenaFieldEffectsScheme", order = 0)]
	public class ArenaFieldEffectsScheme : SingleScriptableObject<ArenaFieldEffectsScheme, DefaultResourcePathProvider<ArenaFieldEffectsScheme>>
	{
		[Serializable]
		public class FieldEffectsScheme
		{
			public SoundInfo BGMSoundInfo;

			public SoundInfo SfxGameStart;

			public SoundInfo SfxGameEnd;

			public SoundInfo SfxCountdownEnd;

			public SoundInfo SfxOvertimeEntered;

			public SoundInfo[] GoalSfxs;

			public SoundInfo[] CountdownSfxs;
		}

		[Serializable]
		private class FieldEffectsSchemes : SerializableDictionary<FieldType, FieldEffectsScheme>
		{
		}

		[SerializeField]
		private FieldEffectsSchemes _fieldEffectsSchemes;

		public FieldEffectsScheme GetSchemeForField(FieldType fieldType)
		{
			return null;
		}
	}
}

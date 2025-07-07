using System;
using UnityEngine;

namespace Moon.GameActivity
{
	[Serializable]
	public class FlagFrameItemDefinition : ActivityStoreItemDefinition
	{
		[SerializeField]
		private FlagThemeLocation _location;

		[SerializeField]
		private FlagFrameTheme _theme;

		public FlagThemeLocation Location => default(FlagThemeLocation);

		public FlagFrameTheme Theme => default(FlagFrameTheme);

		public bool ForLocationAndTheme(FlagThemeLocation location, FlagFrameTheme theme)
		{
			return false;
		}

		public bool ForTheme(FlagFrameTheme theme)
		{
			return false;
		}
	}
}

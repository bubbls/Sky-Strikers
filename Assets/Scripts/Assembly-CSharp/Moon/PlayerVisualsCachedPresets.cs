using System;
using System.Collections.Generic;

namespace Moon
{
	[Serializable]
	public class PlayerVisualsCachedPresets
	{
		public List<PlayerVisualsCachedConfigData> Presets;

		private static List<PlayerVisualsCachedConfigData> GenerateEmptyPresets()
		{
			return null;
		}
	}
}

using UnityEngine.Scripting;

namespace Moon.Player.Code
{
	[Preserve]
	public class LoadingConfig
	{
		public int LoadingGlitchEffectToggle { get; set; }

		public bool IsLoadingGlitchEffectEnabled()
		{
			return false;
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using Chamber8.Framework.Common;

namespace Moon.Arena
{
	public class GameOption : Singleton<GameOption>
	{
		public enum Volume : byte
		{
			Mute = 0,
			LevelOne = 1,
			LevelTwo = 2,
			LevelThree = 3
		}

		public enum SocialPrivacyState : byte
		{
			Everyone = 0,
			MutualFollowing = 1,
			NoOne = 2
		}

		public enum TurningMode
		{
			None = 0,
			SnapTurn = 1,
			SmoothTurn = 2
		}

		public enum SnapTurnAngle
		{
			FortyFive = 0,
			Ninety = 1,
			OneHundredEighty = 2
		}

		public enum SmoothTurnSpeed
		{
			Slow = 0,
			Medium = 1,
			Fast = 2
		}

		[Serializable]
		public class Options
		{
			public TurningMode TurningMode;

			public SnapTurnAngle SnapTurnAngle;

			public SmoothTurnSpeed SmoothTurnSpeed;

			public bool WeaponSwitcheroo;

			public bool SpeedLines;

			public bool PlayerNameOnHead;

			public Volume MusicVolume;

			public Volume VFXVolume;

			public Volume CrowdVolume;

			public SocialPrivacyState SocialPrivacyState;

			public bool PadNotifications;

			public SocialPrivacyState ChangeSocialPrivacyState()
			{
				return default(SocialPrivacyState);
			}
		}

		private Options _options;

		public Options GameOptions => null;

		public event Action<Options> OnOptionsSaved
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected override void Initialize()
		{
		}

		public void Save()
		{
		}

		private static Options CreateDefaultOptions()
		{
			return null;
		}
	}
}

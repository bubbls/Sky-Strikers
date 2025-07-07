using Chamber8.Framework.Messaging;

namespace Moon
{
	public static class JukeboxDataHelper
	{
		public static readonly ISubscriptionModel JukeboxDataUpdated;

		private static GeneralMessage _generalMessage;

		public static void SetJukeboxDataMusicSet(MusicArea musicArea)
		{
		}

		private static void NotifyJukeboxDataUpdated(JukeboxData data)
		{
		}
	}
}

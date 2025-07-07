using Photon.Voice.Unity;

namespace Moon.Arena
{
	public static class VoiceService
	{
		private static VoiceConnection _voiceConnection;

		public static void SetInterestGroup(byte group)
		{
		}

		public static void SubscribeInterestGroup(byte group)
		{
		}

		public static void UnsubscribeInterestGroup(byte group)
		{
		}

		private static VoiceConnection GetVoiceConnection()
		{
			return null;
		}

		public static void SetVoiceConnection()
		{
		}

		public static void ToggleMic(bool isOn, bool saveState = true)
		{
		}

		public static bool IsRecorderEnabled()
		{
			return false;
		}

		private static Recorder Recorder()
		{
			return null;
		}
	}
}

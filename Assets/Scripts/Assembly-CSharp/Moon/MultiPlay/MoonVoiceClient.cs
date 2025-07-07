using Fusion;
using Photon.Realtime;
using Photon.Voice.Fusion;

namespace Moon.MultiPlay
{
	public class MoonVoiceClient : FusionVoiceClient
	{
		private NetworkRunner _runner;

		protected override void Awake()
		{
		}

		public override bool ConnectUsingSettings(AppSettings overwriteSettings = null)
		{
			return false;
		}
	}
}

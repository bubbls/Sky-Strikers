using Fusion;
using Moon.AI.VisualScripting;
using UnityEngine.Scripting;

namespace Moon.GameActivity.Behaviors
{
	public class MSipletsSuckerMsgProducer : MNetworkMessageProducer
	{
		private MsgDataSetTarget _setTarget;

		private MsgDataBite _bite;

		[Preserve]
		public void ServerSetTarget(PlayerRef playerRef)
		{
		}

		[Preserve]
		public void ServerBroadcastBite(PlayerRef playerRef, PlayerParts part)
		{
		}

		[Preserve]
		public void ClientReportBite(PlayerRef playerRef, PlayerParts part)
		{
		}
	}
}

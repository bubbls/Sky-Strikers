using Fusion;
using Moon.AI.VisualScripting;
using UnityEngine.Scripting;

namespace Moon.GameActivity.Behaviors
{
	public class MSipletsSuckerOnMsgReceived : MOnNetworkMessageReceived
	{
		[Preserve]
		public MPlayer TargetPlayer { get; private set; }

		[Preserve]
		public PlayerRef TargetPlayerRef { get; private set; }

		[Preserve]
		public MPlayer BitingPlayer { get; private set; }

		[Preserve]
		public PlayerRef BitingPlayerRef { get; private set; }

		[Preserve]
		public PlayerParts BitingPart { get; private set; }

		protected override void Awake()
		{
		}

		private void OnSetTarget(NetworkObject networkObject, NetworkData data, RpcInfo rpcInfo)
		{
		}

		private void OnBite(NetworkObject networkObject, NetworkData data, RpcInfo rpcInfo)
		{
		}
	}
}

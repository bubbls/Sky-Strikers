using Chamber8.Framework.Messaging;
using Fusion;

namespace Moon.Backpack.Code
{
	public static class BackpackMessageModels
	{
		public class BackpackItemDeSpawnedMessage
		{
			public string FriendlyId;

			public NetworkId NetworkId;
		}

		public class BackpackItemGrabbedMessage
		{
			public MGrabbableBackpackItem GrabbableBackpackItem;
		}

		public class BackpackItemPutBackMessage
		{
			public bool IsByHand;

			public NetworkId NetworkId;

			public BackpackItemNetworkStruct ItemData;

			public ItemSpawnParameters SpawnParameters;

			public PlayerRef PlayerRef;
		}

		public class BackpackItemConsumedMessage
		{
			public MGrabbableBackpackItem GrabbableBackpackItem;
		}

		public static readonly ISubscriptionModel BackpackItemSpawned;

		public static readonly ISubscriptionModel BackpackItemDeSpawned;

		public static readonly ISubscriptionModel BackpackItemGrabbed;

		public static readonly ISubscriptionModel BackpackItemConsumed;

		public static readonly ISubscriptionModel BackpackItemPutBack;
	}
}

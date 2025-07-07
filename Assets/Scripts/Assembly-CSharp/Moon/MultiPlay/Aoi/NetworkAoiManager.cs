using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Chamber8.Framework.Common;
using Chamber8.Framework.Messaging;
using Fusion;
using Moon.Bootstrap;

namespace Moon.MultiPlay.Aoi
{
	public class NetworkAoiManager : Singleton<NetworkAoiManager>
	{
		private IMessageSubscriber[] _subscribers;

		private readonly List<PlayerRef> _playerRefs;

		public IReadOnlyList<PlayerRef> PlayerRefs => null;

		public event Action<PlayerRef> OnPlayerJoined
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

		public event Action<PlayerRef> OnPlayerLeft
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

		public event Action<PlayerRef> OnPlayerInfoRefreshed
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

		public event Action<PlayerRef, PlayerInfo, PlayerInfo> OnPlayerInfoAboutToRefresh
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

		protected override void Dispose()
		{
		}

		private int HandleMPlayerContainerSpawnedMessage(IMessage<MPlayerContainer> message)
		{
			return 0;
		}

		private int HandlePlayerRemoved(IMessage<PlayerRemovedMessage> message)
		{
			return 0;
		}

		private int HandlePlayerInfoBeforeChange(IMessage<PlayerInfoChangedMessage> message)
		{
			return 0;
		}

		private int HandlePlayerInfoChanged(IMessage<PlayerInfoChangedMessage> message)
		{
			return 0;
		}

		private bool CheckIfPlayerInfoChanged(PlayerInfoChangedMessage payload)
		{
			return false;
		}
	}
}

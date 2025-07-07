using System.Collections.Generic;
using Chamber8.Framework.Common;
using Chamber8.Framework.Messaging;
using Fusion;
using Moon.Bootstrap;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.GameActivity
{
	public class EventRoomController : SingleMonoBehaviour<EventRoomController, InSceneSingleMonoBehaviourSettings>
	{
		private const string UserListenedEyeballCollectionSfxKey = "UserListenedEyeballCollectionSfx";

		private const string UserListenedEventRoomDescriptionSfxKey = "UserListenedEventRoomDescriptionSfx";

		private const string CompletedValue = "completed";

		private const string EventOnSipletsAlarm = "OnSipletsAlarm";

		private IMessageSubscriber _subscriber;

		private readonly HashSet<GameObject> _listeners;

		private readonly HashSet<PlayerRef> _lockingPlayers;

		public static bool TrySetUserListenedEyeballCollectionSfx()
		{
			return false;
		}

		[Preserve]
		public static bool TryUserListenedEventRoomDescriptionSfx()
		{
			return false;
		}

		private bool TrySetKey(string key)
		{
			return false;
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private int HandlePlayerRemoved(IMessage<PlayerRemovedMessage> message)
		{
			return 0;
		}

		private void SetPlayerFocusedInternal(PlayerRef playerRef, bool locked)
		{
		}

		private bool IsPlayerFocusedInternal(PlayerRef playerRef)
		{
			return false;
		}

		[Preserve]
		public static void SetPlayerFocused(PlayerRef playerRef, bool locked)
		{
		}

		[Preserve]
		public static bool IsPlayerFocused(PlayerRef playerRef)
		{
			return false;
		}

		[Preserve]
		public static void RegisterEventListener(GameObject listener)
		{
		}

		private void NotifyListeners(string eventName)
		{
		}

		[Preserve]
		public static void TryTriggerAlarmOnPlayer(Collider collider)
		{
		}
	}
}

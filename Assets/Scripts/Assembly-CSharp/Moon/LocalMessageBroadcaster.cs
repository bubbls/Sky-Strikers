using Chamber8.Framework.Messaging;
using Moon.Arena;

namespace Moon
{
	public static class LocalMessageBroadcaster
	{
		private static MatchEventMessage _matchEventMessage;

		private static PlayerActionMessage _playerActionMessage;

		private static PlayerLocomotionMessage _playerLocomotionMessage;

		private static GeneralMessage _generalMessage;

		public static void SendPlayerActionMessage(PlayerActionType playerAction, IMessageData messageData = null)
		{
		}

		public static void SendPlayerLocomotionMessage(PlayerLocomotionActionType locomotionAction, IMessageData messageData = null)
		{
		}

		public static void SendMatchEventMessage(string id, IMessageData messageData = null)
		{
		}

		public static void SendMatchActionEventMessage(string id, IMessageData messageData = null)
		{
		}

		private static void SendMatchEventMessage(string id, IMessageData messageData, ISubscriptionModel messageModel)
		{
		}

		public static void SendPlayerActionBenchmarkMessage(PlayerActionType playerAction, IMessageData messageData = null)
		{
		}

		public static void SendGeneralMessage(string id, IMessageData messageData = null)
		{
		}
	}
}

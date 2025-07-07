using System;
using Chamber8.Framework.Messaging;
using Moon.Arena;
using Moon.MultiPlay;

namespace Moon.Hub
{
	public class HubArenaPlayerClassValidator : IDisposable
	{
		private readonly IMessageSubscriber _arenaLocationEventsSubscription;

		private bool _classValidationEnabled;

		public void Dispose()
		{
		}

		private int HandleLocalPlayerLocationChanged(IMessage<PlayerLocationChangedMessage> message)
		{
			return 0;
		}

		public void EnableClassValidation()
		{
		}

		public void DisableClassValidation()
		{
		}

		private void ValidateLocalPlayerClass()
		{
		}

		private AllowedClasses CastPlayerSuitClassToAllowedClasses(PlayerSuitClass suitClass)
		{
			return default(AllowedClasses);
		}

		private PlayerSuitClass CastAllowedClassToPlayerSuitClass(AllowedClasses allowedClass)
		{
			return default(PlayerSuitClass);
		}
	}
}

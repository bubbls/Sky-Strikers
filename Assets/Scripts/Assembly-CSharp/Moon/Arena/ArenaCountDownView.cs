using Chamber8.Framework.Messaging;
using TMPro;
using UnityEngine;

namespace Moon.Arena
{
	public class ArenaCountDownView : ArenaScreenView, ICountDownView
	{
		[SerializeField]
		protected TMP_Text _viewText;

		private IMessageSubscriber _matchEventsMessageSubscription;

		private int _curRemainingTime;

		private int _cachedRemainingTime;

		private string _baseText;

		private MatchEventMessage _payload;

		public override void Initialize()
		{
		}

		public override void Dispose()
		{
		}

		protected override void EnterViewInternal(object viewData = null)
		{
		}

		private int HandleMatchEvent(IMessage<MatchEventMessage> message)
		{
			return 0;
		}

		protected override void ExitViewInternal()
		{
		}
	}
}

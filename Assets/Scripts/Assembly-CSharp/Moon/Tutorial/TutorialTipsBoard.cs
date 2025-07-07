using System;
using System.Collections.Generic;
using Chamber8.Framework.Messaging;
using Moon.Arena;
using Moon.MultiPlay;
using UnityEngine;

namespace Moon.Tutorial
{
	public class TutorialTipsBoard : MonoBehaviour
	{
		[Serializable]
		private class PlayerSuitTipsBoardConfig
		{
			public PlayerSuitClass SuitClass;

			public List<PlayerSuitTeamIconConfig> TeamIconsConfig;
		}

		[Serializable]
		private class PlayerSuitTeamIconConfig
		{
			public TeamNo TeamNo;

			public Sprite ClassIcon;
		}

		[SerializeField]
		private PlayerSuitClass _suitClass;

		[SerializeField]
		private HandHoldPressButton _handHoldPressButton;

		[Header("UI Config")]
		[SerializeField]
		private List<PlayerSuitTipsBoardConfig> _suitsConfig;

		private IMessageSubscriber[] _subscribers;

		private void OnEnable()
		{
		}

		private int HandleOnPlayerInfoUpdated(IMessage<PlayerInfoChangedMessage> message)
		{
			return 0;
		}

		private void OnDisable()
		{
		}

		private void HandleOnHoldPressComplete()
		{
		}
	}
}

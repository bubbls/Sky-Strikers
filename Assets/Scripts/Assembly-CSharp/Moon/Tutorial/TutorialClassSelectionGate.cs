using System;
using System.Collections.Generic;
using Chamber8.Framework.Messaging;
using DG.Tweening;
using DP.Takeaway.Sound;
using Moon.Arena;
using Moon.MultiPlay;
using UnityEngine;

namespace Moon.Tutorial
{
	public class TutorialClassSelectionGate : MonoBehaviour
	{
		[Serializable]
		private class PlayerSuitTeamIconConfig
		{
			public TeamNo TeamNo;

			public Sprite ClassIcon;
		}

		[SerializeField]
		private PlayerSuitClass _playerSuitClass;

		[SerializeField]
		private HandHoldPressButton _handHoldPressButton;

		[SerializeField]
		private Transform _leftGate;

		[SerializeField]
		private Transform _rightGate;

		[SerializeField]
		private float _leftGateEndValue;

		[SerializeField]
		private float _rightGateEndValue;

		[SerializeField]
		private float _gateAnimationDuration;

		[SerializeField]
		private GameObject _classSelectVFX;

		[SerializeField]
		private GameObject _ui;

		[SerializeField]
		private SoundInfo _soundInfo;

		[SerializeField]
		private List<PlayerSuitTeamIconConfig> _teamIconsConfig;

		private IMessageSubscriber[] _subscribers;

		private Sequence _sequence;

		public void Reset()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void KillSequence()
		{
		}

		private void HandleOnHoldPressComplete()
		{
		}

		private int HandleOnPlayerInfoUpdated(IMessage<PlayerInfoChangedMessage> message)
		{
			return 0;
		}
	}
}

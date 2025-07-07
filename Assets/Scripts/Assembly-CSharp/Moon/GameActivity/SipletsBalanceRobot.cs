using Chamber8.Framework.Messaging;
using DG.Tweening;
using DP.Takeaway.Sound;
using Fusion;
using Moon.Bootstrap;
using Moon.MultiPlay;
using TMPro;
using UnityEngine;

namespace Moon.GameActivity
{
	public class SipletsBalanceRobot : MonoBehaviour
	{
		private struct PendingSiplets
		{
			public int Balance;

			public int PendingAmount;

			public int GetAmount()
			{
				return 0;
			}
		}

		private const int EyeballRemindingNumber = 30;

		[SerializeField]
		private Transform _smallPivot;

		[SerializeField]
		private Transform _bigPivot;

		[SerializeField]
		private TMP_Text _balanceText;

		[SerializeField]
		private TMP_Text _balanceText2;

		[SerializeField]
		private SoundInfo _sfxCounterAppears;

		[SerializeField]
		private SoundPlayerStub _sfxEyeballCollection;

		[SerializeField]
		private Transform _eyeballPivot;

		private int _currentBalance;

		private PendingSiplets? _pendingSiplets;

		private int _lastEyeballCount;

		private SipletsSettings _sipletsSettings;

		private Sequence _sequence;

		private Tween _bigEyeballGroupTween;

		private Tween _smallEyeballGroupTween;

		private IMessageSubscriber[] _subscribers;

		private PlayerRef _playerRef;

		public void Initialize(PlayerRef playerRef)
		{
		}

		private void OnDestroy()
		{
		}

		private void UpdateVisual(bool immediate)
		{
		}

		private void UpdateEyeballGroup(bool immediate)
		{
		}

		private int GetSipletsBalance()
		{
			return 0;
		}

		private int GetEyeballCount()
		{
			return 0;
		}

		private void UpdateEyeballs(bool immediate)
		{
		}

		private void UpdateCounterText(bool immediate)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private int HandleRemoteConfigUpdated(IMessage<object> _)
		{
			return 0;
		}

		private int HandlePlayerInfoChanged(IMessage<PlayerInfoChangedMessage> message)
		{
			return 0;
		}

		public void Show()
		{
		}

		public void TemporaryAddAmount(int amount)
		{
		}

		public void TemporaryCleanAmount()
		{
		}

		private void UpdateBalanceText(int number)
		{
		}
	}
}

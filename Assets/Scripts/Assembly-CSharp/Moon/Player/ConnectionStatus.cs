using System;
using System.Collections.Generic;
using Chamber8.Framework.Messaging;
using DP.Takeaway.Sound;
using DP.Takeaway.Utils;
using Fusion;
using Moon.Bootstrap;
using Moon.MultiPlay;
using TMPro;
using UnityEngine;

namespace Moon.Player
{
	public class ConnectionStatus : MonoBehaviour
	{
		private enum Status
		{
			None = 0,
			Matching = 1,
			Connecting = 2,
			Connected = 3,
			GameMasterChanged = 4,
			YouAreGameMaster = 5
		}

		[Serializable]
		private class SoundSetting
		{
			public Status status;

			public string info;

			public SoundInfo sound;

			public float lifeTime;
		}

		[SerializeField]
		private GameObject _visualRoot;

		[SerializeField]
		private Transform _lookAtTarget;

		[SerializeField]
		private TMP_Text _textConnStatus;

		[SerializeField]
		private List<SoundSetting> _connSounds;

		private Cooldown _cooldown;

		private int _soundId;

		private bool _mainStatusShowing;

		private ConnectionManager.Status _connStatus;

		private MatchmakingStatus _matchStatus;

		private bool? _isBanned;

		private IMessageSubscriber _subscriber;

		private PlayerRef _waitToNotify;

		private PlayerRef _notified;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void UpdatePhotonConnStatus()
		{
		}

		private void UpdateMatchmakingStatus()
		{
		}

		private void UpdateGameMasterStatus()
		{
		}

		private int HandleOnPlayerInfoUpdated(IMessage<PlayerInfoChangedMessage> message)
		{
			return 0;
		}

		private SoundSetting GetSoundSettingByStatus(Status status)
		{
			return null;
		}

		private Status GetPhotonConnStatus(ConnectionManager.Status status)
		{
			return default(Status);
		}

		private Status GetClientStatus(MatchmakingStatus status)
		{
			return default(Status);
		}

		private void Update()
		{
		}

		private string TruncateString(string input, int maxLength)
		{
			return null;
		}
	}
}

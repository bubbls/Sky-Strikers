using Chamber8.Framework.Messaging;
using DP.Takeaway.Utils;
using Fusion;
using Moon.Arena;
using Moon.MultiPlay;
using TMPro;
using UnityEngine;

namespace Moon.Player.Pad
{
	public class PlayerPadNetworkApp : PlayerPadApp
	{
		[SerializeField]
		private TMP_Text _rttText;

		[SerializeField]
		private GameObject _codeGroup;

		[SerializeField]
		private TMP_Text _codeTitle;

		[SerializeField]
		private TMP_Text _fetchingText;

		[SerializeField]
		private TMP_Text[] _codeTexts;

		[SerializeField]
		private TMP_Text _regionText;

		[SerializeField]
		private bool _showPlayerRef;

		[SerializeField]
		private TMP_Text _playerRefText;

		private readonly Cooldown _updateCd;

		private bool _isConnectedAsClient;

		private IMessageSubscriber _messageSubscriber;

		private bool _isFetchingCode;

		private WaitingMessage _waitingMessage;

		public override PlayerPadAppID AppID => default(PlayerPadAppID);

		protected override void InitializeInternal()
		{
		}

		private void OnDestroy()
		{
		}

		private void LateUpdate()
		{
		}

		protected override void HandleAppAboutToOpenInternal(IPlayerPadAppOpenData appOpenData)
		{
		}

		protected override void HandleAppAboutToCloseInternal()
		{
		}

		private void ConnectionManager_OnConnectionStatusChanged(ConnectionManager.Status status, ShutdownReason shutdownReason)
		{
		}

		private int HandleHubCodeChanged(IMessage<object> arg)
		{
			return 0;
		}

		private void SetHubCode(NetworkRunner runner)
		{
		}

		private void CheckForConnection()
		{
		}

		private void UpdateRtt(int rtt)
		{
		}

		private void ClearRtt()
		{
		}

		private void SetCodeText(string code)
		{
		}

		private void ClearCodeText(bool showLine)
		{
		}

		private void ToggleFetchingCode(bool show)
		{
		}
	}
}

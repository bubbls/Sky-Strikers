using System;
using System.Collections.Generic;
using Chamber8.Framework.Messaging;
using DP.Takeaway.VisualScripting;
using Moon.Bootstrap;
using TMPro;
using UnityEngine;

namespace Moon.Arena
{
	[Obsolete("Consoles are in Elevator scene, now")]
	public class NewSessionConsole : MonoBehaviour
	{
		private const string StrConnectToOtherPublic = "CHANGE PUBLIC ROOM";

		private const string StrConnectToPublic = "CONNECT TO PUBLIC ROOM";

		public const string StrWaitingForPublic = "Looking for other players";

		private const string StrConnectedToPublic = "You are now connected to a public room.";

		private const string StrConnectionToPublicFailed = "Connection to public room failed.";

		private const string StrPressToConnectToPublic = "You can press \"CONNECT TO PUBLIC ROOM\" button to connect.";

		private const string StrPrivateRoomTitle = "PRIVATE ROOM";

		private const string StrPrivateRoomTitleWithNumber = "PRIVATE ROOM\n{0}";

		private const string StrEnterPrivateRoomName = "Enter 4-digital number and press JOIN to join a private room.";

		public const string StrWaitingForPrivate = "Waiting for other players";

		private const string StrConnectedToPrivate = "Enjoy!";

		[SerializeField]
		[Header("Region Selection")]
		private TMP_Text _textRegion;

		[SerializeField]
		private TMP_Text _textRtt;

		[SerializeField]
		[Header("PUBLIC ROOM")]
		private TMP_Text _textPublicRoomStatus;

		[SerializeField]
		private TMP_Text _textBtnConnectToPublic;

		[SerializeField]
		private GameObject _btnConnectToPublic;

		[Header("PRIVATE ROOM")]
		[SerializeField]
		private TMP_Text _textPrivateRoomTitle;

		[SerializeField]
		private InputBox _textSessionName;

		[SerializeField]
		private TMP_Text _textPrivateRoomStatus;

		[SerializeField]
		private GameObject _btnConnectToPrivate;

		private CustomEventHandler _customEventHandler;

		private readonly HashSet<IMessageSubscriber> _subscribers;

		private WaitingMessage _publicRoomStatusMessage;

		private WaitingMessage _privateRoomStatusMessage;

		private float _updateInterval;

		private float _updateTimer;

		private static readonly string _sessionNumberFormat;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private int HandleMatchmakingStatusUpdate(IMessage<object> _)
		{
			return 0;
		}

		private int HandleLatencyUpdated(IMessage<object> _)
		{
			return 0;
		}

		private void UpdateRegionSelections()
		{
		}

		private static Color GetRegionColor(Latency latency)
		{
			return default(Color);
		}

		private static Color GetLatencyColor(int latency)
		{
			return default(Color);
		}

		private static string GetRegionText(Latency selectedLatency)
		{
			return null;
		}

		private void UpdateMatchmakingStatus()
		{
		}

		private bool ShouldShowConnectToPrivate()
		{
			return false;
		}

		private void HandleBtnPressed(string btnName)
		{
		}

		private void ChangeRegion(bool next)
		{
		}

		private bool IsUserPreferredLatenciesChanged()
		{
			return false;
		}

		private void UpdateJoinButtonsAfterRegionChanged()
		{
		}

		private void ConnectToPublic()
		{
		}

		private void ConnectToPrivate()
		{
		}

		private void InputRandomSessionName()
		{
		}

		private void InputOneChar(string character)
		{
		}

		private void UpdateConnectToPrivateButton()
		{
		}

		private void DeleteOneChar()
		{
		}

		private void Update()
		{
		}
	}
}

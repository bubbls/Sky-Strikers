using System.Net;
using Chamber8.Framework.Messaging;
using DG.Tweening;
using DP.Takeaway.Sound;
using Moon.Hub;
using Moon.MultiPlay;
using UnityEngine;

namespace Moon.Mission
{
	public class MissionBoardController : MonoBehaviour
	{
		[SerializeField]
		private GameObject _noticeVisual;

		[SerializeField]
		private GameObject _inAreaObjects;

		[SerializeField]
		private CheckPlayersInVolume _checkPlayersInVolume;

		[SerializeField]
		private LocalPlayerCheckVolume _localPlayersInVolume;

		[SerializeField]
		private PushLockButton _btnClaim;

		[SerializeField]
		private MissionBoard _missionBoard;

		[SerializeField]
		private GameObject _missionBoardInUse;

		[SerializeField]
		private SoundInfo _sfxTurnOnMonitor;

		[SerializeField]
		private Animator _effectAnimator;

		private static readonly int _turnOff;

		private static readonly int _turnOn;

		private static readonly int _switch;

		[SerializeField]
		private TaskCompletion _taskCompletion;

		[SerializeField]
		private SoundInfo? _sfxError;

		[SerializeField]
		private CurrencyTransactionTubeRendererController _tubeController;

		private Sequence? _sequence;

		private bool _isBroken;

		private IMessageSubscriber? _sub;

		private readonly string _missionBoardKey;

		private void Start()
		{
		}

		private void HandleOnMissionClaimed()
		{
		}

		private void HandleOnMissionHasClaimable(bool hasClaimable)
		{
		}

		private void OnDestroy()
		{
		}

		public void UpdateMissions()
		{
		}

		private static void HandleRequestMission(MissionTable missionTable)
		{
		}

		private void HandleOnMissionRefreshed(MissionTable missionTable)
		{
		}

		private void HandleOnMissionRefreshFailed(HttpStatusCode errorCode, string message)
		{
		}

		private void SetBroken(HttpStatusCode errorCode, string message)
		{
		}

		private void UpdateMissionAccomplishmentPrompt()
		{
		}

		private void HandleLocalPlayerInVolumeChanged(bool hasPlayer)
		{
		}

		private void TurnOff()
		{
		}

		private void TurnOnForMe()
		{
		}

		private void TurnOnForOthers()
		{
		}

		private void HandleClaimReward()
		{
		}

		private int HandleContractAccepted(IMessage<object> _)
		{
			return 0;
		}
	}
}

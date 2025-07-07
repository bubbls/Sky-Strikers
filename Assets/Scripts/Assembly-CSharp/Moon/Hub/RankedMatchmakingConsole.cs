using System.Collections.Generic;
using Chamber8.Framework.Messaging;
using DG.Tweening;
using DP.Takeaway.Sound;
using JetBrains.Annotations;
using Moon.Arena;
using NaughtyAttributes;
using TMPro;
using UnityEngine;

namespace Moon.Hub
{
	public class RankedMatchmakingConsole : MonoBehaviour
	{
		private enum TimerMode
		{
			None = 0,
			CountUp = 1,
			CountDown = 2
		}

		private const float TimeSize = 0.14f;

		private const string AllowedToSearchText = "JOIN RANKED MATCH";

		private const string PreparingText = "PREPARING";

		private const string SearchingForMatchText = "SEARCHING FOR MATCH\n<size=0.14>(PRESS TO CANCEL)</size>\n";

		private const string CancellingSearchText = "CANCELLING";

		private const string SearchCooldownText = "SEARCH COOLDOWN\n";

		private const string PrepareErrorText = "SEARCH ERROR,\nTRY AGAIN LATER";

		private const string AlreadyInMatchText = "LAST MATCH IN PROGRESS, REJOIN NOW\n";

		private const string BannedText = "BANNED FROM RANKED MATCHES FOR\n";

		private const string MatchFoundText = "MATCH FOUND!";

		private const string RejoiningMatchText = "REJOINING MATCH";

		private static readonly int _lightRange;

		[SerializeField]
		private ManualToggle _searchButton;

		[SerializeField]
		private TMP_Text _launchButtonText;

		[SerializeField]
		private TMP_Text _playerCountText;

		[SerializeField]
		private RankedRegionSelectionBoard _regionSelectionBoard;

		[SerializeField]
		[Header("Beam")]
		[Space(7f)]
		private Material _outerBeamMaterial;

		[SerializeField]
		private Material _innerBeamMaterial;

		[SerializeField]
		private float _outerBeamAnimateDuration;

		[SerializeField]
		private SoundInfo _outerBeamSoundInfo;

		[SerializeField]
		private float _innerBeamAnimateDuration;

		[SerializeField]
		private float _animateOutDuration;

		[SerializeField]
		private SoundInfo _innerBeamSoundInfo;

		[SerializeField]
		private SoundInfo _idleSoundInfo;

		[SerializeField]
		private SoundInfo _matchFoundSoundInfo;

		[SerializeField]
		private Transform _soundPos;

		private Sequence _beamSequence;

		private List<int> _soundIds;

		private IMessageSubscriber _messageSubscriber;

		private float _timerTargetTime;

		private string _timerText;

		private TimerMode _curTimerMode;

		private WaitingMessage _waitingMessage;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void LateUpdate()
		{
		}

		private bool CheckConnection()
		{
			return false;
		}

		private void HandleOnSearchButtonValueChanged()
		{
		}

		private int HandleMatchmakingStateChanged(object _)
		{
			return 0;
		}

		private void SetWaitingMessage(string message)
		{
		}

		private void DisableSearchButton()
		{
		}

		private void EnableSearchButton()
		{
		}

		private void UpdateLaunchText(string text)
		{
		}

		private void ConfigureTimer(float targetTime, string text, TimerMode timerMode)
		{
		}

		private void DisableTimer()
		{
		}

		private void AnimateInBeam()
		{
		}

		private void AnimateOutBeam()
		{
		}

		private void ResetBeamMaterials()
		{
		}

		private void StopSounds()
		{
		}

		[Button("Simulate Match Found", EButtonEnableMode.Always)]
		[UsedImplicitly]
		private void SimulateMatchFound()
		{
		}

		[Button("Simulate Button Pressed", EButtonEnableMode.Always)]
		[UsedImplicitly]
		private void SimulateSearchButtonPress()
		{
		}
	}
}

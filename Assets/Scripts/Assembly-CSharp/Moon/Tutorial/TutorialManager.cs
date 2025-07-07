using System.Collections.Generic;
using Chamber8.Framework.Common;
using DP.Takeaway.Game;
using Moon.MultiPlay;
using UnityEngine;

namespace Moon.Tutorial
{
	public class TutorialManager : SingleMonoBehaviour<TutorialManager, InSceneSingleMonoBehaviourSettings>
	{
		[SerializeField]
		private Transform _playerTutorialSpawnPoint;

		[SerializeField]
		private Transform _playerGymMaintenanceSpawnPoint;

		[SerializeField]
		private MJukebox _mJukebox;

		[SerializeField]
		private TutorialClassPath _primePath;

		[SerializeField]
		private TutorialClassPath _jetstreamPath;

		[SerializeField]
		private TutorialPassGate _firstPassGate;

		[SerializeField]
		private TutorialPassGate _backPassGate;

		[SerializeField]
		[Header("Audios")]
		private List<Trigger> _audioTriggers;

		[SerializeField]
		private List<Trigger> _challengeAudioTriggers;

		private static readonly HashSet<string> _audioTriggered;

		private float _completeTutorialTimer;

		private void Awake()
		{
		}

		private void StagingLoadingController_OnLoadingComplete()
		{
		}

		private void InitializeTutorial()
		{
		}

		private void HandleOnAudioTriggerEnter(Trigger audioTrigger)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void HandleOnPrimePathCompleted()
		{
		}

		private void HandleOnJetstreamPathCompleted()
		{
		}

		private int GetCompleteTutorialDuration()
		{
			return 0;
		}

		private void CompleteTutorial()
		{
		}

		private void ToggleBackPassGate(bool enable)
		{
		}
	}
}

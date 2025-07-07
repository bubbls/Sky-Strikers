using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Chamber8.Framework.Common;
using Chamber8.Framework.Messaging;
using DP.Takeaway.Game;
using UnityEngine;

namespace Moon.Tutorial
{
	public class Tutorial : SingleMonoBehaviour<Tutorial, InSceneSingleMonoBehaviourSettings>
	{
		[SerializeField]
		private List<Trigger> _triggers;

		[SerializeField]
		private Trigger _tutorialArenaTrigger;

		[SerializeField]
		private ToggleAccordingToSuitClass _suitClassToggle;

		private static readonly HashSet<string> _triggered;

		[SerializeField]
		private Transform _spawnPoint;

		private IMessageSubscriber[]? _subscribers;

		public Transform SpawnPoint => null;

		public static event Action? OnCompleted
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void Awake()
		{
		}

		private void StagingLoadingController_OnLoadingComplete()
		{
		}

		private void InitializeTutorial()
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private int HandlePlayerSpawned(IMessage<MPlayer> message)
		{
			return 0;
		}

		private void UpdateSuitClassToggles()
		{
		}

		private void HandleEnterTrigger(Trigger trigger)
		{
		}

		private static void MarkTutorialDone()
		{
		}
	}
}

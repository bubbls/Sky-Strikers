using System;
using System.Collections.Generic;
using Chamber8.Framework.Common;
using DP.Takeaway.Inspector;
using DP.Takeaway.Runtime;
using Fusion;
using Moon.Arena;
using Moon.Player.Ability;
using UnityEngine;

namespace Moon.MultiPlay
{
	[CreateAssetMenu(fileName = "NetworkResources", menuName = "Chamber8/Create NetworkResources")]
	public class NetworkResources : SingleScriptableObject<NetworkResources, DefaultResourcePathProvider<NetworkResources>>
	{
		[Serializable]
		public struct SceneSettings
		{
			[ScenePath]
			public string Path;

			[PossibleStringValues(new string[] { "arena_session", "arena_session_ranked", "hub_session" })]
			public string QueueName;

			[PossibleStringValues(new string[] { "arena_session_private", "arena_session_ranked_private", "hub_session_private" })]
			public string PrivateQueueName;

			public string DisplayName;

			[ScenePath]
			public string AdditiveSceneSlotZeroPath;

			[ScenePath]
			public string AdditiveSceneSlotOnePath;

			[ScenePath]
			public string AdditiveSceneSlotTwoPath;
		}

		[Serializable]
		private class SceneSettingsLookup : DP.Takeaway.Runtime.SerializableDictionary<FieldType, SceneSettings>
		{
		}

		[Serializable]
		private class SuitClassAbilityLookup : DP.Takeaway.Runtime.SerializableDictionary<PlayerSuitClass, MPlayerAbility>
		{
		}

		[SerializeField]
		public NetworkRunner NetworkRunner;

		[SerializeField]
		public MSession MSession;

		[SerializeField]
		public MPlayer MPlayer;

		[SerializeField]
		public MPlayerContainer MPlayerContainer;

		[SerializeField]
		public PlayerVisualsController PlayerVisualsController;

		[ScenePath]
		[SerializeField]
		public string ElevatorScenePath;

		[ScenePath]
		[SerializeField]
		public string ClassChangeRoomScenePath;

		[SerializeField]
		[ScenePath]
		public string TutorialScenePath;

		[SerializeField]
		public List<FieldType> BackfillingFieldTypes;

		[SerializeField]
		public List<FieldType> ServerRegistrationFieldTypes;

		[SerializeField]
		private SceneSettingsLookup _sceneSettingsLookup;

		[SerializeField]
		private SuitClassAbilityLookup _suitClassAbilityLookup;

		public SceneSettings GetSceneSettings(FieldType fieldType)
		{
			return default(SceneSettings);
		}

		public MPlayerAbility GetAbility(PlayerSuitClass suitClass)
		{
			return null;
		}
	}
}

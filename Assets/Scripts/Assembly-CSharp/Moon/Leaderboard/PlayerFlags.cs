using System;
using System.Collections.Generic;
using Chamber8.Framework.Messaging;
using DP.Takeaway.VisualScripting;
using Moon.GameActivity;
using UnityEngine;

namespace Moon.Leaderboard
{
	public class PlayerFlags : MonoBehaviour
	{
		[Serializable]
		private class PlayerFlagSettings
		{
			public FlagFrameItemDefinition definition;

			public GameObject toggle;
		}

		[SerializeField]
		private List<PlayerFlagSettings> _items;

		[SerializeField]
		private GameObject _panelModel;

		private IMessageSubscriber[] _subscribers;

		private CustomEventHandler _customEventHandler;

		private bool _isLocalPlayer;

		public void SetLocalPlayer(bool isLocalPlayer)
		{
		}

		public void HandleOnPlayerInfoChanged()
		{
		}

		private void Awake()
		{
		}

		public void Initialize()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private int HandlePlayerInventoryUpdated(IMessage<object> _)
		{
			return 0;
		}

		private bool IsPurchasedByDefinition(FlagFrameItemDefinition definition)
		{
			return false;
		}

		private void UpdateFlagFrame()
		{
		}

		private void HandleToggleChanged(GameObject toggle)
		{
		}

		private void UpdateFlagFrameConfiguration(FlagThemeLocation location, FlagFrameTheme theme)
		{
		}

		private bool UpdateFlagFrameConfiguration(ref FlagFrameConfiguration configuration, FlagThemeLocation location, FlagFrameTheme theme)
		{
			return false;
		}

		private void SyncLocalData(FlagFrameConfiguration configuration)
		{
		}

		private FlagFrameItemDefinition FindDefinitionByToggle(GameObject toggle)
		{
			return null;
		}
	}
}

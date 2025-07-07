using System;
using System.Collections.Generic;
using DP.Takeaway.Utils;
using Moon.MultiPlay;
using UnityEngine;

namespace Moon.Player.Visual
{
	[Serializable]
	public class PlayerInfoVisualsHandler : MonoBehaviour, ICommandExecutor
	{
		private List<PlayerNameVisual> _playerNameVisuals;

		private List<PlayerNumberVisual> _playerNumberVisuals;

		private List<PlayerRoleVisual> _playerRoleVisuals;

		private List<PlayerAmmoIndicator> _ammoIndicators;

		public void CheckForVisuals()
		{
		}

		public void Clear()
		{
		}

		private void SetPlayerName(string playerName)
		{
		}

		private void SetPlayerNumber(int number)
		{
		}

		private void SetGameRole(bool isGameMaster)
		{
		}

		public void SetAmmo(int amount)
		{
		}

		public void UpdateVisualsWithPlayerInfo(PlayerInfo playerInfo)
		{
		}

		public ICommand ExecuteCommand(ICommand command)
		{
			return null;
		}

		private void RegisterPlayerInfoVisuals(PlayerInfoVisual[] playerInfoVisuals)
		{
		}
	}
}

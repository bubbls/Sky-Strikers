using System;
using System.Runtime.CompilerServices;
using Moon.ReportingSystem;
using UnityEngine;

namespace Moon
{
	public class ArenaPlayerListPanelRanked : PlayerListConsole
	{
		[SerializeField]
		private GameObject _container;

		[SerializeField]
		private LocalPlayerCheckVolume _localPlayerCheckVolume;

		public event Action OnPlayerLeft
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

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		private void HandleLocalPlayerEnterVolume(bool hasPlayer)
		{
		}

		public void TogglePanel(bool enable)
		{
		}
	}
}

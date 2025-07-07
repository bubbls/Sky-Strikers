using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DP.Takeaway.Utils;
using Fusion;
using Moon.AI.VisualScripting;
using UnityEngine;

namespace Moon.MultiPlay
{
	public class CheckPlayersInVolume : MonoBehaviour
	{
		private enum ExecutionPeer
		{
			Player = 0,
			Server = 1
		}

		[SerializeField]
		private OverlapShapeDesc _osd;

		[SerializeField]
		private float _checkingInterval;

		[SerializeField]
		private ExecutionPeer _executionPeer;

		private Cooldown _cd;

		private readonly HashSet<PlayerRef> _playersInVolume;

		private readonly HashSet<PlayerRef> _playersMovedOut;

		private readonly HashSet<PlayerRef> _playersMovedIn;

		public IReadOnlyCollection<PlayerRef> PlayersInVolume => null;

		public IReadOnlyCollection<PlayerRef> PlayersMovedOut => null;

		public IReadOnlyCollection<PlayerRef> PlayersMovedIn => null;

		public event Action OnChanged
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

		private void LateUpdate()
		{
		}

		private void DoCheck()
		{
		}

		private void DoCheckInternal(NetworkRunner runner)
		{
		}
	}
}

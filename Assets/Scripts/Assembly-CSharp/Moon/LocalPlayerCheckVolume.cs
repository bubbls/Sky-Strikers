using System;
using System.Runtime.CompilerServices;
using DP.Takeaway.Utils;
using Moon.AI.VisualScripting;
using UnityEngine;

namespace Moon
{
	public class LocalPlayerCheckVolume : MonoBehaviour
	{
		private const float MinCheckIntervalOffset = 0.01f;

		private const float MaxCheckIntervalOffset = 0.1f;

		[SerializeField]
		private OverlapShapeDesc _overlapShapeDesc;

		[SerializeField]
		private float _checkingInterval;

		[SerializeField]
		private bool _autoCheckEnabled;

		[SerializeField]
		private bool _addCheckIntervalRandomOffset;

		private Cooldown _cd;

		private bool _isInArea;

		public bool HasPlayer { get; private set; }

		public event Action<bool> OnChanged
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

		private void Start()
		{
		}

		private void LateUpdate()
		{
		}

		public bool CheckHasPlayer()
		{
			return false;
		}

		public void ToggleAutoChecking(bool enable)
		{
		}
	}
}

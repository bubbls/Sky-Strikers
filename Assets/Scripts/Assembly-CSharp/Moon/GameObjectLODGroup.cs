using System;
using System.Collections.Generic;
using DP.Takeaway.Utils;
using JetBrains.Annotations;
using NaughtyAttributes;
using UnityEngine;

namespace Moon
{
	[ExecuteInEditMode]
	public class GameObjectLODGroup : MonoBehaviour
	{
		[Serializable]
		public struct Group
		{
			public float FillPercent;

			public List<GameObjectLODListener> _lodListeners;

			private bool _isActive;

			private bool _hasInitialState;

			[SerializeField]
			[Header("Read Only")]
			[UsedImplicitly]
			[ReadOnly]
			public float ActivateDistance;

			public void ToggleGroup(bool state)
			{
			}
		}

		[SerializeField]
		private Transform _positionReference;

		[SerializeField]
		private Group[] _lodGroups;

		[SerializeField]
		private float _lodBias;

		[SerializeField]
		private float _objHeight;

		[SerializeField]
		public float _minCamDistanceForLOD;

		[SerializeField]
		private float _cooldownInterval;

		[ReadOnly]
		[SerializeField]
		private Camera _targetCamera;

		[ReadOnly]
		[SerializeField]
		[UsedImplicitly]
		private float _curCameraDistance;

		[SerializeField]
		[UsedImplicitly]
		[ReadOnly]
		private float _curRatio;

		[SerializeField]
		[UsedImplicitly]
		[ReadOnly]
		private int _activeGroupIndex;

		private Vector3 _worldPos;

		private Vector3 _screenPos;

		private Vector3 _topScreenPos;

		private Vector3 _bottomScreenPos;

		private float _biasedThreshold;

		private int _targetLodGroup;

		private Cooldown _cooldown;

		[Header("Editor Only")]
		[SerializeField]
		private bool _executeInEditMode;

		public Group[] LODGroups => null;

		private void Start()
		{
		}

		private void LateUpdate()
		{
		}

		private void UpdateLOD()
		{
		}

		private void OnDrawGizmosSelected()
		{
		}

		private float CalculateScreenHeightRatio()
		{
			return 0f;
		}

		private float CalculateViewportRatio()
		{
			return 0f;
		}

		private float MinDistanceToActivateLOD(float threshold)
		{
			return 0f;
		}

		[UsedImplicitly]
		[Button("Reset LOD", EButtonEnableMode.Always)]
		private void ResetLOD()
		{
		}

		public void RegisterLODListener(ICollection<GameObjectLODListener> listeners, int levelIndex)
		{
		}

		public void UnregisterLODListeners(ICollection<GameObjectLODListener> listeners, int levelIndex)
		{
		}
	}
}

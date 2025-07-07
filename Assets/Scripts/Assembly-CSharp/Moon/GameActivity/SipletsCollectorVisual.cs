using System;
using System.Collections.Generic;
using Chamber8.Framework.Messaging;
using DP.Takeaway.Utils;
using Fusion;
using UnityEngine;

namespace Moon.GameActivity
{
	public class SipletsCollectorVisual : MonoBehaviour
	{
		private class TrailFxInstance
		{
			private List<Vector3> _trailPositions;

			private float _normalizedTime;

			private readonly CatmullRom _catmullRom;

			private readonly Transform _fxTransform;

			private GameObject _fx;

			private Action _onComplete;

			private bool _completed;

			private readonly float _startTime;

			private readonly float _pathDistortionAmp;

			private readonly float _pathDistortionFreq;

			private float _delayTime;

			public string Id { get; }

			public int Amount { get; }

			public TrailFxInstance(string idempotencyId, ref SipletsTrail trail)
			{
			}

			public void DisposeAndSpawnAbsorbingFx(GameObject fxAbsorbingPrefab, Transform parent)
			{
			}

			public bool LateUpdate(float deltaTime, IReadOnlyCollection<Vector3> movingPositions)
			{
				return false;
			}

			public void Complete(Action onComplete)
			{
			}
		}

		private const float MaxTrailTime = 10f;

		[SerializeField]
		private Transform[] _myTrailPositions;

		[SerializeField]
		private SipletsBalanceRobot _sipletsBalanceRobot;

		private readonly List<TrailFxInstance> _fxInstances;

		private readonly HashSet<TrailFxInstance> _fxToRemove;

		private IMessageSubscriber _subscriber;

		private SipletsSurroundingFx _fxSipletsSurrounding;

		public void Initialize(PlayerRef playerRef)
		{
		}

		public void Disable()
		{
		}

		public void NotifyWillCollect(string idempotencyId, ref SipletsTrail trail)
		{
		}

		public void NotifyCollected(string idempotencyId, bool success)
		{
		}

		private void PlayFx(string idempotencyId, ref SipletsTrail trail)
		{
		}

		private void LateUpdate()
		{
		}
	}
}

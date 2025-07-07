using System;
using System.Collections.Generic;
using Chamber8.Framework.Common;
using Fusion;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Moon
{
	public class HitVisualizer : SingleMonoBehaviour<HitVisualizer, DefaultSingleMonoBehaviourSettings<HitVisualizer>>
	{
		private struct Theme
		{
			public Color SourceColor;

			public Color TargetColor;

			public Color BodyVelocityColor;

			public Color ThrowVelocityColor;

			public Color FinalVelocityColor;
		}

		private struct HitboxInfo
		{
			public HitboxTypes Type;

			public Vector3 Position;

			public Vector3 BoxExtends;

			public Quaternion Rotation;

			public float SphereRadius;
		}

		private struct HitVisInfo
		{
			public PlayerRef PlayerRef;

			public HitboxInfo Source;

			public HitboxInfo Target;

			public Vector3 HitPosition;

			public Vector3 BodyVelocity;

			public Vector3 ThrowVelocity;

			public Vector3 ModifiedThrowVelocity;

			public Vector3 FinalVelocity;

			public int HitTick;

			public int HitterLastUpdatedTick;

			public int HitInfoReceivedTick;
		}

		[Serializable]
		public struct TrackingPositions
		{
			public Vector3 TrackingSpacePosition;

			public Vector3 Position;

			public Vector3 Velocity;

			public Vector3 HeadTrackerPosition;

			public Vector3 HandTrackerPosition;
		}

		[Serializable]
		private struct ThrowVelocityInfo
		{
			public Vector3 ThrowVelocity;

			public int UpdatedTick;

			public int SampleCount;

			public List<TrackingPositions> TrackingPositionsList;
		}

		[Serializable]
		private struct LastHit
		{
			public Vector3 HitPosition;

			public ThrowVelocityInfo ServerThrowVelocityInfo;

			public List<ThrowVelocityInfo> ClientThrowVelocityInfos;
		}

		[Serializable]
		private struct LastHitList
		{
			public List<LastHit> Hits;
		}

		public const int MaxVisualizationsCount = 16;

		private static readonly int _colorId;

		[NonSerialized]
		public int VisibleVisualization;

		[NonSerialized]
		public bool DrawEachOne;

		[NonSerialized]
		public bool DrawTrackingPositions;

		[NonSerialized]
		public int TrackingPositionsCount;

		[NonSerialized]
		public bool DrawTrackingPositionOneByOne;

		[SerializeField]
		private Material _pointMaterial;

		[SerializeField]
		private Material _hitboxMaterial;

		[SerializeField]
		private Material _lineMaterial;

		[SerializeField]
		private InputActionReference _actionSave;

		private readonly LinkedList<HitVisInfo>[] _hitVisualizations;

		private readonly List<LineRenderer> _lineRenderers;

		private int _lineDrawingIndex;

		private readonly List<TMP_Text> _textRenderers;

		private int _textDrawingIndex;

		private Vector3 _rightTrackedBatVelocity;

		private readonly LinkedList<ThrowVelocityInfo> _rightTrackedBatVelocityList;

		private Vector3 _rightTrackedBatVelocityServer;

		private float _maxHandVelocity;

		private float _maxBatVelocity;

		private Mesh _meshCube;

		private Mesh _meshSphere;

		private readonly LinkedList<LastHit> _lastHits;

		private Theme VisTheme { get; }
	}
}

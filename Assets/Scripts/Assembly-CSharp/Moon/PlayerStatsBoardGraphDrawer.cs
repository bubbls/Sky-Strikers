using System.Collections.Generic;
using NaughtyAttributes;
using UnityEngine;

namespace Moon
{
	public class PlayerStatsBoardGraphDrawer : MonoBehaviour
	{
		[SerializeField]
		private List<PlayerStatsBoardGraphPoint> _graphPoints;

		[SerializeField]
		private Material _fillMaterial;

		[SerializeField]
		private Transform _drawParentTransform;

		[SerializeField]
		[Header("Debug")]
		private List<Transform> _debugPoints;

		private GameObject _statsGraphObject;

		private MeshFilter _meshFilter;

		public void SetGraphPointsValue(List<float> pointsValue, List<float> maxValues)
		{
		}

		[Button(null, EButtonEnableMode.Always)]
		public void DebugDrawGraph()
		{
		}

		public void DrawGraph()
		{
		}
	}
}

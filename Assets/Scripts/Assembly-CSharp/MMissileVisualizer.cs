using System.Collections.Generic;
using UnityEngine;

public class MMissileVisualizer : MonoBehaviour
{
	[SerializeField]
	private Transform _inputDataMuzzlePoint;

	[SerializeField]
	private Transform _muzzleVisualPoint;

	[SerializeField]
	private Transform _missileSpawnPoint;

	[SerializeField]
	private Transform _missileCurPoint;

	[SerializeField]
	private Transform _predictedMissileSpawnPoint;

	[SerializeField]
	private Transform _probeVisualsContainer;

	[SerializeField]
	private Material _probeHitMaterial;

	[SerializeField]
	private Material _probeNoHitMaterial;

	[SerializeField]
	private GameObject _probeGo;

	[SerializeField]
	private int _maxProbes;

	private int _curProbeIndex;

	private List<GameObject> _probeVisuals;

	private static MMissileVisualizer _instance;

	private void Awake()
	{
	}

	public static void Clear()
	{
	}

	public static void SetInputDataMuzzlePosRot(Vector3 position, Quaternion rotation)
	{
	}

	public static void SetMuzzleVisualPosRot(Vector3 position, Quaternion rotation)
	{
	}

	public static void SetPredictedMissileSpawnPosRot(Vector3 position, Quaternion rotation)
	{
	}

	public static void SetMissileSpawnPosRot(Vector3 position, Quaternion rotation)
	{
	}

	public static void SetMissileCurPosRot(Vector3 position, Quaternion rotation)
	{
	}

	public static void VisualizeMissileProbe(Vector3 center, Vector3 extents, Quaternion rotation, bool hasHit)
	{
	}
}

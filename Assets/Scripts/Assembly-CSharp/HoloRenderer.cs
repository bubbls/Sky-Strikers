using Unity.Collections;
using UnityEngine;

public class HoloRenderer : MonoBehaviour
{
	public delegate void VariantProxy(int index, Matrix4x4 matrix, out Color color, out Vector3 scale);

	[SerializeField]
	private Material _holoMaterial;

	[SerializeField]
	private float _holoRadius;

	[SerializeField]
	private int _holoDensity;

	[SerializeField]
	private Vector2 _holoSize;

	[SerializeField]
	public Color BaseColor;

	[SerializeField]
	public Vector3 BaseScale;

	private Mesh _holoMesh;

	private NativeArray<Matrix4x4> _holoMatrix;

	private NativeArray<Vector3> _holoVertices;

	private NativeArray<Color> _holoColors;

	private bool _triangleDirty;

	public int HoloDensity => 0;

	public VariantProxy Proxy { get; set; }

	private void Awake()
	{
	}

	private void OnValidate()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	private void InitData()
	{
	}
}

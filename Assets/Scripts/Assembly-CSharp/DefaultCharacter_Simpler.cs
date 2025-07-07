using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class DefaultCharacter_Simpler : MonoBehaviour
{
	private bool _isInitialized;

	private float _previousDownPosY;

	private float _previousUpPosY;

	public GameObject downPos;

	public GameObject upPos;

	[Header("Buying")]
	public Color buyingColor;

	[Range(0f, 1f)]
	public float buyingInt;

	[SerializeField]
	[Space(10f)]
	private List<MeshRenderer> _meshRenderers;

	[SerializeField]
	private List<SkinnedMeshRenderer> _skinnedMeshRenderers;

	[SerializeField]
	private List<Material> _Materials;

	private List<MaterialPropertyBlock> _propertyBlocks;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void Initialize()
	{
	}

	private void IsInitialized()
	{
	}
}

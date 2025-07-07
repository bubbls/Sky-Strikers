using UnityEngine;

[ExecuteInEditMode]
public class SetGlobalMaterial : MonoBehaviour
{
	[Range(0f, 1f)]
	public float TeamRange;

	[Range(0f, 1f)]
	public float LightProbe;

	[Range(0f, 1f)]
	public float Backdrop;

	private void Update()
	{
	}
}

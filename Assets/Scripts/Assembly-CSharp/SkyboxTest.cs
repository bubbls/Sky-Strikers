using UnityEngine;

[ExecuteInEditMode]
public class SkyboxTest : MonoBehaviour
{
	public Material mat;

	public AnimationCurve SkyBoxStretch;

	public float StretchSpeed;

	public AnimationCurve SkyBoxSwitch;

	private float StretchAnim;

	private float SwitchAnim;

	private void Update()
	{
	}
}

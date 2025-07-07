using UnityEngine;

public class DisplaySlotGlobalManager : MonoBehaviour
{
	public float globalDissolveSpeed;

	public float globalDissolveIntervals;

	public Texture2D globalDissolveNoiseTexture;

	public float globalDissolveNoiseTiling;

	[Range(0f, 10f)]
	public float globalDissolveNoiseFalloff;

	public float globalDissolveSoft;

	[Space(10f)]
	public Color globalEdgeColor;

	[Range(0f, 0.5f)]
	public float globalEdgeWidth;

	private void Start()
	{
	}
}

using UnityEngine;

[RequireComponent(typeof(Light))]
public class CFX_LightFlicker : MonoBehaviour
{
	public bool loop;

	public float smoothFactor;

	public float addIntensity;

	private float minIntensity;

	private float maxIntensity;

	private float baseIntensity;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}
}

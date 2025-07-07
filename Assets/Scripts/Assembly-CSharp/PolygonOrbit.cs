using UnityEngine;

[AddComponentMenu("Camera-Control/Mouse drag Orbit with zoom")]
public class PolygonOrbit : MonoBehaviour
{
	public Transform target;

	public float distance;

	public float xSpeed;

	public float ySpeed;

	public float yMinLimit;

	public float yMaxLimit;

	public float distanceMin;

	public float distanceMax;

	public float smoothTime;

	private float rotationYAxis;

	private float rotationXAxis;

	private float velocityX;

	private float velocityY;

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}

	public static float ClampAngle(float angle, float min, float max)
	{
		return 0f;
	}
}

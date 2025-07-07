using UnityEngine;

public class GrabbablePathVelocityTracker : MonoBehaviour
{
	[SerializeField]
	private Transform _handle;

	private Vector3 _handleVelocity;

	private Vector3 _currentHandlePosition;

	private Vector3 _lastHandlePosition;

	private Transform _trackingSpace;

	public void SetTrackingSpace(Transform trackingSpace)
	{
	}

	public void Execute()
	{
	}

	public Vector3 GetVelocity()
	{
		return default(Vector3);
	}

	public Vector3 GetNormalizedVelocity()
	{
		return default(Vector3);
	}

	public void Reset()
	{
	}
}

using UnityEngine;

public class AimerAnimation : MonoBehaviour
{
	private static readonly int _aiming;

	[SerializeField]
	private Animator _aimerAnimator;

	[SerializeField]
	private Transform _floatingPart;

	[SerializeField]
	private float _tolerance;

	private Vector3 _headToAimerVector;

	private float _dotProduct;

	private Transform _head;

	private bool _isInitialized;

	private bool _isAiming;

	public void InitAimer(Transform headTrans)
	{
	}

	private void LateUpdate()
	{
	}

	private void CheckAiming()
	{
	}

	private void OnDrawGizmos()
	{
	}
}

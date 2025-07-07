using System.Collections.Generic;
using UnityEngine;

public class GhostController : MonoBehaviour
{
	public float iniSpeed;

	public float iniRotateSpeed;

	[HideInInspector]
	public float speed;

	[HideInInspector]
	public float rotateSpeed;

	[SerializeField]
	private GameObject ghostBodyPrefab;

	private List<GameObject> ghostBodyList;

	private Vector3 targetPoint;

	private bool moving;

	[HideInInspector]
	public bool isPlayerIn;

	[HideInInspector]
	public Transform player;

	[SerializeField]
	private GameObject ghostRegion;

	private Vector3 cubeCenter;

	private Vector3 cubeSize;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void SetRandomTargetPoint()
	{
	}
}

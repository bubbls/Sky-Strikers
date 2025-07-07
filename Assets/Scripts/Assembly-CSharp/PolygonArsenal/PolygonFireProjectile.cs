using UnityEngine;

namespace PolygonArsenal
{
	public class PolygonFireProjectile : MonoBehaviour
	{
		private RaycastHit hit;

		public GameObject[] projectiles;

		public Transform spawnPosition;

		[HideInInspector]
		public int currentProjectile;

		public float speed;

		private PolygonButtonScript selectedProjectileButton;

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void nextEffect()
		{
		}

		public void previousEffect()
		{
		}

		public void AdjustSpeed(float newSpeed)
		{
		}
	}
}

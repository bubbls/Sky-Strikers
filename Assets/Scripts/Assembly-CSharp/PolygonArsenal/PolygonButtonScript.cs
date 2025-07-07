using UnityEngine;
using UnityEngine.UI;

namespace PolygonArsenal
{
	public class PolygonButtonScript : MonoBehaviour
	{
		public GameObject Button;

		private Text MyButtonText;

		private string projectileParticleName;

		private PolygonFireProjectile effectScript;

		private PolygonProjectileScript projectileScript;

		public float buttonsX;

		public float buttonsY;

		public float buttonsSizeX;

		public float buttonsSizeY;

		public float buttonsDistance;

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void getProjectileNames()
		{
		}

		public bool overButton()
		{
			return false;
		}
	}
}

using UnityEngine;
using UnityEngine.UI;

namespace PolygonArsenal
{
	public class PolygonBeamScript : MonoBehaviour
	{
		[Header("Prefabs")]
		public GameObject[] beamLineRendererPrefab;

		public GameObject[] beamStartPrefab;

		public GameObject[] beamEndPrefab;

		private int currentBeam;

		private GameObject beamStart;

		private GameObject beamEnd;

		private GameObject beam;

		private LineRenderer line;

		[Header("Adjustable Variables")]
		public float beamEndOffset;

		public float textureScrollSpeed;

		public float textureLengthScale;

		[Header("Put Sliders here (Optional)")]
		public Slider endOffSetSlider;

		public Slider scrollSpeedSlider;

		[Header("Put UI Text object here to show beam name")]
		public Text textBeamName;

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void nextBeam()
		{
		}

		public void previousBeam()
		{
		}

		public void UpdateEndOffset()
		{
		}

		public void UpdateScrollSpeed()
		{
		}

		private void ShootBeamInDir(Vector3 start, Vector3 dir)
		{
		}
	}
}

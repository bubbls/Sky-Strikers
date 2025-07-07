using SVGImporter;
using UnityEngine;
using UnityEngine.Events;

namespace Moon
{
	[ExecuteInEditMode]
	[AddComponentMenu("Miscellaneous/SVG Frame Animator with Timing", 20)]
	public class SVGFrameAnimatorWithTiming : MonoBehaviour
	{
		public FrameWithDuration[] framesWithDuration;

		private float timeElapsed;

		public bool autoPlay;

		public UnityEvent onUpdateIndex;

		public float frameIndex;

		private float lastFrameIndex;

		protected SVGRenderer _svgRenderer;

		protected SVGImage _svgImage;

		public SVGRenderer svgRenderer => null;

		public SVGImage svgImage => null;

		protected void OnEnable()
		{
		}

		public void UpdateMesh()
		{
		}

		public void UpdateIndex()
		{
		}

		public void LateUpdate()
		{
		}
	}
}

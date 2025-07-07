using UnityEngine;

namespace SVGImporter
{
	[AddComponentMenu("Miscellaneous/SVG Frame Animator", 20)]
	[ExecuteInEditMode]
	public class SVGFrameAnimator : MonoBehaviour
	{
		public SVGAsset[] frames;

		public float frameIndex;

		private float lastFrameIndex;

		protected SVGRenderer _svgRenderer;

		protected SVGImage _svgImage;

		public SVGRenderer svgRenderer => null;

		public SVGImage svgImage => null;

		protected virtual void OnEnable()
		{
		}

		protected virtual void UpdateMesh()
		{
		}

		private void LateUpdate()
		{
		}
	}
}

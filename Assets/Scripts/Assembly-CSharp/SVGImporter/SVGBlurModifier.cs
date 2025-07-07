using UnityEngine;

namespace SVGImporter
{
	[RequireComponent(typeof(ISVGRenderer))]
	[ExecuteInEditMode]
	[AddComponentMenu("Rendering/SVG Modifiers/Blur Modifier", 22)]
	public class SVGBlurModifier : SVGModifier
	{
		public Camera camera;

		public bool useCameraVelocity;

		public float radius;

		public bool motionBlur;

		public bool manualMotionBlur;

		public float direction;

		protected Vector3 lastPosition;

		protected Vector2 transformVelocity;

		protected Camera mainCamera => null;

		private void LateUpdate()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void PrepareForRendering(SVGLayer[] layers, SVGAsset svgAsset, bool force)
		{
		}
	}
}

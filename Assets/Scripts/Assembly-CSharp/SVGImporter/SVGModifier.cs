using UnityEngine;

namespace SVGImporter
{
	public abstract class SVGModifier : MonoBehaviour, ISVGModify
	{
		[HideInInspector]
		public bool manualUpdate;

		[HideInInspector]
		public bool useSelection;

		[HideInInspector]
		public LayerSelection layerSelection;

		protected ISVGRenderer _svgRenderer;

		public bool hasSelection => false;

		public ISVGRenderer svgRenderer => null;

		protected virtual void Init()
		{
		}

		protected virtual void Clear()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected virtual void OnWillRenderObject()
		{
		}

		protected abstract void PrepareForRendering(SVGLayer[] layers, SVGAsset svgAsset, bool force);
	}
}

using UnityEngine;
using UnityEngine.UI;

namespace Moon
{
	[RequireComponent(typeof(CanvasRenderer))]
	public class UIMaskableCollider : MaskableGraphic
	{
		[SerializeField]
		private Collider _collider;

		protected override void OnEnable()
		{
		}

		public override void OnCullingChanged()
		{
		}
	}
}

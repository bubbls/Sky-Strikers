using Chamber8.Framework.Common;
using UnityEngine;

namespace Moon
{
	public class LayerConstants : Singleton<LayerConstants>
	{
		public LayerMask LayerDefault { get; private set; }

		public LayerMask LayerSurface { get; private set; }

		public LayerMask LayerPlayerField { get; private set; }

		public LayerMask MaskPlayerField { get; private set; }

		public LayerMask MaskDefault { get; private set; }

		public LayerMask MaskSurface { get; private set; }

		public LayerMask MaskLocomotion { get; private set; }

		public LayerMask LayerCustomCollision { get; private set; }

		public LayerMask MaskCustomCollision { get; private set; }

		public LayerMask MaskBall { get; private set; }

		public LayerMask LayerBall { get; private set; }

		public LayerMask MaskAffectByExplosion { get; private set; }

		public LayerMask MaskAffectByLocalPlayerExplosion { get; private set; }

		public LayerMask MaskAffectByServerExplosion { get; private set; }

		public LayerMask MaskAffectByProjectile { get; private set; }

		public LayerMask LayerDeadZone { get; private set; }

		public LayerMask LayerField { get; private set; }

		public LayerMask MaskField { get; private set; }

		public LayerMask LayerPlayerVisual { get; private set; }

		public LayerMask LayerPlayerVisualNotVisibleInMainCamera { get; private set; }

		public LayerMask MaskPlayerVisualNotVisibleInMainCamera { get; private set; }

		public LayerMask LayerPhysicalUI { get; private set; }

		public LayerMask MaskPhysicalUI { get; private set; }

		public LayerMask LayerPlayer { get; private set; }

		public LayerMask MaskPlayer { get; private set; }

		public LayerMask LayerHand { get; private set; }

		public LayerMask MaskHand { get; private set; }

		public LayerMask LayerGrabbable { get; private set; }

		public LayerMask MaskGrabbable { get; private set; }

		public LayerMask MaskProjectile { get; private set; }

		public LayerMask LayerEvent { get; private set; }

		public LayerMask MaskEvent { get; private set; }

		public LayerMask MaskItemCollision { get; private set; }

		protected override void Initialize()
		{
		}
	}
}

using UnityEngine;

namespace Moon.Player.Visual
{
	public class PrimeMagepunkSuitHandVisual : PrimeSuitHandVisual
	{
		[SerializeField]
		private AimerAnimation _aimerAnimation;

		private void Start()
		{
		}

		protected override void HandleOnPlayerSkeletonChanged(PlayerSkeleton playerSkeleton)
		{
		}
	}
}

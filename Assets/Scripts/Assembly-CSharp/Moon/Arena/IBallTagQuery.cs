using System;

namespace Moon.Arena
{
	public interface IBallTagQuery
	{
		event Action<BallTag, HittableHitInfo> OnBallTaggedFromHit;

		bool HasTag(BallTag ballTag);

		bool IsBallInteractable();

		bool CanIgnoreHitSource(HitSourceID hitSourceID);
	}
}

using System.Collections.Generic;

namespace Moon
{
	public class PlayerHand : PlayerHandBase
	{
		private readonly HashSet<string> _invisibleReason;

		private bool _forcePose;

		public override void Reset()
		{
		}

		public void ToggleForcePose(bool forcePose)
		{
		}

		public override void SetFingerThumb(float value)
		{
		}

		public override void SetFingerIndex(float value)
		{
		}

		public override void SetFingerOthers(float value)
		{
		}

		public void ForceSetFingerThumb(float value)
		{
		}

		public void ForceSetFingerIndex(float value)
		{
		}

		public void ForceSetFingerOthers(float value)
		{
		}

		public void SetInvisible(string reason)
		{
		}

		public void UnsetInvisible(string reason)
		{
		}

		public void ClearInvisibleReasons()
		{
		}
	}
}

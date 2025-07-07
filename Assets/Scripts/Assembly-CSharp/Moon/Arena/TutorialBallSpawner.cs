using Fusion;
using UnityEngine;

namespace Moon.Arena
{
	[NetworkBehaviourWeaved(5)]
	public class TutorialBallSpawner : MBallSpawner
	{
		[SerializeField]
		private int _score;

		private static Changed<TutorialBallSpawner> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<TutorialBallSpawner> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<TutorialBallSpawner> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		public int Score => 0;

		protected override void Ball_OnEnteredCollision(CollisionInfo collisionInfo)
		{
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}
	}
}

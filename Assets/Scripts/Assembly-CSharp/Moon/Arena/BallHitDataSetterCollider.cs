using Fusion;
using UnityEngine;

namespace Moon.Arena
{
	public class BallHitDataSetterCollider : MonoBehaviour
	{
		[SerializeField]
		private HitSourceID _hitSourceID;

		public HitSourceID HitSourceID => default(HitSourceID);

		public PlayerRef PlayerRef { get; private set; }

		private void Start()
		{
		}

		public void SetPlayerRef(PlayerRef playerRef)
		{
		}
	}
}

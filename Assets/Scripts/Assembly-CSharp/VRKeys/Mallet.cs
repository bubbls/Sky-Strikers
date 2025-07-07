using UnityEngine;

namespace VRKeys
{
	public class Mallet : MonoBehaviour
	{
		public enum MalletHand
		{
			Left = 0,
			Right = 1,
			Both = 2,
			None = 3
		}

		public AudioClip clipToPlay;

		public MalletHand hand;

		public HandCollider handCollider;

		private bool _isMovingDownward;

		private AudioSource audioSource;

		private Controller controller;

		private Vector3 prevPos;

		public bool isMovingDownward
		{
			get
			{
				return false;
			}
			private set
			{
			}
		}

		private void Awake()
		{
		}

		private void FixedUpdate()
		{
		}

		public void HandleTriggerEnter(Key key)
		{
		}

		public Controller Controller()
		{
			return null;
		}
	}
}

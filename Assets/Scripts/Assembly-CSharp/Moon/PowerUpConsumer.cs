using DP.Takeaway.Utils;
using UnityEngine;

namespace Moon
{
	public class PowerUpConsumer : MonoBehaviour
	{
		[SerializeField]
		private Component _target;

		public void SetTarget(Component target)
		{
		}

		public void Consume(ICommand powerUpCommand)
		{
		}
	}
}

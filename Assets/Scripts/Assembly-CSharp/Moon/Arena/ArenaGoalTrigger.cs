using System;
using UnityEngine;

namespace Moon.Arena
{
	public class ArenaGoalTrigger : MonoBehaviour
	{
		public Action<Collider> OnArenaGoalTriggerEnter;

		private void OnTriggerEnter(Collider other)
		{
		}
	}
}

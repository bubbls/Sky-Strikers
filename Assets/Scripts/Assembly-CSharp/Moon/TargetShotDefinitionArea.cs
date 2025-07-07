using Moon.Arena;
using UnityEngine;

namespace Moon
{
	public class TargetShotDefinitionArea : MonoBehaviour
	{
		[SerializeField]
		private ArenaGoal _arenaGoal;

		private bool _isBallInTargetShotArea;

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}
	}
}

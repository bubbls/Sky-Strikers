using UnityEngine;

namespace Moon.Arena
{
	public class ArenaEyeStateMachine : MonoBehaviour
	{
		public enum EyeState : byte
		{
			None = 0,
			Idle = 1,
			LookAtBall = 2,
			SpawnTears = 3
		}

		private ArenaEyeSpawnTearsState _spawnTearsState;

		private Animator _animator;

		private EyeState _currentState;

		private void Awake()
		{
		}

		public void ChangeState(EyeState newState)
		{
		}

		public void StopSpawnPumpkinState(bool shouldLookAtBall)
		{
		}

		private void SetState(EyeState state)
		{
		}

		private void HandleSpawnTears()
		{
		}

		private void SetAnimatorState(string stateName)
		{
		}

		private void Reset()
		{
		}
	}
}

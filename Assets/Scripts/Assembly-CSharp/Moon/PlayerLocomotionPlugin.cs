using UnityEngine;

namespace Moon
{
	public abstract class PlayerLocomotionPlugin : MonoBehaviour
	{
		public abstract void InitializeValues(PlayerLocomotion locomotion);

		public abstract void Apply(PlayerLocomotion locomotion, float deltaTime);

		public abstract void HandleXRInput(MXRInputData inputData);
	}
}

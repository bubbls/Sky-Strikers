using Moon.Arena;
using UnityEngine;

namespace Moon.Player.Ability.Jetstream
{
	public class JetstreamBallShotControlFx : MonoBehaviour
	{
		[SerializeField]
		private Transform _ringFxContainer;

		[SerializeField]
		private PlayerTeamObjectsGroup _teamObjectsGroup;

		public void Initialize(TeamNo teamNo)
		{
		}

		public void UpdateVisuals(Vector3 handPosition, Vector3 ballPosition)
		{
		}
	}
}

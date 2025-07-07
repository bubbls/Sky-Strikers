using NaughtyAttributes;
using UnityEngine;

namespace Moon.Player.Ability.Bulwarp
{
	[RequireComponent(typeof(LineRenderer))]
	public class ArenaBulwarpAreaLineGenerator : MonoBehaviour
	{
		[SerializeField]
		private LineRenderer _lineRenderer;

		private Transform[] _points;

		[Button("Generate Line", EButtonEnableMode.Always)]
		private void GenerateLine()
		{
		}

		[Button("Mirror Line Points & Generate Line", EButtonEnableMode.Always)]
		private void MirrorAndGenerateLine()
		{
		}

		private void FindPoints()
		{
		}
	}
}

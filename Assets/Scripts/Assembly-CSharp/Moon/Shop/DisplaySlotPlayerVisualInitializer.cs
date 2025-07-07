using JetBrains.Annotations;
using Moon.Player.Visual;
using NaughtyAttributes;
using UnityEngine;

namespace Moon.Shop
{
	public class DisplaySlotPlayerVisualInitializer : MonoBehaviour
	{
		[SerializeField]
		private PlayerVisualBase[] _playerVisuals;

		private void Start()
		{
		}

		[UsedImplicitly]
		[Button("Find Visuals", EButtonEnableMode.Always)]
		private void FindVisuals()
		{
		}
	}
}

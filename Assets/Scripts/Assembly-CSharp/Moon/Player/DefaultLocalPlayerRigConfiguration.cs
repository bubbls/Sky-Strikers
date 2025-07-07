using Chamber8.Framework.Common;
using UnityEngine;

namespace Moon.Player
{
	[CreateAssetMenu(fileName = "DefaultLocalPlayerRigConfiguration", menuName = "Moon/Player/DefaultLocalPlayerRigConfiguration")]
	public class DefaultLocalPlayerRigConfiguration : SingleScriptableObject<DefaultLocalPlayerRigConfiguration, DefaultResourcePathProvider<DefaultLocalPlayerRigConfiguration>>
	{
		[SerializeField]
		private PlayerLocomotionConfiguration _locomotionConfiguration;

		public PlayerLocomotionConfiguration LocomotionConfiguration => null;
	}
}

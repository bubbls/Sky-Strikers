using Fusion;
using Moon.AI.VisualScripting;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.GameActivity.Behaviors
{
	public class MSeekPlayer : MonoBehaviour
	{
		[Preserve]
		public MPlayer Target { get; private set; }

		[Preserve]
		public Transform TargetBody { get; private set; }

		[Preserve]
		public PlayerRef TargetPlayerRef { get; private set; }

		[Preserve]
		public bool Seek(OverlapShapeDesc sight)
		{
			return false;
		}
	}
}

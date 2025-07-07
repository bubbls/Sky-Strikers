using UnityEngine;
using moveen.core;

namespace moveen.descs
{
	public class MoveenStep2 : MonoBehaviour
	{
		[Tooltip("Stepping engine")]
		public Step2 step;

		public static bool showInstrumentalInfo;

		public virtual void OnValidate()
		{
		}

		private void Update()
		{
		}
	}
}

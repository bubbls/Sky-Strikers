using Moon.AI.VisualScripting;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.GameActivity.Behaviors
{
	public class Sight : MonoBehaviour
	{
		[Preserve]
		public bool IsInsight(Transform target, OverlapShapeDesc sight)
		{
			return false;
		}
	}
}

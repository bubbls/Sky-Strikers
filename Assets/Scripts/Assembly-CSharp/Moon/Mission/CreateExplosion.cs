using Moon.AI.VisualScripting;
using NaughtyAttributes;
using UnityEngine;

namespace Moon.Mission
{
	public class CreateExplosion : MonoBehaviour
	{
		[SerializeField]
		private LayerMask _layerMask;

		[SerializeField]
		private OverlapShapeDesc _osd;

		[SerializeField]
		private float _force;

		[Button(null, EButtonEnableMode.Always)]
		public void Explode()
		{
		}
	}
}

using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.AI
{
	[Preserve]
	public class AIMove : MonoBehaviour
	{
		private int _pointIndex;

		private Transform[] _points;

		private float _speed;

		private float _pointCorrection;

		private Rigidbody _localPlayer;

		public void Init(Rigidbody localPlayer)
		{
		}

		private void Update()
		{
		}
	}
}

using DP.Takeaway.Utils;
using UnityEngine;

namespace Moon.Benchmark
{
	public class ServerFPSLogger : MonoBehaviour
	{
		private const float UpdateInterval = 1f;

		private int _frameCount;

		private float _deltaTime;

		private float _fps;

		private Cooldown _cooldown;

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}

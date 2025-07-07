using System;
using System.Threading;
using UnityEngine;

namespace Moon.Bootstrap
{
	public class DefaultGameCycleServiceRunner : MonoBehaviour
	{
		private static readonly CancellationTokenSource _defaultTokenSource;

		private Action _serveTick;

		private bool _hasServerTick;

		public static CancellationToken DefaultToken => default(CancellationToken);

		private void Update()
		{
		}

		private void OnApplicationQuit()
		{
		}

		public void Serve(Action tick)
		{
		}

		public static DefaultGameCycleServiceRunner GetRunner<T>() where T : DefaultGameCycleServiceRunner
		{
			return null;
		}
	}
}

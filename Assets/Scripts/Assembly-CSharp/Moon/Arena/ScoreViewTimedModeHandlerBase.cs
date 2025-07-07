using System;
using UnityEngine;

namespace Moon.Arena
{
	public abstract class ScoreViewTimedModeHandlerBase : MonoBehaviour, IScoreViewGameModeHandler, IDisposable
	{
		protected const int TimedModeFinalSecondsTime = 10;

		public abstract void Initialize();

		public abstract void Dispose();

		public abstract void HandleOnViewEntered(object viewData);

		public abstract void HandleOnViewExited();
	}
}

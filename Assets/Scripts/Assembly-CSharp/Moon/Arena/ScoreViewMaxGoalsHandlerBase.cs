using System;
using UnityEngine;

namespace Moon.Arena
{
	public abstract class ScoreViewMaxGoalsHandlerBase : MonoBehaviour, IScoreViewGameModeHandler, IDisposable
	{
		public abstract void Initialize();

		public abstract void Dispose();

		public abstract void HandleOnViewEntered(object viewData);

		public abstract void HandleOnViewExited();
	}
}

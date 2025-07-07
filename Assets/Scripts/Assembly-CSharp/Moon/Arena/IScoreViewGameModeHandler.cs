using System;

namespace Moon.Arena
{
	public interface IScoreViewGameModeHandler : IDisposable
	{
		void Initialize();

		void HandleOnViewEntered(object viewData);

		void HandleOnViewExited();
	}
}

using System;
using System.Collections.Generic;

namespace Moon.Bootstrap
{
	public class GameCycleManager<T> where T : IBaseGameCycle
	{
		private readonly List<T> _gameCycles;

		private readonly Dictionary<T, HashSet<Type>> _allowedCycleTypes;

		private readonly List<T> _runningGameCycles;

		public T CurrentCycle { get; private set; }

		public void Register(T gameCycle, params Type[] allowedCycleTypes)
		{
		}

		public bool TryGetNextCycle(Type gameCycleType, out T nextCycle)
		{
			nextCycle = default(T);
			return false;
		}

		private void PushCurrentCycleToBackgroundIfNeed()
		{
		}

		public void SetCurrentCycle(T nextCycle)
		{
		}

		public void GetFirstCycle()
		{
		}

		public void Clear()
		{
		}

		public void Tick()
		{
		}
	}
}

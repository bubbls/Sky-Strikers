using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Fusion.FSM
{
	public static class IListExtensions
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool RemoveBySwap<T>(this IList<T> list, int index)
		{
			return false;
		}
	}
}

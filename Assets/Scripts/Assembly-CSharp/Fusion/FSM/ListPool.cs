using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Fusion.FSM
{
	public class ListPool<T>
	{
		private const int POOL_CAPACITY = 4;

		private const int LIST_CAPACITY = 16;

		public static readonly ListPool<T> Shared;

		private List<List<T>> _pool;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public List<T> Get(int capacity)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Return(List<T> list)
		{
		}
	}
	public static class ListPool
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static List<T> Get<T>(int capacity)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Return<T>(List<T> list)
		{
		}
	}
}

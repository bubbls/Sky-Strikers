using System.Collections.Generic;

namespace SVGImporter.Utils
{
	public class LiteStack<T>
	{
		private int idx;

		private List<T> stack;

		public int Count => 0;

		public void Push(T obj)
		{
		}

		public T Pop()
		{
			return default(T);
		}

		public T Peek()
		{
			return default(T);
		}

		public void Clear()
		{
		}
	}
	public class LiteStack : LiteStack<object>
	{
	}
}

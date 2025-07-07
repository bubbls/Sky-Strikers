using System;
using System.Threading.Tasks;

namespace Moon.Bootstrap
{
	public static class TaskExtension
	{
		public static Task Catch(this Task task)
		{
			return null;
		}

		public static Task Catch(this Task task, Action<Exception> onCaught)
		{
			return null;
		}
	}
}

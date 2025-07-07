using System.Collections.Generic;
using moveen.descs;

namespace moveen.utils
{
	public static class OrderedTick
	{
		private static List<IOrderableTick> all;

		private static List<IOrderableTick> toAdd;

		private static bool readyForTick;

		private static bool readyForFixedTick;

		private static bool isSorted;

		public static void setUnsorted()
		{
		}

		public static void addComponent(IOrderableTick co)
		{
		}

		public static void deleteComponent(IOrderableTick co)
		{
		}

		public static void onUnityFixedUpdate(float dt)
		{
		}

		public static void onUnityLateFixedUpdate()
		{
		}

		public static void onUnityUpdate()
		{
		}

		public static void onUnityLateUpdate()
		{
		}

		private static void tick(float dt)
		{
		}

		private static void sort()
		{
		}

		private static int compareOrderable(IOrderableTick a, IOrderableTick b)
		{
			return 0;
		}

		public static void forceTick(float dt)
		{
		}
	}
}

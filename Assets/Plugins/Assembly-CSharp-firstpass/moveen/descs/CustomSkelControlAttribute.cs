using System;

namespace moveen.descs
{
	[AttributeUsage(AttributeTargets.Field)]
	public class CustomSkelControlAttribute : Attribute
	{
		public float min;

		public float max;

		public bool solve;
	}
}

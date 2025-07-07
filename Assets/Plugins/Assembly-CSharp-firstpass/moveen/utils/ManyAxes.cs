using System.Collections.Generic;
using UnityEngine;

namespace moveen.utils
{
	public class ManyAxes : BiConsumer<Vector3, Vector3>
	{
		public List<Tuple<Vector3, Vector3>> axes;

		public virtual void accept(Vector3 input, Vector3 output)
		{
		}

		public ManyAxes(List<Tuple<Vector3, Vector3>> axes)
		{
		}
	}
}

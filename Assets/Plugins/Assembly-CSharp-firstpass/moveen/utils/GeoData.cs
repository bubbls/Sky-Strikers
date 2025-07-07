using System.Collections.Generic;
using UnityEngine;

namespace moveen.utils
{
	public class GeoData
	{
		public List<Vector3> pos;

		public List<Vector3> normal;

		public List<Vector2> uv;

		public List<int> indices;

		public void addTriangle(Vector3 a, Vector3 b, Vector3 c, Vector3 normal)
		{
		}

		public void addBacks()
		{
		}

		public Mesh getMesh()
		{
			return null;
		}
	}
}

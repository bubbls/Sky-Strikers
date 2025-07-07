using UnityEngine;

namespace SVGImporter.Utils
{
	public struct StrokeSegment
	{
		public Vector2 startPoint;

		public Vector2 endPoint;

		public Vector2 direction;

		public Vector2 directionNormalized;

		public Vector2 directionNormalizedRotated;

		public float length;

		public StrokeSegment(Vector2 startPoint, Vector2 endPoint)
		{
			this.startPoint = default(Vector2);
			this.endPoint = default(Vector2);
			direction = default(Vector2);
			directionNormalized = default(Vector2);
			directionNormalizedRotated = default(Vector2);
			length = 0f;
		}
	}
}

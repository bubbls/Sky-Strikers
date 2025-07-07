using System;
using UnityEngine;

namespace SVGImporter.Utils
{
	[Serializable]
	public struct SVGBounds
	{
		[HideInInspector]
		[SerializeField]
		private float _minX;

		[HideInInspector]
		[SerializeField]
		private float _minY;

		[SerializeField]
		[HideInInspector]
		private float _maxX;

		[HideInInspector]
		[SerializeField]
		private float _maxY;

		[SerializeField]
		private Vector2 _center;

		[SerializeField]
		private Vector2 _size;

		[SerializeField]
		[HideInInspector]
		private Vector2 _extents;

		public float minX
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float maxX
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float minY
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float maxY
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Vector2 min
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Vector2 max
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Vector2 size
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Vector2 extents
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Vector2 center
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Rect rect => default(Rect);

		public static SVGBounds InfiniteInverse => default(SVGBounds);

		public bool isInfiniteInverse => false;

		public SVGBounds(float minX, float minY, float maxX, float maxY)
		{
			_minX = 0f;
			_minY = 0f;
			_maxX = 0f;
			_maxY = 0f;
			_center = default(Vector2);
			_size = default(Vector2);
			_extents = default(Vector2);
		}

		public SVGBounds(Vector2 center, Vector2 size)
		{
			_minX = 0f;
			_minY = 0f;
			_maxX = 0f;
			_maxY = 0f;
			_center = default(Vector2);
			_size = default(Vector2);
			_extents = default(Vector2);
		}

		public SVGBounds(Bounds bounds)
		{
			_minX = 0f;
			_minY = 0f;
			_maxX = 0f;
			_maxY = 0f;
			_center = default(Vector2);
			_size = default(Vector2);
			_extents = default(Vector2);
		}

		public bool Contains(Vector2 point)
		{
			return false;
		}

		public bool Contains(SVGBounds bounds)
		{
			return false;
		}

		public bool Contains(Vector2 center, Vector2 size)
		{
			return false;
		}

		public SVGBounds Encapsulate(Vector2 point)
		{
			return default(SVGBounds);
		}

		public SVGBounds Encapsulate(float minX, float minY, float maxX, float maxY)
		{
			return default(SVGBounds);
		}

		public SVGBounds Encapsulate(Vector2 center, Vector2 size)
		{
			return default(SVGBounds);
		}

		public SVGBounds Encapsulate(SVGBounds bounds)
		{
			return default(SVGBounds);
		}

		public SVGBounds Encapsulate(Bounds bounds)
		{
			return default(SVGBounds);
		}

		public SVGBounds Expand(float amount)
		{
			return default(SVGBounds);
		}

		public SVGBounds Expand(Vector2 amount)
		{
			return default(SVGBounds);
		}

		public bool Intersects(SVGBounds bounds)
		{
			return false;
		}

		public SVGBounds SetMinMax(float minX, float minY, float maxX, float maxY)
		{
			return default(SVGBounds);
		}

		public void ApplyBounds(SVGBounds bounds)
		{
		}

		public SVGBounds Reset()
		{
			return default(SVGBounds);
		}

		public bool Compare(SVGBounds bounds)
		{
			return false;
		}

		public SVGBounds ResetToInfiniteInverse()
		{
			return default(SVGBounds);
		}

		public override string ToString()
		{
			return null;
		}

		public Bounds ToBounds()
		{
			return default(Bounds);
		}

		private void UpdateMinMax()
		{
		}

		private void UpdateSizeExtentsCenter()
		{
		}
	}
}

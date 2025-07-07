using System.Collections.Generic;
using SVGImporter.Utils;
using UnityEngine;

namespace SVGImporter.Data
{
	public class QuadTree<T>
	{
		protected internal QuadTreeCell<T> _root;

		protected internal SVGBounds _originalBounds;

		protected internal int _originalMaxCapacity;

		public QuadTreeCell<T> root => null;

		public QuadTree(SVGBounds bounds)
		{
		}

		public QuadTree(SVGBounds bounds, int maxCapacity)
		{
		}

		public QuadTreeNode<T> Add(T data, SVGBounds bounds)
		{
			return null;
		}

		public List<QuadTreeNode<T>> Contains(Vector2 point)
		{
			return null;
		}

		public List<QuadTreeNode<T>> Contains(SVGBounds bounds)
		{
			return null;
		}

		public List<QuadTreeNode<T>> Intersects(SVGBounds bounds)
		{
			return null;
		}

		public void Clear()
		{
		}

		public void Reset()
		{
		}
	}
}

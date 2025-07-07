using System.Collections.Generic;
using SVGImporter.Utils;
using UnityEngine;

namespace SVGImporter.Data
{
	public class QuadTreeCell<T>
	{
		private const int DEFAULT_MAX_CAPACITY = 1;

		public int maxCapacity;

		public SVGBounds bounds;

		public QuadTreeCell<T> parent;

		public QuadTreeCell<T> topLeft;

		public QuadTreeCell<T> topRight;

		public QuadTreeCell<T> bottomLeft;

		public QuadTreeCell<T> bottomRight;

		public List<QuadTreeNode<T>> nodes;

		public QuadTree<T> quadTree;

		protected internal int _depth;

		public int depth => 0;

		public QuadTreeCell<T> root => null;

		public bool isCellEmpty => false;

		internal QuadTreeCell<T> FindRoot(QuadTreeCell<T> current)
		{
			return null;
		}

		public QuadTreeCell(SVGBounds bounds)
		{
		}

		public QuadTreeCell(SVGBounds bounds, int maxCapacity)
		{
		}

		public QuadTreeCell(SVGBounds bounds, QuadTreeCell<T> parent, int maxCapacity)
		{
		}

		public QuadTreeCell(SVGBounds bounds, QuadTreeCell<T> parent, QuadTree<T> quadTree, int maxCapacity)
		{
		}

		public QuadTreeNode<T> Add(T data, SVGBounds bounds)
		{
			return null;
		}

		public QuadTreeNode<T> Add(QuadTreeNode<T> node)
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

		public List<QuadTreeNode<T>> NearestNeighbour(Vector2 point)
		{
			return null;
		}

		public void Clear()
		{
		}

		public void Remove()
		{
		}

		public void CleanUnusedCells()
		{
		}

		public static void CleanUnusedCells(QuadTreeCell<T> cell)
		{
		}
	}
}

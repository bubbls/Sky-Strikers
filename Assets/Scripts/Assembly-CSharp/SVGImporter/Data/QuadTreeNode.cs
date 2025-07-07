using SVGImporter.Utils;

namespace SVGImporter.Data
{
	public class QuadTreeNode<T>
	{
		public T data;

		public SVGBounds bounds;

		public QuadTreeCell<T> cell;

		protected internal int _depth;

		public QuadTree<T> quadTree => null;

		public int depth => 0;

		public QuadTreeNode(T data, SVGBounds bounds)
		{
		}

		public QuadTreeNode(T data, SVGBounds bounds, QuadTreeCell<T> cell)
		{
		}

		public void Move(SVGBounds bounds)
		{
		}

		public void Remove()
		{
		}
	}
}

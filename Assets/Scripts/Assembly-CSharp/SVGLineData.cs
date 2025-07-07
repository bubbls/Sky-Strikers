using System.Collections.Generic;
using UnityEngine;

public class SVGLineData
{
	public struct Edge
	{
		public Vector2 start;

		public Vector2 end;

		public Edge(Vector2 start, Vector2 end)
		{
			this.start = default(Vector2);
			this.end = default(Vector2);
		}

		public Vector2 Direction()
		{
			return default(Vector2);
		}

		public Vector2 DirectionNormalized()
		{
			return default(Vector2);
		}

		public float Magnitude()
		{
			return 0f;
		}
	}

	public List<Vector2> _points;

	protected float[] _magnitudes;

	protected Vector2[] _normals;

	protected float _totalMagnitude;

	public float totalMagnitude => 0f;

	public SVGLineData()
	{
	}

	public SVGLineData(List<Vector2> points)
	{
	}

	public SVGLineData(Vector2[] points)
	{
	}

	public void Add(Vector2 point)
	{
	}

	public void Insert(int index, Vector2 item)
	{
	}

	public void Remove(Vector2 point)
	{
	}

	public void RemoveAt(int index)
	{
	}

	public Edge GetEdge(int index)
	{
		return default(Edge);
	}

	public int GetEdgeCount()
	{
		return 0;
	}

	public void UpdateMagnitudes()
	{
	}

	public void UpdateNormals()
	{
	}

	public void UpdateAll()
	{
	}

	public void Clear()
	{
	}

	public Vector2 GetNormal(int index)
	{
		return default(Vector2);
	}

	public float GetMagnitude(int index)
	{
		return 0f;
	}
}

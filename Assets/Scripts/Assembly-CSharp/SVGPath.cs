using System;
using UnityEngine;

[Serializable]
public class SVGPath
{
	public Vector2[] points;

	public Rect bounds;

	public int pointCount => 0;

	public SVGPath()
	{
	}

	public SVGPath(Vector2[] points)
	{
	}

	public SVGPath(Vector2[] points, Rect bounds)
	{
	}

	public void RecalculateBounds()
	{
	}
}

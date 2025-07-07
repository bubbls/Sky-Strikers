using System;
using UnityEngine;

namespace Moon
{
	[Serializable]
	public class MissileConfig
	{
		[SerializeField]
		private float _duration;

		[SerializeField]
		private float _speed;

		[SerializeField]
		private Vector2 _extents;

		public float Duration => 0f;

		public float Speed => 0f;

		public Vector2 Extents => default(Vector2);
	}
}

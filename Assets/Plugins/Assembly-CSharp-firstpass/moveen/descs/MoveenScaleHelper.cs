using UnityEngine;
using moveen.utils;

namespace moveen.descs
{
	[ExecuteInEditMode]
	public class MoveenScaleHelper : MonoBehaviour
	{
		[ReadOnly]
		public float lastScale;

		[HideInInspector]
		public bool showWarning;

		public void OnEnable()
		{
		}
	}
}

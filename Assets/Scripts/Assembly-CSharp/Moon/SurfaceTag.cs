using UnityEngine;

namespace Moon
{
	public class SurfaceTag : MonoBehaviour
	{
		[SerializeField]
		private SurfaceTagType _surfaceTagType;

		public SurfaceTagType SurfaceTagType => default(SurfaceTagType);
	}
}

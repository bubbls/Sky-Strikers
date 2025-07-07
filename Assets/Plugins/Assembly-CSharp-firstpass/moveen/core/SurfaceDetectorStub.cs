using UnityEngine;

namespace moveen.core
{
	public class SurfaceDetectorStub : ISurfaceDetector
	{
		public override Vector3 detect(Vector3 input, Vector3 normal)
		{
			return default(Vector3);
		}
	}
}

using UnityEngine;

namespace Moon
{
	public class GameCamera : MonoBehaviour
	{
		[SerializeField]
		protected Camera _camera;

		public Camera Camera => null;

		public virtual void Initialize()
		{
		}

		public virtual void ToggleCamera(bool enable)
		{
		}
	}
}

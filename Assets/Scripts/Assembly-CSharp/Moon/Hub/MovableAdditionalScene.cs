using UnityEngine;

namespace Moon.Hub
{
	public class MovableAdditionalScene : MonoBehaviour, IAdditionalScene
	{
		[SerializeField]
		private Transform _transform;

		public void MoveTo(AdditionalSceneHandler handler)
		{
		}

		public void Hide()
		{
		}
	}
}

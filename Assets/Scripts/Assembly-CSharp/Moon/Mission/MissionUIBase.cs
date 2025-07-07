using UnityEngine;

namespace Moon.Mission
{
	public abstract class MissionUIBase : MonoBehaviour
	{
		[SerializeField]
		private GameObject _container;

		protected GameObject Container => null;

		public virtual bool IsOn => false;

		public virtual void ToggleUI(bool enable)
		{
		}
	}
}

using UnityEngine;

namespace Moon
{
	public abstract class PlayerStatsBoardPage : MonoBehaviour
	{
		[SerializeField]
		private GameObject _container;

		public void Show()
		{
		}

		public void Hide()
		{
		}

		public virtual void UpdatePageData(PlayerSuitClass suitClass)
		{
		}
	}
}

using UnityEngine;

namespace Moon.Arena
{
	public class ArenaFieldChangingView : ArenaScreenView
	{
		[SerializeField]
		private GameObject _textObj;

		[SerializeField]
		private float _textFlashInterval;

		public override void Initialize()
		{
		}

		public override void Dispose()
		{
		}

		protected override void EnterViewInternal(object viewData = null)
		{
		}

		protected override void ExitViewInternal()
		{
		}

		private void DisableText()
		{
		}

		private void EnableText()
		{
		}
	}
}

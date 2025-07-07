using Chamber8.Framework.Messaging;
using TMPro;
using UnityEngine;

namespace Moon.Arena
{
	public class ArenaMatchEndView : ArenaScreenView
	{
		[SerializeField]
		protected TMP_Text _viewText;

		[SerializeField]
		private TeamNo _targetTeam;

		[SerializeField]
		private TMP_ColorGradient _drawGradient;

		[SerializeField]
		private TMP_ColorGradient _teamOneGradient;

		[SerializeField]
		private TMP_ColorGradient _teamTwoGradient;

		private IMessageSubscriber _messageSubscriber;

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
	}
}

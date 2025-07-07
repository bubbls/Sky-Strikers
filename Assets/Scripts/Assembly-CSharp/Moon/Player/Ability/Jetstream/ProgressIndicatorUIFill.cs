using UnityEngine;
using UnityEngine.UI;

namespace Moon.Player.Ability.Jetstream
{
	public class ProgressIndicatorUIFill : ProgressIndicator
	{
		[SerializeField]
		private Image[] _fillImages;

		public override void SetProgress(float progress)
		{
		}
	}
}

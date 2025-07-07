using DP.Takeaway.Utils;
using Moon.Hub;
using NaughtyAttributes;
using TMPro;
using UnityEngine;

namespace Moon.SNS
{
	public class NewMailFlag : MonoBehaviour
	{
		[SerializeField]
		private TMP_Text _textCount;

		[SerializeField]
		private TMP_Text[] _otherTexts;

		[SerializeField]
		private ManualToggle _toggle;

		[SerializeField]
		private RepeatAction _repeatAction;

		[SerializeField]
		private GameObject _exclamationMark;

		[Button(null, EButtonEnableMode.Always)]
		private void DebugSetNumber1()
		{
		}

		[Button(null, EButtonEnableMode.Always)]
		private void DebugSetNumber0()
		{
		}

		public void Set(int number)
		{
		}
	}
}

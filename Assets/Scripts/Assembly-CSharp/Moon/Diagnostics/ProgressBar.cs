using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Moon.Diagnostics
{
	public class ProgressBar : MonoBehaviour
	{
		[SerializeField]
		[Range(0f, 1f)]
		private float _progress;

		[SerializeField]
		private Image _progressBar;

		[SerializeField]
		private TMP_Text? _textProgress;

		public float Progress
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		private void OnValidate()
		{
		}

		public void SetValue(int value, int max)
		{
		}
	}
}

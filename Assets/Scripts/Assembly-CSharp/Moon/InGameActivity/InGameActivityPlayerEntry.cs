using System.Text.RegularExpressions;
using TMPro;
using UnityEngine;

namespace Moon.InGameActivity
{
	public class InGameActivityPlayerEntry : MonoBehaviour
	{
		[SerializeField]
		private TMP_Text _positionText;

		[SerializeField]
		private TMP_Text _nameText;

		[SerializeField]
		private TMP_Text _activityPointText;

		private readonly Regex _regex;

		public void Reset()
		{
		}

		public void UpdateVisual(string playerName, int activityPoint, int position)
		{
		}

		public void UpdateVisual(string playerName, int activityPoint)
		{
		}
	}
}

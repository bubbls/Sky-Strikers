using System.Net;
using TMPro;
using UnityEngine;

namespace Moon.Mission
{
	public class MissionBoardErrorInfoPanel : MissionUIBase
	{
		[SerializeField]
		private TMP_Text _errorMessageText;

		public void UpdateErrorInfo(HttpStatusCode errorCode, string errorMessage)
		{
		}
	}
}

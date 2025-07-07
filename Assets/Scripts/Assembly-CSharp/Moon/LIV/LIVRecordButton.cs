using TMPro;
using UnityEngine;

namespace Moon.LIV
{
	public class LIVRecordButton : LIVButton
	{
		[SerializeField]
		private TMP_Text _buttonText;

		[SerializeField]
		private ColorConfig _modelColorConfig;

		[SerializeField]
		private ColorConfig _textColorConfig;

		[SerializeField]
		private MeshRenderer _meshRenderer;

		private static readonly int _baseColor;

		private const string RecordText = "Record";

		public void StartRecording()
		{
		}

		public void UpdateRecording(string recordingTime)
		{
		}

		public void StopRecording()
		{
		}
	}
}

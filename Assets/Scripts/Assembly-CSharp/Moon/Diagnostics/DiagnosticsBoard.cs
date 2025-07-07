using Chamber8.Framework.Messaging;
using Moon.Hub;
using NaughtyAttributes;
using TMPro;
using UnityEngine;

namespace Moon.Diagnostics
{
	public class DiagnosticsBoard : MonoBehaviour
	{
		[SerializeField]
		private ManualButton _btnDiagnostic;

		[SerializeField]
		private ProgressBar _progressBar;

		[SerializeField]
		private TMP_Text _text;

		private IMessageSubscriber? _subscriber;

		private bool _readyToSend;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		[Button(null, EButtonEnableMode.Always)]
		private void HandleBtnDiagnosticPressed()
		{
		}

		private void ReadyToSend()
		{
		}

		private int HandleSendDiagProgress(IMessage<SendDiagProgressMessage> message)
		{
			return 0;
		}
	}
}

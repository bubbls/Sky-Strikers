using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Moon
{
	public class LocalPlayerHandDebugVisualizer : MonoBehaviour
	{
		private static LocalPlayerHandDebugVisualizer _instance;

		[SerializeField]
		private TMP_Text _debugText;

		[SerializeField]
		private GameObject _debugCanvas;

		[SerializeField]
		private InputActionAsset _debugInputActions;

		[SerializeField]
		private InputActionReference _toggleDebugCanvasAction;

		private Dictionary<string, string> _debugInfos;

		private bool _hasTextUpdatePending;

		private void Awake()
		{
		}

		private void LateUpdate()
		{
		}

		private void OnDestroy()
		{
		}

		private void ToggleDebugCanvas(InputAction.CallbackContext ctx)
		{
		}

		public static void UpdateInfo(string key, string value)
		{
		}

		private void UpdateText()
		{
		}
	}
}

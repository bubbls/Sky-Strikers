using RuntimeInspectorNamespace;
using UnityEngine;
using UnityEngine.UI;
using VRKeys;

namespace Moon
{
	public class VRRuntimeInspectorFieldCreationInjector : MonoBehaviour
	{
		[SerializeField]
		private Keyboard _vrKeyboard;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void HandleNewInspectorFieldCreated(InspectorField inspectorField)
		{
		}

		private void HandleInputFieldFocused(InputField inputField)
		{
		}
	}
}

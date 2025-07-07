using UnityEngine;

namespace Moon.Hub
{
	public class ManualButtonVisual : MonoBehaviour
	{
		[SerializeField]
		private ManualButton _btn;

		[SerializeField]
		private MeshRenderer _meshRenderer;

		[SerializeField]
		private Material _materialEnabled;

		[SerializeField]
		private Material _materialDisabled;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Start()
		{
		}

		private void HandleEnabled()
		{
		}
	}
}

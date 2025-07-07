using UnityEngine;

namespace Moon.Hub
{
	public class ManualToggleVisual : MonoBehaviour
	{
		[SerializeField]
		private ManualToggle _toggle;

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

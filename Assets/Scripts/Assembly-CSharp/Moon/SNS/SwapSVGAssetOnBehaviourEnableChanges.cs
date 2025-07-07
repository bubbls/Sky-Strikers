using SVGImporter;
using UnityEngine;

namespace Moon.SNS
{
	public class SwapSVGAssetOnBehaviourEnableChanges : MonoBehaviour
	{
		[SerializeField]
		private EnableBehaviour _enableBehaviour;

		[SerializeField]
		private SVGRenderer _renderer;

		[SerializeField]
		private SVGAsset _enableAsset;

		[SerializeField]
		private SVGAsset _disableAsset;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void HandleBehaviourEnableChanges()
		{
		}
	}
}

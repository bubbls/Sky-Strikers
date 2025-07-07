using UnityEngine;

namespace Moon.Player.Ability.Jetstream
{
	public class ProgressIndicatorMaterialFill : ProgressIndicator
	{
		[SerializeField]
		private MeshRenderer[] _fillMeshes;

		[SerializeField]
		private string _fillProperty;

		private int _cachedFillProperty;

		private Material[] _instancedMaterials;

		private bool _isInitialized;

		private void TryInitialize()
		{
		}

		private void OnDestroy()
		{
		}

		public override void SetProgress(float progress)
		{
		}
	}
}

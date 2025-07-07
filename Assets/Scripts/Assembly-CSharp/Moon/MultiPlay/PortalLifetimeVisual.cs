using UnityEngine;

namespace Moon.MultiPlay
{
	public class PortalLifetimeVisual : MonoBehaviour
	{
		[SerializeField]
		private Material _targetMaterial;

		[SerializeField]
		private AnimationCurve _lifetimeShaderValueCurve;

		[SerializeField]
		private MeshRenderer[] _portalMeshRenderers;

		[SerializeField]
		private float _portalLifetimeLerpSpeed;

		[SerializeField]
		private string _shaderPropertyToChange;

		private Material _material;

		private bool _instantiatedMaterials;

		private float _targetDoorSwitchValue;

		private float _curDoorSwitchValue;

		private int _shaderPropId;

		public void SetupMaterials()
		{
		}

		public void ForceSetCurrentAndTargetDoorSwitchValue(float value)
		{
		}

		public void SetTargetDoorSwitchValue(float remainingLifetime)
		{
		}

		private void LateUpdate()
		{
		}

		private void OnDestroy()
		{
		}

		public void TryDestroyMaterial()
		{
		}
	}
}

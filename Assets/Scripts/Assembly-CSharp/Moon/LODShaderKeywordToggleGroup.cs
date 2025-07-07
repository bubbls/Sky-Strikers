using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using NaughtyAttributes;
using UnityEngine;

namespace Moon
{
	public class LODShaderKeywordToggleGroup : GameObjectLODListener
	{
		[Serializable]
		private class SimplifiedRendererPair
		{
			public Material Material;

			public List<Renderer> Renderers;
		}

		private const string ShaderKeyword = "_SIMPLIFIEDON_ON";

		[SerializeField]
		private List<SimplifiedRendererPair> _simplifiedRendererPairs;

		[SerializeField]
		[Header("Editor Only")]
		private GameObject[] _objsToFindAllRenderers;

		[SerializeField]
		private bool _includeMeshRenderers;

		[SerializeField]
		private bool _includeParticleRenderers;

		private HashSet<Material> _instancedMaterials;

		private bool _isInitialized;

		private void Initialize()
		{
		}

		private void OnDestroy()
		{
		}

		protected override void ActivateLODStateInternal()
		{
		}

		protected override void DeactivateLODStateInternal()
		{
		}

		private void ToggleKeyword(bool toggleOn)
		{
		}

		[UsedImplicitly]
		[Button("Find All Renderers", EButtonEnableMode.Always)]
		private void FindAllRenderers()
		{
		}

		private void SetSimplifiedUniqueMaterials(List<Renderer> renderers)
		{
		}
	}
}

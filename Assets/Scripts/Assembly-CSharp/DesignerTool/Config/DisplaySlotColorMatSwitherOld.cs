using System.Collections.Generic;
using UnityEngine;

namespace DesignerTool.Config
{
	public class DisplaySlotColorMatSwitherOld : MonoBehaviour
	{
		private bool _isInitialized;

		public GameObject downPos;

		public GameObject upPos;

		[Space(10f)]
		public bool _isTest;

		public float globalDissolveSpeed;

		public float globalDissolveIntervals;

		public Texture2D globalDissolveNoiseTexture;

		public float globalDissolveNoiseTiling;

		[Range(0f, 10f)]
		public float globalDissolveNoiseFalloff;

		public float globalDissolveSoft;

		[Space(10f)]
		public Color globalEdgeColor;

		[Range(0f, 0.5f)]
		public float globalEdgeWidth;

		[Header("Buying")]
		public Color buyingColor;

		[Range(0f, 1f)]
		public float buyingInt;

		[SerializeField]
		[Space(10f)]
		protected List<Renderer> renderers;

		[SerializeField]
		private List<Material> _Materials;

		private List<MaterialPropertyBlock> _propertyBlocks;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void Initialize()
		{
		}

		private void IsInitialized()
		{
		}

		public void AddRenderer(Renderer[] renderers)
		{
		}

		public void ResetRenderers()
		{
		}
	}
}

using System.Collections.Generic;
using UnityEngine;

namespace Moon.Shop.Mirror
{
	public class ShopMirror : MonoBehaviour
	{
		private const string ShaderFeatureShownOn = "_ShownOn";

		[SerializeField]
		private List<Renderer> _mirrorRenderers;

		private void Start()
		{
		}
	}
}

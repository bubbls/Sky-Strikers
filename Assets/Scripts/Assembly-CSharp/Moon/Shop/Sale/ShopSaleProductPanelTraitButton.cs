using System;
using System.Runtime.CompilerServices;
using DP.Takeaway.VisualScripting;
using SVGImporter;
using UnityEngine;

namespace Moon.Shop.Sale
{
	[RequireComponent(typeof(CustomEventHandler))]
	public class ShopSaleProductPanelTraitButton : MonoBehaviour
	{
		[SerializeField]
		private SVGRenderer _renderer;

		private int _index;

		public event Action<int> OnButtonPressed
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void Start()
		{
		}

		public void SetIcon(SVGAsset asset)
		{
		}

		private void HandleButtonPressed(string btnName)
		{
		}
	}
}

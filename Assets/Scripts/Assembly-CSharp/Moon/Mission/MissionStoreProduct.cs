using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace Moon.Mission
{
	public class MissionStoreProduct : MonoBehaviour
	{
		[Serializable]
		private class StateColors
		{
			public Color NormalColor;

			public Color DisabledColor;
		}

		[SerializeField]
		private MissionStoreProductDataDefinition _storeProductDataDefinition;

		[SerializeField]
		private TMP_Text _titleText;

		[SerializeField]
		private TMP_Text _infoText;

		[SerializeField]
		private TMP_Text _priceText;

		[SerializeField]
		private TMP_Text _buttonText;

		[SerializeField]
		private MeshRenderer _buttonMeshRender;

		[SerializeField]
		private BoxCollider _buttonBoxCollider;

		[SerializeField]
		private StateColors _buttonStateColors;

		private MissionStoreProductData _productData;

		private const float DisplayInfoResetTime = 3f;

		public MissionStoreProductData ProductData => null;

		public event Action<MissionStoreProduct> RequestPurchase
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

		public void Initialize()
		{
		}

		private void HandleOnButtonPressed(string buttonName)
		{
		}

		public void SetProductAsRedeemed()
		{
		}

		public void UpdateDisplayInfo(string message)
		{
		}

		private void ResetDisplayInfo()
		{
		}
	}
}

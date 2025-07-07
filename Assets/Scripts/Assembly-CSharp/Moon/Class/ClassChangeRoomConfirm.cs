using System;
using System.Runtime.CompilerServices;
using SVGImporter;
using UnityEngine;
using UnityEngine.UI;

namespace Moon.Class
{
	public class ClassChangeRoomConfirm : MonoBehaviour
	{
		[SerializeField]
		private SVGImage _backgroundSvgImage;

		[SerializeField]
		private SVGAsset _svgBgAsset;

		[SerializeField]
		private SVGAsset _svgBgOffAsset;

		[SerializeField]
		private Image _classIconImage;

		[SerializeField]
		private Sprite[] _svgAssets;

		[SerializeField]
		private float _unselectedAlpha;

		[SerializeField]
		private PlayerSuitClass _suitClass;

		[SerializeField]
		private HandHoldPressButton _holdPressButton;

		private bool? _selected;

		private float _originDepth;

		public PlayerSuitClass SuitClass => default(PlayerSuitClass);

		public event Action<PlayerSuitClass> OnConfirmed
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

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void HandleOnHoldPressComplete()
		{
		}

		public void DeSelect()
		{
		}

		public void Select(bool value)
		{
		}

		public void ChangeColor(int index)
		{
		}

		private void SetAlpha(bool selected)
		{
		}
	}
}

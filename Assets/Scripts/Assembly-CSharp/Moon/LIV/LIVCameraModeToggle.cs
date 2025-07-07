using System;
using System.Runtime.CompilerServices;
using SVGImporter;
using TMPro;
using UnityEngine;

namespace Moon.LIV
{
	public class LIVCameraModeToggle : LIVToggle
	{
		[SerializeField]
		private LIVCameraMode _cameraMode;

		[SerializeField]
		private MeshRenderer _meshRenderer;

		[SerializeField]
		private ColorConfig _modelColorConfig;

		[SerializeField]
		private SVGImage _icon;

		[SerializeField]
		private ColorConfig _iconColorConfig;

		[SerializeField]
		private TMP_Text _text;

		[SerializeField]
		private ColorConfig _textColorConfig;

		private static readonly int _baseColor;

		public event Action<LIVCameraMode> OnToggled
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

		protected override void HandleOnToggled()
		{
		}

		protected override void UpdateVisuals(bool isOn)
		{
		}
	}
}

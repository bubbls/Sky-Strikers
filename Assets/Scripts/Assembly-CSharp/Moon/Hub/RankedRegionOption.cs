using System;
using System.Runtime.CompilerServices;
using SVGImporter;
using TMPro;
using UnityEngine;

namespace Moon.Hub
{
	public class RankedRegionOption : MonoBehaviour
	{
		[SerializeField]
		private ManualButton _manualButton;

		[SerializeField]
		private MeshRenderer _buttonMesh;

		[SerializeField]
		private Material _buttonSelectedMaterial;

		[SerializeField]
		private Material _buttonDeselectedMaterial;

		[SerializeField]
		private SVGImage _bg;

		[SerializeField]
		private SVGAsset _bgSelectedAsset;

		[SerializeField]
		private SVGAsset _bgDeselectedAsset;

		[SerializeField]
		private Color _iconSelectedColor;

		[SerializeField]
		private Color _iconDeselectedColor;

		[SerializeField]
		private SVGImage _iconImage;

		[SerializeField]
		private SVGAsset _iconSelectedAsset;

		[SerializeField]
		private SVGAsset _iconDeselectedAsset;

		[SerializeField]
		private TMP_Text _regionName;

		[SerializeField]
		private TMP_Text _regionPing;

		public bool IsSelected { get; private set; }

		public event Action<RankedRegionOption> OnButtonValueChanged
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

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void Configure(string region)
		{
		}

		public void UpdateLatency(int latency)
		{
		}

		private void Handle_OnPressed()
		{
		}

		private void UpdateBasedOnState()
		{
		}

		public void ForceState(bool isSelected)
		{
		}
	}
}

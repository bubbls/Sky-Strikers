using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Moon.Hub
{
	[ExecuteInEditMode]
	public class ToggleGroup : MonoBehaviour
	{
		[SerializeField]
		private List<ManualToggle> _toggles;

		public ManualToggle SelectedToggle => null;

		public event Action OnValueChanged
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

		private void RegisterEventListener(bool register)
		{
		}

		private void NotifyValueChanged(ManualToggle toggle)
		{
		}

		public void SetSelectedToggle(ManualToggle toggle)
		{
		}

		public void SetEnable(bool b)
		{
		}
	}
}

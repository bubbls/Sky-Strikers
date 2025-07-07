using System;
using System.Runtime.CompilerServices;
using DP.Takeaway.Runtime;
using Moon.Arena;
using UnityEngine;

namespace Moon.Hub
{
	public class FieldSelector : MonoBehaviour
	{
		[Serializable]
		private class FieldLookup : SerializableDictionary<ManualToggle, FieldType>
		{
		}

		[SerializeField]
		private ToggleGroup _toggleGroup;

		[SerializeField]
		private FieldLookup _fieldLookup;

		public FieldType SelectedFieldType { get; private set; }

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

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnToggleGroupValueChanged()
		{
		}

		public void SetSelectedField(FieldType targetFieldType)
		{
		}

		public void SetEnable(bool b)
		{
		}
	}
}

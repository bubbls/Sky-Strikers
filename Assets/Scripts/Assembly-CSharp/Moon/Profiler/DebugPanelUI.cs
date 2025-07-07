using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Moon.Profiler
{
	public class DebugPanelUI : MonoBehaviour, IDebugPanelDrawContext
	{
		[FormerlySerializedAs("_Root")]
		[SerializeField]
		private Canvas _root;

		[SerializeField]
		private VRInspectMode _vrInspectMode;

		[FormerlySerializedAs("_InputNode")]
		[SerializeField]
		private GameObject _inputNode;

		[FormerlySerializedAs("_OffsetNode")]
		[SerializeField]
		private Transform _offsetNode;

		[FormerlySerializedAs("_ScaleNode")]
		[SerializeField]
		private Transform _scaleNode;

		[FormerlySerializedAs("_LeftPanel")]
		[SerializeField]
		private GameObject _leftPanel;

		[FormerlySerializedAs("_Content")]
		[SerializeField]
		private RectTransform _content;

		[FormerlySerializedAs("_RightView")]
		[SerializeField]
		private ScrollRect _rightView;

		[FormerlySerializedAs("_Title")]
		[SerializeField]
		private Text _title;

		[FormerlySerializedAs("_Tips")]
		[SerializeField]
		private Text _tips;

		[FormerlySerializedAs("_TmpLeftBtn")]
		[SerializeField]
		private GameObject _tmpLeftBtn;

		[FormerlySerializedAs("_TmpContentColumn")]
		[SerializeField]
		private GameObject _tmpContentColumn;

		[FormerlySerializedAs("_TmpContentBtn")]
		[SerializeField]
		private GameObject _tmpContentBtn;

		[FormerlySerializedAs("_TmpContentCheckbox")]
		[SerializeField]
		private GameObject _tmpContentCheckbox;

		[SerializeField]
		[FormerlySerializedAs("_TmpContentCombobox")]
		private GameObject _tmpContentCombobox;

		[FormerlySerializedAs("_TmpContentSlider")]
		[SerializeField]
		private GameObject _tmpContentSlider;

		[SerializeField]
		[FormerlySerializedAs("_TmpContentText")]
		private GameObject _tmpContentText;

		[SerializeField]
		[FormerlySerializedAs("_TmpContentInput")]
		private GameObject _tmpContentInput;

		[FormerlySerializedAs("_TmpContentRawImage")]
		[SerializeField]
		private GameObject _tmpContentRawImage;

		[SerializeField]
		[FormerlySerializedAs("_TmpContentEmptyLine")]
		private GameObject _tmpContentEmptyLine;

		[SerializeField]
		private InputActionReference _triggerInput;

		private bool _activated;

		private DebugPanelEntryNode _nodes;

		private DebugPanelEntryNode _current;

		private Coroutine _debouncingTrigger;

		private bool _samelineFlag;

		private float _nextWidthFlag;

		private float _labelWidthFlag;

		public Canvas Root => null;

		public Transform OffsetNode => null;

		public Transform InputNode => null;

		public void AddPanel(IDebugPanelInterface panel, bool active = false)
		{
		}

		public void RemovePanel(IDebugPanelInterface panel)
		{
		}

		public void EnableScroll(bool enable)
		{
		}

		public void CloseUi()
		{
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

		private void RefreshOffsetNode()
		{
		}

		private void HandleInputActionToggle(InputAction.CallbackContext context)
		{
		}

		private DebugPanelEntryNode AddNode(DebugPanelEntryNode current, string subName, bool isTail, IDebugPanelInterface panel)
		{
			return null;
		}

		private void ResortItems()
		{
		}

		private GameObject CreateLeftButton(string name, int offset, out Button btn, out Text corner)
		{
			btn = null;
			corner = null;
			return null;
		}

		private void OnClickLeft(DebugPanelEntryNode panel)
		{
		}

		private RectTransform GetLineNode(float MinHeight)
		{
			return null;
		}

		private void ClearFlags()
		{
		}

		private Text RawText(string content, int MaxLine, float labelHeightFlag)
		{
			return null;
		}

		public IDebugPanelDrawContext SameLine()
		{
			return null;
		}

		public IDebugPanelDrawContext NextWidth(float width)
		{
			return null;
		}

		public IDebugPanelDrawContext EmptyLine(float width = 10f)
		{
			return null;
		}

		public IDebugPanelDrawContext Padding(float width)
		{
			return null;
		}

		public IDebugPanelDrawContext LabelWidth(float width)
		{
			return null;
		}

		public void Text(string text, int MaxLine = 1)
		{
		}

		public void Text(TextGetter text, int MaxLine = 1)
		{
		}

		public void Button(string text, UnityAction cb)
		{
		}

		public void Button(TextGetter text, UnityAction cb)
		{
		}

		public void CheckBox(string text, bool defaultValue, UnityAction<bool> onChanged)
		{
		}

		public void ComboBox(string label, List<string> datas, int defaultValue, UnityAction<int> onChanged)
		{
		}

		public void ComboBox<T>(string label, T defValue, UnityAction<T> onChanged) where T : Enum
		{
		}

		public void Slider(string text, float min, float max, float defaultValue, bool useInt, UnityAction<float> onChanged)
		{
		}

		public void SliderWithFunction(string text, float min, float max, float defaultValue, EaseFunc func, UnityAction<float> onChanged)
		{
		}

		public void TextInput(string text, string defaultValue, UnityAction<string> onChanged)
		{
		}

		public GameObject RenderTexture(int width, int height, TextureGetter tex)
		{
			return null;
		}
	}
}

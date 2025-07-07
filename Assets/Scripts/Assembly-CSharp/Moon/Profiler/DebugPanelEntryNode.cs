using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Moon.Profiler
{
	public class DebugPanelEntryNode : IComparable<DebugPanelEntryNode>
	{
		private bool _isExpand;

		private bool _isActive;

		private string _fullpath;

		private int _layer;

		private IDebugPanelInterface _dp;

		private GameObject _root;

		private Text _corner;

		private Button _btn;

		private ColorBlock _normalColor;

		private ColorBlock _activeColor;

		private Dictionary<string, DebugPanelEntryNode> _children;

		public GameObject Btn => null;

		public string FullPath => null;

		public int Layer => 0;

		public bool IsExpand
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsActive
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int ChildrenCount => 0;

		public IDebugPanelInterface Panel
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public DebugPanelEntryNode GetChild(string subName)
		{
			return null;
		}

		public DebugPanelEntryNode GetChildFromPanel(IDebugPanelInterface dp)
		{
			return null;
		}

		public DebugPanelEntryNode AddChild(string subName, IDebugPanelInterface dp, GameObject root, Button btn, Text corner)
		{
			return null;
		}

		public bool RemoveChild(DebugPanelEntryNode node)
		{
			return false;
		}

		public void ClickNode(DebugPanelEntryNode node)
		{
		}

		public bool IsChildOf(DebugPanelEntryNode node)
		{
			return false;
		}

		public int CompareTo(DebugPanelEntryNode other)
		{
			return 0;
		}

		public void CollapseAllChildren()
		{
		}

		public List<DebugPanelEntryNode> Fill(List<DebugPanelEntryNode> lst)
		{
			return null;
		}
	}
}

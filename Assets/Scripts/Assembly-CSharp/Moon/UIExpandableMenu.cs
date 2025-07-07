using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Moon
{
	public class UIExpandableMenu : MonoBehaviour
	{
		[SerializeField]
		private LayoutElement _layoutElement;

		[SerializeField]
		private Vector2 _collapsedSize;

		[SerializeField]
		private Vector2 _expandedSize;

		[SerializeField]
		private float _expandDuration;

		[SerializeField]
		private bool _expandX;

		[SerializeField]
		private bool _expandY;

		private Sequence _sequence;

		private void OnDestroy()
		{
		}

		public void Expand(Action onExpandComplete)
		{
		}

		public void Collapse(Action onCollapseComplete)
		{
		}

		public void ExpandInstantly()
		{
		}

		public void CollapseInstantly()
		{
		}

		private void ApplySize(Vector2 size)
		{
		}

		private float CalculateDuration(float currentSize, float targetStartSize, float targetEndSize, float maxDuration)
		{
			return 0f;
		}
	}
}

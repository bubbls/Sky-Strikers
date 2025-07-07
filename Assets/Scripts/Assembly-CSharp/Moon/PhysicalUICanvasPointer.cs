using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Moon
{
	public class PhysicalUICanvasPointer : MonoBehaviour
	{
		[SerializeField]
		private float _raycastLength;

		[SerializeField]
		private LayerMask _uiLayer;

		[SerializeField]
		private Transform? _pointerPoint;

		private GameObject? _currTarget;

		private PointerEventData? _cachedPointerEventData;

		private int _pointerIndex;

		public float RaycastLength => 0f;

		public LayerMask UILayer => default(LayerMask);

		public Transform? PointerPoint => null;

		public bool IsPointerOnCanvas { get; private set; }

		public event Action? OnEnterCanvas
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

		public event Action? OnExitCanvas
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

		public event Action<GameObject>? OnPress
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

		public event Action<GameObject>? OnRelease
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

		public event Action<GameObject>? OnClick
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

		public event Action<PointerEventData, float>? OnPointerUpdated
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

		protected virtual void HandleOnEnableInternal()
		{
		}

		private void OnDisable()
		{
		}

		protected virtual void HandleOnDisableInternal()
		{
		}

		private void LateUpdate()
		{
		}

		internal void SetIndex(int index)
		{
		}

		public void Click()
		{
		}

		public void Press()
		{
		}

		public void Release()
		{
		}

		private void UpdatePointer()
		{
		}
	}
}

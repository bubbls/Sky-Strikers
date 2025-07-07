using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Moon
{
	[RequireComponent(typeof(EventSystem))]
	public class PhysicalUIInputModule : BaseInputModule
	{
		private readonly List<PhysicalUICanvasPointer> _pointers;

		private PointerEventData[]? _eventDataCollection;

		private readonly List<RaycastResult> _validResultsCache;

		private GameObject? _curRaycastObject;

		private static PhysicalUIInputModule? _instance;

		private Camera _cam;

		public static PhysicalUIInputModule? Instance => null;

		public Camera UICamera => null;

		private void CreateCamera()
		{
		}

		protected override void Awake()
		{
		}

		public int AddPointer(PhysicalUICanvasPointer pointer)
		{
			return 0;
		}

		public void RemovePointer(PhysicalUICanvasPointer pointer)
		{
		}

		public override void Process()
		{
		}

		private void Preprocess(Transform targetTransform)
		{
		}

		public GameObject ProcessClick(int index)
		{
			return null;
		}

		public GameObject ProcessPress(int index)
		{
			return null;
		}

		public GameObject ProcessRelease(int index)
		{
			return null;
		}

		public PointerEventData GetData(int index)
		{
			return null;
		}
	}
}

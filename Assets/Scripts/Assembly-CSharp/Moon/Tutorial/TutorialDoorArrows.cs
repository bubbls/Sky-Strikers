using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

namespace Moon.Tutorial
{
	public class TutorialDoorArrows : MonoBehaviour
	{
		[SerializeField]
		private List<GameObject> _arrows;

		[SerializeField]
		private float _arrowDuration;

		private Sequence _sequence;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}
	}
}

using System;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using moveen.descs;

namespace Moon.GameActivity.Behaviors
{
	public class SipletsSuckerPipeController : MonoBehaviour
	{
		[Serializable]
		private class Pipe
		{
			[SerializeField]
			private MeshRenderer _meshRenderer;

			[SerializeField]
			private float _delay;

			[SerializeField]
			private float _widthAmount;

			[SerializeField]
			private bool _direction;

			[SerializeField]
			private float _fillTimeMultiplier;

			[SerializeField]
			private MoveenSkelBezier _bezier;

			private Material _material;

			private float _width;

			private float _move;

			public void Initialize()
			{
			}

			public void PlayFx(Sequence sequence, float fillTime, IReadOnlyList<GameObject> fracts)
			{
			}

			private void UpdateVisual(IReadOnlyList<GameObject> fracts)
			{
			}

			private void UpdateFracts(Transform fracts, float offset)
			{
			}
		}

		[SerializeField]
		private float _fillTime;

		[SerializeField]
		private GameObject _prefabFracts;

		[SerializeField]
		private List<Pipe> _pipes;

		private Sequence _sequence;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		[ContextMenu("Moon/Sucker/Pipe PlayFx")]
		public void PlayFx()
		{
		}
	}
}

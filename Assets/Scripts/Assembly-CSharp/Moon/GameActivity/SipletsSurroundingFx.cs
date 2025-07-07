using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;

namespace Moon.GameActivity
{
	public class SipletsSurroundingFx : MonoBehaviour
	{
		[SerializeField]
		private GameObject _root;

		[SerializeField]
		private TMP_Text _textNumber;

		[SerializeField]
		private List<GameObject> _fragments;

		[SerializeField]
		private MeshRenderer _circleRenderer;

		[SerializeField]
		private float _minAlpha;

		[SerializeField]
		private float _maxAlpha;

		private Material _material;

		private Tween _tween;

		private Tween _textNumberTween;

		private static readonly int _paramAlpha;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public void SetAmount(int amount)
		{
		}
	}
}

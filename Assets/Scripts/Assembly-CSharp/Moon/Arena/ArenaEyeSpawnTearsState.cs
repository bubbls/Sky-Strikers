using DG.Tweening;
using UnityEngine;

namespace Moon.Arena
{
	public class ArenaEyeSpawnTearsState : MonoBehaviour
	{
		[SerializeField]
		private MeshRenderer _eyeballMeshRenderer;

		[SerializeField]
		private Transform _eyeTransform;

		[SerializeField]
		private int _defaultXEuler;

		[SerializeField]
		private int _rotateOffset;

		private static readonly int _albedoColor;

		private Tween _eyeColorTween;

		private Sequence _sequence;

		private bool _isAnimating;

		private int _eyeBallContainerRotationIndex;

		public void Animate(bool animateIn)
		{
		}

		private void KillTweens()
		{
		}

		private void OnDestroy()
		{
		}

		public void Reset()
		{
		}
	}
}

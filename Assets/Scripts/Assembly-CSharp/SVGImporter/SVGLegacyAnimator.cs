using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace SVGImporter
{
	[RequireComponent(typeof(SVGRenderer))]
	public class SVGLegacyAnimator : MonoBehaviour
	{
		[Serializable]
		public class OnCompleteEvent : UnityEvent<SVGLegacyAnimator>
		{
		}

		public enum WrapMode
		{
			ONCE = 0,
			LOOP = 1,
			PING_PONG = 2
		}

		public SVGAsset[] frames;

		public WrapMode wrapMode;

		public bool playOnAwake;

		public float duration;

		public float timeScale;

		public bool direction;

		public int loops;

		public int currentLoop;

		public bool rewind;

		public float progress;

		[FormerlySerializedAs("onComplete")]
		[SerializeField]
		protected OnCompleteEvent m_onComplete;

		protected bool _isPlaying;

		protected SVGRenderer svgRenderer;

		public OnCompleteEvent onComplete
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool isPlaying => false;

		public float normalizedProgress => 0f;

		public void Play()
		{
		}

		public void Stop()
		{
		}

		public void Pause()
		{
		}

		public void Restart()
		{
		}

		protected virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		public void UpdateMesh()
		{
		}

		private void AnimationEnded()
		{
		}
	}
}

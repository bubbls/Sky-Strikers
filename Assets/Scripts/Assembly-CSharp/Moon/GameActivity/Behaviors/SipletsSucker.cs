using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening;
using DP.Takeaway.FX;
using UnityEngine;
using UnityEngine.Scripting;
using moveen.descs;

namespace Moon.GameActivity.Behaviors
{
	public class SipletsSucker : MonoBehaviour
	{
		public enum Emoji
		{
			None = 0,
			Normal = 1,
			Happy = 2,
			Satisfied = 3
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CTestTransformSipletsInternal_003Ed__24 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public GameObject sender;

			public string eventComplete;

			private TaskAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		private static readonly int _paramMainTex;

		[SerializeField]
		private Transform _bodyTarget;

		[SerializeField]
		private Transform _spawnPoint;

		[SerializeField]
		private GameObject _suckerRoot;

		[SerializeField]
		private MoveenStepper5 _sucker;

		[SerializeField]
		private Transform _sipletStar;

		[SerializeField]
		private Texture2D[] _texHappyEyes;

		[SerializeField]
		private Texture2D _texNormalEye;

		[SerializeField]
		private Texture2D _texSatisfied;

		[SerializeField]
		private Animation _happyAnimation;

		[SerializeField]
		private LightIntensityController _lightController;

		[SerializeField]
		private Material _eyeMaterial;

		private Tween _sipletStarTween;

		private Emoji _lastEmoji;

		private void OnDestroy()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		[Preserve]
		public bool TransformSiplets(GameObject sender, MPlayer player, string eventComplete)
		{
			return false;
		}

		[Preserve]
		public void TeleportBack()
		{
		}

		[Preserve]
		public void ToggleEmoji(Emoji emoji)
		{
		}

		[Preserve]
		public void PlayFxTransferDataToLeaderboard(int sipletsBalance)
		{
		}

		private void HandleLightIntensityChanged(float intensity)
		{
		}

		private void BlinkHappyEyes(float value)
		{
		}

		[AsyncStateMachine(typeof(_003CTestTransformSipletsInternal_003Ed__24))]
		private static void TestTransformSipletsInternal(GameObject sender, MPlayer player, string eventComplete)
		{
		}

		private static bool TransformSipletsInternal(GameObject sender, MPlayer player, string eventComplete)
		{
			return false;
		}
	}
}

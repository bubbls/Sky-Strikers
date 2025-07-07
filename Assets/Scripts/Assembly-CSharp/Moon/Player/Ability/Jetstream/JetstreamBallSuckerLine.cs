using UnityEngine;

namespace Moon.Player.Ability.Jetstream
{
	public class JetstreamBallSuckerLine : MonoBehaviour
	{
		private static readonly int _ballPosition;

		[SerializeField]
		private MeshRenderer[] _lineMeshRenderer;

		private bool _isInitialized;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public void ShowLine()
		{
		}

		public void UpdateBallPosition(Vector3 ballPosition)
		{
		}

		public void HideLine()
		{
		}

		private void SetBallPositionInMaterials(Vector3 ballPosition)
		{
		}
	}
}

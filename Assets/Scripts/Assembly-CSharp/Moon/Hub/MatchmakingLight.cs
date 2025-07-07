using Chamber8.Framework.Messaging;
using DP.Takeaway.FX;
using UnityEngine;

namespace Moon.Hub
{
	public class MatchmakingLight : MonoBehaviour
	{
		[SerializeField]
		private MeshRenderer _lightRenderer;

		[SerializeField]
		private LightIntensityController _lightCtrl;

		[SerializeField]
		private Color _offColor;

		[SerializeField]
		private Color _onlineAColor;

		[SerializeField]
		private Color _onlineBColor;

		[SerializeField]
		private Color _offlineColor;

		[SerializeField]
		private Color _failedColor;

		private static readonly int _paramBaseColor;

		private Material _material;

		private Color _lightColor;

		private IMessageSubscriber _subscriber;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private int HandleMatchmakingStatusUpdate(IMessage<object> arg)
		{
			return 0;
		}

		private void HandleIntensityChanged(float intensity)
		{
		}

		private void UpdateMatchmakingStatus()
		{
		}
	}
}

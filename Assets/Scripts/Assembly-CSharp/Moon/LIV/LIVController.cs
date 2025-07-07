using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Chamber8.Framework.Common;
using Chamber8.Framework.Messaging;
using UnityEngine;

namespace Moon.LIV
{
	public class LIVController : SingleMonoBehaviour<LIVController, NoResourceSingleMonoBehaviourSettings>
	{
		private static bool _instanceCreated;

		[SerializeField]
		private LIVCameraLocalGrabbable _livCameraLocalGrabbable;

		[Header("LIV SDK")]
		[SerializeField]
		private LIVServiceHelper _livServiceHelper;

		[SerializeField]
		private LIVCameraController _livCameraController;

		[Header("LIV Visuals")]
		[SerializeField]
		private List<GameObject> _visuals;

		private IMessageSubscriber[] _subscribers;

		private LivCameraAttachPoint _currentAttachPoint;

		public new static bool HasInstance => false;

		public LIVCameraLocalGrabbable LivCameraLocalGrabbable => null;

		public LIVCameraController LivCameraController => null;

		public static bool IsInitialized { get; private set; }

		public LivCameraAttachPoint CurrentAttachPoint
		{
			get
			{
				return default(LivCameraAttachPoint);
			}
			private set
			{
			}
		}

		public static event Action OnLivControllerInitialized
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

		public event Action OnForcePlacedInWorld
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

		public event Action OnPutBackOnBodyBracket
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

		public event Action<LivCameraAttachPoint> OnAttachPointChanged
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

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public void PutCameraOnBodyBracket()
		{
		}

		public void ToggleLivCameraVisuals(bool enable)
		{
		}

		private void OnEnable()
		{
		}

		private void LivCameraLocalGrabbable_OnGrabbed()
		{
		}

		private void OnDisable()
		{
		}

		private int HandleGeneralMessage(IMessage<GeneralMessage> message)
		{
			return 0;
		}

		private void HandleOnLeftCameraArea()
		{
		}

		private int HandleMPlayerSpawnedMessage(IMessage<MPlayer> message)
		{
			return 0;
		}

		public void Place(Vector3 position, Vector3 forward)
		{
		}

		public void PutCameraOnBracket(Vector3 position, Quaternion rotation)
		{
		}
	}
}

using Chamber8.Framework.Common;
using Moon.Arena;
using NaughtyAttributes;
using UnityEngine;

namespace Moon.Bootstrap
{
	[DefaultExecutionOrder(-40)]
	public class InSceneNetworkConfiguration : SingleMonoBehaviour<InSceneNetworkConfiguration, InSceneNetworkConfigurationSettings>
	{
		public enum Mode
		{
			Host = 0,
			Client = 1,
			AutoHostOrClient = 2
		}

		private static bool _instanceCreated;

		private static bool _triedToCreateInstance;

		[ShowIf("ShowFieldTypeInEditor")]
		[Header("=== Field Type ===")]
		[SerializeField]
		private FieldType _fieldType;

		[Header("=== Photon Region ===")]
		[SerializeField]
		private PhotonRegion.Code _photonRegion;

		[SerializeField]
		private string _sessionId;

		[Header("=== Photon Mode ===")]
		[ShowIf("ShowHostClientOption")]
		[SerializeField]
		private bool _useHostClientMode;

		[ShowIf(EConditionOperator.And, new string[] { "ShowHostClientOption", "_useHostClientMode" })]
		[SerializeField]
		private Mode _hostClientMode;

		[SerializeField]
		[Header("=== PlayFab ===")]
		[ShowIf("ShowConnectDedicatedServerOption")]
		private bool _connectDedicatedServerDirectly;

		[Header("=== Settings ===")]
		[SerializeField]
		private bool _unlimitedAmmo;

		public new static bool HasInstance => false;

		public FieldType FieldType => default(FieldType);

		public PhotonRegion.Code PhotonRegion => default(PhotonRegion.Code);

		public string SessionId => null;

		public bool UseHostClientMode => false;

		public Mode HostClientMode => default(Mode);

		public bool ConnectDedicatedServerDirectly => false;

		public bool UnlimitedAmmo => false;

		private bool ShowHostClientOption()
		{
			return false;
		}

		private bool ShowConnectDedicatedServerOption()
		{
			return false;
		}

		private bool ShowFieldTypeInEditor()
		{
			return false;
		}
	}
}

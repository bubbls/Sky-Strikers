using UnityEngine;

namespace Moon.Framework.Base
{
	[CreateAssetMenu(menuName = "Moon/Create PhotonAppSettings Config", fileName = "Chamber 8 Studio/VR/Create PhotonAppSettings Config")]
	public class PhotonAppSettingsConfig : ScriptableObject
	{
		[SerializeField]
		private PhotonAppSettingsConfigData _data_CN;

		[SerializeField]
		private PhotonAppSettingsConfigData _data_Overseas;

		public PhotonAppSettingsConfigData Data_CN => null;

		public PhotonAppSettingsConfigData Data_Overseas => null;
	}
}

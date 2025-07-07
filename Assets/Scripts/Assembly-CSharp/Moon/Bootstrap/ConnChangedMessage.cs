using Moon.MultiPlay;

namespace Moon.Bootstrap
{
	public class ConnChangedMessage
	{
		public enum CategoryType
		{
			Photon = 0,
			Client = 1
		}

		public CategoryType Category;

		public ConnectionManager.Status PhotonStatus;

		public ClientSharedData.Status ClientStatus;

		public object Payload;
	}
}

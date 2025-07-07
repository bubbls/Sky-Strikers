using Fusion;

namespace Moon.Bootstrap
{
	public struct PhotonConnectResult
	{
		public bool Success;

		public ShutdownReason Error;

		public PhotonConnectResult(bool success, ShutdownReason invalidAuthentication)
		{
			Success = false;
			Error = default(ShutdownReason);
		}
	}
}

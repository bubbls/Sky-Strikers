using Chamber8.Framework.Common;

namespace Moon.Bootstrap
{
	public class InSceneNetworkConfigurationSettings : EmptyPathProvider, ISingleMonoBehaviourSettings, IPathProvider
	{
		public bool DontDestroyOnLoad => false;

		public bool CreateNewOrLoadFromResource => false;
	}
}

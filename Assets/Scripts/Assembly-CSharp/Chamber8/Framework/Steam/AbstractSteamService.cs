using Chamber8.Framework.Core;

namespace Chamber8.Framework.Steam
{
	public abstract class AbstractSteamService : IConditionalCreation
	{
		public bool CreateOnCondition()
		{
			return false;
		}
	}
}

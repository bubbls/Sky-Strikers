using Chamber8.Framework.Core;

namespace Chamber8.Framework.Service.Oculus
{
	public abstract class AbstractOculusService : IConditionalCreation
	{
		public bool CreateOnCondition()
		{
			return false;
		}
	}
}

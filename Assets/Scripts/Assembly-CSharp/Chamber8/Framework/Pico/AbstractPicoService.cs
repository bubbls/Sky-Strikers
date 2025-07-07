using Chamber8.Framework.Core;

namespace Chamber8.Framework.Pico
{
	public abstract class AbstractPicoService : IConditionalCreation
	{
		public bool CreateOnCondition()
		{
			return false;
		}
	}
}

using System.Threading;
using System.Threading.Tasks;

namespace Moon.Bootstrap
{
	public abstract class AbstractAsyncGameCycle : IAsyncGameCycle, IBaseGameCycle
	{
		public virtual bool Background => false;

		public virtual Task Begin(CancellationToken cancellationToken)
		{
			return null;
		}

		public virtual Task End(CancellationToken cancellationToken)
		{
			return null;
		}

		public virtual void Tick(bool isBackground)
		{
		}
	}
}

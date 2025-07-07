using System.Threading;
using System.Threading.Tasks;

namespace Moon.Bootstrap
{
	public interface IAsyncGameCycle : IBaseGameCycle
	{
		Task Begin(CancellationToken cancellationToken);

		Task End(CancellationToken cancellationToken);
	}
}

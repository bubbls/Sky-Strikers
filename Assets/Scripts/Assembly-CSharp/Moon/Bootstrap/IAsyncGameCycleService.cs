using System;
using System.Threading;
using System.Threading.Tasks;

namespace Moon.Bootstrap
{
	public interface IAsyncGameCycleService : IBaseGameCycleService
	{
		Task MoveNextAsync(Type gameCycleType, CancellationToken cancellationToken);

		Task DisposeAsync(CancellationToken cancellationToken);
	}
}

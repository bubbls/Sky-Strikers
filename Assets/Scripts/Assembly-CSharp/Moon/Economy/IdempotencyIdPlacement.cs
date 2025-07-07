using System;

namespace Moon.Economy
{
	internal class IdempotencyIdPlacement
	{
		private Guid _idempotencyId;

		private Guid _allocated;

		public bool TryGet(out Guid idempotencyId)
		{
			idempotencyId = default(Guid);
			return false;
		}

		public void Return(Guid idempotencyId)
		{
		}
	}
}

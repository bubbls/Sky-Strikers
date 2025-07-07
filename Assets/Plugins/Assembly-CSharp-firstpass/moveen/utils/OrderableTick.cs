using moveen.descs;

namespace moveen.utils
{
	public class OrderableTick : IOrderableTick
	{
		public int executionOrder;

		public bool _participateInUpdate;

		public bool _participateInPhysicsUpdate;

		public bool _isBroken;

		public int getOrder()
		{
			return 0;
		}

		public virtual void tick(float dt)
		{
		}

		public virtual void fixedTick(float dt)
		{
		}

		public bool getParticipateInTick()
		{
			return false;
		}

		public bool getParticipateInFixedTick()
		{
			return false;
		}

		public void setExceptionsInTick(bool value)
		{
		}

		public bool getIsExceptionsInTick()
		{
			return false;
		}
	}
}

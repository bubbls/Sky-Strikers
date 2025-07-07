namespace Moon.Framework.Base
{
	public enum WebRequestState : byte
	{
		None = 0,
		Pending = 1,
		Timeout = 2,
		Completed = 3
	}
}

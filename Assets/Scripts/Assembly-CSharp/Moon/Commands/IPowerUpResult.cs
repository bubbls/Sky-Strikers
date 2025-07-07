namespace Moon.Commands
{
	public interface IPowerUpResult
	{
		bool Success { get; }

		int Diff { get; }
	}
}

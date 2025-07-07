namespace Moon.Bootstrap
{
	public interface IBaseGameCycle
	{
		bool Background { get; }

		void Tick(bool inBackground);
	}
}

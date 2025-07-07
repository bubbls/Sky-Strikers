using Chamber8.Framework.Common;

namespace Moon.Mission
{
	public interface IMissionItemUI : IInitializer
	{
		IMissionItemUI Previous { get; set; }

		bool IsFirst { get; set; }

		bool IsLast { get; set; }

		MissionRecord Mission();

		void Render(MissionRecord mission);
	}
}

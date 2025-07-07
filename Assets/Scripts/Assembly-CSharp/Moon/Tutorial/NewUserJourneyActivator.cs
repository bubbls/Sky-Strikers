using Chamber8.Framework.Common;
using Moon.Arena;

namespace Moon.Tutorial
{
	public class NewUserJourneyActivator : Singleton<NewUserJourneyActivator>
	{
		public bool IsTutorialActivated { get; private set; }

		private static bool HasCompletedTutorial => false;

		public bool ShouldActivateTutorial()
		{
			return false;
		}

		public void TryActivateTutorial()
		{
		}

		public void TryCompleteNewUserJourneyIfNoTutorial()
		{
		}

		public bool IsTutorialCompleted()
		{
			return false;
		}

		public void MarkTutorialAndNewUserJourneyDone()
		{
		}

		public FieldType GetStartingScene()
		{
			return default(FieldType);
		}

		public void SetStartingSuit()
		{
		}

		public string GetUserGroup()
		{
			return null;
		}
	}
}

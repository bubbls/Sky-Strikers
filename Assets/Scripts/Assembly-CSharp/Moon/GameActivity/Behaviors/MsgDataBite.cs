using Moon.AI.VisualScripting;

namespace Moon.GameActivity.Behaviors
{
	public class MsgDataBite : NetworkData
	{
		public int PlayerRef;

		public PlayerParts Part;

		public static MsgDataBite CreateBite()
		{
			return null;
		}

		public static MsgDataBite CreateBiteOther()
		{
			return null;
		}

		private MsgDataBite()
		{
		}
	}
}

using UnityEngine;

namespace SVGImporter.Utils
{
	public class SVGViewport
	{
		public enum Align
		{
			None = 0,
			xMinYMin = 1,
			xMidYMin = 2,
			xMaxYMin = 3,
			xMinYMid = 4,
			xMidYMid = 5,
			xMaxYMid = 6,
			xMinYMax = 7,
			xMidYMax = 8,
			xMaxYMax = 9
		}

		public enum MeetOrSlice
		{
			Meet = 0,
			Slice = 1
		}

		private const string None = "none";

		private const string xMinYMin = "xminymin";

		private const string xMidYMin = "xmidymin";

		private const string xMaxYMin = "xmaxymin";

		private const string xMinYMid = "xminymid";

		private const string xMidYMid = "xmidymid";

		private const string xMaxYMid = "xmaxymid";

		private const string xMinYMax = "xminymax";

		private const string xMidYMax = "xmidymax";

		private const string xMaxYMax = "xmaxymax";

		private const string Meet = "meet";

		private const string Slice = "slice";

		public static MeetOrSlice GetMeetOrSliceFromStrings(string[] inputStrings)
		{
			return default(MeetOrSlice);
		}

		public static MeetOrSlice GetMeetOrSliceFromString(string inputText)
		{
			return default(MeetOrSlice);
		}

		public static string GetStringFromMeetOrSlice(MeetOrSlice meetOrSlice)
		{
			return null;
		}

		public static Align GetAlignFromStrings(string[] inputStrings)
		{
			return default(Align);
		}

		public static Align GetAlignFromString(string inputText)
		{
			return default(Align);
		}

		public static string GetStringFromAlign(Align align)
		{
			return null;
		}

		public static Rect GetViewport(Rect viewport, Rect content, Align viewportAlign = Align.xMidYMid, MeetOrSlice viewportMeetOrSlice = MeetOrSlice.Meet)
		{
			return default(Rect);
		}

		protected static Vector2 Getalign(Rect viewport, Vector2 size, Align align)
		{
			return default(Vector2);
		}
	}
}

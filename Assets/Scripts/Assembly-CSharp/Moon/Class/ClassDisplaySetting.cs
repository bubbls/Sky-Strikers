using System;
using SVGImporter;
using UnityEngine;

namespace Moon.Class
{
	[CreateAssetMenu(menuName = "ScriptableObjects/ClassDisplaySetting")]
	public class ClassDisplaySetting : ScriptableObject
	{
		public enum DisplayState
		{
			Off = 0,
			On = 1
		}

		[Serializable]
		public class DisplaySVG
		{
			public DisplayState displayState;

			public SVGAsset displaySVG;
		}

		public PlayerSuitClass suitClass;

		public DisplaySVG[] detailSVG;

		public DisplaySVG[] titleSVG;

		public DisplaySVG[] confirmSVG;

		public GameObject displayModel;

		public SVGAsset leftIntroSVG;

		public SVGAsset rightRightSVG;
	}
}

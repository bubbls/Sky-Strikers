using System;
using UnityEngine;

namespace AmplifyShaderPack
{
	public class ASPReadme : ScriptableObject
	{
		public enum SampleRPType
		{
			Builtin = 0,
			HDRP = 1,
			URP = 2,
			None = 3
		}

		[Serializable]
		public class ASPSection
		{
			public string Heading;

			public string Text;

			public string LinkText;

			public string Url;

			public ASPSection(string heading, string text, string linkText, string url)
			{
			}
		}

		[Serializable]
		public class ASPBlock
		{
			public ASPSection BlockHeader;

			public ASPSection[] BlockContent;
		}

		public Texture2D Icon;

		public string Title;

		public ASPSection Description;

		public ASPSection PropertiesHeader;

		public ASPSection[] Properties;

		public ASPBlock[] AdditionalProperties;

		public ASPBlock[] AdditionalScripts;

		public bool LoadedLayout;

		public SampleRPType RPType;
	}
}

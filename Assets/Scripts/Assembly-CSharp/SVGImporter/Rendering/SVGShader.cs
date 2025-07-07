using UnityEngine;

namespace SVGImporter.Rendering
{
	public class SVGShader
	{
		private static Shader _gradientColorAlphaBlended;

		private static Shader _gradientColorAlphaBlendedAntialiased;

		private static Shader _gradientColorOpaque;

		private static Shader _solidColorAlphaBlended;

		private static Shader _solidColorAlphaBlendedAntialiased;

		private static Shader _solidColorOpaque;

		private static Shader _ui;

		private static Shader _uiAntialiased;

		public static Shader GradientColorAlphaBlended => null;

		public static Shader GradientColorAlphaBlendedAntialiased => null;

		public static Shader GradientColorOpaque => null;

		public static Shader SolidColorAlphaBlended => null;

		public static Shader SolidColorAlphaBlendedAntialiased => null;

		public static Shader SolidColorOpaque => null;

		public static Shader UI => null;

		public static Shader UIAntialiased => null;
	}
}

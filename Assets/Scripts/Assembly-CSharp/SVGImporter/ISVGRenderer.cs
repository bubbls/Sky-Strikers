using System;
using System.Collections.Generic;

namespace SVGImporter
{
	public interface ISVGRenderer
	{
		SVGAsset vectorGraphics { get; }

		int lastFrameChanged { get; }

		List<ISVGModify> modifiers { get; }

		event Action<SVGLayer[], SVGAsset, bool> OnPrepareForRendering;

		void UpdateRenderer();

		void AddModifier(ISVGModify modifier);

		void RemoveModifier(ISVGModify modifier);
	}
}

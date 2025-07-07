using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Moon.Profiler
{
	public interface IDebugPanelDrawContext
	{
		IDebugPanelDrawContext SameLine();

		IDebugPanelDrawContext EmptyLine(float width = 10f);

		IDebugPanelDrawContext Padding(float width);

		IDebugPanelDrawContext NextWidth(float width);

		IDebugPanelDrawContext LabelWidth(float width);

		void Text(string text, int MaxLine = 1);

		void Text(TextGetter text, int MaxLine = 1);

		void Button(string text, UnityAction cb);

		void Button(TextGetter text, UnityAction cb);

		void CheckBox(string text, bool defaultValue, UnityAction<bool> onChanged);

		void ComboBox(string label, List<string> datas, int defaultValue, UnityAction<int> onChanged);

		void ComboBox<T>(string label, T defValue, UnityAction<T> onChanged) where T : Enum;

		void Slider(string text, float min, float max, float defaultValue, bool useInt, UnityAction<float> onChanged);

		void SliderWithFunction(string text, float min, float max, float defaultValue, EaseFunc f, UnityAction<float> onChanged);

		void TextInput(string text, string defaultValue, UnityAction<string> onChanged);

		GameObject RenderTexture(int width, int height, TextureGetter tex);
	}
}

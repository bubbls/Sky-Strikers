using System.Collections.Generic;
using UnityEngine;

namespace Moon.Common
{
	public class TextProvider : MonoBehaviour
	{
		private static TextProvider _instance;

		protected Dictionary<string, string> _localizedTexts;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public static string GetText(string textKey)
		{
			return null;
		}

		protected virtual void LoadTexts()
		{
		}
	}
}

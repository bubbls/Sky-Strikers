using System.Collections.Generic;
using UnityEngine;

namespace moveen.example
{
	public class CharInfo : MonoBehaviour
	{
		public string team;

		public static List<CharInfo> allChars;

		public int command;

		private void OnDisable()
		{
		}

		private void OnEnable()
		{
		}

		public CharInfo getClosestToMe(predicate p)
		{
			return null;
		}
	}
}

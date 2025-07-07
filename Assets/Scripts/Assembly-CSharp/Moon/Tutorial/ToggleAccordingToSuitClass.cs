using System;
using System.Collections.Generic;
using DP.Takeaway.Runtime;
using UnityEngine;

namespace Moon.Tutorial
{
	public class ToggleAccordingToSuitClass : MonoBehaviour
	{
		[Serializable]
		private class Group
		{
			public List<GameObject> Objects;
		}

		[Serializable]
		private class Lookup : SerializableDictionary<PlayerSuitClass, Group>
		{
		}

		[SerializeField]
		private Lookup _lookup;

		public void UpdateVisuals(PlayerSuitClass suitClass)
		{
		}
	}
}

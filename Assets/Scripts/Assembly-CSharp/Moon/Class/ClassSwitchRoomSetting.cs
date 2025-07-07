using System;
using DP.Takeaway.Runtime;
using UnityEngine;

namespace Moon.Class
{
	[CreateAssetMenu(menuName = "ScriptableObjects/ClassSwitchRoomSetting")]
	public class ClassSwitchRoomSetting : ScriptableObject
	{
		[Serializable]
		public class SuitClassDisplaySettings : SerializableDictionary<PlayerSuitClass, ClassDisplaySetting>
		{
		}

		public SuitClassDisplaySettings DisplaySettings;
	}
}

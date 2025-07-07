using System;
using Chamber8.Framework.Common;
using DP.Takeaway.Runtime;
using UnityEngine;

namespace Moon
{
	[CreateAssetMenu(menuName = "Moon/Create Weapons", fileName = "Weapons", order = 0)]
	public class Weapons : SingleScriptableObject<Weapons, DefaultResourcePathProvider<Weapons>>
	{
		[Serializable]
		public class Specific
		{
			public int InitialBulletAmount;

			public int MaxBulletAmount;
		}

		[Serializable]
		private class WeaponSpecifics : SerializableDictionary<WeaponType, Specific>
		{
		}

		[SerializeField]
		private WeaponSpecifics _weaponSpecifics;

		public Specific FindSpecific(WeaponType weaponType)
		{
			return null;
		}
	}
}

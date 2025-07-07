using System;
using System.Collections.Generic;
using Fusion;
using UnityEngine;

namespace Moon.MultiPlay
{
	public static class FusionExtension
	{
		private static readonly Dictionary<Type, Fusion.Behaviour> _singletonBehaviours;

		public static void RegisterSingletonBehaviour(this NetworkRunner runner, Fusion.Behaviour behaviour)
		{
		}

		public static void UnregisterSingletonBehaviour(this NetworkRunner runner, Fusion.Behaviour behaviour)
		{
		}

		public static bool TryGetSingletonBehaviour<T>(this NetworkRunner runner, out T behaviour) where T : Fusion.Behaviour
		{
			behaviour = null;
			return false;
		}

		public static bool IsServerOrSharedModeMasterClient(this NetworkRunner runner)
		{
			return false;
		}

		public static bool TestIsGameMaster(this NetworkRunner runner, PlayerRef playerRef, bool isPlayerJoin = false)
		{
			return false;
		}

		private static NetworkObject GetPlayerObject()
		{
			return null;
		}

		public static T GetPlayerObjectComp<T>() where T : MonoBehaviour
		{
			return null;
		}

		public static T GetPlayerObjectComp<T>(this NetworkRunner runner, PlayerRef playerRef) where T : MonoBehaviour
		{
			return null;
		}
	}
}

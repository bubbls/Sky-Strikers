using System;
using Chamber8.Framework.Common;
using UnityEngine;

namespace Moon
{
	public class LocalPlayerRigSettings : DefaultSingleMonoBehaviourSettings<LocalPlayerRig>, ISingleMonoBehaviourInstantiator
	{
		public static Func<UnityEngine.Object, UnityEngine.Object> StaticInstantiateDelegate;

		public Func<UnityEngine.Object, UnityEngine.Object> InstantiateDelegate => null;
	}
}

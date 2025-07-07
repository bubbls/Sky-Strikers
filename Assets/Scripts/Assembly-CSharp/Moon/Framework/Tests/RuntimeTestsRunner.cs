using System.Collections.Generic;
using System.Reflection;
using Chamber8.Framework.Common;
using UnityEngine;

namespace Moon.Framework.Tests
{
	public class RuntimeTestsRunner : SingleMonoBehaviour<RuntimeTestsRunner, DefaultSingleMonoBehaviourSettings<RuntimeTestsRunner>>
	{
		private class RuntimeTestMethod : IRuntimeTest
		{
			private readonly object _clsInstance;

			private readonly MethodInfo _methodInfo;

			public MethodInfo MethodInfo => null;

			public string Name { get; }

			public void Test()
			{
			}

			public RuntimeTestMethod(object clsInstance, MethodInfo methodInfo)
			{
			}
		}

		private readonly List<IRuntimeTest> _allTests;

		public IEnumerable<IRuntimeTest> All => null;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void BootstrapRuntimeTestsRunner()
		{
		}

		private void Awake()
		{
		}
	}
}

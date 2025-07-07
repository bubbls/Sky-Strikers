using NaughtyAttributes;
using UnityEngine;

namespace Moon.Analytics
{
	public class TestAnalytics : MonoBehaviour
	{
		private struct TestStruct
		{
			public int Value;

			public TestStruct(int value)
			{
				Value = 0;
			}
		}

		[Button(null, EButtonEnableMode.Always)]
		private void TestLogArray()
		{
		}

		[Button(null, EButtonEnableMode.Always)]
		private void TestLogArrayWithNestedObject()
		{
		}
	}
}

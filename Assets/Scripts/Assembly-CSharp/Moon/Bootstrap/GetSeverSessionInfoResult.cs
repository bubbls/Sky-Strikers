using System;
using JetBrains.Annotations;

namespace Moon.Bootstrap
{
	[Serializable]
	public class GetSeverSessionInfoResult
	{
		[CanBeNull]
		public ServerSessionInfo ServerSessionInfo;
	}
}

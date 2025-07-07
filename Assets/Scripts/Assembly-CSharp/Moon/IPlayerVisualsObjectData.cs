using System;
using Fusion;

namespace Moon
{
	public interface IPlayerVisualsObjectData<out T> : INetworkStruct where T : Enum
	{
	}
}

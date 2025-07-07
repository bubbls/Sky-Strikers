using System.Collections.Generic;
using Chamber8.Framework.Core;
using UnityEngine.Scripting;

namespace Moon.PlayerProfile
{
	[Preserve]
	public class DummyPlayerProfileServiceDefinitionLoader : IServiceDefinitionLoader
	{
		public List<IServiceDefinition> LoadDefinitions()
		{
			return null;
		}
	}
}

using System.Collections.Generic;
using Chamber8.Framework.Core;
using UnityEngine.Scripting;

namespace Moon.Bootstrap
{
	[Preserve]
	public class ServiceLoaderConfigurator : IServiceDefinitionLoaderConfigurer
	{
		public List<IServiceDefinitionLoader> ConfiguredLoaders()
		{
			return null;
		}
	}
}

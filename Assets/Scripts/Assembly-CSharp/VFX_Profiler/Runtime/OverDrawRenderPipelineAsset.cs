using UnityEngine;
using UnityEngine.Rendering;

namespace VFX_Profiler.Runtime
{
	[CreateAssetMenu(menuName = "VFX_Profiler/Rendering/OverDraw Render Pipeline")]
	public class OverDrawRenderPipelineAsset : RenderPipelineAsset
	{
		protected override RenderPipeline CreatePipeline()
		{
			return null;
		}
	}
}

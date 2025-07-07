using UnityEngine;
using UnityEngine.Rendering;

namespace VFX_Profiler.Runtime
{
	public class OverDrawRenderPipeline : RenderPipeline
	{
		private const string BUFF_NAME = "Render Camera";

		private static CommandBuffer _commandBuffer;

		private CullingResults _cullingResults;

		private static Material _overQueue;

		private static Material _overTransparent;

		private static ShaderTagId[] s_ShaderTagIds;

		protected override void Render(ScriptableRenderContext context, Camera[] cameras)
		{
		}

		public void Render(ScriptableRenderContext context, Camera camera)
		{
		}
	}
}

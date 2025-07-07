Shader "Moon/0Simple/Scene/Window" {
	Properties {
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[ASEBegin] [SingleLineTexture] _InteriorMapping ("InteriorMapping", Cube) = "white" {}
		[HDR] _InteriorColor ("InteriorColor", Vector) = (0,0,0,0)
		_InteriorDepth ("InteriorDepth", Range(-1, 1)) = -1
		_InteriorDepthStretch ("InteriorDepthStretch", Range(0.5, 1.5)) = 1
		_InteriorRotateX ("InteriorRotateX", Range(-1, 1)) = 0
		_InteriorRotateY ("InteriorRotateY", Range(-1, 1)) = 0
		_InteriorMip ("InteriorMip", Range(0, 8)) = 0
		_InteriorTilingOffset ("InteriorTiling&Offset", Vector) = (1,1,0,0)
		[SingleLineTexture] [Space(10)] _GlassTex ("GlassTex", 2D) = "white" {}
		_GlassCenter ("GlassCenter", Vector) = (0,0,0.5,0)
		_GlassInt ("GlassInt", Range(0, 1)) = 1
		_GlassColor ("GlassColor", Vector) = (0,0,0,0)
		_FresnelScale ("FresnelScale", Range(0, 1)) = 1
		[Toggle] _VertexAO ("VertexAO", Float) = 0
		_VertexAOAdjust ("VertexAOAdjust", Range(-1, 1)) = 0
		[ASEEnd] [Header(Simplified)] [Toggle(_SIMPLIFIEDON_ON)] _SimplifiedOn ("SimplifiedOn", Float) = 0
		[HideInInspector] _texcoord ("", 2D) = "white" {}
		[HideInInspector] _QueueOffset ("_QueueOffset", Float) = 0
		[HideInInspector] _QueueControl ("_QueueControl", Float) = -1
		[HideInInspector] [NoScaleOffset] unity_Lightmaps ("unity_Lightmaps", 2DArray) = "" {}
		[HideInInspector] [NoScaleOffset] unity_LightmapsInd ("unity_LightmapsInd", 2DArray) = "" {}
		[HideInInspector] [NoScaleOffset] unity_ShadowMasks ("unity_ShadowMasks", 2DArray) = "" {}
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType" = "Opaque" }
		LOD 200

		Pass
		{
			HLSLPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			float4x4 unity_MatrixMVP;

			struct Vertex_Stage_Input
			{
				float3 pos : POSITION;
			};

			struct Vertex_Stage_Output
			{
				float4 pos : SV_POSITION;
			};

			Vertex_Stage_Output vert(Vertex_Stage_Input input)
			{
				Vertex_Stage_Output output;
				output.pos = mul(unity_MatrixMVP, float4(input.pos, 1.0));
				return output;
			}

			float4 frag(Vertex_Stage_Output input) : SV_TARGET
			{
				return float4(1.0, 1.0, 1.0, 1.0); // RGBA
			}

			ENDHLSL
		}
	}
	Fallback "Hidden/Shader Graph/FallbackError"
	//CustomEditor "UnityEditor.ShaderGraphUnlitGUI"
}
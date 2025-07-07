Shader "Moon/0Simple/Scene/Mirrors_2DTexture" {
	Properties {
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		[ASEBegin] [Header(Color)] [SingleLineTexture] [Space(5)] _MirrorTexture ("MirrorTexture", 2D) = "white" {}
		_MirrorOffset ("MirrorOffset", Range(0, 0.5)) = 0.5
		_MirrorTextureMip ("MirrorTextureMip", Range(0, 6)) = 0
		_MirrorTilingOffset ("MirrorTilingOffset", Vector) = (1,1,0,0)
		[Header(Fresnel)] _FresnelColorAInt ("FresnelColor(A:Int)", Vector) = (1,1,1,1)
		_FresnelPower ("FresnelPower", Range(0, 10)) = 1
		[Header(GlassTex)] [SingleLineTexture] [Space(5)] _GlassTex ("GlassTex", 2D) = "black" {}
		_GlassInt ("GlassInt", Range(0, 1)) = 1
		_GlassTextuerTiling ("GlassTextuerTiling", Vector) = (1,1,0,0)
		_GlassCenter ("GlassCenter", Vector) = (0,0,0.5,0)
		[Toggle(_ALPHACOLORON_ON)] _AlphaColorOn ("AlphaColorOn", Float) = 0
		[ASEEnd] _AlphaColor ("AlphaColor", Vector) = (1,1,1,1)
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
Shader "Moon/0Simple/Scene/Plaque" {
	Properties {
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		[ASEBegin] [SingleLineTexture] _BaseMap_R ("BaseMap_R", 2D) = "white" {}
		[SingleLineTexture] [Normal] _NormalMap ("NormalMap", 2D) = "bump" {}
		_NormalScale ("NormalScale", Range(0, 5)) = 1
		_SmoothInt ("SmoothInt", Range(0, 1)) = 0.39
		_LightDir ("LightDir", Vector) = (0,1,0,0)
		[Header(Glass)] [SingleLineTexture] _GlassTex ("GlassTex", 2D) = "white" {}
		_GlassTexTiling ("GlassTexTiling", Range(0, 2)) = 0.5
		_GlassInt ("GlassInt", Range(0, 1)) = 1
		_GlassCenter ("GlassCenter", Vector) = (0,0,0.5,0)
		_MetallicColor ("MetallicColor", Vector) = (1,0.8447998,0,0)
		_MetallicColor2 ("MetallicColor2", Vector) = (1,0.2644757,0,0)
		_BackgroundColor ("BackgroundColor", Vector) = (0.1019608,0.03921569,0.01568628,0)
		[ASEEnd] _BackgroundColor2 ("BackgroundColor2", Vector) = (0.1037736,0.0391752,0.01615344,0)
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
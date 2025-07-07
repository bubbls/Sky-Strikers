Shader "Moon/0Simple/Scene/Badge" {
	Properties {
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[ASEBegin] [KeywordEnum(AlbedoColor,Matcap,InteriorMapping)] _Material ("Material", Float) = 0
		_ScreenColor ("ScreenColor", Vector) = (0.1843137,0.1843137,0.1843137,0)
		[Header(AlbedoColor)] [SingleLineTexture] _Albedo ("Albedo", 2D) = "white" {}
		[HDR] _AlbedoColor ("AlbedoColor", Vector) = (1,1,1,0)
		[Space(10)] _HalfLambertOffset ("HalfLambertOffset", Range(0.5, 1)) = 0.62
		_AlbedoTiling ("AlbedoTiling", Vector) = (1,1,0,0)
		[Header(Matcap)] [SingleLineTexture] _Matcap ("Matcap", 2D) = "white" {}
		_MatcapMip ("MatcapMip", Range(0, 8)) = 0
		[HDR] _MatcapColor ("MatcapColor", Vector) = (1,1,1,0)
		_AlbedoAdd ("AlbedoAdd", Range(0, 1)) = 0.5
		[Header(InteriorMapping)] [SingleLineTexture] _InteriorMapping ("InteriorMapping", Cube) = "white" {}
		_InteriorMip ("InteriorMip", Range(0, 8)) = 0
		[HDR] _InteriorColor ("InteriorColor", Vector) = (0,0,0,0)
		_InteriorTilingOffset ("InteriorTiling&Offset", Vector) = (1,1,0,0)
		_FresnelScale ("FresnelScale", Range(0, 2)) = 1
		[ASEEnd] _FresnelPower ("FresnelPower", Range(0, 10)) = 2
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
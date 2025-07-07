Shader "Moon/0Simple/Scene/DefaultScene_Simpler" {
	Properties {
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[SingleLineTexture] _BaseMap ("BaseMap", 2D) = "white" {}
		_VertexAO ("VertexAO", Range(-1, 1)) = 0
		[HDR] _BaseColor ("BaseColor", Vector) = (1,1,1,0)
		_SimplifiedColor ("SimplifiedColor", Vector) = (1,1,1,0)
		[HDR] _EmissionColor ("EmissionColor", Vector) = (1,1,1,1)
		_EmissionSpeed ("EmissionSpeed", Range(0, 20)) = 0
		_EmissionMin ("EmissionMin", Range(0, 1)) = 0.1
		[HDR] _HighlightColor ("HighlightColor", Vector) = (1,1,1,0)
		_SmoothnessMax ("SmoothnessMax", Float) = 20
		_SmoothnessMin ("SmoothnessMin", Float) = 2
		_HighlightMin ("HighlightMin", Range(0, 1)) = 0.1
		[Toggle(_BAKEDCOLORON_ON)] _BakedColorOn ("BakedColorOn", Float) = 0
		_BakedColorIntensity ("BakedColorIntensity", Range(0, 100)) = 1
		_BakedEmissionIntensity ("BakedEmissionIntensity", Range(0, 100)) = 0
		[Toggle(_ROUGHMAPON_ON)] _RoughMapOn ("RoughMapOn", Float) = 0
		[SingleLineTexture] _RoughMap ("RoughMap", 2D) = "black" {}
		_RoughMapTiling ("RoughMapTiling", Float) = 1
		_RoughMapColor ("RoughMapColor", Vector) = (1,1,1,0)
		[Toggle(_SIMPLIFIEDON_ON)] _SimplifiedOn ("SimplifiedOn", Float) = 0
		[Toggle] _LookBakedColor ("LookBakedColor", Float) = 0
		[Toggle(_SNOWON_ON)] _SnowOn ("SnowOn", Float) = 0
		[SingleLineTexture] _SnowTexture ("SnowTexture", 2D) = "white" {}
		_SnowTiling ("SnowTiling", Vector) = (1,1,0,0)
		_SnowTexturePower ("SnowTexturePower", Range(0, 19)) = 1
		_SnowColor ("SnowColor", Vector) = (1,1,1,1)
		[SingleLineTexture] _SnowMask ("SnowMask", 2D) = "white" {}
		_SnowMaskTilingOffset ("SnowMaskTilingOffset", Vector) = (1,1,0,0)
		_SnowMaskInt ("SnowMaskInt", Range(-1, 1)) = 0
		_SnowPow ("SnowPow", Range(0, 10)) = 2
		_SnowRange ("SnowRange", Range(0, 1)) = 0
		[ASEEnd] _SnowRangeSoft ("SnowRangeSoft", Range(0, 2)) = 1
		[HideInInspector] _QueueOffset ("_QueueOffset", Float) = 0
		[HideInInspector] _QueueControl ("_QueueControl", Float) = -1
		[HideInInspector] [NoScaleOffset] unity_Lightmaps ("unity_Lightmaps", 2DArray) = "" {}
		[HideInInspector] [NoScaleOffset] unity_LightmapsInd ("unity_LightmapsInd", 2DArray) = "" {}
		[HideInInspector] [NoScaleOffset] unity_ShadowMasks ("unity_ShadowMasks", 2DArray) = "" {}
		[ToggleOff] [HideInInspector] _ReceiveShadows ("Receive Shadows", Float) = 1
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
	//CustomEditor "DefaultSceneSimpleGui"
}
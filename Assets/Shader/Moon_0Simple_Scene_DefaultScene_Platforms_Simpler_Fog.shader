Shader "Moon/0Simple/Scene/DefaultScene_Platforms_Simpler_Fog" {
	Properties {
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[Header(BaseColor)] [SingleLineTexture] _BaseMap ("BaseMap", 2D) = "white" {}
		_VertexAO ("VertexAO", Range(-1, 1)) = 0
		[HDR] _BaseColor ("BaseColor", Vector) = (1,1,1,0)
		[HDR] _EmissionColor ("EmissionColor", Vector) = (1,1,1,1)
		[Header(Verge)] [SingleLineTexture] _VergeNoise ("VergeNoise", 2D) = "white" {}
		_VergeRange ("VergeRange", Range(0, 2)) = 0
		_VergeSoft ("VergeSoft", Range(0, 10)) = 1
		_VergeSpeed ("VergeSpeed", Range(0, 2)) = 0
		_VergeColor ("VergeColor", Vector) = (1,1,1,0)
		_VergeWavinessSpeed ("VergeWavinessSpeed", Float) = 10
		_VergeTiling ("VergeTiling", Vector) = (1,1,0,0)
		[Header(Heighlight)] [HDR] _HighlightColor ("HighlightColor", Vector) = (1,1,1,0)
		_SmoothnessMax ("SmoothnessMax", Float) = 20
		_SmoothnessMin ("SmoothnessMin", Float) = 2
		_HighlightMin ("HighlightMin", Range(0, 1)) = 1
		[Header(Simplified)] [Toggle(_SIMPLIFIEDON_ON)] _SimplifiedOn ("SimplifiedOn", Float) = 0
		[Header(SHColor)] [Toggle] _SHColorOn ("SHColorOn", Float) = 0
		[ASEEnd] _SHColorIntensity ("SHColorIntensity", Float) = 2
		[HideInInspector] _custom_SHAr ("custom_SHAr", Vector) = (0,0,0,0)
		[HideInInspector] _custom_SHAg ("custom_SHAg", Vector) = (0,0,0,0)
		[HideInInspector] _custom_SHAb ("custom_SHAb", Vector) = (0,0,0,0)
		[HideInInspector] _custom_SHBr ("custom_SHBr", Vector) = (0,0,0,0)
		[HideInInspector] _custom_SHBg ("custom_SHBg", Vector) = (0,0,0,0)
		[HideInInspector] _custom_SHBb ("custom_SHBb", Vector) = (0,0,0,0)
		[HideInInspector] _custom_SHC ("custom_SHC", Vector) = (0,0,0,0)
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
	//CustomEditor "BakedGUI"
}
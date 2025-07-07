Shader "Moon/0Simple/Scene/Lava" {
	Properties {
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		[ASEBegin] [SingleLineTexture] _FireTexture ("FireTexture", 2D) = "white" {}
		_FireTilingSpeed ("FireTiling&Speed", Vector) = (1,1,0,0)
		_LavaColor1 ("LavaColor1", Vector) = (1,1,1,0)
		_LavaColor2 ("LavaColor2", Vector) = (0,0,0,0)
		_ColorRange ("ColorRange", Range(0, 1)) = 0
		[Header(Noise)] [SingleLineTexture] _Noise ("Noise", 2D) = "white" {}
		_NoiseIntensity ("NoiseIntensity", Range(0, 1)) = 0
		_NoiseTilingSpeed ("NoiseTiling&Speed", Vector) = (1,1,0,0)
		[Header(DarkSpot)] _DarkSpotRange ("DarkSpotRange", Range(0, 1)) = 1
		_DarkSpotSoft ("DarkSpotSoft", Range(0, 1)) = 0.1
		_DarkSpotColor ("DarkSpotColor", Vector) = (0,0,0,0)
		[Header(Alpha)] _AlphaRange ("AlphaRange", Range(0, 1)) = 0
		[ASEEnd] _AlphaSoft ("AlphaSoft", Range(0, 1)) = 0.5
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
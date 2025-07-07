Shader "Moon/0Simple/Scene/Shop_Commercial_Glass" {
	Properties {
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		[ASEBegin] _Opacity ("Opacity", Range(-1, 1)) = 0
		[SingleLineTexture] _MainTex ("MainTex", 2D) = "white" {}
		_MainColor ("MainColor", Vector) = (1,1,1,0)
		_MainTexTiling ("MainTexTiling", Vector) = (1,1,0,0)
		[SingleLineTexture] _NoiseTex ("NoiseTex", 2D) = "white" {}
		_NoiseTexTiling ("NoiseTexTiling", Vector) = (1,1,0,0)
		_NoiseTexSpeed ("NoiseTexSpeed", Vector) = (0,0,0,0)
		_FresnelPow ("FresnelPow", Range(0, 10)) = 1
		_FresnelColor ("FresnelColor", Vector) = (1,1,1,0)
		[Header(Cave)] _CaveOffset ("CaveOffset", Range(0, 10)) = 0
		_CaveSoft ("CaveSoft", Range(0, 10)) = 1
		_CavePosition ("CavePosition", Vector) = (0,0,0,0)
		[Header(Simplified)] [Toggle(_SIMPLIFIEDON_ON)] _SimplifiedOn ("SimplifiedOn", Float) = 0
		[ASEEnd] _SimplifiedColor ("SimplifiedColor", Vector) = (1,1,1,0)
		[HideInInspector] _QueueOffset ("_QueueOffset", Float) = 0
		[HideInInspector] _QueueControl ("_QueueControl", Float) = -1
		[HideInInspector] [NoScaleOffset] unity_Lightmaps ("unity_Lightmaps", 2DArray) = "" {}
		[HideInInspector] [NoScaleOffset] unity_LightmapsInd ("unity_LightmapsInd", 2DArray) = "" {}
		[HideInInspector] [NoScaleOffset] unity_ShadowMasks ("unity_ShadowMasks", 2DArray) = "" {}
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
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

			Texture2D<float4> _MainTex;
			SamplerState sampler_MainTex;

			struct Fragment_Stage_Input
			{
				float2 uv : TEXCOORD0;
			};

			float4 frag(Fragment_Stage_Input input) : SV_TARGET
			{
				return _MainTex.Sample(sampler_MainTex, float2(input.uv.x, input.uv.y));
			}

			ENDHLSL
		}
	}
	Fallback "Hidden/Shader Graph/FallbackError"
	//CustomEditor "UnityEditor.ShaderGraphUnlitGUI"
}
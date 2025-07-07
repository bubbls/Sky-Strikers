Shader "Moon/Effect/TearsPetroleum" {
	Properties {
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[Main(g1, _KEYWORD, on, off)] _Float4 ("黑色眼泪材质", Float) = 0
		[Sub(g1)] _BaseColor ("BaseColor", Vector) = (0,0,0,0)
		[Main(matcap, _KEYWORD, on, off)] _Float2 ("材质映射", Float) = 0
		[Tex(matcap, _MatCapColor)] _Matcap ("Matcap", 2D) = "white" {}
		[Sub(matcap)] _MatcapMip ("MatcapMip", Range(0, 8)) = 0
		[Sub(matcap)] _MatcapIntensity ("MatcapIntensity", Float) = 6
		[HideInInspector] _MatCapColor ("MatCapColor", Vector) = (0,0,0,0)
		[Sub(matcap)] _MatcapFresnle ("MatcapFresnle", Vector) = (0,1,5,0)
		[Tex(normal)] [Normal] _Normal ("Normal", 2D) = "bump" {}
		[Sub(normal)] _NormalScale ("NormalScale", Range(0, 2)) = 0.5
		[Sub(normal)] _NormalrSpeed ("NormalrSpeed", Float) = 0.1
		[Sub(normal)] _NormalTiling ("NormalTiling", Vector) = (1,1,0,0)
		[Main(noise, _KEYWORD, on, off)] _Float0 ("扰动", Float) = 0
		[Tex(noise)] _Noise ("Noise", 2D) = "white" {}
		[Sub(noise)] _NoiseIntensity ("NoiseIntensity", Range(0, 2)) = 1
		[Sub(noise)] _NoiseSpeed ("NoiseSpeed", Float) = 2
		[Sub(noise)] _NoiseTiling ("NoiseTiling", Vector) = (1,1,0,0)
		[Main(smoke, _KEYWORD, on, off)] _Float3 ("烟雾", Float) = 0
		[Tex(smoke, _SmokeColor)] _Smoke ("Smoke", 2D) = "white" {}
		[Sub(smoke)] _SmokeSpeed ("SmokeSpeed", Float) = 4
		[HideInInspector] _SmokeColor ("SmokeColor", Vector) = (0.133366,0.3490566,0.2261628,0)
		[Sub(smoke)] _SmokeSubtract ("SmokeSubtract", Range(0, 1)) = 0
		[Sub(smoke)] _SmokeTiling ("SmokeTiling", Vector) = (1,1,0,0)
		[Main(wave, _KEYWORD, on, off) ] _Float7 ("冲击波", Float) = 0
		[Toggle(_WAVE_ON)] _Wave ("Wave", Float) = 0
		[Sub(wave)] _WaveFlow ("WaveFlow", Float) = 1
		[Sub(wave)] _WaveRange ("WaveRange", Vector) = (2.5,3.8,0,0)
		[Sub(wave)] _WaveColor ("WaveColor", Vector) = (1,1,1,0)
		_WaveMin ("WaveMin", Float) = 0
		[ASEEnd] _WaveSoft ("WaveSoft", Float) = 1
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
	//CustomEditor "LWGUI.LWGUI"
}
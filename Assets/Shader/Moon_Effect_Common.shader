Shader "Moon/Effect/Common" {
	Properties {
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[Enum(UnityEngine.Rendering.BlendMode)] _Scr ("Scr", Float) = 1
		[Enum(UnityEngine.Rendering.BlendMode)] _Dst ("Dst", Float) = 1
		[Enum(UnityEngine.Rendering.CullMode)] _Cullmode ("Cullmode", Float) = 2
		[Main(Main)] _Main ("Main", Float) = 0
		[Sub(Main)] _MainTex ("MainTex", 2D) = "white" {}
		[Sub(Main)] _MainColor ("MainColor", Vector) = (1,1,1,1)
		[Sub(Main)] _MainTexRotat ("MainTexRotat", Range(0, 360)) = 0
		[Sub(Main)] _MainTexSpeed ("MainTexSpeed", Vector) = (0,0,0,0)
		[Toggle(_MAINRADIAL_ON)] _MainRadial ("MainRadial", Float) = 0
		[Sub(Main)] _MainTexRadialTilingSpeed ("MainTexRadialTiling&Speed", Vector) = (1,1,0,0)
		[Sub(Main)] _MainMip ("MainMip", Range(0, 7)) = 0
		[Main(Mask)] _Mask ("Mask", Float) = 0
		[Tex(Mask)] _MaskTex ("MaskTex", 2D) = "white" {}
		[Toggle(_MASKA_ON)] _MaskA ("MaskA", Float) = 0
		[Toggle(_MASKCUSTOM_ON)] _MaskCustom ("MaskCustom", Float) = 0
		[Sub(Mask)] _MaskIntensity ("MaskIntensity", Range(0, 1)) = 0
		[Sub(Mask)] _MaskSoft ("MaskSoft", Range(0, 1)) = 0
		[Sub(Mask)] _MaskRotat ("MaskRotat", Range(0, 360)) = 0
		[Sub(Mask)] _MaskSpeed ("MaskSpeed", Vector) = (0,0,0,0)
		[Toggle(_MASKRADIAL_ON)] _MaskRadial ("MaskRadial", Float) = 0
		[Sub(Mask)] _MaskRadialTilingSpeed ("MaskRadialTiling&Speed", Vector) = (1,1,0,0)
		[Main(Dissolve)] _Dissolve ("Dissolve", Float) = 0
		[Sub(Dissolve)] _DissolveTex ("DissolveTex", 2D) = "white" {}
		[Toggle(_DISSOLVEA_ON)] _DissolveA ("DissolveA", Float) = 0
		[Sub(Dissolve)] [HDR] _DissolveColor ("DissolveColor", Vector) = (1,1,1,1)
		[Sub(Dissolve)] _DissolveIntensity ("DissolveIntensity", Range(0, 1)) = 0
		[Sub(Dissolve)] _DissolveSoft ("DissolveSoft", Range(0, 1)) = 0
		[Toggle(_DISSOLVEHARDEDGE_ON)] _DissolveHardEdge ("DissolveHardEdge", Float) = 0
		[Sub(Dissolve)1] _DissolveHardIntensity ("DissolveHardIntensity", Range(0, 1)) = 0
		[Sub(Dissolve)] _DissolveHardWidth ("DissolveHardWidth", Range(0, 1)) = 1
		[Sub(Dissolve)] _DissolveRotat ("DissolveRotat", Range(0, 360)) = 0
		[Sub(Dissolve)] _DissolveSpeed ("DissolveSpeed", Vector) = (0,0,0,0)
		[Toggle(_DISSOLVERADIAL_ON)] _DissolveRadial ("DissolveRadial", Float) = 0
		[Sub(Dissolve)] _DissolveRadialTilingSpeed ("DissolveRadialTiling&Speed", Vector) = (1,1,0,0)
		[Main(Dissolve2)] _Dissolve2 ("Dissolve2", Float) = 0
		[Sub(Dissolve2)] _Dissolve2Tex ("Dissolve2Tex", 2D) = "white" {}
		[Toggle(_DISSOLVE2A_ON)] _Dissolve2A ("Dissolve2A", Float) = 0
		[Sub(Dissolve2)] _Dissolve2Rotat ("Dissolve2Rotat", Range(0, 360)) = 0
		[Sub(Dissolve2)] _Dissolve2Speed ("Dissolve2Speed", Vector) = (0,0,0,0)
		[Main(Noise)] _Noise ("Noise", Float) = 0
		[Sub(Noise)] _UVNoise ("UVNoise", 2D) = "black" {}
		[Sub(Noise)] _UVNoiseInt ("UVNoiseInt", Range(0, 1)) = 0
		[Sub(Noise)] _UVNoiseRotat ("UVNoiseRotat", Range(0, 360)) = 0
		[Sub(Noise)] _UVNoiseSpeed ("UVNoiseSpeed", Vector) = (0,0,0,0)
		[Sub(Noise)] _NoiseColorInt ("NoiseColorInt", Range(0, 3)) = 0
		[ASEEnd] [Sub(Noise)] _NoiseColorPow ("NoiseColorPow", Float) = 1
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
	//CustomEditor "LWGUI.LWGUI"
}
Shader "Moon/Scene/WarningSpace" {
	Properties {
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[Main(base, _KEYWORD, on, off) ] _Float0 ("区域形警告效果", Float) = 0
		[Sub(base)] _Color1 ("Color1", Vector) = (1,0,0,0)
		[Sub(base)] _Color2 ("Color2", Vector) = (1,0.3764706,0,0)
		[Tex(base)] _MainTex ("MainTex", 2D) = "white" {}
		[Sub(base)] _MainTexTiling ("MainTexTiling", Vector) = (8,8,0,0)
		[Sub(mask)] _BreathingLightSpeed ("BreathingLightSpeed", Float) = 1
		[Main(range, _KEYWORD, on, off) ] _Float1 ("警告范围", Float) = 0
		[Sub(range)] _WarningStartPosition ("WarningStartPosition", Vector) = (-34.2,-8.5,16.07,0)
		[Sub(range)] _WarningRange ("WarningRange", Float) = 3.38
		[Sub(range)] _WarningRangeSoft ("WarningRangeSoft", Float) = 40.9
		[Main(scanline, _KEYWORD, on, off) ] _Float2 ("信号干扰", Float) = 0
		[Tex(scanline)] _ScanlineNoise ("ScanlineNoise", 2D) = "black" {}
		[Sub(scanline)] _ScanlineNoiseTiling ("ScanlineNoiseTiling", Vector) = (2,2,0,0)
		[Sub(scanline)] _ScanlineNoiseInt ("ScanlineNoiseInt", Float) = 1
		[Sub(scanline)] _Scanline2Width ("Scanline2Width", Range(0, 1)) = 0.05
		[Sub(scanline)] _Scanline1Width ("Scanline1Width", Range(0, 1)) = 0.09019417
		[Sub(scanline)] _ScanlineSpeed ("ScanlineSpeed", Float) = 2
		[Main(mask, _KEYWORD, on, off) ] _Float3 ("像素格", Float) = 0
		[Tex(mask)] _MaskTex ("MaskTex", 2D) = "white" {}
		[Sub(mask)] _MaskTexTiling ("MaskTexTiling", Vector) = (400,400,0,0)
		[Sub(mask)] _Alpha ("Alpha", Range(0, 1)) = 0
		[ASEEnd] [MinMaxSlider(mask, _AlphaRimOffset, _AlphaRimSoft)] _AlphaRimSoft ("AlphaRimSoft", Range(0, 1)) = 0.78
		[HideInInspector] _AlphaRimOffset ("AlphaRimOffset", Range(0, 1)) = 0.52
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
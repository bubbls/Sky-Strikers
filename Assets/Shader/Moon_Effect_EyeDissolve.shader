Shader "Moon/Effect/EyeDissolve" {
	Properties {
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[Main(g1, _KEYWORD, on, off) ] _Float8 ("眼球/溶解效果", Float) = 0
		[Tex(g1)] _Albedo ("Albedo", 2D) = "white" {}
		[HideInInspector] [HDR] _AlbedoColor ("AlbedoColor", Vector) = (1,1,1,0)
		[Main(emi, _KEYWORD, on, off) ] _Float7 ("自发光，A材质捕获Mask", Float) = 0
		[Tex(emi, _EmissionColor)] _Emission ("Emission", 2D) = "black" {}
		[HideInInspector] [HDR] _EmissionColor ("EmissionColor", Vector) = (1,1,1,1)
		[Main(matcap, _KEYWORD, on, off) ] _Float3 ("材质捕获", Float) = 0
		[SingleLineTexture] [Tex(matcap)] _Matcap ("Matcap", 2D) = "white" {}
		[Sub(matcap)] _MatcapMip ("MatcapMip", Range(0, 8)) = 0
		[Sub(matcap)] _MatcapIntensity ("MatcapIntensity", Float) = 6
		[Main(dissolve, _KEYWORD, on, off)] _dissolfe ("溶解", Float) = 0
		[Toggle(_DISSOLVE_ON)] _Dissolve ("Dissolve", Float) = 0
		[Sub(dissolve)] _DissolveAmount ("DissolveAmount", Range(0, 1)) = 0
		[Sub(dissolve)] _DissolveAmountMin ("DissolveAmountMin", Float) = 0
		[Sub(dissolve)] _DissolveAmountMax ("DissolveAmountMax", Float) = 1
		[Tex(dissolve, _DissolveEdgeColor)] [Space(10)] _DissolveNoise ("DissolveNoise", 2D) = "white" {}
		[Sub(dissolve)] _DissolveSpread ("DissolveSpread", Range(0.01, 1)) = 0.01
		[Sub(dissolve)] _DissolveDirection ("DissolveDirection", Vector) = (0.5,0,0,0)
		[HideInInspector] _DissolveEdgeColor ("DissolveEdgeColor", Vector) = (0,1,0.8897755,0)
		[Sub(dissolve)] _DissolveNoiseTiling ("DissolveNoiseTiling", Vector) = (1,1,0,0)
		[Main(glitch, _KEYWORD, on, off)] _Float10 ("信号干扰", Float) = 0
		[Toggle(_GLITCH_ON)] _Glitch ("Glitch", Float) = 0
		[Sub(glitch)] _GlitchInt ("GlitchInt", Range(0, 3)) = 0.08505014
		[Sub(glitch)] _GlitchWidth ("GlitchWidth", Range(0, 1)) = 0.4410474
		[Tex(glitch, _GlitchColor)] _GlitchColorTex ("GlitchColorTex", 2D) = "white" {}
		[HideInInspector] [HDR] _GlitchColor ("GlitchColor", Vector) = (1,1,1,0)
		[Tex(glitch)] _GlitchNoiseTex ("GlitchNoiseTex", 2D) = "white" {}
		[Sub(glitch)] _GlitchLineTiling ("GlitchLineTiling", Float) = 1
		[Sub(glitch)] _GlitchTimeSpeed ("GlitchTimeSpeed", Float) = 0.5
		[ASEEnd] [Sub(glitch)] _GlitchTimeRandom ("GlitchTimeRandom", Range(0, 1)) = 0
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
	//CustomEditor "LWGUI.LWGUI"
}
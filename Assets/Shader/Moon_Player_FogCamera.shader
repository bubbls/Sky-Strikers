Shader "Moon/Player/FogCamera" {
	Properties {
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		[Main(height, _KEYWORD, on, off) ] _Float0 ("烟雾高度", Float) = 0
		[Sub(height)] _FogAltitudeHeight ("FogAltitudeHeight", Float) = 0
		[Sub(height)] _FogAltitudeSoft ("FogAltitudeSoft", Float) = 2
		[Main(base, _KEYWORD, on, off) ] _Float2 ("颜色", Float) = 0
		[Tex(base)] _FogNoise ("FogNoise", 2D) = "white" {}
		[Color(base,_BaseColor1)] _BaseColor ("BaseColor", Vector) = (0.1098039,0.1137255,0.1215686,0)
		[HideInInspector] _BaseColor1 ("BaseColor1", Vector) = (0.2313726,0.2431373,0.2627451,0)
		[Sub(base)] _FogNoiseTiling ("FogNoiseTiling", Float) = 0.5
		[Sub(base)] _FogNoiseSpeed ("FogNoiseSpeed", Float) = 0.1
		[MinMaxSlider(base, _FogAmount,_FogSoft)] _FogAmount ("FogAmount", Range(-1, 1)) = 0
		[HideInInspector] _FogSoft ("FogSoft", Range(0, 1)) = 0.1179366
		[ASEEnd] [Sub(base)] _FogNoiseFalloff ("FogNoiseFalloff", Float) = 4.02
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
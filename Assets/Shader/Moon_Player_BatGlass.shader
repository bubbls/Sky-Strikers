Shader "Moon/Player/BatGlass" {
	Properties {
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[ASEBegin] [SingleLineTexture] [Space(10)] _MainTex ("MainTex", 2D) = "white" {}
		_WaterColor1 ("WaterColor1", Vector) = (0,0,0,0)
		_WaterColor2 ("WaterColor2", Vector) = (0.4811321,0.124822,0.4500638,0)
		_WaterSurfaceColor ("WaterSurfaceColor", Vector) = (0.581358,0.2130651,0.7924528,0)
		_WaterColorMin ("WaterColorMin", Range(0, 1)) = 0
		_WaterColorMax ("WaterColorMax", Range(0, 1)) = 1
		[Space(10)] _WaterHeight ("WaterHeight", Range(0, 2)) = 0
		_WaterFalloff ("WaterFalloff", Float) = 0.01
		_WaterOpacity ("WaterOpacity", Range(0, 1)) = 1
		_CorrugationIntensity ("CorrugationIntensity", Float) = 0.12
		_CorrugationSpeed ("CorrugationSpeed", Float) = 1
		_WaterEdgeInt ("WaterEdgeInt", Range(0, 1)) = 0.5
		[SingleLineTexture] [Space(10)] _Matcap ("Matcap", 2D) = "white" {}
		_MatcapIntensity ("MatcapIntensity", Range(0, 1)) = 0.5
		[Space(10)] _FresnelColor ("FresnelColor", Vector) = (1,1,1,1)
		_FresnelMin ("FresnelMin", Range(0, 1)) = 0
		_FresnelMax ("FresnelMax", Range(0, 1)) = 0
		_FresnelOpacity ("FresnelOpacity", Range(0, 1)) = 0
		_GlassOpacity ("GlassOpacity", Range(0, 1)) = 0.1
		[SingleLineTexture] [Space(10)] _Bubbles ("Bubbles", 2D) = "white" {}
		_BubbleIntensity ("BubbleIntensity", Range(0, 1)) = 0.3
		_BubbleSpeed ("BubbleSpeed", Vector) = (0,0,0,0)
		[Space(10)] [Toggle(_LIGHTPROBEON_ON)] _LightProbeOn ("LightProbeOn", Float) = 1
		[ASEEnd] _LightProbeLerp ("LightProbeLerp", Range(0, 1)) = 0.5
		[HideInInspector] _texcoord ("", 2D) = "white" {}
		[HideInInspector] _QueueOffset ("_QueueOffset", Float) = 0
		[HideInInspector] _QueueControl ("_QueueControl", Float) = -1
		[HideInInspector] [NoScaleOffset] unity_Lightmaps ("unity_Lightmaps", 2DArray) = "" {}
		[HideInInspector] [NoScaleOffset] unity_LightmapsInd ("unity_LightmapsInd", 2DArray) = "" {}
		[HideInInspector] [NoScaleOffset] unity_ShadowMasks ("unity_ShadowMasks", 2DArray) = "" {}
		[ToggleOff] [HideInInspector] _ReceiveShadows ("Receive Shadows", Float) = 1
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
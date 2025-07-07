Shader "Moon/0Simple/Player/PointArrow" {
	Properties {
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[Toggle] _TeamTwo ("TeamTwo", Float) = 0
		[SingleLineTexture] _RingNoise ("RingNoise", 2D) = "white" {}
		_RingNoiseTiling ("RingNoiseTiling", Vector) = (1,1,0,0)
		_RingColor1 ("RingColor1", Vector) = (1,0.654902,0.654902,1)
		_RingColor1_TeamTwo ("RingColor1_TeamTwo", Vector) = (0.4292453,1,0.9969314,1)
		_RingColor2 ("RingColor2", Vector) = (1,0,0,1)
		_RingColor2_TeamTwo ("RingColor2_TeamTwo", Vector) = (0,0.2400873,1,1)
		_ArrowLineRange ("ArrowLineRange", Range(-2, 1)) = 0
		_ArrowColor1 ("ArrowColor1", Vector) = (1,0.6556604,0.6556604,1)
		_ArrowColor1_TeamTwo ("ArrowColor1_TeamTwo", Vector) = (0,0.9510722,1,1)
		_ArrowColor2 ("ArrowColor2", Vector) = (1,0,0,1)
		_ArrowColor2_TeamTwo ("ArrowColor2_TeamTwo", Vector) = (0,0.5458817,1,1)
		_ArrowLineSoft ("ArrowLineSoft", Range(0, 1)) = 0
		_ArrowLineSpeed ("ArrowLineSpeed", Float) = 1
		[IntRange] _ArrowLineFrequency ("ArrowLineFrequency", Range(1, 4)) = 0
		_ArrowLineUOffset ("ArrowLineUOffset", Range(0, 1)) = 1
		[ASEEnd] _ArrowDarkIntensity ("ArrowDarkIntensity", Range(0, 1)) = 0
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
	//CustomEditor "PointArrowGui"
}
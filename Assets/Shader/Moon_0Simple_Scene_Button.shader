Shader "Moon/0Simple/Scene/Button" {
	Properties {
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[ASEBegin] [SingleLineTexture] _BaseMap ("BaseMap", 2D) = "white" {}
		_BaseColor ("BaseColor", Vector) = (1,1,1,0)
		[HDR] _EmissionColor ("EmissionColor", Vector) = (1,1,1,1)
		_EmissionSpeed ("EmissionSpeed", Range(0, 20)) = 0
		[Space(10)] _BacklightOffset ("BacklightOffset", Range(-1.5, 1)) = 0
		_BacklightSoft ("BacklightSoft", Range(0, 2)) = 0.5
		_BacklightColor ("BacklightColor", Vector) = (0.5,0.5,0.5,0)
		[Space(10)] _UplightOffset ("UplightOffset", Range(-1.5, 1)) = 0
		_UplightSoft ("UplightSoft", Range(0, 2)) = 0.5
		[HDR] _UplightColor ("UplightColor", Vector) = (1,1,1,1)
		[Space(10)] [Toggle(_LIGHTPROBEON_ON)] _LightProbeOn ("LightProbeOn", Float) = 1
		_LightProbeInt ("LightProbeInt", Range(0, 1)) = 1
		[Space(10)] [HDR] _HighlightColor ("HighlightColor", Vector) = (1,1,1,0)
		_HighlightMin ("HighlightMin", Range(0, 1)) = 0.1
		[ASEEnd] _Smoothnesse ("Smoothnesse", Range(0, 10)) = 1
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
	//CustomEditor "UnityEditor.ShaderGraphUnlitGUI"
}
Shader "Moon/0Simple/Scene/NoiseShimmer" {
	Properties {
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		[ASEBegin] [SingleLineTexture] _NoiseTex ("NoiseTex", 2D) = "white" {}
		_NoiseSpeed ("NoiseSpeed", Float) = 1
		_TeamOneColor ("TeamOneColor", Vector) = (0.1058824,0.2627451,0.682353,1)
		_TeamOneColorHigh ("TeamOneColorHigh", Vector) = (0.2313726,0.5882353,1,1)
		_TeamTwoColor ("TeamTwoColor", Vector) = (0.7450981,0.145098,0.2392157,1)
		_TeamTwoColorHigh ("TeamTwoColorHigh", Vector) = (1,0.4392157,0.6078432,1)
		[Header(GI)] [Toggle(_BAKEDCOLORON_ON)] _BakedColorOn ("BakedColorOn", Float) = 0
		[Header(TeamRange)] _TeamRangeMax ("TeamRangeMax", Float) = 1
		_MiddleRange ("MiddleRange", Float) = 5
		[ASEEnd] _MiddleRangeSoft ("MiddleRangeSoft", Float) = 1
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
Shader "Moon/0Simple/Scene/DefaultScene_TeamColor" {
	Properties {
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		_TeamTwoColor ("TeamTwoColor", Vector) = (1,0,0,0)
		_TeamOneColor ("TeamOneColor", Vector) = (0,0.7980525,1,0)
		_VertexAO ("VertexAO", Range(-1, 1)) = 0
		[Space(10)] [HDR] _HighlightColor ("HighlightColor", Vector) = (1,1,1,0)
		_SmoothnessMax ("SmoothnessMax", Float) = 20
		_SmoothnessMin ("SmoothnessMin", Float) = 2
		_HighlightMin ("HighlightMin", Range(0, 1)) = 0.1
		[Header(GI)] [Toggle(_BAKEDCOLORON_ON)] _BakedColorOn ("BakedColorOn", Float) = 0
		[Header(Rough)] [SingleLineTexture] _RoughMap ("RoughMap", 2D) = "white" {}
		_NormalTiling ("NormalTiling", Float) = 1
		_NormalScale ("NormalScale", Range(0, 1)) = 1
		_Roughness ("Roughness", Range(0, 1)) = 1
		[Header(TeamRange)] _TeamRangeMax ("TeamRangeMax", Float) = 4
		[ASEEnd] _GoaldoorPosition ("GoaldoorPosition", Vector) = (0,0,0,0)
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
	//CustomEditor "BakedGUI"
}
Shader "Moon/0Simple/Scene/BallsDeepTeamColor" {
	Properties {
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		[ASEBegin] [Header(TeamRange)] _TeamOne ("TeamOne", Vector) = (0,0.5548499,1,1)
		_TeamTwo ("TeamTwo", Vector) = (1,0,0,1)
		_TeamColorSoft ("TeamColorSoft", Range(0, 1)) = 1
		_TeamRangeLineUp ("TeamRangeLineUp", Range(0, 1)) = 0
		[Header(GI)] [Toggle(_BAKEDCOLORON_ON)] _BakedColorOn ("BakedColorOn", Float) = 0
		[Header(MaskTex)] [SingleLineTexture] _MaskTex ("MaskTex", 2D) = "white" {}
		_MaskTexTiling ("MaskTexTiling", Float) = 7
		_MaskTexSpace ("MaskTexSpace", Range(2, 6)) = 4
		_MaskTexSpeed ("MaskTexSpeed", Float) = 1
		_TeamOneArrow ("TeamOneArrow", Vector) = (0,1,0.9902086,0)
		_TeamTwoArrow ("TeamTwoArrow", Vector) = (1,0.6894004,0,0)
		[Header(Point)] _PointRadius ("PointRadius", Range(0, 0.5)) = 0.2092862
		[ASEEnd] _PointTiling ("PointTiling", Vector) = (1,1,0,0)
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
Shader "Moon/0Simple/Scene/GoalRing" {
	Properties {
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[ASEBegin] [Header(Space)] [SingleLineTexture] _SpaceTexR ("SpaceTex:R", 2D) = "white" {}
		_SpaceTexMip ("SpaceTexMip", Range(0, 6)) = 0
		_SpaceDeep ("SpaceDeep", Range(0.01, 1)) = 0
		_SpaceSpeed ("SpaceSpeed", Float) = 1
		_SpaceColor ("SpaceColor", Vector) = (1,1,1,0)
		_BackgroundColor ("BackgroundColor", Vector) = (0,0,0,0)
		_SpaceTilingOffset ("SpaceTiling&Offset", Vector) = (1,1,0,0)
		[Header(FarAway)] _SpaceFarAwayColor ("SpaceFarAwayColor", Vector) = (0,0,0,0)
		_SpaceFarAwayOffset ("SpaceFarAwayOffset", Range(-5, 1)) = 0
		_SpaceFarAwaySoft ("SpaceFarAwaySoft", Range(0, 3)) = 0
		[Header(PlaneWave)] _PlaneWaveColor ("PlaneWaveColor", Vector) = (0,0,0,0)
		_PlaneWaveSpeed ("PlaneWaveSpeed", Float) = 1
		_PlaneWaveRange ("PlaneWaveRange", Range(0, 1)) = 0.5058827
		_PlaneWaveSoft ("PlaneWaveSoft", Range(0, 1)) = 0.3999996
		[ASEEnd] _PlaneWaveFrequency ("PlaneWaveFrequency", Float) = 20
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
Shader "Moon/0Simple/Scene/DefaultScene_Door" {
	Properties {
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[Toggle] _IsTeamTwo ("IsTeamTwo", Float) = 0
		_BaseColor ("BaseColor", Vector) = (0,1,0.9596043,1)
		_BaseColor1 ("BaseColor1", Vector) = (0,0.1821904,1,1)
		_ShineSpeed ("ShineSpeed", Float) = 1
		_VertexAO ("VertexAO", Range(-1, 1)) = 0
		[HDR] _HighlightColor ("HighlightColor", Vector) = (1,1,1,0)
		_HighlightPow ("HighlightPow", Range(0, 10)) = 1
		[Toggle(_LIGHTMAPON_ON)] _LightMapOn ("LightMapOn", Float) = 0
		[Toggle] _ThreeColorOn ("ThreeColorOn", Float) = 0
		[HDR] _ThreeColorUp ("ThreeColorUp", Vector) = (0,0.23313,1,0)
		_ThreeColorSide ("ThreeColorSide", Vector) = (1,0,0,0)
		_ThreeColorDown ("ThreeColorDown", Vector) = (0.06978607,1,0,0)
		[SingleLineTexture] _RoughMap ("RoughMap", 2D) = "bump" {}
		_NormalTiling ("NormalTiling", Float) = 1
		_Roughness ("Roughness", Range(0, 1)) = 1
		[ASEEnd] [Toggle(_SIMPLIFIEDON_ON)] _SimplifiedOn ("SimplifiedOn", Float) = 0
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
	//CustomEditor "DefaultSceneDoorGui"
}
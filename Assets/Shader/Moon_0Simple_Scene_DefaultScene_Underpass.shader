Shader "Moon/0Simple/Scene/DefaultScene_Underpass" {
	Properties {
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[SingleLineTexture] _BaseMap ("BaseMap", 2D) = "white" {}
		_VertexAO ("VertexAO", Range(-1, 1)) = 0
		[Space(10)] [Toggle(_BAKEDCOLORON_ON)] _BakedColorOn ("BakedColorOn", Float) = 0
		_BakedColorIntensity ("BakedColorIntensity", Range(0, 100)) = 1
		[Header(Rough)] [SingleLineTexture] [Normal] _RoughMap ("RoughMap", 2D) = "white" {}
		_RoughTiling ("RoughTiling", Float) = 1
		_RoughScale ("RoughScale", Range(0, 1)) = 1
		_Roughness ("Roughness", Range(0, 1)) = 1
		_MoveLineIntervals ("MoveLineIntervals", Range(0, 1)) = 1
		[Header(MoveLine)] _MoveLineHighRange ("MoveLineHighRange", Range(0, 1)) = 1
		_MoveLineHighSpeed ("MoveLineHighSpeed", Float) = 0
		_MoveHighLineSoft ("MoveHighLineSoft", Range(0, 1)) = 0.3
		_MoveLineOffset ("MoveLineOffset", Range(0, 1)) = 0.5
		_MoveLineDownInt ("MoveLineDownInt", Range(0, 1)) = 0.5748727
		[Header(Simplified)] [Toggle(_SIMPLIFIEDON_ON)] _SimplifiedOn ("SimplifiedOn", Float) = 0
		[ASEEnd] [Toggle] _LookBakedColor ("LookBakedColor", Float) = 0
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
Shader "Moon/0Simple/Scene/SimplerHologram" {
	Properties {
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[Toggle(_SAMPLEBASEMAP_ON)] _SampleBaseMap ("SampleBaseMap", Float) = 0
		[SingleLineTexture] _BaseMap ("BaseMap", 2D) = "white" {}
		_BaseColor ("BaseColor", Vector) = (0.5377358,0.5377358,0.5377358,1)
		_LineFreq ("LineFreq", Float) = 200
		_Speed ("Speed", Float) = 10
		_LineOpacity ("LineOpacity", Range(0, 1)) = 0.5
		_FresnelColor ("FresnelColor", Vector) = (1,1,1,0)
		_FresnelRange ("FresnelRange", Range(0, 1)) = 0.09411765
		_FresnelSoft ("FresnelSoft", Range(0, 1)) = 0.2691213
		_FillStart ("FillStart", Float) = 4
		_FillEnd ("FillEnd", Float) = 1
		_Alpha ("Alpha", Range(0, 1)) = 1
		[Toggle] _DissolveOn ("DissolveOn", Float) = 1
		_DissolveOffset ("DissolveOffset", Range(0, 1)) = 0
		_DissolveSoft ("DissolveSoft", Range(0, 1)) = 0.5
		_DissolveMin ("DissolveMin", Float) = -2
		_DissolveMax ("DissolveMax", Float) = 1
		[ASEEnd] [KeywordEnum(WorldY,VertexX,VertexY,VertexZ)] _ScanningLineDirection ("ScanningLineDirection", Float) = 0
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
	//CustomEditor "SimpleHologramGui"
}
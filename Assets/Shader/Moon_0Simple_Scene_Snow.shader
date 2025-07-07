Shader "Moon/0Simple/Scene/Snow" {
	Properties {
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[SingleLineTexture] [Normal] _NormalMap ("NormalMap", 2D) = "bump" {}
		_NormalMapTilingOffset ("NormalMapTilingOffset", Vector) = (1,1,0,0)
		_SnowRange ("SnowRange", Range(-1, 1)) = 0
		_SnowSoft ("SnowSoft", Range(0, 2)) = 1
		_SnowColor1 ("SnowColor1", Vector) = (0,0,0,0)
		_SnowColor2 ("SnowColor2", Vector) = (1,1,1,0)
		_FresnelRange ("FresnelRange", Range(0, 1)) = 0
		_FresnelSoft ("FresnelSoft", Range(0, 1)) = 1
		_FresnelIntensity ("FresnelIntensity", Range(0, 1)) = 1
		[SingleLineTexture] _SnowSpark ("SnowSpark", 2D) = "white" {}
		_SnowSparkTIling ("SnowSparkTIling", Vector) = (1,1,0,0)
		_SparkPower ("SparkPower", Range(0, 10)) = 1
		_SparkInt ("SparkInt", Range(0, 2)) = 1
		_LgihtDir ("LgihtDir", Vector) = (0.5,0.5,0.5,0)
		[Toggle(_BAKEDCOLORON_ON)] _BakedColorOn ("BakedColorOn", Float) = 0
		[HDR] _VertexColor ("VertexColor", Vector) = (0,0.004788588,0.3584906,0)
		[ASEEnd] _VertexColorIntensity ("VertexColorIntensity", Range(0, 5)) = 0
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
	//CustomEditor "SnowGUI"
}
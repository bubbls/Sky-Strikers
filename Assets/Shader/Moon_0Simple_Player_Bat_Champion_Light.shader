Shader "Moon/0Simple/Player/Bat_Champion_Light" {
	Properties {
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		_OutLightSize ("OutLightSize", Range(0, 1)) = 0.2
		_OutLightRange ("OutLightRange", Range(0, 1)) = 0.2352941
		_OutLightSoft ("OutLightSoft", Range(0, 1)) = 1
		_OutLightColor1 ("OutLightColor1", Vector) = (0.1597988,0.3654272,0.5943396,0)
		[HDR] _OutLightColor2 ("OutLightColor2", Vector) = (0,1,0.9725938,0)
		[SingleLineTexture] _NoiseTexture ("NoiseTexture", 2D) = "white" {}
		_NoiseIntensity ("NoiseIntensity", Range(0, 10)) = 0.2
		_NoiseTiling ("NoiseTiling", Float) = 1
		[KeywordEnum(X,Y,Z)] _NoiseDirection ("NoiseDirection", Float) = 0
		[ASEEnd] _AlphaMultiply ("AlphaMultiply", Range(0, 5)) = 1
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
	//CustomEditor "Bat_Champion_Light_GUI"
}
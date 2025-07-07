Shader "Moon/Player/Talking_volume" {
	Properties {
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		[ASEBegin] _Team2 ("Team2", Range(0, 1)) = 0
		_Volume ("Volume", Range(0, 1)) = 0.5
		[HDR] _Team1Color ("Team1Color", Vector) = (1,1,1,0)
		[HDR] _Team2Color ("Team2Color", Vector) = (0,1,0.8535376,0)
		[Space(10)] _SoundTexture ("SoundTexture", 2D) = "white" {}
		_UVSpeed ("UVSpeed", Float) = 0
		_Noise ("Noise", 2D) = "white" {}
		_NoiseItensity ("NoiseItensity", Float) = 0.63
		_NoiseSpeed ("NoiseSpeed", Float) = 1
		[Header(Rim)] [HDR] _EnvironmentColor ("Environment Color", Vector) = (1,1,1,0)
		_RimLightStrength ("Rim Light Strength", Range(0, 1)) = 0.6470588
		[ASEEnd] _RimLIghtPower ("Rim LIght Power", Float) = 5
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
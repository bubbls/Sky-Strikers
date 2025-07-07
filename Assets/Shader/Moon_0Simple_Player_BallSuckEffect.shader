Shader "Moon/0Simple/Player/BallSuckEffect" {
	Properties {
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		[ASEBegin] [SingleLineTexture] _NoiseTex ("NoiseTex", 2D) = "white" {}
		_NoiseTexTiling ("NoiseTexTiling", Vector) = (1,1,0,0)
		_NoiseColor ("NoiseColor", Vector) = (0.8018868,0.4593135,0.2080367,0)
		_NoiseTexSpeed ("NoiseTexSpeed", Vector) = (0,0,0,0)
		_Noise1Color ("Noise1Color", Vector) = (0,0.9896781,1,0)
		_NoiseTex2Speed ("NoiseTex2Speed", Vector) = (0,0,0,0)
		_Diameter ("Diameter", Range(-2, 2)) = 0
		_NoiseTex2Offset ("NoiseTex2Offset", Vector) = (0,0,0,0)
		[SingleLineTexture] _DistortionTex ("DistortionTex", 2D) = "black" {}
		_DistortionIntensity ("DistortionIntensity", Range(0, 1)) = 1
		_DistortionSpeed ("DistortionSpeed", Vector) = (0,0,0,0)
		_DistortionTiling ("DistortionTiling", Vector) = (1,1,0,0)
		[ASEEnd] [Enum(UnityEngine.Rendering.CullMode)] _CollMode ("CollMode", Float) = 2
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
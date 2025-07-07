Shader "ShuttleWindow" {
	Properties {
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		[ASEBegin] _Launch ("Launch", Range(0, 1)) = 0
		[Header(ReflectionProbe)] [SingleLineTexture] _ReflectionProbe ("ReflectionProbe", Cube) = "white" {}
		_ReflectionProbeMip ("ReflectionProbeMip", Range(0, 7)) = 3
		_TensileRange ("TensileRange", Vector) = (0,2.5,0,0)
		[Header(Glass)] _GlassColor ("GlassColor", Vector) = (0,1,1,1)
		_FresnelPow ("FresnelPow", Range(0, 10)) = 1
		[Header(Noise)] [SingleLineTexture] _Noise ("Noise", 2D) = "black" {}
		_NoiseColor ("NoiseColor", Vector) = (0.116901,0.5039381,0.6698113,0)
		[ASEEnd] _NoiseTilingSpeed ("NoiseTilingSpeed", Vector) = (1,1,0,0)
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
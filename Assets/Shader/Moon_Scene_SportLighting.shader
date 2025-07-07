Shader "Moon/Scene/SportLighting" {
	Properties {
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[ASEBegin] _Expand ("Expand", Float) = 0
		_ExpandDirection ("ExpandDirection", Vector) = (1,1,0,0)
		[HDR] _EmissionColor ("EmissionColor", Vector) = (0.6839622,1,0.9937462,0)
		[HDR] _EmissionColor2 ("EmissionColor2", Vector) = (1,1,1,0)
		_ColorOffset ("ColorOffset", Float) = 0
		_ColorSoft ("ColorSoft", Range(0, 1)) = 1
		[Space(10)] _fadeEnd ("fadeEnd", Float) = 5
		_fadePower ("fadePower", Float) = 2
		_DiffusionStart ("DiffusionStart", Float) = 0
		_DiffusionEnd ("DiffusionEnd", Float) = 2
		_DiffusionPower ("DiffusionPower", Float) = 2
		[SingleLineTexture] [Space(10)] _Noise ("Noise", 2D) = "white" {}
		_NoiseIntensity ("NoiseIntensity", Range(0, 1)) = 0
		_NoiseTiling ("NoiseTiling", Vector) = (1,1,0,0)
		_NoiseSpeed ("NoiseSpeed", Vector) = (0,0,0,0)
		[ASEEnd] [Enum(UnityEngine.Rendering.CullMode)] _CullMode ("CullMode", Float) = 0
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
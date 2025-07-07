Shader "Moon/0Simple/Scene/Backdrop" {
	Properties {
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		[ASEBegin] [Header(ReflectionProbe)] [SingleLineTexture] _ReflectionProbe ("ReflectionProbe", Cube) = "white" {}
		_ReflectionProbeMip ("ReflectionProbeMip", Float) = 3
		[Header(Backdrop)] [SingleLineTexture] _Noise ("Noise", 2D) = "white" {}
		_BackdropSoft ("BackdropSoft", Range(0, 2)) = 1
		_FlickerSpeed ("FlickerSpeed", Float) = 1
		_NoiseTiling ("NoiseTiling", Vector) = (1,1,0,0)
		[Header(Line)] _LineRange ("LineRange", Range(0, 1)) = 0
		_LineSoft ("LineSoft", Range(0, 1)) = 1
		[Enum(UnityEngine.Rendering.CullMode)] _CallMode ("CallMode", Float) = 2
		[ASEEnd] [Toggle] _Backdrop1 ("Backdrop1", Float) = 0
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
	//CustomEditor "UnityEditor.ShaderGraphUnlitGUI"
}
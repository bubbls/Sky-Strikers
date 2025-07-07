Shader "Moon/0Simple/Scene/Glass_Unidirectional" {
	Properties {
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		[ASEBegin] [Header(SkyTex)] [SingleLineTexture] _Skybox ("Skybox", Cube) = "black" {}
		_SkyboxMip ("SkyboxMip", Range(0, 8)) = 1
		_SkyboxColor ("SkyboxColor", Vector) = (1,1,1,0)
		_SkyboxOffset ("SkyboxOffset", Vector) = (0,0,0,0)
		[Header(MaskTex)] [SingleLineTexture] _MaskTex ("MaskTex", 2D) = "black" {}
		_MaskTexColor ("MaskTexColor", Vector) = (1,1,1,0.5019608)
		_MaskTexTiling ("MaskTexTiling", Vector) = (1,1,0,0)
		[Header(Fresnel)] _FresnelColor ("FresnelColor", Vector) = (1,1,1,0)
		_Fresnel ("Fresnel", Vector) = (0,1,5,0)
		[ASEEnd] [Enum(UnityEngine.Rendering.CullMode)] _CullMode ("CullMode", Float) = 2
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
Shader "Moon/0Simple/Effect/JetstreamWeaponLink_Alpha" {
	Properties {
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[KeywordEnum(World,Local)] _UV ("UV", Float) = 1
		[Enum(UnityEngine.Rendering.CullMode)] _CullMode ("CullMode", Float) = 2
		[SingleLineTexture] _MaskTex ("MaskTex", 2D) = "white" {}
		[Toggle] _Rotate90Degrees ("Rotate90Degrees", Float) = 0
		_maskTexOffsetY ("maskTexOffsetY", Float) = 0
		_FakeOffest ("FakeOffest", Range(0, 1)) = 0.1
		_FakeSoft ("FakeSoft", Range(0, 1)) = 0.1
		_TensileRatio ("TensileRatio", Range(0, 1)) = 1
		[HDR] _BaseColor ("BaseColor", Vector) = (1,1,1,1)
		_Helical ("Helical", Float) = 0
		_Tiling ("Tiling", Vector) = (1,1,0,0)
		_MaskSpeed ("MaskSpeed", Vector) = (0,0,0,0)
		_Vertex ("Vertex", Vector) = (1,1,1,0)
		[Toggle] _Noise ("Noise", Float) = 0
		[SingleLineTexture] _NoiseTexture ("NoiseTexture", 2D) = "white" {}
		_NoiseTiling ("NoiseTiling", Vector) = (0,0,0,0)
		_NoiseIntensity ("NoiseIntensity", Range(0, 1)) = 1
		_NoiseSpeed ("NoiseSpeed", Vector) = (0,0,0,0)
		_BallPosition ("BallPosition", Vector) = (2,2,1,0)
		[ASEEnd] _RotationSpeed ("RotationSpeed", Range(-1, 1)) = 0
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
	//CustomEditor "JetstreamWeaponLink"
}
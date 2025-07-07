Shader "Moon/0Simple/Player/DefaultCharacter_Transparent" {
	Properties {
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[SingleLineTexture] _AlbedoAEmission ("Albedo A:Emission", 2D) = "white" {}
		_VertexAO ("VertexAO", Range(-1, 1)) = 0
		[Toggle] _EmissionSwitch ("EmissionSwitch", Float) = 0
		[HDR] _EmissionColor ("EmissionColor", Vector) = (1,1,1,1)
		_EmissionSpeed ("EmissionSpeed", Range(0, 20)) = 0
		[HDR] _EmissionColorDown ("EmissionColorDown", Vector) = (0.4056604,0.4056604,0.4056604,1)
		_BacklightOffset ("BacklightOffset", Range(-1.5, 1)) = 0
		_BacklightSoft ("BacklightSoft", Range(0, 2)) = 0.5
		_BacklightColor ("BacklightColor", Vector) = (0.5,0.5,0.5,0)
		_UplightOffset ("UplightOffset", Range(-1.5, 1)) = 0
		_UplightSoft ("UplightSoft", Range(0, 2)) = 0.5
		[HDR] _UplightColor ("UplightColor", Vector) = (0,0,0,1)
		_InnerColor ("InnerColor", Vector) = (1,0.6987091,0,0)
		_InnerOutlineInt ("InnerOutlineInt", Range(0, 1)) = 0
		[SingleLineTexture] _DissolveNoise2U ("DissolveNoise(2U)", 2D) = "white" {}
		[Toggle] _SwitchUV ("SwitchUV", Float) = 0
		[Toggle] _NegateUV ("NegateUV", Float) = 0
		[HDR] _DissolveColor ("DissolveColor", Vector) = (1,1,1,0)
		_DissolveColorSoft ("DissolveColorSoft", Range(0.01, 1)) = 0.1
		_DissolveOffset ("DissolveOffset", Range(0, 1)) = 0
		_DissolveSoft ("DissolveSoft", Range(0.01, 1)) = 0.1
		_DissolveMin ("DissolveMin", Float) = 0
		_DissolveMax ("DissolveMax", Float) = 1
		[ASEEnd] _NoiseTiling ("NoiseTiling", Vector) = (1,1,0,0)
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
	//CustomEditor "DefaultCharacterTransparentGui"
}
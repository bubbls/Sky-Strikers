Shader "Moon/0Simple/Scene/PlayerMelting" {
	Properties {
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[SingleLineTexture] _Noise2 ("Noise2", 2D) = "white" {}
		[Toggle(_DISSOLVEON_ON)] _DissolveOn ("DissolveOn", Float) = 0
		_Noise2Tiling ("Noise2Tiling", Float) = 3
		_Noise2Falloff ("Noise2Falloff", Range(0, 10)) = 5
		_PivotSoft ("PivotSoft", Range(0, 1)) = 0.5
		_DissolveOffset ("DissolveOffset", Range(0, 1)) = 0
		_DissolveMin ("DissolveMin", Float) = 0
		_DissolveMax ("DissolveMax", Float) = 1
		[Toggle] _Reverse ("Reverse", Float) = 0
		_EdgeWidth ("EdgeWidth", Range(0, 0.5)) = 0
		[HDR] _EdgeColor ("EdgeColor", Vector) = (0,1,0.9062204,0)
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
		[Toggle(_LIGHTPROBEON_ON)] _LightProbeOn ("LightProbeOn", Float) = 1
		_LightProbeLerp ("LightProbeLerp", Range(0, 1)) = 0.5
		[ASEEnd] [Toggle(_SIMPLIFIEDON_ON)] _SimplifiedOn ("SimplifiedOn", Float) = 0
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
	//CustomEditor "ShopPlayerMeltingGui"
}
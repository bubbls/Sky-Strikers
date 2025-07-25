Shader "Moon/0Simple/Player/EpicSuit" {
	Properties {
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		_BackgroundColor ("BackgroundColor", Vector) = (0,0,0,0)
		[SingleLineTexture] _StarryTexture ("StarryTexture", 2D) = "white" {}
		_StarryParallaxScale ("StarryParallaxScale", Range(0, 1)) = 0
		_StarrySpeed ("StarrySpeed", Float) = 0.01
		_StarryTiling ("StarryTiling", Float) = 1
		_FresnelColor ("FresnelColor", Vector) = (1,1,1,0)
		_FresnelPow ("FresnelPow", Range(0.01, 10)) = 1
		[Toggle(_MATCAP_ON)] _MatCap ("MatCap", Float) = 0
		[SingleLineTexture] _MatCapTex ("MatCapTex", 2D) = "black" {}
		_MatCapIntensity ("MatCapIntensity", Range(0, 3)) = 1.2
		[Toggle(_EDGELIGHT_ON)] _EdgeLight ("EdgeLight", Float) = 0
		[SingleLineTexture] _EdgeLighMask ("EdgeLighMask", 2D) = "white" {}
		_EdgeLightRange ("EdgeLightRange", Range(0, 1)) = 0
		_EdgeLightSoft ("EdgeLightSoft", Range(0, 1)) = 1
		[ASEEnd] [HDR] _EdgeLightColor ("EdgeLightColor", Vector) = (1,1,1,0)
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
	//CustomEditor "StarrySuitGUI"
}
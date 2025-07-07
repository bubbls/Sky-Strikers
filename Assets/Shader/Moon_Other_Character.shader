Shader "Moon/Other/Character" {
	Properties {
		[Header(Base Color)] [Space] [NoScaleOffset] _BaseMap ("Albedo", 2D) = "white" {}
		_Tilling ("Tilling", Float) = 1
		_DiffuseColor ("Diffuse Color", Vector) = (1,1,1,1)
		_ShadowIntensity ("Global Shadow Intensity", Range(0, 5)) = 1
		[Toggle(_AlphaOn)] _Alpha ("White: Specific Specular Region; Black: Face Shadow", Float) = 0
		_FaceLit ("Face Lit Intensity", Range(0, 1)) = 1
		[Toggle(_ShadowOverrideOn)] _ShadowOverride ("Override Shadow Color", Float) = 0
		_ShadowColor ("Shadow Color", Vector) = (1,1,1,1)
		[Space(20)] [Header(Light Settings)] [Space] _Scale ("Boundary Scale", Range(0, 50)) = 0.15
		_Lower ("Boundary Offset", Range(0, 1)) = 0
		_Intensity ("Light Intensity", Range(0, 10)) = 1
		_SpecularIntensity ("Specular Intensity", Range(0, 5)) = 1
		_IceMultiplier ("Ice Specular Intensity Multiplier", Range(1, 100)) = 1
		[Space(20)] [Header(Normal)] [Space] [Toggle(_NormalOn)] _Normal ("Use Normal Map", Float) = 0
		[NoScaleOffset] [Normal] _BumpMap ("Normal Map", 2D) = "bump" {}
		_BumpScale ("Normal Scale", Range(-1, 2)) = 1
		[Space(20)] [Header(Roughness Metallic AO)] [Space] [Toggle(_PBROn)] _PBR ("Use RMA Texture", Float) = 0
		[NoScaleOffset] _RMATex ("Roughness-Metallic-AO Texture", 2D) = "white" {}
		_Roughness ("Roughness", Range(0, 1)) = 0
		_Metallic ("Metallic", Range(0, 1)) = 0
		_AOColor ("AO Color", Vector) = (0,0,0,1)
		[Toggle(_EmissionOn)] _Emission ("Has Emission", Float) = 0
		[HDR] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		[Space] [Header(Skybox)] [Space] [Toggle(_SkyboxOn)] _Skybox ("Has Reflection", Float) = 0
		[NoScaleOffset] _SkyboxTex ("Environment", Cube) = "white" {}
		_Limit ("Roughness Region Threshold", Range(0, 0.1)) = 0.08
		_SkyboxColor ("Environment Color", Vector) = (1,1,1,1)
		_SkyboxOffset ("Skybox Offset", Vector) = (0,0,0,0)
		[Space(20)] [Header(Rim Light)] [Space] [Toggle(_RimOn)] _Rim ("Enable Rim Light", Float) = 0
		_RimLightColor ("Rim Light Color", Vector) = (1,1,1,1)
		_Distance ("Distance", Range(0, 1)) = 0.2
		_RimMultiplier ("Rim Light Limit Multiplier", Range(0, 1)) = 0.6
		_RimLightStrength ("Rim Light Strength", Range(0, 1)) = 0.2
		[Space(20)] [Header(Fog)] [Space] [Toggle(_FogOn)] _Fog ("Can Be Affected By Fog", Float) = 0
		[Toggle(_ReceiveShadowOn)] _ReceiveShadow ("Receive Shadow", Float) = 0
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
	Fallback "Packages/com.unity.render-pipelines.universal/FallbackError"
}
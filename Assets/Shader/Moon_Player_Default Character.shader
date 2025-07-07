Shader "Moon/Player/Default Character" {
	Properties {
		[SingleLineTexture] _BaseMap ("Albedo", 2D) = "white" {}
		_DiffuseColor ("Diffuse Color", Vector) = (1,1,1,1)
		[Toggle(_EmissionOn)] _Emission ("Emission Map?", Float) = 0
		[HDR] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		_EmissionIntensity ("EmissionIntensity", Range(0, 1)) = 1
		[Toggle(_ExtraEmissionOn)] _ExtraEmission ("Extra Emission Map?", Float) = 0
		[HDR] _ExtraEmissionColor1 ("Extra Emission Color 1", Vector) = (1,1,1,1)
		[HDR] _ExtraEmissionColor2 ("Extra Emission Color 2", Vector) = (1,1,1,1)
		[Toggle(_Shadow2On)] _Shadow2 ("Enable Fixed Soft Shadow?", Float) = 0
		[Toggle(_Shadow1On)] _Shadow1 ("Enable Adjustable Shadow?", Float) = 0
		_Scale ("Boundary Scale - Adjustable Shadow", Range(0.0001, 50)) = 0.05
		_Lower ("Boundary Offset- Adjustable Shadow", Range(0, 1)) = 0
		_Intensity ("Light Intensity", Range(0, 3)) = 1
		_ShadowIntensity ("Shadow Intensity", Range(1, 3)) = 1
		[Toggle(_ShadowOverrideOn)] _ShadowOverride ("Override Shadow Color?", Float) = 0
		_ShadowColor ("Color for Adjustable Shadow", Vector) = (1,1,1,1)
		[Toggle(_SpecularOn)] _Specular ("Enable Specular?", Float) = 0
		[Toggle(_SpecViewOn)] _SpecView ("Specular Color moves with view direction?", Float) = 0
		[SingleLineTexture] _SpecularMask ("Mask for specular area (2 possible layers)", 2D) = "white" {}
		_SpecularColor ("Specular Color", Vector) = (1,1,1,1)
		_SpecularIntensity ("Specular Intensity", Range(0.5, 10)) = 1
		_SpecularStrength ("Specular Strength", Range(0, 1)) = 0.2
		_SpecularOffset ("Specular Offset", Range(0, 1)) = 0.2
		[Toggle(_Specular1On)] _Specular1 ("Enable Specular Layer 2?", Float) = 0
		_SpecularIntensity1 ("Specular Intensity for layer 2?", Range(0.5, 3)) = 1
		[Toggle(_RimOn)] _Rim ("Enable Rim Light?", Float) = 0
		_RimLightStrength ("Rim Light Strength", Range(0, 1)) = 0.2
		_RimLightOffset ("Rim Light Offset", Range(0, 1)) = 0.2
		[HDR] _RimLightColor ("Rim Light Color", Vector) = (1,1,1,1)
		[Toggle(_RimPartOn)] _RimPart ("Different Rim Light for lit and shadow part?", Float) = 0
		[HDR] _RimLightColor1 ("Rim Light Color for Lit part", Vector) = (1,1,1,1)
		[Toggle(_RimShadowOn)] _RimShadow ("Rim Light only in shadow part", Float) = 0
		[Toggle(_OutlineOn)] _Outline ("Outline", Float) = 0
		_OutlineSlider ("OutlineSlider", Range(0, 1)) = 1
		_OutlineMax ("OutlineMax", Range(1, -1)) = 0
		_OutlineColor ("Outline Color", Vector) = (0,0,0,1)
		_EnvUpColor ("EnvUpColor", Vector) = (0,0,0,0)
		_EnvUpInt ("EnvUpInt", Range(0, 2)) = 1
		_EnvSideColor ("EnvSideColor", Vector) = (0,0,0,0)
		_EnvSideInt ("EnvSideInt", Range(0, 2)) = 1
		_EnvDownColor ("DownColor", Vector) = (0,0,0,0)
		_EnvDownInt ("EnvDownInt", Range(0, 2)) = 1
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
	//CustomEditor "DefaultCharacterGUI"
}
Shader "Moon/Effect/Opaque" {
	Properties {
		[Header(Toggle)] [Space] [KeywordEnum(SolidRimLight,Smoke,DefaultUnlit)] _Keyword0 ("Opaque Type", Float) = 0
		[Space(10)] [Header(Basic Rim Settings)] [Space] _RimLightStrength ("Rim Light Strength", Range(0, 1)) = 0.2
		_RimLightOffset ("Rim Light Offset", Range(0, 1)) = 0.2
		[Space(10)] [Header(Smoke)] [Space] [NoScaleOffset] _BaseMap ("Base Map", 2D) = "white" {}
		_Tilling ("Tilling", Range(1, 10)) = 1
		_RimEmission ("Rim Emission", Range(0, 15)) = 1.5
		_Emission ("Emission", Range(0, 15)) = 2
		[Space(10)] [Header(Solid Rim Light)] [Space] [HDR] _Albedo ("Albedo Color", Vector) = (1,1,1,1)
		[HDR] _FresnelColor ("Fresnel Color", Vector) = (1,1,1,1)
		_Intensity ("Light Intensity", Range(1, 10)) = 1
		_ShadowColor ("Shadow Color", Vector) = (1,1,1,1)
		[Space(10)] [Header(Default Unlit)] [Space] _EmissionIntensity ("Emission Intensity", Range(1, 5)) = 1
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
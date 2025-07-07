Shader "Moon/Effect/Transparent" {
	Properties {
		[Header(Toggles)] [Space] [KeywordEnum(PolygonArsenal,VFX_Klaus,DefaultAdd)] _Keyword0 ("VFX Origin", Float) = 0
		[KeywordEnum(ADD,APB)] _Keyword1 ("VFX_Klaus Blend Type", Float) = 0
		[KeywordEnum(SolidGlow,Smoke)] _Keyword2 ("Polygon Arsenal Type", Float) = 0
		[Space(10)] [Header(Basic Settings)] [Space] [NoScaleOffset] _BaseMap ("Base Map", 2D) = "white" {}
		_TintColor ("Tint Color", Vector) = (1,1,1,1)
		_Tilling ("Tilling", Range(0.1, 10)) = 1
		_Offset ("UV Offset", Vector) = (0,0,0,0)
		[Space(10)] [Header(Rim Light for PolygonArsenal and Smoke)] [Space] _RimEmission ("Rim Emission", Range(0, 15)) = 1.5
		_Emission ("Emission", Range(0, 15)) = 2
		_RimLightStrength ("Rim Light Strength", Range(0, 1)) = 0.2
		_RimLightOffset ("Rim Light Offset", Range(0, 1)) = 0.2
		[Space(10)] [Header(Emission Intensity for PolygonArsenal and SolidGlow)] [Space] _Intensity ("Emission Intensity", Range(0, 20)) = 1
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
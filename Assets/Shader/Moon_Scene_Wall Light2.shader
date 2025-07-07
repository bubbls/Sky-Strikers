Shader "Moon/Scene/Wall Light2" {
	Properties {
		[NoScaleOffset] _BaseMap ("Base Map: R(Base) G(Group)", 2D) = "white" {}
		[HDR] _ColorAH ("Color For Team Orange: High", Vector) = (1,1,1,1)
		[HDR] _ColorAM ("Color For Team Orange: Middle", Vector) = (1,1,1,1)
		[HDR] _ColorAL ("Color For Team Orange: Low", Vector) = (1,1,1,1)
		[HDR] _ColorBH ("Color For Team Blue: High", Vector) = (1,1,1,1)
		[HDR] _ColorBM ("Color For Team Blue: Middle", Vector) = (1,1,1,1)
		[HDR] _ColorBL ("Color For Team Blue: Low", Vector) = (1,1,1,1)
		[HDR] _DefaultColorH ("Default Color: High", Vector) = (1,1,1,1)
		[HDR] _DefaultColorM ("Default Color: Middle", Vector) = (1,1,1,1)
		[HDR] _DefaultColorL ("Default Color: Low", Vector) = (1,1,1,1)
		_Frequency ("Alternate Frequency", Range(1, 10)) = 1
		_RimLightStrength ("Rim Light Strength", Range(0, 1)) = 0.2
		[Toggle(_OrangeOn)] _Orange ("Team Orange Wins?", Float) = 0
		[Toggle(_BlueOn)] _Blue ("Team Blue Wins?", Float) = 0
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
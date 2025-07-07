Shader "Fusion Graph Shader" {
	Properties {
		_MainTex ("Sprite Texture", 2D) = "white" {}
		_ColorMask ("Color Mask", Float) = 15
		_GoodColor ("Good Color", Vector) = (0,1,0,1)
		_WarnColor ("Warn Color", Vector) = (0.9,0.6,0,1)
		_BadColor ("Bad Color", Vector) = (1,0,0,1)
		_FlagColor ("Flag Color", Vector) = (1,1,0,1)
		_InvalidColor ("Invalid Color", Vector) = (0,1,1,1)
		_NoneColor ("Flag Color", Vector) = (0,0,0,0)
		_ZWrite ("ZWrite", Float) = 0
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
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

			Texture2D<float4> _MainTex;
			SamplerState sampler_MainTex;

			struct Fragment_Stage_Input
			{
				float2 uv : TEXCOORD0;
			};

			float4 frag(Fragment_Stage_Input input) : SV_TARGET
			{
				return _MainTex.Sample(sampler_MainTex, float2(input.uv.x, input.uv.y));
			}

			ENDHLSL
		}
	}
}
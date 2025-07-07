Shader "PXR/HandRay" {
	Properties {
		_MainTex ("MainTex", 2D) = "white" {}
		_AlphaIntensity ("AlphaIntensity", Range(0, 1)) = 0.5
		[Header(Fresnel)] _FresnelColor ("FresnelColor", Vector) = (1,1,1,1)
		_FresnelSize ("FresnelSize", Range(0, 5)) = 1
		_FresnelPower ("FresnelPower", Range(0, 10)) = 1
		[Space(10)] _NonFresnelColor ("NonFresnelColor", Vector) = (1,1,1,1)
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
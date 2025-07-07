Shader "PXR/Hand" {
	Properties {
		[Header(BaseColor)] _InnerColor ("内部颜色", Vector) = (1,1,1,1)
		_OutColor ("外部颜色", Vector) = (1,1,1,1)
		_FresnelPower ("菲涅尔强度", Float) = 1
		[Header(Light)] [Space(5)] _PressLight ("按下光照", Vector) = (1,1,1,1)
		_ClickLight ("点击光照", Vector) = (1,1,1,1)
		_PressRange ("按压范围", Range(0, 1)) = 0.015
		_ClickRange ("点击范围", Range(0, 1)) = 0.015
		_ClickPosition ("点击位置", Vector) = (1,1,1,1)
		_PressIntensity ("按压强度", Range(0, 1)) = 1
		[Header(Wrist)] [Space(10)] _WristFadeRange ("腕部渐变范围", Range(0, 1)) = 1
		_FadeIn ("透明消隐", Range(0, 1)) = 0
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
}
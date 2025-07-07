Shader "Moon/Scene/Goal Light" {
	Properties {
		[Main(g1, _KEYWORD, on, off)] _Float1 ("带扫光的球场LED颜色", Float) = 1
		[Main(g2, _KEYWORD, on, off)] _Float2 ("队伍颜色", Float) = 1
		[Toggle(_ShowAwayColor)] _Goal ("Show Away Color", Float) = 0
		[Sub(g2)] _HomeColor ("Home Color", Vector) = (1,1,1,1)
		[Sub(g2)] _HomeGColor ("Home Glowing Color", Vector) = (1,1,1,1)
		[Sub(g2)] _AwayColor ("Away Base Color", Vector) = (1,1,1,1)
		[Sub(g2)] _AwayGColor ("Away Glowing Color", Vector) = (1,1,1,1)
		[Main(base, _KEYWORD, on, off)] _Float3 ("固有色", Float) = 1
		[Tex(base)] _BaseMap ("Base Map: R(Color) G(Alternate) B(Type)", 2D) = "white" {}
		[Sub(base)] _BaseMapTiling ("BaseMapTiling", Vector) = (1,1,1,1)
		[Sub(base)] _Intensity ("Intensity", Range(1, 10)) = 10
		[Sub(base)] _DefaultGColor ("Default Glowing Color", Vector) = (1,1,1,1)
		[Main(light, _KEYWORD, on, off)] _Float4 ("扫光", Float) = 1
		[Sub(light)] _Period ("Light Moving Period", Range(1, 2)) = 1.5
		[Sub(light)] _Speed ("Light Moving Speed", Range(1, 10)) = 0
		[Sub(light)] _BoundaryWidth ("Boundary Width", Range(0, 0.5)) = 0.5
		[Main(Flashing, _KEYWORD, on, off)] _Float5 ("频闪", Float) = 1
		[Toggle(_FlashingOn)] _IsHomeGoal ("Flashing On", Float) = 0
		[Sub(Flashing)] _Frequency ("Light Alternate Frequency", Range(1, 100)) = 0
		[Sub(Flashing)] _Extra ("Extra Intensity", Range(0, 10)) = 0
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
	//CustomEditor "LWGUI.LWGUI"
}
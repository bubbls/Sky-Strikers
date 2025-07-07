Shader "Moon/Scene/WarningBraid " {
	Properties {
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		[Main(color, _KEYWORD, on, off) ] _float1 ("警示条", Float) = 0
		[Tex(color)] _WaringMask ("WaringMask", 2D) = "white" {}
		[Sub(color)] _WaringMaskTiling ("WaringMaskTiling", Vector) = (1,1,0,0)
		[Sub(color)] _RedColor ("RedColor", Vector) = (1,0,0,0)
		[Sub(color)] _RedSpeed ("RedSpeed", Vector) = (0,0,0,0)
		[Sub(color)] _YellowColor ("YellowColor", Vector) = (1,0.918384,0,0)
		[Sub(color)] _YellowSpeed ("YellowSpeed", Vector) = (0,0,0,0)
		[Sub(color)] _YellowFlickerFrquency ("YellowFlickerFrquency", Float) = 8
		[Main(mask, _KEYWORD, on, off) ] _Float0 ("Mask", Float) = 0
		[Tex(mask)] _MaskTex ("MaskTex", 2D) = "white" {}
		[Sub(mask)] _MaskTexTiling ("MaskTexTiling", Vector) = (80,40,0,0)
		[ASEEnd] [Sub(mask)] _Alpha ("Alpha", Range(0, 1)) = 1
		[HideInInspector] _QueueOffset ("_QueueOffset", Float) = 0
		[HideInInspector] _QueueControl ("_QueueControl", Float) = -1
		[HideInInspector] [NoScaleOffset] unity_Lightmaps ("unity_Lightmaps", 2DArray) = "" {}
		[HideInInspector] [NoScaleOffset] unity_LightmapsInd ("unity_LightmapsInd", 2DArray) = "" {}
		[HideInInspector] [NoScaleOffset] unity_ShadowMasks ("unity_ShadowMasks", 2DArray) = "" {}
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
	//CustomEditor "LWGUI.LWGUI"
}
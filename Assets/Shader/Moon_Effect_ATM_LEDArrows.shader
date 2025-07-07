Shader "Moon/Effect/ATM/LEDArrows" {
	Properties {
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[Main(g1, _KEYWORD, on, off) ] _Float2 ("玻璃管道能量涌动", Float) = 8.06
		[Header(Vertex)] _Switch ("Switch", Range(-0.5, 1)) = 1
		[Header(BaseColor)] [HDR] _PipelineColor ("PipelineColor", Vector) = (0,0,0,0)
		_FresnelBiasScalePower ("Fresnel/Bias/Scale/Power", Vector) = (0,1,5,0)
		_Noise ("Noise", 2D) = "white" {}
		_NoiseOffset ("NoiseOffset", Float) = 0
		_NoiseSoft ("NoiseSoft", Float) = 0.5
		_NoiseSpeed ("NoiseSpeed", Vector) = (0,0,0,0)
		[Header(Vertex)] [HDR] _VertexColor ("VertexColor", Vector) = (1,1,1,0)
		[HDR] _VertexColor2 ("VertexColor2", Vector) = (1,1,1,0)
		_VertexAmountHardness ("VertexAmountHardness", Float) = 20
		_VertexFrequency ("VertexFrequency", Float) = 5
		_VertexSpeed ("VertexSpeed", Float) = 1
		_VertexRange ("VertexRange", Float) = 0
		_VertexIntensity ("VertexIntensity", Float) = 0
		[ASEEnd] _MaskOffset ("MaskOffset", Range(0, 1)) = 0
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
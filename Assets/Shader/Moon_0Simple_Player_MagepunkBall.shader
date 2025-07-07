Shader "Moon/0Simple/Player/MagepunkBall" {
	Properties {
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[ASEBegin] [Header(Innerline)] _InnerlineRange ("InnerlineRange", Range(0, 1)) = 0.1
		_InnerlineSoft ("InnerlineSoft", Range(0, 1)) = 0.2
		[Header(Noise)] [SingleLineTexture] _Noise ("Noise", 2D) = "white" {}
		_NoiseRange ("NoiseRange", Range(0, 1)) = 0.1
		_NoiseRangeSoft ("NoiseRangeSoft", Range(0, 1)) = 0.1
		_NoiseTilingSpeed1 ("NoiseTilingSpeed", Vector) = (1,1,0,0)
		_NoiseDisruptionInt ("NoiseDisruptionInt", Range(0, 1)) = 0.1
		_NoiseDisruptionTilingSpeed ("NoiseDisruptionTilingSpeed", Vector) = (1,1,0,0)
		[Header(Color)] [HDR] _BaseColor ("BaseColor", Vector) = (0,0.9731085,1,0)
		_BaseColor1 ("BaseColor1", Vector) = (1,1,1,0)
		[Header(Vertex)] _VertexInt ("VertexInt", Range(0, 0.2)) = 0.1
		_VertexNoiseTex ("VertexNoiseTex", Vector) = (1,1,0,0)
		[Header(Shop)] [Toggle(_SHOP_ON)] _Shop ("Shop", Float) = 0
		[HDR] _TeamTwoColor1 ("TeamTwoColor1", Vector) = (0,0.9731085,1,0)
		_TeamTwoColor2 ("TeamTwoColor2", Vector) = (1,1,1,0)
		[HideInInspector] _UpPos ("UpPos", Float) = -643.185
		[HideInInspector] _DownPos ("DownPos", Float) = -643.714
		[ASEEnd] _TipCollapse ("TipCollapse", Float) = 0
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
	//CustomEditor "UnityEditor.ShaderGraphUnlitGUI"
}
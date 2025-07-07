Shader "Moon/Effect/VFX_Scene" {
	Properties {
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[Enum(UnityEngine.Rendering.CullMode)] _CullMode1 ("CullMode1", Float) = 2
		[Main(g1, _KEYWORD, on, off) ] _Float0 ("颜色1", Float) = 0
		[SingleLineTexture] [Tex(g1, _Color1)] _Tex1 ("Tex1", 2D) = "black" {}
		[HideInInspector] [HDR] _Color1 ("Color1", Vector) = (1,1,1,1)
		[Sub(g1)] _Tex1TilingOffset ("Tex1Tiling&Offset", Vector) = (1,1,0,0)
		[Sub(g1)] _Tex1Speed ("Tex1Speed", Vector) = (0,0,0,0)
		[Tex(g1)] _Mask1 ("Mask1", 2D) = "white" {}
		[Sub(g1)] _Mask1TilingOffset ("Mask1Tiling&Offset", Vector) = (1,1,0,0)
		[Main(g2, _KEYWORD, on, off) ] _Float1 ("颜色2", Float) = 0
		[Toggle(_COLOR2ON_ON)] _Color2On ("Color2On", Float) = 0
		[Tex(g2, _Color2)] _Tex2 ("Tex2", 2D) = "black" {}
		[HideInInspector] [HDR] _Color2 ("Color2", Vector) = (0.5754717,0.5754717,0.5754717,1)
		[Sub(g2)] _Tex2TilingOffset ("Tex2Tiling&Offset", Vector) = (1,1,0,0)
		[Sub(g2)] _Tex2Speed ("Tex2Speed", Vector) = (0,0,0,0)
		[Tex(g2)] _Mask2 ("Mask2", 2D) = "white" {}
		[Sub(g2)] _Mask2TilingOffset ("Mask2Tiling&Offset", Vector) = (1,1,0,0)
		[Main(g3, _KEYWORD, on, off) ] _Float2 ("颜色3", Float) = 0
		[Toggle(_COLOR3ON_ON)] _Color3On ("Color3On", Float) = 0
		[Tex(g3, _Color3)] _MainTex3 ("MainTex3", 2D) = "black" {}
		[HideInInspector] [HDR] _Color3 ("Color3", Vector) = (0.3679245,0.3679245,0.3679245,1)
		[Sub(g3)] _Tex3TilingOffset ("Tex3Tiling&Offset", Vector) = (1,1,0,0)
		[Sub(g3)] _Tex3Speed ("Tex3Speed", Vector) = (0,0,0,0)
		[Tex(g3)] _Noise3 ("Noise3", 2D) = "black" {}
		[Sub(g3)] _Noise3TilingOffset ("Noise3Tiling&Offset", Vector) = (1,1,0,0)
		[Sub(g3)] _Noise3Intensity ("Noise3Intensity", Range(0, 1)) = 0.5
		[Sub(g3)] _Noise3Speed ("Noise3Speed", Vector) = (0,0,0,0)
		[Tex(g3)] _MaskTex3 ("MaskTex3", 2D) = "white" {}
		[Sub(g3)] _MaskTex3TilingOffset ("MaskTex3Tiling&Offset", Vector) = (1,1,0,0)
		[Main(g4, _KEYWORD, on, off)] _Float3 ("贴图4", Float) = 0
		[Toggle(_COLOR4ON_ON)] _Color4On ("Color4On", Float) = 0
		[Tex(g4, _Color4)] _Tex4 ("Tex4", 2D) = "black" {}
		[Sub(g4)] _Tex4TilingOffset ("Tex4Tiling&Offset", Vector) = (1,1,0,0)
		[Sub(g4)] _Tex4Speed ("Tex4Speed", Vector) = (0,0,0,0)
		[Tex(g4)] _MaskTex4 ("MaskTex4", 2D) = "white" {}
		[Sub(g4)] _MaskTex4TilingOffset ("MaskTex4Tiling&Offset", Vector) = (1,1,0,0)
		[HideInInspector] [HDR] _Color4 ("Color4", Vector) = (0.2358491,0.2358491,0.2358491,1)
		[Main(g5, _KEYWORD, on, off)] _Float4 ("颜色5", Float) = 0
		[Toggle(_COLOR5ON_ON)] _Color5On ("Color5On", Float) = 0
		[Tex(g5, _Color5)] _Tex5 ("Tex5", 2D) = "black" {}
		[HideInInspector] [HDR] _Color5 ("Color5", Vector) = (0.245283,0.245283,0.245283,1)
		[ASEEnd] [Sub(g5)] _Tex5TilingOffset ("Tex5Tiling&Offset", Vector) = (1,1,0,0)
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
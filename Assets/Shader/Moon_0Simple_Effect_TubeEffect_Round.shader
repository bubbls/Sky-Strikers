Shader "Moon/0Simple/Effect/TubeEffect_Round" {
	Properties {
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		[SingleLineTexture] _MainTex ("MainTex", 2D) = "white" {}
		[IntRange] _MainTexHelical ("MainTexHelical", Range(0, 5)) = 0
		_Speed ("Speed", Vector) = (0,0,0,0)
		[Space(10)] _TubeGeometry ("TubeGeometry", Range(0, 10)) = 1
		_TubeMiddleDistance ("TubeMiddleDistance", Range(0, 1)) = 0.2
		_TilingZCentre ("Tiling(Z=Centre)", Vector) = (1,4,2,0)
		_MaskRange ("MaskRange", Range(0, 1)) = 0
		_MaskSoft ("MaskSoft", Range(0, 1)) = 1
		[Toggle] _TextureIsClamp ("TextureIsClamp", Float) = 0
		[Toggle] _Rotation ("Rotation", Float) = 0
		[ASEEnd] _MainColor ("MainColor", Vector) = (1,1,1,1)
		[HideInInspector] _QueueOffset ("_QueueOffset", Float) = 0
		[HideInInspector] _QueueControl ("_QueueControl", Float) = -1
		[HideInInspector] [NoScaleOffset] unity_Lightmaps ("unity_Lightmaps", 2DArray) = "" {}
		[HideInInspector] [NoScaleOffset] unity_LightmapsInd ("unity_LightmapsInd", 2DArray) = "" {}
		[HideInInspector] [NoScaleOffset] unity_ShadowMasks ("unity_ShadowMasks", 2DArray) = "" {}
		[ToggleOff] [HideInInspector] _ReceiveShadows ("Receive Shadows", Float) = 1
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
	Fallback "Hidden/Shader Graph/FallbackError"
	//CustomEditor "TubeEffectRoundGUI"
}
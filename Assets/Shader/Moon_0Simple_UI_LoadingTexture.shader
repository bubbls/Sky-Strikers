Shader "Moon/0Simple/UI/LoadingTexture" {
	Properties {
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[Toggle(_TEXTURE0_ON_ON)] _Texture0_On ("Texture0_On", Float) = 0
		[SingleLineTexture] _Texture0 ("Texture0", 2D) = "white" {}
		_Texture0_ResizingX ("Texture0_ResizingX", Float) = 1
		_Texture0_ResizingY ("Texture0_ResizingY", Float) = 0
		_Texture0_OffsetX ("Texture0_OffsetX", Float) = 0
		_Texture0_OffsetY ("Texture0_OffsetY", Float) = 0
		_Texture0_MoveIntensity ("Texture0_MoveIntensity", Range(-1, 1)) = 0
		[Toggle(_TEXTURE1_ON_ON)] _Texture1_On ("Texture1_On", Float) = 0
		[SingleLineTexture] _Texture1 ("Texture1", 2D) = "white" {}
		_Texture1_ResizingX ("Texture1_ResizingX", Float) = 1
		_Texture1_ResizingY ("Texture1_ResizingY", Float) = 0
		_Texture1_OffsetX ("Texture1_OffsetX", Float) = 0
		_Texture1_OffsetY ("Texture1_OffsetY", Float) = 0
		_Texture1_MoveIntensity ("Texture1_MoveIntensity", Range(-1, 1)) = 0
		[Toggle(_TEXTURE2_ON_ON)] _Texture2_On ("Texture2_On", Float) = 0
		[SingleLineTexture] _Texture2 ("Texture2", 2D) = "white" {}
		_Texture2_ResizingX ("Texture2_ResizingX", Float) = 1
		_Texture2_ResizingY ("Texture2_ResizingY", Float) = 0
		_Texture2_OffsetX ("Texture2_OffsetX", Float) = 0
		_Texture2_OffsetY ("Texture2_OffsetY", Float) = 0
		_Texture2_MoveIntensity ("Texture2_MoveIntensity", Range(-1, 1)) = 0
		[Toggle(_TEXTURE3_ON_ON)] _Texture3_On ("Texture3_On", Float) = 0
		[SingleLineTexture] _Texture3 ("Texture3", 2D) = "white" {}
		_Texture3_ResizingX ("Texture3_ResizingX", Float) = 1
		_Texture3_ResizingY ("Texture3_ResizingY", Float) = 0
		_Texture3_OffsetX ("Texture3_OffsetX", Float) = 0
		_Texture3_OffsetY ("Texture3_OffsetY", Float) = 0
		_Texture3_MoveIntensity ("Texture3_MoveIntensity", Range(-1, 1)) = 0
		[Toggle(_NOISEMOVEON_ON)] _NoiseMoveOn ("NoiseMoveOn", Float) = 0
		[SingleLineTexture] _NoiseMove ("NoiseMove", 2D) = "black" {}
		_NoiseMoveTiling ("NoiseMoveTiling", Float) = 0.1
		[ASEEnd] _NoiseMoveSpeed ("NoiseMoveSpeed", Float) = 1
		[HideInInspector] _QueueOffset ("_QueueOffset", Float) = 0
		[HideInInspector] _QueueControl ("_QueueControl", Float) = -1
		[HideInInspector] [NoScaleOffset] unity_Lightmaps ("unity_Lightmaps", 2DArray) = "" {}
		[HideInInspector] [NoScaleOffset] unity_LightmapsInd ("unity_LightmapsInd", 2DArray) = "" {}
		[HideInInspector] [NoScaleOffset] unity_ShadowMasks ("unity_ShadowMasks", 2DArray) = "" {}
		[ToggleOff] [HideInInspector] _ReceiveShadows ("Receive Shadows", Float) = 1
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
	//CustomEditor "LoadingTextureGui"
}
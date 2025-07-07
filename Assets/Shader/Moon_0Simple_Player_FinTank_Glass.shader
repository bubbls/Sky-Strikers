Shader "Moon/0Simple/Player/FinTank_Glass" {
	Properties {
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		[SingleLineTexture] _BaseMap ("BaseMap", 2D) = "white" {}
		_BaseColor ("BaseColor", Vector) = (0,0,0,0)
		[SingleLineTexture] _MatCap ("MatCap", 2D) = "white" {}
		_MatCapColor ("MatCapColor", Vector) = (1,1,1,1)
		[SingleLineTexture] _BubbleTexture ("BubbleTexture", 2D) = "white" {}
		_BubbleColor ("BubbleColor", Vector) = (0.3474991,0.5341573,0.5377358,0)
		_BubbleXSpeed ("BubbleXSpeed", Range(0, 1)) = 1
		_BubbleXIntensity ("BubbleXIntensity", Range(0, 1)) = 1
		_BubbleTilingSpeed ("BubbleTilingSpeed", Vector) = (1,1,0,0)
		_FresnelRange ("FresnelRange", Range(0.1, 10)) = 1
		_FresnelColor ("FresnelColor", Vector) = (1,1,1,1)
		[ASEEnd] _BackgroundColor ("BackgroundColor", Vector) = (0.3474991,0.5341573,0.5377358,0)
		[HideInInspector] _texcoord ("", 2D) = "white" {}
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
	//CustomEditor "FinTankGlass"
}
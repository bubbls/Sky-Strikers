Shader "Moon/0Simple/Scene/IceTransparent" {
	Properties {
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[SingleLineTexture] [Normal] _NormalMap ("NormalMap", 2D) = "bump" {}
		_NormalScale ("NormalScale", Range(0, 3)) = 1
		_NormalTiling ("NormalTiling", Vector) = (1,1,0,0)
		[SingleLineTexture] _InnerIceTexture ("InnerIceTexture", 2D) = "white" {}
		_InnerIceParallaxScale ("InnerIceParallaxScale", Range(0, 1)) = 0
		_InnerIcePower ("InnerIcePower", Range(0, 10)) = 1
		_IceHighColor ("IceHighColor", Vector) = (0,0.9301291,1,0)
		_IceLowColor ("IceLowColor", Vector) = (0,0,0,0)
		[SingleLineTexture] _CracklesTexture ("CracklesTexture", 2D) = "white" {}
		_CracklesPower ("CracklesPower", Range(0, 10)) = 1
		_CracklesColor ("CracklesColor", Vector) = (0,0.707391,1,0)
		_CracklesTiling ("CracklesTiling", Vector) = (1,1,0,0)
		_FresnelRange ("FresnelRange", Range(0, 1)) = 0
		_FresnelSoft ("FresnelSoft", Range(0, 1)) = 1
		_FresnelAdded ("FresnelAdded", Range(0, 1)) = 0
		_FresnelColor ("FresnelColor", Vector) = (1,1,1,1)
		_IceTransparency ("IceTransparency", Range(0, 1)) = 0.5
		_BackgroundFresnelPower ("BackgroundFresnelPower", Range(0, 10)) = 1
		_BackgroundColor1 ("BackgroundColor1", Vector) = (1,1,1,0)
		_BackgroundColor2 ("BackgroundColor2", Vector) = (0,0,0,0)
		_BackgroundCrackles ("BackgroundCrackles", Vector) = (0.7322891,0.8160606,0.8301887,0)
		_InnerIceFrontDistort ("InnerIceFrontDistort", Float) = 0.5
		[ASEEnd] _InnerIceFrontTilingOffset ("InnerIceFrontTilingOffset", Vector) = (0.1,0.1,0.3,0.3)
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
	//CustomEditor "IceTransparentGUI"
}
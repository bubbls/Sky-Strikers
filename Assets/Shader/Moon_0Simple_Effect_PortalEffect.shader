Shader "Moon/0Simple/Effect/PortalEffect" {
	Properties {
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[SingleLineTexture] _NoiseTexNoMip ("NoiseTex(NoMip)", 2D) = "white" {}
		_NoiseColor ("NoiseColor", Vector) = (0,0.9999995,1,1)
		_NoiseMaskOffset ("NoiseMaskOffset", Range(0, 3)) = 0
		_NoiseMaskSoft ("NoiseMaskSoft", Range(0, 1)) = 0
		_NoiseTexPow ("NoiseTexPow", Range(0, 5)) = 1
		_NoiseTilingSpeed ("NoiseTiling&Speed", Vector) = (1,0.66,-0.2,0.5)
		[SingleLineTexture] _SpaceTex ("SpaceTex", 2D) = "white" {}
		_SpaceTexMip ("SpaceTexMip", Range(0, 6)) = 0
		_SpaceDeep ("SpaceDeep", Range(0.01, 1)) = 0
		_SpaceSpeed ("SpaceSpeed", Float) = 1
		_SpaceColor ("SpaceColor", Vector) = (1,1,1,0)
		_SpaceColor2 ("SpaceColor2", Vector) = (1,1,1,0)
		_SpaceTilingOffset ("SpaceTiling&Offset", Vector) = (1,1,0,0)
		_SpaceFarAwayColor ("SpaceFarAwayColor", Vector) = (0,0,0,0)
		_SpaceFarAwayOffset ("SpaceFarAwayOffset", Range(-5, 0.99)) = -2.602024
		_SpaceFarAwaySoft ("SpaceFarAwaySoft", Range(0, 3)) = 0
		[Toggle(_SPACEFARAWAYTEXTUREON_ON)] _SpaceFarAwayTextureOn ("SpaceFarAwayTextureOn", Float) = 0
		[SingleLineTexture] _SpaceFarAwayTexture ("SpaceFarAwayTexture", 2D) = "white" {}
		_SpaceFarAwayTextureSize ("SpaceFarAwayTextureSize", Vector) = (1,1,0,0)
		_SpaceNoiseIntensity ("SpaceNoiseIntensity", Range(0, 1)) = 0.2
		_DoorSwitch ("DoorSwitch", Range(0, 1)) = 1
		_DoorSwitchSoft ("DoorSwitchSoft", Range(0, 1)) = 0.1
		_DoorSwitchMin ("DoorSwitchMin", Float) = -0.1
		_DoorSwitchMax ("DoorSwitchMax", Float) = 1
		[SingleLineTexture] _InnerLineTex ("InnerLineTex", 2D) = "black" {}
		_DoorOffBackgroundColor ("DoorOffBackgroundColor", Vector) = (0,0,0,0)
		_BackgroundColor ("BackgroundColor", Vector) = (0,0,0,0)
		_AlphaOffset ("AlphaOffset", Range(-1, 1)) = 0
		_AlphaSoft ("AlphaSoft", Range(0, 1)) = 1
		_ApertureColor ("ApertureColor", Vector) = (1,1,1,0)
		_NoiseInt ("NoiseInt", Range(0, 10)) = 2
		[Toggle(_COLORTEXON_ON)] _ColorTexOn ("ColorTexOn", Float) = 0
		[SingleLineTexture] _ColorTexAInner ("ColorTex A:Inner", 2D) = "black" {}
		_ColorTextureInt ("ColorTextureInt", Range(0, 2)) = 1
		_ColorTexColor ("ColorTexColor", Vector) = (1,0.2028302,0.2028302,0)
		_ColorTexTiling ("ColorTexTiling", Vector) = (1,1,0,0)
		[Enum(UnityEngine.Rendering.CullMode)] _CullMode ("CullMode", Float) = 2
		_ApertureColor2 ("ApertureColor2", Vector) = (1,1,1,0)
		_NumberOfSpirals ("NumberOfSpirals", Float) = 0
		[ASEEnd] [Toggle] _SpaceFarAwayTextureRevolve ("SpaceFarAwayTextureRevolve", Float) = 0
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
	//CustomEditor "PortalEffectGUI"
}
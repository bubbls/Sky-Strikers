Shader "Moon/0Simple/Scene/Leveling" {
	Properties {
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[ASEBegin] _LevelingWidth ("LevelingWidth", Range(0, 1)) = 0.4941177
		_LevelingMove ("LevelingMove", Range(0, 1)) = 0.3089167
		[Space(10)] _LevelingColor ("LevelingColor", Vector) = (0.09411766,0.9803922,0.7058824,1)
		[HDR] _LevelingColor2 ("LevelingColor2", Vector) = (0,0.7734165,0.6338982,0)
		_LevelingColorSoft ("LevelingColorSoft", Range(0, 1)) = 0.1058823
		[Space(10)] _AlphaSoft ("AlphaSoft", Range(0, 1)) = 0.1058823
		_GlassColor ("GlassColor", Vector) = (1,1,1,0)
		[Space(10)] [Toggle(_MATCAPON_ON)] _MatCapOn ("MatCapOn", Float) = 0
		[SingleLineTexture] _MatCap ("MatCap", 2D) = "black" {}
		_MatCapMip ("MatCapMip", Range(0, 8)) = 1
		_MatCapIntensity ("MatCapIntensity", Range(0, 3)) = 1.2
		_FresnelBiasScalePower ("Fresnel/Bias/Scale/Power", Vector) = (0,1,2,0)
		[Toggle(_LEVELINGTEXTUREON_ON)] _LevelingTextureOn ("LevelingTextureOn", Float) = 0
		[SingleLineTexture] _LevelingTexture ("LevelingTexture", 2D) = "white" {}
		_LevelingTextureTiling ("LevelingTextureTiling", Vector) = (1,1,0,0)
		_LevelingColorSpeed2 ("LevelingColorSpeed2", Vector) = (0,0,0,0)
		_LevelingDistortionIntensity ("LevelingDistortionIntensity", Range(0, 1)) = 0.2
		[ASEEnd] _LevelingDistortionSpeed ("LevelingDistortionSpeed", Vector) = (0,0,0,0)
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
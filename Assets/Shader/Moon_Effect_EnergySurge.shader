Shader "Moon/Effect/EnergySurge" {
	Properties {
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		[Main(leveling, _KEYWORD, on, off) ] _Float4 ("经验条百分比", Float) = 0
		[Sub(leveling)] _LevelingWidth ("LevelingWidth", Range(0, 1)) = 0.4941177
		[Sub(leveling)] _LevelingMove ("LevelingMove", Range(0, 1)) = 0.3089167
		[Sub(leveling)] _LevelingSoft ("LevelingSoft", Range(0, 1)) = 0.1058823
		[Main(fresnel, _KEYWORD, on, off) ] _Float1 ("轮廓光(RimmingLight)", Float) = 0
		[Sub(fresnel)] _RimmingColor ("RimmingColor", Vector) = (0.8726415,1,0.9756181,0)
		[Sub(fresnel)] _FresnelBiasScalePower ("Fresnel/Bias/Scale/Power", Vector) = (0,1,2,0)
		[Main(Energy, _KEYWORD, on, off) ] _Float3 ("能量涌动(EnergySurge)", Float) = 0
		[Color(Energy, _EnergyColor2)] _SurgeColor ("SurgeColor", Vector) = (0,1,0.8980392,0)
		[HideInInspector] _EnergyColor2 ("EnergyColor2", Vector) = (0,0.6262352,1,0)
		[Sub(Energy)] _SurgeFrequency ("SurgeFrequency", Float) = 10
		[Sub(Energy)] _SurgeSpeed ("SurgeSpeed", Float) = 10
		[Sub(Energy)] _SurgeVertexIntensity ("SurgeVertexIntensity", Float) = 30
		[ASEEnd] _Alpha ("Alpha", Range(0, 1)) = 1
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
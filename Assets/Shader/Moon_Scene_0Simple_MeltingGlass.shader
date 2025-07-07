Shader "Moon/Scene/0Simple/MeltingGlass" {
	Properties {
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		[ASEBegin] [Toggle(_REVERSE_ON)] _Reverse ("Reverse", Float) = 0
		_DissolveMin ("DissolveMin", Float) = 0
		_DissolveMax ("DissolveMax", Float) = 1
		_DissolveOffset ("DissolveOffset", Range(0, 1)) = 0
		_PivotScale ("PivotScale", Range(0, 1)) = 0.5
		[SingleLineTexture] _Noise2 ("Noise2", 2D) = "white" {}
		_Noise2Tiling ("Noise2Tiling", Vector) = (1,1,0,0)
		[Header(Color)] [SingleLineTexture] [HDR] _Environment ("Environment", Cube) = "black" {}
		[HDR] _EnvironmentColor ("Environment Color", Vector) = (1,1,1,0)
		_RimLightStrength ("Rim Light Strength", Range(0, 1)) = 0.6470588
		_RimLIghtPower ("Rim LIght Power", Range(0, 10)) = 1
		_RimLightBias ("RimLightBias", Range(0, 1)) = 0.3
		[Space(10)] _EdgeWidth ("EdgeWidth", Range(0, 0.5)) = 0
		[ASEEnd] [HDR] _EdgeColor ("EdgeColor", Vector) = (0,1,0.9062204,0)
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
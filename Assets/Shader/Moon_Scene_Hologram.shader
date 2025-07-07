Shader "Moon/Scene/Hologram" {
	Properties {
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[ASEBegin] [Space(10)] _MainColor ("MainColor", Vector) = (0.4433962,0.2393077,0.09411713,0)
		_FresnelBias ("FresnelBias", Range(0, 1)) = 0.5
		_FresnelScale ("FresnelScale", Range(0, 1)) = 1
		_FresnelPower ("FresnelPower", Float) = 5
		_FresnelColor ("FresnelColor", Vector) = (1,1,1,0)
		[SingleLineTexture] [Space(10)] _ScanlineTex ("ScanlineTex", 2D) = "white" {}
		_ScanlineSpeed ("ScanlineSpeed", Float) = 1
		_ScanlineFreq ("ScanlineFreq", Float) = 10
		_ScanlineIntensity ("ScanlineIntensity", Range(0, 1)) = 0.7411765
		[Space(10)] _DisturbanceFrequency ("DisturbanceFrequency", Float) = 0.5
		_DisturbanceSpeed ("DisturbanceSpeed", Float) = -0.1
		_DisturbanceWidth ("DisturbanceWidth", Float) = 0.99
		_DisturbanceDirection ("DisturbanceDirection", Vector) = (0.5,0,0,0)
		[Space(10)] _UpDownSpeed ("UpDownSpeed", Float) = 2
		[ASEEnd] _UpDownDirection ("UpDownDirection", Vector) = (0,2,0,0)
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
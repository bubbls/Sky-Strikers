Shader "Moon/Player/Talking_volume_bar" {
	Properties {
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		[ASEBegin] [Toggle] _Team2 ("Team2", Range(0, 1)) = 1
		_Volume ("Volume", Range(0, 1)) = 0
		_VolumeMin ("VolumeMin", Float) = -0.2
		_VolumeMax ("VolumeMax", Float) = 1
		_GridQuantity ("GridQuantity", Float) = 10
		_VolumeColorSoft ("VolumeColorSoft", Range(0, 1)) = 0
		[Space(10)] _BaseColor ("BaseColor", Vector) = (0.1603774,0.1603774,0.1603774,0)
		_Team1Color ("Team1Color", Vector) = (0.6509434,0.6509434,0.6509434,0)
		_Team1ColorHeight ("Team1ColorHeight", Vector) = (1,1,1,0)
		_Team2Color ("Team2Color", Vector) = (0.6509434,0.6509434,0.6509434,0)
		[ASEEnd] _Team2ColorHeight ("Team2ColorHeight", Vector) = (1,1,1,0)
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
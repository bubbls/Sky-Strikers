Shader "Moon/0Simple/Effect/TubeEffect2" {
	Properties {
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		[ASEBegin] [SingleLineTexture] _MaskTexture ("MaskTexture", 2D) = "white" {}
		[SingleLineTexture] _MaskTexture2 ("MaskTexture2", 2D) = "white" {}
		_MaskColorIntensity ("MaskColorIntensity", Range(0, 4)) = 1
		_MaskTextureMip ("MaskTextureMip", Range(0, 5)) = 1
		_MaskTextureTiling ("MaskTextureTiling", Float) = 1
		_MaskTextureSpeed ("MaskTextureSpeed", Float) = 0
		_Position ("Position", Vector) = (0,0,0,0)
		[Space(10)] _TubeGeometry ("TubeGeometry", Range(0, 10)) = 1
		_TubeMiddleDistance ("TubeMiddleDistance", Range(0, 1)) = 0.2
		[Space(10)] _DoorSwitch ("DoorSwitch", Range(0, 1)) = 1
		_Color1 ("Color 1", Vector) = (1,0,0,0)
		[ASEEnd] _Color0 ("Color 0", Vector) = (0.2917078,1,0,0)
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
	//CustomEditor "UnityEditor.ShaderGraphUnlitGUI"
}
Shader "Moon/0Simple/Scene/AirWall" {
	Properties {
		[Enum(UnityEngine.Rendering.CullMode)] _CullMode ("CullMode", Float) = 2
		[Header(BallPosition)] [SingleLineTexture] _BaseMap ("Base Map", 2D) = "white" {}
		_BaseColor ("Base Color", Vector) = (1,1,1,0)
		_BallHighlight ("Highlight Intensity", Range(1, 10)) = 10
		_DetectionRegion ("Detection Region", Range(0, 5)) = 2
		_BoundaryWidth ("Boundary Width", Range(0, 1)) = 1
		_Tilling ("Tilling", Vector) = (1,1,0,0)
		[Header(PlayerWall)] [Toggle(_PLAYERWALL_ON)] _PlayerWallOn ("PlayerWallOn", Float) = 0
		[SingleLineTexture] _PlayerWallTex ("PlayerWallTex", 2D) = "white" {}
		_PlayerWallTexSpace ("PlayerWallTexSpace", Float) = 0
		_PlayerWallTiling ("PlayerWallTiling", Vector) = (1,1,1,1)
		_PlayerWallRadius ("PlayerWallRadius", Float) = 0
		_PlayerWallColor ("PlayerWallColor", Vector) = (1,0,0,1)
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
}
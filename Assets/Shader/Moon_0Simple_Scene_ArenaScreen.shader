Shader "Moon/0Simple/Scene/ArenaScreen" {
	Properties {
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[ASEBegin] _MaskColorInt ("MaskColorInt", Range(0, 1)) = 1
		[Toggle] [Space(5)] _CountdownOn ("CountdownOn", Float) = 1
		_ClockCountDown ("ClockCountDown", Range(0, 1)) = 0
		_Countdown ("Countdown", Range(0, 1)) = -1
		[IntRange] _Num ("Num", Range(0, 10)) = 1
		[Toggle] [Space(5)] _ScoringMode ("ScoringMode", Float) = 0
		[IntRange] _ScoreTeamOne ("ScoreTeamOne", Range(0, 5)) = 0
		[IntRange] _ScoreTeamTwo ("ScoreTeamTwo", Range(0, 5)) = 0
		[Header(Goal)] [SingleLineTexture] _GoalEffect ("GoalEffect", 2D) = "black" {}
		_GoalEffectSpeed ("GoalEffectSpeed", Float) = 1
		_GoalColor1 ("GoalColor1", Vector) = (0.5828468,0,0.8125821,0)
		_GoalColor ("GoalColor", Vector) = (0.5841841,0.06132078,1,0)
		_GoalEffectTilingOffset ("GoalEffectTilingOffset", Vector) = (1,1,0,0)
		[Header(Background)] _BackgroundRange ("BackgroundRange", Range(0, 1)) = 0
		_BackgroundSoft ("BackgroundSoft", Range(0, 1)) = 1
		_BackGroundColor2 ("BackGroundColor2", Vector) = (1,1,1,0)
		_BackGroundColor1 ("BackGroundColor1", Vector) = (0,0,0,0)
		_BackgroundLineRange ("BackgroundLineRange", Range(0, 1)) = 0.9
		_BackgroundLineInt ("BackgroundLineInt", Range(0, 1)) = 0
		_BackgroundTiling ("BackgroundTiling", Vector) = (1,1,0,0)
		[Header(Clock)] [SingleLineTexture] _Clock ("Clock", 2D) = "black" {}
		_ClockOutRange ("ClockOutRange", Float) = -10.34
		_ClockDownColor ("ClockDownColor", Vector) = (0.138172,0.2049981,0.254717,0)
		_ClockUpColor ("ClockUpColor", Vector) = (0.2284176,0.7024311,0.8207547,0)
		_ClockOffset ("ClockOffset", Range(0, 1)) = 0.85
		_ClockSoft ("ClockSoft", Range(0, 1)) = 0.1
		_ClockBeginning ("ClockBeginning", Range(0, 1)) = 1
		_ClockCenter ("ClockCenter", Vector) = (1,1,0,0)
		_ClockTilingOffset ("ClockTilingOffset", Vector) = (1,1,0,0)
		[Header(Cuntdown)] [SingleLineTexture] _CountdownTexture ("CountdownTexture", 2D) = "black" {}
		_CountdownBGInt ("CountdownBGInt", Range(0, 1)) = 0.1
		_CountdownOffset ("CountdownOffset", Vector) = (1,1,0,0)
		[Header(Num)] [SingleLineTexture] _NumTexture ("NumTexture", 2D) = "black" {}
		_NumBevel ("NumBevel", Range(-1, 1)) = 1
		_NumColor ("NumColor", Vector) = (0,0.7445183,1,0)
		_NumRowCount ("NumRowCount", Float) = 1
		_NumColumnsCount ("NumColumnsCount", Float) = 1
		_NumOffsetVertically ("NumOffsetVertically", Float) = 0
		_NumScaleAndOffset ("NumScaleAndOffset", Vector) = (1,1,0,0)
		[SingleLineTexture] _GoalBackground ("GoalBackground", 2D) = "white" {}
		_GoalBackgroundScaleOffset ("GoalBackgroundScaleOffset", Vector) = (1,1,0,0)
		[Header(ScoreMode)] [SingleLineTexture] _ScoreTexture ("ScoreTexture", 2D) = "black" {}
		_TeamOneColor1 ("TeamOneColor1", Vector) = (0,0.9400835,1,0)
		_TeamOneColor0 ("TeamOneColor0", Vector) = (0,0.1608472,1,0)
		_TeamTwoColor1 ("TeamTwoColor1", Vector) = (0,0.9400835,1,0)
		_TeamTwoColor0 ("TeamTwoColor0", Vector) = (0,0.1608472,1,0)
		_ScoreTextureScaleOffset ("ScoreTextureScaleOffset", Vector) = (1,1,0,0)
		[ASEEnd] [Toggle] _TeamTwo ("TeamTwo", Float) = 0
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
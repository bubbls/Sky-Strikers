Shader "VFX/PandaShaderSampleURPV1.0" {
	Properties {
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[Enum(UnityEngine.Rendering.BlendMode)] _Scr ("Scr", Float) = 5
		[Enum(UnityEngine.Rendering.BlendMode)] _Dst ("Dst", Float) = 10
		[Enum(UnityEngine.Rendering.CullMode)] _CullMode ("CullMode", Float) = 0
		_MainTex ("MainTex", 2D) = "white" {}
		[Toggle] _MainTexIsClamp ("MainTexIsClamp", Float) = 0
		[Toggle] _MainTexRotation ("MinTexRotation", Float) = 0
		_VTOTex ("VTOTex", 2D) = "black" {}
		[Toggle] _VTOTexAR ("VTOTexAR", Float) = 1
		[Toggle] _VTONormal ("VTONormal", Float) = 0
		[Toggle] _MainTexAR ("MainTexAR", Float) = 0
		[Toggle(_MAINTEXRG_ON)] _MainTexRG ("MainTexRG", Float) = 0
		[HDR] _MainGColor ("MainGColor", Vector) = (1,1,1,1)
		_MainGSpeed ("MainGSpeed", Vector) = (0,0,0,0)
		_MainGTiling ("MainGTiling", Vector) = (1,1,0,0)
		[HDR] _MainColor ("MainColor", Vector) = (1,1,1,1)
		_VTOTexUSpeed ("VTOTexUSpeed", Float) = 0
		_MainTexUSpeed ("MainTexUSpeed", Float) = 0
		_MainTexVSpeed ("MainTexVSpeed", Float) = 0
		_VTOTexVSpeed ("VTOTexVSpeed", Float) = 0
		[Toggle] _CustomMainTex ("CustomMainTex", Float) = 0
		[Toggle(_FMASKTEX_ON)] _FMaskTex ("FMaskTex", Float) = 0
		_MaskTex ("MaskTex", 2D) = "white" {}
		[Toggle] _MaskTexAR ("MaskTexAR", Float) = 1
		_MaskTexUSpeed ("MaskTexUSpeed", Float) = 0
		_MaskTexVSpeed ("MaskTexVSpeed", Float) = 0
		[Toggle(_FDISTORTTEX_ON)] _FDistortTex ("FDistortTex", Float) = 0
		_DistortTex ("DistortTex", 2D) = "white" {}
		[Toggle] _DistortTexAR ("DistortTexAR", Float) = 1
		_DistortFactor ("DistortFactor", Range(0, 1)) = 0
		_DistortTexUSpeed ("DistortTexUSpeed", Float) = 0
		_DistortTexVSpeed ("DistortTexVSpeed", Float) = 0
		[Toggle] _DistortMainTex ("DistortMainTex", Float) = 0
		[Toggle] _DistortMaskTex ("DistortMaskTex", Float) = 0
		[Toggle] _DistortDissolveTex ("DistortDissolveTex", Float) = 0
		[Toggle(_FDISSOLVETEX_ON)] _FDissolveTex ("FDissolveTex", Float) = 0
		_DissolveTex ("DissolveTex", 2D) = "white" {}
		[Toggle] _DissolveTexAR ("DissolveTexAR", Float) = 1
		[HDR] _DissolveColor ("DissolveColor", Vector) = (1,1,1,1)
		[Toggle] _CustomDissolve ("CustomDissolve", Float) = 0
		_DissolveFactor ("DissolveFactor", Range(0, 1)) = 0
		_DissolveSoft ("DissolveSoft", Range(0, 1)) = 0.1
		_DissolveWide ("DissolveWide", Range(0, 1)) = 0.05
		_DissolveTexUSpeed ("DissolveTexUSpeed", Float) = 0
		_DissolveTexVSpeed ("DissolveTexVSpeed", Float) = 0
		_MainAlpha ("MainAlpha", Range(0, 10)) = 1
		[Toggle(_FFNL_ON)] _FFnl ("FFnl", Float) = 0
		[HDR] _FnlColor ("FnlColor", Vector) = (1,1,1,1)
		_FnlScale ("FnlScale", Range(0, 2)) = 0
		_FnlPower ("FnlPower", Range(1, 10)) = 1
		[Toggle] _ReFnl ("ReFnl", Float) = 0
		[Enum(Alpha,0,Add,1)] _BlendMode ("BlendMode", Float) = 0
		[Enum(UnityEngine.Rendering.CompareFunction)] _ZTest ("ZTest", Float) = 4
		_DepthFade ("DepthFade", Range(0, 10)) = 1
		[Toggle(_IFVTO_ON)] _IfVTO ("IfVTO", Float) = 0
		[Toggle] _CustomVTO ("CustomVTO", Float) = 0
		[ASEEnd] _VTOScale ("VTOScale", Vector) = (1,1,1,1)
		[Enum(Off,0, On, 1)] _ZWrite ("ZWrite", Float) = 0
		[Toggle(_CULLDISTANCE_ON)] _CullDistance ("CullDistance", Float) = 0
		[Toggle] _Center3 ("Center3", Float) = 0
		_CullDistanceRange ("CullDistanceRange", Range(0, 20)) = 1
		_CullSoft ("CullSoft", Range(0, 2)) = 1
		_ElevationOffset ("ElevationOffset", Float) = 0
		_ElevationSoft ("ElevationOffset", Range(0, 1)) = 0.2
		[Toggle] _ElevationOn ("ElevationOn", Float) = 0
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
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

			Texture2D<float4> _MainTex;
			SamplerState sampler_MainTex;

			struct Fragment_Stage_Input
			{
				float2 uv : TEXCOORD0;
			};

			float4 frag(Fragment_Stage_Input input) : SV_TARGET
			{
				return _MainTex.Sample(sampler_MainTex, float2(input.uv.x, input.uv.y));
			}

			ENDHLSL
		}
	}
	Fallback "Hidden/InternalErrorShader"
	//CustomEditor "SampleGUIURP"
}
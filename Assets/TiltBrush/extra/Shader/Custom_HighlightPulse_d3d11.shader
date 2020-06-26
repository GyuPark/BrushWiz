//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Custom/HighlightPulse" {
Properties {
_MainTex ("Base (RGB)", 2D) = "white" { }
_Color ("Color", Color) = (1,1,1,1)
_PulseColor ("PulseColor", Color) = (1,1,1,1)
_PulseSpeed ("PulseSpeed", Float) = 1
}
SubShader {
 LOD 100
 Tags { "RenderType" = "Opaque" }
 Pass {
  LOD 100
  Tags { "RenderType" = "Opaque" }
  GpuProgramID 42040
Program "vp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
}
Program "fp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
}
}
}
Fallback "Diffuse"
}
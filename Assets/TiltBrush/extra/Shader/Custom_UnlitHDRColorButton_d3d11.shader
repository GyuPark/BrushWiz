//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Custom/UnlitHDRColorButton" {
Properties {
_Color ("Color", Color) = (0,0,0,0)
_SecondaryColor ("Fade Color", Color) = (0,0,0,0)
_EdgeFalloff ("Edge Falloff", Float) = 2
_EdgeWidth ("Edge Width", Float) = 1.5
}
SubShader {
 LOD 100
 Tags { "RenderType" = "Opaque" }
 Pass {
  LOD 100
  Tags { "RenderType" = "Opaque" }
  GpuProgramID 40288
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
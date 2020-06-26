//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Custom/SharingState" {
Properties {
_Color ("Color", Color) = (0,0,0,1)
_LineColor ("Line Color", Color) = (78,217,255,255)
_MainTex ("Base (RGB) TransGloss (A)", 2D) = "white" { }
_BGTex ("BGTex", 2D) = "white" { }
_Ratio ("Animation Ratio", Range(0, 1)) = 0
}
SubShader {
 LOD 100
 Tags { "RenderType" = "Opaque" }
 Pass {
  LOD 100
  Tags { "RenderType" = "Opaque" }
  GpuProgramID 44709
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
}
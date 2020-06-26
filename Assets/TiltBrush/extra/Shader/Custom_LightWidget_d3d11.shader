//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Custom/LightWidget" {
Properties {
_TrueColor ("Color", Color) = (0,0,0,0)
_Color ("Outline Color", Color) = (0,0,0,0)
_ClampedColor ("Clamped Color", Color) = (1,1,1,1)
_OutlineWidth ("White Outline Width", Float) = 0.02
_SecondOutlineWidth ("Black Outline Width", Float) = 0.03
_FlattenAmount ("Flatten Amount", Range(0, 1)) = 0
}
SubShader {
 Tags { "RenderType" = "Opaque" }
 Pass {
  Tags { "RenderType" = "Opaque" }
  GpuProgramID 53841
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
 Pass {
  Tags { "RenderType" = "Opaque" }
  Cull Front
  GpuProgramID 109523
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
 Pass {
  Tags { "RenderType" = "Opaque" }
  Cull Front
  GpuProgramID 170667
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
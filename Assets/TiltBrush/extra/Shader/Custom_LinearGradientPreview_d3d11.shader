//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Custom/LinearGradientPreview" {
Properties {
_Color ("Color", Color) = (1,1,1,1)
_ColorA ("ColorA", Color) = (0,0,0,1)
_ColorB ("ColorB", Color) = (1,1,1,1)
_GradientDirection ("Gradient", Vector) = (0,0,1,1)
_OutlineWidth ("Outline Width", Range(0.001, 1)) = 0.02
_SecondOutlineWidth ("Outline Width", Range(0.001, 1)) = 0.02
_EquatorWidth ("Equator Width", Range(0.001, 1)) = 0.008
}
SubShader {
 Pass {
  Cull Front
  GpuProgramID 64130
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
  Cull Front
  GpuProgramID 86412
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
  Cull Front
  GpuProgramID 136692
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
//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Custom/TransformLine" {
Properties {
_Color ("Color", Color) = (0,1,1,1)
}
SubShader {
 Pass {
  Cull Front
  GpuProgramID 1952
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
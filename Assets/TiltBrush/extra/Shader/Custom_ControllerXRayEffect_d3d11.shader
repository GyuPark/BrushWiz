//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Custom/ControllerXRayEffect" {
Properties {
_Color ("Color", Color) = (1,1,1,1)
}
SubShader {
 Pass {
  ZTest Off
  ZWrite Off
  GpuProgramID 45971
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
Fallback "Unlit/Diffuse"
}
//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Hidden/VR/BlitTexArraySliceToDepth" {
Properties {
_MainTex ("Texture", any) = "" { }
}
SubShader {
 Pass {
  ZTest Always
  Cull Off
  GpuProgramID 33758
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
//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Hidden/VR/BlitTexArraySliceToDepth_MSAA" {
Properties {
_MainTex ("Texture", any) = "" { }
}
SubShader {
 Pass {
  ZTest Always
  Cull Off
  GpuProgramID 42003
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
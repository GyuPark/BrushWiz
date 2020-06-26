//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Unlit/FullScreenOverlay" {
Properties {
_Color ("Color", Color) = (1,1,1,1)
}
SubShader {
 Tags { "QUEUE" = "Overlay-1" "RenderType" = "Transparent" }
 Pass {
  Tags { "QUEUE" = "Overlay-1" "RenderType" = "Transparent" }
  ZTest Always
  ZWrite Off
  GpuProgramID 6929
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
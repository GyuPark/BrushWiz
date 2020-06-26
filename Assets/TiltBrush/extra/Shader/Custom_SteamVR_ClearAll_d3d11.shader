//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Custom/SteamVR_ClearAll" {
Properties {
_Color ("Color", Color) = (0,0,0,0)
_MainTex ("Base (RGB)", 2D) = "white" { }
}
SubShader {
 Tags { "QUEUE" = "Background" }
 Pass {
  Tags { "QUEUE" = "Background" }
  ZTest Always
  Cull Off
  GpuProgramID 43305
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
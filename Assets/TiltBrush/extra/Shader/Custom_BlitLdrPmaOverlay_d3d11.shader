//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Custom/BlitLdrPmaOverlay" {
Properties {
_MainTex ("", 2D) = "white" { }
_OverlayTex ("Overlay Texture", 2D) = "black" { }
_OverlayUvRange ("Overlay UV Range", Vector) = (0,0,1,1)
}
SubShader {
 Pass {
  ZTest Off
  ZWrite Off
  Cull Off
  GpuProgramID 14610
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
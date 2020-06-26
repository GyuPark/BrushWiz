//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Custom/TransformControllerOverlay" {
Properties {
_Color ("Color", Color) = (0,1,1,1)
_BlackOutlineInflation ("Black Outline Inflation", Range(0, 1)) = 0
_ColoredOutlineInflation ("Colored Outline Inflation", Range(0, 1)) = 0
_BaseInflation ("Base Inflation", Float) = 0.01
}
SubShader {
 Tags { "QUEUE" = "AlphaTest+20" }
 Pass {
  Tags { "QUEUE" = "AlphaTest+20" }
  Cull Front
  GpuProgramID 3605
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
  Tags { "QUEUE" = "AlphaTest+20" }
  Cull Front
  GpuProgramID 112221
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
//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Unlit/GroundPlaneOverlay" {
Properties {
_Color ("Color", Color) = (1,1,1,1)
_ChaperoneScaleX ("Chaperone Scale X", Float) = 1
_ChaperoneScaleZ ("Chaperone Scale Z", Float) = 1
}
SubShader {
 LOD 201
 Tags { "QUEUE" = "Overlay" "RenderType" = "Transparent" }
 Pass {
  LOD 201
  Tags { "QUEUE" = "Overlay" "RenderType" = "Transparent" }
  ZTest Always
  ZWrite Off
  GpuProgramID 59163
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
SubShader {
 LOD 100
 Tags { "QUEUE" = "Overlay" "RenderType" = "Transparent" }
 Pass {
  LOD 100
  Tags { "QUEUE" = "Overlay" "RenderType" = "Transparent" }
  ZTest Always
  ZWrite Off
  GpuProgramID 121938
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